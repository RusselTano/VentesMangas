/*
    Programmeurs:   Andreas, Cdric, Dylane, Manuela
    Date:           Novembre 2024
  
    Assembly:       VentesMangas.exe
    Solution:       VentesMangas.sln
    Projet:         VentesMangas.csproj

    Namespace:      {VentesMangas}

    Classe:         VentesMangasForm.cs
  
    But:           Gestion des clients, des ventes et des achats de mangas.
*/
using System;
using System.Windows.Forms;
using TransactionNS;
using g = VentesMangas.VentesMangasGeneraleClass;
using ce = VentesMangas.VentesMangasGeneraleClass.Erreurs;
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
        private Transaction oTrans = new Transaction();
        private TypesNS.Type oTypes = new TypesNS.Type();
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
                g.InitMessagesErreurs();
                venteMangaAboutBox venteMangeaAbout = new venteMangaAboutBox();
                InitValue();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(g.tMessagesErreursStr[(int)ce.ECEErreurPrix], "Prix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(g.tMessagesErreursStr[(int)ce.CEErreurIndeterminee], "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Selection d'un titre et d'un genre
        private void TransactionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (titreComboBox.SelectedIndex != -1 && genreComboBox.SelectedIndex != -1)
                    prixLabel.Text = oTrans.GetPrix(titreComboBox.SelectedIndex, genreComboBox.SelectedIndex).ToString("c2");
                else
                    MessageBox.Show(g.tMessagesErreursStr[(int)ce.ECEErreurPrix], "Prix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(g.tMessagesErreursStr[(int)ce.ECEErreurPrix], "Prix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show(g.tMessagesErreursStr[(int)ce.CEErreurArgumentException], "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show(g.tMessagesErreursStr[(int)ce.CEErreurIndeterminee], "Prix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Boite de dialogue
        private void aproposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            venteMangaAboutBox venteMangeaAbout = new venteMangaAboutBox();
            venteMangeaAbout?.ShowDialog(this);
        }
        #endregion

        #region SelectAll
        private void MaskedTextBox_Enter(object sender, EventArgs e)
        {
            (sender as MaskedTextBox)?.SelectAll();
        }
        #endregion

        #region Enregistrer
        private void enregistrerButton_Click(object sender, EventArgs e)
        {

            Enregistrer_Click();
        }
        #endregion

        #region Transmettre les données par le constructeur
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
        //        typesComboBox.SelectedItem.ToString(),
        //        modelesComboBox.SelectedItem.ToString(),
        //        DateTime.Parse(dateLivraisonDateTimePicker.Value.ToString()),
        //        titreComboBox.SelectedItem.ToString(),
        //        genreComboBox.SelectedItem.ToString(),
        //        Decimal.Parse(prixLabel.Text.Replace("$", "").Trim())
        //    );

        //    oTrans.Enregistrer();
        //}
        #endregion

        #region Transmettre les données par les propriétés
        /// <summary>
        /// Gère l'événement de clic du bouton Enregistrer.
        /// Transmet les données du projet principal au projet Transaction en utilisant les propriétés.
        /// </summary>
        public void Enregistrer_Click()
        {
            try
            {
                oTrans.NomStr = nomMaskedTextBox.Text;
                oTrans.PrenomStr = prenomMaskedTextBox.Text;
                oTrans.AdresseStr = adresseMaskedTextBox.Text;
                oTrans.CodePostalStr = codePostalMaskedTextBox.Text;
                oTrans.TelephoneStr = telephoneMaskedTextBox.Text;
                oTrans.TypeMangaStr = typesComboBox.SelectedItem.ToString();
                oTrans.ModeleMangaStr = modelesComboBox.SelectedItem.ToString();
                oTrans.DateLivraisonDateTime = DateTime.Parse(dateLivraisonDateTimePicker.Value.ToString());
                oTrans.TitreStr = titreComboBox.SelectedItem.ToString();
                oTrans.GenreStr = genreComboBox.SelectedItem.ToString();
                oTrans.PrixDecimal = Decimal.Parse(prixLabel.Text.Replace("$", "").Trim());
                paiementLabel.Text = oTrans.DatePaiement.ToLongDateString();
                oTrans.Enregistrer();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Transmettre les données via Enregistrer avec paramètres
        /// <summary>
        /// Gerer l'événement de clic du bouton Enregistrer.
        /// Transmet les données du projet principal au projet Transaction en utilisant la méthode Enregistrer avec paramètres.
        /// </summary>
        //public void Enregistrer_Click()
        //{
        //    Transaction oTrans = new Transaction();
        //    oTrans.Enregistrer(
        //        oTrans.IdInt,
        //        nomMaskedTextBox.Text,
        //        prenomMaskedTextBox.Text,
        //        adresseMaskedTextBox.Text,
        //        codePostalMaskedTextBox.Text,
        //        telephoneMaskedTextBox.Text,
        //        typesComboBox.SelectedItem.ToString(),
        //        modelesComboBox.SelectedItem.ToString(),
        //        DateTime.Parse(dateLivraisonDateTimePicker.Value.ToString()),
        //        titreComboBox.SelectedItem.ToString(),
        //        genreComboBox.SelectedItem.ToString(),
        //        Decimal.Parse(prixLabel.Text.Replace("$", "").Trim())
        //    );
        //}
        #endregion

        #region Methodes Privees
        private void InitValue()
        {
            

            titreComboBox.SelectedIndexChanged -= TransactionComboBox_SelectedIndexChanged;
            genreComboBox.SelectedIndexChanged -= TransactionComboBox_SelectedIndexChanged;

            typesComboBox.Items.AddRange(oTypes.GetTypesModeles(CodesTypes.Types));
            modelesComboBox.Items.AddRange(oTypes.GetTypesModeles(CodesTypes.Modeles));
            titreComboBox.Items.AddRange(oTrans.GetTitres());
            genreComboBox.Items.AddRange(oTrans.GetGenres());

            typesComboBox.SelectedIndex = 0;
            modelesComboBox.SelectedIndex = 0;
            titreComboBox.SelectedIndex = 0;
            genreComboBox.SelectedIndex = 0;

            titreComboBox.SelectedIndexChanged += TransactionComboBox_SelectedIndexChanged;
            genreComboBox.SelectedIndexChanged += TransactionComboBox_SelectedIndexChanged;

            nomMaskedTextBox.Text = "Tano";
            prenomMaskedTextBox.Text = "Dylane";
            adresseMaskedTextBox.Text = "555 Duke street";
            codePostalMaskedTextBox.Text = "E2A 2K9";
            telephoneMaskedTextBox.Text = "506-555-5555";
            dateLivraisonDateTimePicker.Value = DateTime.Now;
            prixLabel.Text = oTrans.GetPrix(titreComboBox.SelectedIndex, genreComboBox.SelectedIndex).ToString("c2");
        }
        #endregion

        #region Quitter
        private void quitterButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region validation date de livraison
        private void dateLivraisonLabel_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DateTime.TryParse(dateLivraisonLabel.Text, out DateTime date))
            {
                dateLivraisonLabel.Text = date.ToLongDateString();
            }
            else
            {
                dateLivraisonLabel.Text = DateTime.Now.ToLongDateString();
            }
        }
        #endregion
    }
}
