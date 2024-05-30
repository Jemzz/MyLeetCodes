namespace Leetcodes.LeetSolutions
{
    public class TwoSumSol
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int comp = target - nums[i];

                if (dict.ContainsKey(comp))
                {
                    return new int[] { dict[comp], i };
                }

                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }

            return new int[0];
        }
    }
}
