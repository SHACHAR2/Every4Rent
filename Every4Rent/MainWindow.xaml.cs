using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;



namespace Every4Rent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //System.Data.OleDb.OleDbConnection conn;
        Model model;
        //Database1Entities dataEntities = new Database1Entities();

        public MainWindow()
        {
            InitializeComponent();
            model = new Model();

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //What happen when loggin in
            if(String.IsNullOrWhiteSpace(LogEmailTB.Text)||String.IsNullOrWhiteSpace(LogPassTB.Password))
            {
                MessageBox.Show("Please Enter Email and Password");
                return;
            }
            if(model.Login(LogEmailTB.Text, LogPassTB.Password))
            {
                MessageBox.Show("Welcome");
                //EveryTab.IsEnabled = true;
                SetTab.IsEnabled = true;
                InboxTab.IsEnabled = true;
                TabC.SelectedIndex = 2;
                myProButt.IsEnabled = true;
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            //register a new User

            //is Email valid
            if(!IsValidEmail(Email.Text) || !IsValidEmail(PPEmail.Text))
            {
                MessageBox.Show("Inavid Email ¯\\_(ツ)_/¯");
                return;
            }

            //is textbox filled
            if(!IsFilledTextboxes())
            {
                MessageBox.Show("Fill all the \"*\" fields \n¯\\_(ツ)_/¯");
                return;
            }
            //send registration email
            model.RegEmail(Email.Text, FNameTB.Text);         //REMOVE COMMENT LATER
            

            //Creating query to insert into the database
            string user = FNameTB.Text + "~" + LNameTB.Text + "~" + BrithdateBox.Text+ "~";
            user += Email.Text + "~" + PPEmail.Text + "~" + PPPassword.Password + "~" + PassTB.Password;
            string phone = PhoneTB.Text;
            model.InsertUser(user, PhoneTB.Text);

            MessageBox.Show("Registration completed \n An Email is Realy sent to you by our SMTP servers :)");
            TabC.SelectedIndex = 0;


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

        //Is the Registration mandatory textboxes are empty
        private bool IsFilledTextboxes()
        {
            if (String.IsNullOrWhiteSpace(FNameTB.Text) || String.IsNullOrWhiteSpace(LNameTB.Text) || String.IsNullOrWhiteSpace(BrithdateBox.Text))
                return false;
            if (String.IsNullOrWhiteSpace(Email.Text) || String.IsNullOrWhiteSpace(PPEmail.Text) || String.IsNullOrWhiteSpace(PPPassword.Password))
                return false;
            if (String.IsNullOrWhiteSpace(PassTB.Password))
                return false;
            return true;
        }
        private void ForgotPass_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This feature is under construction or destruction");
        }

        private void BrowseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            open.Title = "Upload Image to Everything$Rent";
            Nullable<bool> result = open.ShowDialog();
            if (result == true)
            {
                model.AddImage(open.FileName);
                MessageBox.Show("Image Uploaded with success");
            }
            
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            //Closes the Everything4Rent+Settings+inbox
            model.Logout();
            //EveryTab.IsEnabled = false;
            SetTab.IsEnabled = false;
            InboxTab.IsEnabled = false;
            TabC.SelectedIndex = 0;
            myProButt.IsEnabled = false;
        }

        private void UpdateProfile_Click(object sender, RoutedEventArgs e)
        {
            //TODO: open the UpdatePro.xaml
            UpdatePro updateWin = new UpdatePro(this,6,model.getEmail());
            updateWin.Show();

            //TODO: Enable when closing;
            this.IsEnabled = false;
            //With all the data from the user
        }

        private void Delete_Profile_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete\nyour Everything4Rent profile?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                model.deleteProfile();
                //EveryTab.IsEnabled = false;
                SetTab.IsEnabled = false;
                InboxTab.IsEnabled = false;
                TabC.SelectedIndex = 1;
            }
                
        }

        private void TabC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e) //real estate
        {
           /*
            Products form = new Products();
            WindowInteropHelper wih = new WindowInteropHelper(this);
            wih.Owner = form.Handle;
            form.disp_data("Real_Estate");
            form.Show();
           */
        }

        private void WindowsFormsHost_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
        private void Button_Click_2(object sender, RoutedEventArgs e) //real estate
        {

           


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /*
            Products form = new Products();
            WindowInteropHelper wih = new WindowInteropHelper(this);
            wih.Owner = form.Handle;
            form.disp_data("Second hand");
            form.Show();
            */
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           /*
            Products form = new Products();
            WindowInteropHelper wih = new WindowInteropHelper(this);
            wih.Owner = form.Handle;
            form.disp_data("Pets");
            form.Show();
            */
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            /*
            My_Products form = new My_Products(model.getEmail());
            //WindowInteropHelper wih = new WindowInteropHelper(this);
            //wih.Owner = form.Handle;
            form.disp_data();
            form.Show();
            */

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            /*
            Products form = new Products();
            WindowInteropHelper wih = new WindowInteropHelper(this);
            wih.Owner = form.Handle;
            form.disp_data("Vehicle");
            form.Show();
            */
        }
    }
}
