using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoT3CodeLai
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            SplashScreen frm = new SplashScreen();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrEmpty(txtTenNhom.Text)) {
                MessageBox.Show("Khong duoc de trong ten nhom");
                txtTenNhom.Focus();  
                return;
            }
            if(tvNhomQuyen.SelectedNode == null) 
                tvNhomQuyen.Nodes.Add(txtTenNhom.Text);
            else {
                tvNhomQuyen.SelectedNode.Nodes.Add(txtTenNhom.Text);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tpPhanQuyen) {
                lblThongTinNguoiDung.Text = String.Format("Ten: {0} / Nguoi Dung {1}", txtNguoiDung.Text, txtTenDangNhap.Text);
            }
            tvDSQuyen.Nodes.Clear();
            foreach (TreeNode tn in tvNhomQuyen.Nodes) {
                tvDSQuyen.Nodes.Add((TreeNode)tn.Clone());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            
            //tvDSChon.Nodes.Add((TreeNode)tvDSQuyen.SelectedNode.Clone());
            //tvDSQuyen.SelectedNode.Remove();

            //2 viec xu ly chinh 
            //1. Tao mot tree ao chua toan bo tu goc den nhanh dang duoc chon
            //2. So sanh tree ao voi tree dang co voi tvDSchon

            TreeNode nodeDaChon = tvDSChon.SelectedNode;
            string fpath = nodeDaChon.FullPath;
            string[] pathArr = fpath.Split('\\');
            TreeView tempTree = new TreeView();
            foreach(TreeNode node in tvDSChon.Nodes) {
                if(node.FullPath == pathArr[0]) {
                    TreeNode foundNode = (TreeNode)node.Clone();
                    tempTree.Nodes.Add(foundNode);
                    AddTree(pathArr, 1, foundNode);
                    break;
                }
            }
        }

        void AddTree(string[] pathArr, int level, TreeNode node) 
        {
            if (level >= pathArr.Length) return;
            string[] pathArrHienTai = new string[level + 1];
            Array.Copy(pathArr, pathArrHienTai, level + 1);
            string pathHienTai = string.Join("\\", pathArrHienTai);
            while (true) {
                bool timThay = false;
                int i = 0;
                for ( ; i<node.Nodes.Count;i++) {
                    break;
                }
                if(i >= node.Nodes.Count) {

                }
            }
        }

        StringBuilder sb = new StringBuilder();
        private void btnSave_Click(object sender, EventArgs e)
        {
            sb.Clear();
            foreach (TreeNode tn in tvDSChon.Nodes)
                BuildPath(tn);
            MessageBox.Show("Cac quyen da chon la: \n" + sb.ToString());
        }
        
        void BuildPath(TreeNode tn)
        {
            if (tn.Nodes.Count > 0)
                foreach (TreeNode t in tn.Nodes) BuildPath(t);
            else sb.AppendLine(tn.FullPath);
            
        }
    }
}
