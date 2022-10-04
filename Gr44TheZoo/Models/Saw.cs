using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gr44TheZoo.Models
{
    public class Saw : IDanger
    {
        public Dictionary<string, int> DangerType()
        {
            Dictionary<string, int> dangerTyps = new Dictionary<string, int>();
            dangerTyps.Add("BLADRUNNER", 10);

            return dangerTyps;
        }
    }
}
