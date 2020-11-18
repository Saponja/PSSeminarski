namespace Forms.UserControls
{
    partial class UCZakazivanjePregleda
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
            this.dgvPregled = new System.Windows.Forms.DataGridView();
            this.dgvPacijent = new System.Windows.Forms.DataGridView();
            this.btnZakazi = new System.Windows.Forms.Button();
            this.cbLekar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.MaskedTextBox();
            this.txtVreme = new System.Windows.Forms.MaskedTextBox();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPregled
            // 
            this.dgvPregled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregled.Location = new System.Drawing.Point(0, 14);
            this.dgvPregled.Name = "dgvPregled";
            this.dgvPregled.RowHeadersWidth = 51;
            this.dgvPregled.RowTemplate.Height = 24;
            this.dgvPregled.Size = new System.Drawing.Size(463, 215);
            this.dgvPregled.TabIndex = 0;
            // 
            // dgvPacijent
            // 
            this.dgvPacijent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacijent.Location = new System.Drawing.Point(469, 14);
            this.dgvPacijent.Name = "dgvPacijent";
            this.dgvPacijent.RowHeadersWidth = 51;
            this.dgvPacijent.RowTemplate.Height = 24;
            this.dgvPacijent.Size = new System.Drawing.Size(354, 215);
            this.dgvPacijent.TabIndex = 2;
            // 
            // btnZakazi
            // 
            this.btnZakazi.Location = new System.Drawing.Point(179, 420);
            this.btnZakazi.Name = "btnZakazi";
            this.btnZakazi.Size = new System.Drawing.Size(117, 34);
            this.btnZakazi.TabIndex = 3;
            this.btnZakazi.Text = "Zakazi termin";
            this.btnZakazi.UseVisualStyleBackColor = true;
            this.btnZakazi.Click += new System.EventHandler(this.btnZakazi_Click);
            // 
            // cbLekar
            // 
            this.cbLekar.FormattingEnabled = true;
            this.cbLekar.Location = new System.Drawing.Point(175, 287);
            this.cbLekar.Name = "cbLekar";
            this.cbLekar.Size = new System.Drawing.Size(121, 24);
            this.cbLekar.TabIndex = 7;
            this.cbLekar.SelectionChangeCommitted += new System.EventHandler(this.cbLekar_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lekar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vreme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Datum";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(175, 326);
            this.txtDatum.Mask = "00/00/0000";
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(121, 22);
            this.txtDatum.TabIndex = 11;
            this.txtDatum.ValidatingType = typeof(System.DateTime);
            // 
            // txtVreme
            // 
            this.txtVreme.Location = new System.Drawing.Point(175, 366);
            this.txtVreme.Mask = "00:00";
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.Size = new System.Drawing.Size(121, 22);
            this.txtVreme.TabIndex = 12;
            this.txtVreme.ValidatingType = typeof(System.DateTime);
            // 
            // dgvTermini
            // 
            this.dgvTermini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(338, 235);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.Size = new System.Drawing.Size(485, 219);
            this.dgvTermini.TabIndex = 13;
            // 
            // UCZakazivanjePregleda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.txtVreme);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLekar);
            this.Controls.Add(this.btnZakazi);
            this.Controls.Add(this.dgvPacijent);
            this.Controls.Add(this.dgvPregled);
            this.Name = "UCZakazivanjePregleda";
            this.Size = new System.Drawing.Size(839, 472);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregled;
        private System.Windows.Forms.DataGridView dgvPacijent;
        private System.Windows.Forms.Button btnZakazi;
        private System.Windows.Forms.ComboBox cbLekar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtDatum;
        private System.Windows.Forms.MaskedTextBox txtVreme;
        private System.Windows.Forms.DataGridView dgvTermini;
    }
}
