using System;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace Features.GameReplay;

public class CatchCheatEvent : ReplayEvent
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Card, int> <>9__25_1;

		public static Func<List<Card>, List<int>> <>9__25_0;

		public static Func<Card, int> <>9__25_3;

		public static Func<List<Card>, List<int>> <>9__25_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal List<int> <.ctor>b__25_0(List<Card> cardsInHand)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00d9: Expected O, but got I4
			//IL_0171: Expected O, but got I
			//IL_0181: Expected O, but got I
			//IL_01a3: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected O, but got Unknown
			//IL_0111: Expected O, but got I
			//IL_0122: Expected I, but got O
			//IL_0140: Expected O, but got I
			//IL_0082: Expected O, but got I
			object obj = typeof(CardUtils.<>c) + 72;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v6+8]");
			Func<object, int> selector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v12+B8]");
					obj4 = 0;
				}
				object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 456;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)2784;
				Func<object, int> func = default(Func<object, int>);
				func..ctor(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v11+B8]");
				object obj11 = (nint)0 + (nint)8;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			IEnumerable<int> source = Enumerable.Select(cardsInHand, selector);
			return Enumerable.ToList(source);
		}

		internal int <.ctor>b__25_1(Card card)
		{
			//IL_003d: Expected I4, but got O
			if (card != null)
			{
				return card.AsInt();
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal List<int> <.ctor>b__25_2(List<Card> eating)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00d9: Expected O, but got I4
			//IL_0171: Expected O, but got I
			//IL_0181: Expected O, but got I
			//IL_01a3: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected O, but got Unknown
			//IL_0111: Expected O, but got I
			//IL_0122: Expected I, but got O
			//IL_0140: Expected O, but got I
			//IL_0082: Expected O, but got I
			object obj = typeof(CardUtils.<>c) + 72;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v6+18]");
			Func<object, int> selector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v6+18]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v12+B8]");
					obj4 = 0;
				}
				object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 456;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)2800;
				Func<object, int> func = default(Func<object, int>);
				func..ctor(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v11+B8]");
				object obj11 = (nint)0 + (nint)24;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			IEnumerable<int> source = Enumerable.Select(eating, selector);
			return Enumerable.ToList(source);
		}

		internal int <.ctor>b__25_3(Card card)
		{
			//IL_003d: Expected I4, but got O
			if (card != null)
			{
				return card.AsInt();
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private CheatingOption <CheatingOption>k__BackingField;

	private Card <WrongCard>k__BackingField;

	private Card <AllowedCard>k__BackingField;

	private bool <IsCorrect>k__BackingField;

	private List<List<int>> <CardsInHands>k__BackingField;

	private List<List<int>> <Eatings>k__BackingField;

	public CheatingOption CheatingOption
	{
		get
		{
			return <CheatingOption>k__BackingField;
		}
		private set
		{
			<CheatingOption>k__BackingField = value;
		}
	}

	public Card WrongCard
	{
		get
		{
			return <WrongCard>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Card AllowedCard
	{
		get
		{
			return <AllowedCard>k__BackingField;
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

	public bool IsCorrect
	{
		get
		{
			return <IsCorrect>k__BackingField;
		}
		private set
		{
			<IsCorrect>k__BackingField = value;
		}
	}

	public List<List<int>> CardsInHands
	{
		get
		{
			return <CardsInHands>k__BackingField;
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

	public List<List<int>> Eatings
	{
		get
		{
			return <Eatings>k__BackingField;
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

	public CatchCheatEvent()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 56;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj3 = this + 64;
		obj3 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((object)this)..ctor();
	}

	public unsafe CatchCheatEvent(int playerIndex, CheatingOption cheatingOption, Card wrongCard, Card allowedCard, List<List<Card>> cardsInHands, List<List<Card>> cheatingInfoEatings, bool isCorrect)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_14d4: Expected O, but got I
		//IL_14e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e8: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3b: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0141: Expected I, but got O
		//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Expected O, but got Unknown
		//IL_0a82: Expected I, but got O
		//IL_01dd: Expected I, but got O
		//IL_01fd: Expected O, but got I
		//IL_021f: Expected O, but got I4
		//IL_0b1e: Expected I, but got O
		//IL_0b3e: Expected O, but got I
		//IL_0b60: Expected O, but got I4
		//IL_0186: Expected O, but got I
		//IL_01a8: Expected O, but got I4
		//IL_0ac7: Expected O, but got I
		//IL_0ae9: Expected O, but got I4
		//IL_0245: Expected O, but got I
		//IL_0267: Expected O, but got I4
		//IL_0b86: Expected O, but got I
		//IL_0ba8: Expected O, but got I4
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0307: Expected I, but got O
		//IL_0317: Expected O, but got I
		//IL_150e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1513: Expected O, but got Unknown
		//IL_1529: Expected O, but got I
		//IL_153a: Expected I, but got O
		//IL_153a: Expected O, but got I
		//IL_1542: Expected I, but got O
		//IL_1558: Expected O, but got I
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Expected O, but got Unknown
		//IL_0c4b: Expected I, but got O
		//IL_0c5b: Expected O, but got I
		//IL_171f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1724: Expected O, but got Unknown
		//IL_173a: Expected O, but got I
		//IL_174b: Expected I, but got O
		//IL_174b: Expected O, but got I
		//IL_1753: Expected I, but got O
		//IL_1769: Expected O, but got I
		//IL_03cd: Expected O, but got I
		//IL_03f1: Expected O, but got I4
		//IL_0403: Expected O, but got I4
		//IL_0287: Expected I, but got O
		//IL_0d11: Expected O, but got I
		//IL_0d35: Expected O, but got I4
		//IL_0d47: Expected O, but got I4
		//IL_0bc8: Expected I, but got O
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected O, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected O, but got Unknown
		//IL_0533: Expected O, but got I
		//IL_0e4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4f: Expected O, but got Unknown
		//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e63: Expected O, but got Unknown
		//IL_0e6f: Expected O, but got I
		//IL_05c8: Expected I, but got O
		//IL_05d8: Expected O, but got I
		//IL_0435: Expected O, but got I4
		//IL_0f13: Expected I, but got O
		//IL_0f23: Expected O, but got I
		//IL_0d71: Expected O, but got I4
		//IL_0465: Expected O, but got I
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_048b: Expected O, but got I
		//IL_04b6: Expected O, but got I4
		//IL_04e1: Expected O, but got I4
		//IL_0da1: Expected O, but got I
		//IL_0daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daf: Expected O, but got Unknown
		//IL_0dc7: Expected O, but got I
		//IL_0df2: Expected O, but got I4
		//IL_0e15: Expected O, but got I4
		//IL_15f1: Expected I, but got O
		//IL_1601: Expected O, but got I
		//IL_1614: Unknown result type (might be due to invalid IL or missing references)
		//IL_1619: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_17df: Expected I, but got O
		//IL_17ef: Expected O, but got I
		//IL_1802: Unknown result type (might be due to invalid IL or missing references)
		//IL_1807: Expected O, but got Unknown
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Expected O, but got Unknown
		//IL_1927: Expected O, but got I
		//IL_124c: Expected O, but got I4
		//IL_0699: Expected O, but got I4
		//IL_06ab: Expected O, but got I
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected O, but got Unknown
		//IL_0fe4: Expected O, but got I4
		//IL_0ff6: Expected O, but got I
		//IL_0fff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1004: Expected O, but got Unknown
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Expected O, but got Unknown
		//IL_0904: Expected I, but got O
		//IL_0914: Expected O, but got I
		//IL_0644: Expected O, but got I
		//IL_189a: Expected O, but got I4
		//IL_0f8f: Expected O, but got I
		//IL_06f3: Expected I, but got O
		//IL_0703: Expected O, but got I
		//IL_1260: Unknown result type (might be due to invalid IL or missing references)
		//IL_1265: Expected O, but got Unknown
		//IL_126d: Expected I, but got O
		//IL_127d: Expected O, but got I
		//IL_103e: Expected I, but got O
		//IL_104e: Expected O, but got I
		//IL_16f1: Expected I, but got O
		//IL_1701: Expected O, but got I
		//IL_1663: Expected I, but got O
		//IL_18dc: Expected O, but got I
		//IL_1851: Expected I, but got O
		//IL_09d5: Expected O, but got I4
		//IL_09e7: Expected O, but got I
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f5: Expected O, but got Unknown
		//IL_0980: Expected O, but got I
		//IL_0801: Expected I, but got O
		//IL_07c4: Expected O, but got I4
		//IL_07d6: Expected O, but got I
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e4: Expected O, but got Unknown
		//IL_132e: Expected O, but got I4
		//IL_1340: Expected O, but got I
		//IL_1349: Unknown result type (might be due to invalid IL or missing references)
		//IL_134e: Expected O, but got Unknown
		//IL_114c: Expected I, but got O
		//IL_110f: Expected O, but got I4
		//IL_1121: Expected O, but got I
		//IL_112a: Unknown result type (might be due to invalid IL or missing references)
		//IL_112f: Expected O, but got Unknown
		//IL_076f: Expected O, but got I
		//IL_12e1: Expected O, but got I
		//IL_10ba: Expected O, but got I
		//IL_087e: Expected O, but got I4
		//IL_11c9: Expected O, but got I4
		//IL_0550: Expected O, but got I
		//IL_0e8c: Expected O, but got I
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Expected O, but got Unknown
		//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d1: Expected O, but got Unknown
		//IL_1209: Unknown result type (might be due to invalid IL or missing references)
		//IL_120e: Expected O, but got Unknown
		//IL_1217: Unknown result type (might be due to invalid IL or missing references)
		//IL_121c: Expected O, but got Unknown
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<List<Card>> list = (List<List<Card>>)((nint)0 + (nint)2912);
		List<object> list2 = default(List<object>);
		list2..ctor();
		Func<object, object> func = (Func<object, object>)(this + 56);
		func = (Func<object, object>)(object)list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list3 = default(List<object>);
		list3..ctor();
		object obj2 = this + 64;
		obj2 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((object)this)..ctor();
		base.<PlayerIndex>k__BackingField = playerIndex;
		base.<ReplayEventType>k__BackingField = ReplayEventsTypes.CatchCheat;
		CheatingOption cheatingOption2 = default(CheatingOption);
		<CheatingOption>k__BackingField = cheatingOption2;
		object obj3 = this + 32;
		Card card = default(Card);
		obj3 = card;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 40;
		obj4 = allowedCard;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = func == null;
		List<List<Card>> list4 = null;
		Card card2 = allowedCard;
		nint num4;
		Func<object, object> func2;
		Card card3;
		if (!flag)
		{
			object obj5 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3736;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list5 = default(List<object>);
			list5..ctor();
			func = (Func<object, object>)(object)list5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			card3 = (Card)(typeof(CardUtils.<>c) + 72);
			nint num = (nint)card3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v91 (Il2CppClass<Card>)+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v91 (Il2CppClass<Card>)+B8]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v113 (Il2CppStaticFields<Card>)+10]");
				func2 = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v113 (Il2CppStaticFields<Card>)+10]");
				if ((object)((nint)0 != 0) == null)
				{
					nint num3 = num;
					num4 = num2;
					goto IL_0235;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				nint num3 = (nint)card3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v129 (Il2CppClass<Card>)+B8]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v112 (Il2CppStaticFields<Card>)+10]");
				func2 = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v112 (Il2CppStaticFields<Card>)+10]");
				object obj6 = (nint)0 != 0;
				num4 = num5;
				if (obj6 == null)
				{
					goto IL_0235;
				}
			}
			goto IL_029c;
		}
		if (cheatingInfoEatings == null)
		{
			return;
		}
		object obj7 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list6 = default(List<object>);
		list6..ctor();
		obj2 = list6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		func2 = (Func<object, object>)(typeof(CardUtils.<>c) + 72);
		nint num6 = (nint)func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v46 (Il2CppClass<System.Func`2<System.Object, System.Object>>)+E4]");
		nint num9;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v46 (Il2CppClass<System.Func`2<System.Object, System.Object>>)+B8]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v62 (Il2CppStaticFields<System.Func`2<System.Object, System.Object>>)+20]");
			func = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v62 (Il2CppStaticFields<System.Func`2<System.Object, System.Object>>)+20]");
			if ((object)((nint)0 != 0) == null)
			{
				nint num8 = num6;
				num9 = num7;
				goto IL_0b76;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num8 = (nint)func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v77 (Il2CppClass<System.Func`2<System.Object, System.Object>>)+B8]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v61 (Il2CppStaticFields<System.Func`2<System.Object, System.Object>>)+20]");
			func = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v61 (Il2CppStaticFields<System.Func`2<System.Object, System.Object>>)+20]");
			object obj8 = (nint)0 != 0;
			num9 = num10;
			if (obj8 == null)
			{
				goto IL_0b76;
			}
		}
		goto IL_0bdd;
		IL_0e3b:
		func = (Func<object, object>)(typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528);
		list = (List<List<Card>>)(typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 160);
		func2 = (Func<object, object>)((nint)0 + (nint)2920);
		List<List<Card>> list8 = default(List<List<Card>>);
		List<List<Card>> list7 = list8;
		int num13 = default(int);
		object obj9 = default(object);
		object obj11 = default(object);
		object[] array2;
		object obj12 = default(object);
		object obj17 = default(object);
		object obj20 = default(object);
		int num22;
		CheatingOption cheatingOption4;
		object[] array3 = default(object[]);
		nint num14;
		bool flag3 = default(bool);
		int num17;
		Card card4;
		object[] array;
		CheatingOption cheatingOption3;
		object obj18;
		Func<object, object> func3;
		while (true)
		{
			nint num11 = (nint)list7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v33 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v33 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0fbf;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v33 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+B0]");
			int num12 = (int)((nint)0 + (nint)8);
			bool flag2 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X10_v29 (System.Int32)-8]");
				if (0 == (nint)func)
				{
					break;
				}
				num13 = num12 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v33 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+12E]");
				array = (object[])(-1);
				flag3 = (nint)array != 1;
				flag2 = flag3;
				num12 = num13;
				if (flag3)
				{
					continue;
				}
				goto IL_0fbf;
			}
			array = (object[])((int*)num12)->m_value;
			obj9 = (object)(num11 + ((int*)num12)->m_value) + 312;
			flag3 = flag2;
			num13 = num12;
			goto IL_17d7;
			IL_17d7:
			num14 = (nint)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ X0_v54+8]");
			func3 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1106 @ X0_v54] (should have been resolved before IL gen)");
			object obj10 = obj11 & 1;
			if (obj10 != null)
			{
				if (list4 == null)
				{
					break;
				}
				nint num15 = (nint)list4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X8_v36 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+12E]");
				array2 = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X8_v36 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_10ea;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X8_v36 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+B0]");
				int num16 = (int)((nint)0 + (nint)8);
				bool flag4 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ X10_v24 (System.Int32)-8]");
					if (0 == (nint)list)
					{
						break;
					}
					num13 = num16 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X8_v36 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+12E]");
					array2 = (object[])(-1);
					flag3 = (nint)array2 != 1;
					flag4 = flag3;
					num16 = num13;
					if (flag3)
					{
						continue;
					}
					goto IL_10ea;
				}
				array2 = (object[])((int*)num16)->m_value;
				obj12 = (object)(num15 + ((int*)num16)->m_value) + 312;
				flag3 = flag4;
				num13 = num16;
				goto IL_1849;
			}
			num17 = num13;
			card4 = card;
			object obj13 = 0;
			while (true)
			{
				if (list4 == null)
				{
					goto IL_1880;
				}
				object obj14 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num18 = (nint)list4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X8_v9 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X8_v9 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_1309;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X8_v9 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+B0]");
				int num19 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1285 @ X10_v7 (System.Int32)-8]");
					if (0 == (nint)obj14)
					{
						break;
					}
					num17 = num19 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X8_v9 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+12E]");
					bool flag5 = (nint)(object)(-1) != 1;
					num19 = num17;
					if (flag5)
					{
						continue;
					}
					goto IL_1309;
				}
				array = (object[])((int*)num19)->m_value;
				object obj15 = (object)(num18 + ((int*)num19)->m_value) + 312;
				num17 = num19;
				goto IL_18cc;
				IL_1880:
				bool flag6 = obj13 == null;
				object obj16 = !flag6;
				if (obj16 == null)
				{
					return;
				}
				OutOfMemoryException ex = new OutOfMemoryException();
				if ((nint)func3 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj13 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj18 = obj17;
				continue;
				IL_1309:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				cheatingOption3 = CheatingOption.None;
				goto IL_18cc;
				IL_18cc:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1363 @ X0_v18+8]");
				func3 = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1363 @ X0_v18] (should have been resolved before IL gen)");
				goto IL_1880;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_10ea:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			cheatingOption3 = CheatingOption.None;
			goto IL_1849;
			IL_1849:
			nint num20 = (nint)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1403 @ X0_v58] (should have been resolved before IL gen)");
			List<object> list9 = (List<object>)obj2;
			if (obj2 != null)
			{
				num20 = (nint)func2;
				list9._version++;
				array2 = list9._items;
				if (list9._items != null)
				{
					num13 = list9._size;
					int num21;
					if ((object)(list9._size >= array2.Length) != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X8_v39 (Il2CppClass<System.Func`2<System.Object, System.Object>>)+20]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1428 @ X8_v43+C0]");
						num21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v42 (System.Int32)+70]");
						cheatingOption3 = CheatingOption.None;
						((List<object>)obj2).AddWithResize(obj20);
					}
					else
					{
						num21 = ++list9._size;
						object obj21 = (object)(list9._items + list9._size) + 32;
						obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					bool flag7 = list4 == null;
					list7 = list4;
					num22 = num13;
					cheatingOption4 = cheatingOption3;
					array3 = array2;
					func3 = (Func<object, object>)obj20;
					num14 = num21;
					if (!flag7)
					{
						continue;
					}
					goto IL_13c6;
				}
			}
			goto IL_1382;
			IL_0fbf:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			cheatingOption3 = CheatingOption.None;
			goto IL_17d7;
		}
		NullReferenceException ex2 = new NullReferenceException();
		num22 = num13;
		cheatingOption4 = cheatingOption3;
		array3 = array;
		goto IL_1418;
		IL_029c:
		cheatingOption3 = (CheatingOption)((nint)0 + (nint)2824);
		IEnumerable<object> enumerable = Enumerable.Select(cardsInHands, func2);
		bool flag8 = enumerable == null;
		list4 = null;
		func3 = func2;
		object obj24;
		IEnumerable<object> enumerable2;
		int num24;
		if (!flag8)
		{
			object obj22 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2832;
			nint num23 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v73 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v73 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03ab;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v73 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
			num22 = (int)((nint)0 + (nint)8);
			bool flag9 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v12 (System.Int32)-8]");
				if (0 == (nint)obj22)
				{
					break;
				}
				num13 = num22 + 16;
				obj23--;
				flag3 = (nint)obj23 != 1;
				flag9 = flag3;
				num22 = num13;
				if (flag3)
				{
					continue;
				}
				goto IL_03ab;
			}
			array3 = (object[])((object)(num23 + ((int*)num22)->m_value) + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v101+8]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v660 @ X8_v101] (should have been resolved before IL gen)");
			List<List<Card>> list10 = default(List<List<Card>>);
			bool flag10 = list10 == null;
			list4 = list10;
			obj18 = 0;
			flag3 = flag9;
			num13 = num22;
			enumerable2 = list10;
			list4 = list10;
			obj18 = 0;
			cheatingOption4 = cheatingOption3;
			num24 = (int)(&list4);
			if (!flag10)
			{
				goto IL_04ff;
			}
			goto IL_13b0;
		}
		goto IL_157c;
		IL_13c6:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_1418;
		IL_157c:
		num17 = num13;
		card4 = card;
		array = array3;
		throw new NullReferenceException();
		IL_0235:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v129 (Il2CppClass<Card>)+E4]");
		array3 = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v129 (Il2CppClass<Card>)+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num25 = (nint)card3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v110 (Il2CppClass<Card>)+B8]");
			num4 = 0;
		}
		object obj25 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj26 = (nint)0 + (nint)2776;
		Func<object, object> func4 = default(Func<object, object>);
		func4..ctor((object)num4, (IntPtr)obj26);
		nint num26 = (nint)card3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v109 (Il2CppClass<Card>)+B8]");
		object obj27 = (nint)0 + (nint)16;
		obj27 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		card = null;
		func2 = func4;
		goto IL_029c;
		IL_0b76:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v77 (Il2CppClass<System.Func`2<System.Object, System.Object>>)+E4]");
		array3 = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v77 (Il2CppClass<System.Func`2<System.Object, System.Object>>)+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num27 = (nint)func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v59 (Il2CppClass<System.Func`2<System.Object, System.Object>>)+B8]");
			num9 = 0;
		}
		object obj28 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = (nint)0 + (nint)2792;
		Func<object, object> func5 = default(Func<object, object>);
		func5..ctor((object)num9, (IntPtr)obj29);
		nint num28 = (nint)func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v58 (Il2CppClass<System.Func`2<System.Object, System.Object>>)+B8]");
		object obj30 = (nint)0 + (nint)32;
		obj30 = func5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		card = null;
		func = func5;
		goto IL_0bdd;
		IL_135c:
		NullReferenceException ex4 = new NullReferenceException();
		num22 = num13;
		cheatingOption4 = cheatingOption3;
		object obj31 = default(object);
		func3 = (Func<object, object>)obj31;
		goto IL_1418;
		IL_0cef:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj32 = default(object);
		array3 = (object[])obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v73+8]");
		func3 = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v656 @ X0_v73] (should have been resolved before IL gen)");
		object obj33 = list8 != null;
		list4 = list8;
		obj18 = 0;
		cheatingOption3 = CheatingOption.None;
		if (obj33 != null)
		{
			goto IL_0e3b;
		}
		list4 = list8;
		obj18 = 0;
		num22 = num13;
		cheatingOption4 = CheatingOption.None;
		num14 = (nint)(&list4);
		goto IL_13c6;
		IL_0bdd:
		cheatingOption3 = (CheatingOption)((nint)0 + (nint)2824);
		IEnumerable<object> enumerable3 = Enumerable.Select(cheatingInfoEatings, func);
		bool flag11 = enumerable3 == null;
		func3 = func;
		list = cheatingInfoEatings;
		if (!flag11)
		{
			object obj34 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2832;
			nint num29 = (nint)enumerable3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v29 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v29 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0cef;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v29 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
			num22 = (int)((nint)0 + (nint)8);
			bool flag12 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v12 (System.Int32)-8]");
				if (0 == (nint)obj34)
				{
					break;
				}
				num13 = num22 + 16;
				obj35--;
				flag3 = (nint)obj35 != 1;
				flag12 = flag3;
				num22 = num13;
				if (flag3)
				{
					continue;
				}
				goto IL_0cef;
			}
			array3 = (object[])((object)(num29 + ((int*)num22)->m_value) + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v50+8]");
			func3 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v794 @ X8_v50] (should have been resolved before IL gen)");
			bool flag13 = list8 == null;
			list4 = list8;
			obj18 = 0;
			flag3 = flag12;
			num13 = num22;
			list4 = list8;
			obj18 = 0;
			cheatingOption4 = cheatingOption3;
			list = cheatingInfoEatings;
			num14 = (nint)(&list4);
			if (!flag13)
			{
				goto IL_0e3b;
			}
			goto IL_13c6;
		}
		goto IL_157c;
		IL_04ff:
		object obj36 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		func2 = (Func<object, object>)(typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 160);
		card3 = (Card)((nint)0 + (nint)2920);
		IEnumerable<object> enumerable4 = enumerable2;
		object obj37 = default(object);
		object obj38 = default(object);
		object obj41 = default(object);
		object obj43 = default(object);
		while (true)
		{
			nint num30 = (nint)enumerable4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v77 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			array3 = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v77 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0674;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v77 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
			int num31 = (int)((nint)0 + (nint)8);
			bool flag14 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X10_v57 (System.Int32)-8]");
				if (0 == (nint)obj36)
				{
					break;
				}
				num13 = num31 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v77 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
				array3 = (object[])(-1);
				flag3 = (nint)array3 != 1;
				flag14 = flag3;
				num31 = num13;
				if (flag3)
				{
					continue;
				}
				goto IL_0674;
			}
			array3 = (object[])((int*)num31)->m_value;
			obj37 = (object)(num30 + ((int*)num31)->m_value) + 312;
			flag3 = flag14;
			num13 = num31;
			goto IL_15e9;
			IL_165b:
			num14 = (nint)obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1330 @ X0_v110] (should have been resolved before IL gen)");
			List<object> list11 = (List<object>)(object)func;
			if (func != null)
			{
				num14 = (nint)card3;
				list11._version++;
				array3 = list11._items;
				if (list11._items != null)
				{
					num13 = list11._size;
					if ((object)(list11._size >= array3.Length) != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v6 (Il2CppClass<Card>)+20]");
						object obj39 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1420 @ X8_v94+C0]");
						num24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v74 (System.Int32)+70]");
						cheatingOption3 = CheatingOption.None;
						((List<object>)(object)func).AddWithResize(obj31);
					}
					else
					{
						list11._size++;
						object obj40 = (object)(list11._items + list11._size) + 32;
						obj40 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					bool flag15 = list4 == null;
					enumerable4 = list4;
					num22 = num13;
					cheatingOption4 = cheatingOption3;
					obj24 = obj31;
					if (!flag15)
					{
						continue;
					}
					goto IL_13b0;
				}
			}
			goto IL_135c;
			IL_09b0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			cheatingOption3 = CheatingOption.None;
			goto IL_16e9;
			IL_16e9:
			num14 = (nint)obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1395 @ X0_v103+8]");
			card2 = (Card)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1395 @ X0_v103] (should have been resolved before IL gen)");
			goto IL_1692;
			IL_0674:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			cheatingOption3 = CheatingOption.None;
			goto IL_15e9;
			IL_15e9:
			num14 = (nint)obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X0_v99+8]");
			func3 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1051 @ X0_v99] (should have been resolved before IL gen)");
			object obj42 = obj43 & 1;
			if (obj42 != null)
			{
				if (list4 == null)
				{
					break;
				}
				nint num32 = (nint)list4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X8_v87 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+12E]");
				array3 = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X8_v87 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_079f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X8_v87 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+B0]");
				int num33 = (int)((nint)0 + (nint)8);
				bool flag16 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1235 @ X10_v52 (System.Int32)-8]");
					if (0 == (nint)func2)
					{
						break;
					}
					num13 = num33 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X8_v87 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+12E]");
					array3 = (object[])(-1);
					flag3 = (nint)array3 != 1;
					flag16 = flag3;
					num33 = num13;
					if (flag3)
					{
						continue;
					}
					goto IL_079f;
				}
				array3 = (object[])((int*)num33)->m_value;
				obj38 = (object)(num32 + ((int*)num33)->m_value) + 312;
				flag3 = flag16;
				num13 = num33;
				goto IL_165b;
			}
			bool flag17 = list4 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X0_v99+8]");
			card2 = (Card)0;
			if (flag17)
			{
				goto IL_1692;
			}
			object obj44 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			nint num34 = (nint)list4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ X8_v83 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+12E]");
			array3 = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ X8_v83 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_09b0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ X8_v83 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+B0]");
			int num35 = (int)((nint)0 + (nint)8);
			bool flag18 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1348 @ X10_v45 (System.Int32)-8]");
				if (0 == (nint)obj44)
				{
					break;
				}
				num13 = num35 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ X8_v83 (Il2CppClass<System.Collections.Generic.List`1<System.Collections.Generic.List`1<Card>>>)+12E]");
				array3 = (object[])(-1);
				flag3 = (nint)array3 != 1;
				flag18 = flag3;
				num35 = num13;
				if (flag3)
				{
					continue;
				}
				goto IL_09b0;
			}
			array3 = (object[])((int*)num35)->m_value;
			obj41 = (object)(num34 + ((int*)num35)->m_value) + 312;
			flag3 = flag18;
			num13 = num35;
			goto IL_16e9;
			IL_079f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			cheatingOption3 = CheatingOption.None;
			goto IL_165b;
			IL_1692:
			num17 = num13;
			card4 = card;
			array = array3;
			func = null;
			func3 = (Func<object, object>)(object)card2;
			list = list4;
			throw new OutOfMemoryException();
		}
		NullReferenceException ex5 = new NullReferenceException();
		num22 = num13;
		cheatingOption4 = cheatingOption3;
		goto IL_1418;
		IL_13b0:
		NullReferenceException ex6 = new NullReferenceException();
		func3 = (Func<object, object>)obj24;
		goto IL_1418;
		IL_1418:
		num13 = num22;
		cheatingOption3 = cheatingOption4;
		goto IL_157c;
		IL_03ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj45 = default(object);
		array3 = (object[])obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v125+8]");
		obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v534 @ X0_v125] (should have been resolved before IL gen)");
		List<List<Card>> list12 = default(List<List<Card>>);
		object obj46 = list12 != null;
		list4 = list12;
		obj18 = 0;
		cheatingOption3 = CheatingOption.None;
		enumerable2 = list12;
		if (obj46 != null)
		{
			goto IL_04ff;
		}
		list4 = list12;
		obj18 = 0;
		num22 = num13;
		cheatingOption4 = CheatingOption.None;
		num24 = (int)(&list4);
		goto IL_13b0;
		IL_1382:
		NullReferenceException ex7 = new NullReferenceException();
		num22 = num13;
		cheatingOption4 = cheatingOption3;
		array3 = array2;
		func3 = (Func<object, object>)obj20;
		goto IL_1418;
	}
}
