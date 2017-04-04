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
    public partial class ListaClientesForm : Form
    {
        ClienteBO bo;

        public ListaClientesForm()
        {
            InitializeComponent();

            bo = new ClienteBO();
        }

        private void ListaClientesForm_Load(object sender, EventArgs e)
        {
            var clientes = bo.Listar();
            dgvClientes.DataSource = clientes;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var form = new CadastroClientesForm();
            form.Show();
        }
    }
}
