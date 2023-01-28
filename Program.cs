using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // P1();
            // P2();
            // P3();
            // P4();
            // P5();
            // P8();
            // P11();
            // P15();
            Console.ReadKey();
        }

       

        static void P1()//1. Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
        {
            Console.WriteLine("Scrie un numar");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Scrie {n} nimere");
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            int s = 0;
            for (int i = 0; i < n; i++)
                s += v[i];
            Console.WriteLine(s);
        }
        static void P2()//2. Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k.
                        //   Daca k nu apare in vector rezultatul va fi -1. 
        {
            Console.WriteLine("Scrie un sir de numere");
            string[] t = Console.ReadLine().Split(' ');
            int n = int.Parse(t[0]);
            int k = int.Parse(t[1]);
            bool ok = false;
            t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            for (int i = 0; i < n; i++)
                if (v[i] == k)
                {
                    Console.WriteLine(i);
                    ok = true;
                    break;
                }
            if (!ok)
                Console.WriteLine("-1");
        }
        static void P3()//3. Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
                        //   Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 
        {
            Console.WriteLine("Scrie un numar n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Scrie {n} numere");
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
                int min = v[0], pmin = v[0];
                int max = v[0], pmax = v[0];
            for (int i = 0; i < n; i++)
            {
                if (v[i] < min) min = v[i];
                if (v[i] > max) max = v[i];
            }
            for(int i = 0; i < n;++i)
            {
                pmin = v[0] - min;
                pmax = max - v[0]; 
            }


            Console.Write($"{pmin} {pmax}");


        }
        static void P4()//Deteminati printr-o singura parcurgere,
                        //cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 
        {
            Console.WriteLine("Scrie un numar");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Scrie {n} numere ");
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            int min = v[0];
            int max = v[0];
            int ap = 0;  
            for (int i = 0; i < n; i++)
            {
                if (v[i] < min) min = v[i]; 
                if (v[i] > max) max = v[i];
                ap++;
            }
            Console.WriteLine($"{min} {max} {ap}");

        }

        private static void P5()
        {
            //Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
            //Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.
            Console.WriteLine("Scrie un numar n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Scrieti{n} numere");
            string[] t = Console.ReadLine().Split(' ');
            Console.WriteLine("Alege un element din numere de mai sus");
            int e = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int aux = 0;
            int pe, pk = 0;
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            for (int i = 0; i < n; i++) ;
        }
        static void P8()//8. Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.
                        //   Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 

        {
            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            int aux = v[0];
            for (int i = 0; i < n - 1; i++)
                v[i] = v[i + 1];
            for (int i = 0; i < n; i++)
                v[n - 1] = aux;
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        static void P11()//Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). ,,
        {
            int n = int.Parse(Console.ReadLine());
            bool[] v = new bool[n];
            int idx = 2;
            do
            {
                int k = 1;
                while (idx * k < n)
                {
                    v[idx * k] = true;
                    k++;
                }
                while (v[idx] == true) idx++;
                Console.WriteLine(idx + " ");
                for (int i = 0; i < n; i++) ;
                //   Console.WriteLine(v[i] + " ");
            }
            while (idx < n - 1);
            Console.WriteLine(idx);
        }
        static void P15()//Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 
        {
            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split(' ');
            int k = n - 1;
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                bool ok = false;
                for (int j = 0; j < n; j++)
                    if (v[i] == v[j])
                    {
                        ok = true;
                        break;
                    }
                if (ok)
                {
                    int aux = v[i]; v[i] = v[k]; v[v[k]] = aux; k--; i--;
                }
                Console.WriteLine(k);
            }

        }
    

    }
}
