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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpNhomQuyen = new System.Windows.Forms.TabPage();
            this.tpThongTinChung = new System.Windows.Forms.TabPage();
            this.tpPhanQuyen = new System.Windows.Forms.TabPage();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.btnThemNhom = new System.Windows.Forms.Button();
            this.tvNhomQuyen = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tpNhomQuyen.SuspendLayout();
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
            // tpThongTinChung
            // 
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten Nhom";
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
            // tvNhomQuyen
            // 
            this.tvNhomQuyen.Location = new System.Drawing.Point(237, 23);
            this.tvNhomQuyen.Name = "tvNhomQuyen";
            this.tvNhomQuyen.Size = new System.Drawing.Size(372, 332);
            this.tvNhomQuyen.TabIndex = 2;
            this.tvNhomQuyen.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
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
    }
}