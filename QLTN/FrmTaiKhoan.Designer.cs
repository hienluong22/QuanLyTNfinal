
namespace QLTN
{
    partial class FrmTaiKhoan
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
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.bntedit = new System.Windows.Forms.Button();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comQ = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(200)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-6, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPre);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.bntedit);
            this.panel1.Controls.Add(this.btnaddnew);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTenDN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaTK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 496);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 291);
            this.panel1.TabIndex = 3;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.White;
            this.btnLast.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btnLast.Location = new System.Drawing.Point(252, 2);
            this.btnLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(77, 34);
            this.btnLast.TabIndex = 42;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btnNext.Location = new System.Drawing.Point(170, 2);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(77, 34);
            this.btnNext.TabIndex = 41;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.White;
            this.btnPre.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btnPre.Location = new System.Drawing.Point(87, 2);
            this.btnPre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(77, 34);
            this.btnPre.TabIndex = 40;
            this.btnPre.Text = "Trước";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btnFirst.Location = new System.Drawing.Point(4, 2);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(77, 34);
            this.btnFirst.TabIndex = 39;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFristCH_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.White;
            this.btnupdate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btnupdate.Location = new System.Drawing.Point(720, 105);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(111, 34);
            this.btnupdate.TabIndex = 23;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.White;
            this.btndelete.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btndelete.Location = new System.Drawing.Point(720, 57);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(111, 34);
            this.btndelete.TabIndex = 22;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // bntedit
            // 
            this.bntedit.BackColor = System.Drawing.Color.White;
            this.bntedit.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntedit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.bntedit.Location = new System.Drawing.Point(592, 107);
            this.bntedit.Name = "bntedit";
            this.bntedit.Size = new System.Drawing.Size(111, 34);
            this.bntedit.TabIndex = 21;
            this.bntedit.Text = "Sửa";
            this.bntedit.UseVisualStyleBackColor = false;
            this.bntedit.Click += new System.EventHandler(this.bntedit_Click);
            // 
            // btnaddnew
            // 
            this.btnaddnew.BackColor = System.Drawing.Color.White;
            this.btnaddnew.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btnaddnew.Location = new System.Drawing.Point(592, 57);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(111, 34);
            this.btnaddnew.TabIndex = 20;
            this.btnaddnew.Text = "Thêm";
            this.btnaddnew.UseVisualStyleBackColor = false;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.Location = new System.Drawing.Point(169, 201);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(164, 36);
            this.txtMatKhau.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mật khẩu:";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.ForeColor = System.Drawing.Color.Black;
            this.txtTenDN.Location = new System.Drawing.Point(169, 138);
            this.txtTenDN.Multiline = true;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(164, 36);
            this.txtTenDN.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // txtMaTK
            // 
            this.txtMaTK.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTK.ForeColor = System.Drawing.Color.Black;
            this.txtMaTK.Location = new System.Drawing.Point(169, 74);
            this.txtMaTK.Multiline = true;
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(164, 36);
            this.txtMaTK.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã tài khoản:";
            // 
            // comQ
            // 
            this.comQ.FormattingEnabled = true;
            this.comQ.Location = new System.Drawing.Point(128, 62);
            this.comQ.Name = "comQ";
            this.comQ.Size = new System.Drawing.Size(121, 24);
            this.comQ.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.label5.Location = new System.Drawing.Point(30, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quyền: ";
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTK,
            this.TenDN,
            this.MatKhau,
            this.Quyen});
            this.grdData.Location = new System.Drawing.Point(2, 108);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.RowTemplate.Height = 24;
            this.grdData.Size = new System.Drawing.Size(998, 382);
            this.grdData.TabIndex = 7;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            // 
            // MaTK
            // 
            this.MaTK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaTK.DataPropertyName = "MaTK";
            this.MaTK.HeaderText = "Mã TK";
            this.MaTK.MinimumWidth = 6;
            this.MaTK.Name = "MaTK";
            this.MaTK.Width = 78;
            // 
            // TenDN
            // 
            this.TenDN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenDN.DataPropertyName = "TenDN";
            this.TenDN.HeaderText = "Tên DN";
            this.TenDN.MinimumWidth = 6;
            this.TenDN.Name = "TenDN";
            this.TenDN.Width = 86;
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 95;
            // 
            // Quyen
            // 
            this.Quyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Quyen.DataPropertyName = "Quyen";
            this.Quyen.HeaderText = "Quyền";
            this.Quyen.MinimumWidth = 6;
            this.Quyen.Name = "Quyen";
            this.Quyen.Width = 79;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btnFilter.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(439, 55);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(185, 38);
            this.btnFilter.TabIndex = 24;
            this.btnFilter.Text = "Lọc dữ liệu";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(132)))), ((int)(((byte)(253)))));
            this.btnHuy.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(648, 55);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(185, 38);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "Hủy lọc dữ liệu";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 784);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.comQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmTaiKhoan";
            this.Text = "FrmTaiKhoan";
            this.Load += new System.EventHandler(this.FrmTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button bntedit;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
    }
}