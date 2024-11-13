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

namespace TransactionNS
{
    /// <summary>
    /// Objet metier: Classe de transaction
    /// </summary>
    /// <remarks>Tous droits réservés: Dylane Tano Inc. 2025</remarks>

    public class Transaction
    {
        #region Declaration des tableaux
        private string[] tTitres;
        private string[] tGenres;
        private decimal[,] tPrix;
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
            tPrix = new decimal[5,5]
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
        public decimal GetPrix(int titre, int genre)
        {
            if (titre < tPrix.GetLowerBound(0) || titre > tPrix.GetUpperBound(0) || genre < tPrix.GetLowerBound(1) || genre > tPrix.GetUpperBound(1))
            {
                return -1; 
            }
            return tPrix[titre, genre];
        }
        #endregion
    }
}
