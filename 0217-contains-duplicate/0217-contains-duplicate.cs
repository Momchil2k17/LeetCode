public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var hashNum = new HashSet<int>(nums);
        return hashNum.Count<nums.Length;
    }
}