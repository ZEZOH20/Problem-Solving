from collections import defaultdict
class Solution:
    def topKFrequent(self, nums: list[int], k: int) -> list[int]:
        dic = defaultdict(int)
        #build hash
        for i in nums:
            dic[i]+=1
            
        # Step 1: get list of (key, value) tuples
        items = list(dic.items())

        # Step 2: Bubble sort by value (ascending)
        n = len(items)
        for i in range(n):
            for j in range(i+1, n):
                if items[j][1] > items[i][1]:
                    items[i], items[j] = items[j], items[i]

        # Step 3: create new dictionary
        sorted_dict = dict(items)
        sorted_dict_keys = sorted_dict.keys()
        # print(sorted_dict)
        
        return list(sorted_dict)[:k]