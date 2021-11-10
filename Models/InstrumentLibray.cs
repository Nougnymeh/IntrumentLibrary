using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrumentLibrary.Models
{
    class InstrumentLibray
    {
        public abstract class Instrument
        {
            public string serialNumber { get; set; }
            public string Name { get; set; }

            public Instrument (string Name)
            {
                this.Name = Name;
            }

            public abstract void Play();
        }

        public class Guitar : Instrument
        {
            public Guitar(string Name) : base(Name)
            {
            }

            public override void Play()
            {
                Console.WriteLine($"I am playing {Name} Guitar");
            }
        }
        public class Mandolin : Instrument
        {
            public Mandolin(string Name) : base(Name)
            {
            }

            public override void Play()
            {
                //throw new NotImplementedException();
                Console.WriteLine($"I am playing {Name} Mandolin");
            }
        }

        public class Ukele : Instrument
        {
            public Ukele(string Name) : base(Name)
            {
            }

            public override void Play()
            {
                //throw new NotImplementedException();
                Console.WriteLine($"I am playing {Name} Ukele");
            }
        }
    }
}
