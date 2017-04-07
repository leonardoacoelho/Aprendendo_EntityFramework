using AprendendoEF.BLL;
using AprendendoEF.UI.Base;
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
    public partial class ListaClientesForm : BaseForm
    {
        ClienteBO bo;

        public ListaClientesForm(MenuForm menu) : base(menu)
        {
            InitializeComponent();
            bo = new ClienteBO();
        }

        public void ListaClientesForm_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            var clientes = bo.Listar();
            dgvClientes.DataSource = clientes;
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["Column1"].Value.ToString());

                try
                {
                    var cliente = bo.Encontrar(id);

                    if (cliente == null)
                    {
                        MessageBox.Show("Nenhum cliente foi encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var form = new CadastroClientesForm(this, cliente);

                        form.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void menuNovo_Click(object sender, EventArgs e)
        {
            var form = new CadastroClientesForm(this);

            form.Show();
        }
    }
}
