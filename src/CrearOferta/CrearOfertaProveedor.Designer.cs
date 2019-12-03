namespace FrbaOfertas.CrearOferta
{
    partial class CrearOfertaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearOfertaProveedor));
            this.cmd_limpiar = new System.Windows.Forms.Button();
            this.cmd_darAlta = new System.Windows.Forms.Button();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.Detalles = new System.Windows.Forms.GroupBox();
            this.dateTimePickerVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerOferta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maxUnidadesPorCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_precioOferta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_stockDisponible = new System.Windows.Forms.TextBox();
            this.txt_precioLista = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Detalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_limpiar
            // 
            this.cmd_limpiar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_limpiar.Location = new System.Drawing.Point(266, 361);
            this.cmd_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_limpiar.Name = "cmd_limpiar";
            this.cmd_limpiar.Size = new System.Drawing.Size(86, 34);
            this.cmd_limpiar.TabIndex = 20;
            this.cmd_limpiar.Text = "Limpiar";
            this.cmd_limpiar.UseVisualStyleBackColor = false;
            // 
            // cmd_darAlta
            // 
            this.cmd_darAlta.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_darAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_darAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_darAlta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_darAlta.Location = new System.Drawing.Point(438, 361);
            this.cmd_darAlta.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_darAlta.Name = "cmd_darAlta";
            this.cmd_darAlta.Size = new System.Drawing.Size(128, 34);
            this.cmd_darAlta.TabIndex = 19;
            this.cmd_darAlta.Text = "Guardar";
            this.cmd_darAlta.UseVisualStyleBackColor = false;
            this.cmd_darAlta.Click += new System.EventHandler(this.cmd_darAlta_Click);
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_cancelar.Location = new System.Drawing.Point(52, 361);
            this.cmd_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(128, 34);
            this.cmd_cancelar.TabIndex = 21;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = false;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click_1);
            // 
            // Detalles
            // 
            this.Detalles.Controls.Add(this.dateTimePickerVencimiento);
            this.Detalles.Controls.Add(this.label7);
            this.Detalles.Controls.Add(this.dateTimePickerOferta);
            this.Detalles.Controls.Add(this.label1);
            this.Detalles.Controls.Add(this.txt_descripcion);
            this.Detalles.Controls.Add(this.label10);
            this.Detalles.Controls.Add(this.label3);
            this.Detalles.Controls.Add(this.txt_maxUnidadesPorCliente);
            this.Detalles.Controls.Add(this.label5);
            this.Detalles.Controls.Add(this.label8);
            this.Detalles.Controls.Add(this.label2);
            this.Detalles.Controls.Add(this.txt_precioOferta);
            this.Detalles.Controls.Add(this.label4);
            this.Detalles.Controls.Add(this.txt_stockDisponible);
            this.Detalles.Controls.Add(this.txt_precioLista);
            this.Detalles.Controls.Add(this.label6);
            this.Detalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detalles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Detalles.Location = new System.Drawing.Point(52, 12);
            this.Detalles.Name = "Detalles";
            this.Detalles.Size = new System.Drawing.Size(514, 338);
            this.Detalles.TabIndex = 18;
            this.Detalles.TabStop = false;
            this.Detalles.Text = "Detalle de Oferta";
            // 
            // dateTimePickerVencimiento
            // 
            this.dateTimePickerVencimiento.Location = new System.Drawing.Point(157, 70);
            this.dateTimePickerVencimiento.Name = "dateTimePickerVencimiento";
            this.dateTimePickerVencimiento.Size = new System.Drawing.Size(314, 20);
            this.dateTimePickerVencimiento.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Fecha De Vencimiento";
            // 
            // dateTimePickerOferta
            // 
            this.dateTimePickerOferta.Location = new System.Drawing.Point(157, 29);
            this.dateTimePickerOferta.Name = "dateTimePickerOferta";
            this.dateTimePickerOferta.Size = new System.Drawing.Size(314, 20);
            this.dateTimePickerOferta.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha De Publicación";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(157, 111);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(314, 20);
            this.txt_descripcion.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(18, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Descripción de Oferta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "$";
            // 
            // txt_maxUnidadesPorCliente
            // 
            this.txt_maxUnidadesPorCliente.Location = new System.Drawing.Point(227, 268);
            this.txt_maxUnidadesPorCliente.Name = "txt_maxUnidadesPorCliente";
            this.txt_maxUnidadesPorCliente.Size = new System.Drawing.Size(245, 20);
            this.txt_maxUnidadesPorCliente.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(18, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Máximo de Unidades por Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(18, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio de Oferta";
            // 
            // txt_precioOferta
            // 
            this.txt_precioOferta.Location = new System.Drawing.Point(157, 149);
            this.txt_precioOferta.Name = "txt_precioOferta";
            this.txt_precioOferta.Size = new System.Drawing.Size(315, 20);
            this.txt_precioOferta.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(18, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio de Lista";
            // 
            // txt_stockDisponible
            // 
            this.txt_stockDisponible.Location = new System.Drawing.Point(157, 228);
            this.txt_stockDisponible.Name = "txt_stockDisponible";
            this.txt_stockDisponible.Size = new System.Drawing.Size(315, 20);
            this.txt_stockDisponible.TabIndex = 9;
            // 
            // txt_precioLista
            // 
            this.txt_precioLista.Location = new System.Drawing.Point(157, 189);
            this.txt_precioLista.Name = "txt_precioLista";
            this.txt_precioLista.Size = new System.Drawing.Size(315, 20);
            this.txt_precioLista.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(18, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stock Disponible";
            // 
            // CrearOfertaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(619, 413);
            this.Controls.Add(this.cmd_limpiar);
            this.Controls.Add(this.cmd_darAlta);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.Detalles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearOfertaProveedor";
            this.Text = "Crear Oferta";
            this.Detalles.ResumeLayout(false);
            this.Detalles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_limpiar;
        private System.Windows.Forms.Button cmd_darAlta;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.GroupBox Detalles;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maxUnidadesPorCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_precioOferta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_stockDisponible;
        private System.Windows.Forms.TextBox txt_precioLista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerVencimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerOferta;
        private System.Windows.Forms.Label label1;
    }
}