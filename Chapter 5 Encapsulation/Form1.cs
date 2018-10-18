using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_5_Encapsulation
{
    public partial class Form1 : Form
    {

        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numericUpDown2.Value, setHealthyOptionCheckBox2.Checked, setCostDecorationCheckBox2.Checked);
            DisplayDinnerPartyCost();
        }
        private void DisplayDinnerPartyCost()
        {
            decimal TotalCost = dinnerParty.Cost();
           TotalCost2.Text = TotalCost.ToString("c");
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void setCostDecorationCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = setCostDecorationCheckBox2.Checked;
            DisplayDinnerPartyCost();
        }

        private void setHealthyOptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = setHealthyOptionCheckBox2.Checked;
            DisplayDinnerPartyCost();
        }
    }
}
