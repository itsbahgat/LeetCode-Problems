/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function(s) {
    
    let len = 0;
    let str = "";
    let substring_list = [];
    let pointer =0;
    

   for (let i=0; i<s.length; i++){
        if (str.indexOf(s[i]) != -1){
            substring_list.push(str);
            str="";
            i= pointer; pointer++; continue;
        }
         
        str += s[i];
       
        if (i === s.length-1 )
             substring_list.push(str);
        
    }

    for (var i in substring_list){
        if (substring_list[i].length > len)
            len = substring_list[i].length;        
    }

    if (len>0)
        return len
    else
        return s.length
};