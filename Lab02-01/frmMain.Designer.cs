namespace Lab02_01;

partial class frmMain
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
        dgvNhanVien = new DataGridView();
        colMSNV = new DataGridViewTextBoxColumn();
        colTenNV = new DataGridViewTextBoxColumn();
        colLuongCB = new DataGridViewTextBoxColumn();
        btnThem = new Button();
        btnSua = new Button();
        btnXoa = new Button();
        btnDong = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
        SuspendLayout();
        //
        // dgvNhanVien
        //
        dgvNhanVien.AllowUserToAddRows = false;
        dgvNhanVien.AllowUserToDeleteRows = false;
        dgvNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvNhanVien.BackgroundColor = Color.White;
        dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colMSNV, colTenNV, colLuongCB });
        dgvNhanVien.Location = new Point(12, 12);
        dgvNhanVien.MultiSelect = false;
        dgvNhanVien.Name = "dgvNhanVien";
        dgvNhanVien.ReadOnly = true;
        dgvNhanVien.RowHeadersVisible = false;
        dgvNhanVien.RowHeadersWidth = 51;
        dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvNhanVien.Size = new Size(480, 306);
        dgvNhanVien.TabIndex = 0;
        dgvNhanVien.CellDoubleClick += dgvNhanVien_CellDoubleClick;
        //
        // colMSNV
        //
        colMSNV.DataPropertyName = "MaNV";
        colMSNV.HeaderText = "MSNV";
        colMSNV.MinimumWidth = 6;
        colMSNV.Name = "colMSNV";
        colMSNV.ReadOnly = true;
        colMSNV.Width = 110;
        //
        // colTenNV
        //
        colTenNV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colTenNV.DataPropertyName = "TenNV";
        colTenNV.HeaderText = "Tên NV";
        colTenNV.MinimumWidth = 6;
        colTenNV.Name = "colTenNV";
        colTenNV.ReadOnly = true;
        //
        // colLuongCB
        //
        colLuongCB.DataPropertyName = "LuongCB";
        colLuongCB.HeaderText = "Lương CB";
        colLuongCB.MinimumWidth = 6;
        colLuongCB.Name = "colLuongCB";
        colLuongCB.ReadOnly = true;
        colLuongCB.Width = 130;
        //
        // btnThem
        //
        btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnThem.Location = new Point(506, 12);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(102, 34);
        btnThem.TabIndex = 1;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += btnThem_Click;
        //
        // btnSua
        //
        btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSua.Location = new Point(506, 56);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(102, 34);
        btnSua.TabIndex = 2;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = true;
        btnSua.Click += btnSua_Click;
        //
        // btnXoa
        //
        btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnXoa.Location = new Point(506, 100);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(102, 34);
        btnXoa.TabIndex = 3;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;
        //
        // btnDong
        //
        btnDong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnDong.Location = new Point(506, 144);
        btnDong.Name = "btnDong";
        btnDong.Size = new Size(102, 34);
        btnDong.TabIndex = 4;
        btnDong.Text = "Đóng";
        btnDong.UseVisualStyleBackColor = true;
        btnDong.Click += btnDong_Click;
        //
        // frmMain
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(620, 330);
        Controls.Add(btnDong);
        Controls.Add(btnXoa);
        Controls.Add(btnSua);
        Controls.Add(btnThem);
        Controls.Add(dgvNhanVien);
        Name = "frmMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "List View";
        Load += frmMain_Load;
        ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dgvNhanVien;
    private DataGridViewTextBoxColumn colMSNV;
    private DataGridViewTextBoxColumn colTenNV;
    private DataGridViewTextBoxColumn colLuongCB;
    private Button btnThem;
    private Button btnSua;
    private Button btnXoa;
    private Button btnDong;
}
