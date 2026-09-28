using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using ListView;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class LastMatchStrip : ListViewItem<PlayerInfoWrapper, int>
{
	private sealed class <>c__DisplayClass8_0
	{
		public string message;

		public LastMatchStrip <>4__this;

		internal void <AddClicked>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_00d0: Expected O, but got I
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected O, but got Unknown
			//IL_011b: Expected O, but got I4
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_0075: Expected O, but got I4
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			object obj = (nint)0 + (nint)1048;
			if (response.Succeeded)
			{
				object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v13+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object title = "DNQUALIFIER" + 3784;
				object buttonText = "Network Authentication Required" + 3128;
				PopupWindow.ShowInfo((string)title, message, (string)buttonText);
				return;
			}
			object obj5 = (nint)0 + (nint)1024;
			string errorMessage = response.ErrorMessage;
			object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowError(errorMessage);
			LastMatchStrip lastMatchStrip = <>4__this;
			lastMatchStrip.addButton.interactable = true;
		}
	}

	private Button addButton;

	private AvatarInitializer avatar;

	private int _playerID;

	private void Awake()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		//IL_005a: Expected I, but got O
		AvatarInitializer avatarInitializer = avatar;
		avatarInitializer.<TrackingPlacement>k__BackingField = TrackingPlacement.FriendsCenter;
		Button button = addButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
	}

	public override void Setup(PlayerInfoWrapper datum, bool firstTime)
	{
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		PlayerInfo <player>k__BackingField = datum.<player>k__BackingField;
		_playerID = <player>k__BackingField.<DBID>k__BackingField;
		AvatarData avatarData = <player>k__BackingField;
		avatar.Initialize(avatarData);
		addButton.interactable = true;
	}

	public void AssignData(PlayerInfo player)
	{
		_playerID = player.<DBID>k__BackingField;
		AvatarData avatarData = player;
		avatar.Initialize(avatarData);
		addButton.interactable = true;
	}

	public void AssignData(PlayerProfileModel player)
	{
		//IL_000f: Expected I4, but got I8
		_playerID = (int)player.<userDbId>k__BackingField;
		AvatarData avatarData = player;
		avatar.Initialize(avatarData);
		addButton.interactable = true;
	}

	public void SetAddButtonInteractability(bool isInteractable)
	{
		addButton.interactable = isInteractable;
	}

	private void AddClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_00f2: Expected I8, but got I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0124: Expected O, but got I4
		//IL_012d: Expected O, but got I4
		//IL_0097: Expected I8, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02d8: Expected O, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_0313: Expected I, but got O
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0181: Expected O, but got I4
		//IL_0273: Expected O, but got I4
		//IL_01aa: Expected O, but got I
		//IL_00d0: Expected O, but got I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_0206: Expected O, but got I4
		//IL_023c: Expected O, but got I4
		//IL_0226: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		addButton.interactable = false;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v10+E4]");
		object obj6;
		object obj8;
		if ((nint)0 != 0)
		{
			bool flag = FriendsManager.IsReceivedFriendship(_playerID);
			obj6 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1416;
			if (!flag)
			{
				goto IL_0143;
			}
			object obj7 = 0;
			obj8 = obj6;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = FriendsManager.IsReceivedFriendship(_playerID);
			obj6 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1416;
			bool flag3 = !flag2;
			object obj9 = !flag3;
			object obj7 = 0;
			obj8 = obj6;
			if (obj9 == null)
			{
				goto IL_0143;
			}
		}
		goto IL_02b8;
		IL_02b8:
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj11 = (nint)0 + (nint)3456;
		object obj12 = obj2 + 16;
		obj12 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj11);
		object obj13 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v17+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.AddFriend(_playerID, action);
		return;
		IL_0143:
		object obj15 = typeof(Queue<string>) + 848;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v22+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj18 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		bool flag6 = SFSKammelnaUserExtensions.Can(localUser, UserPermission.ForceFriend);
		object obj19 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1424;
		bool flag7 = !flag6;
		object obj20 = !flag7;
		object obj21 = ~obj20;
		if (obj21 == null)
		{
			object obj7 = 0;
			obj8 = obj6;
		}
		else
		{
			object obj7 = 0;
			obj8 = obj19;
		}
		goto IL_02b8;
	}

	public LastMatchStrip()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
