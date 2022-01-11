using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinationCounter = 0;
            int combinationNum1 = 0;
            int combinationNum2 = 0;
            int magicNumCounter = 0;
            bool flag = false;

            for (int x1 = num1; x1 <= num2; x1++)
            {
                for (int x2 = num1; x2 <= num2; x2++)
                {
                    combinationCounter++;
                    int sum = x1 + x2;

                    if (sum == magicNum)
                    {
                        combinationNum1 = x1;
                        combinationNum2 = x2;
                        magicNumCounter = combinationCounter;
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine($"Combination N:{magicNumCounter} ({combinationNum1} + {combinationNum2} = {magicNum})");
            }
            else
            {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNum}");
            }
        }
    }
}
