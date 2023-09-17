using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppSimpleProject.Commons
{
    class Currency
    {
        public int r030 { get; set; } // Код валюти
        public string txt { get; set; } // Назва валюти
        public double rate { get; set; } // Курс валюти
        public string cc { get; set; } // Скорочена назва валюти
        public string exchangedate { get; set; }
    }
}
