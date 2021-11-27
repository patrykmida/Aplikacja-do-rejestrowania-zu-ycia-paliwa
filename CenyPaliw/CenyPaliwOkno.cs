using CenyPaliw.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenyPaliw
{
    public partial class CenyPaliwOkno : Form
    {
        private CenaPaliwaModel model;
        private bool ok;
        public CenyPaliwOkno()
        {
            InitializeComponent();
            this.Text = "Dodawanie ceny";
            model = new CenaPaliwaModel();
            this.dateTimePicker.Value = DateTime.Now;
        }


        public CenyPaliwOkno(CenaPaliwaModel model)
        {
            InitializeComponent();
            this.Text = "Edycja ceny";
            this.model = model;
            this.dateTimePicker.Value = DateTime.Now;

            this.textBoxRopa.Text = model.CenaRopy.ToString();
            this.textBoxGaz.Text = model.CenaGazu.ToString();
            this.textBoxPb95.Text = model.CenaPB95.ToString();
            this.textBoxPb98.Text = model.CenaPB98.ToString();

            ok = false;
        }

        public CenaPaliwaModel Model
        {
            get => model;
        }
        public bool OK
        {
            get => ok;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.PoleWymaganeFloat(textBoxRopa, "cena ropy");
            validator.PoleWymaganeFloat(textBoxGaz, "cena gazu");
            validator.PoleWymaganeFloat(textBoxPb95, "cena pb95");
            validator.PoleWymaganeFloat(textBoxPb98, "cena pb98");
           
            if (validator.Poprawne)
            {
                model.Data = dateTimePicker.Value;
                model.CenaRopy = float.Parse(this.textBoxRopa.Text);
                model.CenaGazu = float.Parse(this.textBoxGaz.Text);
                model.CenaPB95 = float.Parse(this.textBoxPb95.Text);
                model.CenaPB98 = float.Parse(this.textBoxPb98.Text);
                
                ok = true;
                this.Close();
            }

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
