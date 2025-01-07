namespace TarotApp
{
    partial class ThongTinUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinUser));
            this.picBackGround = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNamSinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCungHoangDao = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackGround
            // 
            this.picBackGround.Image = ((System.Drawing.Image)(resources.GetObject("picBackGround.Image")));
            this.picBackGround.ImageRotate = 0F;
            this.picBackGround.Location = new System.Drawing.Point(-13, -1);
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.Size = new System.Drawing.Size(416, 354);
            this.picBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackGround.TabIndex = 0;
            this.picBackGround.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.picBackGround;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHoTen.BorderThickness = 3;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "Nhập Họ Tên";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.SystemColors.Info;
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(55, 131);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(312, 30);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            this.txtHoTen.Enter += new System.EventHandler(this.txtHoTen_Enter_1);
            this.txtHoTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoTen_KeyDown_1);
            this.txtHoTen.Leave += new System.EventHandler(this.txtHoTen_Leave_1);
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNamSinh.BorderThickness = 3;
            this.txtNamSinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamSinh.DefaultText = "Nhập Năm Sinh";
            this.txtNamSinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamSinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamSinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamSinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamSinh.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNamSinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamSinh.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSinh.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNamSinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamSinh.Location = new System.Drawing.Point(55, 192);
            this.txtNamSinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.PasswordChar = '\0';
            this.txtNamSinh.PlaceholderText = "";
            this.txtNamSinh.SelectedText = "";
            this.txtNamSinh.Size = new System.Drawing.Size(312, 30);
            this.txtNamSinh.TabIndex = 1;
            this.txtNamSinh.TextChanged += new System.EventHandler(this.txtNamSinh_TextChanged);
            this.txtNamSinh.Enter += new System.EventHandler(this.txtNamSinh_Enter_1);
            this.txtNamSinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNamSinh_KeyDown);
            this.txtNamSinh.Leave += new System.EventHandler(this.txtNamSinh_Leave_1);
            // 
            // txtCungHoangDao
            // 
            this.txtCungHoangDao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCungHoangDao.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCungHoangDao.BorderThickness = 3;
            this.txtCungHoangDao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCungHoangDao.DefaultText = "Nhập Cung Hoàng Đạo";
            this.txtCungHoangDao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCungHoangDao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCungHoangDao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCungHoangDao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCungHoangDao.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCungHoangDao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCungHoangDao.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCungHoangDao.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCungHoangDao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCungHoangDao.Location = new System.Drawing.Point(55, 260);
            this.txtCungHoangDao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCungHoangDao.Name = "txtCungHoangDao";
            this.txtCungHoangDao.PasswordChar = '\0';
            this.txtCungHoangDao.PlaceholderText = "";
            this.txtCungHoangDao.SelectedText = "";
            this.txtCungHoangDao.Size = new System.Drawing.Size(312, 30);
            this.txtCungHoangDao.TabIndex = 1;
            this.txtCungHoangDao.TextChanged += new System.EventHandler(this.txtCungHoangDao_TextChanged);
            this.txtCungHoangDao.Enter += new System.EventHandler(this.txtCungHoangDao_Enter_1);
            this.txtCungHoangDao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCungHoangDao_KeyDown);
            this.txtCungHoangDao.Leave += new System.EventHandler(this.txtCungHoangDao_Leave_1);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2HtmlLabel1.BackgroundImage")));
            this.guna2HtmlLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Info;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(92, 81);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(214, 33);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Thông Tin Người Dùng";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.picBackGround;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this;
            // 
            // ThongTinUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 352);
            this.Controls.Add(this.txtCungHoangDao);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.picBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongTinUser";
            this.Text = "ThongTinUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThongTinUser_FormClosed);
            this.Load += new System.EventHandler(this.ThongTinUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picBackGround;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtNamSinh;
        private Guna.UI2.WinForms.Guna2TextBox txtCungHoangDao;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}