using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WCS_capitalism_simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person
            {
                Firstname = "Patrick",
                Lastname = "Balkany",

            };

            person1.Accounts = new List<SavingAccount>
                {
                    new SavingAccount { Amount = 2000000, InterestRate=5 },
                    new SavingAccount { Amount = 250000, InterestRate=15 },
                    new SavingAccount { Amount = 10000000, InterestRate=2 },
                };


            string messageInBox = "";
            foreach (SavingAccount account in person1.Accounts)
            {
                messageInBox += $"Amount : {account.Amount}, Interests Rate : {account.InterestRate}, Interests Amount : {account.GetInterests()}\n";
            }

            MessageBox.Show(messageInBox,"Accounts Summary : ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
