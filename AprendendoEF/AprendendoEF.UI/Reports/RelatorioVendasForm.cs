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
    public partial class RelatorioVendasForm : Form
    {
        public RelatorioVendasForm()
        {
            InitializeComponent();
        }

        private void RelatorioVendasForm_Load(object sender, EventArgs e)
        {
            var vendaBO = new VendaBO();
            var vendas = vendaBO.Listar();

            var relatorio = new List<RelatorioVendas>();

            foreach (var venda in vendas)
            {
                var itemRelatorio = new RelatorioVendas
                {
                    Id = venda.Id,
                    Cliente_Nome = venda.Cliente.ToString(),
                    Data = venda.Data,
                    Valor = venda.Valor
                };

                relatorio.Add(itemRelatorio);
            }

            RelatorioVendasBindingSource.DataSource = relatorio;

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            this.reportViewer1.RefreshReport();
        }
    }
}
