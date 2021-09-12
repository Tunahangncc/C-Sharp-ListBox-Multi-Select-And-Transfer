using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_FinalUygulamasi3
{
    public partial class Katilimci : Form
    {

        public Katilimci()
        {
            InitializeComponent();
        }
        //Değişkenler
        int Sayi;

        //İşlemler
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Form1.KullaniciListesi.Clear();
            Form1.OgrenciListesi.Clear();
            lstKatilimcilar.Items.Clear();
            this.Close();
        }
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            MesajBlogu();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Olaylar
        private void Katilimci_Load(object sender, EventArgs e)
        {
            bilgiMessaji2("NASIL KULLANILIR","Yan menüde bulunan onaylama işlemi doluluk oranını verir",btnOnayla);
            for(int i=0; i<Form1.KullaniciListesi.Count; i++)
            {
                lstKatilimcilar.Items.Add(Form1.KullaniciListesi[i]);
            }

            Sayi = Form1.KullaniciListesi.Count;
            lblSayi.Text = Sayi.ToString();

            DolulukOrani();

        }


        //Fonksiyonlar
        ToolTip bilgiMessaji2(string baslik, string aciklama, Control nesne)
        {
            ToolTip bilgi = new ToolTip();
            bilgi.Active = true;// görünürlüğü
            bilgi.ToolTipTitle = baslik; // mesaj başlığı
            bilgi.ToolTipIcon = ToolTipIcon.Info;//ikon
            bilgi.UseFading = true;//silik olarak kaybolup yüklenme
            bilgi.UseAnimation = true;
            bilgi.IsBalloon = true;
            bilgi.ShowAlways = true;//her zaman göster
            bilgi.AutoPopDelay = 2500; // mesaj açık kalma süresi
            bilgi.ReshowDelay = 2000; //  mouse çekildiğinde kaç saniye sonra kapanacak
            bilgi.InitialDelay = 900; // mesajın açılma süresi
            bilgi.BackColor = Color.White;
            bilgi.ForeColor = Color.Black;
            bilgi.SetToolTip(nesne, aciklama);//hangi kontrolde görüneceği

            return bilgi;
        }

        private void DolulukOrani()
        {
            if(Sayi < 5)
            {
                btnRenk.BackColor = Color.DarkRed;
            }
            else if(Sayi >=5 && Sayi <= 10)
            {
                btnRenk.BackColor = Color.DarkOrange;
            }
            else if(Sayi > 10)
            {
                btnRenk.BackColor = Color.DarkGreen;
            }
        }
        private void MesajBlogu()
        {
            if (Sayi < 5)
            {
                MessageBox.Show("Katılım oranı çok azdır");
            }
            else if (Sayi >= 5 && Sayi <= 10)
            {
                MessageBox.Show("Katılım oranı orta düzeyde dir");
            }
            else if (Sayi > 10)
            {
                MessageBox.Show("Katılım oranı yeterlidir");
            }
        }
    }
}
