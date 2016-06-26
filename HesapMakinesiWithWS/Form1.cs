using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiWithWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* 
            Başkaları tarafından sunulan bir web servisine bağlanılarak
            web service metotları kullanılır ve işlemler gerçekleştirilir.
            XML Web Service'leri asmx uzantılı olur.
            XML Web Service adresi sonuna "?wsdl" yazılarak o web service'i
            ile ilgili tanımlama(metot bilgileri) elde edilebilir.
            .NET bunları bizim için otomatik tanır ve metotları oluşturur.

            Bir web service'i metotlarını kullanabilmek için "....Client" ile biten
            class dan bir instance(new 'leme) yapılır. Sonrasında metotlar kullanılır.

            Calculator Service : http://www.dneonline.com/calculator.asmx
            Calculator Service WSDL : http://www.dneonline.com/calculator.asmx?wsdl
        */

        private CalculatorServiceRef.CalculatorSoapClient client =
                new CalculatorServiceRef.CalculatorSoapClient();

        private CalculatorContext db = new CalculatorContext();

        private void btnToplaHesapla_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(t1.Text);
            int s2 = int.Parse(t2.Text);
            int sonuc = 0;

            // Web Service 'deki topla(add) metodu kullanımı.
            sonuc = client.Add(s1, s2);

            ts.Text = sonuc.ToString();

            Logla(s1, s2, sonuc, "Toplama");
        }

        private void btnCikarHesapla_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(c1.Text);
            int s2 = int.Parse(c2.Text);
            int sonuc = 0;

            // Web Service 'deki çıkarma(subtract) metodu kullanımı.
            sonuc = client.Subtract(s1, s2);

            cs.Text = sonuc.ToString();

            Logla(s1, s2, sonuc, "Çıkarma");
        }

        private void btnCarpHesapla_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(ca1.Text);
            int s2 = int.Parse(ca2.Text);
            int sonuc = 0;

            // Web Service 'deki çarpma(Multiply) metodu kullanımı.
            sonuc = client.Multiply(s1, s2);

            cas.Text = sonuc.ToString();

            Logla(s1, s2, sonuc, "Çarpma");
        }

        private void btnBolHesapla_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(b1.Text);
            int s2 = int.Parse(b2.Text);
            int sonuc = 0;

            // Web Service 'deki bölme(Divide) metodu kullanımı.
            sonuc = client.Divide(s1, s2);

            bs.Text = sonuc.ToString();

            Logla(s1, s2, sonuc, "Bölme");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Veritabanı yoksa oluştur..
            db.Database.CreateIfNotExists();
        }

        private void Logla(int sayi1, int sayi2, int sonuc, string islemTuru)
        {
            CalculatorIslem islem = new CalculatorIslem()
            {
                Sayi1 = sayi1,
                Sayi2 = sayi2,
                Sonuc = sonuc,
                IslemTuru = islemTuru,
                IslemTarihi = DateTime.Now
            };

            db.CalculatorIslemler.Add(islem);
            db.SaveChanges();
        }
    }
}
