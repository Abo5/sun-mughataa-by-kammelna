using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities.Data;
using Unity.Properties;

public class MockChallengeConnector : ChallengeConnector
{
	public override void SendChallengeInvite(int userId, FriendlyChallengeRoomConfig conf)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		object key = "destinationTimeZone" + 3968;
		object command = "destinationTimeZone" + 3976;
		ISFSObject iSFSObject = conf.ToSfsObject();
		SFSExtensions.Put(iSFSObject, (string)key, userId);
		SFS.SendZoneExtensionRequest((string)command, iSFSObject);
	}

	public override void SendChallengeAccept(int challengerId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)3224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public override void SendChallengeDecline(int challengerId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)3232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public override void GetUsersFriendlyChallenges(long userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		//IL_0089: Expected O, but got I
		//IL_00b2: Expected O, but got I
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_019c: Expected O, but got I8
		//IL_0141: Expected I, but got O
		//IL_0151: Expected O, but got I
		//IL_017a: Expected O, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 2496;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FriendlyChallengeEntryModel friendlyChallengeEntryModel = default(FriendlyChallengeEntryModel);
		friendlyChallengeEntryModel..ctor();
		FriendlyChallengeEntryModel[] array = default(FriendlyChallengeEntryModel[]);
		bool flag = array == null;
		FriendlyChallengeEntryModel friendlyChallengeEntryModel2 = null;
		if (flag)
		{
			goto IL_0210;
		}
		bool flag2 = friendlyChallengeEntryModel == null;
		friendlyChallengeEntryModel2 = null;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		FriendlyChallengeEntryModel friendlyChallengeEntryModel3;
		if (!flag2)
		{
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11 (Il2CppClass<FriendlyChallengeEntryModel[]>)+40]");
			friendlyChallengeEntryModel2 = (FriendlyChallengeEntryModel)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag3 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11 (Il2CppClass<FriendlyChallengeEntryModel[]>)+40]");
			friendlyChallengeEntryModel3 = (FriendlyChallengeEntryModel)0;
			if (flag3)
			{
				goto IL_0234;
			}
		}
		if (array.Length != 0)
		{
			object obj3 = array + 32;
			obj3 = friendlyChallengeEntryModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			FriendlyChallengeEntryModel friendlyChallengeEntryModel4 = default(FriendlyChallengeEntryModel);
			friendlyChallengeEntryModel4..ctor();
			bool flag4 = friendlyChallengeEntryModel4 == null;
			friendlyChallengeEntryModel2 = null;
			if (!flag4)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v10 (Il2CppClass<FriendlyChallengeEntryModel[]>)+40]");
				friendlyChallengeEntryModel2 = (FriendlyChallengeEntryModel)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag5 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v10 (Il2CppClass<FriendlyChallengeEntryModel[]>)+40]");
				friendlyChallengeEntryModel3 = (FriendlyChallengeEntryModel)0;
				if (flag5)
				{
					goto IL_0234;
				}
			}
			object obj4 = array.Length & 0xFFFFFFFEL;
			if (obj4 != null)
			{
				object obj5 = array + 40;
				obj5 = friendlyChallengeEntryModel4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag6 = (object)_events == null;
				friendlyChallengeEntryModel2 = friendlyChallengeEntryModel4;
				if (!flag6)
				{
					_events.TriggerChallengeDataReceived(array);
					return;
				}
				goto IL_0210;
			}
		}
		goto IL_021e;
		IL_0234:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0210:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_021e;
		IL_021e:
		ex = new IndexOutOfRangeException();
		friendlyChallengeEntryModel3 = friendlyChallengeEntryModel2;
		goto IL_0234;
	}

	protected override void InviteFailed(FriendlyChallengeInviteError error)
	{
	}

	protected override void ResponseFailed(FriendlyChallengeResponseError error)
	{
	}

	protected override void ChallengeCancelled(bool isCancelledByCreator)
	{
	}

	protected override void ChallengeWithdrawn()
	{
	}
}
