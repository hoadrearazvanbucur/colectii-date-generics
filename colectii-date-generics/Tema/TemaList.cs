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

        public int suma()
        {
            NodeTema save = head;
            int s = 0;
            while(save!=null)
            {
                s += save.Data;
                save = save.Next;
            }
            return s;
        }

        /*
        
        2.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Produsul elementelor pe pozitii impare.

        */

        public int produsImp()
        {
            NodeTema save = head;
            int p = 1,k=0;
            while (save != null)
            {
                if(k%2==0)
                p *= save.Data;
                k++;
                save = save.Next;
            }
            return p;
        }
        
        /*
        
        3.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Media aritmetica a tuturor numerelor.

        */

        public int ma()
        {
            return suma() / size();
        }

        /*
        
        4.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Cmmdc-ul tuturor numerelor.

        */
        public int cmmdc(int a,int b)
        {
            while (a != b)
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            return a;
        }

        public int cmmdcList()
        {
            NodeTema save = head;
            int a = save.Data;
            save = save.Next;
            while(save!=null)
            {
                a = cmmdc(a, save.Data);
                save = save.Next;
            }
            return a;
        }

        /*
        
        5.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Cifra de control a fiecarui element.

        */
        public int sumCif(int a)
        {
            int s = 0;
            while(a!=0)
            {
                s += a % 10;
                a = a / 10;
            }
            return s;
        }
        
        public int cifraControl(int a)
        {
            while ((a=sumCif(a)) > 9)
                a = sumCif(a);
            return a;
        }

        public int[] cControl()
        {
            NodeTema save = head;
            int[] x = new int[100];
            int k = 0;
            while(save!=null)
            {
                x[k++] = cifraControl(save.Data);
                save = save.Next;
            }
            return x;
        }

        /*
        
        6.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Sa se afiseze numerele prime.

        */

        public bool prim(int a)
        {
            for (int i = 2; i <= a / 2; i++)
                if (a % i == 0)
                    return false;
            return true;
        }

        public int[] nrPrime()
        {
            NodeTema save = head;
            int[] x = new int[100];
            int k = 0;
            while(save!=null)
            {
                if (prim(save.Data) == true)
                    x[k++] = save.Data;
                save = save.Next;
            }
            return x;
        }

        /*
        
        7.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Sa se afiseze numere care sunt prime intre ele cu pozitia lor in lista.

        */

        public int[] primeEle()
        {
            NodeTema save = head;
            int[] x = new int[100];
            int k = 0,k1=1;
            while (save != null)
            {
                if (cmmdc(save.Data,k1)==1)
                    x[k++] = save.Data;
                k1++;
                save = save.Next;
            }
            return x;
        }

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

        public void stergeImp()
        {
            NodeTema save = head;
            int k = 0;
            while(save!=null)
            {
                if (save.Data % 2 == 1)
                {
                    this.remove(k);
                    k--;
                }
                k++;
                save = save.Next;
            }
        }

        /*
        
        10.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se afiseze elementele din lista care sunt multipli ai ultimului element.

        */

        public int[] multipliU()
        {
            NodeTema save = head;
            int[] x = new int[100];
            int k = 0, k1 = 1,d=this.size()-1;
            while (save.Next != null)
            {
                if (save.Data % this.get(d).Data == 0)
                    x[k++] = save.Data;
                k1++;
                save = save.Next;
            }
            return x;
        }

        /*
        
        11.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se afiseze elementele din lista in urmatoarea ordine: primul, ultimul, al doilea, penultimul, etc.

        */

        public void regulaSchimbare()
        {
            for (int i = 0; i < this.size() / 2; i++)
                Console.Write(this.get(i).Data + " , " + this.get(this.size()-1 - i).Data +" , ");
            if(this.size()%2==1)
                Console.Write(this.get((this.size() - 1) / 2).Data);
        }

        /*
        
        12.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se determine maximul si minimul valorilor elementelor din lista.

        */

        public int maxim()
        {
            NodeTema save = head;
            int maxim = -1;
            while(save!=null)
            {
                if (maxim < save.Data)
                    maxim = save.Data;
                save = save.Next;
            }
            return maxim;
        }

        public int minim()
        {
            NodeTema save = head;
            int minim = 999;
            while (save != null)
            {
                if (minim> save.Data)
                    minim = save.Data;
                save = save.Next;
            }
            return minim;
        }

        /*
        
        13.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se determine indicele maximului si cel al minimului valorilor elementelor unei liste.

        */

        public void indiceMaxMin()
        {
            Console.WriteLine("Indicele maximului: " + this.indexOf(this.maxim()));
            Console.WriteLine("Indicele minimului: " + this.indexOf(this.minim()));
        }

        /*
        
        14.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se afiseze elementele cuprinse intre elementul cu valoarea minima si cel cu valoare maxima din lista, inclusiv acestea.

        */

        public void intervalMaxMin()
        {
            for (int i = this.indexOf(this.maxim()); i <= this.indexOf(this.minim()); i++)
                Console.Write(this.get(i).Data+" , ");
        }

        /*
        
        15.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se determine cate elemente din sir sunt egale cu ultimul element al acestuia.

        */

        public int nrEleUlt()
        {
            NodeTema save = head;
            int u = this.get(this.size() - 1).Data,k=0;
            while(save.Next!=null)
            {
                if (save.Data == u)
                    k++;
                save = save.Next;
            }
            return k;
        }

        /*
        
        16.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se se afiseze elementele din sir care au proprietatea ca primele doua cifre din scrierea zecimala
                   formeaza un patrat perfect.

        */

        public void douaPatrat()
        {
            NodeTema save = head;
            while(save!=null)
            {
                int a = save.Data;
                while(save.Data/100 !=0)
                    save.Data /= 10;
                if (save.Data > 9 && (int)Math.Sqrt(save.Data) == (double)Math.Sqrt(save.Data))
                    Console.WriteLine(a);
                save = save.Next;
            }
        }

        /*
        
        17.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se determine perechea de elemente dintr-o lista egal departate de centru cu suma elementelor maxima.

        */

        public void egalDep()
        {
            int maxim = 0,a=1,b=1;
            for (int i = 0; i < this.size() / 2; i++)
                if (maxim < this.get(i).Data + this.get(this.size() - 1 - i).Data)
                {
                    maxim = this.get(i).Data + this.get(this.size() - 1 - i).Data;
                    a = this.get(i).Data;
                    b = this.get(this.size() - 1 - i).Data;
                }
            Console.WriteLine(a.ToString() + "  " + b.ToString());
        }

        /*
        
        18.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se determine pozitia pe care s-ar afla primul element al sirului în sirul sortat.

        */

        public int pozSort()
        {
            int a = this.get(0).Data,k=0;
            this.sort();
            NodeTema save = head;
            while(save!=null)
            {
                if (save.Data == a)
                    return k;
                    k++;
                save = save.Next;
            }
            return -1;
        }

        /*
        
        19.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Determinati cate dintre numerele date apar o singura data.

        */

        public void singuraData()
        {
            int[] x = new int[100];
            NodeTema save = head;
            while(save!=null)
            {
                x[save.Data]++;
                save = save.Next;
            }
            for (int i = 0; i < 100; i++)
                if (x[i] == 1)
                    Console.WriteLine(i);
        }

        /*
        
        20.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se inlocuiasca toate elementele nule dintr-un vector cu elemente numere naturale
                   cu partea întreaga a mediei aritmetice a elementelor nenule din vector.

        */

        public void inlocNul()
        {
            for (int i = 1; i < this.size() - 1; i++)
                if (this.get(i).Data == 0)
                    this.get(i).Data = (this.get(i - 1).Data + this.get(i + 1).Data) / 2;
        }
    }
}
