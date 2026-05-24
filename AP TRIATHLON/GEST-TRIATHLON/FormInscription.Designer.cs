namespace GEST_TRIATHLON
{
    partial class FormInscription
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
            this.LabelTriathlon = new System.Windows.Forms.Label();
            this.cb_Triathlon = new System.Windows.Forms.ComboBox();
            this.LabelNumDossard = new System.Windows.Forms.Label();
            this.tb_NumDossard = new System.Windows.Forms.TextBox();
            this.LabelDateInscription = new System.Windows.Forms.Label();
            this.dtp_DateInscription = new System.Windows.Forms.DateTimePicker();
            this.chk_Forfait = new System.Windows.Forms.CheckBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTriathlon
            // 
            this.LabelTriathlon.AutoSize = true;
            this.LabelTriathlon.Location = new System.Drawing.Point(12, 15);
            this.LabelTriathlon.Name = "LabelTriathlon";
            this.LabelTriathlon.Size = new System.Drawing.Size(56, 13);
            this.LabelTriathlon.TabIndex = 0;
            this.LabelTriathlon.Text = "Triathlon :";
            // 
            // cb_Triathlon
            // 
            this.cb_Triathlon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Triathlon.FormattingEnabled = true;
            this.cb_Triathlon.Location = new System.Drawing.Point(120, 12);
            this.cb_Triathlon.Name = "cb_Triathlon";
            this.cb_Triathlon.Size = new System.Drawing.Size(400, 21);
            this.cb_Triathlon.TabIndex = 1;
            this.cb_Triathlon.SelectedIndexChanged += new System.EventHandler(this.cb_Triathlon_SelectedIndexChanged);
            // 
            // LabelNumDossard
            // 
            this.LabelNumDossard.AutoSize = true;
            this.LabelNumDossard.Location = new System.Drawing.Point(12, 50);
            this.LabelNumDossard.Name = "LabelNumDossard";
            this.LabelNumDossard.Size = new System.Drawing.Size(74, 13);
            this.LabelNumDossard.TabIndex = 2;
            this.LabelNumDossard.Text = "N° Dossard :";
            // 
            // tb_NumDossard
            // 
            this.tb_NumDossard.Location = new System.Drawing.Point(120, 47);
            this.tb_NumDossard.Name = "tb_NumDossard";
            this.tb_NumDossard.ReadOnly = true;
            this.tb_NumDossard.Size = new System.Drawing.Size(100, 20);
            this.tb_NumDossard.TabIndex = 3;
            // 
            // LabelDateInscription
            // 
            this.LabelDateInscription.AutoSize = true;
            this.LabelDateInscription.Location = new System.Drawing.Point(12, 85);
            this.LabelDateInscription.Name = "LabelDateInscription";
            this.LabelDateInscription.Size = new System.Drawing.Size(98, 13);
            this.LabelDateInscription.TabIndex = 4;
            this.LabelDateInscription.Text = "Date d\'inscription :";
            // 
            // dtp_DateInscription
            // 
            this.dtp_DateInscription.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateInscription.Location = new System.Drawing.Point(120, 82);
            this.dtp_DateInscription.Name = "dtp_DateInscription";
            this.dtp_DateInscription.Size = new System.Drawing.Size(120, 20);
            this.dtp_DateInscription.TabIndex = 5;
            // 
            // chk_Forfait
            // 
            this.chk_Forfait.AutoSize = true;
            this.chk_Forfait.Location = new System.Drawing.Point(120, 120);
            this.chk_Forfait.Name = "chk_Forfait";
            this.chk_Forfait.Size = new System.Drawing.Size(56, 17);
            this.chk_Forfait.TabIndex = 6;
            this.chk_Forfait.Text = "Forfait";
            this.chk_Forfait.UseVisualStyleBackColor = true;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(15, 160);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(100, 30);
            this.btn_Valider.TabIndex = 7;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(130, 160);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(100, 30);
            this.btn_Annuler.TabIndex = 8;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(420, 160);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(100, 30);
            this.btn_Supprimer.TabIndex = 9;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // FormInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 201);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.chk_Forfait);
            this.Controls.Add(this.dtp_DateInscription);
            this.Controls.Add(this.LabelDateInscription);
            this.Controls.Add(this.tb_NumDossard);
            this.Controls.Add(this.LabelNumDossard);
            this.Controls.Add(this.cb_Triathlon);
            this.Controls.Add(this.LabelTriathlon);
            this.Name = "FormInscription";
            this.Text = "Inscription à un triathlon";
            this.Load += new System.EventHandler(this.FormInscription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LabelTriathlon;
        private System.Windows.Forms.ComboBox cb_Triathlon;
        private System.Windows.Forms.Label LabelNumDossard;
        private System.Windows.Forms.TextBox tb_NumDossard;
        private System.Windows.Forms.Label LabelDateInscription;
        private System.Windows.Forms.DateTimePicker dtp_DateInscription;
        private System.Windows.Forms.CheckBox chk_Forfait;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_Supprimer;
    }
}
