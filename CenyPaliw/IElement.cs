using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenyPaliw
{
    public class Element
    {
        public Element()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
