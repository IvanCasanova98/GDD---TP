namespace FrbaOfertas.ComprarOferta
{
    partial class HistorialCupones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialCupones));
            this.dataGridHistorial = new System.Windows.Forms.DataGridView();
            this.CodigoCupon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canjeado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHistorial
            // 
            this.dataGridHistorial.AllowUserToDeleteRows = false;
            this.dataGridHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCupon,
            this.Detalle,
            this.Cantidad,
            this.FechaVenc,
            this.Canjeado});
            this.dataGridHistorial.Location = new System.Drawing.Point(12, 106);
            this.dataGridHistorial.Name = "dataGridHistorial";
            this.dataGridHistorial.ReadOnly = true;
            this.dataGridHistorial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridHistorial.Size = new System.Drawing.Size(893, 437);
            this.dataGridHistorial.TabIndex = 0;
            this.dataGridHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CodigoCupon
            // 
            this.CodigoCupon.HeaderText = "CodigoCupon";
            this.CodigoCupon.Name = "CodigoCupon";
            this.CodigoCupon.ReadOnly = true;
            this.CodigoCupon.Width = 200;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Width = 300;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // FechaVenc
            // 
            this.FechaVenc.HeaderText = "Fecha Vencimiento";
            this.FechaVenc.Name = "FechaVenc";
            this.FechaVenc.ReadOnly = true;
            this.FechaVenc.Width = 150;
            // 
            // Canjeado
            // 
            this.Canjeado.HeaderText = "Canjeado";
            this.Canjeado.Name = "Canjeado";
            this.Canjeado.ReadOnly = true;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.Location = new System.Drawing.Point(278, 29);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(351, 39);
            this.lblHistorial.TabIndex = 1;
            this.lblHistorial.Text = "Historial de cupones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HistorialCupones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(925, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.dataGridHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistorialCupones";
            this.Text = "HistorialCupones";
            this.Load += new System.EventHandler(this.HistorialCupones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHistorial;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCupon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canjeado;
    }
}