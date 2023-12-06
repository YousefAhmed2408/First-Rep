using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for Forget.xaml
    /// </summary>
    public partial class Forget : Page
    {
        masterEntities db = new masterEntities();
        public Forget()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            account a = db.accounts.First(x => x.Phonenumber == phone.Text);
            if (fpass.Text == conf.Text)
            {
                a.pass = fpass.Text;
                db.accounts.AddOrUpdate(a);
                db.SaveChanges();
                MessageBox.Show("Update successfuly");
                Login ll = new Login();
                this.NavigationService.Navigate(ll);
            }
            else
            {
                MessageBox.Show("Update Failed");
            }

        }
    }
}

