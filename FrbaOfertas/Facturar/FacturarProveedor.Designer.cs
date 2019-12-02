namespace FrbaOfertas.Facturar
{
    partial class FacturarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturarProveedor));
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.cmd_avanzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listView1.Location = new System.Drawing.Point(48, 10);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(708, 252);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Facturas Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Facturas Hasta";
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Location = new System.Drawing.Point(305, 45);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(429, 31);
            this.dateTimeDesde.TabIndex = 22;
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Location = new System.Drawing.Point(305, 170);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(429, 31);
            this.dateTimeHasta.TabIndex = 23;
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_cancelar.Location = new System.Drawing.Point(802, 27);
            this.cmd_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(256, 65);
            this.cmd_cancelar.TabIndex = 26;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = false;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click);
            // 
            // cmd_avanzar
            // 
            this.cmd_avanzar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_avanzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_avanzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_avanzar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_avanzar.Location = new System.Drawing.Point(802, 164);
            this.cmd_avanzar.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_avanzar.Name = "cmd_avanzar";
            this.cmd_avanzar.Size = new System.Drawing.Size(256, 65);
            this.cmd_avanzar.TabIndex = 27;
            this.cmd_avanzar.Text = "Avanzar";
            this.cmd_avanzar.UseVisualStyleBackColor = false;
            this.cmd_avanzar.Click += new System.EventHandler(this.cmd_avanzar_Click);
            // 
            // FacturarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1102, 304);
            this.Controls.Add(this.cmd_avanzar);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.dateTimeHasta);
            this.Controls.Add(this.dateTimeDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FacturarProveedor";
            this.Text = "Facturar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.Button cmd_avanzar;
    }
}