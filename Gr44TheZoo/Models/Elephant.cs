using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gr44TheZoo.Models
{
    public class Elephant : Animal,IDanger
    {
        public double TrunkLength { get; set; }
        public Elephant(double trunkLength,string? name, double weight, double height, WeightUnit weightUnit, HeightUnit heightUnit) : base(name, weight, height, weightUnit, heightUnit)
        {
            TrunkLength = trunkLength;
        }

        public override string MakeNoise()
        {
            return "Tuiii pawoo";
        }
        public override string Info()
        {
            return base.Info() + $"\nTrunkLength: {TrunkLength}  {HeightUnit} ";
        }

        public Dictionary<string, int> DangerType()
        {
            Dictionary<string, int> dangerTypes = new Dictionary<string, int>();
            dangerTypes.Add("Tramped", 9);
            
            return dangerTypes;
        }
    }

}

