using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class MainMenuFTInfoPanel : FastTrackInfoPanel
{
	public TextMeshProUGUI LevelText;

	public Sprite menuFirstCompletedStage;

	public Sprite menuFirstFutureStage;

	private void InitMainMenuItems()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object obj = "SERVICE_DISABLED" + 2392;
		object obj2 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 384;
		TextMeshProExtensions.Localize(text: (string)((FTLevel != 2) ? obj2 : obj), textMesh: LevelText);
	}

	protected override void InitFT()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		base.InitFT();
		object obj = "SERVICE_DISABLED" + 2392;
		object obj2 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 384;
		TextMeshProExtensions.Localize(text: (string)((FTLevel != 2) ? obj2 : obj), textMesh: LevelText);
	}

	protected override void InitLevelRanks()
	{
		//IL_003a: Expected O, but got I
		//IL_0092: Expected O, but got I4
		base.InitLevelRanks();
		List<object> list = (List<object>)(object)levelRanks;
		int num = 0;
		int num2 = default(int);
		while (num < list._size)
		{
			object obj = list.get_Item(num);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v8 (System.Object)+70]");
			object obj2 = 0;
			num++;
			string text = num2.ToString();
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v107 @ X8_v7+558] (should have been resolved before IL gen)");
			list = (List<object>)(object)levelRanks;
			bool flag = levelRanks == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				throw new NullReferenceException();
			}
		}
	}

	protected unsafe override void InitCurrentStage()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		base.InitCurrentStage();
		int num = this + 136;
		string text = ((int*)num)->ToString();
		TextMeshProExtensions.FixArabic(stageText, text);
	}

	protected override void InitHearts()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_016c: Expected O, but got I4
		//IL_0175: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		//IL_0087: Expected O, but got I4
		//IL_00ab: Expected O, but got I
		//IL_01ac: Expected O, but got I
		//IL_01c6: Expected O, but got I4
		//IL_020c: Expected O, but got I4
		//IL_0115: Expected O, but got I
		//IL_0125: Expected O, but got I
		//IL_024c: Expected O, but got I
		//IL_026e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A05]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj5;
		if (obj3 != null)
		{
			base.InitHearts();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = 0;
			if (!flag)
			{
				goto IL_0095;
			}
		}
		else
		{
			_ = 1;
			base.InitHearts();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = 0;
			obj6 = 0;
			if (obj7 != null)
			{
				goto IL_0095;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
		object obj8 = (nint)0 & (nint)1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		obj5 = obj6;
		if (obj9 != null)
		{
			goto IL_00d0;
		}
		goto IL_01dc;
		IL_0105:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v17+8]");
		object obj11 = 0;
		goto IL_012a;
		IL_012a:
		_ = 1;
		return;
		IL_022a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v5+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+8]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_012a;
		IL_0095:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
		object obj15 = (nint)0 & (nint)1;
		bool flag5 = obj15 == null;
		obj6 = obj5;
		if (!flag5)
		{
			goto IL_00d0;
		}
		goto IL_01dc;
		IL_01dc:
		_ = 1;
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		object obj18 = obj16;
		obj5 = obj6;
		if (obj17 != null)
		{
			goto IL_0105;
		}
		goto IL_022a;
		IL_00d0:
		obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+E4]");
		bool flag7 = (nint)0 == 0;
		obj18 = obj16;
		if (!flag7)
		{
			goto IL_0105;
		}
		goto IL_022a;
	}

	protected override void InitProgressBreadCrumps()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_016c: Expected O, but got I4
		//IL_0175: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		//IL_0087: Expected O, but got I4
		//IL_00ab: Expected O, but got I
		//IL_01ac: Expected O, but got I
		//IL_01c6: Expected O, but got I4
		//IL_020c: Expected O, but got I4
		//IL_0115: Expected O, but got I
		//IL_0125: Expected O, but got I
		//IL_024c: Expected O, but got I
		//IL_026e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A06]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj5;
		if (obj3 != null)
		{
			base.InitProgressBreadCrumps();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = 0;
			if (!flag)
			{
				goto IL_0095;
			}
		}
		else
		{
			_ = 1;
			base.InitProgressBreadCrumps();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = 0;
			obj6 = 0;
			if (obj7 != null)
			{
				goto IL_0095;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
		object obj8 = (nint)0 & (nint)1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		obj5 = obj6;
		if (obj9 != null)
		{
			goto IL_00d0;
		}
		goto IL_01dc;
		IL_0105:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v17+8]");
		object obj11 = 0;
		goto IL_012a;
		IL_012a:
		_ = 1;
		return;
		IL_022a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v5+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+8]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_012a;
		IL_0095:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
		object obj15 = (nint)0 & (nint)1;
		bool flag5 = obj15 == null;
		obj6 = obj5;
		if (!flag5)
		{
			goto IL_00d0;
		}
		goto IL_01dc;
		IL_01dc:
		_ = 1;
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		object obj18 = obj16;
		obj5 = obj6;
		if (obj17 != null)
		{
			goto IL_0105;
		}
		goto IL_022a;
		IL_00d0:
		obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+E4]");
		bool flag7 = (nint)0 == 0;
		obj18 = obj16;
		if (!flag7)
		{
			goto IL_0105;
		}
		goto IL_022a;
	}
}
