using System;

/* 
Source: https://www.hackerrank.com/challenges/icecream-parlor/problem?isFullScreen=true
Two friends like to pool their money and go to the ice cream parlor. They always choose two distinct flavors and they spend all of their money.
Given a list of prices for the flavors of ice cream, select the two that will cost all of the money they have.
 
 */
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