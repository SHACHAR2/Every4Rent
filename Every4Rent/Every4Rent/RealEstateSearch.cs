using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Every4Rent
{
    public partial class RealEstateSearch : Form
    {
        string countryChoose = "";
        string peopleAmountChoose = "";
        string sqrtMeter = "";
        string cityChoose = "";
        string startDate = "";
        string startHour = "";
        string endDate = "";
        string endHour = "";
        string selectedCurrency = "";
        string selectedType = "";
        double maxPriceChooose = -1;
        double minPriceChooose = -1;

        public RealEstateSearch()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//choose currency
        {
            selectedCurrency = currnecy.Items[currnecy.SelectedIndex].ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//type
        {
            selectedType = RealType.Items[RealType.SelectedIndex].ToString();
        }

        private void countryTxt_TextChanged(object sender, EventArgs e)//choose country
        {
            TextBox objTextBox = (TextBox)sender;
            countryChoose = objTextBox.Text;
        }

        private void PeopleAm_TextChanged(object sender, EventArgs e)//choose people amount
        {
            TextBox objTextBox = (TextBox)sender;
            peopleAmountChoose = objTextBox.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//choose sqrtMeter
        {
            TextBox objTextBox = (TextBox)sender;
            sqrtMeter = objTextBox.Text;
        }

        private void cityBox_TextChanged(object sender, EventArgs e)//choose city
        {
            TextBox objTextBox = (TextBox)sender;
            cityChoose = objTextBox.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)//choose start date
        {
            startHour = dateTimePicker1.Value.ToShortTimeString();
            startDate = dateTimePicker1.Value.ToShortDateString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)//choose end date
        {
            endHour = dateTimePicker2.Value.ToShortTimeString();
            endDate = dateTimePicker2.Value.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)//search
        {

        }

        private void MaxPrice_TextChanged(object sender, EventArgs e)//choose max price
        {
            TextBox objTextBox = (TextBox)sender;
            maxPriceChooose = Convert.ToDouble(objTextBox.Text);
        }

        private void MinPrice_TextChanged(object sender, EventArgs e)//choose min price
        {
            TextBox objTextBox = (TextBox)sender;
            minPriceChooose = Convert.ToDouble(objTextBox.Text);
        }
    }
}