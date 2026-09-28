using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Features.GameReplay;
using UnityEngine;

namespace UI.Conditions;

[Serializable]
public class GameReplaySavedCondition : BoolCondition
{
	protected override bool ActualValue
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0132: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_01b8: Expected O, but got I4
			//IL_0160: Expected O, but got I
			//IL_017a: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_01f0: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7DF8]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v10+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E4]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_0188;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v16+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v12+40]");
			return false;
			IL_01ce:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v3+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v3+40]");
			return false;
			IL_00b0:
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = obj11;
			if (!flag3)
			{
				goto IL_00e5;
			}
			goto IL_01ce;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E4]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 != null)
			{
				goto IL_00b0;
			}
			goto IL_0188;
			IL_0188:
			_ = 1;
			obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v16+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			obj12 = obj11;
			if (obj14 != null)
			{
				goto IL_00e5;
			}
			goto IL_01ce;
		}
	}

	public override void Setup(GameObject gm)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)560;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GameReplayManager.OnGameSaved += action;
	}

	public GameReplaySavedCondition()
	{
		isActive = true;
		((object)this)..ctor();
	}
}
