namespace GEST_TRIATHLON
{
    partial class FormListeTriathlon
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.triathlonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesTriathlonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesTriathletesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesInscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesÉpreuvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.résultatDesTriathlonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.résultatDesPrélevementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelLieu = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelEntre = new System.Windows.Forms.Label();
            this.LabelEt = new System.Windows.Forms.Label();
            this.btn_Filtrer = new System.Windows.Forms.Button();
            this.dgv_Liste = new System.Windows.Forms.DataGridView();
            this.cb_Lieu = new System.Windows.Forms.ComboBox();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.dtp_DateDebut = new System.Windows.Forms.DateTimePicker();
            this.dtp_DateFin = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Creation = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triathlonsToolStripMenuItem,
            this.resultatsToolStripMenuItem,
            this.diversToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // triathlonsToolStripMenuItem
            // 
            this.triathlonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesTriathlonsToolStripMenuItem,
            this.listeDesTriathletesToolStripMenuItem,
            this.listeDesInscriptionsToolStripMenuItem,
            this.listeDesÉpreuvesToolStripMenuItem});
            this.triathlonsToolStripMenuItem.Name = "triathlonsToolStripMenuItem";
            this.triathlonsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.triathlonsToolStripMenuItem.Text = "Triathlons";
            // 
            // listeDesTriathlonsToolStripMenuItem
            // 
            this.listeDesTriathlonsToolStripMenuItem.Name = "listeDesTriathlonsToolStripMenuItem";
            this.listeDesTriathlonsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.listeDesTriathlonsToolStripMenuItem.Text = "Liste des triathlons";
            // 
            // listeDesTriathletesToolStripMenuItem
            // 
            this.listeDesTriathletesToolStripMenuItem.Name = "listeDesTriathletesToolStripMenuItem";
            this.listeDesTriathletesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.listeDesTriathletesToolStripMenuItem.Text = "Liste des triathletes";
            // 
            // listeDesInscriptionsToolStripMenuItem
            // 
            this.listeDesInscriptionsToolStripMenuItem.Name = "listeDesInscriptionsToolStripMenuItem";
            this.listeDesInscriptionsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.listeDesInscriptionsToolStripMenuItem.Text = "Liste des inscriptions";
            // 
            // listeDesÉpreuvesToolStripMenuItem
            // 
            this.listeDesÉpreuvesToolStripMenuItem.Name = "listeDesÉpreuvesToolStripMenuItem";
            this.listeDesÉpreuvesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.listeDesÉpreuvesToolStripMenuItem.Text = "Liste des épreuves";
            // 
            // resultatsToolStripMenuItem
            // 
            this.resultatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.résultatDesTriathlonsToolStripMenuItem,
            this.résultatDesPrélevementsToolStripMenuItem});
            this.resultatsToolStripMenuItem.Name = "resultatsToolStripMenuItem";
            this.resultatsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.resultatsToolStripMenuItem.Text = "Resultats";
            // 
            // résultatDesTriathlonsToolStripMenuItem
            // 
            this.résultatDesTriathlonsToolStripMenuItem.Name = "résultatDesTriathlonsToolStripMenuItem";
            this.résultatDesTriathlonsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.résultatDesTriathlonsToolStripMenuItem.Text = "Résultat des triathlons";
            // 
            // résultatDesPrélevementsToolStripMenuItem
            // 
            this.résultatDesPrélevementsToolStripMenuItem.Name = "résultatDesPrélevementsToolStripMenuItem";
            this.résultatDesPrélevementsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.résultatDesPrélevementsToolStripMenuItem.Text = "Résultat des prélevements";
            // 
            // diversToolStripMenuItem
            // 
            this.diversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catégorieToolStripMenuItem,
            this.typesToolStripMenuItem});
            this.diversToolStripMenuItem.Name = "diversToolStripMenuItem";
            this.diversToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.diversToolStripMenuItem.Text = "Divers";
            // 
            // catégorieToolStripMenuItem
            // 
            this.catégorieToolStripMenuItem.Name = "catégorieToolStripMenuItem";
            this.catégorieToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.catégorieToolStripMenuItem.Text = "Catégorie";
            // 
            // typesToolStripMenuItem
            // 
            this.typesToolStripMenuItem.Name = "typesToolStripMenuItem";
            this.typesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.typesToolStripMenuItem.Text = "Types";
            // 
            // LabelLieu
            // 
            this.LabelLieu.AutoSize = true;
            this.LabelLieu.Location = new System.Drawing.Point(28, 42);
            this.LabelLieu.Name = "LabelLieu";
            this.LabelLieu.Size = new System.Drawing.Size(33, 13);
            this.LabelLieu.TabIndex = 2;
            this.LabelLieu.Text = "Lieu :";
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(28, 75);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(37, 13);
            this.LabelType.TabIndex = 3;
            this.LabelType.Text = "Type :";
            // 
            // LabelEntre
            // 
            this.LabelEntre.AutoSize = true;
            this.LabelEntre.Location = new System.Drawing.Point(314, 42);
            this.LabelEntre.Name = "LabelEntre";
            this.LabelEntre.Size = new System.Drawing.Size(32, 13);
            this.LabelEntre.TabIndex = 4;
            this.LabelEntre.Text = "Entre";
            // 
            // LabelEt
            // 
            this.LabelEt.AutoSize = true;
            this.LabelEt.Location = new System.Drawing.Point(613, 42);
            this.LabelEt.Name = "LabelEt";
            this.LabelEt.Size = new System.Drawing.Size(16, 13);
            this.LabelEt.TabIndex = 5;
            this.LabelEt.Text = "et";
            // 
            // btn_Filtrer
            // 
            this.btn_Filtrer.Location = new System.Drawing.Point(352, 70);
            this.btn_Filtrer.Name = "btn_Filtrer";
            this.btn_Filtrer.Size = new System.Drawing.Size(75, 23);
            this.btn_Filtrer.TabIndex = 6;
            this.btn_Filtrer.Text = "Filtrer";
            this.btn_Filtrer.UseVisualStyleBackColor = true;
            this.btn_Filtrer.Click += new System.EventHandler(this.btn_Filtrer_Click);
            // 
            // dgv_Liste
            // 
            this.dgv_Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Liste.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Liste.Location = new System.Drawing.Point(12, 113);
            this.dgv_Liste.Name = "dgv_Liste";
            this.dgv_Liste.Size = new System.Drawing.Size(926, 437);
            this.dgv_Liste.TabIndex = 7;
            this.dgv_Liste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Liste_CellContentClick);
            this.dgv_Liste.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Liste_CellDoubleClick);
            this.dgv_Liste.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_Liste_KeyDown);
            // 
            // cb_Lieu
            // 
            this.cb_Lieu.FormattingEnabled = true;
            this.cb_Lieu.Location = new System.Drawing.Point(69, 39);
            this.cb_Lieu.Name = "cb_Lieu";
            this.cb_Lieu.Size = new System.Drawing.Size(121, 21);
            this.cb_Lieu.TabIndex = 8;
            this.cb_Lieu.SelectedIndexChanged += new System.EventHandler(this.cb_Lieu_SelectedIndexChanged);
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Location = new System.Drawing.Point(69, 72);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(121, 21);
            this.cb_Type.TabIndex = 9;
            this.cb_Type.SelectedIndexChanged += new System.EventHandler(this.cb_Type_SelectedIndexChanged);
            // 
            // dtp_DateDebut
            // 
            this.dtp_DateDebut.Checked = false;
            this.dtp_DateDebut.Location = new System.Drawing.Point(352, 39);
            this.dtp_DateDebut.Name = "dtp_DateDebut";
            this.dtp_DateDebut.ShowCheckBox = true;
            this.dtp_DateDebut.Size = new System.Drawing.Size(255, 20);
            this.dtp_DateDebut.TabIndex = 10;
            // 
            // dtp_DateFin
            // 
            this.dtp_DateFin.Checked = false;
            this.dtp_DateFin.Location = new System.Drawing.Point(635, 39);
            this.dtp_DateFin.Name = "dtp_DateFin";
            this.dtp_DateFin.ShowCheckBox = true;
            this.dtp_DateFin.Size = new System.Drawing.Size(255, 20);
            this.dtp_DateFin.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reinitialiser les filtres";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Creation
            // 
            this.btn_Creation.Location = new System.Drawing.Point(766, 72);
            this.btn_Creation.Name = "btn_Creation";
            this.btn_Creation.Size = new System.Drawing.Size(124, 23);
            this.btn_Creation.TabIndex = 14;
            this.btn_Creation.Text = "Création d\'un triathlon";
            this.btn_Creation.UseVisualStyleBackColor = true;
            this.btn_Creation.Click += new System.EventHandler(this.btn_Creation_Click);
            // 
            // FormListeTriathlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 562);
            this.Controls.Add(this.btn_Creation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp_DateFin);
            this.Controls.Add(this.dtp_DateDebut);
            this.Controls.Add(this.cb_Type);
            this.Controls.Add(this.cb_Lieu);
            this.Controls.Add(this.dgv_Liste);
            this.Controls.Add(this.btn_Filtrer);
            this.Controls.Add(this.LabelEt);
            this.Controls.Add(this.LabelEntre);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.LabelLieu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormListeTriathlon";
            this.Text = "Liste des Triathlons";
            this.Load += new System.EventHandler(this.FormListeTriathlon_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem triathlonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesTriathlonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesTriathletesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesInscriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesÉpreuvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem résultatDesTriathlonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem résultatDesPrélevementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
        private System.Windows.Forms.Label LabelLieu;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelEntre;
        private System.Windows.Forms.Label LabelEt;
        private System.Windows.Forms.Button btn_Filtrer;
        private System.Windows.Forms.DataGridView dgv_Liste;
        private System.Windows.Forms.ComboBox cb_Lieu;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.DateTimePicker dtp_DateDebut;
        private System.Windows.Forms.DateTimePicker dtp_DateFin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Creation;
    }
}