namespace ProyectoAviles
{
    partial class Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnBuscar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnVentas = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCerrarAll = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.lblID_US = new FlatUI.FlatLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtbxNOMBRE_CLIENTE_ADD = new FlatUI.FlatTextBox();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.txtbxTELEFONO = new FlatUI.FlatTextBox();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.pnlSeacrh = new System.Windows.Forms.Panel();
            this.dtgvNOMBRE_CLIENTE_BUSCAR = new System.Windows.Forms.DataGridView();
            this.btnNOMBRE_CLIENTE_BUSCAR = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtbxNOMBRE_CLIENTE_BUSCAR = new FlatUI.FlatTextBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.pnlID_ELI = new System.Windows.Forms.Panel();
            this.dtgwEliminar = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.flatLabel5 = new FlatUI.FlatLabel();
            this.btnACTUAL = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtbxID_ELIMINAR = new System.Windows.Forms.TextBox();
            this.pnlAgregar.SuspendLayout();
            this.pnlSeacrh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNOMBRE_CLIENTE_BUSCAR)).BeginInit();
            this.pnlID_ELI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwEliminar)).BeginInit();
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
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.color = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.colorActive = System.Drawing.Color.SkyBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImagePosition = 21;
            this.btnBuscar.ImageZoom = 50;
            this.btnBuscar.LabelPosition = 43;
            this.btnBuscar.LabelText = "Buscar";
            this.btnBuscar.Location = new System.Drawing.Point(16, 13);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 126);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.color = System.Drawing.Color.SeaGreen;
            this.btnAdd.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImagePosition = 21;
            this.btnAdd.ImageZoom = 45;
            this.btnAdd.LabelPosition = 43;
            this.btnAdd.LabelText = "Agregar";
            this.btnAdd.Location = new System.Drawing.Point(16, 164);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 126);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnDelete.color = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnDelete.colorActive = System.Drawing.Color.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImagePosition = 21;
            this.btnDelete.ImageZoom = 45;
            this.btnDelete.LabelPosition = 43;
            this.btnDelete.LabelText = "Eliminar";
            this.btnDelete.Location = new System.Drawing.Point(16, 311);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 126);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.ActiveBorderThickness = 1;
            this.btnCerrar.ActiveCornerRadius = 20;
            this.btnCerrar.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnCerrar.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnCerrar.ActiveLineColor = System.Drawing.Color.White;
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.ButtonText = "Cerrar";
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCerrar.IdleBorderThickness = 1;
            this.btnCerrar.IdleCornerRadius = 20;
            this.btnCerrar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnCerrar.IdleForecolor = System.Drawing.Color.White;
            this.btnCerrar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCerrar.Location = new System.Drawing.Point(195, 403);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(166, 48);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.ActiveBorderThickness = 1;
            this.btnVentas.ActiveCornerRadius = 20;
            this.btnVentas.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnVentas.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnVentas.ActiveLineColor = System.Drawing.Color.White;
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVentas.BackgroundImage")));
            this.btnVentas.ButtonText = "Realizar venta";
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnVentas.IdleBorderThickness = 1;
            this.btnVentas.IdleCornerRadius = 20;
            this.btnVentas.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnVentas.IdleForecolor = System.Drawing.Color.White;
            this.btnVentas.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnVentas.Location = new System.Drawing.Point(549, 403);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(5);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(166, 48);
            this.btnVentas.TabIndex = 9;
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCerrarAll
            // 
            this.btnCerrarAll.ActiveBorderThickness = 1;
            this.btnCerrarAll.ActiveCornerRadius = 20;
            this.btnCerrarAll.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnCerrarAll.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnCerrarAll.ActiveLineColor = System.Drawing.Color.White;
            this.btnCerrarAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCerrarAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarAll.BackgroundImage")));
            this.btnCerrarAll.ButtonText = "Cerrar";
            this.btnCerrarAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarAll.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCerrarAll.IdleBorderThickness = 1;
            this.btnCerrarAll.IdleCornerRadius = 20;
            this.btnCerrarAll.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnCerrarAll.IdleForecolor = System.Drawing.Color.White;
            this.btnCerrarAll.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCerrarAll.Location = new System.Drawing.Point(373, 403);
            this.btnCerrarAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnCerrarAll.Name = "btnCerrarAll";
            this.btnCerrarAll.Size = new System.Drawing.Size(166, 48);
            this.btnCerrarAll.TabIndex = 10;
            this.btnCerrarAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrarAll.Click += new System.EventHandler(this.btnCerrarAll_Click);
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.Controls.Add(this.lblID_US);
            this.pnlAgregar.Controls.Add(this.bunifuThinButton21);
            this.pnlAgregar.Controls.Add(this.txtbxNOMBRE_CLIENTE_ADD);
            this.pnlAgregar.Controls.Add(this.flatLabel4);
            this.pnlAgregar.Controls.Add(this.txtbxTELEFONO);
            this.pnlAgregar.Controls.Add(this.flatLabel3);
            this.pnlAgregar.Controls.Add(this.flatLabel2);
            this.pnlAgregar.Location = new System.Drawing.Point(156, 22);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(603, 360);
            this.pnlAgregar.TabIndex = 10;
            // 
            // lblID_US
            // 
            this.lblID_US.AutoSize = true;
            this.lblID_US.BackColor = System.Drawing.Color.Transparent;
            this.lblID_US.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_US.ForeColor = System.Drawing.Color.White;
            this.lblID_US.Location = new System.Drawing.Point(147, 47);
            this.lblID_US.Name = "lblID_US";
            this.lblID_US.Size = new System.Drawing.Size(0, 25);
            this.lblID_US.TabIndex = 17;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Agregar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(207, 265);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(166, 48);
            this.bunifuThinButton21.TabIndex = 16;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // txtbxNOMBRE_CLIENTE_ADD
            // 
            this.txtbxNOMBRE_CLIENTE_ADD.BackColor = System.Drawing.Color.Transparent;
            this.txtbxNOMBRE_CLIENTE_ADD.FocusOnHover = false;
            this.txtbxNOMBRE_CLIENTE_ADD.Location = new System.Drawing.Point(221, 165);
            this.txtbxNOMBRE_CLIENTE_ADD.MaxLength = 32767;
            this.txtbxNOMBRE_CLIENTE_ADD.Multiline = false;
            this.txtbxNOMBRE_CLIENTE_ADD.Name = "txtbxNOMBRE_CLIENTE_ADD";
            this.txtbxNOMBRE_CLIENTE_ADD.ReadOnly = false;
            this.txtbxNOMBRE_CLIENTE_ADD.Size = new System.Drawing.Size(348, 29);
            this.txtbxNOMBRE_CLIENTE_ADD.TabIndex = 15;
            this.txtbxNOMBRE_CLIENTE_ADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbxNOMBRE_CLIENTE_ADD.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtbxNOMBRE_CLIENTE_ADD.UseSystemPasswordChar = false;
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(34, 169);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(181, 25);
            this.flatLabel4.TabIndex = 14;
            this.flatLabel4.Text = "Nombre del cliente:";
            // 
            // txtbxTELEFONO
            // 
            this.txtbxTELEFONO.BackColor = System.Drawing.Color.Transparent;
            this.txtbxTELEFONO.FocusOnHover = false;
            this.txtbxTELEFONO.Location = new System.Drawing.Point(154, 109);
            this.txtbxTELEFONO.MaxLength = 32767;
            this.txtbxTELEFONO.Multiline = false;
            this.txtbxTELEFONO.Name = "txtbxTELEFONO";
            this.txtbxTELEFONO.ReadOnly = false;
            this.txtbxTELEFONO.Size = new System.Drawing.Size(181, 29);
            this.txtbxTELEFONO.TabIndex = 13;
            this.txtbxTELEFONO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbxTELEFONO.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtbxTELEFONO.UseSystemPasswordChar = false;
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(34, 113);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(90, 25);
            this.flatLabel3.TabIndex = 12;
            this.flatLabel3.Text = "Telefono:";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(34, 47);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(107, 25);
            this.flatLabel2.TabIndex = 10;
            this.flatLabel2.Text = "ID Usuario:";
            // 
            // pnlSeacrh
            // 
            this.pnlSeacrh.Controls.Add(this.dtgvNOMBRE_CLIENTE_BUSCAR);
            this.pnlSeacrh.Controls.Add(this.btnNOMBRE_CLIENTE_BUSCAR);
            this.pnlSeacrh.Controls.Add(this.txtbxNOMBRE_CLIENTE_BUSCAR);
            this.pnlSeacrh.Controls.Add(this.flatLabel1);
            this.pnlSeacrh.Location = new System.Drawing.Point(160, 3);
            this.pnlSeacrh.Name = "pnlSeacrh";
            this.pnlSeacrh.Size = new System.Drawing.Size(596, 379);
            this.pnlSeacrh.TabIndex = 11;
            // 
            // dtgvNOMBRE_CLIENTE_BUSCAR
            // 
            this.dtgvNOMBRE_CLIENTE_BUSCAR.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvNOMBRE_CLIENTE_BUSCAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNOMBRE_CLIENTE_BUSCAR.GridColor = System.Drawing.Color.White;
            this.dtgvNOMBRE_CLIENTE_BUSCAR.Location = new System.Drawing.Point(35, 163);
            this.dtgvNOMBRE_CLIENTE_BUSCAR.Name = "dtgvNOMBRE_CLIENTE_BUSCAR";
            this.dtgvNOMBRE_CLIENTE_BUSCAR.Size = new System.Drawing.Size(520, 150);
            this.dtgvNOMBRE_CLIENTE_BUSCAR.TabIndex = 14;
            // 
            // btnNOMBRE_CLIENTE_BUSCAR
            // 
            this.btnNOMBRE_CLIENTE_BUSCAR.ActiveBorderThickness = 1;
            this.btnNOMBRE_CLIENTE_BUSCAR.ActiveCornerRadius = 20;
            this.btnNOMBRE_CLIENTE_BUSCAR.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnNOMBRE_CLIENTE_BUSCAR.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.btnNOMBRE_CLIENTE_BUSCAR.ActiveLineColor = System.Drawing.Color.White;
            this.btnNOMBRE_CLIENTE_BUSCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnNOMBRE_CLIENTE_BUSCAR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNOMBRE_CLIENTE_BUSCAR.BackgroundImage")));
            this.btnNOMBRE_CLIENTE_BUSCAR.ButtonText = "Buscar";
            this.btnNOMBRE_CLIENTE_BUSCAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNOMBRE_CLIENTE_BUSCAR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNOMBRE_CLIENTE_BUSCAR.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNOMBRE_CLIENTE_BUSCAR.IdleBorderThickness = 1;
            this.btnNOMBRE_CLIENTE_BUSCAR.IdleCornerRadius = 20;
            this.btnNOMBRE_CLIENTE_BUSCAR.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnNOMBRE_CLIENTE_BUSCAR.IdleForecolor = System.Drawing.Color.White;
            this.btnNOMBRE_CLIENTE_BUSCAR.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.btnNOMBRE_CLIENTE_BUSCAR.Location = new System.Drawing.Point(230, 89);
            this.btnNOMBRE_CLIENTE_BUSCAR.Margin = new System.Windows.Forms.Padding(5);
            this.btnNOMBRE_CLIENTE_BUSCAR.Name = "btnNOMBRE_CLIENTE_BUSCAR";
            this.btnNOMBRE_CLIENTE_BUSCAR.Size = new System.Drawing.Size(140, 48);
            this.btnNOMBRE_CLIENTE_BUSCAR.TabIndex = 13;
            this.btnNOMBRE_CLIENTE_BUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNOMBRE_CLIENTE_BUSCAR.Click += new System.EventHandler(this.btnNOMBRE_CLIENTE_BUSCAR_Click);
            // 
            // txtbxNOMBRE_CLIENTE_BUSCAR
            // 
            this.txtbxNOMBRE_CLIENTE_BUSCAR.BackColor = System.Drawing.Color.Transparent;
            this.txtbxNOMBRE_CLIENTE_BUSCAR.FocusOnHover = false;
            this.txtbxNOMBRE_CLIENTE_BUSCAR.Location = new System.Drawing.Point(218, 52);
            this.txtbxNOMBRE_CLIENTE_BUSCAR.MaxLength = 32767;
            this.txtbxNOMBRE_CLIENTE_BUSCAR.Multiline = false;
            this.txtbxNOMBRE_CLIENTE_BUSCAR.Name = "txtbxNOMBRE_CLIENTE_BUSCAR";
            this.txtbxNOMBRE_CLIENTE_BUSCAR.ReadOnly = false;
            this.txtbxNOMBRE_CLIENTE_BUSCAR.Size = new System.Drawing.Size(348, 29);
            this.txtbxNOMBRE_CLIENTE_BUSCAR.TabIndex = 11;
            this.txtbxNOMBRE_CLIENTE_BUSCAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbxNOMBRE_CLIENTE_BUSCAR.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtbxNOMBRE_CLIENTE_BUSCAR.UseSystemPasswordChar = false;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(31, 56);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(181, 25);
            this.flatLabel1.TabIndex = 10;
            this.flatLabel1.Text = "Nombre del cliente:";
            // 
            // pnlID_ELI
            // 
            this.pnlID_ELI.Controls.Add(this.txtbxID_ELIMINAR);
            this.pnlID_ELI.Controls.Add(this.btnACTUAL);
            this.pnlID_ELI.Controls.Add(this.dtgwEliminar);
            this.pnlID_ELI.Controls.Add(this.bunifuThinButton22);
            this.pnlID_ELI.Controls.Add(this.flatLabel5);
            this.pnlID_ELI.Location = new System.Drawing.Point(151, 17);
            this.pnlID_ELI.Name = "pnlID_ELI";
            this.pnlID_ELI.Size = new System.Drawing.Size(651, 381);
            this.pnlID_ELI.TabIndex = 13;
            // 
            // dtgwEliminar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgwEliminar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgwEliminar.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgwEliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgwEliminar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgwEliminar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgwEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwEliminar.DoubleBuffered = true;
            this.dtgwEliminar.EnableHeadersVisualStyles = false;
            this.dtgwEliminar.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgwEliminar.HeaderForeColor = System.Drawing.Color.White;
            this.dtgwEliminar.Location = new System.Drawing.Point(86, 107);
            this.dtgwEliminar.Name = "dtgwEliminar";
            this.dtgwEliminar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgwEliminar.Size = new System.Drawing.Size(489, 222);
            this.dtgwEliminar.TabIndex = 18;
            this.dtgwEliminar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgwEliminar_CellContentClick);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Eliminar";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(246, 54);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(166, 48);
            this.bunifuThinButton22.TabIndex = 17;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click_1);
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(210, 14);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(37, 25);
            this.flatLabel5.TabIndex = 14;
            this.flatLabel5.Text = "ID:";
            // 
            // btnACTUAL
            // 
            this.btnACTUAL.ActiveBorderThickness = 1;
            this.btnACTUAL.ActiveCornerRadius = 20;
            this.btnACTUAL.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnACTUAL.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnACTUAL.ActiveLineColor = System.Drawing.Color.White;
            this.btnACTUAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnACTUAL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnACTUAL.BackgroundImage")));
            this.btnACTUAL.ButtonText = "Actualizar lista";
            this.btnACTUAL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnACTUAL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACTUAL.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnACTUAL.IdleBorderThickness = 1;
            this.btnACTUAL.IdleCornerRadius = 20;
            this.btnACTUAL.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnACTUAL.IdleForecolor = System.Drawing.Color.White;
            this.btnACTUAL.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnACTUAL.Location = new System.Drawing.Point(246, 328);
            this.btnACTUAL.Margin = new System.Windows.Forms.Padding(5);
            this.btnACTUAL.Name = "btnACTUAL";
            this.btnACTUAL.Size = new System.Drawing.Size(166, 48);
            this.btnACTUAL.TabIndex = 19;
            this.btnACTUAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnACTUAL.Click += new System.EventHandler(this.btnACTUAL_Click);
            // 
            // txtbxID_ELIMINAR
            // 
            this.txtbxID_ELIMINAR.Location = new System.Drawing.Point(252, 17);
            this.txtbxID_ELIMINAR.Name = "txtbxID_ELIMINAR";
            this.txtbxID_ELIMINAR.Size = new System.Drawing.Size(160, 20);
            this.txtbxID_ELIMINAR.TabIndex = 20;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(771, 454);
            this.Controls.Add(this.pnlID_ELI);
            this.Controls.Add(this.btnCerrarAll);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pnlAgregar);
            this.Controls.Add(this.pnlSeacrh);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.pnlAgregar.ResumeLayout(false);
            this.pnlAgregar.PerformLayout();
            this.pnlSeacrh.ResumeLayout(false);
            this.pnlSeacrh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNOMBRE_CLIENTE_BUSCAR)).EndInit();
            this.pnlID_ELI.ResumeLayout(false);
            this.pnlID_ELI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwEliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuTileButton btnBuscar;
        private Bunifu.Framework.UI.BunifuTileButton btnDelete;
        private Bunifu.Framework.UI.BunifuTileButton btnAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnVentas;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCerrar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCerrarAll;
        private System.Windows.Forms.Panel pnlSeacrh;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNOMBRE_CLIENTE_BUSCAR;
        private FlatUI.FlatTextBox txtbxNOMBRE_CLIENTE_BUSCAR;
        private FlatUI.FlatLabel flatLabel1;
        private System.Windows.Forms.Panel pnlAgregar;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private FlatUI.FlatTextBox txtbxNOMBRE_CLIENTE_ADD;
        private FlatUI.FlatLabel flatLabel4;
        private FlatUI.FlatTextBox txtbxTELEFONO;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatLabel flatLabel2;
        private System.Windows.Forms.DataGridView dtgvNOMBRE_CLIENTE_BUSCAR;
        private FlatUI.FlatLabel lblID_US;
        private System.Windows.Forms.Panel pnlID_ELI;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private FlatUI.FlatLabel flatLabel5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgwEliminar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnACTUAL;
        private System.Windows.Forms.TextBox txtbxID_ELIMINAR;
    }
}