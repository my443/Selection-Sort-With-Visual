using System.Numerics;

class Program()
{
    static void Main(string[] args)
    {
        int[] ints = { 1, 7, 9, 2, 4, 3 };

        int currentMinimum = 0;
        int currentItem = 0;

        for (int i = 0; i < ints.Length; i++)
        {
            currentMinimum = i;

            for (int j = i; j < ints.Length; j++)
            {   
                if (ints[j] < ints[currentMinimum]) {
                    currentMinimum = j;
                }
                PrintResults(j, i, currentMinimum,ints);
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }

            if (currentMinimum != i)
            {
                int newMin = ints[currentMinimum];
                int newMax = ints[i];

                ints[i] = newMin;
                ints[currentMinimum] = newMax;
            }

            Console.WriteLine("--- NEXT LOOP ---");

        }
    }

    static void PrintResults(int innerLoopItem, int currentItem, int currentMinimum, int[] ints)
    {
        foreach (int i in ints)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        for (int i = 0; i < currentItem; i++)
        {
            Console.Write("  ");
        }
        Console.Write("^ ");
        Console.WriteLine();
        for (int i = 0; i < innerLoopItem; i++)
        {
            Console.Write("  ");
        }
        Console.WriteLine("# ");
        for (int i = 0; i < currentMinimum; i++) {
            Console.Write("  ");
        }
        Console.WriteLine("M ");
        //Console.WriteLine();


    }
}