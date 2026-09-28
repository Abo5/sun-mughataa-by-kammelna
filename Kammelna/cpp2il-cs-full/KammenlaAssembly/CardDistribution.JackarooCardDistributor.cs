using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Jackaroo;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

namespace CardDistribution;

public class JackarooCardDistributor : CardDistributor
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<JackarooPlayer, int> <>9__1_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <ResolvePileStateFromHandSizes>b__1_0(JackarooPlayer p)
		{
			//IL_0052: Expected I4, but got O
			if (p != null)
			{
				List<Card> <Cards>k__BackingField = ((CardGamePlayer)p).<Cards>k__BackingField;
				if (((CardGamePlayer)p).<Cards>k__BackingField != null)
				{
					return <Cards>k__BackingField._size;
				}
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	protected override int? ResolveMidGamePileState(CardGame game)
	{
		//IL_01b6: Expected O, but got I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_006d: Expected I, but got O
		//IL_0096: Expected O, but got I4
		//IL_00ca: Expected O, but got I
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0183: Expected O, but got I4
		//IL_01f7: Expected I4, but got I8
		//IL_0211: Expected O, but got I4
		//IL_0236: Expected O, but got I
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected I4, but got Unknown
		//IL_02a6: Expected O, but got I4
		if ((object)game != null)
		{
			if (game.<Dealer>k__BackingField >= 1 && game.<MoveNumber>k__BackingField >= 1)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
				object obj2 = obj;
				nint num = (nint)game;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X9_v3 (Il2CppClass<CardGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v9+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X9_v3 (Il2CppClass<CardGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v9+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X9_v8-8]");
					if (0 == (nint)obj2)
					{
						int[] cardsPerBatch = base.CardsPerBatch;
						if (cardsPerBatch != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [game @ X1 (CardGame)+198]");
							int num4 = 0;
							bool flag2 = num4 == 0;
							object obj6 = !flag2;
							if (obj6 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [game @ X1 (CardGame)+198]");
								object obj7 = -cardsPerBatch.Length;
								bool flag3 = (nint)obj7 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [game @ X1 (CardGame)+198]");
								int num5 = (int)((nint)0 ^ (nint)cardsPerBatch.Length);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [game @ X1 (CardGame)+198]");
								int num6 = 0 ^ obj7;
								int num7 = num5 & num6;
								bool flag4 = num7 < 0;
								bool flag5 = flag3 == flag4;
								object obj8 = !flag5;
								object obj9 = ~obj8;
								int value;
								if (obj9 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [game @ X1 (CardGame)+198]");
									value = 0;
								}
								else
								{
									value = cardsPerBatch.Length;
								}
								return value;
							}
							return ResolvePileStateFromHandSizes((JackarooGame)game, cardsPerBatch.Length);
						}
						goto IL_02fa;
					}
				}
				Type type = game.GetType();
				if ((object)type == null)
				{
					goto IL_02fa;
				}
				string text = type.Name;
				object obj10 = "WhiteSmoke" + 3312;
				string text2 = (string)obj10 + text;
				object obj11 = typeof(DataRelation) + 856;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v15+E4]");
				bool flag6 = (nint)0 == 0;
				object obj13 = !flag6;
				object message = text2;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					message = text2;
				}
				Debug.LogError(message);
			}
			return (int?)(object)0;
		}
		goto IL_02fa;
		IL_02fa:
		return (int?)new NullReferenceException();
	}

	private unsafe int? ResolvePileStateFromHandSizes(JackarooGame game, int batchCount)
	{
		//IL_02c2: Expected O, but got I
		//IL_02d2: Expected O, but got I
		//IL_02e2: Expected O, but got I
		//IL_0304: Expected O, but got I4
		//IL_0309: Expected I, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00e9: Expected I4, but got O
		//IL_0359: Expected O, but got I4
		//IL_0067: Expected O, but got I
		//IL_0077: Expected O, but got I
		//IL_0087: Expected O, but got I
		//IL_042f: Expected O, but got I4
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_04b5: Expected O, but got I
		//IL_04c6: Expected I, but got O
		//IL_04e4: Expected O, but got I
		//IL_0396: Expected I4, but got O
		//IL_03ba: Expected O, but got I4
		//IL_0389: Expected O, but got I
		//IL_03ef: Expected O, but got Ref
		//IL_0503: Expected native int or pointer, but got O
		//IL_0188: Expected O, but got I4
		//IL_0407: Expected O, but got Ref
		//IL_01ed: Expected O, but got I4
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0424: Expected O, but got Ref
		//IL_026b: Expected O, but got I4
		JackarooGame jackarooGame = default(JackarooGame);
		bool flag = (object)jackarooGame == null;
		JackarooGame jackarooGame2 = jackarooGame;
		int num2 = default(int);
		int num = num2;
		if (flag)
		{
			goto IL_0296;
		}
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 464;
		jackarooGame2 = (JackarooGame)(object)jackarooGame.<JackarooPlayers>k__BackingField;
		NullReferenceException ex = (NullReferenceException)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v5 (System.NullReferenceException)+E4]");
		bool flag2 = (nint)0 == 0;
		num = num2;
		if (flag2)
		{
			goto IL_02a4;
		}
		object obj2 = (nint)0 + (nint)1872;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v5 (System.NullReferenceException)+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v6+8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v6+8]");
		bool flag3 = (nint)0 == 0;
		num = num2;
		IntPtr intPtr = default(IntPtr);
		nint num3 = intPtr;
		object obj5 = obj2;
		object obj6 = obj;
		JackarooGame <JackarooPlayers>k__BackingField = (JackarooGame)(object)jackarooGame.<JackarooPlayers>k__BackingField;
		int num4 = num2;
		if (!flag3)
		{
			goto IL_00e1;
		}
		goto IL_0337;
		IL_0296:
		ex = new NullReferenceException();
		goto IL_02a4;
		IL_0429:
		return (int?)(object)0;
		IL_00e1:
		num2 = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCAA68");
		JackarooGame jackarooGame3 = default(JackarooGame);
		if ((object)jackarooGame3 != null)
		{
			goto IL_0110;
		}
		goto IL_0429;
		IL_0110:
		int[] cardsPerBatch = base.CardsPerBatch;
		int num5 = Enumerable.Sum(cardsPerBatch);
		int num6;
		int value;
		int? num7;
		int? num8 = default(int?);
		if ((nint)jackarooGame3 < num5)
		{
			int[] array = base.CardsPerBatch;
			bool flag4 = array == null;
			jackarooGame = null;
			jackarooGame2 = jackarooGame3;
			if (flag4)
			{
				goto IL_0296;
			}
			object obj7 = 0;
			num6 = 0;
			while (num6 < array.Length)
			{
				int[] cardsPerBatch2 = base.CardsPerBatch;
				bool flag5 = cardsPerBatch2 == null;
				jackarooGame = null;
				jackarooGame2 = jackarooGame3;
				num = num6;
				if (!flag5)
				{
					bool flag6 = num6 < cardsPerBatch2.Length;
					object obj8 = !flag6;
					if (obj8 != null)
					{
						return (int?)new IndexOutOfRangeException();
					}
					object obj9 = cardsPerBatch2 + num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v26+20]");
					obj7 = 0 + obj7;
					if (jackarooGame3 < obj7)
					{
						goto IL_040c;
					}
					int[] cardsPerBatch3 = base.CardsPerBatch;
					num = num6 + 1;
					bool flag7 = cardsPerBatch3 == null;
					object obj10 = !flag7;
					jackarooGame = null;
					jackarooGame2 = jackarooGame3;
					array = cardsPerBatch3;
					num6 = num;
					if (obj10 != null)
					{
						continue;
					}
				}
				goto IL_0296;
			}
			value = 0;
			num7 = (int?)(object)(&num8);
		}
		else
		{
			value = num;
			num7 = (int?)(object)(&num8);
		}
		goto IL_04fb;
		IL_040c:
		value = num6 + 1;
		num7 = (int?)(object)(&num8);
		goto IL_04fb;
		IL_02a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ex = (NullReferenceException)obj;
		obj2 = (nint)0 + (nint)1872;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v5 (System.NullReferenceException)+B8]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v6+8]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v6+8]");
		bool flag8 = (nint)0 == 0;
		object obj11 = !flag8;
		num3 = unchecked((nint)null);
		obj5 = obj2;
		obj6 = obj;
		<JackarooPlayers>k__BackingField = jackarooGame2;
		num4 = num;
		if (obj11 != null)
		{
			goto IL_00e1;
		}
		goto IL_0337;
		IL_04fb:
		*(int?*)(nint)num7 = value;
		goto IL_0429;
		IL_0337:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v5 (System.NullReferenceException)+E4]");
		bool flag9 = (nint)0 == 0;
		object obj12 = !flag9;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v12+B8]");
			obj3 = 0;
		}
		object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)1736;
		Func<object, int> func = default(Func<object, int>);
		func..ctor(obj3, (IntPtr)obj15);
		object obj16 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v11+B8]");
		object obj17 = (nint)0 + (nint)8;
		obj17 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num2 = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCAA68");
		bool flag10 = (object)jackarooGame3 == null;
		object obj18 = !flag10;
		obj = obj6;
		num = num4;
		if (obj18 != null)
		{
			goto IL_0110;
		}
		goto IL_0429;
	}
}
