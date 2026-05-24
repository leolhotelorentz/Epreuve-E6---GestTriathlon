using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Triathlon
    {
        private int idTriathlon;
        private string nomTriathlon;
        private string lieu;
        private DateTime dateTriathlon;
        private int codeType;
        private string libelleType;

        public Triathlon() { }
        public Triathlon(int idTriathlon, string nomTriathlon, string lieu, DateTime dateTriathlon, int codeType)
        {
            this.idTriathlon = idTriathlon;
            this.nomTriathlon = nomTriathlon;
            this.lieu = lieu;
            this.dateTriathlon = dateTriathlon;
            this.codeType = codeType;
        }

        public int IdTriathlon
        {
            get { return idTriathlon; }
            set { idTriathlon = value; }
        }

        public string NomTriathlon
        {
            get { return nomTriathlon; }
            set { nomTriathlon = value; }
        }

        public string Lieu
        {
            get { return lieu; }
            set { lieu = value; }
        }

        public DateTime DateTriathlon
        {
            get { return dateTriathlon; }
            set { dateTriathlon = value; }
        }

        public int CodeType
        {
            get { return codeType; }
            set { codeType = value; }
        }

        public string LibelleType
        {
            get { return libelleType; }
            set { libelleType = value; }
        }
    }
}
