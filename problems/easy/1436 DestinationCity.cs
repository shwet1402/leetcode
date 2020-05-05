public class Solution {
    public string DestCity(IList<IList<string>> paths) {      
        List<string> departureCity = new List<string>();
        List<string> arrivalCity = new List<string>();

        // Separate DepartureCity and arrivalCity List
        for( int i = 0; i < paths.Count; i++ )
        {
            departureCity.Add(paths[i][0]);
            arrivalCity.Add(paths[i][1]);
        }
        // Check last arrivale city
        for( int j = 0; j < paths.Count; j++ )
        {         
            if(departureCity.Contains(arrivalCity[j])) continue;
            else return arrivalCity[j];
        }        
        return paths[0][1];        
    }
}
