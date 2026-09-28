using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;

public static class BalootProjectMethods
{
	public static int OrderingValue(BalootProject project)
	{
		//IL_001a: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0037: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00da: Expected O, but got I
		//IL_00f7: Expected I4, but got O
		bool flag = project < (BalootProject)4;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = 119877632 + 1696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X8_v2+project @ X0 (BalootProject)*4]");
			return 0;
		}
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = "placementId" + 1224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj6 = (nint)0 + (nint)2352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (int)ex2;
	}

	public static string ServerStringValue(BalootProject project)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		return EnumExtensions.GetFriendlyName(enumeration);
	}

	public static int ServerValue(BalootProject project)
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
		bool flag = project < (BalootProject)4;
		object obj = !flag;
		if (obj == null)
		{
			return (int)(3 - project);
		}
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = "placementId" + 1224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj5 = (nint)0 + (nint)2368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (int)ex2;
	}

	public static BalootProject FromServerValue(int value)
	{
		//IL_001a: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00da: Expected I4, but got O
		bool flag = value < 4;
		object obj = !flag;
		if (obj == null)
		{
			return (BalootProject)(3 - value);
		}
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = "utf-32" + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj5 = (nint)0 + (nint)2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (BalootProject)ex2;
	}

	public unsafe static KeyValuePair<BalootProject, ProjectConditions> Requires(BalootProject project, ProjectConditions conditions)
	{
		//IL_000e: Expected O, but got I4
		//IL_0026: Expected native int or pointer, but got O
		KeyValuePair<BalootProject, ProjectConditions> keyValuePair = (KeyValuePair<BalootProject, ProjectConditions>)0;
		_ = 0;
		_ = 0;
		*(KeyValuePair<System.Int32Enum, ProjectConditions>*)(nint)keyValuePair = new KeyValuePair<System.Int32Enum, ProjectConditions>((System.Int32Enum)project, conditions);
		return keyValuePair;
	}
}
