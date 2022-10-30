namespace Codility.Lessons.Arrays;

public static class OddOccurrencesInArray
{
	public static int Solution(int[] a)
	{
		var nonPairs = new Dictionary<int, int>();
		foreach (var key in a)
			if (!nonPairs.ContainsKey(key))
				nonPairs[key] = 1;
			else
				nonPairs.Remove(key);

		return nonPairs.Keys.ToList().FirstOrDefault();
	}
}
