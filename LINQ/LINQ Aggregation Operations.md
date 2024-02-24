LINQ Aggregation Operations

The Count()
extension method is one such aggregation example. Other possibilities include obtaining an average,
maximum, minimum, or sum of values using the Max(), Min(), Average(), or Sum() members of the
Enumerable class.

double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };
// Various aggregation examples.
Console.WriteLine("Max temp: {0}",
(from t in winterTemps select t).Max());


