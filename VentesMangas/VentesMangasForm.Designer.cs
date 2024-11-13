namespace VentesMangas
{
    public partial class VentesMangasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titreLabel = new System.Windows.Forms.Label();
            this.clientGroupBox = new System.Windows.Forms.GroupBox();
            this.modelesComboBox = new System.Windows.Forms.ComboBox();
            this.modeleVoitureLabel = new System.Windows.Forms.Label();
            this.typesComboBox = new System.Windows.Forms.ComboBox();
            this.typesVoituresLabel = new System.Windows.Forms.Label();
            this.telephoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.codePostalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.adresseMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.prenomMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nomMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.codePostalLabel = new System.Windows.Forms.Label();
            this.adresseLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.transactionGroupBox = new System.Windows.Forms.GroupBox();
            this.dateLivraisonDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLivraisonLabel = new System.Windows.Forms.Label();
            this.prixLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.titreComboBox = new System.Windows.Forms.ComboBox();
            this.prixLLabel = new System.Windows.Forms.Label();
            this.genresLabel = new System.Windows.Forms.Label();
            this.titresLabel = new System.Windows.Forms.Label();
            this.transactionsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aproposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerButton = new System.Windows.Forms.Button();
            this.quitterButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoGauchePictureBox = new System.Windows.Forms.PictureBox();
            this.mangasPictureBox = new System.Windows.Forms.PictureBox();
            this.logoDroitPictureBox = new System.Windows.Forms.PictureBox();
            this.clientGroupBox.SuspendLayout();
            this.transactionGroupBox.SuspendLayout();
            this.transactionsMenuStrip.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoGauchePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangasPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoDroitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titreLabel
            // 
            this.titreLabel.AutoSize = true;
            this.titreLabel.Font = new System.Drawing.Font("Cooper Black", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreLabel.ForeColor = System.Drawing.Color.Crimson;
            this.titreLabel.Location = new System.Drawing.Point(217, 0);
            this.titreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titreLabel.Name = "titreLabel";
            this.titreLabel.Size = new System.Drawing.Size(632, 77);
            this.titreLabel.TabIndex = 2;
            this.titreLabel.Text = "Ventes de Mangas";
            // 
            // clientGroupBox
            // 
            this.clientGroupBox.Controls.Add(this.modelesComboBox);
            this.clientGroupBox.Controls.Add(this.modeleVoitureLabel);
            this.clientGroupBox.Controls.Add(this.typesComboBox);
            this.clientGroupBox.Controls.Add(this.typesVoituresLabel);
            this.clientGroupBox.Controls.Add(this.telephoneMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.telephoneLabel);
            this.clientGroupBox.Controls.Add(this.codePostalMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.adresseMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.prenomMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.nomMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.codePostalLabel);
            this.clientGroupBox.Controls.Add(this.adresseLabel);
            this.clientGroupBox.Controls.Add(this.prenomLabel);
            this.clientGroupBox.Controls.Add(this.nomLabel);
            this.clientGroupBox.Location = new System.Drawing.Point(36, 326);
            this.clientGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientGroupBox.Name = "clientGroupBox";
            this.clientGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.clientGroupBox.Size = new System.Drawing.Size(552, 361);
            this.clientGroupBox.TabIndex = 24;
            this.clientGroupBox.TabStop = false;
            this.clientGroupBox.Text = "Client:";
            // 
            // modelesComboBox
            // 
            this.modelesComboBox.FormattingEnabled = true;
            this.modelesComboBox.Location = new System.Drawing.Point(189, 308);
            this.modelesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.modelesComboBox.Name = "modelesComboBox";
            this.modelesComboBox.Size = new System.Drawing.Size(323, 24);
            this.modelesComboBox.TabIndex = 30;
            // 
            // modeleVoitureLabel
            // 
            this.modeleVoitureLabel.AutoSize = true;
            this.modeleVoitureLabel.Location = new System.Drawing.Point(24, 311);
            this.modeleVoitureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modeleVoitureLabel.Name = "modeleVoitureLabel";
            this.modeleVoitureLabel.Size = new System.Drawing.Size(118, 16);
            this.modeleVoitureLabel.TabIndex = 29;
            this.modeleVoitureLabel.Text = "Modèle de voiture:";
            // 
            // typesComboBox
            // 
            this.typesComboBox.FormattingEnabled = true;
            this.typesComboBox.Location = new System.Drawing.Point(191, 263);
            this.typesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.typesComboBox.Name = "typesComboBox";
            this.typesComboBox.Size = new System.Drawing.Size(323, 24);
            this.typesComboBox.TabIndex = 28;
            // 
            // typesVoituresLabel
            // 
            this.typesVoituresLabel.AutoSize = true;
            this.typesVoituresLabel.Location = new System.Drawing.Point(25, 267);
            this.typesVoituresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typesVoituresLabel.Name = "typesVoituresLabel";
            this.typesVoituresLabel.Size = new System.Drawing.Size(104, 16);
            this.typesVoituresLabel.TabIndex = 27;
            this.typesVoituresLabel.Text = "Type de voiture:";
            // 
            // telephoneMaskedTextBox
            // 
            this.telephoneMaskedTextBox.Location = new System.Drawing.Point(189, 218);
            this.telephoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telephoneMaskedTextBox.Name = "telephoneMaskedTextBox";
            this.telephoneMaskedTextBox.Size = new System.Drawing.Size(324, 22);
            this.telephoneMaskedTextBox.TabIndex = 26;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(25, 222);
            this.telephoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(76, 16);
            this.telephoneLabel.TabIndex = 25;
            this.telephoneLabel.Text = "Téléphone:";
            // 
            // codePostalMaskedTextBox
            // 
            this.codePostalMaskedTextBox.Location = new System.Drawing.Point(189, 172);
            this.codePostalMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codePostalMaskedTextBox.Name = "codePostalMaskedTextBox";
            this.codePostalMaskedTextBox.Size = new System.Drawing.Size(324, 22);
            this.codePostalMaskedTextBox.TabIndex = 24;
            // 
            // adresseMaskedTextBox
            // 
            this.adresseMaskedTextBox.Location = new System.Drawing.Point(191, 127);
            this.adresseMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.adresseMaskedTextBox.Name = "adresseMaskedTextBox";
            this.adresseMaskedTextBox.Size = new System.Drawing.Size(324, 22);
            this.adresseMaskedTextBox.TabIndex = 23;
            // 
            // prenomMaskedTextBox
            // 
            this.prenomMaskedTextBox.Location = new System.Drawing.Point(191, 81);
            this.prenomMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prenomMaskedTextBox.Name = "prenomMaskedTextBox";
            this.prenomMaskedTextBox.Size = new System.Drawing.Size(324, 22);
            this.prenomMaskedTextBox.TabIndex = 22;
            // 
            // nomMaskedTextBox
            // 
            this.nomMaskedTextBox.Location = new System.Drawing.Point(189, 36);
            this.nomMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomMaskedTextBox.Name = "nomMaskedTextBox";
            this.nomMaskedTextBox.Size = new System.Drawing.Size(324, 22);
            this.nomMaskedTextBox.TabIndex = 21;
            // 
            // codePostalLabel
            // 
            this.codePostalLabel.AutoSize = true;
            this.codePostalLabel.Location = new System.Drawing.Point(25, 176);
            this.codePostalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codePostalLabel.Name = "codePostalLabel";
            this.codePostalLabel.Size = new System.Drawing.Size(83, 16);
            this.codePostalLabel.TabIndex = 20;
            this.codePostalLabel.Text = "Code postal:";
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.Location = new System.Drawing.Point(25, 130);
            this.adresseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Size = new System.Drawing.Size(61, 16);
            this.adresseLabel.TabIndex = 19;
            this.adresseLabel.Text = "Adresse:";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(25, 85);
            this.prenomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(57, 16);
            this.prenomLabel.TabIndex = 18;
            this.prenomLabel.Text = "Prénom:";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(25, 39);
            this.nomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(39, 16);
            this.nomLabel.TabIndex = 17;
            this.nomLabel.Text = "Nom:";
            // 
            // transactionGroupBox
            // 
            this.transactionGroupBox.BackColor = System.Drawing.Color.White;
            this.transactionGroupBox.Controls.Add(this.dateLivraisonDateTimePicker);
            this.transactionGroupBox.Controls.Add(this.dateLivraisonLabel);
            this.transactionGroupBox.Controls.Add(this.prixLabel);
            this.transactionGroupBox.Controls.Add(this.genreComboBox);
            this.transactionGroupBox.Controls.Add(this.titreComboBox);
            this.transactionGroupBox.Controls.Add(this.prixLLabel);
            this.transactionGroupBox.Controls.Add(this.genresLabel);
            this.transactionGroupBox.Controls.Add(this.titresLabel);
            this.transactionGroupBox.Location = new System.Drawing.Point(609, 326);
            this.transactionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.transactionGroupBox.Name = "transactionGroupBox";
            this.transactionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.transactionGroupBox.Size = new System.Drawing.Size(491, 242);
            this.transactionGroupBox.TabIndex = 25;
            this.transactionGroupBox.TabStop = false;
            this.transactionGroupBox.Text = "Transaction:";
            // 
            // dateLivraisonDateTimePicker
            // 
            this.dateLivraisonDateTimePicker.Location = new System.Drawing.Point(188, 39);
            this.dateLivraisonDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateLivraisonDateTimePicker.Name = "dateLivraisonDateTimePicker";
            this.dateLivraisonDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dateLivraisonDateTimePicker.TabIndex = 27;
            // 
            // dateLivraisonLabel
            // 
            this.dateLivraisonLabel.AutoSize = true;
            this.dateLivraisonLabel.Location = new System.Drawing.Point(36, 39);
            this.dateLivraisonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLivraisonLabel.Name = "dateLivraisonLabel";
            this.dateLivraisonLabel.Size = new System.Drawing.Size(111, 16);
            this.dateLivraisonLabel.TabIndex = 26;
            this.dateLivraisonLabel.Text = "Date de livraison:";
            // 
            // prixLabel
            // 
            this.prixLabel.BackColor = System.Drawing.Color.White;
            this.prixLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prixLabel.Location = new System.Drawing.Point(188, 176);
            this.prixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prixLabel.Name = "prixLabel";
            this.prixLabel.Size = new System.Drawing.Size(266, 28);
            this.prixLabel.TabIndex = 25;
            this.prixLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genreComboBox
            // 
            this.genreComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(188, 130);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(265, 24);
            this.genreComboBox.TabIndex = 24;
            this.genreComboBox.SelectedIndexChanged += new System.EventHandler(this.TransactionComboBox_SelectedIndexChanged);
            // 
            // titreComboBox
            // 
            this.titreComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.titreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titreComboBox.FormattingEnabled = true;
            this.titreComboBox.Location = new System.Drawing.Point(188, 85);
            this.titreComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.titreComboBox.Name = "titreComboBox";
            this.titreComboBox.Size = new System.Drawing.Size(265, 24);
            this.titreComboBox.TabIndex = 23;
            this.titreComboBox.SelectedIndexChanged += new System.EventHandler(this.TransactionComboBox_SelectedIndexChanged);
            // 
            // prixLLabel
            // 
            this.prixLLabel.AutoSize = true;
            this.prixLLabel.Location = new System.Drawing.Point(36, 182);
            this.prixLLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prixLLabel.Name = "prixLLabel";
            this.prixLLabel.Size = new System.Drawing.Size(32, 16);
            this.prixLLabel.TabIndex = 22;
            this.prixLLabel.Text = "Prix:";
            // 
            // genresLabel
            // 
            this.genresLabel.AutoSize = true;
            this.genresLabel.Location = new System.Drawing.Point(36, 134);
            this.genresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(54, 16);
            this.genresLabel.TabIndex = 21;
            this.genresLabel.Text = "Genres:";
            // 
            // titresLabel
            // 
            this.titresLabel.AutoSize = true;
            this.titresLabel.Location = new System.Drawing.Point(36, 89);
            this.titresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titresLabel.Name = "titresLabel";
            this.titresLabel.Size = new System.Drawing.Size(37, 16);
            this.titresLabel.TabIndex = 20;
            this.titresLabel.Text = "Titre:";
            // 
            // transactionsMenuStrip
            // 
            this.transactionsMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.transactionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.transactionsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.transactionsMenuStrip.Name = "transactionsMenuStrip";
            this.transactionsMenuStrip.Size = new System.Drawing.Size(1149, 28);
            this.transactionsMenuStrip.TabIndex = 26;
            this.transactionsMenuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aproposDeToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // aproposDeToolStripMenuItem
            // 
            this.aproposDeToolStripMenuItem.Name = "aproposDeToolStripMenuItem";
            this.aproposDeToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.aproposDeToolStripMenuItem.Text = "À &propos de...";
            // 
            // enregistrerButton
            // 
            this.enregistrerButton.BackColor = System.Drawing.Color.Green;
            this.enregistrerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enregistrerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrerButton.ForeColor = System.Drawing.Color.White;
            this.enregistrerButton.Location = new System.Drawing.Point(609, 593);
            this.enregistrerButton.Margin = new System.Windows.Forms.Padding(4);
            this.enregistrerButton.Name = "enregistrerButton";
            this.enregistrerButton.Size = new System.Drawing.Size(191, 65);
            this.enregistrerButton.TabIndex = 28;
            this.enregistrerButton.Text = "&Enregistrer";
            this.enregistrerButton.UseVisualStyleBackColor = false;
            // 
            // quitterButton
            // 
            this.quitterButton.BackColor = System.Drawing.Color.Crimson;
            this.quitterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitterButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quitterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitterButton.ForeColor = System.Drawing.Color.White;
            this.quitterButton.Location = new System.Drawing.Point(914, 593);
            this.quitterButton.Margin = new System.Windows.Forms.Padding(4);
            this.quitterButton.Name = "quitterButton";
            this.quitterButton.Size = new System.Drawing.Size(186, 65);
            this.quitterButton.TabIndex = 29;
            this.quitterButton.Text = "&Quitter";
            this.quitterButton.UseVisualStyleBackColor = false;
            this.quitterButton.Click += new System.EventHandler(this.quitterButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.White;
            this.logoPanel.Controls.Add(this.titreLabel);
            this.logoPanel.Controls.Add(this.logoGauchePictureBox);
            this.logoPanel.Controls.Add(this.mangasPictureBox);
            this.logoPanel.Controls.Add(this.logoDroitPictureBox);
            this.logoPanel.Location = new System.Drawing.Point(36, 44);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(1064, 274);
            this.logoPanel.TabIndex = 30;
            // 
            // logoGauchePictureBox
            // 
            this.logoGauchePictureBox.Image = global::VentesMangas.Properties.Resources.mangas;
            this.logoGauchePictureBox.Location = new System.Drawing.Point(29, 114);
            this.logoGauchePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.logoGauchePictureBox.Name = "logoGauchePictureBox";
            this.logoGauchePictureBox.Size = new System.Drawing.Size(245, 114);
            this.logoGauchePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoGauchePictureBox.TabIndex = 0;
            this.logoGauchePictureBox.TabStop = false;
            // 
            // mangasPictureBox
            // 
            this.mangasPictureBox.Image = global::VentesMangas.Properties.Resources.mangatitre;
            this.mangasPictureBox.Location = new System.Drawing.Point(308, 95);
            this.mangasPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.mangasPictureBox.Name = "mangasPictureBox";
            this.mangasPictureBox.Size = new System.Drawing.Size(477, 165);
            this.mangasPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mangasPictureBox.TabIndex = 1;
            this.mangasPictureBox.TabStop = false;
            // 
            // logoDroitPictureBox
            // 
            this.logoDroitPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.logoDroitPictureBox.Image = global::VentesMangas.Properties.Resources.mangas;
            this.logoDroitPictureBox.Location = new System.Drawing.Point(813, 114);
            this.logoDroitPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.logoDroitPictureBox.Name = "logoDroitPictureBox";
            this.logoDroitPictureBox.Size = new System.Drawing.Size(235, 114);
            this.logoDroitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoDroitPictureBox.TabIndex = 27;
            this.logoDroitPictureBox.TabStop = false;
            // 
            // VentesMangasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.quitterButton;
            this.ClientSize = new System.Drawing.Size(1149, 716);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.quitterButton);
            this.Controls.Add(this.enregistrerButton);
            this.Controls.Add(this.transactionsMenuStrip);
            this.Controls.Add(this.transactionGroupBox);
            this.Controls.Add(this.clientGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentesMangasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventes de mangas";
            this.Load += new System.EventHandler(this.VentesMangasForm_Load);
            this.clientGroupBox.ResumeLayout(false);
            this.clientGroupBox.PerformLayout();
            this.transactionGroupBox.ResumeLayout(false);
            this.transactionGroupBox.PerformLayout();
            this.transactionsMenuStrip.ResumeLayout(false);
            this.transactionsMenuStrip.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoGauchePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangasPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoDroitPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoGauchePictureBox;
        private System.Windows.Forms.PictureBox mangasPictureBox;
        private System.Windows.Forms.Label titreLabel;
        private System.Windows.Forms.GroupBox clientGroupBox;
        private System.Windows.Forms.ComboBox typesComboBox;
        private System.Windows.Forms.Label typesVoituresLabel;
        private System.Windows.Forms.MaskedTextBox telephoneMaskedTextBox;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.MaskedTextBox codePostalMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox adresseMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox prenomMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox nomMaskedTextBox;
        private System.Windows.Forms.Label codePostalLabel;
        private System.Windows.Forms.Label adresseLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.GroupBox transactionGroupBox;
        private System.Windows.Forms.DateTimePicker dateLivraisonDateTimePicker;
        private System.Windows.Forms.Label dateLivraisonLabel;
        private System.Windows.Forms.Label prixLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.ComboBox titreComboBox;
        private System.Windows.Forms.Label prixLLabel;
        private System.Windows.Forms.Label genresLabel;
        private System.Windows.Forms.Label titresLabel;
        private System.Windows.Forms.MenuStrip transactionsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aproposDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox logoDroitPictureBox;
        private System.Windows.Forms.Button enregistrerButton;
        private System.Windows.Forms.Button quitterButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.ComboBox modelesComboBox;
        private System.Windows.Forms.Label modeleVoitureLabel;
    }
}

