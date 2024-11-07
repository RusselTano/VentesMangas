using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private decimal[] tPrix;
        #endregion

        #region Initialisation des tableaux
        private void InitTitres()
        {
            tTitres = new string[5]
            {
                "Naruto",
                "Cardcaptor Sakura",
                "Berserk",
                "Your Lie in April",
                "Oyasumi Punpun"
            };
        }
        private void InitGenres()
        {
            tGenres = new string[5]
            {
                "Shonen",
                "Shojo",
                "Seinen",
                "Josei",
                "Seinen"
            };
        }
        private void InitPrix()
        {
            tPrix = new decimal[5]
            {
                8.99m,
                7.99m,
                10.99m,
                8.50m,
                9.49m
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
        #endregion

        #region Genres de mangas
        #endregion

        #region Prix des mangas
        #endregion
    }
}
