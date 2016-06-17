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
            using (BiblioEntities context = new BiblioEntities())
            {
                dataGridViewAdherent.DataSource = context.ReadAdherents().ToList();
                dataGridViewAdherent.Columns[0].HeaderText = "Id";
                dataGridViewAdherent.Columns[1].HeaderText = "Nom";
                dataGridViewAdherent.Columns[2].HeaderText = "Prenom";
                dataGridViewAdherent.Columns[3].HeaderText = "Date de naissance";
                dataGridViewAdherent.Columns[4].HeaderText = "Adresse";
                dataGridViewAdherent.Columns[5].HeaderText = "Code postal";
                dataGridViewAdherent.Columns[6].HeaderText = "Telephone";
                dataGridViewAdherent.Columns[7].HeaderText = "Email";
                dataGridViewAdherent.Columns[8].HeaderText = "Date d'inscription";
            }
        }
    }
}
