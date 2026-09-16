namespace NDPproje
{
    partial class FormRapor
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
            dataGridViewRapor = new DataGridView();
            labelrapor = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRapor).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRapor
            // 
            dataGridViewRapor.AllowUserToAddRows = false;
            dataGridViewRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRapor.Location = new Point(5, 71);
            dataGridViewRapor.Name = "dataGridViewRapor";
            dataGridViewRapor.ReadOnly = true;
            dataGridViewRapor.RowHeadersWidth = 62;
            dataGridViewRapor.Size = new Size(1311, 461);
            dataGridViewRapor.TabIndex = 0;
            // 
            // labelrapor
            // 
            labelrapor.AutoSize = true;
            labelrapor.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelrapor.Location = new Point(523, 9);
            labelrapor.Name = "labelrapor";
            labelrapor.Size = new Size(139, 45);
            labelrapor.TabIndex = 1;
            labelrapor.Text = "Raporlar";
            labelrapor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormRapor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 537);
            Controls.Add(labelrapor);
            Controls.Add(dataGridViewRapor);
            Name = "FormRapor";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRapor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRapor;
        private Label labelrapor;
    }
}