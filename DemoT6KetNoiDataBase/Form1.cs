﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoT6KetNoiDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string conectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IT\C#_ToanTap\WinformAptech\WindowsFormsAptech\DemoT6KetNoiDataBase\UserDB.mdf;Integrated Security=True";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbActive_CheckedChanged(object sender, EventArgs e)
        {
            if (cbActive.Checked) cbActive.Text = "Active";
            else cbActive.Text = "Inactive";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(conectionString);
            //SqlCommand sCmd = new SqlCommand("SELECT * FROM Users");
            SqlCommand sqlCommand = sqlCon.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM Users";
            try {
                sqlCon.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                List<Users> list = new List<Users>();
                while (dr.Read()) {
                    list.Add(new Users()
                    {
                        Username = (string)dr["Username"],
                        Password = (string)dr["Password"],
                        FullName = (string)dr["FullName"],
                        Email = (string)dr["Email"],
                        RoleId = (int)dr["RoleId"],
                        Active = (bool)dr["Active"]
                    });
                }
                dataGridView1.DataSource = list;
            }
            catch (Exception) {
            }
            finally { 
                if(sqlCon.State == ConnectionState.Open)
                    try { sqlCon.Close(); } catch(Exception ex) { MessageBox.Show("Loi co so du lieu khong dong dc" + ex.Message); }
            }
        }
    }
}
