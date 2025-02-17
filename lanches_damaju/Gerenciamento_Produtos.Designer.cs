namespace lanches_damaju
{
    partial class Gerenciamento_Produtos
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.buttonPesquisarClientesClick = new System.Windows.Forms.Button();
            this.buttonRemoverProdutosClick = new System.Windows.Forms.Button();
            this.buttonFecharClick = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(39, 88);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(467, 310);
            this.dgvProdutos.TabIndex = 17;
            // 
            // buttonPesquisarClientesClick
            // 
            this.buttonPesquisarClientesClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonPesquisarClientesClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisarClientesClick.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonPesquisarClientesClick.Location = new System.Drawing.Point(581, 88);
            this.buttonPesquisarClientesClick.Name = "buttonPesquisarClientesClick";
            this.buttonPesquisarClientesClick.Size = new System.Drawing.Size(148, 37);
            this.buttonPesquisarClientesClick.TabIndex = 18;
            this.buttonPesquisarClientesClick.Text = "Pesquisar";
            this.buttonPesquisarClientesClick.UseVisualStyleBackColor = false;
            this.buttonPesquisarClientesClick.Click += new System.EventHandler(this.buttonPesquisarClientesClick_Click);
            // 
            // buttonRemoverProdutosClick
            // 
            this.buttonRemoverProdutosClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonRemoverProdutosClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoverProdutosClick.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonRemoverProdutosClick.Location = new System.Drawing.Point(581, 151);
            this.buttonRemoverProdutosClick.Name = "buttonRemoverProdutosClick";
            this.buttonRemoverProdutosClick.Size = new System.Drawing.Size(148, 37);
            this.buttonRemoverProdutosClick.TabIndex = 19;
            this.buttonRemoverProdutosClick.Text = "Remover";
            this.buttonRemoverProdutosClick.UseVisualStyleBackColor = false;
            this.buttonRemoverProdutosClick.Click += new System.EventHandler(this.buttonRemoverProdutosClick_Click);
            // 
            // buttonFecharClick
            // 
            this.buttonFecharClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonFecharClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFecharClick.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonFecharClick.Location = new System.Drawing.Point(581, 361);
            this.buttonFecharClick.Name = "buttonFecharClick";
            this.buttonFecharClick.Size = new System.Drawing.Size(148, 37);
            this.buttonFecharClick.TabIndex = 20;
            this.buttonFecharClick.Text = "Fechar";
            this.buttonFecharClick.UseVisualStyleBackColor = false;
            this.buttonFecharClick.Click += new System.EventHandler(this.buttonFecharClick_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(99, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 44);
            this.label5.TabIndex = 30;
            this.label5.Text = "Gerenciamento de Produtos\r\n";
            // 
            // Gerenciamento_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonFecharClick);
            this.Controls.Add(this.buttonRemoverProdutosClick);
            this.Controls.Add(this.buttonPesquisarClientesClick);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "Gerenciamento_Produtos";
            this.Text = "Gerenciamento_Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button buttonPesquisarClientesClick;
        private System.Windows.Forms.Button buttonRemoverProdutosClick;
        private System.Windows.Forms.Button buttonFecharClick;
        private System.Windows.Forms.Label label5;
    }
}