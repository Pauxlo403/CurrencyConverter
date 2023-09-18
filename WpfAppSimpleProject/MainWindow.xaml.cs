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
using WpfAppSimpleProject.Commons;

namespace WpfAppSimpleProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CurrencyConverter _currencyConverter;
        public MainWindow()
        {
            _currencyConverter = new CurrencyConverter();
            InitializeComponent();

            DataContext = _currencyConverter;
            //var href =  _currencyConverter.BankHrefApi;
        }

        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            // Валюта 2
            string Currency2Current = Currency2.SelectedItem.ToString();
            // Курс валюти рядок
            var CurrencyRow = _currencyConverter.Currencies.Where(x =>
                x.txt == Currency2Current)
                .ToList();
            // Результат сума
            _currencyConverter.Number2 = _currencyConverter.Number1 / CurrencyRow[0].rate;
            _currencyConverter.Number2 = Math.Round(_currencyConverter.Number2, 3);
        }
    }
}
