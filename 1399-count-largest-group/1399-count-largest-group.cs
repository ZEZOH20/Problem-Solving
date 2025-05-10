public class Solution {
    public int CountLargestGroup(int n) {
        Dictionary<int, int> groups =
      new Dictionary<int, int>();
      int largestG = 0;
      int sDigit = 0;
      
      for(int i=1;i<=n;i++){
        int temp = i;
         while(temp > 0){
            sDigit += temp%10;
            temp /=10;
         }
         if (!groups.ContainsKey(sDigit))
            {
                groups[sDigit] = 1;
            }else{
                groups[sDigit]++;
            }
          //find the largest group elements amount
         if(groups[sDigit] > largestG){
            largestG = groups[sDigit];
         }
         sDigit = 0;
      }

    //find how much groups containing the largest group elements amount (largestG)
      int result = 0;
      foreach (var item in groups){
         if(item.Value == largestG)
            result++;
      }
      return result;
    }
}