using System;
using System.Collections.Generic;
using System.Text;

namespace colectii_date_generics
{
    public class TemaList :IListTema
    {
        private NodeTema head = null;
        public NodeTema Head
        {
            get => this.head;
            set => this.head = value;
        }

        public void add(int data)
        {
            if (head == null)
            {
                NodeTema n = new NodeTema();
                n.Data = data;
                n.Next = null;
                this.head = n;
            }
            else
            {
                NodeTema n = new NodeTema();
                NodeTema iterator = head;
                while (iterator.Next != null)
                    iterator = iterator.Next;
                iterator.Next = n;
                n.Next = null;
                n.Data = data;
            }
        }
        public void remove(int index)
        {
            NodeTema save = head;
            int k = 0;
            if (index < size() && index > 0)
            {
                while (k < index - 1)
                {
                    save = save.Next;
                    k++;
                }
                save.Next = save.Next.Next;
            }
            else if (index == size())
            {
                save = null;
            }
            else if (index == 0)
            {
                head = save.Next;
            }
        }
        public void removeData(int data)
        {
            NodeTema save = head;
            int k = 0;
            while (save != null)
            {
                if (save.Data == data)
                    break;
                k++;
                save = save.Next;
            }
            remove(k);
        }
        public bool contains(int data)
        {
            NodeTema save = head;
            while (save != null)
            {
                if (save.Data == data)
                    return true;
                save = save.Next;
            }
            return false;
        }
        public NodeTema get(int index)
        {
            NodeTema save = head;
            int k = 0;
            while (save != null)
            {
                if (k == index)
                    return save;
                save = save.Next;
                k++;
            }
            return null;
        }
        public int indexOf(int data)
        {
            NodeTema save = head;
            int k = 0;
            while (save != null)
            {
                if (save.Data == data)
                    return k;
                k++;
                save = save.Next;
            }
            return -1;
        }
        public bool isEmpty()
        {
            NodeTema save = head;
            if (save != null)
                return false;
            return true;
        }
        public int size()
        {
            int k = 0;
            NodeTema save = head;
            while (save != null)
            {
                k++;
                save = save.Next;
            }
            return k;
        }
        public void set(int data, int index)
        {
            NodeTema save = head;
            int k = 0;
            if (index != 0)
            {
                while (k < index - 1)
                {
                    save = save.Next;
                    k++;
                }
                NodeTema m = new NodeTema();
                m.Data = data;
                m.Next = save.Next;
                save.Next = m;
            }
            else
            {
                NodeTema m = new NodeTema();
                m.Data = data;
                m.Next = save;
                head = m;
            }
        }
        public string afisare()
        {
            NodeTema save = head;
            string text = "";
            while (save != null)
            {
                text += save.Data + "  ";
                save = save.Next;
            }
            return text;
        }


        /*
        
        1.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Suma tuturor numerelor.

        */



        /*
        
        2.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Produsul elementelor pe pozitii impare.

        */
        /*
        
        3.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Media aritmetica a tuturor numerelor.

        */
        /*
        
        4.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Cmmdc-ul tuturor numerelor.

        */
        /*
        
        5.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Cifra de control a fiecarui element.

        */
        /*
        
        6.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Sa se afiseze numerele prime.

        */
        /*
        
        7.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Sa se afiseze numere care sunt prime intre ele cu pozitia lor in lista.

        */
        /*
        
        8.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Sortare crescatoare a listei.

        */

        public void sort()
        {
            int k;
            do
            {
                k = 0;
                for (int i = 0; i < this.size() - 1; i++)
                    if (this.get(i).Data > this.get(i + 1).Data)
                    {
                        int aux = this.get(i).Data;
                        this.get(i).Data = this.get(i + 1).Data;
                        this.get(i + 1).Data = aux;
                        k = 1;
                    }
            } while (k == 1);
        }

        /*
        
        9.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Stergere elemente impare.

        */
        /*
        
        10.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se afiseze elementele din lista care sunt multipli ai ultimului element.

        */
        /*
        
        11.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se afiseze elementele vectorului in urmatoarea ordine: primul, ultimul, al doilea, penultimul, etc.

        */
        /*
        
        12.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se determine maximul si minimul valorilor elementelor din lista.

        */
        /*
        
        13.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se determine indicele maximului si cel al minimului valorilor elementelor unui vector.

        */
        /*
        
        14.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se afiseze elementele cuprinse intre elementul cu valoarea minima si cel cu valoare maxima din vector, inclusiv acestea.

        */
        /*
        
        15.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se determine cate elemente din sir sunt egale cu ultimul element al acestuia.

        */
        /*
        
        16.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se se afiseze elementele din sir care au proprietatea ca primele doua cifre din scrierea zecimala
                   formeaza un patrat perfect.

        */
        /*
        
        17.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se determine perechea de elemente dintr-un vector egal deprtate de centru cu suma elementelor maxima.

        */
        /*
        
        18.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se determine pozitia pe care s-ar afla primul element al sirului în sirul sortat.

        */
        /*
        
        19.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Determinati cate dintre numerele date apar o singura data.

        */
        /*
        
        20.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se inlocuiasca toate elementele nule dintr-un vector cu elemente numere naturale
                   cu partea întreaga a mediei aritmetice a elementelor nenule din vector.

        */
    }
}
