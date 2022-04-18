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
    /// Логика взаимодействия для DriversPage.xaml
    /// </summary>
    public partial class DriversPage : Page
    {
        public DriversPage()
        {
            var DriverList = DBConetext.db.Drivers.ToList();
            InitializeComponent();
            LVDriversInfo.ItemsSource = DriverList;
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.Autorization.Navigate(new DriversEdit(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var peopleToRemove = LVDriversInfo.SelectedItems.Cast<Drivers>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {peopleToRemove.Count()} элементов?", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    DBConetext.db.Drivers.RemoveRange(peopleToRemove);
                    DBConetext.db.SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    LVDriversInfo.ItemsSource = DBConetext.db.Drivers.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void LViewDriver_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Manager.Autorization.Navigate(new DriversEdit(LVDriversInfo.SelectedItem as Drivers));
        }
    }
}
