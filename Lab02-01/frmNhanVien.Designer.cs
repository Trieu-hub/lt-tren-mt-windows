namespace Lab02_01;

partial class frmNhanVien
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
        lblMSNV = new Label();
        txtMSNV = new TextBox();
        lblTenNV = new Label();
        txtTenNV = new TextBox();
        lblLuongCB = new Label();
        txtLuongCB = new TextBox();
        btnDongY = new Button();
        btnBoQua = new Button();
        SuspendLayout();
        //
        // lblMSNV
        //
        lblMSNV.AutoSize = true;
        lblMSNV.Location = new Point(20, 25);
        lblMSNV.Name = "lblMSNV";
        lblMSNV.Size = new Size(53, 20);
        lblMSNV.TabIndex = 0;
        lblMSNV.Text = "MSNV:";
        //
        // txtMSNV
        //
        txtMSNV.Location = new Point(150, 22);
        txtMSNV.Name = "txtMSNV";
        txtMSNV.Size = new Size(225, 27);
        txtMSNV.TabIndex = 1;
        //
        // lblTenNV
        //
        lblTenNV.AutoSize = true;
        lblTenNV.Location = new Point(20, 68);
        lblTenNV.Name = "lblTenNV";
        lblTenNV.Size = new Size(107, 20);
        lblTenNV.TabIndex = 2;
        lblTenNV.Text = "Tên nhân viên:";
        //
        // txtTenNV
        //
        txtTenNV.Location = new Point(150, 65);
        txtTenNV.Name = "txtTenNV";
        txtTenNV.Size = new Size(225, 27);
        txtTenNV.TabIndex = 3;
        //
        // lblLuongCB
        //
        lblLuongCB.AutoSize = true;
        lblLuongCB.Location = new Point(20, 111);
        lblLuongCB.Name = "lblLuongCB";
        lblLuongCB.Size = new Size(112, 20);
        lblLuongCB.TabIndex = 4;
        lblLuongCB.Text = "Lương căn bản:";
        //
        // txtLuongCB
        //
        txtLuongCB.Location = new Point(150, 108);
        txtLuongCB.Name = "txtLuongCB";
        txtLuongCB.Size = new Size(225, 27);
        txtLuongCB.TabIndex = 5;
        //
        // btnDongY
        //
        btnDongY.Location = new Point(150, 155);
        btnDongY.Name = "btnDongY";
        btnDongY.Size = new Size(105, 32);
        btnDongY.TabIndex = 6;
        btnDongY.Text = "Đồng ý";
        btnDongY.UseVisualStyleBackColor = true;
        btnDongY.Click += btnDongY_Click;
        //
        // btnBoQua
        //
        btnBoQua.Location = new Point(270, 155);
        btnBoQua.Name = "btnBoQua";
        btnBoQua.Size = new Size(105, 32);
        btnBoQua.TabIndex = 7;
        btnBoQua.Text = "Bỏ qua";
        btnBoQua.UseVisualStyleBackColor = true;
        btnBoQua.Click += btnBoQua_Click;
        //
        // frmNhanVien
        //
        AcceptButton = btnDongY;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnBoQua;
        ClientSize = new Size(400, 205);
        Controls.Add(btnBoQua);
        Controls.Add(btnDongY);
        Controls.Add(txtLuongCB);
        Controls.Add(lblLuongCB);
        Controls.Add(txtTenNV);
        Controls.Add(lblTenNV);
        Controls.Add(txtMSNV);
        Controls.Add(lblMSNV);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "frmNhanVien";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Nhân viên";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblMSNV;
    private TextBox txtMSNV;
    private Label lblTenNV;
    private TextBox txtTenNV;
    private Label lblLuongCB;
    private TextBox txtLuongCB;
    private Button btnDongY;
    private Button btnBoQua;
}
