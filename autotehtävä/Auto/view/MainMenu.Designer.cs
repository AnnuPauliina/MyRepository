namespace Autokauppa.view
{
    partial class MainMenu
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantayhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ComboAutonmalli = new System.Windows.Forms.ComboBox();
            this.ComboAutonmerkki = new System.Windows.Forms.ComboBox();
            this.Uusitietuebtn = new System.Windows.Forms.Button();
            this.Tallennabtn = new System.Windows.Forms.Button();
            this.Poistabtn = new System.Windows.Forms.Button();
            this.Edellinenbtn = new System.Windows.Forms.Button();
            this.Seuraavabtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantayhteyttäToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            this.testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            this.testaaTietokantayhteyttäToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            this.testaaTietokantayhteyttäToolStripMenuItem.Click += new System.EventHandler(this.TestaaTietokantayhteytta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Automerkki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Malli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mittarilukema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Moottorin tilavuus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hinta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 303);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rekisteröintipäivämäärä";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 10;
            // 
            // ComboAutonmalli
            // 
            this.ComboAutonmalli.FormattingEnabled = true;
            this.ComboAutonmalli.Location = new System.Drawing.Point(15, 109);
            this.ComboAutonmalli.Name = "ComboAutonmalli";
            this.ComboAutonmalli.Size = new System.Drawing.Size(121, 21);
            this.ComboAutonmalli.TabIndex = 11;
            // 
            // ComboAutonmerkki
            // 
            this.ComboAutonmerkki.FormattingEnabled = true;
            this.ComboAutonmerkki.Location = new System.Drawing.Point(15, 56);
            this.ComboAutonmerkki.Name = "ComboAutonmerkki";
            this.ComboAutonmerkki.Size = new System.Drawing.Size(121, 21);
            this.ComboAutonmerkki.TabIndex = 12;
            this.ComboAutonmerkki.SelectedIndexChanged += new System.EventHandler(this.ComboAutonmerkki_SelectedIndexChanged);
            // 
            // Uusitietuebtn
            // 
            this.Uusitietuebtn.Location = new System.Drawing.Point(333, 40);
            this.Uusitietuebtn.Name = "Uusitietuebtn";
            this.Uusitietuebtn.Size = new System.Drawing.Size(105, 39);
            this.Uusitietuebtn.TabIndex = 13;
            this.Uusitietuebtn.Text = "Uusi tietue";
            this.Uusitietuebtn.UseVisualStyleBackColor = true;
            // 
            // Tallennabtn
            // 
            this.Tallennabtn.Location = new System.Drawing.Point(333, 109);
            this.Tallennabtn.Name = "Tallennabtn";
            this.Tallennabtn.Size = new System.Drawing.Size(105, 39);
            this.Tallennabtn.TabIndex = 14;
            this.Tallennabtn.Text = "Tallenna";
            this.Tallennabtn.UseVisualStyleBackColor = true;
            // 
            // Poistabtn
            // 
            this.Poistabtn.Location = new System.Drawing.Point(333, 178);
            this.Poistabtn.Name = "Poistabtn";
            this.Poistabtn.Size = new System.Drawing.Size(105, 39);
            this.Poistabtn.TabIndex = 15;
            this.Poistabtn.Text = "Poista";
            this.Poistabtn.UseVisualStyleBackColor = true;
            // 
            // Edellinenbtn
            // 
            this.Edellinenbtn.Location = new System.Drawing.Point(277, 245);
            this.Edellinenbtn.Name = "Edellinenbtn";
            this.Edellinenbtn.Size = new System.Drawing.Size(105, 39);
            this.Edellinenbtn.TabIndex = 17;
            this.Edellinenbtn.Text = "Edellinen";
            this.Edellinenbtn.UseVisualStyleBackColor = true;
            // 
            // Seuraavabtn
            // 
            this.Seuraavabtn.Location = new System.Drawing.Point(388, 245);
            this.Seuraavabtn.Name = "Seuraavabtn";
            this.Seuraavabtn.Size = new System.Drawing.Size(105, 39);
            this.Seuraavabtn.TabIndex = 18;
            this.Seuraavabtn.Text = "Seuraava";
            this.Seuraavabtn.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 545);
            this.Controls.Add(this.Seuraavabtn);
            this.Controls.Add(this.Edellinenbtn);
            this.Controls.Add(this.Poistabtn);
            this.Controls.Add(this.Tallennabtn);
            this.Controls.Add(this.Uusitietuebtn);
            this.Controls.Add(this.ComboAutonmerkki);
            this.Controls.Add(this.ComboAutonmalli);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox ComboAutonmalli;
        private System.Windows.Forms.ComboBox ComboAutonmerkki;
        private System.Windows.Forms.Button Uusitietuebtn;
        private System.Windows.Forms.Button Tallennabtn;
        private System.Windows.Forms.Button Poistabtn;
        private System.Windows.Forms.Button Edellinenbtn;
        private System.Windows.Forms.Button Seuraavabtn;
    }
}