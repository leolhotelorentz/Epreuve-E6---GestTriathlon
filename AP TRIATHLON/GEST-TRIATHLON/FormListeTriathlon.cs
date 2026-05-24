using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace GEST_TRIATHLON
{
    public partial class FormListeTriathlon : Form
    {
        public FormListeTriathlon()
        {
            InitializeComponent();
        }
        private void dgv_Liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_Lieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormListeTriathlon_Load(object sender, EventArgs e)
        {
            ChargerTriathlons();
            RemplirComboBoxes();
        }

        private void ChargerTriathlons()
        {
            var list = TriathlonDAO.GetLesTriathlons();

            foreach (var t in list)   
            {
                var typeObj = TypeTriathlonDAO.GetTypeParCode(t.CodeType);
                t.LibelleType = typeObj != null ? typeObj.LibelleType : "";
            }

            AfficherTriathlons(list);
        }

        private void AfficherTriathlons(List<Triathlon> list)
        {
            if (list != null)
            {
                dgv_Liste.DataSource = null;
                dgv_Liste.DataSource = list;

                if (dgv_Liste.Columns["CodeType"] != null)
                    dgv_Liste.Columns["CodeType"].HeaderText = "Code Type";

                if (dgv_Liste.Columns["LibelleType"] != null)
                {
                    dgv_Liste.Columns["LibelleType"].HeaderText = "Libellé Type";
                    dgv_Liste.Columns["LibelleType"].ReadOnly = true;
                }

                dgv_Liste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Erreur lors de la récupération des triathlons");
            }
        }

        private void RemplirComboBoxes()
        {
            var lieux = TriathlonDAO.GetLesTriathlons()
                .Select(t => t.Lieu)
                .Distinct()
                .ToList();
            cb_Lieu.DataSource = lieux;
            cb_Lieu.SelectedIndex = -1;

            var types = TypeTriathlonDAO.GetTousLesTypes();
            cb_Type.DataSource = types;
            cb_Type.DisplayMember = "LibelleType"; 
            cb_Type.ValueMember = "CodeType";      
            cb_Type.SelectedIndex = -1;

            dtp_DateDebut.Checked = false;
            dtp_DateFin.Checked = false;
        }

        private void btn_Filtrer_Click(object sender, EventArgs e)
        {
            string lieu = cb_Lieu.SelectedItem?.ToString();

            int? type = cb_Type.SelectedItem != null
                ? (int?)((TypeTriathlon)cb_Type.SelectedItem).CodeType
                : null;

            DateTime? dateDebut = dtp_DateDebut.Checked ? (DateTime?)dtp_DateDebut.Value.Date : null;
            DateTime? dateFin = dtp_DateFin.Checked ? (DateTime?)dtp_DateFin.Value.Date : null;

            var filtres = TriathlonDAO.GetTriathlonsFiltres(lieu, type, dateDebut, dateFin);

            foreach (var t in filtres)  
            {
                var typeObj = TypeTriathlonDAO.GetTypeParCode(t.CodeType);
                t.LibelleType = typeObj != null ? typeObj.LibelleType : "";
            }

            AfficherTriathlons(filtres);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb_Lieu.SelectedIndex = -1;
            cb_Type.SelectedIndex = -1;

            dtp_DateDebut.Checked = false;
            dtp_DateFin.Checked = false;

            ChargerTriathlons();
        }

        private void dgv_Liste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;

                SupprimerTriathlonSelectionne();
            }
        }

        private void SupprimerTriathlonSelectionne()
        {
            if (dgv_Liste.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un triathlon.");
                return;
            }

            int idTriathlon = Convert.ToInt32(
                dgv_Liste.CurrentRow.Cells["idTriathlon"].Value
            );
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment supprimer ce triathlon et toutes ses épreuves associées ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    TriathlonDAO.SupprimerTriathlon(idTriathlon);

                    MessageBox.Show("Triathlon et épreuves supprimés avec succès !", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ChargerTriathlons();
            }
        }

        private void btn_Creation_Click(object sender, EventArgs e)
        {
            FormAjouterModifierTriathlon frm = new FormAjouterModifierTriathlon();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ChargerTriathlons();
            }
        }

        private void dgv_Liste_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var triathlon = (Triathlon)dgv_Liste.Rows[e.RowIndex].DataBoundItem;
                FormAjouterModifierTriathlon frm = new FormAjouterModifierTriathlon(triathlon);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ChargerTriathlons();
                }
            }
        }
    }
}

