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

namespace tipCalculator8000
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

        private void calculateBtn_Click(object sender, RoutedEventArgs e)
        {
            double billTotal = Convert.ToDouble(totalBox.Text);
            double tipAmount = Convert.ToDouble(TipAmountBox.Text) / 100;
            double result = 0;

            result = (billTotal * tipAmount) + billTotal;

            ResultsTxtBk.Text = "Your bill total will be $" + result;
        }

        private void _10btn_Click(object sender, RoutedEventArgs e)
        {
            TipAmountBox.Text = "10";
        }

        private void _15btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _20btn1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
