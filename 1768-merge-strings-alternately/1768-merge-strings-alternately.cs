public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int wl1 = word1.Length;
        int wl2 = word2.Length;
        string result = "";

        for(int i=0;i<Math.Max(wl1,wl2);i++){
            if(i < wl1)
                result+=word1[i];
            if(i < wl2)
                result+=word2[i];
        }
        return result;
    }
}