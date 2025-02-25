public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var hashNum = new HashSet<int>();
        foreach (int i in nums) 
        {   
            int count=hashNum.Count;
            hashNum.Add(i);
            if (count==hashNum.Count)
            {
                return true;
            }
        }
        return false;
    }
}