﻿namespace Forms
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unesiPacijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unesiPregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preglediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakaziPregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakaziPregledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.terminiLekaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajDijagnozeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGlavni = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacijentToolStripMenuItem,
            this.pregledToolStripMenuItem,
            this.zakaziPregledToolStripMenuItem,
            this.dodajDijagnozeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacijentToolStripMenuItem
            // 
            this.pacijentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiPacijentaToolStripMenuItem,
            this.pacijentiToolStripMenuItem});
            this.pacijentToolStripMenuItem.Name = "pacijentToolStripMenuItem";
            this.pacijentToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.pacijentToolStripMenuItem.Text = "Pacijent";
            // 
            // unesiPacijentaToolStripMenuItem
            // 
            this.unesiPacijentaToolStripMenuItem.Name = "unesiPacijentaToolStripMenuItem";
            this.unesiPacijentaToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.unesiPacijentaToolStripMenuItem.Text = "Unesi pacijenta";
            this.unesiPacijentaToolStripMenuItem.Click += new System.EventHandler(this.unesiPacijentaToolStripMenuItem_Click);
            // 
            // pacijentiToolStripMenuItem
            // 
            this.pacijentiToolStripMenuItem.Name = "pacijentiToolStripMenuItem";
            this.pacijentiToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.pacijentiToolStripMenuItem.Text = "Pacijenti";
            this.pacijentiToolStripMenuItem.Click += new System.EventHandler(this.pacijentiToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiPregledToolStripMenuItem,
            this.preglediToolStripMenuItem});
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.pregledToolStripMenuItem.Text = "Pregled";
            // 
            // unesiPregledToolStripMenuItem
            // 
            this.unesiPregledToolStripMenuItem.Name = "unesiPregledToolStripMenuItem";
            this.unesiPregledToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.unesiPregledToolStripMenuItem.Text = "Unesi pregled";
            this.unesiPregledToolStripMenuItem.Click += new System.EventHandler(this.unesiPregledToolStripMenuItem_Click);
            // 
            // preglediToolStripMenuItem
            // 
            this.preglediToolStripMenuItem.Name = "preglediToolStripMenuItem";
            this.preglediToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.preglediToolStripMenuItem.Text = "Pregledi";
            this.preglediToolStripMenuItem.Click += new System.EventHandler(this.preglediToolStripMenuItem_Click);
            // 
            // zakaziPregledToolStripMenuItem
            // 
            this.zakaziPregledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakaziPregledToolStripMenuItem1,
            this.terminiLekaraToolStripMenuItem});
            this.zakaziPregledToolStripMenuItem.Name = "zakaziPregledToolStripMenuItem";
            this.zakaziPregledToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.zakaziPregledToolStripMenuItem.Text = "Termini";
            // 
            // zakaziPregledToolStripMenuItem1
            // 
            this.zakaziPregledToolStripMenuItem1.Name = "zakaziPregledToolStripMenuItem1";
            this.zakaziPregledToolStripMenuItem1.Size = new System.Drawing.Size(191, 26);
            this.zakaziPregledToolStripMenuItem1.Text = "Zakazi pregled";
            this.zakaziPregledToolStripMenuItem1.Click += new System.EventHandler(this.zakaziPregledToolStripMenuItem1_Click);
            // 
            // terminiLekaraToolStripMenuItem
            // 
            this.terminiLekaraToolStripMenuItem.Name = "terminiLekaraToolStripMenuItem";
            this.terminiLekaraToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.terminiLekaraToolStripMenuItem.Text = "Termini lekara";
            this.terminiLekaraToolStripMenuItem.Click += new System.EventHandler(this.terminiLekaraToolStripMenuItem_Click);
            // 
            // dodajDijagnozeToolStripMenuItem
            // 
            this.dodajDijagnozeToolStripMenuItem.Name = "dodajDijagnozeToolStripMenuItem";
            this.dodajDijagnozeToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.dodajDijagnozeToolStripMenuItem.Text = "Dodaj dijagnoze";
            this.dodajDijagnozeToolStripMenuItem.Click += new System.EventHandler(this.dodajDijagnozeToolStripMenuItem_Click);
            // 
            // pnlGlavni
            // 
            this.pnlGlavni.Location = new System.Drawing.Point(0, 31);
            this.pnlGlavni.Name = "pnlGlavni";
            this.pnlGlavni.Size = new System.Drawing.Size(839, 472);
            this.pnlGlavni.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 502);
            this.Controls.Add(this.pnlGlavni);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Klinika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unesiPacijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unesiPregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preglediToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGlavni;
        private System.Windows.Forms.ToolStripMenuItem zakaziPregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajDijagnozeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakaziPregledToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem terminiLekaraToolStripMenuItem;
    }
}