using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_FinalUygulamasi3
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        //Değişkenler
        Katilimci girisIzni = new Katilimci();
        Random rnd = new Random();
        ArrayList Ogrenciler = new ArrayList();
        int RandomSayi;

        public static ArrayList OgrenciListesi = new ArrayList();
        public static ArrayList KullaniciListesi = new ArrayList();


        //İşlemler
        private void btnOgrenciYenile_Click(object sender, EventArgs e)
        {
            lstOgrenci.Items.Clear();//Eski öğrenci listesini temizliyoruz
            lstKatilimci.Items.Clear();
            Ogrenciler.Clear();//Listeyi temizliyorum. Eğer temizlemezsek yeni kişileri eskileri ile alt alta eklemeye devam eder

            IsımDiz();//isim leri oluşturur


            for (int i = 0; i < Ogrenciler.Count; i++)
            {
                lstOgrenci.Items.Add(Ogrenciler[i]);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            //Bastıkdan 1-2 saniye sonra gelir
            bilgiMessaji("AÇIKLAMA", "Yan menüde bulunan buton random öğrenci oluşturur", btnInfo);
        }

        private void btnTekIleri_Click(object sender, EventArgs e)
        {
            if(lstOgrenci.Items.Count == 0)
            {
                MessageBox.Show("Katılımcı olarak eklenecek isim yok");
            }
            else if(lstOgrenci.Items.Count != 0 && lstOgrenci.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Önce isim seçiniz");
            }
            else
            {
                for(int i=lstOgrenci.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    lstKatilimci.Items.Add(lstOgrenci.SelectedItems[i]);//Seçili itemi taşır
                    lstOgrenci.Items.RemoveAt(lstOgrenci.SelectedIndices[i]);//Seçili item kaldırır
                }
            }
        }
        private void btnTekGeri_Click(object sender, EventArgs e)
        {
            if (lstKatilimci.Items.Count == 0)
            {
                MessageBox.Show("Çıkartılacak katılımcı ismi yok");
            }
            else if(lstKatilimci.Items.Count != 0 && lstKatilimci.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Önce isim seçiniz");
            }
            else
            {
                for (int i = lstKatilimci.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    lstOgrenci.Items.Add(lstKatilimci.SelectedItems[i]);//Seçili itemi taşır
                    lstKatilimci.Items.RemoveAt(lstKatilimci.SelectedIndices[i]);//Seçili item kaldırır
                }
            }
        }
        private void btnCiftGeri_Click(object sender, EventArgs e)
        {
            if (lstKatilimci.Items.Count == 0)
            {
                MessageBox.Show("Çıkartılacak katılımcı ismi yok");
            }
            else
            {
                for(int i=0; i<lstKatilimci.Items.Count; i++)
                {
                    lstOgrenci.Items.Add(lstKatilimci.Items[i]);
                }
                lstKatilimci.Items.Clear();
            }
        }
        private void btnCiftIleri_Click(object sender, EventArgs e)
        {
            if (lstOgrenci.Items.Count == 0)
            {
                MessageBox.Show("Katılımcı olarak eklenecek isim yok");
            }
            else
            {
                for (int i = 0; i < lstOgrenci.Items.Count; i++)
                {
                    lstKatilimci.Items.Add(lstOgrenci.Items[i]);
                }
                lstOgrenci.Items.Clear();
            }
        }
        private void btnIncele_Click(object sender, EventArgs e)
        {
            for(int i=0; i<lstOgrenci.Items.Count; i++)
            {
                OgrenciListesi.Add(lstOgrenci.Items[i]);
            }
            for(int j=0; j<lstKatilimci.Items.Count; j++)
            {
                KullaniciListesi.Add(lstKatilimci.Items[j]);
            }

            girisIzni.ShowDialog();
        }

        //Olaylar
        private void Form1_Load(object sender, EventArgs e)
        {

            IsımDiz();//isim leri oluşturur


            for(int i=0; i<Ogrenciler.Count; i++)
            {
                lstOgrenci.Items.Add(Ogrenciler[i]);
            }
        }


        //Fonksiyonlar
        ToolTip bilgiMessaji(string baslik, string aciklama, Control nesne)
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

        private void IsımDiz()
        {

            for(int i=0; i<20; i++)
            {
                RandomSayi = rnd.Next(0, Ogreci.isimler.Count);

                if (!Ogrenciler.Contains(Ogreci.isimler[RandomSayi]))
                {
                    Ogrenciler.Add(Ogreci.isimler[RandomSayi]);
                }
            }

        }
    }
}
