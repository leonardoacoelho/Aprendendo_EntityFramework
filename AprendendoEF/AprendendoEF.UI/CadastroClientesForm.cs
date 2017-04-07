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
    public partial class CadastroClientesForm : BaseForm
    {
        Cliente _cliente;

        ListaClientesForm _lista;

        ClienteBO bo;

        public CadastroClientesForm(ListaClientesForm lista) : base(lista)
        {
            InitializeComponent();
            bo = new ClienteBO();
            _lista = lista;
        }

        public CadastroClientesForm(ListaClientesForm lista, Cliente cliente) : this(lista)
        {
            _cliente = cliente;

        }

        public int ObterId()
        {
            return !string.IsNullOrEmpty(txtId.Text) ? Convert.ToInt32(txtId.Text) : 0;
        }

        public void LimparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtSobrenome.Text = "";
        }

        private void CadastroClientesForm_Load(object sender, EventArgs e)
        {
            if (_cliente != null)
            {
                txtId.Text = _cliente.Id.ToString();
                txtNome.Text = _cliente.Nome;
                txtEmail.Text = _cliente.Email;
                txtSobrenome.Text = _cliente.Sobrenome;

                menuRemover.Visible = true;
            }
            else
                menuRemover.Visible = false;
        }

        private void menuGravar_Click(object sender, EventArgs e)
        {
            try
            {
                _cliente = new Cliente
                {
                    Id = ObterId(),
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    Sobrenome = txtSobrenome.Text
                };

                bo.Salvar(_cliente);

                MessageBox.Show("Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    LimparCampos();
                    txtNome.Focus();
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
                MessageBox.Show("Os campos em negrito sao obrigatórios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuRemover_Click(object sender, EventArgs e)
        {
            try
            {
                var id = ObterId();

                if (id > 0)
                {
                    var result = MessageBox.Show($"Você tem certeza que deseja remover {_cliente.Nome}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private void menuCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
