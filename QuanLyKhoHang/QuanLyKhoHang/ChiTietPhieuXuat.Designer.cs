﻿namespace QuanLyKhoHang
{
    partial class ChiTietPhieuXuat
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.mat_hang_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMP = new System.Windows.Forms.TextBox();
            this.tbNL = new System.Windows.Forms.TextBox();
            this.tbMQ = new System.Windows.Forms.TextBox();
            this.tbTQ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMNV = new System.Windows.Forms.TextBox();
            this.tbTNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 593);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(3, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(959, 388);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 193);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTNV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbMNV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbTQ);
            this.groupBox1.Controls.Add(this.tbMQ);
            this.groupBox1.Controls.Add(this.tbNL);
            this.groupBox1.Controls.Add(this.tbMP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã quầy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mat_hang_id,
            this.ten,
            this.so_luong});
            this.dataGridView1.Location = new System.Drawing.Point(4, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(952, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(333, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Danh sách mặt hàng";
            // 
            // mat_hang_id
            // 
            this.mat_hang_id.DataPropertyName = "mat_hang_id";
            this.mat_hang_id.HeaderText = "Mã mặt hàng";
            this.mat_hang_id.MinimumWidth = 6;
            this.mat_hang_id.Name = "mat_hang_id";
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên mặt hàng";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            // 
            // so_luong
            // 
            this.so_luong.DataPropertyName = "so_luong";
            this.so_luong.HeaderText = "Số lượng";
            this.so_luong.MinimumWidth = 6;
            this.so_luong.Name = "so_luong";
            // 
            // tbMP
            // 
            this.tbMP.Location = new System.Drawing.Point(100, 44);
            this.tbMP.Name = "tbMP";
            this.tbMP.ReadOnly = true;
            this.tbMP.Size = new System.Drawing.Size(171, 22);
            this.tbMP.TabIndex = 4;
            // 
            // tbNL
            // 
            this.tbNL.Location = new System.Drawing.Point(100, 113);
            this.tbNL.Name = "tbNL";
            this.tbNL.ReadOnly = true;
            this.tbNL.Size = new System.Drawing.Size(171, 22);
            this.tbNL.TabIndex = 5;
            // 
            // tbMQ
            // 
            this.tbMQ.Location = new System.Drawing.Point(389, 43);
            this.tbMQ.Name = "tbMQ";
            this.tbMQ.ReadOnly = true;
            this.tbMQ.Size = new System.Drawing.Size(207, 22);
            this.tbMQ.TabIndex = 6;
            // 
            // tbTQ
            // 
            this.tbTQ.Location = new System.Drawing.Point(389, 112);
            this.tbTQ.Name = "tbTQ";
            this.tbTQ.ReadOnly = true;
            this.tbTQ.Size = new System.Drawing.Size(207, 22);
            this.tbTQ.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên quầy";
            // 
            // tbMNV
            // 
            this.tbMNV.Location = new System.Drawing.Point(724, 44);
            this.tbMNV.Name = "tbMNV";
            this.tbMNV.ReadOnly = true;
            this.tbMNV.Size = new System.Drawing.Size(207, 22);
            this.tbMNV.TabIndex = 9;
            // 
            // tbTNV
            // 
            this.tbTNV.Location = new System.Drawing.Point(724, 113);
            this.tbTNV.Name = "tbTNV";
            this.tbTNV.ReadOnly = true;
            this.tbTNV.Size = new System.Drawing.Size(207, 22);
            this.tbTNV.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tên nhân viên";
            // 
            // ChiTietPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 593);
            this.Controls.Add(this.panel1);
            this.Name = "ChiTietPhieuXuat";
            this.Text = "Chi tiết phiếu xuất";
            this.Load += new System.EventHandler(this.ChiTietPhieuXuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mat_hang_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.TextBox tbTNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTQ;
        private System.Windows.Forms.TextBox tbMQ;
        private System.Windows.Forms.TextBox tbNL;
        private System.Windows.Forms.TextBox tbMP;
    }
}