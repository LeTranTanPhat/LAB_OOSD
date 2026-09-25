namespace QuanLyKhachSan.Forms
{
    partial class FrmPhongTienNghi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPhong = new System.Windows.Forms.TabPage();
            this.tpTienNghi = new System.Windows.Forms.TabPage();
            this.tpLapDat = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.cboKhu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaTN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numSTT = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.btnThemTN = new System.Windows.Forms.Button();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpPhong.SuspendLayout();
            this.tpTienNghi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPhong);
            this.tabControl1.Controls.Add(this.tpTienNghi);
            this.tabControl1.Controls.Add(this.tpLapDat);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1054, 533);
            this.tabControl1.TabIndex = 0;
            // 
            // tpPhong
            // 
            this.tpPhong.Controls.Add(this.btnThemPhong);
            this.tpPhong.Controls.Add(this.dgvPhong);
            this.tpPhong.Controls.Add(this.numGia);
            this.tpPhong.Controls.Add(this.numMax);
            this.tpPhong.Controls.Add(this.label3);
            this.tpPhong.Controls.Add(this.label4);
            this.tpPhong.Controls.Add(this.cboKhu);
            this.tpPhong.Controls.Add(this.label2);
            this.tpPhong.Controls.Add(this.txtPhong);
            this.tpPhong.Controls.Add(this.label1);
            this.tpPhong.Location = new System.Drawing.Point(4, 25);
            this.tpPhong.Name = "tpPhong";
            this.tpPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tpPhong.Size = new System.Drawing.Size(1046, 504);
            this.tpPhong.TabIndex = 0;
            this.tpPhong.Text = "Phòng";
            this.tpPhong.UseVisualStyleBackColor = true;
            // 
            // tpTienNghi
            // 
            this.tpTienNghi.Controls.Add(this.dgvTN);
            this.tpTienNghi.Controls.Add(this.btnThemTN);
            this.tpTienNghi.Controls.Add(this.txtTinhTrang);
            this.tpTienNghi.Controls.Add(this.label8);
            this.tpTienNghi.Controls.Add(this.numSTT);
            this.tpTienNghi.Controls.Add(this.label7);
            this.tpTienNghi.Controls.Add(this.cboLoai);
            this.tpTienNghi.Controls.Add(this.label6);
            this.tpTienNghi.Controls.Add(this.txtMaTN);
            this.tpTienNghi.Controls.Add(this.label5);
            this.tpTienNghi.Location = new System.Drawing.Point(4, 25);
            this.tpTienNghi.Name = "tpTienNghi";
            this.tpTienNghi.Padding = new System.Windows.Forms.Padding(3);
            this.tpTienNghi.Size = new System.Drawing.Size(1046, 504);
            this.tpTienNghi.TabIndex = 1;
            this.tpTienNghi.Text = "Tiện nghi";
            this.tpTienNghi.UseVisualStyleBackColor = true;
            // 
            // tpLapDat
            // 
            this.tpLapDat.Location = new System.Drawing.Point(4, 25);
            this.tpLapDat.Name = "tpLapDat";
            this.tpLapDat.Size = new System.Drawing.Size(1046, 504);
            this.tpLapDat.TabIndex = 2;
            this.tpLapDat.Text = "Lắp đặt / Luân chuyển";
            this.tpLapDat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khu vực:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(96, 24);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(140, 22);
            this.txtPhong.TabIndex = 1;
            // 
            // cboKhu
            // 
            this.cboKhu.FormattingEnabled = true;
            this.cboKhu.Location = new System.Drawing.Point(354, 20);
            this.cboKhu.Name = "cboKhu";
            this.cboKhu.Size = new System.Drawing.Size(134, 24);
            this.cboKhu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(758, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đơn giá / ngày:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(522, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số người tối đa:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(653, 22);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(84, 22);
            this.numMax.TabIndex = 8;
            // 
            // numGia
            // 
            this.numGia.Location = new System.Drawing.Point(885, 26);
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(120, 22);
            this.numGia.TabIndex = 9;
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(10, 119);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(1030, 377);
            this.dgvPhong.TabIndex = 10;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(885, 68);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(120, 45);
            this.btnThemPhong.TabIndex = 11;
            this.btnThemPhong.Text = "Thêm phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã tiện nghi:";
            // 
            // txtMaTN
            // 
            this.txtMaTN.Location = new System.Drawing.Point(119, 29);
            this.txtMaTN.Name = "txtMaTN";
            this.txtMaTN.Size = new System.Drawing.Size(130, 22);
            this.txtMaTN.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(283, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại tiện nghi:";
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(403, 29);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(121, 24);
            this.cboLoai.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(572, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số thứ tự:";
            // 
            // numSTT
            // 
            this.numSTT.Location = new System.Drawing.Point(659, 28);
            this.numSTT.Name = "numSTT";
            this.numSTT.Size = new System.Drawing.Size(120, 22);
            this.numSTT.TabIndex = 4;
            this.numSTT.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(831, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tình trạng:";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(927, 26);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(100, 22);
            this.txtTinhTrang.TabIndex = 6;
            // 
            // btnThemTN
            // 
            this.btnThemTN.Location = new System.Drawing.Point(845, 75);
            this.btnThemTN.Name = "btnThemTN";
            this.btnThemTN.Size = new System.Drawing.Size(182, 34);
            this.btnThemTN.TabIndex = 7;
            this.btnThemTN.Text = "Thêm tiện nghi";
            this.btnThemTN.UseVisualStyleBackColor = true;
            // 
            // dgvTN
            // 
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Location = new System.Drawing.Point(6, 146);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.RowHeadersWidth = 51;
            this.dgvTN.RowTemplate.Height = 24;
            this.dgvTN.Size = new System.Drawing.Size(1032, 350);
            this.dgvTN.TabIndex = 8;
            // 
            // FrmPhongTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPhongTienNghi";
            this.Text = "FrmPhongTienNghi";
            this.tabControl1.ResumeLayout(false);
            this.tpPhong.ResumeLayout(false);
            this.tpPhong.PerformLayout();
            this.tpTienNghi.ResumeLayout(false);
            this.tpTienNghi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPhong;
        private System.Windows.Forms.TabPage tpTienNghi;
        private System.Windows.Forms.TabPage tpLapDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboKhu;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.NumericUpDown numSTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.Button btnThemTN;
    }
}