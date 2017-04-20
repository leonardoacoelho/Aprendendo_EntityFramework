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
    public partial class ListaUsuariosForm : BaseForm
    {
        UsuarioBO bo;

        public ListaUsuariosForm(MenuForm menu) : base(menu)
        {
            InitializeComponent();

            bo = new UsuarioBO();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void menuNovo_Click(object sender, EventArgs e)
        {
            var form = new CadastroUsuariosForm(this);
            form.Show();
        }

        public void ListaUsuariosForm_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            var usuarios = bo.Listar();
            dgvUsuarios.DataSource = usuarios;
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["Id"].Value.ToString());

                try
                {
                    var usuario = bo.Encontrar(id);

                    if (usuario == null)
                    {
                        MessageBox.Show("Nenhum usuario foi encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var form = new CadastroUsuariosForm(this);

                        form.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
