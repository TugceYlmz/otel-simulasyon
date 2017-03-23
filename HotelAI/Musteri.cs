using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAI
{
    class Musteri
    {
        //müşteri bilgileri private şekilde tutuluyor public metodlarında get set kullanılara veriler private değişkene yazılır.
        private string isim;
        public string Isim { get { return isim; } set { isim = value; } }
        private int yas;
        public int Yas { get { return yas; } set { yas = value; } }
        private string cinsiyet;
        public string Cinsiyet { get { return cinsiyet; } set { cinsiyet = value; } }
    }
}
