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
    /// Логика взаимодействия для DriversEdit.xaml
    /// </summary>
    public partial class DriversEdit : Page
    {
        private static Drivers curDriver;
        public DriversEdit(Drivers driver)
        {

            if (driver == null)
                curDriver = new Drivers();
            else
                curDriver = driver;
            InitializeComponent();
            DataContext = curDriver;
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (curDriver.Идентификатор__GUID_ == 0)
                DBConetext.db.Drivers.Add(curDriver);

            DBConetext.db.SaveChanges();
            Manager.Autorization.GoBack();
        }
    }
}
