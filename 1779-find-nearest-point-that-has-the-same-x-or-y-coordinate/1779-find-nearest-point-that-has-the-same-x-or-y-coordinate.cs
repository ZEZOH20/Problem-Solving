public class Solution {
    public int NearestValidPoint(int x, int y, int[][] points) {
        int n = points.Length;
        int indexResult = -1;
        int distance = Int32.MaxValue;
        for(int i=0;i<n;i++){
            int x1 = points[i][0];
            int y1 = points[i][1];
            if(x==x1||y==y1){
                int calcDistance = Math.Abs(x-x1) + Math.Abs(y-y1);
                if(calcDistance < distance){
                    distance = calcDistance;
                    indexResult = i;
                }
            }

        }
        return indexResult;
    }
}