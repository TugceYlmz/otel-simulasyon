using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAI
{
    class Calisan
    {
        private string isim;
        public string Isim { get { return isim; } set { isim = value; } }
        private string cinsiyet;
        public string Cinsiyet { get { return cinsiyet; } set { cinsiyet = value; } }
        private int yas;
        public int Yas { get { return yas; } set { yas = value; } }
        private double maas;
        public double Maas { get { return maas; } set { maas = value; } }

        public void temizle(Calisan calisan, Oda oda)
        {
            //temizleme fonksiyonunu kullanmak için fonksiyona oda numarası ve çalışan bilgisi gönderilir
            System.Windows.Forms.MessageBox.Show(oda.Oda_No + " nolu odayı temizleme işleme başarılı." + " Temizleyen : " + calisan.isim);
        }
        public void maas_al(Calisan calisan)
        {
            //çalışan maaş almak için çalışan bilgisini maas_al fonksiyonuna gönderir
            System.Windows.Forms.MessageBox.Show(calisan.isim + " isimli çalışan " + calisan.maas + " miktarında maaş aldı.");
        }
    }
}
