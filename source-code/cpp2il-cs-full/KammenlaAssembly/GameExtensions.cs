using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;

public static class GameExtensions
{
	public static bool SupportsCheating(Games game)
	{
		//IL_001a: Expected O, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I
		//IL_00ee: Expected I4, but got O
		bool flag = game < (Games)3;
		object obj = !flag;
		if (obj == null)
		{
			return (byte)(1 >> (int)game) != 0;
		}
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = "fetch_products" + 2352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj5 = (nint)0 + (nint)488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (byte)(int)ex2 != 0;
	}
}
