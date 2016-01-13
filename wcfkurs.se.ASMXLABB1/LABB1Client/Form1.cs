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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddTwoButton_Click(object sender, EventArgs e)
        {
            Lab1Service2.Lab1Service2SoapClient client = new Lab1Service2.Lab1Service2SoapClient();
            AddTwoResultLabel.Text = client.AddFunction(int.Parse(AddTwoBox1.Text),int.Parse(AddTwoBox2.Text)).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddThreeButton_Click(object sender, EventArgs e)
        {
            Lab1Service3.Lab1Service3SoapClient client = new Lab1Service3.Lab1Service3SoapClient();

            AddResultLabel2.Text = client.AddThreeNumbers(int.Parse(AddThreeBox1.Text), int.Parse(AddThreeBox2.Text), int.Parse(AddThreeBox3.Text)).ToString();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            Lab1Service4.Lab1Service4SoapClient client = new Lab1Service4.Lab1Service4SoapClient();

            SubtractResultLabel3.Text = client.Subtract(int.Parse(SubtractBox1.Text),int.Parse(SubtractBox2.Text)).ToString();
        }

        private void FindDayButton_Click(object sender, EventArgs e)
        {
            Lab1Service5.Lab1Service5SoapClient client = new Lab1Service5.Lab1Service5SoapClient();

            NameDayDateLabel.Text = client.DateFinder(NameBox.Text);
        }

        private void GoToExtrasButton_Click(object sender, EventArgs e)
        {
            var extras = new Extras();
            extras.Show();
        }
    }
}
