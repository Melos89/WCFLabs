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
    public partial class Extras : Form
    {
        public Extras()
        {
            InitializeComponent();
        }

        private void StopMotionMovieButton_Click(object sender, EventArgs e)
        {
            Lab1ExtrasService1.Extras1ServiceSoapClient client = new Lab1ExtrasService1.Extras1ServiceSoapClient();

            StopMotionMovieTxtBoxResult.Text = client.FindMovies(StopMotionMoviesBox.Text);
        }

        private void FruitButton_Click(object sender, EventArgs e)
        {
            Lab1ExtrasService2.Extras2ServiceSoapClient client = new Lab1ExtrasService2.Extras2ServiceSoapClient();

            FruitResultTextBox.Text = client.FruitFinder(FruitTextBox.Text.FirstOrDefault());
        }

        private void DeadPeopleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lab1ExtrasService3.Extras3ServiceSoapClient client = new Lab1ExtrasService3.Extras3ServiceSoapClient();

            DeadPeopleResultBox.Text = client.FindDeadPeopleByMonth(DeadPeopleComboBox.SelectedText);
        }
    }
}
