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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum) {
                progressBar1.Value += 10;
            }
            else {
                timer1.Stop();
                //Chuyen form
                //frmMainForm frmMain = new frmMainForm();
                //this.Hide();
                //frmMain.ShowDialog();
                //Dong Form
                this.Close();
            }
        }
    }
}
