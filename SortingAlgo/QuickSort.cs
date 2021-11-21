namespace SortingAlgo
{
    public class QuickSort
    {
        public static int[] Sort(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;

            var pivot = arr[(left + right) / 2];
            while (i < j)
            {
                while (arr[i] < pivot)
                    i++;

                while (arr[j] > pivot)
                    j--;

                if (i <= j)
                {
                    var tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
                Sort(arr, left, j);

            if (i < right)
                Sort(arr, i, right);

            return arr;
        }
    }
}