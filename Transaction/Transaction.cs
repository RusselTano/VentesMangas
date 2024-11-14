/*
    Programmeur:    Dylane Tano
    Date:           Novembre 2020
  
    Assembly:       VentesMangas.exe
    Solution:       VentesMangas.sln
    Projet:         VentesMangas.csproj

    Namespace:      TransactionNS

    Classe:        Transaction.cs
  
    But:           Gestion des clients, des ventes et des achats de mangas.
*/

using System;
<<<<<<< HEAD
=======
using System.Windows.Forms;
>>>>>>> PhaseC

namespace TransactionNS
{

    public class Transaction
    {
        #region Declaration des tableaux
        private string[] tTitres;
        private string[] tGenres;
        private decimal[,] tPrix;
        #endregion

        #region Champs prives
        private int idInt;
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

        #region Proprietes publiques
        public int IdInt { get => idInt; set => idInt = value; }
        public string NomStr { get => nomStr; set => nomStr = value; }
        public string PrenomStr { get => prenomStr; set => prenomStr = value; }
        public string AdresseStr { get => adresseStr; set => adresseStr = value; }
        public string CodePostalStr { get => codePostalStr; set => codePostalStr = value; }
        public string TelephoneStr { get => telephoneStr; set => telephoneStr = value; }
        public string TypeMangaStr { get => typeMangaStr; set => typeMangaStr = value; }
        public string ModeleMangaStr { get => modeleMangaStr; set => modeleMangaStr = value; }
        public DateTime DateLivraisonDateTime { get => dateLivraisonDateTime; set => dateLivraisonDateTime = value; }
        public string TitreStr { get => titreStr; set => titreStr = value; }
        public string GenresStr { get => genreStr; set => genreStr = value; }
        public decimal PrixDecimal { get => prixDecimal; set => prixDecimal = value; }
        #endregion

        #region Constructeur avec parametres
        public Transaction(int idPrinc, string nomPrinc, string prenomPrinc, string adressePrinc, string codePostalPrinc, string telephonePrinc, string typeMangaPrinc, string modelMangaPrinc, DateTime dateLivraisonPrinc, string titrePrinc,string genrePrinc,  decimal prixPrinc)
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

        #region Méthode Enregistrer() sans paramètre
        public void Enregistrer()
        {
            string message = $"Client:\n" +
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
                             $"Prix: ${prixDecimal}";
            Console.WriteLine(message);

            MessageBox.Show(message, "Transaction enregistrée", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Méthode Enregistrer() avec paramètres
        public void Enregistrer(int idPrinc, string nomPrinc, string prenomPrinc, string adressePrinc, string codePostalPrinc, string telephonePrinc, string typeMangaPrinc, string modelMangaPrinc, DateTime dateLivraisonPrinc, string titrePrinc,string genrePrinc,  decimal prixPrinc)
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

            Enregistrer();
        }
        #endregion

        #region
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

        #region Constructeur
        public Transaction()
        {
            InitGenres();
            InitTitres();
            InitPrix();
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
<<<<<<< HEAD

            

            if (titre < 0 || titre >= tTitres.Length)
                throw new ArgumentOutOfRangeException(nameof(titre), "L'indice de marque est hors des limites.");
            if (genre < 0 || titre >= tGenres.Length)
                throw new ArgumentOutOfRangeException(nameof(genre), "L'indice de diamètre est hors des limites.");

=======
            if (titre < tPrix.GetLowerBound(0) || titre > tPrix.GetUpperBound(0) || genre < tPrix.GetLowerBound(1) || genre > tPrix.GetUpperBound(1))
            {
                return -1;
            }
>>>>>>> PhaseC
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
    }
}
