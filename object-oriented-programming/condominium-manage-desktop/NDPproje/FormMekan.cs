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

public partial class FormMekan : Form
{
    string kullanan= "";
    string mekan = "";

    public List<Oturan> oturan;
    public List<Blok> blok;
    public FormMekan(List<Oturan> oturan, List<Blok> blok)
    {
        InitializeComponent();
        this.oturan = oturan;
        this.blok = blok;
    }

    private void FormMekan_Load(object sender, EventArgs e)
    {

    }

    private void buttonMekandaDaireAra_Click(object sender, EventArgs e)
    {
       
        radioButtonMekandaOturan.Text = "Oturan";
        radioButtonMekandaAkraba.Text = "Akraba";
        radioButtonMekandaMisafir.Text = "Misafir";
        radioButtonMekandaOturan.Enabled = radioButtonMekandaAkraba.Enabled = radioButtonMekandaMisafir.Enabled = false;
        radioButtonMekandaOturan.Checked = radioButtonMekandaAkraba.Checked = radioButtonMekandaMisafir.Checked = false;
        string girilmisDaire = textBoxMekandaDaire.Text;
        var (basarili, mesaj, daireNumarasi) = ClassHelper.DaireBul(blok, girilmisDaire);
        if (!basarili)
        {
            MessageBox.Show(mesaj);
            return;
        }
        buttonMekanOnayla.Enabled = true;

        Oturan oturan_mekanda = oturan.First(o => o.OturanDaireNumarasi == daireNumarasi);

        radioButtonMekandaOturan.Text = oturan_mekanda.OturanAdi;
        radioButtonMekandaOturan.Enabled = true;
        if (oturan_mekanda.Akraba == "")
        {
            radioButtonMekandaAkraba.Text = "Akraba (Yok)";
        }
        else
        {
            radioButtonMekandaAkraba.Enabled = true;
            radioButtonMekandaAkraba.Text = $"{oturan_mekanda.Akraba} (Akraba)";
        }
        if (oturan_mekanda.Misafir == "")
        {
            radioButtonMekandaMisafir.Text = "Misafir (Yok)";
        }
        else
        {
            radioButtonMekandaMisafir.Enabled = true;
            radioButtonMekandaMisafir.Text = $"{oturan_mekanda.Misafir} (Misafir)";
        }
    }

    private void buttonMekanOnayla_Click(object sender, EventArgs e)
    {
        
        if (!((radioButtonHavuz.Checked || radioButtonSporSalonu.Checked) &&
            (radioButtonMekandaOturan.Checked || radioButtonMekandaAkraba.Checked ||
            radioButtonMekandaMisafir.Checked)))
        {
            MessageBox.Show("Lütfen tüm alanları işaretleyin.");
            return;
        }
        else
        { 
            Oturan oturan_mekanda = oturan.First(o => o.OturanDaireNumarasi == int.Parse(textBoxMekandaDaire.Text));
            if (radioButtonMekandaOturan.Checked == true) kullanan = oturan_mekanda.OturanAdi;
            if (radioButtonMekandaAkraba.Checked == true) kullanan = oturan_mekanda.Akraba;
            if (radioButtonMekandaMisafir.Checked == true) kullanan = oturan_mekanda.Misafir + " (Misafir)";
            if (radioButtonHavuz.Checked == true) mekan = "Havuz";
            if (radioButtonSporSalonu.Checked == true) mekan = "Fitness";

            bool borcVar = Mekan.MekanKull(oturan_mekanda, kullanan, mekan);
            if (borcVar)
            {
                MessageBox.Show($"{oturan_mekanda.Borc:C} borcundan dolayı {mekan} kullanamaz.");
            }
            else
            {
                MessageBox.Show("kullandırıldı.");
            }
        }
        this.Close();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
