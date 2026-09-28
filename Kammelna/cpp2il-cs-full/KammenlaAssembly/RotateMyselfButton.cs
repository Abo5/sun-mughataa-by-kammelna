using System;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;

public class RotateMyselfButton : MonoBehaviour
{
	private Vector3 eulerRotation = (Vector3)0;

	private bool isRelative;

	private RectTransform targetTransform;

	protected void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0049: Expected I, but got O
		//IL_0063: Expected O, but got I
		object obj = (nint)0 + (nint)3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj3 = (nint)0 + (nint)3112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+100]");
		((UnityEvent)0).AddListener(unityAction);
	}

	private void OnValidate()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_010e: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0184: Expected O, but got I
		//IL_0162: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73E4]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj7;
		object obj8;
		object obj4;
		if (obj3 != null)
		{
			obj4 = this + 48;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (!flag)
			{
				goto IL_00a0;
			}
		}
		else
		{
			_ = 1;
			obj4 = this + 48;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj7;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		obj4 = obj8;
		if (obj10 != null)
		{
			return;
		}
		goto IL_0178;
		IL_0178:
		object obj11 = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		RectTransform rectTransform = default(RectTransform);
		targetTransform = rectTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_00a0:
		if ((bool)obj5)
		{
			return;
		}
		goto IL_0178;
	}

	public RotateMyselfButton()
	{
		//IL_000b: Expected O, but got I4
		_ = 1119092736;
		isRelative = true;
		base..ctor();
	}

	private void <Awake>b__3_0()
	{
		//IL_000c: Expected O, but got I
		//IL_002c: Expected F4, but got O
		//IL_002c: Expected O, but got I4
		object obj = (nint)0 + (nint)3112;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(targetTransform, (Vector3)1, (float)eulerRotation);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30594A8");
	}
}
