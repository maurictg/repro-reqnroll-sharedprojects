namespace App.UiTests.Shared.UnitTests;

[TestFixture]
public class SumTest
{
    [Test]
    public void OneAndOneIsTwo()
    {
        var a = 1;
        var b = 1;
        Assert.That(a + b, Is.EqualTo(2));
    }
}