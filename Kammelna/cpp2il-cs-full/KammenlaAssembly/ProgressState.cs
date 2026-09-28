public struct ProgressState
{
	public readonly float Normalized;

	public readonly int Current;

	public readonly int Max;

	public readonly bool IsComplete;

	public ProgressState(float normalized, int current, int max)
	{
		//IL_002b: Expected O, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
		Normalized = normalized;
		Current = current;
		Max = max;
		object obj = current - max;
		bool flag = (nint)obj < 0;
		int num = current ^ max;
		int num2 = current ^ obj;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		bool isComplete = flag == flag2;
		IsComplete = isComplete;
	}
}
