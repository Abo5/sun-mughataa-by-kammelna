using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine;

public class MassPlayPeriodsInfoUI : MassWidget
{
	private Transform playPeriodsLayout;

	private PlayPeriodElement playPeriodElement;

	protected override void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I
		//IL_00eb: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0090: Expected I, but got O
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		GameObject go = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)3264;
		object varName = "alignContent" + 2944;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
	}

	private void RefreshStagePeriods()
	{
		//IL_0011: Expected O, but got I
		//IL_0038: Expected O, but got I
		//IL_01ba: Expected O, but got I
		//IL_01ca: Expected O, but got I
		//IL_01e0: Expected O, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_0208: Expected O, but got I4
		//IL_0218: Expected O, but got I
		//IL_006d: Expected O, but got I
		//IL_0083: Expected O, but got I
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I
		//IL_027a: Expected O, but got I
		//IL_028a: Expected O, but got I
		//IL_02a0: Expected O, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02c8: Expected O, but got I4
		//IL_02d8: Expected O, but got I
		//IL_0252: Expected O, but got I4
		//IL_0164: Expected O, but got I
		//IL_018d: Expected O, but got I4
		//IL_00f3: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_0119: Expected O, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0146: Expected O, but got I
		//IL_0300: Expected O, but got I
		//IL_0332: Expected O, but got I
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_0352: Expected O, but got I
		//IL_039b: Expected O, but got I4
		//IL_03ec: Expected O, but got I
		//IL_03ec: Expected O, but got I
		//IL_0426: Expected O, but got I4
		object obj = (nint)0 + (nint)3120;
		MassEventStageViewModel activeStage = _connector.GetActiveStage();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X22_v6+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X22_v6+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v5+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v5+10]");
			object obj5 = (nint)0 + (nint)309;
			object obj6 = obj5 & 1;
			bool flag = obj6 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v5+10]");
			object obj7 = 0;
			if (!flag)
			{
				goto IL_00be;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X22_v6+38]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v18+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v18+10]");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag2 = obj10 == null;
			object obj11 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v18+10]");
			object obj7 = 0;
			if (obj11 != null)
			{
				goto IL_00be;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 != null)
		{
			goto IL_00e3;
		}
		goto IL_0260;
		IL_0434:
		throw new NullReferenceException();
		IL_0314:
		List<object> <PlayWindows>k__BackingField = (List<object>)(object)activeStage.<PlayWindows>k__BackingField;
		object obj13 = (nint)0 + (nint)3736;
		object obj14 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj15 = (nint)0 + (nint)576;
		int num = 1;
		PlayPeriodElement playPeriodElement = default(PlayPeriodElement);
		object obj19;
		do
		{
			int num2 = num - 1;
			if (num2 < <PlayWindows>k__BackingField._size)
			{
				object obj16 = <PlayWindows>k__BackingField.get_Item(num2);
				object obj17 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v11+E4]");
				bool flag4 = (nint)0 == 0;
				object obj18 = !flag4;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
				int index = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v10 (System.Object)+10]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v10 (System.Object)+18]");
				playPeriodElement.Populate(index, (DateTime)num3, (DateTime)0);
				<PlayWindows>k__BackingField = (List<object>)(object)activeStage.<PlayWindows>k__BackingField;
				num++;
				bool flag5 = activeStage.<PlayWindows>k__BackingField == null;
				obj19 = !flag5;
				continue;
			}
			return;
		}
		while (obj19 != null);
		goto IL_0434;
		IL_0154:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v28+B8]");
		object except = 0;
		UIExtensions.DestroyAllChildren(playPeriodsLayout, (GameObject[])except);
		bool flag6 = activeStage == null;
		object obj20 = !flag6;
		if (obj20 != null)
		{
			goto IL_0314;
		}
		goto IL_0434;
		IL_00be:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v20+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00e3;
		}
		goto IL_0260;
		IL_0260:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X22_v6+38]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v13+10]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v13+10]");
		object obj23 = (nint)0 + (nint)309;
		object obj24 = obj23 & 1;
		bool flag7 = obj24 == null;
		object obj25 = !flag7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v13+10]");
		object obj26 = 0;
		if (obj25 != null)
		{
			goto IL_0154;
		}
		goto IL_02e6;
		IL_00e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X22_v6+38]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v24+10]");
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v24+10]");
		object obj28 = (nint)0 + (nint)309;
		object obj29 = obj28 & 1;
		bool flag8 = obj29 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v24+10]");
		obj26 = 0;
		if (!flag8)
		{
			goto IL_0154;
		}
		goto IL_02e6;
		IL_02e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v18+B8]");
		object except2 = 0;
		UIExtensions.DestroyAllChildren(playPeriodsLayout, (GameObject[])except2);
		goto IL_0314;
	}
}
