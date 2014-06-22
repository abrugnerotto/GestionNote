using entityBDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleEcole
{
    class Program
    {
        static void Main(string[] args)
        {
            Eleves eleves = new Eleves();
            Console.WriteLine("Eleves 1 : "+ eleves.getFirstEleves());
            Console.WriteLine("Eleves 4 : "+ eleves.getEleveById(4));

            Console.ReadLine();
        }
    }
}
