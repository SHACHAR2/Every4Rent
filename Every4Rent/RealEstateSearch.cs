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
        PackageControler pc = new PackageControler();
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
            List<Tuple<string, string>> specificCriteria = new List<Tuple<string, string>>();
            List<Tuple<string, string>> generalCriteria = new List<Tuple<string, string>>();
            if (DateTime.TryParse(startDate, out DateTime dt1) && DateTime.TryParse(endDate, out DateTime dt2))
            {
                if (dt1 > dt2)
                {
                    MessageBox.Show("Invalid dates");
                    return;
                }
            }
            if (maxPriceChooose < minPriceChooose)
            {
                MessageBox.Show("Max price cannot be smaller than min price");
                return;
            }
            if (!startDate.Equals(""))
                generalCriteria.Add(new Tuple<string, string>("StartDate", startDate + " " + startHour));
            if (!endDate.Equals(""))
                generalCriteria.Add(new Tuple<string, string>("EndDate", endDate + " " + endHour));
            if (!countryChoose.Equals(""))
                generalCriteria.Add(new Tuple<string, string>("Country", countryChoose));
            if (!selectedCurrency.Equals(""))
                generalCriteria.Add(new Tuple<string, string>("currency", selectedCurrency));
            if (minPriceChooose != -1)
                generalCriteria.Add(new Tuple<string, string>("min", minPriceChooose.ToString()));
            if (maxPriceChooose != -1)
                generalCriteria.Add(new Tuple<string, string>("max", maxPriceChooose.ToString()));
            if (!peopleAmountChoose.Equals(""))
                specificCriteria.Add(new Tuple<string, string>("people_amount", peopleAmountChoose));
            if (!sqrtMeter.Equals(""))
                specificCriteria.Add(new Tuple<string, string>("square_meter", sqrtMeter));
            if (!cityChoose.Equals(""))
                specificCriteria.Add(new Tuple<string, string>("city", cityChoose));
            if (!selectedType.Equals(""))
                specificCriteria.Add(new Tuple<string, string>("type", selectedType));
            generalCriteria.Add(new Tuple<string, string>("category", "RealEstate"));
            DataTable dt = pc.search(specificCriteria, generalCriteria);
            dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //order order = new order();
            //order.Show();
        }
    }
}