using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ce = VentesMangas.VentesMangasGeneraleClass.Erreurs;
namespace VentesMangas
{
    internal class VentesMangasGeneraleClass
    {
        #region Enumeration
        public enum Erreurs
        {
        }
        #endregion

        #region Declaration
        public static string[] tMessagesErreursStr = new string[15];
        #endregion

        #region Initialisation
        public static void InitMessagesErreurs()
        {
        }
        #endregion
    }
}
