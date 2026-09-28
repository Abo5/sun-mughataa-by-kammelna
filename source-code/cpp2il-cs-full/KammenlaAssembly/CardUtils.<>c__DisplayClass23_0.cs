using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities.Data;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.TextCore;

public class CardUtils : ICardUtils
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Card, int> <>9__17_0;

		public static Func<long, int, long> <>9__18_0;

		public static Func<Card, Suit> <>9__24_0;

		static <>c()
		{
			object typeFromHandle = typeof(<>c);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj = default(object);
			obj..ctor();
			object obj2 = typeFromHandle;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <EncodeBinaryLongCards>b__17_0(Card card)
		{
			//IL_003d: Expected I4, but got O
			if (card != null)
			{
				return card.AsInt();
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal long <EncodeBinaryLongCards>b__18_0(long current, int card)
		{
			int num = 1 << card;
			return num | current;
		}

		internal Suit <GetSuitOrder>b__24_0(Card card)
		{
			//IL_0035: Expected I4, but got O
			if (card != null)
			{
				return card.<Suit>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Suit)ex;
		}
	}

	private sealed class <>c__DisplayClass23_0
	{
		public CardUtils <>4__this;

		public List<Suit> suitOrder;

		internal int <SortCards>g__Comparison|0(Card card1, Card card2)
		{
			//IL_0203: Expected I4, but got O
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected O, but got Unknown
			//IL_019d: Expected O, but got I
			//IL_01b7: Expected O, but got I4
			//IL_00f9: Expected O, but got I
			//IL_01e7: Expected O, but got I4
			if (card1 != null && card2 != null)
			{
				if (card1.<Suit>k__BackingField == card2.<Suit>k__BackingField)
				{
					if (<>4__this != null)
					{
						int value = <>4__this.GetValue(card1);
						int value2 = <>4__this.GetValue(card2);
						return value - value2;
					}
				}
				else
				{
					object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v4+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BC2]");
						object obj3 = (nint)0 & (nint)1;
						if (obj3 != null)
						{
							goto IL_0116;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BC2]");
						object obj4 = (nint)0 & (nint)1;
						bool flag = obj4 == null;
						object obj5 = !flag;
						if (obj5 != null)
						{
							goto IL_0116;
						}
					}
					_ = 1;
					bool flag2 = suitOrder == null;
					object obj6 = !flag2;
					if (obj6 != null)
					{
						goto IL_0135;
					}
				}
			}
			goto IL_01f5;
			IL_0135:
			int num = ((List<System.Int32Enum>)(object)suitOrder).IndexOf((System.Int32Enum)card1.<Suit>k__BackingField);
			int num2 = ((List<System.Int32Enum>)(object)suitOrder).IndexOf((System.Int32Enum)card2.<Suit>k__BackingField);
			return num - num2;
			IL_01f5:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_0116:
			if (suitOrder != null)
			{
				goto IL_0135;
			}
			goto IL_01f5;
		}
	}

	private const long SpadesMask = 8191L;

	private const long HeartsMask = 67100672L;

	private const long ClubsMask = 549688705024L;

	private const long DiamondsMask = 4503049871556608L;

	private static readonly long[] SuitMasks;

	internal static readonly List<Suit> DefaultSuitOrder;

	private static readonly List<Suit> MissingClubsOrder;

	private static readonly List<Suit> MissingDiamondsOrder;

	protected readonly CardGame Game;

	protected CardUtils(CardGame game)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = game;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public static Card FromInt(int intRepresentation)
	{
		//IL_00ba: Expected I4, but got I8
		//IL_00d4: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_001d: Expected O, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_003f: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		int num = (int)(intRepresentation & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = (nint)0 + (nint)1576;
			object obj3 = (nint)0 + (nint)1584;
			object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
			object obj5 = intRepresentation * 1321528399;
			object obj6 = obj5 >> 34;
			object obj7 = obj6 * 13;
			object obj8 = intRepresentation - obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D712E8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D712E8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Card card = default(Card);
			Rank rank = default(Rank);
			Suit suit = default(Suit);
			card..ctor(rank, suit);
			return card;
		}
		return null;
	}

	public static Card FromString(string stringRepresentation)
	{
		//IL_0011: Expected O, but got I
		//IL_001d: Expected O, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (stringRepresentation != null)
		{
			object obj = (nint)0 + (nint)1696;
			object obj2 = (nint)0 + (nint)1704;
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
			int length = stringRepresentation._stringLength - 1;
			string text = stringRepresentation.Substring(1, length);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D71ADC");
			string text2 = stringRepresentation.Substring(0, 1);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D71ADC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Card card = default(Card);
			Rank rank = default(Rank);
			Suit suit = default(Suit);
			card..ctor(rank, suit);
			return card;
		}
		return (Card)(object)new NullReferenceException();
	}

	public static List<Card> DecodeCards(ISFSObject data, string key)
	{
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_0104: Expected I, but got O
		//IL_0114: Expected O, but got I
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_020a: Expected O, but got I4
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_014f: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		object obj;
		nint num2;
		if (data != null)
		{
			obj = typeof(System.IOAsyncCallback) + 976;
			nint num = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v12-8]");
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
			object obj4 = obj3 + 1;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v22+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ X0_v22] (should have been resolved before IL gen)");
			object obj8 = default(object);
			object obj7 = obj8 & 1;
			bool flag = obj7 == null;
			object obj9 = !flag;
			if (obj9 != null)
			{
				goto IL_00fc;
			}
		}
		goto IL_0218;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v19+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v142 @ X0_v19] (should have been resolved before IL gen)");
		object obj11 = default(object);
		object obj10 = obj11 & 1;
		if (obj10 != null)
		{
			goto IL_00fc;
		}
		goto IL_0218;
		IL_0218:
		object obj12 = typeof(List<AdaptivePerformanceScaler>) + 416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		return (List<Card>)(object)list;
		IL_00fc:
		nint num3 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0190;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X10_v7-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj14 += 16;
			obj13--;
			if ((nint)obj13 != 1)
			{
				continue;
			}
			goto IL_0190;
		}
		object obj15 = obj14 + 10;
		object obj16 = num3 + obj15;
		object obj17 = obj16 + 312;
		goto IL_0310;
		IL_0190:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0310;
		IL_0310:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v305 @ X0_v7] (should have been resolved before IL gen)");
		object obj18 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v13+E4]");
		SFSDataWrapper wrapper = default(SFSDataWrapper);
		if ((nint)0 != 0)
		{
			return ExtractCardData(wrapper);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return ExtractCardData(wrapper);
	}

	public static List<Card> DecodeCards(ISFSArray data, int index)
	{
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_010c: Expected I, but got O
		//IL_011c: Expected O, but got I
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_0157: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		bool flag = data == null;
		int num = index;
		if (!flag)
		{
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1616;
			nint num2 = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v12-8]");
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
			object obj4 = obj3 + 1;
			object obj5 = num2 + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v22+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v186 @ X0_v22] (should have been resolved before IL gen)");
			object obj7 = default(object);
			if (index < (nint)obj7)
			{
				goto IL_00f0;
			}
		}
		goto IL_0206;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v19+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v146 @ X0_v19] (should have been resolved before IL gen)");
		object obj8 = default(object);
		if (index < (nint)obj8)
		{
			goto IL_00f0;
		}
		goto IL_0206;
		IL_0206:
		object obj9 = typeof(List<AdaptivePerformanceScaler>) + 416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		return (List<Card>)(object)list;
		IL_00f0:
		object obj10 = typeof(System.IOAsyncCallback) + 960;
		nint num3 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0198;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X10_v7-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_0198;
		}
		object obj13 = obj12 + 2;
		object obj14 = num3 + obj13;
		object obj15 = obj14 + 312;
		goto IL_0306;
		IL_0198:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0306;
		IL_0306:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v322 @ X0_v7] (should have been resolved before IL gen)");
		object obj16 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v17+E4]");
		SFSDataWrapper wrapper = default(SFSDataWrapper);
		if ((nint)0 != 0)
		{
			return ExtractCardData(wrapper);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return ExtractCardData(wrapper);
	}

	private static List<Card> ExtractCardData(SFSDataWrapper wrapper)
	{
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_020f: Expected O, but got I4
		//IL_0046: Expected I, but got O
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_0279: Expected O, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_009f: Expected O, but got I4
		//IL_02e0: Expected I, but got O
		//IL_00cb: Expected O, but got I4
		//IL_00db: Expected O, but got I
		//IL_00e3: Expected I, but got O
		//IL_0125: Expected I8, but got O
		if (wrapper != null)
		{
			int type = wrapper.Type;
			if (type != 12)
			{
				bool flag = type != 5;
				nint num = unchecked((nint)null);
				if (!flag)
				{
					object data = wrapper.Data;
					object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v14+E4]");
					bool flag2 = (nint)0 == 0;
					object obj3 = !flag2;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag3 = data == null;
					num = unchecked((nint)null);
					if (flag3)
					{
						goto IL_022c;
					}
					object obj4 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v16+68]");
					object obj5 = 0;
					nint num2 = (nint)data;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v17 (Il2CppClass<System.Object>)+40]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X1_v12+40]");
					if (num3 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
						object obj6 = default(object);
						return DecodeBinaryLongCards((long)obj6);
					}
				}
				else
				{
					object obj7 = typeof(MemberAchievementClanFeedData) + 2648;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					NotSupportedException ex = default(NotSupportedException);
					ex..ctor();
					object obj8 = (nint)0 + (nint)3352;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					OutOfMemoryException ex2 = new OutOfMemoryException();
				}
				throw new InvalidCastException();
			}
			object data2 = wrapper.Data;
			object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v23+E4]");
			if ((nint)0 != 0)
			{
				if (data2 != null)
				{
					goto IL_019e;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag4 = data2 == null;
				object obj11 = !flag4;
				if (obj11 != null)
				{
					goto IL_019e;
				}
			}
			return DecodeIntArrayCards(null);
		}
		goto IL_022c;
		IL_019e:
		object obj12 = typeof(TypeConverter<ushort, char>) + 3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		IEnumerable<int> enumerable = default(IEnumerable<int>);
		if (enumerable != null)
		{
			return DecodeIntArrayCards(enumerable);
		}
		return (List<Card>)(object)new InvalidCastException();
		IL_022c:
		throw new NullReferenceException();
	}

	public static List<Card> DecodeIntArrayCards(IEnumerable<int> intCards)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0051: Expected I, but got O
		object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1848;
		object obj2 = (nint)0 + (nint)3360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<int, object> func = default(Func<int, object>);
		func..ctor((object)null, (IntPtr)obj2);
		IEnumerable<object> source = Enumerable.Select(intCards, func);
		return (List<Card>)(object)Enumerable.ToList(source);
	}

	public static List<Card> DecodeBinaryLongCards(long binaryRepresentation)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_2a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a1f: Expected O, but got Unknown
		//IL_2a31: Expected I4, but got O
		//IL_17c2: Expected O, but got I
		//IL_005b: Expected O, but got I4
		//IL_0b42: Expected O, but got I
		//IL_2a6f: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_1849: Expected O, but got I4
		//IL_0bc9: Expected O, but got I4
		//IL_00c1: Expected O, but got I
		//IL_187f: Expected O, but got I4
		//IL_0bff: Expected O, but got I4
		//IL_18b5: Expected O, but got I4
		//IL_02fd: Expected O, but got I4
		//IL_0c35: Expected O, but got I4
		//IL_2aa4: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_18eb: Expected O, but got I4
		//IL_0c6b: Expected O, but got I4
		//IL_0332: Expected O, but got I
		//IL_034c: Expected O, but got I8
		//IL_024f: Expected O, but got I4
		//IL_1921: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_012b: Expected O, but got I4
		//IL_0133: Expected I4, but got O
		//IL_0ca1: Expected O, but got I4
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_02bd: Expected O, but got I4
		//IL_02ce: Expected I4, but got O
		//IL_1957: Expected O, but got I4
		//IL_0cd7: Expected O, but got I4
		//IL_198d: Expected O, but got I4
		//IL_05bb: Expected O, but got I4
		//IL_0d0d: Expected O, but got I4
		//IL_2ad9: Expected O, but got I
		//IL_04e6: Expected O, but got I4
		//IL_19c3: Expected O, but got I4
		//IL_0d43: Expected O, but got I4
		//IL_05f0: Expected O, but got I
		//IL_0612: Expected O, but got I4
		//IL_0527: Expected O, but got I4
		//IL_19f9: Expected O, but got I4
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_03fa: Expected O, but got I4
		//IL_040b: Expected I4, but got O
		//IL_0d79: Expected O, but got I4
		//IL_054e: Expected O, but got I
		//IL_055e: Expected O, but got I
		//IL_0584: Expected O, but got I4
		//IL_058c: Expected I4, but got O
		//IL_1a2f: Expected O, but got I4
		//IL_0daf: Expected O, but got I4
		//IL_1a65: Expected O, but got I4
		//IL_087b: Expected O, but got I4
		//IL_0de5: Expected O, but got I4
		//IL_2b0e: Expected O, but got I
		//IL_07a6: Expected O, but got I4
		//IL_1a9b: Expected O, but got I4
		//IL_0e1b: Expected O, but got I4
		//IL_08b0: Expected O, but got I
		//IL_08ca: Expected O, but got I8
		//IL_07e7: Expected O, but got I4
		//IL_1ad1: Expected O, but got I4
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected O, but got Unknown
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected O, but got Unknown
		//IL_06ba: Expected O, but got I4
		//IL_06cb: Expected I4, but got O
		//IL_0e51: Expected O, but got I4
		//IL_080e: Expected O, but got I
		//IL_081e: Expected O, but got I
		//IL_0844: Expected O, but got I4
		//IL_084c: Expected I4, but got O
		//IL_1b01: Expected O, but got I4
		//IL_1b70: Expected O, but got I8
		//IL_1b31: Expected O, but got I
		//IL_1bca: Expected O, but got I4
		//IL_0ec1: Expected O, but got I4
		//IL_0a64: Expected O, but got I4
		//IL_1c00: Expected O, but got I4
		//IL_0ef7: Expected O, but got I4
		//IL_0aa3: Expected O, but got I4
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Expected O, but got Unknown
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Expected O, but got Unknown
		//IL_0978: Expected O, but got I4
		//IL_0989: Expected I4, but got O
		//IL_1c36: Expected O, but got I4
		//IL_0f2d: Expected O, but got I4
		//IL_0aca: Expected O, but got I
		//IL_0ada: Expected O, but got I
		//IL_0b00: Expected O, but got I4
		//IL_0b08: Expected I4, but got O
		//IL_1c6c: Expected O, but got I4
		//IL_0f63: Expected O, but got I4
		//IL_1ca2: Expected O, but got I4
		//IL_0f99: Expected O, but got I4
		//IL_1cd8: Expected O, but got I4
		//IL_0fcf: Expected O, but got I4
		//IL_1d0e: Expected O, but got I4
		//IL_1005: Expected O, but got I4
		//IL_1d44: Expected O, but got I4
		//IL_103b: Expected O, but got I4
		//IL_1d7a: Expected O, but got I4
		//IL_1071: Expected O, but got I4
		//IL_1db0: Expected O, but got I4
		//IL_10a7: Expected O, but got I4
		//IL_1de6: Expected O, but got I4
		//IL_10dd: Expected O, but got I4
		//IL_1e1c: Expected O, but got I4
		//IL_1113: Expected O, but got I4
		//IL_1e52: Expected O, but got I4
		//IL_1149: Expected O, but got I4
		//IL_1e82: Expected O, but got I4
		//IL_1ef9: Expected O, but got I4
		//IL_1eb2: Expected O, but got I
		//IL_11b9: Expected O, but got I4
		//IL_1f4d: Expected O, but got I4
		//IL_11ef: Expected O, but got I4
		//IL_1f83: Expected O, but got I4
		//IL_1225: Expected O, but got I4
		//IL_1fb9: Expected O, but got I4
		//IL_125b: Expected O, but got I4
		//IL_1fef: Expected O, but got I4
		//IL_1291: Expected O, but got I4
		//IL_2025: Expected O, but got I4
		//IL_12cb: Expected O, but got I4
		//IL_205f: Expected O, but got I4
		//IL_1305: Expected O, but got I4
		//IL_2099: Expected O, but got I4
		//IL_133f: Expected O, but got I4
		//IL_20d3: Expected O, but got I4
		//IL_1379: Expected O, but got I4
		//IL_210d: Expected O, but got I4
		//IL_13b3: Expected O, but got I4
		//IL_2147: Expected O, but got I4
		//IL_13ed: Expected O, but got I4
		//IL_2181: Expected O, but got I4
		//IL_1427: Expected O, but got I4
		//IL_21bb: Expected O, but got I4
		//IL_1461: Expected O, but got I4
		//IL_21f5: Expected O, but got I4
		//IL_2225: Expected O, but got I4
		//IL_2294: Expected O, but got I8
		//IL_14d5: Expected O, but got I4
		//IL_2255: Expected O, but got I
		//IL_22f2: Expected O, but got I4
		//IL_150f: Expected O, but got I4
		//IL_232c: Expected O, but got I4
		//IL_1549: Expected O, but got I4
		//IL_2366: Expected O, but got I4
		//IL_1583: Expected O, but got I4
		//IL_23a0: Expected O, but got I4
		//IL_15bd: Expected O, but got I4
		//IL_23da: Expected O, but got I4
		//IL_15f7: Expected O, but got I4
		//IL_2414: Expected O, but got I4
		//IL_1631: Expected O, but got I4
		//IL_244e: Expected O, but got I4
		//IL_166b: Expected O, but got I4
		//IL_2488: Expected O, but got I4
		//IL_16a5: Expected O, but got I4
		//IL_24c2: Expected O, but got I4
		//IL_16df: Expected O, but got I4
		//IL_24fc: Expected O, but got I4
		//IL_1719: Expected O, but got I4
		//IL_2536: Expected O, but got I4
		//IL_1753: Expected O, but got I4
		//IL_2570: Expected O, but got I4
		//IL_178d: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
		object obj2 = (nint)0 + (nint)2632;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Rank rank = (Rank)obj2;
		List<object> list = default(List<object>);
		list..ctor();
		List<object> list2 = (List<object>)obj3;
		object obj8;
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v86 (System.Collections.Generic.List`1<System.Object>)+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				list2 = (List<object>)obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v86 (System.Collections.Generic.List`1<System.Object>)+B8]");
			object obj6 = 0;
			object obj7 = obj6;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v80+18]");
				object[] array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v80+18]");
				if ((nint)0 == 0)
				{
					goto IL_25c9;
				}
				obj8 = (nint)0 + (nint)2648;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v80+20]");
				long num = 0 & binaryRepresentation;
				Rank rank2 = Rank.TWO;
				Card card = default(Card);
				while (true)
				{
					long num2 = num >> (int)rank2;
					long num3 = num2 & 1;
					if (num3 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						card..ctor(rank2, Suit.SPADES);
						object obj9 = obj8;
						int version = list._version + 1;
						list._version = version;
						array = list._items;
						bool flag2 = list._items == null;
						object obj10 = 0;
						Suit suit = Suit.SPADES;
						rank = rank2;
						if (flag2)
						{
							break;
						}
						bool flag3 = list._size < array.Length;
						object obj11 = !flag3;
						if (obj11 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v84+20]");
							object obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1062 @ X8_v86+C0]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v87+70]");
							suit = Suit.SPADES;
							list.AddWithResize((object)card);
							obj10 = 0;
							rank = (Rank)card;
						}
						else
						{
							int size = list._size + 1;
							list._size = size;
							object obj14 = list._items + list._size;
							object obj15 = obj14 + 32;
							obj15 = card;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj10 = 0;
							suit = Suit.SPADES;
							rank = (Rank)card;
						}
					}
					rank2++;
					if (rank2 != Rank.NONE)
					{
						continue;
					}
					goto IL_02d3;
				}
			}
			goto IL_25bb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v86 (System.Collections.Generic.List`1<System.Object>)+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v86 (System.Collections.Generic.List`1<System.Object>)+B8]");
			object obj16 = 0;
			object obj17 = obj16;
			if (obj16 == null)
			{
				goto IL_25bb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v76+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v76+20]");
				long num4 = 0 & binaryRepresentation;
				long num5 = num4 & 1;
				bool flag4 = num5 == 0;
				object obj18 = !flag4;
				if (obj18 != null)
				{
					goto IL_25d4;
				}
				long num6 = num4 & 2;
				bool flag5 = num6 == 0;
				object obj19 = !flag5;
				if (obj19 != null)
				{
					goto IL_25eb;
				}
				long num7 = num4 & 4;
				bool flag6 = num7 == 0;
				object obj20 = !flag6;
				if (obj20 != null)
				{
					goto IL_2602;
				}
				long num8 = num4 & 8;
				bool flag7 = num8 == 0;
				object obj21 = !flag7;
				if (obj21 != null)
				{
					goto IL_2619;
				}
				long num9 = num4 & 0x10;
				bool flag8 = num9 == 0;
				object obj22 = !flag8;
				if (obj22 != null)
				{
					goto IL_2630;
				}
				long num10 = num4 & 0x20;
				bool flag9 = num10 == 0;
				object obj23 = !flag9;
				if (obj23 != null)
				{
					goto IL_2647;
				}
				long num11 = num4 & 0x40;
				bool flag10 = num11 == 0;
				object obj24 = !flag10;
				if (obj24 != null)
				{
					goto IL_265e;
				}
				long num12 = num4 & 0x80;
				bool flag11 = num12 == 0;
				object obj25 = !flag11;
				if (obj25 != null)
				{
					goto IL_2675;
				}
				long num13 = num4 & 0x100;
				bool flag12 = num13 == 0;
				object obj26 = !flag12;
				if (obj26 != null)
				{
					goto IL_268c;
				}
				long num14 = num4 & 0x200;
				bool flag13 = num14 == 0;
				object obj27 = !flag13;
				if (obj27 != null)
				{
					goto IL_26a3;
				}
				long num15 = num4 & 0x400;
				bool flag14 = num15 == 0;
				object obj28 = !flag14;
				if (obj28 != null)
				{
					goto IL_26ba;
				}
				long num16 = num4 & 0x800;
				bool flag15 = num16 == 0;
				object obj29 = !flag15;
				if (obj29 != null)
				{
					goto IL_26d1;
				}
				long num17 = num4 & 0x1000;
				bool flag16 = num17 == 0;
				object obj30 = !flag16;
				if (obj30 != null)
				{
					goto IL_26e8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v76+18]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v76+28]");
					long num18 = 0 & binaryRepresentation;
					long num19 = num18 & 0x2000;
					bool flag17 = num19 == 0;
					object obj31 = !flag17;
					if (obj31 != null)
					{
						goto IL_26ff;
					}
					long num20 = num18 & 0x4000;
					bool flag18 = num20 == 0;
					object obj32 = !flag18;
					if (obj32 != null)
					{
						goto IL_2716;
					}
					long num21 = num18 & 0x8000;
					bool flag19 = num21 == 0;
					object obj33 = !flag19;
					if (obj33 != null)
					{
						goto IL_272d;
					}
					long num22 = num18 & 0x10000;
					bool flag20 = num22 == 0;
					object obj34 = !flag20;
					if (obj34 != null)
					{
						goto IL_2744;
					}
					long num23 = num18 & 0x20000;
					bool flag21 = num23 == 0;
					object obj35 = !flag21;
					if (obj35 != null)
					{
						goto IL_275b;
					}
					long num24 = num18 & 0x40000;
					bool flag22 = num24 == 0;
					object obj36 = !flag22;
					if (obj36 != null)
					{
						goto IL_2772;
					}
					long num25 = num18 & 0x80000;
					bool flag23 = num25 == 0;
					object obj37 = !flag23;
					if (obj37 != null)
					{
						goto IL_2789;
					}
					long num26 = num18 & 0x100000;
					bool flag24 = num26 == 0;
					object obj38 = !flag24;
					if (obj38 != null)
					{
						goto IL_27a0;
					}
					long num27 = num18 & 0x200000;
					bool flag25 = num27 == 0;
					object obj39 = !flag25;
					if (obj39 != null)
					{
						goto IL_27b7;
					}
					long num28 = num18 & 0x400000;
					bool flag26 = num28 == 0;
					object obj40 = !flag26;
					if (obj40 != null)
					{
						goto IL_27ce;
					}
					long num29 = num18 & 0x800000;
					bool flag27 = num29 == 0;
					object obj41 = !flag27;
					if (obj41 != null)
					{
						goto IL_27e5;
					}
					long num30 = num18 & 0x1000000;
					bool flag28 = num30 == 0;
					object obj42 = !flag28;
					if (obj42 != null)
					{
						goto IL_27fc;
					}
					long num31 = num18 & 0x2000000;
					bool flag29 = num31 == 0;
					object obj43 = !flag29;
					if (obj43 != null)
					{
						goto IL_2813;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v76+18]");
					if ((nint)0 != 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v76+30]");
						long num32 = 0 & binaryRepresentation;
						long num33 = num32 & 0x4000000;
						bool flag30 = num33 == 0;
						object obj44 = !flag30;
						if (obj44 != null)
						{
							goto IL_282a;
						}
						long num34 = num32 & 0x8000000;
						bool flag31 = num34 == 0;
						object obj45 = !flag31;
						if (obj45 != null)
						{
							goto IL_2841;
						}
						long num35 = num32 & 0x10000000;
						bool flag32 = num35 == 0;
						object obj46 = !flag32;
						if (obj46 != null)
						{
							goto IL_2858;
						}
						long num36 = num32 & 0x20000000;
						bool flag33 = num36 == 0;
						object obj47 = !flag33;
						if (obj47 != null)
						{
							goto IL_286f;
						}
						long num37 = num32 & 0x40000000;
						bool flag34 = num37 == 0;
						object obj48 = !flag34;
						if (obj48 != null)
						{
							goto IL_2886;
						}
						long num38 = num32 & 0x80000000L;
						bool flag35 = num38 == 0;
						object obj49 = !flag35;
						if (obj49 != null)
						{
							goto IL_289d;
						}
						long num39 = num32 & 0x100000000L;
						bool flag36 = num39 == 0;
						object obj50 = !flag36;
						if (obj50 != null)
						{
							goto IL_28b4;
						}
						long num40 = num32 & 0x200000000L;
						bool flag37 = num40 == 0;
						object obj51 = !flag37;
						if (obj51 != null)
						{
							goto IL_28cb;
						}
						long num41 = num32 & 0x400000000L;
						bool flag38 = num41 == 0;
						object obj52 = !flag38;
						if (obj52 != null)
						{
							goto IL_28e2;
						}
						long num42 = num32 & 0x800000000L;
						bool flag39 = num42 == 0;
						object obj53 = !flag39;
						if (obj53 != null)
						{
							goto IL_28f9;
						}
						long num43 = num32 & 0x1000000000L;
						bool flag40 = num43 == 0;
						object obj54 = !flag40;
						if (obj54 != null)
						{
							goto IL_2910;
						}
						long num44 = num32 & 0x2000000000L;
						bool flag41 = num44 == 0;
						object obj55 = !flag41;
						if (obj55 != null)
						{
							goto IL_2927;
						}
						long num45 = num32 & 0x4000000000L;
						bool flag42 = num45 == 0;
						object obj56 = !flag42;
						if (obj56 != null)
						{
							goto IL_293e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v76+18]");
						if ((nint)0 != 3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v76+38]");
							long num46 = 0 & binaryRepresentation;
							long num47 = num46 & 0x8000000000L;
							bool flag43 = num47 == 0;
							object obj57 = !flag43;
							if (obj57 != null)
							{
								goto IL_2955;
							}
							long num48 = num46 & 0x10000000000L;
							bool flag44 = num48 == 0;
							object obj58 = !flag44;
							if (obj58 != null)
							{
								goto IL_2963;
							}
							long num49 = num46 & 0x20000000000L;
							bool flag45 = num49 == 0;
							object obj59 = !flag45;
							if (obj59 != null)
							{
								goto IL_2971;
							}
							long num50 = num46 & 0x40000000000L;
							bool flag46 = num50 == 0;
							object obj60 = !flag46;
							if (obj60 != null)
							{
								goto IL_297f;
							}
							long num51 = num46 & 0x80000000000L;
							bool flag47 = num51 == 0;
							object obj61 = !flag47;
							if (obj61 != null)
							{
								goto IL_2996;
							}
							long num52 = num46 & 0x100000000000L;
							bool flag48 = num52 == 0;
							object obj62 = !flag48;
							if (obj62 != null)
							{
								goto IL_29a4;
							}
							long num53 = num46 & 0x200000000000L;
							bool flag49 = num53 == 0;
							object obj63 = !flag49;
							if (obj63 != null)
							{
								goto IL_29b2;
							}
							long num54 = num46 & 0x400000000000L;
							bool flag50 = num54 == 0;
							object obj64 = !flag50;
							if (obj64 != null)
							{
								goto IL_29c0;
							}
							long num55 = num46 & 0x800000000000L;
							bool flag51 = num55 == 0;
							object obj65 = !flag51;
							if (obj65 != null)
							{
								goto IL_29ce;
							}
							long num56 = num46 & 0x1000000000000L;
							bool flag52 = num56 == 0;
							object obj66 = !flag52;
							if (obj66 != null)
							{
								goto IL_29dc;
							}
							long num57 = num46 & 0x2000000000000L;
							bool flag53 = num57 == 0;
							object obj67 = !flag53;
							if (obj67 != null)
							{
								goto IL_29ea;
							}
							long num58 = num46 & 0x4000000000000L;
							bool flag54 = num58 == 0;
							object obj68 = !flag54;
							if (obj68 == null)
							{
								long num59 = num46 & 0x8000000000000L;
								bool flag55 = num59 == 0;
								object obj69 = !flag55;
								if (obj69 == null)
								{
									goto IL_179b;
								}
								goto IL_25ad;
							}
							goto IL_29f8;
						}
					}
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj70 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v71+B8]");
			object obj71 = 0;
			object obj72 = obj71;
			if (obj71 == null)
			{
				goto IL_25bb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v65+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v65+20]");
				long num60 = 0 & binaryRepresentation;
				long num61 = num60 & 1;
				bool flag56 = num61 == 0;
				object obj73 = !flag56;
				if (obj73 != null)
				{
					goto IL_25d4;
				}
				long num62 = num60 & 2;
				bool flag57 = num62 == 0;
				object obj74 = !flag57;
				if (obj74 != null)
				{
					goto IL_25eb;
				}
				long num63 = num60 & 4;
				bool flag58 = num63 == 0;
				object obj75 = !flag58;
				if (obj75 != null)
				{
					goto IL_2602;
				}
				long num64 = num60 & 8;
				bool flag59 = num64 == 0;
				object obj76 = !flag59;
				if (obj76 != null)
				{
					goto IL_2619;
				}
				long num65 = num60 & 0x10;
				bool flag60 = num65 == 0;
				object obj77 = !flag60;
				if (obj77 != null)
				{
					goto IL_2630;
				}
				long num66 = num60 & 0x20;
				bool flag61 = num66 == 0;
				object obj78 = !flag61;
				if (obj78 != null)
				{
					goto IL_2647;
				}
				long num67 = num60 & 0x40;
				bool flag62 = num67 == 0;
				object obj79 = !flag62;
				if (obj79 != null)
				{
					goto IL_265e;
				}
				long num68 = num60 & 0x80;
				bool flag63 = num68 == 0;
				object obj80 = !flag63;
				if (obj80 != null)
				{
					goto IL_2675;
				}
				long num69 = num60 & 0x100;
				bool flag64 = num69 == 0;
				object obj81 = !flag64;
				if (obj81 != null)
				{
					goto IL_268c;
				}
				long num70 = num60 & 0x200;
				bool flag65 = num70 == 0;
				object obj82 = !flag65;
				if (obj82 != null)
				{
					goto IL_26a3;
				}
				long num71 = num60 & 0x400;
				bool flag66 = num71 == 0;
				object obj83 = !flag66;
				if (obj83 != null)
				{
					goto IL_26ba;
				}
				long num72 = num60 & 0x800;
				bool flag67 = num72 == 0;
				object obj84 = !flag67;
				if (obj84 != null)
				{
					goto IL_26d1;
				}
				long num73 = num60 & 0x1000;
				bool flag68 = num73 == 0;
				object obj85 = !flag68;
				if (obj85 != null)
				{
					goto IL_26e8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v71+E4]");
				bool flag69 = (nint)0 == 0;
				object obj86 = !flag69;
				if (obj86 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj70 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v71+B8]");
					object obj87 = 0;
					obj72 = obj87;
					if (obj87 == null)
					{
						goto IL_25bb;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v65+18]");
				object obj88 = 0 & 0xFFFFFFFEL;
				if (obj88 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v65+28]");
					long num74 = 0 & binaryRepresentation;
					long num75 = num74 & 0x2000;
					bool flag70 = num75 == 0;
					object obj89 = !flag70;
					if (obj89 != null)
					{
						goto IL_26ff;
					}
					long num76 = num74 & 0x4000;
					bool flag71 = num76 == 0;
					object obj90 = !flag71;
					if (obj90 != null)
					{
						goto IL_2716;
					}
					long num77 = num74 & 0x8000;
					bool flag72 = num77 == 0;
					object obj91 = !flag72;
					if (obj91 != null)
					{
						goto IL_272d;
					}
					long num78 = num74 & 0x10000;
					bool flag73 = num78 == 0;
					object obj92 = !flag73;
					if (obj92 != null)
					{
						goto IL_2744;
					}
					long num79 = num74 & 0x20000;
					bool flag74 = num79 == 0;
					object obj93 = !flag74;
					if (obj93 != null)
					{
						goto IL_275b;
					}
					long num80 = num74 & 0x40000;
					bool flag75 = num80 == 0;
					object obj94 = !flag75;
					if (obj94 != null)
					{
						goto IL_2772;
					}
					long num81 = num74 & 0x80000;
					bool flag76 = num81 == 0;
					object obj95 = !flag76;
					if (obj95 != null)
					{
						goto IL_2789;
					}
					long num82 = num74 & 0x100000;
					bool flag77 = num82 == 0;
					object obj96 = !flag77;
					if (obj96 != null)
					{
						goto IL_27a0;
					}
					long num83 = num74 & 0x200000;
					bool flag78 = num83 == 0;
					object obj97 = !flag78;
					if (obj97 != null)
					{
						goto IL_27b7;
					}
					long num84 = num74 & 0x400000;
					bool flag79 = num84 == 0;
					object obj98 = !flag79;
					if (obj98 != null)
					{
						goto IL_27ce;
					}
					long num85 = num74 & 0x800000;
					bool flag80 = num85 == 0;
					object obj99 = !flag80;
					if (obj99 != null)
					{
						goto IL_27e5;
					}
					long num86 = num74 & 0x1000000;
					bool flag81 = num86 == 0;
					object obj100 = !flag81;
					if (obj100 != null)
					{
						goto IL_27fc;
					}
					long num87 = num74 & 0x2000000;
					bool flag82 = num87 == 0;
					object obj101 = !flag82;
					if (obj101 != null)
					{
						goto IL_2813;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v71+E4]");
					bool flag83 = (nint)0 == 0;
					object obj102 = !flag83;
					if (obj102 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj70 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v71+B8]");
						object obj103 = 0;
						obj72 = obj103;
						if (obj103 == null)
						{
							goto IL_25bb;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v65+18]");
					bool flag84 = (nint)0 < (nint)3;
					object obj104 = !flag84;
					object obj105 = ~obj104;
					if (obj105 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v65+30]");
						long num88 = 0 & binaryRepresentation;
						long num89 = num88 & 0x4000000;
						bool flag85 = num89 == 0;
						object obj106 = !flag85;
						if (obj106 != null)
						{
							goto IL_282a;
						}
						long num90 = num88 & 0x8000000;
						bool flag86 = num90 == 0;
						object obj107 = !flag86;
						if (obj107 != null)
						{
							goto IL_2841;
						}
						long num91 = num88 & 0x10000000;
						bool flag87 = num91 == 0;
						object obj108 = !flag87;
						if (obj108 != null)
						{
							goto IL_2858;
						}
						long num92 = num88 & 0x20000000;
						bool flag88 = num92 == 0;
						object obj109 = !flag88;
						if (obj109 != null)
						{
							goto IL_286f;
						}
						long num93 = num88 & 0x40000000;
						bool flag89 = num93 == 0;
						object obj110 = !flag89;
						if (obj110 != null)
						{
							goto IL_2886;
						}
						long num94 = num88 & 0x80000000L;
						bool flag90 = num94 == 0;
						object obj111 = !flag90;
						if (obj111 != null)
						{
							goto IL_289d;
						}
						long num95 = num88 & 0x100000000L;
						bool flag91 = num95 == 0;
						object obj112 = !flag91;
						if (obj112 != null)
						{
							goto IL_28b4;
						}
						long num96 = num88 & 0x200000000L;
						bool flag92 = num96 == 0;
						object obj113 = !flag92;
						if (obj113 != null)
						{
							goto IL_28cb;
						}
						long num97 = num88 & 0x400000000L;
						bool flag93 = num97 == 0;
						object obj114 = !flag93;
						if (obj114 != null)
						{
							goto IL_28e2;
						}
						long num98 = num88 & 0x800000000L;
						bool flag94 = num98 == 0;
						object obj115 = !flag94;
						if (obj115 != null)
						{
							goto IL_28f9;
						}
						long num99 = num88 & 0x1000000000L;
						bool flag95 = num99 == 0;
						object obj116 = !flag95;
						if (obj116 != null)
						{
							goto IL_2910;
						}
						long num100 = num88 & 0x2000000000L;
						bool flag96 = num100 == 0;
						object obj117 = !flag96;
						if (obj117 != null)
						{
							goto IL_2927;
						}
						long num101 = num88 & 0x4000000000L;
						bool flag97 = num101 == 0;
						object obj118 = !flag97;
						if (obj118 != null)
						{
							goto IL_293e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v71+E4]");
						bool flag98 = (nint)0 == 0;
						object obj119 = !flag98;
						if (obj119 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj120 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1734 @ X8_v68+B8]");
							object obj121 = 0;
							obj72 = obj121;
							if (obj121 == null)
							{
								goto IL_25bb;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v65+18]");
						object obj122 = 0 & 0xFFFFFFFCL;
						if (obj122 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v65+38]");
							long num102 = 0 & binaryRepresentation;
							long num103 = num102 & 0x8000000000L;
							bool flag99 = num103 == 0;
							object obj123 = !flag99;
							if (obj123 != null)
							{
								goto IL_2955;
							}
							long num104 = num102 & 0x10000000000L;
							bool flag100 = num104 == 0;
							object obj124 = !flag100;
							if (obj124 != null)
							{
								goto IL_2963;
							}
							long num105 = num102 & 0x20000000000L;
							bool flag101 = num105 == 0;
							object obj125 = !flag101;
							if (obj125 != null)
							{
								goto IL_2971;
							}
							long num106 = num102 & 0x40000000000L;
							bool flag102 = num106 == 0;
							object obj126 = !flag102;
							if (obj126 != null)
							{
								goto IL_297f;
							}
							long num107 = num102 & 0x80000000000L;
							bool flag103 = num107 == 0;
							object obj127 = !flag103;
							if (obj127 != null)
							{
								goto IL_2996;
							}
							long num108 = num102 & 0x100000000000L;
							bool flag104 = num108 == 0;
							object obj128 = !flag104;
							if (obj128 != null)
							{
								goto IL_29a4;
							}
							long num109 = num102 & 0x200000000000L;
							bool flag105 = num109 == 0;
							object obj129 = !flag105;
							if (obj129 != null)
							{
								goto IL_29b2;
							}
							long num110 = num102 & 0x400000000000L;
							bool flag106 = num110 == 0;
							object obj130 = !flag106;
							if (obj130 != null)
							{
								goto IL_29c0;
							}
							long num111 = num102 & 0x800000000000L;
							bool flag107 = num111 == 0;
							object obj131 = !flag107;
							if (obj131 != null)
							{
								goto IL_29ce;
							}
							long num112 = num102 & 0x1000000000000L;
							bool flag108 = num112 == 0;
							object obj132 = !flag108;
							if (obj132 != null)
							{
								goto IL_29dc;
							}
							long num113 = num102 & 0x2000000000000L;
							bool flag109 = num113 == 0;
							object obj133 = !flag109;
							if (obj133 != null)
							{
								goto IL_29ea;
							}
							long num114 = num102 & 0x4000000000000L;
							bool flag110 = num114 == 0;
							object obj134 = !flag110;
							if (obj134 == null)
							{
								long num115 = num102 & 0x8000000000000L;
								if (num115 == 0)
								{
									goto IL_179b;
								}
								goto IL_25ad;
							}
							goto IL_29f8;
						}
					}
				}
			}
		}
		goto IL_25c9;
		IL_2716:
		Rank rank3 = Rank.THREE;
		Suit suit2 = Suit.HEARTS;
		goto IL_2b41;
		IL_268c:
		rank3 = Rank.TEN;
		suit2 = Suit.SPADES;
		goto IL_2b41;
		IL_2841:
		rank3 = Rank.THREE;
		suit2 = Suit.CLUBS;
		goto IL_2b41;
		IL_2910:
		rank3 = Rank.QUEEN;
		suit2 = Suit.CLUBS;
		goto IL_2b41;
		IL_27b7:
		rank3 = Rank.TEN;
		suit2 = Suit.HEARTS;
		goto IL_2b41;
		IL_2927:
		rank3 = Rank.KING;
		suit2 = Suit.CLUBS;
		goto IL_2b41;
		IL_2858:
		rank3 = Rank.FOUR;
		suit2 = Suit.CLUBS;
		goto IL_2b41;
		IL_293e:
		rank3 = Rank.ACE;
		suit2 = Suit.CLUBS;
		goto IL_2b41;
		IL_27fc:
		rank3 = Rank.KING;
		suit2 = Suit.HEARTS;
		goto IL_2b41;
		IL_286f:
		rank3 = Rank.FIVE;
		suit2 = Suit.CLUBS;
		goto IL_2b41;
		IL_2955:
		rank3 = Rank.TWO;
		goto IL_2b33;
		IL_27a0:
		rank3 = Rank.NINE;
		suit2 = Suit.HEARTS;
		goto IL_2b41;
		IL_2963:
		rank3 = Rank.THREE;
		goto IL_2b33;
		IL_2886:
		rank3 = Rank.SIX;
		suit2 = Suit.CLUBS;
		goto IL_2b41;
		IL_2971:
		rank3 = Rank.FOUR;
		goto IL_2b33;
		IL_2813:
		rank3 = Rank.ACE;
		suit2 = Suit.HEARTS;
		goto IL_2b41;
		IL_297f:
		rank3 = Rank.FIVE;
		suit2 = Suit.DIAMONDS;
		goto IL_2b41;
		IL_2996:
		rank3 = Rank.SIX;
		goto IL_2b33;
		IL_289d:
		rank3 = Rank.SEVEN;
		suit2 = Suit.CLUBS;
		goto IL_2b41;
		IL_27ce:
		rank3 = Rank.JACK;
		suit2 = Suit.HEARTS;
		goto IL_2b41;
		IL_29a4:
		rank3 = Rank.SEVEN;
		goto IL_2b33;
		IL_28b4:
		rank3 = Rank.EIGHT;
		suit2 = Suit.CLUBS;
		goto IL_2b41;
		IL_29b2:
		rank3 = Rank.EIGHT;
		goto IL_2b33;
		IL_2789:
		rank3 = Rank.EIGHT;
		suit2 = Suit.HEARTS;
		goto IL_2b41;
		IL_29c0:
		rank3 = Rank.NINE;
		goto IL_2b33;
		IL_28cb:
		rank3 = Rank.NINE;
		suit2 = Suit.CLUBS;
		goto IL_2b41;
		IL_29ce:
		rank3 = Rank.TEN;
		goto IL_2b33;
		IL_282a:
		rank3 = Rank.TWO;
		suit2 = Suit.CLUBS;
		goto IL_2b41;
		IL_29dc:
		rank3 = Rank.JACK;
		goto IL_2b33;
		IL_28e2:
		rank3 = Rank.TEN;
		suit2 = Suit.CLUBS;
		goto IL_2b41;
		IL_29ea:
		rank3 = Rank.QUEEN;
		goto IL_2b33;
		IL_27e5:
		rank3 = Rank.QUEEN;
		suit2 = Suit.HEARTS;
		goto IL_2b41;
		IL_29f8:
		rank3 = Rank.KING;
		goto IL_2b33;
		IL_25ad:
		rank3 = Rank.ACE;
		goto IL_2b33;
		IL_28f9:
		rank3 = Rank.JACK;
		suit2 = Suit.CLUBS;
		goto IL_2b41;
		IL_2b33:
		suit2 = Suit.DIAMONDS;
		goto IL_2b41;
		IL_2b41:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card2 = default(Card);
		card2..ctor(rank3, suit2);
		return (List<Card>)(object)new NullReferenceException();
		IL_2619:
		rank3 = Rank.FIVE;
		suit2 = Suit.SPADES;
		goto IL_2b41;
		IL_2630:
		rank3 = Rank.SIX;
		suit2 = Suit.SPADES;
		goto IL_2b41;
		IL_26d1:
		rank3 = Rank.KING;
		suit2 = Suit.SPADES;
		goto IL_2b41;
		IL_275b:
		rank3 = Rank.SIX;
		suit2 = Suit.HEARTS;
		goto IL_2b41;
		IL_26ff:
		rank3 = Rank.TWO;
		suit2 = Suit.HEARTS;
		goto IL_2b41;
		IL_26a3:
		rank3 = Rank.JACK;
		suit2 = Suit.SPADES;
		goto IL_2b41;
		IL_179b:
		return (List<Card>)(object)list;
		IL_2675:
		rank3 = Rank.NINE;
		suit2 = Suit.SPADES;
		goto IL_2b41;
		IL_25c9:
		throw new IndexOutOfRangeException();
		IL_25bb:
		NullReferenceException ex = new NullReferenceException();
		goto IL_25c9;
		IL_2772:
		rank3 = Rank.SEVEN;
		suit2 = Suit.HEARTS;
		goto IL_2b41;
		IL_02d3:
		List<object> list3 = (List<object>)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1133 @ X0_v96 (System.Collections.Generic.List`1<System.Object>)+E4]");
		bool flag111 = (nint)0 == 0;
		object obj135 = !flag111;
		if (obj135 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			list3 = (List<object>)obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1133 @ X0_v96 (System.Collections.Generic.List`1<System.Object>)+B8]");
		object obj136 = 0;
		object obj137 = obj136;
		if (obj136 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v91+18]");
			object[] array2 = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v91+18]");
			object obj138 = 0 & 0xFFFFFFFEL;
			if (obj138 == null)
			{
				goto IL_25c9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v91+28]");
			long num116 = 0 & binaryRepresentation;
			long num117 = num116 >> 13;
			Rank rank4 = Rank.TWO;
			Card card3 = default(Card);
			while (true)
			{
				long num118 = num117 >> (int)rank4;
				long num119 = num118 & 1;
				if (num119 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					card3..ctor(rank4, Suit.HEARTS);
					object obj139 = obj8;
					int version2 = list._version + 1;
					list._version = version2;
					array2 = list._items;
					bool flag112 = list._items == null;
					object obj10 = 0;
					Suit suit = Suit.HEARTS;
					rank = rank4;
					if (flag112)
					{
						break;
					}
					bool flag113 = list._size < array2.Length;
					object obj140 = !flag113;
					object obj141 = ~obj140;
					if (obj141 != null)
					{
						int size2 = list._size + 1;
						list._size = size2;
						object obj142 = list._items + list._size;
						object obj143 = obj142 + 32;
						obj143 = card3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj10 = 0;
						suit = Suit.HEARTS;
						rank = (Rank)card3;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v96+20]");
						object obj144 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ X8_v97+C0]");
						object obj145 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1174 @ X8_v98+70]");
						suit = Suit.SPADES;
						list.AddWithResize((object)card3);
						obj10 = 0;
						rank = (Rank)card3;
					}
				}
				rank4++;
				if (rank4 != Rank.NONE)
				{
					continue;
				}
				goto IL_0591;
			}
		}
		goto IL_25bb;
		IL_25d4:
		rank3 = Rank.TWO;
		suit2 = Suit.SPADES;
		goto IL_2b41;
		IL_2744:
		rank3 = Rank.FIVE;
		suit2 = Suit.HEARTS;
		goto IL_2b41;
		IL_25eb:
		rank3 = Rank.THREE;
		suit2 = Suit.SPADES;
		goto IL_2b41;
		IL_26ba:
		rank3 = Rank.QUEEN;
		suit2 = Suit.SPADES;
		goto IL_2b41;
		IL_2602:
		rank3 = Rank.FOUR;
		suit2 = Suit.SPADES;
		goto IL_2b41;
		IL_265e:
		rank3 = Rank.EIGHT;
		suit2 = Suit.SPADES;
		goto IL_2b41;
		IL_2647:
		rank3 = Rank.SEVEN;
		suit2 = Suit.SPADES;
		goto IL_2b41;
		IL_0851:
		List<object> list4 = (List<object>)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1337 @ X0_v116 (System.Collections.Generic.List`1<System.Object>)+E4]");
		bool flag114 = (nint)0 == 0;
		object obj146 = !flag114;
		if (obj146 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			list4 = (List<object>)obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1337 @ X0_v116 (System.Collections.Generic.List`1<System.Object>)+B8]");
		object obj147 = 0;
		object obj148 = obj147;
		if (obj147 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v115+18]");
			object[] array3 = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v115+18]");
			object obj149 = 0 & 0xFFFFFFFCL;
			if (obj149 == null)
			{
				goto IL_25c9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v115+38]");
			long num120 = 0 & binaryRepresentation;
			long num121 = num120 >> 39;
			Rank rank5 = Rank.TWO;
			Card card4 = default(Card);
			while (true)
			{
				long num122 = num121 >> (int)rank5;
				long num123 = num122 & 1;
				if (num123 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					card4..ctor(rank5, Suit.DIAMONDS);
					object obj150 = obj8;
					int version3 = list._version + 1;
					list._version = version3;
					array3 = list._items;
					bool flag115 = list._items == null;
					object obj10 = 0;
					Suit suit = Suit.DIAMONDS;
					rank = rank5;
					if (flag115)
					{
						break;
					}
					bool flag116 = list._size < array3.Length;
					object obj151 = !flag116;
					object obj152 = ~obj151;
					if (obj152 != null)
					{
						int size3 = list._size + 1;
						list._size = size3;
						object obj153 = list._items + list._size;
						object obj154 = obj153 + 32;
						obj154 = card4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj10 = 0;
						suit = Suit.DIAMONDS;
						rank = (Rank)card4;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v120+20]");
						object obj155 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1419 @ X8_v121+C0]");
						object obj156 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1380 @ X8_v122+70]");
						suit = Suit.SPADES;
						list.AddWithResize((object)card4);
						obj10 = 0;
						rank = (Rank)card4;
					}
				}
				rank5++;
				if (rank5 != Rank.NONE)
				{
					continue;
				}
				goto IL_179b;
			}
		}
		goto IL_25bb;
		IL_26e8:
		rank3 = Rank.ACE;
		suit2 = Suit.SPADES;
		goto IL_2b41;
		IL_272d:
		rank3 = Rank.FOUR;
		suit2 = Suit.HEARTS;
		goto IL_2b41;
		IL_0591:
		List<object> list5 = (List<object>)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1227 @ X0_v106 (System.Collections.Generic.List`1<System.Object>)+E4]");
		bool flag117 = (nint)0 == 0;
		object obj157 = !flag117;
		if (obj157 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			list5 = (List<object>)obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1227 @ X0_v106 (System.Collections.Generic.List`1<System.Object>)+B8]");
		object obj158 = 0;
		object obj159 = obj158;
		if (obj158 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v103+18]");
			object[] array4 = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v103+18]");
			bool flag118 = (nint)0 < (nint)3;
			object obj160 = !flag118;
			object obj152 = ~obj160;
			if (obj152 != null)
			{
				goto IL_25c9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v103+30]");
			long num124 = 0 & binaryRepresentation;
			long num125 = num124 >> 26;
			Rank rank6 = Rank.TWO;
			Card card5 = default(Card);
			while (true)
			{
				long num126 = num125 >> (int)rank6;
				long num127 = num126 & 1;
				if (num127 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					card5..ctor(rank6, Suit.CLUBS);
					object obj161 = obj8;
					int version4 = list._version + 1;
					list._version = version4;
					array4 = list._items;
					bool flag119 = list._items == null;
					object obj10 = 0;
					Suit suit = Suit.CLUBS;
					rank = rank6;
					if (flag119)
					{
						break;
					}
					bool flag120 = list._size < array4.Length;
					object obj162 = !flag120;
					obj152 = ~obj162;
					if (obj152 != null)
					{
						int size4 = list._size + 1;
						list._size = size4;
						object obj163 = list._items + list._size;
						object obj164 = obj163 + 32;
						obj164 = card5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj10 = 0;
						suit = Suit.CLUBS;
						rank = (Rank)card5;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v108+20]");
						object obj165 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ X8_v109+C0]");
						object obj166 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ X8_v110+70]");
						suit = Suit.SPADES;
						list.AddWithResize((object)card5);
						obj10 = 0;
						rank = (Rank)card5;
					}
				}
				rank6++;
				if (rank6 != Rank.NONE)
				{
					continue;
				}
				goto IL_0851;
			}
		}
		goto IL_25bb;
	}

	public static long EncodeBinaryLongCards(IEnumerable<Card> cards)
	{
		//IL_011c: Expected O, but got I4
		//IL_01ae: Expected O, but got I
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01d2: Expected O, but got I
		//IL_01e2: Expected O, but got I
		//IL_0204: Expected O, but got I4
		//IL_004c: Expected O, but got I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0154: Expected O, but got I
		//IL_0165: Expected I, but got O
		//IL_0183: Expected O, but got I
		//IL_007c: Expected O, but got I
		object typeFromHandle = typeof(<>c);
		object obj = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj = typeFromHandle;
		}
		object obj3 = (nint)0 + (nint)2984;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+8]");
		Func<object, int> selector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+8]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = typeFromHandle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v13+B8]");
				obj5 = 0;
			}
			object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)2656;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj5, (IntPtr)obj10);
			object obj11 = typeFromHandle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v12+B8]");
			object obj12 = (nint)0 + (nint)8;
			obj12 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<int> cards2 = Enumerable.Select(cards, selector);
		object obj13 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			return EncodeBinaryLongCards(cards2);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return EncodeBinaryLongCards(cards2);
	}

	public static long EncodeBinaryLongCards(IEnumerable<int> cards)
	{
		//IL_0009: Expected O, but got I4
		//IL_002d: Expected O, but got I
		//IL_0118: Expected O, but got I4
		//IL_008b: Expected O, but got I
		//IL_009b: Expected O, but got I
		//IL_00ab: Expected O, but got I
		//IL_00cd: Expected O, but got I4
		//IL_014c: Expected O, but got I
		//IL_015c: Expected O, but got I
		//IL_016c: Expected O, but got I
		//IL_018e: Expected O, but got I4
		//IL_01c6: Expected O, but got I4
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0234: Expected O, but got I
		//IL_0245: Expected I, but got O
		//IL_0263: Expected O, but got I
		//IL_01f6: Expected O, but got I
		object obj = 152993792;
		object typeFromHandle = typeof(<>c);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AFE]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			obj3 = typeFromHandle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeFromHandle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = typeFromHandle;
		object obj6 = (nint)0 + (nint)1792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v4+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v4+10]");
		Func<long, int, long> func = (Func<long, int, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v4+10]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		object obj9 = obj6;
		if (obj8 == null)
		{
			goto IL_01a4;
		}
		goto IL_01fb;
		IL_01a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = typeFromHandle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v10+B8]");
			obj7 = 0;
		}
		object obj12 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)2664;
		Func<long, int, long> func2 = default(Func<long, int, long>);
		func2..ctor(obj7, (IntPtr)obj13);
		object obj14 = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v9+B8]");
		object obj15 = (nint)0 + (nint)16;
		obj15 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj9 = obj6;
		func = func2;
		goto IL_01fb;
		IL_01fb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D75AD0");
		long result = default(long);
		return result;
		IL_007f:
		obj9 = (nint)0 + (nint)1792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v4+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v4+10]");
		func = (Func<long, int, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v4+10]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			obj6 = obj9;
			goto IL_01a4;
		}
		goto IL_01fb;
	}

	public static List<int> DecodeCardNumbers(long binaryRepresentation)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0e94: Expected I4, but got O
		//IL_0ad7: Expected O, but got I
		//IL_005b: Expected O, but got I4
		//IL_090f: Expected O, but got I
		//IL_0ed2: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_0b5e: Expected O, but got I4
		//IL_0996: Expected O, but got I4
		//IL_00c1: Expected O, but got I
		//IL_0b8e: Expected O, but got I4
		//IL_0bfd: Expected O, but got I8
		//IL_0bbe: Expected O, but got I
		//IL_028e: Expected O, but got I4
		//IL_01af: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_0c57: Expected O, but got I4
		//IL_0a06: Expected O, but got I4
		//IL_0f07: Expected O, but got I
		//IL_0214: Expected O, but got I4
		//IL_0c87: Expected O, but got I4
		//IL_02c3: Expected O, but got I
		//IL_02dd: Expected O, but got I8
		//IL_00f4: Expected O, but got I
		//IL_0104: Expected O, but got I
		//IL_0114: Expected O, but got I
		//IL_0cfe: Expected O, but got I4
		//IL_0238: Expected O, but got I
		//IL_025a: Expected O, but got I
		//IL_0cb7: Expected O, but got I
		//IL_0a7a: Expected O, but got I4
		//IL_0326: Expected O, but got I4
		//IL_0d56: Expected O, but got I4
		//IL_0f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3a: Expected O, but got Unknown
		//IL_0d86: Expected O, but got I4
		//IL_0e53: Expected O, but got I4
		//IL_04c7: Expected O, but got I4
		//IL_03d1: Expected O, but got I
		//IL_03e6: Expected O, but got I
		//IL_0df5: Expected O, but got I8
		//IL_0f67: Expected O, but got I
		//IL_0db6: Expected O, but got I
		//IL_0436: Expected O, but got I4
		//IL_04fc: Expected O, but got I
		//IL_051e: Expected O, but got I4
		//IL_0341: Expected O, but got I
		//IL_0363: Expected O, but got I
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_045d: Expected O, but got I
		//IL_046d: Expected O, but got I
		//IL_047d: Expected O, but got I
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected I4, but got Unknown
		//IL_0561: Expected O, but got I4
		//IL_0f95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9a: Expected O, but got Unknown
		//IL_0702: Expected O, but got I4
		//IL_060c: Expected O, but got I
		//IL_0621: Expected O, but got I
		//IL_0fc7: Expected O, but got I
		//IL_0671: Expected O, but got I4
		//IL_0737: Expected O, but got I
		//IL_0751: Expected O, but got I8
		//IL_057c: Expected O, but got I
		//IL_059e: Expected O, but got I
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_0698: Expected O, but got I
		//IL_06a8: Expected O, but got I
		//IL_06b8: Expected O, but got I
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected I4, but got Unknown
		//IL_079a: Expected O, but got I4
		//IL_0ff5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffa: Expected O, but got Unknown
		//IL_083e: Expected O, but got I
		//IL_0853: Expected O, but got I
		//IL_08a1: Expected O, but got I4
		//IL_07b5: Expected O, but got I
		//IL_07d7: Expected O, but got I
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected O, but got Unknown
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c8: Expected I4, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1800;
		object obj2 = (nint)0 + (nint)1312;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		int num = (int)obj2;
		List<int> list = default(List<int>);
		list..ctor();
		List<int> list2 = (List<int>)obj3;
		object obj8;
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v25 (System.Collections.Generic.List`1<System.Int32>)+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				list2 = (List<int>)obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v25 (System.Collections.Generic.List`1<System.Int32>)+B8]");
			object obj5 = 0;
			object obj6 = obj5;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v25+18]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v25+18]");
				if ((nint)0 == 0)
				{
					goto IL_0e74;
				}
				obj8 = (nint)0 + (nint)1336;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v25+20]");
				long num2 = 0 & binaryRepresentation;
				int num3 = 0;
				while (true)
				{
					long num4 = num2 >> num3;
					long num5 = num4 & 1;
					if (num5 != 0)
					{
						object obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj10 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X9_v24+18]");
						bool flag2 = num6 < 0;
						object obj11 = !flag2;
						if (obj11 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v29+20]");
							object obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v32+C0]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v33+70]");
							object obj14 = 0;
							list.AddWithResize(num3);
							num = num3;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj15 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj16 = num7 + 0;
						}
					}
					num3++;
					if (num3 != 13)
					{
						continue;
					}
					goto IL_0264;
				}
			}
			goto IL_0e66;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v25 (System.Collections.Generic.List`1<System.Int32>)+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v25 (System.Collections.Generic.List`1<System.Int32>)+B8]");
			object obj17 = 0;
			object obj18 = obj17;
			if (obj17 == null)
			{
				goto IL_0e66;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+20]");
				long num8 = 0 & binaryRepresentation;
				long num9 = num8 & 0x1FFF;
				bool flag3 = num9 == 0;
				object obj19 = !flag3;
				if (obj19 != null)
				{
					goto IL_0e66;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+18]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+28]");
					long num10 = 0 & binaryRepresentation;
					long num11 = num10 & 0x3FFE000;
					bool flag4 = num11 == 0;
					object obj20 = !flag4;
					if (obj20 != null)
					{
						goto IL_0e66;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+18]");
					if ((nint)0 != 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+30]");
						long num12 = 0 & binaryRepresentation;
						long num13 = num12 & 0x7FFC000000L;
						bool flag5 = num13 == 0;
						object obj21 = !flag5;
						if (obj21 != null)
						{
							goto IL_0e66;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+18]");
						if ((nint)0 != 3)
						{
							goto IL_0e12;
						}
					}
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj22 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v15+B8]");
			object obj23 = 0;
			object obj18 = obj23;
			if (obj23 == null)
			{
				goto IL_0e66;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+20]");
				long num14 = 0 & binaryRepresentation;
				long num15 = num14 & 0x1FFF;
				bool flag6 = num15 == 0;
				object obj24 = !flag6;
				if (obj24 != null)
				{
					goto IL_0e66;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v15+E4]");
				bool flag7 = (nint)0 == 0;
				object obj25 = !flag7;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj22 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v15+B8]");
					object obj26 = 0;
					obj18 = obj26;
					if (obj26 == null)
					{
						goto IL_0e66;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+18]");
				object obj27 = 0 & 0xFFFFFFFEL;
				if (obj27 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+28]");
					long num16 = 0 & binaryRepresentation;
					long num17 = num16 & 0x3FFE000;
					bool flag8 = num17 == 0;
					object obj28 = !flag8;
					if (obj28 != null)
					{
						goto IL_0e66;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v15+E4]");
					bool flag9 = (nint)0 == 0;
					object obj29 = !flag9;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj22 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v15+B8]");
						object obj30 = 0;
						obj18 = obj30;
						if (obj30 == null)
						{
							goto IL_0e66;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+18]");
					bool flag10 = (nint)0 < (nint)3;
					object obj31 = !flag10;
					object obj32 = ~obj31;
					if (obj32 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+30]");
						long num18 = 0 & binaryRepresentation;
						long num19 = num18 & 0x7FFC000000L;
						bool flag11 = num19 == 0;
						object obj33 = !flag11;
						if (obj33 != null)
						{
							goto IL_0e66;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v15+E4]");
						bool flag12 = (nint)0 == 0;
						object obj34 = !flag12;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj35 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v15+B8]");
							object obj36 = 0;
							obj18 = obj36;
							if (obj36 == null)
							{
								goto IL_0e66;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+18]");
						object obj37 = 0 & 0xFFFFFFFCL;
						if (obj37 != null)
						{
							goto IL_0e12;
						}
					}
				}
			}
		}
		goto IL_0e74;
		IL_0264:
		List<int> list3 = (List<int>)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X0_v29 (System.Collections.Generic.List`1<System.Int32>)+E4]");
		bool flag13 = (nint)0 == 0;
		object obj38 = !flag13;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			list3 = (List<int>)obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X0_v29 (System.Collections.Generic.List`1<System.Int32>)+B8]");
		object obj39 = 0;
		object obj40 = obj39;
		if (obj39 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v37+18]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v37+18]");
			object obj42 = 0 & 0xFFFFFFFEL;
			if (obj42 == null)
			{
				goto IL_0e74;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v37+28]");
			long num20 = 0 & binaryRepresentation;
			long num21 = num20 >> 13;
			object obj43 = 0;
			while (true)
			{
				long num22 = num21 >> (int)obj43;
				long num23 = num22 & 1;
				if (num23 != 0)
				{
					object obj44 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj45 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					obj41 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X9_v27+18]");
					bool flag14 = num24 < 0;
					object obj46 = !flag14;
					object obj47 = ~obj46;
					if (obj47 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj48 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						nint num25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj49 = num25 + 0;
						obj41 = obj43 + 13;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v69+20]");
						object obj50 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v70+C0]");
						object obj51 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v71+70]");
						object obj14 = 0;
						num = obj43 + 13;
						list.AddWithResize(num);
					}
				}
				obj43++;
				if ((nint)obj43 != 13)
				{
					continue;
				}
				goto IL_049d;
			}
		}
		goto IL_0e66;
		IL_0e61:
		return list;
		IL_0e12:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+38]");
		long num26 = 0 & binaryRepresentation;
		long num27 = num26 & 0xFFF8000000000L;
		bool flag15 = num27 == 0;
		object obj52 = !flag15;
		if (obj52 == null)
		{
			goto IL_0e61;
		}
		goto IL_0e66;
		IL_0e74:
		return (List<int>)(object)new IndexOutOfRangeException();
		IL_0e66:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0e74;
		IL_06d8:
		List<int> list4 = (List<int>)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v37 (System.Collections.Generic.List`1<System.Int32>)+E4]");
		bool flag16 = (nint)0 == 0;
		object obj53 = !flag16;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			list4 = (List<int>)obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v37 (System.Collections.Generic.List`1<System.Int32>)+B8]");
		object obj54 = 0;
		object obj55 = obj54;
		if (obj54 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v53+18]");
			object obj56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v53+18]");
			object obj57 = 0 & 0xFFFFFFFCL;
			if (obj57 == null)
			{
				goto IL_0e74;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v53+38]");
			long num28 = 0 & binaryRepresentation;
			long num29 = num28 >> 39;
			object obj58 = 0;
			while (true)
			{
				long num30 = num29 >> (int)obj58;
				long num31 = num30 & 1;
				if (num31 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj59 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					obj56 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X9_v33+18]");
					bool flag17 = num32 < 0;
					object obj60 = !flag17;
					object obj61 = ~obj60;
					if (obj61 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj62 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						nint num33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj63 = num33 + 0;
						obj56 = obj58 + 39;
					}
					else
					{
						num = obj58 + 39;
						list.AddWithResize(num);
					}
				}
				obj58++;
				if ((nint)obj58 != 13)
				{
					continue;
				}
				goto IL_0e61;
			}
		}
		goto IL_0e66;
		IL_049d:
		List<int> list5 = (List<int>)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X0_v33 (System.Collections.Generic.List`1<System.Int32>)+E4]");
		bool flag18 = (nint)0 == 0;
		object obj64 = !flag18;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			list5 = (List<int>)obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X0_v33 (System.Collections.Generic.List`1<System.Int32>)+B8]");
		object obj65 = 0;
		object obj66 = obj65;
		if (obj65 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v45+18]");
			object obj67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v45+18]");
			bool flag19 = (nint)0 < (nint)3;
			object obj68 = !flag19;
			object obj61 = ~obj68;
			if (obj61 != null)
			{
				goto IL_0e74;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v45+30]");
			long num34 = 0 & binaryRepresentation;
			long num35 = num34 >> 26;
			object obj69 = 0;
			while (true)
			{
				long num36 = num35 >> (int)obj69;
				long num37 = num36 & 1;
				if (num37 != 0)
				{
					object obj70 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj71 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					obj67 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X9_v30+18]");
					bool flag20 = num38 < 0;
					object obj72 = !flag20;
					obj61 = ~obj72;
					if (obj61 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj73 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						nint num39 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj74 = num39 + 0;
						obj67 = obj69 + 26;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v64+20]");
						object obj75 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v65+C0]");
						object obj76 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v66+70]");
						object obj14 = 0;
						num = obj69 + 26;
						list.AddWithResize(num);
					}
				}
				obj69++;
				if ((nint)obj69 != 13)
				{
					continue;
				}
				goto IL_06d8;
			}
		}
		goto IL_0e66;
	}

	public static int OriginalCardOrder(Card card1, Card card2)
	{
		//IL_00de: Expected I4, but got O
		if (card1 != null)
		{
			int num = card1.AsInt();
			if (card2 != null)
			{
				int num2 = card2.AsInt();
				if (num > num2)
				{
					return 1;
				}
				int num3 = card1.AsInt();
				int num4 = card2.AsInt();
				if (num3 >= num4)
				{
					return 0;
				}
				return -1;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private static int SuitComparison(Card card1, Card card2, List<Suit> suitOrder)
	{
		//IL_008c: Expected I4, but got O
		if (card1 != null && suitOrder != null)
		{
			int num = ((List<System.Int32Enum>)(object)suitOrder).IndexOf((System.Int32Enum)card1.<Suit>k__BackingField);
			if (card2 != null)
			{
				int num2 = ((List<System.Int32Enum>)(object)suitOrder).IndexOf((System.Int32Enum)card2.<Suit>k__BackingField);
				return num - num2;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private int ValueComparison(Card card1, Card card2)
	{
		int value = GetValue(card1);
		int value2 = GetValue(card2);
		return value - value2;
	}

	public void SortCards(List<Card> cards, List<Suit> suitOrder)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0096: Expected I, but got O
		object obj = typeof(<>c) + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3280;
		object obj4 = (nint)0 + (nint)2680;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = suitOrder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Comparison<object> comparison = default(Comparison<object>);
		comparison..ctor(obj2, (IntPtr)obj4);
		((List<object>)(object)cards).Sort(comparison);
	}

	public static List<Suit> GetSuitOrder(List<Card> cards)
	{
		//IL_035c: Expected O, but got I4
		//IL_0442: Expected O, but got I
		//IL_0452: Expected O, but got I
		//IL_0474: Expected O, but got I4
		//IL_004c: Expected O, but got I4
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_0394: Expected O, but got I
		//IL_03a5: Expected I, but got O
		//IL_03c3: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_024c: Expected O, but got I4
		//IL_025e: Expected O, but got I4
		//IL_026f: Expected O, but got I4
		//IL_0422: Expected O, but got I
		//IL_042f: Expected O, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01bd: Expected O, but got I4
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02ee: Expected O, but got I4
		//IL_02f7: Expected O, but got I4
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_01eb: Expected O, but got I4
		//IL_0404: Expected O, but got I4
		//IL_01dd: Expected O, but got I4
		//IL_031f: Expected O, but got I4
		object typeFromHandle = typeof(<>c);
		object obj = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj = typeFromHandle;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v21+18]");
		Func<object, System.Int32Enum> selector = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v21+18]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj6 = typeFromHandle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v27+B8]");
				obj3 = 0;
			}
			object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = (nint)0 + (nint)2672;
			Func<object, System.Int32Enum> func = default(Func<object, System.Int32Enum>);
			func..ctor(obj3, (IntPtr)obj8);
			object obj9 = typeFromHandle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v26+B8]");
			object obj10 = (nint)0 + (nint)24;
			obj10 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<System.Int32Enum> source = Enumerable.Select(cards, selector);
		IEnumerable<System.Int32Enum> source2 = Enumerable.Distinct(source);
		List<System.Int32Enum> list = Enumerable.ToList(source2);
		object obj18;
		object obj14;
		object obj16;
		if (list != null)
		{
			object obj11 = (nint)0 + (nint)3968;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v8 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj12;
			if ((nint)0 != 2)
			{
				obj12 = obj11;
				if (!list.Contains((System.Int32Enum)0))
				{
					object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
					obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v10+E4]");
					bool flag4 = (nint)0 == 0;
					object obj15 = !flag4;
					obj16 = 8;
					if (obj15 == null)
					{
						System.Int32Enum int32Enum = (System.Int32Enum)0;
						object obj17 = obj14;
						obj18 = 8;
						goto IL_027d;
					}
					goto IL_0412;
				}
			}
			obj12 = obj11;
			if (list.Contains((System.Int32Enum)2))
			{
				obj12 = obj11;
				bool flag5 = list.Contains((System.Int32Enum)3);
				object obj19 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
				obj14 = obj19;
				bool flag6 = !flag5;
				object obj20 = !flag6;
				object obj21 = ~obj20;
				obj16 = ((obj21 != null) ? ((object)24) : ((object)8));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v10+E4]");
				bool flag7 = (nint)0 == 0;
				object obj22 = !flag7;
				if (obj22 == null)
				{
					System.Int32Enum int32Enum = (System.Int32Enum)3;
					object obj17 = obj14;
					obj18 = obj16;
					goto IL_027d;
				}
			}
			else
			{
				object obj23 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
				object obj17 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v12+E4]");
				bool flag8 = (nint)0 == 0;
				object obj24 = !flag8;
				System.Int32Enum int32Enum = (System.Int32Enum)2;
				obj18 = 16;
				obj14 = obj17;
				obj16 = 16;
				if (obj24 == null)
				{
					goto IL_027d;
				}
			}
			goto IL_0412;
		}
		return (List<Suit>)(object)new NullReferenceException();
		IL_027d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj25 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		obj14 = obj25;
		obj16 = obj18;
		goto IL_0412;
		IL_0412:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v10+B8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v8+v283 @ X19_v3]");
		return (List<Suit>)0;
	}

	public virtual int GetValue(Card card)
	{
		//IL_003d: Expected I4, but got O
		if (card != null)
		{
			return card.AsInt();
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	static CardUtils()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0072: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_0150: Expected O, but got I
		//IL_0160: Expected O, but got I
		//IL_0170: Expected O, but got I
		//IL_0196: Expected O, but got I
		//IL_01ac: Expected O, but got I
		//IL_01df: Expected O, but got I4
		//IL_00f7: Expected O, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_012d: Expected O, but got I
		//IL_013b: Expected O, but got I4
		//IL_0253: Expected O, but got I
		//IL_0263: Expected O, but got I
		//IL_0273: Expected O, but got I
		//IL_0299: Expected O, but got I
		//IL_02af: Expected O, but got I
		//IL_02e2: Expected O, but got I4
		//IL_0203: Expected O, but got I
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0239: Expected O, but got I
		//IL_0356: Expected O, but got I
		//IL_0366: Expected O, but got I
		//IL_0376: Expected O, but got I
		//IL_039c: Expected O, but got I
		//IL_03b2: Expected O, but got I
		//IL_03e5: Expected O, but got I4
		//IL_0306: Expected O, but got I
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_033c: Expected O, but got I
		//IL_043e: Expected O, but got I
		//IL_044e: Expected O, but got I
		//IL_045e: Expected O, but got I
		//IL_048f: Expected O, but got I
		//IL_0409: Expected O, but got I
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_04dc: Expected O, but got I
		//IL_04f1: Expected O, but got I
		//IL_051f: Expected O, but got I4
		//IL_0593: Expected O, but got I
		//IL_05a3: Expected O, but got I
		//IL_05b3: Expected O, but got I
		//IL_05d9: Expected O, but got I
		//IL_05ef: Expected O, but got I
		//IL_0622: Expected O, but got I4
		//IL_0543: Expected O, but got I
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected O, but got Unknown
		//IL_0579: Expected O, but got I
		//IL_0696: Expected O, but got I
		//IL_06a6: Expected O, but got I
		//IL_06b6: Expected O, but got I
		//IL_06dc: Expected O, but got I
		//IL_06f2: Expected O, but got I
		//IL_0725: Expected O, but got I4
		//IL_0646: Expected O, but got I
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected O, but got Unknown
		//IL_067c: Expected O, but got I
		//IL_077e: Expected O, but got I
		//IL_078e: Expected O, but got I
		//IL_079e: Expected O, but got I
		//IL_07cf: Expected O, but got I
		//IL_0749: Expected O, but got I
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected O, but got Unknown
		//IL_081c: Expected O, but got I
		//IL_0831: Expected O, but got I
		//IL_085f: Expected O, but got I4
		//IL_08d3: Expected O, but got I
		//IL_08e3: Expected O, but got I
		//IL_08f3: Expected O, but got I
		//IL_0919: Expected O, but got I
		//IL_092f: Expected O, but got I
		//IL_0962: Expected O, but got I4
		//IL_0883: Expected O, but got I
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Expected O, but got Unknown
		//IL_08b9: Expected O, but got I
		//IL_09d6: Expected O, but got I
		//IL_09e6: Expected O, but got I
		//IL_09f6: Expected O, but got I
		//IL_0a1c: Expected O, but got I
		//IL_0a32: Expected O, but got I
		//IL_0a65: Expected O, but got I4
		//IL_0986: Expected O, but got I
		//IL_099b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected O, but got Unknown
		//IL_09bc: Expected O, but got I
		//IL_0abe: Expected O, but got I
		//IL_0ace: Expected O, but got I
		//IL_0ade: Expected O, but got I
		//IL_0b0f: Expected O, but got I
		//IL_0a89: Expected O, but got I
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa3: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3056;
		object fldHandle = (nint)0 + (nint)1704;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 3760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Array array = default(Array);
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)fldHandle);
		object obj4 = obj2;
		object obj5 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<System.Int32Enum> list = default(List<System.Int32Enum>);
		list..ctor();
		object obj6 = (nint)0 + (nint)3960;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
		object obj8 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X9_v7+18]");
		bool flag = num < 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj11 = (nint)0 + (nint)1;
			object obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj13 = obj12 + 0;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj14 = (nint)0 + (nint)1;
			object obj15 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v8+20]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v51+C0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v52+70]");
			object obj15 = 0;
			list.AddWithResize((System.Int32Enum)1);
			obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj18 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X9_v7+18]");
		bool flag2 = num2 < 0;
		object obj19 = !flag2;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj20 = (nint)0 + (nint)1;
			object obj21 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj22 = obj21 + 0;
			_ = 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj23 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v8+20]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v48+C0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v49+70]");
			object obj15 = 0;
			list.AddWithResize((System.Int32Enum)2);
			obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj26 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X9_v7+18]");
		bool flag3 = num3 < 0;
		object obj27 = !flag3;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj28 = (nint)0 + (nint)1;
			object obj29 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj30 = obj29 + 0;
			_ = 3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj31 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v8+20]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v45+C0]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v46+70]");
			object obj15 = 0;
			list.AddWithResize((System.Int32Enum)3);
			obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj34 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X9_v7+18]");
		bool flag4 = num4 < 0;
		object obj35 = !flag4;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj36 = (nint)0 + (nint)1;
			object obj37 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj38 = obj37 + 0;
			_ = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v8+20]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v41+C0]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v42+70]");
			object obj15 = 0;
			list.AddWithResize((System.Int32Enum)0);
		}
		object obj41 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v10+B8]");
		object obj42 = (nint)0 + (nint)8;
		obj42 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<System.Int32Enum> list2 = default(List<System.Int32Enum>);
		list2..ctor();
		object obj43 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
		object obj44 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X9_v12+18]");
		bool flag5 = num5 < 0;
		object obj46 = !flag5;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj47 = (nint)0 + (nint)1;
			object obj48 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj49 = obj48 + 0;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj50 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v13+20]");
			object obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v38+C0]");
			object obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v39+70]");
			object obj15 = 0;
			list2.AddWithResize((System.Int32Enum)1);
			obj43 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
			obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj53 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X9_v12+18]");
		bool flag6 = num6 < 0;
		object obj54 = !flag6;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj55 = (nint)0 + (nint)1;
			object obj56 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj57 = obj56 + 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj58 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v13+20]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v35+C0]");
			object obj60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v36+70]");
			object obj15 = 0;
			list2.AddWithResize((System.Int32Enum)0);
			obj43 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
			obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj61 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X9_v12+18]");
		bool flag7 = num7 < 0;
		object obj62 = !flag7;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj63 = (nint)0 + (nint)1;
			object obj64 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj65 = obj64 + 0;
			_ = 3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v13+20]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v31+C0]");
			object obj67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v32+70]");
			object obj15 = 0;
			list2.AddWithResize((System.Int32Enum)3);
		}
		object obj68 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v15+B8]");
		object obj69 = (nint)0 + (nint)16;
		obj69 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<System.Int32Enum> list3 = default(List<System.Int32Enum>);
		list3..ctor();
		object obj70 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
		object obj71 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X9_v18+18]");
		bool flag8 = num8 < 0;
		object obj73 = !flag8;
		if (obj73 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj74 = (nint)0 + (nint)1;
			object obj75 = obj72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj76 = obj75 + 0;
			_ = 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj77 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v18+20]");
			object obj78 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v28+C0]");
			object obj79 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v29+70]");
			object obj15 = 0;
			list3.AddWithResize((System.Int32Enum)2);
			obj70 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
			obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj80 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X9_v18+18]");
		bool flag9 = num9 < 0;
		object obj81 = !flag9;
		if (obj81 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj82 = (nint)0 + (nint)1;
			object obj83 = obj72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj84 = obj83 + 0;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj85 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v18+20]");
			object obj86 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v25+C0]");
			object obj87 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v26+70]");
			object obj15 = 0;
			list3.AddWithResize((System.Int32Enum)1);
			obj70 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
			obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj88 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X9_v18+18]");
		bool flag10 = num10 < 0;
		object obj89 = !flag10;
		if (obj89 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj90 = (nint)0 + (nint)1;
			object obj91 = obj72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v26 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj92 = obj91 + 0;
			_ = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v18+20]");
			object obj93 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v21+C0]");
			object obj94 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v22+70]");
			object obj15 = 0;
			list3.AddWithResize((System.Int32Enum)0);
		}
		object obj95 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v20+B8]");
		object obj96 = (nint)0 + (nint)24;
		obj96 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
