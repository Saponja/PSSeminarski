namespace Forms.UserControls
{
    partial class UCPrikazPregleda
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
            this.dgvPregledi = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLekar = new System.Windows.Forms.TextBox();
            this.txtOblast = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPregledi
            // 
            this.dgvPregledi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledi.Location = new System.Drawing.Point(0, 182);
            this.dgvPregledi.Name = "dgvPregledi";
            this.dgvPregledi.RowHeadersWidth = 51;
            this.dgvPregledi.RowTemplate.Height = 24;
            this.dgvPregledi.Size = new System.Drawing.Size(839, 290);
            this.dgvPregledi.TabIndex = 0;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(674, 48);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 1;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lekar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oblast";
            // 
            // txtLekar
            // 
            this.txtLekar.Location = new System.Drawing.Point(106, 48);
            this.txtLekar.Name = "txtLekar";
            this.txtLekar.Size = new System.Drawing.Size(169, 22);
            this.txtLekar.TabIndex = 4;
            // 
            // txtOblast
            // 
            this.txtOblast.Location = new System.Drawing.Point(106, 111);
            this.txtOblast.Name = "txtOblast";
            this.txtOblast.Size = new System.Drawing.Size(169, 22);
            this.txtOblast.TabIndex = 5;
            // 
            // UCPrikazPregleda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtOblast);
            this.Controls.Add(this.txtLekar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvPregledi);
            this.Name = "UCPrikazPregleda";
            this.Size = new System.Drawing.Size(839, 472);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledi;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLekar;
        private System.Windows.Forms.TextBox txtOblast;
    }
}
