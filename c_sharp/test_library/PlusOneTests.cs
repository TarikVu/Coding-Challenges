
using Xunit;
using Xunit.Sdk;

public class PlusOneTests
{
    [Fact, Trait("Category","PlusOne")]
    public void Case1()
    { 
        int[] input = [1, 2];
        int[] expected = [1, 3];
        Assert.Equal(expected, PlusOneProblem.PlusOne(input));
    }
    
    [Fact, Trait("Category","PlusOne")]
    public void Case2()
    {
        int[] input = [1, 9];
        int[] expected = [2, 0];
        Assert.Equal(expected, PlusOneProblem.PlusOne(input));
    }

    [Fact, Trait("Category","PlusOne")]
    public void Case3()
    {
        int[] input = [9, 9];
        int[] expected = [1,0 , 0];
        Assert.Equal(expected, PlusOneProblem.PlusOne(input));
    }
}