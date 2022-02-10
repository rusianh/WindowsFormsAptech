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
    public partial class BaiTap2 : Form
    {
        public BaiTap2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (lbWord.Visible) {
                lbWord.Visible = false;
                lbMean.Visible = true;
            }
            else { lbWord.Visible = true; lbMean.Visible = false; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWord.Text) && !string.IsNullOrEmpty(txtMean.Text)) {
                lbWord.Items.Add(txtWord.Text);
                lbMean.Items.Add(txtMean.Text);
            }
        }

        private void lbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbWord.SelectedIndex != -1) {
                int index = lbWord.SelectedIndex;
                string word = lbMean.Items[index].ToString();
                txtDataMean.Text = word;
            }
        }

        private void lbMean_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMean.SelectedIndex != -1) {
                int index = lbMean.SelectedIndex;
                string word = lbWord.Items[index].ToString();
                txtDataMean.Text = word;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text)) return;
            ListBox lb;
            if (lbMean.Visible) lb = lbMean;
            else lb = lbWord; // lb tro den vi tri cua lb word
            for (int i = 0; i < lb.Items.Count; i++) {
                if (lb.Items[i].ToString().ToLower().Contains(txtSearch.Text.ToLower())) {
                    lb.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ListBox lb;
            if (lbMean.Visible) lb = lbMean;
            else lb = lbWord;
            if (lb.SelectedIndex >= 0 && MessageBox.Show("Ban co muon xoa khong", "Confirm", MessageBoxButtons.YesNoCancel) == DialogResult.Yes) {
                int viTriXoa = lb.SelectedIndex;
                lbWord.Items.RemoveAt(viTriXoa);
                lbMean.Items.RemoveAt(viTriXoa);
                MessageBox.Show("Xoa thanh cong!");

            }
        }
    }
}
