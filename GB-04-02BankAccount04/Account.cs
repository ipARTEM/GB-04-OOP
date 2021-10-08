using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_04_02BankAccount04
{
    public class Account
    {
        static int counter = 1;

        int _number;

        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value.GetType().ToString() == "System.Int32")
                {
                    _number = value;
                }
            }
               
        } 


        decimal _balance;

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value.GetType().ToString() == "System.Decimal")
                {
                    _balance = value;
                }
            }

        }

        TypeOfBankAccount _typeAccount;

        public TypeOfBankAccount TypeAccount
        {
            get
            {
                return _typeAccount;
            }
            set
            {
                if (value.GetType().ToString() == "GB_04_02BankAccount04.TypeOfBankAccount")
                {
                    _typeAccount = value;
                }
            }

        }

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

        
    }
}