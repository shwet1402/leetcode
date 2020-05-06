
public class Solution {
    public int MinNumberOfFrogs(string croakOfFrogs) {
        int result = 0;
        int currentopen = 0;
        
        int c = 0;
        int r = 0;
        int o = 0;
        int a = 0;
        int k = 0;
        
        foreach (var v in croakOfFrogs)
        {
            if(v=='c') 
            {
                c++;
                currentopen ++;
                result = Math.Max(result, currentopen);             
            }     
            if(v =='r') 
            {
                if(c == 0) return -1;
                else 
                {
                    r++;
                    c--;
                    continue;
                }         
            }
            if(v =='o') 
            {          
                if(r == 0) return -1;
                else 
                {
                    o++;
                    r--;
                    continue;
                }           
            }
            if(v =='a') 
            {       
                if(o == 0) return -1;
                else 
                {
                    a++;
                    o--;
                    continue;
                }             
            }
            if(v =='k') 
            {            
                if(a == 0) return -1;
                else 
                {
                    a--;
                    currentopen--;
                    continue;
                }             
            }              
        }  
        return currentopen>0 ? -1:result;      
    }
}