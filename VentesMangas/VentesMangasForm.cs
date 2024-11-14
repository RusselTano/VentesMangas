/*
    Programmeur:    Dylane Tano
    Date:           Novembre 2020
  
    Assembly:       VentesMangas.exe
    Solution:       VentesMangas.sln
    Projet:         VentesMangas.csproj

    Namespace:      {VentesMangas}

    Classe:         VentesMangasForm.cs
  
    But:           Gestion des clients, des ventes et des achats de mangas.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TypesNS;
using TransactionNS;
using g = VentesMangas.VentesMangasGeneraleClass;
using ce = VentesMangas.VentesMangasGeneraleClass.Erreurs;
using System.Drawing;
using static TypesNS.Type;

namespace VentesMangas
{
    /// <summary>
    /// Saisie d'une transaction de vente de mangas
    /// </summary>
    /// <remarks>Tous droits réservés: Dylane Tano Inc. 2025</remarks>
    public partial class VentesMangasForm : Form
    {
        #region Déclaration
        private Transaction oTrans;
        private TypesNS.Type oTypes;
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
                oTrans = new Transaction();
                oTypes = new TypesNS.Type();
                g.InitMessagesErreurs();
                venteMangaAboutBox venteMangeaAbout = new venteMangaAboutBox();


                titreComboBox.Items.AddRange(oTrans.GetTitres());
                titreComboBox.SelectedIndex = 0;
                genreComboBox.Items.AddRange(oTrans.GetGenres());
                genreComboBox.SelectedIndex = 0;

                typesComboBox.Items.AddRange(oTypes.GetTypesModeles(CodesTypes.Types));
                modelesComboBox.Items.AddRange(oTypes.GetTypesModeles(CodesTypes.Modeles));
                typesComboBox.SelectedIndex = 0;
                modelesComboBox.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException )
            {
                MessageBox.Show(g.tMessagesErreursStr[(int)ce.ECEPrixIntrouvable], "Prix", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                 oTrans = new Transaction();
               

                
                if (titreComboBox.SelectedIndex != -1 && genreComboBox.SelectedIndex != -1)
                   // prixLabel.Text = oTrans.GetPrix(titreComboBox.SelectedIndex, genreComboBox.SelectedIndex).ToString("c2");
                prixLabel.Text = oTrans.GetPrix(titreComboBox.SelectedItem.ToString(), genreComboBox.SelectedItem.ToString()).ToString("c2");

            }
            catch (ArgumentOutOfRangeException )
            {
               
               MessageBox.Show(g.tMessagesErreursStr[(int)ce.ECEPrixIntrouvable], "Prix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(ArgumentException)
            {
                MessageBox.Show(g.tMessagesErreursStr[(int)ce.CEErreurArgumentException], "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {
                MessageBox.Show(g.tMessagesErreursStr[(int)ce.CEErreurIndeterminee], "Prix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region boite de dialogue
        private void aproposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            venteMangaAboutBox venteMangeaAbout = new venteMangaAboutBox();
            if (venteMangeaAbout != null)
            {
               venteMangeaAbout.ShowDialog(this);
            }
        }
        #endregion


    }
}
 