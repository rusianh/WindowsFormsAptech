using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoT2CodeLai
{
    public partial class frmCach2 : Form
    {
        public frmCach2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWord.Text)) {
                MessageBox.Show("Phai nhap word");
                txtWord.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMean.Text)) {
                MessageBox.Show("Phai nhap Mean");
                txtMean.Focus();
                return ;
            }
            lbWord.Items.Add(new TuDien() { Word=txtWord.Text, Mean=txtMean.Text});
            txtMean.Text = "";
            txtWord.Text = "";
            txtWord.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lbWord.SelectedIndex>=0 && MessageBox.Show(String.Format("Ban co chac muon xoa tu{0} ",((TuDien)lbWord.SelectedItem).Word),"Confirm",MessageBoxButtons.YesNo) == DialogResult.Yes) {
                lbWord.Items.RemoveAt(lbWord.SelectedIndex);
                MessageBox.Show("Xoa Thanh Cong");
                txtWord.Focus();
            }
        }

        private void lbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbWord.SelectedIndex < 0) return;
            TuDien tuDuocChon = (TuDien)lbWord.Items[lbWord.SelectedIndex];
            //MessageBox.Show("Da chon: "+tuDuocChon.Word + " co doi tuong string la: "+tuDuocChon.ToString());
            txtDataMean.Text = tuDuocChon.Mean;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearch.Text)) return;
            var dsTimDuoc = lbWord.Items.Cast<TuDien>().Where(x => x.Word.Contains(txtSearch.Text));
            if( dsTimDuoc.Count()<=0) return;
            TuDien t = dsTimDuoc.First();
            lbWord.SelectedItem = t;
        }
    }
}
