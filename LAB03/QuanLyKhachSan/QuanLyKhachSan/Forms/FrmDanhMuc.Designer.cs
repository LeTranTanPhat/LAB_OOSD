namespace QuanLyKhachSan.Forms
{
    partial class FrmDanhMuc
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
            this.tpKhuVuc = new System.Windows.Forms.TabPage();
            this.btnThemKhu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhuTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKhuMa = new System.Windows.Forms.TextBox();
            this.dgvKhu = new System.Windows.Forms.DataGridView();
            this.tpNhanVien = new System.Windows.Forms.TabPage();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNVVaiTro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.tpLoaiTienNghi = new System.Windows.Forms.TabPage();
            this.btnThemLoaiTN = new System.Windows.Forms.Button();
            this.txtLoaiTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoaiMa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvLoaiTN = new System.Windows.Forms.DataGridView();
            this.tpDichVu = new System.Windows.Forms.TabPage();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.numDVGia = new System.Windows.Forms.NumericUpDown();
            this.txtDVDVT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDVTen = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDVMa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.tpQuyDinh = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.numQDTien = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.cboQDLoai = new System.Windows.Forms.ComboBox();
            this.txtQDMucDo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQDMa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvQD = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpKhuVuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).BeginInit();
            this.tpNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.tpLoaiTienNghi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).BeginInit();
            this.tpDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.tpQuyDinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpKhuVuc);
            this.tabControl1.Controls.Add(this.tpNhanVien);
            this.tabControl1.Controls.Add(this.tpLoaiTienNghi);
            this.tabControl1.Controls.Add(this.tpDichVu);
            this.tabControl1.Controls.Add(this.tpQuyDinh);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1041, 523);
            this.tabControl1.TabIndex = 0;
            // 
            // tpKhuVuc
            // 
            this.tpKhuVuc.Controls.Add(this.btnThemKhu);
            this.tpKhuVuc.Controls.Add(this.label2);
            this.tpKhuVuc.Controls.Add(this.txtKhuTen);
            this.tpKhuVuc.Controls.Add(this.label1);
            this.tpKhuVuc.Controls.Add(this.txtKhuMa);
            this.tpKhuVuc.Controls.Add(this.dgvKhu);
            this.tpKhuVuc.Location = new System.Drawing.Point(4, 25);
            this.tpKhuVuc.Name = "tpKhuVuc";
            this.tpKhuVuc.Padding = new System.Windows.Forms.Padding(3);
            this.tpKhuVuc.Size = new System.Drawing.Size(1033, 494);
            this.tpKhuVuc.TabIndex = 0;
            this.tpKhuVuc.Text = "Khu vực";
            this.tpKhuVuc.UseVisualStyleBackColor = true;
            this.tpKhuVuc.Click += new System.EventHandler(this.tpKhuVuc_Click);
            // 
            // btnThemKhu
            // 
            this.btnThemKhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhu.Location = new System.Drawing.Point(780, 41);
            this.btnThemKhu.Name = "btnThemKhu";
            this.btnThemKhu.Size = new System.Drawing.Size(166, 41);
            this.btnThemKhu.TabIndex = 5;
            this.btnThemKhu.Text = "Thêm khu vực";
            this.btnThemKhu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khu vực:";
            // 
            // txtKhuTen
            // 
            this.txtKhuTen.Location = new System.Drawing.Point(483, 50);
            this.txtKhuTen.Name = "txtKhuTen";
            this.txtKhuTen.Size = new System.Drawing.Size(180, 22);
            this.txtKhuTen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khu vực:";
            // 
            // txtKhuMa
            // 
            this.txtKhuMa.Location = new System.Drawing.Point(127, 50);
            this.txtKhuMa.Name = "txtKhuMa";
            this.txtKhuMa.Size = new System.Drawing.Size(168, 22);
            this.txtKhuMa.TabIndex = 1;
            // 
            // dgvKhu
            // 
            this.dgvKhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhu.Location = new System.Drawing.Point(6, 138);
            this.dgvKhu.Name = "dgvKhu";
            this.dgvKhu.RowHeadersWidth = 51;
            this.dgvKhu.RowTemplate.Height = 24;
            this.dgvKhu.Size = new System.Drawing.Size(981, 311);
            this.dgvKhu.TabIndex = 0;
            // 
            // tpNhanVien
            // 
            this.tpNhanVien.Controls.Add(this.btnThemNV);
            this.tpNhanVien.Controls.Add(this.txtNVTen);
            this.tpNhanVien.Controls.Add(this.label4);
            this.tpNhanVien.Controls.Add(this.txtNVSDT);
            this.tpNhanVien.Controls.Add(this.label6);
            this.tpNhanVien.Controls.Add(this.txtNVVaiTro);
            this.tpNhanVien.Controls.Add(this.label5);
            this.tpNhanVien.Controls.Add(this.txtNVMa);
            this.tpNhanVien.Controls.Add(this.label3);
            this.tpNhanVien.Controls.Add(this.dgvNV);
            this.tpNhanVien.Location = new System.Drawing.Point(4, 25);
            this.tpNhanVien.Name = "tpNhanVien";
            this.tpNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhanVien.Size = new System.Drawing.Size(1033, 494);
            this.tpNhanVien.TabIndex = 1;
            this.tpNhanVien.Text = "Nhân viên";
            this.tpNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(822, 36);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(140, 43);
            this.btnThemNV.TabIndex = 5;
            this.btnThemNV.Text = "Thêm Nhân Viên";
            this.btnThemNV.UseVisualStyleBackColor = true;
            // 
            // txtNVTen
            // 
            this.txtNVTen.Location = new System.Drawing.Point(207, 72);
            this.txtNVTen.Name = "txtNVTen";
            this.txtNVTen.Size = new System.Drawing.Size(176, 22);
            this.txtNVTen.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ tên nhân viên:";
            // 
            // txtNVSDT
            // 
            this.txtNVSDT.Location = new System.Drawing.Point(581, 70);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(196, 22);
            this.txtNVSDT.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số điện thoại:";
            // 
            // txtNVVaiTro
            // 
            this.txtNVVaiTro.Location = new System.Drawing.Point(581, 24);
            this.txtNVVaiTro.Name = "txtNVVaiTro";
            this.txtNVVaiTro.Size = new System.Drawing.Size(168, 22);
            this.txtNVVaiTro.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vai trò / Chức vụ:";
            // 
            // txtNVMa
            // 
            this.txtNVMa.Location = new System.Drawing.Point(180, 24);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(203, 22);
            this.txtNVMa.TabIndex = 2;
            this.txtNVMa.TextChanged += new System.EventHandler(this.txtNVMa_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã nhân viên:";
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(6, 122);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(981, 327);
            this.dgvNV.TabIndex = 0;
            // 
            // tpLoaiTienNghi
            // 
            this.tpLoaiTienNghi.Controls.Add(this.btnThemLoaiTN);
            this.tpLoaiTienNghi.Controls.Add(this.txtLoaiTen);
            this.tpLoaiTienNghi.Controls.Add(this.label8);
            this.tpLoaiTienNghi.Controls.Add(this.txtLoaiMa);
            this.tpLoaiTienNghi.Controls.Add(this.label7);
            this.tpLoaiTienNghi.Controls.Add(this.dgvLoaiTN);
            this.tpLoaiTienNghi.Location = new System.Drawing.Point(4, 25);
            this.tpLoaiTienNghi.Name = "tpLoaiTienNghi";
            this.tpLoaiTienNghi.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoaiTienNghi.Size = new System.Drawing.Size(1033, 494);
            this.tpLoaiTienNghi.TabIndex = 2;
            this.tpLoaiTienNghi.Text = "Loại tiện nghi";
            this.tpLoaiTienNghi.UseVisualStyleBackColor = true;
            // 
            // btnThemLoaiTN
            // 
            this.btnThemLoaiTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiTN.Location = new System.Drawing.Point(808, 56);
            this.btnThemLoaiTN.Name = "btnThemLoaiTN";
            this.btnThemLoaiTN.Size = new System.Drawing.Size(160, 41);
            this.btnThemLoaiTN.TabIndex = 5;
            this.btnThemLoaiTN.Text = "Thêm Loại Tiện Nghi";
            this.btnThemLoaiTN.UseVisualStyleBackColor = true;
            // 
            // txtLoaiTen
            // 
            this.txtLoaiTen.Location = new System.Drawing.Point(557, 65);
            this.txtLoaiTen.Name = "txtLoaiTen";
            this.txtLoaiTen.Size = new System.Drawing.Size(203, 22);
            this.txtLoaiTen.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(415, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tên loại tiện nghi:";
            // 
            // txtLoaiMa
            // 
            this.txtLoaiMa.Location = new System.Drawing.Point(172, 65);
            this.txtLoaiMa.Name = "txtLoaiMa";
            this.txtLoaiMa.Size = new System.Drawing.Size(203, 22);
            this.txtLoaiMa.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mã loại tiện nghi:";
            // 
            // dgvLoaiTN
            // 
            this.dgvLoaiTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTN.Location = new System.Drawing.Point(6, 149);
            this.dgvLoaiTN.Name = "dgvLoaiTN";
            this.dgvLoaiTN.RowHeadersWidth = 51;
            this.dgvLoaiTN.RowTemplate.Height = 24;
            this.dgvLoaiTN.Size = new System.Drawing.Size(981, 300);
            this.dgvLoaiTN.TabIndex = 0;
            // 
            // tpDichVu
            // 
            this.tpDichVu.Controls.Add(this.btnThemDV);
            this.tpDichVu.Controls.Add(this.label12);
            this.tpDichVu.Controls.Add(this.numDVGia);
            this.tpDichVu.Controls.Add(this.txtDVDVT);
            this.tpDichVu.Controls.Add(this.label11);
            this.tpDichVu.Controls.Add(this.txtDVTen);
            this.tpDichVu.Controls.Add(this.label10);
            this.tpDichVu.Controls.Add(this.txtDVMa);
            this.tpDichVu.Controls.Add(this.label9);
            this.tpDichVu.Controls.Add(this.dgvDV);
            this.tpDichVu.Location = new System.Drawing.Point(4, 25);
            this.tpDichVu.Name = "tpDichVu";
            this.tpDichVu.Size = new System.Drawing.Size(1033, 494);
            this.tpDichVu.TabIndex = 3;
            this.tpDichVu.Text = "Dịch vụ";
            this.tpDichVu.UseVisualStyleBackColor = true;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(751, 47);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(130, 59);
            this.btnThemDV.TabIndex = 9;
            this.btnThemDV.Text = "Thêm Dịch Vụ";
            this.btnThemDV.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(405, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Đơn giá:";
            // 
            // numDVGia
            // 
            this.numDVGia.Location = new System.Drawing.Point(511, 87);
            this.numDVGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numDVGia.Name = "numDVGia";
            this.numDVGia.Size = new System.Drawing.Size(131, 22);
            this.numDVGia.TabIndex = 7;
            // 
            // txtDVDVT
            // 
            this.txtDVDVT.Location = new System.Drawing.Point(511, 32);
            this.txtDVDVT.Name = "txtDVDVT";
            this.txtDVDVT.Size = new System.Drawing.Size(102, 22);
            this.txtDVDVT.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(405, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Đơn vị tính:";
            // 
            // txtDVTen
            // 
            this.txtDVTen.Location = new System.Drawing.Point(136, 86);
            this.txtDVTen.Name = "txtDVTen";
            this.txtDVTen.Size = new System.Drawing.Size(198, 22);
            this.txtDVTen.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tên dịch vụ:";
            // 
            // txtDVMa
            // 
            this.txtDVMa.Location = new System.Drawing.Point(131, 32);
            this.txtDVMa.Name = "txtDVMa";
            this.txtDVMa.Size = new System.Drawing.Size(203, 22);
            this.txtDVMa.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mã dịch vụ:";
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(3, 156);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersWidth = 51;
            this.dgvDV.RowTemplate.Height = 24;
            this.dgvDV.Size = new System.Drawing.Size(987, 296);
            this.dgvDV.TabIndex = 0;
            // 
            // tpQuyDinh
            // 
            this.tpQuyDinh.Controls.Add(this.button1);
            this.tpQuyDinh.Controls.Add(this.numQDTien);
            this.tpQuyDinh.Controls.Add(this.label15);
            this.tpQuyDinh.Controls.Add(this.cboQDLoai);
            this.tpQuyDinh.Controls.Add(this.txtQDMucDo);
            this.tpQuyDinh.Controls.Add(this.label16);
            this.tpQuyDinh.Controls.Add(this.label14);
            this.tpQuyDinh.Controls.Add(this.txtQDMa);
            this.tpQuyDinh.Controls.Add(this.label13);
            this.tpQuyDinh.Controls.Add(this.dgvQD);
            this.tpQuyDinh.Location = new System.Drawing.Point(4, 25);
            this.tpQuyDinh.Name = "tpQuyDinh";
            this.tpQuyDinh.Size = new System.Drawing.Size(1033, 494);
            this.tpQuyDinh.TabIndex = 4;
            this.tpQuyDinh.Text = "Quy định đền bù";
            this.tpQuyDinh.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(896, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thêm quy định";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numQDTien
            // 
            this.numQDTien.Location = new System.Drawing.Point(758, 99);
            this.numQDTien.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numQDTien.Name = "numQDTien";
            this.numQDTien.Size = new System.Drawing.Size(120, 22);
            this.numQDTien.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(224, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "Chọn loại tiện nghi liên quan:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // cboQDLoai
            // 
            this.cboQDLoai.FormattingEnabled = true;
            this.cboQDLoai.Location = new System.Drawing.Point(275, 99);
            this.cboQDLoai.Name = "cboQDLoai";
            this.cboQDLoai.Size = new System.Drawing.Size(203, 24);
            this.cboQDLoai.TabIndex = 9;
            // 
            // txtQDMucDo
            // 
            this.txtQDMucDo.Location = new System.Drawing.Point(675, 40);
            this.txtQDMucDo.Name = "txtQDMucDo";
            this.txtQDMucDo.Size = new System.Drawing.Size(203, 22);
            this.txtQDMucDo.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(522, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(158, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "Số tiền phạt/đền bù:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(573, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Mức độ:";
            // 
            // txtQDMa
            // 
            this.txtQDMa.Location = new System.Drawing.Point(275, 38);
            this.txtQDMa.Name = "txtQDMa";
            this.txtQDMa.Size = new System.Drawing.Size(203, 22);
            this.txtQDMa.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(123, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Mã quy định:";
            // 
            // dgvQD
            // 
            this.dgvQD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQD.Location = new System.Drawing.Point(3, 164);
            this.dgvQD.Name = "dgvQD";
            this.dgvQD.RowHeadersWidth = 51;
            this.dgvQD.RowTemplate.Height = 24;
            this.dgvQD.Size = new System.Drawing.Size(1034, 321);
            this.dgvQD.TabIndex = 0;
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 534);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDanhMuc";
            this.Text = "FrmDanhMuc";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpKhuVuc.ResumeLayout(false);
            this.tpKhuVuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).EndInit();
            this.tpNhanVien.ResumeLayout(false);
            this.tpNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.tpLoaiTienNghi.ResumeLayout(false);
            this.tpLoaiTienNghi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).EndInit();
            this.tpDichVu.ResumeLayout(false);
            this.tpDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.tpQuyDinh.ResumeLayout(false);
            this.tpQuyDinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpKhuVuc;
        private System.Windows.Forms.TabPage tpNhanVien;
        private System.Windows.Forms.TabPage tpLoaiTienNghi;
        private System.Windows.Forms.TabPage tpDichVu;
        private System.Windows.Forms.TabPage tpQuyDinh;
        private System.Windows.Forms.DataGridView dgvKhu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKhuTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKhuMa;
        private System.Windows.Forms.Button btnThemKhu;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNVVaiTro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.TextBox txtLoaiTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoaiMa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvLoaiTN;
        private System.Windows.Forms.Button btnThemLoaiTN;
        private System.Windows.Forms.TextBox txtDVMa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numDVGia;
        private System.Windows.Forms.TextBox txtDVDVT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDVTen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboQDLoai;
        private System.Windows.Forms.TextBox txtQDMucDo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtQDMa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvQD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numQDTien;
        private System.Windows.Forms.Label label16;
    }
}