/*
    Programmeur:    Dylane Tano
    Date:           Novembre 2020
  
    Assembly:       VentesMangas.exe
    Solution:       VentesMangas.sln
    Projet:         VentesMangas.csproj

    Namespace:      typeNS

    Classe:         Type.cs
  
    But:           Gestion des clients, des ventes et des achats de mangas.
*/
using System;


namespace TypesNS
{
    public class Type
    {
        #region enum
        public enum CodesTypes
        {
            Types,
            Modeles
        }

        #endregion

        
            #region declarations
            private string[] tTypes ;
            private string[] tModeles;
        #endregion

        #region constructeur
        public Type()
            {
                InitTypes();
                InitModeles();
            }
        #endregion
        #region initialisation
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
        /// <summary>
        /// Retourne les types ou les modèles selon l'énumération donnée.
        /// </summary>
        /// <param name="type">Type de CodesTypes, soit Types ou Modeles.</param>
        /// <returns>Un tableau de chaînes représentant les types ou les modèles.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Si le paramètre est incorrect.</exception>
        /// 
        

        #region type modele
        public string[] GetTypesModeles(CodesTypes type)
            {
                switch (type)
                {
                    case    CodesTypes.Types:
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
