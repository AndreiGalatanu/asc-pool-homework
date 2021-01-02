using System;

namespace Boundle1
{
    class Program
    {
        static void Main(string[] args)
        {
            pool1 p = new pool1();

            // ****************** Vectori **************** 
            ExercitiiVectori v = new ExercitiiVectori();
            // 1.   
            //v.diferenta();
            // 2.
            //v.prob2();
            // 3.
            //v.prob3();
            // 4.
            //v.sortVector();
            // 5.
            //v.afisareMultipli();

            // *******************************************
            //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare. 
            //    p.one();

            //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
            // p.ecuatieGradDoi();

            //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
            //  p.divizibil();

            //Detreminati daca un an y este an bisect. 
            //  p.anBisec();

            //Extrageti si afisati a k - a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
            // p.extrageK();

            //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
            //p.laturiTriunghui();

            //(Swap)Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.
            //p.swap();

            //(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.
            // p.swapRestrictiona();

            //Afisati toti divizorii numarului n.
            // p.divizoriLuin();

            //Test de primalitate: determinati daca un numar n este prim.
            //  p.nrPrim();

            //Afisati in ordine inversa cifrele unui numar n. 
            //p.orindeInveras();

            //Determinati cate numere integi divizibile cu n se afla in intervalul[a, b].
            //p.divPeInterval();

            //Determianti cati ani bisecti sunt intre anii y1 si y2.
            //p.aniBisectiInterval();

            //Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.
            //p.palindorm();

            //Se dau 3 numere.Sa se afiseze in ordine crescatoare.
            // p.nrCrescator();

            //Se dau 5 numere.Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
            //p.ordineCrescatoare();

            // Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.Folositi algoritmul lui Euclid.

            //p.euclidAlgo();

            //Afisati descompunerea in factori primi ai unui numar n.De ex.pentru n = 1776 afisati 2 ^ 3 x 3 ^ 1 x 7 ^ 2.
            p.monotonCrescatir();

            //Determinati daca un numar e format doar cu 2 cifre care se pot repeta.De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.


            //Afisati fractia m / n in format zecimal, cu perioada intre paranteze(daca e cazul).Exemplu: 13 / 30 = 0.4(3).


            //Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?".


        }
    }

}
