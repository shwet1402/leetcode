public class Solution {
    public IList<IList<string>> DisplayTable(IList<IList<string>> orders) {
        
        IList<IList<string>> result = new List<IList<string>>();
        List<string> header = new List<string>(){"Table"};
        
        // Create List of food items in ascending order
        var fooditem = orders.GroupBy(o=> o[2], o=>o[2])
                        .Select(grp => grp.First())
                        .OrderBy(x => x, StringComparer.Ordinal)
                        .ToList();
        
        header.AddRange(fooditem);     
        result.Add(header);
        
       // Create nested loop to group order by table and then by food item
       var table =  from order in orders 
                    group order by order[1] into orderGroup 
                    orderby int.Parse(orderGroup.Key)
                    from newGroup2 in
                    (from order in orderGroup
                    group order by order[2])
                    group newGroup2 by orderGroup.Key;   
        
        // Create list of fooditem count for the table to display count in a 2D List
        foreach (var outerGroup in table)
        {
            List<string> output = new List<string>();
            output.Add(outerGroup.Key);
            
            foreach(var food in fooditem)
            {
                var count = 0;
                foreach(var v in outerGroup)
                {
                    if (food == v.Key) 
                    {
                        count = v.Count();
                        break;
                    }            
                }
                
                output.Add(count.ToString());              
            }
            
            result.Add(output);    
        }   
        
        return result;  
    }
}
