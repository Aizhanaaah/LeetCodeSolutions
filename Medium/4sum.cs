public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        IList<IList<int>> list = new List<IList<int>>();
        Array.Sort(nums);
      //4 points move through the array
        for(int i = 0; i < nums.Length-3; i++)
        {
          //i duplicate constraints:
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            for(int j = i+1; j<nums.Length-2; j++)
            {
                int left = j+1;
                int right = nums.Length-1;
              //j duplicate contraints:
                if (j > i+1 && nums[j] == nums[j - 1]) continue;
                while(left<right)
                {
                  //in case that the size of sum of the elements can exceed the int size:
                    long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
                    if(sum<target)
                    {
                        left++;
                    }
                    else if(sum>target)
                    {
                        right--;
                    }
                    else
                    {
                        list.Add(new List<int> { nums[i], nums[j], nums[left], nums[right]});
                        left++;
                        right--;
                      //left and right constraints:
                        while (left < right && nums[left] == nums[left - 1]) left++;
                        while (left < right && nums[right] == nums[right + 1]) right--;
                    }
                }
            }
        }
        return list;
    }
}
