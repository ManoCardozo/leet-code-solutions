using System.Linq;
using System.Collections.Generic;

namespace LeetCodeSolutions._4.MedianOfTwoSortedArrays
{
    public class MedianOfTwoSortedArraysSolution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var sortedArrays = new int[nums1.Length + nums2.Length];
            nums1.CopyTo(sortedArrays, 0);
            nums2.CopyTo(sortedArrays, nums1.Length);

            var hash = new List<int>(sortedArrays).OrderBy(o => o).ToList();

            double median;

            if (hash.Count == 1)
            {
                median = hash[0];
            }
            else if (hash.Count % 2 != 0)
            {
                var medianIndex = (hash.Count + 1) / 2;
                median = hash[medianIndex - 1];
            }
            else
            {
                var firstMedianIndex = (int)((hash.Count / 2) - 0.5);
                var secondMedianIndex = (int)((hash.Count / 2) + 0.5);
                var firstVal = hash[firstMedianIndex];
                var secondal = hash[secondMedianIndex];

                median = ((double)firstVal + (double)secondal) / 2;

                var asd = firstVal / 2;
            }


            return median;
        }
    }
}
