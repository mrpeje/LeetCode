// O(m*n)
var image = new int[][] { [1, 1, 1], [1, 1, 0], [1, 0, 1] };
var solution = new Solution();
var res = solution.FloodFill(image, 1, 1, 2);
Console.WriteLine(res);
Console.ReadLine();
public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        int rowsLen = image.Length;
        int colsLen = image[0].Length;
        Queue<(int, int)> queue = new Queue<(int, int)>();
        queue.Enqueue((sr, sc));
        int oldColor = image[sr][sc];
        image[sr][sc] = color;

        if (oldColor == color)
            return image;

        int row, col;
        var rowDir = new int[] { -1, 1, 0, 0};
        var colDir = new int[] { 0, 0, -1, 1 };
        while(queue.Count > 0)
        {
            (row,col) = queue.Dequeue();
            for(int i = 0; i <= 3; i++) 
            {
                int newRow = row + rowDir[i];
                int newCol = col + colDir[i];
                if(newRow < rowsLen && newRow >= 0 && newCol < colsLen && newCol >= 0)
                    if (image[newRow][newCol] == oldColor)
                    {
                        image[newRow][newCol] = color;
                        queue.Enqueue((newRow, newCol));
                    }
            }
        }
        return image;
    }
}