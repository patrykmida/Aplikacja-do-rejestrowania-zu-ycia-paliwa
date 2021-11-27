using CenyPaliw.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenyPaliw
{
    class BazaDanych
    {
        private static BazaDanych instancja;

       
        UzytkownikModel uzytkownik;

        private Zbior<UzytkownikModel> uzytkownicy;
        private Zbior<StacjaModel> stacje;
        private Zbior<SamochodModel> samochody;
        private Zbior<ProducentModel> producenci;
        private Zbior<CenaPaliwaModel> cenyPaliw;
        private BazaDanych()
        {
            uzytkownicy = new Zbior<UzytkownikModel>("uzytkownicy");
            stacje = new Zbior<StacjaModel>("stacje");
            samochody = new Zbior<SamochodModel>("samochody");
            producenci = new Zbior<ProducentModel>("producenci");
            cenyPaliw = new Zbior<CenaPaliwaModel>("cenyPaliw");
            
            uzytkownicy.Wczytaj();
            stacje.Wczytaj();
            samochody.Wczytaj();
            producenci.Wczytaj();
            cenyPaliw.Wczytaj();

            if(uzytkownicy.Lista.Count == 0)
            {
                UzytkownikModel uzytkownik = new UzytkownikModel();
                uzytkownik.Login = "Admin";
                uzytkownik.Haslo = "Admin";
                uzytkownik.CzyAdmin = true;
                uzytkownicy.Dodaj(uzytkownik);
                uzytkownicy.Zapisz();
            }

            uzytkownik = null;
        }

        public static BazaDanych DajInstancje()
        {
            if (instancja == null)
            {
                instancja = new BazaDanych();
            }
            return instancja;
        }

        public bool Zaloguj(string login, string haslo)
        {
            uzytkownik = ZnajdzUzytkownika(login);
            if(uzytkownik!=null && uzytkownik.Haslo == haslo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
        public UzytkownikModel Uzytkownik
        {
            get => uzytkownik;
        }

       

        public Zbior<UzytkownikModel> Uzytkownicy
        {
            get
            {
                return uzytkownicy;
            }
        }
        public Zbior<StacjaModel> Stacje
        {
            get
            {
                return stacje;
            }
        }

        public Zbior<SamochodModel> Samochody
        {
            get
            {
                return samochody;
            }
        }

        public Zbior<ProducentModel> Producenci
        {
            get
            {
                return producenci;
            }
        }

        public Zbior<CenaPaliwaModel> CenyPaliw
        {
            get
            {
                return cenyPaliw;
            }
        }
        private UzytkownikModel ZnajdzUzytkownika(string login)
        {
            foreach (UzytkownikModel uzytkownik in uzytkownicy.Lista)
            {
                if (uzytkownik.Login == login)
                {
                    return uzytkownik;
                }
            }
            return null;
        }

    }
}
