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
            this.Ofe_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ofe_Descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clie_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ofe_Precio_Ficticio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.cmd_facturar = new System.Windows.Forms.Button();
            this.Compra_Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ofe_ID,
            this.Ofe_Descrip,
            this.clie_nombre,
            this.Ofe_Precio_Ficticio,
            this.Compra_Cant});
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1366, 673);
            this.dataGridView1.TabIndex = 0;
            // 
            // Ofe_ID
            // 
            this.Ofe_ID.HeaderText = "Ofe_ID";
            this.Ofe_ID.Name = "Ofe_ID";
            this.Ofe_ID.ReadOnly = true;
            // 
            // Ofe_Descrip
            // 
            this.Ofe_Descrip.HeaderText = "Ofe_Descrip";
            this.Ofe_Descrip.Name = "Ofe_Descrip";
            this.Ofe_Descrip.ReadOnly = true;
            // 
            // clie_nombre
            // 
            this.clie_nombre.HeaderText = "clie_nombre";
            this.clie_nombre.Name = "clie_nombre";
            this.clie_nombre.ReadOnly = true;
            // 
            // Ofe_Precio_Ficticio
            // 
            this.Ofe_Precio_Ficticio.HeaderText = "Ofe_Precio_Ficticio";
            this.Ofe_Precio_Ficticio.Name = "Ofe_Precio_Ficticio";
            this.Ofe_Precio_Ficticio.ReadOnly = true;
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_cancelar.Location = new System.Drawing.Point(12, 11);
            this.cmd_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(256, 65);
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
            this.cmd_facturar.Location = new System.Drawing.Point(1122, 11);
            this.cmd_facturar.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_facturar.Name = "cmd_facturar";
            this.cmd_facturar.Size = new System.Drawing.Size(256, 65);
            this.cmd_facturar.TabIndex = 29;
            this.cmd_facturar.Text = "Facturar";
            this.cmd_facturar.UseVisualStyleBackColor = false;
            this.cmd_facturar.Click += new System.EventHandler(this.cmd_facturar_Click);
            // 
            // Compra_Cant
            // 
            this.Compra_Cant.HeaderText = "Compra_Cant";
            this.Compra_Cant.Name = "Compra_Cant";
            this.Compra_Cant.ReadOnly = true;
            // 
            // OfertasAdquiridasFacturaDeProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1390, 768);
            this.Controls.Add(this.cmd_facturar);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}