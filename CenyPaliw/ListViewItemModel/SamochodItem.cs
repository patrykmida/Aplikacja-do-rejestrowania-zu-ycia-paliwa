using CenyPaliw.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenyPaliw.ListViewItemModel
{
    class SamochodItem : ListViewItem
    {
        SamochodModel model;
        public SamochodItem(SamochodModel model)
        {
            this.model = model;

            Ustaw();
        }

        public SamochodModel Model
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
            this.Text = model.Marka;
            SubItems.Add(model.Model);
            SubItems.Add(model.PojemnoscSilnika.ToString());
            SubItems.Add(model.SpalanieNa100.ToString());
            SubItems.Add(model.Paliwo.ToString());
        }
    }
}
