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
            this.btnXoaPX = new System.Windows.Forms.Button();
            this.btnThemPX = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 549);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(288, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 27);
            this.label1.TabIndex = 35;
            this.label1.Text = "Bảng Phiếu Xuất";
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
            this.quay_id,
            this.nhan_vien_id,
            this.ngay_xuat});
            this.dataGridView1.Location = new System.Drawing.Point(14, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(811, 412);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã Phiếu";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // quay_id
            // 
            this.quay_id.DataPropertyName = "quay_id";
            this.quay_id.HeaderText = "Mã Quầy";
            this.quay_id.MinimumWidth = 6;
            this.quay_id.Name = "quay_id";
            // 
            // nhan_vien_id
            // 
            this.nhan_vien_id.DataPropertyName = "nhan_vien_id";
            this.nhan_vien_id.HeaderText = "Mã Nhân Viên";
            this.nhan_vien_id.MinimumWidth = 6;
            this.nhan_vien_id.Name = "nhan_vien_id";
            // 
            // ngay_xuat
            // 
            this.ngay_xuat.DataPropertyName = "ngay_xuat";
            this.ngay_xuat.HeaderText = "Ngày Xuất";
            this.ngay_xuat.MinimumWidth = 6;
            this.ngay_xuat.Name = "ngay_xuat";
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
            this.panel2.Size = new System.Drawing.Size(859, 133);
            this.panel2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label11.Location = new System.Drawing.Point(83, 35);
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
            this.label17.Location = new System.Drawing.Point(55, 73);
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
            this.tbSearch.Location = new System.Drawing.Point(392, 42);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(316, 46);
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
            this.btnSearch.Location = new System.Drawing.Point(730, 42);
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
            this.panel3.Controls.Add(this.btnXoaPX);
            this.panel3.Controls.Add(this.btnThemPX);
            this.panel3.Location = new System.Drawing.Point(868, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 688);
            this.panel3.TabIndex = 2;
            // 
            // btnXoaPX
            // 
            this.btnXoaPX.BackColor = System.Drawing.Color.Red;
            this.btnXoaPX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoaPX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaPX.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoaPX.FlatAppearance.BorderSize = 0;
            this.btnXoaPX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.btnXoaPX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.btnXoaPX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPX.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPX.ForeColor = System.Drawing.Color.White;
            this.btnXoaPX.Image = global::QuanLyKhoHang.Properties.Resources.add;
            this.btnXoaPX.Location = new System.Drawing.Point(63, 364);
            this.btnXoaPX.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaPX.Name = "btnXoaPX";
            this.btnXoaPX.Size = new System.Drawing.Size(220, 85);
            this.btnXoaPX.TabIndex = 3;
            this.btnXoaPX.Text = "Xoá phiếu xuất";
            this.btnXoaPX.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoaPX.UseVisualStyleBackColor = false;
            this.btnXoaPX.Click += new System.EventHandler(this.btnXoaPX_Click);
            // 
            // btnThemPX
            // 
            this.btnThemPX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.btnThemPX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThemPX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemPX.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThemPX.FlatAppearance.BorderSize = 0;
            this.btnThemPX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.btnThemPX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.btnThemPX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPX.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPX.ForeColor = System.Drawing.Color.White;
            this.btnThemPX.Image = global::QuanLyKhoHang.Properties.Resources.add;
            this.btnThemPX.Location = new System.Drawing.Point(63, 122);
            this.btnThemPX.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemPX.Name = "btnThemPX";
            this.btnThemPX.Size = new System.Drawing.Size(220, 85);
            this.btnThemPX.TabIndex = 2;
            this.btnThemPX.Text = "Thêm phiếu xuất";
            this.btnThemPX.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThemPX.UseVisualStyleBackColor = false;
            this.btnThemPX.Click += new System.EventHandler(this.btnThemPX_Click);
            // 
            // QLXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThemPX;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quay_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhan_vien_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_xuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaPX;
    }
}