namespace TarotApp
{
    partial class frmTarot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarot));
            this.picBackground = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnChucNang = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.BoBaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LichSuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.ThoatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.cmbTheme = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnBatDau = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBackground
            // 
            this.picBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBackground.Image")));
            this.picBackground.ImageRotate = 0F;
            this.picBackground.Location = new System.Drawing.Point(-34, 0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(1136, 609);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 0;
            this.picBackground.TabStop = false;
            // 
            // btnChucNang
            // 
            this.btnChucNang.Animated = true;
            this.btnChucNang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChucNang.BackgroundImage")));
            this.btnChucNang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChucNang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChucNang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChucNang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChucNang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChucNang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChucNang.FillColor = System.Drawing.Color.Transparent;
            this.btnChucNang.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChucNang.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnChucNang.Image = ((System.Drawing.Image)(resources.GetObject("btnChucNang.Image")));
            this.btnChucNang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChucNang.Location = new System.Drawing.Point(0, 0);
            this.btnChucNang.Name = "btnChucNang";
            this.btnChucNang.Size = new System.Drawing.Size(134, 36);
            this.btnChucNang.TabIndex = 1;
            this.btnChucNang.Text = "Chức Năng";
            this.btnChucNang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnChucNang.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.picBackground;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this;
            // 
            // BoBaiToolStripMenuItem
            // 
            this.BoBaiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("BoBaiToolStripMenuItem.Image")));
            this.BoBaiToolStripMenuItem.Name = "BoBaiToolStripMenuItem";
            this.BoBaiToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.BoBaiToolStripMenuItem.Text = "Thông Tin Bộ Bài";
            this.BoBaiToolStripMenuItem.Click += new System.EventHandler(this.BoBaiToolStripMenuItem_Click);
            // 
            // LichSuToolStripMenuItem
            // 
            this.LichSuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LichSuToolStripMenuItem.Image")));
            this.LichSuToolStripMenuItem.Name = "LichSuToolStripMenuItem";
            this.LichSuToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.LichSuToolStripMenuItem.Text = "Lịch Sử Xem Bài";
            this.LichSuToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // cmsMenu
            // 
            this.cmsMenu.BackColor = System.Drawing.Color.BurlyWood;
            this.cmsMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoBaiToolStripMenuItem,
            this.LichSuToolStripMenuItem,
            this.ThoatToolStripMenuItem1});
            this.cmsMenu.Name = "guna2ContextMenuStrip1";
            this.cmsMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsMenu.RenderStyle.ColorTable = null;
            this.cmsMenu.RenderStyle.RoundedEdges = true;
            this.cmsMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsMenu.Size = new System.Drawing.Size(168, 70);
            this.cmsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMenu_Opening);
            // 
            // ThoatToolStripMenuItem1
            // 
            this.ThoatToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ThoatToolStripMenuItem1.Image")));
            this.ThoatToolStripMenuItem1.Name = "ThoatToolStripMenuItem1";
            this.ThoatToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.ThoatToolStripMenuItem1.Text = "Thoát";
            this.ThoatToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.picBackground;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // cmbTheme
            // 
            this.cmbTheme.BackColor = System.Drawing.Color.BurlyWood;
            this.cmbTheme.BorderColor = System.Drawing.Color.Black;
            this.cmbTheme.BorderThickness = 2;
            this.cmbTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTheme.FillColor = System.Drawing.Color.BurlyWood;
            this.cmbTheme.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTheme.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTheme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTheme.ForeColor = System.Drawing.Color.Black;
            this.cmbTheme.ItemHeight = 30;
            this.cmbTheme.Location = new System.Drawing.Point(203, 395);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.ShadowDecoration.BorderRadius = 10;
            this.cmbTheme.ShadowDecoration.Enabled = true;
            this.cmbTheme.Size = new System.Drawing.Size(251, 36);
            this.cmbTheme.TabIndex = 3;
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.Color.Transparent;
            this.btnBatDau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBatDau.BackgroundImage")));
            this.btnBatDau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBatDau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatDau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBatDau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBatDau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBatDau.FillColor = System.Drawing.Color.Transparent;
            this.btnBatDau.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnBatDau.Location = new System.Drawing.Point(241, 464);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(180, 34);
            this.btnBatDau.TabIndex = 5;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2DateTimePicker1.BackgroundImage")));
            this.guna2DateTimePicker1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.BurlyWood;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(0, 575);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(203, 34);
            this.guna2DateTimePicker1.TabIndex = 6;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 12, 29, 21, 16, 15, 236);
            // 
            // frmTarot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 609);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.cmbTheme);
            this.Controls.Add(this.btnChucNang);
            this.Controls.Add(this.picBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTarot";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTarot_FormClosed);
            this.Load += new System.EventHandler(this.frmTarot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picBackground;
        private Guna.UI2.WinForms.Guna2Button btnChucNang;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.ToolStripMenuItem BoBaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LichSuToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem ThoatToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTheme;
        private Guna.UI2.WinForms.Guna2Button btnBatDau;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
    }
}

