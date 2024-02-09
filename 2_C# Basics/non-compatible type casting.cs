/* What is non-compatible type casting?
Sometimes we cannot use implicit or explicit conversion because the data types are too different. For example, the compiler will throw an error when converting string to int data types.
*/
namespace CSharpSpeedrun
{
    class Program
    {
        static void Main(string[] args)
        {
           string myLuckyText = "938473"; 
           int myLuckyInt = Convert.ToInt32(myLuckyText); 
           Console.WriteLine(myLuckyInt);
        }
    }
}