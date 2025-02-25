public class Solution {
    public bool IsAnagram(string s, string t) {
        //s
        if(s.Length!=t.Length) return false;
       Dictionary<char, int> map = new Dictionary<char, int>();
foreach (var ch in s)
{
    if (map.ContainsKey(ch))
    {
        map[ch]++;
    }
    else
    {
        map[ch] = 1;
    }
}
foreach (var ch in t)
{
    if (!map.ContainsKey(ch))
    {
        map[ch] = 1;
    }
    else
    {
        map[ch] -= 1;
    }
}
foreach (var kvp in map)
{
    if (kvp.Value != 0)
    {
        return false;
    }

}
return true;
}
}