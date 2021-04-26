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

namespace DZ1
{
    /// <summary>
    /// Логика взаимодействия для CreateSale.xaml
    /// </summary>
    public partial class CreateSale : Window
    {
        public CreateSale()
        {
            InitializeComponent();
        }

        private void SaleExitButton_Click(object sender, RoutedEventArgs e)
        {
            Sale sale = new Sale();
            sale.Show();
            this.Close();
        }
    }
}
