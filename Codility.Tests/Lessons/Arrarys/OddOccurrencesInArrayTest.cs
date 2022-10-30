using Codility.Lessons.Arrays;

namespace Codility.Tests.Lessons.Arrays;

public class OddOccurrencesInArrayTest
{
	[Fact]
	public void OddOccurrencesShouldTrue()
	{
		var input = new[] { 9, 3, 9, 3, 9, 7, 9 };
		var output = 7;

		Assert.Equal(output, OddOccurrencesInArray.Solution(input));
	}
}
