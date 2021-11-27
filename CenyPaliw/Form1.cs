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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Logowanie logowanie = new Logowanie();
            logowanie.ShowDialog();
            if (!BazaDanych.DajInstancje().Zaloguj(logowanie.Login, logowanie.Haslo))
            {
                Environment.Exit(0);
            }
            WczytajSamochody();
            WczytajStacje();
        }

        void WczytajSamochody()
        {
            this.listViewSamochody.Items.Clear();
            foreach (Guid idSamochodu in BazaDanych.DajInstancje().Uzytkownik.Samochody)
            {
                var model = BazaDanych.DajInstancje().Samochody[idSamochodu];
                SamochodItem item = new SamochodItem(model);
                this.listViewSamochody.Items.Add(item);
            }
  
        }
        void WczytajStacje()
        {
            this.listViewStacje.Items.Clear();
            foreach (StacjaModel model in BazaDanych.DajInstancje().Stacje.Lista)
            {
                StacjaItem item = new StacjaItem(model);
                this.listViewStacje.Items.Add(item);
            }

        }

        private void buttonDodajsamochod_Click(object sender, EventArgs e)
        {
            SamochodOkno samochodOkno = new SamochodOkno();
            samochodOkno.ShowDialog();
            if (samochodOkno.OK)
            {
                SamochodItem item = new SamochodItem(samochodOkno.Model);
                BazaDanych.DajInstancje().Samochody.Dodaj(samochodOkno.Model);
                BazaDanych.DajInstancje().Samochody.Zapisz();
                BazaDanych.DajInstancje().Uzytkownik.Samochody.Add(samochodOkno.Model.Id);
                BazaDanych.DajInstancje().Uzytkownicy.Zapisz();
                this.listViewSamochody.Items.Add(item);
            }
        }

        private void buttonEdytujSamochod_Click(object sender, EventArgs e)
        {
            if (this.listViewSamochody.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Należy zaznaczyc zamochód do edycji");
                return;
            }
            SamochodItem item = (SamochodItem)this.listViewSamochody.SelectedItems[0];
            SamochodOkno samochodOkno = new SamochodOkno(item.Model);
            samochodOkno.ShowDialog();
            if (samochodOkno.OK)
            {
                item.Model = samochodOkno.Model;
                BazaDanych.DajInstancje().Samochody.Zapisz();
            }
        }

        private void buttonUsunSamochod_Click(object sender, EventArgs e)
        {
            if (this.listViewSamochody.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Należy zaznaczyc zamochód do usuniecia");
                return;
            }
            SamochodItem item = (SamochodItem)this.listViewSamochody.SelectedItems[0];
            this.listViewSamochody.Items.Remove(item);
            BazaDanych.DajInstancje().Samochody.Usun(item.Model);
            BazaDanych.DajInstancje().Samochody.Zapisz();
            BazaDanych.DajInstancje().Uzytkownik.Samochody.Remove(item.Model.Id);
            BazaDanych.DajInstancje().Uzytkownicy.Zapisz();
        }

        private void buttonDodajStacje_Click(object sender, EventArgs e)
        {
            StacjaOkno stacjaOkno = new StacjaOkno();
            stacjaOkno.ShowDialog();
            if (stacjaOkno.OK)
            {
                StacjaItem item = new StacjaItem(stacjaOkno.Model);
                BazaDanych.DajInstancje().Stacje.Dodaj(stacjaOkno.Model);
                BazaDanych.DajInstancje().Stacje.Zapisz();
                this.listViewStacje.Items.Add(item);
            }
        }

        private void buttonEdytujStacje_Click(object sender, EventArgs e)
        {
            if (this.listViewStacje.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Należy zaznaczyc stacje do edycji");
                return;
            }
            StacjaItem item = (StacjaItem)this.listViewStacje.SelectedItems[0];
            StacjaOkno stacjaOkno = new StacjaOkno(item.Model);
            stacjaOkno.ShowDialog();
            if (stacjaOkno.OK)
            {
                item.Model = stacjaOkno.Model;
                BazaDanych.DajInstancje().Stacje.Zapisz();
            }
        }

        private void buttonUsunStacje_Click(object sender, EventArgs e)
        {
            if (this.listViewStacje.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Należy zaznaczyc stacje do usuniecia");
                return;
            }
            StacjaItem item = (StacjaItem)this.listViewStacje.SelectedItems[0];
            this.listViewStacje.Items.Remove(item);
            BazaDanych.DajInstancje().Stacje.Usun(item.Model);
            BazaDanych.DajInstancje().Stacje.Zapisz();
        }
    }
}
