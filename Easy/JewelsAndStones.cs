public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int n = 0;
        for(int i = 0; i < jewels.Length; i++)
        {
            for(int j = 0; j < stones.Length; j++)
            {
                if(jewels[i]==stones[j])
                {
                    n++;
                }
            }
        }
        return n;
    }
}
