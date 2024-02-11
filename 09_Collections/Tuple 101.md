think of a tuple as a simple construct holding more than
one value and defined with parentheses, like this tuple that holds a string and an int:
(string, int)

//Switch expression with Tuples
static string RockPaperScissors(string first, string second)
{
return (first, second) switch
{
("rock", "paper") => "Paper wins.",
("rock", "scissors") => "Rock wins.",
("paper", "rock") => "Paper wins.",
("paper", "scissors") => "Scissors wins.",
("scissors", "rock") => "Rock wins.",
("scissors", "paper") => "Scissors wins.",
(_, _) => "Tie.",
};
}

Console.WriteLine(RockPaperScissors("paper","rock"));

As mentioned earlier in this chapter, one way to use out parameters is to retrieve more than
one value from a method call. Another way is to use a light construct called a tuple.

(string, int, string) values = ("a", 5, "c");
var values = ("a", 5, "c");

var valuesWithNames2 = (FirstLetter: "a", TheNumber: 5, SecondLetter: "c");
Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");

static void FillTheseValues(out int a, out string b, out bool c)
{
a = 9;
b = "Enjoy your string.";
c = true;
}
By using a tuple, you can remove the parameters and still get the three values back.
static (int a,string b,bool c) FillTheseValues()
{
return (9,"Enjoy your string.",true);
}
Calling this method is as simple as calling any other method.
var samples = FillTheseValues();
Console.WriteLine($"Int is: {samples.a}");

