using System;

namespace BankingApp
{
    class BankingSystem
    {
        int amt;
        static int[,] userAccounts = new int[10, 2]
        {
            { 1234, 1234 },
            { 5678, 5678 },
            { 9101, 9101 },
            { 1121, 1121 },
            { 3141, 3141 },
            { 5161, 5161 },
            { 7181, 7181 },
            { 9202, 9202 },
            { 2232, 2232 },
            { 3242, 3242 }
        };

        public void Withdrawal()
        {
            Console.WriteLine("Enter The Amount To Withdraw: ");
            int with = int.Parse(Console.ReadLine());

            if (with <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid amount to withdraw.");
                return;
            }

            if (with < 100)
            {
                Console.WriteLine("Withdrawal amount must be 100 rupees or more.");
            }
            else if (with > amt)
            {
                Console.WriteLine("Insufficient balance. Please enter a valid amount to withdraw.");
            }
            else
            {
                amt -= with;
                Console.WriteLine("Amount Withdrawn: " + with);
            }
        }

        public void Credit()
        {
            Console.WriteLine("Enter The Amount To Credit: ");
            int cre = int.Parse(Console.ReadLine());

            if (cre <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid amount to credit.");
                return;
            }

            if (cre < 100)
            {
                Console.WriteLine("Credit amount must be 100 rupees or more.");
            }
            else
            {
                amt += cre;
                Console.WriteLine("Credited Amount: " + cre);
            }
        }

        public void Show_Balance()
        {
            Console.WriteLine("Balance Amount: " + amt);
        }

        public static void Main(string[] args)
        {
            int accno;
            int pass;
            bool validAccount = false;
            int accountIndex = -1;

            // Account number validation loop
            while (true)
            {
                Console.Write("Enter The Account number: ");
                accno = int.Parse(Console.ReadLine());

                for (int i = 0; i < userAccounts.GetLength(0); i++)
                {
                    if (userAccounts[i, 0] == accno)
                    {
                        validAccount = true;
                        accountIndex = i;
                        break;
                    }
                }

                if (validAccount)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid account number. Please enter a valid account number.");
                }
            }

            // Password validation loop
            while (true)
            {
                Console.Write("Enter The password: ");
                pass = int.Parse(Console.ReadLine());

                if (userAccounts[accountIndex, 1] == pass)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid password. Please enter a valid password.");
                }
            }

            Console.WriteLine("Welcome!");

            BankingSystem obj = new BankingSystem();

            Console.Write("Enter The Initial Amount To Be Credited: ");
            obj.amt = int.Parse(Console.ReadLine());

            while (obj.amt < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid initial amount.");
                obj.amt = int.Parse(Console.ReadLine());
            }

            while (true)
            {
                Console.WriteLine("\n1. For Withdrawal\n2. For Credit\n3. Current Amount\n4. Exit");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        obj.Withdrawal();
                        break;

                    case 2:
                        obj.Credit();
                        break;

                    case 3:
                        obj.Show_Balance();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }
    }
}
