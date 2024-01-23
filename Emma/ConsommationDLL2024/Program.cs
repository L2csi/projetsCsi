using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLLl2CSI2024;

namespace ConsommationDLL2024
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisir id");
            int id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Saisir le nom");
            string no = Console.ReadLine();
            Console.WriteLine("Saisir le postnom");
            string post = Console.ReadLine();
            Console.WriteLine("Saisir le prénom");
            string pren = Console.ReadLine();
            Class1 dll = new Class1();
            dll.executeRqt("INSERT INTO Etudiant values (" + id + ",'" + no + "','" + post + "','" + pren + "', getdate())");
            Console.WriteLine("Enregistrement reussi");

            Console.ReadKey();
        }
    }
}
