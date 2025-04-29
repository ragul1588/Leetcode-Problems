public class Solution {
    public void SolveSudoku(char[][] board) {
        solve(board);
    }

    public bool solve(char[][] board){
        for(int i=0; i<9; i++){
            for(int j=0; j<9; j++){
                if(board[i][j]=='.'){
                    for(char c='1'; c<='9'; c++){
                        if(Isvalid(i,j,c,board)){
                            board[i][j]=c;
                            if(solve(board)){
                              return true;
                            }
                            else board[i][j] = '.';
                        }
                    }
                    return false;
                }
            }
        }
        return true;
    }

    public bool Isvalid(int row, int col, char c, char[][] board){
        for(int i=0; i<9; i++){
            if(board[i][col] == c) return false;
            if(board[row][i] == c) return false;
            int rowCalc = 3 * (row / 3) + i / 3;
            int colCalc = 3 * (col / 3) + i % 3;
            if(board[rowCalc][colCalc] == c) return false;
        }
        return true;
    }
}