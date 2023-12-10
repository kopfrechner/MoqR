using FluentAssertions;

namespace MoqR.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        true.Should().BeTrue();
    }
}