using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Boundle1
{
    class pool1
    {

        public void one()//Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
        {
            int a, b;
            Console.WriteLine("Enter A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine(" Infinite solutions");
                }
                else
                {
                    Console.WriteLine(" imposible ecuation");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("X = -{0}", x);
            }

        }

        //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        internal void laturiTriunghui()
        {
            Console.WriteLine(" dan 3 numre abc");
            string line = Console.ReadLine();
            string[] token = line.Split(' ');

            int a = int.Parse(token[0]);
            int b = int.Parse(token[1]);
            int c = int.Parse(token[2]);

            if (a + b > c && b + c > a && c + a > b)

            {
                Console.WriteLine("este triunghi");
            }
            else
            {
                Console.WriteLine("nu este triunghi ");
            }




        }

        internal void orindeInveras()
        {
            Console.WriteLine("Afisami numarul n in revers ");
            int n = int.Parse(Console.ReadLine());
            int aux = 0;
            while (n > 0)
            {
                if (n > 0)
                {
                    int last = n % 10;
                    n /= 10;

                    aux = aux * 10 + last;

                }

            }

            Console.WriteLine(aux);

        }

        internal void nrPrim()//Test de primalitate: determinati daca un numar n este prim.
        {
            Console.WriteLine("Afisami numarul prim al lui n fiind: ");
            int n = int.Parse(Console.ReadLine());

            bool prime = true;

            if (n < 2)
            {
                prime = false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                }



            }
            if (prime)
            {
                Console.WriteLine(n + "-prime");
            }
            else
            {
                Console.WriteLine("not prime ");
            }






        }

        public void euclidAlgo()
        {
            Console.WriteLine("add firs num");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("add second num");
            int num2 = int.Parse(Console.ReadLine());
            int answer = gcd(num1, num2);
            Console.WriteLine("The gcd of {0} and {1} is {2}", num1, num2, answer);
        }


        //----------------------------------------------- Laborator--------------------------------------------------------
        //Monoton crescoatere
        internal void monotonCrescatir()
        {
            int n, a, b;
            n = int.Parse(Console.ReadLine());
            bool monotonCrescator = true;
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    monotonCrescator = false;
                }
                a = b;
            }
            if (monotonCrescator)
            {
                Console.WriteLine("Secventa mononton crescatoare");
            }
            else
            {
                Console.WriteLine(" nu este crescatora");
            }
        }

        internal void monotoncrescatorRotit()
        {

        }



        //------------------------------------------End Lab-------------------------------------------------
        private int gcd(int num1, int num2)
        {
            if (num2 == 0)
            {
                return num1;
            }
            else
            {
                Console.WriteLine("Not yet. {0}/{1} has a reminder of {2}", num1, num2, num1 % num2);
                return gcd(num2, num1 % num2);
            }
        }

        internal void ordineCrescatoare()
        {
            Console.WriteLine("Se dau 5 numere ");
            string line = Console.ReadLine();

            string[] tokens = line.Split(' ');

            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(tokens[i]);

            }

            int a, b, c, d, e;
            a = arr[0]; b = arr[1]; c = arr[2]; d = arr[3]; e = arr[4];

            if (a > b) { int temp = a; a = b; b = temp; }
            if (c > d) { int temp = c; c = d; d = temp; }
            if (d > e) { int temp = d; d = e; e = temp; }
            if (a > c) { int temp = a; a = c; c = temp; }
            if (b > d) { int temp = b; b = d; d = temp; }
            if (b > c) { int temp = b; b = c; c = temp; }
            if (d > e) { int temp = d; d = e; e = temp; }

            Console.WriteLine($"{a}-{b}-{c}-{d}-{e}", 0, 1, 2, 3, 4);



        }

        //Se dau 3 numere.Sa se afiseze in ordine crescatoare.
        internal void nrCrescator()
        {
            Console.WriteLine("Se dau 3 numere ");
            string line = Console.ReadLine();

            string[] tokens = line.Split(' ');

            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(tokens[i]);

            }
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int aux = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = aux;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }



        }

        //Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar
        //egal cu el, de ex. 121 sau 12321.
        internal void palindorm()
        {
            Console.WriteLine(" numar palindrom");
            int n = int.Parse(Console.ReadLine());
            int last = 0;
            int reverse = 0;
            int temp = n;
            while (temp > 0)
            {
                last = temp % 10;
                temp /= 10;

                reverse = reverse * 10 + last;

            }

            if (n == reverse)
            {
                Console.WriteLine("palindrom");
            }
            else
            {
                Console.WriteLine("not palindrom");
            }


        }

        //Determianti cati ani bisecti sunt intre anii y1 si y2. 
        internal void aniBisectiInterval()
        {
            int y1, y2;
            Console.WriteLine("Selecati anul y1 :");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Selecati anul y2 :");
            y2 = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = y1; i <= y2; i++)
            {
                if (i % 4 == 0)
                {

                    count++;
                }


            }
            Console.WriteLine("ani bisecti = " + count);




        }

        //Determinati cate numere integi divizibile cu n se afla in intervalul[a, b].
        internal void divPeInterval()
        {
            string line = Console.ReadLine();

            string[] token = line.Split(' ');
            int count = 0;
            Console.WriteLine("divizor");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= token.Length - 1; i++)
            {
                int temp = int.Parse(token[i]);
                if (temp % 2 == 0)
                {
                    Console.Write(temp + " ");
                    count++;
                }

            }
            Console.WriteLine();
            Console.WriteLine(count + " - divizori");

        }

        //Afisati toti divizorii numarului n.
        internal void divizoriLuin()
        {
            Console.WriteLine("Afisami divizori lui n fiind: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }

        }

        //(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.
        internal void swapRestrictiona()
        {
            Console.WriteLine("introduceti doua volari ");

            int a, b;

            Console.WriteLine("a este: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(" b este :");
            b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;


            Console.WriteLine(" acum a este :" + a + "si b este : " + b);
        }

        //(Swap)Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.
        internal void swap()
        {
            Console.WriteLine("introduceti doua volari ");

            int a, b;

            Console.WriteLine("a este: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(" b este :");
            b = int.Parse(Console.ReadLine());

            int revers = 0;

            revers = b;
            b = a;
            a = revers;
            Console.WriteLine(" acum a este :" + a + "si b este : " + b);


        }

        //Extrageti si afisati a k - a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
        internal void extrageK()
        {
            Console.WriteLine("Se da un numar ");
            string line = Console.ReadLine();
            Console.WriteLine("A cata cifra doriti sa o afisatid  ");
            int k = int.Parse(Console.ReadLine());

            int invr = line.Length - k;

            char[] s = line.ToCharArray();
            Console.WriteLine("cifra este : " + s[invr]);


        }

        internal void anBisec()
        //Detreminati daca un an y este an bisect.
        {
            Console.WriteLine("Selectati un an si aflati daca este un an bisec");
            int y = int.Parse(Console.ReadLine());
            if (y % 4 == 0 && y % 100 != 0)
            {
                Console.WriteLine(" an bisect");
            }
            else if (y % 400 == 0) { Console.WriteLine("an bisect"); }
            else
            {
                Console.WriteLine("An obisnuit ");
            }
        }
        internal void divizibil()//Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
        {
            Console.WriteLine("Determinati daca n  se divide pe k unde ");
            Console.WriteLine(" n :");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(" k :");
            int k = int.Parse(Console.ReadLine());

            if (n % k == 0)
            {
                Console.WriteLine("este divizibil");
            }
            else
            {
                Console.WriteLine("nu este divizibil");
            }

        }

        public void ecuatieGradDoi()//Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
        {
            double a, b, c;
            Console.WriteLine("Give a value to  a ,b ,c ");
            string line = "";

            line = Console.ReadLine();


            string[] split = line.Split(' ');

            a = double.Parse(split[0]);
            b = double.Parse(split[1]);
            c = double.Parse(split[2]);
            Console.WriteLine("the values are  a = {0} b = {1} c = {2}", a, b, c);

            double sqrtpart = b * b - 4 * a * c;
            double x, x1, x2, img;
            if (sqrtpart > 0)
            {
                x1 = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
                x2 = (-b - Math.Sqrt(sqrtpart)) / (2 * a);

                Console.WriteLine("Doua solutii reale : {0,8:f4} sau {1,8:f4}", x1, x2);
            }
            else if (sqrtpart < 0)
            {
                sqrtpart = -sqrtpart;
                x = -b / (2 * a);
                img = Math.Sqrt(sqrtpart) / (2 * a);

                Console.WriteLine("2 imaginary solutions : {0,8:f4} + {1,8:f4}", x, img);
            }
            else
            {
                x = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine(" one real solution : {0,8:f4}", x);
            }


        }




    }
}
