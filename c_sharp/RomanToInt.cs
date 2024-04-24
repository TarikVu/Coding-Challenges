using System;

public class RomanToIntProblem
{

    public int RomanToInt(string s) {
    
        // Explanation:
        // Brute force approach
        // Look at s iteratively, and sum it up this way and have each of the 
        // six subtraction cases as if statements that are to be checked. 
        // Time: O(n), Space: O(1)

        // Can we do better?
        // Why not get rid of the pesky logic that the romans use? 
        // we can keep to a simple O(n) Traversal from left to right and now worry about
        // the subtraction cases.  Why not just replace the 6 cases with their "improper forms"
        // to simplify our algorithm? 
        // Answer utilize the "replace" built in method and replace every instance of the subtract
        // form with the left to right ascending form. This would require setup and the time complexity
        // would be affected depending on the helper method's backend implementation.
        // this also alleviates the need of looking at multiple chars at once. 
        // Finally just save the chars and their respective values inside a dictionary.
        // Time: O(n), Space: O(1)

        Dictionary<char, int> dict = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        // Replace the subtraction cases:
        s = s.Replace("IV", "IIII");
        s = s.Replace("IX", "VIIII");
        s = s.Replace("XL", "XXXX");
        s = s.Replace("XC", "LXXXX");
        s = s.Replace("CD", "CCCC");
        s = s.Replace("CM", "DCCCC");

        int num = 0;
        foreach(char c in s)
        {
            num += dict[c];
        }

        return num;

    }
}