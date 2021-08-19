using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMorpheus
{
    class Program
    {
        static void Main(string[] args)
        {
            aus("Hello",42);
            Console.WriteLine(Program.fak(5));
            Console.ReadKey();

            Klasse uni = new Klasse(); //Mit dem Konstruktor aus Klasse.cs
            uni.Zeichenkette = "Hallo Welt";
        }

        //Rekursiv, Methode ruft sich selbst innerhalb der Methode auf
        public static Int64 fak(int n)
        {
            if (n == 2)
            {
                return 2;
            }
            return n * fak(n - 1);
        }
        
        //Überladung: zwei funktionen mit dem gleichen Namen. Der Compiler erkennt anhand der Parameter welche gemeint is. Siehe insbesondere Zeile 33.
        public static void aus(string i, int j=1) //mit j=1 setzt 1 als Standartparameter für J es sei denn beim Aufrufen der Methode wird ein anderer Wert festgelegt bspw. 42 :)
        {
            for (int k=0; k < j; k++)
            {
                Program.aus(i);
            }
        }
        public static void aus(string i)
        {
            Console.WriteLine(i);
        }
    }
}
