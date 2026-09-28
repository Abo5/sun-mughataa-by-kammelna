using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ClanJoinRequestStrip : ListViewItem<ClanJoinRequestDataHolder, int>
{
	private AvatarInitializer avatar;

	private Button ConfirmButton;

	private Button rejectButton;

	private ClanJoinRequestsListView _listView;

	public void SetListView(ClanJoinRequestsListView listView)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 168;
		obj = listView;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public unsafe override void Setup(ClanJoinRequestDataHolder datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_0111: Expected O, but got Ref
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_0084: Expected I, but got O
		//IL_00d3: Expected O, but got I
		//IL_00eb: Expected I, but got O
		object obj = (nint)0 + (nint)1624;
		int num = default(int);
		bool firstTime2 = default(bool);
		base.Setup((ClanJoinRequestDataHolder)(&num), firstTime2);
		SetInteractable(interactable: true);
		AvatarData avatarData = datum.<User>k__BackingField;
		avatar.Initialize(avatarData);
		Button confirmButton = ConfirmButton;
		confirmButton.m_OnClick.RemoveAllListeners();
		Button confirmButton2 = ConfirmButton;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj3 = (nint)0 + (nint)1152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj3);
		confirmButton2.m_OnClick.AddListener(unityAction);
		Button button = rejectButton;
		button.m_OnClick.RemoveAllListeners();
		Button button2 = rejectButton;
		object obj4 = (nint)0 + (nint)1160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj4);
		button2.m_OnClick.AddListener(unityAction2);
	}

	public void OnActionFailed()
	{
		SetInteractable(interactable: true);
	}

	public void Dismiss(bool confirmed, Action onComplete)
	{
		if (onComplete != null)
		{
			IntPtr invoke_impl = ((Delegate)onComplete).invoke_impl;
			IntPtr method_code = ((Delegate)onComplete).method_code;
			IntPtr method = ((Delegate)onComplete).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X3_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void Begin(bool accepted)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_0171: Expected O, but got I
		//IL_0147: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87B7]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object listView;
		UnityEngine.Object listView2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			listView = _listView;
			listView2 = _listView;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			listView = _listView;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			listView2 = _listView;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = listView2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0156;
		IL_0156:
		SetInteractable(interactable: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanJoinRequestStrip)+50]");
		object obj7 = 0;
		if (accepted)
		{
			ClanJoinRequestsListView listView3 = _listView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v3+14]");
			listView3.Accept(0, this);
		}
		else
		{
			ClanJoinRequestsListView listView4 = _listView;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v3+14]");
			listView4.Reject(0, this);
		}
		return;
		IL_0091:
		if (listView == null)
		{
			return;
		}
		goto IL_0156;
	}

	private void SetInteractable(bool interactable)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0181: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_022a: Expected O, but got I4
		//IL_0233: Expected O, but got I4
		//IL_0102: Expected I4, but got O
		//IL_01d4: Expected O, but got I4
		//IL_0286: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87B8]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object confirmButton;
		UnityEngine.Object confirmButton2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			confirmButton = ConfirmButton;
			confirmButton2 = ConfirmButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			confirmButton = ConfirmButton;
			confirmButton2 = ConfirmButton;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = confirmButton2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (flag4)
		{
			goto IL_00d1;
		}
		goto IL_01e7;
		IL_0141:
		rejectButton.interactable = interactable;
		return;
		IL_011a:
		UnityEngine.Object obj8;
		if (obj8 != null)
		{
			goto IL_0141;
		}
		return;
		IL_0253:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj9;
		bool flag5 = obj9 != null;
		bool flag6 = !flag5;
		object obj10 = !flag6;
		if (obj10 == null)
		{
			return;
		}
		goto IL_0141;
		IL_0091:
		bool flag7 = confirmButton != null;
		bool flag8 = !flag7;
		object obj11 = !flag8;
		obj6 = 0;
		obj7 = null;
		if (obj11 == null)
		{
			goto IL_00d1;
		}
		goto IL_01e7;
		IL_01e7:
		ConfirmButton.interactable = interactable;
		obj8 = rejectButton;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v4+E4]");
		bool flag9 = (nint)0 == 0;
		object obj13 = !flag9;
		obj6 = 0;
		bool flag10 = interactable;
		obj9 = rejectButton;
		if (obj13 != null)
		{
			goto IL_011a;
		}
		goto IL_0253;
		IL_00d1:
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v4+E4]");
		bool flag11 = (nint)0 == 0;
		obj8 = rejectButton;
		flag10 = (byte)(int)obj7 != 0;
		obj9 = rejectButton;
		if (!flag11)
		{
			goto IL_011a;
		}
		goto IL_0253;
	}

	private void <Setup>b__5_0()
	{
		Begin(accepted: true);
	}

	private void <Setup>b__5_1()
	{
		Begin(accepted: false);
	}
}
