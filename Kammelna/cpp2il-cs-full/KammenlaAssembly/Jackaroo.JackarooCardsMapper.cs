using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;

namespace Jackaroo;

public static class JackarooCardsMapper
{
	private static JackarooAllowedRules AllowedRules
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			//IL_0036: Expected I4, but got O
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			return (JackarooAllowedRules)obj3;
		}
	}

	public static JackarooActions GetJackarooActions(Card card)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_0059: Expected I4, but got O
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
		object obj3 = 0;
		if (IsCustomRule(card, (JackarooAllowedRules)obj3, out var jackarooActions))
		{
			return jackarooActions;
		}
		return GetDefaultJackarooActions(card);
	}

	public static JackarooActions GetJackarooActions(Card card, JackarooAllowedRules allowedRules)
	{
		if (IsCustomRule(card, allowedRules, out var jackarooActions))
		{
			return jackarooActions;
		}
		return GetDefaultJackarooActions(card);
	}

	private unsafe static bool IsCustomRule(Card card, JackarooAllowedRules allowedRules, out JackarooActions jackarooActions)
	{
		//IL_056e: Expected I4, but got O
		//IL_00be: Expected O, but got I4
		//IL_048d: Expected O, but got I4
		//IL_00ec: Expected O, but got I4
		//IL_047f: Expected O, but got I4
		//IL_02f4: Expected O, but got I4
		//IL_025d: Expected O, but got I4
		//IL_014e: Expected O, but got I4
		//IL_00de: Expected O, but got I4
		//IL_0414: Expected O, but got I4
		//IL_04be: Expected O, but got I4
		//IL_028b: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		//IL_0442: Expected O, but got I4
		//IL_032e: Expected O, but got I4
		//IL_04ec: Expected O, but got I4
		//IL_027d: Expected O, but got I4
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected O, but got Unknown
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected O, but got Unknown
		//IL_0434: Expected O, but got I4
		//IL_04de: Expected O, but got I4
		//IL_05f2: Expected O, but got I4
		//IL_060c: Expected O, but got I4
		//IL_054e: Expected O, but got I4
		if (allowedRules == JackarooAllowedRules.DEFAULT)
		{
			goto IL_0447;
		}
		Rank <Rank>k__BackingField;
		ref JackarooActions reference;
		if (card != null)
		{
			<Rank>k__BackingField = card.<Rank>k__BackingField;
			if (card.<Rank>k__BackingField == Rank.JACK)
			{
				if (CardUtilExtensions.IsRed(card))
				{
					bool flag = JackarooAllowedRulesExtensions.HasRuleFlag(allowedRules, JackarooAllowedRules.JACK_RED_SWAP);
					bool flag2 = !flag;
					object obj = !flag2;
					object obj2 = ~obj;
					object obj3 = ((obj2 != null) ? ((object)1) : ((object)8192));
					reference = ref *(JackarooActions*)obj3;
					return flag;
				}
				if (CardUtilExtensions.IsBlack(card))
				{
					bool flag3 = JackarooAllowedRulesExtensions.HasRuleFlag(allowedRules, JackarooAllowedRules.JACK_BLACK_MOVE);
					object obj4 = (flag3 ? ((object)1) : ((object)8192));
					reference = ref *(JackarooActions*)obj4;
					return flag3;
				}
				<Rank>k__BackingField = card.<Rank>k__BackingField;
			}
			if (<Rank>k__BackingField == Rank.QUEEN)
			{
				if (CardUtilExtensions.IsRed(card))
				{
					if (JackarooAllowedRulesExtensions.HasRuleFlag(allowedRules, JackarooAllowedRules.QUEEN_RED_MOVE))
					{
						reference = ref *(JackarooActions*)1;
						return true;
					}
					bool flag4 = JackarooAllowedRulesExtensions.HasRuleFlag(allowedRules, JackarooAllowedRules.QUEEN_RED_STEAL);
					bool flag5 = !flag4;
					object obj5 = !flag5;
					object obj6 = ~obj5;
					object obj7 = ((obj6 != null) ? ((object)65536) : ((object)262144));
					reference = ref *(JackarooActions*)obj7;
					return flag4;
				}
				if (CardUtilExtensions.IsBlack(card))
				{
					if (JackarooAllowedRulesExtensions.HasRuleFlag(allowedRules, JackarooAllowedRules.QUEEN_BLACK_BURN))
					{
						reference = ref *(JackarooActions*)65536;
						return true;
					}
					bool flag6 = JackarooAllowedRulesExtensions.HasRuleFlag(allowedRules, JackarooAllowedRules.QUEEN_BLACK_STEAL);
					bool flag7 = !flag6;
					object obj8 = !flag7;
					object obj9 = ~obj8;
					object obj10 = ((obj9 != null) ? ((object)1) : ((object)262144));
					reference = ref *(JackarooActions*)obj10;
					return flag6;
				}
				<Rank>k__BackingField = card.<Rank>k__BackingField;
			}
			if (<Rank>k__BackingField == Rank.KING)
			{
				JackarooAllowedRules flag12;
				JackarooAllowedRules jackarooAllowedRules;
				if (CardUtilExtensions.IsRed(card))
				{
					bool flag8 = JackarooAllowedRulesExtensions.HasRuleFlag(allowedRules, JackarooAllowedRules.KING_RED_PLANT);
					bool flag9 = !flag8;
					object obj11 = !flag9;
					if (obj11 != null)
					{
						goto IL_03a7;
					}
					bool flag10 = JackarooAllowedRulesExtensions.HasRuleFlag(allowedRules, JackarooAllowedRules.KING_RED_MOVE_EAT_PATH);
					bool flag11 = !flag10;
					object obj12 = !flag11;
					if (obj12 != null)
					{
						goto IL_0520;
					}
					flag12 = JackarooAllowedRules.KING_RED_PLANT_MOVE_NO_KILL;
					jackarooAllowedRules = allowedRules;
				}
				else
				{
					if (!CardUtilExtensions.IsBlack(card))
					{
						<Rank>k__BackingField = card.<Rank>k__BackingField;
						goto IL_05b5;
					}
					if (JackarooAllowedRulesExtensions.HasRuleFlag(allowedRules, JackarooAllowedRules.KING_BLACK_PLANT))
					{
						goto IL_03a7;
					}
					if (JackarooAllowedRulesExtensions.HasRuleFlag(allowedRules, JackarooAllowedRules.KING_BLACK_MOVE_EAT_PATH))
					{
						goto IL_0520;
					}
					flag12 = JackarooAllowedRules.KING_BLACK_PLANT_MOVE_NO_KILL;
					jackarooAllowedRules = allowedRules;
				}
				bool flag13 = JackarooAllowedRulesExtensions.HasRuleFlag(jackarooAllowedRules, flag12);
				object obj13 = 131073 + 7;
				bool flag14 = !flag13;
				object obj14 = !flag14;
				object obj15 = ~obj14;
				object obj16 = ((obj15 != null) ? obj13 : ((object)131073));
				reference = ref *(JackarooActions*)obj16;
				return flag13;
			}
			goto IL_05b5;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0447:
		reference = ref *(JackarooActions*)null;
		return false;
		IL_05b5:
		switch (<Rank>k__BackingField)
		{
		case Rank.ACE:
		{
			bool flag16 = JackarooAllowedRulesExtensions.HasRuleFlag(allowedRules, JackarooAllowedRules.ACE_MOVE_1_PLANT);
			bool flag17 = !flag16;
			object obj18 = !flag17;
			object obj19 = ~obj18;
			object obj20 = ((obj19 != null) ? ((object)47) : ((object)15));
			object obj21 = obj20 + 131072;
			object obj22 = obj21 + 1;
			reference = ref *(JackarooActions*)obj22;
			return flag16;
		}
		case Rank.TEN:
		{
			bool flag15 = JackarooAllowedRulesExtensions.HasRuleFlag(allowedRules, JackarooAllowedRules.TEN_MOVE);
			object obj17 = (flag15 ? ((object)1) : ((object)32769));
			reference = ref *(JackarooActions*)obj17;
			return flag15;
		}
		}
		goto IL_0447;
		IL_03a7:
		reference = ref *(JackarooActions*)131072;
		return true;
		IL_0520:
		reference = ref *(JackarooActions*)8;
		return true;
	}

	private static JackarooActions GetDefaultJackarooActions(Card card)
	{
		//IL_002c: Expected O, but got I4
		//IL_003f: Expected O, but got I4
		//IL_0059: Expected O, but got I4
		//IL_00b5: Expected I, but got O
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		//IL_0099: Expected O, but got I
		//IL_010d: Expected O, but got I
		//IL_012a: Expected I4, but got O
		Rank <Rank>k__BackingField = card.<Rank>k__BackingField;
		bool flag = card.<Rank>k__BackingField < Rank.ACE;
		object obj = !flag;
		object obj2 = card.<Rank>k__BackingField - 12;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 == null)
		{
			object obj5 = 119877632 + 808;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X9_v3+v12 @ X0_v16 (Rank)]");
			object obj6 = (nint)85834936 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v44 @ X10_v2 (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		Card card2 = default(Card);
		nint num = (nint)card2;
		string message = card2.ToString();
		object obj7 = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor(message);
		object obj8 = (nint)0 + (nint)488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (JackarooActions)ex2;
	}
}
