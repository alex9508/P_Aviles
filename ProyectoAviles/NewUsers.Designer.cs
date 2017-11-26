namespace ProyectoAviles
{
    partial class NewUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUsers));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnAdd = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbxNombre = new FlatUI.FlatTextBox();
            this.flatLabel8 = new FlatUI.FlatLabel();
            this.txtbxUsuario = new FlatUI.FlatTextBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.txtbxContrasenia = new FlatUI.FlatTextBox();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.cmbbxTIPO = new System.Windows.Forms.ComboBox();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtgwUSERS = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwUSERS)).BeginInit();
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
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
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
            this.btnAdd.ImageZoom = 50;
            this.btnAdd.LabelPosition = 43;
            this.btnAdd.LabelText = "Agregar";
            this.btnAdd.Location = new System.Drawing.Point(16, 313);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 126);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnBuscar.LabelText = "Mostrar";
            this.btnBuscar.Location = new System.Drawing.Point(16, 69);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 126);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 49);
            this.panel1.TabIndex = 12;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(705, -1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(76, 48);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 13;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.flatLabel3);
            this.panel2.Controls.Add(this.cmbbxTIPO);
            this.panel2.Controls.Add(this.txtbxContrasenia);
            this.panel2.Controls.Add(this.flatLabel2);
            this.panel2.Controls.Add(this.txtbxUsuario);
            this.panel2.Controls.Add(this.flatLabel1);
            this.panel2.Controls.Add(this.txtbxNombre);
            this.panel2.Controls.Add(this.flatLabel8);
            this.panel2.Location = new System.Drawing.Point(197, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 314);
            this.panel2.TabIndex = 13;
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txtbxNombre.FocusOnHover = false;
            this.txtbxNombre.Location = new System.Drawing.Point(179, 45);
            this.txtbxNombre.MaxLength = 32767;
            this.txtbxNombre.Multiline = false;
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.ReadOnly = false;
            this.txtbxNombre.Size = new System.Drawing.Size(270, 29);
            this.txtbxNombre.TabIndex = 35;
            this.txtbxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbxNombre.TextColor = System.Drawing.Color.White;
            this.txtbxNombre.UseSystemPasswordChar = false;
            // 
            // flatLabel8
            // 
            this.flatLabel8.AutoSize = true;
            this.flatLabel8.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel8.ForeColor = System.Drawing.Color.White;
            this.flatLabel8.Location = new System.Drawing.Point(85, 49);
            this.flatLabel8.Name = "flatLabel8";
            this.flatLabel8.Size = new System.Drawing.Size(88, 25);
            this.flatLabel8.TabIndex = 34;
            this.flatLabel8.Text = "Nombre:";
            // 
            // txtbxUsuario
            // 
            this.txtbxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txtbxUsuario.FocusOnHover = false;
            this.txtbxUsuario.Location = new System.Drawing.Point(179, 86);
            this.txtbxUsuario.MaxLength = 32767;
            this.txtbxUsuario.Multiline = false;
            this.txtbxUsuario.Name = "txtbxUsuario";
            this.txtbxUsuario.ReadOnly = false;
            this.txtbxUsuario.Size = new System.Drawing.Size(270, 29);
            this.txtbxUsuario.TabIndex = 37;
            this.txtbxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbxUsuario.TextColor = System.Drawing.Color.White;
            this.txtbxUsuario.UseSystemPasswordChar = false;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(85, 90);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(82, 25);
            this.flatLabel1.TabIndex = 36;
            this.flatLabel1.Text = "Usuario:";
            // 
            // txtbxContrasenia
            // 
            this.txtbxContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txtbxContrasenia.FocusOnHover = false;
            this.txtbxContrasenia.Location = new System.Drawing.Point(205, 127);
            this.txtbxContrasenia.MaxLength = 32767;
            this.txtbxContrasenia.Multiline = false;
            this.txtbxContrasenia.Name = "txtbxContrasenia";
            this.txtbxContrasenia.ReadOnly = false;
            this.txtbxContrasenia.Size = new System.Drawing.Size(244, 29);
            this.txtbxContrasenia.TabIndex = 39;
            this.txtbxContrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbxContrasenia.TextColor = System.Drawing.Color.White;
            this.txtbxContrasenia.UseSystemPasswordChar = false;
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(85, 131);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(114, 25);
            this.flatLabel2.TabIndex = 38;
            this.flatLabel2.Text = "Contraseña:";
            // 
            // cmbbxTIPO
            // 
            this.cmbbxTIPO.FormattingEnabled = true;
            this.cmbbxTIPO.Items.AddRange(new object[] {
            "Admin",
            "Usuario"});
            this.cmbbxTIPO.Location = new System.Drawing.Point(239, 175);
            this.cmbbxTIPO.Name = "cmbbxTIPO";
            this.cmbbxTIPO.Size = new System.Drawing.Size(210, 21);
            this.cmbbxTIPO.TabIndex = 40;
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(85, 171);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(148, 25);
            this.flatLabel3.TabIndex = 41;
            this.flatLabel3.Text = "Tipo de usuario:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.ActiveBorderThickness = 1;
            this.btnAgregar.ActiveCornerRadius = 20;
            this.btnAgregar.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnAgregar.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.ActiveLineColor = System.Drawing.Color.White;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.ButtonText = "Agregar";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.IdleBorderThickness = 1;
            this.btnAgregar.IdleCornerRadius = 20;
            this.btnAgregar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAgregar.IdleForecolor = System.Drawing.Color.White;
            this.btnAgregar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.Location = new System.Drawing.Point(196, 233);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(166, 48);
            this.btnAgregar.TabIndex = 42;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtgwUSERS
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgwUSERS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgwUSERS.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgwUSERS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgwUSERS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgwUSERS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgwUSERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwUSERS.DoubleBuffered = true;
            this.dtgwUSERS.EnableHeadersVisualStyles = false;
            this.dtgwUSERS.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgwUSERS.HeaderForeColor = System.Drawing.Color.White;
            this.dtgwUSERS.Location = new System.Drawing.Point(158, 117);
            this.dtgwUSERS.Name = "dtgwUSERS";
            this.dtgwUSERS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgwUSERS.Size = new System.Drawing.Size(577, 248);
            this.dtgwUSERS.TabIndex = 14;
            // 
            // NewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(771, 454);
            this.Controls.Add(this.dtgwUSERS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUsers";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwUSERS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuTileButton btnAdd;
        private Bunifu.Framework.UI.BunifuTileButton btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel2;
        private FlatUI.FlatLabel flatLabel3;
        private System.Windows.Forms.ComboBox cmbbxTIPO;
        private FlatUI.FlatTextBox txtbxContrasenia;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatTextBox txtbxUsuario;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatTextBox txtbxNombre;
        private FlatUI.FlatLabel flatLabel8;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgwUSERS;
    }
}