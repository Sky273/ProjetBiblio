using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetBibliotheque
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void tabPageAdherent_Click(object sender, EventArgs e)
        {
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void buttonAjouterAdherent_Click(object sender, EventArgs e)
        {
            FormAdherent formAdherent = new FormAdherent();
            formAdherent.ShowDialog();
        }

        private void tabPageAuteur_Enter(object sender, EventArgs e)
        {
            if (dataGridViewAuteurs.DataSource == null)
            {
                using (BiblioEntities context = new BiblioEntities())
                {
                    // Chargement des auteurs
                    dataGridViewAuteurs.DataSource = context.ReadAuteurs().ToList();
                    dataGridViewAuteurs.Columns[0].HeaderText = "Id";
                    dataGridViewAuteurs.Columns[1].HeaderText = "Nom";
                    dataGridViewAuteurs.Columns[2].HeaderText = "Prénom";
                }
            }
        }

        private void tabPageBibliothecaire_Enter(object sender, EventArgs e)
        {
            if (dataGridViewBibliothecaires.DataSource == null)
            {
                using (BiblioEntities context = new BiblioEntities())
                {
                    dataGridViewBibliothecaires.DataSource = context.ReadBibliothecaires().ToList();
                    dataGridViewBibliothecaires.Columns[0].HeaderText = "Id";
                    dataGridViewBibliothecaires.Columns[1].HeaderText = "Nom";
                    dataGridViewBibliothecaires.Columns[2].HeaderText = "Prénom";
                }
            }
        }

        private void tabPageEmplacement_Enter(object sender, EventArgs e)
        {
            if (dataGridViewEmplacements.DataSource == null)
            {
                using (BiblioEntities context = new BiblioEntities())
                {
                    dataGridViewEmplacements.DataSource = context.ReadEmplacements().ToList();
                    dataGridViewEmplacements.Columns[0].HeaderText = "Id";
                    dataGridViewEmplacements.Columns[1].HeaderText = "Libellé";
                }
            }
        }

        private void tabPageEmprunt_Enter(object sender, EventArgs e)
        {
            if (dataGridViewEmprunts.DataSource == null)
            {
                using (BiblioEntities context = new BiblioEntities())
                {
                    dataGridViewEmprunts.DataSource = context.ReadEmprunts().ToList();
                    dataGridViewEmprunts.Columns[0].HeaderText = "Nom";
                    dataGridViewEmprunts.Columns[1].HeaderText = "Prénom";
                    dataGridViewEmprunts.Columns[2].HeaderText = "Titre";
                    dataGridViewEmprunts.Columns[3].HeaderText = "Date d'emprunt";
                    dataGridViewEmprunts.Columns[4].HeaderText = "Date de retour";
                }
            }
        }

        private void tabPageGenre_Enter(object sender, EventArgs e)
        {
            if (dataGridViewGenres.DataSource == null)
            {
                using (BiblioEntities context = new BiblioEntities())
                {
                    dataGridViewGenres.DataSource = context.ReadGenres().ToList();
                    dataGridViewGenres.Columns[0].HeaderText = "Id";
                    dataGridViewGenres.Columns[1].HeaderText = "Libellé";
                }
            }
        }

        private void tabPageLivre_Enter(object sender, EventArgs e)
        {
            if (dataGridViewLivres.DataSource == null)
            {
                using (BiblioEntities context = new BiblioEntities())
                {
                    dataGridViewLivres.DataSource = context.ReadLivres().ToList();
                    dataGridViewLivres.Columns[0].HeaderText = "Id";
                    dataGridViewLivres.Columns[1].HeaderText = "Titre";
                    dataGridViewLivres.Columns[2].HeaderText = "Date de parution";
                    dataGridViewLivres.Columns[3].HeaderText = "Genre";
                    dataGridViewLivres.Columns[4].HeaderText = "Nom auteur";
                    dataGridViewLivres.Columns[5].HeaderText = "Prénom auteur";
                    dataGridViewLivres.Columns[6].HeaderText = "Emplacement";
                }
            }
        }

        private void tabPageAdherent_Enter(object sender, EventArgs e)
        {
            if (dataGridViewAdherents.DataSource == null)
            {
                using (BiblioEntities context = new BiblioEntities())
                {
                    dataGridViewAdherents.DataSource = context.ReadAdherents().ToList();
                    dataGridViewAdherents.Columns[0].HeaderText = "Id";
                    dataGridViewAdherents.Columns[1].HeaderText = "Nom";
                    dataGridViewAdherents.Columns[2].HeaderText = "Prénom";
                    dataGridViewAdherents.Columns[3].HeaderText = "Date de naissance";
                    dataGridViewAdherents.Columns[4].HeaderText = "Adresse";
                    dataGridViewAdherents.Columns[5].HeaderText = "Code postal";
                    dataGridViewAdherents.Columns[6].HeaderText = "Téléphone";
                    dataGridViewAdherents.Columns[7].HeaderText = "Email";
                    dataGridViewAdherents.Columns[8].HeaderText = "Date d'inscription";

                }
            }
        }
    }
}
