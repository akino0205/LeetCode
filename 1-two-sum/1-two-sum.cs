public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        for(int firstIdx = 0; firstIdx < nums.Length; firstIdx++)
        {
            for(int secondIdx = firstIdx+1; secondIdx < nums.Length; secondIdx++)
            {
                if((nums[firstIdx] + nums[secondIdx]) == target)
                {
                    result[0] = firstIdx;
                    result[1] = secondIdx;
                    return result;
                }
            }
        }
        return result;
    }
}