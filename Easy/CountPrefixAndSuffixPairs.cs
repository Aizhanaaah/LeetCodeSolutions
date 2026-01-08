public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        int n = 0;
        for (int i = 0; i < words.Length-1; i++)
        {
            for(int j = i+1; j < words.Length; j++)
            {
                if(words[i].Length <= words[j].Length &&
                words[i] == words[j].Substring(0, words[i].Length) &&
                words[i] == words[j].Substring(words[j].Length - words[i].Length, words[i].Length))
                {
                    n++;
                }        
            }
        }
        return n;
    }
}
