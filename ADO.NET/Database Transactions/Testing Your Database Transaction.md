Testing Your Database Transaction

void FlagCustomer()
{
Console.WriteLine("***** Simple Transaction Example *****\n");
// A simple way to allow the tx to succeed or not.
bool throwEx = true;
Console.Write("Do you want to throw an exception (Y or N): ");
var userAnswer = Console.ReadLine();
if (string.IsNullOrEmpty(userAnswer) || userAnswer.Equals("N",StringComparison.
OrdinalIgnoreCase))
{
throwEx = false;
}
var dal = new InventoryDal();
// Process customer 1 – enter the id for the customer to move.
dal.ProcessCreditRisk(throwEx, 1);
Console.WriteLine("Check CreditRisk table for results");
Console.ReadLine();
}


