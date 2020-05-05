
public class Solution {
    public bool KLengthApart(int[] nums, int k) {      
        int distance = int.MaxValue;
        List<int> indexOfOne = new List<int>();
        
        // Take all index of '1' in a list
        for( int i = 0; i < nums.Length; i++ )
        {      
            if(nums[i] == 1) indexOfOne.Add(i);    
        }
        
        // Find the minimum distance between two 1's
        if( indexOfOne.Count > 1 )
        {
            for( int j = 1; j < indexOfOne.Count;j++ )
            {
                if( indexOfOne[j] - indexOfOne[j-1] < distance )
                    distance = indexOfOne[j] - indexOfOne[j-1];
                else continue;
            }            
        }
        
        // Check if minimum distance of the array is greater than "k"  
        if(distance > k) return true;
        else return false;       
    }
}