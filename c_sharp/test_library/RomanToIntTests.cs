using Xunit;
using Xunit.Sdk;

public class RomanToIntTests
{

    RomanToIntProblem problem = new RomanToIntProblem();
    [Fact, Trait("Category", "RomanToInt")]
    public void Case1()
    {
        string s = "III";
        Assert.Equal(3, problem.RomanToInt(s));
    }
    [Fact, Trait("Category", "RomanToInt")]
    public void Case2()
    {
        string s = "LVIII";
        Assert.Equal(58, problem.RomanToInt(s));
    }

    
    [Fact, Trait("Category", "RomanToInt")]
    public void Case3()
    {
        string s = "MCMXCIV";
        Assert.Equal(1994,problem.RomanToInt(s));
    }

}