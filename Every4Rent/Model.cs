using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Every4Rent
{
    class Model
    {

        System.Data.OleDb.OleDbConnection conn;
        string image;
        string loggedEmail;


        public Model()
        {
            string path = Directory.GetCurrentDirectory();

            conn = new System.Data.OleDb.OleDbConnection(connectionString: @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\Database11.accdb");

        }
        public string getEmail()
        {
            return loggedEmail;
        }

        public void RegEmail(string Email, string FName)
        {
            string to = Email;
            string from = "everything4rent.pr@gmail.com";
            string subject = "WellCome to Everything4Rent";
            string body = @"The Everything4Rent team wishes you a pleasent day and use on our lovly app! :)";
            MailMessage message = new MailMessage(from, to, subject, body);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            //client.Credentials = CredentialCache.DefaultNetworkCredentials;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            NetworkCredential nc = new NetworkCredential("everything4rent.pr@gmail.com", "omershani");
            client.Credentials = nc;
            client.EnableSsl = true;
            try
            {
                client.Send(message);

                //TabC.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //public string getEmail()
        //{
        //    return loggedEmail;
        //}

        internal bool Login(string email, string password)
        {
            System.Data.OleDb.OleDbCommand comm = new System.Data.OleDb.OleDbCommand();
            comm.CommandType = System.Data.CommandType.Text;
            comm.CommandText = "SELECT [Email], [Password] FROM USERS\nWHERE [Email] = \'" + email + "\' AND [Password] = \'" + password + "\';";
            comm.Connection = conn;
            conn.Open();
            System.Data.OleDb.OleDbDataReader result = null;
            try
            {
                //comm.Connection.Open();
                result = comm.ExecuteReader();

                //MessageBox.Show((string)returnValue);
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show(e.Message);

            }
            //MessageBox.Show("Reader:" + result.ToString()+"\n"+result[0]);
            if (result.HasRows)
            {
                //LOG THE FUCK IN
                conn.Close();
                result.Close();
                loggedEmail = email;
                return true;
            }
            else
            {
                MessageBox.Show("Email and/or password are invalid ¯\\_(ツ)_/¯");
            }
            conn.Close();
            result.Close();
            return false;
            //throw new NotImplementedException();
        }

        internal bool UpdateProfile(string str, string email)
        {
            System.Data.OleDb.OleDbCommand comm = new System.Data.OleDb.OleDbCommand();
            comm.CommandText = "UPDATE USERS SET " + str + "WHERE Email = '" + email + "';";
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
                return false;

            }
            conn.Close();
            return true;
            //throw new NotImplementedException();
        }

        public void InsertUser(string user, string phone)
        {
            System.Data.OleDb.OleDbCommand comm = new System.Data.OleDb.OleDbCommand();
            //Table USERS
            //FirstName, LastName, BirthDate, Email, PPEmail, PPPassword, Password, Phone, Image
            List<string> userVal = SeparateValues(user);

            comm.CommandType = System.Data.CommandType.Text;
            comm.CommandText = "INSERT INTO USERS ([FirstName], [LastName], [BirthDate], [Email], [PPEmail], PPPassword, [Password]";
            string values = "\tVALUES(\'" + userVal[0] + "\',\'" + userVal[1] + "\',\'" + userVal[2] + "\',\'" + userVal[3] + "\',\'" + userVal[4] + "\',\'" + userVal[5] + "\',\'" + userVal[6] + "\'";
            if (!String.IsNullOrWhiteSpace(phone))
            {
                comm.CommandText += ", [Phone]";
                values += ",\'" + userVal[7] + "\'";
            }
            if (!String.IsNullOrWhiteSpace(image))
            {
                comm.CommandText += ", [Image]";
                values += ",\'" + image + "\'"; //Probably need fixing
            }
            comm.CommandText += ")\n";
            values += ")";
            comm.CommandText += values;
            comm.Connection = conn;
            conn.Open();

            //comm.CommandText = "SELECT * FROM USERS";

            try
            {
                //comm.Connection.Open();
                Object returnValue = comm.ExecuteScalar();
                //MessageBox.Show((string)returnValue);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conn.Close();



        }

        internal void AddImage(string fileName)
        {
            image = fileName;

            //throw new NotImplementedException();
        }

        private List<string> SeparateValues(string str)
        {
            List<string> list = new List<string>();
            list = str.Split('~').ToList();
            return list;
        }

        internal void Logout()
        {
            loggedEmail = null;
            //throw new NotImplementedException();
        }

        internal void deleteProfile()
        {
            System.Data.OleDb.OleDbCommand comm = new System.Data.OleDb.OleDbCommand();
            comm.CommandType = System.Data.CommandType.Text;

            comm.Connection = conn;
            comm.CommandText = "DELETE FROM USERS WHERE Email =\'" + loggedEmail + "\'";
            conn.Open();

            try
            {
                //comm.Connection.Open();
                Object returnValue = comm.ExecuteScalar();
                loggedEmail = null;
                image = null;
                //MessageBox.Show((string)returnValue);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conn.Close();
            //TODO: add delete user's item as well
            //throw new NotImplementedException();
        }
    }
}
