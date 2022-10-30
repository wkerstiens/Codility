using static Codility.Lessons.Iterations.BinaryGap;

namespace Codility.Tests.Lessons.Iterations;

public class BinaryGapUnitTests
{
	[Fact]
	public void BinaryGapShouldReturn0()
		=> Assert.Equal(0, Solution(32));

	[Fact]
	public void BinaryGapShouldReturn5()
		=> Assert.Equal(5, Solution(1041));

	[Fact]
	public void BinaryGapShouldReturn2()
		=> Assert.Equal(2, Solution(328));

	[Fact]
	public void BinaryGapShouldReturn3()
		=> Assert.Equal(3, Solution(1162));

	[Fact]
	public void BinaryGapShouldReturn9()
		=> Assert.Equal(5, Solution(1041));
}
