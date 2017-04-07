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
    public partial class ListaProdutosForm : BaseForm
    {
        ProdutoBO bo;
        
        public ListaProdutosForm(MenuForm menu) : base(menu)
        {
            InitializeComponent();

            bo = new ProdutoBO();
        }

        private void menuNovo_Click(object sender, EventArgs e)
        {
            var form = new CadastroProdutoForm(this);

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
                        MessageBox.Show("Produto não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var form = new CadastroProdutoForm(this, produto);
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
