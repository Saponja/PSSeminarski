namespace Forms.UserControls
{
    partial class UCUnosDijagnoze
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvDijagnoze = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijagnoze)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDijagnoze
            // 
            this.dgvDijagnoze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDijagnoze.Location = new System.Drawing.Point(29, 25);
            this.dgvDijagnoze.Name = "dgvDijagnoze";
            this.dgvDijagnoze.RowHeadersWidth = 51;
            this.dgvDijagnoze.RowTemplate.Height = 24;
            this.dgvDijagnoze.Size = new System.Drawing.Size(632, 286);
            this.dgvDijagnoze.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(29, 337);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(131, 47);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(209, 337);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(261, 47);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "Unesi u sistem";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // UCUnosDijagnoze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvDijagnoze);
            this.Name = "UCUnosDijagnoze";
            this.Size = new System.Drawing.Size(711, 468);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijagnoze)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvDijagnoze;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUnesi;
    }
}
