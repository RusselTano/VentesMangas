/*
    Programmeurs:   Andreas, Cdric, Dylane, Manuela
    Date:           Novembre 2024
  
    Assembly:       VentesMangas.exe
    Solution:       VentesMangas.sln
    Projet:         VentesMangas.csproj

    Namespace:      {TransactionNS}

    Classe:        Transaction.cs
  
    But:           Gestion des clients, des ventes et des achats de mangas.
*/

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using ce = TransactionNS.Transaction.CodeErreurs;
namespace TransactionNS
{
    public class Transaction
    {
        #region Declaration des tableaux
        private string[] tTitres;
        private string[] tGenres;
        private decimal[,] tPrix;
        #endregion

        #region Variables privees
        private const string CODE_POSTAL_MODELE_Str = "^([ABCEGHJKLMNPRSTVXY]\\d[ABCEGHJKLMNPRSTVWXYZ])\\ {0,1}(\\d[ABCEGHJKLMNPRSTVWXYZ]\\d)$";
        private const string TELEPHONE_MODELE_Str = "^(\\([2-9]\\d{2}\\)|[2-9]\\d{2})[- .]?\\d{3}[- .]?\\d{4}$";

        private static int idInt;
        private string nomStr;
        private string prenomStr;
        private string adresseStr;
        private string codePostalStr;
        private string telephoneStr;
        string typeMangaStr;
        string modeleMangaStr;
        private DateTime dateLivraisonDateTime;
        string titreStr;
        string genreStr;
        private decimal prixDecimal;
        #endregion

        #region Enumeration
        public enum CodeErreurs
        {
            ECEErreurCodePostalFormat,
            ECEErreurCodePostalVide,
            ECEErreurCodePostalNull,
            ECEErreurTelephoneFormat,
            ECEErreurTelephoneVide,
            ECEErreurTelephoneNull,
        }
        #endregion

        #region Declaration
        public static string[] tMessagesErreursStr = new string[15];
        #endregion

        #region Initialisation
        public static void InitMessagesErreurs()
        {
            tMessagesErreursStr[(int)ce.ECEErreurCodePostalFormat] = "Code postal format invalide";
            tMessagesErreursStr[(int)ce.ECEErreurCodePostalVide] = "Code postal vide";
            tMessagesErreursStr[(int)ce.ECEErreurCodePostalNull] = "Code postal null";
            tMessagesErreursStr[(int)ce.ECEErreurTelephoneFormat] = "Téléphone format invalide";
            tMessagesErreursStr[(int)ce.ECEErreurTelephoneVide] = "Téléphone vide";
            tMessagesErreursStr[(int)ce.ECEErreurTelephoneNull] = "Téléphone null";
        }
        #endregion

        #region Proprietes publiques
        public int IdInt { get => idInt; set => idInt = value; }
        public string NomStr { get => nomStr; set => nomStr = value; }
        public string PrenomStr { get => prenomStr; set => prenomStr = value; }
        public string AdresseStr { get => adresseStr; set => adresseStr = value; }
        public string CodePostalStr
        {
            get
            {
                return codePostalStr;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();

                    if (value != string.Empty)
                    {
                        if (Regex.IsMatch(value, CODE_POSTAL_MODELE_Str, RegexOptions.IgnoreCase))
                            codePostalStr = value;
                        else
                            throw new FormatException(tMessagesErreursStr[(int)ce.ECEErreurCodePostalFormat]);
                    }
                    else
                        throw new ArgumentException(tMessagesErreursStr[(int)ce.ECEErreurCodePostalVide]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreursStr[(int)ce.ECEErreurCodePostalNull]);
            }
        }
        public string TelephoneStr
        {
            get
            {
                return telephoneStr;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();

                    if (value != string.Empty)
                    {
                        if (Regex.IsMatch(value, TELEPHONE_MODELE_Str))
                            telephoneStr = value;
                        else
                            throw new FormatException(tMessagesErreursStr[(int)ce.ECEErreurTelephoneFormat]);
                    }
                    else
                        throw new ArgumentException(tMessagesErreursStr[(int)ce.ECEErreurTelephoneVide]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreursStr[(int)ce.ECEErreurTelephoneNull]);
            }
        }
        public string TypeMangaStr { get => typeMangaStr; set => typeMangaStr = value; }
        public string ModeleMangaStr { get => modeleMangaStr; set => modeleMangaStr = value; }
        public DateTime DateLivraisonDateTime { get => dateLivraisonDateTime; set => dateLivraisonDateTime = value; }
        public string TitreStr { get => titreStr; set => titreStr = value; }
        public string GenreStr { get => genreStr; set => genreStr = value; }
        public decimal PrixDecimal { get => prixDecimal; set => prixDecimal = value; }
        #endregion

        #region Constructeur
        public Transaction()
        {
            InitGenres();
            InitTitres();
            InitPrix();
            InitMessagesErreurs();
        }
        #endregion

        #region Constructeur avec parametres
        public Transaction(int idPrinc, string nomPrinc, string prenomPrinc, string adressePrinc, string codePostalPrinc, string telephonePrinc, string typeMangaPrinc, string modelMangaPrinc, DateTime dateLivraisonPrinc, string titrePrinc, string genrePrinc, decimal prixPrinc)
        {
            SetProperties(idPrinc, nomPrinc, prenomPrinc, adressePrinc, codePostalPrinc, telephonePrinc, typeMangaPrinc, modelMangaPrinc, dateLivraisonPrinc, titrePrinc, genrePrinc, prixPrinc);
        }
        #endregion

        #region Initialisation des tableaux
        /// <summary>
        /// methode pour initialiser les titres
        /// </summary>
        private void InitTitres()
        {
            tTitres = new string[5] { "Naruto", "Cardcaptor Sakura", "Berserk", "Your Lie in April", "Oyasumi Punpun" };
        }
        /// <summary>
        /// methode pour initialiser les genres
        /// </summary>
        private void InitGenres()
        {
            tGenres = new string[5] { "Shonen", "Shojo", "Seinen", "Josei", "Seinen" };
        }
        /// <summary>
        /// methode pour initialiser les prix
        /// </summary>
        private void InitPrix()
        {
            tPrix = new decimal[5, 5]
            {
                { 8.99m, 7.99m, 10.99m, 8.50m, 9.49m },
                { 6.99m, 5.99m, 8.99m, 7.50m, 8.49m },
                { 12.99m, 11.99m, 14.99m, 13.50m, 14.49m },
                { 7.99m, 6.99m, 9.99m, 8.50m, 9.49m },
                { 9.99m, 8.99m, 11.99m, 10.50m, 11.49m }
            };
        }
        #endregion

        #region Titres de mangas
        /// <summary>
        /// methode pour retourner les titres
        /// </summary>
        /// <returns>un tableau de titre</returns>
        public string[] GetTitres()
        {
            return tTitres;
        }
        #endregion

        #region Genres de mangas
        /// <summary>
        /// methode pour retourner les genres
        /// </summary>
        /// <returns>un tableau de genre</returns>
        public string[] GetGenres()
        {
            return tGenres;
        }
        #endregion

        #region Prix de mangas
        /// <summary>
        /// Liste des prix des mangas
        /// </summary>
        /// <param name="titre">Indice (entier) pour le titre du manga</param>
        /// <param name="genre">Indice (entier) pour le genre des pneus</param>
        /// <returns>Le prix associé au titre et au genre du manga.</returns>
        /// 
        public decimal GetPrix(int titre, int genre)
        {
            if (titre < 0 || titre >= tTitres.Length)
                throw new ArgumentOutOfRangeException(nameof(titre), "L'indice de marque est hors des limites.");
            if (genre < 0 || titre >= tGenres.Length)
                throw new ArgumentOutOfRangeException(nameof(genre), "L'indice de diamètre est hors des limites.");

            if (titre < tPrix.GetLowerBound(0) || titre > tPrix.GetUpperBound(0) || genre < tPrix.GetLowerBound(1) || genre > tPrix.GetUpperBound(1))
                return -1;

            return tPrix[titre, genre];
        }

        /// <summary>
        /// Obtenir le prix basé sur le nom de la marque et le diamètre.
        /// </summary>
        /// <param name="marque">Nom de la marque.</param>
        /// <param name="diametre">Diamètre du pneu.</param>
        /// <returns>Le prix sous forme de Decimal.</returns>
        /// <exception cref="ArgumentException">Si la marque ou le diamètre est invalide.</exception>
        /// 
        public decimal GetPrix(string titre, string genre)
        {
            int titreIndex = Array.IndexOf(tTitres, titre);
            int genreIndex = Array.IndexOf(tGenres, genre);

            if (titreIndex == -1)
                throw new ArgumentException("La marque spécifiée est invalide.", nameof(titre));
            if (genreIndex == -1)
                throw new ArgumentException("Le diamètre spécifié est invalide.", nameof(genre));

            return tPrix[titreIndex, genreIndex];
        }
        #endregion

        #region Méthode Enregistrer() sans paramètre
        public void Enregistrer()
        {
                idInt++;

                string message = $"Client:\n" +
                                 $"Id:{idInt}\n" +
                                 $"Nom: {nomStr}\n" +
                                 $"Prénom: {prenomStr}\n" +  
                                 $"Adresse: {adresseStr}\n" +
                                 $"Code postal: {codePostalStr}\n" +
                                 $"Téléphone: {telephoneStr}\n" +
                                 $"Type de manga: {typeMangaStr}\n" +
                                 $"Modèle de manga: {modeleMangaStr}\n\n" +
                                 $"Transaction:\n" +
                                 $"Date de livraison: {dateLivraisonDateTime}\n" +
                                 $"Titre: {titreStr}\n" +
                                 $"Genre: {genreStr}\n" +
                                 $"Prix: {prixDecimal:C2}\n\n";

                Console.WriteLine(message);
                MessageBox.Show(message, "Transaction enregistrée", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Méthode Enregistrer() avec paramètres
        public void Enregistrer(int idPrinc, string nomPrinc, string prenomPrinc, string adressePrinc, string codePostalPrinc, string telephonePrinc, string typeMangaPrinc, string modelMangaPrinc, DateTime dateLivraisonPrinc, string titrePrinc, string genrePrinc, decimal prixPrinc)
        {
            SetProperties(idPrinc, nomPrinc, prenomPrinc, adressePrinc, codePostalPrinc, telephonePrinc, typeMangaPrinc, modelMangaPrinc, dateLivraisonPrinc, titrePrinc, genrePrinc, prixPrinc);
            Enregistrer();
        }
        #endregion

        #region Methodes Privees
        private void SetProperties(int idPrinc, string nomPrinc, string prenomPrinc, string adressePrinc, string codePostalPrinc, string telephonePrinc, string typeMangaPrinc, string modelMangaPrinc, DateTime dateLivraisonPrinc, string titrePrinc, string genrePrinc, decimal prixPrinc)
        {
            idInt = idPrinc;
            nomStr = nomPrinc;
            prenomStr = prenomPrinc;
            adresseStr = adressePrinc;
            codePostalStr = codePostalPrinc;
            telephoneStr = telephonePrinc;
            typeMangaStr = typeMangaPrinc;
            modeleMangaStr = modelMangaPrinc;
            dateLivraisonDateTime = dateLivraisonPrinc;
            titreStr = titrePrinc;
            genreStr = genrePrinc;
            prixDecimal = prixPrinc;
        }
        #endregion
    }

}
