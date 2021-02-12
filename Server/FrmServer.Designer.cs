namespace Server
{
    partial class FrmServer
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
            this.btnPokerni = new System.Windows.Forms.Button();
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPokerni
            // 
            this.btnPokerni.Location = new System.Drawing.Point(50, 27);
            this.btnPokerni.Name = "btnPokerni";
            this.btnPokerni.Size = new System.Drawing.Size(151, 47);
            this.btnPokerni.TabIndex = 0;
            this.btnPokerni.Text = "Pokreni";
            this.btnPokerni.UseVisualStyleBackColor = true;
            this.btnPokerni.Click += new System.EventHandler(this.btnPokerni_Click);
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.Location = new System.Drawing.Point(228, 27);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(165, 47);
            this.btnZaustavi.TabIndex = 1;
            this.btnZaustavi.Text = "Zaustavi";
            this.btnZaustavi.UseVisualStyleBackColor = true;
            this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click);
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Location = new System.Drawing.Point(50, 105);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.RowHeadersWidth = 51;
            this.dgvKlijenti.RowTemplate.Height = 24;
            this.dgvKlijenti.Size = new System.Drawing.Size(713, 309);
            this.dgvKlijenti.TabIndex = 2;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKlijenti);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnPokerni);
            this.Name = "FrmServer";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmServer_FormClosing);
            this.Load += new System.EventHandler(this.FrmServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPokerni;
        private System.Windows.Forms.Button btnZaustavi;
        private System.Windows.Forms.DataGridView dgvKlijenti;
    }
}

