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
    public partial class FormAdherent : Form
    {
        private DataGridView dataGridViewAdherents;
        public FormAdherent()
        {
            InitializeComponent();
        }
        public FormAdherent(DataGridView dataGridViewAdherents)
        {
            InitializeComponent();
            this.dataGridViewAdherents = dataGridViewAdherents;
        }
        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {

            using (BiblioEntities context = new BiblioEntities())
            {
                // Chargement des auteurs
                try
                {
                    context.CreateAdherent(textBoxNom.Text, textBoxPrenom.Text, dateTimePickerNaissance.Value, textBoxAdresse.Text, textBoxCPostal.Text, textBoxVille.Text,textBoxPhone.Text, textBoxMail.Text, dateTimePickerInscription.Value);
                 }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Une erreur s'est produite lors de l'ajout d'un adhérent dans la base de données - {0}", ex.Message));
                }
                dataGridViewAdherents.DataSource = context.ReadAdherents().ToList();
                this.Close();
            }
        }
    }
}
