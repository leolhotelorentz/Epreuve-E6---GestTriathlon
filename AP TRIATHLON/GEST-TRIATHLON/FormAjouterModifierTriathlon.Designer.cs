namespace GEST_TRIATHLON
{
    partial class FormAjouterModifierTriathlon
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
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.cb_Lieu = new System.Windows.Forms.ComboBox();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelLieu = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.LabelDate = new System.Windows.Forms.Label();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.LabelId = new System.Windows.Forms.Label();
            this.LabelNom = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_Nom = new System.Windows.Forms.TextBox();
            this.LabelEpreuveNatation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TemperatureNatation = new System.Windows.Forms.TextBox();
            this.tb_LongitudeNatation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelLongitude = new System.Windows.Forms.Label();
            this.tb_LatitudeNatation = new System.Windows.Forms.TextBox();
            this.LabelLatitude = new System.Windows.Forms.Label();
            this.tb_DenivelePlusCourseAPied = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_DeniveleMoinsCourseAPied = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Pente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_LatitudeCourseAPied = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_LongitudeCourseAPied = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_LatitudeCyclisme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_LongitudeCyclisme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_DeniveleMoinsCyclisme = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_DenivelePlusCyclisme = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Location = new System.Drawing.Point(66, 67);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(149, 21);
            this.cb_Type.TabIndex = 13;
            // 
            // cb_Lieu
            // 
            this.cb_Lieu.FormattingEnabled = true;
            this.cb_Lieu.Location = new System.Drawing.Point(66, 96);
            this.cb_Lieu.Name = "cb_Lieu";
            this.cb_Lieu.Size = new System.Drawing.Size(149, 21);
            this.cb_Lieu.TabIndex = 12;
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(12, 70);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(37, 13);
            this.LabelType.TabIndex = 11;
            this.LabelType.Text = "Type :";
            // 
            // LabelLieu
            // 
            this.LabelLieu.AutoSize = true;
            this.LabelLieu.Location = new System.Drawing.Point(12, 99);
            this.LabelLieu.Name = "LabelLieu";
            this.LabelLieu.Size = new System.Drawing.Size(33, 13);
            this.LabelLieu.TabIndex = 10;
            this.LabelLieu.Text = "Lieu :";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Checked = false;
            this.dtp_Date.Location = new System.Drawing.Point(66, 123);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(194, 20);
            this.dtp_Date.TabIndex = 15;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(12, 129);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(36, 13);
            this.LabelDate.TabIndex = 14;
            this.LabelDate.Text = "Date :";
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(30, 242);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 16;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(125, 242);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuler.TabIndex = 17;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(220, 242);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_Supprimer.TabIndex = 18;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(12, 18);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(25, 13);
            this.LabelId.TabIndex = 18;
            this.LabelId.Text = "Id : ";
            // 
            // LabelNom
            // 
            this.LabelNom.AutoSize = true;
            this.LabelNom.Location = new System.Drawing.Point(12, 44);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(35, 13);
            this.LabelNom.TabIndex = 20;
            this.LabelNom.Text = "Nom :";
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(66, 15);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(100, 20);
            this.tb_Id.TabIndex = 22;
            // 
            // tb_Nom
            // 
            this.tb_Nom.Location = new System.Drawing.Point(66, 41);
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(300, 20);
            this.tb_Nom.TabIndex = 23;
            // 
            // LabelEpreuveNatation
            // 
            this.LabelEpreuveNatation.AutoSize = true;
            this.LabelEpreuveNatation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEpreuveNatation.Location = new System.Drawing.Point(421, 15);
            this.LabelEpreuveNatation.Name = "LabelEpreuveNatation";
            this.LabelEpreuveNatation.Size = new System.Drawing.Size(122, 13);
            this.LabelEpreuveNatation.TabIndex = 24;
            this.LabelEpreuveNatation.Text = "Epreuve de natation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Epreuve de course a pied";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Epreuve de cyclisme";
            // 
            // tb_TemperatureNatation
            // 
            this.tb_TemperatureNatation.Location = new System.Drawing.Point(494, 65);
            this.tb_TemperatureNatation.Name = "tb_TemperatureNatation";
            this.tb_TemperatureNatation.Size = new System.Drawing.Size(46, 20);
            this.tb_TemperatureNatation.TabIndex = 30;
            // 
            // tb_LongitudeNatation
            // 
            this.tb_LongitudeNatation.Location = new System.Drawing.Point(487, 38);
            this.tb_LongitudeNatation.Name = "tb_LongitudeNatation";
            this.tb_LongitudeNatation.Size = new System.Drawing.Size(108, 20);
            this.tb_LongitudeNatation.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Température :";
            // 
            // LabelLongitude
            // 
            this.LabelLongitude.AutoSize = true;
            this.LabelLongitude.Location = new System.Drawing.Point(421, 41);
            this.LabelLongitude.Name = "LabelLongitude";
            this.LabelLongitude.Size = new System.Drawing.Size(60, 13);
            this.LabelLongitude.TabIndex = 27;
            this.LabelLongitude.Text = "Longitude :";
            // 
            // tb_LatitudeNatation
            // 
            this.tb_LatitudeNatation.Location = new System.Drawing.Point(659, 38);
            this.tb_LatitudeNatation.Name = "tb_LatitudeNatation";
            this.tb_LatitudeNatation.Size = new System.Drawing.Size(108, 20);
            this.tb_LatitudeNatation.TabIndex = 32;
            // 
            // LabelLatitude
            // 
            this.LabelLatitude.AutoSize = true;
            this.LabelLatitude.Location = new System.Drawing.Point(605, 41);
            this.LabelLatitude.Name = "LabelLatitude";
            this.LabelLatitude.Size = new System.Drawing.Size(51, 13);
            this.LabelLatitude.TabIndex = 31;
            this.LabelLatitude.Text = "Latitude :";
            // 
            // tb_DenivelePlusCourseAPied
            // 
            this.tb_DenivelePlusCourseAPied.Location = new System.Drawing.Point(487, 153);
            this.tb_DenivelePlusCourseAPied.Name = "tb_DenivelePlusCourseAPied";
            this.tb_DenivelePlusCourseAPied.Size = new System.Drawing.Size(75, 20);
            this.tb_DenivelePlusCourseAPied.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Dénivelé + :";
            // 
            // tb_DeniveleMoinsCourseAPied
            // 
            this.tb_DeniveleMoinsCourseAPied.Location = new System.Drawing.Point(672, 157);
            this.tb_DeniveleMoinsCourseAPied.Name = "tb_DeniveleMoinsCourseAPied";
            this.tb_DeniveleMoinsCourseAPied.Size = new System.Drawing.Size(73, 20);
            this.tb_DeniveleMoinsCourseAPied.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(608, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Dénivelé - :";
            // 
            // tb_Pente
            // 
            this.tb_Pente.Location = new System.Drawing.Point(487, 271);
            this.tb_Pente.Name = "tb_Pente";
            this.tb_Pente.Size = new System.Drawing.Size(75, 20);
            this.tb_Pente.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(421, 272);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Pente :";
            // 
            // tb_LatitudeCourseAPied
            // 
            this.tb_LatitudeCourseAPied.Location = new System.Drawing.Point(659, 127);
            this.tb_LatitudeCourseAPied.Name = "tb_LatitudeCourseAPied";
            this.tb_LatitudeCourseAPied.Size = new System.Drawing.Size(108, 20);
            this.tb_LatitudeCourseAPied.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Latitude :";
            // 
            // tb_LongitudeCourseAPied
            // 
            this.tb_LongitudeCourseAPied.Location = new System.Drawing.Point(487, 127);
            this.tb_LongitudeCourseAPied.Name = "tb_LongitudeCourseAPied";
            this.tb_LongitudeCourseAPied.Size = new System.Drawing.Size(108, 20);
            this.tb_LongitudeCourseAPied.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Longitude :";
            // 
            // tb_LatitudeCyclisme
            // 
            this.tb_LatitudeCyclisme.Location = new System.Drawing.Point(662, 218);
            this.tb_LatitudeCyclisme.Name = "tb_LatitudeCyclisme";
            this.tb_LatitudeCyclisme.Size = new System.Drawing.Size(108, 20);
            this.tb_LatitudeCyclisme.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(605, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Latitude :";
            // 
            // tb_LongitudeCyclisme
            // 
            this.tb_LongitudeCyclisme.Location = new System.Drawing.Point(487, 219);
            this.tb_LongitudeCyclisme.Name = "tb_LongitudeCyclisme";
            this.tb_LongitudeCyclisme.Size = new System.Drawing.Size(108, 20);
            this.tb_LongitudeCyclisme.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Longitude :";
            // 
            // tb_DeniveleMoinsCyclisme
            // 
            this.tb_DeniveleMoinsCyclisme.Location = new System.Drawing.Point(672, 244);
            this.tb_DeniveleMoinsCyclisme.Name = "tb_DeniveleMoinsCyclisme";
            this.tb_DeniveleMoinsCyclisme.Size = new System.Drawing.Size(73, 20);
            this.tb_DeniveleMoinsCyclisme.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(605, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Dénivelé - :";
            // 
            // tb_DenivelePlusCyclisme
            // 
            this.tb_DenivelePlusCyclisme.Location = new System.Drawing.Point(487, 245);
            this.tb_DenivelePlusCyclisme.Name = "tb_DenivelePlusCyclisme";
            this.tb_DenivelePlusCyclisme.Size = new System.Drawing.Size(75, 20);
            this.tb_DenivelePlusCyclisme.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(421, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Dénivelé + :";
            // 
            // FormAjouterModifierTriathlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.tb_LatitudeCyclisme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_LongitudeCyclisme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_DeniveleMoinsCyclisme);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_DenivelePlusCyclisme);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_LatitudeCourseAPied);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_LongitudeCourseAPied);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Pente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_DeniveleMoinsCourseAPied);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_DenivelePlusCourseAPied);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_LatitudeNatation);
            this.Controls.Add(this.LabelLatitude);
            this.Controls.Add(this.tb_TemperatureNatation);
            this.Controls.Add(this.tb_LongitudeNatation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelLongitude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelEpreuveNatation);
            this.Controls.Add(this.tb_Nom);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.LabelNom);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.cb_Type);
            this.Controls.Add(this.cb_Lieu);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.LabelLieu);
            this.Name = "FormAjouterModifierTriathlon";
            this.Text = "Ajouter ou modifier un triathlon";
            this.Load += new System.EventHandler(this.FormAjouterModifierTriathlon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.ComboBox cb_Lieu;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelLieu;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tb_Nom;
        private System.Windows.Forms.Label LabelEpreuveNatation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TemperatureNatation;
        private System.Windows.Forms.TextBox tb_LongitudeNatation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelLongitude;
        private System.Windows.Forms.TextBox tb_LatitudeNatation;
        private System.Windows.Forms.Label LabelLatitude;
        private System.Windows.Forms.TextBox tb_DenivelePlusCourseAPied;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_DeniveleMoinsCourseAPied;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Pente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_LatitudeCourseAPied;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_LongitudeCourseAPied;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_LatitudeCyclisme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_LongitudeCyclisme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_DeniveleMoinsCyclisme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_DenivelePlusCyclisme;
        private System.Windows.Forms.Label label11;
    }
}