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
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        masterEntities db =new masterEntities();
        public Delete()
        {
            InitializeComponent();
            dg.ItemsSource=db.accounts.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            account a = new account();
            a = db.accounts.Remove(db.accounts.FirstOrDefault(x => x.Phonenumber == phone.Text));
            MessageBox.Show("User deleted succ");
            db.SaveChanges();
            dg.ItemsSource = db.accounts.ToList();
        }
    }
}
