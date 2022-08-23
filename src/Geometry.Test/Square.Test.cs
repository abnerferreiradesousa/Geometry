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
    }

    [InlineData(2, 4, 8)]
    [InlineData(3, 9, 12)]
    [InlineData(4, 16, 16)]
    [Theory]
    public void TestSquareCalcAreaAndPerimeter(double side, double expectedArea, double expectedPerimeter)
    {
        var instance = new Square(side);
        instance.Width.Should().Be(side);
        instance.Height.Should().Be(side);
        instance.Area.Should().Be(expectedArea);
        instance.Perimeter.Should().Be(expectedPerimeter);
    }
}