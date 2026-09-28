using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;

[Serializable]
public class LabelTextBehaviour : ProgressBehaviour, ITextReceiver
{
	private TextMeshProUGUI label;

	public override string EditorLabel
	{
		get
		{
			//IL_0016: Expected O, but got I
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_016e: Expected O, but got I
			//IL_0188: Expected O, but got I4
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_0067: Expected O, but got I
			//IL_01d8: Expected O, but got I4
			//IL_022c: Expected O, but got I4
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Expected O, but got Unknown
			//IL_0276: Unknown result type (might be due to invalid IL or missing references)
			//IL_027b: Expected O, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B85]");
			object obj = (nint)0 & (nint)1;
			TextMeshProUGUI textMeshProUGUI;
			object obj2;
			object obj4;
			TextMeshProUGUI textMeshProUGUI2;
			if (obj != null)
			{
				textMeshProUGUI = label;
				obj2 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B8B]");
				object obj3 = (nint)0 & (nint)1;
				bool flag = obj3 == null;
				obj4 = obj2;
				textMeshProUGUI2 = label;
				if (!flag)
				{
					goto IL_0096;
				}
			}
			else
			{
				_ = 1;
				textMeshProUGUI = label;
				obj2 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B8B]");
				object obj5 = (nint)0 & (nint)1;
				bool flag2 = obj5 == null;
				object obj6 = !flag2;
				obj4 = obj2;
				textMeshProUGUI2 = label;
				if (obj6 != null)
				{
					goto IL_0096;
				}
			}
			_ = 1;
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			UnityEngine.Object obj9 = textMeshProUGUI2;
			UnityEngine.Object obj10 = textMeshProUGUI2;
			if (obj8 != null)
			{
				goto IL_00d3;
			}
			goto IL_01f6;
			IL_026c:
			object obj11 = "LAK" + 400;
			string text;
			return (string)obj11 + text;
			IL_00fd:
			if ((object)obj9 != null)
			{
				string name = obj9.name;
				text = name;
				goto IL_026c;
			}
			return (string)(object)new NullReferenceException();
			IL_0242:
			object obj12 = "Network Authentication Required" + 1600;
			text = (string)obj12;
			goto IL_026c;
			IL_0096:
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v5+E4]");
			bool flag4 = (nint)0 == 0;
			obj9 = textMeshProUGUI;
			obj10 = textMeshProUGUI;
			if (!flag4)
			{
				goto IL_00d3;
			}
			goto IL_01f6;
			IL_01f6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = obj10;
			bool flag6 = !flag5;
			object obj13 = !flag6;
			obj9 = obj10;
			if (obj13 != null)
			{
				goto IL_00fd;
			}
			goto IL_0242;
			IL_00d3:
			if ((bool)obj9)
			{
				goto IL_00fd;
			}
			goto IL_0242;
		}
	}

	public override void SetImmediate([In] ref ProgressState state)
	{
	}

	public override void AnimateFromZero([In] ref ProgressState state, float duration, Ease ease)
	{
	}

	public override void AnimateFromCurrent([In] ref ProgressState state, float duration, Ease ease)
	{
	}

	public void SetText(string text)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B18]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = label;
			obj6 = label;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = label;
			obj6 = label;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		TextMeshProExtensions.FixArabic(label, text);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}
}
