using AprendendoEF.BLL;
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
    public partial class ListaProdutosForm : Form
    {
        ProdutoBO bo;

        MenuForm _menu;

        public ListaProdutosForm()
        {
            InitializeComponent();

            bo = new ProdutoBO();
        }

        public ListaProdutosForm(MenuForm menu) : this()
        {
            _menu = menu;
        }

        private void menuNovo_Click(object sender, EventArgs e)
        {
            var form = new CadastroProdutoForm(this)
            {
                MdiParent = _menu
            };

            form.Show();
        }

        private void ListaProdutosForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            var produtos = bo.Listar();
            dgvProdutos.DataSource = produtos;
        }

        private void menuCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var id = Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells["Id"].Value.ToString());

                try
                {
                    var produto = bo.Encontrar(id);

                    if(produto == null)
                    {
                        MessageBox.Show("Cliente não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var form = new CadastroProdutoForm(this, produto)
                        {
                            MdiParent = _menu
                        };
                        
                        form.Show();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
