using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoBuoi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = " Xin Chao ";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            lblSo.Text = txtText.Text.Length.ToString();
        }

        private void txtText_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(txtText.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCalculator calc = new frmCalculator();
            calc.Show();
        }

        private void Exercise1_Click(object sender, EventArgs e)
        {
            Exercise1 ex = new Exercise1();
            ex.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exercise2 ex = new Exercise2();
            ex.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
