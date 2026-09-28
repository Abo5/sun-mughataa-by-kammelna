using System.Threading;
using Cpp2ILInjected;
using Features.GameReplay;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.UI;

public class RoomInfoIcons : MonoBehaviour
{
	public Image iconLock;

	public Image iconSpeed;

	public Image iconFriendly;

	public Image iconCheating;

	private RoomInfoSprites roomInfoSprites;

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e7: Expected O, but got I
		//IL_0111: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_015a: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7AD2]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		KGame kGame = default(KGame);
		bool flag3 = (object)kGame == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_00b8:
		Room room = kGame.Room;
		UpdateIcons(room);
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		if ((object)kGame != null)
		{
			goto IL_00b8;
		}
	}

	public void UpdateIcons(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X10_v5-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj4 = obj3 + 10;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_013b;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_013b;
		IL_013b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v178 @ X0_v3] (should have been resolved before IL gen)");
		int timeoutInterval = SFSKammelnaRoomExtensions.GetTimeoutInterval(room);
		bool isCheating = SFSKammelnaRoomExtensions.IsCheatingAllowed(room);
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
		bool isVoiceChat = SFSKammelnaRoomExtensions.IsVoiceChatEnabled(room);
		bool isLocked = default(bool);
		UpdateIcons(isLocked, timeoutInterval, isCheating, gameType, isVoiceChat);
	}

	public void UpdateIcons(FriendlyChallengeInviteModel challenge)
	{
		UpdateIcons(isLocked: false, challenge.<PlayingSpeed>k__BackingField, challenge.<CheatingAllowed>k__BackingField, GameType.Challenge, isVoiceChat: false);
	}

	public void UpdateIcons(bool isLocked, int speed, bool isCheating, GameType gameType, bool isVoiceChat)
	{
		Sprite lockIcon = roomInfoSprites.GetLockIcon(isLocked);
		iconLock.sprite = lockIcon;
		Sprite speedIcon = roomInfoSprites.GetSpeedIcon(speed);
		iconSpeed.sprite = speedIcon;
		Sprite cheatingIcon = roomInfoSprites.GetCheatingIcon(isCheating);
		iconCheating.sprite = cheatingIcon;
		Sprite roomTypeIcon = roomInfoSprites.GetRoomTypeIcon(gameType, isVoiceChat);
		iconFriendly.sprite = roomTypeIcon;
	}

	public void UpdateIcons(GameRoomData room)
	{
		UpdateIcons(room.IsPasswordProtected, room.Timer, room.IsCheatingAllowed, room.GameType, room.IsVoiceChatEnabled);
	}

	public void UpdateIcons(GameReplayCardData gameReplayCardData)
	{
		GameReplay <GameReplay>k__BackingField = gameReplayCardData.<GameReplay>k__BackingField;
		UpdateIcons(<GameReplay>k__BackingField.<IsPasswordProtected>k__BackingField, <GameReplay>k__BackingField.<Timer>k__BackingField, <GameReplay>k__BackingField.<IsCheatingAllowed>k__BackingField, <GameReplay>k__BackingField.<GameType>k__BackingField, isVoiceChat: false);
	}
}
