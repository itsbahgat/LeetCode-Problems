/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function(x) {
    let digits = [];
    
   
    if (x < 0)
        return false;
    else
    {
        let i = 0;
        while(Math.trunc(x) > 0){
            digits[i]= Math.trunc(x%10);
            x /= 10;
            i++;
        } 
        
        let Size = digits.length;
        for(i=0; i < Math.trunc(Size/2); i++)    
           if (digits[i] !== digits[Size-1-i])
                  return false;      
    } 
    return true;    
};