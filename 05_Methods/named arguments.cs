/* How to declare named arguments?
because c# is a strongly typed language When creating methods with multiple parameters, the order of the arguments and parameters needs to be respected. However, passing arguments with the key: value syntax allows us to bypass that rule. Now the order of the arguments is irrelevant.
*/
 using System;

namespace CSharpSpeedrun
{
    class Program
    {
        static void Main()
        {
            int numberOfHearts = 5; string currentWeapon = "Giant Spoon";

            GetHeroStatus(weapon: currentWeapon, hearts: numberOfHearts);
        }

        static void GetHeroStatus(int hearts, string weapon)
        {
            if (hearts < 10)
            {
                Console.WriteLine("Let's buy some health packs!");
            }
            else
            {
                Console.WriteLine("Ready for adventure!");
            }
            Console.WriteLine("Current weapon: " + weapon);
        }
    }
}
Let’s buy some health packs!
Current weapon: Giant Spoon