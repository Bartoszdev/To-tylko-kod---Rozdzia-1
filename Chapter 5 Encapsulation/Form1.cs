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
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numericUpDown2.Value, setHealthyOptionCheckBox2.Checked, setCostDecorationCheckBox2.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, checkBox1.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }
        private void DisplayDinnerPartyCost()
        {
            decimal TotalCost = dinnerParty.Cost;
           TotalCost2.Text = TotalCost.ToString("c");
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown2.Value;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = checkBox1.Checked;
            DisplayBirthdayPartyCost();
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }
        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal TotalBirthdayPartyCost = birthdayParty.Cost;
            TotalCostBirthday.Text = TotalBirthdayPartyCost.ToString("c");
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
