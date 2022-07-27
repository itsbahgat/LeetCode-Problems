/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number}
 */
var findMedianSortedArrays = function(nums1, nums2) {
    let mergedArray=[]
    
    max= nums1.length;
    min= nums2.length;
    len= max+min;
    let FirstIsMaX = true;
    if (nums2.length > max){
        max= nums2.length; 
        min= nums1.length;
        FirstIsMaX = false;
    }
    
    
    
        
    for (let i=0; i<min; i++){
        mergedArray.push(nums1[i])
        mergedArray.push(nums2[i])
    }
    
    for (let i=min; i<max; i++){
        if (FirstIsMaX){
            mergedArray.push(nums1[i])
        }
        else
            mergedArray.push(nums2[i])
    }

    mergedArray.sort(function(a, b){return a-b});

    
    if (mergedArray.length%2 === 1)
        return mergedArray[Math.ceil(len/2)-1]
    else
        return (mergedArray[(len/2)-1]+mergedArray[len/2])/2
        
};