using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine;

public class TournamentRemainingDaysCounter : MonoBehaviour
{
	private DateTimeText nextTicketTimer;

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01e6: Expected O, but got I4
		//IL_01ef: Expected O, but got I4
		//IL_01b9: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77D7]");
		object obj3 = (nint)0 & (nint)1;
		DateTimeText dateTimeText;
		DateTimeText dateTimeText2;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			dateTimeText = nextTicketTimer;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			dateTimeText2 = nextTicketTimer;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			dateTimeText = nextTicketTimer;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			dateTimeText2 = nextTicketTimer;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		dateTimeText = dateTimeText2;
		goto IL_0168;
		IL_01fd:
		throw new NullReferenceException();
		IL_0168:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		TicketRecord tournamentTickets = SFSKammelnaUserExtensions.GetTournamentTickets(localUser, TournamentType.Public);
		DateTime date;
		if (tournamentTickets != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v5 (Server.Models.TicketRecord)+28]");
			date = (DateTime)0;
		}
		else
		{
			bool flag3 = (object)dateTimeText == null;
			object obj8 = !flag3;
			date = (DateTime)0;
			if (obj8 == null)
			{
				goto IL_01fd;
			}
		}
		dateTimeText.SetDate(date);
		return;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			goto IL_0168;
		}
		goto IL_01fd;
	}
}
