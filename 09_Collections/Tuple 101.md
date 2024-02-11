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