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

namespace MousePointTestTool
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
        int LNum = 0, CNum = 0, RNum = 0;
        private void button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            RLable_num.Content = ++RNum;
            RightPath.Fill=Brushes.Red;
        }

        private void button_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            RLable_num.Content = ++RNum;
            RightPath.Fill = Brushes.Green;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Middle)
            {
                CLable_num.Content = ++CNum;
                CenterPath.Fill=Brushes.Red;
            }
            if (e.ChangedButton == MouseButton.Left)
            {
                LLable_num.Content = ++LNum;
                LeftPath.Fill=Brushes.Red;
            }
        }

        private void button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Middle)
            {
                CLable_num.Content = ++CNum;
                CenterPath.Fill = Brushes.Green;
            }
            if (e.ChangedButton == MouseButton.Left)
            {
                LLable_num.Content = ++LNum;
                LeftPath.Fill= Brushes.Green;
            }
        }
    }
}
