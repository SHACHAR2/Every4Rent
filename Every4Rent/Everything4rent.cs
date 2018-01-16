using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Every4Rent
{
    public partial class Everything4rent : Form
    {
        private Control control;
        private PackageControler packageControl;
        bool isLogin;
        string mail = "";
        public Everything4rent()
        {
            control = new Control();
            packageControl = new PackageControler();
            InitializeComponent();
            personalArea.Enabled = false;
            string path = Directory.GetCurrentDirectory();
            DataTable dt = packageControl.getallAdsByDate();
            dataGridView1.DataSource = dt;
            personalArea.Enabled = false;
            dataGridView1.ReadOnly = true;
           // dataGridView1.Enabled = false;
            isLogin = false;

            

            
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_click(object sender, EventArgs e)
        {
            NewUser nU = new NewUser(this);
            
            nU.Show();
            this.Enabled = false;
            //TODO: disable this window
            personalArea.Enabled = true;
            dataGridView1.Enabled = true;
            isLogin = true;
        }

        private void personalArea_Click(object sender, EventArgs e)
        {
            PersonalArea pa = new PersonalArea(control.getMail());
            pa.Show();
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

        internal bool register(List<string> fields)
        {
            return control.register(fields);
            //throw new NotImplementedException();
        }

        internal void AddImage(string fileName)
        {
            control.addImage(fileName);
            //throw new NotImplementedException();
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

        private void SecondHend_Click(object sender, EventArgs e)
        {
            SecondHandSearch secondHandSearch = new SecondHandSearch();
            secondHandSearch.Show();
        }

        //Create account button_click
        private void register_click(object sender, EventArgs e)
        {
            Register r = new Register(this);
            
            r.Show();
            this.Enabled = false;
            
        }

        public void login(string email, string pass)
        {
            if (control.Login(email, pass))
            {
                MessageBox.Show("Welcome");
                mail = email;
                personalArea.Enabled = true;
                dataGridView1.Enabled = true;
            }
        }
        
        public void disp_data(IDataReader data)
        {

          
            DataTable dt = new DataTable();
            
            try
            {
               
                dt.Load(data);
            }
            catch (Exception e)
            {
               
                MessageBox.Show(e.ToString());
            }

            dataGridView1.DataSource = dt;

            


        }
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            order order = new order(selectedRow);
            order.Show();
           // Application.Exit();
        }

        private void Vehicle_Click(object sender, EventArgs e)
        {
            VehicleSearch vehicleSearch = new VehicleSearch();
            vehicleSearch.Show();
        }
    }
}
