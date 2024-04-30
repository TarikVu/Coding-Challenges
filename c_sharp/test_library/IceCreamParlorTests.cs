using Xunit;
using Xunit.Sdk;


public class IcecreamParlorTests
{
    // Public Tests from source
    [Fact, Trait("Category", "IceCreamParlor")]
    public void Case1()
    {
        int m = 4;
        List<int> cost = new([1, 4, 5, 3, 2]);
        List<int> ans = new([1, 4]);
        Assert.Equal(ans, IceCreamParlorProblem.IcecreamParlor(m, cost));
    }

    [Fact, Trait("Category", "IceCreamParlor")]
    public void Case2()
    {
        int m = 4;
        List<int> cost = new([2, 2, 4, 3]);
        List<int> ans = new([1, 2]);
        Assert.Equal(ans, IceCreamParlorProblem.IcecreamParlor(m, cost));
    }
}