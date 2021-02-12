namespace Forms.UserControls
{
    partial class UCPrikazPacijentaNovo
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
            this.btnObrisi = new System.Windows.Forms.Button();
            this.rbNe = new System.Windows.Forms.RadioButton();
            this.rbDa = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolnica = new System.Windows.Forms.TextBox();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvPacijenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(656, 118);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 21;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // rbNe
            // 
            this.rbNe.AutoSize = true;
            this.rbNe.Location = new System.Drawing.Point(183, 131);
            this.rbNe.Name = "rbNe";
            this.rbNe.Size = new System.Drawing.Size(47, 21);
            this.rbNe.TabIndex = 20;
            this.rbNe.TabStop = true;
            this.rbNe.Text = "Ne";
            this.rbNe.UseVisualStyleBackColor = true;
            // 
            // rbDa
            // 
            this.rbDa.AutoSize = true;
            this.rbDa.Location = new System.Drawing.Point(130, 131);
            this.rbDa.Name = "rbDa";
            this.rbDa.Size = new System.Drawing.Size(47, 21);
            this.rbDa.TabIndex = 19;
            this.rbDa.TabStop = true;
            this.rbDa.Text = "Da";
            this.rbDa.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hitan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bolnica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id pacijenta";
            // 
            // txtBolnica
            // 
            this.txtBolnica.Location = new System.Drawing.Point(130, 80);
            this.txtBolnica.Name = "txtBolnica";
            this.txtBolnica.Size = new System.Drawing.Size(100, 22);
            this.txtBolnica.TabIndex = 15;
            // 
            // btnResetuj
            // 
            this.btnResetuj.Location = new System.Drawing.Point(656, 74);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(75, 23);
            this.btnResetuj.TabIndex = 14;
            this.btnResetuj.Text = "Resetuj";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.btnResetuj_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(130, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 13;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(656, 37);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 12;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
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
            this.dgvPacijenti.Location = new System.Drawing.Point(3, 197);
            this.dgvPacijenti.MultiSelect = false;
            this.dgvPacijenti.Name = "dgvPacijenti";
            this.dgvPacijenti.RowHeadersWidth = 51;
            this.dgvPacijenti.RowTemplate.Height = 24;
            this.dgvPacijenti.Size = new System.Drawing.Size(783, 272);
            this.dgvPacijenti.TabIndex = 11;
            // 
            // UCPrikazPacijentaNovo
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
            this.Name = "UCPrikazPacijentaNovo";
            this.Size = new System.Drawing.Size(788, 472);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.RadioButton rbNe;
        private System.Windows.Forms.RadioButton rbDa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBolnica;
        private System.Windows.Forms.Button btnResetuj;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvPacijenti;
    }
}
