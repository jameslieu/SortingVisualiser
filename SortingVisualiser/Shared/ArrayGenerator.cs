namespace SortingVisualiser.Shared
{
    public  class ArrayGenerator
    {
        public static int[] Generate(int count = 180)
        {
            int Min = 10;
            int Max = 800;
            Random randNum = new Random();
            int[] randNumbers = Enumerable
                .Repeat(0, count)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();
            return randNumbers;
        }
    }
}
