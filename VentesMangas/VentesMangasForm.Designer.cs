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
            this.modeleMangaLabel = new System.Windows.Forms.Label();
            this.typesComboBox = new System.Windows.Forms.ComboBox();
            this.typesMangasLabel = new System.Windows.Forms.Label();
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
            this.titreLabel.Location = new System.Drawing.Point(298, 0);
            this.titreLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titreLabel.Name = "titreLabel";
            this.titreLabel.Size = new System.Drawing.Size(882, 108);
            this.titreLabel.TabIndex = 2;
            this.titreLabel.Text = "Ventes de Mangas";
            // 
            // clientGroupBox
            // 
            this.clientGroupBox.Controls.Add(this.modelesComboBox);
            this.clientGroupBox.Controls.Add(this.modeleMangaLabel);
            this.clientGroupBox.Controls.Add(this.typesComboBox);
            this.clientGroupBox.Controls.Add(this.typesMangasLabel);
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
            this.clientGroupBox.Location = new System.Drawing.Point(50, 489);
            this.clientGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.clientGroupBox.Name = "clientGroupBox";
            this.clientGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.clientGroupBox.Size = new System.Drawing.Size(759, 542);
            this.clientGroupBox.TabIndex = 24;
            this.clientGroupBox.TabStop = false;
            this.clientGroupBox.Text = "Client:";
            // 
            // modelesComboBox
            // 
            this.modelesComboBox.FormattingEnabled = true;
            this.modelesComboBox.Location = new System.Drawing.Point(260, 462);
            this.modelesComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.modelesComboBox.Name = "modelesComboBox";
            this.modelesComboBox.Size = new System.Drawing.Size(443, 32);
            this.modelesComboBox.TabIndex = 30;
            // 
            // modeleMangaLabel
            // 
            this.modeleMangaLabel.AutoSize = true;
            this.modeleMangaLabel.Location = new System.Drawing.Point(24, 311);
            this.modeleMangaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modeleMangaLabel.Name = "modeleMangaLabel";
            this.modeleMangaLabel.Size = new System.Drawing.Size(120, 16);
            this.modeleMangaLabel.TabIndex = 29;
            this.modeleMangaLabel.Text = "Modèle de manga:";
            // 
            // typesComboBox
            // 
            this.typesComboBox.FormattingEnabled = true;
            this.typesComboBox.Location = new System.Drawing.Point(263, 394);
            this.typesComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.typesComboBox.Name = "typesComboBox";
            this.typesComboBox.Size = new System.Drawing.Size(443, 32);
            this.typesComboBox.TabIndex = 28;
            // 
            // typesMangasLabel
            // 
            this.typesMangasLabel.AutoSize = true;
            this.typesMangasLabel.Location = new System.Drawing.Point(34, 400);
            this.typesMangasLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.typesMangasLabel.Name = "typesMangasLabel";
            this.typesMangasLabel.Size = new System.Drawing.Size(156, 25);
            this.typesMangasLabel.TabIndex = 27;
            this.typesMangasLabel.Text = "Type de Manga:";
            // 
            // telephoneMaskedTextBox
            // 
            this.telephoneMaskedTextBox.Location = new System.Drawing.Point(260, 327);
            this.telephoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.telephoneMaskedTextBox.Name = "telephoneMaskedTextBox";
            this.telephoneMaskedTextBox.Size = new System.Drawing.Size(444, 29);
            this.telephoneMaskedTextBox.TabIndex = 26;
            this.telephoneMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBox_Enter);
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(34, 333);
            this.telephoneLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(112, 25);
            this.telephoneLabel.TabIndex = 25;
            this.telephoneLabel.Text = "Téléphone:";
            // 
            // codePostalMaskedTextBox
            // 
            this.codePostalMaskedTextBox.Location = new System.Drawing.Point(260, 258);
            this.codePostalMaskedTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.codePostalMaskedTextBox.Name = "codePostalMaskedTextBox";
            this.codePostalMaskedTextBox.Size = new System.Drawing.Size(444, 29);
            this.codePostalMaskedTextBox.TabIndex = 24;
            this.codePostalMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBox_Enter);
            // 
            // adresseMaskedTextBox
            // 
            this.adresseMaskedTextBox.Location = new System.Drawing.Point(263, 190);
            this.adresseMaskedTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.adresseMaskedTextBox.Name = "adresseMaskedTextBox";
            this.adresseMaskedTextBox.Size = new System.Drawing.Size(444, 29);
            this.adresseMaskedTextBox.TabIndex = 23;
            this.adresseMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBox_Enter);
            // 
            // prenomMaskedTextBox
            // 
            this.prenomMaskedTextBox.Location = new System.Drawing.Point(263, 122);
            this.prenomMaskedTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.prenomMaskedTextBox.Name = "prenomMaskedTextBox";
            this.prenomMaskedTextBox.Size = new System.Drawing.Size(444, 29);
            this.prenomMaskedTextBox.TabIndex = 22;
            this.prenomMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBox_Enter);
            // 
            // nomMaskedTextBox
            // 
            this.nomMaskedTextBox.Location = new System.Drawing.Point(260, 54);
            this.nomMaskedTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nomMaskedTextBox.Name = "nomMaskedTextBox";
            this.nomMaskedTextBox.Size = new System.Drawing.Size(444, 29);
            this.nomMaskedTextBox.TabIndex = 21;
            this.nomMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBox_Enter);
            // 
            // codePostalLabel
            // 
            this.codePostalLabel.AutoSize = true;
            this.codePostalLabel.Location = new System.Drawing.Point(34, 264);
            this.codePostalLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.codePostalLabel.Name = "codePostalLabel";
            this.codePostalLabel.Size = new System.Drawing.Size(123, 25);
            this.codePostalLabel.TabIndex = 20;
            this.codePostalLabel.Text = "Code postal:";
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.Location = new System.Drawing.Point(34, 195);
            this.adresseLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Size = new System.Drawing.Size(91, 25);
            this.adresseLabel.TabIndex = 19;
            this.adresseLabel.Text = "Adresse:";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(34, 128);
            this.prenomLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(86, 25);
            this.prenomLabel.TabIndex = 18;
            this.prenomLabel.Text = "Prénom:";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(34, 58);
            this.nomLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(59, 25);
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
            this.transactionGroupBox.Location = new System.Drawing.Point(837, 489);
            this.transactionGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.transactionGroupBox.Name = "transactionGroupBox";
            this.transactionGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.transactionGroupBox.Size = new System.Drawing.Size(675, 363);
            this.transactionGroupBox.TabIndex = 25;
            this.transactionGroupBox.TabStop = false;
            this.transactionGroupBox.Text = "Transaction:";
            // 
            // dateLivraisonDateTimePicker
            // 
            this.dateLivraisonDateTimePicker.Location = new System.Drawing.Point(258, 58);
            this.dateLivraisonDateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.dateLivraisonDateTimePicker.Name = "dateLivraisonDateTimePicker";
            this.dateLivraisonDateTimePicker.Size = new System.Drawing.Size(363, 29);
            this.dateLivraisonDateTimePicker.TabIndex = 27;
            // 
            // dateLivraisonLabel
            // 
            this.dateLivraisonLabel.AutoSize = true;
            this.dateLivraisonLabel.Location = new System.Drawing.Point(50, 58);
            this.dateLivraisonLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dateLivraisonLabel.Name = "dateLivraisonLabel";
            this.dateLivraisonLabel.Size = new System.Drawing.Size(162, 25);
            this.dateLivraisonLabel.TabIndex = 26;
            this.dateLivraisonLabel.Text = "Date de livraison:";
            // 
            // prixLabel
            // 
            this.prixLabel.BackColor = System.Drawing.Color.White;
            this.prixLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prixLabel.Location = new System.Drawing.Point(258, 264);
            this.prixLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prixLabel.Name = "prixLabel";
            this.prixLabel.Size = new System.Drawing.Size(365, 41);
            this.prixLabel.TabIndex = 25;
            this.prixLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genreComboBox
            // 
            this.genreComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(258, 195);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(363, 32);
            this.genreComboBox.TabIndex = 24;
            this.genreComboBox.SelectedIndexChanged += new System.EventHandler(this.TransactionComboBox_SelectedIndexChanged);
            // 
            // titreComboBox
            // 
            this.titreComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.titreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titreComboBox.FormattingEnabled = true;
            this.titreComboBox.Location = new System.Drawing.Point(258, 128);
            this.titreComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.titreComboBox.Name = "titreComboBox";
            this.titreComboBox.Size = new System.Drawing.Size(363, 32);
            this.titreComboBox.TabIndex = 23;
            this.titreComboBox.SelectedIndexChanged += new System.EventHandler(this.TransactionComboBox_SelectedIndexChanged);
            // 
            // prixLLabel
            // 
            this.prixLLabel.AutoSize = true;
            this.prixLLabel.Location = new System.Drawing.Point(50, 273);
            this.prixLLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prixLLabel.Name = "prixLLabel";
            this.prixLLabel.Size = new System.Drawing.Size(51, 25);
            this.prixLLabel.TabIndex = 22;
            this.prixLLabel.Text = "Prix:";
            // 
            // genresLabel
            // 
            this.genresLabel.AutoSize = true;
            this.genresLabel.Location = new System.Drawing.Point(50, 201);
            this.genresLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(82, 25);
            this.genresLabel.TabIndex = 21;
            this.genresLabel.Text = "Genres:";
            // 
            // titresLabel
            // 
            this.titresLabel.AutoSize = true;
            this.titresLabel.Location = new System.Drawing.Point(50, 134);
            this.titresLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titresLabel.Name = "titresLabel";
            this.titresLabel.Size = new System.Drawing.Size(57, 25);
            this.titresLabel.TabIndex = 20;
            this.titresLabel.Text = "Titre:";
            // 
            // transactionsMenuStrip
            // 
            this.transactionsMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.transactionsMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.transactionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.transactionsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.transactionsMenuStrip.Name = "transactionsMenuStrip";
            this.transactionsMenuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.transactionsMenuStrip.Size = new System.Drawing.Size(1580, 40);
            this.transactionsMenuStrip.TabIndex = 26;
            this.transactionsMenuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(91, 34);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(314, 40);
            this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(314, 40);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aproposDeToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(73, 34);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // aproposDeToolStripMenuItem
            // 
            this.aproposDeToolStripMenuItem.Name = "aproposDeToolStripMenuItem";
            this.aproposDeToolStripMenuItem.Size = new System.Drawing.Size(259, 40);
            this.aproposDeToolStripMenuItem.Text = "À &propos de...";
            this.aproposDeToolStripMenuItem.Click += new System.EventHandler(this.aproposDeToolStripMenuItem_Click);
            // 
            // enregistrerButton
            // 
            this.enregistrerButton.BackColor = System.Drawing.Color.Green;
            this.enregistrerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enregistrerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrerButton.ForeColor = System.Drawing.Color.White;
            this.enregistrerButton.Location = new System.Drawing.Point(837, 890);
            this.enregistrerButton.Margin = new System.Windows.Forms.Padding(6);
            this.enregistrerButton.Name = "enregistrerButton";
            this.enregistrerButton.Size = new System.Drawing.Size(263, 98);
            this.enregistrerButton.TabIndex = 28;
            this.enregistrerButton.Text = "&Enregistrer";
            this.enregistrerButton.UseVisualStyleBackColor = false;
            this.enregistrerButton.Click += new System.EventHandler(this.enregistrerButton_Click);
            // 
            // quitterButton
            // 
            this.quitterButton.BackColor = System.Drawing.Color.Crimson;
            this.quitterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitterButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quitterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitterButton.ForeColor = System.Drawing.Color.White;
            this.quitterButton.Location = new System.Drawing.Point(1257, 890);
            this.quitterButton.Margin = new System.Windows.Forms.Padding(6);
            this.quitterButton.Name = "quitterButton";
            this.quitterButton.Size = new System.Drawing.Size(256, 98);
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
            this.logoPanel.Location = new System.Drawing.Point(50, 66);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(6);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(1463, 411);
            this.logoPanel.TabIndex = 30;
            // 
            // logoGauchePictureBox
            // 
            this.logoGauchePictureBox.Image = global::VentesMangas.Properties.Resources.mangas;
            this.logoGauchePictureBox.Location = new System.Drawing.Point(40, 171);
            this.logoGauchePictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.logoGauchePictureBox.Name = "logoGauchePictureBox";
            this.logoGauchePictureBox.Size = new System.Drawing.Size(337, 171);
            this.logoGauchePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoGauchePictureBox.TabIndex = 0;
            this.logoGauchePictureBox.TabStop = false;
            // 
            // mangasPictureBox
            // 
            this.mangasPictureBox.Image = global::VentesMangas.Properties.Resources.mangatitre;
            this.mangasPictureBox.Location = new System.Drawing.Point(424, 142);
            this.mangasPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.mangasPictureBox.Name = "mangasPictureBox";
            this.mangasPictureBox.Size = new System.Drawing.Size(656, 248);
            this.mangasPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mangasPictureBox.TabIndex = 1;
            this.mangasPictureBox.TabStop = false;
            // 
            // logoDroitPictureBox
            // 
            this.logoDroitPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.logoDroitPictureBox.Image = global::VentesMangas.Properties.Resources.mangas;
            this.logoDroitPictureBox.Location = new System.Drawing.Point(1118, 171);
            this.logoDroitPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.logoDroitPictureBox.Name = "logoDroitPictureBox";
            this.logoDroitPictureBox.Size = new System.Drawing.Size(323, 171);
            this.logoDroitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoDroitPictureBox.TabIndex = 27;
            this.logoDroitPictureBox.TabStop = false;
            // 
            // VentesMangasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.quitterButton;
            this.ClientSize = new System.Drawing.Size(1580, 1074);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.quitterButton);
            this.Controls.Add(this.enregistrerButton);
            this.Controls.Add(this.transactionsMenuStrip);
            this.Controls.Add(this.transactionGroupBox);
            this.Controls.Add(this.clientGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.Label typesMangasLabel;
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
        private System.Windows.Forms.Label modeleMangaLabel;
    }
}

