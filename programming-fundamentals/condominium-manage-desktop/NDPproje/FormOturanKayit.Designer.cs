namespace NDPproje
{
    partial class FormOturanKayit
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
            comboBoxBlok = new ComboBox();
            label1 = new Label();
            textBoxOturanAdi = new TextBox();
            groupBoxAkrabaVar = new GroupBox();
            label2 = new Label();
            textBoxAkrabaAdi = new TextBox();
            radioButtonYok = new RadioButton();
            radioButtonVar = new RadioButton();
            label3 = new Label();
            buttonOturanKaydetmek = new Button();
            textBoxKayitOdeme = new TextBox();
            label4 = new Label();
            groupBoxKayitOdeme = new GroupBox();
            label5 = new Label();
            groupBoxAkrabaVar.SuspendLayout();
            groupBoxKayitOdeme.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxBlok
            // 
            comboBoxBlok.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBlok.FormattingEnabled = true;
            comboBoxBlok.Location = new Point(187, 104);
            comboBoxBlok.Name = "comboBoxBlok";
            comboBoxBlok.Size = new Size(450, 35);
            comboBoxBlok.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 175);
            label1.Name = "label1";
            label1.Size = new Size(113, 27);
            label1.TabIndex = 1;
            label1.Text = "Adi Soyadi:";
            // 
            // textBoxOturanAdi
            // 
            textBoxOturanAdi.Location = new Point(187, 172);
            textBoxOturanAdi.Name = "textBoxOturanAdi";
            textBoxOturanAdi.Size = new Size(450, 34);
            textBoxOturanAdi.TabIndex = 2;
            // 
            // groupBoxAkrabaVar
            // 
            groupBoxAkrabaVar.Controls.Add(label2);
            groupBoxAkrabaVar.Controls.Add(textBoxAkrabaAdi);
            groupBoxAkrabaVar.Controls.Add(radioButtonYok);
            groupBoxAkrabaVar.Controls.Add(radioButtonVar);
            groupBoxAkrabaVar.Location = new Point(68, 240);
            groupBoxAkrabaVar.Name = "groupBoxAkrabaVar";
            groupBoxAkrabaVar.Size = new Size(569, 205);
            groupBoxAkrabaVar.TabIndex = 4;
            groupBoxAkrabaVar.TabStop = false;
            groupBoxAkrabaVar.Text = "Akraba var mi?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 99);
            label2.Name = "label2";
            label2.Size = new Size(147, 27);
            label2.TabIndex = 5;
            label2.Text = "Akrabanin Adi:";
            // 
            // textBoxAkrabaAdi
            // 
            textBoxAkrabaAdi.Enabled = false;
            textBoxAkrabaAdi.Location = new Point(19, 130);
            textBoxAkrabaAdi.Name = "textBoxAkrabaAdi";
            textBoxAkrabaAdi.Size = new Size(476, 34);
            textBoxAkrabaAdi.TabIndex = 6;
            // 
            // radioButtonYok
            // 
            radioButtonYok.AutoSize = true;
            radioButtonYok.Location = new Point(133, 49);
            radioButtonYok.Name = "radioButtonYok";
            radioButtonYok.Size = new Size(68, 31);
            radioButtonYok.TabIndex = 6;
            radioButtonYok.TabStop = true;
            radioButtonYok.Text = "Yok";
            radioButtonYok.UseVisualStyleBackColor = true;
            radioButtonYok.CheckedChanged += radioButtonYok_CheckedChanged;
            // 
            // radioButtonVar
            // 
            radioButtonVar.AutoSize = true;
            radioButtonVar.Location = new Point(25, 49);
            radioButtonVar.Name = "radioButtonVar";
            radioButtonVar.Size = new Size(67, 31);
            radioButtonVar.TabIndex = 5;
            radioButtonVar.TabStop = true;
            radioButtonVar.Text = "Var";
            radioButtonVar.UseVisualStyleBackColor = true;
            radioButtonVar.CheckedChanged += radioButtonVar_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 104);
            label3.Name = "label3";
            label3.Size = new Size(92, 27);
            label3.TabIndex = 5;
            label3.Text = "Blok Seç:";
            // 
            // buttonOturanKaydetmek
            // 
            buttonOturanKaydetmek.Location = new Point(476, 509);
            buttonOturanKaydetmek.Name = "buttonOturanKaydetmek";
            buttonOturanKaydetmek.Size = new Size(161, 70);
            buttonOturanKaydetmek.TabIndex = 6;
            buttonOturanKaydetmek.Text = "Kaydet";
            buttonOturanKaydetmek.UseVisualStyleBackColor = true;
            buttonOturanKaydetmek.Click += buttonOturanKaydetmek_Click;
            // 
            // textBoxKayitOdeme
            // 
            textBoxKayitOdeme.Location = new Point(136, 70);
            textBoxKayitOdeme.Name = "textBoxKayitOdeme";
            textBoxKayitOdeme.Size = new Size(217, 34);
            textBoxKayitOdeme.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 73);
            label4.Name = "label4";
            label4.Size = new Size(111, 27);
            label4.TabIndex = 8;
            label4.Text = "Tutar girin:";
            // 
            // groupBoxKayitOdeme
            // 
            groupBoxKayitOdeme.Controls.Add(label4);
            groupBoxKayitOdeme.Controls.Add(textBoxKayitOdeme);
            groupBoxKayitOdeme.Location = new Point(68, 470);
            groupBoxKayitOdeme.Name = "groupBoxKayitOdeme";
            groupBoxKayitOdeme.Size = new Size(377, 109);
            groupBoxKayitOdeme.TabIndex = 9;
            groupBoxKayitOdeme.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(278, 28);
            label5.Name = "label5";
            label5.Size = new Size(208, 35);
            label5.TabIndex = 10;
            label5.Text = "NOVO REGISTRO";
            // 
            // FormOturanKayit
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 608);
            Controls.Add(label5);
            Controls.Add(groupBoxKayitOdeme);
            Controls.Add(buttonOturanKaydetmek);
            Controls.Add(label3);
            Controls.Add(groupBoxAkrabaVar);
            Controls.Add(textBoxOturanAdi);
            Controls.Add(label1);
            Controls.Add(comboBoxBlok);
            Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormOturanKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayit";
            groupBoxAkrabaVar.ResumeLayout(false);
            groupBoxAkrabaVar.PerformLayout();
            groupBoxKayitOdeme.ResumeLayout(false);
            groupBoxKayitOdeme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxBlok;
        private Label label1;
        private TextBox textBoxOturanAdi;
        private GroupBox groupBoxAkrabaVar;
        private RadioButton radioButtonYok;
        private RadioButton radioButtonVar;
        private Label label2;
        private TextBox textBoxAkrabaAdi;
        private Label label3;
        private Button buttonOturanKaydetmek;
        private TextBox textBoxKayitOdeme;
        private Label label4;
        private GroupBox groupBoxKayitOdeme;
        private Label label5;
    }
}