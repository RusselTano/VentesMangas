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
using System.Globalization;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using ce = TransactionNS.Transaction.CodesErreurs;
namespace TransactionNS
{
    public class Transaction
    {
        #region Declaration des tableaux
        private string[] tTitres = new String[20];
        private string[] tGenres = new String[20];
        private decimal[,] tPrix = new decimal[20, 20];
        private CultureInfo anglaisCultureInfo = new CultureInfo("en-CA");
        #endregion

        #region Variables privees
        private const string CODE_POSTAL_MODELE_Str = "^([ABCEGHJKLMNPRSTVXY]\\d[ABCEGHJKLMNPRSTVWXYZ])\\ {0,1}(\\d[ABCEGHJKLMNPRSTVWXYZ]\\d)$";
        private const string TELEPHONE_MODELE_Str = "^(\\([2-9]\\d{2}\\)|[2-9]\\d{2})[- .]?\\d{3}[- .]?\\d{4}$";
        private const string delimiter = ";";

        private static int idInt;
        private string nomStr;
        private string prenomStr;
        private string adresseStr;
        private string codePostalStr;
        private string telephoneStr;
        string typeMangaStr;
        string modeleMangaStr;
        private DateTime dateLivraisonDateTime;
        private DateTime datePaiement;
        string titreStr;
        string genreStr;
        private decimal prixDecimal;
        #endregion

        #region Enumeration et tableaux
        public enum CodesErreurs
        {
            NomObligatoire,
            PrenomObligatoire,
            AdresseObligatoire,
            CodePostalObligatoire,
            CodePostalInvalide,
            TypeMangaObligatoire,
            TelephoneObligatoire,
            ModeleObligatoire,
            PrixInvalide,
            TitreInvalide,
            GenreInvalide,
            DateLivraisonInvalide,
            ErreurIndeterminee,
            ECEErreurCodePostalFormat,
            ECEErreurCodePostalVide,
            ECEErreurCodePostalNull,
            ECEErreurTelephoneFormat,
            ECEErreurTelephoneVide,
            ECEErreurTelephoneNull,
            ECEErreurFileNotFoundTitre,
            ECEErreurFileNotFoundGenre,
            ECEErreurFileNotFoundPrix,
            ECEErreurFormatTitre,
            ECEErreurFormatGenre,
            ECEErreurFormatPrix,
            ECEErreurIndeterminer,
        }
        #endregion

        #region Declaration
        public static string[] tMessagesErreursStr = new string[50];
        #endregion

        #region Initialisation
        public static void InitMessagesErreurs()
        {
            tMessagesErreursStr[(int)ce.NomObligatoire] = "Le nom est obligatoire.";
            tMessagesErreursStr[(int)ce.PrenomObligatoire] = "Le prenom est obligatoire.";
            tMessagesErreursStr[(int)ce.AdresseObligatoire] = "L'adresse est obligatoire.";
            tMessagesErreursStr[(int)ce.ModeleObligatoire] = "Le modele est obligatoire.";
            tMessagesErreursStr[(int)ce.TelephoneObligatoire] = "Le telephone est obligatoire.";
            tMessagesErreursStr[(int)ce.TypeMangaObligatoire] = "Le type de manga est obligatoire.";
            tMessagesErreursStr[(int)ce.CodePostalObligatoire] = "Le codePostal est obligatoire.";
            tMessagesErreursStr[(int)ce.PrixInvalide] = "Le prix est invalide.";
            tMessagesErreursStr[(int)ce.TitreInvalide] = "Le titre est invalide.";
            tMessagesErreursStr[(int)ce.GenreInvalide] = "Le genre est invalide.";
            tMessagesErreursStr[(int)ce.DateLivraisonInvalide] = "La date de livraison est invalide.";
            tMessagesErreursStr[(int)ce.ErreurIndeterminee] = "Une erreur indéterminée est survenue.";
            tMessagesErreursStr[(int)ce.ECEErreurCodePostalFormat] = "Code postal format invalide";
            tMessagesErreursStr[(int)ce.ECEErreurCodePostalVide] = "Code postal vide";
            tMessagesErreursStr[(int)ce.ECEErreurCodePostalNull] = "Code postal null";
            tMessagesErreursStr[(int)ce.ECEErreurTelephoneFormat] = "Téléphone format invalide";
            tMessagesErreursStr[(int)ce.ECEErreurTelephoneVide] = "Téléphone vide";
            tMessagesErreursStr[(int)ce.ECEErreurTelephoneNull] = "Téléphone null";
            tMessagesErreursStr[(int)ce.ECEErreurFileNotFoundTitre] = "Le fichier des titres n’est pas disponible.";
            tMessagesErreursStr[(int)ce.ECEErreurFormatTitre] = "Le format specifier pour les titres est incorect.";
            tMessagesErreursStr[(int)ce.ECEErreurFileNotFoundGenre] = "Le fichier des genres n’est pas disponible.";
            tMessagesErreursStr[(int)ce.ECEErreurFormatGenre] = "Le format specifier pour les genres est incorect.";
            tMessagesErreursStr[(int)ce.ECEErreurFileNotFoundPrix] = "Le fichier des prix n’est pas disponible.";
            tMessagesErreursStr[(int)ce.ECEErreurFormatPrix] = "Le format specifier pour les prix est incorect.";
            tMessagesErreursStr[(int)ce.ECEErreurIndeterminer] = "veuillez contacter la personne ressources erreur indeterminer";
        }
        #endregion

        #region Proprietes publiques
        public readonly int IdInt;
        public string NomStr
        {
            get { return nomStr; }
            set
            {
                if (value != null)
                {
                    value = value.Trim();

                    if (value != string.Empty)
                    {
                        nomStr = value;
                    }
                    else
                    {
                        throw new ArgumentException(tMessagesErreursStr[(int)CodesErreurs.NomObligatoire]);
                    }
                }
                else
                {
                    throw new ArgumentException(tMessagesErreursStr[(int)CodesErreurs.NomObligatoire]);
                }
            }
        }
        public string PrenomStr
        {
            get { return prenomStr; }
            set
            {
                if (value != null)
                {
                    value = value.Trim();

                    if (value != string.Empty)
                    {
                        prenomStr = value;
                    }
                    else
                    {
                        throw new ArgumentException(tMessagesErreursStr[(int)CodesErreurs.PrenomObligatoire]);
                    }
                }
                else
                {
                    throw new ArgumentException(tMessagesErreursStr[(int)CodesErreurs.PrenomObligatoire]);
                }
            }
        }
        public string AdresseStr
        {
            get { return adresseStr; }
            set
            {
                if (value != null)
                {
                    value = value.Trim();

                    if (value != string.Empty)
                    {
                        adresseStr = value;
                    }
                    else
                    {
                        throw new ArgumentException(tMessagesErreursStr[(int)CodesErreurs.AdresseObligatoire]);
                    }
                }
                else
                {
                    throw new ArgumentException(tMessagesErreursStr[(int)CodesErreurs.AdresseObligatoire]);
                }
            }
        }
        public string CodePostalStr
        {
            get { return codePostalStr; }
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
            get { return telephoneStr; }
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
        public string TypeMangaStr
        {
            get { return typeMangaStr; }
            set
            {
                if (value != null)
                {
                    value = value.Trim();

                    if (value != string.Empty)
                    {
                        typeMangaStr = value;
                    }
                    else
                    {
                        throw new ArgumentException(tMessagesErreursStr[(int)CodesErreurs.TypeMangaObligatoire]);
                    }

                }
                else
                {
                    throw new ArgumentException(tMessagesErreursStr[(int)CodesErreurs.TypeMangaObligatoire]);
                }
            }
        }
        public string ModeleMangaStr
        {
            get { return modeleMangaStr; }
            set
            {
                if (value != null)
                {
                    value = value.Trim();

                    if (value != string.Empty)
                    {
                        modeleMangaStr = value;
                    }
                    else
                    {
                        throw new ArgumentException(tMessagesErreursStr[(int)CodesErreurs.ModeleObligatoire]);
                    }

                }
                else
                {
                    throw new ArgumentException(tMessagesErreursStr[(int)CodesErreurs.ModeleObligatoire]);
                }
            }
        }
        public DateTime DateLivraisonDateTime
        {
            get => dateLivraisonDateTime;
            set
            {
                {
                    if (value >= DateTime.Now.AddDays(-15) && value <= DateTime.Now.AddDays(15))
                    {
                        dateLivraisonDateTime = value;
                        datePaiement = dateLivraisonDateTime.AddDays(30);
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException(tMessagesErreursStr[(int)CodesErreurs.DateLivraisonInvalide]);
                    }
                }
            }
        }
        public DateTime DatePaiement => datePaiement;
        public string TitreStr
        {
            get { return titreStr; }
            set
            {
                if (value != null && (value != string.Empty))
                {
                    if (Array.IndexOf(tTitres, value.Trim()) != -1)
                    {
                        titreStr = value.Trim();
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException(tMessagesErreursStr[(int)CodesErreurs.TitreInvalide]);
                    }
                }
                else
                {
                    throw new ArgumentNullException(tMessagesErreursStr[(int)CodesErreurs.TitreInvalide]);
                }
            }
        }
        public string GenreStr
        {
            get { return genreStr; }
            set
            {
                if (value != null && !string.IsNullOrWhiteSpace(value))
                {
                    if (Array.IndexOf(tGenres, value.Trim()) != -1)
                    {
                        genreStr = value.Trim();
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException(tMessagesErreursStr[(int)CodesErreurs.GenreInvalide]);
                    }
                }
                else
                {
                    throw new ArgumentNullException(tMessagesErreursStr[(int)CodesErreurs.GenreInvalide]);
                }
            }
        }
        public decimal PrixDecimal
        {
            get { return prixDecimal; }
            set
            {
                if (value > 0)
                {
                    if (!string.IsNullOrEmpty(titreStr) && !string.IsNullOrEmpty(genreStr))
                    {
                        // Exemple : Vérification des indices dans les tableaux
                        int indicetitre = Array.IndexOf(tTitres, TitreStr);
                        int indicegenre = Array.IndexOf(tGenres, GenreStr);

                        if (indicetitre != -1 && indicegenre != -1)
                        {
                            if (tPrix[indicetitre, indicegenre] == value)
                            {
                                prixDecimal = value;
                            }
                            else
                            {
                                throw new ArgumentException(tMessagesErreursStr[(int)CodesErreurs.PrixInvalide]);
                            }
                        }
                        else
                        {
                            throw new ArgumentException(tMessagesErreursStr[(int)CodesErreurs.ErreurIndeterminee]);
                        }
                    }
                    else
                    {
                        throw new ArgumentNullException(tMessagesErreursStr[(int)CodesErreurs.ErreurIndeterminee]);
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException(tMessagesErreursStr[(int)CodesErreurs.PrixInvalide]);
                }
            }
        }
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
        public Transaction(int idPrinc, string nomPrinc, string prenomPrinc, string adressePrinc, string codePostalPrinc, string telephonePrinc, string typeMangaPrinc, string modelMangaPrinc, DateTime dateLivraisonPrinc, DateTime datePaiementPrinc, string titrePrinc, string genrePrinc, decimal prixPrinc)
        {
            SetProperties(idPrinc, nomPrinc, prenomPrinc, adressePrinc, codePostalPrinc, telephonePrinc, typeMangaPrinc, modelMangaPrinc, dateLivraisonPrinc, datePaiementPrinc, titrePrinc, genrePrinc, prixPrinc);
        }
        #endregion

        #region Initialisation des tableaux
        /// <summary>
        /// methode pour initialiser les titres
        /// </summary>
        private void InitTitres()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Titre.data");
            Console.WriteLine(filePath);
            try
            {
                String ligne;
                using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.UTF8))
                {
                    int nombre;
                    ligne = sr.ReadLine();
                    nombre = int.Parse(ligne);
                    Array.Resize(ref tTitres, nombre);
                    for (int i = 0; i < nombre; i++)           
                        tTitres[i] = sr.ReadLine().Trim();
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException(tMessagesErreursStr[(int)CodesErreurs.ECEErreurFileNotFoundTitre]);
            }
            catch (FormatException)
            {
                throw new FormatException(tMessagesErreursStr[(int)CodesErreurs.ECEErreurFormatTitre]);
            }
            catch (Exception)
            { throw new Exception(tMessagesErreursStr[(int)CodesErreurs.ECEErreurIndeterminer]); }
        }
        /// <summary>
        /// methode pour initialiser les genres
        /// </summary>
        private void InitGenres()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Genres.data");
            try
            {
                using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.UTF8))
                {
                    string ligne = sr.ReadLine();
                    int nombre = int.Parse(ligne);
                    Array.Resize(ref tGenres, nombre);

                    for (int i = 0; i < nombre; i++)
                        tGenres[i] = sr.ReadLine().Trim();
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException(tMessagesErreursStr[(int)CodesErreurs.ECEErreurFileNotFoundGenre]);
            }

            catch (FormatException)
            {
                throw new FormatException(tMessagesErreursStr[(int)CodesErreurs.ECEErreurFormatGenre]);
            }

            catch (Exception ex)
            { throw new Exception(tMessagesErreursStr[(int)CodesErreurs.ECEErreurIndeterminer]); }

        }
        /// <summary>
        /// methode pour initialiser les prix
        /// </summary>
        private void InitPrix()
        {

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Prix.data");

            try
            {

                using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.UTF8))
                {

                    int rangée = tTitres.Length;
                    int colonne = tGenres.Length;
                    ResizeArray(ref tPrix, rangée, colonne);
                    for (int i = 0; i < rangée; i++)
                    {
                        for (int j = 0; j < colonne; j++)
                        { tPrix[i, j] = Decimal.Parse(sr.ReadLine(), anglaisCultureInfo); }


                    }

                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException(tMessagesErreursStr[(int)CodesErreurs.ECEErreurFileNotFoundPrix]);
            }

            catch (FormatException)
            {
                throw new FormatException(tMessagesErreursStr[(int)CodesErreurs.ECEErreurFormatPrix]);
            }
            catch (Exception)
            { 
                throw new Exception(tMessagesErreursStr[(int)CodesErreurs.ECEErreurIndeterminer]); 
            }
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
            string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string filePath = Path.Combine(projectRoot, "Data", "Transaction.data");

            if(TransactionCompplete())
            {
                idInt = (int)(DateTime.Now.Ticks % int.MaxValue);
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
                 $"Date de paiement: {datePaiement}\n" +
                 $"Prix: {prixDecimal:C2}\n\n";
                Console.WriteLine(message);
                MessageBox.Show(message, "Transaction enregistrée", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    using (StreamWriter sw = new StreamWriter(filePath, true)) 
                    {
                        message = string.Join(delimiter, idInt, nomStr, prenomStr, adresseStr, codePostalStr, telephoneStr, typeMangaStr, modeleMangaStr, dateLivraisonDateTime, datePaiement, titreStr, genreStr, prixDecimal);
                        sw.WriteLine(message);
                    }
                }
                catch (Exception ex)
                {
                    throw new IOException("Une erreur est survenue lors de l'enregistrement de la transaction.", ex);
                }
            }
        }
        #endregion

        #region Méthode Enregistrer() avec paramètres
        public void Enregistrer(int idPrinc, string nomPrinc, string prenomPrinc, string adressePrinc, string codePostalPrinc, string telephonePrinc, string typeMangaPrinc, string modelMangaPrinc, DateTime dateLivraisonPrinc, DateTime datePaiementPrinc, string titrePrinc, string genrePrinc, decimal prixPrinc)
        {
            SetProperties(idPrinc, nomPrinc, prenomPrinc, adressePrinc, codePostalPrinc, telephonePrinc, typeMangaPrinc, modelMangaPrinc, dateLivraisonPrinc, datePaiementPrinc, titrePrinc, genrePrinc, prixPrinc);
            Enregistrer();
        }
        #endregion

        #region Methodes Privees
        private void SetProperties(int idPrinc, string nomPrinc, string prenomPrinc, string adressePrinc, string codePostalPrinc, string telephonePrinc, string typeMangaPrinc, string modelMangaPrinc, DateTime dateLivraisonPrinc, DateTime datePaiementPrinc, string titrePrinc, string genrePrinc, decimal prixPrinc)
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
            datePaiement = datePaiementPrinc;
        }
        public bool TransactionCompplete()
        {
            // Vérifie que toutes les propriétés obligatoires sont renseignées.
            return !string.IsNullOrWhiteSpace(nomStr) &&
                   !string.IsNullOrWhiteSpace(prenomStr) &&
                   !string.IsNullOrWhiteSpace(adresseStr) &&
                   !string.IsNullOrWhiteSpace(codePostalStr) &&
                   !string.IsNullOrWhiteSpace(telephoneStr) &&
                   !string.IsNullOrWhiteSpace(typeMangaStr) &&
                   !string.IsNullOrWhiteSpace(modeleMangaStr) &&
                   !string.IsNullOrWhiteSpace(genreStr) &&
                   !string.IsNullOrWhiteSpace(titreStr) &&
                   prixDecimal > 0 &&
                   dateLivraisonDateTime != default &&
                   datePaiement != default;
        }

        #endregion

        #region Méthode privée ResizeArray
        private void ResizeArray(ref decimal[,] prix, int pRangé, int pColonne)
        {
            prix = new decimal[pRangé, pColonne];
        }
        #endregion

    }
}
