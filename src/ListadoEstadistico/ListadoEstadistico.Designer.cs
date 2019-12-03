namespace FrbaOfertas.ListadoEstadistico
{
    partial class ListadoEstadistico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoEstadistico));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdListadoFACTURACION = new System.Windows.Forms.Button();
            this.cmdListadoOFERTAS = new System.Windows.Forms.Button();
            this.radioBtnSEGUNDO = new System.Windows.Forms.RadioButton();
            this.radioBtnPRIMERO = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAños = new System.Windows.Forms.ComboBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.dataGridViewListadoFACTURAS = new System.Windows.Forms.DataGridView();
            this.ID_PROVEEDOR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZÓN_SOCIAL2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_FACTURADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD_FACTURAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.dataGridViewListadoOFERTAS = new System.Windows.Forms.DataGridView();
            this.ID_PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZÓN_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD_OFERTAS_REALIZADAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PORCENTAJE_DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoFACTURAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoOFERTAS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdListadoFACTURACION);
            this.groupBox1.Controls.Add(this.cmdListadoOFERTAS);
            this.groupBox1.Controls.Add(this.radioBtnSEGUNDO);
            this.groupBox1.Controls.Add(this.radioBtnPRIMERO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboAños);
            this.groupBox1.Controls.Add(this.lblnombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(106, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Listado";
            // 
            // cmdListadoFACTURACION
            // 
            this.cmdListadoFACTURACION.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdListadoFACTURACION.Location = new System.Drawing.Point(47, 75);
            this.cmdListadoFACTURACION.Name = "cmdListadoFACTURACION";
            this.cmdListadoFACTURACION.Size = new System.Drawing.Size(148, 63);
            this.cmdListadoFACTURACION.TabIndex = 15;
            this.cmdListadoFACTURACION.Text = "Mayor Facturación";
            this.cmdListadoFACTURACION.UseVisualStyleBackColor = true;
            this.cmdListadoFACTURACION.Click += new System.EventHandler(this.cmdListadoFACTURACION_Click);
            // 
            // cmdListadoOFERTAS
            // 
            this.cmdListadoOFERTAS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdListadoOFERTAS.Location = new System.Drawing.Point(513, 75);
            this.cmdListadoOFERTAS.Name = "cmdListadoOFERTAS";
            this.cmdListadoOFERTAS.Size = new System.Drawing.Size(148, 63);
            this.cmdListadoOFERTAS.TabIndex = 14;
            this.cmdListadoOFERTAS.Text = "Mayor Porcentaje de Descuento Ofrecido en Ofertas";
            this.cmdListadoOFERTAS.UseVisualStyleBackColor = true;
            this.cmdListadoOFERTAS.Click += new System.EventHandler(this.cmdListadoOFERTAS_Click);
            // 
            // radioBtnSEGUNDO
            // 
            this.radioBtnSEGUNDO.AutoSize = true;
            this.radioBtnSEGUNDO.ForeColor = System.Drawing.Color.Maroon;
            this.radioBtnSEGUNDO.Location = new System.Drawing.Point(305, 112);
            this.radioBtnSEGUNDO.Name = "radioBtnSEGUNDO";
            this.radioBtnSEGUNDO.Size = new System.Drawing.Size(157, 17);
            this.radioBtnSEGUNDO.TabIndex = 4;
            this.radioBtnSEGUNDO.TabStop = true;
            this.radioBtnSEGUNDO.Text = "SEGUNDO SEMESTRE";
            this.radioBtnSEGUNDO.UseVisualStyleBackColor = true;
            // 
            // radioBtnPRIMERO
            // 
            this.radioBtnPRIMERO.AutoSize = true;
            this.radioBtnPRIMERO.ForeColor = System.Drawing.Color.Maroon;
            this.radioBtnPRIMERO.Location = new System.Drawing.Point(305, 85);
            this.radioBtnPRIMERO.Name = "radioBtnPRIMERO";
            this.radioBtnPRIMERO.Size = new System.Drawing.Size(144, 17);
            this.radioBtnPRIMERO.TabIndex = 3;
            this.radioBtnPRIMERO.TabStop = true;
            this.radioBtnPRIMERO.Text = "PRIMER SEMESTRE";
            this.radioBtnPRIMERO.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(229, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Semestre";
            // 
            // cboAños
            // 
            this.cboAños.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAños.FormattingEnabled = true;
            this.cboAños.Location = new System.Drawing.Point(89, 35);
            this.cboAños.Name = "cboAños";
            this.cboAños.Size = new System.Drawing.Size(572, 21);
            this.cboAños.TabIndex = 1;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblnombre.Location = new System.Drawing.Point(44, 38);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(29, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Año";
            // 
            // dataGridViewListadoFACTURAS
            // 
            this.dataGridViewListadoFACTURAS.AllowUserToDeleteRows = false;
            this.dataGridViewListadoFACTURAS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListadoFACTURAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoFACTURAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PROVEEDOR2,
            this.RAZÓN_SOCIAL2,
            this.TOTAL_FACTURADO,
            this.CANTIDAD_FACTURAS});
            this.dataGridViewListadoFACTURAS.Location = new System.Drawing.Point(60, 223);
            this.dataGridViewListadoFACTURAS.Name = "dataGridViewListadoFACTURAS";
            this.dataGridViewListadoFACTURAS.ReadOnly = true;
            this.dataGridViewListadoFACTURAS.Size = new System.Drawing.Size(832, 383);
            this.dataGridViewListadoFACTURAS.TabIndex = 2;
            // 
            // ID_PROVEEDOR2
            // 
            this.ID_PROVEEDOR2.HeaderText = "ID_PROVEEDOR";
            this.ID_PROVEEDOR2.Name = "ID_PROVEEDOR2";
            this.ID_PROVEEDOR2.ReadOnly = true;
            // 
            // RAZÓN_SOCIAL2
            // 
            this.RAZÓN_SOCIAL2.HeaderText = "RAZÓN_SOCIAL";
            this.RAZÓN_SOCIAL2.Name = "RAZÓN_SOCIAL2";
            this.RAZÓN_SOCIAL2.ReadOnly = true;
            // 
            // TOTAL_FACTURADO
            // 
            this.TOTAL_FACTURADO.HeaderText = "TOTAL_FACTURADO";
            this.TOTAL_FACTURADO.Name = "TOTAL_FACTURADO";
            this.TOTAL_FACTURADO.ReadOnly = true;
            // 
            // CANTIDAD_FACTURAS
            // 
            this.CANTIDAD_FACTURAS.HeaderText = "CANTIDAD_DE_FACTURAS";
            this.CANTIDAD_FACTURAS.Name = "CANTIDAD_FACTURAS";
            this.CANTIDAD_FACTURAS.ReadOnly = true;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(106, 180);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(118, 37);
            this.cmdCancelar.TabIndex = 13;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(669, 180);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(135, 37);
            this.cmdLimpiar.TabIndex = 12;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // dataGridViewListadoOFERTAS
            // 
            this.dataGridViewListadoOFERTAS.AllowUserToDeleteRows = false;
            this.dataGridViewListadoOFERTAS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListadoOFERTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoOFERTAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PROVEEDOR,
            this.RAZÓN_SOCIAL,
            this.CANTIDAD_OFERTAS_REALIZADAS,
            this.PORCENTAJE_DESCUENTO});
            this.dataGridViewListadoOFERTAS.Location = new System.Drawing.Point(60, 223);
            this.dataGridViewListadoOFERTAS.Name = "dataGridViewListadoOFERTAS";
            this.dataGridViewListadoOFERTAS.ReadOnly = true;
            this.dataGridViewListadoOFERTAS.Size = new System.Drawing.Size(832, 383);
            this.dataGridViewListadoOFERTAS.TabIndex = 14;
            this.dataGridViewListadoOFERTAS.Visible = false;
            // 
            // ID_PROVEEDOR
            // 
            this.ID_PROVEEDOR.HeaderText = "ID_PROVEEDOR";
            this.ID_PROVEEDOR.Name = "ID_PROVEEDOR";
            this.ID_PROVEEDOR.ReadOnly = true;
            // 
            // RAZÓN_SOCIAL
            // 
            this.RAZÓN_SOCIAL.HeaderText = "RAZÓN_SOCIAL";
            this.RAZÓN_SOCIAL.Name = "RAZÓN_SOCIAL";
            this.RAZÓN_SOCIAL.ReadOnly = true;
            // 
            // CANTIDAD_OFERTAS_REALIZADAS
            // 
            this.CANTIDAD_OFERTAS_REALIZADAS.HeaderText = "CANTIDAD_OFERTAS_REALIZADAS";
            this.CANTIDAD_OFERTAS_REALIZADAS.Name = "CANTIDAD_OFERTAS_REALIZADAS";
            this.CANTIDAD_OFERTAS_REALIZADAS.ReadOnly = true;
            // 
            // PORCENTAJE_DESCUENTO
            // 
            this.PORCENTAJE_DESCUENTO.HeaderText = "PORCENTAJE_DESCUENTO";
            this.PORCENTAJE_DESCUENTO.Name = "PORCENTAJE_DESCUENTO";
            this.PORCENTAJE_DESCUENTO.ReadOnly = true;
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(953, 651);
            this.Controls.Add(this.dataGridViewListadoOFERTAS);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.dataGridViewListadoFACTURAS);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListadoEstadistico";
            this.Text = "Listado Estadistico";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoFACTURAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoOFERTAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.ComboBox cboAños;
        private System.Windows.Forms.RadioButton radioBtnSEGUNDO;
        private System.Windows.Forms.RadioButton radioBtnPRIMERO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewListadoFACTURAS;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdListadoFACTURACION;
        private System.Windows.Forms.Button cmdListadoOFERTAS;
        private System.Windows.Forms.DataGridView dataGridViewListadoOFERTAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZÓN_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD_OFERTAS_REALIZADAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PORCENTAJE_DESCUENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROVEEDOR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZÓN_SOCIAL2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_FACTURADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD_FACTURAS;
    }
}