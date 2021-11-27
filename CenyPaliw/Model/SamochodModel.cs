using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenyPaliw.Model
{
    public class SamochodModel : Element
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public float PojemnoscSilnika { get; set; }
        public float SpalanieNa100 { get; set; }

        public RodzajPaliwa Paliwo { get; set; }


    }
}
