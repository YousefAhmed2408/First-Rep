using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Page
    {
        masterEntities db=new masterEntities();
        public Signup()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool IsValid(String Pass)
            {
                bool upper, lower, num, sympole;
                upper = lower = num = sympole = false;
                string spatiel = "!@#$%^&*()";
                foreach (char c in Pass)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        upper = true;
                    }
                    else if (c >= 'a' && c <= 'z')
                    {
                        lower = true;
                    }
                    else if (c >= '0' && c <= '9')
                    {
                        num = true;
                    }
                    else if (spatiel.Contains(c))
                    {
                        sympole = true;
                    }
                }
                return upper && lower && num && sympole;
            }
            int age = int.Parse(Age_txt.Text);
            if(age > 18 && age < 60)
            {

                if (Phonenum_txt.Text.Length == 11)
                {
                    if (IsValid (password.Password))
                    {
                        account kok = new account();    
                        kok.unamee = username_txt.Text;
                        kok.pass = password.Password;
                        kok.Phonenumber = Phonenum_txt.Text;
                        kok.age = int.Parse(Age_txt.Text);
                        if (combo.Text == "Male")
                        {
                            kok.gender = "Male";
                        }
                        if (combo.Text == "Female")
                        {
                            kok.gender = "Female";
                        }


                        if (com.Text == "Cairo")
                        {
                            kok.City = "Cairo";
                        }
                        if (com.Text == "giza")
                        {
                            kok.City = "giza";
                        }
                        if (com.Text == "October")
                        {
                            kok.City = "October";
                        }
                        if (com.Text == "Aswan")
                        {
                            kok.City = "Aswan";
                        }
                        if (com.Text == "Luxor")
                        {
                            kok.City = "Luxor";
                        }
                        db.accounts.Add(kok);
                        db.SaveChanges();
                        MessageBox.Show("the data thave saved");
                        Login loginp = new Login();
                        this.NavigationService.Navigate(loginp);

                    }
                    else if (!IsValid(password.Password))
                    {
                        MessageBox.Show("You sould [a-z],[A-Z],[1,9]");
                    }
                }
                else
                {
                    MessageBox.Show("phone number must be from 11 elements");
                }
            }
            else
            {
                MessageBox.Show("Age must be between 18 and 60");
            }
           
            
        }
    }
}
