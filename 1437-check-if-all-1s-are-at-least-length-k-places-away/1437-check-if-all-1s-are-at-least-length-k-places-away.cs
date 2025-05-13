public class Solution {
    public bool KLengthApart(int[] nums, int k) {
        int tempIndex = -1;
        bool result = true;
        for(int i=0;i<nums.Length;i++){
            if(nums[i] == 1 && tempIndex == -1)
                tempIndex = i;
            else if(nums[i] == 1){
                int distance  = i - tempIndex - 1;
                 if(distance < k){
                    result = false;
                    break;
                 }
                tempIndex = i; 
            }    
        }
      return result;
    }
}