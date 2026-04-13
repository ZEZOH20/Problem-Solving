

class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:

        rows, cols = len(grid), len(grid[0])
        visited = [[False for _ in range(cols)] for _ in range(rows)]
        
        queue = []

        islandCount = 0

        for i in range(len(grid)):
            for j in range(len(grid[0])):
                if grid[i][j] == '1' and not visited[i][j]:
                    queue.append((i, j))
                    visited[i][j] = True
                    islandCount += 1
            
                    while queue:
                        x, y = queue.pop(0)
                    
                    # Check neighbors (up, down, left, right)
                        for dx, dy in [(-1, 0), (1, 0), (0, -1), (0, 1)]:
                            newX, newY = x + dx, y + dy
                        
                            if (0 <= newX < len(grid) and 
                                0 <= newY < len(grid[0]) and 
                                grid[newX][newY] == '1' and 
                                not visited[newX][newY]):
                            
                                queue.append((newX, newY))
                                visited[newX][newY] = True
                            
        
        return islandCount






