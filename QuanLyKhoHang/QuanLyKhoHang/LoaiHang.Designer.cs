namespace QuanLyKhoHang
{
    partial class LoaiHang
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
            this.but_changeToRegis = new System.Windows.Forms.Button();
            this.but_xoa = new System.Windows.Forms.Button();
            this.label_sua = new System.Windows.Forms.Label();
            this.but_sua = new System.Windows.Forms.Button();
            this.label_error_ten = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.but_error_ten = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_dk = new System.Windows.Forms.Label();
            this.but_register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.but_search = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.but_changeToRegis.Location = new System.Drawing.Point(252, 3);
            this.but_changeToRegis.Name = "but_changeToRegis";
            this.but_changeToRegis.Size = new System.Drawing.Size(26, 27);
            this.but_changeToRegis.TabIndex = 10;
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
            this.but_xoa.Location = new System.Drawing.Point(156, 471);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(100, 41);
            this.but_xoa.TabIndex = 8;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_xoa.UseVisualStyleBackColor = false;
            this.but_xoa.Visible = false;
            this.but_xoa.Click += new System.EventHandler(this.but_sua_xoa_Click);
            // 
            // label_sua
            // 
            this.label_sua.AutoSize = true;
            this.label_sua.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label_sua.Location = new System.Drawing.Point(74, 13);
            this.label_sua.Name = "label_sua";
            this.label_sua.Size = new System.Drawing.Size(138, 27);
            this.label_sua.TabIndex = 49;
            this.label_sua.Text = "Chỉnh sửa";
            this.label_sua.Visible = false;
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
            this.but_sua.Location = new System.Drawing.Point(31, 471);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(127, 41);
            this.but_sua.TabIndex = 7;
            this.but_sua.Text = "Sửa";
            this.but_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_sua.UseVisualStyleBackColor = false;
            this.but_sua.Visible = false;
            this.but_sua.Click += new System.EventHandler(this.but_sua_xoa_Click);
            // 
            // label_error_ten
            // 
            this.label_error_ten.AutoSize = true;
            this.label_error_ten.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.label_error_ten.Location = new System.Drawing.Point(22, 156);
            this.label_error_ten.Name = "label_error_ten";
            this.label_error_ten.Size = new System.Drawing.Size(140, 14);
            this.label_error_ten.TabIndex = 44;
            this.label_error_ten.Text = "Không được bỏ trống";
            this.label_error_ten.Visible = false;
            // 
            // tbTen
            // 
            this.tbTen.BackColor = System.Drawing.Color.White;
            this.tbTen.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.tbTen.Location = new System.Drawing.Point(45, 123);
            this.tbTen.Multiline = true;
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(191, 30);
            this.tbTen.TabIndex = 4;
            this.tbTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.but_error_ten.Location = new System.Drawing.Point(242, 126);
            this.but_error_ten.Name = "but_error_ten";
            this.but_error_ten.Size = new System.Drawing.Size(26, 27);
            this.but_error_ten.TabIndex = 39;
            this.but_error_ten.UseVisualStyleBackColor = false;
            this.but_error_ten.Visible = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.label_id.Location = new System.Drawing.Point(128, 67);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(62, 24);
            this.label_id.TabIndex = 16;
            this.label_id.Text = "8E7A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.label8.Location = new System.Drawing.Point(60, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã:#";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.label7.Location = new System.Drawing.Point(22, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "_______________________";
            // 
            // label_dk
            // 
            this.label_dk.AutoSize = true;
            this.label_dk.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label_dk.Location = new System.Drawing.Point(44, 12);
            this.label_dk.Name = "label_dk";
            this.label_dk.Size = new System.Drawing.Size(194, 27);
            this.label_dk.TabIndex = 13;
            this.label_dk.Text = "Phiếu đăng ký";
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
            this.but_register.Location = new System.Drawing.Point(64, 471);
            this.but_register.Name = "but_register";
            this.but_register.Size = new System.Drawing.Size(161, 41);
            this.but_register.TabIndex = 9;
            this.but_register.Text = "Thêm";
            this.but_register.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_register.UseVisualStyleBackColor = false;
            this.but_register.Click += new System.EventHandler(this.but_register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(33, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên loại hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.textbox_search);
            this.panel2.Controls.Add(this.but_search);
            this.panel2.Location = new System.Drawing.Point(0, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 115);
            this.panel2.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label11.Location = new System.Drawing.Point(380, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 27);
            this.label11.TabIndex = 31;
            this.label11.Text = "Tìm kiếm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(106)))), ((int)(((byte)(155)))));
            this.label17.Location = new System.Drawing.Point(359, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "___________________________";
            // 
            // textbox_search
            // 
            this.textbox_search.BackColor = System.Drawing.Color.White;
            this.textbox_search.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.textbox_search.Location = new System.Drawing.Point(33, 30);
            this.textbox_search.Multiline = true;
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(200, 38);
            this.textbox_search.TabIndex = 2;
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
            this.but_search.Location = new System.Drawing.Point(249, 30);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(45, 38);
            this.but_search.TabIndex = 3;
            this.but_search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_search.UseVisualStyleBackColor = false;
            this.but_search.Click += new System.EventHandler(this.but_search_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(106)))), ((int)(((byte)(155)))));
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(0, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(614, 570);
            this.panel5.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(614, 449);
            this.panel3.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten});
            this.dataGridView2.Location = new System.Drawing.Point(15, 84);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(583, 352);
            this.dataGridView2.TabIndex = 32;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã loại hàng";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên loại hàng";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label9.Location = new System.Drawing.Point(182, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "Danh sách loại hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.but_changeToRegis);
            this.panel1.Controls.Add(this.but_xoa);
            this.panel1.Controls.Add(this.label_sua);
            this.panel1.Controls.Add(this.but_sua);
            this.panel1.Controls.Add(this.label_error_ten);
            this.panel1.Controls.Add(this.tbTen);
            this.panel1.Controls.Add(this.but_error_ten);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label_dk);
            this.panel1.Controls.Add(this.but_register);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(620, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 570);
            this.panel1.TabIndex = 37;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.right;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(101, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(26, 22);
            this.panel6.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(133, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Loại hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.label3.Location = new System.Drawing.Point(29, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tồn kho";
            // 
            // LoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 574);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoaiHang";
            this.Text = "LoaiHang";
            this.Load += new System.EventHandler(this.LoaiHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_changeToRegis;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Label label_sua;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.Label label_error_ten;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Button but_error_ten;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_dk;
        private System.Windows.Forms.Button but_register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Button but_search;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}