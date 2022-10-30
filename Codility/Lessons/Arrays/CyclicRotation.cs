namespace Codility.Lessons.Arrays;

public static class CyclicRotation
{
	public static int[] Solution(int[] a, int k)
	{
		// rotate a, k times
		var output = new int[a.Length];
		for (var index = 0; index < a.Length; ++index)
			output[(index + k) % a.Length] = a[index];
		return output;
	}
}
