namespace _16Matematiikkapeli
{
    partial class FormJako
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
            this.button1 = new System.Windows.Forms.Button();
            this.boxtulos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltoinen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblensimmäinen = new System.Windows.Forms.Label();
            this.lblpisteet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(112, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Laske";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxtulos
            // 
            this.boxtulos.Location = new System.Drawing.Point(189, 59);
            this.boxtulos.Name = "boxtulos";
            this.boxtulos.Size = new System.Drawing.Size(100, 22);
            this.boxtulos.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "=";
            // 
            // lbltoinen
            // 
            this.lbltoinen.AutoSize = true;
            this.lbltoinen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoinen.Location = new System.Drawing.Point(108, 59);
            this.lbltoinen.Name = "lbltoinen";
            this.lbltoinen.Size = new System.Drawing.Size(53, 20);
            this.lbltoinen.TabIndex = 8;
            this.lbltoinen.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "/";
            // 
            // lblensimmäinen
            // 
            this.lblensimmäinen.AutoSize = true;
            this.lblensimmäinen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblensimmäinen.Location = new System.Drawing.Point(24, 59);
            this.lblensimmäinen.Name = "lblensimmäinen";
            this.lblensimmäinen.Size = new System.Drawing.Size(53, 20);
            this.lblensimmäinen.TabIndex = 6;
            this.lblensimmäinen.Text = "label1";
            // 
            // lblpisteet
            // 
            this.lblpisteet.AutoSize = true;
            this.lblpisteet.Location = new System.Drawing.Point(12, 9);
            this.lblpisteet.Name = "lblpisteet";
            this.lblpisteet.Size = new System.Drawing.Size(46, 17);
            this.lblpisteet.TabIndex = 12;
            this.lblpisteet.Text = "label3";
            // 
            // FormJako
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 187);
            this.Controls.Add(this.lblpisteet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxtulos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltoinen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblensimmäinen);
            this.Name = "FormJako";
            this.Text = "FormJako";
            this.Load += new System.EventHandler(this.FormJako_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox boxtulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltoinen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblensimmäinen;
        private System.Windows.Forms.Label lblpisteet;
    }
}