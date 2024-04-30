using System;

public class PlusOneProblem{

    public int[] PlusOne(int[] digits){

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
}