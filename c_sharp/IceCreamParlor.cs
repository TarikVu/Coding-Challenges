using System;

public class IceCreamParlorProblem
{
   public static List<int> IcecreamParlor(int m, List<int> arr)
    {
        int l = 0;
        int r = 1; 
        List<int> ans = [];
        while (r<arr.Count){
                
                if (arr[l]+arr[r] == m){
                    ans.Add(l+1);
                    ans.Add(r+1);
                    break;
                }
                
                if (l == r-1){
                    r++;
                    l = 0;
                    continue;
                }
                
                l++; 
        }
        return ans;
    }
}