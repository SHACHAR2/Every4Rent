using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Every4Rent
{
    class PackageModel
    {
        OleDbConnection conn;
        string loggedEmail;
        public PackageModel()
        {
            string path = Directory.GetCurrentDirectory();
            conn = new OleDbConnection(connectionString: @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\Database11.accdb");
        }
        public void login(string email)
        {
            loggedEmail = email;
            //TODO: need adding
        }
        public void logOut()
        {
            loggedEmail = null;
        }
        public string getEmail()
        {
            return loggedEmail;
        }
        /// <summary>
        /// Inserts a new advertisement
        /// </summary>
        /// <param name="adData"></param>
        /// <returns></returns>
        public bool AdInsert(List<Tuple<string,string,string>> adData)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "INSERT INTO AVERTISES (";
            
            int i = 0;
            foreach(Tuple<string,string,string> tup in adData)
            {
                comm.CommandText += tup.Item2;
                if (i < adData.Count)
                    comm.CommandText += ",";
                i++;
            }
            comm.CommandText += ") VALUES (";
            foreach (Tuple<string, string, string> tup in adData)
            {
                if (tup.Item1 == "string")
                    comm.CommandText += " '" + tup.Item2 + "' ";
                else if (tup.Item1 == "int")
                    comm.CommandText += " " + tup.Item2 + " ";
                else
                    comm.CommandText += " " + tup.Item2 + " ";
                if (i < adData.Count)
                    comm.CommandText += ",";
                i++;
            }
            
            return ExeScalar(comm);

            
        }
        internal DataTable userDetail(string email)
        {
            System.Data.OleDb.OleDbCommand comm = new System.Data.OleDb.OleDbCommand();
            comm.CommandType = System.Data.CommandType.Text;
            comm.CommandText = "SELECT * FROM USERS WHERE [Email] = \'" + email + ";";
            comm.Connection = conn;
            conn.Open();
            DataTable result = new DataTable(); ;
            try
            {
                //comm.Connection.Open();
                OleDbDataReader dr = comm.ExecuteReader();
                result.Load(dr);
                return result;
                //MessageBox.Show((string)returnValue);
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }

            //throw new NotImplementedException();
        }
        public bool ProductInsert(string category,List<Tuple<string,string,string>> productData)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "INSERT INTO ";
            //DataTable dt = new DataTable();            
            comm.CommandText += getProdTableName(category);

            comm.CommandText += "(";
            int i = 0;
            foreach(Tuple<string,string,string> tup in productData)
            {
                comm.CommandText += tup.Item2;
                if (i < productData.Count)
                    comm.CommandText += ",";
                i++;
            }
            //int bla;
            i = 0;
            comm.CommandText += " ) VALUES (";
            foreach (Tuple<string, string, string> tup in productData)
            {
                if (tup.Item1 == "string")
                    comm.CommandText += " '" + tup.Item2 + "' ";
                else if (tup.Item1 == "int")
                    comm.CommandText += " " + tup.Item2 + " ";
                else
                    comm.CommandText += " " + tup.Item2 + " ";
                if (i < productData.Count)
                    comm.CommandText += ",";
                i++;
            }
            conn.Open();
            return ExeScalar(comm);

            
        }
        public bool Order(string adNum)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM ADVERTISES WHERE ID = " + adNum + "";
            DataTable dt = new DataTable();            
            dt = ExcuteRead(comm);

            DataRow ad = dt.Rows[0];
            string startDate = dt.Rows[0]["StartDate"].ToString();
            string endDate = dt.Rows[0]["EndDate"].ToString();
            string pref = ad["Preference"].ToString();
            if (pref == "fifo")
            {
                changeTaken(int.Parse(adNum), true);
                return InsertOrder(dt.Rows[0]["owner"].ToString(), int.Parse(adNum), startDate, endDate, "ahhhh");
            }
            else if (pref == "safe")
            {
                return InsertOrder(dt.Rows[0]["owner"].ToString(), int.Parse(adNum), startDate, endDate, "ahhh");
            }
            else if (pref == "conservative")
            {
                int minRank = int.Parse(ad["minRank"].ToString());
                if (toApproveConservativeOrder(minRank, adNum))
                {
                    InsertOrder(dt.Rows[0]["owner"].ToString(), int.Parse(adNum), startDate, endDate, "bad");
                }
                else
                {
                    InsertOrder(dt.Rows[0]["owner"].ToString(), int.Parse(adNum), startDate, endDate, "good");
                }
                return true;
            }
            return false;
        }

        private bool toApproveConservativeOrder(int minRank, string adnum)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM USERS WHERE ID = " + loggedEmail + "";
            DataTable dt = new DataTable();
            conn.Open();
            dt = ExcuteRead(comm);

            int avgRank = int.Parse(dt.Rows[0]["avgRank"].ToString());
            if (avgRank > minRank)
            {
                changeTaken(int.Parse(adnum), true);
                return true;
            }
            return false; ;
        }

        private bool InsertOrder(string owner, int adNum, string startd, string endD, string stat)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "INSERT INTO Ads_Users (Email, Ad number, StartDate, EndDate, Status)";
            comm.CommandText += "VALUES (" + owner + ", " + adNum + ", " + startd + ", " + endD + ", " + stat + " );";
            return ExeScalar(comm);
        }
        /// <summary>
        /// gets all the ads of a certain email address
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public DataTable searchByEmail(string email)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM ADVERTISES WHERE owner = '" + email + "'";
            return ExcuteRead(comm);

        }
        /// <summary>
        /// updates the isTaken status of a certian ad (by entering the ad's number ad the desired status)
        /// </summary>
        /// <param name="num"></param>
        /// <param name="stat"></param>
        public void changeTaken(int num, bool stat)
        {
            string statInt;
            if (stat)
                statInt = "-1";
            else
                statInt = "0";
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "UPDATE ADVERTISES SET isTaken = " + statInt + " WHERE num = " + num.ToString() + " ;";
            ExeScalar(comm);
        }

        //Get all the ads that fit the cratiria
        //public DataTable Search(string category, List<Tuple<string, string, string, string>> searchBy, double minPrice, double MaxPrice)
        //{
        //    OleDbCommand comm = new OleDbCommand();
        //    comm.CommandType = CommandType.Text;
        //    comm.CommandText = "SELECT * FROM ADVERTISES WHERE ";
        //    comm.CommandText += "category = '" + category+"'";
        //    if(MaxPrice != -1)
        //        comm.CommandText += " AND isTaken = 0 " + " AND Price > " + minPrice + " AND Price < " + MaxPrice + " AND num IN (";
        //    else
        //        comm.CommandText += " AND isTaken = 0 AND" + " Price > " + minPrice + " AND num IN (";
        //    comm.CommandText += "SELECT adNum FROM Ads_Package ";
        //    comm.CommandText += "WHERE category = '" + category + "' AND  productNum IN (";
        //    comm.CommandText += "SELECT number From ";
        //    comm.CommandText += getProdTableName(category); //GET THE CATEGORY TABLE NAME

        //    comm.CommandText += " WHERE ";
        //    int i = 0;
        //    foreach (Tuple<string, string, string, string> val in searchBy)
        //    {
        //        if (val.Item1 == "date")
        //        {
        //            comm.CommandText += val.Item2 + " BETWEEN #" + val.Item3 + "# AND #" + val.Item4 + "# ";
        //        }
        //        if (val.Item1 == "int")
        //        {
        //            comm.CommandText += val.Item2 + " = " + val.Item3 + " ";
        //        }
        //        if (val.Item1 == "string")
        //        {
        //            comm.CommandText += val.Item2 + " = '" + val.Item3 + "' ";
        //        }
        //        if (i < searchBy.Count - 1)
        //        {
        //            comm.CommandText += " AND ";
        //        }
        //        i++;
        //    }
        //    comm.CommandText += "));";
        //    return ExcuteRead(comm);
        //}
        public DataTable Search(List<Tuple<string, string, string, string>> dataToAdvertises, List<Tuple<string, string, string, string>> specificData, string minPrice, string maxPrice)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM ADVERTISES WHERE ";
            string category = dataToAdvertises[dataToAdvertises.Count - 1].Item3;
            for (int i = 0; i < dataToAdvertises.Count - 1; i++)
            {
                if (dataToAdvertises[i].Item1 == "int")
                {
                    comm.CommandText += dataToAdvertises[i].Item2 + " = " + dataToAdvertises[i].Item3;
                }
                if (dataToAdvertises[i].Item1 == "string")
                {
                    if (dataToAdvertises[i].Item2.Equals("StartDate"))
                    {
                        comm.CommandText += dataToAdvertises[i].Item2 + " <= '" + dataToAdvertises[i].Item3 + "' AND ";
                    }
                    else if (dataToAdvertises[i].Item2.Equals("EndDate"))
                    {
                        comm.CommandText += dataToAdvertises[i].Item2 + " >= '" + dataToAdvertises[i].Item3 + "' AND ";
                    }
                    else
                        comm.CommandText += dataToAdvertises[i].Item2 + " = '" + dataToAdvertises[i].Item3 + "' AND ";
                }
            }
            comm.CommandText += "category" + " = '" + category + "'";
            if (!minPrice.Equals("") && !maxPrice.Equals(""))
                comm.CommandText += " AND Price > " + minPrice + " AND Price < " + maxPrice;
            else if (!minPrice.Equals("") && maxPrice.Equals(""))
                comm.CommandText += " AND Price > " + minPrice;
            else if (minPrice.Equals("") && !maxPrice.Equals(""))
                comm.CommandText += "AND Price < " + maxPrice;
            comm.CommandText += " AND isTaken = 0 AND num IN (";
            comm.CommandText += "SELECT adNum FROM Ads_Package ";
            comm.CommandText += "WHERE category = '" + category + "' AND  productNum IN (";
            comm.CommandText += "SELECT number From " + category;
            //comm.Connection = conn;
            if (specificData.Count != 0)
            {
                comm.CommandText += " WHERE ";
                int i = 0;
                foreach (Tuple<string, string, string, string> val in specificData)
                {
                    if (val.Item1 == "int")
                    {
                        comm.CommandText += val.Item2 + " = " + val.Item3;
                    }
                    if (val.Item1 == "string")
                    {
                        comm.CommandText += val.Item2 + " = '" + val.Item3 + "'";
                    }
                    if (i < specificData.Count - 1)
                    {
                        comm.CommandText += " AND ";
                    }
                    i++;
                }
            }
            comm.CommandText += "));";
            //conn.Open();
            return ExcuteRead(comm);
            //try
            //{
            //    OleDbDataReader result = comm.ExecuteReader();
            //    DataTable dt = new DataTable();
            //    dt.Load(result);
            //    dt.Columns.Remove("IsTaken");
            //    conn.Close();
            //    return dt;
            //}
            //catch (Exception e)
            //{
            //    conn.Close();
            //    MessageBox.Show(e.ToString());
            //    return null;
            //}
        }
        public void Insert(string category, List<Tuple<string, string, string>> insertData)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "INSERT INTO " + category + " (";
            int i = 0;
            int last = insertData.Capacity;
            foreach (Tuple<string, string, string> col in insertData)
            {
                comm.CommandText += " " + col.Item2 + " ";
                if (i < last - 1)
                {
                    comm.CommandText += ", ";
                }
                i++;
            }
            comm.CommandText += ") VALUES (";
            i = 0;
            last = insertData.Capacity;
            foreach (Tuple<string, string, string> col in insertData)
            {
                string type = col.Item1;
                if (type == "string")
                {
                    comm.CommandText += "'" + col.Item3 + "' ";
                }
                else if (type == "date")
                    comm.CommandText += "#" + col.Item3 + "# ";
                else
                {
                    comm.CommandText += " " + col.Item3 + " ";
                }
                if (i < last - 1)
                {
                    comm.CommandText += ", ";
                }
                i++;
            }
            comm.CommandText += ");";
            ExeScalar(comm);
        }

        public DataTable[] getPackage(string adnumber)
        {
            //ad[0] = adnumber
            //ad[1] = productNumber
            //ad[2] = category
            DataTable[] results = new DataTable[4];
            DataTable adTable = new DataTable();
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM Ads_Package WHERE abNum = " + adnumber + ";";
            ExcuteRead(comm);

            List<string> vihacles = new List<string>();
            List<string> pets = new List<string>();
            List<string> realEstate = new List<string>();
            List<string> secondHand = new List<string>();

            foreach (DataRow row in adTable.Rows)
            {
                if ((string)row[2] == "Pets")
                {
                    pets.Add(row[1].ToString());
                }
                else if ((string)row[2] == "RealEstate")
                {
                    realEstate.Add(row[1].ToString());
                }
                else if ((string)row[2] == "second hand")
                {
                    secondHand.Add(row[1].ToString());
                }
                else if ((string)row[2] == "vehicle")
                {
                    vihacles.Add(row[1].ToString());
                }
                else
                    MessageBox.Show("Error record: category is " + row[2].ToString());
            }
            results[0] = getProductsByCat(pets, "Pets");
            results[1] = getProductsByCat(realEstate, "RealEstate");
            results[2] = getProductsByCat(secondHand, "SecondHand");
            results[3] = getProductsByCat(vihacles, "vehical");
            return results;
        }

        private DataTable getProductsByCat(List<string> products, string category)
        {
            DataTable result = new DataTable();
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM " + category + " ";
            comm.CommandText += "WHERE number IN( ";
            int i = 0;
            foreach (string product in products)
            {
                comm.CommandText += "'" + product + "' ";
                if (i < products.Capacity - 1)
                {
                    comm.CommandText += ", ";
                }
            }
            comm.CommandText += ");";
            DataTable dt = ExcuteRead(comm);
            return dt;

        }

        public bool UpdateAd(string adnum, List<Tuple<string,string,string>> updateData)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "UPDATE ADVERTISES ";
            comm.CommandText += "SET ";
            int i = 0;
            foreach(Tuple<string,string,string> tup in updateData)
            {
                if(tup.Item1 == "string")
                {
                    comm.CommandText += " " + tup.Item2 + " = '" + tup.Item3+"' ";
                }
                else
                    comm.CommandText += " " + tup.Item2 + " = " + tup.Item3 + " ";

                if (i < updateData.Count)
                    comm.CommandText += ", ";
                i++;
            }
            comm.CommandText += ")";

            comm.CommandText += "WHERE num = " + adnum+";";
            return ExeScalar(comm);
            
        }
        /// <summary>
        /// Deletes an ad and ALL the 
        /// </summary>
        /// <param name="packNum"></param>
        /// <returns></returns>
        public bool DeleteAd(int packNum)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM ADVERTISES ";
            comm.CommandText += "WHERE number = " + packNum;
            DataTable result = new DataTable();
            result = ExcuteRead(comm);
            if (result.Rows[0]["owner"].ToString() != loggedEmail)
                return false;
            comm.CommandText = "SELECT * FROM Ads_Package WHERE adNum = " + packNum;
            DataTable products = ExcuteRead(comm);
            foreach(DataRow row in products.Rows)
            {
                DeleteProductsByNumber(int.Parse(row["ProductNum"].ToString()), row["category"].ToString());
            }
            
            comm.CommandText = "DELETE FROM ADVERTISES WHERE num = " + packNum;
            ///////////////////////////NEED FINISHING

            return false;
        }
        /// <summary>
        /// Only deletes the product if the logged email is matching the owners of the product.
        /// </summary>
        /// <param name="prodNum"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool DeleteSpecificProductBy(int prodNum,string category)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM Ads_Package";
            comm.CommandText += "WHERE number = " + prodNum+" AND category = "+category+";";
            
            DataTable result = new DataTable();
            result = ExcuteRead(comm);
            string adnum = result.Rows[0]["adNum"].ToString();
            comm.CommandText = "SELECT * FROM ADVERTISES";
            comm.CommandText = "WHERE num = " + adnum + ";";
            
            result = ExcuteRead(comm);
            if (result.Rows[0]["owner"].ToString() != loggedEmail)
                return false;
            else
            {
                DeleteProductsByNumber(prodNum, category);
                comm.CommandText = "DELETE FROM Ads_Package WHERE adNum = " + adnum + " AND productNum = " + prodNum + ";";
                ExeScalar(comm);
            }
                

            return false;
        }
        private bool DeleteProductsByNumber(int prodNum,string category)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            
            comm.CommandText = "DELETE FROM" + getProdTableName(category);
            comm.CommandText += "WHERE number = " + prodNum;
            
            return ExeScalar(comm);

            
        }
        public DataTable allAdsByDate()
        {
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM ADVERTISES ORDER BY PublishDate;";
            DataTable dt = ExcuteRead(comm);
            dt.Columns.Remove("isTaken");
            return dt;
            
        }

        private string getProdTableName(string category)
        {
            if (category == "SecondHand")
            {
                return " SecondHand ";
            }
            else if (category == "RealEstate")
            {
                return " RealEstate ";
            }
            else if (category == "Pets")
            {
                return " Pets ";
            }
            else if (category == " Vehicles")
            {
                return " Vehical ";
            }
            else
                return "ERROR";
        }
        private DataTable ExcuteRead(OleDbCommand comm)
        {
            comm.Connection = conn;
            conn.Open();
            DataTable result = new DataTable();
            try
            {
                OleDbDataReader r = comm.ExecuteReader();
                result.Load(r);
                conn.Close();
                return result;
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        private bool ExeScalar(OleDbCommand comm)
        {
            comm.Connection=conn;
            conn.Open();
            try
            {
                comm.ExecuteScalar();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public DataTable getProductsByCategory(string category, int number)
        {
            DataTable result = new DataTable();
            OleDbCommand comm = new OleDbCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM " + category + " ";
            comm.CommandText += "WHERE number IN (SELECT productNum FROM Ads_Package WHERE adNum = " + number + " );";
            result = ExcuteRead(comm);
            return result;
        }


    }
}