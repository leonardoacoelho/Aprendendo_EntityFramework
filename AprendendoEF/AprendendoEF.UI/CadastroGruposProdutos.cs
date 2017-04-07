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
    public partial class CadastroGruposProdutos : BaseForm
    {
        GrupoProdutoBO bo;

        ListaGruposProdutos _lista;

        GrupoProduto _grupo;

        public CadastroGruposProdutos(ListaGruposProdutos lista) : base(lista)
        {
            InitializeComponent();
            bo = new GrupoProdutoBO();
            _lista = lista;
        }

        public CadastroGruposProdutos(ListaGruposProdutos lista, GrupoProduto grupo) : this(lista)
        {
            _grupo = grupo;
        }

        private void CadastroGruposProdutos_Load(object sender, EventArgs e)
        {
            if (_grupo != null)
            {
                txtId.Text = _grupo.Id.ToString();
                txtNome.Text = _grupo.Nome;

                menuRemover.Visible = true;
            }
            else
                menuRemover.Visible = false;
        }

        private void menuCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void menuGravar_Click(object sender, EventArgs e)
        {
            try
            {
                _grupo = new GrupoProduto
                {
                    Id = ObterId(),
                    Nome = txtNome.Text
                };

                bo.Salvar(_grupo);

                MessageBox.Show("Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    LimparCampos();
                    txtNome.Focus();
                    _lista.AtualizarGrid();
                }
                else
                {
                    _lista.AtualizarGrid();
                    Hide();
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("O campo nome é obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LimparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
        }

        private int ObterId()
        {
            return !string.IsNullOrEmpty(txtId.Text) ? Convert.ToInt32(txtId.Text) : 0;
        }

        private void menuRemover_Click(object sender, EventArgs e)
        {
            try
            {
                var id = ObterId();

                if(id > 0)
                {
                    var result = MessageBox.Show($"Você tem certeza que deseja remover {txtNome.Text}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(result == DialogResult.Yes)
                    {
                        bo.Remover(id);

                        MessageBox.Show("Removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
