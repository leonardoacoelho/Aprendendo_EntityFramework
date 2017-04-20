using AprendendoEF.BLL;
using AprendendoEF.Exceptions;
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
    public partial class CadastroUsuariosForm : BaseForm
    {
        Usuario _usuario;

        ListaUsuariosForm _lista;

        UsuarioBO bo;

        public CadastroUsuariosForm(ListaUsuariosForm lista) : base(lista)
        {
            InitializeComponent();

            bo = new UsuarioBO();
            _lista = lista;
        }

        public CadastroUsuariosForm(ListaUsuariosForm lista, Usuario usuario) : this(lista)
        {
            _usuario = usuario;
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void menuGravar_Click(object sender, EventArgs e)
        {
            try
            {
                _usuario = new Usuario
                {
                    Id = ObterId(),
                    Login = txtUsuario.Text,
                    Senha = txtSenha.Text, 
                    ConfirmaSenha = txtConfirma.Text
                };

                bo.Salvar(_usuario);

                MessageBox.Show("Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    LimparCampos();
                    txtUsuario.Focus();
                    _lista.AtualizarGrid();
                }
                else
                {
                    Hide();
                    _lista.AtualizarGrid();
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Os campos em negrito devem ser preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ValoresNaoCoincidemException)
            {
                MessageBox.Show("Os campos senha e confirmação de senha devem ser iguais!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (CadastroJaExistenteException)
            {
                MessageBox.Show($"O usuario {_usuario.Login} já esxiste!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ObterId()
        {
            return !string.IsNullOrEmpty(txtId.Text) ? Convert.ToInt32(txtId.Text) : 0;
        }

        public void LimparCampos()
        {
            txtId.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtConfirma.Text = "";
        }

        private void menuRemover_Click(object sender, EventArgs e)
        {
            try
            {
                var id = ObterId();

                if (id > 0)
                {
                    var result = MessageBox.Show($"Você tem certeza que deseja remover {_usuario.Login}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        bo.Remover(id);

                        MessageBox.Show("Removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampos();
                        _lista.AtualizarGrid();
                        Hide();
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CadastroUsuariosForm_Load(object sender, EventArgs e)
        {
            if (_usuario == null)
                txtUsuario.Enabled = true;
            else
            {
                txtId.Text = _usuario.Id.ToString();
                txtUsuario.Text = _usuario.Login;
                txtConfirma.Text = _usuario.ConfirmaSenha;

                txtUsuario.Enabled = false;
            }
        }
    }
}