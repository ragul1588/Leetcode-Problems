public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        
        List<int> li = new List<int>();
        int count=0;
       foreach(string a in words){
           if(a.Contains(x)){
            li.Add(count);
           }
            count++;
       }
       return li;
    }
}