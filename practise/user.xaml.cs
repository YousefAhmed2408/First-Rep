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

namespace practise
{
    /// <summary>
    /// Interaction logic for user.xaml
    /// </summary>
    public partial class user : Page
    {
        masterEntities proEntities1 = new masterEntities();
        public user(string name)
        {
            InitializeComponent();
             Login login=new Login();
            dg.ItemsSource = proEntities1.accounts.Where(x=> x.unamee == name).ToList();
            label1.Content = "Welcome " + name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login login=new Login();
            this.NavigationService.Navigate(login);
        }
    }
}
