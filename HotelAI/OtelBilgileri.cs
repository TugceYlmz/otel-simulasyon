using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAI
{
    class OtelBilgileri
    {
        private static string otelIsmi;
        public static string OtelIsmi { get { return otelIsmi; } set { otelIsmi = value; } }
        private static int yildizSayisi;
        public static int YildizSayisi { get { return yildizSayisi; } set { yildizSayisi = value; } }
        private static int odaSayisi;
        public static int OdaSayisi { get { return odaSayisi; } set { odaSayisi = value; } }
        private static string adres;
        public static string Adres { get { return adres; } set { adres = value; } }

    }
}
