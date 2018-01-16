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
    public partial class order : Form
    {
        DataGridViewRow dataGridViewRow1 = new DataGridViewRow();
        private PackageControler packageControl;

        public order(DataGridViewRow dataGridViewRow)
        {
            dataGridViewRow1 = dataGridViewRow;
            packageControl = new PackageControler();
            InitializeComponent();
            DataTable dtVehicle = packageControl.ProductsInPackage("Vehicle", Int32.Parse(dataGridViewRow.Cells[0].Value.ToString()));
            VehicleView.DataSource = dtVehicle;
            DataTable dtPets = packageControl.ProductsInPackage("Pets", Int32.Parse(dataGridViewRow.Cells[0].Value.ToString()));
            PetsView.DataSource = dtPets;
            DataTable dtSecond = packageControl.ProductsInPackage("SecondHand", Int32.Parse(dataGridViewRow.Cells[0].Value.ToString()));
            SecondHandView.DataSource = dtSecond;
            DataTable dtReal = packageControl.ProductsInPackage("RealEstate", Int32.Parse(dataGridViewRow.Cells[0].Value.ToString()));
            RealEstateView.DataSource = dtReal;
        }

        private void button1_Click(object sender, EventArgs e)//submit request
        {
            packageControl.Order(dataGridViewRow1.Cells[0].Value.ToString());
            MessageBox.Show("order was succcefuly submited");
        }
    }
}