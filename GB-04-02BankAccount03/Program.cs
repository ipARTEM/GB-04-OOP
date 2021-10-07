using System;

namespace GB_04_02BankAccount03
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(10);
            Account account2 = new Account(TypeOfBankAccount.DEBIT);
            Account account3 = new Account(100, TypeOfBankAccount.DEPOSIT);

            account1.FullInfo();
            account2.FullInfo();
            account3.FullInfo();
        }
    }
}
