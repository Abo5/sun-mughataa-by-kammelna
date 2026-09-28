using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class BalootCardUtils : CardUtils
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Rank, IEnumerable<Suit>> <>9__3_0;

		public static Func<Rank, Suit, Card> <>9__3_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal IEnumerable<Suit> <get_AllBalootCards>b__3_0(Rank rank)
		{
			return SuitMethods.GetAll();
		}

		internal Card <get_AllBalootCards>b__3_1(Rank rank, Suit suit)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			return (Card)obj2;
		}
	}

	private static readonly IEnumerable<Rank> BalootCardRanks;

	public static IEnumerable<Card> AllBalootCards
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a7: Expected O, but got Unknown
			//IL_02d1: Expected O, but got I4
			//IL_00b1: Expected O, but got I
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_038b: Expected O, but got I
			//IL_039b: Expected O, but got I
			//IL_03bd: Expected O, but got I4
			//IL_0311: Expected O, but got I
			//IL_0343: Expected O, but got I4
			//IL_010e: Expected O, but got I
			//IL_011e: Expected O, but got I
			//IL_0405: Expected O, but got I4
			//IL_01c4: Expected O, but got I
			//IL_01d5: Expected O, but got I
			//IL_01e5: Expected O, but got I
			//IL_0207: Expected O, but got I4
			//IL_0592: Unknown result type (might be due to invalid IL or missing references)
			//IL_0597: Expected O, but got Unknown
			//IL_05ad: Expected O, but got I
			//IL_05b5: Expected I, but got O
			//IL_05c6: Expected I, but got O
			//IL_05e4: Expected O, but got I
			//IL_0464: Expected O, but got I4
			//IL_046d: Expected O, but got I4
			//IL_0496: Expected O, but got I4
			//IL_04a6: Expected I, but got O
			//IL_0435: Expected O, but got I
			//IL_0237: Expected O, but got I4
			//IL_051a: Unknown result type (might be due to invalid IL or missing references)
			//IL_051f: Expected O, but got Unknown
			//IL_0535: Expected O, but got I
			//IL_0546: Expected I, but got O
			//IL_0564: Expected O, but got I
			//IL_0267: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1968;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A62]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2576;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v59+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2576;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v59+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v18+B8]");
			object obj10 = 0;
			object obj11 = obj10;
			object obj12 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v45+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			obj4 = obj7;
			object obj14 = obj12;
			object obj15 = obj10;
			if (obj13 != null)
			{
				goto IL_00fe;
			}
			goto IL_0369;
			IL_015b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v45+E4]");
			bool flag4 = (nint)0 == 0;
			object obj17 = default(object);
			object obj16 = obj17;
			Func<System.Int32Enum, object> func2 = default(Func<System.Int32Enum, object>);
			Func<System.Int32Enum, object> func = func2;
			nint num2 = default(nint);
			nint num = num2;
			object obj18 = obj12;
			obj7 = obj4;
			obj15 = obj11;
			Func<System.Int32Enum, object> func4;
			Func<System.Int32Enum, object> func3 = func4;
			if (!flag4)
			{
				goto IL_01b8;
			}
			goto IL_04c4;
			IL_04c4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj7;
			obj17 = obj16;
			func2 = func;
			num2 = num;
			obj4 = obj7;
			obj11 = obj15;
			func4 = func3;
			goto IL_01b8;
			IL_01b8:
			object obj19 = (nint)0 + (nint)424;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v45+B8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v23+10]");
			Func<System.Int32Enum, System.Int32Enum, object> func5 = (Func<System.Int32Enum, System.Int32Enum, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v23+10]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v45+E4]");
				bool flag6 = (nint)0 == 0;
				object obj22 = !flag6;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj23 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v29+B8]");
					obj20 = 0;
				}
				object obj24 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 864;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj25 = (nint)0 + (nint)736;
				Func<System.Int32Enum, System.Int32Enum, object> func6 = default(Func<System.Int32Enum, System.Int32Enum, object>);
				func6..ctor(obj20, (IntPtr)obj25);
				object obj26 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v28+B8]");
				object obj27 = (nint)0 + (nint)16;
				obj27 = func6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				func5 = func6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DDB70C");
			IEnumerable<object> source = default(IEnumerable<object>);
			return (IEnumerable<Card>)Enumerable.ToArray(source);
			IL_00a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v59+B8]");
			object obj28 = 0;
			obj11 = obj28;
			obj12 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v45+E4]");
			bool flag7 = (nint)0 == 0;
			obj14 = obj12;
			obj7 = obj4;
			obj15 = obj28;
			if (!flag7)
			{
				goto IL_00fe;
			}
			goto IL_0369;
			IL_0369:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v45+B8]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v4+8]");
			func4 = (Func<System.Int32Enum, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v4+8]");
			bool flag8 = (nint)0 == 0;
			object obj30 = !flag8;
			obj4 = obj7;
			obj11 = obj15;
			object obj31 = obj12;
			if (obj30 != null)
			{
				goto IL_015b;
			}
			goto IL_03e3;
			IL_00fe:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v45+B8]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v4+8]");
			func4 = (Func<System.Int32Enum, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v4+8]");
			bool flag9 = (nint)0 == 0;
			obj31 = obj12;
			obj7 = obj4;
			obj15 = obj11;
			if (!flag9)
			{
				goto IL_015b;
			}
			goto IL_03e3;
			IL_03e3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v4+E4]");
			bool flag10 = (nint)0 == 0;
			object obj32 = !flag10;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj33 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v11+B8]");
				obj29 = 0;
			}
			object obj34 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj35 = (nint)0 + (nint)728;
			num2 = (nint)obj35;
			Func<System.Int32Enum, object> func7 = default(Func<System.Int32Enum, object>);
			func7..ctor(obj29, (IntPtr)obj35);
			object obj36 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v9+B8]");
			object obj37 = (nint)0 + (nint)8;
			obj37 = func7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj12 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v45+E4]");
			bool flag11 = (nint)0 == 0;
			object obj38 = !flag11;
			obj17 = 0;
			func2 = func7;
			obj4 = obj7;
			obj11 = obj15;
			func4 = func7;
			obj16 = 0;
			func = func7;
			num = (nint)obj35;
			obj18 = obj12;
			func3 = func7;
			if (obj38 != null)
			{
				goto IL_01b8;
			}
			goto IL_04c4;
		}
	}

	public BalootCardUtils(CardGame game)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005d: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		base..ctor(game);
	}

	public static Card RandomBalootCard(List<Card> exclusionList = null)
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_00fc: Expected O, but got I4
		//IL_0054: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1968;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 416;
		if (exclusionList != null && exclusionList._size > 0)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IEnumerable<Card> allBalootCards = AllBalootCards;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor((IEnumerable<object>)allBalootCards);
			IEnumerable<object> source = Enumerable.Except(list, exclusionList);
			List<object> array = Enumerable.ToList(source);
			return (Card)ArraysExtensions.Random(array);
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<Card> allBalootCards2 = AllBalootCards;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor((IEnumerable<object>)allBalootCards2);
		return (Card)ArraysExtensions.Random(list2);
	}

	public override int GetValue(Card card)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_01fc: Expected O, but got I4
		//IL_0205: Expected O, but got I4
		//IL_0112: Expected O, but got I4
		//IL_046e: Expected I4, but got O
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0163: Expected O, but got I4
		//IL_022b: Expected O, but got I4
		//IL_0245: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01b0: Expected O, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected I4, but got Unknown
		//IL_029f: Expected O, but got I
		//IL_0262: Expected O, but got I4
		//IL_02e3: Expected O, but got I8
		UnityEngine.Object game = Game;
		bool flag = (object)Game == null;
		Card card2 = card;
		if (!flag)
		{
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1984;
			card2 = (Card)obj;
			nint num = (nint)game;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v23 (Il2CppClass<UnityEngine.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X1_v2 (Card)+130]");
			bool flag2 = num2 < 0;
			object obj2 = !flag2;
			object obj3 = ~obj2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v23 (Il2CppClass<UnityEngine.Object>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X1_v2 (Card)+130]");
				object obj4 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v25-8]");
				if (0 == (nint)card2)
				{
					goto IL_00ad;
				}
			}
			InvalidCastException ex = new InvalidCastException();
			return (int)ex;
		}
		goto IL_00ad;
		IL_00ad:
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = Game == null;
			bool flag4 = !flag3;
			object obj7 = 0;
			UnityEngine.Object obj8 = null;
			if (!flag4)
			{
				goto IL_0125;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = Game == null;
			bool flag6 = !flag5;
			object obj9 = !flag6;
			object obj7 = 0;
			UnityEngine.Object obj8 = null;
			if (obj9 != null)
			{
				goto IL_0125;
			}
		}
		object obj10 = card.<Rank>k__BackingField - 8;
		bool flag7 = (nint)obj10 < 5;
		object obj11 = !flag7;
		int num4;
		if (obj11 == null)
		{
			object obj12 = 119877632 + 1728;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X10_v11+v311 @ X9_v5*4]");
			num4 = 0;
		}
		else
		{
			num4 = (int)(card.<Rank>k__BackingField - 4);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v2 (UnityEngine.Object)+120]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X9_v6+10]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v2 (UnityEngine.Object)+178]");
			object obj14 = 0 & 0xFFFFFFFDL;
			if ((nint)obj14 == 1)
			{
				CardGame game2 = Game;
				int num5 = num4 * 100;
				if (card.<Suit>k__BackingField == game2.<CurrentSuit>k__BackingField)
				{
					num4 = num5;
				}
				return num4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v2 (UnityEngine.Object)+178]");
			if ((nint)0 == 2)
			{
				CardGame game3 = Game;
				if (card.<Suit>k__BackingField == game3.<TrumpSuit>k__BackingField)
				{
					if (card.<Rank>k__BackingField != Rank.NINE)
					{
						if (card.<Rank>k__BackingField == Rank.JACK)
						{
							return 10000;
						}
						return num4 * 1000;
					}
					return 9000;
				}
				int num6 = num4 * 100;
				if (card.<Suit>k__BackingField == game3.<CurrentSuit>k__BackingField)
				{
					num4 = num6;
				}
				return num4;
			}
		}
		goto IL_049f;
		IL_049f:
		return num4;
		IL_0125:
		object obj15 = typeof(DataRelation) + 856;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v26+E4]");
		bool flag8 = (nint)0 == 0;
		object obj17 = !flag8;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "_InputUv1BufferOffset" + 4064;
		Debug.LogError(message);
		object obj18 = (int)card.<Suit>k__BackingField * 13;
		num4 = (int)(card.<Rank>k__BackingField + obj18);
		goto IL_049f;
	}

	static BalootCardUtils()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3608;
		object fldHandle = (nint)0 + (nint)1776;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Array array = default(Array);
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)fldHandle);
		object obj3 = obj2;
		object obj4 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
