using System;
using System.IO;

public static class ExceptionsExtensions
{
	public static bool IsDiskFull(IOException ex)
	{
		//IL_00ba: Expected I4, but got O
		//IL_0034: Expected O, but got I8
		//IL_0056: Expected O, but got I8
		//IL_0061: Expected O, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		if (ex != null)
		{
			object obj = ((Exception)ex)._HResult - 2147942439L;
			bool flag = obj == null;
			object obj2 = 2147942439L + 73;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				object obj5 = ((Exception)ex)._HResult - obj2;
				return obj5 == null;
			}
			return true;
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}
}
