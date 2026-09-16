namespace NDPproje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonOturnMenu = new Button();
            comboBoxOturanMenu = new ComboBox();
            groupBoxOturanMenu = new GroupBox();
            buttonDaireBul = new Button();
            buttonOturanSilmeIptal = new Button();
            label1 = new Label();
            textBoxDaireBul = new TextBox();
            groupBoxDaireBul = new GroupBox();
            groupBox1 = new GroupBox();
            buttonOdemeMenu = new Button();
            comboBoxOdemeMenu = new ComboBox();
            buttonMekanlar = new Button();
            comboBoxRapor = new ComboBox();
            groupBox2 = new GroupBox();
            buttonRaporOnayla = new Button();
            label3 = new Label();
            buttonKazanc = new Button();
            label7 = new Label();
            labelBildirim = new Label();
            labelBosDaireSayisi = new Label();
            labelDoluDaireSayisi = new Label();
            panel1 = new Panel();
            label2 = new Label();
            groupBoxOturanMenu.SuspendLayout();
            groupBoxDaireBul.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOturnMenu
            // 
            buttonOturnMenu.Font = new Font("Calibri", 11F);
            buttonOturnMenu.Location = new Point(392, 74);
            buttonOturnMenu.Name = "buttonOturnMenu";
            buttonOturnMenu.Size = new Size(146, 53);
            buttonOturnMenu.TabIndex = 1;
            buttonOturnMenu.Text = "Devam";
            buttonOturnMenu.UseVisualStyleBackColor = true;
            buttonOturnMenu.Click += buttonOturnMenu_Click;
            // 
            // comboBoxOturanMenu
            // 
            comboBoxOturanMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOturanMenu.Font = new Font("Calibri", 11F);
            comboBoxOturanMenu.FormattingEnabled = true;
            comboBoxOturanMenu.Location = new Point(61, 33);
            comboBoxOturanMenu.Name = "comboBoxOturanMenu";
            comboBoxOturanMenu.Size = new Size(477, 35);
            comboBoxOturanMenu.TabIndex = 2;
            comboBoxOturanMenu.SelectedIndexChanged += comboBoxOturanMenu_SelectedIndexChanged;
            // 
            // groupBoxOturanMenu
            // 
            groupBoxOturanMenu.Controls.Add(comboBoxOturanMenu);
            groupBoxOturanMenu.Controls.Add(buttonOturnMenu);
            groupBoxOturanMenu.Font = new Font("Calibri", 11F);
            groupBoxOturanMenu.Location = new Point(158, 204);
            groupBoxOturanMenu.Name = "groupBoxOturanMenu";
            groupBoxOturanMenu.RightToLeft = RightToLeft.No;
            groupBoxOturanMenu.Size = new Size(578, 172);
            groupBoxOturanMenu.TabIndex = 3;
            groupBoxOturanMenu.TabStop = false;
            groupBoxOturanMenu.Text = "Oturan Alanı";
            // 
            // buttonDaireBul
            // 
            buttonDaireBul.Font = new Font("Calibri", 11F);
            buttonDaireBul.ForeColor = SystemColors.ControlText;
            buttonDaireBul.Location = new Point(266, 87);
            buttonDaireBul.Name = "buttonDaireBul";
            buttonDaireBul.Size = new Size(150, 64);
            buttonDaireBul.TabIndex = 7;
            buttonDaireBul.Text = "Onayla";
            buttonDaireBul.UseVisualStyleBackColor = true;
            buttonDaireBul.Click += buttonDaireBulOnayla_Click;
            // 
            // buttonOturanSilmeIptal
            // 
            buttonOturanSilmeIptal.BackColor = SystemColors.Control;
            buttonOturanSilmeIptal.Font = new Font("Calibri", 11F);
            buttonOturanSilmeIptal.ForeColor = SystemColors.ControlText;
            buttonOturanSilmeIptal.Location = new Point(99, 88);
            buttonOturanSilmeIptal.Name = "buttonOturanSilmeIptal";
            buttonOturanSilmeIptal.Size = new Size(151, 64);
            buttonOturanSilmeIptal.TabIndex = 8;
            buttonOturanSilmeIptal.Text = "İptal";
            buttonOturanSilmeIptal.UseVisualStyleBackColor = false;
            buttonOturanSilmeIptal.Click += buttonDaireBulIptal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F);
            label1.Location = new Point(13, 46);
            label1.Name = "label1";
            label1.Size = new Size(220, 27);
            label1.TabIndex = 7;
            label1.Text = "Daire numarasini girin:";
            // 
            // textBoxDaireBul
            // 
            textBoxDaireBul.Font = new Font("Calibri", 11F);
            textBoxDaireBul.Location = new Point(242, 44);
            textBoxDaireBul.Name = "textBoxDaireBul";
            textBoxDaireBul.Size = new Size(174, 34);
            textBoxDaireBul.TabIndex = 7;
            // 
            // groupBoxDaireBul
            // 
            groupBoxDaireBul.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxDaireBul.Controls.Add(label1);
            groupBoxDaireBul.Controls.Add(buttonDaireBul);
            groupBoxDaireBul.Controls.Add(buttonOturanSilmeIptal);
            groupBoxDaireBul.Controls.Add(textBoxDaireBul);
            groupBoxDaireBul.Font = new Font("Calibri", 11F);
            groupBoxDaireBul.Location = new Point(914, 597);
            groupBoxDaireBul.Name = "groupBoxDaireBul";
            groupBoxDaireBul.Size = new Size(450, 172);
            groupBoxDaireBul.TabIndex = 9;
            groupBoxDaireBul.TabStop = false;
            groupBoxDaireBul.Text = "Daire Bul";
            groupBoxDaireBul.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonOdemeMenu);
            groupBox1.Controls.Add(comboBoxOdemeMenu);
            groupBox1.Font = new Font("Calibri", 11F);
            groupBox1.Location = new Point(158, 405);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(578, 172);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödeme Alanı";
            // 
            // buttonOdemeMenu
            // 
            buttonOdemeMenu.Font = new Font("Calibri", 11F);
            buttonOdemeMenu.Location = new Point(392, 97);
            buttonOdemeMenu.Name = "buttonOdemeMenu";
            buttonOdemeMenu.Size = new Size(146, 53);
            buttonOdemeMenu.TabIndex = 11;
            buttonOdemeMenu.Text = "Devam";
            buttonOdemeMenu.UseVisualStyleBackColor = true;
            buttonOdemeMenu.Click += buttonOdemeMenu_Click;
            // 
            // comboBoxOdemeMenu
            // 
            comboBoxOdemeMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOdemeMenu.FormattingEnabled = true;
            comboBoxOdemeMenu.Location = new Point(62, 39);
            comboBoxOdemeMenu.Name = "comboBoxOdemeMenu";
            comboBoxOdemeMenu.Size = new Size(476, 35);
            comboBoxOdemeMenu.TabIndex = 11;
            comboBoxOdemeMenu.SelectedIndexChanged += comboBoxOdemeMenu_SelectedIndexChanged;
            // 
            // buttonMekanlar
            // 
            buttonMekanlar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMekanlar.BackColor = SystemColors.Control;
            buttonMekanlar.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMekanlar.ForeColor = SystemColors.ControlText;
            buttonMekanlar.Location = new Point(914, 39);
            buttonMekanlar.Name = "buttonMekanlar";
            buttonMekanlar.Size = new Size(340, 91);
            buttonMekanlar.TabIndex = 11;
            buttonMekanlar.Text = "Havuz / Spor Salonu Kullanımı";
            buttonMekanlar.UseVisualStyleBackColor = false;
            buttonMekanlar.Click += buttonMekanlar_Click;
            // 
            // comboBoxRapor
            // 
            comboBoxRapor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRapor.FormattingEnabled = true;
            comboBoxRapor.Location = new Point(61, 42);
            comboBoxRapor.Name = "comboBoxRapor";
            comboBoxRapor.Size = new Size(477, 35);
            comboBoxRapor.TabIndex = 12;
            comboBoxRapor.SelectedIndexChanged += comboBoxRapor_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonRaporOnayla);
            groupBox2.Controls.Add(comboBoxRapor);
            groupBox2.Font = new Font("Calibri", 11F);
            groupBox2.Location = new Point(158, 608);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(578, 172);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Raporlar";
            // 
            // buttonRaporOnayla
            // 
            buttonRaporOnayla.Location = new Point(325, 83);
            buttonRaporOnayla.Name = "buttonRaporOnayla";
            buttonRaporOnayla.Size = new Size(213, 53);
            buttonRaporOnayla.TabIndex = 14;
            buttonRaporOnayla.Text = "Göster";
            buttonRaporOnayla.UseVisualStyleBackColor = true;
            buttonRaporOnayla.Click += buttonRaporOnayla_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 23);
            label3.Name = "label3";
            label3.Size = new Size(693, 64);
            label3.TabIndex = 17;
            label3.Text = "SAKARYA TATIL SITESI YÖNETIMI";
            // 
            // buttonKazanc
            // 
            buttonKazanc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonKazanc.BackColor = SystemColors.Control;
            buttonKazanc.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonKazanc.ForeColor = SystemColors.ControlText;
            buttonKazanc.Location = new Point(1288, 39);
            buttonKazanc.Name = "buttonKazanc";
            buttonKazanc.Size = new Size(133, 91);
            buttonKazanc.TabIndex = 21;
            buttonKazanc.Text = "Toplam kazanç";
            buttonKazanc.UseVisualStyleBackColor = false;
            buttonKazanc.Click += buttonKazanc_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(170, 11);
            label7.Name = "label7";
            label7.Size = new Size(141, 27);
            label7.TabIndex = 19;
            label7.Text = "GÜNÜN ÖZETİ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelBildirim
            // 
            labelBildirim.AutoSize = true;
            labelBildirim.Location = new Point(43, 183);
            labelBildirim.Name = "labelBildirim";
            labelBildirim.Size = new Size(295, 27);
            labelBildirim.TabIndex = 18;
            labelBildirim.Text = "Önemli Bildirimler: Bildirim yok";
            // 
            // labelBosDaireSayisi
            // 
            labelBosDaireSayisi.AutoSize = true;
            labelBosDaireSayisi.Location = new Point(43, 148);
            labelBosDaireSayisi.Name = "labelBosDaireSayisi";
            labelBosDaireSayisi.Size = new Size(173, 27);
            labelBosDaireSayisi.TabIndex = 16;
            labelBosDaireSayisi.Text = "Boş daire sayısı: 0";
            // 
            // labelDoluDaireSayisi
            // 
            labelDoluDaireSayisi.AutoSize = true;
            labelDoluDaireSayisi.Location = new Point(41, 115);
            labelDoluDaireSayisi.Name = "labelDoluDaireSayisi";
            labelDoluDaireSayisi.Size = new Size(183, 27);
            labelDoluDaireSayisi.TabIndex = 15;
            labelDoluDaireSayisi.Text = "Dolu daire sayısı: 0";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(labelDoluDaireSayisi);
            panel1.Controls.Add(labelBildirim);
            panel1.Controls.Add(labelBosDaireSayisi);
            panel1.Location = new Point(914, 220);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 271);
            panel1.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 80);
            label2.Name = "label2";
            label2.Size = new Size(200, 27);
            label2.TabIndex = 23;
            label2.Text = "Toplam bina sayısı: 9";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1589, 880);
            Controls.Add(panel1);
            Controls.Add(buttonKazanc);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxOturanMenu);
            Controls.Add(buttonMekanlar);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxDaireBul);
            Font = new Font("Calibri", 11F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SAKARYA TATIL SITESI YÖNETIMI";
            Load += Form1_Load;
            groupBoxOturanMenu.ResumeLayout(false);
            groupBoxDaireBul.ResumeLayout(false);
            groupBoxDaireBul.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonOturnMenu;
        private ComboBox comboBoxOturanMenu;
        private GroupBox groupBoxOturanMenu;
        private Button buttonDaireBul;
        private Button buttonOturanSilmeIptal;
        private Label label1;
        private TextBox textBoxDaireBul;
        private GroupBox groupBoxDaireBul;
        private GroupBox groupBox1;
        private ComboBox comboBoxOdemeMenu;
        private Button buttonOdemeMenu;
        private Button buttonMekanlar;
        private ComboBox comboBoxRapor;
        private GroupBox groupBox2;
        private Button buttonRaporOnayla;
        private Label label3;
        private Button buttonKazanc;
        private Label labelBildirim;
        private Label labelBosDaireSayisi;
        private Label labelDoluDaireSayisi;
        private Label label7;
        private Panel panel1;
        private Label label2;
    }
}
