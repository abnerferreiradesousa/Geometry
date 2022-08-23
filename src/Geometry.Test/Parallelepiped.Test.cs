namespace Geometry.Test;

public class ParallelepipedTest
{
    [InlineData(2, 3, 4)]
    [InlineData(3, 4, 5)]
    [Theory]
    public void TestParallelepiped(double height, double width, double depth)
    {
        var instance = new Parallelepiped(width, height, depth);
        instance.Depth.Should().Be(depth);
        instance.Width.Should().Be(width);
        instance.Height.Should().Be(height);
    }
}