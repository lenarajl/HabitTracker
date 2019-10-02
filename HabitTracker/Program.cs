using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
            //Main is an entry point, everybody has Main and don't delete
        {
            var account = new Account();
            //"new" creates an instance, which means your memory gets allocated
            //account is the variable holding onto the bank account, etc.
            //instance of an account == object
            account.EmailAddress = "test@test.com";
            account.AccountNumber = 12345;
            Console.WriteLine(account.EmailAddress);
        }
    }
}
