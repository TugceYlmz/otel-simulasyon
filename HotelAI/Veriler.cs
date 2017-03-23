using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAI
{
    class Veriler:OtelBilgileri
    {
        //bu kısımda listeler içinde verileri tutmayı planlıyordum ama liste kullanımını tam bilmediğim için gerçekleştiremedim.

        public List<Musteri> musteriler = new List<Musteri> { };
        public List<Oda> odalar = new List<Oda> { };
        public List<Calisan> calisanlar = new List<Calisan> { };
    }
}
