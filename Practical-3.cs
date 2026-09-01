using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{
    namespace DailyExpense
    {
        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("Enter Expense ID:");
                    int expenseId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Expense Category:");
                    string category = Console.ReadLine();

                    Console.WriteLine("Enter Expense Amount:");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Payment Type (Cash/UPI/Card):");
                    string paymentType = Console.ReadLine();

                    DateTime currentDate = DateTime.Now;

                    if (expenseId <= 0)
                    {
                        throw new Exception("Expense ID must be greater than 0.");
                    }

                    if (string.IsNullOrWhiteSpace(category))
                    {
                        throw new Exception("Expense Category cannot be empty.");
                    }

                    if (amount <= 0)
                    {
                        throw new Exception("Expense Amount must be greater than 0.");
                    }

                    if (string.IsNullOrWhiteSpace(paymentType))
                    {
                        throw new Exception("Payment Type cannot be empty.");
                    }

                    Console.WriteLine("\n----- Daily Expense Details -----");
                    Console.WriteLine("Expense ID      : " + expenseId);
                    Console.WriteLine("Category        : " + category);
                    Console.WriteLine("Amount          : $" + amount);
                    Console.WriteLine("Payment Type    : " + paymentType);
                    Console.WriteLine("Current Date    : " + currentDate.ToString("dd-MM-yyyy"));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter the correct data type.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Manual Exception: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Execution Done !!!!");
                }

                Console.ReadLine();
            }
        }
    }
}
