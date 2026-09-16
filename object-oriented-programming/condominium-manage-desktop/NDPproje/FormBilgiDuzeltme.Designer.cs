namespace NDPproje
{
    partial class FormBilgiDuzeltme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonDuzeltmeOnayla = new Button();
            labelDaireNumarasi = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxAdiDuzelt = new TextBox();
            textBoxAkrabaDuzelt = new TextBox();
            labelOdeme = new Label();
            textBoxOdeme = new TextBox();
            buttonDuzeltmeIptal = new Button();
            labelBorcGoster = new Label();
            label1 = new Label();
            textBoxMisafir = new TextBox();
            SuspendLayout();
            // 
            // buttonDuzeltmeOnayla
            // 
            buttonDuzeltmeOnayla.Location = new Point(557, 331);
            buttonDuzeltmeOnayla.Name = "buttonDuzeltmeOnayla";
            buttonDuzeltmeOnayla.Size = new Size(123, 62);
            buttonDuzeltmeOnayla.TabIndex = 1;
            buttonDuzeltmeOnayla.Text = "Onayla";
            buttonDuzeltmeOnayla.UseVisualStyleBackColor = true;
            buttonDuzeltmeOnayla.Click += buttonDuzeltmeOnayla_Click;
            // 
            // labelDaireNumarasi
            // 
            labelDaireNumarasi.AutoSize = true;
            labelDaireNumarasi.Location = new Point(13, 47);
            labelDaireNumarasi.Name = "labelDaireNumarasi";
            labelDaireNumarasi.Size = new Size(147, 27);
            labelDaireNumarasi.TabIndex = 2;
            labelDaireNumarasi.Text = "Oda numarasi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 96);
            label2.Name = "label2";
            label2.Size = new Size(113, 27);
            label2.TabIndex = 4;
            label2.Text = "Adi Soyadi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 152);
            label3.Name = "label3";
            label3.Size = new Size(83, 27);
            label3.TabIndex = 5;
            label3.Text = "Akraba:";
            // 
            // textBoxAdiDuzelt
            // 
            textBoxAdiDuzelt.Location = new Point(162, 90);
            textBoxAdiDuzelt.Name = "textBoxAdiDuzelt";
            textBoxAdiDuzelt.Size = new Size(518, 34);
            textBoxAdiDuzelt.TabIndex = 6;
            // 
            // textBoxAkrabaDuzelt
            // 
            textBoxAkrabaDuzelt.Location = new Point(162, 145);
            textBoxAkrabaDuzelt.Name = "textBoxAkrabaDuzelt";
            textBoxAkrabaDuzelt.Size = new Size(518, 34);
            textBoxAkrabaDuzelt.TabIndex = 7;
            // 
            // labelOdeme
            // 
            labelOdeme.AutoSize = true;
            labelOdeme.Location = new Point(16, 366);
            labelOdeme.Name = "labelOdeme";
            labelOdeme.Size = new Size(134, 27);
            labelOdeme.TabIndex = 8;
            labelOdeme.Text = "Odeme alanı:";
            labelOdeme.Visible = false;
            // 
            // textBoxOdeme
            // 
            textBoxOdeme.Location = new Point(156, 359);
            textBoxOdeme.Name = "textBoxOdeme";
            textBoxOdeme.Size = new Size(228, 34);
            textBoxOdeme.TabIndex = 9;
            textBoxOdeme.Visible = false;
            // 
            // buttonDuzeltmeIptal
            // 
            buttonDuzeltmeIptal.Location = new Point(412, 331);
            buttonDuzeltmeIptal.Name = "buttonDuzeltmeIptal";
            buttonDuzeltmeIptal.Size = new Size(123, 62);
            buttonDuzeltmeIptal.TabIndex = 10;
            buttonDuzeltmeIptal.Text = "Iptal";
            buttonDuzeltmeIptal.UseVisualStyleBackColor = true;
            buttonDuzeltmeIptal.Click += buttonDuzeltmeIptal_Click;
            // 
            // labelBorcGoster
            // 
            labelBorcGoster.AutoSize = true;
            labelBorcGoster.Location = new Point(12, 291);
            labelBorcGoster.Name = "labelBorcGoster";
            labelBorcGoster.Size = new Size(138, 27);
            labelBorcGoster.TabIndex = 11;
            labelBorcGoster.Text = "Borç: 00,00 TL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 204);
            label1.Name = "label1";
            label1.Size = new Size(82, 27);
            label1.TabIndex = 12;
            label1.Text = "Misafir:";
            // 
            // textBoxMisafir
            // 
            textBoxMisafir.Location = new Point(162, 197);
            textBoxMisafir.Name = "textBoxMisafir";
            textBoxMisafir.Size = new Size(518, 34);
            textBoxMisafir.TabIndex = 13;
            // 
            // FormBilgiDuzeltme
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 442);
            Controls.Add(textBoxMisafir);
            Controls.Add(label1);
            Controls.Add(labelBorcGoster);
            Controls.Add(buttonDuzeltmeIptal);
            Controls.Add(textBoxOdeme);
            Controls.Add(labelOdeme);
            Controls.Add(textBoxAkrabaDuzelt);
            Controls.Add(textBoxAdiDuzelt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelDaireNumarasi);
            Controls.Add(buttonDuzeltmeOnayla);
            Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormBilgiDuzeltme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bilgi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonDuzeltmeOnayla;
        private Label labelDaireNumarasi;
        private Label label2;
        private Label label3;
        private TextBox textBoxAdiDuzelt;
        private TextBox textBoxAkrabaDuzelt;
        private Label labelOdeme;
        private TextBox textBoxOdeme;
        private Button buttonDuzeltmeIptal;
        private Label labelBorcGoster;
        private Label label1;
        private TextBox textBoxMisafir;
    }
}