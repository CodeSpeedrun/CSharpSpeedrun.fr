/*  logical Operators 
&& returns true if both statements are true otherwise it will return false.
|| will return true if one of the statements is true.
! reverses the result, returns false if the result true and returns true if the result is false.
*/
int a = 5;
int b = 10;

Console.WriteLine("Logical and: " + ((a < 3) && b < 20) );
Console.WriteLine("Logical or: " + ((a < 3) || b < 20) );
Console.WriteLine("Logical not: " + (a != b));
 

/* operator precedence
The evaluation of an expression is done from left to right. If multiple operators are used, then the operators with higher priority are evaluated before the operators with lower priority. However, with additional ( ), the priority of the operators can be manually changed as illustrated below:
*/
int a = 5;
int b = 10;
Console.WriteLine( a + b * 3 ); 
Console.WriteLine((a + b) * 3 ); 
// (a + b) evaluated first

/* 
35
45 
*/