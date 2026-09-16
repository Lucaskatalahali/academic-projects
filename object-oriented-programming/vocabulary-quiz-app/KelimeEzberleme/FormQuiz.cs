using System.Data;

namespace KelimeEzberleme;

public partial class FormQuiz : Form
{
    List<Kelime> listkelimeler;
    Random random = new Random();
    int index = 0;
    int puan = 0;
    int count = 0;

    public FormQuiz(List<Kelime> list)
    {
        if (File.Exists("icon.ico"))
        {
            this.Icon = new Icon("icon.ico");
        }

        InitializeComponent();
        OrganizarBotoesCentralizados();

        listkelimeler = new List<Kelime>(list);
        listkelimeler = listkelimeler.OrderBy(x => random.Next()).ToList();
        sonrakiSoru();
    }

    private void OrganizarBotoesCentralizados()
    {
        // Cria um painel de grade 2x2 responsivo
        TableLayoutPanel gridBotoes = new TableLayoutPanel
        {
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            ColumnCount = 2,
            RowCount = 2,
            Location = new Point(14, 260),
            Size = new Size(this.ClientSize.Width - 28, this.ClientSize.Height - 275)
        };

        // Colunas e linhas divididas em 50% cada
        gridBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        gridBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        gridBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        gridBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

        // Ajusta as propriedades dos botões para preencher as células da grade
        Button[] botoes = { buttonOpsyon1, buttonOpsyon2, buttonOpsyon3, buttonOpsyon4 };
        foreach (var btn in botoes)
        {
            this.Controls.Remove(btn);
            btn.Dock = DockStyle.Fill;
            btn.Margin = new Padding(8);
        }

        // Insere os 4 botões na matriz 2x2
        gridBotoes.Controls.Add(buttonOpsyon1, 0, 0);
        gridBotoes.Controls.Add(buttonOpsyon2, 1, 0);
        gridBotoes.Controls.Add(buttonOpsyon3, 0, 1);
        gridBotoes.Controls.Add(buttonOpsyon4, 1, 1);

        this.Controls.Add(gridBotoes);
    }

    private void sonrakiSoru()
    {
        if (index >= listkelimeler.Count)
        {
            MessageBox.Show($"Bitti! Final Puan: {puan}");
            Close();
            return;
        }

        labelProgress.Text = $"{index + 1}/{listkelimeler.Count}";
        labelScore.Text = $"Puan: {puan}";
        labelSoru.Text = listkelimeler[index].Ingilizce;

        List<Kelime> random_secenekler = new List<Kelime>(listkelimeler);
        random_secenekler = random_secenekler.OrderBy(x => random.Next()).ToList();

        List<string> turkSecenekler = new List<string>();
        for (int i = 0; i <= 2; i++)
        {
            if (random_secenekler[i].Turkce != listkelimeler[index].Turkce)
            {
                turkSecenekler.Add(random_secenekler[i].Turkce);
            }
            else
            {
                i--;
            }
        }
        turkSecenekler.Add(listkelimeler[index].Turkce);
        turkSecenekler = turkSecenekler.OrderBy(x => random.Next()).ToList();

        buttonOpsyon1.Text = turkSecenekler[0];
        buttonOpsyon2.Text = turkSecenekler[1];
        buttonOpsyon3.Text = turkSecenekler[2];
        buttonOpsyon4.Text = turkSecenekler[3];
    }

    private void cevapKontrol(object sender, EventArgs e)
    {
        if (sender is Button clickedButton)
        {
            count++;
            string secenek = clickedButton.Text;
            if (secenek == listkelimeler[index].Turkce)
            {
                index++;
                if (count == 1) puan += 10;
                count = 0;
                buttonOpsyon1.BackColor = SystemColors.Control;
                buttonOpsyon2.BackColor = SystemColors.Control;
                buttonOpsyon3.BackColor = SystemColors.Control;
                buttonOpsyon4.BackColor = SystemColors.Control;
                sonrakiSoru();
            }
            else
            {
                clickedButton.BackColor = Color.Red;
            }
        }
    }
}