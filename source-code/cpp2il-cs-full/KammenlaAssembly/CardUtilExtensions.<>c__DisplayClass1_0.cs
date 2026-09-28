using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using GoogleMobileAds.Ump.Api;
using HuaweiMobileServices.Location.Location;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;

public static class CardUtilExtensions
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Card, Card, global::<>f__AnonymousType2<Card, Card>> <>9__3_1;

		public static Func<global::<>f__AnonymousType2<Card, Card>, bool> <>9__3_2;

		public static Func<global::<>f__AnonymousType2<Card, Card>, Card> <>9__3_3;

		public static Func<Card, Rank, <>f__AnonymousType3<Card, Rank>> <>9__4_1;

		public static Func<<>f__AnonymousType3<Card, Rank>, bool> <>9__4_2;

		public static Func<<>f__AnonymousType3<Card, Rank>, Card> <>9__4_3;

		public static Func<Card, Suit, <>f__AnonymousType4<Card, Suit>> <>9__5_1;

		public static Func<<>f__AnonymousType4<Card, Suit>, bool> <>9__5_2;

		public static Func<<>f__AnonymousType4<Card, Suit>, Card> <>9__5_3;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal global::<>f__AnonymousType2<Card, Card> <GetCards>b__3_1(Card card, Card cardToCheck)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 72;
			object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 2568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FD5D08");
			global::<>f__AnonymousType2<Card, Card> result = default(global::<>f__AnonymousType2<Card, Card>);
			return result;
		}

		internal bool <GetCards>b__3_2(global::<>f__AnonymousType2<Card, Card> <>h__TransparentIdentifier0)
		{
			//IL_0054: Expected I4, but got O
			//IL_003c: Expected I, but got O
			if (<>h__TransparentIdentifier0 != null)
			{
				Card <card>i__Field = <>h__TransparentIdentifier0.<card>i__Field;
				if (<>h__TransparentIdentifier0.<card>i__Field != null)
				{
					nint num = (nint)<card>i__Field;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v48 @ X8_v3 (Il2CppClass<Card>)+138] (should have been resolved before IL gen)");
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal Card <GetCards>b__3_3(global::<>f__AnonymousType2<Card, Card> <>h__TransparentIdentifier0)
		{
			if (<>h__TransparentIdentifier0 != null)
			{
				return <>h__TransparentIdentifier0.<card>i__Field;
			}
			return (Card)(object)new NullReferenceException();
		}

		internal <>f__AnonymousType3<Card, Rank> <GetCardsWithRanks>b__4_1(Card card, Rank rankToCheck)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 88;
			object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 2600;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FD7744");
			<>f__AnonymousType3<Card, Rank> result = default(<>f__AnonymousType3<Card, Rank>);
			return result;
		}

		internal bool <GetCardsWithRanks>b__4_2(<>f__AnonymousType3<Card, Rank> <>h__TransparentIdentifier0)
		{
			//IL_0079: Expected I4, but got O
			//IL_0015: Expected O, but got I
			//IL_0057: Expected O, but got I
			if (<>h__TransparentIdentifier0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [<>h__TransparentIdentifier0 @ X1 (<>f__AnonymousType3`2<Card, Rank>)+10]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [<>h__TransparentIdentifier0 @ X1 (<>f__AnonymousType3`2<Card, Rank>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [<>h__TransparentIdentifier0 @ X1 (<>f__AnonymousType3`2<Card, Rank>)+18]");
					object obj2 = num - 0;
					return obj2 == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal Card <GetCardsWithRanks>b__4_3(<>f__AnonymousType3<Card, Rank> <>h__TransparentIdentifier0)
		{
			//IL_0012: Expected O, but got I
			if (<>h__TransparentIdentifier0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [<>h__TransparentIdentifier0 @ X1 (<>f__AnonymousType3`2<Card, Rank>)+10]");
				return (Card)0;
			}
			return (Card)(object)new NullReferenceException();
		}

		internal <>f__AnonymousType4<Card, Suit> <GetCardsWithSuits>b__5_1(Card card, Suit suitToCheck)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 104;
			object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 2632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FD96B4");
			<>f__AnonymousType4<Card, Suit> result = default(<>f__AnonymousType4<Card, Suit>);
			return result;
		}

		internal bool <GetCardsWithSuits>b__5_2(<>f__AnonymousType4<Card, Suit> <>h__TransparentIdentifier0)
		{
			//IL_0079: Expected I4, but got O
			//IL_0015: Expected O, but got I
			//IL_0057: Expected O, but got I
			if (<>h__TransparentIdentifier0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [<>h__TransparentIdentifier0 @ X1 (<>f__AnonymousType4`2<Card, Suit>)+10]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [<>h__TransparentIdentifier0 @ X1 (<>f__AnonymousType4`2<Card, Suit>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+14]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [<>h__TransparentIdentifier0 @ X1 (<>f__AnonymousType4`2<Card, Suit>)+18]");
					object obj2 = num - 0;
					return obj2 == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal Card <GetCardsWithSuits>b__5_3(<>f__AnonymousType4<Card, Suit> <>h__TransparentIdentifier0)
		{
			//IL_0012: Expected O, but got I
			if (<>h__TransparentIdentifier0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [<>h__TransparentIdentifier0 @ X1 (<>f__AnonymousType4`2<Card, Suit>)+10]");
				return (Card)0;
			}
			return (Card)(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass0_0
	{
		public List<Card> cardsToCheck;

		internal bool <Contains>b__0(Card card)
		{
			return Enumerable.Contains((IEnumerable<object>)cardsToCheck, (object)card);
		}
	}

	private sealed class <>c__DisplayClass1_0
	{
		public List<Rank> ranksToCheck;

		internal bool <Contains>b__0(Card card)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00a5: Expected I4, but got O
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_007a: Expected I, but got O
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4048;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (obj2 != null)
			{
				object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3040;
				object obj4 = (nint)0 + (nint)2608;
				object obj5 = obj2 + 16;
				obj5 = card;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<System.Int32Enum, bool> func = default(Func<System.Int32Enum, bool>);
				func..ctor(obj2, (IntPtr)obj4);
				return Enumerable.Any((IEnumerable<System.Int32Enum>)ranksToCheck, func);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass1_1
	{
		public Card card;

		internal bool <Contains>b__1(Rank rankToCheck)
		{
			//IL_005d: Expected I4, but got O
			//IL_003b: Expected O, but got I4
			Card card = this.card;
			if (this.card != null)
			{
				object obj = card.<Rank>k__BackingField - rankToCheck;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass2_0
	{
		public List<Suit> suitsToCheck;

		internal bool <Contains>b__0(Card card)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00a5: Expected I4, but got O
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_007a: Expected I, but got O
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4064;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (obj2 != null)
			{
				object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3720;
				object obj4 = (nint)0 + (nint)2624;
				object obj5 = obj2 + 16;
				obj5 = card;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<System.Int32Enum, bool> func = default(Func<System.Int32Enum, bool>);
				func..ctor(obj2, (IntPtr)obj4);
				return Enumerable.Any((IEnumerable<System.Int32Enum>)suitsToCheck, func);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass2_1
	{
		public Card card;

		internal bool <Contains>b__1(Suit suitToCheck)
		{
			//IL_005d: Expected I4, but got O
			//IL_003b: Expected O, but got I4
			Card card = this.card;
			if (this.card != null)
			{
				object obj = card.<Suit>k__BackingField - suitToCheck;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public List<Card> cardsToCheck;

		internal IEnumerable<Card> <GetCards>b__0(Card card)
		{
			return cardsToCheck;
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public List<Rank> ranksToCheck;

		internal IEnumerable<Rank> <GetCardsWithRanks>b__0(Card card)
		{
			return ranksToCheck;
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public List<Suit> suitsToCheck;

		internal IEnumerable<Suit> <GetCardsWithSuits>b__0(Card card)
		{
			return suitsToCheck;
		}
	}

	public static bool Contains(List<Card> cards, List<Card> cardsToCheck)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a3: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
			object obj4 = (nint)0 + (nint)2592;
			object obj5 = obj2 + 16;
			obj5 = cardsToCheck;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return Enumerable.Any(cards, func);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool Contains(List<Card> cards, List<Rank> ranksToCheck)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a3: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
			object obj4 = (nint)0 + (nint)2600;
			object obj5 = obj2 + 16;
			obj5 = ranksToCheck;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return Enumerable.Any(cards, func);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool Contains(List<Card> cards, List<Suit> suitsToCheck)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a3: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
			object obj4 = (nint)0 + (nint)2616;
			object obj5 = obj2 + 16;
			obj5 = suitsToCheck;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return Enumerable.Any(cards, func);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static List<Card> GetCards(List<Card> cards, List<Card> cardsToCheck)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_008d: Expected I, but got O
		//IL_0141: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0161: Expected O, but got I
		//IL_0183: Expected O, but got I4
		//IL_00c6: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_00e6: Expected O, but got I
		//IL_0108: Expected O, but got I4
		//IL_02c1: Expected O, but got I
		//IL_02d1: Expected O, but got I
		//IL_02e1: Expected O, but got I
		//IL_0303: Expected O, but got I4
		//IL_01bb: Expected O, but got I4
		//IL_03ab: Expected O, but got I4
		//IL_0246: Expected O, but got I
		//IL_0256: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_0288: Expected O, but got I4
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_04b7: Expected O, but got I
		//IL_04c8: Expected I, but got O
		//IL_04e6: Expected O, but got I
		//IL_05a8: Expected O, but got I
		//IL_05b8: Expected O, but got I
		//IL_05da: Expected O, but got I4
		//IL_033b: Expected O, but got I4
		//IL_01eb: Expected O, but got I
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0537: Expected O, but got I
		//IL_0548: Expected I, but got O
		//IL_0566: Expected O, but got I
		//IL_0581: Expected O, but got I4
		//IL_03f2: Expected O, but got I4
		//IL_036b: Expected O, but got I
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_0612: Expected O, but got I
		//IL_0623: Expected I, but got O
		//IL_0641: Expected O, but got I
		//IL_0422: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj5;
		Func<object, object> func = default(Func<object, object>);
		object obj8;
		object obj9;
		Func<object, object, object> resultSelector;
		object obj11;
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 424;
			object obj4 = (nint)0 + (nint)2632;
			obj5 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4024;
			object obj6 = obj2 + 16;
			obj6 = cardsToCheck;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor(obj2, (IntPtr)obj4);
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v43+E4]");
			if ((nint)0 != 0)
			{
				obj8 = (nint)0 + (nint)400;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v43+B8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v30+8]");
				resultSelector = (Func<object, object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v30+8]");
				bool flag = (nint)0 == 0;
				object obj10 = !flag;
				if (obj10 == null)
				{
					obj11 = obj8;
					goto IL_0199;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj5;
				obj11 = (nint)0 + (nint)400;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v43+B8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v30+8]");
				resultSelector = (Func<object, object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v30+8]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				obj8 = obj11;
				if (obj12 == null)
				{
					goto IL_0199;
				}
			}
			goto IL_01f0;
		}
		return (List<Card>)(object)new NullReferenceException();
		IL_0199:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v43+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v36+B8]");
			obj9 = 0;
		}
		object obj15 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)2520;
		Func<object, object, object> func2 = default(Func<object, object, object>);
		func2..ctor(obj9, (IntPtr)obj16);
		object obj17 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v35+B8]");
		object obj18 = (nint)0 + (nint)8;
		obj18 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj8 = obj11;
		resultSelector = func2;
		goto IL_01f0;
		IL_01f0:
		object obj19 = obj8;
		IEnumerable<object> source = Enumerable.SelectMany(cards, (Func<object, IEnumerable<object>>)func, resultSelector);
		object obj20 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v33+E4]");
		object obj22;
		Func<object, bool> predicate;
		object obj24;
		object obj21;
		if ((nint)0 != 0)
		{
			obj21 = (nint)0 + (nint)3072;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v33+B8]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+10]");
			bool flag4 = (nint)0 == 0;
			object obj23 = !flag4;
			if (obj23 == null)
			{
				obj24 = obj21;
				goto IL_0319;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj5;
			obj24 = (nint)0 + (nint)3072;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v33+B8]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+10]");
			bool flag5 = (nint)0 == 0;
			object obj25 = !flag5;
			obj21 = obj24;
			if (obj25 == null)
			{
				goto IL_0319;
			}
		}
		goto IL_0370;
		IL_0319:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v33+E4]");
		bool flag6 = (nint)0 == 0;
		object obj26 = !flag6;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj27 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v25+B8]");
			obj22 = 0;
		}
		object obj28 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = (nint)0 + (nint)2528;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj22, (IntPtr)obj29);
		object obj30 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v24+B8]");
		object obj31 = (nint)0 + (nint)16;
		obj31 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj19 = 0;
		obj21 = obj24;
		predicate = func3;
		goto IL_0370;
		IL_0370:
		IEnumerable<object> source2 = Enumerable.Where(source, predicate);
		object obj32 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v19+E4]");
		bool flag7 = (nint)0 == 0;
		object obj33 = !flag7;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj32 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v19+B8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v10+18]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v10+18]");
		bool flag8 = (nint)0 == 0;
		object obj35 = !flag8;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v19+E4]");
			bool flag9 = (nint)0 == 0;
			object obj36 = !flag9;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj37 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v16+B8]");
				obj34 = 0;
			}
			object obj38 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj39 = (nint)0 + (nint)2536;
			Func<object, object> func4 = default(Func<object, object>);
			func4..ctor(obj34, (IntPtr)obj39);
			object obj40 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v15+B8]");
			object obj41 = (nint)0 + (nint)24;
			obj41 = func4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func4;
		}
		IEnumerable<object> source3 = Enumerable.Select(source2, selector);
		return (List<Card>)(object)Enumerable.ToList(source3);
	}

	public static List<Card> GetCardsWithRanks(List<Card> cards, List<Rank> ranksToCheck)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_008d: Expected I, but got O
		//IL_0141: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0161: Expected O, but got I
		//IL_0183: Expected O, but got I4
		//IL_00c6: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_00e6: Expected O, but got I
		//IL_0108: Expected O, but got I4
		//IL_02c1: Expected O, but got I
		//IL_02d1: Expected O, but got I
		//IL_02e1: Expected O, but got I
		//IL_0303: Expected O, but got I4
		//IL_01bb: Expected O, but got I4
		//IL_03ab: Expected O, but got I4
		//IL_0246: Expected O, but got I
		//IL_0256: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_0288: Expected O, but got I4
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_04b7: Expected O, but got I
		//IL_04c8: Expected I, but got O
		//IL_04e6: Expected O, but got I
		//IL_05a8: Expected O, but got I
		//IL_05b8: Expected O, but got I
		//IL_05da: Expected O, but got I4
		//IL_033b: Expected O, but got I4
		//IL_01eb: Expected O, but got I
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0537: Expected O, but got I
		//IL_0548: Expected I, but got O
		//IL_0566: Expected O, but got I
		//IL_0581: Expected O, but got I4
		//IL_03f2: Expected O, but got I4
		//IL_036b: Expected O, but got I
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_0612: Expected O, but got I
		//IL_0623: Expected I, but got O
		//IL_0641: Expected O, but got I
		//IL_0422: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj5;
		Func<object, object> func = default(Func<object, object>);
		object obj8;
		object obj9;
		Func<object, System.Int32Enum, object> resultSelector;
		object obj11;
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 432;
			object obj4 = (nint)0 + (nint)2640;
			obj5 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4024;
			object obj6 = obj2 + 16;
			obj6 = ranksToCheck;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor(obj2, (IntPtr)obj4);
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v43+E4]");
			if ((nint)0 != 0)
			{
				obj8 = (nint)0 + (nint)408;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v43+B8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v30+20]");
				resultSelector = (Func<object, System.Int32Enum, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v30+20]");
				bool flag = (nint)0 == 0;
				object obj10 = !flag;
				if (obj10 == null)
				{
					obj11 = obj8;
					goto IL_0199;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj5;
				obj11 = (nint)0 + (nint)408;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v43+B8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v30+20]");
				resultSelector = (Func<object, System.Int32Enum, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v30+20]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				obj8 = obj11;
				if (obj12 == null)
				{
					goto IL_0199;
				}
			}
			goto IL_01f0;
		}
		return (List<Card>)(object)new NullReferenceException();
		IL_0199:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v43+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v36+B8]");
			obj9 = 0;
		}
		object obj15 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)2544;
		Func<object, System.Int32Enum, object> func2 = default(Func<object, System.Int32Enum, object>);
		func2..ctor(obj9, (IntPtr)obj16);
		object obj17 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v35+B8]");
		object obj18 = (nint)0 + (nint)32;
		obj18 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj8 = obj11;
		resultSelector = func2;
		goto IL_01f0;
		IL_01f0:
		object obj19 = obj8;
		IEnumerable<object> source = Enumerable.SelectMany(cards, (Func<object, IEnumerable<System.Int32Enum>>)func, resultSelector);
		object obj20 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v33+E4]");
		object obj22;
		Func<object, bool> predicate;
		object obj24;
		object obj21;
		if ((nint)0 != 0)
		{
			obj21 = (nint)0 + (nint)3080;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v33+B8]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+28]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+28]");
			bool flag4 = (nint)0 == 0;
			object obj23 = !flag4;
			if (obj23 == null)
			{
				obj24 = obj21;
				goto IL_0319;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj5;
			obj24 = (nint)0 + (nint)3080;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v33+B8]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+28]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+28]");
			bool flag5 = (nint)0 == 0;
			object obj25 = !flag5;
			obj21 = obj24;
			if (obj25 == null)
			{
				goto IL_0319;
			}
		}
		goto IL_0370;
		IL_0319:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v33+E4]");
		bool flag6 = (nint)0 == 0;
		object obj26 = !flag6;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj27 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v25+B8]");
			obj22 = 0;
		}
		object obj28 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = (nint)0 + (nint)2552;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj22, (IntPtr)obj29);
		object obj30 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v24+B8]");
		object obj31 = (nint)0 + (nint)40;
		obj31 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj19 = 0;
		obj21 = obj24;
		predicate = func3;
		goto IL_0370;
		IL_0370:
		IEnumerable<object> source2 = Enumerable.Where(source, predicate);
		object obj32 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v19+E4]");
		bool flag7 = (nint)0 == 0;
		object obj33 = !flag7;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj32 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v19+B8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v10+30]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v10+30]");
		bool flag8 = (nint)0 == 0;
		object obj35 = !flag8;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v19+E4]");
			bool flag9 = (nint)0 == 0;
			object obj36 = !flag9;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj37 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v16+B8]");
				obj34 = 0;
			}
			object obj38 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj39 = (nint)0 + (nint)2560;
			Func<object, object> func4 = default(Func<object, object>);
			func4..ctor(obj34, (IntPtr)obj39);
			object obj40 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v15+B8]");
			object obj41 = (nint)0 + (nint)48;
			obj41 = func4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func4;
		}
		IEnumerable<object> source3 = Enumerable.Select(source2, selector);
		return (List<Card>)(object)Enumerable.ToList(source3);
	}

	public static List<Card> GetCardsWithSuits(List<Card> cards, List<Suit> suitsToCheck)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_008d: Expected I, but got O
		//IL_0141: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0161: Expected O, but got I
		//IL_0183: Expected O, but got I4
		//IL_00c6: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_00e6: Expected O, but got I
		//IL_0108: Expected O, but got I4
		//IL_02c1: Expected O, but got I
		//IL_02d1: Expected O, but got I
		//IL_02e1: Expected O, but got I
		//IL_0303: Expected O, but got I4
		//IL_01bb: Expected O, but got I4
		//IL_03ab: Expected O, but got I4
		//IL_0246: Expected O, but got I
		//IL_0256: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_0288: Expected O, but got I4
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_04b7: Expected O, but got I
		//IL_04c8: Expected I, but got O
		//IL_04e6: Expected O, but got I
		//IL_05a8: Expected O, but got I
		//IL_05b8: Expected O, but got I
		//IL_05da: Expected O, but got I4
		//IL_033b: Expected O, but got I4
		//IL_01eb: Expected O, but got I
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0537: Expected O, but got I
		//IL_0548: Expected I, but got O
		//IL_0566: Expected O, but got I
		//IL_0581: Expected O, but got I4
		//IL_03f2: Expected O, but got I4
		//IL_036b: Expected O, but got I
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_0612: Expected O, but got I
		//IL_0623: Expected I, but got O
		//IL_0641: Expected O, but got I
		//IL_0422: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj5;
		Func<object, object> func = default(Func<object, object>);
		object obj8;
		object obj9;
		Func<object, System.Int32Enum, object> resultSelector;
		object obj11;
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 440;
			object obj4 = (nint)0 + (nint)2648;
			obj5 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 4024;
			object obj6 = obj2 + 16;
			obj6 = suitsToCheck;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor(obj2, (IntPtr)obj4);
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v43+E4]");
			if ((nint)0 != 0)
			{
				obj8 = (nint)0 + (nint)416;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v43+B8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v30+38]");
				resultSelector = (Func<object, System.Int32Enum, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v30+38]");
				bool flag = (nint)0 == 0;
				object obj10 = !flag;
				if (obj10 == null)
				{
					obj11 = obj8;
					goto IL_0199;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj5;
				obj11 = (nint)0 + (nint)416;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v43+B8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v30+38]");
				resultSelector = (Func<object, System.Int32Enum, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v30+38]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				obj8 = obj11;
				if (obj12 == null)
				{
					goto IL_0199;
				}
			}
			goto IL_01f0;
		}
		return (List<Card>)(object)new NullReferenceException();
		IL_0199:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v43+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v36+B8]");
			obj9 = 0;
		}
		object obj15 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)2568;
		Func<object, System.Int32Enum, object> func2 = default(Func<object, System.Int32Enum, object>);
		func2..ctor(obj9, (IntPtr)obj16);
		object obj17 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v35+B8]");
		object obj18 = (nint)0 + (nint)56;
		obj18 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj8 = obj11;
		resultSelector = func2;
		goto IL_01f0;
		IL_01f0:
		object obj19 = obj8;
		IEnumerable<object> source = Enumerable.SelectMany(cards, (Func<object, IEnumerable<System.Int32Enum>>)func, resultSelector);
		object obj20 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v33+E4]");
		object obj22;
		Func<object, bool> predicate;
		object obj24;
		object obj21;
		if ((nint)0 != 0)
		{
			obj21 = (nint)0 + (nint)3088;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v33+B8]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+40]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+40]");
			bool flag4 = (nint)0 == 0;
			object obj23 = !flag4;
			if (obj23 == null)
			{
				obj24 = obj21;
				goto IL_0319;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj5;
			obj24 = (nint)0 + (nint)3088;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v33+B8]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+40]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+40]");
			bool flag5 = (nint)0 == 0;
			object obj25 = !flag5;
			obj21 = obj24;
			if (obj25 == null)
			{
				goto IL_0319;
			}
		}
		goto IL_0370;
		IL_0319:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v33+E4]");
		bool flag6 = (nint)0 == 0;
		object obj26 = !flag6;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj27 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v25+B8]");
			obj22 = 0;
		}
		object obj28 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = (nint)0 + (nint)2576;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj22, (IntPtr)obj29);
		object obj30 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v24+B8]");
		object obj31 = (nint)0 + (nint)64;
		obj31 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj19 = 0;
		obj21 = obj24;
		predicate = func3;
		goto IL_0370;
		IL_0370:
		IEnumerable<object> source2 = Enumerable.Where(source, predicate);
		object obj32 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v19+E4]");
		bool flag7 = (nint)0 == 0;
		object obj33 = !flag7;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj32 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v19+B8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v10+48]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v10+48]");
		bool flag8 = (nint)0 == 0;
		object obj35 = !flag8;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v19+E4]");
			bool flag9 = (nint)0 == 0;
			object obj36 = !flag9;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj37 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v16+B8]");
				obj34 = 0;
			}
			object obj38 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj39 = (nint)0 + (nint)2584;
			Func<object, object> func4 = default(Func<object, object>);
			func4..ctor(obj34, (IntPtr)obj39);
			object obj40 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v15+B8]");
			object obj41 = (nint)0 + (nint)72;
			obj41 = func4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func4;
		}
		IEnumerable<object> source3 = Enumerable.Select(source2, selector);
		return (List<Card>)(object)Enumerable.ToList(source3);
	}

	public static bool IsBlack(Card card)
	{
		//IL_0056: Expected I4, but got O
		//IL_0034: Expected O, but got I8
		if (card != null)
		{
			object obj = (long)card.<Suit>k__BackingField & 0xFFFFFFFDL;
			return obj == null;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool IsRed(Card card)
	{
		//IL_0064: Expected I4, but got O
		//IL_0034: Expected O, but got I8
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		if (card != null)
		{
			object obj = (long)card.<Suit>k__BackingField & 0xFFFFFFFDL;
			object obj2 = obj - 1;
			return obj2 == null;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static Card Clone(Card card)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card card2 = default(Card);
		card2..ctor(card);
		return card2;
	}
}
