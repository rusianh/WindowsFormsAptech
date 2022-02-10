﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void baiTap2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaiTap2 frm = new BaiTap2();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void cach2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCach2 frm = new frmCach2();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
