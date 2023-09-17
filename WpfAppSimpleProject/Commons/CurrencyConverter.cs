using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;

namespace WpfAppSimpleProject.Commons
{
    class CurrencyConverter : INotifyPropertyChanged
    {
        //20200302&json
        private string _href = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?date=";
        private string _fullHref = String.Empty;
        private DateTime _date;

        // Список курсів
        private ObservableCollection<Currency> currencies = new ObservableCollection<Currency>();
        public ObservableCollection<Currency> Currencies
        {
            get { return currencies; }
            set
            {
                currencies = value;
                OnPropertyChanged(nameof(Currencies));
            }
        }

        // Список назв валют
        private ObservableCollection<string> currencyNames = new ObservableCollection<string>();
        public ObservableCollection<string> CurrencyNames
        {
            get { return currencyNames; }
            set
            {
                currencyNames = value;
                OnPropertyChanged(nameof(CurrencyNames));
            }
        }

        // Число 1
        private double number1 = 1;
        public double Number1
        {
            get { return number1; }
            set
            {
                number1 = value;
                OnPropertyChanged(nameof(Number1));
            }
        }

        // Число 2
        private double number2;
        public double Number2
        {
            get { return number2; }
            set
            {
                number2 = value;
                OnPropertyChanged(nameof(Number2));
            }
        }

        public CurrencyConverter()
        {
            Date = DateTime.Now;
        }

        public DateTime Date
        {
            get { return _date; }

            set { 
                _date = value;
                _fullHref = _href + _date.ToString("yyyyMMdd") + "&json";
                LoadCurrencies();
            }
        }
        public string BankHrefApi
        {
            get
            {
                return _fullHref;
            }
        }
        private void LoadCurrencies()
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;

            string currenciesJSONResponse = client.DownloadString(_fullHref);

            // Список з JSON-файлу
            Currencies = JsonConvert.DeserializeObject<ObservableCollection<Currency>>(currenciesJSONResponse);

            // Додати Українська гривня до списку
            CurrencyNames.Add("Українська гривня");

            // З загального файлу курсів валют скопіювати назви валют в окремий список
            // для заповнення ComboBox
            foreach (var currency in Currencies)
            {
                CurrencyNames.Add(currency.txt);
            }
            CurrencyNames = new ObservableCollection<string>(CurrencyNames.OrderBy(x => x));
            Console.WriteLine(currenciesJSONResponse);
        }

        // Для оновлення даних на формі
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        #endregion
    }
}