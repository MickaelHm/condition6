using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez renseigner en lettre minuscule un mois de l'année");
            string userMonth = Console.ReadLine();
            if (userMonth == "mars" || userMonth == "avril" || userMonth == "mai")
            {
                Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
            }
            else
            {
                if (userMonth == "juin" || userMonth == "juillet" || userMonth == "août")
                {
                    Console.WriteLine("La saison du mois saisi est l'ETE.");
                }
                else
                {
                    if (userMonth == "septembre" || userMonth == "octobre" || userMonth == "novembre")
                    {
                        Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
                    }
                    else
                    {
                        if (userMonth == "décembre" || userMonth == "janvier" || userMonth == "février")
                            Console.WriteLine("La saison du mois saisi est l'HIVER.");
                    }
                }
            }
                    }
    }
}
