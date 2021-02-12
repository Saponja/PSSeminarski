namespace Forms.UserControls
{
    partial class UCPrikazTermina
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
            this.cbLekari = new System.Windows.Forms.ComboBox();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLekari
            // 
            this.cbLekari.FormattingEnabled = true;
            this.cbLekari.Location = new System.Drawing.Point(28, 70);
            this.cbLekari.Name = "cbLekari";
            this.cbLekari.Size = new System.Drawing.Size(205, 24);
            this.cbLekari.TabIndex = 0;
            this.cbLekari.Text = "Lekar";
            this.cbLekari.SelectionChangeCommitted += new System.EventHandler(this.cbLekari_SelectionChangeCommitted);
            // 
            // dgvTermini
            // 
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(28, 130);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.Size = new System.Drawing.Size(593, 299);
            this.dgvTermini.TabIndex = 1;
            // 
            // UCPrikazTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.cbLekari);
            this.Name = "UCPrikazTermina";
            this.Size = new System.Drawing.Size(826, 555);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLekari;
        private System.Windows.Forms.DataGridView dgvTermini;
    }
}
