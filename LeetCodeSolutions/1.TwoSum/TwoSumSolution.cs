namespace LeetCodeSolutions._1.TwoSum
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var firstOperand = 0;
            var secondOperand = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            firstOperand = i;
                            secondOperand = j;
                        }
                    }
                }
            }

            return new int[] { firstOperand, secondOperand };
        }
    }
}
