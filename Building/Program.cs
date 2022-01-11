using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int floorNum = floors; floorNum > 0; floorNum--)
            {
                for (int roomNum = 0; roomNum < rooms; roomNum++)
                {
                    if (floorNum == floors)
                    {
                        Console.Write($"L{floorNum}{roomNum} ");
                    }
                    else if (floorNum % 2 == 0)
                    {
                        Console.Write($"O{floorNum}{roomNum} ");
                    }
                    else
                    {
                        Console.Write($"A{floorNum}{roomNum} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
