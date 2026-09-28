using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class LastMatchCacher : MonoBehaviour
{
	private sealed class <>c__DisplayClass6_0
	{
		public PlayerInfo player;

		internal bool <AddPlayerToCacheIfValid>b__0(PlayerInfo p)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo playerInfo = player;
				if (player != null)
				{
					object obj = p.<DBID>k__BackingField - playerInfo.<DBID>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private List<PlayerInfo> _cachedPlayer;

	private KGame game;

	public static string LastMatchPlayersPath
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0085: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = "java.io.FileOutputStream" + 1160;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string cachePath = Config.CachePath;
			return cachePath + (string)obj2;
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0129: Expected O, but got I
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0149: Expected O, but got I
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0058: Expected O, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00b9: Expected I, but got O
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00de: Expected O, but got I
		//IL_0108: Expected I, but got O
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2688;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = (nint)0 + (nint)136;
		object obj4 = typeof(SqlSingle[]) + 2376;
		object obj5 = (nint)0 + (nint)136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj6 = this + 32;
		obj6 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj9 = this + 40;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj5);
		object obj11 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj12 = (nint)0 + (nint)128;
		((KGame)obj9).OnGameInitialized += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)obj12);
		game.OnPlayerSwitchSeat += playerSwitchSeatDelegate;
	}

	private void CachePlayers()
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01c2: Expected O, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_008e: Expected O, but got I4
		//IL_0145: Expected O, but got I
		//IL_015d: Expected O, but got I
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_0118: Expected O, but got I4
		if (game.IsSpectator)
		{
			return;
		}
		Room room = game.Room;
		PlayerInfo[] playersInfo = SFSKammelnaRoomExtensions.GetPlayersInfo(room);
		bool flag = playersInfo.Length < 1;
		PlayerInfo playerInfo = null;
		if (!flag)
		{
			object obj = playersInfo + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X22_v3+v172 @ X21_v7*8]");
				playerInfo = (PlayerInfo)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X22_v3+v172 @ X21_v7*8]");
				AddPlayerToCacheIfValid((PlayerInfo)0, _cachedPlayer);
				obj2++;
			}
			while ((nint)obj2 < playersInfo.Length);
		}
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj4 = "java.io.FileOutputStream" + 1160;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string cachePath = Config.CachePath;
		string path = cachePath + (string)obj4;
		object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FileUtils.SaveObject(path, (object)_cachedPlayer);
	}

	private void AddPlayerToCacheIfValid(PlayerInfo player, List<PlayerInfo> playerCache)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0067: Expected O, but got I4
		//IL_009c: Expected O, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I
		//IL_010b: Expected I, but got O
		//IL_011c: Expected O, but got I
		//IL_0147: Expected O, but got I4
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_01a0: Expected O, but got I4
		//IL_01fe: Expected I8, but got I
		//IL_01c9: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool isSpectator = game.IsSpectator;
		bool flag = !isSpectator;
		object obj4 = !flag;
		if (obj4 != null)
		{
			return;
		}
		bool isMe = ((PlayerInfo)obj3).IsMe;
		bool flag2 = !isMe;
		object obj5 = !flag2;
		if (obj5 != null || !((PlayerInfo)obj3).IsHuman)
		{
			return;
		}
		object obj6 = typeof(List<Tween>) + 3384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = (nint)0 + (nint)3448;
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj2, (IntPtr)obj7);
		object obj8 = (nint)0 + (nint)1936;
		bool flag3 = ((List<object>)(object)playerCache).Exists(predicate);
		bool flag4 = !flag3;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			object obj10 = obj3;
			object obj11 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v11+10]");
			if (FriendsManager.IsCompleteStranger(0L))
			{
				object obj14 = (nint)0 + (nint)1928;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9C1C4");
			}
		}
	}

	public LastMatchCacher()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 32;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <Start>b__4_0(int i, string s)
	{
		CachePlayers();
	}
}
