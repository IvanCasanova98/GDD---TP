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
            this.button1.Location = new System.Drawing.Point(624, 141);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
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
            this.cmd_limpiar.Location = new System.Drawing.Point(12, 141);
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
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 124);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 412);
            this.dataGridView1.TabIndex = 18;
            // 
            // ListadoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 635);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmd_limpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoProveedor";
            this.Text = "Listado Proveedor";
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

    }
}