using System;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GEST_TRIATHLON
{
    public partial class FormAjouterModifierTriathlon : Form
    {
        private Triathlon triathlonAModifier;
        private bool modeModification;

        public FormAjouterModifierTriathlon()
        {
            InitializeComponent();
            modeModification = false;
        }

        public FormAjouterModifierTriathlon(Triathlon triathlon) : this()
        {
            triathlonAModifier = triathlon;
            modeModification = true;
        }

        private void FormAjouterModifierTriathlon_Load(object sender, EventArgs e)
        {
            ChargerComboBoxes();

            if (modeModification && triathlonAModifier != null)
            {
                RemplirChamps();
                tb_Id.ReadOnly = true;
                this.Text = "Modifier un triathlon";
                btn_Supprimer.Visible = true;
            }
            else
            {
                this.Text = "Ajouter un triathlon";
                GenererNouvelId();
                btn_Supprimer.Visible = false;
            }
        }

        private void ChargerComboBoxes()
        {
            var types = TypeTriathlonDAO.GetTousLesTypes();
            cb_Type.DataSource = types;
            cb_Type.DisplayMember = "LibelleType";
            cb_Type.ValueMember = "CodeType";
            cb_Type.SelectedIndex = -1;

            var lieux = TriathlonDAO.GetLesTriathlons()
                .Select(t => t.Lieu)
                .Distinct()
                .ToList();

            cb_Lieu.DataSource = lieux;
            cb_Lieu.SelectedIndex = -1;
        }

        private void GenererNouvelId()
        {
            var triathlons = TriathlonDAO.GetLesTriathlons();
            int maxId = triathlons.Count > 0 ? triathlons.Max(t => t.IdTriathlon) : 0;
            tb_Id.Text = (maxId + 1).ToString();
            tb_Id.ReadOnly = true;
        }

        private void RemplirChamps()
        {
            tb_Id.Text = triathlonAModifier.IdTriathlon.ToString();
            tb_Nom.Text = triathlonAModifier.NomTriathlon;

            if (cb_Lieu.Items.Contains(triathlonAModifier.Lieu))
                cb_Lieu.SelectedItem = triathlonAModifier.Lieu;
            else
                cb_Lieu.Text = triathlonAModifier.Lieu;

            cb_Type.SelectedValue = triathlonAModifier.CodeType;
            dtp_Date.Value = triathlonAModifier.DateTriathlon;
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            if (!ValiderSaisie())
                return;

            try
            {
                Triathlon triathlon = new Triathlon
                {
                    IdTriathlon = int.Parse(tb_Id.Text),
                    NomTriathlon = tb_Nom.Text.Trim(),
                    Lieu = cb_Lieu.Text.Trim(),
                    DateTriathlon = dtp_Date.Value.Date,
                    CodeType = (int)cb_Type.SelectedValue
                };

                int result;
                if (modeModification)
                {
                    result = TriathlonDAO.ModifierTriathlon(triathlon);
                    if (result > 0)
                    {
                        MessageBox.Show("Triathlon modifié avec succès !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la modification du triathlon.", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    result = TriathlonDAO.AjouterTriathlon(triathlon);
                    if (result > 0)
                    {
                        MessageBox.Show("Triathlon ajouté avec succès !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'ajout du triathlon.", "Erreur",
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
            if (string.IsNullOrWhiteSpace(tb_Nom.Text))
            {
                MessageBox.Show("Veuillez saisir un nom de triathlon.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Nom.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cb_Lieu.Text))
            {
                MessageBox.Show("Veuillez sélectionner ou saisir un lieu.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_Lieu.Focus();
                return false;
            }

            if (cb_Type.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un type de triathlon.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_Type.Focus();
                return false;
            }

            return true;
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            if (!modeModification || triathlonAModifier == null)
                return;

            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment supprimer ce triathlon et toutes ses épreuves associées ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    TriathlonDAO.SupprimerTriathlon(triathlonAModifier.IdTriathlon);
                    MessageBox.Show("Triathlon supprimé avec succès !", "Succès",
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
