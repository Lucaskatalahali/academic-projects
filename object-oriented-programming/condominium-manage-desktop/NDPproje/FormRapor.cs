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

public partial class FormRapor : Form
{
    public List<Oturan> oturan;
    public FormRapor(List<Oturan> oturan)
    {
        InitializeComponent();
        this.oturan = oturan;

        labelrapor.Text = "Oturanlar Raporu";
        dataGridViewRapor.DataSource = oturan;
        dataGridViewRapor.Columns["OturanAdi"].HeaderText = "Adı Soyadı";
        dataGridViewRapor.Columns["OturanDaireNumarasi"].HeaderText = "Daire No";
        dataGridViewRapor.Columns["Akraba"].HeaderText = "Akraba";
        dataGridViewRapor.Columns["Misafir"].HeaderText = "Misafir";
        dataGridViewRapor.Columns["Borc"].HeaderText = "Kalan Borç (TL)";
    }

    public FormRapor(DataTable table, string labelText)
    {
        InitializeComponent();
        labelrapor.Text = labelText;
        dataGridViewRapor.DataSource = table;

    }
}
