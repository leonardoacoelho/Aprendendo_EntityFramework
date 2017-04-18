using AprendendoEF.BLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            this.reportViewer1.RefreshReport();
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
    }
}
