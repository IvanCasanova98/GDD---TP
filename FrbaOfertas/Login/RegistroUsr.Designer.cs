namespace FrbaOfertas.RegistroUsuario
{
    partial class RegistroUsr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsr));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmd_sgte = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbo_rol = new System.Windows.Forms.ComboBox();
            this.tb_pass_confirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Alta de Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre de Usuario:";
            // 
            // tb_user
            // 
            this.tb_user.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_user.ForeColor = System.Drawing.Color.Black;
            this.tb_user.Location = new System.Drawing.Point(140, 18);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(231, 20);
            this.tb_user.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Contraseña:";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(140, 44);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(231, 20);
            this.tb_pass.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmd_sgte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.cbo_rol);
            this.groupBox1.Controls.Add(this.tb_pass_confirm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_pass);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_user);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(21, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(393, 184);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Usuario";
            // 
            // cmd_sgte
            // 
            this.cmd_sgte.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_sgte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_sgte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_sgte.Location = new System.Drawing.Point(224, 136);
            this.cmd_sgte.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_sgte.Name = "cmd_sgte";
            this.cmd_sgte.Size = new System.Drawing.Size(128, 34);
            this.cmd_sgte.TabIndex = 0;
            this.cmd_sgte.Text = "Siguiente";
            this.cmd_sgte.UseVisualStyleBackColor = false;
            this.cmd_sgte.Click += new System.EventHandler(this.cmd_sgte_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Rol:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(45, 136);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 34);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbo_rol
            // 
            this.cbo_rol.AccessibleDescription = "";
            this.cbo_rol.AccessibleName = "";
            this.cbo_rol.AutoCompleteCustomSource.AddRange(new string[] {
            "Cliente",
            "Proveedor",
            "Administrador"});
            this.cbo_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_rol.FormattingEnabled = true;
            this.cbo_rol.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbo_rol.Items.AddRange(new object[] {
            "Cliente",
            "Proveedor",
            "Administrador"});
            this.cbo_rol.Location = new System.Drawing.Point(140, 95);
            this.cbo_rol.MaxDropDownItems = 3;
            this.cbo_rol.Name = "cbo_rol";
            this.cbo_rol.Size = new System.Drawing.Size(231, 21);
            this.cbo_rol.TabIndex = 3;
            // 
            // tb_pass_confirm
            // 
            this.tb_pass_confirm.Location = new System.Drawing.Point(140, 69);
            this.tb_pass_confirm.Name = "tb_pass_confirm";
            this.tb_pass_confirm.PasswordChar = '*';
            this.tb_pass_confirm.Size = new System.Drawing.Size(231, 20);
            this.tb_pass_confirm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Repita Contraseña:";
            // 
            // RegistroUsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroUsr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_pass_confirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_rol;
        private System.Windows.Forms.Button cmd_sgte;

        
    }
}