namespace Forms.UserControls
{
    partial class UCPrikazPacijenata
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
            this.dgvPacijenti = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.txtBolnica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbDa = new System.Windows.Forms.RadioButton();
            this.rbNe = new System.Windows.Forms.RadioButton();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacijenti
            // 
            this.dgvPacijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacijenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacijenti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPacijenti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacijenti.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPacijenti.Location = new System.Drawing.Point(0, 173);
            this.dgvPacijenti.Name = "dgvPacijenti";
            this.dgvPacijenti.RowHeadersWidth = 51;
            this.dgvPacijenti.RowTemplate.Height = 24;
            this.dgvPacijenti.Size = new System.Drawing.Size(783, 290);
            this.dgvPacijenti.TabIndex = 0;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(653, 18);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 1;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(127, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 2;
            // 
            // btnResetuj
            // 
            this.btnResetuj.Location = new System.Drawing.Point(653, 55);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(75, 23);
            this.btnResetuj.TabIndex = 3;
            this.btnResetuj.Text = "Resetuj";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.btnResetuj_Click);
            // 
            // txtBolnica
            // 
            this.txtBolnica.Location = new System.Drawing.Point(127, 61);
            this.txtBolnica.Name = "txtBolnica";
            this.txtBolnica.Size = new System.Drawing.Size(100, 22);
            this.txtBolnica.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id pacijenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bolnica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hitan";
            // 
            // rbDa
            // 
            this.rbDa.AutoSize = true;
            this.rbDa.Location = new System.Drawing.Point(127, 112);
            this.rbDa.Name = "rbDa";
            this.rbDa.Size = new System.Drawing.Size(47, 21);
            this.rbDa.TabIndex = 8;
            this.rbDa.TabStop = true;
            this.rbDa.Text = "Da";
            this.rbDa.UseVisualStyleBackColor = true;
            // 
            // rbNe
            // 
            this.rbNe.AutoSize = true;
            this.rbNe.Location = new System.Drawing.Point(180, 112);
            this.rbNe.Name = "rbNe";
            this.rbNe.Size = new System.Drawing.Size(47, 21);
            this.rbNe.TabIndex = 9;
            this.rbNe.TabStop = true;
            this.rbNe.Text = "Ne";
            this.rbNe.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(653, 99);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 10;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // UCPrikazPacijenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.rbNe);
            this.Controls.Add(this.rbDa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBolnica);
            this.Controls.Add(this.btnResetuj);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvPacijenti);
            this.Name = "UCPrikazPacijenata";
            this.Size = new System.Drawing.Size(783, 463);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacijenti;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnResetuj;
        private System.Windows.Forms.TextBox txtBolnica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbDa;
        private System.Windows.Forms.RadioButton rbNe;
        private System.Windows.Forms.Button btnObrisi;
    }
}
