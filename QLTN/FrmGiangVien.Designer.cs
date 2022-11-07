
namespace QLTN
{
    partial class FrmGiangVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLastCH = new System.Windows.Forms.Button();
            this.btnNextCH = new System.Windows.Forms.Button();
            this.btnPreCH = new System.Windows.Forms.Button();
            this.btnFristCH = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(200)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-7, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1019, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giảng viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnLastCH);
            this.panel1.Controls.Add(this.btnNextCH);
            this.panel1.Controls.Add(this.btnPreCH);
            this.panel1.Controls.Add(this.btnFristCH);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnaddnew);
            this.panel1.Controls.Add(this.txtMaMon);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtNgaySinh);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtTenGV);
            this.panel1.Controls.Add(this.txtMaGV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 446);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 335);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(412, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mã môn";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(129, 252);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 36);
            this.txtEmail.TabIndex = 22;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.button6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(761, 202);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(176, 38);
            this.button6.TabIndex = 21;
            this.button6.Text = "Lọc dữ liệu";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.button5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(761, 251);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 38);
            this.button5.TabIndex = 20;
            this.button5.Text = "Hủy lọc dữ liệu";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.White;
            this.btnupdate.Enabled = false;
            this.btnupdate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btnupdate.Location = new System.Drawing.Point(865, 148);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(108, 34);
            this.btnupdate.TabIndex = 19;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.White;
            this.btndelete.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btndelete.Location = new System.Drawing.Point(865, 91);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(108, 34);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.White;
            this.btnedit.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btnedit.Location = new System.Drawing.Point(719, 151);
            this.btnedit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(99, 34);
            this.btnedit.TabIndex = 17;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnaddnew
            // 
            this.btnaddnew.BackColor = System.Drawing.Color.White;
            this.btnaddnew.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btnaddnew.Location = new System.Drawing.Point(719, 91);
            this.btnaddnew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(99, 34);
            this.btnaddnew.TabIndex = 16;
            this.btnaddnew.Text = "Thêm";
            this.btnaddnew.UseVisualStyleBackColor = false;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.ForeColor = System.Drawing.Color.Black;
            this.txtMaMon.Location = new System.Drawing.Point(504, 192);
            this.txtMaMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaMon.Multiline = true;
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(164, 36);
            this.txtMaMon.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.Location = new System.Drawing.Point(504, 119);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(164, 36);
            this.txtSDT.TabIndex = 10;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.txtNgaySinh.Location = new System.Drawing.Point(504, 45);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgaySinh.Multiline = true;
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(164, 36);
            this.txtNgaySinh.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(129, 191);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(229, 36);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGV.ForeColor = System.Drawing.Color.Black;
            this.txtTenGV.Location = new System.Drawing.Point(129, 123);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenGV.Multiline = true;
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(229, 36);
            this.txtTenGV.TabIndex = 7;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.ForeColor = System.Drawing.Color.Black;
            this.txtMaGV.Location = new System.Drawing.Point(129, 51);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaGV.Multiline = true;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(229, 36);
            this.txtMaGV.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "SĐT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên GV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã GV:";
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.TenGV,
            this.DiaChi,
            this.SDT,
            this.NgaySinh,
            this.MaMon,
            this.Email});
            this.grdData.Location = new System.Drawing.Point(4, 47);
            this.grdData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.RowTemplate.Height = 24;
            this.grdData.Size = new System.Drawing.Size(999, 393);
            this.grdData.TabIndex = 3;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaGV
            // 
            this.MaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.MinimumWidth = 6;
            this.MaGV.Name = "MaGV";
            this.MaGV.Width = 80;
            // 
            // TenGV
            // 
            this.TenGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên GV";
            this.TenGV.MinimumWidth = 6;
            this.TenGV.Name = "TenGV";
            this.TenGV.Width = 86;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.FillWeight = 120F;
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 80;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.FillWeight = 150F;
            this.SDT.HeaderText = "Số ĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 77;
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.FillWeight = 120F;
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // MaMon
            // 
            this.MaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.FillWeight = 120F;
            this.MaMon.HeaderText = "Mã môn";
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            this.MaMon.Width = 87;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 71;
            // 
            // btnLastCH
            // 
            this.btnLastCH.BackColor = System.Drawing.Color.White;
            this.btnLastCH.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btnLastCH.Location = new System.Drawing.Point(276, 2);
            this.btnLastCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLastCH.Name = "btnLastCH";
            this.btnLastCH.Size = new System.Drawing.Size(77, 34);
            this.btnLastCH.TabIndex = 42;
            this.btnLastCH.Text = "Cuối";
            this.btnLastCH.UseVisualStyleBackColor = false;
            // 
            // btnNextCH
            // 
            this.btnNextCH.BackColor = System.Drawing.Color.White;
            this.btnNextCH.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btnNextCH.Location = new System.Drawing.Point(194, 2);
            this.btnNextCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextCH.Name = "btnNextCH";
            this.btnNextCH.Size = new System.Drawing.Size(77, 34);
            this.btnNextCH.TabIndex = 41;
            this.btnNextCH.Text = "Sau";
            this.btnNextCH.UseVisualStyleBackColor = false;
            // 
            // btnPreCH
            // 
            this.btnPreCH.BackColor = System.Drawing.Color.White;
            this.btnPreCH.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btnPreCH.Location = new System.Drawing.Point(111, 2);
            this.btnPreCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreCH.Name = "btnPreCH";
            this.btnPreCH.Size = new System.Drawing.Size(77, 34);
            this.btnPreCH.TabIndex = 40;
            this.btnPreCH.Text = "Trước";
            this.btnPreCH.UseVisualStyleBackColor = false;
            // 
            // btnFristCH
            // 
            this.btnFristCH.BackColor = System.Drawing.Color.White;
            this.btnFristCH.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFristCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btnFristCH.Location = new System.Drawing.Point(28, 2);
            this.btnFristCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFristCH.Name = "btnFristCH";
            this.btnFristCH.Size = new System.Drawing.Size(77, 34);
            this.btnFristCH.TabIndex = 39;
            this.btnFristCH.Text = "Đầu";
            this.btnFristCH.UseVisualStyleBackColor = false;
            // 
            // FrmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 750);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGiangVien";
            this.Text = "FrmGiangVien";
            this.Load += new System.EventHandler(this.FrmGiangVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button btnLastCH;
        private System.Windows.Forms.Button btnNextCH;
        private System.Windows.Forms.Button btnPreCH;
        private System.Windows.Forms.Button btnFristCH;
    }
}