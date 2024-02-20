
using ClassLibrary1;
List<Pet> pets = new List<Pet>();

string input = "";

while (input != "4") { 
Console.WriteLine("Welcome To The Pet Store");
Console.WriteLine("1. Add a new Pet");
Console.WriteLine("2. List all pets");
Console.WriteLine("3. Remove all pets");
Console.WriteLine("4. Exit");
    input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.WriteLine("What is the name of the new pet?");
            string petName = Console.ReadLine();

            Console.WriteLine("1. Add a new Cat");
            Console.WriteLine("2. Add a new Chimp");
            Console.WriteLine("3. Add a new Turtle");
            string input2 = Console.ReadLine();
            switch(input2)
            {
                case "1":
                    Cat newCat = new Cat(petName);
                    pets.Add(newCat);
                    break;
                case "2":
                    Chimp newChimp = new Chimp(petName);
                    pets.Add(newChimp);
                    break;
                    
                case "3":
                    Turtle newTurtle = new Turtle(petName);
                    pets.Add(newTurtle);
                    break;        
            }
            break;
        case "2":
            foreach (var Pet in pets){
              Pet.ShowInfo();
            }

            break;
        case "3":
           pets.Clear();

            break;
        default:
            break;
    }
}

