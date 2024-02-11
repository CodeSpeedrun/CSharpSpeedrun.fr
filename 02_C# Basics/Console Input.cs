/* Using Convert.ToInt32();
*/
Console.WriteLine("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine()); //int to int
Console.WriteLine("Age = " + age);


/* Console.Read()
The second way to capture user input is the Console.Read() method that reads the whole input line but only returns the ASCII value of the first character. For example, the ASCII value of A is 65. Some devices still use ASCII encoding, so this method might come in handy.
*/
Console.WriteLine("Enter coupon code: ");
int code = Console.Read();

Console.WriteLine("ASCII = " + code);


/* Console.ReadKey()
The third way to capture user input is the Console.ReadKey() method. This method records the first keyboard keypress and returns the ConsoleKeyInfo struct which can be used to display additional information about the key that was pressed.
*/
Console.WriteLine("Press any key to continue...");
ConsoleKeyInfo key = Console.ReadKey();

Console.WriteLine();
Console.WriteLine("Key pressed = " + key.Key);
