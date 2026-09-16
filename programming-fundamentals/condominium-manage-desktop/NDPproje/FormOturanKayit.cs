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

namespace NDPproje;

public partial class FormOturanKayit : Form
{
    private const double tutar1 = 10000; //Tek oturan fiyat
    private const double tutar2 = 17000; //Eger oturan bir akrabasi varsa fiyat artiyor
    public List<Blok> blok; 
    public List<Oturan> oturan;
    public FormOturanKayit(List<Blok> blok, List<Oturan> oturan)
    {
        InitializeComponent();

        this.blok = blok;
        this.oturan = oturan;

        for (int i = 1; i <= 9; i++)
        {
            comboBoxBlok.Items.Add($"Blok - {i}");
        }
        comboBoxBlok.SelectedIndex = 0;
    }

    private void buttonOturanKaydetmek_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxOturanAdi.Text)){
            MessageBox.Show("Lütfen oturanin adini girin.");
                return;
        }
        if (radioButtonVar.Checked == false && radioButtonYok.Checked == false)
        {
            MessageBox.Show("Lütfen bir akraba olup olmadığını bildirin");
            return;
        }
        if(radioButtonVar.Checked == true && string.IsNullOrWhiteSpace(textBoxAkrabaAdi.Text))
        {
            MessageBox.Show("Lütfen akrabanın adini bildirin");
            return;
        }
        if (string.IsNullOrWhiteSpace(textBoxKayitOdeme.Text))
        {
            MessageBox.Show("Lütfen ödeme yapın");
            return;
        }
        double tutar;
        if (!double.TryParse(textBoxKayitOdeme.Text, out tutar) || tutar < 0)
        {
            MessageBox.Show("Lütfen geçerli bir tutar giriniz!");
            return;
        }

        ClassHelper.KazancEkle(tutar);
        double borc;
        int daireNumarasi = 0;

        if (radioButtonVar.Checked == true)
        {
            borc = tutar2 - tutar;
            if (borc < 0) borc = 0;
        }
        else
        {
            borc = tutar1 - tutar;
            if (borc < 0) borc = 0;
        }
        int count = 0;
        foreach (Daire daire in blok[comboBoxBlok.SelectedIndex].daireler)
        {
            if (daire.Bos == true)
            {
                count++;
                daire.Bos = false;
                daireNumarasi = daire.DaireNumara;
                break;
            }
        }

        if (count == 1)
        {
            string adi = textBoxOturanAdi.Text.Trim();
            string akraba = textBoxAkrabaAdi.Text.Trim();
            int daire = daireNumarasi;
            string misafir = "";
            double kalanBorc = borc;

            Oturan yeniOturan = new Oturan();

            yeniOturan.kayit(adi, daire, akraba, misafir, borc, tutar);

            MessageBox.Show($"Oturan başarıyla kaydedildi!\n\nAdi Soyadi: {yeniOturan.OturanAdi}" +
              $" \nBlok Nº: {yeniOturan.OturanDaireNumarasi / 100} \nDaire Numarasi: " +
              $"{yeniOturan.OturanDaireNumarasi} \nÖdenmiş Tutar: {tutar:C} \nBorç: {yeniOturan.Borc:C}");

            oturan.Add(yeniOturan);

            this.DialogResult = DialogResult.OK;
        }
        else
        {
            MessageBox.Show("Bu blokta boş daire yok.");
            return;
        }
   
        this.Close();
    }

    private void radioButtonVar_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButtonVar.Checked == true)
        {
            textBoxAkrabaAdi.Enabled = true;
            groupBoxKayitOdeme.Text = $"Toplam Tutar: {tutar2:C}";
        }
    }

    private void radioButtonYok_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButtonYok.Checked == true)
        {
            textBoxAkrabaAdi.Text = "";
            groupBoxKayitOdeme.Text = $"Toplam Tutar: {tutar1:C}";
            textBoxAkrabaAdi.Enabled = false;
        }
    }
}
