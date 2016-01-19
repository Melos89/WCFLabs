using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BMICounterWebForm
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {


        }

        protected void BMIButton_Click(object sender, EventArgs e)
        {
            var proxy = new BMICounterClient();

            var bmi = proxy.CalculateBMI(float.Parse(WeightBox.Text),float.Parse(HeightBox.Text));

            ResultLabel.Text += bmi;

        }
    }
}