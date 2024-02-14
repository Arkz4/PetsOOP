using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Turtle : Pet
    {
        public Turtle(string Name) : base(Name)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine(Name + " grunts at you.");
        }
        public void hideInShell()
        {
            Console.WriteLine(Name + " hides in shell");
        }

                public void Meet(Cat newFriend)
        {
            Console.WriteLine(Name + " runs from " + newFriend.Name);
        }

        public void Meet(Chimp newFriend)
        {
            Console.WriteLine(Name + " runs from " + newFriend.Name);
        }
    }
}
