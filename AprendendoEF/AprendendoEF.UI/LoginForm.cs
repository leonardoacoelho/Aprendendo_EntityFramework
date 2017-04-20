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
    public partial class LoginForm : Form
    {
        LoginBO bo;

        Usuario _usuario;

        public LoginForm()
        {
            InitializeComponent();

            bo = new LoginBO();
        }
        public LoginForm(Usuario usuario) : this()
        {
            _usuario = usuario;
        }

        private void menuEntrar_Click(object sender, EventArgs e)
        {
            var form = new MenuForm();

            _usuario = new Usuario
            {
                Login = txtLogin.Text,
                Senha = txtSenha.Text
            };

            var logado = bo.Logar(_usuario);

            if (logado)
            {
                form.Show();
                Hide();
            }
            else
                MessageBox.Show("Usuario ou senha incorretos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void menuCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
