class Solution:
    def reverseVowels(self, s: str) -> str:
        vowels = ['a', 'e', 'i', 'o', 'u' , 'A', 'E', 'I', 'O', 'U']

        sList = list(s)
        leftIndex = 0
        rightIndex = len(s) - 1
        while(leftIndex < rightIndex):
            while(leftIndex < rightIndex and sList[leftIndex] not in vowels):
                leftIndex += 1

            while(leftIndex < rightIndex and sList[rightIndex] not in vowels):
                rightIndex -= 1

            sList[leftIndex], sList[rightIndex] = sList[rightIndex], sList[leftIndex]
            leftIndex += 1
            rightIndex -= 1
            
        return "".join(sList)
        