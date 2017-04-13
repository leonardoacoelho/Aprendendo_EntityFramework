namespace AprendendoEF.UI
{
    partial class VendaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venda_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFinaliza = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemover = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Checked = false;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(422, 53);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(160, 20);
            this.dtpData.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(369, 249);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(213, 20);
            this.txtValor.TabIndex = 2;
            this.txtValor.Text = "R$0,00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor Total:";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Itens,
            this.Quantidade,
            this.ValorUnitario,
            this.ValorTotal,
            this.Venda_Id,
            this.Id,
            this.Venda,
            this.Produto_Id});
            this.dgvItens.Location = new System.Drawing.Point(25, 88);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            this.dgvItens.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(557, 142);
            this.dgvItens.TabIndex = 9;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            this.dgvItens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItens_KeyDown);
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Itens
            // 
            this.Itens.DataPropertyName = "Produto";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Itens.DefaultCellStyle = dataGridViewCellStyle1;
            this.Itens.HeaderText = "Produto";
            this.Itens.Name = "Itens";
            this.Itens.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.ValorUnitario.DefaultCellStyle = dataGridViewCellStyle3;
            this.ValorUnitario.HeaderText = "Valor Unitário";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.ValorTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // Venda_Id
            // 
            this.Venda_Id.DataPropertyName = "Venda_Id";
            this.Venda_Id.HeaderText = "Venda_Id";
            this.Venda_Id.Name = "Venda_Id";
            this.Venda_Id.ReadOnly = true;
            this.Venda_Id.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Venda
            // 
            this.Venda.DataPropertyName = "Venda";
            this.Venda.HeaderText = "Venda";
            this.Venda.Name = "Venda";
            this.Venda.ReadOnly = true;
            this.Venda.Visible = false;
            // 
            // Produto_Id
            // 
            this.Produto_Id.DataPropertyName = "Produto_Id";
            this.Produto_Id.HeaderText = "Produto_Id";
            this.Produto_Id.Name = "Produto_Id";
            this.Produto_Id.ReadOnly = true;
            this.Produto_Id.Visible = false;
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(91, 52);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(273, 21);
            this.cbxCliente.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(153, 14);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(134, 20);
            this.txtId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número da venda:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddItem,
            this.menuSair,
            this.menuFinaliza,
            this.menuRemover});
            this.menuStrip1.Location = new System.Drawing.Point(0, 280);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAddItem
            // 
            this.menuAddItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuAddItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.menuAddItem.Image = global::AprendendoEF.UI.Properties.Resources.add;
            this.menuAddItem.Name = "menuAddItem";
            this.menuAddItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuAddItem.Size = new System.Drawing.Size(92, 20);
            this.menuAddItem.Text = "ADD ITEM";
            this.menuAddItem.Click += new System.EventHandler(this.menuAddItem_Click);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            this.menuSair.Visible = false;
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // menuFinaliza
            // 
            this.menuFinaliza.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuFinaliza.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuFinaliza.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.menuFinaliza.Image = global::AprendendoEF.UI.Properties.Resources.check;
            this.menuFinaliza.Name = "menuFinaliza";
            this.menuFinaliza.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFinaliza.Size = new System.Drawing.Size(138, 20);
            this.menuFinaliza.Text = "FINALIZAR VENDA";
            this.menuFinaliza.Click += new System.EventHandler(this.menuFinaliza_Click);
            // 
            // menuRemover
            // 
            this.menuRemover.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuRemover.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuRemover.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.menuRemover.Image = global::AprendendoEF.UI.Properties.Resources.stop;
            this.menuRemover.Name = "menuRemover";
            this.menuRemover.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuRemover.Size = new System.Drawing.Size(134, 20);
            this.menuRemover.Text = "REMOVER VENDA";
            this.menuRemover.Click += new System.EventHandler(this.menuRemover_Click);
            // 
            // VendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 304);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VendaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.VendaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAddItem;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuFinaliza;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ToolStripMenuItem menuRemover;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venda_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto_Id;
    }
}