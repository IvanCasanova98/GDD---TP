namespace FrbaOfertas.Home
{
    partial class MenuPrincial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMDeProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confecciónYPublicaciónDeOfertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarOfertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregaConsumoDeOfertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónAProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoEstadísticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.aBMDeProveedorToolStripMenuItem,
            this.cargarCreditoToolStripMenuItem,
            this.confecciónYPublicaciónDeOfertasToolStripMenuItem,
            this.comprarOfertaToolStripMenuItem,
            this.entregaConsumoDeOfertaToolStripMenuItem,
            this.facturaciónAProveedorToolStripMenuItem,
            this.listadoEstadísticoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(214, 505);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "NavBar";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarDatosToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.opcionesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 110, 0, 0);
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 5);
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // modificarDatosToolStripMenuItem
            // 
            this.modificarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.proveedorToolStripMenuItem});
            this.modificarDatosToolStripMenuItem.Name = "modificarDatosToolStripMenuItem";
            this.modificarDatosToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.modificarDatosToolStripMenuItem.Text = "Modificar datos personales";
            this.modificarDatosToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(263, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "HPBC-FRBAOFERTAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 19);
            this.toolStripMenuItem1.Text = "ABM de Rol";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 19);
            this.toolStripMenuItem2.Text = "ABM de Cliente";
            // 
            // aBMDeProveedorToolStripMenuItem
            // 
            this.aBMDeProveedorToolStripMenuItem.Name = "aBMDeProveedorToolStripMenuItem";
            this.aBMDeProveedorToolStripMenuItem.Size = new System.Drawing.Size(213, 19);
            this.aBMDeProveedorToolStripMenuItem.Text = "ABM de Proveedor";
            // 
            // cargarCreditoToolStripMenuItem
            // 
            this.cargarCreditoToolStripMenuItem.Name = "cargarCreditoToolStripMenuItem";
            this.cargarCreditoToolStripMenuItem.Size = new System.Drawing.Size(213, 19);
            this.cargarCreditoToolStripMenuItem.Text = "Cargar Credito";
            // 
            // confecciónYPublicaciónDeOfertasToolStripMenuItem
            // 
            this.confecciónYPublicaciónDeOfertasToolStripMenuItem.Name = "confecciónYPublicaciónDeOfertasToolStripMenuItem";
            this.confecciónYPublicaciónDeOfertasToolStripMenuItem.Size = new System.Drawing.Size(213, 19);
            this.confecciónYPublicaciónDeOfertasToolStripMenuItem.Text = "Confección y publicación de Ofertas ";
            // 
            // comprarOfertaToolStripMenuItem
            // 
            this.comprarOfertaToolStripMenuItem.Name = "comprarOfertaToolStripMenuItem";
            this.comprarOfertaToolStripMenuItem.Size = new System.Drawing.Size(213, 19);
            this.comprarOfertaToolStripMenuItem.Text = "Comprar Oferta ";
            // 
            // entregaConsumoDeOfertaToolStripMenuItem
            // 
            this.entregaConsumoDeOfertaToolStripMenuItem.Name = "entregaConsumoDeOfertaToolStripMenuItem";
            this.entregaConsumoDeOfertaToolStripMenuItem.Size = new System.Drawing.Size(213, 19);
            this.entregaConsumoDeOfertaToolStripMenuItem.Text = "Entrega/Consumo de oferta ";
            // 
            // facturaciónAProveedorToolStripMenuItem
            // 
            this.facturaciónAProveedorToolStripMenuItem.Name = "facturaciónAProveedorToolStripMenuItem";
            this.facturaciónAProveedorToolStripMenuItem.Size = new System.Drawing.Size(213, 19);
            this.facturaciónAProveedorToolStripMenuItem.Text = " Facturación a Proveedor";
            // 
            // listadoEstadísticoToolStripMenuItem
            // 
            this.listadoEstadísticoToolStripMenuItem.Name = "listadoEstadísticoToolStripMenuItem";
            this.listadoEstadísticoToolStripMenuItem.Size = new System.Drawing.Size(213, 19);
            this.listadoEstadísticoToolStripMenuItem.Text = " Listado Estadístico";
            // 
            // MenuPrincial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(865, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aBMDeProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarCreditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confecciónYPublicaciónDeOfertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarOfertaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregaConsumoDeOfertaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónAProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoEstadísticoToolStripMenuItem;


    }
}