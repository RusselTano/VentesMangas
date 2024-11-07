using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransactionNS;
using g = VentesMangas.VentesMangasGeneraleClass;
using ce = VentesMangas.VentesMangasGeneraleClass.Erreurs;

namespace VentesMangas
{
    /// <summary>
    /// Formulaire de gestion des ventes de mangas.
    /// </summary>
    public partial class VentesMangasForm : Form
    {
        #region Déclaration
        private string[] tTitresMangas;
        private string[] tGenres;
        private decimal[] tPrix;
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur
        /// </summary>
        public VentesMangasForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Initialisation
        private void VentesMangasForm_Load(object sender, EventArgs e)
        {
            g.InitMessagesErreurs();
            Transaction oTrans = new Transaction();
        }
        #endregion

        #region Obtenir le prix
        #endregion

        #region Quitter
        private void quitterButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
