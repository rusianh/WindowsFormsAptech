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
    public partial class Exercise2 : Form
    {
        public Exercise2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            if(textBox3.Text != "")
            {
            for (int i = 0; i < listBox1.Items.Count ; i++)
            {
                if (listBox1.Items[i].ToString().StartsWith(textBox3.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    listBox3.Items.Add(listBox2.Items[i]);
                }
            }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //foreach (string s in listBox1.SelectedItems.OfType<string>().ToList())
            //    listBox1.Items.Remove(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (string s in listBox1.SelectedItems.OfType<string>().ToList())
                listBox1.Items.Remove(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
