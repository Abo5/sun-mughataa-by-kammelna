using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class ClanLevelProgress : MonoBehaviour
{
	private Image indicator;

	private RectTransform icon;

	private float bounceScale;

	private float bounceDuration;

	private bool <IsAchieved>k__BackingField;

	public bool IsAchieved
	{
		get
		{
			return <IsAchieved>k__BackingField;
		}
		private set
		{
			<IsAchieved>k__BackingField = value;
		}
	}

	public void ResetProgress()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01e9: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_028d: Expected O, but got I4
		//IL_02a0: Expected O, but got I4
		//IL_010d: Expected I4, but got O
		//IL_023c: Expected O, but got I4
		//IL_02f4: Expected O, but got I4
		//IL_0186: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8668]");
		object obj3 = (nint)0 & (nint)1;
		Object obj5;
		Object obj6;
		if (obj3 != null)
		{
			<IsAchieved>k__BackingField = false;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			obj5 = icon;
			obj6 = icon;
			if (!flag)
			{
				goto IL_009c;
			}
		}
		else
		{
			_ = 1;
			<IsAchieved>k__BackingField = false;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = icon;
			obj6 = icon;
			if (obj7 != null)
			{
				goto IL_009c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = 0;
		Object obj9 = null;
		if (flag4)
		{
			goto IL_00dc;
		}
		goto IL_024f;
		IL_014c:
		int num = ShortcutExtensions.DOKill(indicator);
		Color color = indicator.color;
		indicator.color = (Color)0;
		GameObject gameObject = indicator.gameObject;
		gameObject.SetActive(value: false);
		return;
		IL_0125:
		Object obj10;
		if (obj10 != null)
		{
			goto IL_014c;
		}
		return;
		IL_02c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Object obj11;
		bool flag5 = obj11 != null;
		bool flag6 = !flag5;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			return;
		}
		goto IL_014c;
		IL_009c:
		bool flag7 = obj5 != null;
		bool flag8 = !flag7;
		object obj13 = !flag8;
		obj8 = 0;
		obj9 = null;
		if (obj13 == null)
		{
			goto IL_00dc;
		}
		goto IL_024f;
		IL_024f:
		int num2 = ShortcutExtensions.DOKill(icon);
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v2+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		obj10 = indicator;
		obj8 = 0;
		bool flag10 = false;
		obj11 = indicator;
		if (obj15 != null)
		{
			goto IL_0125;
		}
		goto IL_02c1;
		IL_00dc:
		obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v2+E4]");
		bool flag11 = (nint)0 == 0;
		obj10 = indicator;
		flag10 = (byte)(int)obj9 != 0;
		obj11 = indicator;
		if (!flag11)
		{
			goto IL_0125;
		}
		goto IL_02c1;
	}

	public void SetAchieved()
	{
		if (!<IsAchieved>k__BackingField)
		{
			<IsAchieved>k__BackingField = true;
			GameObject gameObject = indicator.gameObject;
			gameObject.SetActive(value: true);
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(indicator, 1f, 0.5f);
			BounceIcon();
		}
	}

	private void BounceIcon()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_018c: Expected O, but got I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		//IL_0215: Expected O, but got I4
		//IL_022a: Expected O, but got I
		//IL_025e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8669]");
		object obj3 = (nint)0 & (nint)1;
		Object obj5;
		Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v24+E4]");
			bool flag = (nint)0 == 0;
			obj5 = icon;
			obj6 = icon;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = icon;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = icon;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0154;
		IL_0154:
		Vector3 localScale = icon.localScale;
		int num = ShortcutExtensions.DOKill(icon);
		icon.localScale = (Vector3)0;
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		float num2 = default(float);
		float duration = num2 * bounceScale;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(icon, (Vector3)0, duration);
		object obj12 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t = default(Tween);
		Sequence s2 = TweenSettingsExtensions.Append(s, t);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(icon, (Vector3)0, num2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t2 = default(Tween);
		Sequence sequence = TweenSettingsExtensions.Append(s2, t2);
		return;
		IL_0091:
		if (obj5 == null)
		{
			return;
		}
		goto IL_0154;
	}

	public ClanLevelProgress()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253598]");
		bounceScale = 0f;
		base..ctor();
	}
}
