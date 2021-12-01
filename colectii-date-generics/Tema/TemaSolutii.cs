using System;
using System.Collections.Generic;
using System.Text;

namespace colectii_date_generics
{
    public class TemaSolutii
    {
        /*

        1.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Suma tuturor numerelor.

        */
        public void problema1()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare()+"\n\n");

            Console.WriteLine("Suma: "+list.suma());
        }

        /*
        
        2.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Produsul elementelor pe pozitii impare.

        */
        public void problema2()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\n");

            Console.WriteLine("Produs : " + list.produsImp());
        }

        /*
        
        3.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Media aritmetica a tuturor numerelor.

        */
        public void problema3()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\n");

            Console.WriteLine("Media aritmetica:" + list.ma());
        }

        /*
        
        4.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Cmmdc-ul tuturor numerelor.

        */
        public void problema4()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\n");

            Console.WriteLine("Cmmdc: " + list.cmmdcList());
        }

        /*
        
        5.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Cifra de control a fiecarui element.

        */
        public void problema5()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\n"+"Cifra Control:\n");

            int[] x = list.cControl();
            int k = 0;
            while(x[k]!=0)
                Console.WriteLine(x[k++].ToString());
        }

        /*
        
        6.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Sa se afiseze numerele prime.

        */
        public void problema6()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\nNumere prime:\n");

            int[] x = list.nrPrime();
            int k = 0;
            while (x[k] != 0)
                Console.WriteLine(x[k++].ToString());
        }

        /*
        
        7.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Sa se afiseze numere care sunt prime intre ele cu pozitia lor in lista.

        */
        public void problema7()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\nNumere prime intre ele cu pozitia:\n");

            int[] x = list.primeEle();
            int k = 0;
            while (x[k] != 0)
                Console.WriteLine(x[k++].ToString());
        }

        /*
        
        8.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Sortare crescatoare a listei.

        */
        public void problema8()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\nElementele sortate crescator:\n");

            list.sort();
            Console.WriteLine(list.afisare());
        }

        /*
        
        9.Input:  O lista citita de la tastatura cu n elemente.
         Output:  Stergere elemente impare.

        */
        public void problema9()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\nFara numere impare:\n");
            list.stergeImp();
            Console.WriteLine(list.afisare());
        }

        /*
        
        10.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se afiseze elementele din lista care sunt multipli ai ultimului element.

        */
        public void problema10()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\nMultiplu ultimului element sunt:\n");

            int[] x = list.multipliU();
            int k = 0;
            while (x[k] != 0)
                Console.WriteLine(x[k++].ToString());
        }

        /*
        
        11.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se afiseze elementele listei in urmatoarea ordine: primul, ultimul, al doilea, penultimul, etc.

        */
        public void problema11()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\nElementele listei dupa regula:\n");
            list.regulaSchimbare();
        }

        /*
        
        12.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se determine maximul si minimul valorilor elementelor din lista.

        */
        public void problema12()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\n");
            Console.WriteLine("Maxim: " + list.maxim());
            Console.WriteLine("Minim: " + list.minim());
        }

        /*
        
        13.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se determine indicele maximului si cel al minimului valorilor elementelor unui vector.

        */
        public void problema13()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\n");
            list.indiceMaxMin();
        }

        /*
        
        14.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se afiseze elementele cuprinse intre elementul cu valoarea minima si cel cu valoare maxima din vector, inclusiv acestea.

        */
        public void problema14()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\n");
            list.intervalMaxMin();

        }

        /*
        
        15.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se determine cate elemente din sir sunt egale cu ultimul element al acestuia.

        */
        public void problema15()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\n" + list.nrEleUlt()+" elemente egale cu ultimul element");
        }

        /*
        
        16.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se se afiseze elementele din sir care au proprietatea ca primele doua cifre din scrierea zecimala
                   formeaza un patrat perfect.

        */
        public void problema16()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\nPrimele doua cifre patrt perfect");
            list.douaPatrat();

        }

        /*
        
        17.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se determine perechea de elemente dintr-o lista egal deprtate de centru cu suma elementelor maxima.

        */
        public void problema17()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\nPerechea maxima egal departata de mijloc");
            list.egalDep();
        }

        /*
        
        18.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se determine pozitia pe care s-ar afla primul element al sirului în sirul sortat.

        */
        public void problema18()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\nPozitia primului element in lista sortata");
            Console.WriteLine(list.pozSort());
        }

        /*
        
        19.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Determinati cate dintre numerele date apar o singura data.

        */
        public void problema19()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\nNumerele care apar o singura data sunt:");
            list.singuraData();
        }

        /*
        
        20.Input:  O lista citita de la tastatura cu n elemente.
          Output:  Sa se inlocuiasca toate elementele nule dintr-un vector cu elemente numere naturale
                   cu partea întreaga a mediei aritmetice a elementelor nenule din vector.

        */
        public void problema20()
        {
            TemaList list = new TemaList();
            Console.WriteLine("Introduceti lungimea listei.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti elementele listei.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}  ->  ");
                list.add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nElementele listei:");
            Console.WriteLine(list.afisare() + "\n\nNoua lista dupa inlocuirea elementelor nule");
            list.inlocNul();
            Console.WriteLine(list.afisare());
        }

    }
}
