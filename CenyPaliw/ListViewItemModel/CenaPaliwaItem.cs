using CenyPaliw.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenyPaliw.ListViewItemModel
{
    class CenaPaliwaItem : ListViewItem
    {
        CenaPaliwaModel model;
        public CenaPaliwaItem(CenaPaliwaModel model)
        {
            this.model = model;

            Ustaw();
        }

        public CenaPaliwaModel Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
                Ustaw();
            }
        }
        private void Ustaw()
        {
            SubItems.Clear();
            this.Text = model.Data.ToShortDateString();
            SubItems.Add(model.CenaPB95.ToString());
            SubItems.Add(model.CenaPB98.ToString());
            SubItems.Add(model.CenaRopy.ToString());
            SubItems.Add(model.CenaGazu.ToString());
        }
    }
}
