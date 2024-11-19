/*
    Programmeurs:   Andreas, Cdric, Dylane, Manuela
    Date:           Novembre 2024
  
    Assembly:       VentesMangas.exe
    Solution:       VentesMangas.sln
    Projet:         VentesMangas.csproj

    Namespace:      {VentesMangas}

    Classe:         VentesMangasClassGenerale.cs
  
    But:           Gestion des clients, des ventes et des achats de mangas.
*/

using ce = VentesMangas.VentesMangasGeneraleClass.Erreurs;
namespace VentesMangas
{
    /// <summary>
    /// Classe genrale dans la couche de resentation
    /// </summary>
    /// <remarks>Projet: VentesMangas</remarks>
    internal class VentesMangasGeneraleClass
    {
        #region Enumeration
        public enum Erreurs
        {
            CEErreurIndeterminee,
            CEErreurArgumentException,
            CEErreurSurCodesTypes,
            ECEErreurPrix,
            ECEErreurTitre,
            ECEErreurGenre,
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
            tMessagesErreursStr[(int)ce.CEErreurArgumentException] = "Paramètre incorrect pour le titre ou le genre.";
            tMessagesErreursStr[(int)ce.CEErreurIndeterminee] = "Erreur indéterminée. Contactez la personne ressource.";
            tMessagesErreursStr[(int)ce.ECEErreurPrix] = "Le prix du pneu ne peut être déterminé avec les indices fournie.";
            tMessagesErreursStr[(int)ce.ECEErreurTitre] = "Le titre du manga ne peut être déterminé avec les indices fournie.";
            tMessagesErreursStr[(int)ce.ECEErreurGenre] = "Le genre du manga ne peut être déterminé avec les indices fournie.";
            tMessagesErreursStr[(int)ce.ECEErreurCodePostalFormat] = "Code postal format invalide";
            tMessagesErreursStr[(int)ce.ECEErreurCodePostalVide] = "Code postal vide";
            tMessagesErreursStr[(int)ce.ECEErreurCodePostalNull] = "Code postal null";
            tMessagesErreursStr[(int)ce.ECEErreurTelephoneFormat] = "Téléphone format invalide";
            tMessagesErreursStr[(int)ce.ECEErreurTelephoneVide] = "Téléphone vide";
            tMessagesErreursStr[(int)ce.ECEErreurTelephoneNull] = "Téléphone null";
        }
        #endregion
    }
}
