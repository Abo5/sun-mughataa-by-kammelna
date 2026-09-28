public static class DirectionExtensions
{
	public static bool IsHorizontal(GestureDirection direction)
	{
		//IL_001a: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		bool flag = direction < GestureDirection.Up;
		object obj = !flag;
		return (byte)(int)(~obj) != 0;
	}

	public static bool IsVertical(GestureDirection direction)
	{
		//IL_0012: Expected O, but got I8
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		object obj = (long)direction & 0xFFFFFFFEL;
		object obj2 = obj - 2;
		return obj2 == null;
	}
}
