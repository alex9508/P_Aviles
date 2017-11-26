namespace ProyectoAviles
{
    partial class Egresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Egresos));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnAdd = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtbxMonto = new FlatUI.FlatTextBox();
            this.flatLabel5 = new FlatUI.FlatLabel();
            this.txtbxDescripcion = new FlatUI.FlatTextBox();
            this.flatLabel8 = new FlatUI.FlatLabel();
            this.lblID_USER_ONLINE = new FlatUI.FlatLabel();
            this.flatLabel6 = new FlatUI.FlatLabel();
            this.dtgwEgresos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwEgresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.bunifuDragControl1.TargetControl = this.panel2;
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
            this.btnAdd.ImageZoom = 55;
            this.btnAdd.LabelPosition = 43;
            this.btnAdd.LabelText = "Agregar";
            this.btnAdd.Location = new System.Drawing.Point(16, 313);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 126);
            this.btnAdd.TabIndex = 8;
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
            this.btnBuscar.ImageZoom = 55;
            this.btnBuscar.LabelPosition = 43;
            this.btnBuscar.LabelText = "Mostrar";
            this.btnBuscar.Location = new System.Drawing.Point(16, 69);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 126);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuThinButton21);
            this.panel3.Controls.Add(this.txtbxMonto);
            this.panel3.Controls.Add(this.flatLabel5);
            this.panel3.Controls.Add(this.txtbxDescripcion);
            this.panel3.Controls.Add(this.flatLabel8);
            this.panel3.Controls.Add(this.lblID_USER_ONLINE);
            this.panel3.Controls.Add(this.flatLabel6);
            this.panel3.Location = new System.Drawing.Point(175, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 260);
            this.panel3.TabIndex = 11;
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(197, 206);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(166, 48);
            this.bunifuThinButton21.TabIndex = 36;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // txtbxMonto
            // 
            this.txtbxMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txtbxMonto.FocusOnHover = false;
            this.txtbxMonto.Location = new System.Drawing.Point(181, 153);
            this.txtbxMonto.MaxLength = 32767;
            this.txtbxMonto.Multiline = false;
            this.txtbxMonto.Name = "txtbxMonto";
            this.txtbxMonto.ReadOnly = false;
            this.txtbxMonto.Size = new System.Drawing.Size(284, 29);
            this.txtbxMonto.TabIndex = 35;
            this.txtbxMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbxMonto.TextColor = System.Drawing.Color.White;
            this.txtbxMonto.UseSystemPasswordChar = false;
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(100, 157);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(75, 25);
            this.flatLabel5.TabIndex = 34;
            this.flatLabel5.Text = "Monto:";
            // 
            // txtbxDescripcion
            // 
            this.txtbxDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txtbxDescripcion.FocusOnHover = false;
            this.txtbxDescripcion.Location = new System.Drawing.Point(223, 80);
            this.txtbxDescripcion.MaxLength = 32767;
            this.txtbxDescripcion.Multiline = false;
            this.txtbxDescripcion.Name = "txtbxDescripcion";
            this.txtbxDescripcion.ReadOnly = false;
            this.txtbxDescripcion.Size = new System.Drawing.Size(242, 29);
            this.txtbxDescripcion.TabIndex = 33;
            this.txtbxDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbxDescripcion.TextColor = System.Drawing.Color.White;
            this.txtbxDescripcion.UseSystemPasswordChar = false;
            // 
            // flatLabel8
            // 
            this.flatLabel8.AutoSize = true;
            this.flatLabel8.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel8.ForeColor = System.Drawing.Color.White;
            this.flatLabel8.Location = new System.Drawing.Point(100, 84);
            this.flatLabel8.Name = "flatLabel8";
            this.flatLabel8.Size = new System.Drawing.Size(117, 25);
            this.flatLabel8.TabIndex = 32;
            this.flatLabel8.Text = "Descripcion:";
            // 
            // lblID_USER_ONLINE
            // 
            this.lblID_USER_ONLINE.AutoSize = true;
            this.lblID_USER_ONLINE.BackColor = System.Drawing.Color.Transparent;
            this.lblID_USER_ONLINE.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_USER_ONLINE.ForeColor = System.Drawing.Color.White;
            this.lblID_USER_ONLINE.Location = new System.Drawing.Point(131, 16);
            this.lblID_USER_ONLINE.Name = "lblID_USER_ONLINE";
            this.lblID_USER_ONLINE.Size = new System.Drawing.Size(0, 25);
            this.lblID_USER_ONLINE.TabIndex = 31;
            // 
            // flatLabel6
            // 
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel6.ForeColor = System.Drawing.Color.White;
            this.flatLabel6.Location = new System.Drawing.Point(13, 15);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(123, 25);
            this.flatLabel6.TabIndex = 30;
            this.flatLabel6.Text = "ID USUARIO:";
            // 
            // dtgwEgresos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgwEgresos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgwEgresos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgwEgresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgwEgresos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgwEgresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgwEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwEgresos.DoubleBuffered = true;
            this.dtgwEgresos.EnableHeadersVisualStyles = false;
            this.dtgwEgresos.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgwEgresos.HeaderForeColor = System.Drawing.Color.White;
            this.dtgwEgresos.Location = new System.Drawing.Point(170, 79);
            this.dtgwEgresos.Name = "dtgwEgresos";
            this.dtgwEgresos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgwEgresos.Size = new System.Drawing.Size(572, 350);
            this.dtgwEgresos.TabIndex = 12;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(707, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(76, 52);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 52);
            this.panel2.TabIndex = 10;
            // 
            // Egresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(771, 454);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtgwEgresos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBuscar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Egresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egresos";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwEgresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuTileButton btnAdd;
        private Bunifu.Framework.UI.BunifuTileButton btnBuscar;
        private System.Windows.Forms.Panel panel3;
        private FlatUI.FlatTextBox txtbxMonto;
        private FlatUI.FlatLabel flatLabel5;
        private FlatUI.FlatTextBox txtbxDescripcion;
        private FlatUI.FlatLabel flatLabel8;
        private FlatUI.FlatLabel lblID_USER_ONLINE;
        private FlatUI.FlatLabel flatLabel6;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgwEgresos;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}