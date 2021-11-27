using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenyPaliw.Model
{
    public class UzytkownikModel : Element
    {
        public UzytkownikModel()
        {
            Samochody = new List<Guid>();
        }

        public string Login { get; set; }
        public string Haslo { get; set; }
        public bool CzyAdmin { get; set; }

        public List<Guid> Samochody { get; set; }
    }
}
