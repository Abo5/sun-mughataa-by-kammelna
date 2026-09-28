using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace KammelnaOffline.Baloot;

public static class BalootUtils
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<BalootProject, BalootProject> <>9__1_0;

		public static Func<Card, bool> <>9__2_0;

		public static Func<Suit, Card> <>9__2_1;

		public static Func<Card, bool> <>9__4_0;

		public static Func<Card, Rank> <>9__4_1;

		public static Func<IGrouping<Rank, Card>, bool> <>9__4_2;

		public static Func<Card, Suit> <>9__8_0;

		public static Func<IGrouping<Suit, Card>, bool> <>9__8_1;

		public static Func<List<Card>, Rank> <>9__8_2;

		public static Func<int, bool> <>9__9_1;

		public static Func<Card, Suit> <>9__17_0;

		public static Func<Suit, int> <>9__19_0;

		public static Func<Card, Suit> <>9__19_1;

		public static Func<KeyValuePair<Suit, int>, IComparable> <>9__19_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2680;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal BalootProject <CheckProjects>b__1_0(BalootProject project)
		{
			return project;
		}

		internal bool <CheckProject400>b__2_0(Card card)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (card != null)
			{
				object obj = card.<Rank>k__BackingField - 12;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal Card <CheckProject400>b__2_1(Suit suit)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Card card = default(Card);
			card..ctor(Rank.ACE, suit);
			return card;
		}

		internal bool <CheckProject100SameRank>b__4_0(Card card)
		{
			//IL_00c8: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_00a8: Expected O, but got I4
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected I4, but got Unknown
			if (card != null)
			{
				object obj = card.<Rank>k__BackingField - 7;
				bool flag = (nint)obj < 0;
				bool flag2 = obj == null;
				object obj2 = card.<Rank>k__BackingField ^ Rank.NINE;
				object obj3 = card.<Rank>k__BackingField ^ obj;
				object obj4 = obj2 & obj3;
				bool flag3 = (nint)obj4 < 0;
				bool flag4 = flag == flag3;
				object obj5 = !flag2;
				return (byte)((flag4 & obj5) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal Rank <CheckProject100SameRank>b__4_1(Card card)
		{
			//IL_0035: Expected I4, but got O
			if (card != null)
			{
				return card.<Rank>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Rank)ex;
		}

		internal bool <CheckProject100SameRank>b__4_2(IGrouping<Rank, Card> cards)
		{
			//IL_0021: Expected O, but got I4
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected I4, but got Unknown
			//IL_008f: Expected O, but got I4
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected I4, but got Unknown
			int num = Enumerable.Count((IEnumerable<object>)cards);
			object obj = num - 3;
			bool flag = (nint)obj < 0;
			bool flag2 = obj == null;
			int num2 = num ^ 3;
			int num3 = num ^ obj;
			int num4 = num2 & num3;
			bool flag3 = num4 < 0;
			bool flag4 = flag == flag3;
			object obj2 = !flag2;
			return (byte)((flag4 & obj2) ? 1 : 0) != 0;
		}

		internal Suit <FindSequenceProject>b__8_0(Card card)
		{
			//IL_0035: Expected I4, but got O
			if (card != null)
			{
				return card.<Suit>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Suit)ex;
		}

		internal bool <FindSequenceProject>b__8_1(IGrouping<Suit, Card> cards)
		{
			//IL_0021: Expected O, but got I4
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected I4, but got Unknown
			//IL_008f: Expected O, but got I4
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected I4, but got Unknown
			int num = Enumerable.Count((IEnumerable<object>)cards);
			object obj = num - 2;
			bool flag = (nint)obj < 0;
			bool flag2 = obj == null;
			int num2 = num ^ 2;
			int num3 = num ^ obj;
			int num4 = num2 & num3;
			bool flag3 = num4 < 0;
			bool flag4 = flag == flag3;
			object obj2 = !flag2;
			return (byte)((flag4 & obj2) ? 1 : 0) != 0;
		}

		internal Rank <FindSequenceProject>b__8_2(List<Card> list)
		{
			//IL_0021: Expected I4, but got O
			object obj = Enumerable.First((IEnumerable<object>)list);
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Object)+10]");
				return Rank.TWO;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Rank)ex;
		}

		internal bool <GetBestProjectTeam>b__9_1(int i)
		{
			//IL_0060: Expected O, but got I4
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected I4, but got Unknown
			bool flag = i < 0;
			bool flag2 = i == 0;
			int num = i ^ i;
			int num2 = i & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			return (byte)((flag4 & obj) ? 1 : 0) != 0;
		}

		internal Suit <CheckIfAiCouldBuySun>b__17_0(Card card)
		{
			//IL_0035: Expected I4, but got O
			if (card != null)
			{
				return card.<Suit>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Suit)ex;
		}

		internal int <CheckIfAiCouldBuyHokom2>b__19_0(Suit s)
		{
			return 0;
		}

		internal Suit <CheckIfAiCouldBuyHokom2>b__19_1(Card card)
		{
			//IL_0035: Expected I4, but got O
			if (card != null)
			{
				return card.<Suit>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Suit)ex;
		}

		internal IComparable <CheckIfAiCouldBuyHokom2>b__19_2(KeyValuePair<Suit, int> pair)
		{
			//IL_0015: Expected O, but got I4
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			IComparable result = default(IComparable);
			return result;
		}
	}

	private sealed class <>c__DisplayClass13_0
	{
		public Suit trumpSuit;

		internal bool <PlayableCards>b__0(Card card)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (card != null)
			{
				object obj = card.<Suit>k__BackingField - trumpSuit;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass14_0
	{
		public Suit type;

		internal bool <GetSuitCards>b__0(Card t)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (t != null)
			{
				object obj = t.<Suit>k__BackingField - type;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public Suit trumpSuit;

		public BalootGame.BalootGameMode gameMode;

		internal int <CalculateEatingScore>b__0(Card card)
		{
			//IL_02be: Expected I4, but got O
			//IL_0155: Expected O, but got I4
			//IL_016f: Expected O, but got I4
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Expected O, but got Unknown
			//IL_0197: Expected O, but got I4
			//IL_0110: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_009c: Expected O, but got I4
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_022f: Expected O, but got I4
			//IL_0249: Expected O, but got I4
			//IL_0252: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Expected O, but got Unknown
			//IL_0271: Expected O, but got I4
			//IL_01e0: Expected O, but got I4
			//IL_02a3: Expected O, but got I4
			Rank rank;
			bool flag4;
			int result;
			int num;
			if (card != null)
			{
				Rank <Rank>k__BackingField;
				bool flag5;
				if (card.<Suit>k__BackingField == trumpSuit)
				{
					object obj = gameMode - 2;
					bool flag = obj == null;
					rank = card.<Rank>k__BackingField;
					object obj2 = card.<Rank>k__BackingField - 8;
					bool flag2 = (nint)obj2 < 4;
					object obj3 = !flag2;
					object obj4 = obj2 - 4;
					bool flag3 = obj4 == null;
					object obj5 = ~obj3;
					object obj6 = obj5 | flag3;
					flag4 = flag;
					<Rank>k__BackingField = card.<Rank>k__BackingField;
					flag5 = flag;
					if (obj6 == null)
					{
						goto IL_00fa;
					}
				}
				else
				{
					rank = card.<Rank>k__BackingField;
					object obj2 = card.<Rank>k__BackingField - 8;
					bool flag6 = (nint)obj2 < 4;
					object obj7 = !flag6;
					object obj8 = obj2 - 4;
					bool flag7 = obj8 == null;
					object obj9 = !flag7;
					object obj10 = obj7 & obj9;
					flag4 = false;
					<Rank>k__BackingField = card.<Rank>k__BackingField;
					flag5 = false;
					if (obj10 != null)
					{
						goto IL_00fa;
					}
				}
				object obj11 = 119877632 + 1160;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X11_v3+v88 @ X10_v2*4]");
				result = 0;
				bool flag8 = !flag5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X11_v3+v88 @ X10_v2*4]");
				num = 0;
				rank = <Rank>k__BackingField;
				if (flag8)
				{
					goto IL_0130;
				}
				goto IL_0221;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_00fa:
			bool flag9 = !flag4;
			object obj12 = !flag9;
			result = 0;
			num = 0;
			if (obj12 == null)
			{
				goto IL_0130;
			}
			goto IL_0221;
			IL_0221:
			object obj13 = rank - 5;
			bool flag10 = (nint)obj13 < 7;
			object obj14 = !flag10;
			object obj15 = obj13 - 7;
			bool flag11 = obj15 == null;
			object obj16 = !flag11;
			object obj17 = obj14 & obj16;
			result = num;
			if (obj17 == null)
			{
				object obj18 = 119877632 + 1180;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X9_v4+v162 @ X8_v3*4]");
				return 0;
			}
			goto IL_0130;
			IL_0130:
			return result;
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public Rank rank;

		internal bool <ContainsRank>b__0(Card card)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (card != null)
			{
				object obj = card.<Rank>k__BackingField - rank;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public BalootGame.BalootGameMode gameMode;

		internal int <GetBestProjectTeam>b__0(List<Card> cards)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_006a: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2048;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return BalootProjectUtility.ProjectPrecedence(cards, gameMode);
		}
	}

	public static List<ProjectsUtility<BalootProject>.Project> GetBestProjects(List<Card> playerCards, BalootGame.BalootGameMode gameMode)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0086: Expected O, but got I4
		//IL_0036: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2048;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = gameMode - 2;
		bool isHokom = obj4 == null;
		return BalootProjectUtility.BestProjectCards(playerCards, null, isHokom);
	}

	public unsafe static List<ProjectsUtility<BalootProject>.Project> CheckProjects(List<BalootProject> definedProjects, List<Card> cards, BalootGame.BalootGameMode gameMode)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0038: Expected O, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0058: Expected O, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_00a1: Expected I, but got O
		//IL_00af: Expected I, but got O
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected O, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected O, but got Unknown
		//IL_0586: Expected O, but got Ref
		//IL_058f: Expected O, but got I4
		//IL_05a1: Expected O, but got I4
		//IL_05aa: Expected O, but got I4
		//IL_05b3: Expected O, but got I4
		//IL_05c4: Expected O, but got I4
		//IL_05cc: Expected O, but got Ref
		//IL_05d5: Expected O, but got I4
		//IL_05f5: Expected O, but got Ref
		//IL_00e9: Expected O, but got I
		//IL_00f5: Expected O, but got I
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected O, but got Unknown
		//IL_063f: Expected O, but got I
		//IL_064b: Expected O, but got I
		//IL_066d: Expected O, but got I4
		//IL_067e: Expected O, but got I4
		//IL_0687: Expected O, but got I4
		//IL_0690: Expected O, but got I4
		//IL_03e2: Expected O, but got I
		//IL_0402: Expected O, but got I
		//IL_0424: Expected O, but got I4
		//IL_0434: Expected O, but got I
		//IL_07a5: Expected I, but got O
		//IL_07b5: Expected O, but got I
		//IL_01ca: Expected I, but got O
		//IL_0214: Expected I, but got O
		//IL_015d: Expected O, but got I
		//IL_017d: Expected O, but got I
		//IL_01a4: Expected O, but got I
		//IL_0474: Expected O, but got I4
		//IL_1820: Unknown result type (might be due to invalid IL or missing references)
		//IL_1825: Expected O, but got Unknown
		//IL_07f0: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Expected I, but got O
		//IL_025e: Expected O, but got I
		//IL_1751: Expected O, but got I
		//IL_1760: Unknown result type (might be due to invalid IL or missing references)
		//IL_1765: Expected O, but got Unknown
		//IL_177b: Expected O, but got I
		//IL_178c: Expected I, but got O
		//IL_178c: Expected O, but got I
		//IL_1794: Expected I, but got O
		//IL_17aa: Expected O, but got I
		//IL_1241: Expected O, but got Ref
		//IL_124a: Expected O, but got I4
		//IL_17d1: Expected O, but got I
		//IL_0328: Expected O, but got I4
		//IL_0330: Expected O, but got Ref
		//IL_0339: Expected O, but got I4
		//IL_04b1: Expected I, but got O
		//IL_04dc: Expected O, but got I4
		//IL_0506: Expected I, but got O
		//IL_0516: Expected O, but got I
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Expected O, but got Unknown
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Expected O, but got Unknown
		//IL_0299: Expected O, but got I
		//IL_192d: Expected O, but got I4
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected O, but got Unknown
		//IL_0819: Expected O, but got I
		//IL_036a: Expected O, but got I4
		//IL_0373: Expected O, but got I4
		//IL_037c: Expected O, but got I4
		//IL_038d: Expected O, but got I4
		//IL_0395: Expected O, but got Ref
		//IL_039e: Expected O, but got I4
		//IL_03b7: Expected O, but got Ref
		//IL_16fd: Expected O, but got I
		//IL_125e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1263: Expected O, but got Unknown
		//IL_126b: Expected I, but got O
		//IL_127b: Expected O, but got I
		//IL_08ae: Expected I, but got O
		//IL_08be: Expected O, but got I
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_12b6: Expected O, but got I
		//IL_1891: Unknown result type (might be due to invalid IL or missing references)
		//IL_1896: Expected O, but got Unknown
		//IL_18b0: Expected O, but got I4
		//IL_08f9: Expected O, but got I
		//IL_199b: Expected O, but got I
		//IL_1852: Expected O, but got I
		//IL_132f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1334: Expected O, but got Unknown
		//IL_133d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1342: Expected O, but got Unknown
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_0977: Expected O, but got Unknown
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected O, but got Unknown
		//IL_12c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c9: Expected O, but got Unknown
		//IL_12df: Expected O, but got I
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Expected O, but got Unknown
		//IL_0922: Expected O, but got I
		//IL_10e3: Expected O, but got I4
		//IL_10ec: Expected O, but got I4
		//IL_10f5: Expected O, but got I4
		//IL_0f56: Expected O, but got Ref
		//IL_143f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1444: Expected O, but got Unknown
		//IL_0787: Expected O, but got Ref
		//IL_0fa2: Expected O, but got Ref
		//IL_18e3: Expected O, but got Ref
		//IL_1905: Expected O, but got I4
		//IL_1472: Expected O, but got I
		//IL_15ec: Expected O, but got Ref
		//IL_0fc5: Expected O, but got I
		//IL_0fda: Expected O, but got I
		//IL_0de8: Expected O, but got I
		//IL_0dfd: Expected O, but got I
		//IL_0e25: Expected I4, but got O
		//IL_101f: Expected O, but got I
		//IL_102f: Expected O, but got I
		//IL_1058: Expected O, but got I4
		//IL_0c45: Expected O, but got I
		//IL_0c5a: Expected O, but got I
		//IL_0c82: Expected I4, but got O
		//IL_0e43: Expected O, but got I
		//IL_0e53: Expected O, but got I
		//IL_0e7c: Expected O, but got I4
		//IL_06ad: Expected O, but got I
		//IL_06bd: Expected O, but got I
		//IL_1123: Expected O, but got I
		//IL_1133: Expected O, but got I
		//IL_0a6d: Expected O, but got I
		//IL_0a82: Expected O, but got I
		//IL_0aaa: Expected I4, but got O
		//IL_06e7: Expected I, but got O
		//IL_070a: Expected O, but got I4
		//IL_0713: Expected O, but got I4
		//IL_107c: Expected O, but got I
		//IL_109e: Expected O, but got I
		//IL_10a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ac: Expected O, but got Unknown
		//IL_10b4: Expected O, but got I4
		//IL_0ca0: Expected O, but got I
		//IL_0cb0: Expected O, but got I
		//IL_0cd9: Expected O, but got I4
		//IL_115d: Expected I, but got O
		//IL_0ea0: Expected O, but got I
		//IL_0ec2: Expected O, but got I
		//IL_0ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed0: Expected O, but got Unknown
		//IL_0ed9: Expected O, but got I4
		//IL_11e7: Expected O, but got I
		//IL_11f7: Expected O, but got I
		//IL_0ac8: Expected O, but got I
		//IL_0ad8: Expected O, but got I
		//IL_0b01: Expected O, but got I4
		//IL_1221: Expected I, but got O
		//IL_0cfd: Expected O, but got I
		//IL_0d1f: Expected O, but got I
		//IL_0d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2d: Expected O, but got Unknown
		//IL_0d36: Expected O, but got I4
		//IL_1185: Expected O, but got I
		//IL_1195: Expected O, but got I
		//IL_11bf: Expected I, but got O
		//IL_0b25: Expected O, but got I
		//IL_0b47: Expected O, but got I
		//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Expected O, but got Unknown
		//IL_0b5e: Expected O, but got I4
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80A6]");
		nint num = 0;
		object obj3 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3824;
		object obj4 = (nint)0 + (nint)3264;
		object obj5 = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj6 = (nint)0 + (nint)2640;
		object obj7 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3280;
		Func<System.Int32Enum, System.Int32Enum> func = (Func<System.Int32Enum, System.Int32Enum>)((nint)0 + (nint)3368);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<ProjectsUtility<System.Int32Enum>.Project> list = default(List<ProjectsUtility<System.Int32Enum>.Project>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor((IEnumerable<object>)cards);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)func;
		Comparison<object> comparison = default(Comparison<object>);
		comparison..ctor((object)null, (IntPtr)func);
		bool flag = list2 == null;
		BalootProject balootProject = BalootProject.Sira;
		Comparison<object> comparison2 = comparison;
		Func<System.Int32Enum, System.Int32Enum> func2;
		object obj10;
		Func<System.Int32Enum, System.Int32Enum> keySelector;
		Comparison<object> comparison3;
		nint num4;
		NullReferenceException ex;
		BalootProject balootProject2;
		if (!flag)
		{
			object obj8 = (nint)0 + (nint)2736;
			func2 = (Func<System.Int32Enum, System.Int32Enum>)((nint)0 + (nint)2728);
			obj7 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2680;
			list2.Sort(comparison);
			list2.Reverse();
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v103+E4]");
			nint num3;
			if ((nint)0 != 0)
			{
				obj10 = (nint)0 + (nint)2352;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v103+B8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v52 (Il2CppClass<System.NullReferenceException>)+8]");
				keySelector = (Func<System.Int32Enum, System.Int32Enum>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v52 (Il2CppClass<System.NullReferenceException>)+8]");
				bool flag2 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v52 (Il2CppClass<System.NullReferenceException>)+8]");
				Func<System.Int32Enum, System.Int32Enum> func3 = (Func<System.Int32Enum, System.Int32Enum>)0;
				obj6 = obj10;
				num3 = num;
				if (!flag2)
				{
					goto IL_01c2;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj7;
				obj10 = (nint)0 + (nint)2352;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v103+B8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v52 (Il2CppClass<System.NullReferenceException>)+8]");
				keySelector = (Func<System.Int32Enum, System.Int32Enum>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v52 (Il2CppClass<System.NullReferenceException>)+8]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v52 (Il2CppClass<System.NullReferenceException>)+8]");
				Func<System.Int32Enum, System.Int32Enum> func3 = (Func<System.Int32Enum, System.Int32Enum>)0;
				obj6 = obj10;
				num3 = num;
				if (obj11 != null)
				{
					goto IL_01c2;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v103+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v67+B8]");
				num3 = 0;
			}
			comparison3 = (Comparison<object>)num3;
			object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)960;
			Func<System.Int32Enum, System.Int32Enum> func4 = default(Func<System.Int32Enum, System.Int32Enum>);
			func4..ctor((object)num3, (IntPtr)obj15);
			num = (nint)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v52 (Il2CppClass<System.NullReferenceException>)+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num4 = (nint)obj6;
			IOrderedEnumerable<System.Int32Enum> orderedEnumerable = Enumerable.OrderByDescending((IEnumerable<System.Int32Enum>)definedProjects, func4);
			bool flag5 = orderedEnumerable == null;
			object obj17 = !flag5;
			balootProject2 = BalootProject.Sira;
			ex = (NullReferenceException)orderedEnumerable;
			func2 = func4;
			balootProject = BalootProject.Sira;
			num2 = (nint)obj6;
			func = func4;
			comparison2 = (Comparison<object>)num3;
			if (obj17 != null)
			{
				goto IL_0232;
			}
		}
		goto IL_0524;
		IL_0524:
		ex = new NullReferenceException();
		goto IL_0532;
		IL_060b:
		comparison2 = (Comparison<object>)(typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528);
		func = (Func<System.Int32Enum, System.Int32Enum>)(typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 296);
		obj7 = (nint)0 + (nint)3272;
		obj4 = (nint)0 + (nint)2952;
		ProjectsUtility<System.Int32Enum>.Project project2 = default(ProjectsUtility<System.Int32Enum>.Project);
		ProjectsUtility<System.Int32Enum>.Project project = project2;
		object obj19 = default(object);
		object obj18 = obj19;
		BalootGame.BalootGameMode balootGameMode = BalootGame.BalootGameMode.NotDetermined;
		ProjectsUtility<System.Int32Enum>.Project project3 = (ProjectsUtility<System.Int32Enum>.Project)0;
		object obj21 = default(object);
		object obj20 = obj21;
		ProjectsUtility<BalootProject>.Project project4 = (ProjectsUtility<BalootProject>.Project)0;
		ProjectsUtility<BalootProject>.Project project5 = (ProjectsUtility<BalootProject>.Project)0;
		ProjectsUtility<BalootProject>.Project project6 = (ProjectsUtility<BalootProject>.Project)0;
		List<BalootProject> list4 = default(List<BalootProject>);
		List<BalootProject> list3 = list4;
		object obj24 = default(object);
		object obj25 = default(object);
		object obj27 = default(object);
		object obj29 = default(object);
		object obj31 = default(object);
		object obj44;
		List<BalootProject> list6 = default(List<BalootProject>);
		bool flag26;
		object obj58 = default(object);
		object obj67 = default(object);
		List<ProjectsUtility<BalootProject>.Project> result = default(List<ProjectsUtility<BalootProject>.Project>);
		ArgumentOutOfRangeException ex3 = default(ArgumentOutOfRangeException);
		object obj22;
		BalootGame.BalootGameMode balootGameMode2;
		BalootGame.BalootGameMode balootGameMode3;
		object obj42;
		object obj43;
		object obj68;
		object obj45;
		nint num6;
		object obj28;
		List<BalootProject> list5;
		do
		{
			nint num5 = (nint)list3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v16 (Il2CppClass<System.Collections.Generic.List`1<BalootProject>>)+12E]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v16 (Il2CppClass<System.Collections.Generic.List`1<BalootProject>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0841;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v16 (Il2CppClass<System.Collections.Generic.List`1<BalootProject>>)+B0]");
			object obj23 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X10_v29-8]");
				obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X10_v29-8]");
				if (0 == (nint)comparison2)
				{
					break;
				}
				obj25 = obj23 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v16 (Il2CppClass<System.Collections.Generic.List`1<BalootProject>>)+12E]");
				obj22 = -1;
				bool flag6 = (nint)obj22 != 1;
				obj23 = obj25;
				if (flag6)
				{
					continue;
				}
				goto IL_0841;
			}
			obj22 = obj23;
			object obj26 = num5 + obj23;
			obj27 = obj26 + 312;
			obj25 = obj23;
			goto IL_17f5;
			IL_1876:
			obj28 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v941 @ X0_v36] (should have been resolved before IL gen)");
			object obj30 = obj31 - 1;
			bool flag7 = obj30 == null;
			obj18 = !flag7;
			if ((nint)obj31 <= 1)
			{
				if (obj31 != null)
				{
					if ((nint)obj31 != 1)
					{
						goto IL_1430;
					}
					bool flag8 = FindSequenceProject((List<Card>)(object)list2, out project6, 4, BalootProject.P50);
					bool flag9 = !flag8;
					balootProject = BalootProject.P50;
					num2 = 4;
					balootGameMode2 = (BalootGame.BalootGameMode)(int)(&project6);
					if (!flag9)
					{
						bool flag10 = list == null;
						num6 = 4;
						balootGameMode2 = (BalootGame.BalootGameMode)(int)(&project6);
						if (!flag10)
						{
							obj28 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+1C]");
							object obj32 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+10]");
							obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+10]");
							bool flag11 = (nint)0 == 0;
							num6 = 0;
							balootGameMode2 = (BalootGame.BalootGameMode)project6;
							if (!flag11)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
								obj25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X9_v18+18]");
								obj24 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
								nint num7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X9_v18+18]");
								bool flag12 = num7 < 0;
								object obj33 = !flag12;
								if (obj33 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
									obj28 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+10]");
									nint num8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
									object obj34 = num8 + 0;
									object obj35 = obj34 + 40;
									obj35 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									balootProject = BalootProject.P50;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v31+20]");
									object obj36 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ X8_v46+C0]");
									obj28 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v31+70]");
									balootProject = BalootProject.Sira;
									list.AddWithResize((ProjectsUtility<System.Int32Enum>.Project)project6);
								}
								num2 = (nint)obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C999D4");
								balootGameMode2 = BalootGame.BalootGameMode.NotDetermined;
								goto IL_0720;
							}
						}
						throw new NullReferenceException();
					}
				}
				else
				{
					bool flag13 = FindSequenceProject((List<Card>)(object)list2, out project4, 3, BalootProject.Sira);
					bool flag14 = !flag13;
					balootProject = BalootProject.Sira;
					num2 = 3;
					balootGameMode2 = (BalootGame.BalootGameMode)(int)(&project4);
					if (!flag14)
					{
						bool flag15 = list == null;
						num6 = 3;
						balootGameMode2 = (BalootGame.BalootGameMode)(int)(&project4);
						if (!flag15)
						{
							obj28 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+1C]");
							object obj37 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+10]");
							obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+10]");
							bool flag16 = (nint)0 == 0;
							num6 = 0;
							balootGameMode2 = (BalootGame.BalootGameMode)project4;
							if (!flag16)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
								obj25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X9_v18+18]");
								obj24 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
								nint num9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X9_v18+18]");
								bool flag17 = num9 < 0;
								object obj38 = !flag17;
								if (obj38 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
									obj28 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+10]");
									nint num10 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
									object obj39 = num10 + 0;
									object obj40 = obj39 + 40;
									obj40 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									balootProject = BalootProject.Sira;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v31+20]");
									object obj41 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X8_v40+C0]");
									obj28 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v31+70]");
									balootProject = BalootProject.Sira;
									list.AddWithResize((ProjectsUtility<System.Int32Enum>.Project)project4);
								}
								num2 = (nint)obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C999D4");
								balootGameMode2 = BalootGame.BalootGameMode.NotDetermined;
								goto IL_0720;
							}
						}
						project2 = project;
						obj19 = obj18;
						balootGameMode3 = balootGameMode;
						obj21 = obj20;
						obj42 = obj24;
						obj43 = obj44;
						obj45 = obj25;
						balootProject2 = BalootProject.Sira;
						obj6 = (object)(&project3);
						list5 = list6;
						throw new NullReferenceException();
					}
				}
			}
			else
			{
				if ((nint)obj31 == 2)
				{
					_ = 0;
					_ = 0;
					ProjectsUtility<BalootProject>.Project project7;
					if (FindSequenceProject((List<Card>)(object)list2, out System.Runtime.CompilerServices.Unsafe.As<object, ProjectsUtility<BalootProject>.Project>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96)), 5, BalootProject.P100))
					{
						obj28 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
						num6 = 5;
					}
					else
					{
						if (!CheckProject100SameRank((List<Card>)(object)list2, gameMode, out project7))
						{
							balootGameMode = BalootGame.BalootGameMode.NotDetermined;
							project3 = (ProjectsUtility<System.Int32Enum>.Project)0;
							obj20 = 0;
							project7 = (ProjectsUtility<BalootProject>.Project)0;
							balootProject = BalootProject.P100;
							num2 = (nint)(&project7);
							balootGameMode2 = gameMode;
							goto IL_0720;
						}
						num6 = (nint)(&project7);
						obj28 = (object)(&project7);
					}
					project2 = (ProjectsUtility<System.Int32Enum>.Project)obj28;
					object obj46 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref project3, 8));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag18 = list == null;
					ProjectsUtility<System.Int32Enum>.Project project8 = (ProjectsUtility<System.Int32Enum>.Project)0;
					if (!flag18)
					{
						obj28 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+1C]");
						object obj47 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+10]");
						obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+10]");
						bool flag19 = (nint)0 == 0;
						num6 = (nint)balootGameMode;
						project8 = (ProjectsUtility<System.Int32Enum>.Project)obj28;
						if (!flag19)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
							obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X9_v18+18]");
							obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
							nint num11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X9_v18+18]");
							bool flag20 = num11 < 0;
							object obj48 = !flag20;
							if (obj48 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v31+20]");
								object obj49 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1207 @ X8_v27+C0]");
								obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v31+70]");
								balootProject = BalootProject.Sira;
								list.AddWithResize((ProjectsUtility<System.Int32Enum>.Project)obj28);
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
								obj28 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+10]");
								nint num12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
								object obj50 = num12 + 0;
								object obj51 = obj50 + 40;
								obj51 = balootGameMode;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								balootProject = BalootProject.P100;
							}
							num2 = (nint)obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C999D4");
							project = project2;
							project3 = project2;
							obj20 = 0;
							project7 = (ProjectsUtility<BalootProject>.Project)0;
							balootGameMode2 = balootGameMode;
							goto IL_0720;
						}
					}
					throw new NullReferenceException();
				}
				if ((nint)obj31 != 3)
				{
					goto IL_1430;
				}
				bool flag21 = CheckProject400((List<Card>)(object)list2, gameMode, out project5);
				bool flag22 = !flag21;
				num2 = (nint)(&project5);
				balootGameMode2 = gameMode;
				if (!flag22)
				{
					bool flag23 = list == null;
					num6 = (nint)(&project5);
					balootGameMode2 = gameMode;
					if (!flag23)
					{
						obj28 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+1C]");
						object obj52 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+10]");
						obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+10]");
						bool flag24 = (nint)0 == 0;
						num6 = 0;
						balootGameMode2 = (BalootGame.BalootGameMode)project5;
						if (!flag24)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
							obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X9_v18+18]");
							obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
							nint num13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X9_v18+18]");
							bool flag25 = num13 < 0;
							object obj53 = !flag25;
							if (obj53 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
								obj28 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+10]");
								nint num14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
								object obj54 = num14 + 0;
								object obj55 = obj54 + 40;
								obj55 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v31+20]");
								object obj56 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1193 @ X8_v34+C0]");
								obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v31+70]");
								balootProject = BalootProject.Sira;
								list.AddWithResize((ProjectsUtility<System.Int32Enum>.Project)project5);
							}
							num2 = (nint)obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C999D4");
							balootGameMode2 = BalootGame.BalootGameMode.NotDetermined;
							goto IL_0720;
						}
					}
					throw new NullReferenceException();
				}
			}
			goto IL_0720;
			IL_0720:
			flag26 = list6 == null;
			list3 = list6;
			project2 = project;
			obj19 = obj18;
			balootGameMode3 = balootGameMode;
			obj21 = obj20;
			obj42 = obj24;
			obj43 = obj44;
			obj45 = obj25;
			balootProject2 = balootProject;
			num6 = num2;
			obj6 = (object)(&project3);
			list5 = list6;
			continue;
			IL_094a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num2 = 0;
			goto IL_1876;
			IL_0841:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num2 = 0;
			goto IL_17f5;
			IL_17f5:
			obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v32+8]");
			balootGameMode2 = BalootGame.BalootGameMode.NotDetermined;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v715 @ X0_v32] (should have been resolved before IL gen)");
			object obj57 = obj58 & 1;
			if (obj57 != null)
			{
				if (list6 != null)
				{
					nint num15 = (nint)list6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v19 (Il2CppClass<System.Collections.Generic.List`1<BalootProject>>)+12E]");
					obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v19 (Il2CppClass<System.Collections.Generic.List`1<BalootProject>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_094a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v19 (Il2CppClass<System.Collections.Generic.List`1<BalootProject>>)+B0]");
					object obj59 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X10_v24-8]");
						obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X10_v24-8]");
						if (0 == (nint)func)
						{
							break;
						}
						obj25 = obj59 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v19 (Il2CppClass<System.Collections.Generic.List`1<BalootProject>>)+12E]");
						obj22 = -1;
						bool flag27 = (nint)obj22 != 1;
						obj59 = obj25;
						if (flag27)
						{
							continue;
						}
						goto IL_094a;
					}
					obj22 = obj59;
					object obj60 = num15 + obj59;
					obj29 = obj60 + 312;
					obj25 = obj59;
					goto IL_1876;
				}
				throw new NullReferenceException();
			}
			obj6 = (object)(&project3);
			object obj61 = 0;
			while (true)
			{
				if (list6 == null)
				{
					goto IL_1913;
				}
				object obj62 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num16 = (nint)list6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v8 (Il2CppClass<System.Collections.Generic.List`1<BalootProject>>)+12E]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v8 (Il2CppClass<System.Collections.Generic.List`1<BalootProject>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_1307;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v8 (Il2CppClass<System.Collections.Generic.List`1<BalootProject>>)+B0]");
				object obj63 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X10_v8-8]");
					obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X10_v8-8]");
					if (0 == (nint)obj62)
					{
						break;
					}
					obj25 = obj63 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v8 (Il2CppClass<System.Collections.Generic.List`1<BalootProject>>)+12E]");
					obj22 = -1;
					bool flag28 = (nint)obj22 != 1;
					obj63 = obj25;
					if (flag28)
					{
						continue;
					}
					goto IL_1307;
				}
				obj22 = obj63;
				object obj64 = num16 + obj63;
				object obj65 = obj64 + 312;
				obj25 = obj63;
				goto IL_19bf;
				IL_1913:
				bool flag29 = obj61 == null;
				object obj66 = !flag29;
				project2 = project;
				obj19 = obj18;
				balootGameMode3 = balootGameMode;
				obj21 = obj20;
				obj42 = obj24;
				obj43 = obj44;
				obj45 = obj25;
				balootProject2 = balootProject;
				num6 = num2;
				list5 = list3;
				if (obj66 == null)
				{
					return (List<ProjectsUtility<BalootProject>.Project>)(object)list;
				}
				OutOfMemoryException ex2 = new OutOfMemoryException();
				if (balootGameMode2 != BalootGame.BalootGameMode.Sun)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj61 = obj67;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				project = project2;
				obj18 = obj19;
				balootGameMode = balootGameMode3;
				obj20 = obj21;
				obj24 = obj42;
				obj44 = obj43;
				obj68 = obj67;
				obj25 = obj45;
				balootProject = balootProject2;
				num2 = num6;
				list3 = list5;
				continue;
				IL_1307:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num2 = 0;
				goto IL_19bf;
				IL_19bf:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1017 @ X0_v21+8]");
				balootGameMode2 = BalootGame.BalootGameMode.NotDetermined;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1017 @ X0_v21] (should have been resolved before IL gen)");
				goto IL_1913;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return result;
			IL_1430:
			object obj69 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ex3..ctor();
			object obj70 = (nint)0 + (nint)2456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
		while (!flag26);
		goto IL_1354;
		IL_02e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj71 = default(object);
		obj22 = obj71;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X0_v116+8]");
		balootGameMode2 = BalootGame.BalootGameMode.NotDetermined;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v738 @ X0_v116] (should have been resolved before IL gen)");
		bool flag30 = list4 == null;
		object obj72 = !flag30;
		obj44 = (object)(&list6);
		obj68 = 0;
		balootProject = balootProject2;
		num2 = 0;
		if (obj72 != null)
		{
			goto IL_060b;
		}
		balootGameMode3 = BalootGame.BalootGameMode.NotDetermined;
		project3 = (ProjectsUtility<System.Int32Enum>.Project)0;
		project4 = (ProjectsUtility<BalootProject>.Project)0;
		project5 = (ProjectsUtility<BalootProject>.Project)0;
		obj42 = obj24;
		project6 = (ProjectsUtility<BalootProject>.Project)0;
		obj43 = (object)(&list6);
		obj68 = 0;
		obj45 = obj25;
		num6 = 0;
		obj28 = (object)(&list6);
		list5 = (List<BalootProject>)(object)ex;
		goto IL_1354;
		IL_0232:
		object obj73 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2952;
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v52 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v52 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02e2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v52 (Il2CppClass<System.NullReferenceException>)+B0]");
		object obj75 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X10_v35-8]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X10_v35-8]");
			bool flag31 = 0 == (nint)obj73;
			obj25 = obj75;
			balootProject = balootProject2;
			num2 = num4;
			func = func2;
			comparison2 = comparison3;
			if (flag31)
			{
				break;
			}
			obj25 = obj75 + 16;
			obj74--;
			bool flag32 = (nint)obj74 != 1;
			obj75 = obj25;
			if (flag32)
			{
				continue;
			}
			goto IL_02e2;
		}
		goto IL_0532;
		IL_1354:
		throw new NullReferenceException();
		IL_0532:
		object obj76 = num + obj25;
		object obj77 = obj76 + 312;
		obj22 = obj77;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v54+8]");
		balootGameMode2 = BalootGame.BalootGameMode.NotDetermined;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v214 @ X8_v54] (should have been resolved before IL gen)");
		bool flag33 = list4 == null;
		obj44 = (object)(&list6);
		obj68 = 0;
		balootGameMode3 = BalootGame.BalootGameMode.NotDetermined;
		project3 = (ProjectsUtility<System.Int32Enum>.Project)0;
		project4 = (ProjectsUtility<BalootProject>.Project)0;
		project5 = (ProjectsUtility<BalootProject>.Project)0;
		obj42 = obj24;
		project6 = (ProjectsUtility<BalootProject>.Project)0;
		obj43 = (object)(&list6);
		obj68 = 0;
		obj45 = obj25;
		balootProject2 = balootProject;
		num6 = num2;
		obj28 = (object)(&list6);
		list5 = definedProjects;
		if (!flag33)
		{
			goto IL_060b;
		}
		goto IL_1354;
		IL_01c2:
		num4 = (nint)obj10;
		IOrderedEnumerable<System.Int32Enum> orderedEnumerable2 = Enumerable.OrderByDescending((IEnumerable<System.Int32Enum>)definedProjects, keySelector);
		bool flag34 = orderedEnumerable2 == null;
		balootProject2 = BalootProject.Sira;
		ex = (NullReferenceException)orderedEnumerable2;
		comparison3 = comparison;
		balootProject = BalootProject.Sira;
		num2 = (nint)obj10;
		func = func2;
		comparison2 = comparison;
		if (!flag34)
		{
			goto IL_0232;
		}
		goto IL_0524;
	}

	private unsafe static bool CheckProject400(List<Card> playerCards, BalootGame.BalootGameMode gameMode, out ProjectsUtility<BalootProject>.Project project)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0189: Expected O, but got I
		//IL_0199: Expected O, but got I
		//IL_01a9: Expected O, but got I
		//IL_01cb: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_0072: Expected O, but got I
		//IL_0203: Expected O, but got I4
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_03f1: Expected O, but got I
		//IL_0402: Expected I, but got O
		//IL_0420: Expected O, but got I
		//IL_029e: Expected O, but got I
		//IL_02ae: Expected O, but got I
		//IL_02d0: Expected O, but got I4
		//IL_0233: Expected O, but got I
		//IL_0126: Expected O, but got I
		//IL_0136: Expected O, but got I
		//IL_0158: Expected O, but got I4
		//IL_0366: Expected O, but got I
		//IL_0386: Expected O, but got Ref
		//IL_0300: Expected O, but got I4
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_0461: Expected O, but got I
		//IL_0472: Expected I, but got O
		//IL_0490: Expected O, but got I
		//IL_0330: Expected O, but got I
		ref ProjectsUtility<BalootProject>.Project reference = ref *(ProjectsUtility<BalootProject>.Project*)null;
		_ = 0;
		object obj;
		object obj3;
		Func<object, bool> func;
		object obj13;
		Func<object, bool> func3;
		if (gameMode != BalootGame.BalootGameMode.Hokom)
		{
			obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2680;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v5+E4]");
			object obj4;
			object obj5;
			if ((nint)0 != 0)
			{
				obj3 = (nint)0 + (nint)3496;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v5+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v6+10]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v6+10]");
				bool flag = (nint)0 == 0;
				obj5 = obj3;
				if (!flag)
				{
					goto IL_009f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				obj3 = (nint)0 + (nint)3496;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v5+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v6+10]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v6+10]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				obj5 = obj3;
				if (obj6 != null)
				{
					goto IL_009f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v12+B8]");
				obj4 = 0;
			}
			object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)944;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj4, (IntPtr)obj10);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v11+B8]");
			object obj12 = (nint)0 + (nint)16;
			obj12 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj13 = obj5;
			int num = Enumerable.Count(playerCards, func2);
			bool flag4 = num == 4;
			func3 = func2;
			if (flag4)
			{
				goto IL_00e0;
			}
		}
		goto IL_0276;
		IL_0335:
		IEnumerable<Suit> all;
		Func<System.Int32Enum, object> selector;
		IEnumerable<object> source = Enumerable.Select((IEnumerable<System.Int32Enum>)all, selector);
		List<object> list = Enumerable.ToList(source);
		object obj14 = (nint)0 + (nint)208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39D85CC");
		object obj15 = default(object);
		reference = ref *(ProjectsUtility<BalootProject>.Project*)obj15;
		object obj16 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref project, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return true;
		IL_00e0:
		all = SuitMethods.GetAll();
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v29+E4]");
		object obj18;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v29+B8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v25+18]");
			selector = (Func<System.Int32Enum, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v25+18]");
			bool flag5 = (nint)0 == 0;
			object obj19 = !flag5;
			if (obj19 == null)
			{
				goto IL_02de;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v29+B8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v25+18]");
			selector = (Func<System.Int32Enum, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v25+18]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				goto IL_02de;
			}
		}
		goto IL_0335;
		IL_0276:
		return false;
		IL_009f:
		obj13 = obj3;
		int num2 = Enumerable.Count(playerCards, func);
		bool flag7 = num2 != 4;
		func3 = func;
		if (!flag7)
		{
			goto IL_00e0;
		}
		goto IL_0276;
		IL_02de:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v29+E4]");
		bool flag8 = (nint)0 == 0;
		object obj21 = !flag8;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v31+B8]");
			obj18 = 0;
		}
		object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)952;
		Func<System.Int32Enum, object> func4 = default(Func<System.Int32Enum, object>);
		func4..ctor(obj18, (IntPtr)obj24);
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v30+B8]");
		object obj26 = (nint)0 + (nint)24;
		obj26 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector = func4;
		goto IL_0335;
	}

	private unsafe static bool CheckProject100(List<Card> playerCards, BalootGame.BalootGameMode gameMode, out ProjectsUtility<BalootProject>.Project project)
	{
		//IL_00b7: Expected O, but got Ref
		ProjectsUtility<BalootProject>.Project project3;
		ref ProjectsUtility<BalootProject>.Project reference;
		if (FindSequenceProject(playerCards, out var project2, 5, BalootProject.P100))
		{
			project3 = project2;
			int num = 5;
		}
		else
		{
			ProjectsUtility<BalootProject>.Project project4;
			bool flag = CheckProject100SameRank(playerCards, gameMode, out project4);
			if (!flag)
			{
				reference = ref *(ProjectsUtility<BalootProject>.Project*)null;
				_ = 0;
				return flag;
			}
			project3 = project4;
			int num = (int)(&project4);
		}
		reference = ref *(ProjectsUtility<BalootProject>.Project*)project3;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref project, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return true;
	}

	private unsafe static bool CheckProject100SameRank(List<Card> playerCards, BalootGame.BalootGameMode gameMode, out ProjectsUtility<BalootProject>.Project project)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_013c: Expected O, but got I4
		//IL_00a0: Expected O, but got I
		//IL_00b0: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_0170: Expected O, but got I
		//IL_0180: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01b2: Expected O, but got I4
		//IL_02e4: Expected O, but got I
		//IL_02f4: Expected O, but got I
		//IL_0304: Expected O, but got I
		//IL_0326: Expected O, but got I4
		//IL_0269: Expected O, but got I
		//IL_0279: Expected O, but got I
		//IL_0289: Expected O, but got I
		//IL_02ab: Expected O, but got I4
		//IL_01ea: Expected O, but got I4
		//IL_0489: Expected O, but got I
		//IL_0499: Expected O, but got I
		//IL_04bb: Expected O, but got I4
		//IL_035e: Expected O, but got I4
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected O, but got Unknown
		//IL_066c: Expected O, but got I
		//IL_067d: Expected I, but got O
		//IL_069b: Expected O, but got I
		//IL_06b2: Expected I, but got O
		//IL_0443: Expected O, but got I4
		//IL_03e2: Expected O, but got I
		//IL_03f2: Expected O, but got I
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected O, but got Unknown
		//IL_06f1: Expected O, but got I
		//IL_0702: Expected I, but got O
		//IL_0720: Expected O, but got I
		//IL_0737: Expected I, but got O
		//IL_021a: Expected O, but got I
		//IL_04ec: Expected O, but got I4
		//IL_038e: Expected O, but got I
		//IL_0642: Expected I4, but got O
		//IL_0461: Expected I4, but got O
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected O, but got Unknown
		//IL_077b: Expected O, but got I
		//IL_078c: Expected I, but got O
		//IL_07aa: Expected O, but got I
		//IL_0551: Expected I4, but got O
		//IL_051c: Expected O, but got I
		//IL_05f7: Expected O, but got I
		//IL_061c: Expected O, but got Ref
		object obj = 152993792;
		object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2680;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80A8]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			ref ProjectsUtility<BalootProject>.Project reference = ref *(ProjectsUtility<BalootProject>.Project*)null;
			_ = 0;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v46+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			ref ProjectsUtility<BalootProject>.Project reference = ref *(ProjectsUtility<BalootProject>.Project*)null;
			_ = 0;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v46+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)3280;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v46+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v41+20]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v41+20]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 == null)
		{
			goto IL_01c8;
		}
		goto IL_021f;
		IL_055f:
		IEnumerable<object> source;
		object obj11 = Enumerable.First(source);
		bool result;
		if (obj11 != null)
		{
			if (gameMode != BalootGame.BalootGameMode.Hokom)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v11 (System.Object)+10]");
				if ((nint)0 == 12)
				{
					result = false;
					goto IL_074c;
				}
			}
			List<object> list = Enumerable.ToList(source);
			object obj12 = (nint)0 + (nint)208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39D85CC");
			object obj13 = default(object);
			ref ProjectsUtility<BalootProject>.Project reference = ref *(ProjectsUtility<BalootProject>.Project*)obj13;
			object obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref project, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			result = true;
			goto IL_074c;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0393:
		IEnumerable<object> source3;
		Func<object, System.Int32Enum> keySelector;
		ILookup<System.Int32Enum, object> source2 = Enumerable.ToLookup(source3, keySelector);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v20+E4]");
		object obj16;
		Func<object, bool> predicate2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v20+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v17+30]");
			predicate2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v17+30]");
			if ((nint)0 != 0)
			{
				goto IL_0418;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v20+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v17+30]");
			predicate2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v17+30]");
			bool flag4 = (nint)0 == 0;
			object obj17 = !flag4;
			if (obj17 != null)
			{
				goto IL_0418;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj19 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v23+B8]");
			obj16 = 0;
		}
		object obj20 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = (nint)0 + (nint)936;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj16, (IntPtr)obj21);
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v22+B8]");
		object obj23 = (nint)0 + (nint)48;
		obj23 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj24 = Enumerable.FirstOrDefault(source2, func);
		bool flag6 = obj24 == null;
		source = (IEnumerable<object>)obj24;
		result = (byte)(int)obj24 != 0;
		if (!flag6)
		{
			goto IL_055f;
		}
		goto IL_074c;
		IL_021f:
		source3 = Enumerable.Where(playerCards, predicate);
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v36+E4]");
		object obj27;
		object obj29;
		object obj26;
		if ((nint)0 != 0)
		{
			obj26 = (nint)0 + (nint)2936;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v36+B8]");
			obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v30+28]");
			keySelector = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v30+28]");
			bool flag7 = (nint)0 == 0;
			object obj28 = !flag7;
			if (obj28 == null)
			{
				obj29 = obj26;
				goto IL_033c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj2;
			obj29 = (nint)0 + (nint)2936;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v36+B8]");
			obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v30+28]");
			keySelector = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v30+28]");
			bool flag8 = (nint)0 == 0;
			object obj30 = !flag8;
			obj26 = obj29;
			if (obj30 == null)
			{
				goto IL_033c;
			}
		}
		goto IL_0393;
		IL_0094:
		obj10 = (nint)0 + (nint)3280;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v46+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v41+20]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v41+20]");
		bool flag9 = (nint)0 == 0;
		object obj31 = !flag9;
		if (obj31 == null)
		{
			obj7 = obj10;
			goto IL_01c8;
		}
		goto IL_021f;
		IL_0418:
		object obj32 = Enumerable.FirstOrDefault(source2, predicate2);
		bool flag10 = obj32 == null;
		object obj33 = !flag10;
		source = (IEnumerable<object>)obj32;
		if (obj33 != null)
		{
			goto IL_055f;
		}
		result = (byte)(int)obj32 != 0;
		goto IL_074c;
		IL_01c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v46+E4]");
		bool flag11 = (nint)0 == 0;
		object obj34 = !flag11;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj35 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v47+B8]");
			obj8 = 0;
		}
		object obj36 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj37 = (nint)0 + (nint)920;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj8, (IntPtr)obj37);
		object obj38 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v46+B8]");
		object obj39 = (nint)0 + (nint)32;
		obj39 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = unchecked((nint)null);
		obj10 = obj7;
		predicate = func2;
		goto IL_021f;
		IL_074c:
		return result;
		IL_033c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v36+E4]");
		bool flag12 = (nint)0 == 0;
		object obj40 = !flag12;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj41 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v36+B8]");
			obj27 = 0;
		}
		object obj42 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj43 = (nint)0 + (nint)928;
		Func<object, System.Int32Enum> func3 = default(Func<object, System.Int32Enum>);
		func3..ctor(obj27, (IntPtr)obj43);
		object obj44 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v35+B8]");
		object obj45 = (nint)0 + (nint)40;
		obj45 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num = unchecked((nint)null);
		obj26 = obj29;
		keySelector = func3;
		goto IL_0393;
	}

	private static bool CheckProject100Sequence(List<Card> playerCards, out ProjectsUtility<BalootProject>.Project project)
	{
		return FindSequenceProject(playerCards, out project, 5, BalootProject.P100);
	}

	private static bool CheckProject50(List<Card> playerCards, out ProjectsUtility<BalootProject>.Project project)
	{
		return FindSequenceProject(playerCards, out project, 4, BalootProject.P50);
	}

	private static bool CheckProjectSira(List<Card> playerCards, out ProjectsUtility<BalootProject>.Project project)
	{
		return FindSequenceProject(playerCards, out project, 3, BalootProject.Sira);
	}

	private unsafe static bool FindSequenceProject(List<Card> playerCards, out ProjectsUtility<BalootProject>.Project project, int size, BalootProject balootProject)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0152: Expected O, but got I4
		//IL_015b: Expected O, but got I4
		//IL_0164: Expected O, but got I4
		//IL_0175: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00d5: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_0081: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_1ccf: Expected O, but got I4
		//IL_01aa: Expected O, but got I
		//IL_01ba: Expected O, but got I
		//IL_01ca: Expected O, but got I
		//IL_01ec: Expected O, but got I4
		//IL_01fc: Expected O, but got I
		//IL_1d61: Expected O, but got I
		//IL_1d70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d75: Expected O, but got Unknown
		//IL_1d81: Expected O, but got I
		//IL_1d91: Expected O, but got I
		//IL_1da1: Expected O, but got I
		//IL_1dc3: Expected O, but got I4
		//IL_0115: Expected O, but got I
		//IL_245d: Expected I4, but got O
		//IL_0222: Expected O, but got I
		//IL_0244: Expected O, but got I4
		//IL_02bd: Expected O, but got I
		//IL_02df: Expected O, but got I4
		//IL_1cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf9: Expected O, but got Unknown
		//IL_1d0f: Expected O, but got I
		//IL_1d20: Expected I, but got O
		//IL_1d3e: Expected O, but got I
		//IL_1de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de5: Expected O, but got Unknown
		//IL_1dfb: Expected O, but got I
		//IL_1e0c: Expected I, but got O
		//IL_1e2a: Expected O, but got I
		//IL_0274: Expected O, but got I
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_035a: Expected I, but got O
		//IL_036a: Expected O, but got I
		//IL_030f: Expected O, but got I
		//IL_1e90: Expected O, but got I
		//IL_1e5c: Expected O, but got I
		//IL_1b83: Expected O, but got Ref
		//IL_1b8c: Expected O, but got I4
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		//IL_0480: Expected O, but got I
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_04a0: Expected O, but got I
		//IL_042b: Expected O, but got I4
		//IL_043d: Expected O, but got I
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_05c7: Expected O, but got I
		//IL_03d6: Expected O, but got I
		//IL_1efb: Expected O, but got I
		//IL_1f0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f13: Expected O, but got Unknown
		//IL_1534: Expected O, but got Ref
		//IL_1543: Unknown result type (might be due to invalid IL or missing references)
		//IL_1548: Expected O, but got Unknown
		//IL_156a: Expected O, but got I4
		//IL_157a: Expected O, but got Ref
		//IL_1583: Expected O, but got I4
		//IL_15bc: Expected O, but got I4
		//IL_15c5: Expected O, but got I4
		//IL_15ce: Expected O, but got I4
		//IL_1ec7: Expected O, but got I
		//IL_1757: Unknown result type (might be due to invalid IL or missing references)
		//IL_175c: Expected O, but got Unknown
		//IL_1774: Expected O, but got I
		//IL_0688: Expected O, but got I4
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected O, but got Unknown
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected O, but got Unknown
		//IL_15e4: Expected O, but got Ref
		//IL_15ed: Expected O, but got I4
		//IL_1606: Expected O, but got I4
		//IL_1616: Expected O, but got Ref
		//IL_161f: Expected O, but got I4
		//IL_1630: Expected O, but got I4
		//IL_1a96: Expected O, but got I4
		//IL_0633: Expected O, but got I
		//IL_22fc: Expected O, but got I
		//IL_2242: Expected O, but got I4
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected O, but got Unknown
		//IL_0706: Expected O, but got I
		//IL_22c0: Expected O, but got I
		//IL_1825: Expected O, but got I4
		//IL_1832: Unknown result type (might be due to invalid IL or missing references)
		//IL_1837: Expected O, but got Unknown
		//IL_1840: Unknown result type (might be due to invalid IL or missing references)
		//IL_1845: Expected O, but got Unknown
		//IL_221e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2223: Expected O, but got Unknown
		//IL_1f7a: Expected O, but got I
		//IL_1f9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa0: Expected O, but got Unknown
		//IL_1fb6: Expected O, but got I
		//IL_1fbe: Expected I4, but got O
		//IL_17d8: Expected O, but got I
		//IL_18c9: Expected O, but got I4
		//IL_1f40: Expected O, but got I
		//IL_23a0: Expected O, but got I
		//IL_1891: Expected O, but got I4
		//IL_1ae5: Expected O, but got I4
		//IL_07c7: Expected O, but got I4
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected O, but got Unknown
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected O, but got Unknown
		//IL_19a1: Expected O, but got I4
		//IL_2384: Unknown result type (might be due to invalid IL or missing references)
		//IL_2389: Expected I4, but got Unknown
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected O, but got Unknown
		//IL_0835: Expected I, but got O
		//IL_0845: Expected O, but got I
		//IL_0772: Expected O, but got I
		//IL_1be2: Expected O, but got I4
		//IL_1bf3: Expected O, but got I4
		//IL_23d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d9: Expected O, but got Unknown
		//IL_23ef: Expected O, but got I
		//IL_2400: Expected I, but got O
		//IL_241e: Expected O, but got I
		//IL_1903: Expected O, but got I
		//IL_19d1: Expected O, but got I
		//IL_2014: Expected O, but got I
		//IL_2038: Expected O, but got I4
		//IL_1c62: Expected O, but got I4
		//IL_1a13: Expected O, but got I4
		//IL_1a39: Expected O, but got I4
		//IL_0a8c: Expected O, but got I
		//IL_1fe0: Expected O, but got I
		//IL_1942: Expected O, but got I
		//IL_1962: Expected O, but got Ref
		//IL_094c: Expected O, but got Ref
		//IL_0955: Expected O, but got I4
		//IL_0986: Expected O, but got I4
		//IL_0906: Expected O, but got I4
		//IL_0918: Expected O, but got I
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Expected O, but got Unknown
		//IL_197a: Expected O, but got I4
		//IL_20c2: Expected O, but got I
		//IL_20d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_20da: Expected O, but got Unknown
		//IL_08b1: Expected O, but got I
		//IL_208e: Expected O, but got I
		//IL_0b4d: Expected O, but got I4
		//IL_0b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5f: Expected O, but got Unknown
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Expected O, but got Unknown
		//IL_1afb: Expected O, but got Ref
		//IL_1b04: Expected O, but got I4
		//IL_1b15: Expected O, but got I4
		//IL_10c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cd: Expected O, but got Unknown
		//IL_10e5: Expected O, but got I
		//IL_1452: Expected O, but got Ref
		//IL_145b: Expected O, but got I4
		//IL_146c: Expected O, but got I4
		//IL_0af8: Expected O, but got I
		//IL_0bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb3: Expected O, but got Unknown
		//IL_0bcb: Expected O, but got I
		//IL_21f6: Expected O, but got I
		//IL_21c2: Expected O, but got I
		//IL_213b: Expected O, but got I
		//IL_1196: Expected O, but got I4
		//IL_11a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a8: Expected O, but got Unknown
		//IL_11b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b6: Expected O, but got Unknown
		//IL_13e2: Expected O, but got Ref
		//IL_13eb: Expected O, but got I4
		//IL_1404: Expected O, but got I4
		//IL_2107: Expected O, but got I
		//IL_1149: Expected O, but got I
		//IL_0c8c: Expected O, but got I4
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9e: Expected O, but got Unknown
		//IL_0ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cac: Expected O, but got Unknown
		//IL_141a: Expected O, but got Ref
		//IL_1423: Expected O, but got I4
		//IL_143c: Expected O, but got I4
		//IL_0c37: Expected O, but got I
		//IL_0d09: Expected O, but got I
		//IL_0d20: Expected O, but got Ref
		//IL_14db: Expected O, but got Ref
		//IL_14e4: Expected O, but got I4
		//IL_14f4: Expected O, but got I
		//IL_14fd: Expected O, but got I4
		//IL_1527: Expected O, but got I4
		//IL_0d60: Expected O, but got I4
		//IL_0d71: Expected I4, but got O
		//IL_0dda: Expected I4, but got O
		//IL_0fe5: Expected O, but got I4
		//IL_1391: Expected O, but got Ref
		//IL_139a: Expected O, but got I4
		//IL_13aa: Expected O, but got I
		//IL_13b3: Expected O, but got I4
		//IL_13cc: Expected O, but got I4
		//IL_0df4: Expected O, but got I
		//IL_0dfc: Expected I4, but got O
		//IL_100a: Expected O, but got I4
		//IL_102a: Expected O, but got I4
		//IL_099b: Expected O, but got I
		//IL_09ab: Expected O, but got I
		//IL_1482: Expected O, but got Ref
		//IL_148b: Expected O, but got I4
		//IL_149b: Expected O, but got I
		//IL_14a4: Expected O, but got I4
		//IL_14c5: Expected O, but got I4
		//IL_09f4: Expected O, but got I
		//IL_09fd: Expected O, but got I4
		//IL_0a35: Expected O, but got I
		//IL_0a3e: Expected O, but got I4
		//IL_106a: Unknown result type (might be due to invalid IL or missing references)
		//IL_106f: Expected O, but got Unknown
		//IL_1078: Unknown result type (might be due to invalid IL or missing references)
		//IL_107d: Expected O, but got Unknown
		//IL_0eb2: Expected O, but got I4
		//IL_0ed2: Expected O, but got I4
		//IL_0f65: Expected I4, but got O
		//IL_0f12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f17: Expected O, but got Unknown
		//IL_0f20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f25: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2680;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80A9]");
		object obj3 = (nint)0 & (nint)1;
		object obj5;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v164+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = 0;
			object obj7 = obj4;
			obj5 = 0;
			obj6 = 0;
			if (!flag)
			{
				goto IL_00a9;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v164+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj5 = 0;
			obj6 = 0;
			object obj7 = obj4;
			obj5 = 0;
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_00a9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj9 = (nint)0 + (nint)2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v164+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v137+38]");
		Func<object, System.Int32Enum> func = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v137+38]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v137+38]");
		Func<object, System.Int32Enum> keySelector = (Func<object, System.Int32Enum>)0;
		object obj12 = obj9;
		if (obj11 == null)
		{
			goto IL_0212;
		}
		goto IL_1c94;
		IL_1e41:
		throw new NullReferenceException();
		IL_1aea:
		OutOfMemoryException ex = new OutOfMemoryException();
		object obj13 = (object)(&obj6);
		object obj14 = 0;
		int num2;
		int num = num2;
		object obj15 = -1;
		goto IL_1b7a;
		IL_22e4:
		object obj17 = default(object);
		object obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X0_v52+8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1164 @ X0_v52] (should have been resolved before IL gen)");
		object obj19 = obj13;
		object obj21;
		object obj20 = obj21;
		object obj23 = default(object);
		object obj22 = obj23;
		object obj25 = default(object);
		object obj24 = obj25;
		object obj27 = default(object);
		object obj26 = obj27;
		object obj29;
		object obj28 = obj29;
		object obj31;
		object obj30 = obj31;
		int num4 = default(int);
		int num3 = num4;
		ILookup<System.Int32Enum, object> lookup2;
		ILookup<System.Int32Enum, object> lookup = lookup2;
		object obj33;
		object obj32 = obj33;
		object obj35;
		object obj34 = obj35;
		object obj36 = obj15;
		object obj38;
		object obj37 = obj38;
		object obj40;
		object obj39 = obj40;
		goto IL_2228;
		IL_00a9:
		obj12 = (nint)0 + (nint)2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v164+B8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v137+38]");
		keySelector = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v137+38]");
		bool flag4 = (nint)0 == 0;
		object obj41 = !flag4;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v137+38]");
			func = (Func<object, System.Int32Enum>)0;
			obj9 = obj12;
			goto IL_0212;
		}
		goto IL_1c94;
		IL_13d1:
		NullReferenceException ex2 = new NullReferenceException();
		obj13 = (object)(&obj6);
		obj14 = 0;
		num = num2;
		object[] array2;
		object[] array = array2;
		obj15 = -1;
		goto IL_1b7a;
		IL_0212:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v164+E4]");
		array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v164+E4]");
		bool flag5 = (nint)0 == 0;
		object obj42 = !flag5;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj43 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v143+B8]");
			obj10 = 0;
		}
		object obj44 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj45 = (nint)0 + (nint)968;
		Func<object, System.Int32Enum> func2 = default(Func<object, System.Int32Enum>);
		func2..ctor(obj10, (IntPtr)obj45);
		object obj46 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v142+B8]");
		object obj47 = (nint)0 + (nint)56;
		obj47 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		keySelector = func2;
		obj12 = obj9;
		goto IL_1c94;
		IL_1eeb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ X0_v65+8]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v876 @ X0_v65] (should have been resolved before IL gen)");
		object obj49 = default(object);
		object obj48 = obj49 & 1;
		bool flag7 = default(bool);
		if (obj48 != null)
		{
			if (obj5 != null)
			{
				object obj50 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 4072;
				object obj51 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X8_v50+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X8_v50+12E]");
				if ((nint)0 == 0)
				{
					goto IL_07a2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X8_v50+B0]");
				int num5 = (int)((nint)0 + (nint)8);
				bool flag6 = flag7;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1142 @ X10_v54 (System.Int32)-8]");
					obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1142 @ X10_v54 (System.Int32)-8]");
					if (0 == (nint)obj50)
					{
						break;
					}
					num3 = num5 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X8_v50+12E]");
					array = (object[])(-1);
					flag7 = (nint)array != 1;
					flag6 = flag7;
					num5 = num3;
					if (flag7)
					{
						continue;
					}
					goto IL_07a2;
				}
				array = (object[])((int*)num5)->m_value;
				object obj52 = obj51 + ((int*)num5)->m_value;
				object obj53 = obj52 + 312;
				flag7 = flag6;
				num3 = num5;
				goto IL_1f64;
			}
			NullReferenceException ex3 = new NullReferenceException();
			obj13 = obj19;
			obj23 = obj22;
			obj25 = obj24;
			obj27 = obj26;
			num4 = num3;
			lookup2 = lookup;
			num = num2;
			obj15 = -1;
			goto IL_1b7a;
		}
		object obj54 = (object)(&obj5);
		obj35 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2680;
		object obj55 = obj54;
		bool flag8 = obj54 == null;
		object obj56 = !flag8;
		obj13 = obj19;
		obj21 = (object)(&obj5);
		object obj57 = 0;
		obj23 = obj22;
		obj25 = obj24;
		obj27 = obj26;
		num4 = num3;
		lookup2 = lookup;
		num = num2;
		obj33 = 11;
		obj15 = -1;
		obj40 = 0;
		if (obj56 != null)
		{
			goto IL_1748;
		}
		obj20 = (object)(&obj5);
		obj57 = 0;
		obj28 = obj29;
		obj30 = obj31;
		obj32 = 11;
		obj34 = obj35;
		obj16 = (object)(&obj5);
		obj36 = -1;
		obj37 = obj38;
		obj39 = 0;
		goto IL_2228;
		IL_0663:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 0;
		goto IL_1eeb;
		IL_1c94:
		ILookup<System.Int32Enum, object> lookup3 = Enumerable.ToLookup(playerCards, keySelector);
		object obj58 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v5+E4]");
		bool flag9 = (nint)0 == 0;
		object obj59 = !flag9;
		lookup2 = lookup3;
		if (obj59 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj58 = obj2;
			lookup2 = lookup3;
		}
		object obj60 = (nint)0 + (nint)3128;
		obj38 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3712;
		obj15 = (nint)0 + (nint)2808;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v5+B8]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v128+40]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v128+40]");
		bool flag10 = (nint)0 == 0;
		object obj62 = !flag10;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v5+E4]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v5+E4]");
			bool flag11 = (nint)0 == 0;
			object obj63 = !flag11;
			if (obj63 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj64 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v134+B8]");
				obj61 = 0;
			}
			object obj65 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3384;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj66 = (nint)0 + (nint)976;
			Func<object, bool> func3 = default(Func<object, bool>);
			func3..ctor(obj61, (IntPtr)obj66);
			object obj67 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v133+B8]");
			object obj68 = (nint)0 + (nint)64;
			obj68 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func3;
		}
		num = (int)obj60;
		IEnumerable<object> enumerable = Enumerable.Where(lookup2, predicate);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj18 = obj15;
		List<object> list = default(List<object>);
		list..ctor();
		if (enumerable == null)
		{
			goto IL_1e41;
		}
		object obj69 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2704;
		nint num6 = (nint)enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v37 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v37 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0406;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v37 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
		int num7 = (int)((nint)0 + (nint)8);
		bool flag12 = flag7;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X10_v64 (System.Int32)-8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X10_v64 (System.Int32)-8]");
			if (0 == (nint)obj69)
			{
				break;
			}
			num4 = num7 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v37 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			array = (object[])(-1);
			flag7 = (nint)array != 1;
			flag12 = flag7;
			num7 = num4;
			if (flag7)
			{
				continue;
			}
			goto IL_0406;
		}
		array = (object[])((int*)num7)->m_value;
		object obj70 = num6 + ((int*)num7)->m_value;
		object obj71 = obj70 + 312;
		flag7 = flag12;
		num4 = num7;
		goto IL_1e80;
		IL_07a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 0;
		goto IL_1f64;
		IL_093b:
		NullReferenceException ex4 = new NullReferenceException();
		obj13 = (object)(&obj6);
		obj14 = 0;
		obj23 = obj22;
		obj25 = obj24;
		obj27 = obj26;
		num4 = num3;
		lookup2 = lookup;
		obj15 = -1;
		goto IL_1b7a;
		IL_1409:
		NullReferenceException ex5 = new NullReferenceException();
		obj13 = (object)(&obj6);
		obj14 = 0;
		num = num2;
		array = array2;
		obj15 = -1;
		goto IL_1b7a;
		IL_08e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num = 0;
		goto IL_2004;
		IL_21e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1639 @ X0_v96+8]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1639 @ X0_v96] (should have been resolved before IL gen)");
		goto IL_1aea;
		IL_2228:
		Func<object, System.Int32Enum> func4 = default(Func<object, System.Int32Enum>);
		object obj85 = default(object);
		bool result = default(bool);
		object obj88 = default(object);
		while (true)
		{
			bool flag13 = obj39 == null;
			object obj72 = !flag13;
			obj13 = obj19;
			obj21 = obj20;
			obj23 = obj22;
			obj25 = obj24;
			obj27 = obj26;
			obj29 = obj28;
			obj31 = obj30;
			num4 = num3;
			lookup2 = lookup;
			num = num2;
			obj15 = obj36;
			obj38 = obj37;
			ref ProjectsUtility<BalootProject>.Project reference;
			if (obj72 == null)
			{
				if ((nint)obj32 != 11)
				{
					bool flag14 = obj32 == null;
					object obj73 = !flag14;
					if (obj73 != null)
					{
						goto IL_237b;
					}
				}
				object obj74 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ X0_v15+E4]");
				bool flag15 = (nint)0 == 0;
				object obj75 = !flag15;
				if (obj75 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj74 = obj34;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ X0_v15+B8]");
				object obj76 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1243 @ X8_v12+48]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1243 @ X8_v12+48]");
					IOrderedEnumerable<object> source = Enumerable.OrderByDescending(list, (Func<object, System.Int32Enum>)0);
					object obj77 = Enumerable.FirstOrDefault(source);
					if (obj77 != null)
					{
						goto IL_1936;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ X0_v15+E4]");
					bool flag16 = (nint)0 == 0;
					object obj78 = !flag16;
					if (obj78 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj79 = obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1254 @ X8_v18+B8]");
						obj76 = 0;
					}
					object obj80 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3752;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj81 = (nint)0 + (nint)984;
					func4..ctor(obj76, (IntPtr)obj81);
					object obj82 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X8_v17+B8]");
					object obj83 = (nint)0 + (nint)72;
					obj83 = func4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					IOrderedEnumerable<object> source2 = Enumerable.OrderByDescending(list, func4);
					object obj77 = Enumerable.FirstOrDefault(source2);
					bool flag17 = obj77 == null;
					object obj84 = !flag17;
					if (obj84 != null)
					{
						goto IL_1936;
					}
				}
				reference = ref *(ProjectsUtility<BalootProject>.Project*)null;
				_ = 0;
				obj16 = 0;
				goto IL_237b;
			}
			OutOfMemoryException ex6 = new OutOfMemoryException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			obj35 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2680;
			if ((nint)obj18 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj40 = obj85;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj55 = obj21;
				bool flag18 = obj21 == null;
				object obj86 = !flag18;
				obj57 = obj85;
				obj33 = 0;
				if (obj86 != null)
				{
					break;
				}
				obj19 = obj13;
				obj20 = obj21;
				obj57 = obj85;
				obj22 = obj23;
				obj24 = obj25;
				obj26 = obj27;
				obj28 = obj29;
				obj30 = obj31;
				num3 = num4;
				lookup = lookup2;
				num2 = num;
				obj32 = 0;
				obj34 = obj35;
				obj16 = obj21;
				obj36 = obj15;
				obj37 = obj38;
				obj39 = obj85;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return result;
			IL_1936:
			object obj87 = (nint)0 + (nint)208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39D85CC");
			reference = ref *(ProjectsUtility<BalootProject>.Project*)obj88;
			object obj89 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref project, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj16 = 1;
			goto IL_237b;
			IL_237b:
			return (byte)(obj16 & 1) != 0;
		}
		goto IL_1748;
		IL_1748:
		object obj90 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj91 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X8_v31+12E]");
		array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X8_v31+12E]");
		if ((nint)0 == 0)
		{
			goto IL_1800;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X8_v31+B0]");
		int num8 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X10_v9 (System.Int32)-8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X10_v9 (System.Int32)-8]");
			if (0 == (nint)obj90)
			{
				break;
			}
			num4 = num8 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X8_v31+12E]");
			array = (object[])(-1);
			bool flag19 = (nint)array != 1;
			num8 = num4;
			if (flag19)
			{
				continue;
			}
			goto IL_1800;
		}
		array = (object[])((int*)num8)->m_value;
		object obj92 = obj91 + ((int*)num8)->m_value;
		obj17 = obj92 + 312;
		num4 = num8;
		num2 = num;
		goto IL_22e4;
		IL_1f64:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1175 @ X0_v69] (should have been resolved before IL gen)");
		object obj93 = (nint)0 + (nint)800;
		IEnumerable<object> enumerable3 = default(IEnumerable<object>);
		IEnumerable<object> enumerable2 = Enumerable.Take(enumerable3, 1);
		object obj94 = typeof(List<AdaptivePerformanceScaler>) + 416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj95 = (nint)0 + (nint)2640;
		num = (int)obj95;
		List<object> list2 = default(List<object>);
		list2..ctor(enumerable2);
		if (enumerable3 != null)
		{
			object obj96 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2992;
			nint num9 = (nint)enumerable3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1267 @ X8_v61 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1267 @ X8_v61 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_08e1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1267 @ X8_v61 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
			int num10 = (int)((nint)0 + (nint)8);
			bool flag20 = flag7;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1341 @ X10_v49 (System.Int32)-8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1341 @ X10_v49 (System.Int32)-8]");
				if (0 == (nint)obj96)
				{
					break;
				}
				num3 = num10 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1267 @ X8_v61 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
				array = (object[])(-1);
				flag7 = (nint)array != 1;
				flag20 = flag7;
				num10 = num3;
				if (flag7)
				{
					continue;
				}
				goto IL_08e1;
			}
			array = (object[])((int*)num10)->m_value;
			object obj97 = num9 + ((int*)num10)->m_value;
			object obj98 = obj97 + 312;
			flag7 = flag20;
			num3 = num10;
			goto IL_2004;
		}
		NullReferenceException ex7 = new NullReferenceException();
		obj13 = obj19;
		obj23 = obj22;
		obj25 = obj24;
		obj27 = obj26;
		num4 = num3;
		lookup2 = lookup;
		obj18 = enumerable2;
		obj15 = -1;
		goto IL_1b7a;
		IL_1171:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 0;
		goto IL_21e6;
		IL_2004:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1372 @ X0_v76+8]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1372 @ X0_v76] (should have been resolved before IL gen)");
		object obj99 = default(object);
		bool flag21 = obj99 == null;
		object obj100 = !flag21;
		obj23 = obj22;
		obj25 = obj24;
		obj27 = obj26;
		num4 = num3;
		lookup2 = lookup;
		num2 = num;
		object obj101 = obj99;
		object obj120;
		if (obj100 != null)
		{
			object obj109 = default(object);
			object obj115 = default(object);
			object obj122 = default(object);
			while (true)
			{
				object obj102 = obj101;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1426 @ X8_v66+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1426 @ X8_v66+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0b28;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1426 @ X8_v66+B0]");
				int num11 = (int)((nint)0 + (nint)8);
				bool flag22 = flag7;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1470 @ X10_v43 (System.Int32)-8]");
					obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1470 @ X10_v43 (System.Int32)-8]");
					if (0 == (nint)obj31)
					{
						break;
					}
					num4 = num11 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1426 @ X8_v66+12E]");
					array = (object[])(-1);
					flag7 = (nint)array != 1;
					flag22 = flag7;
					num11 = num4;
					if (flag7)
					{
						continue;
					}
					goto IL_0b28;
				}
				array = (object[])((int*)num11)->m_value;
				object obj103 = obj102 + ((int*)num11)->m_value;
				object obj104 = obj103 + 312;
				flag7 = flag22;
				num4 = num11;
				goto IL_20b2;
				IL_1380:
				NullReferenceException ex8 = new NullReferenceException();
				obj13 = (object)(&obj6);
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1634 @ X0_v105 (System.Object)+10]");
				obj25 = 0;
				obj27 = -1;
				obj88 = obj29;
				array = array2;
				obj15 = -1;
				goto IL_1b7a;
				IL_0f94:
				object obj105 = obj38;
				int version = list2._version + 1;
				list2._version = version;
				array2 = list2._items;
				bool flag23 = list2._items == null;
				int num12;
				obj18 = num12;
				object obj113;
				if (!flag23)
				{
					num3 = list2._size;
					obj22 = array2.Length;
					bool flag24 = list2._size < array2.Length;
					object obj106 = !flag24;
					if (obj106 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1733 @ X8_v100+20]");
						object obj107 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1779 @ X8_v103+C0]");
						object obj108 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1780 @ X8_v104+70]");
						num = 0;
						list2.AddWithResize(obj109);
						obj18 = obj109;
					}
					else
					{
						int size2 = list2._size + 1;
						list2._size = size2;
						object obj110 = list2._items + list2._size;
						object obj111 = obj110 + 32;
						obj111 = obj109;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj18 = obj109;
					}
					bool flag25 = obj6 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1634 @ X0_v105 (System.Object)+10]");
					obj24 = 0;
					obj26 = -1;
					obj88 = obj29;
					object obj112 = obj113;
					lookup = lookup2;
					array = array2;
					obj23 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1634 @ X0_v105 (System.Object)+10]");
					obj25 = 0;
					obj27 = -1;
					obj88 = obj29;
					obj112 = obj113;
					num4 = num3;
					num2 = num;
					obj101 = obj6;
					if (!flag25)
					{
						continue;
					}
					goto IL_093b;
				}
				goto IL_1380;
				IL_2162:
				int version2 = list2._version + 1;
				list2._size = 0;
				list2._version = version2;
				flag7 = num < 1;
				if (!flag7)
				{
					Array.Clear(list2._items, 0, num);
					lookup2 = null;
					num12 = 0;
				}
				goto IL_0f94;
				IL_0b28:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num2 = 0;
				goto IL_20b2;
				IL_20b2:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1485 @ X0_v80+8]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1485 @ X0_v80] (should have been resolved before IL gen)");
				object obj114 = obj115 & 1;
				if (obj114 == null)
				{
					break;
				}
				if (obj6 == null)
				{
					goto IL_1441;
				}
				object obj116 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 352;
				object obj117 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1495 @ X8_v92+12E]");
				array2 = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1495 @ X8_v92+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0c67;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1495 @ X8_v92+B0]");
				int num13 = (int)((nint)0 + (nint)8);
				bool flag26 = flag7;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1592 @ X10_v38 (System.Int32)-8]");
					obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1592 @ X10_v38 (System.Int32)-8]");
					if (0 == (nint)obj116)
					{
						break;
					}
					num4 = num13 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1495 @ X8_v92+12E]");
					array2 = (object[])(-1);
					flag7 = (nint)array2 != 1;
					flag26 = flag7;
					num13 = num4;
					if (flag7)
					{
						continue;
					}
					goto IL_0c67;
				}
				array2 = (object[])((int*)num13)->m_value;
				object obj118 = obj117 + ((int*)num13)->m_value;
				object obj119 = obj118 + 312;
				flag7 = flag26;
				num4 = num13;
				goto IL_212b;
				IL_0c67:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num2 = 0;
				goto IL_212b;
				IL_212b:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1631 @ X0_v103+8]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1631 @ X0_v103] (should have been resolved before IL gen)");
				if (obj109 == null)
				{
					goto IL_13d1;
				}
				obj18 = obj120;
				object obj121 = Enumerable.Last(list2);
				if (obj121 == null)
				{
					goto IL_1409;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1648 @ X0_v108 (System.Object)+10]");
				obj113 = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				if (((Enum)(&obj88)).Equals(obj122))
				{
					bool flag27 = list2 == null;
					object obj123 = !flag27;
					num = 0;
					num12 = (int)obj122;
					if (obj123 != null)
					{
						goto IL_0f94;
					}
					num = 0;
					obj18 = obj122;
					goto IL_1380;
				}
				if (list2 != null)
				{
					num = list2._size;
					bool flag28 = list2._size < size;
					num12 = (int)obj122;
					if (flag28)
					{
						goto IL_2162;
					}
					object obj124 = (nint)0 + (nint)800;
					num = (int)obj124;
					IEnumerable<object> source3 = Enumerable.Take(list2, size);
					List<object> list3 = Enumerable.ToList(source3);
					if (list != null)
					{
						int version3 = list._version + 1;
						list._version = version3;
						object[] items = list._items;
						bool flag29 = list._items == null;
						array2 = list._items;
						if (!flag29)
						{
							num4 = list._size;
							obj23 = items.Length;
							bool flag30 = list._size < items.Length;
							object obj125 = !flag30;
							if (obj125 == null)
							{
								int size3 = list._size + 1;
								list._size = size3;
								object obj126 = list._items + list._size;
								object obj127 = obj126 + 32;
								obj127 = list3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
							else
							{
								list.AddWithResize((object)list3);
							}
							num = list2._size;
							num12 = (int)list3;
							goto IL_2162;
						}
					}
					NullReferenceException ex9 = new NullReferenceException();
					obj13 = (object)(&obj6);
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1634 @ X0_v105 (System.Object)+10]");
					obj25 = 0;
					obj27 = -1;
					obj88 = obj29;
					array = array2;
					obj18 = list3;
					obj15 = -1;
				}
				else
				{
					NullReferenceException ex10 = new NullReferenceException();
					obj13 = (object)(&obj6);
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1634 @ X0_v105 (System.Object)+10]");
					obj25 = 0;
					obj27 = -1;
					obj88 = obj29;
					num = 0;
					array = array2;
					obj18 = obj122;
					obj15 = -1;
				}
				goto IL_1b7a;
			}
			if (obj6 != null)
			{
				object obj128 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj129 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X8_v86+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X8_v86+12E]");
				if ((nint)0 == 0)
				{
					goto IL_1171;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X8_v86+B0]");
				int num14 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1613 @ X10_v27 (System.Int32)-8]");
					obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1613 @ X10_v27 (System.Int32)-8]");
					if (0 == (nint)obj128)
					{
						break;
					}
					num4 = num14 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X8_v86+12E]");
					array = (object[])(-1);
					bool flag31 = (nint)array != 1;
					num14 = num4;
					if (flag31)
					{
						continue;
					}
					goto IL_1171;
				}
				array = (object[])((int*)num14)->m_value;
				object obj130 = obj129 + ((int*)num14)->m_value;
				object obj131 = obj130 + 312;
				num4 = num14;
				goto IL_21e6;
			}
			goto IL_1aea;
		}
		goto IL_093b;
		IL_1441:
		NullReferenceException ex11 = new NullReferenceException();
		obj13 = (object)(&obj6);
		obj14 = 0;
		num = num2;
		obj15 = -1;
		goto IL_1b7a;
		IL_0406:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num = 0;
		goto IL_1e80;
		IL_1e80:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X0_v58+8]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v482 @ X0_v58] (should have been resolved before IL gen)");
		object obj132 = default(object);
		if (obj132 != null)
		{
			obj31 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			obj120 = (nint)0 + (nint)1624;
			obj29 = typeof(System.Buffers.Text.ParserHelpers) + 3136;
			obj38 = (nint)0 + (nint)2648;
			obj19 = obj13;
			obj22 = obj23;
			obj24 = obj25;
			obj26 = obj27;
			num3 = num4;
			object obj133 = obj132;
			lookup = lookup2;
			num2 = num;
			object obj134 = obj133;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v44+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v44+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0663;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v44+B0]");
			int num15 = (int)((nint)0 + (nint)8);
			bool flag32 = flag7;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X10_v59 (System.Int32)-8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X10_v59 (System.Int32)-8]");
				if (0 == (nint)obj31)
				{
					break;
				}
				num3 = num15 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v44+12E]");
				array = (object[])(-1);
				flag7 = (nint)array != 1;
				flag32 = flag7;
				num15 = num3;
				if (flag7)
				{
					continue;
				}
				goto IL_0663;
			}
			array = (object[])((int*)num15)->m_value;
			object obj135 = obj134 + ((int*)num15)->m_value;
			object obj136 = obj135 + 312;
			flag7 = flag32;
			num3 = num15;
			goto IL_1eeb;
		}
		NullReferenceException ex12 = new NullReferenceException();
		goto IL_1b7a;
		IL_1800:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 0;
		goto IL_22e4;
		IL_1b7a:
		obj21 = (object)(&obj5);
		obj57 = 0;
		goto IL_1e41;
	}

	public static int GetBestProjectTeam(int dealer, List<List<Card>> playersCards, BalootGame.BalootGameMode gameMode)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0853: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0085: Expected I, but got O
		//IL_00d7: Expected O, but got I4
		//IL_0895: Expected O, but got I
		//IL_08a5: Expected O, but got I
		//IL_08c7: Expected O, but got I4
		//IL_011e: Expected O, but got I4
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected O, but got Unknown
		//IL_08ff: Expected O, but got I
		//IL_0910: Expected I, but got O
		//IL_092e: Expected O, but got I
		//IL_014e: Expected O, but got I
		//IL_01ce: Expected O, but got I4
		//IL_01de: Expected O, but got I4
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_0244: Expected O, but got I4
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected I4, but got Unknown
		//IL_02cf: Expected O, but got I4
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_0342: Expected O, but got I4
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected I4, but got Unknown
		//IL_03cd: Expected O, but got I4
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		//IL_045a: Expected O, but got I4
		//IL_047e: Expected O, but got I4
		//IL_0591: Expected O, but got I4
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected O, but got Unknown
		//IL_05d6: Unsupported input type for neg.
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected I4, but got Unknown
		//IL_09e7: Expected O, but got I4
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		//IL_0604: Expected O, but got I
		//IL_061e: Expected O, but got I4
		//IL_063a: Expected O, but got I4
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected O, but got Unknown
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected O, but got Unknown
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected O, but got Unknown
		//IL_068d: Unsupported input type for neg.
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected O, but got Unknown
		//IL_0a15: Expected O, but got I4
		//IL_06ad: Expected O, but got I
		//IL_06dd: Expected O, but got I4
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected O, but got Unknown
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected O, but got Unknown
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected O, but got Unknown
		//IL_0730: Unsupported input type for neg.
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected O, but got Unknown
		//IL_0a3e: Expected O, but got I4
		//IL_0750: Expected O, but got I
		//IL_076a: Expected O, but got I4
		//IL_0786: Expected O, but got I4
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected O, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected O, but got Unknown
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Expected O, but got Unknown
		//IL_07d9: Unsupported input type for neg.
		//IL_07d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Expected O, but got Unknown
		//IL_0a67: Expected O, but got I4
		//IL_0805: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool[] array2;
		int result;
		int result2;
		int num9;
		if (obj2 != null)
		{
			object obj3 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3744;
			object obj4 = (nint)0 + (nint)1032;
			object obj5 = (nint)0 + (nint)2832;
			object obj6 = (nint)0 + (nint)1320;
			object obj7 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2680;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj2, (IntPtr)obj4);
			IEnumerable<int> source = Enumerable.Select(playersCards, func);
			int[] array = Enumerable.ToArray(source);
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v12+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v18+50]");
			Func<int, bool> selector = (Func<int, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v18+50]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v12+E4]");
				bool flag3 = (nint)0 == 0;
				object obj12 = !flag3;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj13 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v24+B8]");
					obj10 = 0;
				}
				object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj15 = (nint)0 + (nint)992;
				Func<int, bool> func2 = default(Func<int, bool>);
				func2..ctor(obj10, (IntPtr)obj15);
				object obj16 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v23+B8]");
				object obj17 = (nint)0 + (nint)80;
				obj17 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func2;
			}
			IEnumerable<bool> source2 = Enumerable.Select(array, selector);
			array2 = Enumerable.ToArray(source2);
			if (array != null)
			{
				if (array.Length != 0)
				{
					bool flag4 = array.Length < 2;
					object obj18 = !flag4;
					object obj19 = array.Length - 2;
					bool flag5 = obj19 == null;
					object obj20 = ~obj18;
					object obj21 = obj20 | flag5;
					if (obj21 == null)
					{
						int num = array[0];
						object obj22 = array[0] - array[2];
						bool flag6 = (nint)obj22 < 0;
						bool flag7 = obj22 == null;
						int num2 = array[0] ^ array[2];
						int num3 = array[0] ^ obj22;
						int num4 = num2 & num3;
						bool flag8 = num4 < 0;
						bool flag9 = flag6 == flag8;
						object obj23 = !flag7;
						object obj24 = flag9 & obj23;
						object obj25 = ~obj24;
						if (obj25 != null)
						{
							num = array[2];
						}
						if (array.Length != 3)
						{
							int num5 = array[1];
							object obj26 = array[1] - array[3];
							bool flag10 = (nint)obj26 < 0;
							bool flag11 = obj26 == null;
							int num6 = array[1] ^ array[3];
							int num7 = array[1] ^ obj26;
							int num8 = num6 & num7;
							bool flag12 = num8 < 0;
							bool flag13 = flag10 == flag12;
							object obj27 = !flag11;
							object obj28 = flag13 & obj27;
							object obj29 = ~obj28;
							if (obj29 != null)
							{
								num5 = array[3];
							}
							if (num > num5)
							{
								result = 1;
								goto IL_09f5;
							}
							if (num5 > num)
							{
								return 2;
							}
							bool flag14 = num == 0;
							object obj30 = !flag14;
							object obj31 = ~obj30;
							bool flag15;
							if (obj31 == null)
							{
								object obj32 = num - num5;
								flag15 = obj32 == null;
							}
							else
							{
								flag15 = false;
							}
							if (!flag15)
							{
								return 0;
							}
							if (dealer <= 2)
							{
								bool flag16 = dealer == 1;
								result = 2;
								result2 = 1;
								if (flag16)
								{
									goto IL_0999;
								}
								if (dealer == 2)
								{
									goto IL_0575;
								}
								num9 = 0;
							}
							else
							{
								bool flag17 = dealer == 3;
								result = 2;
								result2 = 1;
								if (flag17)
								{
									goto IL_0999;
								}
								bool flag18 = dealer != 4;
								num9 = 0;
								if (!flag18)
								{
									goto IL_0575;
								}
							}
							goto IL_09b6;
						}
					}
				}
				goto IL_0837;
			}
		}
		goto IL_0845;
		IL_0999:
		if (array2 != null)
		{
			object obj33 = -dealer;
			object obj34 = obj33 & 3;
			int num10 = dealer & 3;
			if (0 >= dealer)
			{
				num10 = 0 - obj34;
			}
			bool flag19 = num10 < array2.Length;
			object obj35 = !flag19;
			if (obj35 == null)
			{
				object obj36 = array2 + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X9_v9+v410 @ X11_v5 (System.Int32)]");
				object obj37 = (nint)0 & (nint)1;
				bool flag20 = obj37 == null;
				object obj38 = !flag20;
				if (obj38 != null)
				{
					goto IL_09f5;
				}
				object obj39 = dealer + 1;
				object obj40 = 0 - obj39;
				object obj41 = obj40 & 3;
				object obj42 = obj39 & 3;
				if (0 >= (nint)obj39)
				{
					obj42 = 0 - obj41;
				}
				bool flag21 = (nint)obj42 < array2.Length;
				object obj43 = !flag21;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X9_v9+v411 @ X11_v9]");
					object obj44 = (nint)0 & (nint)1;
					if (obj44 != null)
					{
						return result2;
					}
					object obj45 = dealer + 2;
					object obj46 = 0 - obj45;
					object obj47 = obj46 & 3;
					object obj48 = obj45 & 3;
					if (0 >= (nint)obj45)
					{
						obj48 = 0 - obj47;
					}
					bool flag22 = (nint)obj48 < array2.Length;
					object obj49 = !flag22;
					if (obj49 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X9_v9+v412 @ X11_v13]");
						object obj50 = (nint)0 & (nint)1;
						bool flag23 = obj50 == null;
						object obj51 = !flag23;
						if (obj51 != null)
						{
							goto IL_09f5;
						}
						object obj52 = dealer + 3;
						object obj53 = 0 - obj52;
						object obj54 = obj53 & 3;
						object obj55 = obj52 & 3;
						if (0 >= (nint)obj52)
						{
							obj55 = 0 - obj54;
						}
						bool flag24 = (nint)obj55 < array2.Length;
						object obj56 = !flag24;
						if (obj56 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X9_v9+v192 @ X11_v17]");
							bool flag25 = (nint)0 == 0;
							object obj57 = !flag25;
							object obj58 = ~obj57;
							if (obj58 == null)
							{
								return result2;
							}
							return 0;
						}
					}
				}
			}
			goto IL_0837;
		}
		goto IL_0845;
		IL_0575:
		num9 = 2;
		goto IL_09b6;
		IL_09f5:
		return result;
		IL_09b6:
		result = 1;
		result2 = num9;
		goto IL_0999;
		IL_0845:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0837:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0845;
	}

	public static int GetCardValueRank(Card card, BalootGame.BalootGameMode gameMode)
	{
		//IL_019f: Expected I4, but got O
		//IL_0030: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_009c: Expected O, but got I4
		//IL_012a: Expected O, but got I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0152: Expected O, but got I4
		//IL_0184: Expected O, but got I4
		int result;
		if (card != null)
		{
			object obj = card.<Rank>k__BackingField - 5;
			bool flag = (nint)obj < 7;
			object obj2 = !flag;
			object obj3 = obj - 7;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			int num;
			if (obj5 == null)
			{
				object obj6 = 119877632 + 1096;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X9_v6+v3 @ X8_v2*4]");
				result = 0;
				bool flag3 = gameMode == BalootGame.BalootGameMode.Hokom;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X9_v6+v3 @ X8_v2*4]");
				num = 0;
				if (!flag3)
				{
					goto IL_00d9;
				}
			}
			else
			{
				bool flag4 = gameMode != BalootGame.BalootGameMode.Hokom;
				result = 0;
				num = 0;
				if (flag4)
				{
					goto IL_00d9;
				}
			}
			bool flag5 = (nint)obj < 7;
			object obj7 = !flag5;
			object obj8 = obj - 7;
			bool flag6 = obj8 == null;
			object obj9 = !flag6;
			object obj10 = obj7 & obj9;
			result = num;
			if (obj10 == null)
			{
				object obj11 = 119877632 + 1128;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X9_v3+v3 @ X8_v2*4]");
				return 0;
			}
			goto IL_00d9;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_00d9:
		return result;
	}

	public static int GetCardValueForScores(Card card, BalootGame.BalootGameMode gameMode)
	{
		//IL_01b2: Expected I4, but got O
		//IL_0030: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_009c: Expected O, but got I4
		//IL_0123: Expected O, but got I4
		//IL_013d: Expected O, but got I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0165: Expected O, but got I4
		//IL_0197: Expected O, but got I4
		int result;
		if (card != null)
		{
			object obj = card.<Rank>k__BackingField - 8;
			bool flag = (nint)obj < 4;
			object obj2 = !flag;
			object obj3 = obj - 4;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			int num;
			if (obj5 == null)
			{
				object obj6 = 119877632 + 1160;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X10_v4+v3 @ X9_v1*4]");
				result = 0;
				bool flag3 = gameMode == BalootGame.BalootGameMode.Hokom;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X10_v4+v3 @ X9_v1*4]");
				num = 0;
				if (!flag3)
				{
					goto IL_00d9;
				}
			}
			else
			{
				bool flag4 = gameMode != BalootGame.BalootGameMode.Hokom;
				result = 0;
				num = 0;
				if (flag4)
				{
					goto IL_00d9;
				}
			}
			object obj7 = card.<Rank>k__BackingField - 5;
			bool flag5 = (nint)obj7 < 7;
			object obj8 = !flag5;
			object obj9 = obj7 - 7;
			bool flag6 = obj9 == null;
			object obj10 = !flag6;
			object obj11 = obj8 & obj10;
			result = num;
			if (obj11 == null)
			{
				object obj12 = 119877632 + 1180;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X9_v3+v83 @ X8_v2*4]");
				return 0;
			}
			goto IL_00d9;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_00d9:
		return result;
	}

	public static int CheckWhoEats(Card[] cards, Suit currentSuit, BalootGame.BalootGameMode gameMode, Suit trumpSuit)
	{
		//IL_1bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf5: Expected O, but got Unknown
		//IL_1b9e: Expected I4, but got O
		//IL_002c: Expected O, but got I4
		//IL_173b: Expected O, but got I
		//IL_1750: Expected O, but got I
		//IL_01ce: Expected O, but got I4
		//IL_179e: Expected O, but got I4
		//IL_1821: Expected O, but got I
		//IL_1837: Expected O, but got I
		//IL_17c2: Expected O, but got I
		//IL_17d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17dc: Expected O, but got Unknown
		//IL_17f7: Expected O, but got I
		//IL_188a: Expected O, but got I4
		//IL_00d1: Expected O, but got I4
		//IL_00eb: Expected O, but got I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0113: Expected O, but got I4
		//IL_0120: Expected I4, but got O
		//IL_190d: Expected O, but got I
		//IL_1923: Expected O, but got I
		//IL_0273: Expected O, but got I4
		//IL_028d: Expected O, but got I4
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_02b5: Expected O, but got I4
		//IL_02c2: Expected I4, but got O
		//IL_18ae: Expected O, but got I
		//IL_18c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c8: Expected O, but got Unknown
		//IL_18e3: Expected O, but got I
		//IL_05a5: Expected O, but got I4
		//IL_05bf: Expected O, but got I4
		//IL_1976: Expected O, but got I4
		//IL_03b6: Expected O, but got I4
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03de: Expected O, but got I4
		//IL_03eb: Expected I4, but got O
		//IL_19f9: Expected O, but got I
		//IL_1a0f: Expected O, but got I
		//IL_199a: Expected O, but got I
		//IL_19af: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b4: Expected O, but got Unknown
		//IL_19cf: Expected O, but got I
		//IL_1a63: Expected O, but got I4
		//IL_1c40: Expected O, but got I4
		//IL_1c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4e: Expected O, but got Unknown
		//IL_1c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c73: Expected I4, but got Unknown
		//IL_04aa: Expected O, but got I4
		//IL_04c4: Expected O, but got I4
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_04ec: Expected O, but got I4
		//IL_0ae0: Expected O, but got I4
		//IL_0ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aee: Expected O, but got Unknown
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected I4, but got Unknown
		//IL_06cf: Expected O, but got I4
		//IL_06e9: Expected O, but got I4
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected O, but got Unknown
		//IL_0711: Expected O, but got I4
		//IL_1a87: Expected O, but got I
		//IL_1a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa1: Expected O, but got Unknown
		//IL_0a05: Expected O, but got I4
		//IL_0a1f: Expected O, but got I4
		//IL_1afc: Expected O, but got I4
		//IL_0765: Expected O, but got I4
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected O, but got Unknown
		//IL_078d: Expected O, but got I4
		//IL_079a: Expected I4, but got O
		//IL_081e: Expected O, but got I4
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Expected O, but got Unknown
		//IL_0846: Expected O, but got I4
		//IL_0a66: Expected O, but got I4
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Expected O, but got Unknown
		//IL_0a8e: Expected O, but got I4
		//IL_0a9b: Expected I4, but got O
		//IL_0912: Expected O, but got I4
		//IL_092c: Expected O, but got I4
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected O, but got Unknown
		//IL_0954: Expected O, but got I4
		//IL_0961: Expected I4, but got O
		//IL_0bb8: Expected O, but got I4
		//IL_0bd2: Expected O, but got I4
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be0: Expected O, but got Unknown
		//IL_0bfa: Expected O, but got I4
		//IL_0c07: Expected I4, but got O
		//IL_0ed1: Expected O, but got I4
		//IL_0eeb: Expected O, but got I4
		//IL_0cd2: Expected O, but got I4
		//IL_0cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce0: Expected O, but got Unknown
		//IL_0cfa: Expected O, but got I4
		//IL_0d07: Expected I4, but got O
		//IL_0dc9: Expected O, but got I4
		//IL_0de3: Expected O, but got I4
		//IL_0dec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df1: Expected O, but got Unknown
		//IL_0e0b: Expected O, but got I4
		//IL_0e35: Expected O, but got I4
		object obj;
		int num;
		Suit suit;
		int num2;
		int num3;
		int num4;
		int num5;
		int item;
		Card card;
		Suit <Suit>k__BackingField;
		bool flag4;
		if (BalootGameModeExtensions.IsSunOrAshkal(gameMode))
		{
			if (cards != null)
			{
				obj = cards.Length;
				bool flag = cards.Length == 0;
				num = 152993792;
				if (flag)
				{
					goto IL_0f58;
				}
				card = cards[0];
				if (cards[0] != null)
				{
					<Suit>k__BackingField = card.<Suit>k__BackingField;
					if (card.<Suit>k__BackingField == currentSuit)
					{
						card = (Card)(card.<Rank>k__BackingField - 5);
						bool flag2 = (nint)card < 7;
						object obj2 = !flag2;
						object obj3 = card - 7;
						bool flag3 = obj3 == null;
						object obj4 = !flag3;
						if ((obj2 & obj4) == 0)
						{
							suit = (Suit)119878728;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X10_v73 (Suit)+v402 @ X9_v23 (Card)*4]");
							num2 = 0;
							if (gameMode == BalootGame.BalootGameMode.Hokom)
							{
								goto IL_039c;
							}
							<Suit>k__BackingField = suit;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X10_v73 (Suit)+v402 @ X9_v23 (Card)*4]");
							num = 0;
						}
						else
						{
							flag4 = gameMode != BalootGame.BalootGameMode.Hokom;
							suit = card.<Suit>k__BackingField;
							num2 = 0;
							num = 0;
							if (!flag4)
							{
								goto IL_039c;
							}
						}
					}
					else
					{
						num = 0;
					}
					goto IL_1bc4;
				}
			}
		}
		else
		{
			if (gameMode != BalootGame.BalootGameMode.Hokom)
			{
				num3 = 0;
				num4 = 0;
				num5 = 0;
				item = 0;
				goto IL_1be1;
			}
			if (cards != null)
			{
				obj = cards.Length;
				bool flag = cards.Length == 0;
				num = 152993792;
				if (!flag)
				{
					card = cards[0];
					if (cards[0] == null)
					{
						goto IL_1b90;
					}
					<Suit>k__BackingField = card.<Suit>k__BackingField;
					if (card.<Suit>k__BackingField == trumpSuit)
					{
						card = (Card)(card.<Rank>k__BackingField - 5);
						bool flag5 = (nint)card < 7;
						object obj5 = !flag5;
						object obj6 = card - 7;
						bool flag6 = obj6 == null;
						object obj7 = !flag6;
						if ((obj5 & obj7) == 0)
						{
							<Suit>k__BackingField = (Suit)119878760;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v35 (Suit)+v402 @ X9_v23 (Card)*4]");
							num5 = 0;
							if (cards.Length != 1)
							{
								goto IL_0652;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v35 (Suit)+v402 @ X9_v23 (Card)*4]");
							num = 0;
							goto IL_0f58;
						}
					}
					else if (card.<Suit>k__BackingField == currentSuit)
					{
						card = (Card)(card.<Rank>k__BackingField - 5);
						bool flag7 = (nint)card < 8;
						object obj8 = !flag7;
						if (obj8 == null)
						{
							<Suit>k__BackingField = (Suit)119878728;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v35 (Suit)+v402 @ X9_v23 (Card)*4]");
							num5 = 0;
							if (cards.Length != 1)
							{
								goto IL_0652;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v35 (Suit)+v402 @ X9_v23 (Card)*4]");
							num = 0;
							goto IL_0f58;
						}
					}
					bool flag8 = (nint)obj == 1;
					num5 = 0;
					num = 0;
					if (!flag8)
					{
						goto IL_0652;
					}
				}
				goto IL_0f58;
			}
		}
		goto IL_1b90;
		IL_1bc4:
		if ((nint)obj == 1)
		{
			goto IL_0f58;
		}
		card = cards[1];
		if (cards[1] == null)
		{
			goto IL_1b90;
		}
		<Suit>k__BackingField = card.<Suit>k__BackingField;
		Suit suit2;
		int num6;
		int num7 = default(int);
		if (card.<Suit>k__BackingField == currentSuit)
		{
			card = (Card)(card.<Rank>k__BackingField - 5);
			bool flag9 = (nint)card < 7;
			object obj9 = !flag9;
			object obj10 = card - 7;
			bool flag10 = obj10 == null;
			object obj11 = !flag10;
			object obj12 = obj9 & obj11;
			if (obj12 == null)
			{
				suit2 = (Suit)119878728;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1242 @ X10_v68 (Suit)+v402 @ X9_v23 (Card)*4]");
				num6 = 0;
				if (gameMode == BalootGame.BalootGameMode.Hokom)
				{
					goto IL_0804;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1242 @ X10_v68 (Suit)+v402 @ X9_v23 (Card)*4]");
				num7 = 0;
				<Suit>k__BackingField = suit2;
			}
			else
			{
				bool flag11 = gameMode != BalootGame.BalootGameMode.Hokom;
				num6 = 0;
				suit2 = card.<Suit>k__BackingField;
				num7 = 0;
				if (!flag11)
				{
					goto IL_0804;
				}
			}
		}
		else
		{
			num7 = 0;
		}
		goto IL_1c26;
		IL_1715:
		item = 0;
		goto IL_1be1;
		IL_0f9c:
		Card card2 = cards[3];
		int num8;
		int num9;
		int num10;
		int num11;
		if (cards[3] != null)
		{
			if (card2.<Suit>k__BackingField == trumpSuit)
			{
				if (card2.<Rank>k__BackingField <= Rank.TEN)
				{
					if (card2.<Rank>k__BackingField <= Rank.EIGHT)
					{
						if (card2.<Rank>k__BackingField == Rank.SEVEN)
						{
							goto IL_1633;
						}
						bool flag12 = card2.<Rank>k__BackingField == Rank.EIGHT;
						num7 = num3;
						num8 = num4;
						num = num5;
						if (flag12)
						{
							goto IL_119b;
						}
					}
					else
					{
						if (card2.<Rank>k__BackingField == Rank.NINE)
						{
							goto IL_164f;
						}
						bool flag13 = card2.<Rank>k__BackingField == Rank.TEN;
						num7 = num3;
						num9 = num4;
						num = num5;
						if (flag13)
						{
							goto IL_1498;
						}
					}
				}
				else if (card2.<Rank>k__BackingField <= Rank.QUEEN)
				{
					if (card2.<Rank>k__BackingField == Rank.JACK)
					{
						goto IL_1641;
					}
					bool flag14 = card2.<Rank>k__BackingField == Rank.QUEEN;
					num7 = num3;
					num10 = num4;
					num = num5;
					if (flag14)
					{
						goto IL_139a;
					}
				}
				else
				{
					if (card2.<Rank>k__BackingField == Rank.KING)
					{
						goto IL_165d;
					}
					bool flag15 = card2.<Rank>k__BackingField == Rank.ACE;
					num7 = num3;
					num11 = num4;
					num = num5;
					if (flag15)
					{
						goto IL_160d;
					}
				}
			}
			else if (card2.<Suit>k__BackingField == currentSuit)
			{
				if (card2.<Rank>k__BackingField <= Rank.TEN)
				{
					if (card2.<Rank>k__BackingField <= Rank.EIGHT)
					{
						if (card2.<Rank>k__BackingField != Rank.SEVEN)
						{
							if (card2.<Rank>k__BackingField != Rank.EIGHT)
							{
								goto IL_1715;
							}
							item = 2;
						}
						else
						{
							item = 1;
						}
					}
					else if (card2.<Rank>k__BackingField != Rank.NINE)
					{
						if (card2.<Rank>k__BackingField != Rank.TEN)
						{
							goto IL_1715;
						}
						item = 7;
					}
					else
					{
						item = 3;
					}
				}
				else if (card2.<Rank>k__BackingField <= Rank.QUEEN)
				{
					if (card2.<Rank>k__BackingField != Rank.JACK)
					{
						if (card2.<Rank>k__BackingField != Rank.QUEEN)
						{
							goto IL_1715;
						}
						item = 5;
					}
					else
					{
						item = 4;
					}
				}
				else if (card2.<Rank>k__BackingField != Rank.KING)
				{
					if (card2.<Rank>k__BackingField != Rank.ACE)
					{
						goto IL_1715;
					}
					item = 8;
				}
				else
				{
					item = 6;
				}
				goto IL_1be1;
			}
			goto IL_1715;
		}
		goto IL_1b90;
		IL_10e0:
		Card card3;
		int num12;
		if (card3.<Rank>k__BackingField <= Rank.TEN)
		{
			if (card3.<Rank>k__BackingField <= Rank.EIGHT)
			{
				bool flag16 = card3.<Rank>k__BackingField == Rank.SEVEN;
				num3 = num7;
				num5 = num;
				if (flag16)
				{
					goto IL_1633;
				}
				bool flag17 = card3.<Rank>k__BackingField != Rank.EIGHT;
				num8 = num4;
				num3 = num7;
				num5 = num;
				item = num12;
				if (!flag17)
				{
					goto IL_119b;
				}
			}
			else
			{
				bool flag18 = card3.<Rank>k__BackingField == Rank.NINE;
				num3 = num7;
				num5 = num;
				if (flag18)
				{
					goto IL_164f;
				}
				bool flag19 = card3.<Rank>k__BackingField != Rank.TEN;
				num9 = num4;
				num3 = num7;
				num5 = num;
				item = num12;
				if (!flag19)
				{
					goto IL_1498;
				}
			}
		}
		else if (card3.<Rank>k__BackingField <= Rank.QUEEN)
		{
			bool flag20 = card3.<Rank>k__BackingField == Rank.JACK;
			num3 = num7;
			num5 = num;
			if (flag20)
			{
				goto IL_1641;
			}
			bool flag21 = card3.<Rank>k__BackingField != Rank.QUEEN;
			num10 = num4;
			num3 = num7;
			num5 = num;
			item = num12;
			if (!flag21)
			{
				goto IL_139a;
			}
		}
		else
		{
			bool flag22 = card3.<Rank>k__BackingField == Rank.KING;
			num3 = num7;
			num5 = num;
			if (flag22)
			{
				goto IL_165d;
			}
			bool flag23 = card3.<Rank>k__BackingField != Rank.ACE;
			num11 = num4;
			num3 = num7;
			num5 = num;
			item = num12;
			if (!flag23)
			{
				goto IL_160d;
			}
		}
		goto IL_1be1;
		IL_1c81:
		if ((nint)obj == 3)
		{
			goto IL_0f58;
		}
		card3 = cards[3];
		if (cards[3] == null)
		{
			goto IL_1b90;
		}
		bool flag24 = card3.<Suit>k__BackingField != currentSuit;
		num3 = num7;
		num5 = num;
		if (flag24)
		{
			goto IL_1715;
		}
		object obj13 = card3.<Rank>k__BackingField - 5;
		bool flag25 = (nint)obj13 < 7;
		object obj14 = !flag25;
		object obj15 = obj13 - 7;
		bool flag26 = obj15 == null;
		object obj16 = !flag26;
		object obj17 = obj14 & obj16;
		if (obj17 == null)
		{
			object obj18 = 119877632 + 1096;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X10_v62+v666 @ X9_v51*4]");
			item = 0;
			bool flag27 = gameMode != BalootGame.BalootGameMode.Hokom;
			num3 = num7;
			num5 = num;
			if (!flag27)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X10_v62+v666 @ X9_v51*4]");
				num12 = 0;
				goto IL_10e0;
			}
		}
		else
		{
			bool flag28 = gameMode != BalootGame.BalootGameMode.Hokom;
			num12 = 0;
			num3 = num7;
			num5 = num;
			item = 0;
			if (!flag28)
			{
				goto IL_10e0;
			}
		}
		goto IL_1be1;
		IL_0f66:
		bool flag29 = (nint)obj == 3;
		num3 = num7;
		num4 = 0;
		num5 = num;
		if (flag29)
		{
			goto IL_0f58;
		}
		goto IL_0f9c;
		IL_119b:
		num3 = num7;
		num4 = num8;
		num5 = num;
		item = 10;
		goto IL_1be1;
		IL_1633:
		item = 9;
		goto IL_1be1;
		IL_1c26:
		bool flag30 = (nint)obj < 2;
		object obj19 = !flag30;
		object obj20 = obj - 2;
		bool flag31 = obj20 == null;
		object obj21 = ~obj19;
		if (((obj21 | flag31) ? 1 : 0) != 0)
		{
			goto IL_0f58;
		}
		card = cards[2];
		if (cards[2] == null)
		{
			goto IL_1b90;
		}
		<Suit>k__BackingField = card.<Suit>k__BackingField;
		Suit suit3;
		int num13;
		if (card.<Suit>k__BackingField == currentSuit)
		{
			card = (Card)(card.<Rank>k__BackingField - 5);
			bool flag32 = (nint)card < 7;
			object obj22 = !flag32;
			object obj23 = card - 7;
			bool flag33 = obj23 == null;
			object obj24 = !flag33;
			if ((obj22 & obj24) == 0)
			{
				suit3 = (Suit)119878728;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1480 @ X10_v63 (Suit)+v402 @ X9_v23 (Card)*4]");
				num13 = 0;
				if (gameMode == BalootGame.BalootGameMode.Hokom)
				{
					goto IL_0cb8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1480 @ X10_v63 (Suit)+v402 @ X9_v23 (Card)*4]");
				num4 = 0;
			}
			else
			{
				flag4 = gameMode != BalootGame.BalootGameMode.Hokom;
				num13 = 0;
				suit3 = card.<Suit>k__BackingField;
				num4 = 0;
				if (!flag4)
				{
					goto IL_0cb8;
				}
			}
		}
		else
		{
			num4 = 0;
		}
		goto IL_1c81;
		IL_0cb8:
		bool flag34 = (nint)card < 7;
		object obj25 = !flag34;
		object obj26 = card - 7;
		bool flag35 = obj26 == null;
		object obj27 = !flag35;
		flag4 = (byte)(obj25 & obj27) != 0;
		num4 = num13;
		<Suit>k__BackingField = suit3;
		if (!flag4)
		{
			<Suit>k__BackingField = (Suit)119878760;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v35 (Suit)+v402 @ X9_v23 (Card)*4]");
			num4 = 0;
		}
		goto IL_1c81;
		IL_1be1:
		object obj28 = typeof(List<AdaptivePerformanceScaler>) + 1800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<int> list = default(List<int>);
		list..ctor();
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj29 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X9_v7+18]");
				bool flag36 = num14 < 0;
				object obj31 = !flag36;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj32 = (nint)0 + (nint)1;
					object obj33 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj34 = obj33 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj35 = (nint)0 + (nint)1;
				}
				else
				{
					list.AddWithResize(num5);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
					obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj36 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
					if ((nint)0 == 0)
					{
						goto IL_1b90;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X9_v7+18]");
				bool flag37 = num15 < 0;
				object obj37 = !flag37;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj38 = (nint)0 + (nint)1;
					object obj39 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj40 = obj39 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj41 = (nint)0 + (nint)1;
				}
				else
				{
					list.AddWithResize(num3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
					obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj42 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
					if ((nint)0 == 0)
					{
						goto IL_1b90;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X9_v7+18]");
				bool flag38 = num16 < 0;
				object obj43 = !flag38;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj44 = (nint)0 + (nint)1;
					object obj45 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj46 = obj45 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj47 = (nint)0 + (nint)1;
				}
				else
				{
					list.AddWithResize(num4);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
					obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj48 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
					if ((nint)0 == 0)
					{
						goto IL_1b90;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X9_v7+18]");
				bool flag39 = num17 < 0;
				object obj49 = !flag39;
				if (obj49 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj50 = (nint)0 + (nint)1;
					object obj51 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj52 = obj51 + 0;
				}
				else
				{
					list.AddWithResize(item);
				}
				int item2 = Enumerable.Max(list);
				int num18 = list.IndexOf(item2);
				bool flag40 = num18 < 3;
				object obj53 = !flag40;
				int result = ((num18 == 3) ? 4 : 0);
				object obj54 = ~obj53;
				if (obj54 == null)
				{
					return result;
				}
				return num18 + 1;
			}
		}
		goto IL_1b90;
		IL_1498:
		num3 = num7;
		num4 = num9;
		num5 = num;
		item = 13;
		goto IL_1be1;
		IL_1b90:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0652:
		card = cards[1];
		if (cards[1] != null)
		{
			<Suit>k__BackingField = card.<Suit>k__BackingField;
			if (card.<Suit>k__BackingField == trumpSuit)
			{
				card = (Card)(card.<Rank>k__BackingField - 5);
				bool flag41 = (nint)card < 7;
				object obj55 = !flag41;
				object obj56 = card - 7;
				bool flag42 = obj56 == null;
				object obj57 = !flag42;
				object obj58 = obj55 & obj57;
				if (obj58 == null)
				{
					<Suit>k__BackingField = (Suit)119878760;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v35 (Suit)+v402 @ X9_v23 (Card)*4]");
					num3 = 0;
					bool flag43 = (nint)obj < 2;
					object obj59 = !flag43;
					object obj60 = obj - 2;
					bool flag44 = obj60 == null;
					object obj61 = !flag44;
					if ((obj59 & obj61) != 0)
					{
						goto IL_0b3b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v35 (Suit)+v402 @ X9_v23 (Card)*4]");
					num7 = 0;
					num = num5;
					goto IL_0f58;
				}
			}
			else if (card.<Suit>k__BackingField == currentSuit)
			{
				card = (Card)(card.<Rank>k__BackingField - 5);
				bool flag45 = (nint)card < 8;
				object obj62 = !flag45;
				if (obj62 == null)
				{
					<Suit>k__BackingField = (Suit)119878728;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v35 (Suit)+v402 @ X9_v23 (Card)*4]");
					num3 = 0;
					bool flag46 = (nint)obj < 2;
					object obj63 = !flag46;
					object obj64 = obj - 2;
					bool flag47 = obj64 == null;
					object obj65 = !flag47;
					if ((obj63 & obj65) != 0)
					{
						goto IL_0b3b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v35 (Suit)+v402 @ X9_v23 (Card)*4]");
					num7 = 0;
					num = num5;
					goto IL_0f58;
				}
			}
			bool flag48 = (nint)obj < 2;
			object obj66 = !flag48;
			object obj67 = obj - 2;
			bool flag49 = obj67 == null;
			object obj68 = ~obj66;
			flag4 = (byte)((obj68 | flag49) ? 1 : 0) != 0;
			num3 = 0;
			num7 = 0;
			num = num5;
			if (!flag4)
			{
				goto IL_0b3b;
			}
			goto IL_0f58;
		}
		goto IL_1b90;
		IL_165d:
		item = 12;
		goto IL_1be1;
		IL_0804:
		bool flag50 = (nint)card < 7;
		object obj69 = !flag50;
		object obj70 = card - 7;
		bool flag51 = obj70 == null;
		object obj71 = !flag51;
		object obj72 = obj69 & obj71;
		num7 = num6;
		<Suit>k__BackingField = suit2;
		if (obj72 == null)
		{
			<Suit>k__BackingField = (Suit)119878760;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v35 (Suit)+v402 @ X9_v23 (Card)*4]");
			num7 = 0;
		}
		goto IL_1c26;
		IL_0f58:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0f66;
		IL_1641:
		item = 16;
		goto IL_1be1;
		IL_139a:
		num3 = num7;
		num4 = num10;
		num5 = num;
		item = 11;
		goto IL_1be1;
		IL_039c:
		bool flag52 = (nint)card < 7;
		object obj73 = !flag52;
		object obj74 = card - 7;
		bool flag53 = obj74 == null;
		object obj75 = !flag53;
		flag4 = (byte)(obj73 & obj75) != 0;
		<Suit>k__BackingField = suit;
		num = num2;
		if (!flag4)
		{
			<Suit>k__BackingField = (Suit)119878760;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v35 (Suit)+v402 @ X9_v23 (Card)*4]");
			num = 0;
		}
		goto IL_1bc4;
		IL_160d:
		num3 = num7;
		num4 = num11;
		num5 = num;
		item = 14;
		goto IL_1be1;
		IL_164f:
		item = 15;
		goto IL_1be1;
		IL_0b3b:
		card = cards[2];
		if (cards[2] != null)
		{
			<Suit>k__BackingField = card.<Suit>k__BackingField;
			if (card.<Suit>k__BackingField == trumpSuit)
			{
				card = (Card)(card.<Rank>k__BackingField - 5);
				bool flag54 = (nint)card < 7;
				object obj76 = !flag54;
				object obj77 = card - 7;
				bool flag55 = obj77 == null;
				object obj78 = !flag55;
				flag4 = (byte)(obj76 & obj78) != 0;
				num7 = num3;
				num = num5;
				if (!flag4)
				{
					<Suit>k__BackingField = (Suit)119878760;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v35 (Suit)+v402 @ X9_v23 (Card)*4]");
					num4 = 0;
					if ((nint)obj == 3)
					{
						num7 = num3;
						num = num5;
						goto IL_0f58;
					}
					goto IL_0f9c;
				}
			}
			else
			{
				flag4 = card.<Suit>k__BackingField != currentSuit;
				num7 = num3;
				num = num5;
				if (!flag4)
				{
					card = (Card)(card.<Rank>k__BackingField - 5);
					bool flag56 = (nint)card < 8;
					object obj79 = !flag56;
					num7 = num3;
					num = num5;
					if (obj79 == null)
					{
						<Suit>k__BackingField = (Suit)119878728;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v35 (Suit)+v402 @ X9_v23 (Card)*4]");
						num4 = 0;
						flag4 = (nint)obj != 3;
						num7 = num3;
						num = num5;
						if (!flag4)
						{
							goto IL_0f58;
						}
						goto IL_0f9c;
					}
				}
			}
			goto IL_0f66;
		}
		goto IL_1b90;
	}

	public unsafe static List<Card> PlayableCards(List<Card> cards, Card[] playedCards, bool firstPlayer, int playerIndex, BalootGame.BalootGameMode gameMode, Suit currentSuit, Suit trumpSuit, bool isHokomClose, bool[] ekkahFlags)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0041: Expected O, but got I
		//IL_02f1: Expected O, but got I
		//IL_02fd: Expected O, but got I
		//IL_03b0: Expected I4, but got O
		//IL_03ff: Expected O, but got I4
		//IL_00ef: Expected O, but got I
		//IL_354d: Expected O, but got I4
		//IL_0415: Expected I4, but got O
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected O, but got Unknown
		//IL_068f: Expected O, but got I
		//IL_06a0: Expected I, but got O
		//IL_0478: Expected I4, but got O
		//IL_04ce: Expected O, but got I4
		//IL_06ec: Expected O, but got I
		//IL_032c: Expected O, but got I
		//IL_033c: Expected O, but got I
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected O, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_023c: Expected O, but got I4
		//IL_0e8d: Expected O, but got I4
		//IL_0d98: Expected O, but got I4
		//IL_0dac: Expected O, but got I8
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0c32: Expected O, but got I8
		//IL_0b45: Expected O, but got I4
		//IL_369c: Unknown result type (might be due to invalid IL or missing references)
		//IL_36a1: Expected O, but got Unknown
		//IL_0929: Expected O, but got I4
		//IL_39f3: Expected O, but got I8
		//IL_364e: Expected O, but got I4
		//IL_3657: Unknown result type (might be due to invalid IL or missing references)
		//IL_365c: Expected O, but got Unknown
		//IL_367c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3681: Expected O, but got Unknown
		//IL_399c: Expected O, but got I4
		//IL_39ac: Expected O, but got I4
		//IL_39cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_39d1: Expected O, but got Unknown
		//IL_0f3c: Expected O, but got I4
		//IL_3612: Unknown result type (might be due to invalid IL or missing references)
		//IL_3617: Expected O, but got Unknown
		//IL_0e59: Expected O, but got I4
		//IL_30fc: Expected O, but got I4
		//IL_3963: Expected O, but got I8
		//IL_3784: Unknown result type (might be due to invalid IL or missing references)
		//IL_3789: Expected O, but got Unknown
		//IL_35c4: Expected O, but got I4
		//IL_35cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_35d2: Expected O, but got Unknown
		//IL_35f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_35f7: Expected O, but got Unknown
		//IL_3ea2: Expected O, but got I8
		//IL_30bb: Expected O, but got I4
		//IL_35a5: Expected O, but got I4
		//IL_0802: Expected O, but got I4
		//IL_0bf4: Expected O, but got I4
		//IL_3755: Unknown result type (might be due to invalid IL or missing references)
		//IL_375a: Expected O, but got Unknown
		//IL_3dc0: Expected O, but got I8
		//IL_3fb8: Expected O, but got I4
		//IL_3fc8: Expected O, but got I4
		//IL_3fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fed: Expected O, but got Unknown
		//IL_1248: Expected O, but got I4
		//IL_09d8: Expected O, but got I4
		//IL_3904: Expected O, but got I4
		//IL_390c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3911: Expected O, but got Unknown
		//IL_392b: Expected O, but got I4
		//IL_3707: Expected O, but got I4
		//IL_3710: Unknown result type (might be due to invalid IL or missing references)
		//IL_3715: Expected O, but got Unknown
		//IL_3735: Unknown result type (might be due to invalid IL or missing references)
		//IL_373a: Expected O, but got Unknown
		//IL_1185: Expected O, but got I4
		//IL_3cc0: Expected O, but got I4
		//IL_3cd0: Expected O, but got I4
		//IL_3cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cf5: Expected O, but got Unknown
		//IL_38a0: Expected O, but got I4
		//IL_38a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_38ad: Expected O, but got Unknown
		//IL_38c7: Expected O, but got I4
		//IL_36cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_36d0: Expected O, but got Unknown
		//IL_2cc4: Expected O, but got I4
		//IL_3c35: Expected O, but got I4
		//IL_3c3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c42: Expected O, but got Unknown
		//IL_3c5c: Expected O, but got I4
		//IL_23e7: Expected O, but got I4
		//IL_10c2: Expected O, but got I4
		//IL_2c6c: Expected O, but got I4
		//IL_3a4c: Expected O, but got I8
		//IL_1558: Expected O, but got I4
		//IL_383c: Expected O, but got I4
		//IL_3844: Unknown result type (might be due to invalid IL or missing references)
		//IL_3849: Expected O, but got Unknown
		//IL_3863: Expected O, but got I4
		//IL_3bda: Expected O, but got I4
		//IL_3be2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3be7: Expected O, but got Unknown
		//IL_3c01: Expected O, but got I4
		//IL_2119: Expected O, but got I4
		//IL_0fff: Expected O, but got I4
		//IL_288e: Expected O, but got I4
		//IL_14b6: Expected O, but got I4
		//IL_1576: Expected O, but got I4
		//IL_1583: Expected O, but got I4
		//IL_159d: Expected O, but got I4
		//IL_325c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3261: Expected O, but got Unknown
		//IL_326a: Unknown result type (might be due to invalid IL or missing references)
		//IL_326f: Expected O, but got Unknown
		//IL_3289: Expected O, but got I4
		//IL_3ef8: Expected O, but got I4
		//IL_3f05: Expected O, but got I4
		//IL_3f1f: Expected O, but got I4
		//IL_2836: Expected O, but got I4
		//IL_2db9: Expected O, but got I4
		//IL_2dcf: Expected O, but got I
		//IL_2def: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df4: Expected O, but got Unknown
		//IL_3b7f: Expected O, but got I4
		//IL_3b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b8c: Expected O, but got Unknown
		//IL_3ba6: Expected O, but got I4
		//IL_1e4b: Expected O, but got I4
		//IL_2cf0: Expected O, but got I4
		//IL_2cfd: Expected O, but got I4
		//IL_2d17: Expected O, but got I4
		//IL_1baa: Expected O, but got I4
		//IL_1bb7: Expected O, but got I4
		//IL_1bd1: Expected O, but got I4
		//IL_2427: Expected O, but got I
		//IL_2437: Expected O, but got I4
		//IL_1414: Expected O, but got I4
		//IL_3f5c: Expected O, but got I4
		//IL_3f69: Expected O, but got I4
		//IL_3f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f8e: Expected O, but got Unknown
		//IL_297b: Expected O, but got I8
		//IL_2e12: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e17: Expected O, but got Unknown
		//IL_2e20: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e25: Expected O, but got Unknown
		//IL_2e3f: Expected O, but got I4
		//IL_2cb6: Expected O, but got I4
		//IL_2159: Expected O, but got I
		//IL_2169: Expected O, but got I4
		//IL_130d: Expected O, but got I4
		//IL_131a: Expected O, but got I4
		//IL_1334: Expected O, but got I4
		//IL_28ba: Expected O, but got I4
		//IL_28c7: Expected O, but got I4
		//IL_28e1: Expected O, but got I4
		//IL_3e1e: Expected O, but got I4
		//IL_3e2b: Expected O, but got I4
		//IL_3e4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e50: Expected O, but got Unknown
		//IL_15e7: Expected O, but got I
		//IL_15f7: Expected O, but got I4
		//IL_29a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ad: Expected O, but got Unknown
		//IL_29b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_29bb: Expected O, but got Unknown
		//IL_29d5: Expected O, but got I4
		//IL_2880: Expected O, but got I4
		//IL_24cf: Expected O, but got I
		//IL_24e9: Expected O, but got I4
		//IL_24f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_24f7: Expected O, but got Unknown
		//IL_2511: Expected O, but got I4
		//IL_1e8b: Expected O, but got I
		//IL_1e9b: Expected O, but got I4
		//IL_37bf: Expected O, but got I4
		//IL_37cc: Expected O, but got I4
		//IL_37e6: Expected O, but got I4
		//IL_3d44: Expected O, but got I4
		//IL_3d51: Expected O, but got I4
		//IL_3d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d76: Expected O, but got Unknown
		//IL_1c29: Expected O, but got I8
		//IL_3a9d: Expected O, but got I4
		//IL_3aaa: Expected O, but got I4
		//IL_3ac4: Expected O, but got I4
		//IL_2201: Expected O, but got I
		//IL_221b: Expected O, but got I4
		//IL_2224: Unknown result type (might be due to invalid IL or missing references)
		//IL_2229: Expected O, but got Unknown
		//IL_2243: Expected O, but got I4
		//IL_32eb: Expected O, but got I
		//IL_32fa: Expected O, but got I4
		//IL_254d: Expected O, but got I4
		//IL_255d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2562: Expected O, but got Unknown
		//IL_2582: Unknown result type (might be due to invalid IL or missing references)
		//IL_2587: Expected O, but got Unknown
		//IL_168f: Expected O, but got I
		//IL_16a9: Expected O, but got I4
		//IL_16b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b7: Expected O, but got Unknown
		//IL_16d1: Expected O, but got I4
		//IL_1c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5b: Expected O, but got Unknown
		//IL_1c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c69: Expected O, but got Unknown
		//IL_1c83: Expected O, but got I4
		//IL_3b01: Expected O, but got I4
		//IL_3b0e: Expected O, but got I4
		//IL_3b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b33: Expected O, but got Unknown
		//IL_1f33: Expected O, but got I
		//IL_1f4d: Expected O, but got I4
		//IL_1f56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5b: Expected O, but got Unknown
		//IL_1f75: Expected O, but got I4
		//IL_227f: Expected O, but got I4
		//IL_228f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2294: Expected O, but got Unknown
		//IL_22b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b9: Expected O, but got Unknown
		//IL_2ea1: Expected O, but got I
		//IL_2eb0: Expected O, but got I4
		//IL_170d: Expected O, but got I4
		//IL_1722: Expected O, but got I
		//IL_1742: Unknown result type (might be due to invalid IL or missing references)
		//IL_1747: Expected O, but got Unknown
		//IL_337e: Expected O, but got I
		//IL_3398: Expected O, but got I4
		//IL_33a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_33a6: Expected O, but got Unknown
		//IL_33c0: Expected O, but got I4
		//IL_1fb1: Expected O, but got I4
		//IL_1fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc6: Expected O, but got Unknown
		//IL_1fe6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1feb: Expected O, but got Unknown
		//IL_2a37: Expected O, but got I
		//IL_25f1: Expected I4, but got O
		//IL_33fc: Expected O, but got I4
		//IL_3411: Expected O, but got I
		//IL_3431: Unknown result type (might be due to invalid IL or missing references)
		//IL_3436: Expected O, but got Unknown
		//IL_2f34: Expected O, but got I
		//IL_2f4e: Expected O, but got I4
		//IL_2f57: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f5c: Expected O, but got Unknown
		//IL_2f76: Expected O, but got I4
		//IL_2323: Expected I4, but got O
		//IL_2ab8: Expected O, but got I4
		//IL_2ac5: Expected O, but got I4
		//IL_2ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aea: Expected O, but got Unknown
		//IL_2639: Expected O, but got I4
		//IL_17b1: Expected I4, but got O
		//IL_2fb2: Expected O, but got I4
		//IL_2fc7: Expected O, but got I
		//IL_2fe7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fec: Expected O, but got Unknown
		//IL_1ce5: Expected O, but got I
		//IL_1cf4: Expected O, but got I4
		//IL_2055: Expected I4, but got O
		//IL_236b: Expected O, but got I4
		//IL_2679: Unknown result type (might be due to invalid IL or missing references)
		//IL_267e: Expected O, but got Unknown
		//IL_2687: Unknown result type (might be due to invalid IL or missing references)
		//IL_268c: Expected O, but got Unknown
		//IL_17f9: Expected O, but got I4
		//IL_209d: Expected O, but got I4
		//IL_23ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b0: Expected O, but got Unknown
		//IL_23b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_23be: Expected O, but got Unknown
		//IL_1d78: Expected O, but got I
		//IL_1d92: Expected O, but got I4
		//IL_1d9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da0: Expected O, but got Unknown
		//IL_1dba: Expected O, but got I4
		//IL_1839: Unknown result type (might be due to invalid IL or missing references)
		//IL_183e: Expected O, but got Unknown
		//IL_1847: Unknown result type (might be due to invalid IL or missing references)
		//IL_184c: Expected O, but got Unknown
		//IL_20dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e2: Expected O, but got Unknown
		//IL_20eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f0: Expected O, but got Unknown
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		List<object> list = default(List<object>);
		List<Card> result;
		if (obj4 != null)
		{
			object obj5 = typeof(List<AdaptivePerformanceScaler>) + 416;
			object obj6 = (nint)0 + (nint)2632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = obj6;
			list..ctor();
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = !isHokomClose;
				result = cards;
				if (flag2)
				{
					goto IL_3529;
				}
				if (cards != null)
				{
					if (cards._size < 1)
					{
						goto IL_05ce;
					}
					object obj8 = (nint)0 + (nint)2760;
					int num = 0;
					while (true)
					{
						object obj9 = ((List<object>)(object)cards).get_Item(num);
						if (obj9 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v193 (System.Object)+14]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
						if (num2 != 0)
						{
							object obj10 = ((List<object>)(object)cards).get_Item(num);
							if (list == null)
							{
								break;
							}
							int version = list._version + 1;
							list._version = version;
							object[] items = list._items;
							if (list._items == null)
							{
								break;
							}
							bool flag3 = list._size < items.Length;
							object obj11 = !flag3;
							if (obj11 != null)
							{
								list.AddWithResize(obj10);
							}
							else
							{
								int size = list._size + 1;
								list._size = size;
								object obj12 = list._items + list._size;
								object obj13 = obj12 + 32;
								obj13 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
						}
						num++;
						if (num < cards._size)
						{
							continue;
						}
						goto IL_05ce;
					}
				}
			}
			else if (cards != null)
			{
				if (cards._size < 1)
				{
					goto IL_0540;
				}
				object obj14 = (nint)0 + (nint)2760;
				object obj15 = (nint)0 + (nint)2648;
				int num4 = default(int);
				int num3 = num4;
				Suit suit2 = default(Suit);
				Suit suit = suit2;
				int num5 = 0;
				while (true)
				{
					flag = (byte)(int)obj14 != 0;
					object obj16 = ((List<object>)(object)cards).get_Item(num5);
					if (obj16 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X0_v182 (System.Object)+14]");
					bool flag4 = (nint)0 != (nint)currentSuit;
					obj7 = num5;
					if (!flag4)
					{
						flag = (byte)(int)obj14 != 0;
						object obj17 = ((List<object>)(object)cards).get_Item(num5);
						if (list == null)
						{
							break;
						}
						object obj18 = obj15;
						int version2 = list._version + 1;
						list._version = version2;
						suit = (Suit)list._items;
						if (list._items == null)
						{
							break;
						}
						num3 = list._size;
						int size2 = list._size;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1355 @ X9_v98 (Suit)+18]");
						bool flag5 = (nint)size2 < (nint)0;
						object obj19 = !flag5;
						if (obj19 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v177+20]");
							object obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1553 @ X8_v179+C0]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ X8_v180+70]");
							flag = false;
							list.AddWithResize(obj17);
							obj7 = obj17;
						}
						else
						{
							int size3 = list._size + 1;
							list._size = size3;
							object obj22 = list._items + list._size;
							object obj23 = obj22 + 32;
							obj23 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj7 = obj17;
						}
					}
					num5++;
					bool flag6 = num5 >= cards._size;
					num4 = num3;
					suit2 = suit;
					if (!flag6)
					{
						continue;
					}
					goto IL_0540;
				}
			}
		}
		goto IL_34dd;
		IL_3481:
		List<object> list2 = default(List<object>);
		if (list2 == null)
		{
			goto IL_34dd;
		}
		result = ((list2._size != 0) ? ((List<Card>)(object)list2) : cards);
		goto IL_3529;
		IL_2bff:
		int num6 = 0;
		goto IL_3dac;
		IL_05ce:
		if (list == null)
		{
			goto IL_34dd;
		}
		result = ((list._size != 0) ? ((List<Card>)(object)list) : cards);
		goto IL_3529;
		IL_3202:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		object obj25;
		List<Card> suitCards;
		int num8;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X28_v7+18]");
			if ((nint)0 == 0)
			{
				goto IL_34eb;
			}
			object obj24 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X28_v7+20]");
			object obj26 = obj24 & 0;
			object obj27 = obj26 & 1;
			bool flag7 = obj27 == null;
			object obj28 = !flag7;
			result = cards;
			if (obj28 != null)
			{
				goto IL_3529;
			}
			if (suitCards != null)
			{
				if (suitCards._size < 1)
				{
					goto IL_3481;
				}
				object obj29 = (nint)0 + (nint)2648;
				object obj30 = 119877632 + 1128;
				int num7 = 0;
				while (true)
				{
					object obj31 = ((List<object>)(object)suitCards).get_Item(num7);
					if (obj31 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X0_v32 (System.Object)+10]");
					object obj32 = -5;
					bool flag8 = (nint)obj32 < 7;
					object obj33 = !flag8;
					object obj34 = obj32 - 7;
					bool flag9 = obj34 == null;
					object obj35 = !flag9;
					object obj36 = obj33 & obj35;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X26_v10+v3322 @ X8_v29*4]");
						bool flag10 = (nint)0 < (nint)num8;
						object obj37 = !flag10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X26_v10+v3322 @ X8_v29*4]");
						object obj38 = -num8;
						bool flag11 = obj38 == null;
						object obj39 = ~obj37;
						object obj40 = obj39 | flag11;
						if (obj40 == null)
						{
							object obj41 = ((List<object>)(object)suitCards).get_Item(num7);
							if (list2 == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9C1C4");
						}
					}
					num7++;
					if (num7 < suitCards._size)
					{
						continue;
					}
					goto IL_3481;
				}
			}
		}
		goto IL_34dd;
		IL_3ca4:
		bool flag12 = playedCards.Length < 2;
		object obj42 = !flag12;
		object obj43 = playedCards.Length - 2;
		bool flag13 = obj43 == null;
		object obj44 = ~obj42;
		object obj45 = obj44 | flag13;
		int num9;
		object obj47;
		if (obj45 == null)
		{
			Card card = playedCards[2];
			if (playedCards[2] != null)
			{
				Suit <Suit>k__BackingField = card.<Suit>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
				bool flag14 = (nint)<Suit>k__BackingField == (nint)0;
				object obj46 = !flag14;
				BalootGame.BalootGameMode gameMode2;
				if (!flag14)
				{
					bool flag15 = card.<Suit>k__BackingField == currentSuit;
					gameMode2 = BalootGame.BalootGameMode.Sun;
					if (!flag15)
					{
						num9 = 0;
						obj47 = 1;
						goto IL_28a1;
					}
				}
				else
				{
					gameMode2 = BalootGame.BalootGameMode.Hokom;
				}
				num9 = GetCardValueRank(playedCards[2], gameMode2);
				obj47 = obj46;
				goto IL_28a1;
			}
			obj47 = 1;
			goto IL_293c;
		}
		goto IL_34eb;
		IL_35aa:
		object obj48;
		bool flag16 = (nint)obj48 < 2;
		object obj49 = !flag16;
		object obj50 = obj48 - 2;
		bool flag17 = obj50 == null;
		object obj51 = ~obj49;
		object obj52 = obj51 | flag17;
		if (obj52 != null)
		{
			goto IL_34eb;
		}
		Card card2 = playedCards[2];
		int num10;
		if (playedCards[2] != null)
		{
			Suit suit2 = card2.<Suit>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
			int num4 = 0;
			Suit <Suit>k__BackingField2 = card2.<Suit>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
			if ((nint)<Suit>k__BackingField2 == (nint)0)
			{
				int cardValueRank = GetCardValueRank(playedCards[2], BalootGame.BalootGameMode.Hokom);
				obj48 = playedCards.Length;
				num10 = cardValueRank;
				goto IL_36be;
			}
		}
		num10 = 0;
		goto IL_36be;
		IL_1a9a:
		int num11 = 0;
		goto IL_3a38;
		IL_26a3:
		if (list2 == null)
		{
			goto IL_34dd;
		}
		result = (List<Card>)(object)((list2._size != 0) ? list2 : list);
		goto IL_3529;
		IL_27c9:
		int num12 = 0;
		goto IL_3ca4;
		IL_3634:
		object obj53;
		bool flag18 = (nint)obj53 < 2;
		object obj54 = !flag18;
		object obj55 = obj53 - 2;
		bool flag19 = obj55 == null;
		object obj56 = ~obj54;
		object obj57 = obj56 | flag19;
		if (obj57 != null)
		{
			goto IL_34eb;
		}
		Card card3 = playedCards[2];
		int num13;
		if (playedCards[2] != null)
		{
			Suit suit2 = card3.<Suit>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
			int num4 = 0;
			Suit <Suit>k__BackingField3 = card3.<Suit>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
			if ((nint)<Suit>k__BackingField3 == (nint)0)
			{
				int cardValueRank2 = GetCardValueRank(playedCards[2], BalootGame.BalootGameMode.Hokom);
				obj53 = playedCards.Length;
				num13 = cardValueRank2;
				goto IL_3748;
			}
		}
		num13 = 0;
		goto IL_3748;
		IL_2cd7:
		int num14;
		int num15;
		bool flag20 = num14 < num15;
		object obj58 = !flag20;
		object obj59 = num14 - num15;
		bool flag21 = obj59 == null;
		object obj60 = !flag21;
		object obj61 = obj58 & obj60;
		object obj62 = ~obj61;
		if (obj62 != null)
		{
			num14 = num15;
		}
		bool flag22 = num6 < num14;
		object obj63 = !flag22;
		object obj64 = num6 - num14;
		bool flag23 = obj64 == null;
		object obj65 = ~obj63;
		object obj66 = obj65 | flag23;
		BalootGame.BalootGameMode balootGameMode;
		if (obj66 == null)
		{
			bool flag24 = balootGameMode == BalootGame.BalootGameMode.Hokom;
			result = cards;
			if (flag24)
			{
				goto IL_3529;
			}
		}
		goto IL_2d72;
		IL_3edf:
		int num16;
		bool flag25 = num8 < num16;
		object obj67 = !flag25;
		object obj68 = num8 - num16;
		bool flag26 = obj68 == null;
		object obj69 = !flag26;
		object obj70 = obj67 & obj69;
		object obj71 = ~obj70;
		if (obj71 != null)
		{
			num8 = num16;
		}
		int num17;
		bool flag27 = num17 < num8;
		object obj72 = !flag27;
		object obj73 = num17 - num8;
		bool flag28 = obj73 == null;
		object obj74 = ~obj72;
		object obj75 = obj74 | flag28;
		BalootGame.BalootGameMode balootGameMode2;
		if (obj75 == null)
		{
			bool flag29 = balootGameMode2 == BalootGame.BalootGameMode.Hokom;
			result = cards;
			if (flag29)
			{
				goto IL_3529;
			}
		}
		goto IL_3202;
		IL_0540:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		list2..ctor();
		if (list == null)
		{
			goto IL_34dd;
		}
		bool flag30 = BalootGameModeExtensions.IsSunOrAshkal(gameMode);
		int num18;
		int num19;
		object obj77;
		int num20;
		object obj78;
		int num21;
		if (list._size != 0)
		{
			if (!flag30)
			{
				bool flag31 = gameMode != BalootGame.BalootGameMode.Hokom;
				result = cards;
				if (flag31)
				{
					goto IL_3529;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
				if ((nint)currentSuit == (nint)0)
				{
					if (playerIndex <= 2)
					{
						if (playerIndex != 1)
						{
							bool flag32 = playerIndex != 2;
							result = cards;
							if (flag32)
							{
								goto IL_3529;
							}
							if (playedCards == null)
							{
								goto IL_34dd;
							}
							obj48 = playedCards.Length;
							if (playedCards.Length != 0)
							{
								Card card4 = playedCards[0];
								if (playedCards[0] != null)
								{
									Suit suit2 = card4.<Suit>k__BackingField;
									if (card4.<Suit>k__BackingField == currentSuit)
									{
										int cardValueRank3 = GetCardValueRank(playedCards[0], BalootGame.BalootGameMode.Hokom);
										obj48 = playedCards.Length;
										num18 = cardValueRank3;
										goto IL_35aa;
									}
								}
								num18 = 0;
								goto IL_35aa;
							}
						}
						else
						{
							if (playedCards == null)
							{
								goto IL_34dd;
							}
							obj53 = playedCards.Length;
							object obj76 = playedCards.Length & 0xFFFFFFFEL;
							if (obj76 != null)
							{
								Card card5 = playedCards[1];
								if (playedCards[1] != null)
								{
									Suit suit2 = card5.<Suit>k__BackingField;
									if (card5.<Suit>k__BackingField == currentSuit)
									{
										int cardValueRank4 = GetCardValueRank(playedCards[1], BalootGame.BalootGameMode.Hokom);
										obj53 = playedCards.Length;
										num19 = cardValueRank4;
										goto IL_3634;
									}
								}
								num19 = 0;
								goto IL_3634;
							}
						}
					}
					else if (playerIndex != 3)
					{
						bool flag33 = playerIndex != 4;
						result = cards;
						if (flag33)
						{
							goto IL_3529;
						}
						if (playedCards == null)
						{
							goto IL_34dd;
						}
						obj77 = playedCards.Length;
						if (playedCards.Length != 0)
						{
							Card card6 = playedCards[0];
							if (playedCards[0] != null)
							{
								Suit suit2 = card6.<Suit>k__BackingField;
								if (card6.<Suit>k__BackingField == currentSuit)
								{
									int cardValueRank5 = GetCardValueRank(playedCards[0], BalootGame.BalootGameMode.Hokom);
									obj77 = playedCards.Length;
									num20 = cardValueRank5;
									goto IL_3605;
								}
							}
							num20 = 0;
							goto IL_3605;
						}
					}
					else
					{
						if (playedCards == null)
						{
							goto IL_34dd;
						}
						obj78 = playedCards.Length;
						if (playedCards.Length != 0)
						{
							Card card7 = playedCards[0];
							if (playedCards[0] != null)
							{
								Suit suit2 = card7.<Suit>k__BackingField;
								if (card7.<Suit>k__BackingField == currentSuit)
								{
									int cardValueRank6 = GetCardValueRank(playedCards[0], BalootGame.BalootGameMode.Hokom);
									obj78 = playedCards.Length;
									num21 = cardValueRank6;
									goto IL_368f;
								}
							}
							num21 = 0;
							goto IL_368f;
						}
					}
					goto IL_34eb;
				}
			}
			goto IL_05c1;
		}
		bool flag34 = gameMode != BalootGame.BalootGameMode.Hokom || flag30;
		bool flag35 = !flag34;
		object obj79 = !flag35;
		result = cards;
		BalootGame.BalootGameMode balootGameMode3;
		int num23;
		object obj84;
		int num24;
		BalootGame.BalootGameMode balootGameMode4;
		if (obj79 == null)
		{
			object obj80 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj81 = (nint)0 + (nint)1000;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj4, (IntPtr)obj81);
			int num22 = Enumerable.Count(cards, func);
			bool flag36 = num22 < 1;
			result = cards;
			if (!flag36)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
				object obj82 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
				suitCards = GetSuitCards(cards, Suit.SPADES);
				if (playerIndex <= 2)
				{
					if (playerIndex != 1)
					{
						bool flag37 = playerIndex != 2;
						result = cards;
						if (flag37)
						{
							goto IL_3529;
						}
						if (playedCards == null)
						{
							goto IL_34dd;
						}
						if (playedCards.Length != 0)
						{
							Card card8 = playedCards[0];
							if (playedCards[0] != null)
							{
								Suit <Suit>k__BackingField4 = card8.<Suit>k__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
								bool flag38 = (nint)<Suit>k__BackingField4 == (nint)0;
								object obj83 = !flag38;
								BalootGame.BalootGameMode gameMode3;
								if (!flag38)
								{
									bool flag39 = card8.<Suit>k__BackingField == currentSuit;
									gameMode3 = BalootGame.BalootGameMode.Sun;
									if (!flag39)
									{
										balootGameMode3 = BalootGame.BalootGameMode.Sun;
										num23 = 0;
										goto IL_359c;
									}
								}
								else
								{
									gameMode3 = BalootGame.BalootGameMode.Hokom;
								}
								int cardValueRank7 = GetCardValueRank(playedCards[0], gameMode3);
								obj84 = obj83;
								balootGameMode3 = BalootGame.BalootGameMode.Sun;
								num23 = cardValueRank7;
								goto IL_3f9c;
							}
							balootGameMode3 = BalootGame.BalootGameMode.NotDetermined;
							num23 = 0;
							goto IL_359c;
						}
					}
					else
					{
						if (playedCards == null)
						{
							goto IL_34dd;
						}
						object obj85 = playedCards.Length & 0xFFFFFFFEL;
						if (obj85 != null)
						{
							Card card9 = playedCards[1];
							if (playedCards[1] != null)
							{
								Suit <Suit>k__BackingField5 = card9.<Suit>k__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
								BalootGame.BalootGameMode gameMode4;
								if ((nint)<Suit>k__BackingField5 == (nint)0)
								{
									gameMode4 = BalootGame.BalootGameMode.Hokom;
								}
								else
								{
									bool flag40 = card9.<Suit>k__BackingField != currentSuit;
									gameMode4 = BalootGame.BalootGameMode.Sun;
									if (flag40)
									{
										num14 = 0;
										balootGameMode = BalootGame.BalootGameMode.Sun;
										goto IL_3980;
									}
								}
								int cardValueRank8 = GetCardValueRank(playedCards[1], gameMode4);
								num14 = cardValueRank8;
								balootGameMode = BalootGame.BalootGameMode.Sun;
							}
							else
							{
								num14 = 0;
								balootGameMode = BalootGame.BalootGameMode.NotDetermined;
							}
							goto IL_3980;
						}
					}
				}
				else if (playerIndex != 3)
				{
					bool flag41 = playerIndex != 4;
					result = cards;
					if (flag41)
					{
						goto IL_3529;
					}
					if (playedCards == null)
					{
						goto IL_34dd;
					}
					if (playedCards.Length != 0)
					{
						Card card10 = playedCards[0];
						if (playedCards[0] != null)
						{
							Suit <Suit>k__BackingField6 = card10.<Suit>k__BackingField;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
							BalootGame.BalootGameMode gameMode5;
							if ((nint)<Suit>k__BackingField6 == (nint)0)
							{
								gameMode5 = BalootGame.BalootGameMode.Hokom;
							}
							else
							{
								bool flag42 = card10.<Suit>k__BackingField != currentSuit;
								gameMode5 = BalootGame.BalootGameMode.Sun;
								if (flag42)
								{
									num24 = 0;
									balootGameMode4 = BalootGame.BalootGameMode.Sun;
									goto IL_394f;
								}
							}
							int cardValueRank9 = GetCardValueRank(playedCards[0], gameMode5);
							num24 = cardValueRank9;
							balootGameMode4 = BalootGame.BalootGameMode.Sun;
						}
						else
						{
							num24 = 0;
							balootGameMode4 = BalootGame.BalootGameMode.NotDetermined;
						}
						goto IL_394f;
					}
				}
				else
				{
					if (playedCards == null)
					{
						goto IL_34dd;
					}
					if (playedCards.Length != 0)
					{
						Card card11 = playedCards[0];
						if (playedCards[0] != null)
						{
							Suit <Suit>k__BackingField7 = card11.<Suit>k__BackingField;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
							BalootGame.BalootGameMode gameMode6;
							if ((nint)<Suit>k__BackingField7 == (nint)0)
							{
								gameMode6 = BalootGame.BalootGameMode.Hokom;
							}
							else
							{
								bool flag43 = card11.<Suit>k__BackingField != currentSuit;
								gameMode6 = BalootGame.BalootGameMode.Sun;
								if (flag43)
								{
									num17 = 0;
									balootGameMode2 = BalootGame.BalootGameMode.Sun;
									goto IL_39df;
								}
							}
							int cardValueRank10 = GetCardValueRank(playedCards[0], gameMode6);
							num17 = cardValueRank10;
							balootGameMode2 = BalootGame.BalootGameMode.Sun;
						}
						else
						{
							num17 = 0;
							balootGameMode2 = BalootGame.BalootGameMode.NotDetermined;
						}
						goto IL_39df;
					}
				}
				goto IL_34eb;
			}
		}
		goto IL_3529;
		IL_293c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X28_v7+18]");
			object obj86 = 0 & 0xFFFFFFFEL;
			if (obj86 == null)
			{
				goto IL_34eb;
			}
			object obj87 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X28_v7+21]");
			object obj88 = obj87 & 0;
			object obj89 = obj88 & 1;
			bool flag44 = obj89 == null;
			object obj90 = !flag44;
			result = cards;
			if (obj90 != null)
			{
				goto IL_3529;
			}
			if (suitCards != null)
			{
				if (suitCards._size < 1)
				{
					goto IL_3481;
				}
				object obj91 = (nint)0 + (nint)2648;
				int num25 = 0;
				while (true)
				{
					object card12 = ((List<object>)(object)suitCards).get_Item(num25);
					int cardValueRank11 = GetCardValueRank((Card)card12, BalootGame.BalootGameMode.Hokom);
					bool flag45 = cardValueRank11 < num24;
					object obj92 = !flag45;
					object obj93 = cardValueRank11 - num24;
					bool flag46 = obj93 == null;
					object obj94 = ~obj92;
					object obj95 = obj94 | flag46;
					if (obj95 == null)
					{
						object obj96 = ((List<object>)(object)suitCards).get_Item(num25);
						if (list2 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9C1C4");
					}
					num25++;
					if (num25 < suitCards._size)
					{
						continue;
					}
					goto IL_3481;
				}
			}
		}
		goto IL_34dd;
		IL_359c:
		obj84 = 1;
		goto IL_3f9c;
		IL_3748:
		object obj97 = obj53 & 0xFFFFFFFCL;
		if (obj97 != null)
		{
			Card card13 = playedCards[3];
			if (playedCards[3] != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
				Suit suit2 = Suit.SPADES;
				Suit <Suit>k__BackingField8 = card13.<Suit>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
				if ((nint)<Suit>k__BackingField8 == (nint)0)
				{
					int cardValueRank12 = GetCardValueRank(card13, BalootGame.BalootGameMode.Hokom);
					card13 = (Card)cardValueRank12;
				}
				else
				{
					card13 = null;
				}
			}
			bool flag47 = num19 < (nint)card13;
			object obj98 = !flag47;
			object obj99 = num19 - card13;
			bool flag48 = obj99 == null;
			object obj100 = !flag48;
			object obj101 = obj98 & obj100;
			object obj102 = ~obj101;
			Card card14 = ((obj102 != null) ? card13 : ((Card)num19));
			bool flag49 = num13 < (nint)card14;
			object obj103 = !flag49;
			object obj104 = num13 - card14;
			bool flag50 = obj104 == null;
			object obj105 = !flag50;
			object obj106 = obj103 & obj105;
			if (obj106 != null)
			{
				goto IL_05c1;
			}
			if (list._size < 1)
			{
				goto IL_26a3;
			}
			object obj107 = (nint)0 + (nint)2760;
			object obj108 = 119877632 + 1128;
			int num26 = 0;
			while (true)
			{
				object obj109 = list.get_Item(num26);
				if (obj109 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v148 (System.Object)+10]");
				object obj110 = -5;
				bool flag51 = (nint)obj110 < 7;
				object obj111 = !flag51;
				object obj112 = obj110 - 7;
				bool flag52 = obj112 == null;
				object obj113 = !flag52;
				object obj114 = obj111 & obj113;
				if (obj114 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X25_v50+v2771 @ X8_v144*4]");
					bool flag53 = 0 < (nint)card14;
					object obj115 = !flag53;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X25_v50+v2771 @ X8_v144*4]");
					object obj116 = 0 - card14;
					bool flag54 = obj116 == null;
					object obj117 = ~obj115;
					object obj118 = obj117 | flag54;
					if (obj118 == null)
					{
						object obj119 = list.get_Item(num26);
						if (list2 == null)
						{
							break;
						}
						int version3 = list2._version + 1;
						list2._version = version3;
						Suit suit2 = (Suit)list2._items;
						if (list2._items == null)
						{
							break;
						}
						int size4 = list2._size;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2485 @ X9_v60 (Suit)+18]");
						bool flag55 = (nint)size4 < (nint)0;
						object obj120 = !flag55;
						if (obj120 != null)
						{
							list2.AddWithResize(obj119);
						}
						else
						{
							int size5 = list2._size + 1;
							list2._size = size5;
							object obj121 = list2._items + list2._size;
							object obj122 = obj121 + 32;
							obj122 = obj119;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
					}
				}
				num26++;
				if (num26 < list._size)
				{
					continue;
				}
				goto IL_26a3;
			}
			goto IL_34dd;
		}
		goto IL_34eb;
		IL_2d72:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		object obj128;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X28_v7+18]");
			bool flag56 = (nint)0 < (nint)2;
			object obj123 = !flag56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X28_v7+18]");
			object obj124 = -2;
			bool flag57 = obj124 == null;
			object obj125 = ~obj123;
			object obj126 = obj125 | flag57;
			if (obj126 != null)
			{
				goto IL_34eb;
			}
			object obj127 = obj128;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X28_v7+22]");
			object obj129 = obj127 & 0;
			object obj130 = obj129 & 1;
			bool flag58 = obj130 == null;
			object obj131 = !flag58;
			result = cards;
			if (obj131 != null)
			{
				goto IL_3529;
			}
			if (suitCards != null)
			{
				if (suitCards._size < 1)
				{
					goto IL_3481;
				}
				object obj132 = (nint)0 + (nint)2648;
				object obj133 = 119877632 + 1128;
				int num27 = 0;
				while (true)
				{
					object obj134 = ((List<object>)(object)suitCards).get_Item(num27);
					if (obj134 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v71 (System.Object)+10]");
					object obj135 = -5;
					bool flag59 = (nint)obj135 < 7;
					object obj136 = !flag59;
					object obj137 = obj135 - 7;
					bool flag60 = obj137 == null;
					object obj138 = !flag60;
					object obj139 = obj136 & obj138;
					if (obj139 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X26_v30+v3342 @ X8_v65*4]");
						bool flag61 = (nint)0 < (nint)num14;
						object obj140 = !flag61;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X26_v30+v3342 @ X8_v65*4]");
						object obj141 = -num14;
						bool flag62 = obj141 == null;
						object obj142 = ~obj140;
						object obj143 = obj142 | flag62;
						if (obj143 == null)
						{
							object obj144 = ((List<object>)(object)suitCards).get_Item(num27);
							if (list2 == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9C1C4");
						}
					}
					num27++;
					if (num27 < suitCards._size)
					{
						continue;
					}
					goto IL_3481;
				}
			}
		}
		goto IL_34dd;
		IL_28a1:
		bool flag63 = num24 < num9;
		object obj145 = !flag63;
		object obj146 = num24 - num9;
		bool flag64 = obj146 == null;
		object obj147 = !flag64;
		object obj148 = obj145 & obj147;
		object obj149 = ~obj148;
		if (obj149 != null)
		{
			num24 = num9;
		}
		bool flag65 = num12 < num24;
		object obj150 = !flag65;
		object obj151 = num12 - num24;
		bool flag66 = obj151 == null;
		object obj152 = ~obj150;
		object obj153 = obj152 | flag66;
		if (obj153 == null)
		{
			bool flag67 = balootGameMode4 == BalootGame.BalootGameMode.Hokom;
			result = cards;
			if (flag67)
			{
				goto IL_3529;
			}
		}
		goto IL_293c;
		IL_3a38:
		object obj154 = playedCards.Length & 0xFFFFFFFCL;
		if (obj154 == null)
		{
			goto IL_34eb;
		}
		Card card15 = playedCards[3];
		if (playedCards[3] == null)
		{
			goto IL_1b91;
		}
		Suit <Suit>k__BackingField9 = card15.<Suit>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
		BalootGame.BalootGameMode gameMode7;
		if ((nint)<Suit>k__BackingField9 == (nint)0)
		{
			gameMode7 = BalootGame.BalootGameMode.Hokom;
		}
		else
		{
			if (card15.<Suit>k__BackingField != currentSuit)
			{
				goto IL_1b91;
			}
			gameMode7 = BalootGame.BalootGameMode.Sun;
		}
		int cardValueRank13 = GetCardValueRank(playedCards[3], gameMode7);
		bool flag68 = num23 < num11;
		object obj155 = !flag68;
		object obj156 = num23 - num11;
		bool flag69 = obj156 == null;
		object obj157 = !flag69;
		object obj158 = obj155 & obj157;
		object obj159 = ~obj158;
		int num28 = ((obj159 != null) ? num11 : num23);
		bool flag70 = cardValueRank13 < num28;
		object obj160 = !flag70;
		object obj161 = cardValueRank13 - num28;
		bool flag71 = obj161 == null;
		object obj162 = ~obj160;
		object obj163 = obj162 | flag71;
		if (obj163 == null)
		{
			bool flag72 = balootGameMode3 == BalootGame.BalootGameMode.Hokom;
			result = cards;
			if (flag72)
			{
				goto IL_3529;
			}
		}
		goto IL_3b41;
		IL_3b41:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X28_v7+18]");
			object obj164 = 0 & 0xFFFFFFFCL;
			if (obj164 == null)
			{
				goto IL_34eb;
			}
			object obj165 = obj84;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X28_v7+23]");
			object obj166 = obj165 & 0;
			object obj167 = obj166 & 1;
			bool flag73 = obj167 == null;
			object obj168 = !flag73;
			result = cards;
			if (obj168 != null)
			{
				goto IL_3529;
			}
			if (suitCards != null)
			{
				if (suitCards._size < 1)
				{
					goto IL_3481;
				}
				object obj169 = (nint)0 + (nint)2648;
				object obj170 = 119877632 + 1128;
				int num29 = 0;
				while (true)
				{
					object obj171 = ((List<object>)(object)suitCards).get_Item(num29);
					if (obj171 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v90 (System.Object)+10]");
					object obj172 = -5;
					bool flag74 = (nint)obj172 < 7;
					object obj173 = !flag74;
					object obj174 = obj172 - 7;
					bool flag75 = obj174 == null;
					object obj175 = !flag75;
					object obj176 = obj173 & obj175;
					if (obj176 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X26_v40+v3403 @ X8_v85*4]");
						if ((nint)0 > (nint)num28)
						{
							object obj177 = ((List<object>)(object)suitCards).get_Item(num29);
							if (list2 == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9C1C4");
						}
					}
					num29++;
					if (num29 < suitCards._size)
					{
						continue;
					}
					goto IL_3481;
				}
			}
		}
		goto IL_34dd;
		IL_3f9c:
		bool flag76 = playedCards.Length < 2;
		object obj178 = !flag76;
		object obj179 = playedCards.Length - 2;
		bool flag77 = obj179 == null;
		object obj180 = ~obj178;
		object obj181 = obj180 | flag77;
		if (obj181 != null)
		{
			goto IL_34eb;
		}
		Card card16 = playedCards[2];
		if (playedCards[2] == null)
		{
			goto IL_1a9a;
		}
		balootGameMode3++;
		Suit <Suit>k__BackingField10 = card16.<Suit>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
		BalootGame.BalootGameMode gameMode8;
		if ((nint)<Suit>k__BackingField10 == (nint)0)
		{
			gameMode8 = BalootGame.BalootGameMode.Hokom;
		}
		else
		{
			if (card16.<Suit>k__BackingField != currentSuit)
			{
				goto IL_1a9a;
			}
			gameMode8 = BalootGame.BalootGameMode.Sun;
		}
		int cardValueRank14 = GetCardValueRank(playedCards[2], gameMode8);
		num11 = cardValueRank14;
		goto IL_3a38;
		IL_05c1:
		result = (List<Card>)(object)list;
		goto IL_3529;
		IL_3777:
		object obj182 = obj78 & 0xFFFFFFFCL;
		int num30;
		if (obj182 != null)
		{
			Card card17 = playedCards[3];
			if (playedCards[3] != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
				Suit suit2 = Suit.SPADES;
				Suit <Suit>k__BackingField11 = card17.<Suit>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
				if ((nint)<Suit>k__BackingField11 == (nint)0)
				{
					int cardValueRank15 = GetCardValueRank(card17, BalootGame.BalootGameMode.Hokom);
					card17 = (Card)cardValueRank15;
				}
				else
				{
					card17 = null;
				}
			}
			bool flag78 = num30 < (nint)card17;
			object obj183 = !flag78;
			object obj184 = num30 - card17;
			bool flag79 = obj184 == null;
			object obj185 = !flag79;
			object obj186 = obj183 & obj185;
			object obj187 = ~obj186;
			Card card18 = ((obj187 != null) ? card17 : ((Card)num30));
			bool flag80 = num21 < (nint)card18;
			object obj188 = !flag80;
			object obj189 = num21 - card18;
			bool flag81 = obj189 == null;
			object obj190 = !flag81;
			object obj191 = obj188 & obj190;
			if (obj191 != null)
			{
				goto IL_05c1;
			}
			if (list._size < 1)
			{
				goto IL_26a3;
			}
			object obj192 = (nint)0 + (nint)2760;
			object obj193 = 119877632 + 1128;
			int num31 = 0;
			while (true)
			{
				object obj194 = list.get_Item(num31);
				if (obj194 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v108 (System.Object)+10]");
				object obj195 = -5;
				bool flag82 = (nint)obj195 < 7;
				object obj196 = !flag82;
				object obj197 = obj195 - 7;
				bool flag83 = obj197 == null;
				object obj198 = !flag83;
				object obj199 = obj196 & obj198;
				if (obj199 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X25_v46+v2784 @ X8_v108*4]");
					bool flag84 = 0 < (nint)card18;
					object obj200 = !flag84;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X25_v46+v2784 @ X8_v108*4]");
					object obj201 = 0 - card18;
					bool flag85 = obj201 == null;
					object obj202 = ~obj200;
					object obj203 = obj202 | flag85;
					if (obj203 == null)
					{
						object obj204 = list.get_Item(num31);
						if (list2 == null)
						{
							break;
						}
						int version4 = list2._version + 1;
						list2._version = version4;
						Suit suit2 = (Suit)list2._items;
						if (list2._items == null)
						{
							break;
						}
						int size6 = list2._size;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2485 @ X9_v60 (Suit)+18]");
						bool flag86 = (nint)size6 < (nint)0;
						object obj205 = !flag86;
						if (obj205 != null)
						{
							list2.AddWithResize(obj204);
						}
						else
						{
							int size7 = list2._size + 1;
							list2._size = size7;
							object obj206 = list2._items + list2._size;
							object obj207 = obj206 + 32;
							obj207 = obj204;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
					}
				}
				num31++;
				if (num31 < list._size)
				{
					continue;
				}
				goto IL_26a3;
			}
			goto IL_34dd;
		}
		goto IL_34eb;
		IL_34dd:
		NullReferenceException ex = new NullReferenceException();
		goto IL_34eb;
		IL_394f:
		object obj208 = playedCards.Length & 0xFFFFFFFEL;
		if (obj208 == null)
		{
			goto IL_34eb;
		}
		Card card19 = playedCards[1];
		if (playedCards[1] == null)
		{
			goto IL_27c9;
		}
		balootGameMode4++;
		Suit <Suit>k__BackingField12 = card19.<Suit>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
		BalootGame.BalootGameMode gameMode9;
		if ((nint)<Suit>k__BackingField12 == (nint)0)
		{
			gameMode9 = BalootGame.BalootGameMode.Hokom;
		}
		else
		{
			if (card19.<Suit>k__BackingField != currentSuit)
			{
				goto IL_27c9;
			}
			gameMode9 = BalootGame.BalootGameMode.Sun;
		}
		int cardValueRank16 = GetCardValueRank(playedCards[1], gameMode9);
		num12 = cardValueRank16;
		goto IL_3ca4;
		IL_36be:
		object obj209 = obj48 & 0xFFFFFFFCL;
		if (obj209 == null)
		{
			goto IL_34eb;
		}
		Card card20 = playedCards[3];
		int num32;
		if (playedCards[3] != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
			Suit suit2 = Suit.SPADES;
			Suit <Suit>k__BackingField13 = card20.<Suit>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
			if ((nint)<Suit>k__BackingField13 == (nint)0)
			{
				int cardValueRank17 = GetCardValueRank(playedCards[3], BalootGame.BalootGameMode.Hokom);
				bool flag87 = num18 < num10;
				object obj210 = !flag87;
				object obj211 = num18 - num10;
				bool flag88 = obj211 == null;
				object obj212 = !flag88;
				object obj213 = obj210 & obj212;
				object obj214 = ~obj213;
				num32 = ((obj214 != null) ? num10 : num18);
				bool flag89 = cardValueRank17 < num32;
				object obj215 = !flag89;
				object obj216 = cardValueRank17 - num32;
				bool flag90 = obj216 == null;
				object obj217 = !flag90;
				object obj218 = obj215 & obj217;
				if (obj218 != null)
				{
					goto IL_05c1;
				}
				goto IL_3801;
			}
		}
		bool flag91 = num18 < num10;
		object obj219 = !flag91;
		object obj220 = num18 - num10;
		bool flag92 = obj220 == null;
		object obj221 = !flag92;
		object obj222 = obj219 & obj221;
		object obj223 = ~obj222;
		num32 = ((obj223 != null) ? num10 : num18);
		goto IL_3801;
		IL_3605:
		object obj224 = obj77 & 0xFFFFFFFEL;
		if (obj224 == null)
		{
			goto IL_34eb;
		}
		Card card21 = playedCards[1];
		int num33;
		if (playedCards[1] != null)
		{
			Suit suit2 = card21.<Suit>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
			int num4 = 0;
			Suit <Suit>k__BackingField14 = card21.<Suit>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
			if ((nint)<Suit>k__BackingField14 == (nint)0)
			{
				int cardValueRank18 = GetCardValueRank(playedCards[1], BalootGame.BalootGameMode.Hokom);
				obj77 = playedCards.Length;
				num33 = cardValueRank18;
				goto IL_36ed;
			}
		}
		num33 = 0;
		goto IL_36ed;
		IL_3dac:
		object obj225 = playedCards.Length & 0xFFFFFFFCL;
		if (obj225 != null)
		{
			Card card22 = playedCards[3];
			if (playedCards[3] != null)
			{
				Suit <Suit>k__BackingField15 = card22.<Suit>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
				bool flag93 = (nint)<Suit>k__BackingField15 == (nint)0;
				object obj226 = !flag93;
				BalootGame.BalootGameMode gameMode10;
				if (!flag93)
				{
					bool flag94 = card22.<Suit>k__BackingField == currentSuit;
					gameMode10 = BalootGame.BalootGameMode.Sun;
					if (!flag94)
					{
						num15 = 0;
						obj128 = 1;
						goto IL_2cd7;
					}
				}
				else
				{
					gameMode10 = BalootGame.BalootGameMode.Hokom;
				}
				num15 = GetCardValueRank(playedCards[3], gameMode10);
				obj128 = obj226;
				goto IL_2cd7;
			}
			obj128 = 1;
			goto IL_2d72;
		}
		goto IL_34eb;
		IL_3801:
		if (list._size < 1)
		{
			goto IL_26a3;
		}
		object obj227 = (nint)0 + (nint)2760;
		object obj228 = 119877632 + 1128;
		int num34 = 0;
		while (true)
		{
			object obj229 = list.get_Item(num34);
			if (obj229 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v168 (System.Object)+10]");
			object obj230 = -5;
			bool flag95 = (nint)obj230 < 7;
			object obj231 = !flag95;
			object obj232 = obj230 - 7;
			bool flag96 = obj232 == null;
			object obj233 = !flag96;
			object obj234 = obj231 & obj233;
			if (obj234 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X25_v52+v2758 @ X8_v162*4]");
				bool flag97 = (nint)0 < (nint)num32;
				object obj235 = !flag97;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X25_v52+v2758 @ X8_v162*4]");
				object obj236 = -num32;
				bool flag98 = obj236 == null;
				object obj237 = ~obj235;
				object obj238 = obj237 | flag98;
				if (obj238 == null)
				{
					object obj239 = list.get_Item(num34);
					if (list2 == null)
					{
						break;
					}
					int version5 = list2._version + 1;
					list2._version = version5;
					Suit suit2 = (Suit)list2._items;
					if (list2._items == null)
					{
						break;
					}
					int size8 = list2._size;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2485 @ X9_v60 (Suit)+18]");
					bool flag99 = (nint)size8 < (nint)0;
					object obj240 = !flag99;
					if (obj240 != null)
					{
						list2.AddWithResize(obj239);
					}
					else
					{
						int size9 = list2._size + 1;
						list2._size = size9;
						object obj241 = list2._items + list2._size;
						object obj242 = obj241 + 32;
						obj242 = obj239;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
				}
			}
			num34++;
			if (num34 < list._size)
			{
				continue;
			}
			goto IL_26a3;
		}
		goto IL_34dd;
		IL_1b91:
		bool flag100 = num23 < num11;
		object obj243 = !flag100;
		object obj244 = num23 - num11;
		bool flag101 = obj244 == null;
		object obj245 = !flag101;
		object obj246 = obj243 & obj245;
		object obj247 = ~obj246;
		num28 = ((obj247 != null) ? num11 : num23);
		goto IL_3b41;
		IL_39df:
		object obj248 = playedCards.Length & 0xFFFFFFFEL;
		if (obj248 == null)
		{
			goto IL_34eb;
		}
		Card card23 = playedCards[1];
		if (playedCards[1] == null)
		{
			goto IL_30f3;
		}
		balootGameMode2++;
		Suit <Suit>k__BackingField16 = card23.<Suit>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
		bool flag102 = (nint)<Suit>k__BackingField16 == (nint)0;
		object obj249 = !flag102;
		BalootGame.BalootGameMode gameMode11;
		if (!flag102)
		{
			bool flag103 = card23.<Suit>k__BackingField == currentSuit;
			gameMode11 = BalootGame.BalootGameMode.Sun;
			if (!flag103)
			{
				goto IL_30f3;
			}
		}
		else
		{
			gameMode11 = BalootGame.BalootGameMode.Hokom;
		}
		int cardValueRank19 = GetCardValueRank(playedCards[1], gameMode11);
		obj25 = obj249;
		num8 = cardValueRank19;
		goto IL_3e8e;
		IL_34eb:
		return (List<Card>)(object)new IndexOutOfRangeException();
		IL_3980:
		bool flag104 = playedCards.Length < 2;
		object obj250 = !flag104;
		object obj251 = playedCards.Length - 2;
		bool flag105 = obj251 == null;
		object obj252 = ~obj250;
		object obj253 = obj252 | flag105;
		if (obj253 != null)
		{
			goto IL_34eb;
		}
		Card card24 = playedCards[2];
		if (playedCards[2] == null)
		{
			goto IL_2bff;
		}
		balootGameMode++;
		Suit <Suit>k__BackingField17 = card24.<Suit>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
		BalootGame.BalootGameMode gameMode12;
		if ((nint)<Suit>k__BackingField17 == (nint)0)
		{
			gameMode12 = BalootGame.BalootGameMode.Hokom;
		}
		else
		{
			if (card24.<Suit>k__BackingField != currentSuit)
			{
				goto IL_2bff;
			}
			gameMode12 = BalootGame.BalootGameMode.Sun;
		}
		int cardValueRank20 = GetCardValueRank(playedCards[2], gameMode12);
		num6 = cardValueRank20;
		goto IL_3dac;
		IL_3529:
		return result;
		IL_36ed:
		bool flag106 = (nint)obj77 < 2;
		object obj254 = !flag106;
		object obj255 = obj77 - 2;
		bool flag107 = obj255 == null;
		object obj256 = ~obj254;
		object obj257 = obj256 | flag107;
		if (obj257 == null)
		{
			Card card25 = playedCards[2];
			if (playedCards[2] != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
				Suit suit2 = Suit.SPADES;
				Suit <Suit>k__BackingField18 = card25.<Suit>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
				if ((nint)<Suit>k__BackingField18 == (nint)0)
				{
					int cardValueRank21 = GetCardValueRank(card25, BalootGame.BalootGameMode.Hokom);
					card25 = (Card)cardValueRank21;
				}
				else
				{
					card25 = null;
				}
			}
			bool flag108 = num20 < (nint)card25;
			object obj258 = !flag108;
			object obj259 = num20 - card25;
			bool flag109 = obj259 == null;
			object obj260 = !flag109;
			object obj261 = obj258 & obj260;
			object obj262 = ~obj261;
			Card card26 = ((obj262 != null) ? card25 : ((Card)num20));
			bool flag110 = num33 < (nint)card26;
			object obj263 = !flag110;
			object obj264 = num33 - card26;
			bool flag111 = obj264 == null;
			object obj265 = !flag111;
			object obj266 = obj263 & obj265;
			if (obj266 != null)
			{
				goto IL_05c1;
			}
			if (list._size < 1)
			{
				goto IL_26a3;
			}
			object obj267 = (nint)0 + (nint)2760;
			object obj268 = 119877632 + 1128;
			int num35 = 0;
			while (true)
			{
				object obj269 = list.get_Item(num35);
				if (obj269 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v128 (System.Object)+10]");
				object obj270 = -5;
				bool flag112 = (nint)obj270 < 7;
				object obj271 = !flag112;
				object obj272 = obj270 - 7;
				bool flag113 = obj272 == null;
				object obj273 = !flag113;
				object obj274 = obj271 & obj273;
				if (obj274 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X25_v48+v2946 @ X8_v126*4]");
					bool flag114 = 0 < (nint)card26;
					object obj275 = !flag114;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X25_v48+v2946 @ X8_v126*4]");
					object obj276 = 0 - card26;
					bool flag115 = obj276 == null;
					object obj277 = ~obj275;
					object obj278 = obj277 | flag115;
					if (obj278 == null)
					{
						object obj279 = list.get_Item(num35);
						if (list2 == null)
						{
							break;
						}
						int version6 = list2._version + 1;
						list2._version = version6;
						Suit suit2 = (Suit)list2._items;
						if (list2._items == null)
						{
							break;
						}
						int size10 = list2._size;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2485 @ X9_v60 (Suit)+18]");
						bool flag116 = (nint)size10 < (nint)0;
						object obj280 = !flag116;
						if (obj280 != null)
						{
							list2.AddWithResize(obj279);
						}
						else
						{
							int size11 = list2._size + 1;
							list2._size = size11;
							object obj281 = list2._items + list2._size;
							object obj282 = obj281 + 32;
							obj282 = obj279;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
					}
				}
				num35++;
				if (num35 < list._size)
				{
					continue;
				}
				goto IL_26a3;
			}
			goto IL_34dd;
		}
		goto IL_34eb;
		IL_368f:
		object obj283 = obj78 & 0xFFFFFFFEL;
		if (obj283 == null)
		{
			goto IL_34eb;
		}
		Card card27 = playedCards[1];
		if (playedCards[1] != null)
		{
			Suit suit2 = card27.<Suit>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
			int num4 = 0;
			Suit <Suit>k__BackingField19 = card27.<Suit>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
			if ((nint)<Suit>k__BackingField19 == (nint)0)
			{
				int cardValueRank22 = GetCardValueRank(playedCards[1], BalootGame.BalootGameMode.Hokom);
				obj78 = playedCards.Length;
				num30 = cardValueRank22;
				goto IL_3777;
			}
		}
		num30 = 0;
		goto IL_3777;
		IL_30f3:
		obj25 = 1;
		num8 = 0;
		goto IL_3e8e;
		IL_3e8e:
		object obj284 = playedCards.Length & 0xFFFFFFFCL;
		if (obj284 == null)
		{
			goto IL_34eb;
		}
		Card card28 = playedCards[3];
		if (playedCards[3] == null)
		{
			goto IL_3202;
		}
		Suit <Suit>k__BackingField20 = card28.<Suit>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
		BalootGame.BalootGameMode gameMode13;
		if ((nint)<Suit>k__BackingField20 == (nint)0)
		{
			gameMode13 = BalootGame.BalootGameMode.Hokom;
		}
		else
		{
			if (card28.<Suit>k__BackingField != currentSuit)
			{
				num16 = 0;
				goto IL_3edf;
			}
			gameMode13 = BalootGame.BalootGameMode.Sun;
		}
		num16 = GetCardValueRank(playedCards[3], gameMode13);
		goto IL_3edf;
	}

	public static List<Card> GetSuitCards(List<Card> cards, Suit type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005b: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
			object obj4 = (nint)0 + (nint)1008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			IEnumerable<object> source = Enumerable.Where(cards, func);
			return (List<Card>)(object)Enumerable.ToList(source);
		}
		return (List<Card>)(object)new NullReferenceException();
	}

	public static bool CheckIfCardEats(Card card, BalootGame.BalootGameMode gameMode, Dictionary<Suit, List<Card>> playedCards, Suit trumpSuit)
	{
		//IL_0862: Expected I4, but got O
		//IL_0018: Expected O, but got I4
		//IL_0027: Expected O, but got I4
		//IL_0041: Expected O, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0069: Expected O, but got I4
		//IL_0131: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d7: Expected I4, but got O
		//IL_00fa: Expected O, but got I4
		//IL_0094: Expected O, but got I
		//IL_00b3: Expected O, but got I
		//IL_01d2: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_018a: Expected O, but got I4
		//IL_0111: Expected O, but got I4
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected O, but got Unknown
		//IL_08b2: Expected I4, but got O
		//IL_01c4: Expected O, but got I
		//IL_07c4: Expected O, but got I4
		//IL_07de: Expected O, but got I4
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Expected O, but got Unknown
		//IL_0806: Expected O, but got I4
		//IL_084f: Expected O, but got I4
		//IL_07ac: Expected O, but got I4
		//IL_0831: Expected O, but got I
		//IL_0210: Expected O, but got I4
		//IL_05e6: Expected O, but got I4
		//IL_0600: Expected O, but got I4
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected O, but got Unknown
		//IL_0628: Expected O, but got I4
		//IL_0661: Expected O, but got I4
		//IL_0653: Expected O, but got I
		//IL_0347: Expected O, but got I
		//IL_0361: Expected O, but got I4
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0389: Expected O, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0497: Expected O, but got I
		//IL_04b1: Expected O, but got I4
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected O, but got Unknown
		//IL_04d9: Expected O, but got I4
		//IL_0a1f: Expected O, but got I4
		//IL_0564: Expected O, but got I4
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_058c: Expected O, but got I4
		//IL_06aa: Expected O, but got I
		//IL_06c4: Expected O, but got I4
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected O, but got Unknown
		//IL_06ec: Expected O, but got I4
		//IL_072d: Expected O, but got I4
		//IL_073b: Expected O, but got I4
		//IL_0513: Expected O, but got I
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_05be: Expected O, but got I4
		//IL_09bf: Expected O, but got I4
		//IL_0717: Expected O, but got I
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected O, but got Unknown
		object obj7;
		object obj13;
		System.Int32Enum key;
		object obj14;
		if (card != null)
		{
			object obj = card.<Rank>k__BackingField - 5;
			object obj2 = 119877632 + 1096;
			bool flag = (nint)obj < 7;
			object obj3 = !flag;
			object obj4 = obj - 7;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			object obj6 = obj3 & obj5;
			object obj8;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X19_v3+v63 @ X8_v5*4]");
				obj7 = 0;
				bool flag3 = gameMode == BalootGame.BalootGameMode.Hokom;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X19_v3+v63 @ X8_v5*4]");
				obj8 = 0;
				if (!flag3)
				{
					goto IL_00c1;
				}
			}
			else
			{
				bool flag4 = gameMode != BalootGame.BalootGameMode.Hokom;
				obj7 = 0;
				obj8 = 0;
				if (flag4)
				{
					goto IL_00c1;
				}
			}
			bool flag5 = (nint)obj < 7;
			object obj9 = !flag5;
			object obj10 = obj - 7;
			bool flag6 = obj10 == null;
			object obj11 = !flag6;
			object obj12 = obj9 & obj11;
			if (obj12 == null)
			{
				Suit suit = (Suit)119878760;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v6 (Suit)+v63 @ X8_v5*4]");
				obj8 = 0;
			}
			obj13 = card + 20;
			key = (System.Int32Enum)obj13;
			bool flag7 = BalootGameModeExtensions.IsSunOrAshkal(BalootGame.BalootGameMode.Hokom);
			bool flag8 = !flag7;
			obj7 = obj8;
			if (flag8)
			{
				if ((nint)obj13 == (nint)trumpSuit)
				{
					Suit suit = trumpSuit;
					obj7 = obj8;
					obj14 = 16;
					goto IL_09ec;
				}
				object obj15 = card.<Rank>k__BackingField - 5;
				bool flag9 = (nint)obj15 < 7;
				object obj16 = !flag9;
				object obj17 = obj15 - 7;
				bool flag10 = obj17 == null;
				object obj18 = !flag10;
				object obj19 = obj16 & obj18;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X19_v3+v381 @ X8_v34*4]");
					obj7 = 0;
					Suit suit = trumpSuit;
				}
				else
				{
					Suit suit = trumpSuit;
					obj7 = 0;
				}
			}
			goto IL_01c9;
		}
		goto IL_0854;
		IL_0854:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_087f:
		object obj63;
		if (playedCards != null)
		{
			object obj20 = ((Dictionary<System.Int32Enum, object>)(object)playedCards).get_Item(key);
			if (obj20 != null)
			{
				object obj21 = 0;
				int num = 0;
				do
				{
					int num2 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v8 (System.Object)+18]");
					bool flag18;
					bool flag19;
					Suit suit;
					object obj61;
					if ((nint)num2 < (nint)0)
					{
						if (BalootGameModeExtensions.IsSunOrAshkal(gameMode))
						{
							object obj22 = ((Dictionary<System.Int32Enum, object>)(object)playedCards).get_Item(key);
							if (obj22 == null)
							{
								break;
							}
							object obj23 = ((List<object>)obj22).get_Item(num);
							if (obj23 == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v24 (System.Object)+10]");
							object obj24 = -5;
							bool flag11 = (nint)obj24 < 7;
							object obj25 = !flag11;
							object obj26 = obj24 - 7;
							bool flag12 = obj26 == null;
							object obj27 = !flag12;
							object obj28 = obj25 & obj27;
							Suit suit2;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X19_v3+v496 @ X8_v29*4]");
								suit2 = Suit.SPADES;
								if (gameMode != BalootGame.BalootGameMode.Hokom)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X19_v3+v496 @ X8_v29*4]");
									suit = Suit.SPADES;
									goto IL_021e;
								}
							}
							else
							{
								bool flag13 = gameMode != BalootGame.BalootGameMode.Hokom;
								suit = Suit.SPADES;
								suit2 = Suit.SPADES;
								if (flag13)
								{
									goto IL_021e;
								}
							}
							bool flag14 = (nint)obj24 < 7;
							object obj29 = !flag14;
							object obj30 = obj24 - 7;
							bool flag15 = obj30 == null;
							object obj31 = !flag15;
							object obj32 = obj29 & obj31;
							suit = suit2;
							if (obj32 == null)
							{
								object obj33 = 119877632 + 1128;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X9_v13+v496 @ X8_v29*4]");
								suit = Suit.SPADES;
							}
							goto IL_021e;
						}
						if (gameMode == BalootGame.BalootGameMode.Hokom)
						{
							if ((nint)obj13 == (nint)trumpSuit)
							{
								object obj34 = ((Dictionary<System.Int32Enum, object>)(object)playedCards).get_Item(key);
								if (obj34 == null)
								{
									break;
								}
								object obj35 = ((List<object>)obj34).get_Item(num);
								if (obj35 == null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v21 (System.Object)+10]");
								object obj36 = -5;
								bool flag16 = (nint)obj36 < 7;
								object obj37 = !flag16;
								object obj38 = obj36 - 7;
								bool flag17 = obj38 == null;
								object obj39 = !flag17;
								object obj40 = obj37 & obj39;
								object obj41;
								if (obj40 == null)
								{
									suit = (Suit)119878760;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v6 (Suit)+v572 @ X8_v24*4]");
									obj41 = 0;
								}
								else
								{
									suit = trumpSuit;
									obj41 = 0;
								}
								object obj42 = obj7 - obj41;
								flag18 = (nint)obj42 < 0;
								object obj43 = obj7 ^ obj41;
								object obj44 = obj7 ^ obj42;
								object obj45 = obj43 & obj44;
								flag19 = (nint)obj45 < 0;
								goto IL_0a06;
							}
							object obj46 = card.<Rank>k__BackingField - 5;
							bool flag20 = (nint)obj46 < 7;
							object obj47 = !flag20;
							object obj48 = obj46 - 7;
							bool flag21 = obj48 == null;
							object obj49 = !flag21;
							object obj50 = obj47 & obj49;
							if (obj50 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X19_v3+v215 @ X8_v17*4]");
								obj7 = 0;
							}
							else
							{
								obj7 = 0;
							}
							object obj51 = ((Dictionary<System.Int32Enum, object>)(object)playedCards).get_Item(key);
							if (obj51 == null)
							{
								break;
							}
							object obj52 = ((List<object>)obj51).get_Item(num);
							if (obj52 == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v18 (System.Object)+10]");
							object obj53 = -5;
							bool flag22 = (nint)obj53 < 7;
							object obj54 = !flag22;
							object obj55 = obj53 - 7;
							bool flag23 = obj55 == null;
							object obj56 = !flag23;
							object obj57 = obj54 & obj56;
							object obj58;
							if (obj57 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X19_v3+v604 @ X8_v19*4]");
								obj58 = 0;
							}
							else
							{
								obj58 = 0;
							}
							bool flag24 = obj7 < obj58;
							object obj59 = !flag24;
							object obj60 = ~obj59;
							obj61 = ~obj60;
							if (obj61 == null)
							{
								obj21++;
							}
							suit = trumpSuit;
						}
						goto IL_08e5;
					}
					object obj62 = obj21 - obj63;
					return obj62 == null;
					IL_0a06:
					bool flag25 = flag18 == flag19;
					object obj64 = !flag25;
					obj61 = ~obj64;
					if (obj61 == null)
					{
						obj21++;
					}
					goto IL_08e5;
					IL_08e5:
					num++;
					obj20 = ((Dictionary<System.Int32Enum, object>)(object)playedCards).get_Item(key);
					continue;
					IL_021e:
					object obj65 = obj7 - suit;
					flag18 = (nint)obj65 < 0;
					object obj66 = obj7 ^ suit;
					object obj67 = obj7 ^ obj65;
					object obj68 = obj66 & obj67;
					flag19 = (nint)obj68 < 0;
					goto IL_0a06;
				}
				while (obj20 != null);
			}
		}
		goto IL_0854;
		IL_09ec:
		object obj69 = obj14 - obj7;
		obj63 = obj69;
		goto IL_087f;
		IL_00c1:
		obj13 = card + 20;
		key = (System.Int32Enum)obj13;
		bool flag26 = BalootGameModeExtensions.IsSunOrAshkal(gameMode);
		bool flag27 = !flag26;
		object obj70 = !flag27;
		if (obj70 != null)
		{
			goto IL_01c9;
		}
		obj63 = 0;
		goto IL_087f;
		IL_01c9:
		obj14 = 8;
		goto IL_09ec;
	}

	public static int CalculateEatingScore(Card[] playedCards, BalootGame.BalootGameMode gameMode, Suit trumpSuit)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0088: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005f: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 456;
			object obj4 = (nint)0 + (nint)1016;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj2, (IntPtr)obj4);
			return Enumerable.Sum(playedCards, func);
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public unsafe static bool CheckIfAiCouldBuySun(List<Card> cards, Card floorCard)
	{
		//IL_1a32: Expected O, but got I4
		//IL_1558: Expected O, but got I
		//IL_1561: Unknown result type (might be due to invalid IL or missing references)
		//IL_1566: Expected O, but got Unknown
		//IL_156e: Expected I4, but got O
		//IL_15a2: Expected O, but got I4
		//IL_15b3: Expected O, but got I4
		//IL_15cc: Expected O, but got I4
		//IL_002d: Expected O, but got I
		//IL_0035: Expected I, but got O
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		//IL_047d: Expected O, but got I
		//IL_0489: Expected O, but got I
		//IL_0492: Expected O, but got I4
		//IL_049b: Expected O, but got I4
		//IL_2168: Unknown result type (might be due to invalid IL or missing references)
		//IL_216d: Expected O, but got Unknown
		//IL_2175: Expected I, but got O
		//IL_1603: Expected O, but got I4
		//IL_160c: Expected O, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected I4, but got Unknown
		//IL_00b7: Expected O, but got I4
		//IL_00d7: Expected O, but got I4
		//IL_051e: Expected I, but got O
		//IL_1f00: Expected O, but got I4
		//IL_01a6: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_1ae8: Expected O, but got I
		//IL_1afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b00: Expected O, but got Unknown
		//IL_13f9: Expected O, but got I
		//IL_1419: Expected O, but got I
		//IL_143b: Expected O, but got I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_016b: Expected O, but got I4
		//IL_1300: Expected O, but got I4
		//IL_1ab4: Expected O, but got I
		//IL_028e: Expected I, but got O
		//IL_02d6: Expected I, but got O
		//IL_0231: Expected O, but got I
		//IL_0251: Expected O, but got I
		//IL_1dd2: Expected O, but got I4
		//IL_1e23: Expected O, but got I4
		//IL_0542: Expected O, but got I
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		//IL_1483: Expected O, but got I4
		//IL_20c3: Expected O, but got I4
		//IL_1859: Expected O, but got I4
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_0308: Expected I, but got O
		//IL_0318: Expected O, but got I
		//IL_200f: Expected O, but got I
		//IL_201e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2023: Expected O, but got Unknown
		//IL_2039: Expected O, but got I
		//IL_204a: Expected I, but got O
		//IL_204a: Expected O, but got I
		//IL_206d: Expected O, but got I
		//IL_1314: Unknown result type (might be due to invalid IL or missing references)
		//IL_1319: Expected O, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected O, but got Unknown
		//IL_0596: Expected I, but got O
		//IL_03ae: Expected I4, but got O
		//IL_03f0: Expected O, but got I4
		//IL_03f5: Expected I, but got O
		//IL_0406: Expected O, but got I4
		//IL_0413: Expected I, but got O
		//IL_14c5: Expected I, but got O
		//IL_14f0: Expected O, but got I4
		//IL_14f9: Expected O, but got I4
		//IL_1512: Expected O, but got I4
		//IL_151a: Expected I, but got O
		//IL_1522: Expected O, but got I
		//IL_13d1: Expected I, but got O
		//IL_0641: Expected I, but got O
		//IL_1f50: Expected I4, but got O
		//IL_1f60: Expected O, but got I
		//IL_1b61: Expected O, but got I
		//IL_1933: Expected O, but got I4
		//IL_1944: Expected O, but got I4
		//IL_1a50: Expected O, but got I
		//IL_168a: Expected O, but got I4
		//IL_1f24: Expected O, but got I
		//IL_180a: Expected O, but got I4
		//IL_1b2d: Expected O, but got I
		//IL_1630: Expected O, but got I4
		//IL_1639: Unknown result type (might be due to invalid IL or missing references)
		//IL_163e: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_069c: Expected I, but got O
		//IL_0665: Expected O, but got I
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_19c3: Expected O, but got I4
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_1712: Unknown result type (might be due to invalid IL or missing references)
		//IL_1717: Expected O, but got Unknown
		//IL_1741: Expected O, but got I4
		//IL_0747: Expected I, but got O
		//IL_1bcc: Expected O, but got I
		//IL_1790: Expected O, but got I4
		//IL_17b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b9: Expected I4, but got Unknown
		//IL_1b98: Expected O, but got I
		//IL_1c04: Expected O, but got Ref
		//IL_1c0d: Expected O, but got I4
		//IL_1c1e: Expected O, but got I4
		//IL_076b: Expected O, but got I
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Expected O, but got Unknown
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Expected O, but got Unknown
		//IL_0908: Expected I, but got O
		//IL_1c77: Expected O, but got I
		//IL_1c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8f: Expected O, but got Unknown
		//IL_0ed9: Expected O, but got Ref
		//IL_1c43: Expected O, but got I
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Expected O, but got Unknown
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected O, but got Unknown
		//IL_189f: Expected O, but got Ref
		//IL_18a8: Expected O, but got I4
		//IL_18b9: Expected O, but got I4
		//IL_0f0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f12: Expected O, but got Unknown
		//IL_118e: Expected O, but got Ref
		//IL_1197: Expected O, but got I4
		//IL_11a8: Expected O, but got I4
		//IL_0fc5: Expected I, but got O
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Expected O, but got Unknown
		//IL_1d9f: Expected O, but got I
		//IL_0a2b: Expected I, but got O
		//IL_1d6b: Expected O, but got I
		//IL_0fe4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe9: Expected O, but got Unknown
		//IL_0ff2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff7: Expected O, but got Unknown
		//IL_1cbc: Expected O, but got I
		//IL_1129: Expected O, but got Ref
		//IL_1132: Expected O, but got I4
		//IL_1143: Expected O, but got I4
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4f: Expected O, but got Unknown
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5d: Expected O, but got Unknown
		//IL_0a8b: Expected I, but got O
		//IL_0a98: Expected I, but got O
		//IL_0ac3: Expected O, but got I4
		//IL_129f: Expected O, but got Ref
		//IL_12a8: Expected O, but got I4
		//IL_12b1: Expected O, but got I4
		//IL_12c2: Expected O, but got I4
		//IL_0c11: Expected O, but got I
		//IL_0c2b: Expected O, but got I4
		//IL_11ee: Expected O, but got Ref
		//IL_11f7: Expected O, but got I4
		//IL_1200: Expected O, but got I4
		//IL_1211: Expected O, but got I4
		//IL_0d35: Expected O, but got I
		//IL_0d4f: Expected O, but got I4
		//IL_0b04: Expected O, but got I
		//IL_0b1e: Expected O, but got I4
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected O, but got Unknown
		//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b51: Expected O, but got Unknown
		//IL_0c80: Expected O, but got I4
		//IL_07ea: Expected O, but got I4
		//IL_0802: Expected I, but got O
		//IL_080b: Expected O, but got I4
		//IL_0e77: Expected O, but got I4
		//IL_0b79: Expected O, but got I4
		//IL_0b82: Expected O, but got I4
		//IL_0b9a: Expected I, but got O
		//IL_1cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfc: Expected I4, but got Unknown
		//IL_1d16: Expected O, but got I4
		//IL_1d1f: Expected O, but got I4
		//IL_0e69: Expected O, but got I4
		//IL_0e85: Expected O, but got I4
		//IL_0ca8: Expected O, but got I4
		//IL_0cb1: Expected O, but got I4
		//IL_0cd2: Expected I, but got O
		//IL_0e5b: Expected O, but got I4
		//IL_0bb1: Expected O, but got I4
		//IL_0e93: Expected O, but got I4
		//IL_0e25: Expected O, but got I4
		//IL_0ce9: Expected O, but got I4
		//IL_0dca: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80D5]");
		nint num = 0;
		int num2 = (int)((nint)0 + (nint)1896);
		List<object> list = Enumerable.ToList((IEnumerable<object>)cards);
		bool flag = list == null;
		List<object> list2 = (List<object>)152993792;
		int num3 = default(int);
		object obj2 = default(object);
		object obj10;
		Func<object, System.Int32Enum> keySelector;
		object obj12 = default(object);
		nint num5 = default(nint);
		nint num7;
		if (!flag)
		{
			object obj = (nint)0 + (nint)2648;
			num = (nint)obj;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag2 = list._items == null;
			list2 = list;
			if (!flag2)
			{
				num2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2680;
				num3 = list._size;
				obj2 = items.Length;
				bool flag3 = list._size < items.Length;
				object obj3 = !flag3;
				Card card = default(Card);
				nint num4;
				int value;
				if (obj3 == null)
				{
					int size = list._size + 1;
					list._size = size;
					object obj4 = list._items + list._size;
					object obj5 = obj4 + 32;
					obj5 = card;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					value = ((int*)num2)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v109 (System.Int32)+E4]");
					bool flag4 = (nint)0 == 0;
					object obj6 = !flag4;
					object obj7 = card;
					if (obj6 != null)
					{
						goto IL_0225;
					}
					num4 = num5;
					int num6 = value;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v21 (Il2CppClass<System.NullReferenceException>)+20]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v127+C0]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v128+70]");
					num5 = 0;
					list.AddWithResize((object)card);
					value = ((int*)num2)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v109 (System.Int32)+E4]");
					bool flag5 = (nint)0 == 0;
					object obj7 = card;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v128+70]");
					num4 = 0;
					int num6 = value;
					if (!flag5)
					{
						goto IL_0225;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				value = ((int*)num2)->m_value;
				obj10 = (nint)0 + (nint)2944;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v109 (System.Int32)+B8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v21 (Il2CppClass<System.NullReferenceException>)+58]");
				keySelector = (Func<object, System.Int32Enum>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v21 (Il2CppClass<System.NullReferenceException>)+58]");
				bool flag6 = (nint)0 == 0;
				object obj11 = !flag6;
				obj12 = obj10;
				num5 = num4;
				num7 = num;
				if (obj11 != null)
				{
					goto IL_0286;
				}
				goto IL_1461;
			}
		}
		goto IL_1538;
		IL_11dd:
		NullReferenceException ex = new NullReferenceException();
		object obj14;
		object obj13 = (object)(&obj14);
		object obj15 = 0;
		object obj16 = 0;
		Func<object, bool> func2 = default(Func<object, bool>);
		Func<object, bool> func = func2;
		object obj17 = 152993792;
		IEnumerable<Card> enumerable2 = default(IEnumerable<Card>);
		IEnumerable<Card> enumerable = enumerable2;
		bool flag8;
		bool flag7 = flag8;
		Func<object, bool> func3 = func2;
		object obj18 = obj2;
		int num8 = num3;
		int num9 = num2;
		goto IL_21cd;
		IL_2084:
		bool result;
		return result;
		IL_0632:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num5 = unchecked((nint)null);
		goto IL_1b51;
		IL_1305:
		object obj19 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		bool value3;
		bool value2 = ((bool*)(value3 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X8_v29 (System.Boolean)+12E]");
		int num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X8_v29 (System.Boolean)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_13c2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X8_v29 (System.Boolean)+B0]");
		int num11 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ X10_v13 (System.Int32)-8]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ X10_v13 (System.Int32)-8]");
			if (0 == (nint)obj19)
			{
				break;
			}
			num3 = num11 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X8_v29 (System.Boolean)+12E]");
			num10 = (int)(-1);
			bool flag9 = num10 != 1;
			num11 = num3;
			if (flag9)
			{
				continue;
			}
			goto IL_13c2;
		}
		num10 = ((int*)num11)->m_value;
		object obj20 = (value2 ? 1 : 0) + ((int*)num11)->m_value;
		object obj21 = obj20 + 312;
		nint num12 = num5;
		num3 = num11;
		goto IL_1f48;
		IL_0225:
		obj10 = (nint)0 + (nint)2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v109 (System.Int32)+B8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v21 (Il2CppClass<System.NullReferenceException>)+58]");
		keySelector = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v21 (Il2CppClass<System.NullReferenceException>)+58]");
		bool flag10 = (nint)0 == 0;
		obj12 = obj10;
		num7 = num;
		if (!flag10)
		{
			goto IL_0286;
		}
		goto IL_1461;
		IL_1b51:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1072 @ X0_v48+8]");
		func3 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1072 @ X0_v48] (should have been resolved before IL gen)");
		if (enumerable2 != null)
		{
			object obj22 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2992;
			nint num13 = (nint)enumerable2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1117 @ X8_v49 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Card>>)+12E]");
			num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1117 @ X8_v49 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Card>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0738;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1117 @ X8_v49 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Card>>)+B0]");
			int num14 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1304 @ X10_v46 (System.Int32)-8]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1304 @ X10_v46 (System.Int32)-8]");
				if (0 == (nint)obj22)
				{
					break;
				}
				num3 = num14 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1117 @ X8_v49 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Card>>)+12E]");
				num10 = (int)(-1);
				bool flag11 = num10 != 1;
				num14 = num3;
				if (flag11)
				{
					continue;
				}
				goto IL_0738;
			}
			num10 = ((int*)num14)->m_value;
			object obj23 = num13 + ((int*)num14)->m_value;
			object obj24 = obj23 + 312;
			num3 = num14;
			goto IL_1bbc;
		}
		NullReferenceException ex2 = new NullReferenceException();
		object obj25 = default(object);
		obj16 = obj25;
		obj17 = 152993792;
		enumerable = enumerable2;
		flag7 = flag8;
		num12 = num5;
		obj18 = obj2;
		num8 = num3;
		num9 = num2;
		goto IL_21cd;
		IL_13c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num12 = unchecked((nint)null);
		goto IL_1f48;
		IL_0286:
		nint num15 = (nint)obj10;
		ILookup<System.Int32Enum, object> lookup = Enumerable.ToLookup(list, keySelector);
		bool flag12 = lookup == null;
		obj16 = obj25;
		NullReferenceException ex3 = (NullReferenceException)lookup;
		object obj27 = default(object);
		object obj26 = obj27;
		obj12 = obj10;
		num5 = (nint)obj10;
		list2 = list;
		if (!flag12)
		{
			goto IL_02ec;
		}
		goto IL_1538;
		IL_1461:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v109 (System.Int32)+E4]");
		bool flag13 = (nint)0 == 0;
		object obj28 = !flag13;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int value4 = ((int*)num2)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X8_v114 (System.Int32)+B8]");
			num7 = 0;
		}
		obj26 = num7;
		object obj29 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj30 = (nint)0 + (nint)912;
		Func<object, System.Int32Enum> func4 = default(Func<object, System.Int32Enum>);
		func4..ctor((object)num7, (IntPtr)obj30);
		num = ((int*)num2)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v21 (Il2CppClass<System.NullReferenceException>)+B8]");
		object obj31 = (nint)0 + (nint)88;
		obj31 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num15 = (nint)obj12;
		ILookup<System.Int32Enum, object> lookup2 = Enumerable.ToLookup(list, func4);
		bool flag14 = lookup2 == null;
		object obj32 = !flag14;
		obj16 = 0;
		obj10 = obj12;
		ex3 = (NullReferenceException)lookup2;
		obj25 = 0;
		num5 = (nint)obj12;
		obj27 = num7;
		list2 = list;
		if (obj32 != null)
		{
			goto IL_02ec;
		}
		goto IL_1538;
		IL_1118:
		NullReferenceException ex4 = new NullReferenceException();
		obj13 = (object)(&obj14);
		obj15 = 0;
		obj16 = obj25;
		obj17 = 152993792;
		enumerable = enumerable2;
		flag7 = flag8;
		num12 = num5;
		func3 = null;
		obj18 = obj2;
		num8 = num3;
		num9 = num2;
		goto IL_21cd;
		IL_20a9:
		object obj33;
		bool flag15 = obj33 == null;
		object obj34 = !flag15;
		int num17;
		int num16 = num17;
		object obj35;
		obj13 = obj35;
		object obj37;
		object obj36 = obj37;
		object obj39;
		object obj38 = obj39;
		Func<object, bool> func5;
		func = func5;
		int num19;
		int num18 = num19;
		int num21;
		int num20 = num21;
		object obj41;
		object obj40 = obj41;
		object obj42;
		obj12 = obj42;
		object obj43;
		obj27 = obj43;
		List<object> list3;
		list2 = list3;
		object obj44;
		if (obj34 == null)
		{
			if ((nint)obj44 != 13)
			{
				bool flag16 = obj44 == null;
				object obj45 = !flag16;
				if (obj45 != null)
				{
					goto IL_2084;
				}
			}
			if (num17 >= 124 || ((nint)obj41 >= 4 && num17 > 66))
			{
				result = true;
			}
			else
			{
				object obj46 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2048;
				object obj47 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X0_v19+E4]");
				bool flag17 = (nint)0 == 0;
				object obj48 = !flag17;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num22 = BalootProjectUtility.BestProjectsValue(cards);
				int num23 = BalootProjectMethods.OrderingValue(BalootProject.P100);
				object obj49 = num22 - num23;
				bool flag18 = (nint)obj49 < 0;
				int num24 = num22 ^ num23;
				int num25 = num22 ^ obj49;
				int num26 = num24 & num25;
				bool flag19 = num26 < 0;
				bool flag20 = flag18 == flag19;
				result = flag20;
			}
			goto IL_2084;
		}
		goto IL_21cd;
		IL_02ec:
		object obj50 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2704;
		num = (nint)ex3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v21 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v21 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_039c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v21 (Il2CppClass<System.NullReferenceException>)+B0]");
		int num27 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X10_v62 (System.Int32)-8]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X10_v62 (System.Int32)-8]");
			bool flag21 = 0 == (nint)obj50;
			obj25 = obj16;
			obj12 = obj10;
			num5 = num15;
			num3 = num27;
			obj27 = obj26;
			list2 = list;
			if (flag21)
			{
				break;
			}
			num3 = num27 + 16;
			obj51--;
			bool flag22 = (nint)obj51 != 1;
			num27 = num3;
			if (flag22)
			{
				continue;
			}
			goto IL_039c;
		}
		goto IL_1546;
		IL_128e:
		NullReferenceException ex5 = new NullReferenceException();
		obj13 = (object)(&obj14);
		obj15 = 0;
		obj16 = 0;
		func = func2;
		obj17 = 152993792;
		enumerable = enumerable2;
		flag7 = flag8;
		func3 = func2;
		obj18 = obj2;
		num8 = num3;
		num9 = num2;
		goto IL_21cd;
		IL_1f48:
		result = (byte)(int)obj21 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1124 @ X0_v35+8]");
		func3 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1124 @ X0_v35] (should have been resolved before IL gen)");
		num17 = num16;
		obj35 = obj13;
		obj37 = obj36;
		obj39 = obj38;
		obj16 = obj25;
		func5 = func;
		object obj52;
		obj44 = obj52;
		num19 = num18;
		num21 = num20;
		object obj53;
		obj17 = obj53;
		obj41 = obj40;
		IEnumerable<Card> enumerable3;
		enumerable = enumerable3;
		flag7 = flag8;
		obj42 = obj12;
		obj18 = obj2;
		num8 = num3;
		obj43 = obj27;
		num9 = num2;
		list3 = list2;
		goto IL_20a9;
		IL_1bf3:
		NullReferenceException ex6 = new NullReferenceException();
		obj13 = (object)(&obj14);
		obj15 = 0;
		Func<object, bool> func6;
		func = func6;
		obj17 = 152993792;
		enumerable = enumerable2;
		flag7 = flag8;
		goto IL_21cd;
		IL_039c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj54 = default(object);
		num10 = (int)obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v123+8]");
		Rank rank = Rank.TWO;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v822 @ X0_v123] (should have been resolved before IL gen)");
		IEnumerable<Card> enumerable4 = default(IEnumerable<Card>);
		bool flag23 = enumerable4 == null;
		obj25 = obj16;
		IEnumerable<Card> enumerable5 = default(IEnumerable<Card>);
		flag8 = (byte)(&enumerable5) != 0;
		obj33 = 0;
		num5 = unchecked((nint)null);
		flag7 = (byte)(&enumerable5) != 0;
		obj33 = 0;
		obj12 = obj10;
		num12 = unchecked((nint)null);
		obj18 = obj2;
		num8 = num3;
		obj27 = obj26;
		num9 = num2;
		list2 = list;
		if (!flag23)
		{
			goto IL_0449;
		}
		goto IL_15fa;
		IL_1538:
		ex3 = new NullReferenceException();
		goto IL_1546;
		IL_1546:
		object obj55 = num + ((int*)num3)->m_value;
		object obj56 = obj55 + 312;
		num10 = (int)obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v23+8]");
		rank = Rank.TWO;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v193 @ X8_v23] (should have been resolved before IL gen)");
		bool flag24 = enumerable4 == null;
		object obj57 = !flag24;
		flag8 = (byte)(&enumerable5) != 0;
		obj33 = 0;
		obj16 = obj25;
		flag7 = (byte)(&enumerable5) != 0;
		obj33 = 0;
		num12 = num5;
		obj18 = obj2;
		num8 = num3;
		num9 = num2;
		if (obj57 != null)
		{
			goto IL_0449;
		}
		goto IL_15fa;
		IL_0449:
		object obj58 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2712;
		list2 = (List<object>)(typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448);
		obj27 = (nint)0 + (nint)1024;
		obj12 = (nint)0 + (nint)2496;
		obj14 = 0;
		obj40 = 0;
		enumerable3 = enumerable4;
		object obj59 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		nint num28 = (nint)enumerable3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v37 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Card>>)+12E]");
		num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v37 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Card>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_050f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v37 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Card>>)+B0]");
		int num29 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X10_v56 (System.Int32)-8]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X10_v56 (System.Int32)-8]");
			if (0 == (nint)obj59)
			{
				break;
			}
			num3 = num29 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v37 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Card>>)+12E]");
			num10 = (int)(-1);
			bool flag25 = num10 != 1;
			num29 = num3;
			if (flag25)
			{
				continue;
			}
			goto IL_050f;
		}
		num10 = ((int*)num29)->m_value;
		object obj60 = num28 + ((int*)num29)->m_value;
		object obj61 = obj60 + 312;
		num3 = num29;
		goto IL_1ad8;
		IL_0fb6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num5 = unchecked((nint)null);
		goto IL_1d8f;
		IL_21cd:
		OutOfMemoryException ex7 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		if ((nint)func3 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			value3 = ((bool*)(flag7 ? 1 : 0))->m_value;
			bool flag26 = (byte)(~(((bool*)(flag7 ? 1 : 0))->m_value ? 1u : 0u)) != 0;
			object obj62 = !flag26;
			obj25 = obj16;
			obj52 = 0;
			obj53 = obj17;
			enumerable3 = enumerable;
			flag8 = flag7;
			object obj63 = default(object);
			obj33 = obj63;
			num5 = num12;
			obj2 = obj18;
			num3 = num8;
			num2 = num9;
			if (obj62 != null)
			{
				goto IL_1305;
			}
			num17 = num16;
			obj35 = obj13;
			obj37 = obj36;
			obj39 = obj38;
			func5 = func;
			obj44 = 0;
			num19 = num18;
			num21 = num20;
			obj41 = obj40;
			obj33 = obj63;
			obj42 = obj12;
			obj43 = obj27;
			result = flag7;
			list3 = list2;
			goto IL_20a9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		bool result2 = default(bool);
		return result2;
		IL_0738:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num5 = unchecked((nint)null);
		goto IL_1bbc;
		IL_15fa:
		obj14 = 0;
		obj40 = 0;
		NullReferenceException ex8 = new NullReferenceException();
		func3 = (Func<object, bool>)rank;
		goto IL_21cd;
		IL_050f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num5 = unchecked((nint)null);
		goto IL_1ad8;
		IL_1ad8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X0_v43+8]");
		func3 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v781 @ X0_v43] (should have been resolved before IL gen)");
		object obj65 = default(object);
		object obj64 = obj65 & 1;
		if (obj64 != null)
		{
			if (enumerable5 != null)
			{
				object obj66 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 4072;
				nint num30 = (nint)enumerable5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v44 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Card>>)+12E]");
				num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v44 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Card>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0632;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v44 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Card>>)+B0]");
				int num31 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X10_v51 (System.Int32)-8]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X10_v51 (System.Int32)-8]");
					if (0 == (nint)obj66)
					{
						break;
					}
					num3 = num31 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v44 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Card>>)+12E]");
					num10 = (int)(-1);
					bool flag27 = num10 != 1;
					num31 = num3;
					if (flag27)
					{
						continue;
					}
					goto IL_0632;
				}
				num10 = ((int*)num31)->m_value;
				object obj67 = num30 + ((int*)num31)->m_value;
				object obj68 = obj67 + 312;
				num3 = num31;
				goto IL_1b51;
			}
			NullReferenceException ex9 = new NullReferenceException();
			obj16 = obj25;
			obj17 = 152993792;
			enumerable = enumerable5;
			flag7 = flag8;
			num12 = num5;
			obj18 = obj2;
			num8 = num3;
			num9 = num2;
			goto IL_21cd;
		}
		obj52 = 13;
		value3 = ((bool*)(flag8 ? 1 : 0))->m_value;
		bool flag28 = (byte)(~(((bool*)(flag8 ? 1 : 0))->m_value ? 1u : 0u)) != 0;
		obj53 = 152993792;
		num17 = num16;
		obj35 = obj13;
		obj37 = obj36;
		obj39 = obj38;
		obj16 = obj25;
		func5 = func;
		obj44 = obj52;
		num19 = num18;
		num21 = num20;
		obj17 = 152993792;
		obj41 = obj40;
		enumerable = enumerable3;
		flag7 = flag8;
		obj42 = obj12;
		num12 = num5;
		obj18 = obj2;
		num8 = num3;
		obj43 = obj27;
		num9 = num2;
		result = flag8;
		list3 = list2;
		if (!flag28)
		{
			goto IL_1305;
		}
		goto IL_20a9;
		IL_188e:
		OutOfMemoryException ex10 = new OutOfMemoryException();
		obj13 = (object)(&obj14);
		obj15 = 0;
		obj16 = obj25;
		obj17 = 152993792;
		enumerable = enumerable2;
		flag7 = flag8;
		num12 = num5;
		obj18 = obj2;
		num8 = num3;
		num9 = num2;
		goto IL_21cd;
		IL_1bbc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1337 @ X0_v52+8]");
		func3 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1337 @ X0_v52] (should have been resolved before IL gen)");
		object obj69 = default(object);
		if (obj69 != null)
		{
			object obj70 = obj69;
			num18 = 1;
			num20 = 0;
			num2 = 0;
			object obj75 = default(object);
			object obj77 = default(object);
			object obj90 = default(object);
			while (true)
			{
				object obj71 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				object obj72 = obj70;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1428 @ X8_v59+12E]");
				num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1428 @ X8_v59+12E]");
				if ((nint)0 == 0)
				{
					goto IL_08f9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1428 @ X8_v59+B0]");
				int num32 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ X10_v41 (System.Int32)-8]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ X10_v41 (System.Int32)-8]");
					if (0 == (nint)obj71)
					{
						break;
					}
					num3 = num32 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1428 @ X8_v59+12E]");
					num10 = (int)(-1);
					bool flag29 = num10 != 1;
					num32 = num3;
					if (flag29)
					{
						continue;
					}
					goto IL_08f9;
				}
				num10 = ((int*)num32)->m_value;
				object obj73 = obj72 + ((int*)num32)->m_value;
				object obj74 = obj73 + 312;
				num3 = num32;
				goto IL_1c67;
				IL_0a1c:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num5 = unchecked((nint)null);
				goto IL_1ce0;
				IL_1ce0:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1633 @ X0_v73] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj75..ctor();
				if (obj75 == null)
				{
					goto IL_1118;
				}
				_ = 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				func2..ctor(obj75, (IntPtr)obj27);
				num12 = (nint)obj12;
				bool flag30 = Enumerable.Any(enumerable2, func2);
				bool flag31 = !flag30;
				object obj76 = !flag31;
				if (obj76 == null)
				{
					if (obj77 == null)
					{
						goto IL_11dd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ X0_v75+10]");
					object obj78 = -8;
					bool flag32 = (nint)obj78 < 4;
					object obj79 = !flag32;
					object obj80 = obj78 - 4;
					bool flag33 = obj80 == null;
					object obj81 = ~obj79;
					object obj82 = obj81 | flag33;
					if (obj82 != null)
					{
						num10 = 119877632 + 1160;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X9_v2 (System.Int32)+v1679 @ X8_v95*4]");
						num2 = (int)((nint)0 + (nint)num2);
						bool flag34 = obj14 == null;
						obj25 = 0;
						func = func2;
						obj70 = obj14;
						num5 = (nint)obj12;
						obj16 = 0;
						func6 = func2;
						func3 = func2;
						obj18 = obj2;
						num8 = num3;
						num9 = num2;
						if (!flag34)
						{
							continue;
						}
					}
					else
					{
						bool flag35 = obj14 == null;
						object obj83 = !flag35;
						obj25 = 0;
						func = func2;
						obj70 = obj14;
						num5 = (nint)obj12;
						if (obj83 != null)
						{
							continue;
						}
						obj16 = 0;
						func6 = func2;
						func3 = func2;
						obj18 = obj2;
						num8 = num3;
						num9 = num2;
					}
					goto IL_1bf3;
				}
				if (obj77 == null)
				{
					goto IL_128e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ X0_v75+10]");
				object obj84 = -8;
				bool flag36 = obj84 == null;
				obj38 = !flag36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ X0_v75+10]");
				object obj87;
				if ((nint)0 <= (nint)8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ X0_v75+10]");
					num10 = (int)(-5);
					bool flag37 = num10 < 3;
					object obj85 = !flag37;
					if (obj85 == null)
					{
						bool flag38 = obj14 == null;
						object obj86 = !flag38;
						obj25 = 0;
						func = func2;
						obj70 = obj14;
						num20 = 1;
						num5 = (nint)obj12;
						if (obj86 != null)
						{
							continue;
						}
						obj16 = 0;
						func6 = func2;
						num20 = 1;
						func3 = func2;
						obj18 = obj2;
						num8 = num3;
						num9 = num2;
						goto IL_1bf3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ X0_v75+10]");
					if ((nint)0 != 8)
					{
						goto IL_0e7c;
					}
					obj87 = 10;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ X0_v75+10]");
					object obj88 = -10;
					bool flag39 = obj88 == null;
					obj38 = !flag39;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ X0_v75+10]");
					if ((nint)0 <= (nint)10)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ X0_v75+10]");
						if ((nint)0 != 9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ X0_v75+10]");
							if ((nint)0 != 10)
							{
								goto IL_0e7c;
							}
							obj87 = 3;
						}
						else
						{
							obj87 = 2;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ X0_v75+10]");
						if ((nint)0 != 11)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ X0_v75+10]");
							if ((nint)0 != 12)
							{
								goto IL_0e7c;
							}
							obj87 = 11;
						}
						else
						{
							obj87 = 4;
						}
					}
				}
				goto IL_1cef;
				IL_0e7c:
				obj87 = 0;
				goto IL_1cef;
				IL_08f9:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num5 = unchecked((nint)null);
				goto IL_1c67;
				IL_1c67:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1486 @ X0_v58+8]");
				func3 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1486 @ X0_v58] (should have been resolved before IL gen)");
				object obj89 = obj90 & 1;
				if (obj89 == null)
				{
					break;
				}
				if (obj14 == null)
				{
					goto IL_117d;
				}
				object obj91 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 352;
				object obj92 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ X8_v78+12E]");
				num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ X8_v78+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0a1c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ X8_v78+B0]");
				int num33 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1594 @ X10_v36 (System.Int32)-8]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1594 @ X10_v36 (System.Int32)-8]");
					if (0 == (nint)obj91)
					{
						break;
					}
					num3 = num33 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ X8_v78+12E]");
					num10 = (int)(-1);
					bool flag40 = num10 != 1;
					num33 = num3;
					if (flag40)
					{
						continue;
					}
					goto IL_0a1c;
				}
				num10 = ((int*)num33)->m_value;
				object obj93 = obj92 + ((int*)num33)->m_value;
				object obj94 = obj93 + 312;
				num3 = num33;
				goto IL_1ce0;
				IL_1cef:
				num10 = obj87 * num18;
				bool flag41 = obj14 == null;
				object obj95 = !flag41;
				obj25 = 0;
				func = func2;
				obj70 = obj14;
				num18 = num10;
				num20 = 1;
				num5 = num12;
				if (obj95 != null)
				{
					continue;
				}
				obj16 = 0;
				func6 = func2;
				num18 = num10;
				num20 = 1;
				func3 = func2;
				obj18 = obj2;
				num8 = num3;
				num9 = num2;
				goto IL_1bf3;
			}
			object obj96 = (object)(&obj14);
			object obj97 = obj96;
			if (obj96 != null)
			{
				object obj98 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj99 = obj97;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1503 @ X8_v72+12E]");
				num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1503 @ X8_v72+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0fb6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1503 @ X8_v72+B0]");
				int num34 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1615 @ X10_v30 (System.Int32)-8]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1615 @ X10_v30 (System.Int32)-8]");
					if (0 == (nint)obj98)
					{
						break;
					}
					num3 = num34 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1503 @ X8_v72+12E]");
					num10 = (int)(-1);
					bool flag42 = num10 != 1;
					num34 = num3;
					if (flag42)
					{
						continue;
					}
					goto IL_0fb6;
				}
				num10 = ((int*)num34)->m_value;
				object obj100 = obj99 + ((int*)num34)->m_value;
				object obj101 = obj100 + 312;
				num3 = num34;
				goto IL_1d8f;
			}
			goto IL_188e;
		}
		obj16 = obj25;
		func6 = func;
		num18 = 1;
		num20 = 0;
		num12 = num5;
		obj18 = obj2;
		num8 = num3;
		num9 = 0;
		goto IL_1bf3;
		IL_117d:
		NullReferenceException ex11 = new NullReferenceException();
		obj13 = (object)(&obj14);
		obj15 = 0;
		obj16 = obj25;
		obj17 = 152993792;
		enumerable = enumerable2;
		flag7 = flag8;
		num12 = num5;
		obj18 = obj2;
		num8 = num3;
		num9 = num2;
		goto IL_21cd;
		IL_1d8f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ X0_v66+8]");
		func3 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1647 @ X0_v66] (should have been resolved before IL gen)");
		goto IL_188e;
	}

	public static bool CheckIfAiCouldBuyHokom1(List<Card> cards, Card floorCard)
	{
		//IL_0832: Expected I4, but got O
		//IL_0044: Expected O, but got I
		//IL_00bb: Expected O, but got I4
		//IL_0135: Expected O, but got I
		//IL_0145: Expected O, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0193: Expected O, but got I4
		//IL_058f: Expected O, but got I4
		//IL_05a9: Expected O, but got I4
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected O, but got Unknown
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected O, but got Unknown
		//IL_05e5: Expected O, but got I4
		//IL_05ee: Expected O, but got I4
		//IL_05f7: Expected O, but got I4
		//IL_0608: Expected O, but got I4
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01d9: Expected O, but got I4
		//IL_01e2: Expected O, but got I4
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected O, but got Unknown
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected O, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected O, but got Unknown
		//IL_06b2: Expected O, but got I4
		//IL_0310: Expected I, but got O
		//IL_0354: Expected O, but got I
		//IL_036e: Expected O, but got I4
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_07cb: Expected O, but got I4
		//IL_0200: Expected O, but got I
		//IL_076c: Expected O, but got I4
		//IL_03b8: Expected O, but got I4
		//IL_04bd: Expected O, but got I4
		//IL_04d7: Expected O, but got I4
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected O, but got Unknown
		//IL_04ff: Expected O, but got I4
		//IL_03c5: Expected I, but got O
		//IL_0409: Expected O, but got I
		//IL_0423: Expected O, but got I4
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got Unknown
		//IL_044b: Expected O, but got I4
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		List<Card> suitCards;
		object obj14;
		object obj15;
		object obj16;
		IntPtr intPtr;
		object obj17;
		object obj20;
		object obj9;
		nint num = default(nint);
		if (floorCard != null)
		{
			suitCards = GetSuitCards(cards, floorCard.<Suit>k__BackingField);
			if (suitCards != null)
			{
				object obj = (nint)0 + (nint)2648;
				object obj2 = obj;
				int version = suitCards._version + 1;
				suitCards._version = version;
				Card[] items = suitCards._items;
				if (suitCards._items != null)
				{
					bool flag = suitCards._size < items.Length;
					object obj3 = !flag;
					if (obj3 == null)
					{
						int size = suitCards._size + 1;
						suitCards._size = size;
						object obj4 = suitCards._items + suitCards._size;
						object obj5 = obj4 + 32;
						obj5 = floorCard;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v6+20]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v44+C0]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v45+70]");
						num = 0;
						((List<object>)(object)suitCards).AddWithResize((object)floorCard);
					}
					if (cards != null)
					{
						object obj8 = 119877632 + 1072;
						if (cards._size < 1)
						{
							obj9 = floorCard.<Rank>k__BackingField - 7;
							bool flag2 = (nint)obj9 < 5;
							object obj10 = !flag2;
							object obj11 = obj9 - 5;
							bool flag3 = obj11 == null;
							object obj12 = ~obj10;
							object obj13 = obj12 | flag3;
							obj14 = 1;
							obj15 = 1;
							obj16 = 1;
							intPtr = num;
							obj17 = 1;
							if (obj13 != null)
							{
								goto IL_0532;
							}
							goto IL_0616;
						}
						object obj18 = (nint)0 + (nint)2760;
						object obj19 = 119877632 + 1160;
						obj14 = 1;
						obj20 = 0;
						int num2 = 0;
						while (true)
						{
							object obj21 = ((List<object>)(object)cards).get_Item(num2);
							if (obj21 == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v31 (System.Object)+14]");
							if ((nint)0 == (nint)floorCard.<Suit>k__BackingField)
							{
								object obj22 = ((List<object>)(object)cards).get_Item(num2);
								if (obj22 == null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v37 (System.Object)+10]");
								if ((nint)0 != 5)
								{
									object obj23 = ((List<object>)(object)cards).get_Item(num2);
									if (obj23 == null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v39 (System.Object)+10]");
									if ((nint)0 != 6)
									{
										num = (nint)obj18;
										object obj24 = ((List<object>)(object)cards).get_Item(num2);
										if (obj24 == null)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v41 (System.Object)+10]");
										object obj25 = -7;
										bool flag4 = (nint)obj25 < 5;
										object obj26 = !flag4;
										object obj27 = obj25 - 5;
										bool flag5 = obj27 == null;
										object obj28 = !flag5;
										object obj29 = obj26 & obj28;
										if (obj29 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X24_v3+v614 @ X8_v42*4]");
											obj14 = 0 * obj14;
										}
										else
										{
											obj14 = 0 * obj14;
										}
										goto IL_0861;
									}
								}
							}
							num = (nint)obj18;
							object obj30 = ((List<object>)(object)cards).get_Item(num2);
							if (obj30 == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v35 (System.Object)+10]");
							object obj31 = -8;
							bool flag6 = (nint)obj31 < 4;
							object obj32 = !flag6;
							object obj33 = obj31 - 4;
							bool flag7 = obj33 == null;
							object obj34 = ~obj32;
							object obj35 = obj34 | flag7;
							object obj36;
							if (obj35 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X27_v11+v567 @ X8_v35*4]");
								obj36 = 0;
							}
							else
							{
								obj36 = 0;
							}
							obj20 = obj36 + obj20;
							goto IL_0861;
							IL_0861:
							num2++;
							if (num2 < cards._size)
							{
								continue;
							}
							goto IL_0493;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0616:
		object obj37 = 0 * obj16;
		bool flag8 = (nint)obj37 < 80;
		num = intPtr;
		if (!flag8)
		{
			goto IL_0649;
		}
		goto IL_06c8;
		IL_06c8:
		if (suitCards._size >= 3)
		{
			if (ContainsRank(suitCards, Rank.NINE) && ContainsRank(suitCards, Rank.TEN))
			{
				bool flag9 = ContainsRank(suitCards, Rank.ACE);
				bool flag10 = !flag9;
				object obj38 = !flag10;
				if (obj38 != null)
				{
					goto IL_0808;
				}
			}
			if (suitCards._size == 4)
			{
				bool flag11 = ContainsRank(suitCards, Rank.NINE);
				bool flag12 = !flag11;
				object obj39 = !flag12;
				if (obj39 != null || ContainsRank(suitCards, Rank.JACK))
				{
					goto IL_0808;
				}
			}
		}
		goto IL_0816;
		IL_0808:
		return true;
		IL_0532:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X24_v3+v390 @ X8_v23*4]");
		object obj40 = 0 * obj14;
		bool flag13 = (nint)obj40 >= 80;
		intPtr = num;
		obj17 = obj15;
		if (flag13)
		{
			goto IL_0649;
		}
		goto IL_06c8;
		IL_0493:
		object obj41 = ~obj20;
		obj15 = obj41 >> 31;
		obj9 = floorCard.<Rank>k__BackingField - 7;
		bool flag14 = (nint)obj9 < 5;
		object obj42 = !flag14;
		object obj43 = obj9 - 5;
		bool flag15 = obj43 == null;
		object obj44 = !flag15;
		object obj45 = obj42 & obj44;
		obj16 = obj14;
		intPtr = num;
		obj17 = obj15;
		if (obj45 == null)
		{
			goto IL_0532;
		}
		goto IL_0616;
		IL_0816:
		return false;
		IL_0649:
		if (suitCards._size >= 3)
		{
			bool flag16 = ContainsRank(suitCards, Rank.JACK);
			object obj46 = flag16 & obj17;
			object obj47 = obj46 & 1;
			bool flag17 = obj47 == null;
			object obj48 = !flag17;
			num = intPtr;
			if (obj48 == null)
			{
				goto IL_06c8;
			}
			goto IL_0808;
		}
		goto IL_0816;
	}

	public unsafe static KeyValuePair<bool, Suit> CheckIfAiCouldBuyHokom2(List<Card> cards, Card floorCard)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_1f95: Expected I, but got O
		//IL_0063: Expected O, but got I4
		//IL_1fa6: Expected O, but got I
		//IL_1fb2: Expected O, but got I
		//IL_1fc2: Expected O, but got I
		//IL_1fd2: Expected O, but got I
		//IL_1ff4: Expected O, but got I4
		//IL_29bb: Expected O, but got I4
		//IL_29c4: Expected O, but got I4
		//IL_0098: Expected O, but got I
		//IL_00ba: Expected O, but got I4
		//IL_0110: Expected O, but got I
		//IL_0162: Expected O, but got I4
		//IL_016b: Expected O, but got I4
		//IL_2019: Unknown result type (might be due to invalid IL or missing references)
		//IL_201e: Expected O, but got Unknown
		//IL_2034: Expected O, but got I
		//IL_2045: Expected I, but got O
		//IL_2063: Expected O, but got I
		//IL_2a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a28: Expected O, but got Unknown
		//IL_2a34: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_01b8: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_02b2: Expected O, but got I
		//IL_02c2: Expected O, but got I
		//IL_02d2: Expected O, but got I
		//IL_031e: Expected O, but got I
		//IL_043b: Expected O, but got I
		//IL_044b: Expected O, but got I
		//IL_045b: Expected O, but got I
		//IL_047d: Expected O, but got I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_026f: Expected O, but got I4
		//IL_1eaa: Expected O, but got I4
		//IL_1ebb: Expected O, but got I4
		//IL_03c8: Expected O, but got I4
		//IL_0340: Expected O, but got I
		//IL_0350: Expected O, but got I
		//IL_0360: Expected O, but got I
		//IL_16c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cd: Expected O, but got Unknown
		//IL_16e5: Expected O, but got I
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		//IL_0598: Expected I, but got O
		//IL_05a8: Expected O, but got I
		//IL_04ab: Expected O, but got I
		//IL_04cd: Expected O, but got I4
		//IL_1f62: Expected O, but got I4
		//IL_03ef: Expected O, but got I4
		//IL_03f8: Expected O, but got I4
		//IL_209f: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a4: Expected O, but got Unknown
		//IL_20ba: Expected O, but got I
		//IL_20cb: Expected I, but got O
		//IL_20e9: Expected O, but got I
		//IL_2727: Expected O, but got I
		//IL_2655: Expected O, but got I4
		//IL_217f: Expected O, but got I
		//IL_21a1: Expected O, but got I4
		//IL_0533: Expected O, but got I4
		//IL_0544: Expected O, but got I4
		//IL_054d: Expected O, but got I4
		//IL_0556: Expected O, but got I4
		//IL_04fd: Expected O, but got I
		//IL_26f3: Expected O, but got I
		//IL_2110: Expected O, but got I
		//IL_2131: Expected O, but got I4
		//IL_2141: Unknown result type (might be due to invalid IL or missing references)
		//IL_2146: Expected O, but got Unknown
		//IL_1792: Expected O, but got I4
		//IL_179f: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a4: Expected O, but got Unknown
		//IL_17ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b2: Expected O, but got Unknown
		//IL_1e23: Expected O, but got Ref
		//IL_1e34: Expected O, but got I4
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected O, but got Unknown
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Expected O, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		//IL_071e: Expected O, but got I
		//IL_072a: Expected O, but got I
		//IL_073b: Expected O, but got I4
		//IL_06a1: Expected O, but got I4
		//IL_06b3: Expected O, but got I
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected O, but got Unknown
		//IL_1749: Expected O, but got I
		//IL_1836: Expected O, but got I4
		//IL_0840: Expected O, but got I
		//IL_0614: Expected O, but got I
		//IL_062e: Expected O, but got I4
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_27d2: Expected O, but got I
		//IL_27e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e6: Expected O, but got Unknown
		//IL_27f6: Expected O, but got I
		//IL_2806: Expected O, but got I
		//IL_2828: Expected O, but got I4
		//IL_17fe: Expected O, but got I4
		//IL_18ca: Expected O, but got I4
		//IL_18d2: Expected I, but got O
		//IL_18e2: Expected O, but got I
		//IL_222e: Expected O, but got I
		//IL_2241: Unknown result type (might be due to invalid IL or missing references)
		//IL_2246: Expected O, but got Unknown
		//IL_187d: Expected O, but got I4
		//IL_15a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15aa: Expected O, but got Unknown
		//IL_15b6: Expected O, but got I
		//IL_15be: Expected O, but got Ref
		//IL_15e5: Expected O, but got Ref
		//IL_15f6: Expected O, but got I4
		//IL_1637: Expected O, but got I4
		//IL_1640: Expected O, but got I4
		//IL_1648: Expected O, but got Ref
		//IL_1659: Expected O, but got I4
		//IL_1692: Expected O, but got I4
		//IL_16a3: Expected O, but got I4
		//IL_21bf: Expected O, but got I
		//IL_21e0: Expected O, but got I4
		//IL_21f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f5: Expected O, but got Unknown
		//IL_28fb: Expected O, but got I
		//IL_2845: Unknown result type (might be due to invalid IL or missing references)
		//IL_284a: Expected O, but got Unknown
		//IL_2860: Expected O, but got I
		//IL_2871: Expected I, but got O
		//IL_288f: Expected O, but got I
		//IL_28aa: Expected O, but got I4
		//IL_0939: Expected O, but got I4
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Expected O, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Expected O, but got Unknown
		//IL_28c7: Expected O, but got I
		//IL_18ad: Expected O, but got I
		//IL_1cf6: Expected O, but got I4
		//IL_08ac: Expected O, but got I
		//IL_08c6: Expected O, but got I4
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Expected O, but got Unknown
		//IL_19d1: Expected O, but got I4
		//IL_198a: Expected O, but got I4
		//IL_199c: Expected O, but got I
		//IL_19a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19aa: Expected O, but got Unknown
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected O, but got Unknown
		//IL_09b7: Expected O, but got I
		//IL_1946: Expected O, but got I
		//IL_22e2: Expected O, but got I
		//IL_1b1f: Expected O, but got I4
		//IL_1d5d: Expected O, but got I4
		//IL_2273: Expected O, but got I
		//IL_2294: Expected O, but got I4
		//IL_22a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a9: Expected O, but got Unknown
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af9: Expected O, but got Unknown
		//IL_0b01: Expected I, but got O
		//IL_0b11: Expected O, but got I
		//IL_0ab0: Expected O, but got I4
		//IL_0abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac2: Expected O, but got Unknown
		//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Expected O, but got Unknown
		//IL_0a23: Expected O, but got I
		//IL_0a3d: Expected O, but got I4
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4b: Expected O, but got Unknown
		//IL_1c30: Expected O, but got I4
		//IL_2388: Expected O, but got I
		//IL_1bd1: Expected O, but got I4
		//IL_137f: Expected O, but got I4
		//IL_2319: Expected O, but got I
		//IL_233a: Expected O, but got I4
		//IL_234a: Unknown result type (might be due to invalid IL or missing references)
		//IL_234f: Expected O, but got Unknown
		//IL_2559: Expected O, but got Ref
		//IL_2562: Expected O, but got I4
		//IL_259b: Expected O, but got I4
		//IL_0c48: Expected O, but got I4
		//IL_0c0a: Expected O, but got I4
		//IL_0c1c: Expected O, but got I
		//IL_0c25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Expected O, but got Unknown
		//IL_0cb5: Expected O, but got I
		//IL_0b7d: Expected O, but got I
		//IL_0b97: Expected O, but got I4
		//IL_0ba0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba5: Expected O, but got Unknown
		//IL_242e: Expected O, but got I
		//IL_2441: Unknown result type (might be due to invalid IL or missing references)
		//IL_2446: Expected O, but got Unknown
		//IL_1395: Expected O, but got Ref
		//IL_23bf: Expected O, but got I
		//IL_23e0: Expected O, but got I4
		//IL_23f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f5: Expected O, but got Unknown
		//IL_0dae: Expected O, but got I4
		//IL_0dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc0: Expected O, but got Unknown
		//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dce: Expected O, but got Unknown
		//IL_1d7b: Expected O, but got Ref
		//IL_1d84: Expected O, but got I4
		//IL_1db5: Expected O, but got I4
		//IL_13c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ce: Expected O, but got Unknown
		//IL_13e6: Expected O, but got I
		//IL_11e2: Expected O, but got Ref
		//IL_11eb: Expected O, but got I4
		//IL_121c: Expected O, but got I4
		//IL_0d21: Expected O, but got I
		//IL_0d3b: Expected O, but got I4
		//IL_0d44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d49: Expected O, but got Unknown
		//IL_0e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e14: Expected O, but got Unknown
		//IL_0e2c: Expected O, but got I
		//IL_262c: Expected O, but got I
		//IL_25bd: Expected O, but got I
		//IL_25de: Expected O, but got I4
		//IL_25ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f3: Expected O, but got Unknown
		//IL_14df: Expected O, but got I4
		//IL_14ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f1: Expected O, but got Unknown
		//IL_14fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ff: Expected O, but got Unknown
		//IL_2473: Expected O, but got I
		//IL_2494: Expected O, but got I4
		//IL_24a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a9: Expected O, but got Unknown
		//IL_1452: Expected O, but got I
		//IL_146c: Expected O, but got I4
		//IL_1475: Unknown result type (might be due to invalid IL or missing references)
		//IL_147a: Expected O, but got Unknown
		//IL_123a: Expected O, but got Ref
		//IL_1243: Expected O, but got I4
		//IL_1279: Expected O, but got I4
		//IL_0f25: Expected O, but got I4
		//IL_0f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f37: Expected O, but got Unknown
		//IL_0f40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f45: Expected O, but got Unknown
		//IL_0f7b: Expected I, but got O
		//IL_0e98: Expected O, but got I
		//IL_0eb2: Expected O, but got I4
		//IL_0ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec0: Expected O, but got Unknown
		//IL_0c87: Expected O, but got I4
		//IL_129f: Expected O, but got I4
		//IL_12bd: Expected O, but got Ref
		//IL_12c6: Expected O, but got I4
		//IL_12e7: Expected O, but got I4
		//IL_1300: Expected O, but got I4
		//IL_0ff1: Expected O, but got I
		//IL_100b: Expected O, but got I4
		//IL_1014: Unknown result type (might be due to invalid IL or missing references)
		//IL_1019: Expected O, but got Unknown
		//IL_131e: Expected O, but got Ref
		//IL_1327: Expected O, but got I4
		//IL_1350: Expected O, but got I4
		//IL_1369: Expected O, but got I4
		//IL_107f: Expected O, but got I
		//IL_108f: Expected O, but got I
		//IL_10b8: Expected O, but got I4
		//IL_10d5: Expected O, but got I
		//IL_1120: Expected O, but got I4
		//IL_1129: Unknown result type (might be due to invalid IL or missing references)
		//IL_112e: Expected O, but got Unknown
		//IL_114d: Expected O, but got I4
		//IL_115a: Expected I4, but got O
		//IL_1195: Expected O, but got I4
		//IL_24e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ee: Expected O, but got Unknown
		//IL_2508: Expected O, but got I4
		//IL_2519: Expected O, but got I4
		//IL_2521: Expected I4, but got O
		//IL_2529: Expected I4, but got O
		//IL_2532: Expected O, but got I4
		//IL_1177: Expected O, but got I4
		//IL_1187: Expected O, but got I
		//IL_11ab: Expected O, but got I4
		//IL_11b3: Expected I4, but got O
		//IL_11bb: Expected I4, but got O
		//IL_11c4: Expected O, but got I4
		object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3744;
		object obj2 = (nint)0 + (nint)3256;
		object obj3 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2680;
		IEnumerable<Suit> all = SuitMethods.GetAll();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<System.Int32Enum, System.Int32Enum> func = default(Func<System.Int32Enum, System.Int32Enum>);
		func..ctor((object)null, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
		}
		object obj6 = (nint)0 + (nint)1720;
		object obj7 = (nint)0 + (nint)1896;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v7+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v133+60]");
		Func<System.Int32Enum, int> func2 = (Func<System.Int32Enum, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v133+60]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		Card card = floorCard;
		object[] array;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v7+E4]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v139+B8]");
				obj8 = 0;
			}
			object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3736;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)888;
			Func<System.Int32Enum, int> func3 = default(Func<System.Int32Enum, int>);
			func3..ctor(obj8, (IntPtr)obj13);
			object obj14 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v138+B8]");
			object obj15 = (nint)0 + (nint)96;
			obj15 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func2 = func3;
			card = floorCard;
		}
		object obj16 = obj6;
		Dictionary<System.Int32Enum, int> dictionary = Enumerable.ToDictionary((IEnumerable<System.Int32Enum>)all, func, func2);
		Func<object, System.Int32Enum> func4 = (Func<object, System.Int32Enum>)obj7;
		List<object> list = Enumerable.ToList((IEnumerable<object>)cards);
		bool flag4 = list == null;
		object obj17 = 0;
		object obj18 = 0;
		Func<System.Int32Enum, System.Int32Enum> func5 = func;
		int num = default(int);
		object obj21 = default(object);
		object obj28;
		object obj32;
		object obj33;
		Func<object, System.Int32Enum> func7;
		Card card2;
		if (!flag4)
		{
			object obj19 = (nint)0 + (nint)2648;
			object obj20 = obj19;
			int version = list._version + 1;
			list._version = version;
			array = list._items;
			bool flag5 = list._items == null;
			obj17 = 0;
			obj18 = 0;
			func5 = func;
			if (!flag5)
			{
				num = list._size;
				obj21 = array.Length;
				bool flag6 = list._size < array.Length;
				object obj22 = !flag6;
				object obj23 = list._size - array.Length;
				bool flag7 = obj23 == null;
				Func<System.Int32Enum, int> func6;
				object obj26;
				if (obj22 == null)
				{
					int size = list._size + 1;
					list._size = size;
					object obj24 = list._items + list._size;
					object obj25 = obj24 + 32;
					obj25 = card;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj26 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v154+E4]");
					bool flag8 = (nint)0 == 0;
					object obj27 = !flag8;
					obj28 = card;
					if (obj27 != null)
					{
						goto IL_0334;
					}
					card2 = card;
					func6 = func2;
					object obj29 = obj26;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v45+20]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v127+C0]");
					object obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v128+70]");
					func2 = (Func<System.Int32Enum, int>)0;
					list.AddWithResize((object)card);
					obj26 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v154+E4]");
					bool flag9 = (nint)0 == 0;
					obj28 = card;
					card2 = card;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v128+70]");
					func6 = (Func<System.Int32Enum, int>)0;
					object obj29 = obj26;
					if (!flag9)
					{
						goto IL_0334;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj26 = obj3;
				obj32 = (nint)0 + (nint)2944;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v154+B8]");
				obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v114+68]");
				func7 = (Func<object, System.Int32Enum>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v114+68]");
				bool flag10 = (nint)0 == 0;
				object obj34 = !flag10;
				func2 = func6;
				obj6 = obj32;
				if (obj34 != null)
				{
					goto IL_0395;
				}
				goto IL_049b;
			}
		}
		goto IL_207a;
		IL_12ac:
		NullReferenceException ex = new NullReferenceException();
		object obj35 = (object)(&obj18);
		object obj36 = 0;
		Func<object, bool> func9 = default(Func<object, bool>);
		Func<object, bool> func8 = func9;
		object obj37;
		obj21 = obj37;
		int num2;
		num = num2;
		object obj38 = 0;
		func4 = (Func<object, System.Int32Enum>)(object)func9;
		Func<System.Int32Enum, int> func10 = (Func<System.Int32Enum, int>)obj3;
		obj32 = 152993792;
		Func<System.Int32Enum, System.Int32Enum> func11 = func5;
		goto IL_1e1a;
		IL_16b9:
		object obj39 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj41;
		object obj40 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v39+12E]");
		array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v39+12E]");
		if ((nint)0 == 0)
		{
			goto IL_1771;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v39+B0]");
		int num3 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X10_v16 (System.Int32)-8]");
			obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X10_v16 (System.Int32)-8]");
			if (0 == (nint)obj39)
			{
				break;
			}
			num = num3 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v39+12E]");
			array = (object[])(-1);
			bool flag11 = (nint)array != 1;
			num3 = num;
			if (flag11)
			{
				continue;
			}
			goto IL_1771;
		}
		array = (object[])((int*)num3)->m_value;
		object obj42 = obj40 + ((int*)num3)->m_value;
		object obj43 = obj42 + 312;
		num = num3;
		Func<System.Int32Enum, int> func12 = func2;
		goto IL_2717;
		IL_196e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_28eb;
		IL_2548:
		NullReferenceException ex2 = new NullReferenceException();
		obj35 = (object)(&obj18);
		obj36 = 0;
		Func<object, bool> func13;
		func8 = func13;
		System.Int32Enum int32Enum2;
		System.Int32Enum int32Enum = int32Enum2;
		obj21 = obj37;
		num = num2;
		obj38 = obj16;
		func10 = func2;
		obj32 = 152993792;
		func11 = func5;
		goto IL_1e1a;
		IL_28eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ X0_v22+8]");
		func2 = (Func<System.Int32Enum, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1326 @ X0_v22] (should have been resolved before IL gen)");
		object obj44;
		func4 = (Func<object, System.Int32Enum>)obj44;
		IEnumerable<object> source = default(IEnumerable<object>);
		List<object> list2 = Enumerable.ToList(source);
		object obj46;
		object obj47 = default(object);
		object obj48;
		ILookup<System.Int32Enum, object> lookup = default(ILookup<System.Int32Enum, object>);
		ILookup<System.Int32Enum, object> lookup2;
		object obj49 = default(object);
		object obj50;
		int num4 = default(int);
		int num5;
		object obj51;
		Dictionary<System.Int32Enum, int> dictionary2 = default(Dictionary<System.Int32Enum, int>);
		Dictionary<System.Int32Enum, int> dictionary3;
		object obj52;
		object obj53;
		if ((nint)obj6 < 80)
		{
			bool flag12 = list2 == null;
			object obj45 = !flag12;
			if (obj45 != null)
			{
				goto IL_1b2d;
			}
			obj35 = obj46;
			obj47 = obj48;
			lookup = lookup2;
			func8 = func13;
			obj49 = obj50;
			num4 = num5;
			int32Enum = int32Enum2;
			obj7 = obj51;
			dictionary2 = dictionary3;
			obj21 = obj37;
			num = num2;
			obj16 = obj52;
			obj3 = obj53;
		}
		else
		{
			bool flag13 = list2 == null;
			obj35 = obj46;
			obj47 = obj48;
			lookup = lookup2;
			func8 = func13;
			obj49 = obj50;
			num4 = num5;
			int32Enum = int32Enum2;
			obj7 = obj51;
			dictionary2 = dictionary3;
			obj21 = obj37;
			num = num2;
			obj16 = obj52;
			obj3 = obj53;
			if (!flag13)
			{
				if (list2._size >= 3)
				{
					bool flag14 = ContainsRank((IEnumerable<Card>)list2, Rank.JACK);
					bool flag15 = !flag14;
					object obj54 = !flag15;
					if (obj54 != null)
					{
						goto IL_1c6d;
					}
				}
				goto IL_1b2d;
			}
		}
		goto IL_207a;
		IL_1c6d:
		bool key = true;
		goto IL_293a;
		IL_0a8f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		func2 = null;
		goto IL_22d2;
		IL_22d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1357 @ X0_v89+8]");
		func4 = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1357 @ X0_v89] (should have been resolved before IL gen)");
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		bool flag17 = default(bool);
		if (enumerable != null)
		{
			object obj55 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2992;
			nint num6 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1365 @ X8_v67 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1365 @ X8_v67 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0be9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1365 @ X8_v67 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
			int num7 = (int)((nint)0 + (nint)8);
			bool flag16 = flag17;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X10_v50 (System.Int32)-8]");
				obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X10_v50 (System.Int32)-8]");
				bool flag18 = 0 < (nint)obj55;
				object obj22 = !flag18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X10_v50 (System.Int32)-8]");
				object obj23 = 0 - obj55;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X10_v50 (System.Int32)-8]");
				if (0 == (nint)obj55)
				{
					break;
				}
				num2 = num7 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1365 @ X8_v67 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
				array = (object[])(-1);
				bool flag19 = (nint)array < 1;
				obj22 = !flag19;
				obj23 = array - 1;
				bool flag7 = obj23 == null;
				flag17 = (nint)array != 1;
				flag16 = flag17;
				num7 = num2;
				if (flag17)
				{
					continue;
				}
				goto IL_0be9;
			}
			array = (object[])((int*)num7)->m_value;
			object obj56 = num6 + ((int*)num7)->m_value;
			object obj57 = obj56 + 312;
			flag17 = flag16;
			num2 = num7;
			goto IL_2378;
		}
		NullReferenceException ex3 = new NullReferenceException();
		obj35 = obj46;
		func8 = func13;
		obj49 = obj50;
		num4 = num5;
		int32Enum = int32Enum2;
		obj21 = obj37;
		num = num2;
		obj38 = obj16;
		func10 = func2;
		obj32 = 152993792;
		func11 = func5;
		goto IL_1e1a;
		IL_261c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1844 @ X0_v108+8]");
		func4 = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1844 @ X0_v108] (should have been resolved before IL gen)");
		goto IL_1d6a;
		IL_293a:
		System.Int32Enum int32Enum3 = default(System.Int32Enum);
		KeyValuePair<bool, System.Int32Enum> result = new KeyValuePair<bool, System.Int32Enum>(key, int32Enum3);
		goto IL_1c89;
		IL_0334:
		obj32 = (nint)0 + (nint)2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v154+B8]");
		obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v114+68]");
		func7 = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v114+68]");
		bool flag20 = (nint)0 == 0;
		card2 = (Card)obj28;
		obj6 = obj32;
		if (!flag20)
		{
			goto IL_0395;
		}
		goto IL_049b;
		IL_1d6a:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		obj35 = (object)(&obj18);
		obj36 = 0;
		func8 = func13;
		obj21 = obj37;
		num = num2;
		obj38 = obj16;
		func10 = func2;
		obj32 = 152993792;
		func11 = func5;
		goto IL_1e1a;
		IL_14be:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		func2 = null;
		goto IL_261c;
		IL_0395:
		func10 = (Func<System.Int32Enum, int>)obj32;
		ILookup<System.Int32Enum, object> lookup3 = Enumerable.ToLookup(list, func7);
		bool flag21 = lookup3 == null;
		object obj58 = !flag21;
		obj38 = obj16;
		func11 = func;
		if (obj58 != null)
		{
			goto IL_057c;
		}
		obj17 = 0;
		obj18 = 0;
		func4 = func7;
		func2 = (Func<System.Int32Enum, int>)obj32;
		obj6 = obj32;
		func5 = func;
		goto IL_207a;
		IL_0be9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		func2 = null;
		goto IL_2378;
		IL_049b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v154+E4]");
		array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v154+E4]");
		bool flag22 = (nint)0 == 0;
		object obj59 = !flag22;
		if (obj59 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj60 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v120+B8]");
			obj33 = 0;
		}
		func11 = (Func<System.Int32Enum, System.Int32Enum>)obj33;
		object obj61 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj62 = (nint)0 + (nint)896;
		Func<object, System.Int32Enum> func14 = default(Func<object, System.Int32Enum>);
		func14..ctor(obj33, (IntPtr)obj62);
		object obj63 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v119+B8]");
		object obj64 = (nint)0 + (nint)104;
		obj64 = func14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		func10 = (Func<System.Int32Enum, int>)obj6;
		lookup3 = Enumerable.ToLookup(list, func14);
		bool flag23 = lookup3 == null;
		obj38 = 0;
		obj32 = obj6;
		obj17 = 0;
		obj18 = 0;
		obj16 = 0;
		func4 = func14;
		func2 = (Func<System.Int32Enum, int>)obj6;
		func5 = (Func<System.Int32Enum, System.Int32Enum>)obj33;
		if (!flag23)
		{
			goto IL_057c;
		}
		goto IL_207a;
		IL_119a:
		func13 = func9;
		obj49 = 1;
		num4 = (int)array;
		ILookup<System.Int32Enum, object> lookup4;
		int32Enum2 = (System.Int32Enum)lookup4;
		obj16 = 0;
		func4 = (Func<object, System.Int32Enum>)(object)func9;
		goto IL_2548;
		IL_1e1a:
		obj47 = (object)(&obj17);
		lookup = lookup3;
		object obj65 = 0;
		dictionary2 = dictionary;
		obj16 = obj38;
		func2 = func10;
		obj6 = obj32;
		func5 = func11;
		goto IL_207a;
		IL_057c:
		object obj66 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2704;
		nint num8 = (nint)lookup3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v49 (Il2CppClass<System.Linq.ILookup`2<System.Int32Enum, System.Object>>)+12E]");
		array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v49 (Il2CppClass<System.Linq.ILookup`2<System.Int32Enum, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0680;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v49 (Il2CppClass<System.Linq.ILookup`2<System.Int32Enum, System.Object>>)+B0]");
		int num9 = (int)((nint)0 + (nint)8);
		bool flag24 = flag17;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X10_v65 (System.Int32)-8]");
			obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X10_v65 (System.Int32)-8]");
			bool flag25 = 0 < (nint)obj66;
			object obj22 = !flag25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X10_v65 (System.Int32)-8]");
			object obj23 = 0 - obj66;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X10_v65 (System.Int32)-8]");
			if (0 == (nint)obj66)
			{
				break;
			}
			num = num9 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v49 (Il2CppClass<System.Linq.ILookup`2<System.Int32Enum, System.Object>>)+12E]");
			array = (object[])(-1);
			bool flag26 = (nint)array < 1;
			obj22 = !flag26;
			obj23 = array - 1;
			bool flag7 = obj23 == null;
			flag17 = (nint)array != 1;
			flag24 = flag17;
			num9 = num;
			if (flag17)
			{
				continue;
			}
			goto IL_0680;
		}
		array = (object[])((int*)num9)->m_value;
		object obj67 = num8 + ((int*)num9)->m_value;
		object obj68 = obj67 + 312;
		flag17 = flag24;
		num = num9;
		goto IL_216f;
		IL_2378:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1529 @ X0_v93+8]");
		func4 = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1529 @ X0_v93] (should have been resolved before IL gen)");
		object obj69 = default(object);
		object obj81;
		if (obj69 != null)
		{
			obj49 = 0;
			num4 = 1;
			int32Enum = (System.Int32Enum)4;
			object obj70 = obj69;
			object obj75 = default(object);
			object obj80 = default(object);
			object obj82 = default(object);
			while (true)
			{
				object obj71 = obj70;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1612 @ X8_v76+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1612 @ X8_v76+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0d8d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1612 @ X8_v76+B0]");
				int num10 = (int)((nint)0 + (nint)8);
				bool flag27 = flag17;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1662 @ X10_v45 (System.Int32)-8]");
					obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1662 @ X10_v45 (System.Int32)-8]");
					bool flag28 = 0 < (nint)obj7;
					object obj22 = !flag28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1662 @ X10_v45 (System.Int32)-8]");
					object obj23 = 0 - obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1662 @ X10_v45 (System.Int32)-8]");
					if (0 == (nint)obj7)
					{
						break;
					}
					num2 = num10 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1612 @ X8_v76+12E]");
					array = (object[])(-1);
					bool flag29 = (nint)array < 1;
					obj22 = !flag29;
					obj23 = array - 1;
					bool flag7 = obj23 == null;
					flag17 = (nint)array != 1;
					flag27 = flag17;
					num10 = num2;
					if (flag17)
					{
						continue;
					}
					goto IL_0d8d;
				}
				array = (object[])((int*)num10)->m_value;
				object obj72 = obj71 + ((int*)num10)->m_value;
				object obj73 = obj72 + 312;
				flag17 = flag27;
				num2 = num10;
				goto IL_241e;
				IL_241e:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1678 @ X0_v99+8]");
				func4 = (Func<object, System.Int32Enum>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1678 @ X0_v99] (should have been resolved before IL gen)");
				object obj74 = obj75 & 1;
				if (obj74 == null)
				{
					break;
				}
				if (obj18 == null)
				{
					goto IL_11d1;
				}
				object obj76 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 352;
				object obj77 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ X8_v93+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ X8_v93+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0f04;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ X8_v93+B0]");
				int num11 = (int)((nint)0 + (nint)8);
				bool flag30 = flag17;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1788 @ X10_v40 (System.Int32)-8]");
					obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1788 @ X10_v40 (System.Int32)-8]");
					bool flag31 = 0 < (nint)obj76;
					object obj22 = !flag31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1788 @ X10_v40 (System.Int32)-8]");
					object obj23 = 0 - obj76;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1788 @ X10_v40 (System.Int32)-8]");
					if (0 == (nint)obj76)
					{
						break;
					}
					num2 = num11 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ X8_v93+12E]");
					array = (object[])(-1);
					bool flag32 = (nint)array < 1;
					obj22 = !flag32;
					obj23 = array - 1;
					bool flag7 = obj23 == null;
					flag17 = (nint)array != 1;
					flag30 = flag17;
					num11 = num2;
					if (flag17)
					{
						continue;
					}
					goto IL_0f04;
				}
				array = (object[])((int*)num11)->m_value;
				object obj78 = obj77 + ((int*)num11)->m_value;
				object obj79 = obj78 + 312;
				flag17 = flag30;
				num2 = num11;
				goto IL_24d2;
				IL_24d2:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1830 @ X0_v115] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj80..ctor();
				if (obj80 == null)
				{
					goto IL_1229;
				}
				_ = 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				func9..ctor(obj80, (IntPtr)obj81);
				func2 = (Func<System.Int32Enum, int>)obj3;
				bool flag33 = Enumerable.Any(enumerable, func9);
				bool flag34 = !flag33;
				lookup4 = (ILookup<System.Int32Enum, object>)obj80;
				if (!flag34)
				{
					if (obj82 == null)
					{
						goto IL_12ac;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1835 @ X0_v117+10]");
					object obj83 = -7;
					bool flag35 = (nint)obj83 < 7;
					object obj22 = !flag35;
					object obj23 = obj83 - 7;
					bool flag7 = obj23 == null;
					flag17 = (nint)obj83 < 7;
					lookup4 = (ILookup<System.Int32Enum, object>)obj80;
					if (!flag17)
					{
						if (floorCard == null)
						{
							goto IL_130d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1835 @ X0_v117+14]");
						lookup4 = (ILookup<System.Int32Enum, object>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [floorCard @ X1 (Card)+14]");
						array = (object[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1835 @ X0_v117+14]");
						nint num12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [floorCard @ X1 (Card)+14]");
						bool flag36 = num12 < 0;
						obj22 = !flag36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1835 @ X0_v117+14]");
						nint num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [floorCard @ X1 (Card)+14]");
						obj23 = num13 - 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1835 @ X0_v117+14]");
						nint num14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [floorCard @ X1 (Card)+14]");
						if (num14 != 0)
						{
							bool flag37 = (nint)obj83 < 5;
							obj22 = !flag37;
							obj23 = obj83 - 5;
							flag7 = obj23 == null;
							object obj84 = !flag7;
							flag17 = (byte)(obj22 & obj84) != 0;
							object obj86;
							if (!flag17)
							{
								object obj85 = 119877632 + 1072;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1884 @ X9_v55+v1101 @ X8_v100*4]");
								obj86 = 0;
							}
							else
							{
								obj86 = 0;
							}
							array = (object[])(obj86 * num4);
							bool flag38 = obj18 == null;
							object obj87 = !flag38;
							func13 = func9;
							obj49 = 1;
							num4 = (int)array;
							int32Enum = (System.Int32Enum)lookup4;
							obj16 = 0;
							obj70 = obj18;
							if (obj87 != null)
							{
								continue;
							}
							goto IL_119a;
						}
					}
				}
				bool flag39 = obj18 == null;
				func13 = func9;
				obj16 = 0;
				obj70 = obj18;
				if (!flag39)
				{
					continue;
				}
				goto IL_1286;
				IL_0f04:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				func2 = null;
				goto IL_24d2;
				IL_0d8d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				func2 = null;
				goto IL_241e;
			}
			object obj88 = (object)(&obj18);
			object obj89 = obj88;
			if (obj88 != null)
			{
				object obj90 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj91 = obj89;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X8_v87+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X8_v87+12E]");
				if ((nint)0 == 0)
				{
					goto IL_14be;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X8_v87+B0]");
				int num15 = (int)((nint)0 + (nint)8);
				bool flag40 = flag17;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1809 @ X10_v34 (System.Int32)-8]");
					obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1809 @ X10_v34 (System.Int32)-8]");
					bool flag41 = 0 < (nint)obj90;
					object obj22 = !flag41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1809 @ X10_v34 (System.Int32)-8]");
					object obj23 = 0 - obj90;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1809 @ X10_v34 (System.Int32)-8]");
					if (0 == (nint)obj90)
					{
						break;
					}
					num2 = num15 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X8_v87+12E]");
					array = (object[])(-1);
					bool flag42 = (nint)array < 1;
					obj22 = !flag42;
					obj23 = array - 1;
					bool flag7 = obj23 == null;
					flag17 = (nint)array != 1;
					flag40 = flag17;
					num15 = num2;
					if (flag17)
					{
						continue;
					}
					goto IL_14be;
				}
				array = (object[])((int*)num15)->m_value;
				object obj92 = obj91 + ((int*)num15)->m_value;
				object obj93 = obj92 + 312;
				flag17 = flag40;
				num2 = num15;
				goto IL_261c;
			}
			goto IL_1d6a;
		}
		obj49 = 0;
		num4 = 1;
		goto IL_2548;
		IL_1b2d:
		if (list2._size >= 3)
		{
			if (ContainsRank((IEnumerable<Card>)list2, Rank.NINE) && ContainsRank((IEnumerable<Card>)list2, Rank.TEN))
			{
				bool flag43 = ContainsRank((IEnumerable<Card>)list2, Rank.ACE);
				bool flag44 = !flag43;
				object obj94 = !flag44;
				if (obj94 != null)
				{
					goto IL_1c6d;
				}
			}
			if (list2._size == 4)
			{
				bool flag45 = ContainsRank((IEnumerable<Card>)list2, Rank.NINE);
				bool flag46 = !flag45;
				object obj95 = !flag46;
				if (obj95 != null || ContainsRank((IEnumerable<Card>)list2, Rank.JACK))
				{
					goto IL_1c6d;
				}
			}
		}
		key = false;
		goto IL_293a;
		IL_11d1:
		NullReferenceException ex5 = new NullReferenceException();
		obj35 = (object)(&obj18);
		obj36 = 0;
		func8 = func13;
		obj21 = obj37;
		num = num2;
		obj38 = obj16;
		func10 = func2;
		obj32 = 152993792;
		func11 = func5;
		goto IL_1e1a;
		IL_130d:
		NullReferenceException ex6 = new NullReferenceException();
		obj35 = (object)(&obj18);
		obj36 = 0;
		func8 = func9;
		obj21 = obj37;
		num = num2;
		array = (object[])(object)floorCard;
		obj38 = 0;
		func4 = (Func<object, System.Int32Enum>)(object)func9;
		func10 = (Func<System.Int32Enum, int>)obj3;
		obj32 = 152993792;
		func11 = func5;
		goto IL_1e1a;
		IL_0680:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		func10 = null;
		goto IL_216f;
		IL_216f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X0_v78+8]");
		func4 = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v693 @ X0_v78] (should have been resolved before IL gen)");
		object obj96 = default(object);
		bool flag47 = obj96 == null;
		obj18 = 0;
		if (!flag47)
		{
			obj7 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			func5 = (Func<System.Int32Enum, System.Int32Enum>)(typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2712);
			object obj97 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
			obj81 = (nint)0 + (nint)1024;
			obj3 = (nint)0 + (nint)2496;
			obj46 = obj35;
			obj18 = 0;
			func13 = func8;
			obj50 = obj49;
			num5 = num4;
			int32Enum2 = int32Enum;
			obj37 = obj21;
			num2 = num;
			obj16 = obj38;
			func2 = func10;
			lookup4 = lookup3;
			object obj98 = obj96;
			object obj99 = obj98;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v56+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v56+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0918;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v56+B0]");
			int num16 = (int)((nint)0 + (nint)8);
			bool flag48 = flag17;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X10_v60 (System.Int32)-8]");
				obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X10_v60 (System.Int32)-8]");
				bool flag49 = 0 < (nint)obj7;
				object obj22 = !flag49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X10_v60 (System.Int32)-8]");
				object obj23 = 0 - obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X10_v60 (System.Int32)-8]");
				if (0 == (nint)obj7)
				{
					break;
				}
				num2 = num16 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v56+12E]");
				array = (object[])(-1);
				bool flag50 = (nint)array < 1;
				obj22 = !flag50;
				obj23 = array - 1;
				bool flag7 = obj23 == null;
				flag17 = (nint)array != 1;
				flag48 = flag17;
				num16 = num2;
				if (flag17)
				{
					continue;
				}
				goto IL_0918;
			}
			array = (object[])((int*)num16)->m_value;
			object obj100 = obj99 + ((int*)num16)->m_value;
			object obj101 = obj100 + 312;
			flag17 = flag48;
			num2 = num16;
			goto IL_221e;
		}
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_1e1a;
		IL_263b:
		bool flag51 = obj65 == null;
		object obj102 = !flag51;
		obj35 = obj46;
		obj47 = obj48;
		lookup = lookup2;
		func8 = func13;
		obj49 = obj50;
		num4 = num5;
		int32Enum = int32Enum2;
		obj7 = obj51;
		dictionary2 = dictionary3;
		obj21 = obj37;
		num = num2;
		obj16 = obj52;
		func2 = func12;
		obj3 = obj53;
		object obj103;
		obj6 = obj103;
		Func<System.Int32Enum, System.Int32Enum> func15;
		func5 = func15;
		if (obj102 != null)
		{
			goto IL_1e61;
		}
		object obj104;
		if ((nint)obj104 != 10)
		{
			bool flag52 = obj104 == null;
			object obj105 = !flag52;
			if (obj105 != null)
			{
				goto IL_1c89;
			}
		}
		object obj107;
		object obj106 = obj107;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1134 @ X0_v18+E4]");
		bool flag53 = (nint)0 == 0;
		object obj108 = !flag53;
		if (obj108 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj106 = obj107;
		}
		object obj109 = (nint)0 + (nint)2864;
		func5 = (Func<System.Int32Enum, System.Int32Enum>)(typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2008);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1134 @ X0_v18+B8]");
		object obj110 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ X8_v24+70]");
		Func<KeyValuePair<System.Int32Enum, int>, object> func16 = (Func<KeyValuePair<System.Int32Enum, int>, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ X8_v24+70]");
		bool flag54 = (nint)0 == 0;
		object obj111 = !flag54;
		if (obj111 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1134 @ X0_v18+E4]");
			bool flag55 = (nint)0 == 0;
			object obj112 = !flag55;
			if (obj112 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj113 = obj107;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1219 @ X8_v30+B8]");
				obj110 = 0;
			}
			object obj114 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3712;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj115 = (nint)0 + (nint)904;
			Func<KeyValuePair<System.Int32Enum, int>, object> func17 = default(Func<KeyValuePair<System.Int32Enum, int>, object>);
			func17..ctor(obj110, (IntPtr)obj115);
			object obj116 = obj107;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ X8_v29+B8]");
			object obj117 = (nint)0 + (nint)112;
			obj117 = func17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj52 = 0;
			func16 = func17;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C98878");
		obj6 = (int)int32Enum3 >> 32;
		nint num17 = (nint)lookup2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ X8_v11 (Il2CppClass<System.Linq.ILookup`2<System.Int32Enum, System.Object>>)+12E]");
		array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ X8_v11 (Il2CppClass<System.Linq.ILookup`2<System.Int32Enum, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_196e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ X8_v11 (Il2CppClass<System.Linq.ILookup`2<System.Int32Enum, System.Object>>)+B0]");
		int num18 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1272 @ X10_v7 (System.Int32)-8]");
			obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1272 @ X10_v7 (System.Int32)-8]");
			if (0 == (nint)func5)
			{
				break;
			}
			num2 = num18 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ X8_v11 (Il2CppClass<System.Linq.ILookup`2<System.Int32Enum, System.Object>>)+12E]");
			array = (object[])(-1);
			bool flag56 = (nint)array != 1;
			num18 = num2;
			if (flag56)
			{
				continue;
			}
			goto IL_196e;
		}
		array = (object[])((int*)num18)->m_value;
		object obj118 = num17 + ((int*)num18)->m_value;
		object obj119 = obj118 + 312;
		num2 = num18;
		goto IL_28eb;
		IL_1e61:
		OutOfMemoryException ex8 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		object obj120 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2680;
		object obj121 = (nint)0 + (nint)1896;
		object obj124;
		if ((nint)func4 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj41 = obj47;
			bool flag57 = obj47 == null;
			object obj122 = !flag57;
			object obj123 = default(object);
			obj65 = obj123;
			obj124 = 0;
			if (obj122 != null)
			{
				goto IL_16b9;
			}
			obj46 = obj35;
			obj48 = obj47;
			lookup2 = lookup;
			obj65 = obj123;
			func13 = func8;
			obj50 = obj49;
			num5 = num4;
			int32Enum2 = int32Enum;
			obj51 = obj7;
			dictionary3 = dictionary2;
			obj37 = obj21;
			num2 = num;
			obj107 = obj120;
			obj52 = obj16;
			func12 = func2;
			obj53 = obj3;
			obj103 = obj6;
			func15 = func5;
			obj104 = 0;
			obj44 = obj121;
			goto IL_263b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		KeyValuePair<bool, Suit> result2 = default(KeyValuePair<bool, Suit>);
		return result2;
		IL_1229:
		NullReferenceException ex9 = new NullReferenceException();
		obj35 = (object)(&obj18);
		obj36 = 0;
		func8 = func13;
		obj21 = obj37;
		num = num2;
		obj38 = obj16;
		func4 = null;
		func10 = func2;
		obj32 = 152993792;
		func11 = func5;
		goto IL_1e1a;
		IL_1c89:
		return (KeyValuePair<bool, Suit>)result;
		IL_207a:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_1e61;
		IL_1286:
		func13 = func9;
		int32Enum2 = int32Enum;
		obj16 = 0;
		func4 = (Func<object, System.Int32Enum>)(object)func9;
		goto IL_2548;
		IL_0918:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		func2 = null;
		goto IL_221e;
		IL_221e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1196 @ X0_v85+8]");
		func4 = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1196 @ X0_v85] (should have been resolved before IL gen)");
		object obj126 = default(object);
		object obj125 = obj126 & 1;
		if (obj125 != null)
		{
			if (obj17 != null)
			{
				object obj127 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 4072;
				object obj128 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1257 @ X8_v62+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1257 @ X8_v62+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0a8f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1257 @ X8_v62+B0]");
				int num19 = (int)((nint)0 + (nint)8);
				bool flag58 = flag17;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1341 @ X10_v55 (System.Int32)-8]");
					obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1341 @ X10_v55 (System.Int32)-8]");
					bool flag59 = 0 < (nint)obj127;
					object obj22 = !flag59;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1341 @ X10_v55 (System.Int32)-8]");
					object obj23 = 0 - obj127;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1341 @ X10_v55 (System.Int32)-8]");
					if (0 == (nint)obj127)
					{
						break;
					}
					num2 = num19 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1257 @ X8_v62+12E]");
					array = (object[])(-1);
					bool flag60 = (nint)array < 1;
					obj22 = !flag60;
					obj23 = array - 1;
					bool flag7 = obj23 == null;
					flag17 = (nint)array != 1;
					flag58 = flag17;
					num19 = num2;
					if (flag17)
					{
						continue;
					}
					goto IL_0a8f;
				}
				array = (object[])((int*)num19)->m_value;
				object obj129 = obj128 + ((int*)num19)->m_value;
				object obj130 = obj129 + 312;
				flag17 = flag58;
				num2 = num19;
				goto IL_22d2;
			}
			NullReferenceException ex11 = new NullReferenceException();
			obj35 = obj46;
			func8 = func13;
			obj49 = obj50;
			num4 = num5;
			int32Enum = int32Enum2;
			obj21 = obj37;
			num = num2;
			obj38 = obj16;
			func10 = func2;
			obj32 = 152993792;
			func11 = func5;
			goto IL_1e1a;
		}
		obj120 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2680;
		obj121 = (nint)0 + (nint)1896;
		object obj131 = (object)(&obj17);
		obj41 = obj131;
		bool flag61 = obj131 == null;
		obj35 = obj46;
		obj47 = (object)(&obj17);
		lookup = lookup3;
		obj65 = 0;
		func8 = func13;
		obj49 = obj50;
		num4 = num5;
		int32Enum = int32Enum2;
		dictionary2 = dictionary;
		obj21 = obj37;
		num = num2;
		obj6 = 152993792;
		obj124 = 10;
		obj48 = (object)(&obj17);
		lookup2 = lookup3;
		obj65 = 0;
		obj51 = obj7;
		dictionary3 = dictionary;
		obj107 = obj120;
		obj52 = obj16;
		func12 = func2;
		obj53 = obj3;
		obj103 = 152993792;
		func15 = func5;
		obj104 = 10;
		obj44 = obj121;
		if (!flag61)
		{
			goto IL_16b9;
		}
		goto IL_263b;
		IL_1771:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		func12 = null;
		goto IL_2717;
		IL_2717:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X0_v71+8]");
		func4 = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v965 @ X0_v71] (should have been resolved before IL gen)");
		obj46 = obj35;
		obj48 = obj47;
		lookup2 = lookup;
		func13 = func8;
		obj50 = obj49;
		num5 = num4;
		int32Enum2 = int32Enum;
		obj51 = obj7;
		dictionary3 = dictionary2;
		obj37 = obj21;
		num2 = num;
		obj107 = obj120;
		obj52 = obj16;
		obj53 = obj3;
		obj103 = obj6;
		func15 = func5;
		obj104 = obj124;
		obj44 = obj121;
		goto IL_263b;
	}

	public static bool ContainsRank(IEnumerable<Card> cards, Rank rank)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0083: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005a: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
			object obj4 = (nint)0 + (nint)1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return Enumerable.Any(cards, func);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static int WinnerTeam(int team1Abnat, int team2Abnat, int roundBidder)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_015e: Expected O, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected I4, but got Unknown
		//IL_01cb: Expected O, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected I4, but got Unknown
		//IL_0104: Expected O, but got I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_02d6: Expected O, but got I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected I4, but got Unknown
		//IL_0343: Expected O, but got I4
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0233: Expected O, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected I4, but got Unknown
		//IL_02a0: Expected O, but got I4
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		object obj = roundBidder - 1;
		bool flag = (nint)obj < 3;
		object obj2 = !flag;
		object obj3 = obj - 3;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 118730752 + 3184;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X9_v3+v0 @ X8_v1*4]");
			int result = 0;
			object obj7 = team2Abnat - team1Abnat;
			bool flag3 = (nint)obj7 < 0;
			bool flag4 = obj7 == null;
			int num = team2Abnat ^ team1Abnat;
			int num2 = team2Abnat ^ obj7;
			int num3 = num & num2;
			bool flag5 = num3 < 0;
			bool flag6 = flag3 == flag5;
			object obj8 = !flag4;
			object obj9 = flag6 & obj8;
			object obj10 = ~obj9;
			if (obj10 == null)
			{
				result = 2;
			}
			object obj11 = team1Abnat - team2Abnat;
			bool flag7 = (nint)obj11 < 0;
			bool flag8 = obj11 == null;
			int num4 = team1Abnat ^ team2Abnat;
			int num5 = team1Abnat ^ obj11;
			int num6 = num4 & num5;
			bool flag9 = num6 < 0;
			bool flag10 = flag7 == flag9;
			object obj12 = !flag10;
			object obj13 = obj12 | flag8;
			object obj14 = ~obj13;
			if (obj14 == null)
			{
				return result;
			}
			return 1;
		}
		object obj15 = team2Abnat - team1Abnat;
		bool flag11 = (nint)obj15 < 0;
		bool flag12 = obj15 == null;
		int num7 = team2Abnat ^ team1Abnat;
		int num8 = team2Abnat ^ obj15;
		int num9 = num7 & num8;
		bool flag13 = num9 < 0;
		bool flag14 = flag11 == flag13;
		object obj16 = !flag12;
		object obj17 = flag14 & obj16;
		object obj18 = ~obj17;
		int result2 = ((obj18 == null) ? 2 : 0);
		object obj19 = team1Abnat - team2Abnat;
		bool flag15 = (nint)obj19 < 0;
		bool flag16 = obj19 == null;
		int num10 = team1Abnat ^ team2Abnat;
		int num11 = team1Abnat ^ obj19;
		int num12 = num10 & num11;
		bool flag17 = num12 < 0;
		bool flag18 = flag15 == flag17;
		object obj20 = !flag18;
		object obj21 = obj20 | flag16;
		object obj22 = ~obj21;
		if (obj22 == null)
		{
			return result2;
		}
		return 1;
	}

	public static bool BidSuccess(int team1Abnat, int team2Abnat, int roundBidder)
	{
		//IL_000e: Expected O, but got I4
		//IL_001d: Expected O, but got I4
		//IL_0037: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_005f: Expected O, but got I4
		//IL_011d: Expected O, but got I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0145: Expected O, but got I4
		//IL_015b: Expected O, but got I4
		//IL_0164: Expected O, but got I4
		//IL_00fe: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_00a4: Expected O, but got I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e7: Expected O, but got I
		//IL_01bd: Expected O, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected I4, but got Unknown
		//IL_022a: Expected O, but got I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0182: Expected O, but got I
		//IL_025b: Expected O, but got I4
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected I4, but got Unknown
		//IL_02c8: Expected O, but got I4
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_01ab: Expected O, but got I4
		//IL_0198: Expected O, but got I4
		object obj = roundBidder - 1;
		object obj2 = 118730752 + 3184;
		bool flag = (nint)obj < 3;
		object obj3 = !flag;
		object obj4 = obj - 3;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		object obj6 = obj3 & obj5;
		object obj7;
		object obj12;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X10_v2+v0 @ X9_v1*4]");
			obj7 = 0;
			bool flag3 = (nint)obj < 3;
			object obj8 = !flag3;
			object obj9 = obj - 3;
			bool flag4 = obj9 == null;
			object obj10 = ~obj8;
			object obj11 = obj10 | flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X10_v2+v0 @ X9_v1*4]");
			obj12 = 0;
			if (obj11 == null)
			{
				goto IL_00f5;
			}
		}
		else
		{
			bool flag5 = (nint)obj < 3;
			object obj13 = !flag5;
			object obj14 = obj - 3;
			bool flag6 = obj14 == null;
			object obj15 = !flag6;
			object obj16 = obj13 & obj15;
			obj7 = 0;
			obj12 = 0;
			if (obj16 != null)
			{
				goto IL_00f5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X10_v2+v0 @ X9_v1*4]");
		object obj17 = 0;
		obj7 = obj12;
		goto IL_01b0;
		IL_01b0:
		object obj18 = team2Abnat - team1Abnat;
		bool flag7 = (nint)obj18 < 0;
		bool flag8 = obj18 == null;
		int num = team2Abnat ^ team1Abnat;
		int num2 = team2Abnat ^ obj18;
		int num3 = num & num2;
		bool flag9 = num3 < 0;
		bool flag10 = flag7 == flag9;
		object obj19 = !flag8;
		object obj20 = flag10 & obj19;
		object obj21 = ~obj20;
		if (obj21 == null)
		{
			obj17 = 2;
		}
		object obj22 = team1Abnat - team2Abnat;
		bool flag11 = (nint)obj22 < 0;
		bool flag12 = obj22 == null;
		int num4 = team1Abnat ^ team2Abnat;
		int num5 = team1Abnat ^ obj22;
		int num6 = num4 & num5;
		bool flag13 = num6 < 0;
		bool flag14 = flag11 == flag13;
		object obj23 = !flag14;
		object obj24 = obj23 | flag12;
		object obj25 = ~obj24;
		if (obj25 != null)
		{
			obj17 = 1;
		}
		object obj26 = obj7 - obj17;
		return obj26 == null;
		IL_00f5:
		obj17 = 0;
		goto IL_01b0;
	}

	public static int ProjectAbnat(BalootProject project)
	{
		//IL_001a: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0042: Expected O, but got I4
		//IL_006c: Expected O, but got I4
		bool flag = project < BalootProject.P400;
		object obj = !flag;
		object obj2 = project - 3;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 == null)
		{
			object obj5 = 119877632 + 1264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v2+project @ X0 (BalootProject)*4]");
			return 0;
		}
		return 0;
	}

	public static int ProjectValue(BalootProject project, BalootGame.BalootGameMode gameMode)
	{
		//IL_0012: Expected O, but got I8
		//IL_0032: Expected O, but got I8
		//IL_004c: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_0096: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_0100: Expected I4, but got O
		//IL_0088: Expected O, but got I4
		object obj = (long)project & 0xFFFFFFFFL;
		object obj2 = obj << 4;
		object obj3 = 112590420184268820L >> (int)obj2;
		bool flag = project < (BalootProject)4;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object obj6 = ~obj5;
		if (obj6 != null)
		{
			obj3 = 0;
		}
		object obj7 = obj3 & 0x1FFFE;
		object obj8 = ((gameMode != BalootGame.BalootGameMode.Hokom) ? ((object)5) : ((object)10));
		object obj9 = obj7 / obj8;
		object obj10 = project - 3;
		bool flag2 = obj10 == null;
		return obj9 >> (flag2 ? 1 : 0);
	}

	public static int GetPlayerTeam(int seatIndex)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		object obj = seatIndex - 1;
		bool flag = (nint)obj < 3;
		object obj2 = !flag;
		object obj3 = obj - 3;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 118730752 + 3184;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X9_v2+v0 @ X8_v1*4]");
			return 0;
		}
		return 0;
	}

	public static int GetOffsetIndex(int index, int offset, int mod = 4)
	{
		//IL_000d: Expected O, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
		//IL_0027: Expected O, but got I4
		//IL_0034: Expected I4, but got O
		object obj = offset + index;
		int num = obj / mod;
		object obj2 = num * mod;
		return obj - obj2;
	}
}
