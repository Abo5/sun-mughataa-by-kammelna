using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentParticipantStrip : MonoBehaviour
{
	internal AvatarInitializer playerIconUnit;

	internal Image roomOwnerTag;

	private int Id;

	private TournamentViewPanel _panel;

	public virtual void SetPlayer(LobbyPlayerData player, TournamentViewPanel pnl)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0053: Expected O, but got I
		//IL_0064: Expected O, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0093: Expected O, but got I
		//IL_00ab: Expected I, but got O
		//IL_00c5: Expected O, but got I
		int iD = player.ID;
		object obj = this + 56;
		obj = pnl;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X22_v4-18]");
		((AvatarInitializer)0).Initialize(player.User);
		object obj2 = (nint)0 + (nint)3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj4 = (nint)0 + (nint)1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v10+100]");
		((UnityEvent)0).AddListener(unityAction);
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
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D64]");
		object obj3 = (nint)0 & (nint)1;
		int num;
		int id;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			num = Id;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			id = Id;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			num = Id;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			id = Id;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		num = id;
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
