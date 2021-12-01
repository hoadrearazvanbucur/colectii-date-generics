using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace colectii_date_generics
{
    public class ControlMasina
    {
        private List lista;

        public ControlMasina()
        {
            this.lista = new List();
        }


        //Afisare
        public void afisare()
        {
            Console.WriteLine(lista.afisare());
        }


        //Adaugare
        public void adaugare(Masina masina)
        {
            lista.add(masina);
        }


        //Stergere
        public void stergere(int index)
        {
            lista.remove(index);
        }


        //Modificare
        public void modificareMarca(Masina masina,string marca)
        {
            lista.get(lista.indexOf(masina)).Data.Marca = marca;
        }
        public void modificareKm(Masina masina, int km)
        {
            lista.get(lista.indexOf(masina)).Data.Km = km;
        }



        public List Lista
        {
            get => this.lista;
            set => this.lista = value;
        }
    }
}
