using System.Collections.Generic;
using System.Linq;

namespace SortingAlgo
{
    public class MergeSort
    {
        public static List<int> Sort(List<int> arr)
        {
            if (arr.Count <= 1)
                return arr;

            var left = new List<int>();
            var right = new List<int>();

            var middle = arr.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(arr[i]);
            }
            for (int i = middle; i < arr.Count; i++)
            {
                right.Add(arr[i]);
            }

            left = Sort(left);
            right = Sort(right);
            return Merge(left, right);
        }
        
        private static List<int> Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();
            while(left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            return result;
        }
    }
}

