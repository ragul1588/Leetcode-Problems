public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
       
       char[,] board = new char[n,n];
       var result = new List<IList<string>>();
       for(int i=0; i<n; i++)
        for(int j=0; j<n; j++)
          board[i,j]='.';
       
       Nqueens(0,board,result,n);
       return result;
    }

    public void Nqueens(int row, char[,] board,List<IList<string>> res, int n){

        if(row == n){
            res.Add(buildList(board,n));
            return;
        } 
        for(int col=0; col<n; col++){
            if(IsValid(row,col,board,n)){
                board[row,col] = 'Q';
                Nqueens(row+1,board,res,n);
                board[row,col] = '.';
            }
        }
    }

    public bool IsValid(int row, int col, char[,] board, int n){
        for(int i=0; i<row; i++){
            if(board[i,col] == 'Q') return false;
        }
        for(int i=row-1, j=col-1; i>=0 && j>=0; i--,j--) {
              if(board[i,j] == 'Q') return false;
        }
        for(int i=row-1, j=col+1; i>=0 && j<n; i--,j++) {
              if(board[i,j] == 'Q') return false;
        }
        return true;
    }

    public List<string> buildList(char[,] board, int n){
 
      List<string> li = new List<string>();
        for(int i=0; i<n; i++) {
          char[] row = new char[n];
          for(int j=0; j<n; j++) {
             row[j] = board[i,j];
          }
           li.Add(new string(row));
        }
       return li; 
    }
}