using PDV.Taask1.Core;
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

namespace PDV.Taask1.View.Pages.TaskPages
{
    public partial class Task21Page : Page
    {
        public Task21Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }
        private void BtnTask21_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double k = Convert.ToDouble(TbK.Text);
                double p = Convert.ToDouble(TbP.Text);
                double x = Convert.ToDouble(TbX.Text);
                double d = Convert.ToDouble(TbD.Text);

                MessageBox.Show($"Q = {(Math.Sqrt(k + 2.6 * p * Math.Sin(k))) / (x - Math.Pow(3, d))}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbK.Text = string.Empty;
                TbP.Text = string.Empty;
                TbX.Text = string.Empty;
                TbD.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
