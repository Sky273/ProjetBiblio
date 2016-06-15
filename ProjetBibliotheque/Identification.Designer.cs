namespace ProjetBibliotheque
{
    partial class Identification
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
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.labelMotdePasse = new System.Windows.Forms.Label();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.textBoxMotdePasse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Location = new System.Drawing.Point(13, 20);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.labelIdentifiant.TabIndex = 0;
            this.labelIdentifiant.Text = "Identifiant";
            this.labelIdentifiant.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMotdePasse
            // 
            this.labelMotdePasse.AutoSize = true;
            this.labelMotdePasse.Location = new System.Drawing.Point(13, 46);
            this.labelMotdePasse.Name = "labelMotdePasse";
            this.labelMotdePasse.Size = new System.Drawing.Size(71, 13);
            this.labelMotdePasse.TabIndex = 1;
            this.labelMotdePasse.Text = "Mot de passe";
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(105, 13);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdentifiant.TabIndex = 2;
            // 
            // textBoxMotdePasse
            // 
            this.textBoxMotdePasse.Location = new System.Drawing.Point(105, 39);
            this.textBoxMotdePasse.Name = "textBoxMotdePasse";
            this.textBoxMotdePasse.PasswordChar = '*';
            this.textBoxMotdePasse.Size = new System.Drawing.Size(100, 20);
            this.textBoxMotdePasse.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "S\'identifier";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Identification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 96);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMotdePasse);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.labelMotdePasse);
            this.Controls.Add(this.labelIdentifiant);
            this.Name = "Identification";
            this.Text = "Identification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelMotdePasse;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.TextBox textBoxMotdePasse;
        private System.Windows.Forms.Button button1;
    }
}