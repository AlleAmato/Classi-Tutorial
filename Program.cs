using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Utente u = new Utente("Alessandro", "Amato");
            u.MostraUtente();
            Console.ReadLine();

        }
    }
}
