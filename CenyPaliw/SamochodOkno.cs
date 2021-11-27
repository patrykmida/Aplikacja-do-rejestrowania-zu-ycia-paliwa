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
    public partial class SamochodOkno : Form
    {
        private SamochodModel model;
        private bool ok;
        public SamochodOkno()
        {
            InitializeComponent();
            this.Text = "Dodawanie samochodu";
            model = new SamochodModel();
            this.comboBoxRodzajPaliwa.Items.AddRange(Enum.GetNames(typeof(RodzajPaliwa)));
        }

        public SamochodOkno(SamochodModel model)
        {
            InitializeComponent();
            this.Text = "Edycja samochodu";
            this.model = model;
            this.comboBoxRodzajPaliwa.Items.AddRange(Enum.GetNames(typeof(RodzajPaliwa)));

            this.textBoxMarka.Text = model.Marka;
            this.textBoxModel.Text = model.Model;
            this.textBoxPojemnosc.Text = model.PojemnoscSilnika.ToString();
            this.textBoxSpalanie.Text = model.SpalanieNa100.ToString();
            this.comboBoxRodzajPaliwa.SelectedIndex = (int)model.Paliwo;

            ok = false;

        }

        public SamochodModel Model
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
            validator.PoleWymagane(textBoxMarka, "marka");
            validator.PoleWymagane(textBoxModel, "model");
            validator.PoleWymaganeFloat(textBoxPojemnosc, "pojemność silnika");
            validator.PoleWymaganeFloat(textBoxSpalanie, "spalanie");
            validator.PoleWymagane(comboBoxRodzajPaliwa, "rodzaj paliwa");
            
            if(validator.Poprawne)
            {
                model.Marka = this.textBoxMarka.Text;
                model.Model = this.textBoxModel.Text;
                model.PojemnoscSilnika = float.Parse(this.textBoxPojemnosc.Text);
                model.SpalanieNa100 = float.Parse(this.textBoxSpalanie.Text);
                model.Paliwo = (RodzajPaliwa)this.comboBoxRodzajPaliwa.SelectedIndex;
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
