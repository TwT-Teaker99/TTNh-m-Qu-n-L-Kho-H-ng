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
            this.button1 = new System.Windows.Forms.Button();
            this.label_cost = new System.Windows.Forms.Label();
            this.e_sl = new System.Windows.Forms.PictureBox();
            this.e_dvi = new System.Windows.Forms.PictureBox();
            this.e_cost = new System.Windows.Forms.PictureBox();
            this.e_item = new System.Windows.Forms.PictureBox();
            this.label_item = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.textbox_cost = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textbox_soluong = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textbox_donvi = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textbox_item = new System.Windows.Forms.TextBox();
            this.but_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.e_sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_dvi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_item)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.label_cost.Location = new System.Drawing.Point(36, 195);
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
            this.e_sl.Location = new System.Drawing.Point(317, 134);
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
            this.e_dvi.Location = new System.Drawing.Point(316, 173);
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
            this.e_cost.Location = new System.Drawing.Point(169, 172);
            this.e_cost.Name = "e_cost";
            this.e_cost.Size = new System.Drawing.Size(20, 20);
            this.e_cost.TabIndex = 81;
            this.e_cost.TabStop = false;
            this.e_cost.Visible = false;
            // 
            // e_item
            // 
            this.e_item.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.error;
            this.e_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.e_item.Location = new System.Drawing.Point(170, 134);
            this.e_item.Name = "e_item";
            this.e_item.Size = new System.Drawing.Size(20, 20);
            this.e_item.TabIndex = 80;
            this.e_item.TabStop = false;
            this.e_item.Visible = false;
            // 
            // label_item
            // 
            this.label_item.AutoSize = true;
            this.label_item.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.label_item.Location = new System.Drawing.Point(36, 156);
            this.label_item.Name = "label_item";
            this.label_item.Size = new System.Drawing.Size(140, 14);
            this.label_item.TabIndex = 79;
            this.label_item.Text = "Mã MH không tồn tại";
            this.label_item.Visible = false;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Gray;
            this.panel13.Location = new System.Drawing.Point(56, 191);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(100, 1);
            this.panel13.TabIndex = 77;
            // 
            // textbox_cost
            // 
            this.textbox_cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_cost.ForeColor = System.Drawing.Color.Silver;
            this.textbox_cost.Location = new System.Drawing.Point(62, 172);
            this.textbox_cost.Multiline = true;
            this.textbox_cost.Name = "textbox_cost";
            this.textbox_cost.Size = new System.Drawing.Size(88, 20);
            this.textbox_cost.TabIndex = 78;
            this.textbox_cost.Text = "đơn giá";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Gray;
            this.panel12.Location = new System.Drawing.Point(211, 153);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(100, 1);
            this.panel12.TabIndex = 72;
            // 
            // textbox_soluong
            // 
            this.textbox_soluong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_soluong.ForeColor = System.Drawing.Color.Silver;
            this.textbox_soluong.Location = new System.Drawing.Point(217, 134);
            this.textbox_soluong.Multiline = true;
            this.textbox_soluong.Name = "textbox_soluong";
            this.textbox_soluong.Size = new System.Drawing.Size(88, 20);
            this.textbox_soluong.TabIndex = 75;
            this.textbox_soluong.Text = "số lượng";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gray;
            this.panel11.Location = new System.Drawing.Point(211, 191);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(100, 1);
            this.panel11.TabIndex = 73;
            // 
            // textbox_donvi
            // 
            this.textbox_donvi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textbox_donvi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textbox_donvi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_donvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_donvi.ForeColor = System.Drawing.Color.Silver;
            this.textbox_donvi.Location = new System.Drawing.Point(215, 173);
            this.textbox_donvi.Name = "textbox_donvi";
            this.textbox_donvi.Size = new System.Drawing.Size(88, 17);
            this.textbox_donvi.TabIndex = 76;
            this.textbox_donvi.Text = "đơn vị";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gray;
            this.panel10.Location = new System.Drawing.Point(57, 152);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(100, 1);
            this.panel10.TabIndex = 70;
            // 
            // textbox_item
            // 
            this.textbox_item.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textbox_item.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textbox_item.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_item.ForeColor = System.Drawing.Color.Silver;
            this.textbox_item.Location = new System.Drawing.Point(63, 133);
            this.textbox_item.Name = "textbox_item";
            this.textbox_item.Size = new System.Drawing.Size(88, 17);
            this.textbox_item.TabIndex = 71;
            this.textbox_item.Text = "mã mặt hàng";
            // 
            // but_add
            // 
            this.but_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.but_add.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.add;
            this.but_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_add.FlatAppearance.BorderSize = 0;
            this.but_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_add.Location = new System.Drawing.Point(351, 134);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(60, 60);
            this.but_add.TabIndex = 74;
            this.but_add.UseVisualStyleBackColor = false;
            // 
            // ChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 342);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.e_sl);
            this.Controls.Add(this.e_dvi);
            this.Controls.Add(this.e_cost);
            this.Controls.Add(this.e_item);
            this.Controls.Add(this.label_item);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.textbox_cost);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.textbox_soluong);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.textbox_donvi);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.textbox_item);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietPhieuNhap";
            this.Text = "ChiTietPhieuNhap";
            ((System.ComponentModel.ISupportInitialize)(this.e_sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_dvi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.PictureBox e_sl;
        private System.Windows.Forms.PictureBox e_dvi;
        private System.Windows.Forms.PictureBox e_cost;
        private System.Windows.Forms.PictureBox e_item;
        private System.Windows.Forms.Label label_item;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox textbox_cost;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox textbox_soluong;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox textbox_donvi;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textbox_item;
        private System.Windows.Forms.Button but_add;
    }
}