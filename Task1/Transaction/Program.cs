using System;

namespace Transaction
{
    class program
    {
        static void Main(string[] args)
        {
            string[,] name = new string[50,50];
            double[] amount = new double[50,50];

            Console.WriteLine("Enter a choice(1/2/3):");
            Console.WriteLine("choice 1 - Create Customer");
            Console.WriteLine("choice 2 - Deposit");
            Console.WriteLine("choice 3 - Withdraw");
            Console.WriteLine("choice 4 - Balance");
            Console.WriteLine("choice 5 - Exit");




            for (int i = 0; i <= number; i++)
            {
                
                for (int j = 0; j <= number; j++)
                {
                    Console.Write("customer Name:");
                    name[i,j] = Console.ReadLine();
                    Console.WriteLine("Available balance:" + amount[i, j]);
                    Console.Write("Enter a choice:");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter Deposit amount:");
                            double deposit_amount = double.Parse(Console.ReadLine());
                            if (deposit_amount > 0)
                            {
                                amount[i,j] += deposit_amount;
                                Console.WriteLine("After deposit :" + amount[i,j]);
                                Console.WriteLine("Current balance:" + amount[i,j]);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Amount");
                            }
                            break;

                        case "2":
                            Console.Write("Enter Withdraw amount:");
                            double withdraw_amount = int.Parse(Console.ReadLine());
                            if (withdraw_amount > 0 && withdraw_amount <= amount[i,j])
                            {
                                amount[i,j] -= withdraw_amount;
                                Console.WriteLine("After withdraw :" + amount[i,j]);
                                Console.WriteLine("Current balance:" + amount[i, j]);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Amount");
                            }
                            break;

                        case "3":
                            Console.WriteLine($"customer Name:{name[i,j]}");
                            Console.WriteLine("Current Balance:" + amount[i,j]);
                            break;

                        case "4":
                            Console.WriteLine("Exit successful");
                            return;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;

                    }


                }

            }
        }
    }
}
