using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine.UI;

public static class ToggleGroupExtensions
{
	public static int GetSelectedIndex(ToggleGroup group)
	{
		//IL_00f2: Expected I4, but got O
		//IL_0011: Expected O, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00e4: Expected I4, but got I8
		ToggleGroup toggleGroup = default(ToggleGroup);
		if ((object)toggleGroup != null)
		{
			object obj = (nint)0 + (nint)1200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
			object obj2 = default(object);
			if (obj2 == null)
			{
				object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj6 = "Network Authentication Required" + 3488;
				KLogger.LogError(obj6);
				return -1;
			}
			ToggleGroupIndexer toggleGroupIndexer = default(ToggleGroupIndexer);
			if ((object)toggleGroupIndexer != null)
			{
				return toggleGroupIndexer.SelectedIndex;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static void SetSelectedIndex(ToggleGroup group, int index)
	{
		//IL_0011: Expected O, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00a4: Expected O, but got I4
		object obj = (nint)0 + (nint)1200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj2 = default(object);
		if (obj2 != null)
		{
			ToggleGroupIndexer toggleGroupIndexer = default(ToggleGroupIndexer);
			toggleGroupIndexer.SelectedIndex = index;
			return;
		}
		object format = "Network Authentication Required" + 3824;
		string text = string.Format((string)format, group);
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		object obj6 = text;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = text;
		}
		KLogger.LogError(obj6);
	}

	public static void DisableToggles(ToggleGroup group)
	{
		//IL_0011: Expected O, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj2 = default(object);
		if (obj2 != null)
		{
			ToggleGroupIndexer toggleGroupIndexer = default(ToggleGroupIndexer);
			toggleGroupIndexer.DisableToggles();
			return;
		}
		object format = "Network Authentication Required" + 3824;
		string obj3 = string.Format((string)format, group);
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			KLogger.LogError(obj3);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KLogger.LogError(obj3);
	}
}
