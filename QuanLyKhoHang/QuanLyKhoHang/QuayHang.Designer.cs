namespace QuanLyKhoHang
{
    partial class QuayHang
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
            this.label11 = new System.Windows.Forms.Label();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.but_search = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhan_vien_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label_error_quan = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_error_sdt = new System.Windows.Forms.Label();
            this.label_error_ten = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.but_error_quan = new System.Windows.Forms.Button();
            this.but_error_ten = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.but_error_sdt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.but_register = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label11.Location = new System.Drawing.Point(507, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 33);
            this.label11.TabIndex = 31;
            this.label11.Text = "Tìm kiếm";
            // 
            // textbox_search
            // 
            this.textbox_search.BackColor = System.Drawing.Color.White;
            this.textbox_search.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.textbox_search.Location = new System.Drawing.Point(44, 37);
            this.textbox_search.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_search.Multiline = true;
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(265, 46);
            this.textbox_search.TabIndex = 21;
            this.textbox_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // but_search
            // 
            this.but_search.BackColor = System.Drawing.Color.White;
            this.but_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(106)))), ((int)(((byte)(155)))));
            this.but_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.but_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.but_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_search.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(106)))), ((int)(((byte)(155)))));
            this.but_search.Image = global::QuanLyKhoHang.Properties.Resources.search;
            this.but_search.Location = new System.Drawing.Point(332, 37);
            this.but_search.Margin = new System.Windows.Forms.Padding(4);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(60, 47);
            this.but_search.TabIndex = 17;
            this.but_search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_search.UseVisualStyleBackColor = false;
            this.but_search.Click += new System.EventHandler(this.but_search_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 553);
            this.panel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.nhan_vien_id});
            this.dataGridView1.Location = new System.Drawing.Point(10, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 431);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã quầy";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên quầy";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            // 
            // nhan_vien_id
            // 
            this.nhan_vien_id.DataPropertyName = "nhan_vien_id";
            this.nhan_vien_id.HeaderText = "Mã nhân viên";
            this.nhan_vien_id.MinimumWidth = 6;
            this.nhan_vien_id.Name = "nhan_vien_id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label9.Location = new System.Drawing.Point(235, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 27);
            this.label9.TabIndex = 31;
            this.label9.Text = "Danh sách quầy hàng";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.right;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(193, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 34);
            this.panel4.TabIndex = 30;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Courier New", 12F);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label19.Location = new System.Drawing.Point(236, 17);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 22);
            this.label19.TabIndex = 29;
            this.label19.Text = "Quầy hàng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Courier New", 12F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.label18.Location = new System.Drawing.Point(15, 17);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(154, 22);
            this.label18.TabIndex = 29;
            this.label18.Text = "Quản lý xuất";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(106)))), ((int)(((byte)(155)))));
            this.label17.Location = new System.Drawing.Point(479, 69);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(224, 17);
            this.label17.TabIndex = 28;
            this.label17.Text = "___________________________";
            // 
            // label_error_quan
            // 
            this.label_error_quan.AutoSize = true;
            this.label_error_quan.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_quan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.label_error_quan.Location = new System.Drawing.Point(29, 375);
            this.label_error_quan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_error_quan.Name = "label_error_quan";
            this.label_error_quan.Size = new System.Drawing.Size(248, 17);
            this.label_error_quan.TabIndex = 46;
            this.label_error_quan.Text = "Không được bỏ trống hoặc là số";
            this.label_error_quan.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(106)))), ((int)(((byte)(155)))));
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(819, 702);
            this.panel5.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.textbox_search);
            this.panel2.Controls.Add(this.but_search);
            this.panel2.Location = new System.Drawing.Point(0, 557);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 141);
            this.panel2.TabIndex = 9;
            // 
            // label_error_sdt
            // 
            this.label_error_sdt.AutoSize = true;
            this.label_error_sdt.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_sdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.label_error_sdt.Location = new System.Drawing.Point(29, 282);
            this.label_error_sdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_error_sdt.Name = "label_error_sdt";
            this.label_error_sdt.Size = new System.Drawing.Size(272, 17);
            this.label_error_sdt.TabIndex = 45;
            this.label_error_sdt.Text = "sđt phải gồm 9 số không chứa chữ.";
            this.label_error_sdt.Visible = false;
            // 
            // label_error_ten
            // 
            this.label_error_ten.AutoSize = true;
            this.label_error_ten.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.label_error_ten.Location = new System.Drawing.Point(29, 192);
            this.label_error_ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_error_ten.Name = "label_error_ten";
            this.label_error_ten.Size = new System.Drawing.Size(160, 17);
            this.label_error_ten.TabIndex = 44;
            this.label_error_ten.Text = "Không được bỏ trống";
            this.label_error_ten.Visible = false;
            // 
            // tbTen
            // 
            this.tbTen.BackColor = System.Drawing.Color.White;
            this.tbTen.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.tbTen.Location = new System.Drawing.Point(60, 151);
            this.tbTen.Margin = new System.Windows.Forms.Padding(4);
            this.tbTen.Multiline = true;
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(253, 36);
            this.tbTen.TabIndex = 8;
            this.tbTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // but_error_quan
            // 
            this.but_error_quan.BackColor = System.Drawing.Color.White;
            this.but_error_quan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_error_quan.FlatAppearance.BorderSize = 0;
            this.but_error_quan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.but_error_quan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.but_error_quan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_error_quan.Image = global::QuanLyKhoHang.Properties.Resources.error;
            this.but_error_quan.Location = new System.Drawing.Point(324, 338);
            this.but_error_quan.Margin = new System.Windows.Forms.Padding(4);
            this.but_error_quan.Name = "but_error_quan";
            this.but_error_quan.Size = new System.Drawing.Size(35, 33);
            this.but_error_quan.TabIndex = 41;
            this.but_error_quan.UseVisualStyleBackColor = false;
            this.but_error_quan.Visible = false;
            // 
            // but_error_ten
            // 
            this.but_error_ten.BackColor = System.Drawing.Color.White;
            this.but_error_ten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_error_ten.FlatAppearance.BorderSize = 0;
            this.but_error_ten.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.but_error_ten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.but_error_ten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_error_ten.Image = global::QuanLyKhoHang.Properties.Resources.error;
            this.but_error_ten.Location = new System.Drawing.Point(323, 155);
            this.but_error_ten.Margin = new System.Windows.Forms.Padding(4);
            this.but_error_ten.Name = "but_error_ten";
            this.but_error_ten.Size = new System.Drawing.Size(35, 33);
            this.but_error_ten.TabIndex = 39;
            this.but_error_ten.UseVisualStyleBackColor = false;
            this.but_error_ten.Visible = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.label_id.Location = new System.Drawing.Point(171, 82);
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
            this.label8.Location = new System.Drawing.Point(80, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 30);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã:#";
            // 
            // but_error_sdt
            // 
            this.but_error_sdt.BackColor = System.Drawing.Color.White;
            this.but_error_sdt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_error_sdt.FlatAppearance.BorderSize = 0;
            this.but_error_sdt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.but_error_sdt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.but_error_sdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_error_sdt.Image = global::QuanLyKhoHang.Properties.Resources.error;
            this.but_error_sdt.Location = new System.Drawing.Point(323, 245);
            this.but_error_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.but_error_sdt.Name = "but_error_sdt";
            this.but_error_sdt.Size = new System.Drawing.Size(35, 33);
            this.but_error_sdt.TabIndex = 40;
            this.but_error_sdt.UseVisualStyleBackColor = false;
            this.but_error_sdt.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.label7.Location = new System.Drawing.Point(29, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "_______________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(59, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "Phiếu đăng ký";
            // 
            // tbTenNV
            // 
            this.tbTenNV.BackColor = System.Drawing.Color.White;
            this.tbTenNV.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.tbTenNV.Location = new System.Drawing.Point(60, 335);
            this.tbTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenNV.Multiline = true;
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.ReadOnly = true;
            this.tbTenNV.Size = new System.Drawing.Size(253, 36);
            this.tbTenNV.TabIndex = 10;
            this.tbTenNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // but_register
            // 
            this.but_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
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
            this.but_register.Location = new System.Drawing.Point(85, 420);
            this.but_register.Margin = new System.Windows.Forms.Padding(4);
            this.but_register.Name = "but_register";
            this.but_register.Size = new System.Drawing.Size(215, 50);
            this.but_register.TabIndex = 3;
            this.but_register.Text = "Thêm";
            this.but_register.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_register.UseVisualStyleBackColor = false;
            this.but_register.Click += new System.EventHandler(this.but_register_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(41, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(43, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.cbMaNhanVien);
            this.panel1.Controls.Add(this.label_error_quan);
            this.panel1.Controls.Add(this.label_error_sdt);
            this.panel1.Controls.Add(this.label_error_ten);
            this.panel1.Controls.Add(this.tbTen);
            this.panel1.Controls.Add(this.but_error_quan);
            this.panel1.Controls.Add(this.but_error_sdt);
            this.panel1.Controls.Add(this.but_error_ten);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbTenNV);
            this.panel1.Controls.Add(this.but_register);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(829, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 702);
            this.panel1.TabIndex = 33;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnLamMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = global::QuanLyKhoHang.Properties.Resources.add;
            this.btnLamMoi.Location = new System.Drawing.Point(86, 503);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(215, 50);
            this.btnLamMoi.TabIndex = 48;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cbMaNhanVien
            // 
            this.cbMaNhanVien.FormattingEnabled = true;
            this.cbMaNhanVien.Location = new System.Drawing.Point(60, 245);
            this.cbMaNhanVien.Name = "cbMaNhanVien";
            this.cbMaNhanVien.Size = new System.Drawing.Size(253, 30);
            this.cbMaNhanVien.TabIndex = 47;
            this.cbMaNhanVien.TextChanged += new System.EventHandler(this.cbMaNhanVien_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(44, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên quầy";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::QuanLyKhoHang.Properties.Resources.add;
            this.btnXoa.Location = new System.Drawing.Point(85, 594);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(215, 50);
            this.btnXoa.TabIndex = 49;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // QuayHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 706);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuayHang";
            this.ShowIcon = false;
            this.Text = "QuayHang";
            this.Load += new System.EventHandler(this.QuayHang_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Button but_search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_error_quan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_error_sdt;
        private System.Windows.Forms.Label label_error_ten;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Button but_error_quan;
        private System.Windows.Forms.Button but_error_ten;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button but_error_sdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.Button but_register;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhan_vien_id;
        private System.Windows.Forms.ComboBox cbMaNhanVien;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
    }
}