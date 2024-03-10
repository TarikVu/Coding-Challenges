using System;
/* 
Source: https://leetcode.com/problems/valid-parentheses/description/

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', 
determine if the input string is valid. An input string is valid if:

- Open brackets must be closed by the same type of brackets.
- Open brackets must be closed in the correct order.
- Every close bracket has a corresponding open bracket of the same type. 
*/

public class ValidParenthesisProblem
{
    public bool IsValid(string s)
    {

        if (s.Length < 2)
        {
            return false;
        }

        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }

            else
            {

                if (stack.Count == 0)
                {
                    return false;
                }

                switch (c)
                {
                    case ')':
                        if (stack.Peek() != '(')
                        {
                            return false;
                        }
                        else
                        {
                            stack.Pop();
                            break;
                        }
                    case '}':
                        if (stack.Peek() != '{')
                        {
                            return false;
                        }
                        else
                        {
                            stack.Pop();
                            break;
                        }
                    case ']':
                        if (stack.Peek() != '[')
                        {
                            return false;
                        }
                        else
                        {
                            stack.Pop();
                            break;
                        }


                }
            }
        }
        return stack.Count == 0;
    }
}