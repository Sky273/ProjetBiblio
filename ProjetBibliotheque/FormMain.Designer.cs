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
            this.tabControlGestion = new System.Windows.Forms.TabControl();
            this.tabPageAdherent = new System.Windows.Forms.TabPage();
            this.dataGridViewAdherents = new System.Windows.Forms.DataGridView();
            this.tabPageAuteur = new System.Windows.Forms.TabPage();
            this.dataGridViewAuteurs = new System.Windows.Forms.DataGridView();
            this.tabPageBibliothecaire = new System.Windows.Forms.TabPage();
            this.dataGridViewBibliothecaires = new System.Windows.Forms.DataGridView();
            this.tabPageEmplacement = new System.Windows.Forms.TabPage();
            this.dataGridViewEmplacements = new System.Windows.Forms.DataGridView();
            this.tabPageEmprunt = new System.Windows.Forms.TabPage();
            this.dataGridViewEmprunts = new System.Windows.Forms.DataGridView();
            this.tabPageGenre = new System.Windows.Forms.TabPage();
            this.dataGridViewGenres = new System.Windows.Forms.DataGridView();
            this.tabPageLivre = new System.Windows.Forms.TabPage();
            this.dataGridViewLivres = new System.Windows.Forms.DataGridView();
            this.buttonAjouterAdherent = new System.Windows.Forms.Button();
            this.tabControlGestion.SuspendLayout();
            this.tabPageAdherent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdherents)).BeginInit();
            this.tabPageAuteur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuteurs)).BeginInit();
            this.tabPageBibliothecaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBibliothecaires)).BeginInit();
            this.tabPageEmplacement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmplacements)).BeginInit();
            this.tabPageEmprunt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprunts)).BeginInit();
            this.tabPageGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenres)).BeginInit();
            this.tabPageLivre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivres)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlGestion
            // 
            this.tabControlGestion.Controls.Add(this.tabPageAdherent);
            this.tabControlGestion.Controls.Add(this.tabPageAuteur);
            this.tabControlGestion.Controls.Add(this.tabPageBibliothecaire);
            this.tabControlGestion.Controls.Add(this.tabPageEmplacement);
            this.tabControlGestion.Controls.Add(this.tabPageEmprunt);
            this.tabControlGestion.Controls.Add(this.tabPageGenre);
            this.tabControlGestion.Controls.Add(this.tabPageLivre);
            this.tabControlGestion.Location = new System.Drawing.Point(12, 12);
            this.tabControlGestion.Name = "tabControlGestion";
            this.tabControlGestion.SelectedIndex = 0;
            this.tabControlGestion.Size = new System.Drawing.Size(770, 392);
            this.tabControlGestion.TabIndex = 0;
            // 
            // tabPageAdherent
            // 
            this.tabPageAdherent.Controls.Add(this.buttonAjouterAdherent);
            this.tabPageAdherent.Controls.Add(this.dataGridViewAdherents);
            this.tabPageAdherent.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdherent.Name = "tabPageAdherent";
            this.tabPageAdherent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdherent.Size = new System.Drawing.Size(762, 366);
            this.tabPageAdherent.TabIndex = 0;
            this.tabPageAdherent.Text = "Adherents";
            this.tabPageAdherent.UseVisualStyleBackColor = true;
            this.tabPageAdherent.Click += new System.EventHandler(this.tabPageAdherent_Click);
            // 
            // dataGridViewAdherents
            // 
            this.dataGridViewAdherents.AllowUserToAddRows = false;
            this.dataGridViewAdherents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdherents.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewAdherents.Name = "dataGridViewAdherents";
            this.dataGridViewAdherents.Size = new System.Drawing.Size(750, 325);
            this.dataGridViewAdherents.TabIndex = 0;
            // 
            // tabPageAuteur
            // 
            this.tabPageAuteur.Controls.Add(this.dataGridViewAuteurs);
            this.tabPageAuteur.Location = new System.Drawing.Point(4, 22);
            this.tabPageAuteur.Name = "tabPageAuteur";
            this.tabPageAuteur.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuteur.Size = new System.Drawing.Size(762, 366);
            this.tabPageAuteur.TabIndex = 1;
            this.tabPageAuteur.Text = "Auteurs";
            this.tabPageAuteur.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAuteurs
            // 
            this.dataGridViewAuteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuteurs.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewAuteurs.Name = "dataGridViewAuteurs";
            this.dataGridViewAuteurs.Size = new System.Drawing.Size(750, 313);
            this.dataGridViewAuteurs.TabIndex = 0;
            // 
            // tabPageBibliothecaire
            // 
            this.tabPageBibliothecaire.Controls.Add(this.dataGridViewBibliothecaires);
            this.tabPageBibliothecaire.Location = new System.Drawing.Point(4, 22);
            this.tabPageBibliothecaire.Name = "tabPageBibliothecaire";
            this.tabPageBibliothecaire.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBibliothecaire.Size = new System.Drawing.Size(762, 366);
            this.tabPageBibliothecaire.TabIndex = 2;
            this.tabPageBibliothecaire.Text = "Bibliothecaires";
            this.tabPageBibliothecaire.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBibliothecaires
            // 
            this.dataGridViewBibliothecaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBibliothecaires.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewBibliothecaires.Name = "dataGridViewBibliothecaires";
            this.dataGridViewBibliothecaires.Size = new System.Drawing.Size(750, 313);
            this.dataGridViewBibliothecaires.TabIndex = 1;
            // 
            // tabPageEmplacement
            // 
            this.tabPageEmplacement.Controls.Add(this.dataGridViewEmplacements);
            this.tabPageEmplacement.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmplacement.Name = "tabPageEmplacement";
            this.tabPageEmplacement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmplacement.Size = new System.Drawing.Size(762, 366);
            this.tabPageEmplacement.TabIndex = 3;
            this.tabPageEmplacement.Text = "Emplacements";
            this.tabPageEmplacement.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmplacements
            // 
            this.dataGridViewEmplacements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmplacements.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewEmplacements.Name = "dataGridViewEmplacements";
            this.dataGridViewEmplacements.Size = new System.Drawing.Size(750, 313);
            this.dataGridViewEmplacements.TabIndex = 1;
            // 
            // tabPageEmprunt
            // 
            this.tabPageEmprunt.Controls.Add(this.dataGridViewEmprunts);
            this.tabPageEmprunt.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmprunt.Name = "tabPageEmprunt";
            this.tabPageEmprunt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmprunt.Size = new System.Drawing.Size(762, 366);
            this.tabPageEmprunt.TabIndex = 4;
            this.tabPageEmprunt.Text = "Emprunts";
            this.tabPageEmprunt.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmprunts
            // 
            this.dataGridViewEmprunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmprunts.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewEmprunts.Name = "dataGridViewEmprunts";
            this.dataGridViewEmprunts.Size = new System.Drawing.Size(749, 332);
            this.dataGridViewEmprunts.TabIndex = 0;
            // 
            // tabPageGenre
            // 
            this.tabPageGenre.Controls.Add(this.dataGridViewGenres);
            this.tabPageGenre.Location = new System.Drawing.Point(4, 22);
            this.tabPageGenre.Name = "tabPageGenre";
            this.tabPageGenre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGenre.Size = new System.Drawing.Size(762, 366);
            this.tabPageGenre.TabIndex = 5;
            this.tabPageGenre.Text = "Genres";
            this.tabPageGenre.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGenres
            // 
            this.dataGridViewGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenres.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewGenres.Name = "dataGridViewGenres";
            this.dataGridViewGenres.Size = new System.Drawing.Size(750, 313);
            this.dataGridViewGenres.TabIndex = 1;
            // 
            // tabPageLivre
            // 
            this.tabPageLivre.Controls.Add(this.dataGridViewLivres);
            this.tabPageLivre.Location = new System.Drawing.Point(4, 22);
            this.tabPageLivre.Name = "tabPageLivre";
            this.tabPageLivre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLivre.Size = new System.Drawing.Size(762, 366);
            this.tabPageLivre.TabIndex = 6;
            this.tabPageLivre.Text = "Livres";
            this.tabPageLivre.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLivres
            // 
            this.dataGridViewLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivres.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewLivres.Name = "dataGridViewLivres";
            this.dataGridViewLivres.Size = new System.Drawing.Size(750, 313);
            this.dataGridViewLivres.TabIndex = 1;
            // 
            // buttonAjouterAdherent
            // 
            this.buttonAjouterAdherent.Location = new System.Drawing.Point(548, 338);
            this.buttonAjouterAdherent.Name = "buttonAjouterAdherent";
            this.buttonAjouterAdherent.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouterAdherent.TabIndex = 1;
            this.buttonAjouterAdherent.Text = "Ajouter";
            this.buttonAjouterAdherent.UseVisualStyleBackColor = true;
            this.buttonAjouterAdherent.Click += new System.EventHandler(this.buttonAjouterAdherent_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 416);
            this.Controls.Add(this.tabControlGestion);
            this.Name = "FormMain";
            this.Text = "Gestion de bibliothèque";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlGestion.ResumeLayout(false);
            this.tabPageAdherent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdherents)).EndInit();
            this.tabPageAuteur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuteurs)).EndInit();
            this.tabPageBibliothecaire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBibliothecaires)).EndInit();
            this.tabPageEmplacement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmplacements)).EndInit();
            this.tabPageEmprunt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprunts)).EndInit();
            this.tabPageGenre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenres)).EndInit();
            this.tabPageLivre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlGestion;
        private System.Windows.Forms.TabPage tabPageAdherent;
        private System.Windows.Forms.DataGridView dataGridViewAdherents;
        private System.Windows.Forms.TabPage tabPageAuteur;
        private System.Windows.Forms.TabPage tabPageBibliothecaire;
        private System.Windows.Forms.TabPage tabPageEmplacement;
        private System.Windows.Forms.TabPage tabPageEmprunt;
        private System.Windows.Forms.TabPage tabPageGenre;
        private System.Windows.Forms.TabPage tabPageLivre;
        private System.Windows.Forms.DataGridView dataGridViewEmprunts;
        private System.Windows.Forms.DataGridView dataGridViewAuteurs;
        private System.Windows.Forms.DataGridView dataGridViewBibliothecaires;
        private System.Windows.Forms.DataGridView dataGridViewEmplacements;
        private System.Windows.Forms.DataGridView dataGridViewGenres;
        private System.Windows.Forms.DataGridView dataGridViewLivres;
        private System.Windows.Forms.Button buttonAjouterAdherent;
    }
}