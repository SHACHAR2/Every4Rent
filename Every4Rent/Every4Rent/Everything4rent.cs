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
    public partial class Everything4rent : Form
    {
        public Everything4rent()
        {
            InitializeComponent();
            personalArea.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void personalArea_Click(object sender, EventArgs e)
        {

        }
        public void IsRegister(bool isRegister)
        {
            if (isRegister)
            {
                personalArea.Enabled = true;
                MessageBox.Show("Welcome");


            }
            else
                MessageBox.Show("User or password are incorrect");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RealEstate_Click(object sender, EventArgs e) // search real-estate
        {
            RealEstateSearch realEstateSearch = new RealEstateSearch();
            realEstateSearch.Show();

        }

        private void Pet_Click(object sender, EventArgs e)
        {
            PetsSearch petsSearch = new PetsSearch();
            petsSearch.Show();
        }
    }
}
