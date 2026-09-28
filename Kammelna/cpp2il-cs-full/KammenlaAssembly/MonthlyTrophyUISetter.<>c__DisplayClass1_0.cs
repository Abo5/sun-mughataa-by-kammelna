using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Mono.Btls;
using UnityEngine;
using UnityEngine.TextCore;

public class MonthlyTrophyUISetter : MonoBehaviour
{
	private sealed class <>c__DisplayClass1_0
	{
		public UserAchievementModel trophy;

		internal void <Populate>b__0(IMonthlyTrophyUISubSetter s)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_002b: Expected I, but got O
			//IL_003b: Expected O, but got I
			//IL_0122: Expected O, but got I
			//IL_0076: Expected O, but got I
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3896;
			UserAchievementModel userAchievementModel = trophy;
			nint num = (nint)s;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<IMonthlyTrophyUISubSetter>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<IMonthlyTrophyUISubSetter>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00b7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<IMonthlyTrophyUISubSetter>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00b7;
			}
			object obj4 = num + obj3;
			object obj5 = obj4 + 312;
			goto IL_010a;
			IL_00b7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_010a;
			IL_010a:
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v3+8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private List<IMonthlyTrophyUISubSetter> subsetters;

	public void Populate(UserAchievementModel trophy)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_008e: Expected O, but got I
		//IL_009f: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = trophy;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (((UserAchievementModel)obj3).IsCelebrationTrophy())
		{
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2336;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = (nint)0 + (nint)2120;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj5);
			((List<object>)(object)subsetters).ForEach(action);
		}
	}
}
