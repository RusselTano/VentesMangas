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
    internal class VentesMangasGeneraleClass
    {
        #region Enumeration
        public enum Erreurs
        {
            CEErreurIndeterminee,
            ECEPrixIntrouvable,
        }
        #endregion

        #region Declaration
        public static string[] tMessagesErreursStr = new string[15];
        #endregion

        #region Initialisation
        public static void InitMessagesErreurs()
        {
            tMessagesErreursStr[(int)ce.CEErreurIndeterminee] = "Erreur indéterminée. Contactez la personne ressource.";
            tMessagesErreursStr[(int)ce.ECEPrixIntrouvable] = "Le prix du pneu ne peut être déterminé avec les indices fournie.";
        }
        #endregion
    }
}
