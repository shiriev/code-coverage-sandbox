using CodeCoverageSandbox;
using NUnit.Framework;

namespace CodeCoverageSandboc.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var obj = new BranchCoverageExample();
        obj.MultiBranch(3, 4);
        Assert.Pass();
    }
}