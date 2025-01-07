namespace TarotApp
{
    partial class frmTinhYeu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTinhYeu));
            this.picBackGround = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnCard1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnCard2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnCard3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnKetQua = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackGround
            // 
            this.picBackGround.Image = ((System.Drawing.Image)(resources.GetObject("picBackGround.Image")));
            this.picBackGround.ImageRotate = 0F;
            this.picBackGround.Location = new System.Drawing.Point(-29, -1);
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.Size = new System.Drawing.Size(829, 483);
            this.picBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackGround.TabIndex = 0;
            this.picBackGround.TabStop = false;
            this.picBackGround.Click += new System.EventHandler(this.picBackGround_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.picBackGround;
            this.guna2DragControl1.UseTransparentDrag = true;
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
            // btnCard1
            // 
            this.btnCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCard1.BackgroundImage")));
            this.btnCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCard1.BorderColor = System.Drawing.Color.MistyRose;
            this.btnCard1.BorderThickness = 3;
            this.btnCard1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCard1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCard1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCard1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCard1.FillColor = System.Drawing.Color.Transparent;
            this.btnCard1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCard1.ForeColor = System.Drawing.Color.White;
            this.btnCard1.Location = new System.Drawing.Point(112, 94);
            this.btnCard1.Name = "btnCard1";
            this.btnCard1.Size = new System.Drawing.Size(143, 223);
            this.btnCard1.TabIndex = 1;
            this.btnCard1.Click += new System.EventHandler(this.btnCard1_Click);
            // 
            // btnCard2
            // 
            this.btnCard2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCard2.BackgroundImage")));
            this.btnCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCard2.BorderColor = System.Drawing.Color.MistyRose;
            this.btnCard2.BorderThickness = 3;
            this.btnCard2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCard2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCard2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCard2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCard2.FillColor = System.Drawing.Color.Transparent;
            this.btnCard2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCard2.ForeColor = System.Drawing.Color.Transparent;
            this.btnCard2.Location = new System.Drawing.Point(331, 94);
            this.btnCard2.Name = "btnCard2";
            this.btnCard2.Size = new System.Drawing.Size(143, 223);
            this.btnCard2.TabIndex = 1;
            this.btnCard2.Click += new System.EventHandler(this.btnCard2_Click);
            // 
            // btnCard3
            // 
            this.btnCard3.BackColor = System.Drawing.SystemColors.Control;
            this.btnCard3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCard3.BackgroundImage")));
            this.btnCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCard3.BorderColor = System.Drawing.Color.MistyRose;
            this.btnCard3.BorderThickness = 3;
            this.btnCard3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCard3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCard3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCard3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCard3.FillColor = System.Drawing.Color.Transparent;
            this.btnCard3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCard3.ForeColor = System.Drawing.Color.White;
            this.btnCard3.Location = new System.Drawing.Point(548, 94);
            this.btnCard3.Name = "btnCard3";
            this.btnCard3.Size = new System.Drawing.Size(143, 223);
            this.btnCard3.TabIndex = 1;
            this.btnCard3.Click += new System.EventHandler(this.btnCard3_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.Transparent;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(0, -1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 27);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Exit";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnKetQua
            // 
            this.btnKetQua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKetQua.BackgroundImage")));
            this.btnKetQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKetQua.BorderColor = System.Drawing.Color.MistyRose;
            this.btnKetQua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKetQua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKetQua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKetQua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKetQua.FillColor = System.Drawing.Color.Transparent;
            this.btnKetQua.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetQua.ForeColor = System.Drawing.Color.Black;
            this.btnKetQua.Image = ((System.Drawing.Image)(resources.GetObject("btnKetQua.Image")));
            this.btnKetQua.ImageSize = new System.Drawing.Size(30, 30);
            this.btnKetQua.Location = new System.Drawing.Point(305, 344);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.PressedColor = System.Drawing.Color.Transparent;
            this.btnKetQua.Size = new System.Drawing.Size(193, 38);
            this.btnKetQua.TabIndex = 3;
            this.btnKetQua.Text = "Kiểm Tra Kết Quả";
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // frmTinhYeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCard3);
            this.Controls.Add(this.btnCard2);
            this.Controls.Add(this.btnCard1);
            this.Controls.Add(this.picBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTinhYeu";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTinhYeu_FormClosed);
            this.Load += new System.EventHandler(this.frmTinhYeu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picBackGround;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnCard3;
        private Guna.UI2.WinForms.Guna2Button btnCard2;
        private Guna.UI2.WinForms.Guna2Button btnCard1;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Button btnKetQua;
    }
}