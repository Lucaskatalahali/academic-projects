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
//YARDINCI CLASS
//Daire geçerli mi geçerli degil mi? Bu class'te kontrol edecegiz
public static class ClassHelper
{

    public static double ToplamKazanc { get; set; } = 0; //Usar Decimal será?
    public static int DoluDaireSayisi { get; set; } = 0;
    public static int BosDaireSayisi { get; set; } = 0;
    public static string Bildirim { get; set; } = "Yok";

    public static void KazancEkle(double miktar) //TOPLAM KAZANÇ IÇIN METODU 
    {
        ToplamKazanc += miktar;
    }
    public static  (bool basarili, string mesaj, int daireNumara) DaireBul(List<Blok> blok, string daire)
    {
        int daireNumarasi;
        if (string.IsNullOrWhiteSpace(daire))
            return (false, "Lutfen, daire numarasini girin.", -1);

        if (!int.TryParse(daire, out daireNumarasi) || daireNumarasi <= 0)
            return (false, "Lutfen, gecerli bir daire numarasi girin", -1);
        
        if (daireNumarasi < 100 || daireNumarasi > 999)
            return (false, "Daire numarası 100 - 999 arasında olmalıdır.", -1);

        foreach (Daire daire_durum in blok[(daireNumarasi / 100) - 1].daireler) // daireNumarasi/100 = index (blok)
        {
            if (daire_durum.DaireNumara == daireNumarasi)
            {
                if (daire_durum.Bos == true)
                    return (false, $"Hata! {daireNumarasi} numarali daire bostur.", -1);
                    return (true, "Basarili", daireNumarasi);
            }
        }
        return (false, "Daire bulunamadi", -1);
    }


    //Raporlar
    public static DataTable RaporHazirla(string dosyaAdi,string[] sutunlar)
    {
        DataTable table = new DataTable();
        foreach (var kolon in sutunlar)
            table.Columns.Add(kolon);

        string[] satirlar = File.ReadAllLines(dosyaAdi);
        foreach (string satir in satirlar.Skip(1))
        {
            string[] parca = satir.Split('\t');
            table.Rows.Add(parca);
        }
        return table;
    }

    //Dosyalari Olusturmak

    public static void dosyalar()
    {
        // Data dosyasi olustur
        string line = "Adi Soyadi".PadRight(30) + "Daire".PadRight(20) + "Akraba".PadRight(30) +
          "Kalan Borç".PadRight(20);
        string yol = Path.Combine(Application.StartupPath, "Data.txt");
        File.WriteAllText(yol, line + Environment.NewLine);

        // Daire (Mekan) dosyasi olustur
        line = "Blok No\tDaire No\tDurum";
        yol = Path.Combine(Application.StartupPath, "Daire.txt");
        File.WriteAllText(yol, line + Environment.NewLine);

        // Odeme dosyasi olustur
        line = "Adi Soyadi\tDaire No\tTutar\tKalan Borç";
        yol = Path.Combine(Application.StartupPath, "Odeme.txt");
        File.WriteAllText(yol, line + Environment.NewLine);

        // Havuz dosyasi olustur
        line = "Adi Soyadi\tDaire No\tDurum";
        yol = Path.Combine(Application.StartupPath, "Havuz.txt");
        File.WriteAllText(yol, line + Environment.NewLine);

        // Fitness(Spor Salonu) dosyasi olustur
        line = "Adi Soyadi\tDaire No\tDurum";
        yol = Path.Combine(Application.StartupPath, "Fitness.txt");
        File.WriteAllText(yol, line + Environment.NewLine);
    }
}
