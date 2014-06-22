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
            Eleve eleve = new Eleve();
            eleve = eleve.getEleveById(4);
            Console.WriteLine("Eleves 4 : "+ eleve.nomEleve + " Pass :" + eleve.motDePasse);

            Module module = new Module();
            module = module.getModulesById(2);
            Console.WriteLine("Module : " + module.numModule + " " + module.nomModule + " nb de mat :" + module.nbMatiere);

            Console.ReadLine();
        }
    }
}
