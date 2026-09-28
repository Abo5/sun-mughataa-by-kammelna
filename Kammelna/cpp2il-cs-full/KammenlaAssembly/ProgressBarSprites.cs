using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

public class ProgressBarSprites : ScriptableObject
{
	private Sprite GreenFill;

	private Sprite YellowFill;

	private Sprite RedFill;

	private Sprite WhiteFill;

	private Sprite seats;

	public unsafe Sprite GetFill(ProgressBar.ColorStyle style)
	{
		//IL_0098: Expected O, but got Ref
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I4
		if (style <= ProgressBar.ColorStyle.Yellow)
		{
			if (style == ProgressBar.ColorStyle.Green)
			{
				goto IL_012c;
			}
			if (style == ProgressBar.ColorStyle.Yellow)
			{
				return YellowFill;
			}
		}
		else
		{
			switch (style)
			{
			case ProgressBar.ColorStyle.White:
				return WhiteFill;
			case ProgressBar.ColorStyle.Red:
				return RedFill;
			}
		}
		object obj = default(object);
		string text = ((Enum)(&obj)).ToString();
		object obj2 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 120;
		string text2 = (string)obj2 + text;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		object obj6 = text2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = text2;
		}
		KLogger.LogError(obj6);
		goto IL_012c;
		IL_012c:
		return GreenFill;
	}

	public unsafe Sprite GetIcon(ProgressBar.IconType icon)
	{
		//IL_0016: Expected O, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ab: Expected O, but got Ref
		//IL_00ef: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AFC]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			if (icon == ProgressBar.IconType.Seats)
			{
				goto IL_0053;
			}
		}
		else
		{
			_ = 1;
			if (icon == ProgressBar.IconType.Seats)
			{
				goto IL_0053;
			}
		}
		object obj2 = "Index = {0} position = {1}" + 3472;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj4 = default(object);
		string text = ((Enum)(&obj4)).ToString();
		string text2 = (string)obj2 + text;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		object obj7 = text2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = text2;
		}
		KLogger.LogError(obj7);
		return seats;
		IL_0053:
		return seats;
	}
}
