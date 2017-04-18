using AprendendoEF.BLL;
using AprendendoEF.UI.Base;
using AprendendoEF.UI.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprendendoEF.UI
{
    public partial class ListaVendasForm : BaseForm
    {
        VendaBO bo;

        public ListaVendasForm(MenuForm menu) : base(menu)
        {
            InitializeComponent();
            bo = new VendaBO();
        }

        private void menuNova_Click(object sender, EventArgs e)
        {
            var form = new VendaForm(this);
            form.Show();
        }

        private void ListaVendasForm_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            var vendas = bo.Listar();
            dgvVendas.DataSource = vendas;
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dgvVendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = Convert.ToInt32(dgvVendas.Rows[e.RowIndex].Cells["Id"].Value.ToString());

                try
                {
                    var venda = bo.Encontrar(id);

                    if (venda == null)
                        MessageBox.Show("Venda não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        var form = new VendaForm(this, venda);
                        form.Show();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void menuRelatorio_Click(object sender, EventArgs e)
        {
            var form = new RelatorioVendasForm();
            form.Show();
        }
    }
}
