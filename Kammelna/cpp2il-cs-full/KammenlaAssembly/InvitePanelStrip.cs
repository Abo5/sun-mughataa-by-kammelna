using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using ListView;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class InvitePanelStrip : ListViewItem<FriendInviteDataHolder, int>
{
	private AvatarInitializer avatarInitializer;

	public Button inviteButton;

	private TextMeshProUGUI inGameTag;

	private Action<FriendInviteDataHolder> _onInviteRequested;

	private FriendInviteListView _owner;

	private void Awake()
	{
		AvatarInitializer avatarInitializer = this.avatarInitializer;
		avatarInitializer.<TrackingPlacement>k__BackingField = TrackingPlacement.TournamentTeams;
	}

	public override void Setup(FriendInviteDataHolder datum, bool firstTime)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I4
		//IL_0070: Expected O, but got I
		//IL_0085: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0157: Expected I, but got O
		//IL_00f2: Expected O, but got I
		//IL_012f: Expected O, but got I4
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C42]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = this + 160;
			if (obj3 != null)
			{
				goto IL_0064;
			}
		}
		else
		{
			_ = 1;
			object obj3 = this + 160;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0064;
			}
		}
		object obj5 = (nint)0 + (nint)432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
		FriendInviteListView owner = default(FriendInviteListView);
		_owner = owner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag2 = datum == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0064;
		IL_0064:
		object obj7 = (nint)0 + (nint)1696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (InvitePanelStrip)+40]");
		if (datum.Equals(0))
		{
			Refresh();
		}
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v108 @ X8_v11 (Il2CppClass<InvitePanelStrip>)+318] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void Refresh()
	{
		//IL_010e: Expected O, but got I
		//IL_0016: Expected O, but got I
		//IL_005b: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (InvitePanelStrip)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
		AvatarData avatarData = (FriendProfile)0;
		avatarInitializer.Initialize(avatarData);
		Button button = inviteButton;
		button.m_OnClick.RemoveAllListeners();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (InvitePanelStrip)+40]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6+19]");
		if ((nint)0 == 1)
		{
			ShowAsInGame();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6+1A]");
		if ((nint)0 == 1)
		{
			ShowAsParticipantInTournament();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6+18]");
		if ((nint)0 == 1)
		{
			inviteButton.interactable = false;
		}
		else
		{
			ShowAsCanInvite();
		}
	}

	private void ShowAsInGame()
	{
		GameObject gameObject = inviteButton.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = inGameTag.gameObject;
		gameObject2.SetActive(value: true);
	}

	private void ShowAsParticipantInTournament()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007c: Expected I, but got O
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		GameObject gameObject = inviteButton.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = inGameTag.gameObject;
		gameObject2.SetActive(value: true);
		TextMeshProUGUI textMeshProUGUI = inGameTag;
		object obj = "HH:mm:ss.ffZ" + 3704;
		object obj2 = obj;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v62 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void ShowAsCanInvite()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0092: Expected O, but got I
		//IL_00aa: Expected I, but got O
		inviteButton.interactable = true;
		GameObject gameObject = inGameTag.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = inviteButton.gameObject;
		gameObject2.SetActive(value: true);
		Button button = inviteButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
	}

	private void ShowAsInvited()
	{
		inviteButton.interactable = false;
	}

	public void ShowPlayerProfile()
	{
		//IL_00f3: Expected O, but got I
		//IL_0015: Expected O, but got I
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003a: Expected O, but got I
		//IL_0064: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (InvitePanelStrip)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+10]");
		object obj2 = 0;
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+10]");
		if ((nint)0 != intDbId)
		{
			avatarInitializer.OpenProfile();
		}
	}

	public InvitePanelStrip()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	private void <ShowAsCanInvite>b__10_0()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_004d: Expected O, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0130: Expected O, but got I4
		//IL_00f6: Expected O, but got I4
		//IL_008e: Expected O, but got I4
		//IL_00c5: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		inviteButton.interactable = false;
		FriendInviteListView owner = _owner;
		bool flag = (object)_owner == null;
		object obj2 = 0;
		bool flag2 = false;
		if (!flag)
		{
			Action<FriendInviteDataHolder> inviteRequested = owner.InviteRequested;
			bool flag3 = owner.InviteRequested == null;
			obj2 = 0;
			flag2 = false;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (InvitePanelStrip)+40]");
				flag2 = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v6 (System.Action`1<FriendInviteDataHolder>)+28]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ X8_v6 (System.Action`1<FriendInviteDataHolder>)+18] (should have been resolved before IL gen)");
			}
		}
		object message = "SERVICE_DISABLED" + 3040;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj4 = !flag4;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show((string)message, (Vector2)0, 0f);
	}
}
