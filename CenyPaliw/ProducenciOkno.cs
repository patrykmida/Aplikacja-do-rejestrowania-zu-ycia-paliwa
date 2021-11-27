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
    public partial class ProducenciOkno : Form
    {
        public ProducenciOkno()
        {
            InitializeComponent();
            WczytajProducentow();
        }

        void WczytajProducentow()
        {
            this.listViewProducenci.Items.Clear();
            foreach (ProducentModel model in BazaDanych.DajInstancje().Producenci.Lista)
            {
                ProducentItem item = new ProducentItem(model);
                this.listViewProducenci.Items.Add(item);
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.PoleWymagane(textBoxNazwa, "nazwa");
            
            if (validator.Poprawne)
            {
                if(Istnieje(textBoxNazwa.Text))
                {
                    MessageBox.Show("producent o podanej nazwie juz istnieje");
                    return;
                }
                ProducentModel model = new ProducentModel();
                model.Nazwa = textBoxNazwa.Text;
                BazaDanych.DajInstancje().Producenci.Dodaj(model);
                BazaDanych.DajInstancje().Producenci.Zapisz();
                ProducentItem item = new ProducentItem(model);
                this.listViewProducenci.Items.Add(item);
            }
        }

       

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (this.listViewProducenci.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Należy zaznaczyc producenta do edycji");
                return;
            }
            Validator validator = new Validator();
            validator.PoleWymagane(textBoxNazwa, "nazwa");

            if (validator.Poprawne)
            {
                ProducentItem item = (ProducentItem)this.listViewProducenci.SelectedItems[0];
                ProducentModel model = item.Model;
                model.Nazwa = textBoxNazwa.Text;
                item.Model = model;
                BazaDanych.DajInstancje().Producenci.Zapisz();

            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (this.listViewProducenci.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Należy zaznaczyc producenta do edycji");
                return;
            }
            ProducentItem item = (ProducentItem)this.listViewProducenci.SelectedItems[0];
            ProducentModel producent = item.Model;
            if (Uzywany(producent.Id))
            {
                MessageBox.Show("Nie mozna usunac producenta gdyz jest on uzywany");
                return;
            }
            this.listViewProducenci.Items.Remove(item);
            BazaDanych.DajInstancje().Producenci.Usun(producent.Id);
            BazaDanych.DajInstancje().Producenci.Zapisz();
        }

        private bool Istnieje(string nazwa)
        {
            foreach (ProducentModel model in BazaDanych.DajInstancje().Producenci.Lista)
            {
                if (model.Nazwa == nazwa)
                {
                    return true;
                }
            }
            return false;
        }

        private bool Uzywany(Guid idProducenta)
        {
            foreach (StacjaModel model in BazaDanych.DajInstancje().Stacje.Lista)
            {
                if (model.IdProducenta.ToString() == idProducenta.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
