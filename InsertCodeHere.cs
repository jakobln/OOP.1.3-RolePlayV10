using System;

namespace RolePlayV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Warrior warriorA = new Warrior("Ragnar");
            Warrior warriorB = new Warrior("Lagertha");

            Console.WriteLine($"Warrior A is called {warriorA.Name}");
            Console.WriteLine($"Warrior B is called {warriorB.Name}");
        
            Console.WriteLine($"Warrior A's level is {warriorA.level}");
            Console.WriteLine($"Warrior B's level is {warriorB.level}");

            Console.WriteLine($"Warrior A has leveled up and is now level {warriorA.levelup}");
            Console.WriteLine($"Warrior B has leveled up and is now level {warriorB.levelup}");

            // The LAST line of code should be ABOVE this line
        }
    }
}