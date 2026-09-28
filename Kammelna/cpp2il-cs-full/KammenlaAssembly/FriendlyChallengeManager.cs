using System;
using System.Buffers.Text;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;

public class FriendlyChallengeManager : MonoBehaviour
{
	private ChallengeEventsChannel events;

	private FriendlyChallengeData testData;

	public int ChallengeLevel;

	public void TestChallengeEvent()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A3B]");
		object obj3 = (nint)0 & (nint)1;
		FriendlyChallengeData friendlyChallengeData;
		object obj6;
		FriendlyChallengeData friendlyChallengeData2;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			friendlyChallengeData = testData;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			friendlyChallengeData2 = testData;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			friendlyChallengeData = testData;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			friendlyChallengeData2 = testData;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		friendlyChallengeData = friendlyChallengeData2;
		goto IL_0170;
		IL_0170:
		object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 936;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo = default(PlayerInfo);
		playerInfo..ctor(localUser);
		object obj9 = friendlyChallengeData + 16;
		obj9 = playerInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo2 = default(PlayerInfo);
		playerInfo2..ctor(localUser2);
		object obj10 = testData + 24;
		obj10 = playerInfo2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		FriendlyChallengeData friendlyChallengeData3 = testData;
		friendlyChallengeData3.<ChallengeLevel>k__BackingField = ChallengeLevel;
		events.TriggerChallengeActivity(friendlyChallengeData3);
		return;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0170;
	}
}
