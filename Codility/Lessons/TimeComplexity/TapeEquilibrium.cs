namespace Codility.Lessons.TimeComplexity;

public static class TapeEquilibrium
{
	public static int Solution(int[] a)
	{
		var sumOfArray = a.Sum();
		var minDiff = int.MaxValue;
		var leftSide = 0;

		foreach (var element in a.Take(a.Length - 1))
		{
			leftSide += element;
			minDiff = Math.Min(Math.Abs(leftSide - (sumOfArray - leftSide)), minDiff);
		}

		return minDiff;
	}
}
