using Cpp2ILInjected;

public static class Functions
{
	public static T Identity<T>(T value)
	{
		return value;
	}

	public static bool IsNull<T>(T value)
	{
		return value == null;
	}

	public static bool IsNotNull<T>(T value)
	{
		bool flag = value == null;
		return !flag;
	}

	public static T0 Default<T0>()
	{
		//IL_0010: Expected O, but got I
		//IL_0066: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X1+38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X1+38]");
		if ((nint)0 != 0)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
			T0 result = default(T0);
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X1+38]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
		T0 result2 = default(T0);
		return result2;
	}

	public static T0 Default<T1, T0>(T1 value)
	{
		//IL_0010: Expected O, but got I
		//IL_0066: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X2+38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X2+38]");
		if ((nint)0 != 0)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
			T0 result = default(T0);
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X2+38]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
		T0 result2 = default(T0);
		return result2;
	}
}
