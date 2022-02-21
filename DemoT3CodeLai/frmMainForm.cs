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
    }
}
