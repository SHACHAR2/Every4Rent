using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private Everything4rent e4r;
        public Register(Everything4rent e)
        {
            e4r = e;
            InitializeComponent();
        }
        
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            //bool result;
            List<string> fields = new List<string>();
            fields.Add(FNameTB.Text);
            fields.Add(LNameTB.Text);
            fields.Add(BrithdateBox.Text);
            fields.Add(Email.Text);
            fields.Add(PPEmail.Text);
            fields.Add(PPPassword.Password);
            fields.Add(PassTB.Password);
            fields.Add(PhoneTB.Text);
            //result = e4r.register(fields);
            if (e4r.register(fields))
            {
                MessageBox.Show("Registration completed \n An Email is Realy sent to you by our SMTP servers :)");
                //TabC.SelectedIndex = 0;
            }
            

        }

        private void BrowseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            open.Title = "Upload Image to Everything$Rent";
            Nullable<bool> result = open.ShowDialog();
            if (result == true)
            {
                e4r.AddImage(open.FileName);
                MessageBox.Show("Image Uploaded with success");
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e4r.Enabled = true;
            
            //base.
        }

        //protected override void OnClosing(CancelEventArgs e)
        //{
        //    base.OnClosing(e);
        //}

        //protected override void OnClosed(EventArgs e)
        //{
        //    base.OnClosed(e);
            
        //}
    }
}
