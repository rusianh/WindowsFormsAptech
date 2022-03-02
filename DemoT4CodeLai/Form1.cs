using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoT4CodeLai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViewWeather_Click(object sender, EventArgs e)
        {
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid=8e1908235b6bf2bdd4bfdb4af649a714", txtArea.Text);
            HttpClient client = new HttpClient();
            txtWeather.Text = client.GetStringAsync(url).Result;
            // Lam 2 viec 
            // Cai JSon.net: newtonsoft.Json
            // Chuyen file Json quan ly bang class object
            ClsWeather w =  Newtonsoft.Json.JsonConvert.DeserializeObject<ClsWeather>(txtWeather.Text);
            txtWeather.Text = String.Format("Name: {0} ({1}) \r\nWeather: {2} - {3}", w.name, w.sys.country,w.weather[0].main, w.weather[0].description);
        }
    }
}
