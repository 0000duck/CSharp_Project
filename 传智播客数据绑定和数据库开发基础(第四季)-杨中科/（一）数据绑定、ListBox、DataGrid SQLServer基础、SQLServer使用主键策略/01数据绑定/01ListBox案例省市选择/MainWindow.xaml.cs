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

namespace _01ListBox案例省市选择
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> listProv = new List<string>();
            listProv.Add("山东");           
            listProv.Add("河南");
            listProv.Add("河北");
            lbProv.ItemsSource = listProv;
        }

        private void lbProv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string prov = (string)lbProv.SelectedItem;
            //MessageBox.Show(prov);
            if (prov=="山东")
            {
                List<string> city = new List<string>();
                city.Add("烟台");
                city.Add("济南");
                city.Add("烟台");
                lbCity.ItemsSource = city;
            }
            else if (prov=="河北")
            {
                List<string> city = new List<string>();
                city.Add("石家庄");
                city.Add("保定");
                city.Add("廊坊");
                lbCity.ItemsSource = city;
            }
            else if (prov == "河南")
            {
                List<string> city = new List<string>();
                city.Add("焦作");
                city.Add("郑州");
                city.Add("安阳");
                lbCity.ItemsSource = city;
            }
        }
    }
}
