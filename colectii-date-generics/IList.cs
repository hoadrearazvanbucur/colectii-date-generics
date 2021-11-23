using System;
using System.Collections.Generic;
using System.Text;

namespace colectii_date_generics
{
    public interface IList
    {
        abstract void add(Masina masina);
        abstract void remove(int index);
        abstract void remove(Masina masina);
        abstract bool contains(Masina masina);
        abstract bool isEmpty();
        abstract int indexOf(Masina masina);
        abstract int size();
        abstract Node get(int index);
        abstract void set(Masina masina,int index);
        abstract void sortMarca();
    }
}
