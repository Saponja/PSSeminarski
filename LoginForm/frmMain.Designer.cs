namespace LoginForm
{
    partial class frmMain
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
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unesiPacijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unesiPregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preglediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacijentToolStripMenuItem,
            this.pregledToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiPregledToolStripMenuItem,
            this.preglediToolStripMenuItem});
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.pregledToolStripMenuItem.Text = "Pregled";
            // 
            // unesiPacijentaToolStripMenuItem
            // 
            this.unesiPacijentaToolStripMenuItem.Name = "unesiPacijentaToolStripMenuItem";
            this.unesiPacijentaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.unesiPacijentaToolStripMenuItem.Text = "Unesi pacijenta";
            // 
            // pacijentiToolStripMenuItem
            // 
            this.pacijentiToolStripMenuItem.Name = "pacijentiToolStripMenuItem";
            this.pacijentiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pacijentiToolStripMenuItem.Text = "Pacijenti";
            // 
            // unesiPregledToolStripMenuItem
            // 
            this.unesiPregledToolStripMenuItem.Name = "unesiPregledToolStripMenuItem";
            this.unesiPregledToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.unesiPregledToolStripMenuItem.Text = "Unesi pregled";
            // 
            // preglediToolStripMenuItem
            // 
            this.preglediToolStripMenuItem.Name = "preglediToolStripMenuItem";
            this.preglediToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.preglediToolStripMenuItem.Text = "Pregledi";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main";
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
    }
}