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

public class Daire
{
    public int DaireNumara { set; get; } 
    public bool Bos { get; set; }

    public Daire(int blok)
    {
        DaireNumara = blok;
        Bos = true; // Bos
    }

    //Daire Bosaltimak
    public void DaireBosalt()
    {
        Bos = true;
        // Daire dosyasina yaz
        string line = $"{(DaireNumara / 100)}\t{DaireNumara}\tBosaltildi";
        string yol = Path.Combine(Application.StartupPath, "Daire.txt");
        File.AppendAllText(yol, line + Environment.NewLine);
    }
}
