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
            this.dataGridViewAdherent = new System.Windows.Forms.DataGridView();
            this.tabPageAuteur = new System.Windows.Forms.TabPage();
            this.tabPageBibliothecaire = new System.Windows.Forms.TabPage();
            this.tabPageEmplacement = new System.Windows.Forms.TabPage();
            this.tabPageEmprunt = new System.Windows.Forms.TabPage();
            this.tabPageGenre = new System.Windows.Forms.TabPage();
            this.tabPageLivre = new System.Windows.Forms.TabPage();
            this.tabControlGestion.SuspendLayout();
            this.tabPageAdherent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdherent)).BeginInit();
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
            this.tabPageAdherent.Controls.Add(this.dataGridViewAdherent);
            this.tabPageAdherent.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdherent.Name = "tabPageAdherent";
            this.tabPageAdherent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdherent.Size = new System.Drawing.Size(762, 366);
            this.tabPageAdherent.TabIndex = 0;
            this.tabPageAdherent.Text = "Adherents";
            this.tabPageAdherent.UseVisualStyleBackColor = true;
            this.tabPageAdherent.Click += new System.EventHandler(this.tabPageAdherent_Click);
            // 
            // dataGridViewAdherent
            // 
            this.dataGridViewAdherent.AllowUserToAddRows = false;
            this.dataGridViewAdherent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdherent.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewAdherent.Name = "dataGridViewAdherent";
            this.dataGridViewAdherent.Size = new System.Drawing.Size(750, 325);
            this.dataGridViewAdherent.TabIndex = 0;
            // 
            // tabPageAuteur
            // 
            this.tabPageAuteur.Location = new System.Drawing.Point(4, 22);
            this.tabPageAuteur.Name = "tabPageAuteur";
            this.tabPageAuteur.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuteur.Size = new System.Drawing.Size(762, 366);
            this.tabPageAuteur.TabIndex = 1;
            this.tabPageAuteur.Text = "Auteurs";
            this.tabPageAuteur.UseVisualStyleBackColor = true;
            // 
            // tabPageBibliothecaire
            // 
            this.tabPageBibliothecaire.Location = new System.Drawing.Point(4, 22);
            this.tabPageBibliothecaire.Name = "tabPageBibliothecaire";
            this.tabPageBibliothecaire.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBibliothecaire.Size = new System.Drawing.Size(762, 366);
            this.tabPageBibliothecaire.TabIndex = 2;
            this.tabPageBibliothecaire.Text = "Bibliothecaires";
            this.tabPageBibliothecaire.UseVisualStyleBackColor = true;
            // 
            // tabPageEmplacement
            // 
            this.tabPageEmplacement.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmplacement.Name = "tabPageEmplacement";
            this.tabPageEmplacement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmplacement.Size = new System.Drawing.Size(762, 366);
            this.tabPageEmplacement.TabIndex = 3;
            this.tabPageEmplacement.Text = "Emplacements";
            this.tabPageEmplacement.UseVisualStyleBackColor = true;
            // 
            // tabPageEmprunt
            // 
            this.tabPageEmprunt.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmprunt.Name = "tabPageEmprunt";
            this.tabPageEmprunt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmprunt.Size = new System.Drawing.Size(762, 366);
            this.tabPageEmprunt.TabIndex = 4;
            this.tabPageEmprunt.Text = "Emprunts";
            this.tabPageEmprunt.UseVisualStyleBackColor = true;
            // 
            // tabPageGenre
            // 
            this.tabPageGenre.Location = new System.Drawing.Point(4, 22);
            this.tabPageGenre.Name = "tabPageGenre";
            this.tabPageGenre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGenre.Size = new System.Drawing.Size(762, 366);
            this.tabPageGenre.TabIndex = 5;
            this.tabPageGenre.Text = "Genres";
            this.tabPageGenre.UseVisualStyleBackColor = true;
            // 
            // tabPageLivre
            // 
            this.tabPageLivre.Location = new System.Drawing.Point(4, 22);
            this.tabPageLivre.Name = "tabPageLivre";
            this.tabPageLivre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLivre.Size = new System.Drawing.Size(762, 366);
            this.tabPageLivre.TabIndex = 6;
            this.tabPageLivre.Text = "Livres";
            this.tabPageLivre.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdherent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlGestion;
        private System.Windows.Forms.TabPage tabPageAdherent;
        private System.Windows.Forms.DataGridView dataGridViewAdherent;
        private System.Windows.Forms.TabPage tabPageAuteur;
        private System.Windows.Forms.TabPage tabPageBibliothecaire;
        private System.Windows.Forms.TabPage tabPageEmplacement;
        private System.Windows.Forms.TabPage tabPageEmprunt;
        private System.Windows.Forms.TabPage tabPageGenre;
        private System.Windows.Forms.TabPage tabPageLivre;
    }
}