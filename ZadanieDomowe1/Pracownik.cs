using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieDomowe1
{
   public class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime  DataUrodzenia { get; set; }
        public PlecPracownika Plec { get; set; }


        public Pracownik (string imie, string nazwisko, DateTime dataUrodzenia, PlecPracownika plec)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            DataUrodzenia = dataUrodzenia;
            Plec = plec;
        }
        public override string ToString()
        {
            return String.Format("Imie: {0} \nNazwisko: {1} \nDataUrodzenia: {2} \nPlec: {3}", Imie, Nazwisko,DataUrodzenia, Plec);
        }


    } 

    public enum PlecPracownika
    {
        Kobieta,
        Mezczyzna
    }
}
