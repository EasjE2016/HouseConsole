using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConsole
{
    public class House
    {
        private string adresse;  //field

        public string Navn { get; set; } //property
        public int HusNr { get; set; } //property

        public House() //default constructor
        {

        }

        public House(string adresse)  //konstructor med en parameter som har typen string
        {
            this.adresse = adresse;
        }


        public string GetAdresse() //metode som returnerer adresse
        {
            return this.adresse;
        }

        public void SetAdresse(string adresse) //metode hvor adress sættes, da metoden ikke returnerer noget har den typen void
        {
            this.adresse = adresse;
        }

    }
}
