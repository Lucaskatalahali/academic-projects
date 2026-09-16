namespace NDPproje
{
    partial class FormMekan
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
            radioButtonSporSalonu = new RadioButton();
            radioButtonHavuz = new RadioButton();
            textBoxMekandaDaire = new TextBox();
            label1 = new Label();
            buttonMekandaDaireAra = new Button();
            groupBox1 = new GroupBox();
            radioButtonMekandaMisafir = new RadioButton();
            radioButtonMekandaAkraba = new RadioButton();
            radioButtonMekandaOturan = new RadioButton();
            groupBox2 = new GroupBox();
            buttonMekanOnayla = new Button();
            button3 = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // radioButtonSporSalonu
            // 
            radioButtonSporSalonu.AutoSize = true;
            radioButtonSporSalonu.Location = new Point(18, 94);
            radioButtonSporSalonu.Name = "radioButtonSporSalonu";
            radioButtonSporSalonu.Size = new Size(146, 31);
            radioButtonSporSalonu.TabIndex = 0;
            radioButtonSporSalonu.TabStop = true;
            radioButtonSporSalonu.Text = "Spor Salonu";
            radioButtonSporSalonu.UseVisualStyleBackColor = true;
            // 
            // radioButtonHavuz
            // 
            radioButtonHavuz.AutoSize = true;
            radioButtonHavuz.Location = new Point(18, 52);
            radioButtonHavuz.Name = "radioButtonHavuz";
            radioButtonHavuz.Size = new Size(93, 31);
            radioButtonHavuz.TabIndex = 1;
            radioButtonHavuz.TabStop = true;
            radioButtonHavuz.Text = "Havuz";
            radioButtonHavuz.UseVisualStyleBackColor = true;
            // 
            // textBoxMekandaDaire
            // 
            textBoxMekandaDaire.Location = new Point(211, 256);
            textBoxMekandaDaire.Name = "textBoxMekandaDaire";
            textBoxMekandaDaire.Size = new Size(152, 34);
            textBoxMekandaDaire.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 262);
            label1.Name = "label1";
            label1.Size = new Size(154, 27);
            label1.TabIndex = 3;
            label1.Text = "Daire Numarasi";
            // 
            // buttonMekandaDaireAra
            // 
            buttonMekandaDaireAra.Location = new Point(393, 254);
            buttonMekandaDaireAra.Name = "buttonMekandaDaireAra";
            buttonMekandaDaireAra.Size = new Size(180, 40);
            buttonMekandaDaireAra.TabIndex = 4;
            buttonMekandaDaireAra.Text = "Ara";
            buttonMekandaDaireAra.UseVisualStyleBackColor = true;
            buttonMekandaDaireAra.Click += buttonMekandaDaireAra_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonMekandaMisafir);
            groupBox1.Controls.Add(radioButtonMekandaAkraba);
            groupBox1.Controls.Add(radioButtonMekandaOturan);
            groupBox1.Location = new Point(43, 318);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 205);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bunu kullanacak kişiyi belirleyin";
            // 
            // radioButtonMekandaMisafir
            // 
            radioButtonMekandaMisafir.AutoSize = true;
            radioButtonMekandaMisafir.Enabled = false;
            radioButtonMekandaMisafir.Location = new Point(16, 148);
            radioButtonMekandaMisafir.Name = "radioButtonMekandaMisafir";
            radioButtonMekandaMisafir.Size = new Size(101, 31);
            radioButtonMekandaMisafir.TabIndex = 6;
            radioButtonMekandaMisafir.TabStop = true;
            radioButtonMekandaMisafir.Text = "Misafir";
            radioButtonMekandaMisafir.UseVisualStyleBackColor = true;
            // 
            // radioButtonMekandaAkraba
            // 
            radioButtonMekandaAkraba.AutoSize = true;
            radioButtonMekandaAkraba.Enabled = false;
            radioButtonMekandaAkraba.Location = new Point(16, 97);
            radioButtonMekandaAkraba.Name = "radioButtonMekandaAkraba";
            radioButtonMekandaAkraba.Size = new Size(102, 31);
            radioButtonMekandaAkraba.TabIndex = 7;
            radioButtonMekandaAkraba.TabStop = true;
            radioButtonMekandaAkraba.Text = "Akraba";
            radioButtonMekandaAkraba.UseVisualStyleBackColor = true;
            // 
            // radioButtonMekandaOturan
            // 
            radioButtonMekandaOturan.AutoSize = true;
            radioButtonMekandaOturan.Enabled = false;
            radioButtonMekandaOturan.Location = new Point(16, 45);
            radioButtonMekandaOturan.Name = "radioButtonMekandaOturan";
            radioButtonMekandaOturan.Size = new Size(102, 31);
            radioButtonMekandaOturan.TabIndex = 8;
            radioButtonMekandaOturan.TabStop = true;
            radioButtonMekandaOturan.Text = "Oturan";
            radioButtonMekandaOturan.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonHavuz);
            groupBox2.Controls.Add(radioButtonSporSalonu);
            groupBox2.Location = new Point(43, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(299, 144);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kullanılacak mekan";
            // 
            // buttonMekanOnayla
            // 
            buttonMekanOnayla.Enabled = false;
            buttonMekanOnayla.Location = new Point(425, 538);
            buttonMekanOnayla.Name = "buttonMekanOnayla";
            buttonMekanOnayla.Size = new Size(148, 58);
            buttonMekanOnayla.TabIndex = 7;
            buttonMekanOnayla.Text = "Onayla";
            buttonMekanOnayla.UseVisualStyleBackColor = true;
            buttonMekanOnayla.Click += buttonMekanOnayla_Click;
            // 
            // button3
            // 
            button3.Location = new Point(271, 538);
            button3.Name = "button3";
            button3.Size = new Size(139, 56);
            button3.TabIndex = 8;
            button3.Text = "Iptal";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(174, 22);
            label2.Name = "label2";
            label2.Size = new Size(279, 35);
            label2.TabIndex = 9;
            label2.Text = "HAVUZ / SPOR SALONU";
            // 
            // FormMekan
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 642);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(buttonMekanOnayla);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonMekandaDaireAra);
            Controls.Add(label1);
            Controls.Add(textBoxMekandaDaire);
            Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormMekan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "havuz - Fitness";
            Load += FormMekan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonSporSalonu;
        private RadioButton radioButtonHavuz;
        private TextBox textBoxMekandaDaire;
        private Label label1;
        private Button buttonMekandaDaireAra;
        private GroupBox groupBox1;
        private RadioButton radioButtonMekandaOturan;
        private RadioButton radioButtonMekandaMisafir;
        private RadioButton radioButtonMekandaAkraba;
        private GroupBox groupBox2;
        private Button buttonMekanOnayla;
        private Button button3;
        private Label label2;
    }
}