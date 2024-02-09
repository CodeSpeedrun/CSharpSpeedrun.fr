/* What is an Extension Method?
Extension methods are simply additional methods that are injected to the original class without editing or recompiling it.
*/
using System;
namespace CSharpSpeedrun
{

public static class MethodExtension
     {
        public static bool IsEvenNumber(this int i)
        {
            if(i%2 == 0){
               return true;
            }else{
               return false;
             }
        }
    }

class Program
{
    static void Main(string[] args)
    {
        int myNum  = 12;

        bool result = myNum.IsEvenNumber(); 

        Console.WriteLine(result);
    }
}

}
//public static bool IsEvenNumber(this int i, int value)
