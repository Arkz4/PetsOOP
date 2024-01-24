using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Chimp : Pet
    {
        public Chimp(string Name) : base(Name)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine(Name + "  hoots at you.");
        }

        public void Climb()
        {
            Console.WriteLine( Name + " climbs the wall");
        }    
    }
}
