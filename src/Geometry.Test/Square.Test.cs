namespace Geometry.Test;

public class SquareTest
{
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [Theory]
    public void TestSquare(double side)
    {
        var instance = new Square(side);
        instance.Width.Should().Be(side);
        instance.Height.Should().Be(side);
        // instance.Area.Should().Be(expectedArea);
        // instance.Perimeter.Should().Be(expectedPerimeter);
    }
}