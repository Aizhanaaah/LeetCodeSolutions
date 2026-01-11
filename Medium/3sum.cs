public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> list = new List<IList<int>>();
      //input array should be sorted for the sake of duplication finding simplicity
        Array.Sort(nums);
        for(int i = 0; i < nums.Length-2; i++)
        {
           //two pointers and i to travel through the array indexes, all of them are supposed to be in different positions, they should not clash. i index should leave rooms for right and left
            int left = i+1;
            int right = nums.Length-1;
          //to avoid duplicates every previous i is checked, if they are equal we dont do any operations with them
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            while(left<right)
            { 
              //the sum of all 3 elements of each array should be equal to 0, and if less than 0 left pointer should go to next position, if more than 0 right pointer should go to previous position
              //if equal to 0, array of elements are added to list of lists, and pointers continue to travel, same duplication  rule applies to left and right pointers too as well
                int curSum = nums[left]+nums[right];
                if(curSum<(-nums[i]))
                {
                    left++;
                }
                else if(curSum>(-nums[i]))
                {
                    right--;
                }
                else
                {
                    list.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;
                    right--;
                    while (left < right && nums[left] == nums[left - 1]) left++;
                    while (left < right && nums[right] == nums[right + 1]) right--;
                }
            }
        }
        return list;
    }
}
