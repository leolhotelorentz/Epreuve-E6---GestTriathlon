using BLL;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GEST_TRIATHLON
{
    public partial class FormListeTriathlete : Form
    {
        public FormListeTriathlete()
        {
            InitializeComponent();
        }

        private void FormListeTriathlete_Load(object sender, EventArgs e)
        {
            ChargerTriathletes();
            RemplirComboBoxes();
        }

        private void ChargerTriathletes()
        {
            var list = TriathleteDAO.GetTousLesTriathletes();
            AfficherTriathletes(list);
        }

        private void AfficherTriathletes(List<Triathlete> list)
        {
            if (list != null)
            {
                dgv_Liste.DataSource = null;
                dgv_Liste.DataSource = list;

                if (dgv_Liste.Columns["Login"] != null)
                    dgv_Liste.Columns["Login"].Visible = false;

                if (dgv_Liste.Columns["CodeCategorie"] != null)
                    dgv_Liste.Columns["CodeCategorie"].Visible = false;

                if (dgv_Liste.Columns["Age"] != null)
                    dgv_Liste.Columns["Age"].DisplayIndex = dgv_Liste.Columns.Count - 1;

                ConfigurerColonnes();

                dgv_Liste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Erreur lors de la récupération des triathlètes");
            }
        }

        private void ConfigurerColonnes()
        {
            if (dgv_Liste.Columns["NumLicence"] != null)
                dgv_Liste.Columns["NumLicence"].HeaderText = "N° Licence";

            if (dgv_Liste.Columns["Prenom"] != null)
                dgv_Liste.Columns["Prenom"].HeaderText = "Prénom";

            if (dgv_Liste.Columns["AdresseRue"] != null)
                dgv_Liste.Columns["AdresseRue"].HeaderText = "Rue";

            if (dgv_Liste.Columns["AdresseCP"] != null)
                dgv_Liste.Columns["AdresseCP"].HeaderText = "CP";

            if (dgv_Liste.Columns["AdresseVille"] != null)
                dgv_Liste.Columns["AdresseVille"].HeaderText = "Ville";

            if (dgv_Liste.Columns["DateNaissance"] != null)
            {
                dgv_Liste.Columns["DateNaissance"].HeaderText = "Date Naissance";
                dgv_Liste.Columns["DateNaissance"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgv_Liste.Columns["LibelleCategorie"] != null)
                dgv_Liste.Columns["LibelleCategorie"].HeaderText = "Catégorie";

            if (dgv_Liste.Columns["NbTriathlonsParticipes"] != null)
                dgv_Liste.Columns["NbTriathlonsParticipes"].HeaderText = "Nb Triathlons";

            if (dgv_Liste.Columns["AEtePositifDopage"] != null)
                dgv_Liste.Columns["AEtePositifDopage"].Visible = false;

            if (dgv_Liste.Columns["Age"] != null)
                dgv_Liste.Columns["Age"].HeaderText = "Âge";
        }

        private void dgv_Liste_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_Liste.Columns[e.ColumnIndex].Name == "NbTriathlonsParticipes")
            {
                if (e.RowIndex >= 0)
                {
                    var triathlete = (Triathlete)dgv_Liste.Rows[e.RowIndex].DataBoundItem;
                    if (triathlete.AEtePositifDopage)
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void RemplirComboBoxes()
        {
            var categories = CategorieDAO.GetToutesLesCategories();
            cb_Categorie.DataSource = categories;
            cb_Categorie.DisplayMember = "Libelle";
            cb_Categorie.ValueMember = "CodeCategorie";
            cb_Categorie.SelectedIndex = -1;

            cb_Sexe.SelectedIndex = 0;

            var triathlons = TriathlonDAO.GetLesTriathlons();
            var triathlonItems = triathlons.Select(t => new
            {
                IdTriathlon = t.IdTriathlon,
                Affichage = $"{t.IdTriathlon} - {t.NomTriathlon} ({t.DateTriathlon:dd/MM/yyyy})"
            }).ToList();

            triathlonItems.Insert(0, new { IdTriathlon = 0, Affichage = "" });

            cb_Triathlon.DataSource = triathlonItems;
            cb_Triathlon.DisplayMember = "Affichage";
            cb_Triathlon.ValueMember = "IdTriathlon";
            cb_Triathlon.SelectedIndex = 0;
        }

        private void btn_Filtrer_Click(object sender, EventArgs e)
        {
            int? numLicence = null;
            if (!string.IsNullOrWhiteSpace(tb_NumLicence.Text))
            {
                if (int.TryParse(tb_NumLicence.Text, out int val))
                    numLicence = val;
            }

            string nom = string.IsNullOrWhiteSpace(tb_Nom.Text) ? null : tb_Nom.Text.Trim();

            int? codeCategorie = cb_Categorie.SelectedIndex >= 0 ? (int?)cb_Categorie.SelectedValue : null;

            char? sexe = null;
            if (cb_Sexe.SelectedIndex > 0)
                sexe = cb_Sexe.SelectedItem.ToString()[0];

            int? ageMin = null;
            if (!string.IsNullOrWhiteSpace(tb_AgeMin.Text))
            {
                if (int.TryParse(tb_AgeMin.Text, out int val))
                    ageMin = val;
            }

            int? ageMax = null;
            if (!string.IsNullOrWhiteSpace(tb_AgeMax.Text))
            {
                if (int.TryParse(tb_AgeMax.Text, out int val))
                    ageMax = val;
            }

            int? idTriathlon = null;
            if (cb_Triathlon.SelectedIndex > 0)
                idTriathlon = (int)cb_Triathlon.SelectedValue;

            var filtres = TriathleteDAO.GetTriathletesFiltres(numLicence, nom, codeCategorie, sexe, ageMin, ageMax, idTriathlon);
            AfficherTriathletes(filtres);
        }

        private void btn_Reinitialiser_Click(object sender, EventArgs e)
        {
            tb_NumLicence.Clear();
            tb_Nom.Clear();
            cb_Categorie.SelectedIndex = -1;
            cb_Sexe.SelectedIndex = 0;
            tb_AgeMin.Clear();
            tb_AgeMax.Clear();
            cb_Triathlon.SelectedIndex = 0;

            ChargerTriathletes();
        }

        private void dgv_Liste_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var triathlete = (Triathlete)dgv_Liste.Rows[e.RowIndex].DataBoundItem;
                FormAjouterModifierTriathlete frm = new FormAjouterModifierTriathlete(triathlete);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ChargerTriathletes();
                }
            }
        }
    }
}
