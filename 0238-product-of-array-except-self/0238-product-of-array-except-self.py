class Solution:
    
    def productExceptSelf(self, nums: list[int]) -> list[int]:
        # Generating prefix and suffix arrays
        prefix = [nums[0]]
        for i in range(1,len(nums)):
            prefix.append(nums[i] * prefix[i-1])
    
        suffix = [0] * len(nums)
        suffix[-1] = nums[-1] 
        for i in range(len(nums)-2, -1, -1):
            suffix[i] = nums[i] * suffix[i+1]

        output = [] 
        for i in range(len(nums)):
            prefixIndex = i - 1
            suffixIndex = i + 1
            prefixValue = 1 if prefixIndex == -1 else prefix[prefixIndex]
            suffixValue = 1 if suffixIndex == len(nums) else suffix[suffixIndex]
      
            product = prefixValue * suffixValue
            output.append(product)      
        return output