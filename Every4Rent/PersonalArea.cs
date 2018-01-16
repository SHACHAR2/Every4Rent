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
    public partial class PersonalArea : Form
    {
        string email = "";
        PackageControler pc;
        string numTodelete = "";
        public PersonalArea(string mail)
        {
            pc = new PackageControler();
            email = mail;
            InitializeComponent();
            DataTable dt = pc.searchAdByEmail(email);
            dataGridView2.DataSource = dt;
            DataTable dt2 = pc.userDetail(email);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[index];
            
        }

        private void button1_Click(object sender, EventArgs e)//create
        {
            CreateAd ca = new CreateAd(pc);
            ca.Show();
        }

        private void button2_Click(object sender, EventArgs e)//delete
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            numTodelete = objTextBox.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pc.DeleteAd(Convert.ToInt32(numTodelete));
        }

        private void button3_Click(object sender, EventArgs e)//update
        {
            UpdateAd up = new UpdateAd(Convert.ToInt32(numTodelete), pc);
            up.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

    }
}
