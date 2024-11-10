using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace Flight_Management
{
    /// <summary>
    /// Interaction logic for ManageBooking.xaml
    /// </summary>
    public partial class ManageBooking
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Bookings bookings = new Bookings();
            
        }
    }
    public partial class ManageBooking : Page
    {
        private static readonly Flight_Management2Entities flight_Management2Entities2 = new Flight_Management2Entities();
        Flight_Management2Entities fM = flight_Management2Entities2;
        public ManageBooking()
        {
            InitializeComponent();
            try
            {
                dg.ItemsSource = fM.Bookings.ToList();
            }
            catch (Exception ex)
            {

            }
        }


    }
}
