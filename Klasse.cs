using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMorpheus
{
    class Klasse
    {
        public int Zahl;
        private String Zeichenkette;

        //Konstructor
        public Klasse(int n=1, string s="hello")
        {
            Zahl = n;
            Zeichenkette = s;


        }

        public void gehen(int richtung = 1)
        {
            if (richtung == 1)
            {
                Zahl++;
                if (Zahl < 1)
                {
                    Console.WriteLine("No Movement detected");
                }
            } 
        }
    }
}
