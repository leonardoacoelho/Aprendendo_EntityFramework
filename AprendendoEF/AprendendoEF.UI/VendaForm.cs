using AprendendoEF.BLL;
using AprendendoEF.UI.Base;
using AprendendoEF.UI.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AprendendoEF.UI
{
    public partial class VendaForm : BaseForm
    {
        VendaBO bo;

        Venda _venda;

        ListaVendasForm _lista;

        public VendaForm(ListaVendasForm listaForm) : base(listaForm)
        {
            InitializeComponent();

            bo = new VendaBO();
            _venda = new Venda
            {
                Itens = new List<ItemVenda>()
            };
            _lista = listaForm;
        }

        public VendaForm(ListaVendasForm listaForm, Venda venda) : this(listaForm)
        {
            _venda = venda;
        }

        private void menuAddItem_Click(object sender, EventArgs e)
        {
            var form = new ItensVendaForm(this, _venda);
            form.Show();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void VendaForm_Load(object sender, EventArgs e)
        {
            var clienteBO = new ClienteBO();
            var clientes = clienteBO.Listar().OrderBy(x => x.Nome).ThenBy(x => x.Sobrenome).ToList();

            cbxCliente.DataSource = clientes;

            dtpData.Value = DateTime.Today;

            AtualizarGrid();

            if (_venda.Id > 0)
            {
                txtId.Text = _venda.Id.ToString();
                cbxCliente.SelectedIndex = clientes.IndexOf(clientes.FirstOrDefault(x => x.Id == _venda.Cliente_Id));
                dtpData.Value = _venda.Data;
                txtValor.Text = _venda.Valor.ToString("C");
            }
        }

        private void AjustarItens()
        {
            foreach (var item in _venda.Itens)
            {
                item.Item = _venda.Itens.IndexOf(item) + 1;
            }
        }

        public void AtualizarGrid()
        {
            AjustarItens();

            //Atualizar o grid
            var bs = new BindingSource
            {
                DataSource = _venda.Itens
            };

            dgvItens.DataSource = bs;

            //Atualizar o valor  total
            txtValor.Text = GetValor().ToString("C");
        }

        private void dgvItens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var rowIndex = dgvItens.CurrentCell?.OwningRow.Index;

                if (rowIndex != null)
                {
                    _venda.Itens.RemoveAt((int)rowIndex);
                    AtualizarGrid();
                }
            }
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var item = Convert.ToInt32(dgvItens.Rows[e.RowIndex].Cells["Item"].Value.ToString());

                try
                {
                    var itemVenda = _venda.Itens.FirstOrDefault(x => x.Item == item);

                    if (itemVenda == null)
                    {
                        MessageBox.Show("Item não encontrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var form = new ItensVendaForm(this, _venda, itemVenda);
                        form.Show();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void menuFinaliza_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = (Cliente)cbxCliente.SelectedItem;

                _venda.Id = ObterId();
                _venda.Cliente = cliente;
                _venda.Cliente_Id = cliente.Id;
                _venda.Data = dtpData.Value;
                _venda.Valor = GetValor();

                bo.Salvar(_venda);

                MessageBox.Show("Salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var form = new EspelhoVendaForm(_venda.Id); 

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    LimparCampos();
                    AtualizarGrid();
                    _lista.AtualizarGrid();
                }
                else
                {
                    Hide();
                    _lista.AtualizarGrid();
                }

                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double GetValor()
        {
            return _venda.Itens.Sum(x => x.ValorTotal);
        }

        private void LimparCampos()
        {
            txtId.Text = "";
            cbxCliente.SelectedIndex = -1;
            txtValor.Text = "R$0,00";
            _venda = new Venda
            {
                Itens = new List<ItemVenda>()
            };
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

                if (id > 0)
                {
                    var result = MessageBox.Show($"Você tem certeza que deseja remover a venda?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
    }
}
