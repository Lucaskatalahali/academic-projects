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

public class Blok : Mekan
{
    public List<Daire> daireler { get; set; } = new List<Daire>();

    public Blok(int blok)
    {
        for(int i = 0; i <= 99; i++)
        {
            ClassHelper.BosDaireSayisi += 1; 
            Daire newDaire = new Daire(blok*100 + i); // Daire numaralari 100'den baslar ve devam eder
            daireler.Add(newDaire);
        }
    }
}
