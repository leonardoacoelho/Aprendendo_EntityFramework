namespace AprendendoEF.UI
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.menuSair,
            this.menuVenda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuProdutos,
            this.gruposDeProdutosToolStripMenuItem});
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clientesToolStripMenuItem.Image = global::AprendendoEF.UI.Properties.Resources.cadastro;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(103, 23);
            this.clientesToolStripMenuItem.Text = "&Cadastros";
            // 
            // menuClientes
            // 
            this.menuClientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuClientes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(212, 24);
            this.menuClientes.Text = "&Clientes";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuProdutos
            // 
            this.menuProdutos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(212, 24);
            this.menuProdutos.Text = "&Produtos";
            this.menuProdutos.Click += new System.EventHandler(this.menuProdutos_Click);
            // 
            // gruposDeProdutosToolStripMenuItem
            // 
            this.gruposDeProdutosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gruposDeProdutosToolStripMenuItem.Name = "gruposDeProdutosToolStripMenuItem";
            this.gruposDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.gruposDeProdutosToolStripMenuItem.Text = "&Grupos de Produtos";
            this.gruposDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.gruposDeProdutosToolStripMenuItem_Click);
            // 
            // menuSair
            // 
            this.menuSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuSair.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuSair.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.menuSair.Name = "menuSair";
            this.menuSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.menuSair.Size = new System.Drawing.Size(47, 23);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // menuVenda
            // 
            this.menuVenda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuVenda.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.menuVenda.Image = global::AprendendoEF.UI.Properties.Resources.venda;
            this.menuVenda.Name = "menuVenda";
            this.menuVenda.Size = new System.Drawing.Size(78, 23);
            this.menuVenda.Text = "&Venda";
            this.menuVenda.Click += new System.EventHandler(this.menuVenda_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 402);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuProdutos;
        private System.Windows.Forms.ToolStripMenuItem gruposDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuVenda;
    }
}