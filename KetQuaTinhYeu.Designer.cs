namespace TarotApp
{
    partial class frmResultLove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultLove));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.picBackGround = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblResult = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnKetThuc = new Guna.UI2.WinForms.Guna2Button();
            this.btnShare = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.picBackGround;
            // 
            // picBackGround
            // 
            this.picBackGround.Image = ((System.Drawing.Image)(resources.GetObject("picBackGround.Image")));
            this.picBackGround.ImageRotate = 0F;
            this.picBackGround.Location = new System.Drawing.Point(0, -1);
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.Size = new System.Drawing.Size(774, 530);
            this.picBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackGround.TabIndex = 0;
            this.picBackGround.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            this.guna2Elipse3.TargetControl = this.lblResult;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = false;
            this.lblResult.BackColor = System.Drawing.Color.DimGray;
            this.lblResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblResult.BackgroundImage")));
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Tan;
            this.lblResult.Location = new System.Drawing.Point(129, 139);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(516, 285);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = null;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKetThuc.BackgroundImage")));
            this.btnKetThuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKetThuc.BorderRadius = 20;
            this.btnKetThuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKetThuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKetThuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKetThuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKetThuc.FillColor = System.Drawing.Color.Tan;
            this.btnKetThuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.ForeColor = System.Drawing.Color.Black;
            this.btnKetThuc.Location = new System.Drawing.Point(405, 448);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(134, 38);
            this.btnKetThuc.TabIndex = 2;
            this.btnKetThuc.Text = "Thoát";
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnShare
            // 
            this.btnShare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShare.BackgroundImage")));
            this.btnShare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShare.BorderRadius = 20;
            this.btnShare.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShare.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShare.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShare.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShare.FillColor = System.Drawing.Color.Tan;
            this.btnShare.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShare.ForeColor = System.Drawing.Color.Black;
            this.btnShare.Location = new System.Drawing.Point(237, 448);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(134, 38);
            this.btnShare.TabIndex = 2;
            this.btnShare.Text = "Chia Sẻ";
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.picBackGround;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // frmResultLove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 524);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.picBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResultLove";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblResult;
        private Guna.UI2.WinForms.Guna2PictureBox picBackGround;
        private Guna.UI2.WinForms.Guna2Button btnShare;
        private Guna.UI2.WinForms.Guna2Button btnKetThuc;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}