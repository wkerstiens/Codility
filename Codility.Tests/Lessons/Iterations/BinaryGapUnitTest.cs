using Codility.Lessons.Iterations;

namespace Codility.Tests;

public class BinaryGapUnitTests
{
	[Fact]
	public void BinaryGapShouldReturn0()
	{
		Assert.Equal(BinaryGap.Solution(32), 0);
	}
}
