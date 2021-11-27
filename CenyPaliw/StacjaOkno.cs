using CenyPaliw.ListViewItemModel;
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
    public partial class StacjaOkno : Form
    {
        private StacjaModel model;
        private bool ok;
        public StacjaOkno()
        {
            InitializeComponent();
            this.Text = "Dodawanie stacji";
            model = new StacjaModel();
            UzupelnicComboProducentow();
            this.btnDodajCene.Enabled = false;
            this.btnEdytujCene.Enabled = false;
            this.btnUsunCene.Enabled = false;
        }


        public StacjaOkno(StacjaModel model)
        {
            InitializeComponent();
            this.Text = "Edycja stacji";
            this.model = model;
            UzupelnicComboProducentow();

            var producent = BazaDanych.DajInstancje().Producenci[model.IdProducenta];
            this.comboBoxProducenci.SelectedIndex = BazaDanych.DajInstancje().Producenci.Lista.IndexOf(producent); ;

            this.textBoxMiasto.Text = model.Miasto;
            this.textBoxUlica.Text = model.Ulica;
            this.textBoxNr.Text = model.Nr;
            WczytajCeny();
            ok = false;
        }

        private void WczytajCeny()
        {
            this.listViewCenyPaliw.Items.Clear();
            foreach (Guid idCeny in model.CenyPaliw)
            {
                var model = BazaDanych.DajInstancje().CenyPaliw[idCeny];
                CenaPaliwaItem item = new CenaPaliwaItem(model);
                this.listViewCenyPaliw.Items.Add(item);
            }

        }

        private void UzupelnicComboProducentow()
        {
            comboBoxProducenci.Items.Clear();
            foreach (ProducentModel producent in BazaDanych.DajInstancje().Producenci.Lista)
            {
                comboBoxProducenci.Items.Add(producent.Nazwa);
            }
        }

        public StacjaModel Model
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
            validator.PoleWymagane(comboBoxProducenci, "producent");
            validator.PoleWymagane(textBoxMiasto, "miasto");
            validator.PoleWymagane(textBoxUlica, "ulica");
            validator.PoleWymagane(textBoxNr, "numer");


            if (validator.Poprawne)
            {
                var producent = BazaDanych.DajInstancje().Producenci.Lista[this.comboBoxProducenci.SelectedIndex];
                model.IdProducenta = producent.Id;

                model.Miasto = this.textBoxMiasto.Text;
                model.Ulica = this.textBoxUlica.Text;
                model.Nr = this.textBoxNr.Text;

                ok = true;
                this.Close();
            }

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajProducenta_Click(object sender, EventArgs e)
        {
            ProducenciOkno producenciOkno = new ProducenciOkno();
            producenciOkno.ShowDialog();
            UzupelnicComboProducentow();
        }

        private void btnDodajCene_Click(object sender, EventArgs e)
        {
            CenyPaliwOkno cenyPaliwOkno = new CenyPaliwOkno();
            cenyPaliwOkno.ShowDialog();
            if (cenyPaliwOkno.OK)
            {
                CenaPaliwaItem item = new CenaPaliwaItem(cenyPaliwOkno.Model);
                BazaDanych.DajInstancje().CenyPaliw.Dodaj(cenyPaliwOkno.Model);
                BazaDanych.DajInstancje().CenyPaliw.Zapisz();
                model.CenyPaliw.Add(cenyPaliwOkno.Model.Id);
                BazaDanych.DajInstancje().Stacje.Zapisz();
                this.listViewCenyPaliw.Items.Add(item);

            }
        }

        private void btnEdytujCene_Click(object sender, EventArgs e)
        {
            if (this.listViewCenyPaliw.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Należy zaznaczyc cene do edycji");
                return;
            }
            CenaPaliwaItem item = (CenaPaliwaItem)this.listViewCenyPaliw.SelectedItems[0];
            CenyPaliwOkno cenyPaliwOkno = new CenyPaliwOkno(item.Model);
            cenyPaliwOkno.ShowDialog();
            if (cenyPaliwOkno.OK)
            {
                item.Model = cenyPaliwOkno.Model;
                BazaDanych.DajInstancje().CenyPaliw.Zapisz();
            }
        }

        private void btnUsunCene_Click(object sender, EventArgs e)
        {
            if (this.listViewCenyPaliw.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Należy zaznaczyc cene do usuniecia");
                return;
            }
            CenaPaliwaItem item = (CenaPaliwaItem)this.listViewCenyPaliw.SelectedItems[0];
            this.listViewCenyPaliw.Items.Remove(item);
            BazaDanych.DajInstancje().CenyPaliw.Usun(item.Model);
            BazaDanych.DajInstancje().CenyPaliw.Zapisz();
            model.CenyPaliw.Remove(item.Model.Id);
            BazaDanych.DajInstancje().Stacje.Zapisz();
        }
    }
}
