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
    public partial class ListaGruposProdutos : BaseForm
    {
        GrupoProdutoBO bo;

        public ListaGruposProdutos(MenuForm menu) : base(menu)
        {
            InitializeComponent();
            bo = new GrupoProdutoBO();

        }

        private void ListaGruposProdutos_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            var produtos = bo.Listar();
            dgvGruposProd.DataSource = produtos;
        }

        private void menuNovo_Click(object sender, EventArgs e)
        {
            var form = new CadastroGruposProdutos(this);
            form.Show();
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dgvGruposProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var id = Convert.ToInt32(dgvGruposProd.Rows[e.RowIndex].Cells["Id"].Value.ToString());

                try
                {
                    var grupo = bo.Encontrar(id);

                    if(grupo == null)
                    {
                        MessageBox.Show("Grupo não encontrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var form = new CadastroGruposProdutos(this, grupo);
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
