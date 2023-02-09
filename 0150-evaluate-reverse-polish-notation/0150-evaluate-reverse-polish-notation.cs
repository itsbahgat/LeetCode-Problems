public class Solution {
    public int EvalRPN(string[] tokens) {

        Dictionary <string,Func<int,int,int>> functions = new Dictionary <string,Func<int,int,int>>()
        {
            {"+",(x,y)=> x+y },
            {"*",(x,y)=> x*y },
            {"/",(x,y)=> x/y },
            {"-",(x,y)=> x-y }
            };
        
        Stack<int> stack = new Stack<int>();
        int x,y;
        for(int i=0; i<tokens.Length; i++){
            if(functions.ContainsKey(tokens[i])){
                y = stack.Pop();
                x = stack.Pop();
                stack.Push(functions[tokens[i]](x,y));
            }

            else
                stack.Push(Int32.Parse(tokens[i]));
        }

        return stack.Pop();
    }
}