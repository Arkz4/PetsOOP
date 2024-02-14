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

                public void Meet(Cat newFriend)
        {
            Console.WriteLine(Name + " jumps at " + newFriend.Name);
        }

        public void Meet(Turtle newFriend)
        {
            Console.WriteLine(Name + " Jumps at " + newFriend.Name);
        }
    }
}
