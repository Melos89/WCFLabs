using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThousandDaysClientWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DateButton_Click(object sender, EventArgs e)
        {
            var proxy = new NextThousandDaysClient();

            var date = dateBox.Text;

            ResultLabel.Text = proxy.DaysToGo(DateTime.Parse(date)).ToString();
        }
    }
}
