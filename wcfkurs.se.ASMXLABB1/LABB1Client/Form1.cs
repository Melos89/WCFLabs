using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABB1Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WeatherButton_Click(object sender, EventArgs e)
        {
            Labb1Service1.Lab1Service1SoapClient client = new Labb1Service1.Lab1Service1SoapClient();
            WeatherLabel.Text = client.EstimatedWeather();

        }
    }
}
