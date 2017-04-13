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
    public partial class ItensVendaForm : BaseForm
    {
        VendaForm _vendaForm;

        Venda _venda;

        ItemVenda _item;

        public ItensVendaForm(VendaForm vendaForm, Venda venda) : base(vendaForm)
        {
            InitializeComponent();
            _vendaForm = vendaForm;
            _venda = venda;
        }

        public ItensVendaForm(VendaForm vendaForm, Venda venda, ItemVenda item) : this(vendaForm, venda)
        {
            _item = item;
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void menuCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ItensVendaForm_Load(object sender, EventArgs e)
        {
            //preencher produtos
            var produtoBo = new ProdutoBO();
            var produtos = produtoBo.Listar().OrderBy(x => x.Descricao).ToList();

            cbxProduto.DataSource = produtos;

            if (_item != null)
            {
                txtId.Text = _item.Id.ToString();
                txtItem.Text = _item.Item.ToString();
                cbxProduto.SelectedIndex = produtos.IndexOf(produtos.FirstOrDefault(x => x.Id == _item.Produto_Id));
                txtQuantidade.Text = _item.Quantidade.ToString();
                CalcularValorTotal();
            }
            else
                txtItem.Text = (_venda.Itens.Count + 1).ToString();
        }

        private void txtQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularValorTotal();
        }

        private void CalcularValorTotal()
        {
            double quant = 0;
            double valUnit = 0;

            double.TryParse(txtQuantidade.Text, out quant);
            double.TryParse(txtValUnit.Text, out valUnit);

            var total = quant * valUnit;

            txtValTotal.Text = total.ToString("N");
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                double quant = 0;
                double valUnit = 0;

                int.TryParse(txtId.Text, out id);
                double.TryParse(txtQuantidade.Text, out quant);
                double.TryParse(txtValUnit.Text, out valUnit);

                var selectedProduto = (Produto)cbxProduto.SelectedItem;

                _item = new ItemVenda
                {
                    Id = id,
                    Item = Convert.ToInt32(txtItem.Text),
                    Produto = selectedProduto,
                    Produto_Id = selectedProduto.Id,
                    Quantidade = quant,
                    ValorUnitario = valUnit,
                    ValorTotal = quant * valUnit
                };

                var itemVendaBO = new ItemVendaBO();
                itemVendaBO.Validar(_item);

                //verificar se o item ja existe
                var itemJaExiste = _venda.Itens.FirstOrDefault(x => x.Item == _item.Item);

                if (itemJaExiste != null)
                    _venda.Itens.Remove(itemJaExiste);

                //adicionar o item
                _venda.Itens.Add(_item);
                _vendaForm.AtualizarGrid();
                Hide();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Os campos em negrito são obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValUnit.Text = ((Produto)cbxProduto.SelectedItem).Valor.ToString("N");
            CalcularValorTotal();
        }
    }
}