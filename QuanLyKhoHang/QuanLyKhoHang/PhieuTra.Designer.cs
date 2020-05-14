namespace QuanLyKhoHang
{
    partial class PhieuTra
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaPhieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTenQuay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaQuay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTenHang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbLoaiHang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.SoLuong});
            this.dataGridView1.Location = new System.Drawing.Point(12, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1165, 326);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnLamMoi);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(3, 667);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1183, 66);
            this.panel2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(5, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nháy đúp vào 1 dòng để xoá";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(629, 12);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(135, 45);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm Mới Hoá Đơn";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(403, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(141, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Lập Hoá Đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1183, 192);
            this.panel3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbMaPhieu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(826, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Trả";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(105, 104);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(231, 24);
            this.dateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày lập";
            // 
            // tbMaPhieu
            // 
            this.tbMaPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMaPhieu.Location = new System.Drawing.Point(105, 49);
            this.tbMaPhieu.Name = "tbMaPhieu";
            this.tbMaPhieu.Size = new System.Drawing.Size(231, 24);
            this.tbMaPhieu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tbTenNV);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbMaNhanVien);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbTenQuay);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbMaQuay);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 177);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chung";
            // 
            // tbTenNV
            // 
            this.tbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTenNV.Location = new System.Drawing.Point(506, 105);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.ReadOnly = true;
            this.tbTenNV.Size = new System.Drawing.Size(231, 24);
            this.tbTenNV.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên Nhân Viên";
            // 
            // cbMaNhanVien
            // 
            this.cbMaNhanVien.FormattingEnabled = true;
            this.cbMaNhanVien.Location = new System.Drawing.Point(506, 47);
            this.cbMaNhanVien.Name = "cbMaNhanVien";
            this.cbMaNhanVien.Size = new System.Drawing.Size(231, 26);
            this.cbMaNhanVien.TabIndex = 7;
            this.cbMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbMaNhanVien_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã Nhân Viên";
            // 
            // tbTenQuay
            // 
            this.tbTenQuay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTenQuay.Location = new System.Drawing.Point(92, 104);
            this.tbTenQuay.Name = "tbTenQuay";
            this.tbTenQuay.ReadOnly = true;
            this.tbTenQuay.Size = new System.Drawing.Size(231, 24);
            this.tbTenQuay.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Quầy";
            // 
            // cbMaQuay
            // 
            this.cbMaQuay.FormattingEnabled = true;
            this.cbMaQuay.Location = new System.Drawing.Point(92, 46);
            this.cbMaQuay.Name = "cbMaQuay";
            this.cbMaQuay.Size = new System.Drawing.Size(231, 26);
            this.cbMaQuay.TabIndex = 3;
            this.cbMaQuay.SelectedIndexChanged += new System.EventHandler(this.cbMaQuay_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Quầy";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 736);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Location = new System.Drawing.Point(4, 201);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1182, 128);
            this.panel4.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonAdd);
            this.groupBox3.Controls.Add(this.tbSL);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbTenHang);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbLoaiHang);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1175, 122);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(821, 62);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(181, 41);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Thêm Sản Phẩm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tbSL
            // 
            this.tbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSL.Location = new System.Drawing.Point(856, 19);
            this.tbSL.Multiline = true;
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(101, 30);
            this.tbSL.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(755, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số Lượng";
            // 
            // cbTenHang
            // 
            this.cbTenHang.FormattingEnabled = true;
            this.cbTenHang.Location = new System.Drawing.Point(171, 77);
            this.cbTenHang.Name = "cbTenHang";
            this.cbTenHang.Size = new System.Drawing.Size(352, 24);
            this.cbTenHang.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tên Hàng";
            // 
            // cbLoaiHang
            // 
            this.cbLoaiHang.FormattingEnabled = true;
            this.cbLoaiHang.Location = new System.Drawing.Point(171, 23);
            this.cbLoaiHang.Name = "cbLoaiHang";
            this.cbLoaiHang.Size = new System.Drawing.Size(352, 24);
            this.cbLoaiHang.TabIndex = 7;
            this.cbLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cbLoaiHang_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Loại Hàng";
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.FillWeight = 111.631F;
            this.MaHang.HeaderText = "Mã Mặt Hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.FillWeight = 111.631F;
            this.TenHang.HeaderText = "Tên Mặt Hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.FillWeight = 111.631F;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // PhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 736);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhieuTra";
            this.Text = "PhieuTra";
            this.Load += new System.EventHandler(this.PhieuTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTenQuay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMaQuay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTenHang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbLoaiHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}