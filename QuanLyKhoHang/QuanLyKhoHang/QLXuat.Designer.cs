namespace QuanLyKhoHang
{
    partial class QLXuat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quay_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhan_vien_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_xuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label_sua = new System.Windows.Forms.Label();
            this.label_dk = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but_changeToRegis = new System.Windows.Forms.Button();
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_sua = new System.Windows.Forms.Button();
            this.cbTenHang = new System.Windows.Forms.ComboBox();
            this.cbLoaiHang = new System.Windows.Forms.ComboBox();
            this.cbMaQuay = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_del = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.but_error_mhang = new System.Windows.Forms.Button();
            this.but_error_lhang = new System.Windows.Forms.Button();
            this.but_error_sl = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textbox_soluong = new System.Windows.Forms.TextBox();
            this.but_add = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label_error_ten = new System.Windows.Forms.Label();
            this.but_error_maquay = new System.Windows.Forms.Button();
            this.but_error_manv = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.but_register = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 548);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(167, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 27);
            this.label1.TabIndex = 35;
            this.label1.Text = "Bảng Phiếu Xuất";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.quay_id,
            this.nhan_vien_id,
            this.ngay_xuat});
            this.dataGridView1.Location = new System.Drawing.Point(14, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(585, 412);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã Phiếu";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // quay_id
            // 
            this.quay_id.DataPropertyName = "quay_id";
            this.quay_id.HeaderText = "Mã Quầy";
            this.quay_id.MinimumWidth = 6;
            this.quay_id.Name = "quay_id";
            this.quay_id.ReadOnly = true;
            // 
            // nhan_vien_id
            // 
            this.nhan_vien_id.DataPropertyName = "nhan_vien_id";
            this.nhan_vien_id.HeaderText = "Mã Nhân Viên";
            this.nhan_vien_id.MinimumWidth = 6;
            this.nhan_vien_id.Name = "nhan_vien_id";
            this.nhan_vien_id.ReadOnly = true;
            // 
            // ngay_xuat
            // 
            this.ngay_xuat.DataPropertyName = "ngay_xuat";
            this.ngay_xuat.HeaderText = "Ngày Xuất";
            this.ngay_xuat.MinimumWidth = 6;
            this.ngay_xuat.Name = "ngay_xuat";
            this.ngay_xuat.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.right;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(172, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 38);
            this.panel4.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Courier New", 12F);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label19.Location = new System.Drawing.Point(215, 8);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 22);
            this.label19.TabIndex = 31;
            this.label19.Text = "Phiếu xuất";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Courier New", 12F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.label18.Location = new System.Drawing.Point(10, 8);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(154, 22);
            this.label18.TabIndex = 32;
            this.label18.Text = "Quản lý xuất";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(3, 556);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 133);
            this.panel2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label11.Location = new System.Drawing.Point(384, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 33);
            this.label11.TabIndex = 33;
            this.label11.Text = "Tìm kiếm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(106)))), ((int)(((byte)(155)))));
            this.label17.Location = new System.Drawing.Point(356, 95);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(224, 17);
            this.label17.TabIndex = 32;
            this.label17.Text = "___________________________";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbSearch.Location = new System.Drawing.Point(14, 53);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(227, 46);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(106)))), ((int)(((byte)(155)))));
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(106)))), ((int)(((byte)(155)))));
            this.btnSearch.Image = global::QuanLyKhoHang.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(249, 53);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 47);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label_sua);
            this.panel3.Controls.Add(this.label_dk);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.but_changeToRegis);
            this.panel3.Controls.Add(this.but_xoa);
            this.panel3.Controls.Add(this.but_sua);
            this.panel3.Controls.Add(this.cbTenHang);
            this.panel3.Controls.Add(this.cbLoaiHang);
            this.panel3.Controls.Add(this.cbMaQuay);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.cbMaNhanVien);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.but_del);
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Controls.Add(this.but_error_mhang);
            this.panel3.Controls.Add(this.but_error_lhang);
            this.panel3.Controls.Add(this.but_error_sl);
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.textbox_soluong);
            this.panel3.Controls.Add(this.but_add);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label_error_ten);
            this.panel3.Controls.Add(this.but_error_maquay);
            this.panel3.Controls.Add(this.but_error_manv);
            this.panel3.Controls.Add(this.label_id);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.but_register);
            this.panel3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel3.Location = new System.Drawing.Point(610, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 687);
            this.panel3.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label7.Location = new System.Drawing.Point(67, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 79;
            this.label7.Text = "Số lượng";
            // 
            // label_sua
            // 
            this.label_sua.AutoSize = true;
            this.label_sua.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label_sua.Location = new System.Drawing.Point(201, 7);
            this.label_sua.Margin = new System.Windows.Forms.Padding(0);
            this.label_sua.Name = "label_sua";
            this.label_sua.Size = new System.Drawing.Size(177, 33);
            this.label_sua.TabIndex = 78;
            this.label_sua.Text = "Chỉnh sửa";
            this.label_sua.Visible = false;
            // 
            // label_dk
            // 
            this.label_dk.AutoSize = true;
            this.label_dk.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label_dk.Location = new System.Drawing.Point(164, 7);
            this.label_dk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dk.Name = "label_dk";
            this.label_dk.Size = new System.Drawing.Size(249, 33);
            this.label_dk.TabIndex = 76;
            this.label_dk.Text = "Phiếu đăng ký";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label6.Location = new System.Drawing.Point(377, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 75;
            this.label6.Text = "Ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label5.Location = new System.Drawing.Point(13, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 23);
            this.label5.TabIndex = 74;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 73;
            this.label4.Text = "Mã quầy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(13, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 72;
            this.label3.Text = "Loại hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(237, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 71;
            this.label2.Text = "Mặt hàng";
            // 
            // but_changeToRegis
            // 
            this.but_changeToRegis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.but_changeToRegis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_changeToRegis.FlatAppearance.BorderSize = 0;
            this.but_changeToRegis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.but_changeToRegis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.but_changeToRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_changeToRegis.ForeColor = System.Drawing.Color.White;
            this.but_changeToRegis.Location = new System.Drawing.Point(529, 0);
            this.but_changeToRegis.Margin = new System.Windows.Forms.Padding(4);
            this.but_changeToRegis.Name = "but_changeToRegis";
            this.but_changeToRegis.Size = new System.Drawing.Size(35, 33);
            this.but_changeToRegis.TabIndex = 70;
            this.but_changeToRegis.Text = "-";
            this.but_changeToRegis.UseVisualStyleBackColor = false;
            this.but_changeToRegis.Visible = false;
            this.but_changeToRegis.Click += new System.EventHandler(this.but_sua_xoa_Click);
            // 
            // but_xoa
            // 
            this.but_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.but_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_xoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.but_xoa.FlatAppearance.BorderSize = 0;
            this.but_xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.but_xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.but_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_xoa.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_xoa.ForeColor = System.Drawing.Color.White;
            this.but_xoa.Image = global::QuanLyKhoHang.Properties.Resources.delete;
            this.but_xoa.Location = new System.Drawing.Point(312, 612);
            this.but_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(166, 64);
            this.but_xoa.TabIndex = 69;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_xoa.UseVisualStyleBackColor = false;
            this.but_xoa.Visible = false;
            this.but_xoa.Click += new System.EventHandler(this.but_sua_xoa_Click);
            // 
            // but_sua
            // 
            this.but_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.but_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_sua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.but_sua.FlatAppearance.BorderSize = 0;
            this.but_sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.but_sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.but_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_sua.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_sua.ForeColor = System.Drawing.Color.White;
            this.but_sua.Image = global::QuanLyKhoHang.Properties.Resources.repair;
            this.but_sua.Location = new System.Drawing.Point(133, 612);
            this.but_sua.Margin = new System.Windows.Forms.Padding(4);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(182, 64);
            this.but_sua.TabIndex = 68;
            this.but_sua.Text = "Sửa";
            this.but_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_sua.UseVisualStyleBackColor = false;
            this.but_sua.Visible = false;
            this.but_sua.Click += new System.EventHandler(this.but_sua_xoa_Click);
            // 
            // cbTenHang
            // 
            this.cbTenHang.ForeColor = System.Drawing.Color.Black;
            this.cbTenHang.FormattingEnabled = true;
            this.cbTenHang.Location = new System.Drawing.Point(241, 280);
            this.cbTenHang.Name = "cbTenHang";
            this.cbTenHang.Size = new System.Drawing.Size(163, 30);
            this.cbTenHang.TabIndex = 67;
            // 
            // cbLoaiHang
            // 
            this.cbLoaiHang.ForeColor = System.Drawing.Color.Black;
            this.cbLoaiHang.FormattingEnabled = true;
            this.cbLoaiHang.Location = new System.Drawing.Point(17, 280);
            this.cbLoaiHang.Name = "cbLoaiHang";
            this.cbLoaiHang.Size = new System.Drawing.Size(163, 30);
            this.cbLoaiHang.TabIndex = 66;
            this.cbLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cbLoaiHang_SelectedIndexChanged);
            // 
            // cbMaQuay
            // 
            this.cbMaQuay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaQuay.ForeColor = System.Drawing.Color.Black;
            this.cbMaQuay.FormattingEnabled = true;
            this.cbMaQuay.Location = new System.Drawing.Point(16, 177);
            this.cbMaQuay.Name = "cbMaQuay";
            this.cbMaQuay.Size = new System.Drawing.Size(272, 33);
            this.cbMaQuay.TabIndex = 65;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(380, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 30);
            this.dateTimePicker1.TabIndex = 64;
            // 
            // cbMaNhanVien
            // 
            this.cbMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaNhanVien.ForeColor = System.Drawing.Color.Black;
            this.cbMaNhanVien.FormattingEnabled = true;
            this.cbMaNhanVien.Location = new System.Drawing.Point(16, 94);
            this.cbMaNhanVien.Name = "cbMaNhanVien";
            this.cbMaNhanVien.Size = new System.Drawing.Size(272, 33);
            this.cbMaNhanVien.TabIndex = 63;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.SoLuong});
            this.dataGridView2.Location = new System.Drawing.Point(3, 370);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(577, 236);
            this.dataGridView2.TabIndex = 62;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "mat_hang_id";
            this.MaHang.FillWeight = 55F;
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "ten";
            this.TenHang.FillWeight = 104.766F;
            this.TenHang.HeaderText = "Tên Mặt Hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "so_luong";
            this.SoLuong.FillWeight = 60F;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // but_del
            // 
            this.but_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.but_del.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.delete;
            this.but_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_del.FlatAppearance.BorderSize = 0;
            this.but_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_del.Location = new System.Drawing.Point(454, 316);
            this.but_del.Margin = new System.Windows.Forms.Padding(4);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(118, 48);
            this.but_del.TabIndex = 61;
            this.but_del.UseVisualStyleBackColor = false;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(80)))));
            this.panel14.Location = new System.Drawing.Point(133, 41);
            this.panel14.Margin = new System.Windows.Forms.Padding(4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(321, 1);
            this.panel14.TabIndex = 48;
            // 
            // but_error_mhang
            // 
            this.but_error_mhang.BackColor = System.Drawing.Color.White;
            this.but_error_mhang.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.error;
            this.but_error_mhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_error_mhang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_error_mhang.FlatAppearance.BorderSize = 0;
            this.but_error_mhang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.but_error_mhang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.but_error_mhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_error_mhang.Location = new System.Drawing.Point(411, 280);
            this.but_error_mhang.Margin = new System.Windows.Forms.Padding(4);
            this.but_error_mhang.Name = "but_error_mhang";
            this.but_error_mhang.Size = new System.Drawing.Size(25, 23);
            this.but_error_mhang.TabIndex = 60;
            this.but_error_mhang.UseVisualStyleBackColor = false;
            this.but_error_mhang.Visible = false;
            // 
            // but_error_lhang
            // 
            this.but_error_lhang.BackColor = System.Drawing.Color.White;
            this.but_error_lhang.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.error;
            this.but_error_lhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_error_lhang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_error_lhang.FlatAppearance.BorderSize = 0;
            this.but_error_lhang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.but_error_lhang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.but_error_lhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_error_lhang.Location = new System.Drawing.Point(187, 283);
            this.but_error_lhang.Margin = new System.Windows.Forms.Padding(4);
            this.but_error_lhang.Name = "but_error_lhang";
            this.but_error_lhang.Size = new System.Drawing.Size(25, 23);
            this.but_error_lhang.TabIndex = 59;
            this.but_error_lhang.UseVisualStyleBackColor = false;
            this.but_error_lhang.Visible = false;
            // 
            // but_error_sl
            // 
            this.but_error_sl.BackColor = System.Drawing.Color.White;
            this.but_error_sl.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.error;
            this.but_error_sl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_error_sl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_error_sl.FlatAppearance.BorderSize = 0;
            this.but_error_sl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.but_error_sl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.but_error_sl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_error_sl.Location = new System.Drawing.Point(316, 330);
            this.but_error_sl.Margin = new System.Windows.Forms.Padding(4);
            this.but_error_sl.Name = "but_error_sl";
            this.but_error_sl.Size = new System.Drawing.Size(27, 25);
            this.but_error_sl.TabIndex = 57;
            this.but_error_sl.UseVisualStyleBackColor = false;
            this.but_error_sl.Visible = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Gray;
            this.panel12.Location = new System.Drawing.Point(173, 352);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(133, 1);
            this.panel12.TabIndex = 50;
            // 
            // textbox_soluong
            // 
            this.textbox_soluong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_soluong.ForeColor = System.Drawing.Color.Black;
            this.textbox_soluong.Location = new System.Drawing.Point(181, 329);
            this.textbox_soluong.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_soluong.Multiline = true;
            this.textbox_soluong.Name = "textbox_soluong";
            this.textbox_soluong.Size = new System.Drawing.Size(117, 25);
            this.textbox_soluong.TabIndex = 51;
            this.textbox_soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // but_add
            // 
            this.but_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.but_add.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.add;
            this.but_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_add.FlatAppearance.BorderSize = 0;
            this.but_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_add.Location = new System.Drawing.Point(454, 250);
            this.but_add.Margin = new System.Windows.Forms.Padding(4);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(118, 47);
            this.but_add.TabIndex = 50;
            this.but_add.UseVisualStyleBackColor = false;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.label15.Location = new System.Drawing.Point(13, 213);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 17);
            this.label15.TabIndex = 46;
            this.label15.Text = "Không được bỏ trống";
            this.label15.Visible = false;
            // 
            // label_error_ten
            // 
            this.label_error_ten.AutoSize = true;
            this.label_error_ten.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.label_error_ten.Location = new System.Drawing.Point(13, 134);
            this.label_error_ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_error_ten.Name = "label_error_ten";
            this.label_error_ten.Size = new System.Drawing.Size(160, 17);
            this.label_error_ten.TabIndex = 44;
            this.label_error_ten.Text = "Không được bỏ trống";
            this.label_error_ten.Visible = false;
            // 
            // but_error_maquay
            // 
            this.but_error_maquay.BackColor = System.Drawing.Color.White;
            this.but_error_maquay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_error_maquay.FlatAppearance.BorderSize = 0;
            this.but_error_maquay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.but_error_maquay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.but_error_maquay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_error_maquay.Image = global::QuanLyKhoHang.Properties.Resources.error;
            this.but_error_maquay.Location = new System.Drawing.Point(295, 172);
            this.but_error_maquay.Margin = new System.Windows.Forms.Padding(4);
            this.but_error_maquay.Name = "but_error_maquay";
            this.but_error_maquay.Size = new System.Drawing.Size(35, 33);
            this.but_error_maquay.TabIndex = 40;
            this.but_error_maquay.UseVisualStyleBackColor = false;
            this.but_error_maquay.Visible = false;
            // 
            // but_error_manv
            // 
            this.but_error_manv.BackColor = System.Drawing.Color.White;
            this.but_error_manv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_error_manv.FlatAppearance.BorderSize = 0;
            this.but_error_manv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.but_error_manv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.but_error_manv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_error_manv.Image = global::QuanLyKhoHang.Properties.Resources.error;
            this.but_error_manv.Location = new System.Drawing.Point(295, 94);
            this.but_error_manv.Margin = new System.Windows.Forms.Padding(4);
            this.but_error_manv.Name = "but_error_manv";
            this.but_error_manv.Size = new System.Drawing.Size(35, 33);
            this.but_error_manv.TabIndex = 39;
            this.but_error_manv.UseVisualStyleBackColor = false;
            this.but_error_manv.Visible = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.label_id.Location = new System.Drawing.Point(465, 97);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(77, 30);
            this.label_id.TabIndex = 16;
            this.label_id.Text = "8E7A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.label8.Location = new System.Drawing.Point(375, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 30);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã:#";
            // 
            // but_register
            // 
            this.but_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(80)))));
            this.but_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_register.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.but_register.FlatAppearance.BorderSize = 0;
            this.but_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.but_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.but_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_register.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_register.ForeColor = System.Drawing.Color.White;
            this.but_register.Image = global::QuanLyKhoHang.Properties.Resources.add;
            this.but_register.Location = new System.Drawing.Point(133, 613);
            this.but_register.Margin = new System.Windows.Forms.Padding(4);
            this.but_register.Name = "but_register";
            this.but_register.Size = new System.Drawing.Size(293, 63);
            this.but_register.TabIndex = 3;
            this.but_register.Text = "Lập phiếu xuất";
            this.but_register.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_register.UseVisualStyleBackColor = false;
            this.but_register.Click += new System.EventHandler(this.but_register_Click);
            // 
            // QLXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1195, 690);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QLXuat";
            this.Text = "QLXuat";
            this.Load += new System.EventHandler(this.QLXuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quay_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhan_vien_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_xuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_error_sl;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox textbox_soluong;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_error_ten;
        private System.Windows.Forms.Button but_error_maquay;
        private System.Windows.Forms.Button but_error_manv;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button but_register;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbMaNhanVien;
        private System.Windows.Forms.Button but_error_mhang;
        private System.Windows.Forms.Button but_error_lhang;
        private System.Windows.Forms.ComboBox cbMaQuay;
        private System.Windows.Forms.ComboBox cbLoaiHang;
        private System.Windows.Forms.ComboBox cbTenHang;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.Button but_changeToRegis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_sua;
        private System.Windows.Forms.Label label_dk;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}