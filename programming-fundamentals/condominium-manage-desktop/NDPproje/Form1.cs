/************************************************************************
**					      SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					    2024-2025 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje
**				ÖĞRENCİ ADI............: LUCAS ISAAC CASSOMA KATALAHALI
**				ÖĞRENCİ NUMARASI.......: B231210582
**                         DERSİN ALINDIĞI GRUP...: B
*************************************************************************/

using System.Data;


namespace NDPproje;

public partial class Form1 : Form
{
    public List<Blok> blok = new List<Blok>();
    public List<Oturan> oturan = new List<Oturan>();
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Bloklari/Binalar baslat (9 blok olacak)
        for (int blokNumara = 1; blokNumara <= 9; blokNumara++)
        {
            Blok newBlok = new Blok(blokNumara);
            blok.Add(newBlok);
        }

        labelBildirim.Text = "Önemli Bildirimler: Bildirim yok";
        labelBosDaireSayisi.Text = "Boş daire sayısı: " + ClassHelper.BosDaireSayisi.ToString();
        labelDoluDaireSayisi.Text = "Dolu daire sayısı: 0";

        //Dosyalar Olusturmak
        ClassHelper.dosyalar();

        //Raporlar combobox'unu baslat
        comboBoxRapor.Items.Add("Data");
        comboBoxRapor.Items.Add("Daire");
        comboBoxRapor.Items.Add("Ödeme");
        comboBoxRapor.Items.Add("Havuz");
        comboBoxRapor.Items.Add("Fitness");

        // Oturan Menu combobox'unu baslat
        comboBoxOturanMenu.Items.Add("Yeni kayit");
        comboBoxOturanMenu.Items.Add("Oturan silme");
        comboBoxOturanMenu.Items.Add("Oturan düzeltme");
        comboBoxOturanMenu.Items.Add("Misafir ekle");
        comboBoxOturanMenu.Items.Add("Oturan bilgilerini görüntüle");

        // Odeme Menu combobox'unu baslat
        comboBoxOdemeMenu.Items.Add("Yeni Ödeme");
        comboBoxOdemeMenu.Items.Add("Ödeme Düzeltmek");
    }

    // Her seyi kapatan METOD, sadece daire aramak panel kalir
    private void TekPanelGoster(string baslik)
    {
        groupBoxDaireBul.Visible = true;
        groupBoxDaireBul.Text = baslik;
        foreach (Control control in this.Controls)
        {
            if (control != groupBoxDaireBul)
                control.Enabled = false;
        }
    }

    private void Form1Goster()
    {
        textBoxDaireBul.Text = "";
        groupBoxDaireBul.Visible = false;
        foreach (Control control in this.Controls)
        {
            control.Enabled = true;
        }
    }


    private void buttonOturnMenu_Click(object sender, EventArgs e)
    {
        if (comboBoxOturanMenu.SelectedIndex == 0) //Yeni oturan Kayit
        {
            FormOturanKayit oturanKayit = new FormOturanKayit(blok, oturan);
            var sonuc = oturanKayit.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                labelDoluDaireSayisi.Text = "Dolu daire sayısı: " + ClassHelper.DoluDaireSayisi.ToString();
                labelBosDaireSayisi.Text = "Boş daire sayısı: " + ClassHelper.BosDaireSayisi.ToString();
            }
            
                //oturanKayit.ShowDialog();
            comboBoxOturanMenu.SelectedIndex = -1;
        }
        else if (comboBoxOturanMenu.SelectedIndex == 1) //Oturan Silmek

            TekPanelGoster("Oturan Silme"); //Bu metod'da diger form gosterilecek

        else if (comboBoxOturanMenu.SelectedIndex == 2) //Oturan Bilgilerinin Duzeltilmek

            TekPanelGoster("Oturan Bilgilerinin Duzeltilmesi");

        else if (comboBoxOturanMenu.SelectedIndex == 3) //Misafir Eklemek
            TekPanelGoster("Misafir Ekle");
        else if (comboBoxOturanMenu.SelectedIndex == 4)
            TekPanelGoster("Oturan bilgilerini görüntüle");
    }
    private void buttonOdemeMenu_Click(object sender, EventArgs e)
    {
        if (comboBoxOdemeMenu.SelectedIndex == 0) //Odeme yapmak
            TekPanelGoster("Yeni Ödeme");
        if (comboBoxOdemeMenu.SelectedIndex == 1) //Odeme duzeltmek
            TekPanelGoster("Ödeme Düzeltme");
    }


    bool isInternalChange = false;
    private void comboBoxOturanMenu_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (isInternalChange) return;

        isInternalChange = true;
        comboBoxOdemeMenu.SelectedIndex = -1;
        comboBoxRapor.SelectedIndex = -1;
        isInternalChange = false;
    }

    private void comboBoxOdemeMenu_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (isInternalChange) return;

        isInternalChange = true;
        comboBoxRapor.SelectedIndex = -1;
        comboBoxOturanMenu.SelectedIndex = -1;
        isInternalChange = false;
    }
    private void comboBoxRapor_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (isInternalChange) return;

        isInternalChange = true;
        comboBoxOturanMenu.SelectedIndex = -1;
        comboBoxOdemeMenu.SelectedIndex = -1;
        isInternalChange = false;
    }

    private void buttonDaireBulOnayla_Click(object sender, EventArgs e)
    {
        string girilmisDaire = textBoxDaireBul.Text;

        var (basarili, mesaj, daireNumarasi) = ClassHelper.DaireBul(blok, girilmisDaire);
        if (!basarili)
        {
            MessageBox.Show(mesaj);
            return;
        }
        Oturan gecici_oturan = oturan.First(o => o.OturanDaireNumarasi == daireNumarasi);

        if (comboBoxOturanMenu.SelectedIndex == 1) //Oturan silmek
        {

            //OTURAN SIL
            bool borcVar = gecici_oturan.OturanBorcu();
            if (borcVar)
            {
                MessageBox.Show($"Hata! Borcundan dolayi oturan silinemez. Borç miktari: {gecici_oturan.Borc:C}");
            }
            else {
                FormBilgiDuzeltme bilgiGoruntule = new FormBilgiDuzeltme(oturan, gecici_oturan, 6);
                var sonuc = bilgiGoruntule.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    Form1Goster();

                    foreach (Daire daire in blok[(daireNumarasi / 100) - 1].daireler)
                    {
                        if (daire.DaireNumara == daireNumarasi)
                        {
                            daire.DaireBosalt();//Daire Bosaltmak
                            Form1Goster();
                            break;
                        }
                    }

                    labelDoluDaireSayisi.Text = "Dolu daire sayısı: " + ClassHelper.DoluDaireSayisi.ToString();
                    labelBosDaireSayisi.Text = "Boş daire sayısı: " + ClassHelper.BosDaireSayisi.ToString();
                }

            }

        }

        if (comboBoxOturanMenu.SelectedIndex == 2) // Oturanin verilerini duzenle
        {
            FormBilgiDuzeltme bilgiDuzeltme = new FormBilgiDuzeltme(oturan, gecici_oturan, 1);
            comboBoxOturanMenu.SelectedIndex = -1;
            bilgiDuzeltme.ShowDialog();
            Form1Goster();
        }
        // Misafir ekle
        if (comboBoxOturanMenu.SelectedIndex == 3)
        {
            FormBilgiDuzeltme misafirEkle = new FormBilgiDuzeltme(oturan, gecici_oturan, 2);
            misafirEkle.ShowDialog();
            comboBoxOturanMenu.SelectedIndex = -1;
            Form1Goster();
        }
        //Oturan bilgilerini goruntule
        if (comboBoxOturanMenu.SelectedIndex == 4)
        {
            FormBilgiDuzeltme bilgiGoruntule = new FormBilgiDuzeltme(oturan, gecici_oturan, 5);
            bilgiGoruntule.ShowDialog();
            comboBoxOturanMenu.SelectedIndex = -1;
            Form1Goster();
        }

        if (comboBoxOdemeMenu.SelectedIndex == 0) //Yeni Odeme Yapamak
        {
            bool borcVar = gecici_oturan.OturanBorcu();
            if (borcVar)
            {
                FormBilgiDuzeltme bilgiDuzeltme = new FormBilgiDuzeltme(oturan, gecici_oturan, 3);
                bilgiDuzeltme.ShowDialog();
                Form1Goster();
            }
            else
            {
                MessageBox.Show("Bu oturanin borcu yok.");
                Form1Goster();
            }
            comboBoxOdemeMenu.SelectedIndex = -1;
        }
        //Odeme Duzeltmek
        if (comboBoxOdemeMenu.SelectedIndex == 1)
        {
            FormBilgiDuzeltme odemeDuzeltme = new FormBilgiDuzeltme(oturan, gecici_oturan, 4);
            odemeDuzeltme.ShowDialog();
            comboBoxOdemeMenu.SelectedIndex = -1;
            Form1Goster();
        }
    }
    private void buttonDaireBulIptal_Click(object sender, EventArgs e)
    {
        Form1Goster();
    }

    private void buttonMekanlar_Click(object sender, EventArgs e)
    {
        FormMekan formMekan = new FormMekan(oturan, blok);
        formMekan.ShowDialog();
    }

    private void buttonRaporOnayla_Click(object sender, EventArgs e)
    {
        if (comboBoxRapor.SelectedIndex == 0) //Data Rapor
        {
            FormRapor formRapor = new FormRapor(oturan);
            formRapor.ShowDialog();
        }
        else if (comboBoxRapor.SelectedIndex == 1) //Daire Raporu
        {
            var tablo = ClassHelper.RaporHazirla("Daire.txt", new[] { "Blok No", "Daire Numarasi", "Durum" });
            new FormRapor(tablo, "Daireler Raporu").ShowDialog();
        } 
           
        else if (comboBoxRapor.SelectedIndex == 2) //Odeme Rapor
        {
            var tablo = ClassHelper.RaporHazirla("Odeme.txt", new[] { "Adi Soyadi", "Daire Numarasi", "Tutar", "Kalan Borç" });
            new FormRapor(tablo, "Odemeler Raporu").ShowDialog();
        }
        else if (comboBoxRapor.SelectedIndex == 3) //Havuz Rapor
        {
            var tablo = ClassHelper.RaporHazirla("Havuz.txt", new[] { "Adi Soyadi", "Daire Numarasi", "Durum" });
            new FormRapor(tablo, "Havuz Kullanimi Raporu").ShowDialog();
        }
        else if (comboBoxRapor.SelectedIndex == 4) //Fitness Rapor
        {
            var tablo = ClassHelper.RaporHazirla("Fitness.txt", new[] { "Adi Soyadi", "Daire Numarasi", "Durum" });
            new FormRapor(tablo, "Spor Salonu Kullanimi Raporu").ShowDialog();
        }
    }

    private void buttonKazanc_Click(object sender, EventArgs e)
    {
        MessageBox.Show(ClassHelper.ToplamKazanc.ToString("C"));
    }
}
