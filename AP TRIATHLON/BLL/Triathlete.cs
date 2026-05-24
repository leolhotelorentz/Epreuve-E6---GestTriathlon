using System;

namespace BLL
{
    public class Triathlete
    {
        private int numLicence;
        private string nom;
        private string prenom;
        private char sexe;
        private string adresseRue;
        private string adresseCP;
        private string adresseVille;
        private DateTime dateNaissance;
        private int codeCategorie;
        private string login;
        private string libelleCategorie;
        private int nbTriathlonsParticipes;
        private bool aEtePositifDopage;

        public Triathlete() { }

        public Triathlete(int numLicence, string nom, string prenom, char sexe, string adresseRue, 
            string adresseCP, string adresseVille, DateTime dateNaissance, int codeCategorie, string login)
        {
            this.numLicence = numLicence;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.adresseRue = adresseRue;
            this.adresseCP = adresseCP;
            this.adresseVille = adresseVille;
            this.dateNaissance = dateNaissance;
            this.codeCategorie = codeCategorie;
            this.login = login;
        }

        public int NumLicence
        {
            get { return numLicence; }
            set { numLicence = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public char Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }

        public string AdresseRue
        {
            get { return adresseRue; }
            set { adresseRue = value; }
        }

        public string AdresseCP
        {
            get { return adresseCP; }
            set { adresseCP = value; }
        }

        public string AdresseVille
        {
            get { return adresseVille; }
            set { adresseVille = value; }
        }

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        public int CodeCategorie
        {
            get { return codeCategorie; }
            set { codeCategorie = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string LibelleCategorie
        {
            get { return libelleCategorie; }
            set { libelleCategorie = value; }
        }

        public int NbTriathlonsParticipes
        {
            get { return nbTriathlonsParticipes; }
            set { nbTriathlonsParticipes = value; }
        }

        public bool AEtePositifDopage
        {
            get { return aEtePositifDopage; }
            set { aEtePositifDopage = value; }
        }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - dateNaissance.Year;
                if (dateNaissance.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}
