/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    
    let temp = target;
        
    for(let i=0; i<nums.length; i++){
        temp = target - nums[i] 
        if (nums.indexOf(temp) != -1 && nums.indexOf(temp) != i)
            return[i,nums.indexOf(temp)]
    }
};

