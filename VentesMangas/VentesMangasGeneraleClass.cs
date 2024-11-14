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
            ECEPrixIntrouvable,
            CEErreurArgumentException,
            CEErreurSurCodesTypes,
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
            tMessagesErreursStr[(int)ce.ECEPrixIntrouvable] = "Le prix du manga  ne peut être déterminé avec les indices fournie.";
        }
        #endregion
    }
}
