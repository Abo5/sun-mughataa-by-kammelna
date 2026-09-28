using System;
using System.Data;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class Rater : MonoBehaviour
{
	public enum RatingStatus
	{
		New,
		Rated,
		DidNotLike,
		AskLater
	}

	private int numberOfwinsNeededToRate;

	private float numberOfHoursNeededToRate;

	public static RatingStatus Status
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001b: Expected O, but got I
			object obj = "_InputUv1BufferOffset" + 1576;
			object obj2 = (nint)0 + (nint)2496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F812BC");
			RatingStatus result = default(RatingStatus);
			return result;
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001b: Expected O, but got I
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			//IL_0094: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = "_InputUv1BufferOffset" + 1576;
			object obj2 = (nint)0 + (nint)2544;
			object obj3 = typeof(DataRelation) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81564");
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			object key = "DNQUALIFIER" + 1328;
			Prefs.SetDate((string)key, now);
		}
	}

	private static DateTime DateSinceRatingReminder
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_0069: Expected O, but got I4
			//IL_0087: Expected O, but got I
			//IL_009c: Expected O, but got I
			object obj = typeof(DataRelation) + 712;
			object key = "DNQUALIFIER" + 1328;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+10]");
			return Prefs.GetDate((string)key, (DateTime)0);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "DNQUALIFIER" + 1328;
			Prefs.SetDate((string)key, value);
		}
	}

	private static int DidNotLikeCounter
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "[{0}]:{1}" + 936;
			return Prefs.GetInt((string)key, 1);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "[{0}]:{1}" + 936;
			int num = Prefs.GetInt((string)key, value);
		}
	}

	private static int AskLaterCounter
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "[{0}]:{1}" + 944;
			return Prefs.GetInt((string)key, 1);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "[{0}]:{1}" + 944;
			int num = Prefs.GetInt((string)key, value);
		}
	}

	private float requiredSeconds
	{
		get
		{
			float num = numberOfHoursNeededToRate * 1.1146363E+09f;
			return num * 1.1146363E+09f;
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ce: Expected O, but got I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0172: Expected O, but got I4
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_020d: Expected O, but got I4
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_08be: Expected O, but got I4
		//IL_01ef: Expected O, but got I4
		//IL_093d: Expected O, but got I
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected O, but got Unknown
		//IL_0961: Expected O, but got I
		//IL_098f: Expected O, but got I4
		//IL_04c8: Expected O, but got I
		//IL_04e2: Expected O, but got I4
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected O, but got Unknown
		//IL_068b: Expected O, but got I4
		//IL_0397: Expected O, but got I4
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c9: Expected O, but got Unknown
		//IL_07f3: Expected O, but got I4
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_0403: Expected O, but got I4
		//IL_052e: Expected O, but got I4
		//IL_08dc: Expected O, but got I
		//IL_08f1: Expected O, but got I
		//IL_091f: Expected O, but got I4
		//IL_0700: Expected O, but got I4
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_059a: Expected O, but got I4
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_029b: Expected O, but got I4
		//IL_0478: Expected O, but got I4
		//IL_0310: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A4D]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v129+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v129+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform == Platform.Web)
		{
			return;
		}
		goto IL_0111;
		IL_0111:
		if (!Conditions())
		{
			return;
		}
		object obj5 = typeof(DataRelation) + 712;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		object obj8 = "_InputUv1BufferOffset" + 1576;
		object obj9 = (nint)0 + (nint)2496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F812BC");
		object obj10 = default(object);
		TimeSpan timeSpan2 = default(TimeSpan);
		if ((nint)obj10 != 3)
		{
			if ((nint)obj10 != 2)
			{
				bool flag3 = obj10 == null;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					ShowRatingConfirmation();
				}
				return;
			}
			object obj12 = 152989696;
			object key = "[{0}]:{1}" + 936;
			int num = Prefs.GetInt((string)key, 1);
			if (num == 1)
			{
				object key2 = "DNQUALIFIER" + 1328;
				object obj13 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v93+E4]");
				bool flag4 = (nint)0 == 0;
				object obj14 = !flag4;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj13 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v93+B8]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v43+10]");
				DateTime date = Prefs.GetDate((string)key2, (DateTime)0);
				object obj16 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v96+E4]");
				bool flag5 = (nint)0 == 0;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				TimeSpan timeSpan = now - date;
				object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v100+E4]");
				bool flag6 = (nint)0 == 0;
				object obj20 = !flag6;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double totalDays = timeSpan2.TotalDays;
				if (totalDays < 4.000000000698492)
				{
					return;
				}
				object obj21 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X0_v103+E4]");
				bool flag7 = (nint)0 == 0;
				object obj22 = !flag7;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now2 = DateTime.Now;
				DateSinceRatingReminder = now2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X21_v10+A4B]");
				object obj23 = (nint)0 & (nint)1;
				bool flag8 = obj23 == null;
				object obj24 = !flag8;
				if (obj24 == null)
				{
					_ = 1;
				}
				int num2 = Prefs.GetInt((string)key, 1);
				if (num2 != 2)
				{
					return;
				}
				DateTime dateSinceRatingReminder = DateSinceRatingReminder;
				object obj25 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v79+E4]");
				bool flag9 = (nint)0 == 0;
				object obj26 = !flag9;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				TimeSpan timeSpan3 = now - dateSinceRatingReminder;
				object obj27 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj28 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v83+E4]");
				bool flag10 = (nint)0 == 0;
				object obj29 = !flag10;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double totalDays2 = timeSpan2.TotalDays;
				if (totalDays2 < 16.00000000325963)
				{
					return;
				}
			}
			int didNotLikeCounter = DidNotLikeCounter;
			int didNotLikeCounter2 = didNotLikeCounter + 1;
			DidNotLikeCounter = didNotLikeCounter2;
		}
		else
		{
			object key3 = "[{0}]:{1}" + 944;
			int num3 = Prefs.GetInt((string)key3, 1);
			if (num3 > 4)
			{
				int num4 = Prefs.GetInt((string)key3, 1);
				if (num4 < 5)
				{
					return;
				}
				DateTime dateSinceRatingReminder2 = DateSinceRatingReminder;
				object obj30 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X0_v49+E4]");
				bool flag11 = (nint)0 == 0;
				object obj31 = !flag11;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				TimeSpan timeSpan4 = now - dateSinceRatingReminder2;
				object obj32 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj33 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X0_v53+E4]");
				bool flag12 = (nint)0 == 0;
				object obj34 = !flag12;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double totalDays3 = timeSpan2.TotalDays;
				if (totalDays3 < 4.000000000698492)
				{
					return;
				}
				object obj35 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X0_v56+E4]");
				bool flag13 = (nint)0 == 0;
				object obj36 = !flag13;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now3 = DateTime.Now;
				DateSinceRatingReminder = now3;
			}
			else
			{
				object obj37 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X0_v18+E4]");
				bool flag14 = (nint)0 == 0;
				object obj38 = !flag14;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj37 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X0_v18+B8]");
				object obj39 = 0;
				object key4 = "DNQUALIFIER" + 1328;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v12+10]");
				DateTime date2 = Prefs.GetDate((string)key4, (DateTime)0);
				object obj40 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v21+E4]");
				bool flag15 = (nint)0 == 0;
				object obj41 = !flag15;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				TimeSpan timeSpan5 = now - date2;
				object obj42 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj43 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X0_v25+E4]");
				bool flag16 = (nint)0 == 0;
				object obj44 = !flag16;
				if (obj44 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double totalDays4 = timeSpan2.TotalDays;
				if (totalDays4 < 2.0000000002328306)
				{
					return;
				}
				object obj45 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v28+E4]");
				bool flag17 = (nint)0 == 0;
				object obj46 = !flag17;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now4 = DateTime.Now;
				DateSinceRatingReminder = now4;
				int askLaterCounter = AskLaterCounter;
				int askLaterCounter2 = askLaterCounter + 1;
				AskLaterCounter = askLaterCounter2;
			}
		}
		ShowRatingConfirmation();
		return;
		IL_0074:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 == Platform.Web)
		{
			return;
		}
		goto IL_0111;
	}

	private bool Conditions()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d6: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_013f: Expected O, but got I4
		//IL_018f: Invalid comparison between F4 and I4
		//IL_01a0: Expected O, but got I4
		//IL_01b8: Invalid comparison between F4 and I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_020c: Expected O, but got I4
		//IL_0241: Expected O, but got I4
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected I4, but got Unknown
		object obj = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7976]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool lastGameWon = UserInfo.LastGameWon;
		if (!lastGameWon)
		{
			goto IL_00a1;
		}
		goto IL_0115;
		IL_00a1:
		return lastGameWon;
		IL_0115:
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int timePlayed = UserInfo.TimePlayed;
		float num = numberOfHoursNeededToRate * 1.1146363E+09f;
		float num2 = num * 1.1146363E+09f;
		bool flag3 = num2 < (float)timePlayed;
		object obj7 = !flag3;
		float num3 = num2 - (float)timePlayed;
		bool flag4 = num3 == 0f;
		object obj8 = ~obj7;
		object obj9 = obj8 | flag4;
		if (obj9 == null)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v7+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int rateUsWins = UserInfo.RateUsWins;
			object obj12 = rateUsWins - numberOfwinsNeededToRate;
			bool flag6 = (nint)obj12 < 0;
			int num4 = rateUsWins ^ numberOfwinsNeededToRate;
			int num5 = rateUsWins ^ obj12;
			int num6 = num4 & num5;
			bool flag7 = num6 < 0;
			return flag6 == flag7;
		}
		return true;
		IL_0074:
		lastGameWon = UserInfo.LastGameWon;
		bool flag8 = !lastGameWon;
		object obj13 = !flag8;
		if (obj13 == null)
		{
			goto IL_00a1;
		}
		goto IL_0115;
	}

	private void ShowRatingConfirmation()
	{
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected O, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected O, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0040: Expected I, but got O
		//IL_0050: Expected O, but got I
		//IL_07b0: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01b2: Expected O, but got I
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01d9: Expected O, but got I
		//IL_008b: Expected O, but got I
		//IL_06c3: Expected I, but got O
		//IL_0214: Expected O, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected I, but got Unknown
		//IL_02b4: Expected O, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected I, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_02ea: Expected O, but got I
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_0311: Expected O, but got I
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_070a: Expected I, but got O
		//IL_072c: Expected I, but got O
		//IL_034c: Expected O, but got I
		//IL_03e4: Expected O, but got I4
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_0412: Expected O, but got I
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_04a8: Expected I, but got O
		//IL_04ca: Expected O, but got I4
		//IL_044d: Expected O, but got I
		//IL_04e8: Expected I, but got O
		//IL_04f8: Expected O, but got I
		//IL_0587: Expected O, but got I4
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected O, but got Unknown
		//IL_05b7: Expected I, but got O
		//IL_05db: Expected O, but got I4
		//IL_05e4: Expected O, but got I4
		//IL_0533: Expected O, but got I
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected O, but got Unknown
		//IL_078a: Expected O, but got I4
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7977]");
		nint num = 0;
		PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateBuilder(PopupWindow.MessageType.Action);
		object obj4;
		object obj5 = default(object);
		object obj7 = default(object);
		if (popupWindowBuilder != null)
		{
			object obj = typeof(System.IOAsyncCallback) + 392;
			object obj2 = "WhiteSmoke" + 2192;
			nint num2 = (nint)popupWindowBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v10 (Il2CppClass<PopupWindowBuilder>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v10 (Il2CppClass<PopupWindowBuilder>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v10 (Il2CppClass<PopupWindowBuilder>)+B0]");
			obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X10_v13-8]");
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
			object obj6 = num2 + obj4;
			num = (nint)(obj6 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v280 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag2 = obj7 == null;
			obj5 = obj4;
			if (!flag2)
			{
				goto IL_016f;
			}
		}
		goto IL_05f2;
		IL_06a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v280 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		object obj8;
		action..ctor(this, (IntPtr)obj8);
		object label;
		PopupButton popupButton = PopupButton.Positive((string)label, action);
		object obj9 = default(object);
		bool flag3 = obj9 == null;
		object obj10 = 0;
		obj5 = obj4;
		if (flag3)
		{
			goto IL_05f2;
		}
		object obj11 = typeof(System.IOAsyncCallback) + 368;
		object obj12 = (nint)0 + (nint)1504;
		object label2 = "Network Authentication Required" + 248;
		object obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v16+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v16+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0395;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v16+B0]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X10_v21-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj4 = obj15 + 16;
			obj14--;
			bool flag4 = (nint)obj14 != 1;
			obj15 = obj4;
			if (flag4)
			{
				continue;
			}
			goto IL_0395;
		}
		object obj16 = obj13 + obj15;
		object obj17 = obj16 + 312;
		obj4 = obj15;
		goto IL_0702;
		IL_0600:
		object obj18 = obj5 + 9;
		object obj19 = num + obj18;
		object obj20 = obj19 + 312;
		goto IL_0798;
		IL_0496:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj21 = default(object);
		num = (nint)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v567 @ X0_v26] (should have been resolved before IL gen)");
		NullReferenceException ex = default(NullReferenceException);
		bool flag5 = ex == null;
		obj10 = 0;
		obj5 = obj4;
		if (!flag5)
		{
			goto IL_04e0;
		}
		goto IL_05f2;
		IL_04e0:
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0574;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X10_v2-8]");
			bool flag6 = 0 == (nint)obj11;
			obj10 = 0;
			if (flag6)
			{
				break;
			}
			obj5 += 16;
			obj22--;
			if ((nint)obj22 != 1)
			{
				continue;
			}
			goto IL_0574;
		}
		goto IL_0600;
		IL_0574:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj10 = 0;
		object obj23 = default(object);
		obj20 = obj23;
		goto IL_0798;
		IL_00d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v241 @ X0_v37 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag7 = obj7 == null;
		object obj24 = !flag7;
		obj4 = obj5;
		if (obj24 != null)
		{
			goto IL_016f;
		}
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		goto IL_05f2;
		IL_016f:
		object obj25 = typeof(System.IOAsyncCallback) + 384;
		object obj26 = "getSecondRescanTask" + 2664;
		object obj27 = typeof(SqlSingle[]) + 2376;
		obj8 = (nint)0 + (nint)1520;
		label = "WhiteSmoke" + 1504;
		object obj28 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v14+12E]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v14+12E]");
		if ((nint)0 == 0)
		{
			goto IL_025d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v14+B0]");
		object obj30 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X10_v26-8]");
			if (0 == (nint)obj25)
			{
				break;
			}
			obj4 = obj30 + 16;
			obj29--;
			bool flag8 = (nint)obj29 != 1;
			obj30 = obj4;
			if (flag8)
			{
				continue;
			}
			goto IL_025d;
		}
		object obj31 = obj28 + obj30;
		num = (nint)(obj31 + 312);
		obj4 = obj30;
		goto IL_06a1;
		IL_05f2:
		ex = new NullReferenceException();
		goto IL_0600;
		IL_0395:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0702;
		IL_0702:
		num = (nint)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v536 @ X0_v15] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj12);
		PopupButton popupButton2 = PopupButton.Neutral((string)label2, action2, dismiss: true);
		object obj32 = default(object);
		bool flag9 = obj32 == null;
		obj10 = 0;
		obj5 = obj4;
		if (!flag9)
		{
			object obj33 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v19+12E]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v19+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0496;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v19+B0]");
			obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X10_v2-8]");
				if (0 == (nint)obj11)
				{
					break;
				}
				obj4 = obj5 + 16;
				obj34--;
				bool flag10 = (nint)obj34 != 1;
				obj5 = obj4;
				if (flag10)
				{
					continue;
				}
				goto IL_0496;
			}
			object obj35 = obj33 + obj5;
			object obj36 = obj35 + 312;
			num = (nint)obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v582 @ X0_v29] (should have been resolved before IL gen)");
			bool flag11 = ex == null;
			object obj37 = !flag11;
			obj10 = 0;
			if (obj37 != null)
			{
				goto IL_04e0;
			}
		}
		goto IL_05f2;
		IL_0798:
		object obj38 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v3+8]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v345 @ X2_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_025d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		IntPtr intPtr2 = default(IntPtr);
		num = intPtr2;
		goto IL_06a1;
	}

	private void ShowRatingPopup()
	{
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected O, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected O, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0040: Expected I, but got O
		//IL_0050: Expected O, but got I
		//IL_07b0: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01b2: Expected O, but got I
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01d9: Expected O, but got I
		//IL_008b: Expected O, but got I
		//IL_06c3: Expected I, but got O
		//IL_0214: Expected O, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected I, but got Unknown
		//IL_02b4: Expected O, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected I, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_02ea: Expected O, but got I
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_0311: Expected O, but got I
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_070a: Expected I, but got O
		//IL_072c: Expected I, but got O
		//IL_034c: Expected O, but got I
		//IL_03e4: Expected O, but got I4
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_0412: Expected O, but got I
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_04a8: Expected I, but got O
		//IL_04ca: Expected O, but got I4
		//IL_044d: Expected O, but got I
		//IL_04e8: Expected I, but got O
		//IL_04f8: Expected O, but got I
		//IL_0587: Expected O, but got I4
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected O, but got Unknown
		//IL_05b7: Expected I, but got O
		//IL_05db: Expected O, but got I4
		//IL_05e4: Expected O, but got I4
		//IL_0533: Expected O, but got I
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected O, but got Unknown
		//IL_078a: Expected O, but got I4
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7978]");
		nint num = 0;
		PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateBuilder(PopupWindow.MessageType.Action);
		object obj4;
		object obj5 = default(object);
		object obj7 = default(object);
		if (popupWindowBuilder != null)
		{
			object obj = typeof(System.IOAsyncCallback) + 392;
			object obj2 = "Picking audio files is not supported on iOS" + 3968;
			nint num2 = (nint)popupWindowBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v10 (Il2CppClass<PopupWindowBuilder>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v10 (Il2CppClass<PopupWindowBuilder>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v10 (Il2CppClass<PopupWindowBuilder>)+B0]");
			obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X10_v13-8]");
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
			object obj6 = num2 + obj4;
			num = (nint)(obj6 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v280 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag2 = obj7 == null;
			obj5 = obj4;
			if (!flag2)
			{
				goto IL_016f;
			}
		}
		goto IL_05f2;
		IL_06a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v280 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		object obj8;
		action..ctor(this, (IntPtr)obj8);
		object label;
		PopupButton popupButton = PopupButton.Positive((string)label, action, dismiss: true);
		object obj9 = default(object);
		bool flag3 = obj9 == null;
		object obj10 = 0;
		obj5 = obj4;
		if (flag3)
		{
			goto IL_05f2;
		}
		object obj11 = typeof(System.IOAsyncCallback) + 368;
		object obj12 = (nint)0 + (nint)1488;
		object label2 = "Added Tournament Prizes And Features" + 2840;
		object obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v16+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v16+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0395;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v16+B0]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X10_v21-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj4 = obj15 + 16;
			obj14--;
			bool flag4 = (nint)obj14 != 1;
			obj15 = obj4;
			if (flag4)
			{
				continue;
			}
			goto IL_0395;
		}
		object obj16 = obj13 + obj15;
		object obj17 = obj16 + 312;
		obj4 = obj15;
		goto IL_0702;
		IL_0600:
		object obj18 = obj5 + 9;
		object obj19 = num + obj18;
		object obj20 = obj19 + 312;
		goto IL_0798;
		IL_0496:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj21 = default(object);
		num = (nint)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v567 @ X0_v26] (should have been resolved before IL gen)");
		NullReferenceException ex = default(NullReferenceException);
		bool flag5 = ex == null;
		obj10 = 0;
		obj5 = obj4;
		if (!flag5)
		{
			goto IL_04e0;
		}
		goto IL_05f2;
		IL_04e0:
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0574;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X10_v2-8]");
			bool flag6 = 0 == (nint)obj11;
			obj10 = 0;
			if (flag6)
			{
				break;
			}
			obj5 += 16;
			obj22--;
			if ((nint)obj22 != 1)
			{
				continue;
			}
			goto IL_0574;
		}
		goto IL_0600;
		IL_0574:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj10 = 0;
		object obj23 = default(object);
		obj20 = obj23;
		goto IL_0798;
		IL_00d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v241 @ X0_v37 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag7 = obj7 == null;
		object obj24 = !flag7;
		obj4 = obj5;
		if (obj24 != null)
		{
			goto IL_016f;
		}
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		goto IL_05f2;
		IL_016f:
		object obj25 = typeof(System.IOAsyncCallback) + 384;
		object obj26 = "COORDINATE_TYPE_GCJ_02" + 1296;
		object obj27 = typeof(SqlSingle[]) + 2376;
		obj8 = (nint)0 + (nint)1512;
		label = "WhiteSmoke" + 1504;
		object obj28 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v14+12E]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v14+12E]");
		if ((nint)0 == 0)
		{
			goto IL_025d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v14+B0]");
		object obj30 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X10_v26-8]");
			if (0 == (nint)obj25)
			{
				break;
			}
			obj4 = obj30 + 16;
			obj29--;
			bool flag8 = (nint)obj29 != 1;
			obj30 = obj4;
			if (flag8)
			{
				continue;
			}
			goto IL_025d;
		}
		object obj31 = obj28 + obj30;
		num = (nint)(obj31 + 312);
		obj4 = obj30;
		goto IL_06a1;
		IL_05f2:
		ex = new NullReferenceException();
		goto IL_0600;
		IL_0395:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0702;
		IL_0702:
		num = (nint)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v536 @ X0_v15] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj12);
		PopupButton popupButton2 = PopupButton.Neutral((string)label2, action2, dismiss: true);
		object obj32 = default(object);
		bool flag9 = obj32 == null;
		obj10 = 0;
		obj5 = obj4;
		if (!flag9)
		{
			object obj33 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v19+12E]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v19+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0496;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v19+B0]");
			obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X10_v2-8]");
				if (0 == (nint)obj11)
				{
					break;
				}
				obj4 = obj5 + 16;
				obj34--;
				bool flag10 = (nint)obj34 != 1;
				obj5 = obj4;
				if (flag10)
				{
					continue;
				}
				goto IL_0496;
			}
			object obj35 = obj33 + obj5;
			object obj36 = obj35 + 312;
			num = (nint)obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v582 @ X0_v29] (should have been resolved before IL gen)");
			bool flag11 = ex == null;
			object obj37 = !flag11;
			obj10 = 0;
			if (obj37 != null)
			{
				goto IL_04e0;
			}
		}
		goto IL_05f2;
		IL_0798:
		object obj38 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v3+8]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v345 @ X2_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_025d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		IntPtr intPtr2 = default(IntPtr);
		num = intPtr2;
		goto IL_06a1;
	}

	private void Rate()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ef: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7979]");
		object obj3 = (nint)0 & (nint)1;
		string rateLink;
		string url;
		if (obj3 != null)
		{
			Status = RatingStatus.Rated;
			rateLink = GetRateLink();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			url = rateLink;
			if (!flag)
			{
				goto IL_009d;
			}
		}
		else
		{
			_ = 1;
			Status = RatingStatus.Rated;
			rateLink = GetRateLink();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			url = rateLink;
			if (obj5 != null)
			{
				goto IL_009d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Application.OpenURL(url);
		return;
		IL_009d:
		Application.OpenURL(rateLink);
	}

	private static string GetRateLink()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_011b: Expected O, but got I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01cb: Expected O, but got I
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E797A]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform != Platform.Android)
		{
			goto IL_009a;
		}
		goto IL_0161;
		IL_009a:
		switch (platform)
		{
		case Platform.IOS:
			return "getSecondRescanTask" + 3880;
		case Platform.Huawei:
			return "alignContent" + 2320;
		default:
		{
			object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			ex..ctor();
			object obj6 = (nint)0 + (nint)1496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			return (string)(object)new OutOfMemoryException();
		}
		}
		IL_0161:
		return "m_StencilDeferredPS" + 496;
		IL_0074:
		platform = KUtil.GetPlatform();
		if (platform != Platform.Android)
		{
			goto IL_009a;
		}
		goto IL_0161;
	}

	private void AskLater()
	{
		Status = RatingStatus.AskLater;
	}

	private void NegativeFeedback()
	{
		Status = RatingStatus.DidNotLike;
	}
}
