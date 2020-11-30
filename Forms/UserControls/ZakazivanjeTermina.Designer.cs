namespace Forms.UserControls
{
    partial class ZakazivanjeTermina
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
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.cbLekari = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnZakazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(34, 134);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.Size = new System.Drawing.Size(696, 257);
            this.dgvTermini.TabIndex = 0;
            // 
            // cbLekari
            // 
            this.cbLekari.FormattingEnabled = true;
            this.cbLekari.Location = new System.Drawing.Point(99, 28);
            this.cbLekari.Name = "cbLekari";
            this.cbLekari.Size = new System.Drawing.Size(121, 24);
            this.cbLekari.TabIndex = 1;
            this.cbLekari.Text = "Izabrani lekar";
            this.cbLekari.SelectionChangeCommitted += new System.EventHandler(this.cbLekari_SelectionChangeCommitted);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(516, 28);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnZakazi
            // 
            this.btnZakazi.Location = new System.Drawing.Point(636, 29);
            this.btnZakazi.Name = "btnZakazi";
            this.btnZakazi.Size = new System.Drawing.Size(75, 23);
            this.btnZakazi.TabIndex = 3;
            this.btnZakazi.Text = "Zakazi";
            this.btnZakazi.UseVisualStyleBackColor = true;
            this.btnZakazi.Click += new System.EventHandler(this.btnZakazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datum";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(99, 76);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(122, 22);
            this.txtDate.TabIndex = 5;
            // 
            // ZakazivanjeTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZakazi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbLekari);
            this.Controls.Add(this.dgvTermini);
            this.Name = "ZakazivanjeTermina";
            this.Size = new System.Drawing.Size(755, 434);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbLekari;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnZakazi;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDate;
    }
}
