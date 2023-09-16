using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Text;

namespace WpfAppSimpleProject.Commons
{
    class CurrencyConverter
    {
        //20200302&json
        private string _href = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?date=";
        private string _fullHref = String.Empty;
        private DateTime _date;
        public ObservableCollection<Currency> Currencies { get; private set; }

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

            Console.WriteLine(currenciesJSONResponse);
        }
    }
}
