using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // otel bilgilerini düzenledikten sonra yenile butonuna tıkladığımızda bu alan çalışarak gerekli öğeleri gösterecektir.
            label2.Text = OtelBilgileri.OtelIsmi;
            label4.Text = OtelBilgileri.YildizSayisi.ToString();
            label6.Text = OtelBilgileri.OdaSayisi.ToString();
            label8.Text = OtelBilgileri.Adres;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form ilk açıldığında otel bilgilerinin boş görünmesi için
            label2.Text = "";
            label4.Text = "";
            label6.Text = "";
            label8.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //otel bilgilerinin düzenlenmesi için bilgidüzenle penceresini açar
            BilgiDuzenle bd1 = new BilgiDuzenle();
            bd1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //oda ekleme penceresini açar
            odaEKLE odaekle = new odaEKLE();
            odaekle.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //temizleme fonksiyonunu kullanmak için oluşturuldu
            // bir çalışan ve bir oda oluşturularak oda sınıfının hazir_hale_getir fonksiyonuna gönderildi 
            Calisan calisan1 = new Calisan();
            Oda oda1 = new Oda();
            oda1.Oda_No = 1;
            oda1.Oda_Boyutu = 3;
            oda1.Durum = false;
            calisan1.Isim = "Mehmet";
            calisan1.Cinsiyet = "Erkek";

            oda1.hazir_hale_getir(calisan1, oda1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // oda rezervasyonu için kullanıldı 
            // oda ve musteri oluşturularak oda sınıfının ayırt fonksiyonuna gönderildi
            Musteri musteri1 = new Musteri();
            musteri1.Isim = "Bir müşteri";
            musteri1.Cinsiyet = "Kadın";
            Oda oda1 = new Oda();
            oda1.Oda_No = 1;
            oda1.Oda_Boyutu = 3;
            oda1.ayırt(musteri1, oda1);
        }
    }
}
