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
    public partial class odaEKLE : Form
    {
        public odaEKLE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //burada odamızı veriler sınıfındaki odalar listesine ekliyor fakat başka sayfalardan erişim sağlayamadım.
            Oda oda = new Oda(); //yeni bir oda oluşturuyoruz...
            oda.Oda_No = Convert.ToInt32( textBox1.Text); //odamızın numarasını belirliyoruz...
            oda.Oda_Boyutu = Convert.ToInt32( textBox2.Text); //odamızın kaç kişilik olduğunu belirtiyoruz...
            oda.Durum = true; //odamızda kalınabilir mi?...
            Veriler veri = new Veriler(); //veriler sınıfından yeni bir veri nesnesi oluşturuyoruz...
            try
            { 
                //try-catch içerisinde  oluşturduğumuz odayı veriler sınıfndaki odalar listesine ekliyoruz...
                veri.odalar.Add(oda);
                MessageBox.Show("Oda başarı ile kaydedildi.");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                throw;
            }
            
        }

        private void odaEKLE_Load(object sender, EventArgs e)
        {

        }
    }
}
