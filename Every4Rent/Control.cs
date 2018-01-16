using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Every4Rent
{

    class Control
    {
        Model m;
        public Control()
        {
            m = new Model();
        }

        public bool Login(string Email, string pass)
        {

            return m.Login(Email, pass);
        }

        internal bool register(List<string> list)
        {
            string fName = list[0];
            string Email = list[3];
            string pPEmail = list[4];
            if (!IsValidEmail(Email) || !IsValidEmail(pPEmail))
            {
                MessageBox.Show("Inavid Email ¯\\_(ツ)_/¯");
                return false;
            }
            for (int i = 0; i < list.Capacity - 1; i++)
            {
                if (String.IsNullOrWhiteSpace(list[i]))
                    return false;
            }
            m.RegEmail(Email, fName);
            string user = list[0] + "~" + list[1] + "~" + list[2] + "~";
            user += list[3] + "~" + list[4] + "~" + list[5] + "~" + list[6];
            m.InsertUser(user, list[7]);
            return true;
            //throw new NotImplementedException();
        }

        internal void addImage(string fileName)
        {
            m.AddImage(fileName);
            //throw new NotImplementedException();
        }

        public void Logout()
        {
            m.Logout();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        internal void deleteProfile()
        {
            m.deleteProfile();
            //throw new NotImplementedException();
        }
        internal string getMail()
        {
            return m.getEmail();
        }

        internal void UpdateProfile(string[] cols, string[] values, string email, int index)
        {
            string str = setStringQuery(cols, values, index);
            bool result = m.UpdateProfile(str, email);
            //throw new NotImplementedException();
        }
        private string setStringQuery(string[] cols, string[] values, int index)
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

    }
}
