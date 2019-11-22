namespace FrbaOfertas.AbmProveedor
{
    partial class ListadoProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoProveedor));
            this.button1 = new System.Windows.Forms.Button();
            this.txt_cuit = new System.Windows.Forms.TextBox();
            this.txt_razonsocial = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.cmd_limpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dpto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(953, 141);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_cuit
            // 
            this.txt_cuit.Location = new System.Drawing.Point(105, 90);
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(568, 20);
            this.txt_cuit.TabIndex = 15;
            // 
            // txt_razonsocial
            // 
            this.txt_razonsocial.Location = new System.Drawing.Point(105, 27);
            this.txt_razonsocial.Name = "txt_razonsocial";
            this.txt_razonsocial.Size = new System.Drawing.Size(568, 20);
            this.txt_razonsocial.TabIndex = 18;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(105, 57);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(568, 20);
            this.txt_mail.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(17, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "MAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CUIT";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblnombre.Location = new System.Drawing.Point(17, 30);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(82, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Razón Social";
            // 
            // cmd_limpiar
            // 
            this.cmd_limpiar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_limpiar.Location = new System.Drawing.Point(659, 141);
            this.cmd_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_limpiar.Name = "cmd_limpiar";
            this.cmd_limpiar.Size = new System.Drawing.Size(86, 34);
            this.cmd_limpiar.TabIndex = 16;
            this.cmd_limpiar.Text = "Limpiar";
            this.cmd_limpiar.UseVisualStyleBackColor = false;
            this.cmd_limpiar.Click += new System.EventHandler(this.cmd_limpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cuit);
            this.groupBox1.Controls.Add(this.txt_razonsocial);
            this.groupBox1.Controls.Add(this.txt_mail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblnombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(341, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 124);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Razon_Social,
            this.CUIT,
            this.Mail,
            this.Telefono,
            this.Calle,
            this.Piso,
            this.Dpto,
            this.Localidad,
            this.Ciudad,
            this.CodPostal,
            this.Nombre_Contacto,
            this.Rubro,
            this.Habilitado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1353, 412);
            this.dataGridView1.TabIndex = 18;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Razon_Social
            // 
            this.Razon_Social.HeaderText = "Razon Social";
            this.Razon_Social.Name = "Razon_Social";
            this.Razon_Social.ReadOnly = true;
            // 
            // CUIT
            // 
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Calle
            // 
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            // 
            // Piso
            // 
            this.Piso.HeaderText = "Piso";
            this.Piso.Name = "Piso";
            this.Piso.ReadOnly = true;
            // 
            // Dpto
            // 
            this.Dpto.HeaderText = "Dpto";
            this.Dpto.Name = "Dpto";
            this.Dpto.ReadOnly = true;
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // CodPostal
            // 
            this.CodPostal.HeaderText = "Codigo Postal";
            this.CodPostal.Name = "CodPostal";
            this.CodPostal.ReadOnly = true;
            // 
            // Nombre_Contacto
            // 
            this.Nombre_Contacto.HeaderText = "Nombre_Contacto";
            this.Nombre_Contacto.Name = "Nombre_Contacto";
            this.Nombre_Contacto.ReadOnly = true;
            // 
            // Rubro
            // 
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.Name = "Rubro";
            this.Rubro.ReadOnly = true;
            // 
            // Habilitado
            // 
            this.Habilitado.HeaderText = "Habilitado";
            this.Habilitado.Name = "Habilitado";
            this.Habilitado.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(341, 141);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListadoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1377, 635);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmd_limpiar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListadoProveedor";
            this.Text = "Listado Proveedor";
            this.Load += new System.EventHandler(this.ListadoProveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_cuit;
        private System.Windows.Forms.TextBox txt_razonsocial;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Button cmd_limpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon_Social;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dpto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habilitado;

    }
}