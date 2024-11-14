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
        private string[] tTitresMangas;
        private string[] tGenres;
        private decimal[] tPrix;
        Transaction oTrans = new Transaction();

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

                initValue();

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
                    prixLabel.Text = oTrans.GetPrix(titreComboBox.SelectedIndex, genreComboBox.SelectedIndex).ToString("c2");
                else
                    MessageBox.Show(g.tMessagesErreursStr[(int)ce.ECEErreurPrix], "Prix", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void MaskedTextBox_Enter(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            textBox?.SelectAll();
        }

        private void enregistrerButton_Click(object sender, EventArgs e)
        {
            Enregistrer_Click();
        }

        #region 1 . Transmettre les données par le constructeur
        /// <summary>
        /// Gère l'événement de clic du bouton Enregistrer.
        /// Transmet les données du projet principal au projet Transaction en utilisant le constructeur.
        /// </summary>
        //public void Enregistrer_Click()
        //{
        //    Transaction oTrans = new Transaction(
        //        1,
        //        nomMaskedTextBox.Text,
        //        prenomMaskedTextBox.Text,
        //        adresseMaskedTextBox.Text,
        //        codePostalMaskedTextBox.Text,
        //        telephoneMaskedTextBox.Text,
        //        typesComboBox.SelectedItem?.ToString(),
        //        modelesComboBox.SelectedItem?.ToString(),
        //        DateTime.Parse(dateLivraisonDateTimePicker.Text),
        //        titreComboBox.SelectedItem?.ToString(),
        //        genreComboBox.SelectedItem?.ToString(),
        //        Decimal.Parse(prixLabel.Text.Replace("$", "").Trim())
        //    );

        //    oTrans.Enregistrer();
        //}
        #endregion

        #region 2 . Transmettre les données par les propriétés
        /// <summary>
        /// Gère l'événement de clic du bouton Enregistrer.
        /// Transmet les données du projet principal au projet Transaction en utilisant les propriétés.
        /// </summary>
        //public void Enregistrer_Click()
        //{
        //    Transaction oTrans = new Transaction();
        //    oTrans.NomStr = nomMaskedTextBox.Text;
        //    oTrans.PrenomStr = prenomMaskedTextBox.Text;
        //    oTrans.AdresseStr = adresseMaskedTextBox.Text;
        //    oTrans.CodePostalStr = codePostalMaskedTextBox.Text;
        //    oTrans.TelephoneStr = telephoneMaskedTextBox.Text;
        //    oTrans.TypeMangaStr = typesComboBox.SelectedItem?.ToString();
        //    oTrans.ModeleMangaStr = modelesComboBox.SelectedItem?.ToString();
        //    oTrans.DateLivraisonDateTime = DateTime.Parse(dateLivraisonDateTimePicker.Text);
        //    oTrans.TitreStr = titreComboBox.SelectedItem?.ToString();
        //    oTrans.GenresStr = genreComboBox.SelectedItem?.ToString();
        //    oTrans.PrixDecimal = Decimal.Parse(prixLabel.Text.Replace("$", "").Trim());

        //    oTrans.Enregistrer();
        //}
        #endregion

        #region 3 . Transmettre les données via Enregistrer avec paramètres
        /// <summary>
        /// Gerer l'événement de clic du bouton Enregistrer.
        /// Transmet les données du projet principal au projet Transaction en utilisant la méthode Enregistrer avec paramètres.
        /// </summary>
        public void Enregistrer_Click()
        {
            // Transmettre les données via Enregistrer avec paramètres
            Transaction oTrans = new Transaction();
            oTrans.Enregistrer(
                1,
                nomMaskedTextBox.Text,
                prenomMaskedTextBox.Text,
                adresseMaskedTextBox.Text,
                codePostalMaskedTextBox.Text,
                telephoneMaskedTextBox.Text,
                typesComboBox.SelectedItem?.ToString(),
                modelesComboBox.SelectedItem?.ToString(),
                DateTime.Parse(dateLivraisonDateTimePicker.Text),
                titreComboBox.SelectedItem?.ToString(),
                genreComboBox.SelectedItem?.ToString(),
                Decimal.Parse(prixLabel.Text.Replace("$", "").Trim())
            );
        }
        #endregion


        private void initValue()
        {
            titreComboBox.SelectedIndexChanged -= TransactionComboBox_SelectedIndexChanged;
            genreComboBox.SelectedIndexChanged -= TransactionComboBox_SelectedIndexChanged;

            titreComboBox.Items.AddRange(oTrans.GetTitres());
            titreComboBox.SelectedIndex = 0;
            genreComboBox.Items.AddRange(oTrans.GetGenres());
            genreComboBox.SelectedIndex = 0;

            titreComboBox.SelectedIndexChanged += TransactionComboBox_SelectedIndexChanged;
            genreComboBox.SelectedIndexChanged += TransactionComboBox_SelectedIndexChanged;

            nomMaskedTextBox.Text = "Tano";
            prenomMaskedTextBox.Text = "Dylane";
            adresseMaskedTextBox.Text = "555 Duke street";
            codePostalMaskedTextBox.Text = "H3H 2K9";
            telephoneMaskedTextBox.Text = "514-555-5555";
            //typesComboBox.SelectedIndex = 0;
            //modelesComboBox.SelectedIndex = 0;
            dateLivraisonDateTimePicker.Value = DateTime.Now;
            prixLabel.Text = oTrans.GetPrix(titreComboBox.SelectedIndex, genreComboBox.SelectedIndex).ToString("c2");

        }

    }
}
}