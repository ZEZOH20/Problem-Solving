class RecentCounter:
    
    def __init__(self):
        self.requests = []
      
        
    def ping(self, t: int) -> int:
        # range [x , t]
        x = t - 3000
        
        self.requests.append(t)
        counter = 0
        for i in self.requests:
            if i >= x and i <= t :
                counter+=1
            
        return counter
        


# Your RecentCounter object will be instantiated and called as such:
# obj = RecentCounter()
# param_1 = obj.ping(t)