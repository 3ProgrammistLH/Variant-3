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

namespace Кокарев_Вариант_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Attempts = 3;
        public MainWindow()
        {
            InitializeComponent();
            Manager.Autorization = Autorization;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var Username = TBoxLogin.Text;
            var Password = PBoxPass.Password;
            if (!(Username == "inspector" & Password == "inspector"))
            {
                Attempts = Attempts - 1;
                if (Attempts == 0)
                    Application.Current.Shutdown();
                MessageBox.Show($"Неправильно введён логин или пароль \n Попыток осталось = {Attempts}");
                return;
            };
            Manager.Autorization.Navigate(new DriversPage());
            StackPanel.Visibility = Visibility.Hidden;
            Attempts = 5;
        }
    }
}
