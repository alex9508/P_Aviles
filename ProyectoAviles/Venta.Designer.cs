namespace ProyectoAviles
{
    partial class Venta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.gpbxTipos = new FlatUI.FlatGroupBox();
            this.txtbxCantidad = new FlatUI.FlatTextBox();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.rdbtnChico = new FlatUI.FlatRadioButton();
            this.rdbtnGrande = new FlatUI.FlatRadioButton();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.gpbxResenia = new FlatUI.FlatGroupBox();
            this.lblTotalVen = new FlatUI.FlatLabel();
            this.flatLabel7 = new FlatUI.FlatLabel();
            this.lblCantidadF = new FlatUI.FlatLabel();
            this.lblcantiNOO = new FlatUI.FlatLabel();
            this.lblELEtipo = new FlatUI.FlatLabel();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.btnCotizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnREalVenta = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtbxID_Cliente = new FlatUI.FlatTextBox();
            this.flatLabel8 = new FlatUI.FlatLabel();
            this.txtbxDireccion = new FlatUI.FlatTextBox();
            this.flatLabel5 = new FlatUI.FlatLabel();
            this.flatLabel6 = new FlatUI.FlatLabel();
            this.txtbxID_USER_ONLINE = new FlatUI.FlatTextBox();
            this.gpbxTipos.SuspendLayout();
            this.gpbxResenia.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // gpbxTipos
            // 
            this.gpbxTipos.BackColor = System.Drawing.Color.Transparent;
            this.gpbxTipos.BaseColor = System.Drawing.Color.DimGray;
            this.gpbxTipos.Controls.Add(this.txtbxCantidad);
            this.gpbxTipos.Controls.Add(this.flatLabel2);
            this.gpbxTipos.Controls.Add(this.rdbtnChico);
            this.gpbxTipos.Controls.Add(this.rdbtnGrande);
            this.gpbxTipos.Controls.Add(this.flatLabel1);
            this.gpbxTipos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gpbxTipos.Location = new System.Drawing.Point(12, 37);
            this.gpbxTipos.Name = "gpbxTipos";
            this.gpbxTipos.ShowText = true;
            this.gpbxTipos.Size = new System.Drawing.Size(295, 302);
            this.gpbxTipos.TabIndex = 0;
            // 
            // txtbxCantidad
            // 
            this.txtbxCantidad.BackColor = System.Drawing.Color.Transparent;
            this.txtbxCantidad.FocusOnHover = false;
            this.txtbxCantidad.Location = new System.Drawing.Point(143, 219);
            this.txtbxCantidad.MaxLength = 32767;
            this.txtbxCantidad.Multiline = false;
            this.txtbxCantidad.Name = "txtbxCantidad";
            this.txtbxCantidad.ReadOnly = false;
            this.txtbxCantidad.Size = new System.Drawing.Size(96, 29);
            this.txtbxCantidad.TabIndex = 4;
            this.txtbxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbxCantidad.TextColor = System.Drawing.Color.White;
            this.txtbxCantidad.UseSystemPasswordChar = false;
            this.txtbxCantidad.TextChanged += new System.EventHandler(this.txtbxCantidad_TextChanged);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(43, 221);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(94, 25);
            this.flatLabel2.TabIndex = 3;
            this.flatLabel2.Text = "Cantidad:";
            // 
            // rdbtnChico
            // 
            this.rdbtnChico.BackColor = System.Drawing.Color.DimGray;
            this.rdbtnChico.Checked = false;
            this.rdbtnChico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtnChico.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnChico.Location = new System.Drawing.Point(82, 148);
            this.rdbtnChico.Name = "rdbtnChico";
            this.rdbtnChico.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.rdbtnChico.Size = new System.Drawing.Size(123, 22);
            this.rdbtnChico.TabIndex = 2;
            this.rdbtnChico.Text = "     40x20x12";
            this.rdbtnChico.CheckedChanged += new FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.rdbtnChico_CheckedChanged);
            // 
            // rdbtnGrande
            // 
            this.rdbtnGrande.BackColor = System.Drawing.Color.DimGray;
            this.rdbtnGrande.Checked = false;
            this.rdbtnGrande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtnGrande.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnGrande.Location = new System.Drawing.Point(82, 94);
            this.rdbtnGrande.Name = "rdbtnGrande";
            this.rdbtnGrande.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.rdbtnGrande.Size = new System.Drawing.Size(123, 22);
            this.rdbtnGrande.TabIndex = 1;
            this.rdbtnGrande.Text = "     40x20x14";
            this.rdbtnGrande.CheckedChanged += new FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.rdbtnGrande_CheckedChanged);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(55, 27);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(176, 25);
            this.flatLabel1.TabIndex = 0;
            this.flatLabel1.Text = "Elegir tipo de block";
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(511, 12);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(207, 25);
            this.flatLabel3.TabIndex = 1;
            this.flatLabel3.Text = "Descripcion del pedido";
            // 
            // gpbxResenia
            // 
            this.gpbxResenia.BackColor = System.Drawing.Color.Transparent;
            this.gpbxResenia.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.gpbxResenia.Controls.Add(this.lblTotalVen);
            this.gpbxResenia.Controls.Add(this.flatLabel7);
            this.gpbxResenia.Controls.Add(this.lblCantidadF);
            this.gpbxResenia.Controls.Add(this.lblcantiNOO);
            this.gpbxResenia.Controls.Add(this.lblELEtipo);
            this.gpbxResenia.Controls.Add(this.flatLabel4);
            this.gpbxResenia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gpbxResenia.Location = new System.Drawing.Point(477, 46);
            this.gpbxResenia.Name = "gpbxResenia";
            this.gpbxResenia.ShowText = true;
            this.gpbxResenia.Size = new System.Drawing.Size(274, 285);
            this.gpbxResenia.TabIndex = 2;
            // 
            // lblTotalVen
            // 
            this.lblTotalVen.AutoSize = true;
            this.lblTotalVen.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalVen.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVen.ForeColor = System.Drawing.Color.White;
            this.lblTotalVen.Location = new System.Drawing.Point(121, 244);
            this.lblTotalVen.Name = "lblTotalVen";
            this.lblTotalVen.Size = new System.Drawing.Size(0, 25);
            this.lblTotalVen.TabIndex = 7;
            // 
            // flatLabel7
            // 
            this.flatLabel7.AutoSize = true;
            this.flatLabel7.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel7.ForeColor = System.Drawing.Color.White;
            this.flatLabel7.Location = new System.Drawing.Point(76, 201);
            this.flatLabel7.Name = "flatLabel7";
            this.flatLabel7.Size = new System.Drawing.Size(132, 25);
            this.flatLabel7.TabIndex = 6;
            this.flatLabel7.Text = "Importe total:";
            // 
            // lblCantidadF
            // 
            this.lblCantidadF.AutoSize = true;
            this.lblCantidadF.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadF.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadF.ForeColor = System.Drawing.Color.White;
            this.lblCantidadF.Location = new System.Drawing.Point(126, 159);
            this.lblCantidadF.Name = "lblCantidadF";
            this.lblCantidadF.Size = new System.Drawing.Size(0, 25);
            this.lblCantidadF.TabIndex = 5;
            // 
            // lblcantiNOO
            // 
            this.lblcantiNOO.AutoSize = true;
            this.lblcantiNOO.BackColor = System.Drawing.Color.Transparent;
            this.lblcantiNOO.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantiNOO.ForeColor = System.Drawing.Color.White;
            this.lblcantiNOO.Location = new System.Drawing.Point(55, 121);
            this.lblcantiNOO.Name = "lblcantiNOO";
            this.lblcantiNOO.Size = new System.Drawing.Size(172, 25);
            this.lblcantiNOO.TabIndex = 4;
            this.lblcantiNOO.Text = "Cantidad de block:";
            // 
            // lblELEtipo
            // 
            this.lblELEtipo.AutoSize = true;
            this.lblELEtipo.BackColor = System.Drawing.Color.Transparent;
            this.lblELEtipo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblELEtipo.ForeColor = System.Drawing.Color.White;
            this.lblELEtipo.Location = new System.Drawing.Point(92, 78);
            this.lblELEtipo.Name = "lblELEtipo";
            this.lblELEtipo.Size = new System.Drawing.Size(0, 25);
            this.lblELEtipo.TabIndex = 3;
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(76, 34);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(132, 25);
            this.flatLabel4.TabIndex = 2;
            this.flatLabel4.Text = "Tipo de block:";
            // 
            // btnCotizar
            // 
            this.btnCotizar.ActiveBorderThickness = 1;
            this.btnCotizar.ActiveCornerRadius = 20;
            this.btnCotizar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCotizar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCotizar.ActiveLineColor = System.Drawing.Color.White;
            this.btnCotizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCotizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCotizar.BackgroundImage")));
            this.btnCotizar.ButtonText = "Cotizar";
            this.btnCotizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCotizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCotizar.IdleBorderThickness = 1;
            this.btnCotizar.IdleCornerRadius = 20;
            this.btnCotizar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCotizar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCotizar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCotizar.Location = new System.Drawing.Point(63, 385);
            this.btnCotizar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(181, 41);
            this.btnCotizar.TabIndex = 3;
            this.btnCotizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // btnREalVenta
            // 
            this.btnREalVenta.ActiveBorderThickness = 1;
            this.btnREalVenta.ActiveCornerRadius = 20;
            this.btnREalVenta.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnREalVenta.ActiveForecolor = System.Drawing.Color.White;
            this.btnREalVenta.ActiveLineColor = System.Drawing.Color.White;
            this.btnREalVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnREalVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnREalVenta.BackgroundImage")));
            this.btnREalVenta.ButtonText = "Realizar venta";
            this.btnREalVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnREalVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREalVenta.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnREalVenta.IdleBorderThickness = 1;
            this.btnREalVenta.IdleCornerRadius = 20;
            this.btnREalVenta.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnREalVenta.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnREalVenta.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnREalVenta.Location = new System.Drawing.Point(527, 438);
            this.btnREalVenta.Margin = new System.Windows.Forms.Padding(5);
            this.btnREalVenta.Name = "btnREalVenta";
            this.btnREalVenta.Size = new System.Drawing.Size(181, 41);
            this.btnREalVenta.TabIndex = 4;
            this.btnREalVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnREalVenta.Click += new System.EventHandler(this.btnREalVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveBorderThickness = 1;
            this.btnCancelar.ActiveCornerRadius = 20;
            this.btnCancelar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancelar.ActiveLineColor = System.Drawing.Color.White;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleCornerRadius = 20;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.Location = new System.Drawing.Point(312, 452);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(181, 41);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtbxID_Cliente
            // 
            this.txtbxID_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txtbxID_Cliente.FocusOnHover = false;
            this.txtbxID_Cliente.Location = new System.Drawing.Point(612, 337);
            this.txtbxID_Cliente.MaxLength = 32767;
            this.txtbxID_Cliente.Multiline = false;
            this.txtbxID_Cliente.Name = "txtbxID_Cliente";
            this.txtbxID_Cliente.ReadOnly = false;
            this.txtbxID_Cliente.Size = new System.Drawing.Size(96, 29);
            this.txtbxID_Cliente.TabIndex = 7;
            this.txtbxID_Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbxID_Cliente.TextColor = System.Drawing.Color.White;
            this.txtbxID_Cliente.UseSystemPasswordChar = false;
            // 
            // flatLabel8
            // 
            this.flatLabel8.AutoSize = true;
            this.flatLabel8.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel8.ForeColor = System.Drawing.Color.White;
            this.flatLabel8.Location = new System.Drawing.Point(512, 339);
            this.flatLabel8.Name = "flatLabel8";
            this.flatLabel8.Size = new System.Drawing.Size(102, 25);
            this.flatLabel8.TabIndex = 6;
            this.flatLabel8.Text = "ID Cliente:";
            // 
            // txtbxDireccion
            // 
            this.txtbxDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txtbxDireccion.FocusOnHover = false;
            this.txtbxDireccion.Location = new System.Drawing.Point(547, 385);
            this.txtbxDireccion.MaxLength = 32767;
            this.txtbxDireccion.Multiline = false;
            this.txtbxDireccion.Name = "txtbxDireccion";
            this.txtbxDireccion.ReadOnly = false;
            this.txtbxDireccion.Size = new System.Drawing.Size(204, 29);
            this.txtbxDireccion.TabIndex = 9;
            this.txtbxDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbxDireccion.TextColor = System.Drawing.Color.White;
            this.txtbxDireccion.UseSystemPasswordChar = false;
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(447, 387);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(98, 25);
            this.flatLabel5.TabIndex = 8;
            this.flatLabel5.Text = "Direccion:";
            // 
            // flatLabel6
            // 
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel6.ForeColor = System.Drawing.Color.White;
            this.flatLabel6.Location = new System.Drawing.Point(10, 9);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(123, 25);
            this.flatLabel6.TabIndex = 10;
            this.flatLabel6.Text = "ID USUARIO:";
            // 
            // txtbxID_USER_ONLINE
            // 
            this.txtbxID_USER_ONLINE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txtbxID_USER_ONLINE.FocusOnHover = false;
            this.txtbxID_USER_ONLINE.Location = new System.Drawing.Point(139, 5);
            this.txtbxID_USER_ONLINE.MaxLength = 32767;
            this.txtbxID_USER_ONLINE.Multiline = false;
            this.txtbxID_USER_ONLINE.Name = "txtbxID_USER_ONLINE";
            this.txtbxID_USER_ONLINE.ReadOnly = false;
            this.txtbxID_USER_ONLINE.Size = new System.Drawing.Size(96, 29);
            this.txtbxID_USER_ONLINE.TabIndex = 11;
            this.txtbxID_USER_ONLINE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbxID_USER_ONLINE.TextColor = System.Drawing.Color.White;
            this.txtbxID_USER_ONLINE.UseSystemPasswordChar = false;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(787, 493);
            this.Controls.Add(this.txtbxID_USER_ONLINE);
            this.Controls.Add(this.flatLabel6);
            this.Controls.Add(this.txtbxDireccion);
            this.Controls.Add(this.flatLabel5);
            this.Controls.Add(this.txtbxID_Cliente);
            this.Controls.Add(this.flatLabel8);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnREalVenta);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.gpbxResenia);
            this.Controls.Add(this.flatLabel3);
            this.Controls.Add(this.gpbxTipos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.gpbxTipos.ResumeLayout(false);
            this.gpbxTipos.PerformLayout();
            this.gpbxResenia.ResumeLayout(false);
            this.gpbxResenia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private FlatUI.FlatGroupBox gpbxTipos;
        private FlatUI.FlatRadioButton rdbtnChico;
        private FlatUI.FlatRadioButton rdbtnGrande;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatTextBox txtbxCantidad;
        private FlatUI.FlatLabel flatLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCotizar;
        private FlatUI.FlatGroupBox gpbxResenia;
        private FlatUI.FlatLabel lblTotalVen;
        private FlatUI.FlatLabel flatLabel7;
        private FlatUI.FlatLabel lblCantidadF;
        private FlatUI.FlatLabel lblcantiNOO;
        private FlatUI.FlatLabel lblELEtipo;
        private FlatUI.FlatLabel flatLabel4;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatTextBox txtbxID_Cliente;
        private FlatUI.FlatLabel flatLabel8;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnREalVenta;
        private FlatUI.FlatTextBox txtbxDireccion;
        private FlatUI.FlatLabel flatLabel5;
        private FlatUI.FlatLabel flatLabel6;
        private FlatUI.FlatTextBox txtbxID_USER_ONLINE;
    }
}