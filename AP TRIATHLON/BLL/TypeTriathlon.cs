using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TypeTriathlon
    {
        private int codeType;
        private string libelleType;
        private decimal distanceNatation;
        private decimal distanceCyclisme;
        private decimal distanceCourse;

        public TypeTriathlon() { }

        public TypeTriathlon(int codeType, string libelleType, decimal distanceNatation, decimal distanceCyclisme, decimal distanceCourse)
        {
            this.CodeType = codeType;
            this.LibelleType = libelleType;
            this.DistanceNatation = distanceNatation;
            this.DistanceCyclisme = distanceCyclisme;
            this.DistanceCourse = distanceCourse;
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

        public decimal DistanceNatation
        {
            get { return distanceNatation; }
            set { distanceNatation = value; }
        }

        public decimal DistanceCyclisme
        {
            get { return distanceCyclisme; }
            set { distanceCyclisme = value; }
        }

        public decimal DistanceCourse
        {
            get { return distanceCourse; }
            set { distanceCourse = value; }
        }
    }
}
