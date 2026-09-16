using System.Reflection;

namespace KelimeEzberleme;

public partial class Form1 : Form
{
    List<Kelime> list = new List<Kelime>();

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        if (File.Exists("icon.ico"))
        {
            this.Icon = new Icon("icon.ico");
        }
        // Créditos
        // Criação segura e adaptável a qualquer DPI / Resolução
        // 1. Sobe os 3 botões em 20 pixels para criar espaço livre abaixo
        int deslocamento = 20;
        buttonYukle.Top -= deslocamento;
        buttonBaslat.Top -= deslocamento;
        buttonCikis.Top -= deslocamento;

        // 2. Posiciona os créditos com folga segura e sem encostar em nada
        Label labelCredits = new Label
        {
            Text = "By Lucas \u2022 github.com/lucaskatalahali",
            ForeColor = Color.DimGray,
            Font = new Font("Calibri", 9.5F, FontStyle.Regular),
            AutoSize = true,
            Location = new Point(45, this.ClientSize.Height - 32),
            Anchor = AnchorStyles.Bottom | AnchorStyles.Left
        };
        this.Controls.Add(labelCredits);
        labelCredits.BringToFront();

        // Garante que a pasta e os dicionários padrão existam
        GarantirDicionariosPadrao();

        // Carrega os dicionários para o ComboBox
        string path = Path.Combine(Application.StartupPath, "sozlukler");
        if (Directory.Exists(path))
        {
            string[] file = Directory.GetFiles(path, "*.txt");
            foreach (string fileAdi in file)
            {
                string sozluk = Path.GetFileNameWithoutExtension(fileAdi);
                comboBoxSozluk.Items.Add(sozluk);
            }

            if (comboBoxSozluk.Items.Count > 0)
            {
                comboBoxSozluk.SelectedIndex = 0;
            }
        }
    }

    private void GarantirDicionariosPadrao()
    {
        string path = Path.Combine(Application.StartupPath, "sozlukler");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        var assembly = Assembly.GetExecutingAssembly();

        // Pega todos os arquivos embutidos que terminam com .txt
        var resourceNames = assembly.GetManifestResourceNames()
                                    .Where(r => r.EndsWith(".txt", StringComparison.OrdinalIgnoreCase));

        foreach (var resourceName in resourceNames)
        {
            // O resource name no .NET geralmente é: KelimeEzberleme.sozlukler.NomeDoArquivo.txt
            string[] parts = resourceName.Split('.');
            if (parts.Length >= 2)
            {
                string fileName = parts[^2] + ".txt"; // Pega o nome real do arquivo
                string destPath = Path.Combine(path, fileName);

                if (!File.Exists(destPath))
                {
                    using Stream stream = assembly.GetManifestResourceStream(resourceName)!;
                    if (stream != null)
                    {
                        using FileStream fileStream = new FileStream(destPath, FileMode.Create, FileAccess.Write);
                        stream.CopyTo(fileStream);
                    }
                }
            }
        }
    }

    private void buttonYukle_Click(object sender, EventArgs e)
    {
        if (comboBoxSozluk.SelectedItem == null) return;

        string path = Path.Combine(Application.StartupPath, "sozlukler");
        string fileAdi = comboBoxSozluk.SelectedItem.ToString()!;
        fileAdi = Path.Combine(path, fileAdi + ".txt");
        list.Clear();

        if (File.Exists(fileAdi))
        {
            foreach (string satir in File.ReadLines(fileAdi))
            {
                string[] parts = satir.Split('\t');
                if (parts.Length >= 2)
                {
                    Kelime k = new Kelime(parts[0].Trim(), parts[1].Trim());
                    list.Add(k);
                }
            }
        }
        buttonBaslat.Enabled = true;
    }

    private void buttonBaslat_Click(object sender, EventArgs e)
    {
        FormQuiz formQuiz = new FormQuiz(list);
        formQuiz.Show();
    }

    private void buttonCikis_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void comboBoxSozluk_SelectedIndexChanged(object sender, EventArgs e)
    {
        buttonBaslat.Enabled = false;
    }
}