using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                double totalMoney = 0;
                
                if (destination == "End")
                {
                    break;
                }
                
                double budgetNeeded = double.Parse(Console.ReadLine());

                while (true)
                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    totalMoney += savedMoney;

                    if (totalMoney >= budgetNeeded)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
            }
        }
    }
}
