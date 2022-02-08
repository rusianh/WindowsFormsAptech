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
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string nutDuocBam = ((Button)sender).Text;
            if(nutDuocBam!= "=")
                textBox1.Text += nutDuocBam;
            else
            {
                //Tinh ra ket qua
                try
                {
                Jace.CalculationEngine ce = new Jace.CalculationEngine();
                String ketQua = ce.Calculate(textBox1.Text.Replace("x","*")).ToString();
                textBox1.Text += "=" + ketQua;
                MessageBox.Show(textBox1.Text);
                textBox1.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bieu thuc " + textBox1.Text + " Khong Hop Le");
                    textBox1.Text = "";
                }
            }
        }
    }
}
