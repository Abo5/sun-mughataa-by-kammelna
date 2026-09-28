using System;
using Cpp2ILInjected;

namespace Util;

public class EmptyNotificationPermissionChecker : INotificationPermissionChecker
{
	public bool IsGranted()
	{
		return true;
	}

	public void RequestPermission(Action<bool> onResult)
	{
		//IL_002d: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_004d: Expected O, but got I
		if (onResult != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [onResult @ X1 (System.Action`1<System.Boolean>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [onResult @ X1 (System.Action`1<System.Boolean>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [onResult @ X1 (System.Action`1<System.Boolean>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X3_v1 (should have been resolved before IL gen)");
		}
	}
}
