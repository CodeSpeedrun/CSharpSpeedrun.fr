/* What is Interface Segregation Principle (ISP)?
This principle recommends that classes should not 
be forced to implement methods they dont use. In other words, 
instead of a multipurpose interface, it is better to have multiple smaller ones.
*/
public class Manager : Developper
{
   public void MeetClients()
   {
   }
   public void CreateToDoItem()
   {
   }
   public void DevelopFeature()
   {
      throw new Exception(" ");
   }
}