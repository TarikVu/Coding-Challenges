using Xunit;


public class TwoSumTests
{
    public TwoSumProblem problem = new TwoSumProblem();

    // Public Tests from source
    [Fact, Trait("Category", "TwoSum")]
    public void Case1()
    {
        int[] nums = [2,7,11,15];
        int target = 9;
        int[] ans = [0,1];
        Assert.Equal(ans, problem.TwoSum(nums,target));
    }

    // Public Tests from source
    [Fact, Trait("Category", "TwoSum")]
    public void Case2()
    {
        int[] nums = [3,2,4];
        int target = 6;
        int[] ans = [1,2];
        Assert.Equal(ans, problem.TwoSum(nums,target));
    }

    // Public Tests from source
    [Fact, Trait("Category", "TwoSum")]
    public void Case3()
    {
        int[] nums = [3,3];
        int target = 6;
        int[] ans = [0,1];
        Assert.Equal(ans, problem.TwoSum(nums,target));
    }

}