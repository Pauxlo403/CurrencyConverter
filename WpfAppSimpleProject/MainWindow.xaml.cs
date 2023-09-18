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
            // Валюта 1
            string Currency1Current = Currency1.SelectedItem.ToString();


            // Валюта 2
            string Currency2Current = Currency2.SelectedItem.ToString();

            // Курс валюти 2 рядок
            var CurrencyRow2 = _currencyConverter.Currencies.Where(x =>
                x.txt == Currency2Current)
                .ToList();

            // Результат сума
            // Якщо валюта 1 - Гривня, то курс беремо зі списку, інакше рахуємо крос-курс
            if (Currency1Current == "Українська гривня")
            {
                _currencyConverter.Number2 = _currencyConverter.Number1 / CurrencyRow2[0].rate;
                _currencyConverter.Number2 = Math.Round(_currencyConverter.Number2, 3);
            }
            else
            {
                // Курс валюти 1 рядок
                var CurrencyRow1 = _currencyConverter.Currencies.Where(x =>
                x.txt == Currency1Current)
                .ToList();

                _currencyConverter.Number2 = _currencyConverter.Number1 * CurrencyRow1[0].rate / CurrencyRow2[0].rate;
                _currencyConverter.Number2 = Math.Round(_currencyConverter.Number2, 3);

            }
        }
    }
}
