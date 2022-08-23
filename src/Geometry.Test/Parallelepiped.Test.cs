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

    [InlineData(2, 3, 4, 24)]
    [InlineData(3, 4, 5, 60)]
    [Theory]
    public void TestParallelepipedVolumeCalc
    (
        double height, 
        double width, 
        double depth,
        double expectedVolume
    )
    {
        var instance = new Parallelepiped(width, height, depth);
        instance.Volume.Should().Be(expectedVolume);
    }

        [InlineData(-1, 4, 2)]
    [Theory]
    public void TestParallelepipedNonPositiveSideException(double sideA, double sideB, double sideC)
    {
        Action act = () => new Parallelepiped(sideA, sideB, sideC);
        act.Should().Throw<ArgumentException>().WithMessage("All sides must be greater than zero");
    }
}