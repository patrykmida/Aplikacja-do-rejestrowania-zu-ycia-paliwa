using CenyPaliw.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenyPaliw.ListViewItemModel
{
    class StacjaItem : ListViewItem
    {
        StacjaModel model;

        public StacjaItem(StacjaModel model)
        {
            this.model = model;
            Ustaw();
        }

        public StacjaModel Model
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
            CenaPaliwaModel ostatniaCenaPaliwa = model.DajOstatniaCenePaliwa();
            if (ostatniaCenaPaliwa == null)
            {
                ostatniaCenaPaliwa = new CenaPaliwaModel();
            }

            this.Text = BazaDanych.DajInstancje().Producenci[model.IdProducenta].Nazwa;
            SubItems.Add(ostatniaCenaPaliwa.CenaPB95.ToString());
            SubItems.Add(ostatniaCenaPaliwa.CenaPB98.ToString());
            SubItems.Add(ostatniaCenaPaliwa.CenaRopy.ToString());
            SubItems.Add(ostatniaCenaPaliwa.CenaGazu.ToString());
            SubItems.Add(model.DajAdres());
        }
    }
}
