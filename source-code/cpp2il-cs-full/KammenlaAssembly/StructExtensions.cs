using System;
using System.Data;
using Cpp2ILInjected;

public static class StructExtensions
{
	public static bool IsDefault<T>(T value) where T : struct
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0087: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime = default(DateTime);
		object value2 = default(object);
		return dateTime.Equals(value2);
	}
}
