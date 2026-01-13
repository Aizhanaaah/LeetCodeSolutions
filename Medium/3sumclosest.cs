public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
      //closest sum is initialised to compare every sum, so we get the closest number to target:
        int closest = nums[0] + nums[1] + nums[2];
        //3 pointers that move around the sorted array:
        for (int i = 0; i < nums.Length - 2; i++) {
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];
        //the distance between the actual target and current sum is compared to a distance between best sum and target, if it is smaller, which means closer, current sum is now a closest which will be compared to next sums
                if (Math.Abs(sum - target) < Math.Abs(closest - target)) {
                    closest = sum;
                }
                if (sum < target) {
                    left++;
                } else if (sum > target) {
                    right--;
                } else {
                    return sum; 
                }
            }
        }

        return closest;
    }
}
