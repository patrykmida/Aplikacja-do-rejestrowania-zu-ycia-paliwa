using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenyPaliw
{
    class Zbior<T> where T : Element
    {
        List<T> lista;
        Dictionary<Guid, T> slownikElementow;
        string nazwaPliku;

        public Zbior(string nazwa)
        {
            this.nazwaPliku = nazwa + ".txt";
            lista = new List<T>();
            slownikElementow = new Dictionary<Guid, T>();
           
        }

        public T this[Guid id]
        {
            get
            {
                return slownikElementow[id];
            } 
                
        }

        public void Dodaj(T element)
        {
            lista.Add(element);
            slownikElementow.Add(element.Id,element);
        }
        public void Usun(Guid id)
        {
            T element = slownikElementow[id];
            lista.Remove(element);
            slownikElementow.Remove(id);
        }
        public void Usun(T element)
        {
            lista.Remove(element);
            slownikElementow.Remove(element.Id);
        }
        public void Zapisz()
        {
            Serializator.Serialize<T>(lista, nazwaPliku);
        }
        public void Wczytaj()
        {
            lista.Clear();
            slownikElementow.Clear();
            if (File.Exists(nazwaPliku))
            {
                lista = Serializator.Deserialize<T>(nazwaPliku);
            }
            
            foreach (T element in lista)
            {
                slownikElementow.Add(element.Id, element);
            }
        }
        public List<T> Lista
        {
            get
            {
                return lista;
            }
        }

    }
}
