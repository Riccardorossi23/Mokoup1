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
using System.IO;

namespace Mokoup1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void btlGreet_Click(object sender, RoutedEventArgs e)
        {
            string fistName = txtFirstname.Text;
            string SurName = txtLastName.Text;
            DateTime data = Giorno_di_nascita.SelectedDate.Value;
            if(data>DateTime.Today)
            {
                MessageBox.Show($"non puoi essere nati,inserire una data valida");
            }
            else if(fistName!=""||SurName!="")
            {
                MessageBox.Show($"hi {fistName} {SurName} {data.ToShortDateString()}");
            }
            else
            {
                MessageBox.Show($"It is not possible, because the fields of existence are not completed");
            }
           
           
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            btnPrint.IsEnabled = true;
        }
    }
}
