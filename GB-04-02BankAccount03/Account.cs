using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_04_02BankAccount03
{
    public class Account
    {
        int _number;

        static int counter = 1;

        decimal _balance;

        TypeOfBankAccount _typeAccount;

        public Account()
        {
            _number = Increase();
        }

        public Account(decimal balance)
        {
            _balance = balance;
            _number = Increase();

        }
        public Account(TypeOfBankAccount typeAccount)
        {
            _typeAccount = typeAccount;
            _number = Increase();

        }

        public Account(decimal balance, TypeOfBankAccount typeAccount)
        {
            _balance = balance;
            _typeAccount = typeAccount;
            _number = Increase();

        }

        int Increase()
        {
            return counter++;
        }

        public int InfoNumber()
        {
            return _number;
        }

        public decimal InfoBalance()
        {
            return _balance;
        }

        public TypeOfBankAccount InfoTypeAccount()
        {
            return _typeAccount;
        }

        public void FillNumber(int number)
        {
            _number = number;
        }

        public void FillBalance(decimal balance)
        {
            _balance = balance;

        }

        public void FillTypeAccount(TypeOfBankAccount typeAccount)
        {
            _typeAccount = typeAccount;
        }

        public void FullInfo()
        {
            Console.WriteLine($"Тип счёта: {_typeAccount}, Номер счёта: {_number}, Баланс: {_balance}");
        }

    }
}
