using System;
using System.Collections.Generic;

namespace GB_04_03BankAccount01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> listAccount = new List<Account>();

            Account account1 = new Account(100, TypeOfBankAccount.DEPOSIT);
            Account account2 = new Account(99, TypeOfBankAccount.DEBIT);
            Account account3 = new Account(1555, TypeOfBankAccount.CREDIT);
            Account account4 = new Account(888, TypeOfBankAccount.BUDGET);

            listAccount.Add(account1);
            listAccount.Add(account2);
            listAccount.Add(account3);
            listAccount.Add(account4);

            foreach (var item in listAccount)
            {
                item.FullInfo();
            }

            string exit;
            do
            {
                Console.WriteLine("Для выхода нажмите Q + Enter. Для выбора текущего счёта нажмите номер счёта");

                exit = Console.ReadLine();
                exit= exit.ToLower();

                
                int _fromTheAccount=0;
                bool _isAccountFound = false ;
                decimal _take;



                switch (exit)
                {
                    case "1":

                        Console.WriteLine("Выбран текущий счёт № 1.");
                        do
                        {
                            Console.WriteLine("Выберете счёт с которого будут переведены деньги:");

                            try
                            {
                                _fromTheAccount = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in listAccount)
                                {
                                    if (item.Number == _fromTheAccount)
                                    {
                                             

                                        _isAccountFound = true;
                                        break;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Не корректный номер счёта");
                            }

                        } while (_isAccountFound);


                        do
                        {

                            Console.WriteLine("Выберете сумму списания денег:");

                            try
                            {

                            }
                            catch (Exception)
                            {

                                throw;
                            }

                        } while (true);


                        account1.MoneyTransfer(listAccount[_fromTheAccount-1], _take);
                        break;

                    default:
                        break;
                }


            } while (exit!="q");





        }
    }
}
