namespace BaiTapListView
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lvSinhVien = new ListView();
            colLastName = new ColumnHeader();
            colFirstName = new ColumnHeader();
            colPhone = new ColumnHeader();
            grpThongTin = new GroupBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // lvSinhVien
            // 
            lvSinhVien.Columns.AddRange(new ColumnHeader[] { colLastName, colFirstName, colPhone });
            lvSinhVien.Font = new Font("Segoe UI", 10F);
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;
            lvSinhVien.Location = new Point(14, 16);
            lvSinhVien.Margin = new Padding(3, 4, 3, 4);
            lvSinhVien.MultiSelect = false;
            lvSinhVien.Name = "lvSinhVien";
            lvSinhVien.Size = new Size(470, 390);
            lvSinhVien.TabIndex = 0;
            lvSinhVien.UseCompatibleStateImageBehavior = false;
            lvSinhVien.View = View.Details;
            lvSinhVien.SelectedIndexChanged += lvSinhVien_SelectedIndexChanged;
            // 
            // colLastName
            // 
            colLastName.Text = "Last Name";
            colLastName.Width = 170;
            // 
            // colFirstName
            // 
            colFirstName.Text = "First Name";
            colFirstName.Width = 130;
            // 
            // colPhone
            // 
            colPhone.Text = "Phone";
            colPhone.Width = 140;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(lblLastName);
            grpThongTin.Controls.Add(txtLastName);
            grpThongTin.Controls.Add(lblFirstName);
            grpThongTin.Controls.Add(txtFirstName);
            grpThongTin.Controls.Add(lblPhone);
            grpThongTin.Controls.Add(txtPhone);
            grpThongTin.Font = new Font("Segoe UI", 10F);
            grpThongTin.Location = new Point(500, 16);
            grpThongTin.Margin = new Padding(3, 4, 3, 4);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(3, 4, 3, 4);
            grpThongTin.Size = new Size(306, 240);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin sinh viên";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(15, 35);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 23);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(15, 60);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(275, 30);
            txtLastName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(15, 102);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(96, 23);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(15, 127);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(275, 30);
            txtFirstName.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(15, 169);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(63, 23);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(15, 194);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(275, 30);
            txtPhone.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.FlatAppearance.BorderColor = Color.Black;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(500, 270);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 48);
            btnThem.TabIndex = 2;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.FlatAppearance.BorderColor = Color.Black;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F);
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(605, 270);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 48);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.FlatAppearance.BorderColor = Color.Black;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F);
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(711, 270);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 48);
            btnSua.TabIndex = 4;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(820, 422);
            Controls.Add(lvSinhVien);
            Controls.Add(grpThongTin);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài Tập ListView - Quản Lý Sinh Viên";
            Load += Form1_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView lvSinhVien;
        private ColumnHeader colLastName;
        private ColumnHeader colFirstName;
        private ColumnHeader colPhone;
        private GroupBox grpThongTin;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
