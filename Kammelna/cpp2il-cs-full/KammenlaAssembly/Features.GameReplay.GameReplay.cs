using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;
using Util;

namespace Features.GameReplay;

public class GameReplay
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<PlayerInfo, int> <>9__98_0;

		public static Func<PlayerInfo, string> <>9__98_1;

		public static Func<PlayerInfo, int> <>9__98_2;

		public static Func<PlayerInfo, bool> <>9__98_3;

		public static Func<PlayerInfo, int> <>9__98_4;

		public static Func<PlayerInfo, bool> <>9__98_5;

		public static Func<PlayerInfo, bool> <>9__98_6;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 4016;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <.ctor>b__98_0(PlayerInfo info)
		{
			//IL_0035: Expected I4, but got O
			if (info != null)
			{
				return info.<DBID>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal string <.ctor>b__98_1(PlayerInfo info)
		{
			if (info != null)
			{
				return info.<Name>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}

		internal int <.ctor>b__98_2(PlayerInfo info)
		{
			//IL_0064: Expected I4, but got O
			if (info != null)
			{
				PlayerRank <PlayerRank>k__BackingField = info.<PlayerRank>k__BackingField;
				if (info.<PlayerRank>k__BackingField != null)
				{
					return <PlayerRank>k__BackingField.<Points>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal bool <.ctor>b__98_3(PlayerInfo info)
		{
			//IL_0064: Expected I4, but got O
			if (info != null)
			{
				PlayerRank <PlayerRank>k__BackingField = info.<PlayerRank>k__BackingField;
				if (info.<PlayerRank>k__BackingField != null)
				{
					return <PlayerRank>k__BackingField.<IsNew>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <.ctor>b__98_4(PlayerInfo info)
		{
			//IL_0035: Expected I4, but got O
			if (info != null)
			{
				return info.<ActiveCardBack>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal bool <.ctor>b__98_5(PlayerInfo info)
		{
			//IL_0035: Expected I4, but got O
			if (info != null)
			{
				return info.<IsVerified>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <.ctor>b__98_6(PlayerInfo info)
		{
			//IL_0035: Expected I4, but got O
			if (info != null)
			{
				return info.<IsSubscribed>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private int <Version>k__BackingField;

	private int <OwnerId>k__BackingField;

	private string <Name>k__BackingField;

	private int <RoomThemeId>k__BackingField;

	private int[] <PlayersDbIds>k__BackingField;

	private string[] <PlayersNames>k__BackingField;

	private int[] <PlayersRanksPoints>k__BackingField;

	private bool[] <PlayersRanksIsNew>k__BackingField;

	private int[] <PlayersActiveCardsBack>k__BackingField;

	private bool[] <PlayersVerified>k__BackingField;

	private bool[] <PlayersSubscribed>k__BackingField;

	private PlayerRank.Ranks <RankLimit>k__BackingField;

	private int <Id>k__BackingField;

	private Games <Games>k__BackingField;

	private bool <IsPasswordProtected>k__BackingField;

	private int <Timer>k__BackingField;

	private bool <IsCheatingAllowed>k__BackingField;

	private GameType <GameType>k__BackingField;

	private long <PlayTime>k__BackingField;

	private readonly int <WonTeamIndex>k__BackingField;

	private int <TeamScore1>k__BackingField;

	private int <TeamScore2>k__BackingField;

	private List<RoundEvent> <RoundEvents>k__BackingField;

	public int Version
	{
		get
		{
			return <Version>k__BackingField;
		}
		private set
		{
			<Version>k__BackingField = value;
		}
	}

	public int OwnerId
	{
		get
		{
			return <OwnerId>k__BackingField;
		}
		private set
		{
			<OwnerId>k__BackingField = value;
		}
	}

	public string Name
	{
		get
		{
			return <Name>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int RoomThemeId
	{
		get
		{
			return <RoomThemeId>k__BackingField;
		}
		private set
		{
			<RoomThemeId>k__BackingField = value;
		}
	}

	public int[] PlayersDbIds
	{
		get
		{
			return <PlayersDbIds>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string[] PlayersNames
	{
		get
		{
			return <PlayersNames>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int[] PlayersRanksPoints
	{
		get
		{
			return <PlayersRanksPoints>k__BackingField;
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

	public bool[] PlayersRanksIsNew
	{
		get
		{
			return <PlayersRanksIsNew>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int[] PlayersActiveCardsBack
	{
		get
		{
			return <PlayersActiveCardsBack>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool[] PlayersVerified
	{
		get
		{
			return <PlayersVerified>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool[] PlayersSubscribed
	{
		get
		{
			return <PlayersSubscribed>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 88;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public PlayerRank.Ranks RankLimit
	{
		get
		{
			return <RankLimit>k__BackingField;
		}
		private set
		{
			<RankLimit>k__BackingField = value;
		}
	}

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

	public Games Games
	{
		get
		{
			return <Games>k__BackingField;
		}
		private set
		{
			<Games>k__BackingField = value;
		}
	}

	public bool IsPasswordProtected
	{
		get
		{
			return <IsPasswordProtected>k__BackingField;
		}
		private set
		{
			<IsPasswordProtected>k__BackingField = value;
		}
	}

	public int Timer
	{
		get
		{
			return <Timer>k__BackingField;
		}
		private set
		{
			<Timer>k__BackingField = value;
		}
	}

	public bool IsCheatingAllowed
	{
		get
		{
			return <IsCheatingAllowed>k__BackingField;
		}
		private set
		{
			<IsCheatingAllowed>k__BackingField = value;
		}
	}

	public GameType GameType
	{
		get
		{
			return <GameType>k__BackingField;
		}
		private set
		{
			<GameType>k__BackingField = value;
		}
	}

	public long PlayTime
	{
		get
		{
			return <PlayTime>k__BackingField;
		}
		private set
		{
			<PlayTime>k__BackingField = value;
		}
	}

	public int WonTeamIndex => <WonTeamIndex>k__BackingField;

	public int TeamScore1
	{
		get
		{
			return <TeamScore1>k__BackingField;
		}
		private set
		{
			<TeamScore1>k__BackingField = value;
		}
	}

	public int TeamScore2
	{
		get
		{
			return <TeamScore2>k__BackingField;
		}
		private set
		{
			<TeamScore2>k__BackingField = value;
		}
	}

	public List<RoundEvent> RoundEvents
	{
		get
		{
			return <RoundEvents>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 152;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public void SetTeamsScore(int teamScore1, int teamScore2)
	{
		<TeamScore1>k__BackingField = teamScore1;
		<TeamScore2>k__BackingField = teamScore2;
	}

	public void AddRoundEvent()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0085: Expected O, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 3024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = default(object);
		object obj3 = obj4 + 16;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4..ctor();
		List<object> list2 = (List<object>)(object)<RoundEvents>k__BackingField;
		int version = list2._version + 1;
		list2._version = version;
		object[] items = list2._items;
		bool flag = list2._size < items.Length;
		object obj5 = !flag;
		if (obj5 == null)
		{
			int size = list2._size + 1;
			list2._size = size;
			object obj6 = items + list2._size;
			object obj7 = obj6 + 32;
			obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list2.AddWithResize(obj4);
		}
	}

	public void AddReplayEvent(ReplayEvent replayEvent)
	{
		//IL_0011: Expected O, but got I
		//IL_004a: Expected O, but got I
		//IL_00a3: Expected O, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		List<object> list = (List<object>)(object)<RoundEvents>k__BackingField;
		object obj = (nint)0 + (nint)232;
		int index = list._size - 1;
		object obj2 = list.get_Item(index);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v5 (System.Object)+10]");
		List<object> list2 = (List<object>)0;
		int version = list2._version + 1;
		list2._version = version;
		object[] items = list2._items;
		bool flag = list2._size < items.Length;
		object obj3 = !flag;
		if (obj3 == null)
		{
			int size = list2._size + 1;
			list2._size = size;
			object obj4 = items + list2._size;
			object obj5 = obj4 + 32;
			obj5 = replayEvent;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list2.AddWithResize((object)replayEvent);
		}
	}

	public void AddReplayEvent(ReplayEvent replayEvent, int roundIndex, int replayEventIndex = 0)
	{
		//IL_0038: Expected O, but got I
		object obj = ((List<object>)(object)<RoundEvents>k__BackingField).get_Item(roundIndex);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5 (System.Object)+10]");
		((List<object>)0).Insert(replayEventIndex, replayEvent);
	}

	public void RemoveComments()
	{
		//IL_0340: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_002a: Expected O, but got I
		//IL_0036: Expected O, but got I
		//IL_0356: Expected I, but got O
		//IL_02c6: Expected I, but got O
		//IL_0278: Expected O, but got I4
		//IL_0077: Expected O, but got I
		//IL_0159: Expected O, but got I
		//IL_01ec: Expected O, but got I
		bool flag = <RoundEvents>k__BackingField == null;
		object obj = 152993792;
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)816;
			object obj3 = (nint)0 + (nint)3992;
			object obj4 = (nint)0 + (nint)3976;
			obj = (nint)0 + (nint)808;
			List<object>.Enumerator enumerator = ((List<object>)(object)<RoundEvents>k__BackingField).GetEnumerator();
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			object obj5 = default(object);
			object obj8 = default(object);
			while (true)
			{
				IL_034e:
				num = (nint)obj2;
				int num2;
				if (enumerator2.MoveNext())
				{
					if (obj5 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ stack_-68+10]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ stack_-68+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v12+18]");
							num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v12+18]");
							bool flag2 = (nint)0 >= (nint)1;
							object obj7 = obj8;
							if (!flag2)
							{
								continue;
							}
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ stack_-68+10]");
								if ((nint)0 == 0)
								{
									break;
								}
								num2--;
								obj8 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ stack_-68+10]");
								object obj9 = ((List<object>)0).get_Item(num2);
								if (obj9 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v28 (System.Object)+14]");
									bool flag3 = (nint)0 != 14;
									num = num2;
									if (!flag3)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ stack_-68+10]");
										if ((nint)0 == 0)
										{
											goto IL_0234;
										}
										obj8 = obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ stack_-68+10]");
										((List<object>)0).RemoveAt(num2);
										num = num2;
									}
									bool flag4 = num2 <= 0;
									obj7 = obj8;
									if (!flag4)
									{
										continue;
									}
									goto IL_034e;
								}
								goto IL_021e;
							}
							NullReferenceException ex = new NullReferenceException();
							obj8 = obj7;
							break;
						}
						NullReferenceException ex2 = new NullReferenceException();
						break;
					}
					NullReferenceException ex3 = new NullReferenceException();
					break;
				}
				enumerator2.Dispose();
				return;
				IL_021e:
				NullReferenceException ex4 = new NullReferenceException();
				num = num2;
				break;
				IL_0234:
				NullReferenceException ex5 = new NullReferenceException();
				num = num2;
				break;
			}
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			enumerator3 = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
		}
		NullReferenceException ex6 = new NullReferenceException();
		bool flag5 = num != 1;
		OutOfMemoryException ex7 = (OutOfMemoryException)(object)ex6;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj;
			enumerator3.Dispose();
			object obj10 = default(object);
			if (obj10 == null)
			{
				return;
			}
			ex7 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BD48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public GameReplay()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3096;
		<Version>k__BackingField = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 152;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	public unsafe GameReplay(int id, Games games, bool isPasswordProtected, int timer, bool isCheatingAllowed, GameType gameType, long playTime, int wonTeamIndex, int teamScore1, int teamScore2, int ownerId, string name, int roomThemeId, int[] playersDbIds, string[] playersNames, int[] playersRanksPoints, bool[] playersRanksIsNew, string[] playersTitles, int[] playersActiveCardsBack, bool[] playersVerified, bool[] playersSubscribed, PlayerRank.Ranks rankLimit, List<RoundEvent> roundEvents)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0054: Expected O, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0090: Expected O, but got I
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0104: Expected O, but got I
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_012e: Expected O, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0153: Expected O, but got I
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_017d: Expected O, but got I
		//IL_01ee: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 3096;
		<Version>k__BackingField = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = this + 152;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+1C]");
		<OwnerId>k__BackingField = 0;
		object obj5 = this + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+20]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+28]");
		<RoomThemeId>k__BackingField = 0;
		object obj6 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+30]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+38]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+40]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = this + 64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+48]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+58]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj11 = this + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+60]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj12 = this + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+68]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+78]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public GameReplay(Room gameRoom)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e82: Expected O, but got Unknown
		//IL_0ea6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eab: Expected O, but got Unknown
		//IL_01d4: Expected I, but got O
		//IL_01e4: Expected O, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0094: Expected O, but got I
		//IL_00be: Expected O, but got I4
		//IL_021f: Expected O, but got I
		//IL_0f36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3b: Expected O, but got Unknown
		//IL_0f41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f46: Expected O, but got Unknown
		//IL_035d: Expected O, but got I4
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_0f88: Expected O, but got I
		//IL_0f99: Expected O, but got I
		//IL_0fa9: Expected O, but got I
		//IL_0fcb: Expected O, but got I4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0151: Expected I8, but got I4
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_0443: Expected O, but got I4
		//IL_03a4: Expected O, but got I4
		//IL_029a: Expected O, but got I4
		//IL_1066: Expected O, but got I
		//IL_1077: Expected O, but got I
		//IL_1087: Expected O, but got I
		//IL_10a9: Expected O, but got I4
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fed: Expected O, but got Unknown
		//IL_1003: Expected O, but got I
		//IL_1014: Expected I, but got O
		//IL_1032: Expected O, but got I
		//IL_104d: Expected O, but got I4
		//IL_01af: Expected O, but got I4
		//IL_03d4: Expected O, but got I
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected O, but got Unknown
		//IL_048a: Expected O, but got I4
		//IL_02d5: Expected O, but got I
		//IL_02f8: Expected O, but got I4
		//IL_0300: Expected I, but got O
		//IL_05a3: Expected O, but got I
		//IL_05b3: Expected O, but got I
		//IL_05d5: Expected O, but got I4
		//IL_10c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cb: Expected O, but got Unknown
		//IL_10e1: Expected O, but got I
		//IL_10f2: Expected I, but got O
		//IL_1110: Expected O, but got I
		//IL_112b: Expected O, but got I4
		//IL_053c: Expected O, but got I
		//IL_054c: Expected O, but got I
		//IL_056e: Expected O, but got I4
		//IL_04ba: Expected O, but got I
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		//IL_06a4: Expected O, but got I4
		//IL_0605: Expected O, but got I4
		//IL_11c5: Expected O, but got I
		//IL_11d6: Expected O, but got I
		//IL_11e6: Expected O, but got I
		//IL_1208: Expected O, but got I4
		//IL_1147: Unknown result type (might be due to invalid IL or missing references)
		//IL_114c: Expected O, but got Unknown
		//IL_1162: Expected O, but got I
		//IL_1173: Expected I, but got O
		//IL_1191: Expected O, but got I
		//IL_11ac: Expected O, but got I4
		//IL_0635: Expected O, but got I
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected O, but got Unknown
		//IL_06eb: Expected O, but got I4
		//IL_0804: Expected O, but got I
		//IL_0814: Expected O, but got I
		//IL_0836: Expected O, but got I4
		//IL_1225: Unknown result type (might be due to invalid IL or missing references)
		//IL_122a: Expected O, but got Unknown
		//IL_1240: Expected O, but got I
		//IL_1251: Expected I, but got O
		//IL_126f: Expected O, but got I
		//IL_128a: Expected O, but got I4
		//IL_079d: Expected O, but got I
		//IL_07ad: Expected O, but got I
		//IL_07cf: Expected O, but got I4
		//IL_071b: Expected O, but got I
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected O, but got Unknown
		//IL_0866: Expected O, but got I4
		//IL_097f: Expected O, but got I
		//IL_098f: Expected O, but got I
		//IL_09b1: Expected O, but got I4
		//IL_12a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ab: Expected O, but got Unknown
		//IL_12c1: Expected O, but got I
		//IL_12d2: Expected I, but got O
		//IL_12f0: Expected O, but got I
		//IL_130b: Expected O, but got I4
		//IL_0918: Expected O, but got I
		//IL_0928: Expected O, but got I
		//IL_094a: Expected O, but got I4
		//IL_0896: Expected O, but got I
		//IL_0a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a44: Expected O, but got Unknown
		//IL_09e1: Expected O, but got I4
		//IL_0afa: Expected O, but got I
		//IL_0b0a: Expected O, but got I
		//IL_0b2c: Expected O, but got I4
		//IL_1327: Unknown result type (might be due to invalid IL or missing references)
		//IL_132c: Expected O, but got Unknown
		//IL_1342: Expected O, but got I
		//IL_1353: Expected I, but got O
		//IL_1371: Expected O, but got I
		//IL_138c: Expected O, but got I4
		//IL_0a93: Expected O, but got I
		//IL_0aa3: Expected O, but got I
		//IL_0ac5: Expected O, but got I4
		//IL_0a11: Expected O, but got I
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Expected O, but got Unknown
		//IL_0b5c: Expected O, but got I4
		//IL_13a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ad: Expected O, but got Unknown
		//IL_13c3: Expected O, but got I
		//IL_13d4: Expected I, but got O
		//IL_13f2: Expected O, but got I
		//IL_140d: Expected O, but got I4
		//IL_0c04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c09: Expected O, but got Unknown
		//IL_0c11: Expected I, but got O
		//IL_0c21: Expected O, but got I
		//IL_0b8c: Expected O, but got I
		//IL_0cb0: Expected O, but got I4
		//IL_144d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1452: Expected O, but got Unknown
		//IL_1479: Expected I, but got O
		//IL_1489: Expected O, but got I
		//IL_0c5c: Expected O, but got I
		//IL_0d3f: Expected O, but got I4
		//IL_14e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e6: Expected O, but got Unknown
		//IL_0ceb: Expected O, but got I
		//IL_0cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc2: Expected O, but got Unknown
		//IL_0ccb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd0: Expected O, but got Unknown
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6f: Expected O, but got Unknown
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected O, but got Unknown
		//IL_0d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d52: Expected O, but got Unknown
		//IL_0d5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5f: Expected O, but got Unknown
		//IL_0d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6d: Expected O, but got Unknown
		//IL_0e41: Expected O, but got I4
		//IL_0cf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfe: Expected O, but got Unknown
		//IL_0d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0c: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3096;
		object obj2 = typeof(RegisteredWaitHandle) + 1376;
		<Version>k__BackingField = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = this + 152;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		<OwnerId>k__BackingField = SFSKammelnaRoomExtensions.GetRoomOwnerId(gameRoom);
		string text2 = default(string);
		nint num2;
		object obj8;
		if (GameTypeExtensions.IsTournament(SFSKammelnaRoomExtensions.GetGameType(gameRoom)))
		{
			object obj4 = typeof(Queue<string>) + 872;
			object obj5 = (nint)0 + (nint)2248;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v185+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
			TournamentData tournament = tournamentMatchInfo.Tournament;
			int matchRound = TournamentMath.GetMatchRound(tournamentMatchInfo.<MatchId>k__BackingField, tournament.<Size>k__BackingField);
			int numberOfRounds = TournamentMath.GetNumberOfRounds(tournament.<Size>k__BackingField);
			LocalizableText tournamentRoundName = TournamentUtil.GetTournamentRoundName(matchRound, numberOfRounds);
			long num = numberOfRounds - matchRound;
			object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			string text;
			if (num < 3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v113+E4]");
				if ((object)((nint)0 != 0) == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				text = LocalizationUtil.Localize(tournamentRoundName.Text);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v113+E4]");
				if ((object)((nint)0 != 0) == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				text = LocalizationUtil.Localize(tournamentRoundName.Text, num);
			}
			text2 = tournamentMatchInfo.Tournament.<Name>k__BackingField + (string)((nint)0 + (nint)3488) + text;
			obj8 = 0;
			num2 = (nint)text;
			goto IL_0f27;
		}
		nint num3 = (nint)gameRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v104 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v104 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0260;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v104 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X10_v19-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_0260;
		}
		object obj11 = (object)(num3 + (object)(obj10 + 1)) + 312;
		goto IL_0efd;
		IL_0f27:
		object obj12 = typeof(DebugUI.BitField) + 4016;
		object obj13 = this + 24;
		obj13 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int roomThemeID = SFSKammelnaRoomExtensions.GetRoomThemeID(gameRoom);
		PlayerInfo[] playersInfo = SFSKammelnaRoomExtensions.GetPlayersInfo(gameRoom);
		object obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v21+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj12;
		}
		object obj15 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v21+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v95+8]");
		Func<object, int> selector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v95+8]");
		bool flag = (nint)0 == 0;
		object obj17 = !flag;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v21+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj18 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v101+B8]");
				obj16 = 0;
			}
			object obj19 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2680;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj20 = (nint)0 + (nint)1520;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj16, (IntPtr)obj20);
			object obj21 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v100+B8]");
			object obj22 = (nint)0 + (nint)8;
			obj22 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj8 = 0;
			selector = func;
		}
		int[] array = Enumerable.ToArray(Enumerable.Select(playersInfo, selector));
		object obj23 = this + 40;
		obj23 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj24 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v30+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj12;
		}
		object obj25 = (nint)0 + (nint)3784;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v30+B8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v87+10]");
		Func<object, object> selector2 = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v87+10]");
		bool flag2 = (nint)0 == 0;
		object obj27 = !flag2;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v30+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj28 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v93+B8]");
				obj26 = 0;
			}
			object obj29 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2704;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj30 = (nint)0 + (nint)1528;
			Func<object, object> func2 = default(Func<object, object>);
			func2..ctor(obj26, (IntPtr)obj30);
			object obj31 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v92+B8]");
			object obj32 = (nint)0 + (nint)16;
			obj32 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj8 = 0;
			selector2 = func2;
		}
		object[] array2 = Enumerable.ToArray(Enumerable.Select(playersInfo, selector2));
		object obj33 = this + 48;
		obj33 = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj34 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v149+E4]");
		object obj35;
		Func<object, int> selector3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v149+B8]");
			obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v77+18]");
			selector3 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v77+18]");
			if ((object)((nint)0 != 0) == null)
			{
				goto IL_05e3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj34 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v149+B8]");
			obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v77+18]");
			selector3 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v77+18]");
			if ((object)((nint)0 != 0) == null)
			{
				goto IL_05e3;
			}
		}
		goto IL_063a;
		IL_0d2c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj36 = 10;
		goto IL_14d2;
		IL_09bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v120+E4]");
		object obj38;
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj37 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ X8_v53+B8]");
			obj38 = 0;
		}
		object obj39 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj40 = (nint)0 + (nint)1560;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj38, (IntPtr)obj40);
		object obj41 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v52+B8]");
		object obj42 = (nint)0 + (nint)48;
		obj42 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj8 = 0;
		Func<object, bool> selector4 = func3;
		goto IL_0a16;
		IL_0b3a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X0_v110+E4]");
		object obj44;
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj43 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v42+B8]");
			obj44 = 0;
		}
		object obj45 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj46 = (nint)0 + (nint)1568;
		Func<object, bool> func4 = default(Func<object, bool>);
		func4..ctor(obj44, (IntPtr)obj46);
		object obj47 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v41+B8]");
		object obj48 = (nint)0 + (nint)56;
		obj48 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj8 = 0;
		Func<object, bool> selector5 = func4;
		goto IL_0b91;
		IL_14d2:
		object obj49 = typeof(DataRelation) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1015 @ X0_v83] (should have been resolved before IL gen)");
		bool flag3 = default(bool);
		<IsPasswordProtected>k__BackingField = flag3;
		int timeoutInterval = SFSKammelnaRoomExtensions.GetTimeoutInterval(gameRoom);
		<Timer>k__BackingField = timeoutInterval;
		bool flag4 = SFSKammelnaRoomExtensions.IsCheatingAllowed(gameRoom);
		<IsCheatingAllowed>k__BackingField = flag4;
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(gameRoom);
		<GameType>k__BackingField = gameType;
		object obj51;
		object obj50 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ X0_v92+E4]");
		DateTime dateTime;
		DateTime dateTime2;
		if ((nint)0 != 0)
		{
			dateTime = DateTime.Now;
			object obj52 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X8_v29+E4]");
			bool flag5 = (nint)0 == 0;
			dateTime2 = dateTime;
			if (!flag5)
			{
				goto IL_0de7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			dateTime = DateTime.Now;
			object obj52 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X8_v29+E4]");
			object obj53 = (nint)0 != 0;
			dateTime2 = dateTime;
			if (obj53 != null)
			{
				goto IL_0de7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		dateTime = dateTime2;
		goto IL_0de7;
		IL_0260:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 1;
		goto IL_0efd;
		IL_0efd:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v355 @ X0_v179] (should have been resolved before IL gen)");
		goto IL_0f27;
		IL_0c9d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj36 = 0;
		goto IL_143e;
		IL_0de7:
		<PlayTime>k__BackingField = DateTimeUtil.ToEpochMilli(dateTime);
		return;
		IL_0a16:
		bool[] array3 = Enumerable.ToArray(Enumerable.Select(playersInfo, selector4));
		object obj54 = this + 80;
		obj54 = array3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj55 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X0_v110+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X0_v110+B8]");
			obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v36+38]");
			selector5 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v36+38]");
			if ((object)((nint)0 != 0) == null)
			{
				goto IL_0b3a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj55 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X0_v110+B8]");
			obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v36+38]");
			selector5 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v36+38]");
			if ((object)((nint)0 != 0) == null)
			{
				goto IL_0b3a;
			}
		}
		goto IL_0b91;
		IL_0844:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X0_v130+E4]");
		object obj57;
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj56 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v64+B8]");
			obj57 = 0;
		}
		object obj58 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj59 = (nint)0 + (nint)1552;
		Func<object, int> func5 = default(Func<object, int>);
		func5..ctor(obj57, (IntPtr)obj59);
		object obj60 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v63+B8]");
		object obj61 = (nint)0 + (nint)40;
		obj61 = func5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj8 = 0;
		Func<object, int> selector6 = func5;
		goto IL_089b;
		IL_0b91:
		object obj62;
		obj36 = obj62;
		bool[] array4 = Enumerable.ToArray(Enumerable.Select(playersInfo, selector5));
		object obj63 = this + 88;
		obj63 = array4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PlayerRank.Ranks rankLimit = SFSKammelnaRoomExtensions.GetRankLimit(gameRoom);
		object obj64 = typeof(RegisteredWaitHandle) + 1376;
		nint num4 = (nint)gameRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0c9d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj66 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X10_v12-8]");
			if (0 == (nint)obj64)
			{
				break;
			}
			obj66 += 16;
			obj65--;
			if ((nint)obj65 != 1)
			{
				continue;
			}
			goto IL_0c9d;
		}
		object obj67 = (object)(num4 + obj66) + 312;
		goto IL_143e;
		IL_089b:
		int[] array5 = Enumerable.ToArray(Enumerable.Select(playersInfo, selector6));
		object obj68 = this + 72;
		obj68 = array5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj69 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v120+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v120+B8]");
			obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X8_v47+30]");
			selector4 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X8_v47+30]");
			if ((object)((nint)0 != 0) == null)
			{
				goto IL_09bf;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj69 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v120+B8]");
			obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X8_v47+30]");
			selector4 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X8_v47+30]");
			if ((object)((nint)0 != 0) == null)
			{
				goto IL_09bf;
			}
		}
		goto IL_0a16;
		IL_063a:
		int[] array6 = Enumerable.ToArray(Enumerable.Select(playersInfo, selector3));
		object obj70 = this + 56;
		obj70 = array6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj71 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v47+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj71 = obj12;
		}
		obj62 = (nint)0 + (nint)3760;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v47+B8]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v68+20]");
		Func<object, bool> selector7 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v68+20]");
		bool flag6 = (nint)0 == 0;
		object obj73 = !flag6;
		if (obj73 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v47+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj74 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v74+B8]");
				obj72 = 0;
			}
			object obj75 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj76 = (nint)0 + (nint)1544;
			Func<object, bool> func6 = default(Func<object, bool>);
			func6..ctor(obj72, (IntPtr)obj76);
			object obj77 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X8_v73+B8]");
			object obj78 = (nint)0 + (nint)32;
			obj78 = func6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj8 = 0;
			selector7 = func6;
		}
		bool[] array7 = Enumerable.ToArray(Enumerable.Select(playersInfo, selector7));
		object obj79 = this + 64;
		obj79 = array7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj80 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X0_v130+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X0_v130+B8]");
			obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v58+28]");
			selector6 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v58+28]");
			if ((object)((nint)0 != 0) == null)
			{
				goto IL_0844;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj80 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X0_v130+B8]");
			obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v58+28]");
			selector6 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v58+28]");
			if ((object)((nint)0 != 0) == null)
			{
				goto IL_0844;
			}
		}
		goto IL_089b;
		IL_143e:
		obj51 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v947 @ X0_v80] (should have been resolved before IL gen)");
		int num5 = default(int);
		<Id>k__BackingField = num5;
		<Games>k__BackingField = Games.Baloot;
		nint num6 = (nint)gameRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0d2c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj82 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X10_v7-8]");
			if (0 == (nint)obj64)
			{
				break;
			}
			obj82 += 16;
			obj81--;
			if ((nint)obj81 != 1)
			{
				continue;
			}
			goto IL_0d2c;
		}
		object obj83 = (object)(num6 + (object)(obj82 + 10)) + 312;
		goto IL_14d2;
		IL_05e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v149+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj84 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v83+B8]");
			obj35 = 0;
		}
		object obj85 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj86 = (nint)0 + (nint)1536;
		Func<object, int> func7 = default(Func<object, int>);
		func7..ctor(obj35, (IntPtr)obj86);
		object obj87 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v82+B8]");
		object obj88 = (nint)0 + (nint)24;
		obj88 = func7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj8 = 0;
		selector3 = func7;
		goto IL_063a;
	}

	public GameReplay(GameReplay gameReplay)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3096;
		<Version>k__BackingField = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 152;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		<OwnerId>k__BackingField = gameReplay.<OwnerId>k__BackingField;
		object obj3 = this + 24;
		obj3 = gameReplay.<Name>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<RoomThemeId>k__BackingField = gameReplay.<RoomThemeId>k__BackingField;
		object obj4 = this + 40;
		obj4 = gameReplay.<PlayersDbIds>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = this + 48;
		obj5 = gameReplay.<PlayersNames>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = this + 56;
		obj6 = gameReplay.<PlayersRanksPoints>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = this + 64;
		obj7 = gameReplay.<PlayersRanksIsNew>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = this + 72;
		obj8 = gameReplay.<PlayersActiveCardsBack>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = this + 80;
		obj9 = gameReplay.<PlayersVerified>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = this + 88;
		obj10 = gameReplay.<PlayersSubscribed>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = gameReplay.<RankLimit>k__BackingField;
		_ = gameReplay.<Games>k__BackingField;
		_ = gameReplay.<IsPasswordProtected>k__BackingField;
		_ = gameReplay.<Timer>k__BackingField;
		_ = gameReplay.<IsCheatingAllowed>k__BackingField;
		_ = gameReplay.<GameType>k__BackingField;
		_ = gameReplay.<PlayTime>k__BackingField;
		_ = gameReplay.<WonTeamIndex>k__BackingField;
		_ = gameReplay.<TeamScore2>k__BackingField;
		_ = gameReplay.<RoundEvents>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
