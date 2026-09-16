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

namespace NDPproje
{
    public class Mekan
    {
        public static bool MekanKull(Oturan oturan, string kullanan, string mekan)
        {
           bool borcVar= oturan.OturanBorcu();
            if (borcVar)
            {
                string line = $"{kullanan}\t{oturan.OturanDaireNumarasi}\tKullandirilmadi";
                string yol = Path.Combine(Application.StartupPath, $"{mekan}.txt");
                File.AppendAllText(yol, line + Environment.NewLine);
                return true;
            }
            else
            {
                string line = $"{kullanan}\t{oturan.OturanDaireNumarasi}\tKullandirildi";

                string yol = Path.Combine(Application.StartupPath, $"{mekan}.txt");
                File.AppendAllText(yol, line + Environment.NewLine);
                return false;
            }
        }
      

    }
}
