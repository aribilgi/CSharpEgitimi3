using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders19Events
{
    class Product
    {
        public delegate void StockControl();
        private int _stok;
        public Product(int stok) // ctor + tab tab constructor kurucu metot oluşturma kısayolu
        {
            // Kurucu metot class new lenerek nesne oluşturulduğunda çalışır
            _stok = stok;
        }
        public event StockControl StockControlEvent; //Olay oluşturuldu
        public string ProductName { get; set; }
        public int Stok
        {
            get { return _stok; }
            set
            {
                _stok = value;
                if (value <= 15 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }
        }
        public void Satis(int miktar)
        {
            Stok -= miktar;
            Console.WriteLine("{0} Stok miktarı : {1}", ProductName, Stok);
        }

    }
}
