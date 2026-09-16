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

using System.Windows.Forms;

namespace NDPproje;

public class Oturan
{
    public string OturanAdi { get; set; }
    public int OturanDaireNumarasi { get; set; }
    public string Akraba { get; set; }
    public String Misafir { get; set; }
    public double Borc { get; set; }

    public void kayit(string adi, int daire, string akraba, string misafir, double borc, double odenmisTutar)
    {
        OturanAdi = adi;
        OturanDaireNumarasi = daire;
        Akraba = akraba;
        Misafir = misafir;
        Borc = borc;

        ClassHelper.DoluDaireSayisi += 1;
        ClassHelper.BosDaireSayisi -= 1;

        // Data dosyasina kaydet
        string line = $"{OturanAdi}\t{OturanDaireNumarasi}\t{Akraba}\t{""}\t{Borc:C}";
        string yol = Path.Combine(Application.StartupPath, "Data.txt");
        File.AppendAllText(yol, line + Environment.NewLine);

        // Daire dosyasina kaydet
        line = $"{(OturanDaireNumarasi / 100)}\t{OturanDaireNumarasi}\tKayitli";
        yol = Path.Combine(Application.StartupPath, "Daire.txt");
        File.AppendAllText(yol, line + Environment.NewLine);

        // Odeme dosyasina kaydet
        line = $"{OturanAdi}\t{OturanDaireNumarasi}\t{odenmisTutar:C}\t{Borc:C}";
        yol = Path.Combine(Application.StartupPath, "Odeme.txt");
        File.AppendAllText(yol, line + Environment.NewLine);
    }

    //Oturan Borcu Var mi?
    public bool OturanBorcu()
    {
        if(Borc > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //Oturan Duzeltmek
    public bool Duzeltmek(string adi, string akraba, string misafir)
    {
        if (string.IsNullOrWhiteSpace(adi))
        {
            return false;
        }
        else
        {
            OturanAdi = adi.Trim();
            Misafir = misafir.Trim();
            Akraba = akraba.Trim();
            return true;
        }
    }

    //Odeme yapmak
    public bool Odemeyap(string odeme, int control)
    {
        double tutar;
        if (!double.TryParse(odeme, out tutar) || tutar < 0)
        {
            return false;
        }
        else
        {
            if (control == 3)
            {
                Borc = Borc - tutar;

                if (Borc < 0) Borc = 0;
            }
            else { Borc = tutar; }
        }

        if (control == 3)
        {
            ClassHelper.KazancEkle(tutar);
            // Odeme dosyasina kaydet
            string lineOdeme = $"{OturanAdi}\t{OturanDaireNumarasi}\t{tutar:C}\t{Borc:C}";
            string yolOdeme = Path.Combine(Application.StartupPath, "Odeme.txt");
            File.AppendAllText(yolOdeme, lineOdeme + Environment.NewLine);
        }
        else
        {
            string line = $"{OturanAdi}\t{OturanDaireNumarasi}\tDuzetilmis\t{Borc:C}";
            string yol = Path.Combine(Application.StartupPath, "Odeme.txt");
            File.AppendAllText(yol, line + Environment.NewLine);
        }

        return true;
    }
}

