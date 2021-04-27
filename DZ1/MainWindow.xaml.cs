using DZ1.Entity;
using DZ1.Models;
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

namespace DZ1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String login = LoginTextBox.Text;
            String password = PasswordBox.Password;

            try
            {
              using (var context=new DataBaseModel())
                {
                    var user = context.Users.FirstOrDefault(_user=>(_user.Login == login && _user.Password == password));
                    if(user != null)
                    {
                        UserSingleton.Instance().Login = login;                     
                        Information information = new Information();
                        information.Show();
                        this.Close();
                    }
                    else
                        throw new Exception("");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введеные вами данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }       
        }

        private void LoginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (PCheckBox.IsChecked == true)
            {
                PasswordBox.Visibility = Visibility.Hidden;
                PasswordTextBox.Visibility = Visibility.Visible;
                PasswordTextBox.Text = PasswordBox.Password;
            }
        }
        private void PCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {     
                PasswordBox.Visibility = Visibility.Visible;
                PasswordTextBox.Visibility = Visibility.Hidden;             
                PasswordBox.Password = PasswordTextBox.Text;             
        }

    }
}
