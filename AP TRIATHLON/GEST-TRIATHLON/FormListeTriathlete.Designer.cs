namespace GEST_TRIATHLON
{
    partial class FormListeTriathlete
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
            this.dgv_Liste = new System.Windows.Forms.DataGridView();
            this.LabelNumLicence = new System.Windows.Forms.Label();
            this.tb_NumLicence = new System.Windows.Forms.TextBox();
            this.LabelNom = new System.Windows.Forms.Label();
            this.tb_Nom = new System.Windows.Forms.TextBox();
            this.LabelCategorie = new System.Windows.Forms.Label();
            this.cb_Categorie = new System.Windows.Forms.ComboBox();
            this.LabelSexe = new System.Windows.Forms.Label();
            this.cb_Sexe = new System.Windows.Forms.ComboBox();
            this.LabelAgeMin = new System.Windows.Forms.Label();
            this.tb_AgeMin = new System.Windows.Forms.TextBox();
            this.LabelAgeMax = new System.Windows.Forms.Label();
            this.tb_AgeMax = new System.Windows.Forms.TextBox();
            this.LabelTriathlon = new System.Windows.Forms.Label();
            this.cb_Triathlon = new System.Windows.Forms.ComboBox();
            this.btn_Filtrer = new System.Windows.Forms.Button();
            this.btn_Reinitialiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Liste
            // 
            this.dgv_Liste.AllowUserToAddRows = false;
            this.dgv_Liste.AllowUserToDeleteRows = false;
            this.dgv_Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Liste.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Liste.Location = new System.Drawing.Point(12, 120);
            this.dgv_Liste.Name = "dgv_Liste";
            this.dgv_Liste.ReadOnly = true;
            this.dgv_Liste.Size = new System.Drawing.Size(1160, 430);
            this.dgv_Liste.TabIndex = 0;
            this.dgv_Liste.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Liste_CellDoubleClick);
            this.dgv_Liste.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Liste_CellFormatting);
            // 
            // LabelNumLicence
            // 
            this.LabelNumLicence.AutoSize = true;
            this.LabelNumLicence.Location = new System.Drawing.Point(12, 15);
            this.LabelNumLicence.Name = "LabelNumLicence";
            this.LabelNumLicence.Size = new System.Drawing.Size(77, 13);
            this.LabelNumLicence.TabIndex = 1;
            this.LabelNumLicence.Text = "N° de licence :";
            // 
            // tb_NumLicence
            // 
            this.tb_NumLicence.Location = new System.Drawing.Point(101, 12);
            this.tb_NumLicence.Name = "tb_NumLicence";
            this.tb_NumLicence.Size = new System.Drawing.Size(100, 20);
            this.tb_NumLicence.TabIndex = 2;
            // 
            // LabelNom
            // 
            this.LabelNom.AutoSize = true;
            this.LabelNom.Location = new System.Drawing.Point(220, 15);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(35, 13);
            this.LabelNom.TabIndex = 3;
            this.LabelNom.Text = "Nom :";
            // 
            // tb_Nom
            // 
            this.tb_Nom.Location = new System.Drawing.Point(261, 12);
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(150, 20);
            this.tb_Nom.TabIndex = 4;
            // 
            // LabelCategorie
            // 
            this.LabelCategorie.AutoSize = true;
            this.LabelCategorie.Location = new System.Drawing.Point(12, 48);
            this.LabelCategorie.Name = "LabelCategorie";
            this.LabelCategorie.Size = new System.Drawing.Size(58, 13);
            this.LabelCategorie.TabIndex = 5;
            this.LabelCategorie.Text = "Catégorie :";
            // 
            // cb_Categorie
            // 
            this.cb_Categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Categorie.FormattingEnabled = true;
            this.cb_Categorie.Location = new System.Drawing.Point(101, 45);
            this.cb_Categorie.Name = "cb_Categorie";
            this.cb_Categorie.Size = new System.Drawing.Size(151, 21);
            this.cb_Categorie.TabIndex = 6;
            // 
            // LabelSexe
            // 
            this.LabelSexe.AutoSize = true;
            this.LabelSexe.Location = new System.Drawing.Point(270, 48);
            this.LabelSexe.Name = "LabelSexe";
            this.LabelSexe.Size = new System.Drawing.Size(37, 13);
            this.LabelSexe.TabIndex = 7;
            this.LabelSexe.Text = "Sexe :";
            // 
            // cb_Sexe
            // 
            this.cb_Sexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Sexe.FormattingEnabled = true;
            this.cb_Sexe.Items.AddRange(new object[] {
            "",
            "M",
            "F"});
            this.cb_Sexe.Location = new System.Drawing.Point(313, 45);
            this.cb_Sexe.Name = "cb_Sexe";
            this.cb_Sexe.Size = new System.Drawing.Size(80, 21);
            this.cb_Sexe.TabIndex = 8;
            // 
            // LabelAgeMin
            // 
            this.LabelAgeMin.AutoSize = true;
            this.LabelAgeMin.Location = new System.Drawing.Point(12, 81);
            this.LabelAgeMin.Name = "LabelAgeMin";
            this.LabelAgeMin.Size = new System.Drawing.Size(69, 13);
            this.LabelAgeMin.TabIndex = 9;
            this.LabelAgeMin.Text = "Âge minimal :";
            // 
            // tb_AgeMin
            // 
            this.tb_AgeMin.Location = new System.Drawing.Point(101, 78);
            this.tb_AgeMin.Name = "tb_AgeMin";
            this.tb_AgeMin.Size = new System.Drawing.Size(60, 20);
            this.tb_AgeMin.TabIndex = 10;
            // 
            // LabelAgeMax
            // 
            this.LabelAgeMax.AutoSize = true;
            this.LabelAgeMax.Location = new System.Drawing.Point(180, 81);
            this.LabelAgeMax.Name = "LabelAgeMax";
            this.LabelAgeMax.Size = new System.Drawing.Size(72, 13);
            this.LabelAgeMax.TabIndex = 11;
            this.LabelAgeMax.Text = "Âge maximal :";
            // 
            // tb_AgeMax
            // 
            this.tb_AgeMax.Location = new System.Drawing.Point(261, 78);
            this.tb_AgeMax.Name = "tb_AgeMax";
            this.tb_AgeMax.Size = new System.Drawing.Size(60, 20);
            this.tb_AgeMax.TabIndex = 12;
            // 
            // LabelTriathlon
            // 
            this.LabelTriathlon.AutoSize = true;
            this.LabelTriathlon.Location = new System.Drawing.Point(440, 15);
            this.LabelTriathlon.Name = "LabelTriathlon";
            this.LabelTriathlon.Size = new System.Drawing.Size(54, 13);
            this.LabelTriathlon.TabIndex = 13;
            this.LabelTriathlon.Text = "Triathlon :";
            // 
            // cb_Triathlon
            // 
            this.cb_Triathlon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Triathlon.FormattingEnabled = true;
            this.cb_Triathlon.Location = new System.Drawing.Point(502, 12);
            this.cb_Triathlon.Name = "cb_Triathlon";
            this.cb_Triathlon.Size = new System.Drawing.Size(350, 21);
            this.cb_Triathlon.TabIndex = 14;
            // 
            // btn_Filtrer
            // 
            this.btn_Filtrer.Location = new System.Drawing.Point(880, 10);
            this.btn_Filtrer.Name = "btn_Filtrer";
            this.btn_Filtrer.Size = new System.Drawing.Size(120, 25);
            this.btn_Filtrer.TabIndex = 15;
            this.btn_Filtrer.Text = "Filtrer";
            this.btn_Filtrer.UseVisualStyleBackColor = true;
            this.btn_Filtrer.Click += new System.EventHandler(this.btn_Filtrer_Click);
            // 
            // btn_Reinitialiser
            // 
            this.btn_Reinitialiser.Location = new System.Drawing.Point(1020, 10);
            this.btn_Reinitialiser.Name = "btn_Reinitialiser";
            this.btn_Reinitialiser.Size = new System.Drawing.Size(120, 25);
            this.btn_Reinitialiser.TabIndex = 16;
            this.btn_Reinitialiser.Text = "Réinitialiser";
            this.btn_Reinitialiser.UseVisualStyleBackColor = true;
            this.btn_Reinitialiser.Click += new System.EventHandler(this.btn_Reinitialiser_Click);
            // 
            // FormListeTriathlete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.btn_Reinitialiser);
            this.Controls.Add(this.btn_Filtrer);
            this.Controls.Add(this.cb_Triathlon);
            this.Controls.Add(this.LabelTriathlon);
            this.Controls.Add(this.tb_AgeMax);
            this.Controls.Add(this.LabelAgeMax);
            this.Controls.Add(this.tb_AgeMin);
            this.Controls.Add(this.LabelAgeMin);
            this.Controls.Add(this.cb_Sexe);
            this.Controls.Add(this.LabelSexe);
            this.Controls.Add(this.cb_Categorie);
            this.Controls.Add(this.LabelCategorie);
            this.Controls.Add(this.tb_Nom);
            this.Controls.Add(this.LabelNom);
            this.Controls.Add(this.tb_NumLicence);
            this.Controls.Add(this.LabelNumLicence);
            this.Controls.Add(this.dgv_Liste);
            this.Name = "FormListeTriathlete";
            this.Text = "Liste des Triathlètes";
            this.Load += new System.EventHandler(this.FormListeTriathlete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgv_Liste;
        private System.Windows.Forms.Label LabelNumLicence;
        private System.Windows.Forms.TextBox tb_NumLicence;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.TextBox tb_Nom;
        private System.Windows.Forms.Label LabelCategorie;
        private System.Windows.Forms.ComboBox cb_Categorie;
        private System.Windows.Forms.Label LabelSexe;
        private System.Windows.Forms.ComboBox cb_Sexe;
        private System.Windows.Forms.Label LabelAgeMin;
        private System.Windows.Forms.TextBox tb_AgeMin;
        private System.Windows.Forms.Label LabelAgeMax;
        private System.Windows.Forms.TextBox tb_AgeMax;
        private System.Windows.Forms.Label LabelTriathlon;
        private System.Windows.Forms.ComboBox cb_Triathlon;
        private System.Windows.Forms.Button btn_Filtrer;
        private System.Windows.Forms.Button btn_Reinitialiser;
    }
}
