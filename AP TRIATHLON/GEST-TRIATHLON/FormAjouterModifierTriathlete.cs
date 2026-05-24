using BLL;
using BLL;
using DAL;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GEST_TRIATHLON
{
    public partial class FormAjouterModifierTriathlete : Form
    {
        private Triathlete triathlete;

        public FormAjouterModifierTriathlete(Triathlete triathlete)
        {
            InitializeComponent();
            this.triathlete = triathlete;
        }

        private void FormMiseAJourTriathlete_Load(object sender, EventArgs e)
        {
            ChargerCategories();
            RemplirChamps();
            ChargerInscriptions();
        }

        private void ChargerCategories()
        {
            var categories = CategorieDAO.GetToutesLesCategories();
            cb_Categorie.DataSource = categories;
            cb_Categorie.DisplayMember = "Libelle";
            cb_Categorie.ValueMember = "CodeCategorie";
        }

        private void RemplirChamps()
        {
            tb_NumLicence.Text = triathlete.NumLicence.ToString();
            tb_Nom.Text = triathlete.Nom;
            tb_Prenom.Text = triathlete.Prenom;
            cb_Sexe.SelectedItem = triathlete.Sexe.ToString();
            tb_AdresseRue.Text = triathlete.AdresseRue;
            tb_AdresseCP.Text = triathlete.AdresseCP;
            tb_AdresseVille.Text = triathlete.AdresseVille;
            dtp_DateNaissance.Value = triathlete.DateNaissance;
            cb_Categorie.SelectedValue = triathlete.CodeCategorie;
        }

        private void ChargerInscriptions()
        {
            var inscriptions = InscriptionDAO.GetInscriptionsParNumLicence(triathlete.NumLicence);
            dgv_Inscriptions.DataSource = inscriptions;

            if (dgv_Inscriptions.Columns["NumLicence"] != null)
                dgv_Inscriptions.Columns["NumLicence"].Visible = false;

            ConfigurerColonnesInscriptions();
        }

        private void ConfigurerColonnesInscriptions()
        {
            if (dgv_Inscriptions.Columns["IdTriathlon"] != null)
                dgv_Inscriptions.Columns["IdTriathlon"].HeaderText = "ID Triathlon";

            if (dgv_Inscriptions.Columns["NumDossard"] != null)
                dgv_Inscriptions.Columns["NumDossard"].HeaderText = "N° Dossard";

            if (dgv_Inscriptions.Columns["DateInscription"] != null)
            {
                dgv_Inscriptions.Columns["DateInscription"].HeaderText = "Date Inscription";
                dgv_Inscriptions.Columns["DateInscription"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgv_Inscriptions.Columns["NomTriathlon"] != null)
                dgv_Inscriptions.Columns["NomTriathlon"].HeaderText = "Nom Triathlon";

            if (dgv_Inscriptions.Columns["DateTriathlon"] != null)
            {
                dgv_Inscriptions.Columns["DateTriathlon"].HeaderText = "Date Triathlon";
                dgv_Inscriptions.Columns["DateTriathlon"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgv_Inscriptions.Columns["LieuTriathlon"] != null)
                dgv_Inscriptions.Columns["LieuTriathlon"].HeaderText = "Lieu";

            dgv_Inscriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            if (!ValiderSaisie())
                return;

            try
            {
                triathlete.Nom = tb_Nom.Text.Trim();
                triathlete.Prenom = tb_Prenom.Text.Trim();
                triathlete.Sexe = cb_Sexe.SelectedItem.ToString()[0];
                triathlete.AdresseRue = tb_AdresseRue.Text.Trim();
                triathlete.AdresseCP = tb_AdresseCP.Text.Trim();
                triathlete.AdresseVille = tb_AdresseVille.Text.Trim();
                triathlete.DateNaissance = dtp_DateNaissance.Value.Date;
                triathlete.CodeCategorie = (int)cb_Categorie.SelectedValue;

                int result = TriathleteDAO.ModifierTriathlete(triathlete);

                if (result > 0)
                {
                    MessageBox.Show("Triathlète modifié avec succès !", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification du triathlète.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValiderSaisie()
        {
            if (string.IsNullOrWhiteSpace(tb_Nom.Text))
            {
                MessageBox.Show("Veuillez saisir un nom.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Nom.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tb_Prenom.Text))
            {
                MessageBox.Show("Veuillez saisir un prénom.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Prenom.Focus();
                return false;
            }

            if (cb_Sexe.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un sexe.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_Sexe.Focus();
                return false;
            }

            if (cb_Categorie.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_Categorie.Focus();
                return false;
            }

            return true;
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dgv_Inscriptions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var inscription = (Inscription)dgv_Inscriptions.Rows[e.RowIndex].DataBoundItem;
                FormInscription frm = new FormInscription(inscription);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ChargerInscriptions();
                }
            }
        }

        private void btn_NouvelleInscription_Click(object sender, EventArgs e)
        {
            FormInscription frm = new FormInscription(triathlete.NumLicence);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ChargerInscriptions();
            }
        }

        private void btn_ReinitialiserMdp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Voulez-vous réinitialiser le mot de passe à '123' ?",
                "Réinitialisation du mot de passe",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    string nouveauMdp = "123";
                    string hash = CalculerHash(nouveauMdp);

                    int res = TriathleteDAO.ReinitialiserMotDePasse(triathlete.NumLicence, hash);

                    if (res > 0)
                    {
                        MessageBox.Show("Mot de passe réinitialisé à '123' avec succès !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la réinitialisation du mot de passe.", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string CalculerHash(string motDePasse)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(motDePasse));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment supprimer ce triathlète et toutes ses données associées (inscriptions, prélèvements, etc.) ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    TriathleteDAO.SupprimerTriathlete(triathlete.NumLicence);
                    MessageBox.Show("Triathlète supprimé avec succès !", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
