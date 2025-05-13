public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        int counter =0;
       foreach(int num in arr){
            if(counter > 2)
                break;
             if(num % 2 == 0)
                counter = 0;
              else
                counter++;  
       } 
       return counter == 3 ? true : false;
    }
}