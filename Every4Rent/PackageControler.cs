using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Every4Rent
{
    public class PackageControler
    {
        private PackageModel model;
        
        public PackageControler()
        {
            this.model = new PackageModel();
        }
        ///// <summary>
        ///// get criteria and make search in the data-base 
        ///// </summary>
        ///// <param name="category"></param>
        ///// <param name="inputs"></param>
        ///// <returns></returns>
        //public DataTable search(string category, List<Tuple<string, string>> inputs, double minPrice, double maxPrice)
        //{
        //    List<Tuple<string, string, string, string>> dataToModel = new List<Tuple<string, string, string, string>>();
        //    int dateAdded = 0;
        //    foreach (Tuple<string, string> tup in inputs)
        //    {
        //        string collumnName = tup.Item1;
        //        string value = tup.Item2;
        //        DateTime dT = new DateTime();
        //        //KeyValuePair<string,string> dateDate = new KeyValuePair<string, string>();
        //        string date1 = "";
        //        string date2;
        //        int number = 0;
        //        if (int.TryParse(value, out number))
        //        {
        //            dataToModel.Add(new Tuple<string, string, string, string>("int", collumnName, value, ""));
        //        }
        //        else if (DateTime.TryParse(value, out dT))
        //        {
        //            if (dateAdded == 0)
        //                date1 = value;
        //            else
        //            {
        //                date2 = value;
        //                dataToModel.Add(new Tuple<string, string, string, string>("date", collumnName, date1, date2));
        //            }
        //            dateAdded++;

        //        }
        //        else
        //        {
        //            dataToModel.Add(new Tuple<string, string, string, string>("string", collumnName, value, ""));
        //        }
        //        //TODO: CONVERT INTO TUPLE<String,stirng,stirng,string>
        //        //item1 = datatype
        //        //item2 = column name
        //        //item3 = data
        //        //item4 = if data then = end date
        //    }
        //    DataTable dt = model.Search(category, dataToModel, minPrice, maxPrice);
        //    return dt;
        //}
        /// <summary>
        /// get criteria and make search in the data-base 
        /// </summary>
        /// <param name="category"></param>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public DataTable search(List<Tuple<string, string>> specificCriteria, List<Tuple<string, string>> generalCriteria)
        {
            List<Tuple<string, string, string, string>> dataToAdvertises = new List<Tuple<string, string, string, string>>();
            List<Tuple<string, string, string, string>> specificData = new List<Tuple<string, string, string, string>>();
            int dateAdded = 0;
            string minPrice = "";
            string maxPrice = "";
            string date1 = "";
            string date2 = "";
            foreach (Tuple<string, string> tup in generalCriteria)
            {
                if (tup.Item1.Equals("min"))
                {
                    minPrice = tup.Item2;
                    continue;
                }
                else if (tup.Item1.Equals("max"))
                {
                    maxPrice = tup.Item2;
                    continue;
                }
                string collumnName = tup.Item1;
                string value = tup.Item2;
                DateTime dT = new DateTime();
                //KeyValuePair<string,string> dateDate = new KeyValuePair<string, string>();
                int number = 0;
                if (int.TryParse(value, out number))
                {
                    dataToAdvertises.Add(new Tuple<string, string, string, string>("int", collumnName, value, ""));
                }
             /*   else if (DateTime.TryParse(value, out dT))
                {
                    if (dateAdded == 0)
                        date1 = value;
                    else
                    {
                        date2 = value;
                        dataToAdvertises.Add(new Tuple<string, string, string, string>("date", collumnName, date1, date2));
                    }
                    dateAdded++;

                }*/
                else
                {
                    dataToAdvertises.Add(new Tuple<string, string, string, string>("string", collumnName, value, ""));
                }
                //TODO: CONVERT INTO TUPLE<String,stirng,stirng,string>
                //item1 = datatype
                //item2 = column name
                //item3 = data
                //item4 = if data then = end date
            }
            foreach (Tuple<string, string> tup in specificCriteria)
            {
                string collumnName = tup.Item1;
                string value = tup.Item2;
                DateTime dT = new DateTime();
                //KeyValuePair<string,string> dateDate = new KeyValuePair<string, string>();
                int number = 0;
                if (int.TryParse(value, out number))
                {
                    specificData.Add(new Tuple<string, string, string, string>("int", collumnName, value, ""));
                }
           /*     else if (DateTime.TryParse(value, out dT))
                {
                    if (dateAdded == 0)
                        date1 = value;
                    else
                    {
                        date2 = value;
                        specificData.Add(new Tuple<string, string, string, string>("date", collumnName, date1, date2));
                    }
                    dateAdded++;

                }*/
                else
                {
                    specificData.Add(new Tuple<string, string, string, string>("string", collumnName, value, ""));
                }
                //TODO: CONVERT INTO TUPLE<String,stirng,stirng,string>
                //item1 = datatype
                //item2 = column name
                //item3 = data
                //item4 = if data then = end date
            }
            DataTable dt = model.Search(dataToAdvertises, specificData, minPrice, maxPrice);
            return dt;
        }
        /// <summary>
        /// get email and Search in the dataBase
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public DataTable searchAdByEmail(string email)
        {

            //Validating Email address
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                //.Address == email;
            }
            catch
            {
                MessageBox.Show("invalid Email");
                return null;
            }
            return model.searchByEmail(email);
        }
        public bool DeleteAd(int packNum)
        {
            return model.DeleteAd(packNum);
        }

        internal DataTable userDetail(string email)
        {
            return model.userDetail(email);
        }
        public bool UpdateAd(string adnum, List<Tuple<string, string>> updateData)
        {
            List<Tuple<string, string, string>> dataToAdvertises = new List<Tuple<string, string, string>>();
            string minPrice = "";
            string maxPrice = "";
            foreach (Tuple<string, string> tup in updateData)
            {
                if (tup.Item1.Equals("min"))
                {
                    minPrice = tup.Item2;
                    continue;
                }
                else if (tup.Item1.Equals("max"))
                {
                    maxPrice = tup.Item2;
                    continue;
                }
                string collumnName = tup.Item1;
                string value = tup.Item2;
                int number = 0;
                if (int.TryParse(value, out number))
                {
                    dataToAdvertises.Add(new Tuple<string, string, string>("int", collumnName, value));
                }
                else
                {
                    dataToAdvertises.Add(new Tuple<string, string, string>("string", collumnName, value));
                }

            }
            return model.UpdateAd(adnum, dataToAdvertises);
        }

        public bool InsertAd(List<Tuple<string,string>> adData)
        {
            List<Tuple<string, string, string>> toModel = new List<Tuple<string, string, string>>();
            int bla;
            foreach(Tuple<string,string> tup in adData)
            {
                if(int.TryParse(tup.Item2,out bla))
                {
                    toModel.Add(new Tuple<string, string, string>("int", tup.Item1, tup.Item2));
                }
                else
                    toModel.Add(new Tuple<string, string, string>("string", tup.Item1, tup.Item2));
            }
            return model.AdInsert(toModel);
        }
        public bool InsertProduct(List<Tuple<string,string>> adProduct, string category)
        {
            List<Tuple<string, string, string>> toModel = new List<Tuple<string, string, string>>();
            int bla;
            foreach (Tuple<string, string> tup in adProduct)
            {
                if (int.TryParse(tup.Item2, out bla))
                {
                    toModel.Add(new Tuple<string, string, string>("int", tup.Item1, tup.Item2));
                }
                else
                    toModel.Add(new Tuple<string, string, string>("string", tup.Item1, tup.Item2));
            }
            return model.ProductInsert(category,toModel);
            //return false;
        }

        public bool InsertOrder(string adNum)
        {
            return model.Order(adNum);
        }
        public void login(string email)
        {
            model.login(email);
        }
        public void logout()
        {
            model.logOut();
        }
        public bool Order(string adnum)
        {
            int ad;
            if (int.TryParse(adnum, out ad))
                return model.Order(adnum);
            else
                return false;
        }
        public bool removeProductByCar(string category,string productNum)
        {
            return false;
            //model.DeleteProductsByNumber(int.Parse(productNum), category);
        }

        public DataTable getallAdsByDate()
        {
            return model.allAdsByDate();
        }

        public DataTable ProductsInPackage(string category, int num)
        {
            return model.getProductsByCategory(category, num);
        }

    }
}
