using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IntrumentLibrary.Models.InstrumentLibray;

namespace IntrumentLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Guitar myGuitar = new Guitar("Gibson");
            Mandolin myMandolin = new Mandolin("Kentuky");
            Ukele myUkele = new Ukele("Ortega");

            myUkele.serialNumber = "abc123";
            myGuitar.Play();
            myMandolin.Play();
            myUkele.Play();

            Console.ReadKey();
        }

    }
}
