/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function(x) {
    let reverseNum = "";
    let xCopy = x;
   
    if (x < 0)
        return false;
    else
    {
        let i = 0;
        while(Math.trunc(x) > 0){
            reverseNum += Math.trunc(x%10);
            x /= 10;
            i++;
        } 
    console.log(reverseNum)
        
    if (reverseNum == xCopy)   
        return true;
    else 
        return false;
    } 
       
};