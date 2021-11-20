using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace colectii_date_generics
{
    public class Masina :IComparable<Masina>
    {
        string marca;
        int km;

        public Masina(string text)
        {
            string[] textSplit = text.Split(",");
            marca = textSplit[0];
            km = int.Parse(textSplit[1]);
        }

        public override bool Equals(object obj)
        {
            Masina mas = obj as Masina;
            return mas.km == this.km && mas.marca == this.marca;
        }
        public override string ToString() => this.marca + "," + this.km;
        public string afisare()
        {
            string text = "";
            text += "Marca: " + this.marca;
            text += "\nKilometri: " + this.km + "\n\n";
            return text;
        }

        public int CompareTo( Masina other)
        {
            if (other.marca.Length < this.marca.Length)
                return -1;
            else
            if (other.marca.Length == this.marca.Length)
                return 0;
            else
            if (other.marca.Length > this.marca.Length)
                return 1;
            return -2;
        }

        public string Marca
        {
            get => this.marca;
            set => this.marca = value;
        }
        public int Km
        {
            get => this.km;
            set => this.km = value;
        }


    }
}
