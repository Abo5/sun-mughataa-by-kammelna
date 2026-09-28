using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Sfs2X.Entities.Data;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.UI;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;

namespace KammelnaOffline.Baloot.Tutorial;

public static class TutorialCards
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<CardData, int> <>9__130_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 232;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <AddArrayCards>b__130_0(CardData cardData)
		{
			//IL_004a: Expected I4, but got O
			Card card = CardDataExtension.ToCard(cardData);
			if (card != null)
			{
				return card.AsInt();
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public static readonly Dictionary<TutorialType, List<string>> CheatingCases;

	public static readonly Dictionary<TutorialType, int> catchMove;

	private static readonly List<Card> cardsAI2Sun;

	private static readonly List<Card> cardsAI3Sun;

	private static readonly List<Card> cardsAI4Sun;

	private static readonly List<Card> cardsAI2AdvancedSun;

	private static readonly List<Card> cardsAI3AdvancedSun;

	private static readonly List<Card> cardsAI4AdvancedSun;

	private static readonly List<Card> cardsAI2Hokom;

	private static readonly List<Card> cardsAI3Hokom;

	private static readonly List<Card> cardsAI4Hokom;

	private static readonly List<Card> cardsAI2AdvancedHokom;

	private static readonly List<Card> cardsAI3AdvancedHokom;

	private static readonly List<Card> cardsAI4AdvancedHokom;

	private static readonly List<Card> cardsAI2Catch;

	private static readonly List<Card> cardsAI3Catch;

	private static readonly List<Card> cardsAI4Catch;

	private static readonly List<Card> cardsAI2CatchSun;

	private static readonly List<Card> cardsAI3CatchSun;

	private static readonly List<Card> cardsAI4CatchSun;

	private static readonly List<Card> CardsAI2CatchClosedDbl;

	private static readonly List<Card> CardsAI3CatchClosedDbl;

	private static readonly List<Card> CardsAI4CatchClosedDbl;

	private static readonly List<Card> CardsAI2CatchHokomCut;

	private static readonly List<Card> CardsAI3CatchHokomCut;

	private static readonly List<Card> CardsAI4CatchHokomCut;

	private static readonly List<Card> CardsAI2CatchHokomUp;

	private static readonly List<Card> CardsAI3CatchHokomUp;

	private static readonly List<Card> CardsAI4CatchHokomUp;

	private static readonly List<Card> CardsAI2CatchHokomHKMCut;

	private static readonly List<Card> CardsAI3CatchHokomHKMCut;

	private static readonly List<Card> CardsAI4CatchHokomHKMCut;

	private static readonly List<Card> CardsAI2CatchWrongSawa;

	private static readonly List<Card> CardsAI3CatchWrongSawa;

	private static readonly List<Card> CardsAI4CatchWrongSawa;

	public static readonly List<Card> FirstPhaseDummyList;

	public static readonly List<Card> SecondPhaseDummyList;

	public static readonly List<Card> AI1Sawa1stPhase;

	public static readonly List<Card> AI1Sawa2ndPhase;

	public static readonly List<Card> AI2Sawa1stPhase;

	public static readonly List<Card> AI2Sawa2ndPhase;

	public static readonly List<Card> AI3Sawa1stPhase;

	public static readonly List<Card> AI3Sawa2ndPhase;

	public static readonly List<Card> Player2HokomCards1stPhase;

	public static readonly List<Card> Player2HokomCards2ndPhase;

	public static readonly List<Card> Player1AdvHokomCards1stPhase;

	public static readonly List<Card> Player1AdvHokomCards2ndPhase;

	private static readonly List<Card> firstPhase_Sun;

	private static readonly List<Card> firstPhase_AdvancedSun;

	private static readonly List<Card> firstPhase_Hokom;

	private static readonly List<Card> firstPhase_AdvancedHokom;

	private static readonly List<Card> firstPhase_Catch;

	private static readonly List<Card> firstPhase_CatchSun;

	private static readonly List<Card> firstPhase_CatchClosedDbl;

	private static readonly List<Card> firstPhase_CatchHokomCut;

	private static readonly List<Card> firstPhase_CatchHokomUp;

	private static readonly List<Card> firstPhase_CatchHokomHKMCut;

	private static readonly List<Card> firstPhase_CatchWrongSawa;

	private static readonly List<Card> secondPhase_Sun;

	private static readonly List<Card> secondPhase_AdvancedSun;

	private static readonly List<Card> secondPhase_Hokom;

	private static readonly List<Card> secondPhase_AdvancedHokom;

	private static readonly List<Card> secondPhase_Catch;

	private static readonly List<Card> secondPhase_CatchSun;

	private static readonly List<Card> secondPhase_CatchclosedDbl;

	private static readonly List<Card> secondPhase_CatchHokomCut;

	private static readonly List<Card> secondPhase_CatchHokomUp;

	private static readonly List<Card> secondPhase_CatchHokomHKMCut;

	private static readonly List<Card> secondPhase_CatchWrongSawa;

	private static readonly List<Card> eating1;

	private static readonly List<Card> eating2;

	private static readonly List<Card> eating3;

	private static readonly List<Card> eating1_CatchSun;

	private static readonly List<Card> eating2_CatchSun;

	private static readonly List<Card> eating3_CatchSun;

	private static readonly List<Card> eating1_CatchClosedDbl;

	private static readonly List<Card> eating2_CatchClosedDbl;

	private static readonly List<Card> eating1_CatchHokomCut;

	private static readonly List<Card> eating2_CatchHokomCut;

	private static readonly List<Card> eating3_CatchHokomCut;

	private static readonly List<Card> eating4_CatchHokomCut;

	private static readonly List<Card> eating1_CatchHokomUp;

	private static readonly List<Card> eating2_CatchHokomUp;

	private static readonly List<Card> eating3_CatchHokomUp;

	private static readonly List<Card> eating1_CatchHokomHKMCut;

	private static readonly List<Card> eating2_CatchHokomHKMCut;

	private static readonly List<Card> eating3_CatchHokomHKMCut;

	private static readonly List<Card> hand1;

	private static readonly List<Card> hand2;

	private static readonly List<Card> hand3;

	private static readonly List<Card> hand4;

	private static readonly List<Card> hand1_CatchSun;

	private static readonly List<Card> hand2_CatchSun;

	private static readonly List<Card> hand3_CatchSun;

	private static readonly List<Card> hand4_CatchSun;

	private static readonly List<Card> hand1_CatchClosedDbl;

	private static readonly List<Card> hand2_CatchClosedDbl;

	private static readonly List<Card> hand3_CatchClosedDbl;

	private static readonly List<Card> hand4_CatchClosedDbl;

	private static readonly List<Card> hand1_CatchHokomCut;

	private static readonly List<Card> hand2_CatchHokomCut;

	private static readonly List<Card> hand3_CatchHokomCut;

	private static readonly List<Card> hand4_CatchHokomCut;

	private static readonly List<Card> hand1_CatchHokomUp;

	private static readonly List<Card> hand2_CatchHokomUp;

	private static readonly List<Card> hand3_CatchHokomUp;

	private static readonly List<Card> hand4_CatchHokomUp;

	private static readonly List<Card> hand1_CatchHokomHKMCut;

	private static readonly List<Card> hand2_CatchHokomHKMCut;

	private static readonly List<Card> hand3_CatchHokomHKMCut;

	private static readonly List<Card> hand4_CatchHokomHKMCut;

	private static readonly List<Card> hand1_CatchWrongSawa;

	private static readonly List<Card> hand2_CatchWrongSawa;

	private static readonly List<Card> hand3_CatchWrongSawa;

	private static readonly List<Card> hand4_CatchWrongSawa;

	private static readonly List<Card>[] cardsWantedToPlay_Sun;

	private static readonly List<Card>[] cardsWantedToPlay_AdvSun;

	private static readonly List<Card>[] cardsWantedToPlay_Hokom;

	private static readonly List<Card>[] cardsWantedToPlay_AdvHokom;

	private static readonly List<Card>[] cardsWantedToPlay_Catch;

	private static readonly List<Card>[] cardsWantedToPlay_CatchSun;

	private static readonly List<Card>[] cardsWantedToPlay_CatchHokomDbl;

	private static readonly List<Card>[] cardsWantedToPlay_CatchHokomCut;

	private static readonly List<Card>[] cardsWantedToPlay_CatchHokomUp;

	private static readonly List<Card>[] cardsWantedToPlay_CatchHokomHKMCut;

	private static readonly List<Card>[] cardsWantedToPlay_CatchWrongSawa;

	public static List<Card> GetDistributionFirstPhase(TutorialType type)
	{
		//IL_0111: Expected O, but got I4
		//IL_012b: Expected O, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0153: Expected O, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_002a: Expected O, but got I
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I
		TutorialType tutorialType = default(TutorialType);
		object obj = tutorialType - 1;
		bool flag = (nint)obj < 10;
		object obj2 = !flag;
		object obj3 = obj - 10;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 119877632 + 1036;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v2+v41 @ X8_v3]");
			object obj7 = (nint)86028420 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v57 @ X10_v2 (should have been resolved before IL gen)");
		}
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj9 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = "tournament_participate_warning_body_with_tickets_warning_daily" + 968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		object obj11 = "ThisIsFakeReceiptData" + 2688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		string message = default(string);
		ex..ctor(paramName, actualValue, message);
		object obj12 = (nint)0 + (nint)2256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (List<Card>)(object)new OutOfMemoryException();
	}

	public static List<Card> GetDistributionSecondPhase(TutorialType type)
	{
		//IL_0111: Expected O, but got I4
		//IL_012b: Expected O, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0153: Expected O, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_002a: Expected O, but got I
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I
		TutorialType tutorialType = default(TutorialType);
		object obj = tutorialType - 1;
		bool flag = (nint)obj < 10;
		object obj2 = !flag;
		object obj3 = obj - 10;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 119877632 + 1047;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v2+v41 @ X8_v3]");
			object obj7 = (nint)86028984 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v57 @ X10_v2 (should have been resolved before IL gen)");
		}
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj9 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = "tournament_participate_warning_body_with_tickets_warning_daily" + 968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		object obj11 = "ThisIsFakeReceiptData" + 2688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		string message = default(string);
		ex..ctor(paramName, actualValue, message);
		object obj12 = (nint)0 + (nint)2264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (List<Card>)(object)new OutOfMemoryException();
	}

	public static Card GetFloor(TutorialType type)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		//IL_0090: Expected O, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_014c: Expected O, but got I
		object obj = type - 1;
		bool flag = (nint)obj < 10;
		object obj2 = !flag;
		object obj3 = obj - 10;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 119877632 + 1058;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X9_v2+v0 @ X8_v1]");
			object obj7 = (nint)86029492 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v17 @ X10_v2 (should have been resolved before IL gen)");
		}
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj9 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = "tournament_participate_warning_body_with_tickets_warning_daily" + 968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		object obj11 = "ThisIsFakeReceiptData" + 2688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		string message = default(string);
		ex..ctor(paramName, actualValue, message);
		object obj12 = (nint)0 + (nint)2272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (Card)(object)new OutOfMemoryException();
	}

	public static SFSArray GetHandSFSArray(TutorialGame tutorialGame)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 1888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray = default(SFSArray);
		sFSArray..ctor();
		if ((object)tutorialGame != null)
		{
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2272;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = AddArrayCards(sFSArray, tutorialGame._hand1);
			bool flag3 = AddArrayCards(sFSArray, tutorialGame._hand2);
			bool flag4 = AddArrayCards(sFSArray, tutorialGame._hand3);
			bool flag5 = AddArrayCards(sFSArray, tutorialGame._hand4);
			return sFSArray;
		}
		return (SFSArray)(object)new NullReferenceException();
	}

	private static bool AddArrayCards(ISFSArray array, IReadOnlyCollection<CardData> cardsData)
	{
		//IL_0355: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_01a6: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_041a: Expected O, but got I
		//IL_042a: Expected O, but got I
		//IL_044c: Expected O, but got I4
		//IL_03f6: Expected O, but got I4
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected I4, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0131: Expected O, but got I
		//IL_01ed: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected O, but got Unknown
		//IL_0484: Expected O, but got I
		//IL_0495: Expected I, but got O
		//IL_04b3: Expected O, but got I
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_027e: Expected I, but got O
		//IL_028e: Expected O, but got I
		//IL_021d: Expected O, but got I
		//IL_02c9: Expected O, but got I
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		if (cardsData == null)
		{
			goto IL_0347;
		}
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2176;
		nint num = (nint)cardsData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<CardData>>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<CardData>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<CardData>>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X10_v13-8]");
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
		object obj4 = num + obj3;
		object obj5 = obj4 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v32+8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v259 @ X0_v32] (should have been resolved before IL gen)");
		object obj7 = default(object);
		bool flag = (nint)obj7 < 1;
		object obj8 = obj7;
		object obj9 = obj7;
		if (!flag)
		{
			goto IL_0168;
		}
		goto IL_0396;
		IL_0168:
		object obj10 = typeof(TrackedDeviceRaycaster.<>c) + 232;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v8+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+8]");
		Func<CardData, int> selector = (Func<CardData, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+8]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj16 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v24+B8]");
				obj13 = 0;
			}
			object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)848;
			Func<CardData, int> func = default(Func<CardData, int>);
			func..ctor(obj13, (IntPtr)obj18);
			object obj19 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v23+B8]");
			object obj20 = (nint)0 + (nint)8;
			obj20 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<int> source = Enumerable.Select(cardsData, selector);
		int[] array2 = Enumerable.ToArray(source);
		if (array == null)
		{
			goto IL_0347;
		}
		object obj21 = typeof(System.IOAsyncCallback) + 960;
		nint num2 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_030a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
		object obj23 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X10_v8-8]");
			if (0 == (nint)obj21)
			{
				break;
			}
			obj23 += 16;
			obj22--;
			if ((nint)obj22 != 1)
			{
				continue;
			}
			goto IL_030a;
		}
		object obj24 = obj23 + 23;
		object obj25 = num2 + obj24;
		object obj26 = obj25 + 312;
		goto IL_04f6;
		IL_0347:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0396:
		bool flag5 = (nint)obj9 < 0;
		bool flag6 = obj9 == null;
		object obj27 = obj9 ^ obj9;
		object obj28 = obj9 & obj27;
		bool flag7 = (nint)obj28 < 0;
		bool flag8 = flag5 == flag7;
		object obj29 = !flag6;
		return (byte)((flag8 & obj29) ? 1 : 0) != 0;
		IL_04f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v429 @ X0_v13] (should have been resolved before IL gen)");
		obj9 = obj8;
		goto IL_0396;
		IL_030a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_04f6;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v29+8]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v154 @ X0_v29] (should have been resolved before IL gen)");
		object obj30 = default(object);
		bool flag9 = (nint)obj30 >= 1;
		obj8 = obj30;
		if (flag9)
		{
			goto IL_0168;
		}
		obj9 = obj30;
		goto IL_0396;
	}
}
