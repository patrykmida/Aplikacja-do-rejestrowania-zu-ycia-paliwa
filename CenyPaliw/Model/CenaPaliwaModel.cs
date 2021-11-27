using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenyPaliw.Model
{
    public class CenaPaliwaModel : Element
    {
        public Guid IdStacji { get; set; }
        public DateTime Data { get; set; }

        public float CenaRopy { get; set; }
        public float CenaGazu { get; set; }
        public float CenaPB95 { get; set; }
        public float CenaPB98 { get; set; }
    }
}
