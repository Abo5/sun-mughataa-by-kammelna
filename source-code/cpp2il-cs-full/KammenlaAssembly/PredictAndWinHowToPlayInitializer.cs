using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class PredictAndWinHowToPlayInitializer : MonoBehaviour
{
	private TabsUI tabs;

	private Image section;

	private PredictAndWinEventsChannel predictAndWinEventsChannel;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		predictAndWinEventsChannel.ShowHowToPlay += action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		predictAndWinEventsChannel.ShowHowToPlay -= action;
	}

	public void ShowHowToPlay()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01ad: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_024c: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_0163: Expected O, but got I
		//IL_02b1: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E647F]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			obj5 = tabs;
			obj6 = tabs;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = tabs;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = tabs;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		int num = 0;
		if (flag4)
		{
			goto IL_00cb;
		}
		goto IL_0203;
		IL_013a:
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor(section, (Color)0, 1f);
		object obj8 = (nint)0 + (nint)3024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30593E4");
		return;
		IL_0114:
		UnityEngine.Object obj9;
		if ((bool)obj9)
		{
			goto IL_013a;
		}
		return;
		IL_027f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj10;
		bool flag5 = obj10;
		bool flag6 = !flag5;
		object obj11 = !flag6;
		bool flag8;
		bool flag7 = flag8;
		if (obj11 == null)
		{
			return;
		}
		goto IL_013a;
		IL_0091:
		bool flag9 = obj5;
		bool flag10 = !flag9;
		object obj12 = !flag10;
		num = 0;
		if (obj12 == null)
		{
			goto IL_00cb;
		}
		goto IL_0203;
		IL_0203:
		tabs.Activate(0);
		obj9 = section;
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v2+E4]");
		bool flag11 = (nint)0 == 0;
		object obj14 = !flag11;
		flag7 = true;
		flag8 = true;
		num = 0;
		obj10 = section;
		if (obj14 != null)
		{
			goto IL_0114;
		}
		goto IL_027f;
		IL_00cb:
		obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v2+E4]");
		bool flag12 = (nint)0 == 0;
		obj9 = section;
		flag8 = flag7;
		obj10 = section;
		if (!flag12)
		{
			goto IL_0114;
		}
		goto IL_027f;
	}
}
