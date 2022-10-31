using Codility.Lessons.TimeComplexity;

namespace Codility.Tests.Lessons.TimeComplexity;

public class FrogJumpTest
{
	[Fact]
	public void FrogJumpShouldBeTrue()
	{
		Assert.Equal(3, FrogJump.Solution(10, 85, 30));
	}
}
