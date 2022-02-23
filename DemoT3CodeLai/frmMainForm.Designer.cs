namespace DemoT3CodeLai
{
    partial class frmMainForm
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
            if (disposing && (components != null)) {
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Q1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Q2.1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Q2", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Q3.1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Q3.2.1");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Q3.2.2");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Q3.2", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Q3.3");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Q3", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode8});
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpNhomQuyen = new System.Windows.Forms.TabPage();
            this.tvNhomQuyen = new System.Windows.Forms.TreeView();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.btnThemNhom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tpThongTinChung = new System.Windows.Forms.TabPage();
            this.tpPhanQuyen = new System.Windows.Forms.TabPage();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNguoiDung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblThongTinNguoiDung = new System.Windows.Forms.Label();
            this.tvDSQuyen = new System.Windows.Forms.TreeView();
            this.tvDSChon = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpNhomQuyen.SuspendLayout();
            this.tpThongTinChung.SuspendLayout();
            this.tpPhanQuyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpNhomQuyen);
            this.tabControl1.Controls.Add(this.tpThongTinChung);
            this.tabControl1.Controls.Add(this.tpPhanQuyen);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 403);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpNhomQuyen
            // 
            this.tpNhomQuyen.Controls.Add(this.tvNhomQuyen);
            this.tpNhomQuyen.Controls.Add(this.txtTenNhom);
            this.tpNhomQuyen.Controls.Add(this.btnThemNhom);
            this.tpNhomQuyen.Controls.Add(this.label1);
            this.tpNhomQuyen.Location = new System.Drawing.Point(4, 22);
            this.tpNhomQuyen.Name = "tpNhomQuyen";
            this.tpNhomQuyen.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhomQuyen.Size = new System.Drawing.Size(632, 377);
            this.tpNhomQuyen.TabIndex = 0;
            this.tpNhomQuyen.Text = "Nhom Quyen";
            this.tpNhomQuyen.UseVisualStyleBackColor = true;
            // 
            // tvNhomQuyen
            // 
            this.tvNhomQuyen.Location = new System.Drawing.Point(237, 23);
            this.tvNhomQuyen.Name = "tvNhomQuyen";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Q1";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Q2.1";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Q2";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Q3.1";
            treeNode5.Name = "Node8";
            treeNode5.Text = "Q3.2.1";
            treeNode6.Name = "Node9";
            treeNode6.Text = "Q3.2.2";
            treeNode7.Name = "Node6";
            treeNode7.Text = "Q3.2";
            treeNode8.Name = "Node7";
            treeNode8.Text = "Q3.3";
            treeNode9.Name = "Node4";
            treeNode9.Text = "Q3";
            this.tvNhomQuyen.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3,
            treeNode9});
            this.tvNhomQuyen.Size = new System.Drawing.Size(372, 332);
            this.tvNhomQuyen.TabIndex = 2;
            this.tvNhomQuyen.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(40, 23);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(159, 20);
            this.txtTenNhom.TabIndex = 1;
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Location = new System.Drawing.Point(40, 63);
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(81, 24);
            this.btnThemNhom.TabIndex = 1;
            this.btnThemNhom.Text = "Them Nhom";
            this.btnThemNhom.UseVisualStyleBackColor = true;
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten Nhom";
            // 
            // tpThongTinChung
            // 
            this.tpThongTinChung.Controls.Add(this.txtMatKhau);
            this.tpThongTinChung.Controls.Add(this.label4);
            this.tpThongTinChung.Controls.Add(this.txtTenDangNhap);
            this.tpThongTinChung.Controls.Add(this.label3);
            this.tpThongTinChung.Controls.Add(this.txtNguoiDung);
            this.tpThongTinChung.Controls.Add(this.label2);
            this.tpThongTinChung.Location = new System.Drawing.Point(4, 22);
            this.tpThongTinChung.Name = "tpThongTinChung";
            this.tpThongTinChung.Padding = new System.Windows.Forms.Padding(3);
            this.tpThongTinChung.Size = new System.Drawing.Size(632, 377);
            this.tpThongTinChung.TabIndex = 1;
            this.tpThongTinChung.Text = "Thong Tin Chung";
            this.tpThongTinChung.UseVisualStyleBackColor = true;
            // 
            // tpPhanQuyen
            // 
            this.tpPhanQuyen.Controls.Add(this.tvDSChon);
            this.tpPhanQuyen.Controls.Add(this.btnSave);
            this.tpPhanQuyen.Controls.Add(this.btnRemove);
            this.tpPhanQuyen.Controls.Add(this.btnAdd);
            this.tpPhanQuyen.Controls.Add(this.tvDSQuyen);
            this.tpPhanQuyen.Controls.Add(this.lblThongTinNguoiDung);
            this.tpPhanQuyen.Controls.Add(this.label5);
            this.tpPhanQuyen.Location = new System.Drawing.Point(4, 22);
            this.tpPhanQuyen.Name = "tpPhanQuyen";
            this.tpPhanQuyen.Size = new System.Drawing.Size(632, 377);
            this.tpPhanQuyen.TabIndex = 2;
            this.tpPhanQuyen.Text = "Phan Quyen";
            this.tpPhanQuyen.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(29, 423);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(81, 30);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "Gioi Thieu";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(134, 423);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Tat Chuong Trinh";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtNguoiDung
            // 
            this.txtNguoiDung.Location = new System.Drawing.Point(204, 110);
            this.txtNguoiDung.Name = "txtNguoiDung";
            this.txtNguoiDung.Size = new System.Drawing.Size(159, 20);
            this.txtNguoiDung.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ten Dang Nhap";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(204, 153);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(159, 20);
            this.txtTenDangNhap.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nguoi Dung";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(204, 194);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(159, 20);
            this.txtMatKhau.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mat Khau";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nguoi Dung";
            // 
            // lblThongTinNguoiDung
            // 
            this.lblThongTinNguoiDung.AutoSize = true;
            this.lblThongTinNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinNguoiDung.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblThongTinNguoiDung.Location = new System.Drawing.Point(114, 29);
            this.lblThongTinNguoiDung.Name = "lblThongTinNguoiDung";
            this.lblThongTinNguoiDung.Size = new System.Drawing.Size(13, 17);
            this.lblThongTinNguoiDung.TabIndex = 6;
            this.lblThongTinNguoiDung.Text = "-";
            // 
            // tvDSQuyen
            // 
            this.tvDSQuyen.Location = new System.Drawing.Point(35, 51);
            this.tvDSQuyen.Name = "tvDSQuyen";
            this.tvDSQuyen.Size = new System.Drawing.Size(227, 309);
            this.tvDSQuyen.TabIndex = 7;
            // 
            // tvDSChon
            // 
            this.tvDSChon.Location = new System.Drawing.Point(371, 51);
            this.tvDSChon.Name = "tvDSChon";
            this.tvDSChon.Size = new System.Drawing.Size(227, 309);
            this.tvDSChon.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(277, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(277, 181);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(81, 30);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(277, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmMainForm
            // 
            this.AcceptButton = this.btnThemNhom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 487);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMainForm";
            this.Text = "frmMainForm";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpNhomQuyen.ResumeLayout(false);
            this.tpNhomQuyen.PerformLayout();
            this.tpThongTinChung.ResumeLayout(false);
            this.tpThongTinChung.PerformLayout();
            this.tpPhanQuyen.ResumeLayout(false);
            this.tpPhanQuyen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpNhomQuyen;
        private System.Windows.Forms.TabPage tpThongTinChung;
        private System.Windows.Forms.TabPage tpPhanQuyen;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Button btnThemNhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvNhomQuyen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNguoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThongTinNguoiDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView tvDSChon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TreeView tvDSQuyen;
    }
}