namespace Lab03_03
{
    partial class FormAddStudent
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
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblStudentId
            //
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(24, 27);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(56, 13);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Mã Số SV";
            //
            // lblFullName
            //
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(24, 62);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(77, 13);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Tên Sinh Viên";
            //
            // lblFaculty
            //
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(24, 97);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(32, 13);
            this.lblFaculty.TabIndex = 2;
            this.lblFaculty.Text = "Khoa";
            //
            // lblAverageScore
            //
            this.lblAverageScore.AutoSize = true;
            this.lblAverageScore.Location = new System.Drawing.Point(24, 132);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(51, 13);
            this.lblAverageScore.TabIndex = 3;
            this.lblAverageScore.Text = "Điểm TB";
            //
            // txtStudentId
            //
            this.txtStudentId.Location = new System.Drawing.Point(130, 24);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(200, 20);
            this.txtStudentId.TabIndex = 4;
            //
            // txtFullName
            //
            this.txtFullName.Location = new System.Drawing.Point(130, 59);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 20);
            this.txtFullName.TabIndex = 5;
            //
            // cmbFaculty
            //
            this.cmbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Ngôn ngữ Anh",
            "Quản trị kinh doanh"});
            this.cmbFaculty.Location = new System.Drawing.Point(130, 94);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(200, 21);
            this.cmbFaculty.TabIndex = 6;
            //
            // txtAverageScore
            //
            this.txtAverageScore.Location = new System.Drawing.Point(130, 129);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(200, 20);
            this.txtAverageScore.TabIndex = 7;
            //
            // btnAdd
            //
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(130, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 32);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm Mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnExit
            //
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(235, 172);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 32);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            //
            // FormAddStudent
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 226);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAverageScore);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblAverageScore);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblStudentId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Sinh Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}
