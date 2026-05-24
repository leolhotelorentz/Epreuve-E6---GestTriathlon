using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GEST_TRIATHLON
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void listeDesTriathlonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeTriathlon frm = new FormListeTriathlon();
            frm.ShowDialog();
        }

        private void listeDesTriathletesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeTriathlete frm = new FormListeTriathlete();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Connexion.TesterConnexion())
                MessageBox.Show("Connexion OK");
            else
                MessageBox.Show("Connexion impossible");
        }

        private void LabelGT_Click(object sender, EventArgs e)
        {

        }
    }
}
