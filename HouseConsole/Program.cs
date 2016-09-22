using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            House Hus1 = new House(); // laver et objekt/instans af House som jeg navngiver Hus1 , Jeg kalder default constructor

           


            House Hus2 = new House("Solvej"); //laver et objekt/instans af House som jeg navngiver Hus2, Jeg kalder construktoren som tager en string parameter

            Hus2.HusNr = 27; // sætter husnr på Hus2 til værdien 27
            Hus2.Navn = "Murstenshus"; //sætter Navn på Hus2 til værdien "Murstenshus"

            Console.WriteLine("Adresse: {0} ",Hus2.GetAdresse()); // Kalder metoden GetAdresse() på objektet/instansen Hus2 og printer resultatet ud til konsollen
            Console.ReadLine();

        }
    }
}
