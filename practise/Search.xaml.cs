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
    public partial class Search : Page
    {
        masterEntities db = new masterEntities();
        public Search()
        {
            InitializeComponent();
           
        }

        private void search_btn_Click(object sender, RoutedEventArgs e)
        {

            dg.ItemsSource=db.accounts.Where(x=>x.City.Contains(city_txt.Text)).ToList();
       

        }
    }
}
