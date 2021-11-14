namespace SortingAlgo
{
    public class QuickSort
    {
        public static List<int> Sort(List<int> numbers, int left, int right)
        {
            int i = left;
            int j = right;

            var pivot = numbers[(left + right) / 2];
            while (i < j)
            {
                while (numbers[i] < pivot)
                    i++;

                while (numbers[j] > pivot)
                    j--;

                if (i <= j)
                {
                    var tmp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
                Sort(numbers, left, j);

            if (i < right)
                Sort(numbers, i, right);

            return numbers;
        }
    }
}