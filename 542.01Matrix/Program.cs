// O(m*n)
var image = new int[][] { [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [1, 1, 1], [0, 0, 0] };
var solution = new Solution();
var res = solution.UpdateMatrix(image);
for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine();
    for (int j = 0; j < res[i].Length; j++)
        Console.Write(res[i][j] + " ");
}
Console.ReadLine();
public class Solution
{
    public int[][] UpdateMatrix(int[][] mat)
    {
        int columns = mat[0].Length;
        int rows = mat.Length;
        int maxValue = columns + rows;
        Queue<(int, int)> queue = new Queue<(int, int)>();


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (mat[i][j] == 0)
                {
                    queue.Enqueue((i, j));
                }
                else
                    mat[i][j] = maxValue;        
            } 
        }
        var rowDir = new int[] { -1, 1, 0, 0 };
        var colDir = new int[] { 0, 0, -1, 1 };
        while (queue.Count > 0)
        {           
            var (row, col) = queue.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                var newRow = row + rowDir[i];
                var newCol = col + colDir[i];
                if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < columns && mat[newRow][newCol] > mat[row][col] + 1)
                {
                    mat[newRow][newCol] = mat[row][col] + 1;
                    queue.Enqueue((newRow, newCol));
                }
            }            
        }
        return mat;
    }
}