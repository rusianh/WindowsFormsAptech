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
    public partial class Exercise1 : Form
    {
        Double temp;
        public Exercise1()
        {
            InitializeComponent();
            temp = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            String nutDuocBam = ((Button)sender).Text;
            //MessageBox.Show(temp.ToString());

            if (nutDuocBam == "C")
                textBox1.Text = "";
            // Tinh Toan MC MR MS M+
            else if (nutDuocBam == "MC")
            {
                temp = 0;
                textBox1.Text = temp.ToString();
            }
            else if (nutDuocBam == "MR")
            {
                textBox1.Text = temp.ToString();
            }
            else if (nutDuocBam == "MS" && textBox1.Text != "")
            {
                var soLuu = Double.Parse(textBox1.Text);
                temp = soLuu;
                textBox1.Text = temp.ToString();
                MessageBox.Show("Luu thanh cong M = " + temp);
            }
            else if (nutDuocBam == "M+")
            {
                double result = Double.Parse(textBox1.Text) + temp;
                textBox1.Text = result.ToString();
            }
            //End
            else if (nutDuocBam == "sqr")
            {
                Double Result = Math.Sqrt(Double.Parse(textBox1.Text));
                textBox1.Text = Result.ToString();
            }
            else if (nutDuocBam == "Backspace")
            {
                if(textBox1.Text != "")
                {
                int so = textBox1.Text.Count();
                textBox1.Text = textBox1.Text.Remove(so-1, 1);
                }
            }
            else if (nutDuocBam == "1/x")
            {
                Double ketQua = 1/Double.Parse(textBox1.Text);

                textBox1.Text = ketQua.ToString();
            }
            else if (nutDuocBam != "=" && nutDuocBam != "MC" && nutDuocBam != "MR" && nutDuocBam != "MS" && nutDuocBam != "M+")
                textBox1.Text += nutDuocBam;
            else if (nutDuocBam == "=")
            {
                try
                {
                    // Tinh ket qua
                    Jace.CalculationEngine ce = new Jace.CalculationEngine();
                    String ketQua = ce.Calculate(textBox1.Text).ToString();
                    textBox1.Text = ketQua;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bieu thuc: " + textBox1.Text + "Khong Hop le");
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Phep tinh khong hop le");
            }
        }

        private void Exercise1_Load(object sender, EventArgs e)
        {

        }
    }
}
