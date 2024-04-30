using System;
    // Analysis & Explanation:
    // The input "digits" represent an integer that has been spliced and inputted
    // into an integer array. I.E 2314 -> [2,3,1,4] and we are supposed to add one to
    // this array and return the sum.
    // This has 3 cases.  One of which is a bit more obscure.
    // The first case is simple, if the element at digits[len-1] is 0-8
    // Then we return the array with the last index being added to.
    // The second case is we have to carry over to the left by 1.  This is
    // When digits[len-1] contains a 9.  In this case we also have to account for 
    // A large continuation of 9's where we would keep iterating to the left.
    // Finally in the case of all 9's we would have to return a new array with 
    // a leading 1 and the rest of the index's of the array holding 0's.
    // I.E 9999 -> 10000 or [9,9,9,9] -> [1,0,0,0,0].
public class PlusOneProblem
{
    
    // Approach:
    // First establish the current index and a boolean "AddOne" to know that we 
    // have to keep iterating.  Use a While loop as the driving force of the 
    // iterative algorithm to keep decrementing the index.  
    // At each index do the assertion for the values of 0-8 or 9
    // when at 0-8, perform +1 and return immediately. 
    // For the 9 case, set the value to zero and decrement the index.
    // If the index is -1 then we are at the leftmost position and we reuturn a
    // new array with all zeros and a leading 1.
    // Time: O(n) (worse) | Space: O(n) (worse) O(1) (average)

    public static int[] PlusOne(int[] digits){

        int idx = digits.Length-1;
        bool addOne = true;

        while(addOne){

        int cur = digits[idx];

            if(cur < 9){
                digits[idx] = digits[idx] + 1;
                return digits;
            } 

            else{
                
                digits[idx] = 0;
                idx--;
                
                if(idx == -1){
                    int[] ans = new int[digits.Length+1];
                    Array.Clear(ans,0, ans.Length);
                    ans[0] = 1;
                    return ans;
                }
            }

        }

        return digits;

    }

    // Can We Do Better?
    // It's hard to say because the solution relies heavily on a straight-forward iteration
    // where we would need to check each index for a "9".
    // There can be a base case to reduce this if we check that the array only contains 9's
    // we could then return a new array of zeros and a leading one immediately.  However this 
    // would then put the responsibility of time complexity on a built in function to confirm
    // that there are only 9's in the array.  This would most likely lead to constant time anyways.
    // For space, to fix the worse case scenario would be hard in C# due to the limitation of 
    // Array sizes being fixed upon declaration.  Thus leading to creating a new Array in the 
    // Worse case.
}