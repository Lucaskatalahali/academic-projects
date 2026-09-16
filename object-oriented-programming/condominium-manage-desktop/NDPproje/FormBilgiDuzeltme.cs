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

public partial class FormBilgiDuzeltme : Form
{
    Oturan oturan;
    int control_int;
    List<Oturan> listOturan;
    public FormBilgiDuzeltme(List<Oturan> listOturan, Oturan oturan, int control_int)
    {
        InitializeComponent();
        this.oturan = oturan;
        this.control_int = control_int;
        this.listOturan = listOturan;

        labelDaireNumarasi.Text = "Daire Numarasi: " + oturan.OturanDaireNumarasi.ToString();
        textBoxAdiDuzelt.Text = oturan.OturanAdi;
        textBoxAkrabaDuzelt.Text = oturan.Akraba;
        textBoxMisafir.Text = oturan.Misafir;
        labelBorcGoster.Text = $"Kalan Borç: {oturan.Borc:C}";

        // control_int 1 sadece isimleri duzenlemek icindir
        if (control_int == 1)
            labelOdeme.Visible = textBoxOdeme.Visible = false;

        // control_int 2 misafir eklemek icindir
        else if (control_int == 2)
        {
            labelOdeme.Visible = textBoxOdeme.Visible = textBoxAdiDuzelt.Enabled = 
                textBoxAkrabaDuzelt.Enabled = false;
        }

        // control_int 3 odeme yapmak icindir
        else if (control_int == 3)
        {
            labelOdeme.Text = "Tutar Girin:";
            textBoxAdiDuzelt.Enabled = textBoxAkrabaDuzelt.Enabled = textBoxMisafir.Enabled = false;
            labelOdeme.Visible = textBoxOdeme.Visible = true;
        }

        // control_int 4 borcu duzeltmek icindir
        else if (control_int == 4)
        {
            labelOdeme.Text = "Yeni borcu:";
            textBoxAdiDuzelt.Enabled = textBoxAkrabaDuzelt.Enabled = textBoxMisafir.Enabled = false;
            labelOdeme.Visible = textBoxOdeme.Visible = true;
        }

        // control_int 5 sadece bilgiler gormek icindir
        else if (control_int == 5)
        {
            labelOdeme.Visible = textBoxOdeme.Visible = textBoxAdiDuzelt.Enabled = textBoxAkrabaDuzelt.Enabled =
                textBoxMisafir.Enabled = buttonDuzeltmeIptal.Visible = false;
            buttonDuzeltmeOnayla.Text = "Tamam";
        }

        //Oturani Silmek için
        else if(control_int == 6)
        {
            labelOdeme.Visible = textBoxOdeme.Visible = textBoxAdiDuzelt.Enabled = textBoxAkrabaDuzelt.Enabled =
               textBoxMisafir.Enabled = false;
            buttonDuzeltmeOnayla.Text = "Silmek";
        }
    }

    private void buttonDuzeltmeOnayla_Click(object sender, EventArgs e)
    {
        string adi = textBoxAdiDuzelt.Text;
        string akraba = textBoxAkrabaDuzelt.Text;
        string misafir = textBoxMisafir.Text;

        bool duzeltmeBasarili = oturan.Duzeltmek(adi, akraba, misafir);

        if (!duzeltmeBasarili)
        {
            MessageBox.Show("Lutfen, Oturanin Adini Girin.");
            return;
        }

        if(control_int == 3 || control_int == 4)
        {
            string  tutar;
            tutar = textBoxOdeme.Text;
            bool odemeBasarili = oturan.Odemeyap(tutar, control_int);
            if (!odemeBasarili)
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz!");
                return;
            }  
        }
        if(control_int != 5 && control_int != 6) MessageBox.Show("Bilgiler basariyla kaydedildi.");
        if (control_int == 6)
        {
            MessageBox.Show($"{oturan.OturanDaireNumarasi} numarali dairedeki oturan basariyla silindi.");
            ClassHelper.DoluDaireSayisi -= 1;
            ClassHelper.BosDaireSayisi +=1;
            listOturan.Remove(oturan);
            this.DialogResult = DialogResult.OK;
        }
        
        this.Close();
    }

    private void buttonDuzeltmeIptal_Click(object sender, EventArgs e)
    {
        if(control_int == 6) this.DialogResult = DialogResult.Cancel;
        
        this.Close();
    }
}
