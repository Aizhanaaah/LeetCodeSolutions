public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] array = new int[2];
        int left = 0;
        int right = numbers.Length-1;
        while(left<right)
        {
            int curSum = numbers[left]+numbers[right];
            if(curSum > target)
            {
                right--;
            }
            else if(curSum<target)
            {
                left++;
            }
            else
            {
                array[0] = left+1;
                array[1] = right+1;
                return new int[] { left + 1, right + 1 };
            }
        } 
        return new int[2]; 
    }
}
