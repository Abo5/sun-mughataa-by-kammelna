using System;
using System.Collections.Generic;
using System.Data;
using Cpp2ILInjected;
using Util;

public class JackarooCustomRulesSave
{
	private long <CreationTime>k__BackingField;

	private string <Name>k__BackingField;

	private List<JackarooCustomRuleSaveData> <IndicesAndRules>k__BackingField;

	public long CreationTime
	{
		get
		{
			return <CreationTime>k__BackingField;
		}
		set
		{
			<CreationTime>k__BackingField = value;
		}
	}

	public string Name
	{
		get
		{
			return <Name>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<JackarooCustomRuleSaveData> IndicesAndRules
	{
		get
		{
			return <IndicesAndRules>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public JackarooCustomRulesSave()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_013e: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0196: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7787]");
		object obj3;
		object obj5;
		if ((object)((nint)0 & (nint)1) != null)
		{
			obj3 = typeof(DataRelation) + 824;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(DataRelation) + 824;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime dateTime = DateTime.Now;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		DateTime dateTime2 = dateTime;
		if (obj8 != null)
		{
			goto IL_00d7;
		}
		goto IL_01ac;
		IL_00d7:
		<CreationTime>k__BackingField = DateTimeUtil.ToEpochMilli(dateTime);
		base..ctor();
		return;
		IL_01ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		dateTime = dateTime2;
		goto IL_00d7;
		IL_0099:
		dateTime = DateTime.Now;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v2+E4]");
		bool flag4 = (nint)0 == 0;
		dateTime2 = dateTime;
		if (!flag4)
		{
			goto IL_00d7;
		}
		goto IL_01ac;
	}

	public JackarooCustomRulesSave(string name, List<JackarooCustomRuleSaveData> indicesAndRules)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_017d: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_01d5: Expected O, but got I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7788]");
		object obj3;
		object obj5;
		if ((object)((nint)0 & (nint)1) != null)
		{
			obj3 = typeof(DataRelation) + 824;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(DataRelation) + 824;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime dateTime = DateTime.Now;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		DateTime dateTime2 = dateTime;
		if (obj8 != null)
		{
			goto IL_00d7;
		}
		goto IL_01eb;
		IL_00d7:
		<CreationTime>k__BackingField = DateTimeUtil.ToEpochMilli(dateTime);
		base..ctor();
		object obj9 = this + 24;
		obj9 = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = this + 32;
		obj10 = indicesAndRules;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_01eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		dateTime = dateTime2;
		goto IL_00d7;
		IL_0099:
		dateTime = DateTime.Now;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v2+E4]");
		bool flag4 = (nint)0 == 0;
		dateTime2 = dateTime;
		if (!flag4)
		{
			goto IL_00d7;
		}
		goto IL_01eb;
	}
}
