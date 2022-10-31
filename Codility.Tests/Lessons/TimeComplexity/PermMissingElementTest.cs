using Codility.Lessons.TimeComplexity;

namespace Codility.Tests.Lessons.TimeComplexity;

public class PermMissingElementTest
{
	[Fact]
	public void FrogJumpShouldBeTrue()
	{
		Assert.Equal(4, PermMissingElement.Solution(new int[] {1, 2, 3, 5}));
	}
}
