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

namespace _15石头剪刀布
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

        private void btnStone_Click(object sender, RoutedEventArgs e)
        {
            string fist = "石头";
            PlayGame(fist);
        }

        private void PlayGame(string fist)
        {
            //创建玩家对象
            Player p = new Player();
            int playerNumber = p.ChuQuan(fist);
            lblPlayer.Content = fist;

            //创建电脑对象
            Computer cpu = new Computer();
            int cpuNumber = cpu.ChuQuan();
            //将电脑出的拳头的随机数赋值给lblComputer
            lblComputer.Content = cpu.Fist;

            //创建裁判对象
            Judeg jd = new Judeg();
            Result res = jd.GetResult(playerNumber, cpuNumber);
            lblResult.Content = res.ToString();
        }

        private void btnCut_Click(object sender, RoutedEventArgs e)
        {
            string fist = "剪刀";
            PlayGame(fist);
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            string fist = "布";
            PlayGame(fist);
        }
    }
}
