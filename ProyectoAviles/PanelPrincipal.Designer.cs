namespace ProyectoAviles
{
    partial class PanelPrincipal
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
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPrincipal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.PicAd = new System.Windows.Forms.PictureBox();
            this.lblAdmin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUsers = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PicUs = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAU = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEgresos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConsultas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSesion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblmenu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClSes = new Bunifu.Framework.UI.BunifuImageButton();
            this.PicLog = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUs)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClSes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLog)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Header.Controls.Add(this.bunifuImageButton1);
            this.Header.Controls.Add(this.PicAd);
            this.Header.Controls.Add(this.lblAdmin);
            this.Header.Controls.Add(this.lblUsers);
            this.Header.Controls.Add(this.PicUs);
            this.LogoAnimator.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(787, 46);
            this.Header.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LogoAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(747, -4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(39, 45);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 5;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // PicAd
            // 
            this.PanelAnimator.SetDecoration(this.PicAd, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PicAd, BunifuAnimatorNS.DecorationType.None);
            this.PicAd.Image = ((System.Drawing.Image)(resources.GetObject("PicAd.Image")));
            this.PicAd.Location = new System.Drawing.Point(328, 3);
            this.PicAd.Name = "PicAd";
            this.PicAd.Size = new System.Drawing.Size(50, 41);
            this.PicAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAd.TabIndex = 1;
            this.PicAd.TabStop = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.lblAdmin, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.lblAdmin, BunifuAnimatorNS.DecorationType.None);
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(395, 9);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(94, 29);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "ADMIN";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.lblUsers, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.lblUsers, BunifuAnimatorNS.DecorationType.None);
            this.lblUsers.Enabled = false;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.White;
            this.lblUsers.Location = new System.Drawing.Point(398, 9);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(127, 29);
            this.lblUsers.TabIndex = 2;
            this.lblUsers.Text = "USUARIO";
            this.lblUsers.Click += new System.EventHandler(this.lblUsers_Click);
            // 
            // PicUs
            // 
            this.PanelAnimator.SetDecoration(this.PicUs, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PicUs, BunifuAnimatorNS.DecorationType.None);
            this.PicUs.Enabled = false;
            this.PicUs.Image = ((System.Drawing.Image)(resources.GetObject("PicUs.Image")));
            this.PicUs.Location = new System.Drawing.Point(349, 3);
            this.PicUs.Name = "PicUs";
            this.PicUs.Size = new System.Drawing.Size(43, 40);
            this.PicUs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicUs.TabIndex = 3;
            this.PicUs.TabStop = false;
            this.PicUs.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.btnAU);
            this.panel2.Controls.Add(this.btnEgresos);
            this.panel2.Controls.Add(this.btnConsultas);
            this.panel2.Controls.Add(this.btnVenta);
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Controls.Add(this.btnSesion);
            this.panel2.Controls.Add(this.lblmenu);
            this.panel2.Controls.Add(this.bunifuImageButton2);
            this.panel2.Controls.Add(this.btnClSes);
            this.LogoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 447);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAU
            // 
            this.btnAU.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAU.BorderRadius = 0;
            this.btnAU.ButtonText = "Añadir usuarios";
            this.btnAU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.btnAU, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnAU, BunifuAnimatorNS.DecorationType.None);
            this.btnAU.DisabledColor = System.Drawing.Color.Gray;
            this.btnAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAU.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAU.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAU.Iconimage")));
            this.btnAU.Iconimage_right = null;
            this.btnAU.Iconimage_right_Selected = null;
            this.btnAU.Iconimage_Selected = null;
            this.btnAU.IconMarginLeft = 0;
            this.btnAU.IconMarginRight = 0;
            this.btnAU.IconRightVisible = true;
            this.btnAU.IconRightZoom = 0D;
            this.btnAU.IconVisible = true;
            this.btnAU.IconZoom = 80D;
            this.btnAU.IsTab = false;
            this.btnAU.Location = new System.Drawing.Point(8, 345);
            this.btnAU.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAU.Name = "btnAU";
            this.btnAU.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAU.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAU.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAU.selected = false;
            this.btnAU.Size = new System.Drawing.Size(129, 43);
            this.btnAU.TabIndex = 9;
            this.btnAU.Text = "Añadir usuarios";
            this.btnAU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAU.Textcolor = System.Drawing.Color.White;
            this.btnAU.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAU.Click += new System.EventHandler(this.btnAU_Click);
            // 
            // btnEgresos
            // 
            this.btnEgresos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEgresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEgresos.BorderRadius = 0;
            this.btnEgresos.ButtonText = "Egresos";
            this.btnEgresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.btnEgresos, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnEgresos, BunifuAnimatorNS.DecorationType.None);
            this.btnEgresos.DisabledColor = System.Drawing.Color.Gray;
            this.btnEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgresos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEgresos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEgresos.Iconimage")));
            this.btnEgresos.Iconimage_right = null;
            this.btnEgresos.Iconimage_right_Selected = null;
            this.btnEgresos.Iconimage_Selected = null;
            this.btnEgresos.IconMarginLeft = 0;
            this.btnEgresos.IconMarginRight = 0;
            this.btnEgresos.IconRightVisible = true;
            this.btnEgresos.IconRightZoom = 0D;
            this.btnEgresos.IconVisible = true;
            this.btnEgresos.IconZoom = 100D;
            this.btnEgresos.IsTab = false;
            this.btnEgresos.Location = new System.Drawing.Point(8, 277);
            this.btnEgresos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEgresos.Name = "btnEgresos";
            this.btnEgresos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEgresos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEgresos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEgresos.selected = false;
            this.btnEgresos.Size = new System.Drawing.Size(129, 43);
            this.btnEgresos.TabIndex = 8;
            this.btnEgresos.Text = "Egresos";
            this.btnEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEgresos.Textcolor = System.Drawing.Color.White;
            this.btnEgresos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgresos.Click += new System.EventHandler(this.btnEgresos_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultas.BorderRadius = 0;
            this.btnConsultas.ButtonText = "Consultas";
            this.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.btnConsultas, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnConsultas, BunifuAnimatorNS.DecorationType.None);
            this.btnConsultas.DisabledColor = System.Drawing.Color.Gray;
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConsultas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Iconimage")));
            this.btnConsultas.Iconimage_right = null;
            this.btnConsultas.Iconimage_right_Selected = null;
            this.btnConsultas.Iconimage_Selected = null;
            this.btnConsultas.IconMarginLeft = 0;
            this.btnConsultas.IconMarginRight = 0;
            this.btnConsultas.IconRightVisible = true;
            this.btnConsultas.IconRightZoom = 0D;
            this.btnConsultas.IconVisible = true;
            this.btnConsultas.IconZoom = 75D;
            this.btnConsultas.IsTab = false;
            this.btnConsultas.Location = new System.Drawing.Point(8, 215);
            this.btnConsultas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConsultas.selected = false;
            this.btnConsultas.Size = new System.Drawing.Size(129, 43);
            this.btnConsultas.TabIndex = 7;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConsultas.Textcolor = System.Drawing.Color.White;
            this.btnConsultas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVenta.BorderRadius = 0;
            this.btnVenta.ButtonText = "Ventas";
            this.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.btnVenta, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnVenta, BunifuAnimatorNS.DecorationType.None);
            this.btnVenta.DisabledColor = System.Drawing.Color.Gray;
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVenta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVenta.Iconimage")));
            this.btnVenta.Iconimage_right = null;
            this.btnVenta.Iconimage_right_Selected = null;
            this.btnVenta.Iconimage_Selected = null;
            this.btnVenta.IconMarginLeft = 0;
            this.btnVenta.IconMarginRight = 0;
            this.btnVenta.IconRightVisible = true;
            this.btnVenta.IconRightZoom = 0D;
            this.btnVenta.IconVisible = true;
            this.btnVenta.IconZoom = 85D;
            this.btnVenta.IsTab = false;
            this.btnVenta.Location = new System.Drawing.Point(8, 150);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnVenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnVenta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVenta.selected = false;
            this.btnVenta.Size = new System.Drawing.Size(129, 43);
            this.btnVenta.TabIndex = 6;
            this.btnVenta.Text = "Ventas";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVenta.Textcolor = System.Drawing.Color.White;
            this.btnVenta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 0;
            this.btnClientes.ButtonText = "Clientes";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClientes.Iconimage")));
            this.btnClientes.Iconimage_right = null;
            this.btnClientes.Iconimage_right_Selected = null;
            this.btnClientes.Iconimage_Selected = null;
            this.btnClientes.IconMarginLeft = 0;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 80D;
            this.btnClientes.IsTab = false;
            this.btnClientes.Location = new System.Drawing.Point(8, 84);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(129, 43);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientes.Textcolor = System.Drawing.Color.White;
            this.btnClientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnSesion
            // 
            this.btnSesion.ActiveBorderThickness = 1;
            this.btnSesion.ActiveCornerRadius = 20;
            this.btnSesion.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btnSesion.ActiveForecolor = System.Drawing.Color.White;
            this.btnSesion.ActiveLineColor = System.Drawing.Color.WhiteSmoke;
            this.btnSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSesion.BackgroundImage")));
            this.btnSesion.ButtonText = "Cerrar sesion";
            this.btnSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.btnSesion, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnSesion, BunifuAnimatorNS.DecorationType.None);
            this.btnSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesion.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSesion.IdleBorderThickness = 1;
            this.btnSesion.IdleCornerRadius = 20;
            this.btnSesion.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSesion.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnSesion.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSesion.Location = new System.Drawing.Point(16, 412);
            this.btnSesion.Margin = new System.Windows.Forms.Padding(5);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(123, 35);
            this.btnSesion.TabIndex = 4;
            this.btnSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // lblmenu
            // 
            this.lblmenu.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.lblmenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.lblmenu, BunifuAnimatorNS.DecorationType.None);
            this.lblmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblmenu.ForeColor = System.Drawing.Color.White;
            this.lblmenu.Location = new System.Drawing.Point(39, 39);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(88, 29);
            this.lblmenu.TabIndex = 3;
            this.lblmenu.Text = "MENU";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(10, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(38, 35);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btnClSes
            // 
            this.btnClSes.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.btnClSes, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnClSes, BunifuAnimatorNS.DecorationType.None);
            this.btnClSes.Image = ((System.Drawing.Image)(resources.GetObject("btnClSes.Image")));
            this.btnClSes.ImageActive = null;
            this.btnClSes.Location = new System.Drawing.Point(9, 403);
            this.btnClSes.Name = "btnClSes";
            this.btnClSes.Size = new System.Drawing.Size(42, 44);
            this.btnClSes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClSes.TabIndex = 10;
            this.btnClSes.TabStop = false;
            this.btnClSes.Zoom = 10;
            this.btnClSes.Click += new System.EventHandler(this.btnClSes_Click);
            // 
            // PicLog
            // 
            this.PanelAnimator.SetDecoration(this.PicLog, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PicLog, BunifuAnimatorNS.DecorationType.None);
            this.PicLog.Image = ((System.Drawing.Image)(resources.GetObject("PicLog.Image")));
            this.PicLog.Location = new System.Drawing.Point(158, 42);
            this.PicLog.Name = "PicLog";
            this.PicLog.Size = new System.Drawing.Size(629, 451);
            this.PicLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLog.TabIndex = 2;
            this.PicLog.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimator.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation8;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.LogoAnimator.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(50);
            animation7.RotateCoeff = 1F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 1F;
            this.LogoAnimator.DefaultAnimation = animation7;
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(787, 493);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.PicLog);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelPrincipal";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClSes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox PicLog;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public Bunifu.Framework.UI.BunifuCustomLabel lblAdmin;
        public System.Windows.Forms.PictureBox PicAd;
        private Bunifu.Framework.UI.BunifuCustomLabel lblmenu;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSesion;
        public Bunifu.Framework.UI.BunifuCustomLabel lblUsers;
        public System.Windows.Forms.PictureBox PicUs;
        private Bunifu.Framework.UI.BunifuFlatButton btnVenta;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnAU;
        private Bunifu.Framework.UI.BunifuFlatButton btnEgresos;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultas;
        private Bunifu.Framework.UI.BunifuImageButton btnClSes;
    }
}