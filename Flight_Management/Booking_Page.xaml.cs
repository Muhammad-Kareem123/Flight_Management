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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace project
{
    /// <summary>
    /// Interaction logic for booking.xaml
    /// </summary>
    public partial class booking : Page
    {
        public booking()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


        }

        private void txtname_TextChanged(object sender, TextChangedEventArgs e)
        {
            string name;
            name =  txtname.Text;
        }

        private void txtdate_TextChanged(object sender, TextChangedEventArgs e)
        {
             
          string date_of_birth = txtdate.Text;
        }

        private void txtcity_TextChanged(object sender, TextChangedEventArgs e)
        {
            string Departure_City;
            Departure_City = txtcity.Text;
        }

        private void txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string city;
            city = txt.Text;
        }
    }
}
