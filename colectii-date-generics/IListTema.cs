using System;
using System.Collections.Generic;
using System.Text;

namespace colectii_date_generics
{
    public interface IListTema
    {
        abstract void add(int data);
        abstract void remove(int index);
        abstract void removeData(int data);
        abstract bool contains(int data);
        abstract bool isEmpty();
        abstract int indexOf(int data);
        abstract int size();
        abstract NodeTema get(int index);
        abstract void set(int data, int index);
    }
}
