namespace FrbaOfertas.AbmCliente
{
    partial class ListadoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.cmd_limpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_mail);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.txt_dni);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblnombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(70, 117);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(566, 20);
            this.txt_mail.TabIndex = 15;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(70, 23);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(566, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(70, 51);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(566, 20);
            this.txt_apellido.TabIndex = 8;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(70, 83);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(566, 20);
            this.txt_dni.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(14, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "MAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apellido";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblnombre.Location = new System.Drawing.Point(14, 23);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(50, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            // 
            // cmd_limpiar
            // 
            this.cmd_limpiar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_limpiar.Location = new System.Drawing.Point(12, 172);
            this.cmd_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_limpiar.Name = "cmd_limpiar";
            this.cmd_limpiar.Size = new System.Drawing.Size(86, 34);
            this.cmd_limpiar.TabIndex = 13;
            this.cmd_limpiar.Text = "Limpiar";
            this.cmd_limpiar.UseVisualStyleBackColor = false;
            this.cmd_limpiar.Click += new System.EventHandler(this.cmd_limpiar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(625, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 412);
            this.dataGridView1.TabIndex = 15;
            // 
            // ListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 635);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmd_limpiar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListadoCliente";
            this.Text = "Listado Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Button cmd_limpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}