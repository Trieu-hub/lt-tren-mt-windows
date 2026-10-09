namespace LoadSinhVien;

partial class frmSinhVien
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        grpThongTin = new GroupBox();
        lblMaSV = new Label();
        txtMaSV = new TextBox();
        lblHoTen = new Label();
        txtHoTen = new TextBox();
        lblLop = new Label();
        txtLop = new TextBox();
        lblDiem = new Label();
        nudDiem = new NumericUpDown();
        btnThem = new Button();
        btnSua = new Button();
        btnXoa = new Button();
        btnNhapMoi = new Button();
        btnLoad = new Button();
        dgvSinhVien = new DataGridView();
        colMaSV = new DataGridViewTextBoxColumn();
        colHoTen = new DataGridViewTextBoxColumn();
        colLop = new DataGridViewTextBoxColumn();
        colDiem = new DataGridViewTextBoxColumn();
        stsTrangThai = new StatusStrip();
        lblTongSo = new ToolStripStatusLabel();
        lblThongBao = new ToolStripStatusLabel();
        grpThongTin.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudDiem).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
        stsTrangThai.SuspendLayout();
        SuspendLayout();
        //
        // grpThongTin
        //
        grpThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        grpThongTin.Controls.Add(lblMaSV);
        grpThongTin.Controls.Add(txtMaSV);
        grpThongTin.Controls.Add(lblHoTen);
        grpThongTin.Controls.Add(txtHoTen);
        grpThongTin.Controls.Add(lblLop);
        grpThongTin.Controls.Add(txtLop);
        grpThongTin.Controls.Add(lblDiem);
        grpThongTin.Controls.Add(nudDiem);
        grpThongTin.Location = new Point(12, 12);
        grpThongTin.Name = "grpThongTin";
        grpThongTin.Size = new Size(736, 125);
        grpThongTin.TabIndex = 0;
        grpThongTin.TabStop = false;
        grpThongTin.Text = "Thông tin sinh viên";
        //
        // lblMaSV
        //
        lblMaSV.AutoSize = true;
        lblMaSV.Location = new Point(18, 36);
        lblMaSV.Name = "lblMaSV";
        lblMaSV.Size = new Size(53, 20);
        lblMaSV.TabIndex = 0;
        lblMaSV.Text = "Mã SV:";
        //
        // txtMaSV
        //
        txtMaSV.Location = new Point(90, 33);
        txtMaSV.MaxLength = 10;
        txtMaSV.Name = "txtMaSV";
        txtMaSV.Size = new Size(190, 27);
        txtMaSV.TabIndex = 1;
        //
        // lblHoTen
        //
        lblHoTen.AutoSize = true;
        lblHoTen.Location = new Point(320, 36);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new Size(57, 20);
        lblHoTen.TabIndex = 2;
        lblHoTen.Text = "Họ tên:";
        //
        // txtHoTen
        //
        txtHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtHoTen.Location = new Point(392, 33);
        txtHoTen.MaxLength = 100;
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new Size(326, 27);
        txtHoTen.TabIndex = 3;
        //
        // lblLop
        //
        lblLop.AutoSize = true;
        lblLop.Location = new Point(18, 80);
        lblLop.Name = "lblLop";
        lblLop.Size = new Size(37, 20);
        lblLop.TabIndex = 4;
        lblLop.Text = "Lớp:";
        //
        // txtLop
        //
        txtLop.Location = new Point(90, 77);
        txtLop.MaxLength = 20;
        txtLop.Name = "txtLop";
        txtLop.Size = new Size(190, 27);
        txtLop.TabIndex = 5;
        //
        // lblDiem
        //
        lblDiem.AutoSize = true;
        lblDiem.Location = new Point(320, 80);
        lblDiem.Name = "lblDiem";
        lblDiem.Size = new Size(48, 20);
        lblDiem.TabIndex = 6;
        lblDiem.Text = "Điểm:";
        //
        // nudDiem
        //
        nudDiem.DecimalPlaces = 1;
        nudDiem.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
        nudDiem.Location = new Point(392, 77);
        nudDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
        nudDiem.Name = "nudDiem";
        nudDiem.Size = new Size(100, 27);
        nudDiem.TabIndex = 7;
        //
        // btnThem
        //
        btnThem.Location = new Point(12, 149);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(100, 36);
        btnThem.TabIndex = 1;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += btnThem_Click;
        //
        // btnSua
        //
        btnSua.Location = new Point(120, 149);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(100, 36);
        btnSua.TabIndex = 2;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = true;
        btnSua.Click += btnSua_Click;
        //
        // btnXoa
        //
        btnXoa.Location = new Point(228, 149);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(100, 36);
        btnXoa.TabIndex = 3;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;
        //
        // btnNhapMoi
        //
        btnNhapMoi.Location = new Point(336, 149);
        btnNhapMoi.Name = "btnNhapMoi";
        btnNhapMoi.Size = new Size(110, 36);
        btnNhapMoi.TabIndex = 4;
        btnNhapMoi.Text = "Nhập mới";
        btnNhapMoi.UseVisualStyleBackColor = true;
        btnNhapMoi.Click += btnNhapMoi_Click;
        //
        // btnLoad
        //
        btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLoad.Location = new Point(598, 149);
        btnLoad.Name = "btnLoad";
        btnLoad.Size = new Size(150, 36);
        btnLoad.TabIndex = 5;
        btnLoad.Text = "Load sinh viên";
        btnLoad.UseVisualStyleBackColor = true;
        btnLoad.Click += btnLoad_Click;
        //
        // dgvSinhVien
        //
        dgvSinhVien.AllowUserToAddRows = false;
        dgvSinhVien.AllowUserToDeleteRows = false;
        dgvSinhVien.AllowUserToResizeRows = false;
        dgvSinhVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvSinhVien.BackgroundColor = Color.White;
        dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { colMaSV, colHoTen, colLop, colDiem });
        dgvSinhVien.Location = new Point(12, 197);
        dgvSinhVien.MultiSelect = false;
        dgvSinhVien.Name = "dgvSinhVien";
        dgvSinhVien.ReadOnly = true;
        dgvSinhVien.RowHeadersVisible = false;
        dgvSinhVien.RowHeadersWidth = 51;
        dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSinhVien.Size = new Size(736, 305);
        dgvSinhVien.TabIndex = 6;
        dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;
        //
        // colMaSV
        //
        colMaSV.DataPropertyName = "MaSV";
        colMaSV.HeaderText = "Mã SV";
        colMaSV.MinimumWidth = 6;
        colMaSV.Name = "colMaSV";
        colMaSV.ReadOnly = true;
        colMaSV.Width = 120;
        //
        // colHoTen
        //
        colHoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colHoTen.DataPropertyName = "HoTen";
        colHoTen.HeaderText = "Họ tên";
        colHoTen.MinimumWidth = 6;
        colHoTen.Name = "colHoTen";
        colHoTen.ReadOnly = true;
        //
        // colLop
        //
        colLop.DataPropertyName = "Lop";
        colLop.HeaderText = "Lớp";
        colLop.MinimumWidth = 6;
        colLop.Name = "colLop";
        colLop.ReadOnly = true;
        colLop.Width = 130;
        //
        // colDiem
        //
        colDiem.DataPropertyName = "Diem";
        dataGridViewCellStyle1.Format = "0.0";
        colDiem.DefaultCellStyle = dataGridViewCellStyle1;
        colDiem.HeaderText = "Điểm";
        colDiem.MinimumWidth = 6;
        colDiem.Name = "colDiem";
        colDiem.ReadOnly = true;
        colDiem.Width = 90;
        //
        // stsTrangThai
        //
        stsTrangThai.ImageScalingSize = new Size(20, 20);
        stsTrangThai.Items.AddRange(new ToolStripItem[] { lblTongSo, lblThongBao });
        stsTrangThai.Location = new Point(0, 514);
        stsTrangThai.Name = "stsTrangThai";
        stsTrangThai.Size = new Size(760, 26);
        stsTrangThai.SizingGrip = false;
        stsTrangThai.TabIndex = 7;
        //
        // lblTongSo
        //
        lblTongSo.Name = "lblTongSo";
        lblTongSo.Size = new Size(141, 20);
        lblTongSo.Text = "Tổng số: 0 sinh viên";
        //
        // lblThongBao
        //
        lblThongBao.Name = "lblThongBao";
        lblThongBao.Size = new Size(604, 20);
        lblThongBao.Spring = true;
        lblThongBao.TextAlign = ContentAlignment.MiddleRight;
        //
        // frmSinhVien
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(760, 540);
        Controls.Add(dgvSinhVien);
        Controls.Add(btnLoad);
        Controls.Add(btnNhapMoi);
        Controls.Add(btnXoa);
        Controls.Add(btnSua);
        Controls.Add(btnThem);
        Controls.Add(grpThongTin);
        Controls.Add(stsTrangThai);
        MinimumSize = new Size(680, 480);
        Name = "frmSinhVien";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản lý sinh viên";
        Shown += frmSinhVien_Shown;
        grpThongTin.ResumeLayout(false);
        grpThongTin.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudDiem).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
        stsTrangThai.ResumeLayout(false);
        stsTrangThai.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox grpThongTin;
    private Label lblMaSV;
    private TextBox txtMaSV;
    private Label lblHoTen;
    private TextBox txtHoTen;
    private Label lblLop;
    private TextBox txtLop;
    private Label lblDiem;
    private NumericUpDown nudDiem;
    private Button btnThem;
    private Button btnSua;
    private Button btnXoa;
    private Button btnNhapMoi;
    private Button btnLoad;
    private DataGridView dgvSinhVien;
    private DataGridViewTextBoxColumn colMaSV;
    private DataGridViewTextBoxColumn colHoTen;
    private DataGridViewTextBoxColumn colLop;
    private DataGridViewTextBoxColumn colDiem;
    private StatusStrip stsTrangThai;
    private ToolStripStatusLabel lblTongSo;
    private ToolStripStatusLabel lblThongBao;
}
