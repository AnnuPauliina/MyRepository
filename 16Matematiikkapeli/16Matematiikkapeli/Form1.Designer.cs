namespace _16Matematiikkapeli
{
    partial class Form1
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
            this.btnKirjaudu = new System.Windows.Forms.Button();
            this.lbltervetuloa = new System.Windows.Forms.Label();
            this.boxUserID = new System.Windows.Forms.TextBox();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKirjaudu
            // 
            this.btnKirjaudu.Location = new System.Drawing.Point(348, 218);
            this.btnKirjaudu.Name = "btnKirjaudu";
            this.btnKirjaudu.Size = new System.Drawing.Size(158, 38);
            this.btnKirjaudu.TabIndex = 0;
            this.btnKirjaudu.Text = "Kirjaudu sisään";
            this.btnKirjaudu.UseVisualStyleBackColor = true;
            this.btnKirjaudu.Click += new System.EventHandler(this.btnKirjaudu_Click);
            // 
            // lbltervetuloa
            // 
            this.lbltervetuloa.AutoSize = true;
            this.lbltervetuloa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltervetuloa.Location = new System.Drawing.Point(259, 30);
            this.lbltervetuloa.Name = "lbltervetuloa";
            this.lbltervetuloa.Size = new System.Drawing.Size(414, 26);
            this.lbltervetuloa.TabIndex = 8;
            this.lbltervetuloa.Text = "Tervetuloa pelaamaan Matematiikkapeliä!";
            // 
            // boxUserID
            // 
            this.boxUserID.Location = new System.Drawing.Point(417, 118);
            this.boxUserID.Name = "boxUserID";
            this.boxUserID.Size = new System.Drawing.Size(100, 22);
            this.boxUserID.TabIndex = 9;
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(417, 146);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(100, 22);
            this.boxPassword.TabIndex = 10;
            this.boxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxPassword_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kirjaudu sisään jatkaaksesi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Käyttäjätunnus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Salasana:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.boxUserID);
            this.Controls.Add(this.lbltervetuloa);
            this.Controls.Add(this.btnKirjaudu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKirjaudu;
        private System.Windows.Forms.Label lbltervetuloa;
        private System.Windows.Forms.TextBox boxUserID;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

