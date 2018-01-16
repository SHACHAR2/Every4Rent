using System;
using System.Collections.Generic;
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
    /// Interaction logic for NewUser.xaml
    /// </summary>
    public partial class NewUser : Window
    {
        private Everything4rent e4r;
        public NewUser(Everything4rent everything4rent)
        {
            e4r = everything4rent;
            InitializeComponent();
        }

        private void Login_click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(LogEmailTB.Text) || String.IsNullOrWhiteSpace(LogPassTB.Password))
            {
                MessageBox.Show("Please Enter Email and Password");
                return;
            }
            e4r.login(LogEmailTB.Text, LogPassTB.Password);

        }

        private void Forgot_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This feature is under construction or destruction");
        }
    }
}
