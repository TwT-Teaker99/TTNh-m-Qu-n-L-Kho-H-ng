namespace QuanLyKhoHang
{
    partial class ChiTietPhieuNhap
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
            this.label_cost = new System.Windows.Forms.Label();
            this.e_sl = new System.Windows.Forms.PictureBox();
            this.e_dvi = new System.Windows.Forms.PictureBox();
            this.e_cost = new System.Windows.Forms.PictureBox();
            this.textbox_cost = new System.Windows.Forms.TextBox();
            this.textbox_soluong = new System.Windows.Forms.TextBox();
            this.textbox_donvi = new System.Windows.Forms.TextBox();
            this.but_fix = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_dvi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.but_xoa = new System.Windows.Forms.Button();
            this.label_sl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.e_sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_dvi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_cost)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.label_cost.Location = new System.Drawing.Point(3, 132);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(182, 14);
            this.label_cost.TabIndex = 84;
            this.label_cost.Text = "đơn giá phải là số nguyên";
            this.label_cost.Visible = false;
            // 
            // e_sl
            // 
            this.e_sl.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.error;
            this.e_sl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.e_sl.Location = new System.Drawing.Point(130, 30);
            this.e_sl.Name = "e_sl";
            this.e_sl.Size = new System.Drawing.Size(20, 20);
            this.e_sl.TabIndex = 83;
            this.e_sl.TabStop = false;
            this.e_sl.Visible = false;
            // 
            // e_dvi
            // 
            this.e_dvi.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.error;
            this.e_dvi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.e_dvi.Location = new System.Drawing.Point(130, 171);
            this.e_dvi.Name = "e_dvi";
            this.e_dvi.Size = new System.Drawing.Size(20, 20);
            this.e_dvi.TabIndex = 82;
            this.e_dvi.TabStop = false;
            this.e_dvi.Visible = false;
            // 
            // e_cost
            // 
            this.e_cost.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.error;
            this.e_cost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.e_cost.Location = new System.Drawing.Point(130, 100);
            this.e_cost.Name = "e_cost";
            this.e_cost.Size = new System.Drawing.Size(20, 20);
            this.e_cost.TabIndex = 81;
            this.e_cost.TabStop = false;
            this.e_cost.Visible = false;
            // 
            // textbox_cost
            // 
            this.textbox_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_cost.ForeColor = System.Drawing.Color.Black;
            this.textbox_cost.Location = new System.Drawing.Point(12, 97);
            this.textbox_cost.Name = "textbox_cost";
            this.textbox_cost.Size = new System.Drawing.Size(106, 24);
            this.textbox_cost.TabIndex = 78;
            // 
            // textbox_soluong
            // 
            this.textbox_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_soluong.ForeColor = System.Drawing.Color.Black;
            this.textbox_soluong.Location = new System.Drawing.Point(12, 27);
            this.textbox_soluong.Name = "textbox_soluong";
            this.textbox_soluong.Size = new System.Drawing.Size(106, 24);
            this.textbox_soluong.TabIndex = 75;
            // 
            // textbox_donvi
            // 
            this.textbox_donvi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textbox_donvi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textbox_donvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_donvi.ForeColor = System.Drawing.Color.Black;
            this.textbox_donvi.Location = new System.Drawing.Point(12, 167);
            this.textbox_donvi.Name = "textbox_donvi";
            this.textbox_donvi.Size = new System.Drawing.Size(106, 24);
            this.textbox_donvi.TabIndex = 76;
            // 
            // but_fix
            // 
            this.but_fix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.but_fix.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.repair;
            this.but_fix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_fix.FlatAppearance.BorderSize = 0;
            this.but_fix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_fix.Location = new System.Drawing.Point(165, 70);
            this.but_fix.Name = "but_fix";
            this.but_fix.Size = new System.Drawing.Size(60, 60);
            this.but_fix.TabIndex = 74;
            this.but_fix.UseVisualStyleBackColor = false;
            this.but_fix.Click += new System.EventHandler(this.but_fix_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_dvi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.but_xoa);
            this.panel1.Controls.Add(this.label_sl);
            this.panel1.Controls.Add(this.but_fix);
            this.panel1.Controls.Add(this.label_cost);
            this.panel1.Controls.Add(this.textbox_soluong);
            this.panel1.Controls.Add(this.e_sl);
            this.panel1.Controls.Add(this.textbox_donvi);
            this.panel1.Controls.Add(this.e_dvi);
            this.panel1.Controls.Add(this.e_cost);
            this.panel1.Controls.Add(this.textbox_cost);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 210);
            this.panel1.TabIndex = 85;
            // 
            // label_dvi
            // 
            this.label_dvi.AutoSize = true;
            this.label_dvi.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dvi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.label_dvi.Location = new System.Drawing.Point(3, 194);
            this.label_dvi.Name = "label_dvi";
            this.label_dvi.Size = new System.Drawing.Size(140, 14);
            this.label_dvi.TabIndex = 90;
            this.label_dvi.Text = "không được để trống";
            this.label_dvi.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(9, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 89;
            this.label3.Text = "Đơn vị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 88;
            this.label2.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(9, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 87;
            this.label4.Text = "Số lượng";
            // 
            // but_xoa
            // 
            this.but_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.but_xoa.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.delete;
            this.but_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_xoa.FlatAppearance.BorderSize = 0;
            this.but_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_xoa.Location = new System.Drawing.Point(188, 171);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(40, 40);
            this.but_xoa.TabIndex = 86;
            this.but_xoa.UseVisualStyleBackColor = false;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // label_sl
            // 
            this.label_sl.AutoSize = true;
            this.label_sl.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.label_sl.Location = new System.Drawing.Point(9, 53);
            this.label_sl.Name = "label_sl";
            this.label_sl.Size = new System.Drawing.Size(175, 14);
            this.label_sl.TabIndex = 85;
            this.label_sl.Text = "đơn vị phải là số nguyên";
            this.label_sl.Visible = false;
            // 
            // ChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(106)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(234, 216);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChiTietPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa đổi chi tiết phiếu nhập";
            ((System.ComponentModel.ISupportInitialize)(this.e_sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_dvi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_cost)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.PictureBox e_sl;
        private System.Windows.Forms.PictureBox e_dvi;
        private System.Windows.Forms.PictureBox e_cost;
        private System.Windows.Forms.TextBox textbox_cost;
        private System.Windows.Forms.TextBox textbox_soluong;
        private System.Windows.Forms.TextBox textbox_donvi;
        private System.Windows.Forms.Button but_fix;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Label label_sl;
        private System.Windows.Forms.Label label_dvi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}