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
            Console.Write("Enter Your Bank Name : ");
            string bankName = Console.ReadLine();
            Console.Write("How many account you have? or you Want to insert ? :");
            int size = Convert.ToInt32(Console.ReadLine());

            Bank b1 = new Bank(bankName,size);

            while (true)
            {
                Console.WriteLine("Select the following option : ");
                Console.Write("\t1 => Add Account\n\t2 => Delete Account\n\t3 => Transaction\n\t4 => Show Account Details\n\t5 => Exit\nEnter : ");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x == 1)
                {
                    Console.Write("Enter Account : \n\tName : ");
                    string accountName = Console.ReadLine();
                    Console.Write("\tBalance : ");
                    double balance = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\tAddress :\n\t\tRoad No. : ");
                    string roadNo = Console.ReadLine();
                    Console.Write("\t\tHouse No. : ");
                    string houseNo = Console.ReadLine();
                    Console.Write("\t\tCity : ");
                    string city = Console.ReadLine();
                    Console.Write("\t\tCountry : ");
                    string country = Console.ReadLine();

                    int id = AutoIdGenerator();

                    b1.AddAccount(new Account(id,accountName,balance,new Address(roadNo,houseNo,city,country)));


                }
                else if (x==2)
                {
                    Console.Write("Enter You Account Number : ");
                    int accountNumber =Convert.ToInt32(Console.ReadLine());
                    b1.DeleteAccount(accountNumber);
                }
                else if (x == 3)
                {
                    Console.Write("Enter You Account Number : ");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                    int found = b1.SearchAccount(accountNumber);
                    if (found >= 0)
                    {
                        Console.Write("What do you want to do??\n\t1 => Withdraw\n\t2 =>Deposit \n\t3 =>Transfer\nEnter : ");
                        int choise = Convert.ToInt32(Console.ReadLine());
                        if(choise == 1)
                        {
                            Console.Write("Enter the amount you want to withdraw : ");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            b1.Transaction(choise,found,amount);
                        }
                        else if(choise == 2)
                        {
                            Console.Write("Enter the amount you want to Deposit : ");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            b1.Transaction(choise, found, amount);
                        }
                        else if(choise == 3)
                        {
                            Console.Write("Enter Receiver Account Number : ");
                            int recAccountNumber = Convert.ToInt32(Console.ReadLine());
                            int search = b1.SearchAccount(recAccountNumber);
                            if(search == found)
                            {
                                Console.WriteLine("The receiver Account Number is your.....");
                            }
                            else if (search >= 0)
                            {
                                Console.Write("Enter the amount you want to Transfer : ");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                b1.Transaction(choise,found,search,amount);
                            }
                            else
                            {
                                Console.WriteLine("You enter a wrong input....\n\t1 => Go Back\n\t2=>Exit");
                                int wrong = Convert.ToInt32(Console.ReadLine());
                                if (wrong == 1) continue;
                                else if (wrong == 2) break;
                                else
                                {
                                    Console.WriteLine("Again the input was Wrong...Try Some time later");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("You enter a wrong input....\n\t1 => Go Back\n\t2=>Exit");
                            int wrong = Convert.ToInt32(Console.ReadLine());
                            if (wrong == 1) continue;
                            else if (wrong == 2) break;
                            else
                            {
                                Console.WriteLine("Again the input was Wrong...Try Some time later");
                                break;
                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("No Such Account....");
                    }
                }
                else if (x == 4)
                {
                    Console.Write("Enter You Account Number : ");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                    int found = b1.SearchAccount(accountNumber);
                    if (found >= 0) b1.PrintAccountDetails(found);
                    else Console.WriteLine("No such Account.......");

                }
                else if (x == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You enter a wrong input....\n\t1 => Go Back\n\t2=>Exit");
                    int wrong = Convert.ToInt32(Console.ReadLine());
                    if (wrong == 1) continue;
                    else if (wrong == 2) break;
                    else
                    {
                        Console.WriteLine("Again the input was Wrong...Try Some time later");
                        break;
                    }
                }
            }

        }
    }
}
