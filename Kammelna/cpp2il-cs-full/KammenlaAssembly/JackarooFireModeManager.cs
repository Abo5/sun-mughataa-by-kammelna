using System;
using Cpp2ILInjected;
using Jackaroo;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class JackarooFireModeManager : FireModeManager
{
	private GameObject shineUI;

	protected override void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		base.Start();
		Button fireModeButton = _fireModeButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		fireModeButton.m_OnClick.AddListener(unityAction);
	}

	protected override void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0053: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 352;
		object obj2 = (nint)0 + (nint)680;
		base.OnDestroy();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)this, (IntPtr)obj2);
		gameEventsChannel.OnMarbleDismissibleClicked -= action;
	}

	protected override void OnActivateFireMode()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0084: Expected I, but got O
		//IL_0051: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 352;
		object obj2 = (nint)0 + (nint)680;
		base.OnActivateFireMode();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)this, (IntPtr)obj2);
		gameEventsChannel.OnMarbleDismissibleClicked -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action2 = default(Action<object, object>);
		action2..ctor((object)this, (IntPtr)obj2);
		gameEventsChannel.OnMarbleDismissibleClicked += action2;
	}

	protected override void OnEnableFireModeButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0053: Expected O, but got I4
		object obj = typeof(UsageHint) + 72;
		_fireModeButton.interactable = true;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool clickedOnJackarooFireModeButton = UserInfo.ClickedOnJackarooFireModeButton;
		bool active = (byte)((clickedOnJackarooFireModeButton ? 1u : 0u) ^ 1u) != 0;
		shineUI.SetActive(active);
	}

	protected override void OnDisableFireModeButton()
	{
		_fireModeButton.interactable = false;
		shineUI.SetActive(value: false);
	}

	private void MarkJackarooFireModeClicked()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E78A9]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UserInfo.ClickedOnJackarooFireModeButton = true;
		GameObject gameObject = shineUI;
		bool flag2 = (object)shineUI == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0096;
		IL_007d:
		UserInfo.ClickedOnJackarooFireModeButton = true;
		gameObject = shineUI;
		goto IL_0096;
		IL_0096:
		gameObject.SetActive(value: false);
	}

	protected override void OnDismissibleClicked(GameCard cardHit)
	{
	}

	private void OnMarbleDismissibleClicked(GameCard card, JackarooMarbleMono marble)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e9: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_00a1: Expected O, but got I4
		//IL_0128: Expected O, but got I4
		//IL_01d9: Expected O, but got I4
		//IL_018c: Expected O, but got I4
		//IL_0195: Expected O, but got I4
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0263: Expected O, but got I
		//IL_0271: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E78AA]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = marble == null;
		bool flag3 = !flag2;
		object obj5 = 0;
		UnityEngine.Object obj6 = null;
		if (!flag3)
		{
			goto IL_013b;
		}
		return;
		IL_013b:
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag4 = card == null;
			bool flag5 = !flag4;
			object obj8 = !flag5;
			object obj9 = 0;
			if (obj8 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag6 = card == null;
			bool flag7 = !flag6;
			object obj9 = 0;
			if (flag7)
			{
				return;
			}
		}
		GameEventsChannel gameEventsChannel = base.gameEventsChannel;
		if (gameEventsChannel.isFireModeActive)
		{
			gameEventsChannel.TriggerDeactivateFireMode();
			base.gameEventsChannel.TriggerHideDismissibleBlocker();
			object obj10 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 352;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)680;
			Action<object, object> action = default(Action<object, object>);
			action..ctor((object)this, (IntPtr)obj11);
			base.gameEventsChannel.OnMarbleDismissibleClicked -= action;
		}
		return;
		IL_0074:
		bool flag8 = marble == null;
		bool flag9 = !flag8;
		object obj12 = !flag9;
		obj5 = 0;
		obj6 = null;
		if (obj12 == null)
		{
			return;
		}
		goto IL_013b;
	}
}
