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
        btnLoad = new Button();
        dgvSinhVien = new DataGridView();
        colMaSV = new DataGridViewTextBoxColumn();
        colHoTen = new DataGridViewTextBoxColumn();
        colLop = new DataGridViewTextBoxColumn();
        colLopHoc = new DataGridViewTextBoxColumn();
        colDiem = new DataGridViewTextBoxColumn();
        stsTrangThai = new StatusStrip();
        lblTongSo = new ToolStripStatusLabel();
        lblThongBao = new ToolStripStatusLabel();
        ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
        stsTrangThai.SuspendLayout();
        SuspendLayout();
        //
        // btnLoad
        //
        btnLoad.Location = new Point(12, 12);
        btnLoad.Name = "btnLoad";
        btnLoad.Size = new Size(150, 36);
        btnLoad.TabIndex = 0;
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
        dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { colMaSV, colHoTen, colLop, colLopHoc, colDiem });
        dgvSinhVien.Location = new Point(12, 60);
        dgvSinhVien.MultiSelect = false;
        dgvSinhVien.Name = "dgvSinhVien";
        dgvSinhVien.ReadOnly = true;
        dgvSinhVien.RowHeadersVisible = false;
        dgvSinhVien.RowHeadersWidth = 51;
        dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSinhVien.Size = new Size(736, 442);
        dgvSinhVien.TabIndex = 1;
        dgvSinhVien.CellToolTipTextNeeded += dgvSinhVien_CellToolTipTextNeeded;
        //
        // colMaSV
        //
        colMaSV.DataPropertyName = "MaSV";
        colMaSV.HeaderText = "Mã SV";
        colMaSV.MinimumWidth = 6;
        colMaSV.Name = "colMaSV";
        colMaSV.ReadOnly = true;
        colMaSV.Width = 100;
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
        colLop.Width = 90;
        //
        // colLopHoc
        //
        colLopHoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colLopHoc.DataPropertyName = "LopHoc";
        colLopHoc.FillWeight = 150F;
        colLopHoc.HeaderText = "Lớp học (Class)";
        colLopHoc.MinimumWidth = 6;
        colLopHoc.Name = "colLopHoc";
        colLopHoc.ReadOnly = true;
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
        colDiem.Width = 70;
        //
        // stsTrangThai
        //
        stsTrangThai.ImageScalingSize = new Size(20, 20);
        stsTrangThai.Items.AddRange(new ToolStripItem[] { lblTongSo, lblThongBao });
        stsTrangThai.Location = new Point(0, 514);
        stsTrangThai.Name = "stsTrangThai";
        stsTrangThai.Size = new Size(760, 26);
        stsTrangThai.SizingGrip = false;
        stsTrangThai.TabIndex = 2;
        //
        // lblTongSo
        //
        lblTongSo.Name = "lblTongSo";
        lblTongSo.Size = new Size(138, 20);
        lblTongSo.Text = "Tổng số: 0 sinh viên";
        //
        // lblThongBao
        //
        lblThongBao.Name = "lblThongBao";
        lblThongBao.Size = new Size(607, 20);
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
        Controls.Add(stsTrangThai);
        MinimumSize = new Size(680, 400);
        Name = "frmSinhVien";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Danh sách sinh viên";
        Shown += frmSinhVien_Shown;
        ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
        stsTrangThai.ResumeLayout(false);
        stsTrangThai.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnLoad;
    private DataGridView dgvSinhVien;
    private DataGridViewTextBoxColumn colMaSV;
    private DataGridViewTextBoxColumn colHoTen;
    private DataGridViewTextBoxColumn colLop;
    private DataGridViewTextBoxColumn colLopHoc;
    private DataGridViewTextBoxColumn colDiem;
    private StatusStrip stsTrangThai;
    private ToolStripStatusLabel lblTongSo;
    private ToolStripStatusLabel lblThongBao;
}
