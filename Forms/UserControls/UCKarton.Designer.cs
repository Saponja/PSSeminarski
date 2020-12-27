namespace Forms.UserControls
{
    partial class UCKarton
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
            this.gbKarton = new System.Windows.Forms.GroupBox();
            this.lblTermin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDijagnoze = new System.Windows.Forms.DataGridView();
            this.lblPacijent = new System.Windows.Forms.Label();
            this.gbKarton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijagnoze)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKarton
            // 
            this.gbKarton.Controls.Add(this.lblTermin);
            this.gbKarton.Controls.Add(this.label1);
            this.gbKarton.Controls.Add(this.dgvDijagnoze);
            this.gbKarton.Location = new System.Drawing.Point(12, 60);
            this.gbKarton.Name = "gbKarton";
            this.gbKarton.Size = new System.Drawing.Size(676, 391);
            this.gbKarton.TabIndex = 3;
            this.gbKarton.TabStop = false;
            this.gbKarton.Text = "Karton";
            // 
            // lblTermin
            // 
            this.lblTermin.AutoSize = true;
            this.lblTermin.Location = new System.Drawing.Point(496, 30);
            this.lblTermin.Name = "lblTermin";
            this.lblTermin.Size = new System.Drawing.Size(46, 17);
            this.lblTermin.TabIndex = 2;
            this.lblTermin.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sledeci pregled:";
            // 
            // dgvDijagnoze
            // 
            this.dgvDijagnoze.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDijagnoze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDijagnoze.Location = new System.Drawing.Point(6, 30);
            this.dgvDijagnoze.Name = "dgvDijagnoze";
            this.dgvDijagnoze.RowHeadersWidth = 51;
            this.dgvDijagnoze.RowTemplate.Height = 24;
            this.dgvDijagnoze.Size = new System.Drawing.Size(351, 273);
            this.dgvDijagnoze.TabIndex = 0;
            // 
            // lblPacijent
            // 
            this.lblPacijent.AutoSize = true;
            this.lblPacijent.Location = new System.Drawing.Point(18, 19);
            this.lblPacijent.Name = "lblPacijent";
            this.lblPacijent.Size = new System.Drawing.Size(46, 17);
            this.lblPacijent.TabIndex = 4;
            this.lblPacijent.Text = "label2";
            // 
            // UCKarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPacijent);
            this.Controls.Add(this.gbKarton);
            this.Name = "UCKarton";
            this.Size = new System.Drawing.Size(730, 527);
            this.gbKarton.ResumeLayout(false);
            this.gbKarton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijagnoze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKarton;
        private System.Windows.Forms.Label lblTermin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDijagnoze;
        private System.Windows.Forms.Label lblPacijent;
    }
}
