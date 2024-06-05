/*
time: O(n * m) - number of rows * max col size 
space: O(1)
*/
public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) 
    {
        int n = triangle.Count();
        for(int row = n - 2; row >= 0; row--)
        {
            for(int col = 0; col < triangle[row].Count(); col++)
            {
                triangle[row][col] += Math.Min(triangle[row+1][col], triangle[row+1][col+1]);
            }
        }
        return triangle[0][0];
    }
}
