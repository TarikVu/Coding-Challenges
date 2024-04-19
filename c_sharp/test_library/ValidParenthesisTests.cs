using Xunit;


public class ValidParenthesisTests
{

    public ValidParenthesisProblem problem = new ValidParenthesisProblem();


    // Public Tests from source
    [Fact, Trait("Category", "ValidParenthesis")]
    public void testSmall()
    {
        string s = "()";
        Assert.True(problem.IsValid(s));
    }
    [Fact, Trait("Category", "ValidParenthesis")]
    public void testSmall2()
    {
        string s = "()[]{}";
        Assert.True(problem.IsValid(s));
    }

    [Fact, Trait("Category", "ValidParenthesis")]
    public void testSmallFalse()
    {
        string s = "(]";
        Assert.False(problem.IsValid(s));
    }

}