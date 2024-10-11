using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PİZZAOTOMASYONU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //string[] ebatlar = new string[] { "Orta", "Büyük", "Küçük", "Maxi" };
            //int x = 0;
            //foreach (string s in ebatlar)
            //{
            //    cmdEbat.Items.Add(ebatlar[x]);
            //    x++;



            Ebat kucuk = new Ebat { Adi = "Küçük", Carpan = 1m };
            Ebat orta = new Ebat { Adi = "Orta", Carpan = 1.25m };
            Ebat buyuk = new Ebat { Adi = "Büyük", Carpan = 1.75m };
            Ebat maxi = new Ebat { Adi = "Maxi", Carpan = 2 };
            cmdEbat.Items.Add(kucuk);
            cmdEbat.Items.Add(orta);
            cmdEbat.Items.Add(buyuk);
            cmdEbat.Items.Add(maxi);


            Pizza klasik = new Pizza { Adi = "Klasik", Fiyat = 200 };
            Pizza karisik = new Pizza { Adi = "Karışık", Fiyat = 250 };
            Pizza turkish = new Pizza { Adi = "Turkish", Fiyat = 230 };
            Pizza tuna = new Pizza { Adi = "Tuna", Fiyat = 240 };
            Pizza akdeniz = new Pizza { Adi = "Akdeniz", Fiyat = 220 };
            Pizza karadeniz = new Pizza { Adi = "Karadeniz", Fiyat = 180 };
            listPizzalar.Items.Add(klasik);
            listPizzalar.Items.Add(karisik);
            listPizzalar.Items.Add(turkish);
            listPizzalar.Items.Add(akdeniz);
            listPizzalar.Items.Add(karadeniz);

            // klasik.adi yazmak yerine tostringi Ezeceğiz.


            KenarTip ince = new KenarTip { Adi = "İnce", ekFiyat = 1 };
            KenarTip kalin = new KenarTip { Adi = "Kalın", ekFiyat = 30 };
            rdbİnceKenar.Tag = ince;
            rdbKalinKenar.Tag = kalin;
            //TAG ÖZELLİĞİNE ATIYORUZKİ ONUN TAGİNDEN EKFİYATADA ULAŞABİLİYORUZ.

        }

        private void rdbİnceKenar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {//
         //Pizza p =listPizzalar.SelectedItem as Pizza; 

            Pizza p = listPizzalar.SelectedItem as Pizza;
            p.Ebati = cmdEbat.SelectedItem as Ebat;

            if (nudAdet.Value == 0)
            {

                MessageBox.Show("LÜTFEN ADET GİRİNİZ.");
            }
            else
            {
                if (!rdbİnceKenar.Checked)
                {
                    p.KenarTipi = rdbKalinKenar.Tag as KenarTip;
                }
                else
                {
                    p.KenarTipi = rdbİnceKenar.Tag as KenarTip;
                }
            }
            decimal tutar = nudAdet.Value * p.tutar;
            txtTutar.Text = tutar.ToString();
            s = new Siparis();
            s.Pizzalar = p;
            s.Adet = (int)nudAdet.Value;



        }
        Siparis s;
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {

           
            if (s != null)
            {

                listSiparis.Items.Add(s);

            }
            decimal TTutar = 0;
            foreach (Siparis s in listSiparis.Items)
            {

                TTutar += s.Adet * s.Pizzalar.tutar;


            }
            lblToplamTutar.Text= TTutar.ToString(); 


        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            decimal ToplamTutar = 0;
            int sayac=0;
            foreach (Siparis s in listSiparis.Items) {

                ToplamTutar += s.Adet * s.Pizzalar.tutar;
                sayac++;
             
            
            }
            MessageBox.Show(sayac + " Adet Siparişiniz Vardır." + " Siparişinizin Toplam Tutarı : " + ToplamTutar + "  TL'dir.");
        }
    }
}
