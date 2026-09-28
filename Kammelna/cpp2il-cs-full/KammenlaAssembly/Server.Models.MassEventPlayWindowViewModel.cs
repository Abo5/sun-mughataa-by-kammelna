using System;
using System.Data;
using Cpp2ILInjected;

namespace Server.Models;

[Serializable]
public class MassEventPlayWindowViewModel
{
	private DateTime <StartingTime>k__BackingField;

	private DateTime <FinishTime>k__BackingField;

	public DateTime StartingTime
	{
		get
		{
			return <StartingTime>k__BackingField;
		}
		set
		{
			<StartingTime>k__BackingField = value;
		}
	}

	public DateTime FinishTime
	{
		get
		{
			return <FinishTime>k__BackingField;
		}
		set
		{
			<FinishTime>k__BackingField = value;
		}
	}

	public bool IsTimeWithinWindow(DateTime dateTime)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0165: Expected O, but got I4
		//IL_00b6: Expected O, but got I4
		//IL_00f6: Expected O, but got I4
		//IL_01b3: Expected O, but got I4
		//IL_01bc: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7BC0]");
		object obj3 = (nint)0 & (nint)1;
		DateTime dateTime2;
		DateTime dateTime3;
		if (obj3 != null)
		{
			dateTime2 = <StartingTime>k__BackingField;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			dateTime3 = <StartingTime>k__BackingField;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			dateTime2 = <StartingTime>k__BackingField;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			dateTime3 = <StartingTime>k__BackingField;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = dateTime >= dateTime3;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		DateTime dateTime4 = dateTime3;
		if (obj6 != null)
		{
			goto IL_00cc;
		}
		goto IL_01d2;
		IL_00cc:
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return dateTime < <FinishTime>k__BackingField;
		IL_01d2:
		return flag3;
		IL_0091:
		flag3 = dateTime >= dateTime2;
		bool flag6 = !flag3;
		obj7 = 0;
		dateTime4 = dateTime2;
		if (!flag6)
		{
			goto IL_00cc;
		}
		goto IL_01d2;
	}
}
