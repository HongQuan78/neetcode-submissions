public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new HashSet<string>();
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[i].Length; j++)
            {
                if(board[i][j] == '.')
                {
                    continue;
                }

                char value = board[i][j];
                string rowKey = "r" + i + "-" + value;
                string colKey = "c" + j + "-" + value;
                string boxKey = "b" + (i/3) + "-" + (j/3) + "-" + value;

                if(seen.Contains(rowKey) || 
                   seen.Contains(colKey) || 
                   seen.Contains(boxKey))
                {
                    return false;
                }

                seen.Add(rowKey);
                seen.Add(colKey);
                seen.Add(boxKey);
            }
        }

        return true;
    }
}
