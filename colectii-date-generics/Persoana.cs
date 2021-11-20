using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace colectii_date_generics
{
    public class Persoana :IComparable<Persoana>
    {
        private int id, cnp;
        private string name;

        public Persoana(string text)
        {
            string[] textSplit = text.Split(',');
            this.id = int.Parse(textSplit[0]);
            this.cnp = int.Parse(textSplit[1]);
            this.name = textSplit[2];
        }

        public override string ToString() => this.id + "," + this.name + "," + this.name;
        public override bool Equals(object obj)
        {
            Persoana pers = obj as Persoana;
            return pers.id == this.id;
        }
        public string afisare()
        {
            string text = "";
            text += "ID: " + this.id;
            text += "\nCNP: " + this.cnp;
            text += "\nID: " + this.id + "\n\n";
            return text;
        }

        public int CompareTo(Persoana other)
        {
            if (other.Name.Length > this.name.Length)
                return -1;
            else
            if (other.Name.Length == this.name.Length)
                return 0;
            else
            if (other.Name.Length < this.name.Length)
                return 1;
            return -2;
        }



        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public int Cnp
        {
            get => this.cnp;
            set => this.cnp = value;
        }
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }




    }
}
