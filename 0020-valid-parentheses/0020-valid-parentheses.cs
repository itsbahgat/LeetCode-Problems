public class Solution {
    public bool IsValid(string s) {
        
        Stack<char> stack = new Stack<char>();
        Dictionary<char,char> dic = new Dictionary<char, char>() 
        { {'{' ,'}'}, { '[', ']' } , { '(', ')' } };


        stack.Push(s[0]);
        for (int i = 1; i < s.Length; i++)
        {
            if (stack.Count()>0 && dic.ContainsKey(stack.Peek()) && dic[stack.Peek()] == s[i])
                stack.Pop();
            else
                stack.Push(s[i]);
        }

        return stack.Count() > 0 ? false:true ;

        }

}