using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreatorWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            CharacterSheetBox.Clear();
            AbilitiesBox.Clear();
            var proxy = new CharacterCreatorClient();
            var character = proxy.GenerateCharacter(NameBox.Text, comboBox1.Text, int.Parse(AgeBox.Text));
            character.Health = proxy.CalculateHealth(character.Age, character.Level);
            character.Abilities = proxy.GenerateAblities(character.ClassType);

            CharacterSheetBox.Text = $"Name:{character.Name} \r\n Class:{character.ClassType} \r\n Age:{character.Age} \r\n Health:{character.Health} \r\n Level:{character.Level}";
            foreach (var ability in character.Abilities)
            {
                AbilitiesBox.Text += $"{ability}\r\n";
            }
        }
    }
}
