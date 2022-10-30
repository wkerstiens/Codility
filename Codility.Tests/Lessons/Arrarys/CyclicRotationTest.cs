using Codility.Lessons.Arrays;

namespace Codility.Tests.Lessons.Arrays;

public class CyclicRotationTest
{
	[Fact]
	public void RotationTestShouldBeTrue()
	{
		var input = new[] { 3, 8, 9, 7, 6 };
		var output = new[] { 9, 7, 6, 3, 8 };

		Assert.Equal(output, CyclicRotation.Solution(input, 3));
	}
}
