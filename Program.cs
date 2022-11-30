using System;

public static class Globals
{
	internal static void Main()

	{
        Console.Write("Determinati cifra de pe poziti k a numarului x");
        Console.Write("\n");
        int x;
		int k;
        Console.Write("x = ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("k = ");
        k = Convert.ToInt32(Console.ReadLine());
        int i = 1;
		int p = 1;
		while (i < k)
		{
			p = p * 10;
			i++;
		}
		int pozitia = (x / p) % 10;
        Console.Write("Cifra de pe pozitia "+ k + " este : ");
        Console.Write(pozitia);
        Console.Write("\n");
    }
}

