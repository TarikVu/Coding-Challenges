using Xunit;
using Xunit.Sdk;

public class RomanToIntTests
{
 
    [Fact, Trait("Category", "RomanToInt")]
    public void Case1()
    {
        string s = "III";
        Assert.Equal(3, RomanToIntProblem.RomanToInt(s));
    }

    [Fact, Trait("Category", "RomanToInt")]
    public void Case2()
    {
        string s = "LVIII";
        Assert.Equal(58, RomanToIntProblem.RomanToInt(s));
    }

    
    [Fact, Trait("Category", "RomanToInt")]
    public void Case3()
    {
        string s = "MCMXCIV";
        Assert.Equal(1994,RomanToIntProblem.RomanToInt(s));
    }

}