Obtaining Subsets of Data
To obtain a specific subset from a container, you can use the where operator. When doing so, the general
template now becomes the following code:
var result =
from item
in container
where BooleanExpression
select item;


Notice that the where operator expects an expression that resolves to a Boolean. For example, to extract
from the ProductInfo[] argument only the items that have more than 25 items on hand, you could author
the following code:
static void GetOverstock(ProductInfo[] products)
{
Console.WriteLine("The overstock items!");
// Get only the items where we have more than
// 25 in stock.
var overstock =
from p
in products
where p.NumberInStock > 25
select p;


/ Get BMWs going at least 100 MPH.
var onlyFastBMWs =
from c
in myCars
where c.Make == "BMW" && c.Speed >= 100
select c;

