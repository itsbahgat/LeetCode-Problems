public class Solution {
    public int EvalRPN(string[] tokens) {
        
        Stack<int> stack = new Stack<int>();
        int x,y,result;
        for(int i=0; i<tokens.Length; i++){


            if(tokens[i] is "+" or "-" or "*" or "/"){
                y = stack.Pop();
                x = stack.Pop();

                if(tokens[i] is "+") 
                    result = x + y;
                else if (tokens[i] is "-")
                    result = x - y;

                else if (tokens[i] is "*")
                    result = x * y;
                else 
                    result = x / y;

                stack.Push(result);
            }

            else
                stack.Push(Int32.Parse(tokens[i]));
        }

        return stack.Pop();
    }
}