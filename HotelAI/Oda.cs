using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAI
{
    class Oda:OtelBilgileri
    {
        private int oda_no;
        public int Oda_No { get { return oda_no; } set { oda_no = value; } }
        private int oda_boyutu;
        public int Oda_Boyutu { get { return oda_boyutu; } set { oda_boyutu = value; } }
        private Boolean durum;
        public Boolean Durum { get { return durum; } set { durum = value; } }

        public void hazir_hale_getir(Calisan personel, Oda oda) {
            //çalışan veya oda olmazsa temizlik işlemi gerçekleşmez. 
            //odanın hazır hale getirebilinmesi için çalışan ve oda bilgisi bu fonksiyona gönderilir...
            try
            {
                //try-catch deyimi içerisinde oda temizleme işlemi gerçekleştirilir
                personel.temizle(personel, oda);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message); 
                throw;
            }
            

        }

        public void ayırt(Musteri musteri, Oda oda) {
            //bu fonksiyonun kullanılabilmesi için müşteri ve oda bilgileri fonksiyona gönderilir..
            System.Windows.Forms.MessageBox.Show(oda.Oda_No.ToString() +" nolu oda "+ musteri.Isim +" isimli müşteri için ayrıldı.");
        }
    }
}
