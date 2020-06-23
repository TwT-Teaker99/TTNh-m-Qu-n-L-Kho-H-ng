namespace QuanLyKhoHang
{
    partial class Login
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
            this.tbMK = new System.Windows.Forms.TextBox();
            this.pnMK = new System.Windows.Forms.Panel();
            this.tbTDN = new System.Windows.Forms.TextBox();
            this.pnTDN = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picMK = new System.Windows.Forms.PictureBox();
            this.picTDN = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMK
            // 
            this.tbMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMK.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMK.ForeColor = System.Drawing.SystemColors.Window;
            this.tbMK.Location = new System.Drawing.Point(88, 261);
            this.tbMK.Name = "tbMK";
            this.tbMK.Size = new System.Drawing.Size(193, 19);
            this.tbMK.TabIndex = 45;
            this.tbMK.Text = "Mật khẩu";
            this.tbMK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbMK_MouseClick);
            // 
            // pnMK
            // 
            this.pnMK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnMK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnMK.Location = new System.Drawing.Point(51, 283);
            this.pnMK.Name = "pnMK";
            this.pnMK.Size = new System.Drawing.Size(230, 1);
            this.pnMK.TabIndex = 44;
            // 
            // tbTDN
            // 
            this.tbTDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbTDN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTDN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTDN.ForeColor = System.Drawing.SystemColors.Window;
            this.tbTDN.Location = new System.Drawing.Point(88, 210);
            this.tbTDN.Name = "tbTDN";
            this.tbTDN.Size = new System.Drawing.Size(179, 19);
            this.tbTDN.TabIndex = 43;
            this.tbTDN.Text = "Tên đăng nhập";
            this.tbTDN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbTDN_MouseClick);
            // 
            // pnTDN
            // 
            this.pnTDN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnTDN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnTDN.Location = new System.Drawing.Point(51, 235);
            this.pnTDN.Name = "pnTDN";
            this.pnTDN.Size = new System.Drawing.Size(230, 1);
            this.pnTDN.TabIndex = 40;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.btnDangNhap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnDangNhap.Location = new System.Drawing.Point(51, 317);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(230, 30);
            this.btnDangNhap.TabIndex = 39;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 45);
            this.panel1.TabIndex = 38;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.minimize2;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(264, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnExit.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.close;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(300, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 20;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picMK
            // 
            this.picMK.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.password;
            this.picMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMK.Location = new System.Drawing.Point(54, 252);
            this.picMK.Name = "picMK";
            this.picMK.Size = new System.Drawing.Size(28, 28);
            this.picMK.TabIndex = 46;
            this.picMK.TabStop = false;
            // 
            // picTDN
            // 
            this.picTDN.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.tdn;
            this.picTDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTDN.Location = new System.Drawing.Point(54, 204);
            this.picTDN.Name = "picTDN";
            this.picTDN.Size = new System.Drawing.Size(28, 28);
            this.picTDN.TabIndex = 42;
            this.picTDN.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.nha_kho_login;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(121, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 86);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(333, 377);
            this.Controls.Add(this.picMK);
            this.Controls.Add(this.tbMK);
            this.Controls.Add(this.pnMK);
            this.Controls.Add(this.tbTDN);
            this.Controls.Add(this.picTDN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnTDN);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMK;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.Panel pnMK;
        private System.Windows.Forms.TextBox tbTDN;
        private System.Windows.Forms.PictureBox picTDN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnTDN;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
    }
}