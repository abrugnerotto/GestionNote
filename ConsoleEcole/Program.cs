using nsLibraryDB;
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
            EcoleEntities ecoleEntities = new EcoleEntities();

            Console.WriteLine(ecoleEntities.Notes.ToString());
            List<Notes> listNotes = (from m in ecoleEntities.Notes select m);

            Console.ReadLine();
        }
    }
}
