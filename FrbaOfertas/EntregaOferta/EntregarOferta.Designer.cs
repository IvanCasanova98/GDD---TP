namespace FrbaOfertas.EntregarOferta
{
    partial class EntregarOferta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigo_cupon = new System.Windows.Forms.TextBox();
            this.dataGridViewCUPON = new System.Windows.Forms.DataGridView();
            this.Cupon_Fecha_Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupon_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmd_salir = new System.Windows.Forms.Button();
            this.cmd_buscar = new System.Windows.Forms.Button();
            this.cmd_limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCUPON)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_codigo_cupon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(87, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 99);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Codigo del Cupon";
            // 
            // txt_codigo_cupon
            // 
            this.txt_codigo_cupon.Location = new System.Drawing.Point(125, 49);
            this.txt_codigo_cupon.Name = "txt_codigo_cupon";
            this.txt_codigo_cupon.Size = new System.Drawing.Size(534, 20);
            this.txt_codigo_cupon.TabIndex = 15;
            // 
            // dataGridViewCUPON
            // 
            this.dataGridViewCUPON.AllowUserToDeleteRows = false;
            this.dataGridViewCUPON.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCUPON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCUPON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cupon_Fecha_Vencimiento,
            this.Cupon_Codigo,
            this.Seleccionar,
            this.Id});
            this.dataGridViewCUPON.Location = new System.Drawing.Point(87, 164);
            this.dataGridViewCUPON.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCUPON.Name = "dataGridViewCUPON";
            this.dataGridViewCUPON.ReadOnly = true;
            this.dataGridViewCUPON.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewCUPON.RowTemplate.Height = 33;
            this.dataGridViewCUPON.Size = new System.Drawing.Size(697, 308);
            this.dataGridViewCUPON.TabIndex = 17;
            this.dataGridViewCUPON.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCUPON_CellContentClick);
            // 
            // Cupon_Fecha_Vencimiento
            // 
            this.Cupon_Fecha_Vencimiento.HeaderText = "Cupon_Fecha_Vencimiento";
            this.Cupon_Fecha_Vencimiento.Name = "Cupon_Fecha_Vencimiento";
            this.Cupon_Fecha_Vencimiento.ReadOnly = true;
            // 
            // Cupon_Codigo
            // 
            this.Cupon_Codigo.HeaderText = "Cupon_Codigo";
            this.Cupon_Codigo.Name = "Cupon_Codigo";
            this.Cupon_Codigo.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID_Cupon";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // cmd_salir
            // 
            this.cmd_salir.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_salir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_salir.Location = new System.Drawing.Point(88, 127);
            this.cmd_salir.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_salir.Name = "cmd_salir";
            this.cmd_salir.Size = new System.Drawing.Size(86, 34);
            this.cmd_salir.TabIndex = 22;
            this.cmd_salir.Text = "Cancelar";
            this.cmd_salir.UseVisualStyleBackColor = false;
            this.cmd_salir.Click += new System.EventHandler(this.cmd_salir_Click);
            // 
            // cmd_buscar
            // 
            this.cmd_buscar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_buscar.Location = new System.Drawing.Point(700, 127);
            this.cmd_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_buscar.Name = "cmd_buscar";
            this.cmd_buscar.Size = new System.Drawing.Size(86, 34);
            this.cmd_buscar.TabIndex = 21;
            this.cmd_buscar.Text = "Buscar";
            this.cmd_buscar.UseVisualStyleBackColor = false;
            this.cmd_buscar.Click += new System.EventHandler(this.cmd_buscar_Click);
            // 
            // cmd_limpiar
            // 
            this.cmd_limpiar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_limpiar.Location = new System.Drawing.Point(406, 127);
            this.cmd_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_limpiar.Name = "cmd_limpiar";
            this.cmd_limpiar.Size = new System.Drawing.Size(86, 34);
            this.cmd_limpiar.TabIndex = 20;
            this.cmd_limpiar.Text = "Limpiar";
            this.cmd_limpiar.UseVisualStyleBackColor = false;
            this.cmd_limpiar.Click += new System.EventHandler(this.cmd_limpiar_Click);
            // 
            // EntregarOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(865, 485);
            this.Controls.Add(this.cmd_salir);
            this.Controls.Add(this.cmd_buscar);
            this.Controls.Add(this.cmd_limpiar);
            this.Controls.Add(this.dataGridViewCUPON);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EntregarOferta";
            this.Text = "EntregarOferta";
            this.Load += new System.EventHandler(this.EntregarOferta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCUPON)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigo_cupon;
        private System.Windows.Forms.DataGridView dataGridViewCUPON;
        private System.Windows.Forms.Button cmd_salir;
        private System.Windows.Forms.Button cmd_buscar;
        private System.Windows.Forms.Button cmd_limpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupon_Fecha_Vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupon_Codigo;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}