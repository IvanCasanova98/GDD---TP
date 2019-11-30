namespace FrbaOfertas.ComprarOferta
{
    partial class ComprarOferta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprarOferta));
            this.dataGridCompraOfertas = new System.Windows.Forms.DataGridView();
            this.buscador = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompraOfertas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCompraOfertas
            // 
            this.dataGridCompraOfertas.AllowDrop = true;
            this.dataGridCompraOfertas.AllowUserToDeleteRows = false;
            this.dataGridCompraOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompraOfertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalle,
            this.Precio,
            this.Stock,
            this.Comprar});
            this.dataGridCompraOfertas.Location = new System.Drawing.Point(12, 135);
            this.dataGridCompraOfertas.Name = "dataGridCompraOfertas";
            this.dataGridCompraOfertas.ReadOnly = true;
            this.dataGridCompraOfertas.Size = new System.Drawing.Size(1352, 491);
            this.dataGridCompraOfertas.TabIndex = 0;
            // 
            // buscador
            // 
            this.buscador.AutoSize = true;
            this.buscador.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscador.Location = new System.Drawing.Point(12, 92);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(288, 26);
            this.buscador.TabIndex = 1;
            this.buscador.Text = "Buscar Por nombre de oferta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(418, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Su monto:";
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Comprar
            // 
            this.Comprar.HeaderText = "Comprar";
            this.Comprar.Name = "Comprar";
            this.Comprar.ReadOnly = true;
            // 
            // ComprarOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1376, 638);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buscador);
            this.Controls.Add(this.dataGridCompraOfertas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComprarOferta";
            this.Text = "Comprar Oferta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompraOfertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCompraOfertas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewButtonColumn Comprar;
        private System.Windows.Forms.Label buscador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}