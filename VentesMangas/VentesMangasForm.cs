using System;
using System.Collections.Generic;
using System.ComponentModel;
/*
    Programmeur:    Dylane Tano
    Date:           Novembre 2020
  
    Assembly:       VentesMangas.exe
    Solution:       VentesMangas.sln
    Projet:         VentesMangas.csproj

    Namespace:      {VentesMangas}

    Classe:         VentesMangasClassGenerale.cs
  
    But:           Gestion des clients, des ventes et des achats de mangas.
*/

using System.Windows.Forms;

using TransactionNS;
using g = VentesMangas.VentesMangasGeneraleClass;
using ce = VentesMangas.VentesMangasGeneraleClass.Erreurs;

namespace VentesMangas
{
    /// <summary>
    /// Formulaire de gestion des ventes de mangas.
    /// </summary>
    public partial class VentesMangasForm : Form
    {
        #region Déclaration
        private string[] tTitresMangas;
        private string[] tGenres;
        private decimal[] tPrix;
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur
        /// </summary>
        public VentesMangasForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Initialisation
        /// <summary>
        /// peuple les combobox et initialise les messages d'erreurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VentesMangasForm_Load(object sender, EventArgs e)
        {
            try
            {
                Transaction oTrans = new Transaction();

                g.InitMessagesErreurs();

                titreComboBox.SelectedIndexChanged -= TransactionComboBox_SelectedIndexChanged;
                genreComboBox.SelectedIndexChanged -= TransactionComboBox_SelectedIndexChanged;

                titreComboBox.Items.AddRange(oTrans.GetTitres());
                titreComboBox.SelectedIndex = 0;
                genreComboBox.Items.AddRange(oTrans.GetGenres());
                genreComboBox.SelectedIndex = 0;

                titreComboBox.SelectedIndexChanged += TransactionComboBox_SelectedIndexChanged;
                genreComboBox.SelectedIndexChanged += TransactionComboBox_SelectedIndexChanged;

                prixLabel.Text = oTrans.GetPrix(titreComboBox.SelectedIndex, genreComboBox.SelectedIndex).ToString("c2");
            }
            catch (Exception)
            {
                MessageBox.Show(g.tMessagesErreursStr[(int)ce.CEErreurIndeterminee], "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Quitter
        private void quitterButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Selection d'un titre et d'un genre
        private void TransactionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Transaction oTrans = new Transaction();
                if (titreComboBox.SelectedIndex != -1 && genreComboBox.SelectedIndex != -1)
                    prixLabel.Text = oTrans.GetPrix(titreComboBox.SelectedIndex, genreComboBox.SelectedIndex).ToString("c2");
                else
                    MessageBox.Show(g.tMessagesErreursStr[(int)ce.ECEPrixIntrouvable], "Prix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(g.tMessagesErreursStr[(int)ce.ECEPrixIntrouvable], "Prix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(g.tMessagesErreursStr[(int)ce.CEErreurIndeterminee], "Prix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
 