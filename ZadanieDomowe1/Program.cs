using System;
using System.Collections.Generic;
using System.Linq;

namespace ZadanieDomowe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik prac1 = new Pracownik("Mateusz", "Rys", new DateTime(1993,1,2), PlecPracownika.Mezczyzna);
            Pracownik prac2 = new Pracownik("Marian", "Nowak", new DateTime(1997,8,5), PlecPracownika.Mezczyzna);
            Pracownik prac3 = new Pracownik("Zygmunt", "Żak", new DateTime(2001,2,22), PlecPracownika.Mezczyzna);
            Pracownik prac4 = new Pracownik("Anna", "Miś", new DateTime(2000,9,16), PlecPracownika.Kobieta);
            Pracownik prac5 = new Pracownik("Marta", "Zima", new DateTime(1999,12,16), PlecPracownika.Kobieta);
            Pracownik prac6 = new Pracownik("Zenon", "Długosz", new DateTime(1995,4,15), PlecPracownika.Mezczyzna);

            var listaPracownikow1 = new List<Pracownik>();
            listaPracownikow1.Add(prac1);
            listaPracownikow1.Add(prac2);
            listaPracownikow1.Add(prac4);

            var listaPracownikow2 = new List<Pracownik>();
            listaPracownikow2.Add(prac3);
            listaPracownikow2.Add(prac5);
            listaPracownikow2.Add(prac6);

            listaPracownikow1.AddRange(listaPracownikow2);
            //foreach (Pracownik i in listaPracownikow1)
            //{
            //    Console.WriteLine(i);
            //}
           
            var listaPracownikowUrodzonychPrzedRokiem2000 = listaPracownikow1.Where(x => x.DataUrodzenia <= new DateTime(2000, 1, 1) && x.Plec == PlecPracownika.Mezczyzna).ToArray();

            var imiona = listaPracownikow1.Where(x => x.DataUrodzenia <= new DateTime(2000, 1, 1) && x.Plec == PlecPracownika.Mezczyzna).Select(x => x.Imie).ToArray();
            var listaPracownikowInnySposob = (from pracownik in listaPracownikow1
                                              where pracownik.DataUrodzenia <= new DateTime(2000, 1, 1)
                                              where pracownik.Plec == PlecPracownika.Mezczyzna
                                              select pracownik.Imie).ToArray();

            foreach (Pracownik i in listaPracownikowUrodzonychPrzedRokiem2000)
            {
                Console.WriteLine(i);
            }

            
            Console.ReadKey();
        }
    }
}
