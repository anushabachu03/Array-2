// Time Complexity: O(mn)
// Space Complexity: O(1)
public class Solution {
    public static readonly int Live =1, Dead =0, LiveToDead =2, DeadToLive =3;
    int[][] board;
    int m, n;
    int[, ] offsets = new int[,] {
        {-1,0},
        {-1, 1},
        {0, 1},
        {1, 1},
        {1, 0},
        {1, -1},
        {0, -1},
        {-1, -1}
    };
    public void GameOfLife(int[][] board) {
        this.board = board;
        m = board.Length;
        n=board[0].Length;
        
        for(int i=0; i<m; i++){
            for(int j=0; j<n; j++){
                int n = LiveNeighbors(i, j);
                if(board[i][j] == Live ){
                    if(n <2 || n>3)
                        board[i][j] = LiveToDead;
                }
                else if(n==3)
                    board[i][j] = DeadToLive;
            }
        }
        
        for(int i=0; i<m; i++){
            for(int j=0; j<n; j++){
                if(board[i][j] == LiveToDead)
                    board[i][j] = Dead;
                else if(board[i][j] == DeadToLive)
                    board[i][j] = Live;
            }
        }
        
    }
    
    public int LiveNeighbors(int i, int j){
        int count = 0;
        for(int k=0; k<8; k++){
            int row = i+ offsets[k,0];
            int col = j+ offsets[k,1];
            if(row >=0 && row < m && col >=0 && col< n){
                if(board[row][col] == Live || board[row][col] == LiveToDead)
                    count++;
            }
        }
        
        return count;
    }
}
