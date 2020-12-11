// Unit tests in this file were inspired by examples provided within excercise content

using NUnit.Framework;

[TestFixture]
public class ExampleBasedUnitTests
{
    [Test]
    public void Test1()
    {
        var input = 42145;
        var output = 54421;

        Assert.AreEqual(output, Kata.DescendingOrder(input));
    }

    [Test]
    public void Test2()
    {
        var input = 145263;
        var output = 654321;

        Assert.AreEqual(output, Kata.DescendingOrder(input));
    }

    [Test]
    public void Test3()
    {
        var input = 123456789;
        var output = 987654321;

        Assert.AreEqual(output, Kata.DescendingOrder(input));
    }
}
