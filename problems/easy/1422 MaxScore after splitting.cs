public class Solution {
    public int MaxScore(string s) {
        int maxScore = 0;
        for( int i = 1; i < s.Length; i++ )
        {  
            int CurrScore = 0;
            // Add score for 0's in the left
            for (int left = 0; left < i; left++)
            {
                if(s[left] == '0') CurrScore++;
            }
            // Add score for 1's in the right
            for( int right = i; right < s.Length; right++ )
            {
                CurrScore += s[right] - '0';
            }
            maxScore = Math.Max(maxScore,CurrScore);
        }
        
        return maxScore;
    }
}
