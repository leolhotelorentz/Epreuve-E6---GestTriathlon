using System;

namespace BLL
{
    public class Inscription
    {
        private int idTriathlon;
        private int numDossard;
        private DateTime dateInscription;
        private bool forfait;
        private int numLicence;
        private string nomTriathlon;
        private DateTime dateTriathlon;
        private string lieuTriathlon;

        public Inscription() { }

        public Inscription(int idTriathlon, int numDossard, DateTime dateInscription, bool forfait, int numLicence)
        {
            this.idTriathlon = idTriathlon;
            this.numDossard = numDossard;
            this.dateInscription = dateInscription;
            this.forfait = forfait;
            this.numLicence = numLicence;
        }

        public int IdTriathlon
        {
            get { return idTriathlon; }
            set { idTriathlon = value; }
        }

        public int NumDossard
        {
            get { return numDossard; }
            set { numDossard = value; }
        }

        public DateTime DateInscription
        {
            get { return dateInscription; }
            set { dateInscription = value; }
        }

        public bool Forfait
        {
            get { return forfait; }
            set { forfait = value; }
        }

        public int NumLicence
        {
            get { return numLicence; }
            set { numLicence = value; }
        }

        public string NomTriathlon
        {
            get { return nomTriathlon; }
            set { nomTriathlon = value; }
        }

        public DateTime DateTriathlon
        {
            get { return dateTriathlon; }
            set { dateTriathlon = value; }
        }

        public string LieuTriathlon
        {
            get { return lieuTriathlon; }
            set { lieuTriathlon = value; }
        }
    }
}
