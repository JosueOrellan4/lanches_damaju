namespace lanches_damaju
{
    partial class Gerenciamento_Clientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.buttonPesquisarClientesClick = new System.Windows.Forms.Button();
            this.buttonRemoverClientesClick = new System.Windows.Forms.Button();
            this.buttonFecharClick = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(48, 84);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(467, 310);
            this.dgvClientes.TabIndex = 16;
            // 
            // buttonPesquisarClientesClick
            // 
            this.buttonPesquisarClientesClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonPesquisarClientesClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisarClientesClick.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonPesquisarClientesClick.Location = new System.Drawing.Point(590, 84);
            this.buttonPesquisarClientesClick.Name = "buttonPesquisarClientesClick";
            this.buttonPesquisarClientesClick.Size = new System.Drawing.Size(148, 37);
            this.buttonPesquisarClientesClick.TabIndex = 17;
            this.buttonPesquisarClientesClick.Text = "Pesquisar";
            this.buttonPesquisarClientesClick.UseVisualStyleBackColor = false;
            this.buttonPesquisarClientesClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRemoverClientesClick
            // 
            this.buttonRemoverClientesClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonRemoverClientesClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoverClientesClick.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonRemoverClientesClick.Location = new System.Drawing.Point(590, 156);
            this.buttonRemoverClientesClick.Name = "buttonRemoverClientesClick";
            this.buttonRemoverClientesClick.Size = new System.Drawing.Size(148, 37);
            this.buttonRemoverClientesClick.TabIndex = 18;
            this.buttonRemoverClientesClick.Text = "Remover";
            this.buttonRemoverClientesClick.UseVisualStyleBackColor = false;
            this.buttonRemoverClientesClick.Click += new System.EventHandler(this.buttonRemoverClientesClick_Click);
            // 
            // buttonFecharClick
            // 
            this.buttonFecharClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonFecharClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFecharClick.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonFecharClick.Location = new System.Drawing.Point(590, 357);
            this.buttonFecharClick.Name = "buttonFecharClick";
            this.buttonFecharClick.Size = new System.Drawing.Size(148, 37);
            this.buttonFecharClick.TabIndex = 19;
            this.buttonFecharClick.Text = "Fechar";
            this.buttonFecharClick.UseVisualStyleBackColor = false;
            this.buttonFecharClick.Click += new System.EventHandler(this.buttonFecharClick_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(117, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 44);
            this.label5.TabIndex = 29;
            this.label5.Text = "Gerenciamento de Clientes";
            // 
            // Gerenciamento_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonFecharClick);
            this.Controls.Add(this.buttonRemoverClientesClick);
            this.Controls.Add(this.buttonPesquisarClientesClick);
            this.Controls.Add(this.dgvClientes);
            this.Name = "Gerenciamento_Clientes";
            this.Text = "Gerenciamento_Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button buttonPesquisarClientesClick;
        private System.Windows.Forms.Button buttonRemoverClientesClick;
        private System.Windows.Forms.Button buttonFecharClick;
        private System.Windows.Forms.Label label5;
    }
}