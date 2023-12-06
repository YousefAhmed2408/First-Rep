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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
       masterEntities db = new masterEntities ();
        public Login()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Combo .Text== "User")
            {


                string name = username_txt.Text;
                account a = db.accounts.First(x => x.unamee == username_txt.Text && x.pass == Password_pass.Password);

                if (a.unamee == username_txt.Text && a.pass == Password_pass.Password)
                {
                    user k = new user(name);
                    this.NavigationService.Navigate(k);
                }
                else
                {

                    MessageBox.Show("Wrong input");

                }
            }
            if (Combo.Text=="Admin")
            {
                Admin_ b = db.Admin_.First(x=>x.A_Name== username_txt.Text&&x.A_Pass==Password_pass.Password);
                 if(b.A_Name==username_txt.Text && b.A_Pass ==Password_pass.Password)
                 {
                      Admin g= new Admin();
                    this.NavigationService.Navigate(g);
                 }
            }
        }

        private void Forget_btn_Click(object sender, RoutedEventArgs e)
        {
            Forget ff= new Forget();    
            this.NavigationService.Navigate(ff);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Signup ss = new Signup();
            this.NavigationService.Navigate(ss);
        }
    }
}
