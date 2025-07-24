public class Solution {
    public string FrequencySort(string s) {
       var freqMap = new Dictionary<char, int>();
    foreach (char c in s) {
        if (freqMap.ContainsKey(c)) {
            freqMap[c]++;
        } else {
            freqMap[c] = 1;
        }
    }
    var sorted = freqMap.OrderByDescending(kvp => kvp.Value);

    var result = new StringBuilder();
    foreach (var kvp in sorted) {
        result.Append(new string(kvp.Key, kvp.Value));
    }

    return result.ToString();              
    }
}