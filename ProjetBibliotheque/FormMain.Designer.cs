namespace ProjetBibliotheque
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
            this.tabBiblio = new System.Windows.Forms.TabControl();
            this.tabPageAdherent = new System.Windows.Forms.TabPage();
            this.dataGridViewAdherent = new System.Windows.Forms.DataGridView();
            this.tabPageAuteur = new System.Windows.Forms.TabPage();
            this.tabPageBibliothecaire = new System.Windows.Forms.TabPage();
            this.tabPageEmplacement = new System.Windows.Forms.TabPage();
            this.tabPageEmprunt = new System.Windows.Forms.TabPage();
            this.tabPageGenre = new System.Windows.Forms.TabPage();
            this.tabPageLivre = new System.Windows.Forms.TabPage();
            this.tabBiblio.SuspendLayout();
            this.tabPageAdherent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdherent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBiblio
            // 
            this.tabBiblio.Controls.Add(this.tabPageAdherent);
            this.tabBiblio.Controls.Add(this.tabPageAuteur);
            this.tabBiblio.Controls.Add(this.tabPageBibliothecaire);
            this.tabBiblio.Controls.Add(this.tabPageEmplacement);
            this.tabBiblio.Controls.Add(this.tabPageEmprunt);
            this.tabBiblio.Controls.Add(this.tabPageGenre);
            this.tabBiblio.Controls.Add(this.tabPageLivre);
            this.tabBiblio.Location = new System.Drawing.Point(13, 13);
            this.tabBiblio.Name = "tabBiblio";
            this.tabBiblio.SelectedIndex = 0;
            this.tabBiblio.Size = new System.Drawing.Size(843, 400);
            this.tabBiblio.TabIndex = 0;
            // 
            // tabPageAdherent
            // 
            this.tabPageAdherent.Controls.Add(this.dataGridViewAdherent);
            this.tabPageAdherent.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdherent.Name = "tabPageAdherent";
            this.tabPageAdherent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdherent.Size = new System.Drawing.Size(835, 374);
            this.tabPageAdherent.TabIndex = 0;
            this.tabPageAdherent.Text = "Adherent";
            this.tabPageAdherent.UseVisualStyleBackColor = true;
            this.tabPageAdherent.Click += new System.EventHandler(this.tabPageAdherent_Click);
            // 
            // dataGridViewAdherent
            // 
            this.dataGridViewAdherent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdherent.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewAdherent.Name = "dataGridViewAdherent";
            this.dataGridViewAdherent.Size = new System.Drawing.Size(823, 339);
            this.dataGridViewAdherent.TabIndex = 0;
            // 
            // tabPageAuteur
            // 
            this.tabPageAuteur.Location = new System.Drawing.Point(4, 22);
            this.tabPageAuteur.Name = "tabPageAuteur";
            this.tabPageAuteur.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuteur.Size = new System.Drawing.Size(835, 374);
            this.tabPageAuteur.TabIndex = 1;
            this.tabPageAuteur.Text = "Auteur";
            this.tabPageAuteur.UseVisualStyleBackColor = true;
            // 
            // tabPageBibliothecaire
            // 
            this.tabPageBibliothecaire.Location = new System.Drawing.Point(4, 22);
            this.tabPageBibliothecaire.Name = "tabPageBibliothecaire";
            this.tabPageBibliothecaire.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBibliothecaire.Size = new System.Drawing.Size(835, 374);
            this.tabPageBibliothecaire.TabIndex = 2;
            this.tabPageBibliothecaire.Text = "Bibliothecaire";
            this.tabPageBibliothecaire.UseVisualStyleBackColor = true;
            // 
            // tabPageEmplacement
            // 
            this.tabPageEmplacement.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmplacement.Name = "tabPageEmplacement";
            this.tabPageEmplacement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmplacement.Size = new System.Drawing.Size(835, 374);
            this.tabPageEmplacement.TabIndex = 3;
            this.tabPageEmplacement.Text = "Emplacement";
            this.tabPageEmplacement.UseVisualStyleBackColor = true;
            // 
            // tabPageEmprunt
            // 
            this.tabPageEmprunt.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmprunt.Name = "tabPageEmprunt";
            this.tabPageEmprunt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmprunt.Size = new System.Drawing.Size(835, 374);
            this.tabPageEmprunt.TabIndex = 4;
            this.tabPageEmprunt.Text = "Emprunt";
            this.tabPageEmprunt.UseVisualStyleBackColor = true;
            // 
            // tabPageGenre
            // 
            this.tabPageGenre.Location = new System.Drawing.Point(4, 22);
            this.tabPageGenre.Name = "tabPageGenre";
            this.tabPageGenre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGenre.Size = new System.Drawing.Size(835, 374);
            this.tabPageGenre.TabIndex = 5;
            this.tabPageGenre.Text = "Genre";
            this.tabPageGenre.UseVisualStyleBackColor = true;
            // 
            // tabPageLivre
            // 
            this.tabPageLivre.Location = new System.Drawing.Point(4, 22);
            this.tabPageLivre.Name = "tabPageLivre";
            this.tabPageLivre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLivre.Size = new System.Drawing.Size(835, 374);
            this.tabPageLivre.TabIndex = 6;
            this.tabPageLivre.Text = "Livre";
            this.tabPageLivre.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 425);
            this.Controls.Add(this.tabBiblio);
            this.Name = "FormMain";
            this.Text = "Gestion de bibliothèque";
            this.tabBiblio.ResumeLayout(false);
            this.tabPageAdherent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdherent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBiblio;
        private System.Windows.Forms.TabPage tabPageAdherent;
        private System.Windows.Forms.TabPage tabPageAuteur;
        private System.Windows.Forms.TabPage tabPageBibliothecaire;
        private System.Windows.Forms.TabPage tabPageEmplacement;
        private System.Windows.Forms.TabPage tabPageEmprunt;
        private System.Windows.Forms.TabPage tabPageGenre;
        private System.Windows.Forms.TabPage tabPageLivre;
        private System.Windows.Forms.DataGridView dataGridViewAdherent;
    }
}