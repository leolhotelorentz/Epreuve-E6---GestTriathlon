namespace BLL
{
    public class Categorie
    {
        private int codeCategorie;
        private string libelle;
        private int ageMini;
        private int ageMaxi;

        public Categorie() { }

        public Categorie(int codeCategorie, string libelle, int ageMini, int ageMaxi)
        {
            this.codeCategorie = codeCategorie;
            this.libelle = libelle;
            this.ageMini = ageMini;
            this.ageMaxi = ageMaxi;
        }

        public int CodeCategorie
        {
            get { return codeCategorie; }
            set { codeCategorie = value; }
        }

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public int AgeMini
        {
            get { return ageMini; }
            set { ageMini = value; }
        }

        public int AgeMaxi
        {
            get { return ageMaxi; }
            set { ageMaxi = value; }
        }
    }
}
