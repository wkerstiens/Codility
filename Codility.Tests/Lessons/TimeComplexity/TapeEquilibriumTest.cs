using System.Net.Sockets;
using Codility.Lessons.TimeComplexity;

namespace Codility.Tests.Lessons.TimeComplexity;

public class TapeEquilibriumTest
{
	[Fact]
	public void TestSolution()
	{
		var testCases = new
						{
							Questions = new List<int[]>(),
							Answers = new List<int>()
						};
		testCases.Questions.Add(new[] { 3, 1, 2, 4, 3 });
		testCases.Questions.Add(new[] { -3, 1, 2, -4, 3 });
		testCases.Questions.Add(new[] { 5, 2, 7, 10 });
		testCases.Questions.Add(new[] { -1000, 1000, -500, 990 });
		testCases.Questions.Add(new[] { 1, 2 });
		testCases.Questions.Add(new[] { 100, -25 });
		testCases.Questions.Add(new[] { -1000, 1000 });

		testCases.Answers.Add(1);
		testCases.Answers.Add(1);
		testCases.Answers.Add(4);
		testCases.Answers.Add(490);
		testCases.Answers.Add(1);
		testCases.Answers.Add(125);
		testCases.Answers.Add(2000);

		for (var index = 0; index < testCases.Questions.Count; ++index)
			Assert.Equal(testCases.Answers[index], TapeEquilibrium.Solution(testCases.Questions[index]));
	}
}
