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
        public Exercise1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            String nutDuocBam = ((Button)sender).Text;
            if (nutDuocBam == "C")
                textBox1.Text = "";
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
            else if (nutDuocBam != "=")
                textBox1.Text += nutDuocBam;
            else if (nutDuocBam == "=")
            {
                try
                {
                    // Tinh ket qua
                    Jace.CalculationEngine ce = new Jace.CalculationEngine();
                    String ketQua = ce.Calculate(textBox1.Text).ToString();
                    textBox1.Text += " = " + ketQua;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bieu thuc: " + textBox1.Text + "Khong Hop le");
                    throw;
                }
            }
        }
    }
}
