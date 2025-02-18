public class Solution {
    public string MergeAlternately(string word1, string word2) {
        
        int w1 = word1.Length, w2 = word2.Length, i =0;
        string result = "";

        while(w1>0 && w2>0){
            result +=word1[i];
            result +=word2[i];
            w1--;
            w2--;
            i++;
        }
        while(w1>0){
            result +=word1[i];
            w1--;
            i++;
        }
        while(w2>0){
            result +=word2[i];
            w2--;
            i++;
        }
      return result;
    }
}