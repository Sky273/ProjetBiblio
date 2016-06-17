namespace ProjetBibliotheque
{
    partial class FormLivre
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dateTimePickerParution = new System.Windows.Forms.DateTimePicker();
            this.domainUpDownGenre = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownAuteur = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownEmplacement = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(196, 171);
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
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "titre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "date de parution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "emplacement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "auteur";
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Location = new System.Drawing.Point(112, 41);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(160, 20);
            this.textBoxTitre.TabIndex = 8;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(112, 12);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(160, 20);
            this.textBoxId.TabIndex = 10;
            // 
            // dateTimePickerParution
            // 
            this.dateTimePickerParution.Location = new System.Drawing.Point(112, 145);
            this.dateTimePickerParution.Name = "dateTimePickerParution";
            this.dateTimePickerParution.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerParution.TabIndex = 19;
            // 
            // domainUpDownGenre
            // 
            this.domainUpDownGenre.Location = new System.Drawing.Point(112, 67);
            this.domainUpDownGenre.Name = "domainUpDownGenre";
            this.domainUpDownGenre.Size = new System.Drawing.Size(160, 20);
            this.domainUpDownGenre.TabIndex = 20;
            // 
            // domainUpDownAuteur
            // 
            this.domainUpDownAuteur.Location = new System.Drawing.Point(112, 93);
            this.domainUpDownAuteur.Name = "domainUpDownAuteur";
            this.domainUpDownAuteur.Size = new System.Drawing.Size(159, 20);
            this.domainUpDownAuteur.TabIndex = 21;
            // 
            // domainUpDownEmplacement
            // 
            this.domainUpDownEmplacement.Location = new System.Drawing.Point(112, 119);
            this.domainUpDownEmplacement.Name = "domainUpDownEmplacement";
            this.domainUpDownEmplacement.Size = new System.Drawing.Size(159, 20);
            this.domainUpDownEmplacement.TabIndex = 22;
            // 
            // FormLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.domainUpDownEmplacement);
            this.Controls.Add(this.domainUpDownAuteur);
            this.Controls.Add(this.domainUpDownGenre);
            this.Controls.Add(this.dateTimePickerParution);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxTitre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEnregistrer);
            this.Name = "FormLivre";
            this.Text = "Livre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTitre;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DateTimePicker dateTimePickerParution;
        private System.Windows.Forms.DomainUpDown domainUpDownGenre;
        private System.Windows.Forms.DomainUpDown domainUpDownAuteur;
        private System.Windows.Forms.DomainUpDown domainUpDownEmplacement;
    }
}