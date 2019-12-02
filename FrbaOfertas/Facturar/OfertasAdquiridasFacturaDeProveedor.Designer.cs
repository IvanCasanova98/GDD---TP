namespace FrbaOfertas.Facturar
{
    partial class OfertasAdquiridasFacturaDeProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfertasAdquiridasFacturaDeProveedor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.cmd_facturar = new System.Windows.Forms.Button();
            this.Ofe_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ofe_Descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clie_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ofe_Precio_Ficticio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compra_Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ofe_ID,
            this.Ofe_Descrip,
            this.clie_nombre,
            this.Ofe_Precio_Ficticio,
            this.Compra_Cant,
            this.IdCompra});
            this.dataGridView1.Location = new System.Drawing.Point(6, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1374, 494);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_cancelar.Location = new System.Drawing.Point(6, 6);
            this.cmd_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(128, 34);
            this.cmd_cancelar.TabIndex = 28;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = false;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click);
            // 
            // cmd_facturar
            // 
            this.cmd_facturar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_facturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_facturar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_facturar.Location = new System.Drawing.Point(1252, 6);
            this.cmd_facturar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmd_facturar.Name = "cmd_facturar";
            this.cmd_facturar.Size = new System.Drawing.Size(128, 34);
            this.cmd_facturar.TabIndex = 29;
            this.cmd_facturar.Text = "Facturar";
            this.cmd_facturar.UseVisualStyleBackColor = false;
            this.cmd_facturar.Click += new System.EventHandler(this.cmd_facturar_Click);
            // 
            // Ofe_ID
            // 
            this.Ofe_ID.HeaderText = "Id";
            this.Ofe_ID.Name = "Ofe_ID";
            this.Ofe_ID.ReadOnly = true;
            // 
            // Ofe_Descrip
            // 
            this.Ofe_Descrip.HeaderText = "Descripcion";
            this.Ofe_Descrip.Name = "Ofe_Descrip";
            this.Ofe_Descrip.ReadOnly = true;
            this.Ofe_Descrip.Width = 500;
            // 
            // clie_nombre
            // 
            this.clie_nombre.HeaderText = "Fecha Comprada";
            this.clie_nombre.Name = "clie_nombre";
            this.clie_nombre.ReadOnly = true;
            this.clie_nombre.Width = 269;
            // 
            // Ofe_Precio_Ficticio
            // 
            this.Ofe_Precio_Ficticio.HeaderText = "Precio ficticio";
            this.Ofe_Precio_Ficticio.Name = "Ofe_Precio_Ficticio";
            this.Ofe_Precio_Ficticio.ReadOnly = true;
            this.Ofe_Precio_Ficticio.Width = 268;
            // 
            // Compra_Cant
            // 
            this.Compra_Cant.HeaderText = "Cantidad";
            this.Compra_Cant.Name = "Compra_Cant";
            this.Compra_Cant.ReadOnly = true;
            this.Compra_Cant.Width = 269;
            // 
            // IdCompra
            // 
            this.IdCompra.HeaderText = "IdCompra";
            this.IdCompra.Name = "IdCompra";
            this.IdCompra.ReadOnly = true;
            this.IdCompra.Visible = false;
            // 
            // OfertasAdquiridasFacturaDeProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1387, 548);
            this.Controls.Add(this.cmd_facturar);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OfertasAdquiridasFacturaDeProveedor";
            this.Text = "OfertasAdquiridasFacturaDeProveedor";
            this.Load += new System.EventHandler(this.OfertasAdquiridasFacturaDeProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.Button cmd_facturar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ofe_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ofe_Descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn clie_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ofe_Precio_Ficticio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compra_Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompra;
    }
}