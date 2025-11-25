public class Solution {
    public int[] TopKFrequent(int[] nums, int k){
      //creating a dictoinary map
        Dictionary<int, int> freq = new();
        foreach (int n in nums)
        {
            if (freq.ContainsKey(n))
                freq[n]++;
            else
                freq[n] = 1;
        }
      //defining the max number of frequency
        int maxFreq = 0;
        foreach (var pair in freq)
        {
            if (pair.Value > maxFreq)
                maxFreq = pair.Value;
        }
      //creating a bucket list and putting the numbers and their frequency values
        List<int>[] bucket = new List<int>[maxFreq + 1];
        for (int i = 0; i <= maxFreq; i++)
        {
            bucket[i] = new List<int>();
        }
        foreach (var pair in freq)
        {
            int number = pair.Key;
            int frequency = pair.Value;
            bucket[frequency].Add(number);
        }
      //getting the k most frequent elements
        List<int> result = new();
        for (int i = maxFreq; i > 0 && result.Count < k; i--)
        {
            foreach (int num in bucket[i])
            {
                result.Add(num);
                if (result.Count == k)
                    break;
            }
        }

        return result.ToArray();
    }
}
