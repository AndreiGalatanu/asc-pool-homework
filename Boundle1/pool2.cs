using System;
using System.Collections.Generic;
using System.Text;

namespace Boundle1
{
    class pool2
    {
        //Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 

        public void secventaNrPare()
        {
            Console.WriteLine(" Se da o secventa de n nuere");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }


        }

        //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
        public void detNum()
        {
            int negativ = 0;
            int cuZero = 0;
            int pozitiv = 0;
            Console.WriteLine("Se da o secventa de numere de la n ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("pana la ");
            int z = int.Parse(Console.ReadLine());

            for (int i = n; i <= z; i++)
            {
                if (i < 0)
                {
                    negativ++;
                }
                else if (i == 0)
                {
                    cuZero++;
                }
                else
                {
                    pozitiv++;
                }

            }
            Console.WriteLine("numere negative {0} ,numere cu 0 {1} , numere pozitive {2}", negativ, cuZero, pozitiv);
        }

        internal void sumaSiProdusus()
        {
            Console.WriteLine("Suma si produsul numerelor de la 1 la");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            double produsul = 1;
            for (int i = 1; i <= n; i++)
            {
                suma = suma + i;
                produsul = produsul * i;
            }
            Console.WriteLine("suma = " + suma + " produsul = " + produsul);
        }

        internal void pozInSec()
        {
            Console.WriteLine("Secventa de numere ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("se cauta numarul  ");
            int a = int.Parse(Console.ReadLine());
            int[] numere = new int[n];
            Random random = new Random();
            int raspuns = -1;
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = random.Next(0, 10);
            }


            for (int i = 0; i < numere.Length; i++)
            {
                if (a == numere[i])
                {
                    Console.WriteLine("numarul {0} se afla in pozitia {1}", a, i);
                    raspuns = i;
                }

            }
            if (raspuns < 0)
            {
                Console.WriteLine(raspuns);
            }


        }

        internal void egalCuPozitia()
        {
            Console.WriteLine("Secventa de numere ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cate numere sunt egale cu pozitia  ");
            int pozitia = int.Parse(Console.ReadLine());
            int count = 0;
            int[] numere = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = rnd.Next(0, 10);
            }

            for (int i = 0; i < numere.Length; i++)
            {
                if (i == pozitia && numere[i] == pozitia)
                {
                    count++;
                    Console.WriteLine(count + "");
                }



            }

        }
        //Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
        internal void secventaCrescatoare()
        {
            Console.WriteLine("Secventa de numere ");
            int n = int.Parse(Console.ReadLine());
            int estecresc = 0;
            int nuestecrescatoare = 0;

            int[] numere = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = rnd.Next(0, 1000);
                Console.Write(numere[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < numere.Length - 1; i++)
            {


                if (numere[i] > numere[i + 1])
                {
                    nuestecrescatoare++;
                }
                else
                {
                    estecresc++;
                }

            }
            if (estecresc == 0)
            {
                Console.WriteLine("secventa este crescatoare");
            }
            else { Console.WriteLine("nu este crescatoare"); }
        }
        //Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
        internal void secventaMonotona()
        {
            int n;
            Console.WriteLine("Introduceti un numar de la tastatura ");

            int nr_crescator = 0;
            int nr_descrescator = 0;


            Random rnd = new Random();

            int x = rnd.Next(21);

            try
            {
                Console.Write("n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");
                Console.WriteLine("Secventa este : ");
                Console.Write($"{x} x : ");
                Console.WriteLine();
                for (int i = 0; i < n - 1; i++)
                {
                    int y = rnd.Next(21);
                    Console.WriteLine(y + " ");
                    if (x < y)
                    {
                        nr_crescator++;
                    }
                    else if (y < x)
                    {
                        nr_descrescator++;
                    }
                    x = y;
                }
                Console.WriteLine();
                if (nr_crescator > 0 && nr_descrescator == 0)
                {
                    Console.WriteLine(" Secventa crescatoare");
                }
                if (nr_crescator == 0 && nr_descrescator > 0)
                {
                    Console.WriteLine(" Secventa este descrescatoare");
                }
                if (nr_crescator > 0 && nr_descrescator > 0)
                {
                    Console.WriteLine("secventa nu este monotona");

                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        //Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
        internal void numarMaximInSecveta(int n)
        {
            Random rnd = new Random();
            try
            {
                Console.Write("n: " + n);


                int nr_consecutive = 1;
                int Lungime_Max_secventa = 0;

                int x = 3;
                Console.WriteLine();
                Console.WriteLine("Secventa data este: ");
                Console.Write($"{x} = x");
                Console.WriteLine();
                for (int i = 0; i <= n; i++)
                {

                    int y = rnd.Next(2);
                    Console.Write($"{y} ");

                    if (x == y) //conditia pt ca numerele sa fie consecutive
                    {
                        nr_consecutive++;
                        if (nr_consecutive > Lungime_Max_secventa)
                            Lungime_Max_secventa = nr_consecutive;
                    }
                    else
                        nr_consecutive = 1;


                    x = y;

                }

                Console.WriteLine();

                Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa data este: {Lungime_Max_secventa}");

                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }



        //Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 

        internal void sumaInverselor(int n)
        {
            Random rnd = new Random();
            Console.Write("n: " + n);

           int sum = 0;

          int x;

            Console.WriteLine("Secventa este: ");

            for (int i = 0; i <= n; i++)
            {
                x = rnd.Next(100);
                Console.WriteLine(" " + x);

               

            }
            Console.WriteLine("suma este" + sum);
        }














        //Determianti al n-lea numar din sirul lui Fibonacci. 
        internal void secventaFib(int number)
        {
            int n1 = 1, n2 = 1, n3 = 0;



            if (number < 1)
            {
                return;
            }
            if (number == 1)
            {
                Console.WriteLine(1);
            }
            number = number - 2;
            while (number != 0)
            {
                n3 = n1 + n2;
                number--;
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine("al " + number + " numar din sirul lui fibonaci este : " + n3);

        }

        //Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
        internal void secventaMicaSiMare()
        {
            Console.WriteLine("Secventa de numere ");
            int n = int.Parse(Console.ReadLine());
     

            int min = 100;
            int max = 0;
            int[] numere = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = rnd.Next(0, 1000);
                Console.Write(numere[i] + " ");
            }
            for (int i = 0; i < numere.Length - 1; i++)
            {
                if (numere[i] > numere[i + 1])
                {
                    if (max < numere[i])
                    {
                        max = numere[i];

                    }
                }
                else if (numere[i] < numere[i + 1])
                {

                    if (min > numere[i])
                    {
                        min = numere[i];

                    }
                }


            }
            Console.WriteLine();
            Console.WriteLine("minumul este {0} si maxim este {1}", min, max);




        }
    }
}