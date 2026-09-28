using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Jackaroo;
using Kammelna.Server;
using KammelnaOffline.Baloot;
using KammelnaOffline.Baloot.Tutorial;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Sfs2X.Entities.Variables;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public static class SFSKammelnaRoomExtensions
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<PlayerInfo, PlayerRank.Ranks> <>9__15_0;

		public static Func<PlayerRank.Ranks, bool> <>9__15_1;

		public static Func<PlayerRank.Ranks, int> <>9__15_2;

		public static Func<PlayerInfo, PlayerRank.Ranks> <>9__16_0;

		public static Func<PlayerRank.Ranks, bool> <>9__16_1;

		public static Func<PlayerRank.Ranks, int> <>9__16_2;

		public static Func<PlayerInfo, PlayerRank.Ranks> <>9__17_0;

		public static Func<PlayerRank.Ranks, bool> <>9__17_1;

		public static Func<PlayerRank.Ranks, int> <>9__17_2;

		public static Func<PlayerInfo, PlayerRank.Ranks> <>9__17_3;

		public static Func<PlayerRank.Ranks, bool> <>9__17_4;

		public static Func<bool, bool> <>9__23_0;

		public static Func<double, double, Vector2> <>9__57_0;

		public static Func<ISFSObject, MatchData> <>9__58_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal PlayerRank.Ranks <GetHighestRankInRoom>b__15_0(PlayerInfo p)
		{
			//IL_0064: Expected I4, but got O
			if (p != null)
			{
				PlayerRank <PlayerRank>k__BackingField = p.<PlayerRank>k__BackingField;
				if (p.<PlayerRank>k__BackingField != null)
				{
					return <PlayerRank>k__BackingField.<Rank>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (PlayerRank.Ranks)ex;
		}

		internal bool <GetHighestRankInRoom>b__15_1(PlayerRank.Ranks r)
		{
			bool flag = r == PlayerRank.Ranks.AI;
			return !flag;
		}

		internal int <GetHighestRankInRoom>b__15_2(PlayerRank.Ranks r)
		{
			return (int)r;
		}

		internal PlayerRank.Ranks <GetLowestRankInRoom>b__16_0(PlayerInfo p)
		{
			//IL_0064: Expected I4, but got O
			if (p != null)
			{
				PlayerRank <PlayerRank>k__BackingField = p.<PlayerRank>k__BackingField;
				if (p.<PlayerRank>k__BackingField != null)
				{
					return <PlayerRank>k__BackingField.<Rank>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (PlayerRank.Ranks)ex;
		}

		internal bool <GetLowestRankInRoom>b__16_1(PlayerRank.Ranks r)
		{
			bool flag = r == PlayerRank.Ranks.AI;
			return !flag;
		}

		internal int <GetLowestRankInRoom>b__16_2(PlayerRank.Ranks r)
		{
			return (int)r;
		}

		internal PlayerRank.Ranks <GetAverageRank>b__17_0(PlayerInfo p)
		{
			//IL_0064: Expected I4, but got O
			if (p != null)
			{
				PlayerRank <PlayerRank>k__BackingField = p.<PlayerRank>k__BackingField;
				if (p.<PlayerRank>k__BackingField != null)
				{
					return <PlayerRank>k__BackingField.<Rank>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (PlayerRank.Ranks)ex;
		}

		internal bool <GetAverageRank>b__17_1(PlayerRank.Ranks r)
		{
			bool flag = r == PlayerRank.Ranks.AI;
			return !flag;
		}

		internal int <GetAverageRank>b__17_2(PlayerRank.Ranks s)
		{
			return (int)s;
		}

		internal PlayerRank.Ranks <GetAverageRank>b__17_3(PlayerInfo p)
		{
			//IL_0064: Expected I4, but got O
			if (p != null)
			{
				PlayerRank <PlayerRank>k__BackingField = p.<PlayerRank>k__BackingField;
				if (p.<PlayerRank>k__BackingField != null)
				{
					return <PlayerRank>k__BackingField.<Rank>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (PlayerRank.Ranks)ex;
		}

		internal bool <GetAverageRank>b__17_4(PlayerRank.Ranks r)
		{
			bool flag = r == PlayerRank.Ranks.AI;
			return !flag;
		}

		internal bool <GetJoinableSeatsCount>b__23_0(bool js)
		{
			return js;
		}

		internal Vector2 <GetCaptchaPath>b__57_0(double x, double y)
		{
			return (Vector2)this;
		}

		internal MatchData <GetTournamentMatches>b__58_0(ISFSObject o)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3856;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			MatchData matchData = default(MatchData);
			matchData..ctor(o);
			return matchData;
		}
	}

	private sealed class <>c__DisplayClass58_0
	{
		public List<MatchData> matches;

		internal MatchData <GetTournamentMatches>b__1(int id)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0045: Expected O, but got I
			//IL_0065: Expected I, but got O
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (obj2 != null)
			{
				object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
				object obj4 = (nint)0 + (nint)1424;
				object obj5 = (nint)0 + (nint)1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj4);
				MatchData matchData = (MatchData)Enumerable.FirstOrDefault(matches, func);
				if (matchData != null)
				{
					return matchData;
				}
				object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3856;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
				MatchData matchData2 = default(MatchData);
				matchData2..ctor(0);
				return matchData2;
			}
			return (MatchData)(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass58_1
	{
		public int id;

		internal bool <GetTournamentMatches>b__2(MatchData data)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (data != null)
			{
				object obj = data.<ID>k__BackingField - id;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass60_0
	{
		public int matchId;

		internal bool <GetTournamentMatch>b__0(MatchData matchData)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (matchData != null)
			{
				object obj = matchData.<ID>k__BackingField - matchId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public static int GetTeamScore(Room room, int teamIndex)
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0479: Expected I4, but got O
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0136: Expected I, but got O
		//IL_0146: Expected O, but got I
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_033c: Expected O, but got I
		//IL_0356: Expected O, but got I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_023f: Expected O, but got I
		//IL_0181: Expected O, but got I
		//IL_03dc: Expected O, but got I
		//IL_039c: Expected O, but got I4
		//IL_02b1: Expected O, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0065: Expected I, but got O
		//IL_0075: Expected O, but got I
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_043f: Expected O, but got I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		object obj;
		object obj4;
		object obj6;
		nint num;
		object obj18;
		object obj10;
		object obj12;
		if (teamIndex != 2)
		{
			if (teamIndex != 1)
			{
				obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v17+E4]");
				if ((nint)0 != 0)
				{
					object obj3 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 160;
					obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DED]");
					object obj5 = (nint)0 & (nint)1;
					bool flag = obj5 == null;
					obj6 = obj3;
					if (!flag)
					{
						goto IL_0264;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 160;
					obj4 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DED]");
					object obj8 = (nint)0 & (nint)1;
					bool flag2 = obj8 == null;
					object obj9 = !flag2;
					obj6 = obj7;
					if (obj9 != null)
					{
						goto IL_0264;
					}
				}
				_ = 1;
				obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v38+E4]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				obj4 = obj6;
				obj12 = obj10;
				if (obj11 != null)
				{
					goto IL_02a1;
				}
				goto IL_03ba;
			}
			object obj13 = "startPosition" + 2144;
			object obj14 = obj13;
			if (room != null)
			{
				object obj15 = typeof(RegisteredWaitHandle) + 1376;
				object obj16 = obj15;
				num = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01c2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				obj18 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X10_v2-8]");
					if (0 == (nint)obj16)
					{
						break;
					}
					obj18 += 16;
					obj17--;
					if ((nint)obj17 != 1)
					{
						continue;
					}
					goto IL_01c2;
				}
				goto IL_02d7;
			}
		}
		else
		{
			object obj19 = "startPosition" + 2160;
			object obj14 = obj19;
			if (room != null)
			{
				object obj20 = typeof(RegisteredWaitHandle) + 1376;
				object obj16 = obj20;
				nint num2 = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01c2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				obj18 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X10_v2-8]");
					bool flag4 = 0 == (nint)obj16;
					num = num2;
					if (flag4)
					{
						break;
					}
					obj18 += 16;
					obj21--;
					if ((nint)obj21 != 1)
					{
						continue;
					}
					goto IL_01c2;
				}
				goto IL_02d7;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0264:
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v38+E4]");
		bool flag5 = (nint)0 == 0;
		obj12 = obj10;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_02a1;
		}
		goto IL_03ba;
		IL_0401:
		object obj22 = typeof(DataRelation) + 856;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X0_v19+E4]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(obj4);
		return 0;
		IL_02d7:
		object obj25 = obj18 + 31;
		object obj26 = num + obj25;
		object obj27 = obj26 + 312;
		goto IL_0520;
		IL_01c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0520;
		IL_0520:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v425 @ X0_v2] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
		IL_02d1:
		return 0;
		IL_02a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v38+B8]");
		object obj28 = 0;
		if ((nint)obj28 < 2)
		{
			goto IL_02d1;
		}
		goto IL_0401;
		IL_03ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v26+B8]");
		object obj30 = 0;
		bool flag7 = (nint)obj30 < 2;
		obj4 = obj6;
		if (flag7)
		{
			goto IL_02d1;
		}
		goto IL_0401;
	}

	public static PlayerInfo[] GetPlayersInfo(Room room)
	{
		//IL_030d: Expected O, but got I4
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0048: Expected I, but got O
		//IL_0058: Expected O, but got I
		//IL_038d: Expected I, but got O
		//IL_00ee: Expected I, but got O
		//IL_00fe: Expected O, but got I
		//IL_0127: Expected O, but got I
		//IL_0093: Expected O, but got I
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0169: Expected O, but got I
		//IL_0175: Expected O, but got I
		//IL_017d: Expected I, but got O
		//IL_018d: Expected O, but got I
		//IL_021c: Expected O, but got I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_025a: Expected I, but got O
		//IL_026a: Expected O, but got I
		//IL_028e: Expected O, but got I4
		//IL_029e: Expected O, but got I
		//IL_01c8: Expected O, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DC6]");
		nint num = 0;
		bool flag = room == null;
		object obj = 152981504;
		object obj6 = default(object);
		object obj10;
		NullReferenceException ex = default(NullReferenceException);
		object obj12;
		if (!flag)
		{
			object obj2 = typeof(RegisteredWaitHandle) + 1376;
			object obj3 = "not" + 4000;
			obj = obj3;
			nint num2 = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00dc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X10_v13-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj6 = obj5 + 16;
				obj4--;
				bool flag2 = (nint)obj4 != 1;
				obj5 = obj6;
				if (flag2)
				{
					continue;
				}
				goto IL_00dc;
			}
			object obj7 = obj5 + 31;
			object obj8 = num2 + obj7;
			object obj9 = obj8 + 312;
			num = (nint)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v18+8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v248 @ X0_v18] (should have been resolved before IL gen)");
			bool flag3 = ex == null;
			object obj11 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v18+8]");
			obj12 = 0;
			obj6 = obj5;
			if (obj11 != null)
			{
				goto IL_0135;
			}
		}
		goto IL_02b4;
		IL_02b4:
		ex = new NullReferenceException();
		goto IL_02c2;
		IL_0135:
		object obj13 = typeof(UsageHint) + 664;
		obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1664;
		object obj14 = (nint)0 + (nint)560;
		object obj15 = (nint)0 + (nint)448;
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0209;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj13;
			obj12 = obj10;
			if (flag4)
			{
				break;
			}
			obj6 += 16;
			obj16--;
			if ((nint)obj16 != 1)
			{
				continue;
			}
			goto IL_0209;
		}
		goto IL_02c2;
		IL_02c2:
		object obj17 = obj6 + 8;
		object obj18 = num + obj17;
		object obj19 = obj18 + 312;
		goto IL_036b;
		IL_036b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v231 @ X8_v3] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)null, (IntPtr)obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301FE48");
		PlayerInfo[] result = default(PlayerInfo[]);
		return result;
		IL_0209:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj12 = 8;
		object obj20 = default(object);
		obj19 = obj20;
		goto IL_036b;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj21 = default(object);
		num = (nint)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v15+8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ X0_v15] (should have been resolved before IL gen)");
		bool flag5 = ex == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v15+8]");
		obj12 = 0;
		if (!flag5)
		{
			goto IL_0135;
		}
		goto IL_02b4;
	}

	public static GameType GetGameType(Room room)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object obj = "getSecondRescanTask" + 2104;
		object obj2 = (nint)0 + (nint)328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F620");
		GameType result = default(GameType);
		return result;
	}

	public static bool IsPrivate(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "placementId" + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E23]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, defaultValue: false);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static string GetPassword(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "not" + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E24]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1D]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1D]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1D]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1D]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, (string)null);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static string GetPinMessage(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "placementId" + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E25]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1D]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1D]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1D]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1D]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, (string)null);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static bool IsChatEnabled(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2544;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E26]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, defaultValue: true);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static bool IsCheatingAllowed(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E27]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, defaultValue: false);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static int GetTimeoutInterval(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "startPosition" + 3280;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E28]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static long GetGameID(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_02b2: Expected I8, but got I4
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "getSecondRescanTask" + 1584;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E29]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E20]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E20]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E20]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E20]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0L);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static int GetRoomThemeID(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "placementId" + 2112;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E2A]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static int GetCardbackID(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2496;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E2B]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static bool HasTheme(Room room)
	{
		//IL_006d: Expected O, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected I4, but got Unknown
		int roomThemeID = GetRoomThemeID(room);
		bool flag = roomThemeID < 0;
		bool flag2 = roomThemeID == 0;
		int num = roomThemeID ^ roomThemeID;
		int num2 = roomThemeID & num;
		bool flag3 = num2 < 0;
		bool flag4 = flag == flag3;
		object obj = !flag2;
		return (byte)((flag4 & obj) ? 1 : 0) != 0;
	}

	public static PlayerRank.Ranks GetRankLimit(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "placementId" + 2064;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E2C]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return (PlayerRank.Ranks)SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static bool QualifyRankLimit(Room room, User user)
	{
		//IL_00b9: Expected I4, but got O
		//IL_0049: Expected O, but got I4
		//IL_006a: Expected O, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(user);
		if (rank != null)
		{
			PlayerRank.Ranks rankLimit = GetRankLimit(room);
			object obj = rank.<Rank>k__BackingField - rankLimit;
			bool flag = (nint)obj < 0;
			object obj2 = rank.<Rank>k__BackingField ^ rankLimit;
			object obj3 = rank.<Rank>k__BackingField ^ obj;
			object obj4 = obj2 & obj3;
			bool flag2 = (nint)obj4 < 0;
			return flag == flag2;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static PlayerRank.Ranks GetHighestRankInRoom(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_00ae: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_0199: Expected O, but got I
		//IL_01a9: Expected O, but got I
		//IL_01b9: Expected O, but got I
		//IL_01db: Expected O, but got I4
		//IL_0315: Expected O, but got I
		//IL_0325: Expected O, but got I
		//IL_0335: Expected O, but got I
		//IL_0357: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		//IL_03ff: Expected O, but got I4
		//IL_029a: Expected O, but got I
		//IL_02aa: Expected O, but got I
		//IL_02ba: Expected O, but got I
		//IL_02dc: Expected O, but got I4
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		//IL_04cd: Expected O, but got I
		//IL_04de: Expected I, but got O
		//IL_04fc: Expected O, but got I
		//IL_0517: Expected O, but got I4
		//IL_05cf: Expected O, but got I
		//IL_05df: Expected O, but got I
		//IL_0601: Expected O, but got I4
		//IL_038f: Expected O, but got I4
		//IL_024b: Expected O, but got I
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected O, but got Unknown
		//IL_055e: Expected O, but got I
		//IL_056f: Expected I, but got O
		//IL_058d: Expected O, but got I
		//IL_05a8: Expected O, but got I4
		//IL_0446: Expected O, but got I4
		//IL_03bf: Expected O, but got I
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected O, but got Unknown
		//IL_0639: Expected O, but got I
		//IL_064a: Expected I, but got O
		//IL_0668: Expected O, but got I
		//IL_0476: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2472;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DC8]");
		object obj3 = (nint)0 & (nint)1;
		PlayerInfo[] array;
		PlayerInfo[] array2;
		object obj4;
		if (obj3 != null)
		{
			PlayerInfo[] playersInfo = GetPlayersInfo(room);
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v33+E4]");
			bool flag = (nint)0 == 0;
			array = playersInfo;
			object obj5 = obj4;
			array2 = playersInfo;
			if (!flag)
			{
				goto IL_00a2;
			}
		}
		else
		{
			_ = 1;
			PlayerInfo[] playersInfo2 = GetPlayersInfo(room);
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v33+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			array = playersInfo2;
			object obj5 = obj4;
			array2 = playersInfo2;
			if (obj6 != null)
			{
				goto IL_00a2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)3800;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v33+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v28+8]");
		Func<object, System.Int32Enum> selector = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v28+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		array = array2;
		if (obj9 == null)
		{
			goto IL_01f9;
		}
		goto IL_0250;
		IL_036d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v23+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		object obj13;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v23+B8]");
			obj13 = 0;
		}
		object obj14 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)1360;
		Func<System.Int32Enum, bool> func = default(Func<System.Int32Enum, bool>);
		func..ctor(obj13, (IntPtr)obj15);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v22+B8]");
		object obj17 = (nint)0 + (nint)16;
		obj17 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj18 = 0;
		Func<System.Int32Enum, bool> predicate = func;
		object obj20;
		object obj19 = obj20;
		goto IL_03c4;
		IL_03c4:
		IEnumerable<System.Int32Enum> source2;
		IEnumerable<System.Int32Enum> source = Enumerable.Where(source2, predicate);
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj22 = !flag5;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v9+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v8+18]");
		Func<System.Int32Enum, int> keySelector = (Func<System.Int32Enum, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v8+18]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v9+E4]");
			bool flag7 = (nint)0 == 0;
			object obj25 = !flag7;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj26 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v14+B8]");
				obj23 = 0;
			}
			object obj27 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 512;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj28 = (nint)0 + (nint)1368;
			Func<System.Int32Enum, int> func2 = default(Func<System.Int32Enum, int>);
			func2..ctor(obj23, (IntPtr)obj28);
			object obj29 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v13+B8]");
			object obj30 = (nint)0 + (nint)24;
			obj30 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			keySelector = func2;
		}
		IOrderedEnumerable<System.Int32Enum> source3 = Enumerable.OrderByDescending(source, keySelector);
		return (PlayerRank.Ranks)Enumerable.FirstOrDefault(source3);
		IL_01f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v33+E4]");
		bool flag8 = (nint)0 == 0;
		object obj31 = !flag8;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj32 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v34+B8]");
			obj8 = 0;
		}
		object obj33 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj34 = (nint)0 + (nint)1352;
		Func<object, System.Int32Enum> func3 = default(Func<object, System.Int32Enum>);
		func3..ctor(obj8, (IntPtr)obj34);
		object obj35 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v33+B8]");
		object obj36 = (nint)0 + (nint)8;
		obj36 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj18 = 0;
		selector = func3;
		obj10 = obj7;
		array = array2;
		goto IL_0250;
		IL_00a2:
		obj10 = (nint)0 + (nint)3800;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v33+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v28+8]");
		selector = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v28+8]");
		bool flag9 = (nint)0 == 0;
		object obj37 = !flag9;
		if (obj37 == null)
		{
			obj7 = obj10;
			array2 = array;
			goto IL_01f9;
		}
		goto IL_0250;
		IL_0250:
		source2 = Enumerable.Select(array, selector);
		object obj38 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v23+E4]");
		if ((nint)0 != 0)
		{
			obj19 = (nint)0 + (nint)3928;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v23+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17+10]");
			predicate = (Func<System.Int32Enum, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17+10]");
			bool flag10 = (nint)0 == 0;
			object obj39 = !flag10;
			if (obj39 == null)
			{
				obj20 = obj19;
				goto IL_036d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj38 = obj2;
			obj20 = (nint)0 + (nint)3928;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v23+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17+10]");
			predicate = (Func<System.Int32Enum, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17+10]");
			bool flag11 = (nint)0 == 0;
			object obj40 = !flag11;
			obj19 = obj20;
			if (obj40 == null)
			{
				goto IL_036d;
			}
		}
		goto IL_03c4;
	}

	public static PlayerRank.Ranks GetLowestRankInRoom(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_00ae: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_0199: Expected O, but got I
		//IL_01a9: Expected O, but got I
		//IL_01b9: Expected O, but got I
		//IL_01db: Expected O, but got I4
		//IL_0315: Expected O, but got I
		//IL_0325: Expected O, but got I
		//IL_0335: Expected O, but got I
		//IL_0357: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		//IL_03ff: Expected O, but got I4
		//IL_029a: Expected O, but got I
		//IL_02aa: Expected O, but got I
		//IL_02ba: Expected O, but got I
		//IL_02dc: Expected O, but got I4
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		//IL_04cd: Expected O, but got I
		//IL_04de: Expected I, but got O
		//IL_04fc: Expected O, but got I
		//IL_0517: Expected O, but got I4
		//IL_05cf: Expected O, but got I
		//IL_05df: Expected O, but got I
		//IL_0601: Expected O, but got I4
		//IL_038f: Expected O, but got I4
		//IL_024b: Expected O, but got I
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected O, but got Unknown
		//IL_055e: Expected O, but got I
		//IL_056f: Expected I, but got O
		//IL_058d: Expected O, but got I
		//IL_05a8: Expected O, but got I4
		//IL_0446: Expected O, but got I4
		//IL_03bf: Expected O, but got I
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected O, but got Unknown
		//IL_0639: Expected O, but got I
		//IL_064a: Expected I, but got O
		//IL_0668: Expected O, but got I
		//IL_0476: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2472;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DC9]");
		object obj3 = (nint)0 & (nint)1;
		PlayerInfo[] array;
		PlayerInfo[] array2;
		object obj4;
		if (obj3 != null)
		{
			PlayerInfo[] playersInfo = GetPlayersInfo(room);
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v33+E4]");
			bool flag = (nint)0 == 0;
			array = playersInfo;
			object obj5 = obj4;
			array2 = playersInfo;
			if (!flag)
			{
				goto IL_00a2;
			}
		}
		else
		{
			_ = 1;
			PlayerInfo[] playersInfo2 = GetPlayersInfo(room);
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v33+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			array = playersInfo2;
			object obj5 = obj4;
			array2 = playersInfo2;
			if (obj6 != null)
			{
				goto IL_00a2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)3800;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v33+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v28+20]");
		Func<object, System.Int32Enum> selector = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v28+20]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		array = array2;
		if (obj9 == null)
		{
			goto IL_01f9;
		}
		goto IL_0250;
		IL_036d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v23+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		object obj13;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v23+B8]");
			obj13 = 0;
		}
		object obj14 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)1392;
		Func<System.Int32Enum, bool> func = default(Func<System.Int32Enum, bool>);
		func..ctor(obj13, (IntPtr)obj15);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v22+B8]");
		object obj17 = (nint)0 + (nint)40;
		obj17 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj18 = 0;
		Func<System.Int32Enum, bool> predicate = func;
		object obj20;
		object obj19 = obj20;
		goto IL_03c4;
		IL_03c4:
		IEnumerable<System.Int32Enum> source2;
		IEnumerable<System.Int32Enum> source = Enumerable.Where(source2, predicate);
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj22 = !flag5;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v9+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v8+30]");
		Func<System.Int32Enum, int> keySelector = (Func<System.Int32Enum, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v8+30]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v9+E4]");
			bool flag7 = (nint)0 == 0;
			object obj25 = !flag7;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj26 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v14+B8]");
				obj23 = 0;
			}
			object obj27 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 512;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj28 = (nint)0 + (nint)1400;
			Func<System.Int32Enum, int> func2 = default(Func<System.Int32Enum, int>);
			func2..ctor(obj23, (IntPtr)obj28);
			object obj29 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v13+B8]");
			object obj30 = (nint)0 + (nint)48;
			obj30 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			keySelector = func2;
		}
		IOrderedEnumerable<System.Int32Enum> source3 = Enumerable.OrderBy(source, keySelector);
		return (PlayerRank.Ranks)Enumerable.FirstOrDefault(source3);
		IL_01f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v33+E4]");
		bool flag8 = (nint)0 == 0;
		object obj31 = !flag8;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj32 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v34+B8]");
			obj8 = 0;
		}
		object obj33 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj34 = (nint)0 + (nint)1384;
		Func<object, System.Int32Enum> func3 = default(Func<object, System.Int32Enum>);
		func3..ctor(obj8, (IntPtr)obj34);
		object obj35 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v33+B8]");
		object obj36 = (nint)0 + (nint)32;
		obj36 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj18 = 0;
		selector = func3;
		obj10 = obj7;
		array = array2;
		goto IL_0250;
		IL_00a2:
		obj10 = (nint)0 + (nint)3800;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v33+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v28+20]");
		selector = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v28+20]");
		bool flag9 = (nint)0 == 0;
		object obj37 = !flag9;
		if (obj37 == null)
		{
			obj7 = obj10;
			array2 = array;
			goto IL_01f9;
		}
		goto IL_0250;
		IL_0250:
		source2 = Enumerable.Select(array, selector);
		object obj38 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v23+E4]");
		if ((nint)0 != 0)
		{
			obj19 = (nint)0 + (nint)3928;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v23+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17+28]");
			predicate = (Func<System.Int32Enum, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17+28]");
			bool flag10 = (nint)0 == 0;
			object obj39 = !flag10;
			if (obj39 == null)
			{
				obj20 = obj19;
				goto IL_036d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj38 = obj2;
			obj20 = (nint)0 + (nint)3928;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v23+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17+28]");
			predicate = (Func<System.Int32Enum, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17+28]");
			bool flag11 = (nint)0 == 0;
			object obj40 = !flag11;
			obj19 = obj20;
			if (obj40 == null)
			{
				goto IL_036d;
			}
		}
		goto IL_03c4;
	}

	public static float GetAverageRank(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_00ae: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_0199: Expected O, but got I
		//IL_01a9: Expected O, but got I
		//IL_01b9: Expected O, but got I
		//IL_01db: Expected O, but got I4
		//IL_0315: Expected O, but got I
		//IL_0325: Expected O, but got I
		//IL_0335: Expected O, but got I
		//IL_0357: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		//IL_029a: Expected O, but got I
		//IL_02aa: Expected O, but got I
		//IL_02ba: Expected O, but got I
		//IL_02dc: Expected O, but got I4
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected O, but got Unknown
		//IL_0859: Expected O, but got I
		//IL_086a: Expected I, but got O
		//IL_0888: Expected O, but got I
		//IL_08a3: Expected O, but got I4
		//IL_0489: Expected O, but got I
		//IL_0499: Expected O, but got I
		//IL_04a9: Expected O, but got I
		//IL_04cb: Expected O, but got I4
		//IL_038f: Expected O, but got I4
		//IL_024b: Expected O, but got I
		//IL_040e: Expected O, but got I
		//IL_041e: Expected O, but got I
		//IL_042e: Expected O, but got I
		//IL_0450: Expected O, but got I4
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Expected O, but got Unknown
		//IL_08ea: Expected O, but got I
		//IL_08fb: Expected I, but got O
		//IL_0919: Expected O, but got I
		//IL_093c: Expected O, but got I4
		//IL_0503: Expected O, but got I4
		//IL_03bf: Expected O, but got I
		//IL_05ff: Expected O, but got I
		//IL_060f: Expected O, but got I
		//IL_0631: Expected O, but got I4
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Expected O, but got Unknown
		//IL_0973: Expected O, but got I
		//IL_0984: Expected I, but got O
		//IL_09a2: Expected O, but got I
		//IL_09c5: Expected O, but got I4
		//IL_0598: Expected O, but got I
		//IL_05a8: Expected O, but got I
		//IL_05ca: Expected O, but got I4
		//IL_0533: Expected O, but got I
		//IL_075b: Expected O, but got I
		//IL_076b: Expected O, but got I
		//IL_077b: Expected O, but got I
		//IL_079d: Expected O, but got I4
		//IL_0661: Expected O, but got I4
		//IL_06e0: Expected O, but got I
		//IL_06f0: Expected O, but got I
		//IL_0700: Expected O, but got I
		//IL_0722: Expected O, but got I4
		//IL_09e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Expected O, but got Unknown
		//IL_09fc: Expected O, but got I
		//IL_0a0d: Expected I, but got O
		//IL_0a2b: Expected O, but got I
		//IL_0a46: Expected O, but got I4
		//IL_07d5: Expected O, but got I4
		//IL_0691: Expected O, but got I
		//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a67: Expected O, but got Unknown
		//IL_0a7d: Expected O, but got I
		//IL_0a8e: Expected I, but got O
		//IL_0aac: Expected O, but got I
		//IL_0805: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2472;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DCA]");
		object obj3 = (nint)0 & (nint)1;
		PlayerInfo[] array;
		PlayerInfo[] array2;
		object obj4;
		if (obj3 != null)
		{
			PlayerInfo[] playersInfo = GetPlayersInfo(room);
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v62+E4]");
			bool flag = (nint)0 == 0;
			array = playersInfo;
			object obj5 = obj4;
			array2 = playersInfo;
			if (!flag)
			{
				goto IL_00a2;
			}
		}
		else
		{
			_ = 1;
			PlayerInfo[] playersInfo2 = GetPlayersInfo(room);
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v62+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			array = playersInfo2;
			object obj5 = obj4;
			array2 = playersInfo2;
			if (obj6 != null)
			{
				goto IL_00a2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)3800;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v62+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v56+38]");
		Func<object, System.Int32Enum> selector = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v56+38]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		array = array2;
		if (obj9 == null)
		{
			goto IL_01f9;
		}
		goto IL_0250;
		IL_063f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v32+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		object obj13;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v29+B8]");
			obj13 = 0;
		}
		object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)1328;
		Func<object, System.Int32Enum> func = default(Func<object, System.Int32Enum>);
		func..ctor(obj13, (IntPtr)obj15);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v28+B8]");
		object obj17 = (nint)0 + (nint)80;
		obj17 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj18 = 0;
		Func<object, System.Int32Enum> selector2 = func;
		goto IL_0696;
		IL_036d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v52+E4]");
		bool flag5 = (nint)0 == 0;
		object obj19 = !flag5;
		object obj21;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj20 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v51+B8]");
			obj21 = 0;
		}
		object obj22 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)1312;
		Func<System.Int32Enum, bool> func2 = default(Func<System.Int32Enum, bool>);
		func2..ctor(obj21, (IntPtr)obj23);
		object obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v50+B8]");
		object obj25 = (nint)0 + (nint)64;
		obj25 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj27;
		object obj26 = obj27;
		obj18 = 0;
		Func<System.Int32Enum, bool> predicate = func2;
		goto IL_03c4;
		IL_04e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v42+E4]");
		bool flag6 = (nint)0 == 0;
		object obj28 = !flag6;
		object obj30;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj29 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v40+B8]");
			obj30 = 0;
		}
		object obj31 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj32 = (nint)0 + (nint)1320;
		Func<System.Int32Enum, int> func3 = default(Func<System.Int32Enum, int>);
		func3..ctor(obj30, (IntPtr)obj32);
		object obj33 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v39+B8]");
		object obj34 = (nint)0 + (nint)72;
		obj34 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj36;
		object obj35 = obj36;
		obj18 = 0;
		Func<System.Int32Enum, int> selector3 = func3;
		goto IL_0538;
		IL_00a2:
		obj10 = (nint)0 + (nint)3800;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v62+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v56+38]");
		selector = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v56+38]");
		bool flag7 = (nint)0 == 0;
		object obj37 = !flag7;
		if (obj37 == null)
		{
			obj7 = obj10;
			array2 = array;
			goto IL_01f9;
		}
		goto IL_0250;
		IL_080a:
		IEnumerable<System.Int32Enum> source;
		Func<System.Int32Enum, bool> predicate2;
		int num = Enumerable.Count(source, predicate2);
		int num2;
		return (float)num2 / (float)num;
		IL_01f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v62+E4]");
		bool flag8 = (nint)0 == 0;
		object obj38 = !flag8;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj39 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v62+B8]");
			obj8 = 0;
		}
		object obj40 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj41 = (nint)0 + (nint)1304;
		Func<object, System.Int32Enum> func4 = default(Func<object, System.Int32Enum>);
		func4..ctor(obj8, (IntPtr)obj41);
		object obj42 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v61+B8]");
		object obj43 = (nint)0 + (nint)56;
		obj43 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj18 = 0;
		selector = func4;
		obj10 = obj7;
		array = array2;
		goto IL_0250;
		IL_0696:
		PlayerInfo[] playersInfo3;
		source = Enumerable.Select(playersInfo3, selector2);
		object obj44 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v22+E4]");
		object obj46;
		object obj48;
		object obj45;
		if ((nint)0 != 0)
		{
			obj45 = (nint)0 + (nint)3648;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v22+B8]");
			obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v12+58]");
			predicate2 = (Func<System.Int32Enum, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v12+58]");
			bool flag9 = (nint)0 == 0;
			object obj47 = !flag9;
			if (obj47 == null)
			{
				obj48 = obj45;
				goto IL_07b3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj44 = obj2;
			obj48 = (nint)0 + (nint)3648;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v22+B8]");
			obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v12+58]");
			predicate2 = (Func<System.Int32Enum, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v12+58]");
			bool flag10 = (nint)0 == 0;
			object obj49 = !flag10;
			obj45 = obj48;
			if (obj49 == null)
			{
				goto IL_07b3;
			}
		}
		goto IL_080a;
		IL_03c4:
		IEnumerable<System.Int32Enum> source3;
		IEnumerable<System.Int32Enum> source2 = Enumerable.Where(source3, predicate);
		object obj50 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v42+E4]");
		if ((nint)0 != 0)
		{
			obj35 = (nint)0 + (nint)760;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v42+B8]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v34+48]");
			selector3 = (Func<System.Int32Enum, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v34+48]");
			bool flag11 = (nint)0 == 0;
			object obj51 = !flag11;
			if (obj51 == null)
			{
				obj36 = obj35;
				goto IL_04e1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj50 = obj2;
			obj36 = (nint)0 + (nint)760;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v42+B8]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v34+48]");
			selector3 = (Func<System.Int32Enum, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v34+48]");
			bool flag12 = (nint)0 == 0;
			object obj52 = !flag12;
			obj35 = obj36;
			if (obj52 == null)
			{
				goto IL_04e1;
			}
		}
		goto IL_0538;
		IL_0250:
		source3 = Enumerable.Select(array, selector);
		object obj53 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v52+E4]");
		if ((nint)0 != 0)
		{
			obj26 = (nint)0 + (nint)3928;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v52+B8]");
			obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v45+40]");
			predicate = (Func<System.Int32Enum, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v45+40]");
			bool flag13 = (nint)0 == 0;
			object obj54 = !flag13;
			if (obj54 == null)
			{
				obj27 = obj26;
				goto IL_036d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj53 = obj2;
			obj27 = (nint)0 + (nint)3928;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v52+B8]");
			obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v45+40]");
			predicate = (Func<System.Int32Enum, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v45+40]");
			bool flag14 = (nint)0 == 0;
			object obj55 = !flag14;
			obj26 = obj27;
			if (obj55 == null)
			{
				goto IL_036d;
			}
		}
		goto IL_03c4;
		IL_07b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v22+E4]");
		bool flag15 = (nint)0 == 0;
		object obj56 = !flag15;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj57 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v18+B8]");
			obj46 = 0;
		}
		object obj58 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj59 = (nint)0 + (nint)1336;
		Func<System.Int32Enum, bool> func5 = default(Func<System.Int32Enum, bool>);
		func5..ctor(obj46, (IntPtr)obj59);
		object obj60 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v17+B8]");
		object obj61 = (nint)0 + (nint)88;
		obj61 = func5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate2 = func5;
		obj45 = obj48;
		goto IL_080a;
		IL_0538:
		num2 = Enumerable.Sum(source2, selector3);
		playersInfo3 = GetPlayersInfo(room);
		object obj62 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v32+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v32+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v23+50]");
			selector2 = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v23+50]");
			bool flag16 = (nint)0 == 0;
			object obj63 = !flag16;
			if (obj63 == null)
			{
				goto IL_063f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj62 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v32+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v23+50]");
			selector2 = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v23+50]");
			bool flag17 = (nint)0 == 0;
			object obj64 = !flag17;
			if (obj64 == null)
			{
				goto IL_063f;
			}
		}
		goto IL_0696;
	}

	public static bool IsJoinable(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f2: Expected O, but got I
		//IL_011c: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0181: Expected I4, but got O
		//IL_0165: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DCB]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_0173;
		IL_00b8:
		User localUser = sessionModel.LocalUser;
		return IsJoinable(room, localUser);
		IL_0173:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_0173;
	}

	public static bool IsJoinable(Room room, User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_0164: Expected I4, but got O
		//IL_00db: Expected O, but got I4
		//IL_0136: Expected O, but got I4
		object obj = "getSecondRescanTask" + 2104;
		object obj2 = (nint)0 + (nint)328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F620");
		GameType type = default(GameType);
		bool flag = GameTypeExtensions.IsFriendly(type);
		if (flag)
		{
			PlayerRank rank = SFSKammelnaUserExtensions.GetRank(user);
			if (rank == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			PlayerRank.Ranks rankLimit = GetRankLimit(room);
			if (rank.<Rank>k__BackingField < rankLimit)
			{
				flag = false;
			}
			else
			{
				if (!IsCheatingAllowed(room))
				{
					return true;
				}
				bool flag2 = SFSKammelnaUserExtensions.IsSubscribed(user);
				bool flag3 = !flag2;
				object obj3 = !flag3;
				flag = true;
				if (obj3 == null)
				{
					int clanId = GetClanId(room);
					if (clanId >= 1)
					{
						int clanId2 = SFSKammelnaUserExtensions.GetClanId(user);
						object obj4 = clanId2 - clanId;
						return obj4 == null;
					}
					return false;
				}
			}
		}
		return flag;
	}

	public static int GetClanId(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "clear_mass_tournaments" + 64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E2D]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static bool IsClanMember(Room room, User user)
	{
		//IL_0044: Expected O, but got I4
		int clanId = GetClanId(room);
		if (clanId >= 1)
		{
			int clanId2 = SFSKammelnaUserExtensions.GetClanId(user);
			object obj = clanId2 - clanId;
			return obj == null;
		}
		return false;
	}

	public static bool[] GetJoinableSeats(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0068: Expected O, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008d: Expected O, but got I4
		//IL_018d: Expected O, but got I
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_00f7: Expected O, but got I
		//IL_0115: Expected O, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_013e: Expected O, but got I4
		Room room2 = default(Room);
		PlayerInfo[] playersInfo = GetPlayersInfo(room2);
		bool[] array = default(bool[]);
		if (playersInfo != null)
		{
			object obj = typeof(TypeConverter<ushort, char>) + 1832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			if (playersInfo.Length < 1)
			{
				goto IL_01d6;
			}
			object obj2 = playersInfo + 32;
			bool flag = array == null;
			object obj3 = 0;
			if (!flag)
			{
				object obj4 = array + 32;
				object obj5 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X21_v5+v62 @ X22_v8*8]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X21_v5+v62 @ X22_v8*8]");
					bool isHuman = ((PlayerInfo)0).IsHuman;
					bool flag2 = !isHuman;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						bool flag3 = (nint)obj5 < array.Length;
						object obj7 = !flag3;
						if (obj7 != null)
						{
							goto IL_01e9;
						}
						_ = 1;
					}
					obj5++;
					if ((nint)obj5 < playersInfo.Length)
					{
						continue;
					}
					goto IL_01d6;
				}
			}
			else
			{
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X21_v5+v63 @ X22_v6*8]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X21_v5+v63 @ X22_v6*8]");
					if (!((PlayerInfo)0).IsHuman)
					{
						break;
					}
					obj3++;
					if ((nint)obj3 < playersInfo.Length)
					{
						continue;
					}
					goto IL_01d6;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01e9;
		IL_01d6:
		return array;
		IL_01e9:
		return (bool[])(object)new IndexOutOfRangeException();
	}

	public static int GetJoinableSeatsCount(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0150: Expected O, but got I4
		//IL_00ae: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_0194: Expected O, but got I
		//IL_01a4: Expected O, but got I
		//IL_01b4: Expected O, but got I
		//IL_01d6: Expected O, but got I4
		//IL_0216: Expected O, but got I4
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0284: Expected O, but got I
		//IL_0295: Expected I, but got O
		//IL_02b3: Expected O, but got I
		//IL_0246: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2472;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DCD]");
		object obj3 = (nint)0 & (nint)1;
		bool[] array2;
		object obj4;
		bool[] array;
		if (obj3 != null)
		{
			bool[] joinableSeats = GetJoinableSeats(room);
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			array = joinableSeats;
			object obj5 = obj4;
			array2 = joinableSeats;
			if (!flag)
			{
				goto IL_00a2;
			}
		}
		else
		{
			_ = 1;
			bool[] joinableSeats2 = GetJoinableSeats(room);
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			array = joinableSeats2;
			object obj5 = obj4;
			array2 = joinableSeats2;
			if (obj6 != null)
			{
				goto IL_00a2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)3488;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v4+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v4+60]");
		Func<bool, bool> func = (Func<bool, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v4+60]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		array = array2;
		if (obj9 == null)
		{
			goto IL_01f4;
		}
		goto IL_024b;
		IL_01f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v10+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1376;
		Func<bool, bool> func2 = default(Func<bool, bool>);
		func2..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v9+B8]");
		object obj16 = (nint)0 + (nint)96;
		obj16 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		func = func2;
		obj10 = obj7;
		array = array2;
		goto IL_024b;
		IL_024b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DBC554");
		int result = default(int);
		return result;
		IL_00a2:
		obj10 = (nint)0 + (nint)3488;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v4+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v4+60]");
		func = (Func<bool, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v4+60]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			obj7 = obj10;
			array2 = array;
			goto IL_01f4;
		}
		goto IL_024b;
	}

	public static int GetFirstJoinableSeatIndex(Room room)
	{
		//IL_0270: Expected I4, but got O
		//IL_00f6: Expected I4, but got I8
		//IL_0059: Expected O, but got I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0081: Expected O, but got I4
		//IL_0106: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		//IL_02e4: Expected O, but got I
		//IL_02fe: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected I4, but got Unknown
		//IL_031c: Expected O, but got I4
		//IL_012a: Expected O, but got I
		//IL_0144: Expected O, but got I4
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected I4, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_0175: Expected O, but got I
		//IL_018f: Expected O, but got I4
		//IL_0299: Expected O, but got I
		//IL_02b3: Expected O, but got I4
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected I4, but got Unknown
		//IL_01b3: Expected O, but got I
		//IL_01cd: Expected O, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		bool[] joinableSeats = GetJoinableSeats(room);
		object obj4;
		if (joinableSeats != null)
		{
			if (joinableSeats.Length < 1)
			{
				goto IL_00ec;
			}
			object obj = joinableSeats.Length & 0x7FFFFFFF;
			object obj2 = obj - 1;
			bool flag = (nint)obj2 < 3;
			object obj3 = !flag;
			if (obj3 == null)
			{
				obj4 = 0;
				goto IL_030c;
			}
			object obj5 = joinableSeats.Length & 0x7FFFFFFC;
			obj4 = 0;
			while (true)
			{
				object obj6 = (object)joinableSeats + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X11_v7+20]");
				object obj7 = (nint)0 & (nint)1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				if (obj8 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X11_v7+21]");
				object obj9 = (nint)0 & (nint)1;
				bool flag3 = obj9 == null;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					object obj11 = (object)joinableSeats + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X11_v9+22]");
					object obj12 = (nint)0 & (nint)1;
					bool flag4 = obj12 == null;
					object obj13 = !flag4;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X11_v9+23]");
						object obj14 = (nint)0 & (nint)1;
						bool flag5 = obj14 == null;
						object obj15 = !flag5;
						if (obj15 == null)
						{
							obj4 += 4;
							if (obj5 != obj4)
							{
								continue;
							}
							goto IL_030c;
						}
						obj4 += 3;
						break;
					}
					object obj16 = obj4 + 2;
					return obj16 + 1;
				}
				object obj17 = obj4 + 1;
				return obj17 + 1;
			}
			goto IL_0270;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_030c:
		object obj18 = joinableSeats.Length & 3;
		if (obj18 == null)
		{
			goto IL_00ec;
		}
		object obj19 = joinableSeats + 32;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X10_v3+v119 @ X8_v7]");
			object obj20 = (nint)0 & (nint)1;
			bool flag6 = obj20 == null;
			object obj21 = !flag6;
			if (obj21 != null)
			{
				break;
			}
			obj4++;
			obj18--;
			if ((nint)obj18 != 1)
			{
				continue;
			}
			goto IL_00ec;
		}
		goto IL_0270;
		IL_0270:
		return obj4 + 1;
		IL_00ec:
		return -1;
	}

	public static int GetFirstJoinableSeatForTeam(Room room, int teamIndex)
	{
		//IL_02fc: Expected I4, but got O
		//IL_00ec: Expected O, but got I4
		//IL_00fc: Expected O, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0166: Expected I4, but got I8
		//IL_023f: Expected O, but got I4
		//IL_024f: Expected O, but got I4
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_028b: Expected O, but got I4
		//IL_02ad: Expected O, but got I4
		//IL_0182: Expected O, but got I4
		//IL_0192: Expected O, but got I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01ce: Expected O, but got I4
		//IL_01f0: Expected O, but got I4
		bool[] joinableSeats = GetJoinableSeats(room);
		if (teamIndex != 2)
		{
			if (teamIndex != 1)
			{
				return -1;
			}
			if (joinableSeats != null)
			{
				if (joinableSeats.Length != 0)
				{
					if (joinableSeats[0])
					{
						return 1;
					}
					bool flag = joinableSeats.Length < 2;
					object obj = !flag;
					object obj2 = joinableSeats.Length - 2;
					bool flag2 = obj2 == null;
					object obj3 = ~obj;
					object obj4 = obj3 | flag2;
					if (obj4 == null)
					{
						object obj5 = 34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X0_v1 (System.Boolean[])+v192 @ X9_v7]");
						bool flag3 = (nint)0 == 0;
						object obj6 = !flag3;
						object obj7 = ~obj6;
						if (obj7 == null)
						{
							return 3;
						}
						return -1;
					}
				}
				goto IL_02e0;
			}
		}
		else if (joinableSeats != null)
		{
			bool flag4 = joinableSeats.Length < 1;
			object obj8 = !flag4;
			object obj9 = joinableSeats.Length - 1;
			bool flag5 = obj9 == null;
			object obj10 = ~obj8;
			object obj11 = obj10 | flag5;
			if (obj11 == null)
			{
				if (joinableSeats[1])
				{
					return 2;
				}
				bool flag6 = joinableSeats.Length < 3;
				object obj12 = !flag6;
				object obj13 = joinableSeats.Length - 3;
				bool flag7 = obj13 == null;
				object obj14 = ~obj12;
				object obj15 = obj14 | flag7;
				if (obj15 == null)
				{
					object obj16 = 35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X0_v1 (System.Boolean[])+v190 @ X9_v4]");
					bool flag8 = (nint)0 == 0;
					object obj17 = !flag8;
					object obj18 = ~obj17;
					if (obj18 == null)
					{
						return 4;
					}
					return -1;
				}
			}
			goto IL_02e0;
		}
		goto IL_02ee;
		IL_02ee:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_02e0:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_02ee;
	}

	public static int GetOriginalOwnerId(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "Network Authentication Required" + 3320;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E2E]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static string GetTournamentPassword(Room room)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0116: Expected O, but got I4
		//IL_0126: Expected O, but got I
		//IL_0136: Expected O, but got I
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		object obj = "placementId" + 1808;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+90]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+B8]");
		object defaultValue = 0;
		if (room != null)
		{
			object obj4 = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj6 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X10_v5-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				obj6 += 16;
				obj5--;
				if ((nint)obj5 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj7 = obj6 + 31;
			object obj8 = num + obj7;
			object obj9 = obj8 + 312;
			goto IL_015f;
		}
		return (string)(object)new NullReferenceException();
		IL_015f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v182 @ X0_v4] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, (string)defaultValue);
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_015f;
	}

	public static int GetRoomOwnerId(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "Network Authentication Required" + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E30]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static bool IsLobby(Room room)
	{
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0234: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0180: Expected I4, but got O
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
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
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		bool flag = room == null;
		Room room2 = room;
		if (!flag)
		{
			object obj2 = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X10_v6-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj5 = obj4 + 1;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_01dd;
		}
		goto IL_020a;
		IL_01dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ X0_v12] (should have been resolved before IL gen)");
		Room room3 = default(Room);
		room2 = room3;
		goto IL_020a;
		IL_020a:
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GameConfiguration currentGameConfiguration = Config.CurrentGameConfiguration;
		if (currentGameConfiguration != null)
		{
			object obj10 = "LAK" + 3376;
			string text = (string)((currentGameConfiguration.<DefaultRoom>k__BackingField != null) ? currentGameConfiguration.<DefaultRoom>k__BackingField : obj10);
			return (string)(object)room2 == text;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_01dd;
	}

	public static bool IsOffline(Room room)
	{
		//IL_0107: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		object obj2;
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			obj2 = "October" + 72;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj5 = obj4 + 3;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_0148;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0148:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ X0_v3] (should have been resolved before IL gen)");
		string text = default(string);
		return text == (string)obj2;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0148;
	}

	public static bool IsVoiceChatEnabled(Room room)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @946041C");
		bool result = default(bool);
		return result;
	}

	public static bool IsVoiceChatEnabledForSpectators(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "utf-32" + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E32]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, defaultValue: false);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static TutorialType GetTutorialType(Room room)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object obj = "ThisIsFakeReceiptData" + 2672;
		object obj2 = (nint)0 + (nint)376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F620");
		TutorialType result = default(TutorialType);
		return result;
	}

	public static bool GetIsReplay(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_02c4: Expected O, but got I4
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "https://www.kammelna.com/Home/Terms" + 200;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E33]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		int num2 = SFSExtensions.Get(variable, 0);
		object obj10 = num2 - 1;
		return obj10 == null;
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj11 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj11;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj13 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj14 = obj13 + 31;
		object obj15 = num + obj14;
		object obj16 = obj15 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static List<int> GetPlayersVoices(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_00fa: Expected O, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01c9: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_0272: Expected O, but got I4
		//IL_0282: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0204: Expected O, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_015e: Expected O, but got I
		//IL_0187: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02f0: Expected O, but got I4
		//IL_0308: Expected O, but got I
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		object obj2;
		object obj8;
		object obj9 = default(object);
		object obj10;
		object obj11;
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			obj2 = "placementId" + 1792;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v12-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj5 = obj4 + 31;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v19+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v194 @ X0_v19] (should have been resolved before IL gen)");
			bool flag = obj9 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v19+8]");
			obj10 = 0;
			obj11 = obj2;
			if (!flag)
			{
				goto IL_019d;
			}
			goto IL_0316;
		}
		return (List<int>)(object)new NullReferenceException();
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v16+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ X0_v16] (should have been resolved before IL gen)");
		bool flag2 = obj9 == null;
		object obj12 = !flag2;
		if (obj12 != null)
		{
			goto IL_019d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v16+8]");
		obj10 = 0;
		obj11 = obj2;
		goto IL_0316;
		IL_0290:
		ISFSArray iSFSArray = default(ISFSArray);
		return SFSExtensions.ToIntList(iSFSArray);
		IL_019d:
		object obj13 = typeof(UsageHint) + 664;
		object obj14 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v12+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v12+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0245;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v12+B0]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X10_v7-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			obj16 += 16;
			obj15--;
			if ((nint)obj15 != 1)
			{
				continue;
			}
			goto IL_0245;
		}
		object obj17 = obj16 + 8;
		object obj18 = obj14 + obj17;
		object obj19 = obj18 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ X8_v16] (should have been resolved before IL gen)");
		bool flag3 = iSFSArray == null;
		object obj20 = !flag3;
		obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v16+8]");
		obj11 = 0;
		if (obj20 != null)
		{
			goto IL_0290;
		}
		goto IL_0316;
		IL_0316:
		object obj21 = typeof(RegisteredWaitHandle) + 1888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray = default(SFSArray);
		sFSArray..ctor();
		return SFSExtensions.ToIntList(sFSArray);
		IL_0245:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X0_v11] (should have been resolved before IL gen)");
		bool flag4 = iSFSArray == null;
		obj10 = 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v11+8]");
		obj11 = 0;
		if (!flag4)
		{
			goto IL_0290;
		}
		goto IL_0316;
	}

	public static string GetRoomMessage(Room room)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0116: Expected O, but got I4
		//IL_0126: Expected O, but got I
		//IL_0136: Expected O, but got I
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		object obj = "rightCtrl" + 224;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+90]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+B8]");
		object defaultValue = 0;
		if (room != null)
		{
			object obj4 = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj6 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X10_v5-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				obj6 += 16;
				obj5--;
				if ((nint)obj5 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj7 = obj6 + 31;
			object obj8 = num + obj7;
			object obj9 = obj8 + 312;
			goto IL_015f;
		}
		return (string)(object)new NullReferenceException();
		IL_015f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v182 @ X0_v4] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, (string)defaultValue);
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_015f;
	}

	public static int GetRoomSportTeamID(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "rightCtrl" + 632;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E35]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static int GetRoomAdCampaignID(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "placementId" + 2120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E36]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static int GetPlayerIndexByUser(Room room, User user)
	{
		//IL_00f1: Expected I4, but got O
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_0101: Expected O, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected I4, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(user);
		PlayerInfo[] playersInfo = GetPlayersInfo(room);
		if (playersInfo != null)
		{
			if (playersInfo.Length < 1)
			{
				goto IL_00ca;
			}
			object obj = playersInfo + 32;
			object obj2 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X10_v3+v40 @ X9_v4*8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X10_v3+v40 @ X9_v4*8]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X11_v4+10]");
				if ((nint)0 != intDbId)
				{
					obj2++;
					if (playersInfo.Length != (nint)obj2)
					{
						continue;
					}
					goto IL_00ca;
				}
				return obj2 + 1;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_00ca:
		return 0;
	}

	public static int GetPlayerTeamIndex(Room room, User user)
	{
		//IL_0103: Expected I4, but got O
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0079: Expected O, but got I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(user);
		PlayerInfo[] playersInfo = GetPlayersInfo(room);
		int num;
		if (playersInfo != null)
		{
			if (playersInfo.Length < 1)
			{
				goto IL_00e7;
			}
			object obj = playersInfo + 32;
			object obj2 = playersInfo.Length & 0x7FFFFFFF;
			num = 1;
			while (true)
			{
				object obj3 = obj;
				obj += 8;
				if (obj == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X10_v5+10]");
				if ((nint)0 != intDbId)
				{
					num++;
					obj2--;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00e7;
				}
				goto IL_0103;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_00e7:
		num = 0;
		goto IL_0103;
		IL_0103:
		return BalootUtils.GetPlayerTeam(num);
	}

	public static bool IsSuppressUserList(Room room)
	{
		//IL_00f8: Expected I4, but got O
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
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v5-8]");
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
			object obj4 = obj3 + 14;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0139;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0139:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ X0_v3] (should have been resolved before IL gen)");
		object obj7 = default(object);
		return obj7 == null;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0139;
	}

	public static int? GetOnlineUsersCount(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_01b9: Expected O, but got I4
		//IL_007b: Expected O, but got I
		//IL_023e: Expected I, but got O
		//IL_024e: Expected O, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_01a5: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_0108: Expected O, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		object obj;
		if (room != null)
		{
			obj = typeof(RegisteredWaitHandle) + 1376;
			object obj2 = "not" + 2704;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X10_v12-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj5 = obj4 + 35;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v203 @ X0_v23] (should have been resolved before IL gen)");
			object obj8 = default(object);
			bool flag = obj8 == null;
			object obj9 = !flag;
			if (obj9 != null)
			{
				goto IL_0236;
			}
			goto IL_01b3;
		}
		return (int?)new NullReferenceException();
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ X0_v20] (should have been resolved before IL gen)");
		object obj10 = default(object);
		if (obj10 == null)
		{
			goto IL_01b3;
		}
		goto IL_0236;
		IL_0149:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0297;
		IL_01b3:
		return (int?)(object)0;
		IL_0236:
		nint num2 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0149;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X10_v7-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_0149;
		}
		object obj13 = obj12 + 31;
		object obj14 = num2 + obj13;
		object obj15 = obj14 + 312;
		goto IL_0297;
		IL_0297:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v300 @ X0_v7] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
	}

	public static JackarooAllowedRules GetJackarooCustomRules(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "java.io.FileOutputStream" + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E38]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return (JackarooAllowedRules)SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static bool IsTournamentHub(Room room)
	{
		//IL_028b: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_017a: Expected I, but got O
		//IL_018a: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_0228: Expected O, but got I
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_0273: Expected O, but got I
		//IL_01c5: Expected O, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_014d: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		object obj;
		if (room != null)
		{
			obj = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X10_v11-8]");
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
			object obj4 = obj3 + 6;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v207 @ X0_v15] (should have been resolved before IL gen)");
			object obj8 = default(object);
			object obj7 = obj8 & 1;
			bool flag = obj7 == null;
			object obj9 = !flag;
			if (obj9 != null)
			{
				goto IL_00ec;
			}
			goto IL_015b;
		}
		goto IL_027d;
		IL_015b:
		object obj10 = "https://www.kammelna.com/Home/Terms" + 136;
		object obj11 = obj10;
		nint num2 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0206;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X10_v5-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj13 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_0206;
		}
		goto IL_0232;
		IL_0206:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj15 = default(object);
		object obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v5+8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v121 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_0232;
		IL_0232:
		object obj17 = obj13 + 35;
		object obj18 = num2 + obj17;
		object obj19 = obj18 + 312;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v7+8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v122 @ X3_v2 (should have been resolved before IL gen)");
		goto IL_027d;
		IL_00ec:
		return false;
		IL_027d:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ X0_v12] (should have been resolved before IL gen)");
		object obj23 = default(object);
		object obj22 = obj23 & 1;
		if (obj22 != null)
		{
			goto IL_00ec;
		}
		goto IL_015b;
	}

	public static TournamentData GetTournamentInfo(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_00fa: Expected O, but got I4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_019b: Expected I, but got O
		//IL_01ab: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_0241: Expected O, but got I
		//IL_0265: Expected O, but got I4
		//IL_026e: Expected O, but got I4
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_01e6: Expected O, but got I
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0150: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02c2: Expected O, but got I
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		TournamentData tournamentData = default(TournamentData);
		TournamentData tournamentData2;
		object obj8;
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			object obj2 = "https://www.kammelna.com/Home/Terms" + 136;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X10_v12-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj5 = obj4 + 31;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v17+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v198 @ X0_v17] (should have been resolved before IL gen)");
			bool flag = tournamentData == null;
			tournamentData2 = tournamentData;
			if (flag)
			{
				goto IL_0110;
			}
			goto IL_017f;
		}
		return null;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v14+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ X0_v14] (should have been resolved before IL gen)");
		bool flag2 = tournamentData == null;
		object obj9 = !flag2;
		tournamentData2 = tournamentData;
		if (obj9 == null)
		{
			goto IL_0110;
		}
		goto IL_017f;
		IL_02f1:
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentData tournamentData3 = default(TournamentData);
		TournamentData tournamentData4 = default(TournamentData);
		tournamentData3..ctor((ISFSObject)tournamentData4);
		return tournamentData3;
		IL_017f:
		object obj11 = typeof(UsageHint) + 664;
		nint num2 = (nint)tournamentData2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v9 (Il2CppClass<TournamentData>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v9 (Il2CppClass<TournamentData>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0227;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v9 (Il2CppClass<TournamentData>)+B0]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X10_v6-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj13 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_0227;
		}
		object obj14 = obj13 + 7;
		object obj15 = num2 + obj14;
		object obj16 = obj15 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v15+8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v238 @ X8_v15] (should have been resolved before IL gen)");
		bool flag3 = tournamentData == null;
		tournamentData4 = tournamentData;
		if (flag3)
		{
			goto IL_0110;
		}
		goto IL_02f1;
		IL_0227:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v8+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v277 @ X0_v8] (should have been resolved before IL gen)");
		bool flag4 = tournamentData4 == null;
		object obj18 = !flag4;
		obj8 = 7;
		if (obj18 == null)
		{
			return tournamentData4;
		}
		goto IL_02f1;
		IL_0110:
		return tournamentData;
	}

	public static TournamentStatus GetTournamentStatus(Room room)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object obj = "startPosition" + 104;
		object obj2 = (nint)0 + (nint)368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F620");
		TournamentStatus result = default(TournamentStatus);
		return result;
	}

	public static bool IsFinalCountdown(Room room)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object obj = "startPosition" + 104;
		object obj2 = (nint)0 + (nint)368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F620");
		TournamentStatus status = default(TournamentStatus);
		return TournamentStatusExtensions.IsFinalCountdown(status);
	}

	public static int GetTournamentCurrentRound(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "com.unity.services.authentication.profile" + 1816;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E39]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static DateTime? GetTournamentRoundTimer(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_02b2: Expected O, but got I4
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "rightCtrl" + 640;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E3A]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E21]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E21]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E21]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E21]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, (DateTime?)(object)0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static int GetActiveTournamentsCount(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "alignContent" + 3024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E3B]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static int GetTournamentParticipantsCount(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "placementId" + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E3C]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static List<QueuePlayer> GetTournamentQueue(Room room)
	{
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0040: Expected I, but got O
		//IL_0050: Expected O, but got I
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected O, but got Unknown
		//IL_0534: Expected O, but got I
		//IL_0542: Expected I, but got O
		//IL_054e: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_008b: Expected O, but got I
		//IL_0133: Expected I, but got O
		//IL_0143: Expected O, but got I
		//IL_01d9: Expected I, but got O
		//IL_01e9: Expected O, but got I
		//IL_0212: Expected O, but got I
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		//IL_0321: Expected O, but got I
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_0353: Expected O, but got I4
		//IL_017e: Expected O, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_023c: Expected I, but got O
		//IL_024c: Expected O, but got I
		//IL_02db: Expected O, but got I4
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03d4: Expected I, but got O
		//IL_03e4: Expected O, but got I
		//IL_0408: Expected O, but got I4
		//IL_0418: Expected O, but got I
		//IL_0287: Expected O, but got I
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DD6]");
		nint num = 0;
		object obj;
		object obj2;
		object obj5 = default(object);
		object obj9;
		object obj13;
		if (room != null)
		{
			obj = typeof(RegisteredWaitHandle) + 1376;
			obj2 = "placementId" + 1856;
			nint num2 = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X10_v20-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj5 = obj4 + 16;
				obj3--;
				bool flag = (nint)obj3 != 1;
				obj4 = obj5;
				if (flag)
				{
					continue;
				}
				goto IL_00d4;
			}
			object obj6 = obj4 + 35;
			object obj7 = num2 + obj6;
			object obj8 = obj7 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v30+8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v280 @ X0_v30] (should have been resolved before IL gen)");
			object obj11 = default(object);
			object obj10 = obj11 & 1;
			bool flag2 = obj10 == null;
			object obj12 = !flag2;
			obj5 = obj4;
			obj13 = obj2;
			if (obj12 != null)
			{
				goto IL_012b;
			}
			goto IL_0371;
		}
		goto IL_042e;
		IL_0220:
		object obj14 = typeof(UsageHint) + 664;
		NullReferenceException ex = default(NullReferenceException);
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v10 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v10 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02c8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v10 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj5 = (nint)0 + (nint)8;
		object obj17;
		object obj16;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v12-8]");
			bool flag3 = 0 == (nint)obj14;
			obj16 = obj17;
			if (flag3)
			{
				break;
			}
			obj5 += 16;
			obj15--;
			if ((nint)obj15 != 1)
			{
				continue;
			}
			goto IL_02c8;
		}
		goto IL_043c;
		IL_043c:
		object obj18 = obj5 + 8;
		object obj19 = num + obj18;
		object obj20 = obj19 + 312;
		goto IL_0500;
		IL_02c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj16 = 8;
		object obj21 = default(object);
		obj20 = obj21;
		goto IL_0500;
		IL_01c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj22 = default(object);
		num = (nint)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v20+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v355 @ X0_v20] (should have been resolved before IL gen)");
		bool flag4 = ex == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v20+8]");
		obj16 = 0;
		if (!flag4)
		{
			goto IL_0220;
		}
		goto IL_042e;
		IL_0500:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v260 @ X8_v3] (should have been resolved before IL gen)");
		object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)880;
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)null, (IntPtr)obj24);
		object obj25 = (nint)0 + (nint)504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3020370");
		List<QueuePlayer> result = default(List<QueuePlayer>);
		return result;
		IL_00d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v27+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ X0_v27] (should have been resolved before IL gen)");
		object obj27 = default(object);
		object obj26 = obj27 & 1;
		bool flag5 = obj26 == null;
		obj13 = obj2;
		if (!flag5)
		{
			goto IL_012b;
		}
		goto IL_0371;
		IL_0371:
		object obj28 = typeof(List<AdaptivePerformanceScaler>) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		return (List<QueuePlayer>)(object)list;
		IL_012b:
		nint num3 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01c7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj30 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X10_v15-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj5 = obj30 + 16;
			obj29--;
			bool flag6 = (nint)obj29 != 1;
			obj30 = obj5;
			if (flag6)
			{
				continue;
			}
			goto IL_01c7;
		}
		object obj31 = obj30 + 31;
		object obj32 = num3 + obj31;
		object obj33 = obj32 + 312;
		num = (nint)obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v23+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v399 @ X0_v23] (should have been resolved before IL gen)");
		bool flag7 = ex == null;
		object obj34 = !flag7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v23+8]");
		obj16 = 0;
		obj5 = obj30;
		if (obj34 != null)
		{
			goto IL_0220;
		}
		goto IL_042e;
		IL_042e:
		ex = new NullReferenceException();
		goto IL_043c;
	}

	public static bool CanTournamentParticipantsChooseTeam(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "alignContent" + 704;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E3D]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, defaultValue: false);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static bool IsTournamentTeamsShuffled(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "setMimeType" + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E3E]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, defaultValue: false);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static bool IsTournamentWatchersChatEnabled(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "utf-32" + 1728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E3F]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1E]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, defaultValue: false);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static bool HasCaptcha(Room room)
	{
		//IL_0149: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0038: Expected I, but got O
		//IL_0048: Expected O, but got I
		//IL_00e6: Expected O, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0131: Expected O, but got I
		//IL_0083: Expected O, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		nint num;
		object obj5 = default(object);
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			object obj2 = "com.unity.services.authentication.profile" + 2720;
			object obj3 = obj2;
			num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00c4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v4-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00c4;
			}
			goto IL_00f0;
		}
		goto IL_013b;
		IL_013b:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_00c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj7 = default(object);
		object obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v4+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v113 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_00f0;
		IL_00f0:
		object obj9 = obj5 + 35;
		object obj10 = num + obj9;
		object obj11 = obj10 + 312;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v6+8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v125 @ X3_v2 (should have been resolved before IL gen)");
		goto IL_013b;
	}

	public static List<Vector2> GetCaptchaPath(Room room)
	{
		//IL_05e8: Expected O, but got I4
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0048: Expected I, but got O
		//IL_0058: Expected O, but got I
		//IL_072b: Expected O, but got I4
		//IL_00ee: Expected I, but got O
		//IL_00fe: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_0745: Expected O, but got I
		//IL_0756: Expected O, but got I
		//IL_0766: Expected O, but got I
		//IL_0788: Expected O, but got I4
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_0208: Expected O, but got I
		//IL_0093: Expected O, but got I
		//IL_029f: Expected O, but got I4
		//IL_0148: Expected O, but got I
		//IL_057a: Expected O, but got I4
		//IL_065d: Expected I, but got O
		//IL_066d: Expected O, but got I
		//IL_0243: Expected O, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_017e: Expected I, but got O
		//IL_018e: Expected O, but got I
		//IL_01b7: Expected O, but got I
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected O, but got Unknown
		//IL_07c0: Expected O, but got I
		//IL_07d1: Expected I, but got O
		//IL_07ef: Expected O, but got I
		//IL_0353: Expected I, but got O
		//IL_0363: Expected O, but got I
		//IL_038c: Expected O, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_05aa: Expected O, but got I
		//IL_02f8: Expected O, but got I
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_03c6: Expected I, but got O
		//IL_03d6: Expected O, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0465: Expected O, but got I4
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_04ab: Expected I, but got O
		//IL_04bb: Expected O, but got I
		//IL_04df: Expected O, but got I4
		//IL_04ef: Expected O, but got I
		//IL_0411: Expected O, but got I
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DD8]");
		nint num = 0;
		bool flag = room == null;
		double[] array = (double[])152981504;
		object obj;
		object obj4;
		object obj5 = default(object);
		object obj10 = default(object);
		object obj9;
		object obj11;
		if (!flag)
		{
			obj = typeof(RegisteredWaitHandle) + 1376;
			object obj2 = "com.unity.services.authentication.profile" + 2720;
			array = (double[])obj2;
			nint num2 = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00dc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X10_v12-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj5 = obj4 + 16;
				obj3--;
				bool flag2 = (nint)obj3 != 1;
				obj4 = obj5;
				if (flag2)
				{
					continue;
				}
				goto IL_00dc;
			}
			object obj6 = obj4 + 31;
			object obj7 = num2 + obj6;
			object obj8 = obj7 + 312;
			num = (nint)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v43+8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v296 @ X0_v43] (should have been resolved before IL gen)");
			bool flag3 = obj10 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v43+8]");
			obj11 = 0;
			obj5 = obj4;
			if (!flag3)
			{
				goto IL_01cd;
			}
		}
		goto IL_0505;
		IL_0513:
		object obj12 = obj5 + 8;
		object obj13 = num + obj12;
		object obj14 = obj13 + 312;
		goto IL_06ea;
		IL_028c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj9 = 8;
		object obj16 = default(object);
		object obj15 = obj16;
		goto IL_063e;
		IL_063e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v441 @ X8_v24] (should have been resolved before IL gen)");
		ISFSArray sfsArray = default(ISFSArray);
		double[] array2 = SFSExtensions.ToDoubleArray(sfsArray);
		nint num3 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0341;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X10_v2-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 = obj5 + 16;
			obj17--;
			bool flag4 = (nint)obj17 != 1;
			obj5 = obj4;
			if (flag4)
			{
				continue;
			}
			goto IL_0341;
		}
		object obj18 = obj5 + 31;
		object obj19 = num3 + obj18;
		object obj20 = obj19 + 312;
		num = (nint)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v34+8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v510 @ X0_v34] (should have been resolved before IL gen)");
		NullReferenceException ex = default(NullReferenceException);
		bool flag5 = ex == null;
		object obj22 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v34+8]");
		obj11 = 0;
		array = array2;
		if (obj22 != null)
		{
			goto IL_03aa;
		}
		goto IL_0505;
		IL_03aa:
		object obj23 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2472;
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v15 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v15 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0452;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v15 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj5 = (nint)0 + (nint)8;
		object obj25;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X10_v2-8]");
			bool flag6 = 0 == (nint)obj25;
			obj11 = obj21;
			array = array2;
			if (flag6)
			{
				break;
			}
			obj5 += 16;
			obj24--;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_0452;
		}
		goto IL_0513;
		IL_06ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v281 @ X8_v3] (should have been resolved before IL gen)");
		ISFSArray sfsArray2 = default(ISFSArray);
		double[] array3 = SFSExtensions.ToDoubleArray(sfsArray2);
		object obj26 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v6+E4]");
		bool flag7 = (nint)0 == 0;
		object obj27 = !flag7;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj26 = obj23;
		}
		object obj28 = (nint)0 + (nint)3952;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v6+B8]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v7+68]");
		Func<double, double, Vector2> func = (Func<double, double, Vector2>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v7+68]");
		bool flag8 = (nint)0 == 0;
		object obj30 = !flag8;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v6+E4]");
			bool flag9 = (nint)0 == 0;
			object obj31 = !flag9;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj32 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v13+B8]");
				obj29 = 0;
			}
			object obj33 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 736;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj34 = (nint)0 + (nint)1344;
			Func<double, double, Vector2> func2 = default(Func<double, double, Vector2>);
			func2..ctor(obj29, (IntPtr)obj34);
			object obj35 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v12+B8]");
			object obj36 = (nint)0 + (nint)104;
			obj36 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func = func2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DEDA70");
		IEnumerable<Vector2> source = default(IEnumerable<Vector2>);
		return Enumerable.ToList(source);
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj37 = default(object);
		num = (nint)obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v40+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v188 @ X0_v40] (should have been resolved before IL gen)");
		bool flag10 = obj10 == null;
		object obj38 = !flag10;
		obj4 = obj5;
		if (obj38 != null)
		{
			goto IL_01cd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v40+8]");
		obj11 = 0;
		goto IL_0505;
		IL_01cd:
		obj25 = typeof(UsageHint) + 664;
		obj23 = "com.unity.services.authentication.profile" + 2728;
		object obj39 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v23+12E]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v23+12E]");
		if ((nint)0 == 0)
		{
			goto IL_028c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v23+B0]");
		object obj41 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X10_v20-8]");
			if (0 == (nint)obj25)
			{
				break;
			}
			obj4 = obj41 + 16;
			obj40--;
			bool flag11 = (nint)obj40 != 1;
			obj41 = obj4;
			if (flag11)
			{
				continue;
			}
			goto IL_028c;
		}
		object obj42 = obj41 + 8;
		object obj43 = obj39 + obj42;
		obj15 = obj43 + 312;
		obj4 = obj41;
		goto IL_063e;
		IL_0452:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj11 = 8;
		object obj44 = default(object);
		obj14 = obj44;
		array = array2;
		goto IL_06ea;
		IL_0505:
		ex = new NullReferenceException();
		goto IL_0513;
		IL_0341:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj45 = default(object);
		num = (nint)obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v31+8]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v492 @ X0_v31] (should have been resolved before IL gen)");
		bool flag12 = ex == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v31+8]");
		obj11 = 0;
		obj5 = obj4;
		array = array2;
		if (!flag12)
		{
			goto IL_03aa;
		}
		goto IL_0505;
	}

	public static List<MatchData> GetTournamentMatches(Room room)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0044: Expected I, but got O
		//IL_0054: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_008f: Expected O, but got I
		//IL_012f: Expected I, but got O
		//IL_013f: Expected O, but got I
		//IL_01d5: Expected O, but got I
		//IL_01f9: Expected O, but got I4
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_0245: Expected O, but got I
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0277: Expected O, but got I4
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_034b: Expected O, but got I
		//IL_017a: Expected O, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_03da: Expected O, but got I4
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected O, but got Unknown
		//IL_0386: Expected O, but got I
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02f8: Expected O, but got I
		//IL_048c: Expected O, but got I
		//IL_049c: Expected O, but got I
		//IL_04be: Expected O, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_052f: Expected O, but got I
		//IL_0425: Expected O, but got I
		//IL_0435: Expected O, but got I
		//IL_0457: Expected O, but got I4
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_04ee: Expected O, but got I4
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected O, but got Unknown
		//IL_0753: Expected O, but got I
		//IL_0764: Expected I, but got O
		//IL_0782: Expected O, but got I
		//IL_051e: Expected O, but got I
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_05f9: Expected O, but got I
		//IL_060a: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass58_0 <>c__DisplayClass58_ = default(<>c__DisplayClass58_0);
		<>c__DisplayClass58_..ctor();
		object obj2;
		object obj3;
		object obj9;
		object obj13;
		if (room != null)
		{
			obj2 = typeof(RegisteredWaitHandle) + 1376;
			obj3 = "java.io.FileOutputStream" + 3672;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X10_v19-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00d0;
			}
			object obj6 = obj5 + 35;
			object obj7 = num + obj6;
			object obj8 = obj7 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v53+8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v301 @ X0_v53] (should have been resolved before IL gen)");
			object obj11 = default(object);
			object obj10 = obj11 & 1;
			bool flag = obj10 == null;
			object obj12 = !flag;
			obj13 = obj3;
			if (obj12 != null)
			{
				goto IL_0127;
			}
			goto IL_028d;
		}
		goto IL_0634;
		IL_06de:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v476 @ X8_v16] (should have been resolved before IL gen)");
		object obj14 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2472;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v30+E4]");
		object obj16;
		Func<object, object> func;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v30+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v31+70]");
			func = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v31+70]");
			bool flag2 = (nint)0 == 0;
			object obj17 = !flag2;
			if (obj17 == null)
			{
				goto IL_04cc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v30+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v31+70]");
			func = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v31+70]");
			bool flag3 = (nint)0 == 0;
			object obj18 = !flag3;
			if (obj18 == null)
			{
				goto IL_04cc;
			}
		}
		goto IL_0523;
		IL_0523:
		object obj19 = (nint)0 + (nint)488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3020370");
		if (<>c__DisplayClass58_ != null)
		{
			object obj20 = <>c__DisplayClass58_ + 16;
			object obj21 = default(object);
			obj20 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			TournamentData tournamentInfo = GetTournamentInfo(room);
			if (tournamentInfo != null)
			{
				int count = tournamentInfo.<Size>k__BackingField - 1;
				IEnumerable<int> source = Enumerable.Range(1, count);
				object obj22 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1904;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj23 = (nint)0 + (nint)1416;
				Func<int, object> func2 = default(Func<int, object>);
				func2..ctor((object)<>c__DisplayClass58_, (IntPtr)obj23);
				IEnumerable<object> source2 = Enumerable.Select(source, func2);
				return (List<MatchData>)(object)Enumerable.ToList(source2);
			}
		}
		goto IL_0634;
		IL_01bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v43+8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v356 @ X0_v43] (should have been resolved before IL gen)");
		object obj25 = default(object);
		bool flag4 = obj25 == null;
		object obj26 = !flag4;
		if (obj26 != null)
		{
			goto IL_031f;
		}
		goto IL_0634;
		IL_031f:
		object obj27 = typeof(UsageHint) + 664;
		object obj28 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v15+12E]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v15+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03c7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v15+B0]");
		object obj30 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X10_v9-8]");
			if (0 == (nint)obj27)
			{
				break;
			}
			obj30 += 16;
			obj29--;
			if ((nint)obj29 != 1)
			{
				continue;
			}
			goto IL_03c7;
		}
		object obj31 = obj30 + 8;
		object obj32 = obj28 + obj31;
		object obj33 = obj32 + 312;
		goto IL_06de;
		IL_04cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v30+E4]");
		bool flag5 = (nint)0 == 0;
		object obj34 = !flag5;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj35 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v37+B8]");
			obj16 = 0;
		}
		object obj36 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj37 = (nint)0 + (nint)1408;
		Func<object, object> func3 = default(Func<object, object>);
		func3..ctor(obj16, (IntPtr)obj37);
		object obj38 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v36+B8]");
		object obj39 = (nint)0 + (nint)112;
		obj39 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		func = func3;
		goto IL_0523;
		IL_00d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v50+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v198 @ X0_v50] (should have been resolved before IL gen)");
		object obj41 = default(object);
		object obj40 = obj41 & 1;
		bool flag6 = obj40 == null;
		obj13 = obj3;
		if (!flag6)
		{
			goto IL_0127;
		}
		goto IL_028d;
		IL_028d:
		object obj42 = typeof(List<AdaptivePerformanceScaler>) + 2256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		return (List<MatchData>)(object)list;
		IL_0127:
		nint num2 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01bb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj44 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X10_v14-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj44 += 16;
			obj43--;
			if ((nint)obj43 != 1)
			{
				continue;
			}
			goto IL_01bb;
		}
		object obj45 = obj44 + 31;
		object obj46 = num2 + obj45;
		object obj47 = obj46 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v46+8]");
		obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v381 @ X0_v46] (should have been resolved before IL gen)");
		if (obj25 != null)
		{
			goto IL_031f;
		}
		goto IL_0634;
		IL_0634:
		return (List<MatchData>)(object)new NullReferenceException();
		IL_03c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj24 = 8;
		object obj48 = default(object);
		obj33 = obj48;
		goto IL_06de;
	}

	public static List<MatchData> GetParentMatches(Room room, int matchID, int tournamentSize)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0054: Expected O, but got I
		//IL_00c4: Expected O, but got I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01e0: Expected O, but got I
		//IL_0201: Expected O, but got I4
		//IL_0284: Expected O, but got I
		//IL_0294: Expected O, but got I
		//IL_02a4: Expected O, but got I
		//IL_02ce: Expected I, but got O
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_026f: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		int firstParentId = TournamentMath.GetFirstParentId(matchID, tournamentSize);
		MatchData tournamentMatch = GetTournamentMatch(room, firstParentId);
		if (list != null)
		{
			object obj2 = (nint)0 + (nint)3920;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			if (list._items != null)
			{
				bool flag = list._size < items.Length;
				object obj3 = !flag;
				if (obj3 == null)
				{
					int size = list._size + 1;
					list._size = size;
					object obj4 = list._items + list._size;
					object obj5 = obj4 + 32;
					obj5 = tournamentMatch;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				else
				{
					list.AddWithResize((object)tournamentMatch);
				}
				int secondParentId = TournamentMath.GetSecondParentId(matchID, tournamentSize);
				MatchData tournamentMatch2 = GetTournamentMatch(room, secondParentId);
				object obj6 = obj2;
				int version2 = list._version + 1;
				list._version = version2;
				object[] items2 = list._items;
				if (list._items != null)
				{
					object obj7 = typeof(List<Tween>) + 3336;
					object obj8 = (nint)0 + (nint)3280;
					bool flag2 = list._size < items2.Length;
					object obj9 = !flag2;
					if (obj9 == null)
					{
						int size2 = list._size + 1;
						list._size = size2;
						object obj10 = list._items + list._size;
						object obj11 = obj10 + 32;
						obj11 = tournamentMatch2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj12 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v6+20]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v8+C0]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v9+70]");
						object obj12 = 0;
						list.AddWithResize((object)tournamentMatch2);
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Predicate<object> predicate = default(Predicate<object>);
					predicate..ctor((object)null, (IntPtr)obj8);
					int num = list.RemoveAll(predicate);
					return (List<MatchData>)(object)list;
				}
			}
		}
		return (List<MatchData>)(object)new NullReferenceException();
	}

	public static MatchData GetTournamentMatch(Room room, int matchId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_006e: Expected I, but got O
		//IL_007e: Expected O, but got I
		//IL_0114: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0181: Expected O, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_0261: Expected O, but got I
		//IL_0272: Expected I, but got O
		//IL_027e: Expected O, but got I
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass60_0 <>c__DisplayClass60_ = default(<>c__DisplayClass60_0);
		<>c__DisplayClass60_..ctor();
		object obj3;
		object obj9;
		if (<>c__DisplayClass60_ != null)
		{
			<>c__DisplayClass60_.matchId = matchId;
			if (room != null)
			{
				object obj2 = typeof(RegisteredWaitHandle) + 1376;
				obj3 = "java.io.FileOutputStream" + 3672;
				nint num = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00fa;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X10_v7-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj5 += 16;
					obj4--;
					if ((nint)obj4 != 1)
					{
						continue;
					}
					goto IL_00fa;
				}
				object obj6 = obj5 + 35;
				object obj7 = num + obj6;
				object obj8 = obj7 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v24+8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v265 @ X0_v24] (should have been resolved before IL gen)");
				object obj10 = default(object);
				bool flag = obj10 == null;
				object obj11 = obj3;
				if (!flag)
				{
					goto IL_01b0;
				}
				goto IL_02b6;
			}
		}
		goto IL_02f2;
		IL_01b0:
		if (<>c__DisplayClass60_.matchId >= 1)
		{
			TournamentData tournamentInfo = GetTournamentInfo(room);
			if (tournamentInfo == null)
			{
				goto IL_02f2;
			}
			if (<>c__DisplayClass60_.matchId < tournamentInfo.<Size>k__BackingField)
			{
				List<MatchData> tournamentMatches = GetTournamentMatches(room);
				object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj13 = (nint)0 + (nint)1432;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor((object)<>c__DisplayClass60_, (IntPtr)obj13);
				object obj14 = (nint)0 + (nint)1024;
				MatchData matchData = (MatchData)Enumerable.FirstOrDefault(tournamentMatches, func);
				if (matchData != null)
				{
					return matchData;
				}
				object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3856;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				MatchData matchData2 = default(MatchData);
				matchData2..ctor(<>c__DisplayClass60_.matchId);
				return matchData2;
			}
		}
		goto IL_02b6;
		IL_02b6:
		return null;
		IL_00fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v21+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ X0_v21] (should have been resolved before IL gen)");
		object obj16 = default(object);
		if (obj16 != null)
		{
			object obj11 = obj3;
			goto IL_01b0;
		}
		goto IL_02b6;
		IL_02f2:
		return (MatchData)(object)new NullReferenceException();
	}

	public static bool IsMassTournament(Room room)
	{
		//IL_037b: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0171: Expected I, but got O
		//IL_0181: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_0217: Expected O, but got I
		//IL_01bc: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_014c: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_032d: Expected O, but got I
		//IL_0351: Expected O, but got I4
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_02ae: Expected O, but got I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		object obj;
		if (room != null)
		{
			obj = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X10_v13-8]");
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
			object obj4 = obj3 + 6;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v211 @ X0_v28] (should have been resolved before IL gen)");
			object obj8 = default(object);
			object obj7 = obj8 & 1;
			bool flag = obj7 == null;
			object obj9 = !flag;
			if (obj9 == null)
			{
				goto IL_015a;
			}
			goto IL_0367;
		}
		goto IL_036d;
		IL_015a:
		object obj10 = "m_StencilDeferredPS" + 1456;
		nint num2 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01fd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X10_v8-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_01fd;
		}
		object obj13 = obj12 + 35;
		object obj14 = num2 + obj13;
		object obj15 = obj14 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v21+8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v309 @ X0_v21] (should have been resolved before IL gen)");
		object obj17 = default(object);
		bool flag2 = obj17 == null;
		object obj18 = !flag2;
		object obj19 = obj10;
		if (obj18 != null)
		{
			goto IL_0246;
		}
		goto IL_0367;
		IL_0367:
		return false;
		IL_01fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v18+8]");
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v293 @ X0_v18] (should have been resolved before IL gen)");
		object obj20 = default(object);
		bool flag3 = obj20 == null;
		obj19 = obj10;
		if (!flag3)
		{
			goto IL_0246;
		}
		goto IL_0367;
		IL_0246:
		MassTournamentInfo massTournamentInfo = GetMassTournamentInfo(room);
		if (massTournamentInfo != null)
		{
			object obj21 = typeof(DataRelation) + 712;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj23 = !flag4;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			return massTournamentInfo.<FinishTime>k__BackingField > now;
		}
		goto IL_036d;
		IL_036d:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ X0_v25] (should have been resolved before IL gen)");
		object obj25 = default(object);
		object obj24 = obj25 & 1;
		if (obj24 == null)
		{
			goto IL_015a;
		}
		goto IL_0367;
	}

	public static MassTournamentInfo GetMassTournamentInfo(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_00fa: Expected O, but got I4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_019b: Expected I, but got O
		//IL_01ab: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_0241: Expected O, but got I
		//IL_0265: Expected O, but got I4
		//IL_026e: Expected O, but got I4
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_01e6: Expected O, but got I
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0150: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02c2: Expected O, but got I
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		MassTournamentInfo massTournamentInfo = default(MassTournamentInfo);
		MassTournamentInfo massTournamentInfo2;
		object obj8;
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			object obj2 = "m_StencilDeferredPS" + 1456;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X10_v12-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj5 = obj4 + 31;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v17+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v198 @ X0_v17] (should have been resolved before IL gen)");
			bool flag = massTournamentInfo == null;
			massTournamentInfo2 = massTournamentInfo;
			if (flag)
			{
				goto IL_0110;
			}
			goto IL_017f;
		}
		return null;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v14+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ X0_v14] (should have been resolved before IL gen)");
		bool flag2 = massTournamentInfo == null;
		object obj9 = !flag2;
		massTournamentInfo2 = massTournamentInfo;
		if (obj9 == null)
		{
			goto IL_0110;
		}
		goto IL_017f;
		IL_02f1:
		object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MassTournamentInfo massTournamentInfo3 = default(MassTournamentInfo);
		MassTournamentInfo massTournamentInfo4 = default(MassTournamentInfo);
		massTournamentInfo3..ctor((ISFSObject)massTournamentInfo4);
		return massTournamentInfo3;
		IL_017f:
		object obj11 = typeof(UsageHint) + 664;
		nint num2 = (nint)massTournamentInfo2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v9 (Il2CppClass<MassTournamentInfo>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v9 (Il2CppClass<MassTournamentInfo>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0227;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v9 (Il2CppClass<MassTournamentInfo>)+B0]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X10_v6-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj13 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_0227;
		}
		object obj14 = obj13 + 7;
		object obj15 = num2 + obj14;
		object obj16 = obj15 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v15+8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v238 @ X8_v15] (should have been resolved before IL gen)");
		bool flag3 = massTournamentInfo == null;
		massTournamentInfo4 = massTournamentInfo;
		if (flag3)
		{
			goto IL_0110;
		}
		goto IL_02f1;
		IL_0227:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v8+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v277 @ X0_v8] (should have been resolved before IL gen)");
		bool flag4 = massTournamentInfo4 == null;
		object obj18 = !flag4;
		obj8 = 7;
		if (obj18 == null)
		{
			return massTournamentInfo4;
		}
		goto IL_02f1;
		IL_0110:
		return massTournamentInfo;
	}

	public static TimeSpan GetMassMaxStageDelay(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_01ae: Expected O, but got I
		//IL_01c8: Expected O, but got I4
		//IL_0079: Expected O, but got I
		//IL_01fe: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_02e9: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0283: Expected F8, but got I4
		//IL_0267: Expected F8, but got I4
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "m_StencilDeferredPS" + 2576;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E40]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			obj6 = obj2;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_021d;
		IL_02bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v177 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		int num2 = SFSExtensions.Get(variable, 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			return TimeSpan.FromSeconds(num2);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return TimeSpan.FromSeconds(num2);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_02bd;
		IL_00c3:
		object obj11 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj11;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj13 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj14 = obj13 + 31;
		object obj15 = num + obj14;
		object obj16 = obj15 + 312;
		obj4 = obj6;
		goto IL_02bd;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_021d;
		IL_021d:
		throw new NullReferenceException();
	}

	public static int GetMassActiveStage(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "alignContent" + 2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E41]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static int? GetMassActivePlayWindow(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_01b9: Expected O, but got I4
		//IL_007b: Expected O, but got I
		//IL_023e: Expected I, but got O
		//IL_024e: Expected O, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_01a5: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_0108: Expected O, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		object obj;
		if (room != null)
		{
			obj = typeof(RegisteredWaitHandle) + 1376;
			object obj2 = "alignContent" + 2336;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X10_v12-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj5 = obj4 + 35;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v203 @ X0_v23] (should have been resolved before IL gen)");
			object obj8 = default(object);
			bool flag = obj8 == null;
			object obj9 = !flag;
			if (obj9 != null)
			{
				goto IL_0236;
			}
			goto IL_01b3;
		}
		return (int?)new NullReferenceException();
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ X0_v20] (should have been resolved before IL gen)");
		object obj10 = default(object);
		if (obj10 == null)
		{
			goto IL_01b3;
		}
		goto IL_0236;
		IL_0149:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0297;
		IL_01b3:
		return (int?)(object)0;
		IL_0236:
		nint num2 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0149;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X10_v7-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_0149;
		}
		object obj13 = obj12 + 31;
		object obj14 = num2 + obj13;
		object obj15 = obj14 + 312;
		goto IL_0297;
		IL_0297:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v300 @ X0_v7] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
	}

	public static int GetMassActiveStagePointsToPass(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "___# Content push apply failed [{0}]: {1}" + 3960;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E43]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static DateTime? GetMassActiveClusterStartTime(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_02b2: Expected O, but got I4
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "___# Content push apply failed [{0}]: {1}" + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E44]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E21]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E21]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E21]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E21]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, (DateTime?)(object)0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static int GetFriendlyChallengeLevel(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_00ef: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "destinationTimeZone" + 4000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E45]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E1F]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5000]");
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_009e;
			}
		}
		_ = 1;
		bool flag3 = room == null;
		object obj9 = !flag3;
		obj4 = obj6;
		num = 1;
		if (obj9 != null)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_029a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v1] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return SFSExtensions.Get(variable, 0);
		IL_016b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_029a;
		IL_00c3:
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v2-8]");
			bool flag4 = 0 == (nint)obj10;
			obj6 = obj4;
			if (flag4)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj13 = obj12 + 31;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		obj4 = obj6;
		goto IL_029a;
		IL_009e:
		bool flag5 = room == null;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00c3;
		}
		goto IL_022d;
		IL_022d:
		throw new NullReferenceException();
	}

	public static GiftBombData GetActiveBombInfo(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_00fa: Expected O, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0199: Expected I, but got O
		//IL_01a9: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_023f: Expected O, but got I
		//IL_0263: Expected O, but got I4
		//IL_026c: Expected O, but got I4
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_01e4: Expected O, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_014e: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02c0: Expected O, but got I
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		GiftBombData giftBombData = default(GiftBombData);
		GiftBombData giftBombData2;
		object obj8;
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			object obj2 = "___# Content push apply failed [{0}]: {1}" + 2736;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v12-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj5 = obj4 + 31;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v17+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v194 @ X0_v17] (should have been resolved before IL gen)");
			bool flag = giftBombData == null;
			giftBombData2 = giftBombData;
			if (flag)
			{
				goto IL_0110;
			}
			goto IL_017d;
		}
		return (GiftBombData)(object)new NullReferenceException();
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v14+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ X0_v14] (should have been resolved before IL gen)");
		bool flag2 = giftBombData == null;
		object obj9 = !flag2;
		giftBombData2 = giftBombData;
		if (obj9 == null)
		{
			goto IL_0110;
		}
		goto IL_017d;
		IL_02ef:
		object obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftBombData giftBombData3 = default(GiftBombData);
		GiftBombData giftBombData4 = default(GiftBombData);
		giftBombData3..ctor((ISFSObject)giftBombData4);
		return giftBombData3;
		IL_017d:
		object obj11 = typeof(UsageHint) + 664;
		nint num2 = (nint)giftBombData2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v9 (Il2CppClass<GiftBombData>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v9 (Il2CppClass<GiftBombData>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0225;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v9 (Il2CppClass<GiftBombData>)+B0]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X10_v6-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj13 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_0225;
		}
		object obj14 = obj13 + 7;
		object obj15 = num2 + obj14;
		object obj16 = obj15 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v15+8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v234 @ X8_v15] (should have been resolved before IL gen)");
		bool flag3 = giftBombData == null;
		giftBombData4 = giftBombData;
		if (flag3)
		{
			goto IL_0110;
		}
		goto IL_02ef;
		IL_0225:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v8+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v273 @ X0_v8] (should have been resolved before IL gen)");
		bool flag4 = giftBombData4 == null;
		object obj18 = !flag4;
		obj8 = 7;
		if (obj18 == null)
		{
			return giftBombData4;
		}
		goto IL_02ef;
		IL_0110:
		return giftBombData;
	}
}
