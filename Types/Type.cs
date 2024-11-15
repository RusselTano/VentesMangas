/*
    Programmeurs:   Andreas, Cdric, Dylane, Manuela
    Date:           Novembre 2024
  
    Assembly:       VentesMangas.exe
    Solution:       VentesMangas.sln
    Projet:         VentesMangas.csproj

    Namespace:      {TypeNS}

    Classe:         Type.cs
  
    But:            Gérer et fournir les listes de types et de modèles de mangas
*/
using System;

namespace TypesNS
{
    public class Type
    {
        #region Enum
        public enum CodesTypes
        {
            Types,
            Modeles
        }
        #endregion

        #region Declarations
        private string[] tTypes;
        private string[] tModeles;
        #endregion

        #region Constructeur
        public Type()
        {
            InitTypes();
            InitModeles();
        }
        #endregion

        #region Initialisation
        /// <summary>
        /// Initialiser les tableaux des types et modèles.
        /// </summary>
        /// 
        private void InitTypes()
        {
            tTypes = new string[] { "Édition Standard", "Édition Collector", "Édition Deluxe", "Édition limitée", "Box Set" };
        }
        private void InitModeles()
        {
            tModeles = new string[] { "Blu-Ray", "DVD", "Streaming", "Digital Download" };
        }
        #endregion

        #region Type ou modele
        /// <summary>
        /// Retourne les types ou les modèles selon l'énumération donnée.
        /// </summary>
        /// <param name="type">Type de CodesTypes, soit Types ou Modeles.</param>
        /// <returns>Un tableau de chaînes représentant les types ou les modèles.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Si le paramètre est incorrect.</exception>
        /// 
        public string[] GetTypesModeles(CodesTypes type)
        {
            switch (type)
            {
                case CodesTypes.Types:
                    return tTypes;
                case CodesTypes.Modeles:
                    return tModeles;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), "Type non valide pour CodesTypes");
            }
        }
        #endregion
    }
}
