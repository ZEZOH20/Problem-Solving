class Solution(object):
    def uniqueOccurrences(self, arr):
        dic = {}
        for i in arr:
            if i in dic:
                dic[i] += 1
            else:
                dic[i] = 1
           
        duplic = []
        for i in dic.values():
            if i in duplic:
                return False
            duplic.append(i)  
            
        return True  