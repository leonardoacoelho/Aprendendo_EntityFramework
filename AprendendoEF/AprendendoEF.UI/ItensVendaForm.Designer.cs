namespace AprendendoEF.UI
{
    partial class ItensVendaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValUnit = new System.Windows.Forms.TextBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.txtValTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Unitário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Total:";
            // 
            // txtValUnit
            // 
            this.txtValUnit.Enabled = false;
            this.txtValUnit.Location = new System.Drawing.Point(143, 57);
            this.txtValUnit.Name = "txtValUnit";
            this.txtValUnit.Size = new System.Drawing.Size(134, 20);
            this.txtValUnit.TabIndex = 2;
            this.txtValUnit.Text = "0,00";
            this.txtValUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxProduto
            // 
            this.cbxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(143, 30);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(134, 21);
            this.cbxProduto.TabIndex = 0;
            this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.cbxProduto_SelectedIndexChanged);
            // 
            // txtValTotal
            // 
            this.txtValTotal.Enabled = false;
            this.txtValTotal.Location = new System.Drawing.Point(423, 57);
            this.txtValTotal.Name = "txtValTotal";
            this.txtValTotal.Size = new System.Drawing.Size(134, 20);
            this.txtValTotal.TabIndex = 3;
            this.txtValTotal.Text = "0,00";
            this.txtValTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(423, 30);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(134, 20);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuCancelar,
            this.menuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 109);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAdd
            // 
            this.menuAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.menuAdd.Image = global::AprendendoEF.UI.Properties.Resources.check;
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(101, 20);
            this.menuAdd.Text = "ADICIONAR";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuCancelar
            // 
            this.menuCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuCancelar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.menuCancelar.Image = global::AprendendoEF.UI.Properties.Resources.stop;
            this.menuCancelar.Name = "menuCancelar";
            this.menuCancelar.Size = new System.Drawing.Size(94, 20);
            this.menuCancelar.Text = "CANCELAR";
            this.menuCancelar.Click += new System.EventHandler(this.menuCancelar_Click);
            // 
            // menuSair
            // 
            this.menuSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuSair.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(46, 20);
            this.menuSair.Text = "SAIR";
            this.menuSair.Visible = false;
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtId, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtValUnit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbxProduto, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtValTotal, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtQuantidade, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtItem, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 82);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Item:";
            // 
            // txtItem
            // 
            this.txtItem.Enabled = false;
            this.txtItem.Location = new System.Drawing.Point(143, 3);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(134, 20);
            this.txtItem.TabIndex = 12;
            this.txtItem.Text = "0";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(423, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(134, 20);
            this.txtId.TabIndex = 13;
            this.txtId.Text = "0";
            // 
            // ItensVendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 133);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ItensVendaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itens da Venda";
            this.Load += new System.EventHandler(this.ItensVendaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValUnit;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.TextBox txtValTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuCancelar;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtId;
    }
}