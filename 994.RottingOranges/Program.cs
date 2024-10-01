// O(m*n)
var image = new int[][] { [1], [2], [1], [2] };
var solution = new Solution();
var res = solution.OrangesRotting(image);
Console.WriteLine(res);
Console.ReadLine();
public class Solution
{
    public int OrangesRotting(int[][] grid)
    {
        int result = 0;
        int rowCount = grid.Length;
        int colCount = grid[0].Length;
        Queue<(int, int)> queue = new Queue<(int, int)> ();
        bool noOrange = true;
        for (int i = 0; i < rowCount; i++)
            for (int j = 0; j < colCount; j++)
            {
                if (grid[i][j] == 2)
                {
                    queue.Enqueue((i, j));
                    noOrange = false;
                }
            }
        var rowDir = new int[] { -1, 1, 0, 0 };
        var colDir = new int[] { 0, 0, -1, 1 };
        while (queue.Count > 0)
        {
            var addToQueue = new List<(int, int)>();
            while (queue.Count > 0)
            {                
                (int r, int c) = queue.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int col = c + colDir[i];
                    int row = r + rowDir[i];
                    if(col >= 0 && col < colCount && 
                        row >= 0 && row < rowCount)
                    {
                        if (grid[row][col] == 1)
                        {
                            grid[row][col] = 2;
                            addToQueue.Add((row, col));
                        }
                    }
                }
            }
            result++;
            for (int i = 0; i < addToQueue.Count; i++)
            {
                queue.Enqueue(addToQueue[i]);
            }
        }
        for (int i = 0; i < rowCount; i++)
            for (int j = 0; j < colCount; j++)
            {
                if (grid[i][j] == 1)
                {
                    return -1;    
                }
            }
        if (noOrange)
            return 0;
        return result-1;
    }
}