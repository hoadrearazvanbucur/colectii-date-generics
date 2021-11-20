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
        abstract void contains(Masina masina);
        abstract void isEmpty();
        abstract int indexOf(Masina masina);
        abstract int size();
        abstract void get(int index);       
    }
}
