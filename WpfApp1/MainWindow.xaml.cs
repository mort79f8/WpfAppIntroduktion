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
using WpfApp1.BIZ;

namespace WpfAppIntroduktion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ classBIZ = new ClassBIZ();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonOpg12_Click(object sender, RoutedEventArgs e)
        {           
            classBIZ.CheckItemSource(listBoxRes);
            classBIZ.Number4711(listBoxRes);
        }

        private void buttonOpg13_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.CheckItemSource(listBoxRes);
            classBIZ.RandomNumbers(listBoxRes);
        }

        private void buttonOpg14_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.CheckItemSource(listBoxRes);
            classBIZ.RandomSortedNumbers(listBoxRes);
        }

        private void buttonOpg15_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.CheckItemSource(listBoxRes);
            classBIZ.ListUnsortedAndSorted(listBoxRes);
        }

        private void buttonOpg16_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.CheckItemSource(listBoxRes);
            classBIZ.RandomNumbersAndAverage(listBoxRes);
        }

        private void buttonOpg17_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.CheckItemSource(listBoxRes);
            classBIZ.RandomNumberMinusAverage(listBoxRes);
        }

        private void buttonOpg18_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.CheckItemSource(listBoxRes);
            listBoxRes.ItemsSource = classBIZ.RandomNumbersMinusAverage();
        }
    }
}
