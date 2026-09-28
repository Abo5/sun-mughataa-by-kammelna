using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class FireModeManager : MonoBehaviour
{
	protected Button _fireModeButton;

	protected GameEventsChannel gameEventsChannel;

	private KGame _game;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00f2: Expected I, but got O
		//IL_003c: Expected I, but got O
		//IL_007a: Expected I, but got O
		//IL_00b8: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (Il2CppClass<FireModeManager>)+1C0]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		gameEventsChannel.OnShowFireModeButton += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v5 (Il2CppClass<FireModeManager>)+1D0]");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)0);
		gameEventsChannel.OnHideFireModeButton += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6 (Il2CppClass<FireModeManager>)+1E0]");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)0);
		gameEventsChannel.OnEnableFireModeButton += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v7 (Il2CppClass<FireModeManager>)+1F0]");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)0);
		gameEventsChannel.OnDisableFireModeButton += action4;
	}

	protected virtual void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0163: Expected O, but got I
		//IL_018d: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_007d: Expected O, but got I
		//IL_00a7: Expected I, but got O
		//IL_00cf: Expected I, but got O
		//IL_00f6: Expected O, but got I
		//IL_0122: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3616;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 48;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		object obj9 = (nint)0 + (nint)3608;
		((KGame)obj7).OnRoundEnd += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj9);
		gameEventsChannel.HideDismissibleBlocker += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v5 (Il2CppClass<FireModeManager>)+1A0]");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)0);
		object obj10 = (nint)0 + (nint)3600;
		gameEventsChannel.OnActivateFireMode += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj10);
		gameEventsChannel.OnDeactivateFireMode += action4;
	}

	protected virtual void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01fc: Expected I, but got O
		//IL_003c: Expected I, but got O
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_008e: Expected I, but got O
		//IL_00b5: Expected O, but got I
		//IL_00e1: Expected I, but got O
		//IL_0109: Expected I, but got O
		//IL_0130: Expected O, but got I
		//IL_015c: Expected I, but got O
		//IL_0184: Expected I, but got O
		//IL_01c2: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3 (Il2CppClass<FireModeManager>)+1C0]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		gameEventsChannel.OnShowFireModeButton -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v5 (Il2CppClass<FireModeManager>)+1D0]");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)0);
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
		gameEventsChannel.OnHideFireModeButton -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6 (Il2CppClass<FireModeManager>)+1B0]");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)0);
		object obj3 = (nint)0 + (nint)3608;
		gameEventsChannel.OnDismissibleClicked -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj3);
		gameEventsChannel.HideDismissibleBlocker -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v7 (Il2CppClass<FireModeManager>)+1A0]");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)0);
		object obj4 = (nint)0 + (nint)3600;
		gameEventsChannel.OnActivateFireMode -= action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action6 = default(Action);
		action6..ctor(this, (IntPtr)obj4);
		gameEventsChannel.OnDeactivateFireMode -= action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num5 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v8 (Il2CppClass<FireModeManager>)+1E0]");
		Action action7 = default(Action);
		action7..ctor(this, (IntPtr)0);
		gameEventsChannel.OnEnableFireModeButton -= action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num6 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v9 (Il2CppClass<FireModeManager>)+1F0]");
		Action action8 = default(Action);
		action8..ctor(this, (IntPtr)0);
		gameEventsChannel.OnDisableFireModeButton -= action8;
	}

	protected virtual void OnActivateFireMode()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0038: Expected I, but got O
		//IL_0076: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
		gameEventsChannel.TriggerShowDismissibleBlocker();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v4 (Il2CppClass<FireModeManager>)+1B0]");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)0);
		gameEventsChannel.OnDismissibleClicked -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v5 (Il2CppClass<FireModeManager>)+1B0]");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)0);
		gameEventsChannel.OnDismissibleClicked += action2;
	}

	private void OnDeactivateFireMode()
	{
		gameEventsChannel.TriggerHideDismissibleBlocker();
	}

	private void OnRoundEnd()
	{
		gameEventsChannel.TriggerDeactivateFireMode();
	}

	private void OnHideDismissibleBlocker()
	{
		gameEventsChannel.TriggerDeactivateFireMode();
	}

	protected virtual void OnDismissibleClicked(GameCard cardHit)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e4: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_00a1: Expected O, but got I4
		//IL_0123: Expected O, but got I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_01a6: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E78A2]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = cardHit == null;
		bool flag3 = !flag2;
		object obj5 = 0;
		if (!flag3)
		{
			goto IL_0131;
		}
		return;
		IL_0131:
		GameEventsChannel gameEventsChannel = this.gameEventsChannel;
		if (gameEventsChannel.isFireModeActive)
		{
			gameEventsChannel.TriggerDeactivateFireMode();
			this.gameEventsChannel.TriggerHideDismissibleBlocker();
			object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v8 (Il2CppClass<FireModeManager>)+1B0]");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)0);
			this.gameEventsChannel.OnDismissibleClicked -= action;
		}
		return;
		IL_0074:
		bool flag4 = cardHit == null;
		bool flag5 = !flag4;
		object obj7 = !flag5;
		obj5 = 0;
		if (obj7 == null)
		{
			return;
		}
		goto IL_0131;
	}

	protected void DeactivateFireMode()
	{
		gameEventsChannel.TriggerDeactivateFireMode();
	}

	protected virtual void OnShowFireModeButton()
	{
		GameObject gameObject = _fireModeButton.gameObject;
		gameObject.SetActive(value: true);
	}

	protected virtual void OnHideFireModeButton()
	{
		GameObject gameObject = _fireModeButton.gameObject;
		gameObject.SetActive(value: false);
	}

	protected virtual void OnEnableFireModeButton()
	{
		_fireModeButton.interactable = true;
	}

	protected virtual void OnDisableFireModeButton()
	{
		_fireModeButton.interactable = false;
	}
}
