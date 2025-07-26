public class Solution {
 public string FrequencySort(string s) {
        
        int[] characters = new int[128];
        int n = s.Length;
        char[] result = new char[n];
        foreach(char a in s){
            characters[a]++;
        }
        
        int resultIndex = 0;
        while(true){
        int maxLen = 0;
        char maxchar = ' ';
            for(int i='0'; i<='z'; i++){
                if(characters[i]>maxLen){
                    maxLen = characters[i];
                    maxchar = (char)i;
                }
            }
            if(maxchar == ' ') break;
           
            for(int i=0; i<maxLen; i++){
              result[resultIndex] = maxchar;
              resultIndex++;
            }
             characters[maxchar] = 0;
        }
        return new string(result);
    }
}