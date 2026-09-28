using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Server.Models;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class JoinTournamentRoomGroup : MonoBehaviour
{
	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_012e: Expected O, but got I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0185: Expected O, but got I4
		//IL_01b6: Expected I4, but got I8
		object obj = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CCB]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool hasUnseenTournaments = UserInfo.HasUnseenTournaments;
		bool flag2 = !hasUnseenTournaments;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			goto IL_0096;
		}
		goto IL_013c;
		IL_0096:
		if (!SFS.IsSubscribedToGroup(RoomGroup.Tournaments))
		{
			object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v17+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CounterBubbleManager.UpdateCounter(CounterBubbleType.Tournaments, -1);
		}
		return;
		IL_013c:
		SFS.JoinRoomGroup(RoomGroup.Tournaments);
		return;
		IL_0074:
		if (UserInfo.HasUnseenTournaments)
		{
			goto IL_0096;
		}
		goto IL_013c;
	}
}
