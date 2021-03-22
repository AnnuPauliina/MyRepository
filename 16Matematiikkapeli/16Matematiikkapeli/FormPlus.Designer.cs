namespace _16Matematiikkapeli
{
    partial class FormPlus
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
            this.lblensimmäinen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltoinen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxtulos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblpisteet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblensimmäinen
            // 
            this.lblensimmäinen.AutoSize = true;
            this.lblensimmäinen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblensimmäinen.Location = new System.Drawing.Point(12, 39);
            this.lblensimmäinen.Name = "lblensimmäinen";
            this.lblensimmäinen.Size = new System.Drawing.Size(53, 20);
            this.lblensimmäinen.TabIndex = 0;
            this.lblensimmäinen.Text = "label1";
            this.lblensimmäinen.Click += new System.EventHandler(this.lblensimmäinen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // lbltoinen
            // 
            this.lbltoinen.AutoSize = true;
            this.lbltoinen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoinen.Location = new System.Drawing.Point(96, 39);
            this.lbltoinen.Name = "lbltoinen";
            this.lbltoinen.Size = new System.Drawing.Size(53, 20);
            this.lbltoinen.TabIndex = 2;
            this.lbltoinen.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // boxtulos
            // 
            this.boxtulos.Location = new System.Drawing.Point(177, 39);
            this.boxtulos.Name = "boxtulos";
            this.boxtulos.Size = new System.Drawing.Size(100, 22);
            this.boxtulos.TabIndex = 4;
            this.boxtulos.TextChanged += new System.EventHandler(this.boxtulos_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Laske";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblpisteet
            // 
            this.lblpisteet.AutoSize = true;
            this.lblpisteet.Location = new System.Drawing.Point(12, 9);
            this.lblpisteet.Name = "lblpisteet";
            this.lblpisteet.Size = new System.Drawing.Size(46, 17);
            this.lblpisteet.TabIndex = 6;
            this.lblpisteet.Text = "label3";
            // 
            // FormPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 156);
            this.Controls.Add(this.lblpisteet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxtulos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltoinen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblensimmäinen);
            this.Name = "FormPlus";
            this.Text = "Pluslasku";
            this.Load += new System.EventHandler(this.FormPlus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblensimmäinen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltoinen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxtulos;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblpisteet;
    }
}