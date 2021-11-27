using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenyPaliw.Model
{
    public class StacjaModel : Element
    {
        public StacjaModel()
        {
            CenyPaliw = new List<Guid>();
        }

        public Guid IdProducenta { get; set; }

        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string Nr { get; set; }

        public List<Guid> CenyPaliw { get; set; }

        public CenaPaliwaModel DajOstatniaCenePaliwa()
        {
            CenaPaliwaModel ostatniaCenaPaliwa = null;
            foreach (Guid id in CenyPaliw)
            {
                CenaPaliwaModel cenaPaliwa = BazaDanych.DajInstancje().CenyPaliw[id];
                if (ostatniaCenaPaliwa == null)
                {
                    ostatniaCenaPaliwa = cenaPaliwa;
                }
                else if (ostatniaCenaPaliwa.Data.CompareTo(cenaPaliwa.Data) < 0)
                {
                    ostatniaCenaPaliwa = cenaPaliwa;
                }
            }
            return ostatniaCenaPaliwa;
        }

        public string DajAdres()
        {
            return string.Format("{0} ul. {1} {2}", Miasto, Ulica, Nr);
        }

    }

}
