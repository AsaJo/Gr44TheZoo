using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gr44TheZoo.Models
{
    public class Crocodile : Animal,IDanger
    {

        public string BigMouth { get; set; }


        public Crocodile(string bigMouth, string? name, double weight, double height, WeightUnit weightUnit, HeightUnit heightUnit) : base(name, weight, height, weightUnit, heightUnit)
        {
            BigMouth = bigMouth;
        }

        public override string MakeNoise()
        {
            return " Hezzzzzzzzzzzz";
        }
        public override string Info()
        {
            return base.Info() + $"\nT {BigMouth}";
        }

        public Dictionary<string, int> DangerType()
        {
            Dictionary<string, int> dangerTypes = new Dictionary<string, int>();
            dangerTypes.Add("Swallowed", 9);
            dangerTypes.Add("Bite", 6);
            return dangerTypes;
        }
    }
}
