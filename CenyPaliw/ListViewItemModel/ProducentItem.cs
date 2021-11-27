using CenyPaliw.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenyPaliw.ListViewItemModel
{
    class ProducentItem : ListViewItem
    {
        ProducentModel model;
        public ProducentItem(ProducentModel model)
        {
            this.model = model;

            Ustaw();
        }

        public ProducentModel Model
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
            this.Text = model.Nazwa;
        }
    }
}
