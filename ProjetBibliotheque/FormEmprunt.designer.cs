namespace ProjetBibliotheque
{
    partial class FormEmprunt
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
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDateEmprunt = new System.Windows.Forms.DateTimePicker();
            this.domainUpDownLivre = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownAdherent = new System.Windows.Forms.DomainUpDown();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDateRetour = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(196, 138);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnregistrer.TabIndex = 0;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "date emprunt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "date de retour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "livre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "adhérent";
            // 
            // dateTimePickerDateEmprunt
            // 
            this.dateTimePickerDateEmprunt.Location = new System.Drawing.Point(112, 34);
            this.dateTimePickerDateEmprunt.Name = "dateTimePickerDateEmprunt";
            this.dateTimePickerDateEmprunt.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerDateEmprunt.TabIndex = 9;
            // 
            // domainUpDownLivre
            // 
            this.domainUpDownLivre.Location = new System.Drawing.Point(112, 86);
            this.domainUpDownLivre.Name = "domainUpDownLivre";
            this.domainUpDownLivre.Size = new System.Drawing.Size(159, 20);
            this.domainUpDownLivre.TabIndex = 10;
            // 
            // domainUpDownAdherent
            // 
            this.domainUpDownAdherent.Location = new System.Drawing.Point(112, 112);
            this.domainUpDownAdherent.Name = "domainUpDownAdherent";
            this.domainUpDownAdherent.Size = new System.Drawing.Size(160, 20);
            this.domainUpDownAdherent.TabIndex = 11;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(112, 8);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(160, 20);
            this.textBoxId.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePickerDateRetour
            // 
            this.dateTimePickerDateRetour.Location = new System.Drawing.Point(112, 60);
            this.dateTimePickerDateRetour.Name = "dateTimePickerDateRetour";
            this.dateTimePickerDateRetour.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerDateRetour.TabIndex = 14;
            // 
            // FormEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 172);
            this.Controls.Add(this.dateTimePickerDateRetour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.domainUpDownAdherent);
            this.Controls.Add(this.domainUpDownLivre);
            this.Controls.Add(this.dateTimePickerDateEmprunt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEnregistrer);
            this.Name = "FormEmprunt";
            this.Text = "Emprunt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateEmprunt;
        private System.Windows.Forms.DomainUpDown domainUpDownLivre;
        private System.Windows.Forms.DomainUpDown domainUpDownAdherent;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateRetour;
    }
}