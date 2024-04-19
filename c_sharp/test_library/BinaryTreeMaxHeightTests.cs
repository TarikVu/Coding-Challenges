using Xunit;

public class BinaryTreeMaxHeightTests
{
    public BinaryTreeMaxHeightProblem problem = new BinaryTreeMaxHeightProblem();

    [Fact, Trait("Category", "BinaryTreeMaxHeight")]
    public void testTree1()
    {
        TreeNode t = new TreeNode(3,null!,null!);

        Assert.Equal(1,problem.MaxDepth(t));
    }

    [Fact, Trait("Category", "BinaryTreeMaxHeight")]
    public void testEmpty()
    {
        TreeNode t = null!;
        Assert.Equal(0,problem.MaxDepth(t!));
    }


}