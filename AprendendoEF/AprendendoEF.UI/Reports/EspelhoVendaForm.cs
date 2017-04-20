using AprendendoEF.BLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprendendoEF.UI.Reports
{
    public partial class EspelhoVendaForm : Form
    {
        int _vendaId;

        public EspelhoVendaForm(int vendaId)
        {
            InitializeComponent();

            _vendaId = vendaId;
        }

        private void EspelhoVendaForm_Load(object sender, EventArgs e)
        {
            try
            {
                var vendaBO = new VendaBO();
                var venda = vendaBO.Encontrar(_vendaId);

                var relatorio = new List<EspelhoVendaReport>();

                var itemRelatorio = new EspelhoVendaReport
                {
                    Id = venda.Id,
                    Cliente_Nome = venda.Cliente.ToString(),
                    Data = venda.Data,
                    Valor = venda.Valor
                };

                relatorio.Add(itemRelatorio);

                EspelhoVendaReportBindingSource.DataSource = relatorio;

                reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

                ExportarVenda(venda);

                this.reportViewer1.RefreshReport();

                EnviarEmail(venda);

            }
            catch(FormatException)
            {
                MessageBox.Show("E-mail inválido", "Formato do E-mail desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ExportarVenda(Venda venda)
        {
            var bo = new RelatorioBO();
            bo.Exportar("Venda", $"Venda {venda.Id}", reportViewer1.LocalReport);
        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            var vendaId = Convert.ToInt32(e.Parameters[0].Values[0]);

            var vendaBO = new VendaBO();
            var venda = vendaBO.Encontrar(vendaId);

            var relatorio = new List<EspelhoVenda_ItemReport>();

            foreach (var item in venda.Itens)
            {
                var itemRelatorio = new EspelhoVenda_ItemReport
                {
                    Item = item.Item,
                    Produto_Nome = item.Produto.ToString(),
                    Quantidade = item.Quantidade,
                    ValorUnitario = item.ValorUnitario,
                    ValorTotal = item.ValorTotal
                };

                relatorio.Add(itemRelatorio);
            }

            var ds = new ReportDataSource("DsItens", relatorio);

            e.DataSources.Add(ds);
        }

        private void EnviarEmail(Venda venda)
        {
            var sb = new StringBuilder();
            sb.Append($"Você esta recebendo agora a venda {venda.Id}.");
            sb.Append($"\n");
            sb.Append("Caso essa venda não seja sua desconsidere este e-mail.");
            var body = sb.ToString();

            var caminho = @"C:\Relatorios\Venda\";
            var anexo = new Attachment($"{caminho}Venda {venda.Id}.pdf");
            var anexos = new List<Attachment> { anexo };

            var emailBo = new EmailBO();
            emailBo.Enviar(venda.Cliente.Email, $"Venda número {venda.Id}", body, anexos);
        }
    }
}
