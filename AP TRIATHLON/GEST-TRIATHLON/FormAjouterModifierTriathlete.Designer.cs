namespace GEST_TRIATHLON
{
    partial class FormAjouterModifierTriathlete
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.LabelNumLicence = new System.Windows.Forms.Label();
            this.tb_NumLicence = new System.Windows.Forms.TextBox();
            this.LabelNom = new System.Windows.Forms.Label();
            this.tb_Nom = new System.Windows.Forms.TextBox();
            this.LabelPrenom = new System.Windows.Forms.Label();
            this.tb_Prenom = new System.Windows.Forms.TextBox();
            this.LabelSexe = new System.Windows.Forms.Label();
            this.cb_Sexe = new System.Windows.Forms.ComboBox();
            this.LabelAdresseRue = new System.Windows.Forms.Label();
            this.tb_AdresseRue = new System.Windows.Forms.TextBox();
            this.LabelAdresseCP = new System.Windows.Forms.Label();
            this.tb_AdresseCP = new System.Windows.Forms.TextBox();
            this.LabelAdresseVille = new System.Windows.Forms.Label();
            this.tb_AdresseVille = new System.Windows.Forms.TextBox();
            this.LabelDateNaissance = new System.Windows.Forms.Label();
            this.dtp_DateNaissance = new System.Windows.Forms.DateTimePicker();
            this.LabelCategorie = new System.Windows.Forms.Label();
            this.cb_Categorie = new System.Windows.Forms.ComboBox();
            this.LabelInscriptions = new System.Windows.Forms.Label();
            this.dgv_Inscriptions = new System.Windows.Forms.DataGridView();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_NouvelleInscription = new System.Windows.Forms.Button();
            this.btn_ReinitialiserMdp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inscriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNumLicence
            // 
            this.LabelNumLicence.AutoSize = true;
            this.LabelNumLicence.Location = new System.Drawing.Point(12, 15);
            this.LabelNumLicence.Name = "LabelNumLicence";
            this.LabelNumLicence.Size = new System.Drawing.Size(83, 13);
            this.LabelNumLicence.TabIndex = 0;
            this.LabelNumLicence.Text = "N° de licence :";
            // 
            // tb_NumLicence
            // 
            this.tb_NumLicence.Location = new System.Drawing.Point(120, 12);
            this.tb_NumLicence.Name = "tb_NumLicence";
            this.tb_NumLicence.ReadOnly = true;
            this.tb_NumLicence.Size = new System.Drawing.Size(100, 20);
            this.tb_NumLicence.TabIndex = 1;
            // 
            // LabelNom
            // 
            this.LabelNom.AutoSize = true;
            this.LabelNom.Location = new System.Drawing.Point(12, 45);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(35, 13);
            this.LabelNom.TabIndex = 2;
            this.LabelNom.Text = "Nom :";
            // 
            // tb_Nom
            // 
            this.tb_Nom.Location = new System.Drawing.Point(120, 42);
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(200, 20);
            this.tb_Nom.TabIndex = 3;
            // 
            // LabelPrenom
            // 
            this.LabelPrenom.AutoSize = true;
            this.LabelPrenom.Location = new System.Drawing.Point(350, 45);
            this.LabelPrenom.Name = "LabelPrenom";
            this.LabelPrenom.Size = new System.Drawing.Size(49, 13);
            this.LabelPrenom.TabIndex = 4;
            this.LabelPrenom.Text = "Prénom :";
            // 
            // tb_Prenom
            // 
            this.tb_Prenom.Location = new System.Drawing.Point(420, 42);
            this.tb_Prenom.Name = "tb_Prenom";
            this.tb_Prenom.Size = new System.Drawing.Size(200, 20);
            this.tb_Prenom.TabIndex = 5;
            // 
            // LabelSexe
            // 
            this.LabelSexe.AutoSize = true;
            this.LabelSexe.Location = new System.Drawing.Point(12, 75);
            this.LabelSexe.Name = "LabelSexe";
            this.LabelSexe.Size = new System.Drawing.Size(37, 13);
            this.LabelSexe.TabIndex = 6;
            this.LabelSexe.Text = "Sexe :";
            // 
            // cb_Sexe
            // 
            this.cb_Sexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Sexe.FormattingEnabled = true;
            this.cb_Sexe.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cb_Sexe.Location = new System.Drawing.Point(120, 72);
            this.cb_Sexe.Name = "cb_Sexe";
            this.cb_Sexe.Size = new System.Drawing.Size(80, 21);
            this.cb_Sexe.TabIndex = 7;
            // 
            // LabelAdresseRue
            // 
            this.LabelAdresseRue.AutoSize = true;
            this.LabelAdresseRue.Location = new System.Drawing.Point(12, 105);
            this.LabelAdresseRue.Name = "LabelAdresseRue";
            this.LabelAdresseRue.Size = new System.Drawing.Size(36, 13);
            this.LabelAdresseRue.TabIndex = 8;
            this.LabelAdresseRue.Text = "Rue :";
            // 
            // tb_AdresseRue
            // 
            this.tb_AdresseRue.Location = new System.Drawing.Point(120, 102);
            this.tb_AdresseRue.Name = "tb_AdresseRue";
            this.tb_AdresseRue.Size = new System.Drawing.Size(500, 20);
            this.tb_AdresseRue.TabIndex = 9;
            // 
            // LabelAdresseCP
            // 
            this.LabelAdresseCP.AutoSize = true;
            this.LabelAdresseCP.Location = new System.Drawing.Point(12, 135);
            this.LabelAdresseCP.Name = "LabelAdresseCP";
            this.LabelAdresseCP.Size = new System.Drawing.Size(80, 13);
            this.LabelAdresseCP.TabIndex = 10;
            this.LabelAdresseCP.Text = "Code Postal :";
            // 
            // tb_AdresseCP
            // 
            this.tb_AdresseCP.Location = new System.Drawing.Point(120, 132);
            this.tb_AdresseCP.Name = "tb_AdresseCP";
            this.tb_AdresseCP.Size = new System.Drawing.Size(100, 20);
            this.tb_AdresseCP.TabIndex = 11;
            // 
            // LabelAdresseVille
            // 
            this.LabelAdresseVille.AutoSize = true;
            this.LabelAdresseVille.Location = new System.Drawing.Point(250, 135);
            this.LabelAdresseVille.Name = "LabelAdresseVille";
            this.LabelAdresseVille.Size = new System.Drawing.Size(32, 13);
            this.LabelAdresseVille.TabIndex = 12;
            this.LabelAdresseVille.Text = "Ville :";
            // 
            // tb_AdresseVille
            // 
            this.tb_AdresseVille.Location = new System.Drawing.Point(320, 132);
            this.tb_AdresseVille.Name = "tb_AdresseVille";
            this.tb_AdresseVille.Size = new System.Drawing.Size(300, 20);
            this.tb_AdresseVille.TabIndex = 13;
            // 
            // LabelDateNaissance
            // 
            this.LabelDateNaissance.AutoSize = true;
            this.LabelDateNaissance.Location = new System.Drawing.Point(12, 165);
            this.LabelDateNaissance.Name = "LabelDateNaissance";
            this.LabelDateNaissance.Size = new System.Drawing.Size(102, 13);
            this.LabelDateNaissance.TabIndex = 14;
            this.LabelDateNaissance.Text = "Date de naissance :";
            // 
            // dtp_DateNaissance
            // 
            this.dtp_DateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateNaissance.Location = new System.Drawing.Point(120, 162);
            this.dtp_DateNaissance.Name = "dtp_DateNaissance";
            this.dtp_DateNaissance.Size = new System.Drawing.Size(120, 20);
            this.dtp_DateNaissance.TabIndex = 15;
            // 
            // LabelCategorie
            // 
            this.LabelCategorie.AutoSize = true;
            this.LabelCategorie.Location = new System.Drawing.Point(280, 165);
            this.LabelCategorie.Name = "LabelCategorie";
            this.LabelCategorie.Size = new System.Drawing.Size(58, 13);
            this.LabelCategorie.TabIndex = 16;
            this.LabelCategorie.Text = "Catégorie :";
            // 
            // cb_Categorie
            // 
            this.cb_Categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Categorie.FormattingEnabled = true;
            this.cb_Categorie.Location = new System.Drawing.Point(370, 162);
            this.cb_Categorie.Name = "cb_Categorie";
            this.cb_Categorie.Size = new System.Drawing.Size(250, 21);
            this.cb_Categorie.TabIndex = 17;
            // 
            // LabelInscriptions
            // 
            this.LabelInscriptions.AutoSize = true;
            this.LabelInscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInscriptions.Location = new System.Drawing.Point(12, 200);
            this.LabelInscriptions.Name = "LabelInscriptions";
            this.LabelInscriptions.Size = new System.Drawing.Size(83, 15);
            this.LabelInscriptions.TabIndex = 18;
            this.LabelInscriptions.Text = "Inscriptions";
            // 
            // dgv_Inscriptions
            // 
            this.dgv_Inscriptions.AllowUserToAddRows = false;
            this.dgv_Inscriptions.AllowUserToDeleteRows = false;
            this.dgv_Inscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inscriptions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Inscriptions.Location = new System.Drawing.Point(15, 220);
            this.dgv_Inscriptions.Name = "dgv_Inscriptions";
            this.dgv_Inscriptions.ReadOnly = true;
            this.dgv_Inscriptions.Size = new System.Drawing.Size(705, 200);
            this.dgv_Inscriptions.TabIndex = 19;
            this.dgv_Inscriptions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Inscriptions_CellDoubleClick);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(15, 440);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(100, 30);
            this.btn_Valider.TabIndex = 20;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(130, 440);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(100, 30);
            this.btn_Annuler.TabIndex = 21;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(245, 440);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(100, 30);
            this.btn_Supprimer.TabIndex = 22;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_NouvelleInscription
            // 
            this.btn_NouvelleInscription.Location = new System.Drawing.Point(450, 440);
            this.btn_NouvelleInscription.Name = "btn_NouvelleInscription";
            this.btn_NouvelleInscription.Size = new System.Drawing.Size(130, 30);
            this.btn_NouvelleInscription.TabIndex = 23;
            this.btn_NouvelleInscription.Text = "Nouvelle Inscription";
            this.btn_NouvelleInscription.UseVisualStyleBackColor = true;
            this.btn_NouvelleInscription.Click += new System.EventHandler(this.btn_NouvelleInscription_Click);
            // 
            // btn_ReinitialiserMdp
            // 
            this.btn_ReinitialiserMdp.Location = new System.Drawing.Point(590, 440);
            this.btn_ReinitialiserMdp.Name = "btn_ReinitialiserMdp";
            this.btn_ReinitialiserMdp.Size = new System.Drawing.Size(130, 30);
            this.btn_ReinitialiserMdp.TabIndex = 24;
            this.btn_ReinitialiserMdp.Text = "Réinitialiser mot de passe";
            this.btn_ReinitialiserMdp.UseVisualStyleBackColor = true;
            this.btn_ReinitialiserMdp.Click += new System.EventHandler(this.btn_ReinitialiserMdp_Click);
            // 
            // FormMiseAJourTriathlete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 481);
            this.Controls.Add(this.btn_ReinitialiserMdp);
            this.Controls.Add(this.btn_NouvelleInscription);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.dgv_Inscriptions);
            this.Controls.Add(this.LabelInscriptions);
            this.Controls.Add(this.cb_Categorie);
            this.Controls.Add(this.LabelCategorie);
            this.Controls.Add(this.dtp_DateNaissance);
            this.Controls.Add(this.LabelDateNaissance);
            this.Controls.Add(this.tb_AdresseVille);
            this.Controls.Add(this.LabelAdresseVille);
            this.Controls.Add(this.tb_AdresseCP);
            this.Controls.Add(this.LabelAdresseCP);
            this.Controls.Add(this.tb_AdresseRue);
            this.Controls.Add(this.LabelAdresseRue);
            this.Controls.Add(this.cb_Sexe);
            this.Controls.Add(this.LabelSexe);
            this.Controls.Add(this.tb_Prenom);
            this.Controls.Add(this.LabelPrenom);
            this.Controls.Add(this.tb_Nom);
            this.Controls.Add(this.LabelNom);
            this.Controls.Add(this.tb_NumLicence);
            this.Controls.Add(this.LabelNumLicence);
            this.Name = "FormMiseAJourTriathlete";
            this.Text = "Mise à jour d\'un triathlète";
            this.Load += new System.EventHandler(this.FormMiseAJourTriathlete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inscriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LabelNumLicence;
        private System.Windows.Forms.TextBox tb_NumLicence;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.TextBox tb_Nom;
        private System.Windows.Forms.Label LabelPrenom;
        private System.Windows.Forms.TextBox tb_Prenom;
        private System.Windows.Forms.Label LabelSexe;
        private System.Windows.Forms.ComboBox cb_Sexe;
        private System.Windows.Forms.Label LabelAdresseRue;
        private System.Windows.Forms.TextBox tb_AdresseRue;
        private System.Windows.Forms.Label LabelAdresseCP;
        private System.Windows.Forms.TextBox tb_AdresseCP;
        private System.Windows.Forms.Label LabelAdresseVille;
        private System.Windows.Forms.TextBox tb_AdresseVille;
        private System.Windows.Forms.Label LabelDateNaissance;
        private System.Windows.Forms.DateTimePicker dtp_DateNaissance;
        private System.Windows.Forms.Label LabelCategorie;
        private System.Windows.Forms.ComboBox cb_Categorie;
        private System.Windows.Forms.Label LabelInscriptions;
        private System.Windows.Forms.DataGridView dgv_Inscriptions;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_NouvelleInscription;
        private System.Windows.Forms.Button btn_ReinitialiserMdp;
    }
}
