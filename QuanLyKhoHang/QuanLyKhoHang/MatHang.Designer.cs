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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_loc = new System.Windows.Forms.ComboBox();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.but_search = new System.Windows.Forms.Button();
            this.label_error_sdt = new System.Windows.Forms.Label();
            this.label_error_ten = new System.Windows.Forms.Label();
            this.textbox_ten = new System.Windows.Forms.TextBox();
            this.but_error_sdt = new System.Windows.Forms.Button();
            this.but_error_ten = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textbox_sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label_dk = new System.Windows.Forms.Label();
            this.but_register = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridView.ColumnHeadersHeight = 60;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ncc,
            this.sdt,
            this.quan,
            this.Column1});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.GridColor = System.Drawing.Color.White;
            this.gridView.Location = new System.Drawing.Point(28, 37);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 40;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(479, 407);
            this.gridView.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::QuanLyKhoHang.Properties.Resources.right;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(84, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 22);
            this.panel4.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label19.Location = new System.Drawing.Point(116, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 20);
            this.label19.TabIndex = 36;
            this.label19.Text = "Mặt hàng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.label18.Location = new System.Drawing.Point(12, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 20);
            this.label18.TabIndex = 37;
            this.label18.Text = "Tồn kho";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(67)))));
            this.panel2.Location = new System.Drawing.Point(0, 475);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 3);
            this.panel2.TabIndex = 51;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(67)))));
            this.panel3.Location = new System.Drawing.Point(538, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 561);
            this.panel3.TabIndex = 52;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 70;
            // 
            // ncc
            // 
            this.ncc.DataPropertyName = "ncc_id";
            this.ncc.HeaderText = "Tên mặt hàng";
            this.ncc.Name = "ncc";
            this.ncc.ReadOnly = true;
            this.ncc.Width = 103;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "ngay_nhap";
            this.sdt.HeaderText = "Loại hàng";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // quan
            // 
            this.quan.DataPropertyName = "nhan_vien_id";
            this.quan.HeaderText = "Tồn kho";
            this.quan.Name = "quan";
            this.quan.ReadOnly = true;
            this.quan.Width = 85;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Giá hiện tại";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // comboBox_loc
            // 
            this.comboBox_loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_loc.FormattingEnabled = true;
            this.comboBox_loc.Items.AddRange(new object[] {
            "Mã đơn hàng",
            "Mã nhà cung cấp",
            "Ngày nhập",
            "Mã nhân viên",
            "Tên mặt hàng",
            "Mã mặt hàng"});
            this.comboBox_loc.Location = new System.Drawing.Point(374, 503);
            this.comboBox_loc.Name = "comboBox_loc";
            this.comboBox_loc.Size = new System.Drawing.Size(121, 21);
            this.comboBox_loc.TabIndex = 56;
            // 
            // textbox_search
            // 
            this.textbox_search.BackColor = System.Drawing.Color.White;
            this.textbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_search.ForeColor = System.Drawing.Color.Silver;
            this.textbox_search.Location = new System.Drawing.Point(50, 498);
            this.textbox_search.Multiline = true;
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(200, 38);
            this.textbox_search.TabIndex = 54;
            this.textbox_search.Text = "Tìm kiếm";
            this.textbox_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label11.Location = new System.Drawing.Point(314, 502);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 27);
            this.label11.TabIndex = 55;
            this.label11.Text = "Lọc";
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
            this.but_search.Location = new System.Drawing.Point(256, 498);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(45, 38);
            this.but_search.TabIndex = 53;
            this.but_search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_search.UseVisualStyleBackColor = false;
            // 
            // label_error_sdt
            // 
            this.label_error_sdt.AutoSize = true;
            this.label_error_sdt.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_sdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.label_error_sdt.Location = new System.Drawing.Point(599, 307);
            this.label_error_sdt.Name = "label_error_sdt";
            this.label_error_sdt.Size = new System.Drawing.Size(231, 14);
            this.label_error_sdt.TabIndex = 75;
            this.label_error_sdt.Text = "sđt phải 6-11 số không chứa chữ.";
            this.label_error_sdt.Visible = false;
            // 
            // label_error_ten
            // 
            this.label_error_ten.AutoSize = true;
            this.label_error_ten.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.label_error_ten.Location = new System.Drawing.Point(597, 206);
            this.label_error_ten.Name = "label_error_ten";
            this.label_error_ten.Size = new System.Drawing.Size(140, 14);
            this.label_error_ten.TabIndex = 74;
            this.label_error_ten.Text = "Không được bỏ trống";
            this.label_error_ten.Visible = false;
            // 
            // textbox_ten
            // 
            this.textbox_ten.BackColor = System.Drawing.Color.White;
            this.textbox_ten.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.textbox_ten.Location = new System.Drawing.Point(620, 173);
            this.textbox_ten.Multiline = true;
            this.textbox_ten.Name = "textbox_ten";
            this.textbox_ten.Size = new System.Drawing.Size(191, 30);
            this.textbox_ten.TabIndex = 62;
            this.textbox_ten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.but_error_sdt.Location = new System.Drawing.Point(819, 277);
            this.but_error_sdt.Name = "but_error_sdt";
            this.but_error_sdt.Size = new System.Drawing.Size(26, 27);
            this.but_error_sdt.TabIndex = 70;
            this.but_error_sdt.UseVisualStyleBackColor = false;
            this.but_error_sdt.Visible = false;
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
            this.but_error_ten.Location = new System.Drawing.Point(817, 176);
            this.but_error_ten.Name = "but_error_ten";
            this.but_error_ten.Size = new System.Drawing.Size(26, 27);
            this.but_error_ten.TabIndex = 69;
            this.but_error_ten.UseVisualStyleBackColor = false;
            this.but_error_ten.Visible = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.label_id.Location = new System.Drawing.Point(703, 70);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(62, 24);
            this.label_id.TabIndex = 68;
            this.label_id.Text = "8E7A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.label8.Location = new System.Drawing.Point(635, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 67;
            this.label8.Text = "Mã:#";
            // 
            // textbox_sdt
            // 
            this.textbox_sdt.BackColor = System.Drawing.Color.White;
            this.textbox_sdt.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.textbox_sdt.Location = new System.Drawing.Point(622, 274);
            this.textbox_sdt.Multiline = true;
            this.textbox_sdt.Name = "textbox_sdt";
            this.textbox_sdt.Size = new System.Drawing.Size(191, 30);
            this.textbox_sdt.TabIndex = 63;
            this.textbox_sdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(608, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 18);
            this.label4.TabIndex = 60;
            this.label4.Text = "Nhập mã loại hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(608, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tên mặt hàng";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(80)))));
            this.panel14.Location = new System.Drawing.Point(570, 48);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(300, 1);
            this.panel14.TabIndex = 77;
            // 
            // label_dk
            // 
            this.label_dk.AutoSize = true;
            this.label_dk.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label_dk.Location = new System.Drawing.Point(550, 9);
            this.label_dk.Name = "label_dk";
            this.label_dk.Size = new System.Drawing.Size(338, 36);
            this.label_dk.TabIndex = 76;
            this.label_dk.Text = "Thêm mới mặt hàng";
            // 
            // but_register
            // 
            this.but_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.but_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_register.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.but_register.FlatAppearance.BorderSize = 0;
            this.but_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_register.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_register.ForeColor = System.Drawing.Color.White;
            this.but_register.Image = global::QuanLyKhoHang.Properties.Resources.add;
            this.but_register.Location = new System.Drawing.Point(609, 475);
            this.but_register.Name = "but_register";
            this.but_register.Size = new System.Drawing.Size(220, 45);
            this.but_register.TabIndex = 78;
            this.but_register.Text = "Tạo mặt hàng";
            this.but_register.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_register.UseVisualStyleBackColor = false;
            // 
            // MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 561);
            this.Controls.Add(this.but_register);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.label_dk);
            this.Controls.Add(this.label_error_sdt);
            this.Controls.Add(this.label_error_ten);
            this.Controls.Add(this.textbox_ten);
            this.Controls.Add(this.but_error_sdt);
            this.Controls.Add(this.but_error_ten);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textbox_sdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_loc);
            this.Controls.Add(this.textbox_search);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.but_search);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MatHang";
            this.Text = "MatHang";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox comboBox_loc;
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button but_search;
        private System.Windows.Forms.Label label_error_sdt;
        private System.Windows.Forms.Label label_error_ten;
        private System.Windows.Forms.TextBox textbox_ten;
        private System.Windows.Forms.Button but_error_sdt;
        private System.Windows.Forms.Button but_error_ten;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textbox_sdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label_dk;
        private System.Windows.Forms.Button but_register;
    }
}