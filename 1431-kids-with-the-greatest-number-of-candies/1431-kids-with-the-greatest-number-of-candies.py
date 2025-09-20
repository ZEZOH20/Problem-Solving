class Solution(object):
    def kidsWithCandies(self, candies, extraCandies):
        n = len(candies)
        mx = max(candies)
        result = []
        for c in candies:
            if (c + extraCandies) >= mx:
                result.append(True)
            else:
                result.append(False)
                
        return result 
        