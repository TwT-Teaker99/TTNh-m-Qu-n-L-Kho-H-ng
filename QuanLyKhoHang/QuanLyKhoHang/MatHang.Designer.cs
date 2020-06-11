namespace QuanLyKhoHang
{
    partial class MatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.but_search = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.but_changeToRegis = new System.Windows.Forms.Button();
            this.but_xoa = new System.Windows.Forms.Button();
            this.label_sua = new System.Windows.Forms.Label();
            this.but_sua = new System.Windows.Forms.Button();
            this.label_error_remain = new System.Windows.Forms.Label();
            this.label_error_loai = new System.Windows.Forms.Label();
            this.label_error_ten = new System.Windows.Forms.Label();
            this.textbox_ten = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_loc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_dk = new System.Windows.Forms.Label();
            this.textbox_remain = new System.Windows.Forms.TextBox();
            this.but_register = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.e_remain = new System.Windows.Forms.PictureBox();
            this.e_loai = new System.Windows.Forms.PictureBox();
            this.e_ten = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textbox_loai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_remain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_loai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ten)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_search
            // 
            this.textbox_search.BackColor = System.Drawing.Color.White;
            this.textbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.textbox_search.Location = new System.Drawing.Point(55, 15);
            this.textbox_search.Multiline = true;
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(200, 38);
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
            this.but_search.Location = new System.Drawing.Point(261, 15);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(45, 38);
            this.but_search.TabIndex = 17;
            this.but_search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_search.UseVisualStyleBackColor = false;
            this.but_search.Click += new System.EventHandler(this.but_search_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.gridView);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 487);
            this.panel3.TabIndex = 10;
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToResizeColumns = false;
            this.gridView.AllowUserToResizeRows = false;
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.ColumnHeadersHeight = 60;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ncc,
            this.sdt,
            this.quan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.GridColor = System.Drawing.Color.White;
            this.gridView.Location = new System.Drawing.Point(30, 40);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 40;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(502, 427);
            this.gridView.TabIndex = 34;
            this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // ncc
            // 
            this.ncc.DataPropertyName = "ten";
            this.ncc.HeaderText = "Tên mặt hàng";
            this.ncc.Name = "ncc";
            this.ncc.ReadOnly = true;
            this.ncc.Width = 149;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "ten1";
            this.sdt.HeaderText = "Thuộc loại hàng";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 150;
            // 
            // quan
            // 
            this.quan.DataPropertyName = "remain";
            this.quan.HeaderText = "Số lượng tồn";
            this.quan.Name = "quan";
            this.quan.ReadOnly = true;
            this.quan.Width = 149;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.right;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(85, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 22);
            this.panel4.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label19.Location = new System.Drawing.Point(117, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 20);
            this.label19.TabIndex = 29;
            this.label19.Text = "Mặt hàng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.label18.Location = new System.Drawing.Point(13, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 20);
            this.label18.TabIndex = 29;
            this.label18.Text = "Tồn kho";
            // 
            // but_changeToRegis
            // 
            this.but_changeToRegis.BackColor = System.Drawing.Color.White;
            this.but_changeToRegis.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.circle__3_;
            this.but_changeToRegis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_changeToRegis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_changeToRegis.FlatAppearance.BorderSize = 0;
            this.but_changeToRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_changeToRegis.ForeColor = System.Drawing.Color.White;
            this.but_changeToRegis.Location = new System.Drawing.Point(253, 3);
            this.but_changeToRegis.Name = "but_changeToRegis";
            this.but_changeToRegis.Size = new System.Drawing.Size(25, 25);
            this.but_changeToRegis.TabIndex = 52;
            this.but_changeToRegis.Text = "-";
            this.but_changeToRegis.UseVisualStyleBackColor = false;
            this.but_changeToRegis.Visible = false;
            this.but_changeToRegis.Click += new System.EventHandler(this.but_form_alter);
            // 
            // but_xoa
            // 
            this.but_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.but_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_xoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.but_xoa.FlatAppearance.BorderSize = 0;
            this.but_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_xoa.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_xoa.ForeColor = System.Drawing.Color.White;
            this.but_xoa.Image = global::QuanLyKhoHang.Properties.Resources.delete;
            this.but_xoa.Location = new System.Drawing.Point(166, 483);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(85, 41);
            this.but_xoa.TabIndex = 51;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_xoa.UseVisualStyleBackColor = false;
            this.but_xoa.Visible = false;
            this.but_xoa.Click += new System.EventHandler(this.but_form_alter);
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
            this.but_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_sua.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_sua.ForeColor = System.Drawing.Color.White;
            this.but_sua.Image = global::QuanLyKhoHang.Properties.Resources.repair;
            this.but_sua.Location = new System.Drawing.Point(35, 483);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(127, 41);
            this.but_sua.TabIndex = 50;
            this.but_sua.Text = "Sửa";
            this.but_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_sua.UseVisualStyleBackColor = false;
            this.but_sua.Visible = false;
            this.but_sua.Click += new System.EventHandler(this.but_form_alter);
            // 
            // label_error_remain
            // 
            this.label_error_remain.AutoSize = true;
            this.label_error_remain.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_remain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.label_error_remain.Location = new System.Drawing.Point(22, 310);
            this.label_error_remain.Name = "label_error_remain";
            this.label_error_remain.Size = new System.Drawing.Size(140, 14);
            this.label_error_remain.TabIndex = 46;
            this.label_error_remain.Text = "Không được bỏ trống";
            this.label_error_remain.Visible = false;
            // 
            // label_error_loai
            // 
            this.label_error_loai.AutoSize = true;
            this.label_error_loai.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_loai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.label_error_loai.Location = new System.Drawing.Point(32, 216);
            this.label_error_loai.Name = "label_error_loai";
            this.label_error_loai.Size = new System.Drawing.Size(168, 14);
            this.label_error_loai.TabIndex = 45;
            this.label_error_loai.Text = "Mã loại hàng không đúng";
            this.label_error_loai.Visible = false;
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
            // textbox_ten
            // 
            this.textbox_ten.BackColor = System.Drawing.Color.White;
            this.textbox_ten.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.textbox_ten.Location = new System.Drawing.Point(45, 123);
            this.textbox_ten.Multiline = true;
            this.textbox_ten.Name = "textbox_ten";
            this.textbox_ten.Size = new System.Drawing.Size(191, 30);
            this.textbox_ten.TabIndex = 8;
            this.textbox_ten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(106)))), ((int)(((byte)(155)))));
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(1, -5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(550, 570);
            this.panel5.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBox_loc);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textbox_search);
            this.panel2.Controls.Add(this.but_search);
            this.panel2.Location = new System.Drawing.Point(0, 492);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 72);
            this.panel2.TabIndex = 9;
            // 
            // comboBox_loc
            // 
            this.comboBox_loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_loc.FormattingEnabled = true;
            this.comboBox_loc.Items.AddRange(new object[] {
            "Mặt hàng",
            "Loại hàng",
            "Tồn kho"});
            this.comboBox_loc.Location = new System.Drawing.Point(401, 23);
            this.comboBox_loc.Name = "comboBox_loc";
            this.comboBox_loc.Size = new System.Drawing.Size(121, 21);
            this.comboBox_loc.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label11.Location = new System.Drawing.Point(341, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 27);
            this.label11.TabIndex = 33;
            this.label11.Text = "Lọc";
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
            this.label_dk.Text = "Thêm mặt hàng";
            // 
            // textbox_remain
            // 
            this.textbox_remain.BackColor = System.Drawing.Color.White;
            this.textbox_remain.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_remain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.textbox_remain.Location = new System.Drawing.Point(45, 277);
            this.textbox_remain.Multiline = true;
            this.textbox_remain.Name = "textbox_remain";
            this.textbox_remain.Size = new System.Drawing.Size(191, 30);
            this.textbox_remain.TabIndex = 10;
            this.textbox_remain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // but_register
            // 
            this.but_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.but_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_register.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.but_register.FlatAppearance.BorderSize = 0;
            this.but_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_register.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_register.ForeColor = System.Drawing.Color.White;
            this.but_register.Image = global::QuanLyKhoHang.Properties.Resources.add;
            this.but_register.Location = new System.Drawing.Point(64, 483);
            this.but_register.Name = "but_register";
            this.but_register.Size = new System.Drawing.Size(161, 41);
            this.but_register.TabIndex = 3;
            this.but_register.Text = "Thêm";
            this.but_register.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_register.UseVisualStyleBackColor = false;
            this.but_register.Click += new System.EventHandler(this.but_register_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.e_remain);
            this.panel1.Controls.Add(this.e_loai);
            this.panel1.Controls.Add(this.e_ten);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.textbox_loai);
            this.panel1.Controls.Add(this.but_changeToRegis);
            this.panel1.Controls.Add(this.but_xoa);
            this.panel1.Controls.Add(this.label_sua);
            this.panel1.Controls.Add(this.but_sua);
            this.panel1.Controls.Add(this.label_error_remain);
            this.panel1.Controls.Add(this.label_error_loai);
            this.panel1.Controls.Add(this.label_error_ten);
            this.panel1.Controls.Add(this.textbox_ten);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label_dk);
            this.panel1.Controls.Add(this.textbox_remain);
            this.panel1.Controls.Add(this.but_register);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(570, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 552);
            this.panel1.TabIndex = 33;
            // 
            // e_remain
            // 
            this.e_remain.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.error;
            this.e_remain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.e_remain.Location = new System.Drawing.Point(245, 277);
            this.e_remain.Name = "e_remain";
            this.e_remain.Size = new System.Drawing.Size(26, 26);
            this.e_remain.TabIndex = 65;
            this.e_remain.TabStop = false;
            this.e_remain.Visible = false;
            // 
            // e_loai
            // 
            this.e_loai.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.error;
            this.e_loai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.e_loai.Location = new System.Drawing.Point(216, 191);
            this.e_loai.Name = "e_loai";
            this.e_loai.Size = new System.Drawing.Size(26, 26);
            this.e_loai.TabIndex = 64;
            this.e_loai.TabStop = false;
            this.e_loai.Visible = false;
            // 
            // e_ten
            // 
            this.e_ten.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.error;
            this.e_ten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.e_ten.Location = new System.Drawing.Point(242, 123);
            this.e_ten.Name = "e_ten";
            this.e_ten.Size = new System.Drawing.Size(26, 26);
            this.e_ten.TabIndex = 63;
            this.e_ten.TabStop = false;
            this.e_ten.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(168, 212);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(40, 1);
            this.panel7.TabIndex = 54;
            // 
            // textbox_loai
            // 
            this.textbox_loai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textbox_loai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textbox_loai.BackColor = System.Drawing.Color.White;
            this.textbox_loai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_loai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.textbox_loai.Location = new System.Drawing.Point(165, 189);
            this.textbox_loai.Name = "textbox_loai";
            this.textbox_loai.Size = new System.Drawing.Size(45, 17);
            this.textbox_loai.TabIndex = 53;
            this.textbox_loai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(34, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã loại hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(31, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên mặt hàng\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(32, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng tồn";
            // 
            // MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 561);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MatHang";
            this.Text = "MatHang";
            this.Load += new System.EventHandler(this.MatHang_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_remain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_loai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Button but_search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button but_changeToRegis;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Label label_sua;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.Label label_error_remain;
        private System.Windows.Forms.Label label_error_loai;
        private System.Windows.Forms.Label label_error_ten;
        private System.Windows.Forms.TextBox textbox_ten;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_dk;
        private System.Windows.Forms.TextBox textbox_remain;
        private System.Windows.Forms.Button but_register;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textbox_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn quan;
        private System.Windows.Forms.PictureBox e_remain;
        private System.Windows.Forms.PictureBox e_loai;
        private System.Windows.Forms.PictureBox e_ten;
        private System.Windows.Forms.ComboBox comboBox_loc;
        private System.Windows.Forms.Label label11;
    }
}