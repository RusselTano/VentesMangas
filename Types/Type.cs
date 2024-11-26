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
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;


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
        private string[] tTypes = new string[20];
        private string[] tModeles = new string[40];
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
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Types.data");
            StreamReader sr ;
            try
            {
                String ligne;
                  sr = new StreamReader(filePath, System.Text.Encoding.UTF8);

                ligne = sr.ReadLine();
                int i = 0;
                while (ligne != null)
                {
                    tTypes[i] = ligne;
                    ligne = sr.ReadLine();
                    i++;
                }
                Array.Resize(ref tTypes, i);
            }
            catch (FileNotFoundException)
            {

                throw new FileNotFoundException("Le fichier des types n’est pas disponible.");
            }
            catch (Exception)
            {
                throw new Exception("Erreur indéterminée dans la lecture des types.");
            }

        }
        private void InitModeles()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "modeles.data");
            StreamReader sr;
            try
            {
                String ligne;
               sr = new StreamReader(filePath, System.Text.Encoding.UTF8);

                ligne = sr.ReadLine();
                int i = 0;
                while(ligne != null)
               {
                    tModeles[i] = ligne;
                    ligne = sr.ReadLine();
                    i++;
                }
                Array.Resize(ref tModeles, i);
            }
            catch(FileNotFoundException)
            {
                
                throw new FileNotFoundException("LE fichier des modèles n’est pas disponible.", nameof(tModeles));
            }
            catch(Exception)
            {
                throw new Exception("Erreur indéterminée dans la lecture des modèles.");
            }
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
