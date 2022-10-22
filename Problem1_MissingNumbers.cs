// Approach: Use the array index as the hashmap, storing the number and sign representing occurance of i+1. Go through each number and mark the corresponding index as negative. Reiterate and see if each number has occured.
// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> ans = new List<int>();
        for(int i=0; i<nums.Length; i++){
            int index = Math.Abs(nums[i]) -1;
            if(nums[index]  >0)
                nums[index]*=-1;
        }
        
        for(int i=1; i<=nums.Length; i++)
        {
            if(nums[i-1] > 0)
            {
                ans.Add(i);
            }
        }
        
        return ans;
    }
}
