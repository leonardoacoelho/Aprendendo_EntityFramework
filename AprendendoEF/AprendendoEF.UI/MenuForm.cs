﻿using System;
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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            var form = new ListaClientesForm(this)
            {
                MdiParent = this,
            };
            form.Show();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuProdutos_Click(object sender, EventArgs e)
        {
            var form = new ListaProdutosForm(this)
            {
                MdiParent = this,
            };
            form.Show();
        }
    }
}
