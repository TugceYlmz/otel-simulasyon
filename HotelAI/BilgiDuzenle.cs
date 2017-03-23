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
    public partial class BilgiDuzenle : Form
    {
        public BilgiDuzenle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //programımız sadece 1 otele bağlı olacağı için statik olarak tanımladığımız otel bilgileri sınıfındaki değişkenlerimizi direkt olarak kullanacağız...
            //statik değişken tek bir değer alabilen değişken oluyor 
            OtelBilgileri.OtelIsmi = textBox1.Text;
            OtelBilgileri.YildizSayisi = Convert.ToInt32(comboBox1.Text);
            OtelBilgileri.OdaSayisi = Convert.ToInt32(textBox3.Text);
            OtelBilgileri.Adres = textBox4.Text;

            MessageBox.Show(OtelBilgileri.OtelIsmi + " isimli oteliniz başarı ile kaydedilmiştir.");

        }

        private void BilgiDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
