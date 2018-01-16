using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Every4Rent
{
    /// <summary>
    /// Interaction logic for UpdatePro.xaml
    /// </summary>
    public partial class UpdatePro : Window
    {
        MainWindow main;        
        string[] cols;
        string[] values;
        string email;
        int index;
        public UpdatePro(MainWindow mainWindow,int i,string Email)
        {
            main = mainWindow;
            cols = new string[i];
            values = new string[i];
            InitializeComponent();
            this.email = Email;
            index = i;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            main.IsEnabled = true;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(fNtextBox.Text))
                addvalue("FirstName", fNtextBox.Text, 0);
            if (!String.IsNullOrWhiteSpace(lNtextBox1.Text))
                addvalue("LastName", lNtextBox1.Text, 1);
            if (!String.IsNullOrWhiteSpace(passtextBox2.Password))
                addvalue("Password", passtextBox2.Password, 2);
            if (!String.IsNullOrWhiteSpace(phonetextBox3.Text))
                addvalue("Phone", phonetextBox3.Text, 3);
            if (!String.IsNullOrWhiteSpace(pPEmail.Text))
                addvalue("PPEmail", pPEmail.Text, 4);
            if (!String.IsNullOrWhiteSpace(pPPassword.Password))
                addvalue("PPPassword", pPPassword.Password, 5);

            UpdateQuery();
        }

        private void addvalue(string col, string val, int i)
        {
            cols[i] = col;
            values[i] = val;
        }
        private string setStringQuery()
        {
            string q = "";
            for (int i = 0; i < index; i++)
            {
                if (!String.IsNullOrWhiteSpace(cols[i]))
                {
                    q += "[" + cols[i] + "]" + " = '" + values[i] + "', ";
                }

            }
            q = q.Remove(q.Length - 2);
            q += " ";
            return q;
        }

        private void UpdateQuery()
        {
            string path = Directory.GetCurrentDirectory();
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection(connectionString: @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\Database11.accdb");
            System.Data.OleDb.OleDbCommand comm = new System.Data.OleDb.OleDbCommand();
            comm.CommandType = System.Data.CommandType.Text;
            comm.CommandText = "UPDATE USERS SET " + setStringQuery() + "WHERE Email = '" + email + "';";
            comm.Connection = conn;
            conn.Open();
            try
            {
                Object returnValue = comm.ExecuteScalar();
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show(e.Message);
            }
            conn.Close();
        }
    }
}
