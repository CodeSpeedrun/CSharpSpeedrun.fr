/* What is Single Responsibility Principle?
This principle recomments every software modules such as class, structures, methods among others should accomplish only one job. Hence only one reason to change. The modules should not multitask like a Swiss knife, just because we can put every line of code in a single class, doesn’t mean we should.
*/
 using System;

namespace CSharpSpeedrun
{
    public class UserRegistration
    {
        public static void Main()
        {
            FilterUserInput();
            SaveDataToDb();
            MailSender();
        }

        public static void FilterUserInput() { }

        public static void SaveDataToDb() { }

        public static void MailSender() { }
    }
}