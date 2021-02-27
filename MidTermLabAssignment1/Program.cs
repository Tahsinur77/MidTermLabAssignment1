using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment1
{
    class Program
    {
        private static int x = 0;
        public static int AutoIdGenerator()
        {
            x++;
            return x;
            //auto id generator

        }
        static void Main(string[] args)
        {
            Console.Write("\n\t\t=====================================================================\n");
            Console.Write("\t\t|| Enter Your Bank Name : ");
            string bankName = Console.ReadLine();
            Console.Write("\t\t||How many account you have? or you Want to insert ? :");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write("\t\t======================================================================\n");

            Bank b1 = new Bank(bankName,size);

            while (true)
            {
                Console.Write("\n\t\t=====================================================================\n");
                Console.WriteLine("\t\t||Select the following option : ");
                Console.Write("\t\t||\t1 => Add Account\n\t\t||\t2 => Delete Account\n\t\t||\t3 => Transaction\n\t\t||\t4 => Show Account Details\n\t\t||\t5 => Exit\n\t\t||\n\t\t||Enter : ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("\t\t=====================================================================\n");

                if (x == 1)
                {
                    Console.Write("\t\t=====================================================================\n");
                    Console.Write("\t\t||Enter Account : \n\t\t||\tName : ");
                    string accountName = Console.ReadLine();
                    Console.Write("\t\t||\tBalance : ");
                    double balance = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\t\t||\tAddress :\n\t\t||\t\tRoad No. : ");
                    string roadNo = Console.ReadLine();
                    Console.Write("\t\t||\t\tHouse No. : ");
                    string houseNo = Console.ReadLine();
                    Console.Write("\t\t||\t\tCity : ");
                    string city = Console.ReadLine();
                    Console.Write("\t\t||\t\tCountry : ");
                    string country = Console.ReadLine();
                    Console.Write("\t\t=====================================================================\n");

                    int id = AutoIdGenerator();

                    b1.AddAccount(new Account(id,accountName,balance,new Address(roadNo,houseNo,city,country)));


                }
                else if (x==2)
                {
                    Console.Write("\t\t=====================================================================\n");
                    Console.Write("\t\t||\tEnter You Account Number : ");
                    int accountNumber =Convert.ToInt32(Console.ReadLine());
                    b1.DeleteAccount(accountNumber);
                    Console.Write("\t\t=====================================================================\n");
                }
                else if (x == 3)
                {
                    Console.Write("\t\t=====================================================================\n");
                    Console.Write("\t\t||\tEnter You Account Number : ");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                    int found = b1.SearchAccount(accountNumber);
                    if (found >= 0)
                    {
                        Console.Write("\t\t||\tWhat do you want to do??\n\t\t||\t\t1 => Withdraw\n\t\t||\t\t2 =>Deposit \n\t\t||\t\t3 =>Transfer\n\t\t||Enter : ");
                        int choise = Convert.ToInt32(Console.ReadLine());
                        if(choise == 1)
                        {
                            Console.Write("\t\t||Enter the amount you want to withdraw : ");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            b1.Transaction(choise,found,amount);
                        }
                        else if(choise == 2)
                        {
                            Console.Write("\t\t||Enter the amount you want to Deposit : ");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            b1.Transaction(choise, found, amount);
                        }
                        else if(choise == 3)
                        {
                            Console.Write("\t\t||Enter Receiver Account Number : ");
                            int recAccountNumber = Convert.ToInt32(Console.ReadLine());
                            int search = b1.SearchAccount(recAccountNumber);
                            if(search == found)
                            {
                                Console.WriteLine("\t\t||The receiver Account Number is your.....");
                            }
                            else if (search >= 0)
                            {
                                Console.Write("\t\t||Enter the amount you want to Transfer : ");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                b1.Transaction(choise,found,search,amount);
                            }
                            else
                            {
                                Console.WriteLine("\t\t||\tYou enter a wrong input....\n\t\t||\t\t1 => Go Back\n\t\t||\t\t2=>Exit");
                                int wrong = Convert.ToInt32(Console.ReadLine());
                                if (wrong == 1) continue;
                                else if (wrong == 2) break;
                                else
                                {
                                    Console.WriteLine("\t\t||\tAgain the input was Wrong...Try Some time later");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\t\t||\tYou enter a wrong input....\n\t\t||\t\t1 => Go Back\n\t\t||\t\t2=>Exit");
                            int wrong = Convert.ToInt32(Console.ReadLine());
                            if (wrong == 1) continue;
                            else if (wrong == 2) break;
                            else
                            {
                                Console.WriteLine("\t\t||\tAgain the input was Wrong...Try Some time later");
                                break;
                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("\t\t||\tNo Such Account....");
                    }
                    Console.Write("\t\t=====================================================================\n");
                }
                else if (x == 4)
                {
                    Console.Write("\t\t=====================================================================\n");
                    Console.Write("\t\t||\tEnter You Account Number : ");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                    int found = b1.SearchAccount(accountNumber);
                    if (found >= 0) b1.PrintAccountDetails(found);
                    else Console.WriteLine("\t\t||\tNo such Account.......");
                    Console.Write("\t\t=====================================================================\n");

                }
                else if (x == 5)
                {
                    break;
                }
                else
                {
                    Console.Write("\t\t=====================================================================\n");
                    Console.Write("\t\t||\tYou enter a wrong input....\n\t\t||\t1 => Go Back\n\t\t||\t2=>Exit\n\t\t||Enter : ");
                    int wrong = Convert.ToInt32(Console.ReadLine());
                    if (wrong == 1) continue;
                    else if (wrong == 2) break;
                    else
                    {
                        Console.WriteLine("\t\t||\tAgain the input was Wrong...Try Some time later");
                        Console.Write("\t\t=====================================================================\n");
                        break;
                    }
                    
                }
            }

        }
    }
}
