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
    public partial class UpdateAd : Form
    {
        private PackageControler pc;
        string countryChoose = "";
        string startDate = "";
        string startHour = "";
        string endDate = "";
        string endHour = "";
        string selectedCurrency = "";
        string selectedType = "";
        double price = -1;
        string category = "";
        string currency = "";
        int num = 0;

        public UpdateAd(int num, PackageControler pc)
        {
            InitializeComponent();
            this.pc = pc;
            this.num = num;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedType = comboBox1.Items[comboBox1.SelectedIndex].ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            currency = comboBox2.Items[comboBox2.SelectedIndex].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            startHour = dateTimePicker1.Value.ToShortTimeString();
            startDate = dateTimePicker1.Value.ToShortDateString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            endHour = dateTimePicker2.Value.ToShortTimeString();
            endDate = dateTimePicker2.Value.ToShortDateString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            countryChoose = objTextBox.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            price= Convert.ToDouble(objTextBox.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            category = objTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)//submit
        {
            List<Tuple<string, string>> generalCriteria = new List<Tuple<string, string>>();
            if (DateTime.TryParse(startDate, out DateTime dt1) && DateTime.TryParse(endDate, out DateTime dt2))
            {
                if (dt1 > dt2)
                {
                    MessageBox.Show("Invalid dates");
                    return;
                }
            }
            if (!startDate.Equals(""))
                generalCriteria.Add(new Tuple<string, string>("StartDate", startDate + " " + startHour));
            if (!endDate.Equals(""))
                generalCriteria.Add(new Tuple<string, string>("EndDate", endDate + " " + endHour));
            if (!countryChoose.Equals(""))
                generalCriteria.Add(new Tuple<string, string>("Country", countryChoose));
            if (!selectedCurrency.Equals(""))
                generalCriteria.Add(new Tuple<string, string>("currency", selectedCurrency));
            generalCriteria.Add(new Tuple<string, string>("category", category));
            pc.UpdateAd(num.ToString(), generalCriteria);
        }
    }
}
