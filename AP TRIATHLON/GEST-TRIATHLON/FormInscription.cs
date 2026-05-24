using BLL;
using DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GEST_TRIATHLON
{
    public partial class FormInscription : Form
    {
        private Inscription inscription;
        private int numLicence;
        private bool modeModification;

        public FormInscription(Inscription inscription)
        {
            InitializeComponent();
            this.inscription = inscription;
            this.numLicence = inscription.NumLicence;
            this.modeModification = true;
        }

        public FormInscription(int numLicence)
        {
            InitializeComponent();
            this.numLicence = numLicence;
            this.modeModification = false;
        }

        private void FormInscription_Load(object sender, EventArgs e)
        {
            ChargerTriathlons();

            if (modeModification)
            {
                RemplirChamps();
                cb_Triathlon.Enabled = false;
                tb_NumDossard.ReadOnly = true;
                this.Text = "Modifier une inscription";
                btn_Supprimer.Visible = true;
            }
            else
            {
                dtp_DateInscription.Value = DateTime.Now;
                this.Text = "Nouvelle inscription";
                btn_Supprimer.Visible = false;
            }
        }

        private void ChargerTriathlons()
        {
            var triathlons = TriathlonDAO.GetLesTriathlons();
            var triathlonItems = triathlons.Select(t => new
            {
                IdTriathlon = t.IdTriathlon,
                Affichage = $"{t.IdTriathlon} - {t.NomTriathlon} ({t.DateTriathlon:dd/MM/yyyy}) - {t.Lieu}"
            }).ToList();

            cb_Triathlon.DataSource = triathlonItems;
            cb_Triathlon.DisplayMember = "Affichage";
            cb_Triathlon.ValueMember = "IdTriathlon";
            cb_Triathlon.SelectedIndex = -1;
        }

        private void RemplirChamps()
        {
            cb_Triathlon.SelectedValue = inscription.IdTriathlon;
            tb_NumDossard.Text = inscription.NumDossard.ToString();
            dtp_DateInscription.Value = inscription.DateInscription;
            chk_Forfait.Checked = inscription.Forfait;
        }

        private void cb_Triathlon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!modeModification && cb_Triathlon.SelectedValue != null)
            {
                int idTriathlon = (int)cb_Triathlon.SelectedValue;
                int prochainNumDossard = InscriptionDAO.GetProchainNumDossard(idTriathlon);
                tb_NumDossard.Text = prochainNumDossard.ToString();
            }
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            if (!ValiderSaisie())
                return;

            try
            {
                Inscription insc = new Inscription
                {
                    IdTriathlon = (int)cb_Triathlon.SelectedValue,
                    NumDossard = int.Parse(tb_NumDossard.Text),
                    DateInscription = dtp_DateInscription.Value.Date,
                    Forfait = chk_Forfait.Checked,
                    NumLicence = numLicence
                };

                int result;
                if (modeModification)
                {
                    result = InscriptionDAO.ModifierInscription(insc);
                    if (result > 0)
                    {
                        MessageBox.Show("Inscription modifiée avec succès !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la modification de l'inscription.", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    result = InscriptionDAO.AjouterInscription(insc);
                    if (result > 0)
                    {
                        MessageBox.Show("Inscription créée avec succès !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la création de l'inscription.", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            if (cb_Triathlon.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un triathlon.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_Triathlon.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tb_NumDossard.Text))
            {
                MessageBox.Show("Le numéro de dossard est invalide.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            if (!modeModification || inscription == null)
                return;

            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment supprimer cette inscription ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    int res = InscriptionDAO.SupprimerInscription(inscription.IdTriathlon, inscription.NumDossard);
                    if (res > 0)
                    {
                        MessageBox.Show("Inscription supprimée avec succès !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la suppression de l'inscription.", "Erreur",
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
    }
}
