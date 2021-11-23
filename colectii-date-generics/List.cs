using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace colectii_date_generics
{
    public  class List : IList
    {
        private Node head = null;

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
            if (index < size() && index > 0)
            {
                while (k < index-1)
                {
                    save = save.Next;
                    k++;
                }
                save.Next = save.Next.Next;
            }
            else if(index==size())
            {
                save = null;
            }
            else if(index == 0)
            {
                head = save.Next;
            }
        }
        public void remove(Masina masina)
        {
            Node save = head;
            int k = 0;
            while(save!=null)
            {
                if (save.Data.ToString() == masina.ToString())
                    break;
                k++;
                save = save.Next;
            }
            remove(k);
        }
        public bool contains(Masina masina)
        {
            Node save = head;
            while(save!=null)
            {
                if (save.Data.ToString() == masina.ToString())
                    return true;
                save = save.Next;
            }
            return false;
        }
        public Node get(int index)
        {
            Node save = head;
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
        public int indexOf(Masina masina)
        {
            Node save = head;
            int k = 0;
            while (save != null)
            {
                if (save.Data.ToString() == masina.ToString())
                    return k;
                k++;
                save = save.Next;
            }
            return -1;
        }
        public bool isEmpty()
        {
            Node save = head;
            if (save != null)
                return false;
            return true;
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
        public void set(Masina masina,int index)
        {
            Node save = head;
            int k = 0;
            if (index != 0)
            {
                while (k < index - 1)
                {
                    save = save.Next;
                    k++;
                }
                Node m = new Node();
                m.Data = masina;
                m.Next = save.Next;
                save.Next = m;
            }
            else
            {
                Node m = new Node();
                m.Data = masina;
                m.Next = save;
                head = m;
            }
        }
        public void sortMarca()
        {
            int k;
            do{
                k = 0;
                for(int i=0;i<this.size()-1;i++)
                    if (this.get(i).Data.CompareTo(this.get(i+1).Data) == -1){
                        Masina aux = this.get(i).Data;
                        this.get(i).Data=this.get(i+1).Data;
                        this.get(i+1).Data=aux;
                        k=1;
                    }
            } while (k == 1);
        }
        public void sortKm()
        {
            KmComparer comparer = new KmComparer();
            int k;
            do
            {
                k = 0;
                for (int i = 0; i < this.size() - 1; i++)
                    if (comparer.Compare(this.get(i).Data,this.get(i+1).Data)==-1)
                    {
                        Masina aux = this.get(i).Data;
                        this.get(i).Data = this.get(i + 1).Data;
                        this.get(i + 1).Data = aux;
                        k = 1;
                    }
            } while (k == 1);
        }

        public Node Head
        {
            get => this.head;
            set => this.head = value;
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
