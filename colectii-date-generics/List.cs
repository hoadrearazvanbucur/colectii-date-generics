using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace colectii_date_generics
{
    public  class List : IList
    {
        private Node head = null;
        //addSfarsit
        public void add(Masina masina)
        {
            if(head == null)
            {
                Node n = new Node();
                n.Data = masina;
                n.Next = null;
                this.head = n;
            }
            else
            {
                Node n = new Node();
                Node iterator = head;
                while (iterator.Next != null)
                {
                    iterator = iterator.Next;
                }
                iterator.Next = n;
                n.Next = null;
                n.Data = masina;    
            }
        }
        public void remove(int index)
        {
            Node save = head;
            int k = 0;
            if ((index - 1) < size() && (index - 1) > 0)
            {
                while (k < index-2)
                {
                    save = save.Next;
                    k++;
                }
                save.Next = save.Next.Next;
            }
            else if((index-1)==size())
            {
                save = null;
            }
            else if((index - 1) == 0)
            {
                while (save.Next!=null)
                {
                    save = save.Next;
                }
                save = null;
            }
        }

        public void remove(Masina masina)
        {
            throw new NotImplementedException();
        }






        public void contains(Masina masina)
        {
            throw new NotImplementedException();
        }

        public void get(int index)
        {
            throw new NotImplementedException();
        }

        public int indexOf(Masina masina)
        {
            return 0;
        }

        public void isEmpty()
        {
            throw new NotImplementedException();
        }


        public int size()
        {
            int k = 0;
            Node save = head;
            while (save != null)
            {
                k++;
                save = save.Next;
            }
            return k;
        }

        public int CompareTo([AllowNull] List other)
        {
            throw new NotImplementedException();
        }

        public string afisare()
        {
            Node save = head;
            string text = "";
            while(save!=null)
            {
                text+=save.Data.afisare()+"\n\n";
                save = save.Next;
            }
            return text;
        }


    }
}
