using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class PlayerStrip : MonoBehaviour
{
	internal AvatarInitializer playerIconUnit;

	internal Image roomOwnerTag;

	private int <Id>k__BackingField;

	private LobbyPlayerData <playerData>k__BackingField;

	internal LobbyPanel _panel;

	public int Id
	{
		get
		{
			return <Id>k__BackingField;
		}
		private set
		{
			<Id>k__BackingField = value;
		}
	}

	protected LobbyPlayerData playerData
	{
		get
		{
			return <playerData>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private void Awake()
	{
		AvatarInitializer avatarInitializer = playerIconUnit;
		avatarInitializer.<TrackingPlacement>k__BackingField = TrackingPlacement.GameLobby;
	}

	public virtual void SetPlayer(LobbyPlayerData player, LobbyPanel pnl, bool showControlButtons)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0016: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0051: Expected O, but got I
		//IL_0073: Expected O, but got I
		//IL_0073: Expected O, but got I
		//IL_0084: Expected O, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I
		//IL_00cb: Expected I, but got O
		//IL_00e5: Expected O, but got I
		object obj = this + 56;
		LobbyPlayerData lobbyPlayerData = default(LobbyPlayerData);
		obj = lobbyPlayerData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+10]");
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId((User)0);
		object obj3 = this + 64;
		obj3 = pnl;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X21_v6-8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X21_v6-20]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v5+10]");
		((AvatarInitializer)num).Initialize((User)0);
		object obj5 = (nint)0 + (nint)3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj7 = (nint)0 + (nint)1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v12+100]");
		((UnityEvent)0).AddListener(unityAction);
	}

	public void ShowOwnerTag(bool isOwner)
	{
		roomOwnerTag.enabled = isOwner;
	}

	private void ShowPlayerProfile()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C92]");
		object obj3 = (nint)0 & (nint)1;
		int num;
		int num2;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			num = <Id>k__BackingField;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			num2 = <Id>k__BackingField;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			num = <Id>k__BackingField;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			num2 = <Id>k__BackingField;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		num = num2;
		goto IL_0168;
		IL_0168:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		if (num != intDbId)
		{
			playerIconUnit.OpenProfile();
		}
		return;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0168;
	}
}
