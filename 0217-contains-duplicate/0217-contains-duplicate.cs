public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        HashSet<int> set = nums.ToHashSet();
        if (set.Count < nums.Length)
            return true;
        
        // for (int i=0; i<nums.Length; i++){
        //         if (set.Contains(nums[i])){
        //              return true;
        //         }
        //         set.Add(nums[i]);
        // }
        
        return false;
    }
}