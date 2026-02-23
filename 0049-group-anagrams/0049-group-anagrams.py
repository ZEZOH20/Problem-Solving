
from collections import defaultdict
class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        # words = strs.strip("[] ").replace('"', '').split(',')
        groups = defaultdict(list)
        for word in strs:
            key = ''.join(sorted(word,key=str.lower))
            groups[key].append(word)

        result = []
        for group in groups.values():
            result.append(group)

        return result        
        