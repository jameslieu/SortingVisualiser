int Min = 0;
int Max = 200;
int count = 200;
Random randNum = new Random();
int[] randNumbers = Enumerable
    .Repeat(0, count)
    .Select(i => randNum.Next(Min, Max))
    .ToArray();

for (int i = 0; i < randNumbers.Length; i++)
{
    Console.WriteLine(randNumbers[i]);
}

Console.ReadLine();
