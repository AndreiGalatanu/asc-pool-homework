using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Xml.Serialization;

namespace Boundle1
{
    class ExercitiiVectori
    {
        //Se dă un șir cu n elemente, numere naturale. Determinați diferența în valoare absolută dintre numărul de valori
        //pare din șir și numărul de valori impare din șir.
        public void diferenta()
        {
            Console.WriteLine(" Marimea sirului este");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            int par = 0; int impar = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(par + " par " + impar + " impar");
            int rest;
            if (par < impar)
            {
                rest = impar - par;
            }
            else
            {
                rest = par - impar;
            }

            Console.WriteLine(rest + " diferenta ");

        }
        //Se citește un vector cu n elemente, numere naturale.Să se afișeze elementele cu indici pari
        //în ordinea crescătoare a indicilor, iar elementele cu indici impari în ordinea descrescătoare a indicilor
        public void prob2()
        {
            Console.WriteLine(" Selectati marimea");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            List<int> par = new List<int>();
            List<int> impar = new List<int>();


            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {

                    par.Add(arr[i]);


                }
                else
                {
                    impar.Add(arr[i]);
                }

            }

            par.Sort();
            impar.Sort();
            impar.Reverse();
            foreach (var item in par)
            {
                Console.Write(" {0}", item);
            }
            Console.WriteLine();
            foreach (var item in impar)
            {
                Console.Write(" {0}", item);
            }


        }
        public void prob3()//Se citește un vector cu n elemente, numere naturale. 
                           //Să se afișeze elementele vectorului în următoarea ordine: primul, ultimul, al doilea, penultimul, etc.
        {
            Console.WriteLine(" Selectati marimea");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int k = 0; k < n; k++)
            {
                arr[k] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            for (int j = 0; j < n / 2; j++)
            {
                Console.WriteLine(arr[j] + " ");
                Console.WriteLine(arr[n - j - 1] + " ");
            }
            if (n % 2 != 0)
            {
                Console.WriteLine(arr[n / 2]);
            }

        }

        public void sortVector()
        {
            Console.WriteLine("Pick the lenght of the array");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }



            for (int i = 0; i < v.Length - 1; i++)
            {

                for (int j = 0; j < v.Length - i - 1; j++)
                {
                    if (v[j] > v[j + 1])
                    {
                        int temp = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = temp;


                    }

                }


            }
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");

            }

        }

        //Se dau n numere naturale nenule. Ordonați descrescător cele n numere după numărul lor de divizori.
        public void afisareMultipli()
        {
            Console.WriteLine(" mariema arrayului");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }




            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }




        }

    }


}
