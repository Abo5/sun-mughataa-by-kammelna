using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using KammelnaOffline.Baloot.Tutorial;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class TutorialTipsAndErrors
{
	private static readonly string[] bodyTextTips_Sun;

	private static readonly string[] bodyErrorTextTips_Sun;

	private static readonly string[] bodyTextTips_AdvSun;

	private static readonly string[] bodyTextTips_Hokom;

	private static readonly string[] bodyErrorTextTips_Hokom;

	private static readonly string[] bodyTextTips_AdvHokom;

	private static readonly string[] bodyErrorTextTips_AdvHokom;

	public static string GetTipBody(int numberOfCards)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_0029: Expected O, but got I
		//IL_006f: Expected O, but got I4
		//IL_0092: Expected O, but got I
		//IL_009f: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+E0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+E0]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v8+18]");
				bool flag = (nint)numberOfCards < (nint)0;
				object obj6 = !flag;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+E0]");
					object obj7 = (nint)0 + (nint)numberOfCards;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v9+20]");
					return (string)0;
				}
				goto IL_00ad;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00ad;
		IL_00ad:
		return (string)(object)new IndexOutOfRangeException();
	}

	public unsafe static void SetupErrorMessage(TextMeshProUGUI bodyText, TextMeshProUGUI titleText, TutorialType type, int numberOfCards, Card card)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0150: Expected O, but got I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_009e: Expected O, but got I
		//IL_01e0: Expected O, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0192: Expected O, but got I
		//IL_01ac: Expected O, but got I4
		//IL_00db: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_024a: Expected I4, but got O
		//IL_0252: Expected O, but got I4
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02e1: Expected O, but got I4
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_0337: Expected O, but got Ref
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_0662: Expected O, but got I
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_035c: Expected O, but got Ref
		//IL_0372: Expected I, but got O
		//IL_0382: Expected O, but got I
		//IL_03bd: Expected O, but got I
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_04d2: Expected O, but got I8
		//IL_0465: Expected I, but got O
		//IL_0475: Expected O, but got I
		//IL_04b0: Expected O, but got I
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F22]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v42+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v42+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A5]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		object obj8 = obj5;
		if (obj7 != null)
		{
			goto IL_00c3;
		}
		goto IL_01c2;
		IL_0641:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0633:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0641;
		IL_0625:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0633;
		IL_0074:
		obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A5]");
		object obj9 = (nint)0 & (nint)1;
		bool flag3 = obj9 == null;
		obj8 = obj5;
		if (!flag3)
		{
			goto IL_00c3;
		}
		goto IL_01c2;
		IL_01c2:
		_ = 1;
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v25+B8]");
		object obj11 = 0;
		TutorialGame tutorialGame = (TutorialGame)obj11;
		bool flag4 = obj11 == null;
		int num = numberOfCards;
		TextMeshProUGUI textMeshProUGUI = titleText;
		if (!flag4)
		{
			goto IL_0215;
		}
		goto IL_0625;
		IL_00c3:
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v32+B8]");
		object obj13 = 0;
		tutorialGame = (TutorialGame)obj13;
		bool flag5 = obj13 == null;
		object obj14 = !flag5;
		if (obj14 != null)
		{
			goto IL_0215;
		}
		num = numberOfCards;
		textMeshProUGUI = titleText;
		goto IL_0625;
		IL_0215:
		string errorMessage = tutorialGame.GetErrorMessage(numberOfCards, card);
		bool flag6 = errorMessage == null;
		num = 0;
		TutorialType tutorialType = (TutorialType)card;
		textMeshProUGUI = (TextMeshProUGUI)numberOfCards;
		if (!flag6)
		{
			object value = "{0} color encoding is currently unsupported for outputting to HDR." + 416;
			if (!errorMessage.Contains((string)value))
			{
				TextMeshProExtensions.Localize(bodyText, errorMessage);
				num = 0;
				goto IL_0568;
			}
			object obj15 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			bool flag7 = card == null;
			num = 0;
			tutorialType = TutorialType.None;
			textMeshProUGUI = (TextMeshProUGUI)2;
			if (!flag7)
			{
				object obj16 = typeof(System.Buffers.Text.ParserHelpers) + 3136;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object[] array = default(object[]);
				bool flag8 = array == null;
				num = 0;
				tutorialType = TutorialType.None;
				Rank rank = default(Rank);
				textMeshProUGUI = (TextMeshProUGUI)(&rank);
				if (!flag8)
				{
					object obj17 = default(object);
					bool flag9 = obj17 == null;
					TextMeshProUGUI textMeshProUGUI2 = (TextMeshProUGUI)(&rank);
					if (!flag9)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
						textMeshProUGUI2 = (TextMeshProUGUI)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag10 = ex == null;
						num = 0;
						tutorialType = TutorialType.None;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
						textMeshProUGUI = (TextMeshProUGUI)0;
						if (flag10)
						{
							goto IL_0641;
						}
					}
					bool flag11 = array.Length == 0;
					num = 0;
					tutorialType = TutorialType.None;
					textMeshProUGUI = textMeshProUGUI2;
					if (!flag11)
					{
						object obj18 = array + 32;
						obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						string suitLocalizationString = SuitMethods.GetSuitLocalizationString(card.<Suit>k__BackingField);
						bool flag12 = suitLocalizationString == null;
						TextMeshProUGUI textMeshProUGUI3 = null;
						if (!flag12)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
							textMeshProUGUI3 = (TextMeshProUGUI)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag13 = ex == null;
							num = 0;
							tutorialType = TutorialType.None;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
							textMeshProUGUI = (TextMeshProUGUI)0;
							if (flag13)
							{
								goto IL_0641;
							}
						}
						object obj19 = array.Length & 0xFFFFFFFEL;
						bool flag14 = obj19 == null;
						num = 0;
						tutorialType = TutorialType.None;
						textMeshProUGUI = textMeshProUGUI3;
						if (!flag14)
						{
							object obj20 = array + 40;
							obj20 = suitLocalizationString;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							TextMeshProExtensions.LocalizeArguments(bodyText, errorMessage, array);
							num = 0;
							goto IL_0568;
						}
					}
					goto IL_0633;
				}
			}
		}
		goto IL_0625;
		IL_0568:
		object obj21 = "startPosition" + 3056;
		object text;
		if (errorMessage.Equals((string)obj21))
		{
			bool flag15 = (object)titleText == null;
			tutorialType = TutorialType.None;
			textMeshProUGUI = (TextMeshProUGUI)obj21;
			if (flag15)
			{
				goto IL_0625;
			}
			text = "not" + 72;
		}
		else
		{
			bool flag16 = (object)titleText == null;
			tutorialType = TutorialType.None;
			textMeshProUGUI = (TextMeshProUGUI)obj21;
			if (flag16)
			{
				goto IL_0625;
			}
			text = "utf-32" + 2744;
		}
		titleText.color = (Color)0;
		TextMeshProExtensions.Localize(titleText, (string)text);
	}

	private static string GetErrorMessage(int numberOfCards, Card card)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+B8]");
		object obj3 = 0;
		if (obj3 != null)
		{
			return ((TutorialGame)obj3).GetErrorMessage(numberOfCards, card);
		}
		return (string)(object)new NullReferenceException();
	}

	static TutorialTipsAndErrors()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0087: Expected O, but got I8
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_010b: Expected O, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0187: Expected O, but got I8
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01f5: Expected O, but got I4
		//IL_020b: Expected O, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_028f: Expected O, but got I4
		//IL_02a5: Expected O, but got I
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_0329: Expected O, but got I4
		//IL_033f: Expected O, but got I
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_03bb: Expected O, but got I8
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_0429: Expected O, but got I4
		//IL_043f: Expected O, but got I
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected O, but got Unknown
		//IL_0551: Expected O, but got I8
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected O, but got Unknown
		//IL_05b0: Expected O, but got I4
		//IL_05c6: Expected O, but got I
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected O, but got Unknown
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected O, but got Unknown
		//IL_0633: Expected O, but got I8
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected O, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected O, but got Unknown
		//IL_06a1: Expected O, but got I4
		//IL_06b7: Expected O, but got I
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected O, but got Unknown
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected O, but got Unknown
		//IL_072c: Expected O, but got I4
		//IL_0742: Expected O, but got I
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected O, but got Unknown
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Expected O, but got Unknown
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Expected O, but got Unknown
		//IL_07c6: Expected O, but got I4
		//IL_07dc: Expected O, but got I
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected O, but got Unknown
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected O, but got Unknown
		//IL_0849: Expected O, but got I8
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected O, but got Unknown
		//IL_08b7: Expected O, but got I4
		//IL_08cd: Expected O, but got I
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Expected O, but got Unknown
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_090f: Expected O, but got Unknown
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Expected O, but got Unknown
		//IL_094d: Expected O, but got I
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a6: Expected O, but got Unknown
		//IL_09d2: Expected O, but got I8
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fd: Expected O, but got Unknown
		//IL_0a31: Expected O, but got I4
		//IL_0a47: Expected O, but got I
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Expected O, but got Unknown
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Expected O, but got Unknown
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Expected O, but got Unknown
		//IL_0ac3: Expected O, but got I8
		//IL_0aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aef: Expected O, but got Unknown
		//IL_0af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afd: Expected O, but got Unknown
		//IL_0b31: Expected O, but got I4
		//IL_0b47: Expected O, but got I
		//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Expected O, but got Unknown
		//IL_0b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b89: Expected O, but got Unknown
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b97: Expected O, but got Unknown
		//IL_0bcb: Expected O, but got I4
		//IL_0be1: Expected O, but got I
		//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Expected O, but got Unknown
		//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c22: Expected O, but got Unknown
		//IL_0c56: Expected O, but got I4
		//IL_0c6c: Expected O, but got I
		//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c91: Expected O, but got Unknown
		//IL_0ca8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cad: Expected O, but got Unknown
		//IL_0cd9: Expected O, but got I8
		//IL_0d00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d05: Expected O, but got Unknown
		//IL_0d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d13: Expected O, but got Unknown
		//IL_0d47: Expected O, but got I4
		//IL_0d5d: Expected O, but got I
		//IL_0d7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d82: Expected O, but got Unknown
		//IL_0d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9f: Expected O, but got Unknown
		//IL_0da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dad: Expected O, but got Unknown
		//IL_0ddd: Expected O, but got I
		//IL_0e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e36: Expected O, but got Unknown
		//IL_0e62: Expected O, but got I8
		//IL_0e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8d: Expected O, but got Unknown
		//IL_0ec1: Expected O, but got I4
		//IL_0ed7: Expected O, but got I
		//IL_0ef7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efc: Expected O, but got Unknown
		//IL_0f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f19: Expected O, but got Unknown
		//IL_0f22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f27: Expected O, but got Unknown
		//IL_0f53: Expected O, but got I8
		//IL_0f7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7f: Expected O, but got Unknown
		//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8d: Expected O, but got Unknown
		//IL_0fc1: Expected O, but got I4
		//IL_0fd7: Expected O, but got I
		//IL_0ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffc: Expected O, but got Unknown
		//IL_1014: Unknown result type (might be due to invalid IL or missing references)
		//IL_1019: Expected O, but got Unknown
		//IL_1022: Unknown result type (might be due to invalid IL or missing references)
		//IL_1027: Expected O, but got Unknown
		//IL_105b: Expected O, but got I4
		//IL_1071: Expected O, but got I
		//IL_1091: Unknown result type (might be due to invalid IL or missing references)
		//IL_1096: Expected O, but got Unknown
		//IL_10ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b3: Expected O, but got Unknown
		//IL_10bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c1: Expected O, but got Unknown
		//IL_10f5: Expected O, but got I4
		//IL_110b: Expected O, but got I
		//IL_112b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1130: Expected O, but got Unknown
		//IL_1148: Unknown result type (might be due to invalid IL or missing references)
		//IL_114d: Expected O, but got Unknown
		//IL_1156: Unknown result type (might be due to invalid IL or missing references)
		//IL_115b: Expected O, but got Unknown
		//IL_1187: Expected O, but got I8
		//IL_11ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b3: Expected O, but got Unknown
		//IL_11bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c1: Expected O, but got Unknown
		//IL_11f5: Expected O, but got I4
		//IL_120b: Expected O, but got I
		//IL_122b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1230: Expected O, but got Unknown
		//IL_1248: Unknown result type (might be due to invalid IL or missing references)
		//IL_124d: Expected O, but got Unknown
		//IL_1256: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Expected O, but got Unknown
		//IL_128b: Expected O, but got I
		//IL_12df: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e4: Expected O, but got Unknown
		//IL_1310: Expected O, but got I8
		//IL_1336: Unknown result type (might be due to invalid IL or missing references)
		//IL_133b: Expected O, but got Unknown
		//IL_136f: Expected O, but got I4
		//IL_1385: Expected O, but got I
		//IL_13a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13aa: Expected O, but got Unknown
		//IL_13c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c6: Expected O, but got Unknown
		//IL_13f2: Expected O, but got I8
		//IL_1418: Unknown result type (might be due to invalid IL or missing references)
		//IL_141d: Expected O, but got Unknown
		//IL_1451: Expected O, but got I4
		//IL_1467: Expected O, but got I
		//IL_1487: Unknown result type (might be due to invalid IL or missing references)
		//IL_148c: Expected O, but got Unknown
		//IL_14a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a8: Expected O, but got Unknown
		//IL_14dc: Expected O, but got I4
		//IL_14f2: Expected O, but got I
		//IL_1512: Unknown result type (might be due to invalid IL or missing references)
		//IL_1517: Expected O, but got Unknown
		//IL_152e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1533: Expected O, but got Unknown
		//IL_1567: Expected O, but got I4
		//IL_157d: Expected O, but got I
		//IL_159d: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a2: Expected O, but got Unknown
		//IL_15b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15be: Expected O, but got Unknown
		//IL_15ea: Expected O, but got I8
		//IL_1610: Unknown result type (might be due to invalid IL or missing references)
		//IL_1615: Expected O, but got Unknown
		//IL_1649: Expected O, but got I4
		//IL_165f: Expected O, but got I
		//IL_167f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1684: Expected O, but got Unknown
		//IL_169b: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a0: Expected O, but got Unknown
		//IL_16d0: Expected O, but got I
		//IL_1724: Unknown result type (might be due to invalid IL or missing references)
		//IL_1729: Expected O, but got Unknown
		//IL_1755: Expected O, but got I8
		//IL_177b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1780: Expected O, but got Unknown
		//IL_17b4: Expected O, but got I4
		//IL_17ca: Expected O, but got I
		//IL_17ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ef: Expected O, but got Unknown
		//IL_1807: Unknown result type (might be due to invalid IL or missing references)
		//IL_180c: Expected O, but got Unknown
		//IL_1815: Unknown result type (might be due to invalid IL or missing references)
		//IL_181a: Expected O, but got Unknown
		//IL_1846: Expected O, but got I8
		//IL_186d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1872: Expected O, but got Unknown
		//IL_187b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1880: Expected O, but got Unknown
		//IL_18b4: Expected O, but got I4
		//IL_18ca: Expected O, but got I
		//IL_18ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ef: Expected O, but got Unknown
		//IL_1907: Unknown result type (might be due to invalid IL or missing references)
		//IL_190c: Expected O, but got Unknown
		//IL_1915: Unknown result type (might be due to invalid IL or missing references)
		//IL_191a: Expected O, but got Unknown
		//IL_194e: Expected O, but got I4
		//IL_1964: Expected O, but got I
		//IL_1984: Unknown result type (might be due to invalid IL or missing references)
		//IL_1989: Expected O, but got Unknown
		//IL_19a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a6: Expected O, but got Unknown
		//IL_19af: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b4: Expected O, but got Unknown
		//IL_19e8: Expected O, but got I4
		//IL_19fe: Expected O, but got I
		//IL_1a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a23: Expected O, but got Unknown
		//IL_1a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a40: Expected O, but got Unknown
		//IL_1a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4e: Expected O, but got Unknown
		//IL_1a7a: Expected O, but got I8
		//IL_1aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa6: Expected O, but got Unknown
		//IL_1aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab4: Expected O, but got Unknown
		//IL_1ae8: Expected O, but got I4
		//IL_1afe: Expected O, but got I
		//IL_1b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b23: Expected O, but got Unknown
		//IL_1b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b40: Expected O, but got Unknown
		//IL_1b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4e: Expected O, but got Unknown
		//IL_1b7e: Expected O, but got I
		//IL_1bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd7: Expected O, but got Unknown
		//IL_1c03: Expected O, but got I8
		//IL_1c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2e: Expected O, but got Unknown
		//IL_1c62: Expected O, but got I4
		//IL_1c78: Expected O, but got I
		//IL_1c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9d: Expected O, but got Unknown
		//IL_1cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cba: Expected O, but got Unknown
		//IL_1cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc8: Expected O, but got Unknown
		//IL_1cf4: Expected O, but got I8
		//IL_1d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1f: Expected O, but got Unknown
		//IL_1d53: Expected O, but got I4
		//IL_1d69: Expected O, but got I
		//IL_1d89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8e: Expected O, but got Unknown
		//IL_1da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1daa: Expected O, but got Unknown
		//IL_1dde: Expected O, but got I4
		//IL_1df4: Expected O, but got I
		//IL_1e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e19: Expected O, but got Unknown
		//IL_1e30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e35: Expected O, but got Unknown
		//IL_1e69: Expected O, but got I4
		//IL_1e7f: Expected O, but got I
		//IL_1e9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea4: Expected O, but got Unknown
		//IL_1ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec0: Expected O, but got Unknown
		//IL_1eec: Expected O, but got I8
		//IL_1f12: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f17: Expected O, but got Unknown
		//IL_1f4b: Expected O, but got I4
		//IL_1f61: Expected O, but got I
		//IL_1f81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f86: Expected O, but got Unknown
		//IL_1f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa2: Expected O, but got Unknown
		//IL_1fd2: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			object obj2 = "startPosition" + 2952;
			object obj4 = default(object);
			object obj3 = obj4 + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v4-8]");
			object obj5 = 0 & 0xFFFFFFFEL;
			if (obj5 != null)
			{
				object obj6 = "placementId" + 64;
				object obj7 = obj4 + 40;
				obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X20_v6-10]");
				bool flag = (nint)0 < (nint)2;
				object obj8 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X20_v6-10]");
				object obj9 = -2;
				bool flag2 = obj9 == null;
				object obj10 = ~obj8;
				object obj11 = obj10 | flag2;
				if (obj11 == null)
				{
					object obj12 = "Picking audio files is not supported on iOS" + 168;
					object obj13 = obj4 + 48;
					obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X20_v8-18]");
					object obj14 = 0 & 0xFFFFFFFCL;
					if (obj14 != null)
					{
						object obj15 = "Picking audio files is not supported on iOS" + 232;
						object obj16 = obj4 + 56;
						obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X20_v10-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj17 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X20_v10-20]");
						object obj18 = -4;
						bool flag4 = obj18 == null;
						object obj19 = ~obj17;
						object obj20 = obj19 | flag4;
						if (obj20 == null)
						{
							object obj21 = "Picking audio files is not supported on iOS" + 152;
							object obj22 = obj4 + 64;
							obj22 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X20_v12-28]");
							bool flag5 = (nint)0 < (nint)5;
							object obj23 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X20_v12-28]");
							object obj24 = -5;
							bool flag6 = obj24 == null;
							object obj25 = ~obj23;
							object obj26 = obj25 | flag6;
							if (obj26 == null)
							{
								object obj27 = "Picking audio files is not supported on iOS" + 184;
								object obj28 = obj4 + 72;
								obj28 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X20_v14-30]");
								bool flag7 = (nint)0 < (nint)6;
								object obj29 = !flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X20_v14-30]");
								object obj30 = -6;
								bool flag8 = obj30 == null;
								object obj31 = ~obj29;
								object obj32 = obj31 | flag8;
								if (obj32 == null)
								{
									object obj33 = "Picking audio files is not supported on iOS" + 216;
									object obj34 = obj4 + 80;
									obj34 = obj33;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X20_v16-38]");
									object obj35 = 0 & 0xFFFFFFF8L;
									if (obj35 != null)
									{
										object obj36 = "Picking audio files is not supported on iOS" + 224;
										object obj37 = obj4 + 88;
										obj37 = obj36;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X20_v18-40]");
										bool flag9 = (nint)0 < (nint)8;
										object obj38 = !flag9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X20_v18-40]");
										object obj39 = -8;
										bool flag10 = obj39 == null;
										object obj40 = ~obj38;
										object obj41 = obj40 | flag10;
										if (obj41 == null)
										{
											object obj42 = "Picking audio files is not supported on iOS" + 240;
											object obj43 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2304;
											object obj44 = obj4 + 96;
											obj44 = obj42;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj45 = obj43;
											object obj46 = obj4;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v30+18]");
											if ((nint)0 != 0)
											{
												object obj47 = "m_StencilDeferredPS" + 3768;
												object obj49 = default(object);
												object obj48 = obj49 + 32;
												obj48 = obj47;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X20_v20-8]");
												object obj50 = 0 & 0xFFFFFFFEL;
												if (obj50 != null)
												{
													object obj51 = obj49 + 40;
													obj51 = obj47;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X20_v22-10]");
													bool flag11 = (nint)0 < (nint)2;
													object obj52 = !flag11;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X20_v22-10]");
													object obj53 = -2;
													bool flag12 = obj53 == null;
													object obj54 = ~obj52;
													object obj55 = obj54 | flag12;
													if (obj55 == null)
													{
														object obj56 = obj49 + 48;
														obj56 = obj47;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X20_v24-18]");
														object obj57 = 0 & 0xFFFFFFFCL;
														if (obj57 != null)
														{
															object obj58 = "startPosition" + 3056;
															object obj59 = obj49 + 56;
															obj59 = obj58;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X20_v26-20]");
															bool flag13 = (nint)0 < (nint)4;
															object obj60 = !flag13;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X20_v26-20]");
															object obj61 = -4;
															bool flag14 = obj61 == null;
															object obj62 = ~obj60;
															object obj63 = obj62 | flag14;
															if (obj63 == null)
															{
																object obj64 = obj49 + 64;
																obj64 = obj58;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X20_v28-28]");
																bool flag15 = (nint)0 < (nint)5;
																object obj65 = !flag15;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X20_v28-28]");
																object obj66 = -5;
																bool flag16 = obj66 == null;
																object obj67 = ~obj65;
																object obj68 = obj67 | flag16;
																if (obj68 == null)
																{
																	object obj69 = "WhiteSmoke" + 1824;
																	object obj70 = obj49 + 72;
																	obj70 = obj69;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X20_v30-30]");
																	bool flag17 = (nint)0 < (nint)6;
																	object obj71 = !flag17;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X20_v30-30]");
																	object obj72 = -6;
																	bool flag18 = obj72 == null;
																	object obj73 = ~obj71;
																	object obj74 = obj73 | flag18;
																	if (obj74 == null)
																	{
																		object obj75 = obj49 + 80;
																		obj75 = obj58;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X20_v32-38]");
																		object obj76 = 0 & 0xFFFFFFF8L;
																		if (obj76 != null)
																		{
																			object obj77 = "WhiteSmoke" + 1816;
																			object obj78 = obj49 + 88;
																			obj78 = obj77;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X20_v34-40]");
																			bool flag19 = (nint)0 < (nint)8;
																			object obj79 = !flag19;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X20_v34-40]");
																			object obj80 = -8;
																			bool flag20 = obj80 == null;
																			object obj81 = ~obj79;
																			object obj82 = obj81 | flag20;
																			if (obj82 == null)
																			{
																				object obj83 = "WhiteSmoke" + 1808;
																				object obj84 = obj49 + 96;
																				obj84 = obj83;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																				object obj85 = obj43;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v42+B8]");
																				object obj86 = (nint)0 + (nint)8;
																				obj86 = obj49;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v54+18]");
																				if ((nint)0 != 0)
																				{
																					object obj88 = default(object);
																					object obj87 = obj88 + 32;
																					obj87 = obj2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X20_v36-8]");
																					object obj89 = 0 & 0xFFFFFFFEL;
																					if (obj89 != null)
																					{
																						object obj90 = obj88 + 40;
																						obj90 = obj6;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X20_v38-10]");
																						bool flag21 = (nint)0 < (nint)2;
																						object obj91 = !flag21;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X20_v38-10]");
																						object obj92 = -2;
																						bool flag22 = obj92 == null;
																						object obj93 = ~obj91;
																						object obj94 = obj93 | flag22;
																						if (obj94 == null)
																						{
																							object obj95 = "Picking audio files is not supported on iOS" + 304;
																							object obj96 = obj88 + 48;
																							obj96 = obj95;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X20_v40-18]");
																							object obj97 = 0 & 0xFFFFFFFCL;
																							if (obj97 != null)
																							{
																								object obj98 = "Picking audio files is not supported on iOS" + 288;
																								object obj99 = obj88 + 56;
																								obj99 = obj98;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X20_v42-20]");
																								bool flag23 = (nint)0 < (nint)4;
																								object obj100 = !flag23;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X20_v42-20]");
																								object obj101 = -4;
																								bool flag24 = obj101 == null;
																								object obj102 = ~obj100;
																								object obj103 = obj102 | flag24;
																								if (obj103 == null)
																								{
																									object obj104 = "Picking audio files is not supported on iOS" + 248;
																									object obj105 = obj88 + 64;
																									obj105 = obj104;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X20_v44-28]");
																									bool flag25 = (nint)0 < (nint)5;
																									object obj106 = !flag25;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X20_v44-28]");
																									object obj107 = -5;
																									bool flag26 = obj107 == null;
																									object obj108 = ~obj106;
																									object obj109 = obj108 | flag26;
																									if (obj109 == null)
																									{
																										object obj110 = obj88 + 72;
																										obj110 = obj104;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X20_v46-30]");
																										bool flag27 = (nint)0 < (nint)6;
																										object obj111 = !flag27;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X20_v46-30]");
																										object obj112 = -6;
																										bool flag28 = obj112 == null;
																										object obj113 = ~obj111;
																										object obj114 = obj113 | flag28;
																										if (obj114 == null)
																										{
																											object obj115 = obj88 + 80;
																											obj115 = obj104;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X20_v48-38]");
																											object obj116 = 0 & 0xFFFFFFF8L;
																											if (obj116 != null)
																											{
																												object obj117 = "DNQUALIFIER" + 3768;
																												object obj118 = obj88 + 88;
																												obj118 = obj117;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X20_v50-40]");
																												bool flag29 = (nint)0 < (nint)8;
																												object obj119 = !flag29;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X20_v50-40]");
																												object obj120 = -8;
																												bool flag30 = obj120 == null;
																												object obj121 = ~obj119;
																												object obj122 = obj121 | flag30;
																												if (obj122 == null)
																												{
																													object obj123 = "Picking audio files is not supported on iOS" + 176;
																													object obj124 = obj88 + 96;
																													obj124 = obj123;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																													object obj125 = obj43;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v60+B8]");
																													object obj126 = (nint)0 + (nint)16;
																													obj126 = obj88;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v78+18]");
																													if ((nint)0 != 0)
																													{
																														object obj128 = default(object);
																														object obj127 = obj128 + 32;
																														obj127 = obj2;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X20_v52-8]");
																														object obj129 = 0 & 0xFFFFFFFEL;
																														if (obj129 != null)
																														{
																															object obj130 = obj128 + 40;
																															obj130 = obj6;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X20_v54-10]");
																															bool flag31 = (nint)0 < (nint)2;
																															object obj131 = !flag31;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X20_v54-10]");
																															object obj132 = -2;
																															bool flag32 = obj132 == null;
																															object obj133 = ~obj131;
																															object obj134 = obj133 | flag32;
																															if (obj134 == null)
																															{
																																object obj135 = "Picking audio files is not supported on iOS" + 272;
																																object obj136 = obj128 + 48;
																																obj136 = obj135;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X20_v56-18]");
																																object obj137 = 0 & 0xFFFFFFFCL;
																																if (obj137 != null)
																																{
																																	object obj138 = "Picking audio files is not supported on iOS" + 280;
																																	object obj139 = obj128 + 56;
																																	obj139 = obj138;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X20_v58-20]");
																																	bool flag33 = (nint)0 < (nint)4;
																																	object obj140 = !flag33;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X20_v58-20]");
																																	object obj141 = -4;
																																	bool flag34 = obj141 == null;
																																	object obj142 = ~obj140;
																																	object obj143 = obj142 | flag34;
																																	if (obj143 == null)
																																	{
																																		object obj144 = "Picking audio files is not supported on iOS" + 192;
																																		object obj145 = obj128 + 64;
																																		obj145 = obj144;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X20_v60-28]");
																																		bool flag35 = (nint)0 < (nint)5;
																																		object obj146 = !flag35;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X20_v60-28]");
																																		object obj147 = -5;
																																		bool flag36 = obj147 == null;
																																		object obj148 = ~obj146;
																																		object obj149 = obj148 | flag36;
																																		if (obj149 == null)
																																		{
																																			object obj150 = "Picking audio files is not supported on iOS" + 208;
																																			object obj151 = obj128 + 72;
																																			obj151 = obj150;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X20_v62-30]");
																																			bool flag37 = (nint)0 < (nint)6;
																																			object obj152 = !flag37;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X20_v62-30]");
																																			object obj153 = -6;
																																			bool flag38 = obj153 == null;
																																			object obj154 = ~obj152;
																																			object obj155 = obj154 | flag38;
																																			if (obj155 == null)
																																			{
																																				object obj156 = "Picking audio files is not supported on iOS" + 144;
																																				object obj157 = obj128 + 80;
																																				obj157 = obj156;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X20_v64-38]");
																																				object obj158 = 0 & 0xFFFFFFF8L;
																																				if (obj158 != null)
																																				{
																																					object obj159 = "Picking audio files is not supported on iOS" + 256;
																																					object obj160 = obj128 + 88;
																																					obj160 = obj159;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X20_v66-40]");
																																					bool flag39 = (nint)0 < (nint)8;
																																					object obj161 = !flag39;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X20_v66-40]");
																																					object obj162 = -8;
																																					bool flag40 = obj162 == null;
																																					object obj163 = ~obj161;
																																					object obj164 = obj163 | flag40;
																																					if (obj164 == null)
																																					{
																																						object obj165 = "Picking audio files is not supported on iOS" + 264;
																																						object obj166 = obj128 + 96;
																																						obj166 = obj165;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																						object obj167 = obj43;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v84+B8]");
																																						object obj168 = (nint)0 + (nint)24;
																																						obj168 = obj128;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v102+18]");
																																						if ((nint)0 != 0)
																																						{
																																							object obj170 = default(object);
																																							object obj169 = obj170 + 32;
																																							obj169 = obj47;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X20_v68-8]");
																																							object obj171 = 0 & 0xFFFFFFFEL;
																																							if (obj171 != null)
																																							{
																																								object obj172 = obj170 + 40;
																																								obj172 = obj47;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X20_v70-10]");
																																								bool flag41 = (nint)0 < (nint)2;
																																								object obj173 = !flag41;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X20_v70-10]");
																																								object obj174 = -2;
																																								bool flag42 = obj174 == null;
																																								object obj175 = ~obj173;
																																								object obj176 = obj175 | flag42;
																																								if (obj176 == null)
																																								{
																																									object obj177 = obj170 + 48;
																																									obj177 = obj47;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X20_v72-18]");
																																									object obj178 = 0 & 0xFFFFFFFCL;
																																									if (obj178 != null)
																																									{
																																										object obj179 = obj170 + 56;
																																										obj179 = obj47;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X20_v74-20]");
																																										bool flag43 = (nint)0 < (nint)4;
																																										object obj180 = !flag43;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X20_v74-20]");
																																										object obj181 = -4;
																																										bool flag44 = obj181 == null;
																																										object obj182 = ~obj180;
																																										object obj183 = obj182 | flag44;
																																										if (obj183 == null)
																																										{
																																											object obj184 = obj170 + 64;
																																											obj184 = obj58;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X20_v76-28]");
																																											bool flag45 = (nint)0 < (nint)5;
																																											object obj185 = !flag45;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X20_v76-28]");
																																											object obj186 = -5;
																																											bool flag46 = obj186 == null;
																																											object obj187 = ~obj185;
																																											object obj188 = obj187 | flag46;
																																											if (obj188 == null)
																																											{
																																												object obj189 = obj170 + 72;
																																												obj189 = obj69;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X20_v78-30]");
																																												bool flag47 = (nint)0 < (nint)6;
																																												object obj190 = !flag47;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X20_v78-30]");
																																												object obj191 = -6;
																																												bool flag48 = obj191 == null;
																																												object obj192 = ~obj190;
																																												object obj193 = obj192 | flag48;
																																												if (obj193 == null)
																																												{
																																													object obj194 = obj170 + 80;
																																													obj194 = obj58;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X20_v80-38]");
																																													object obj195 = 0 & 0xFFFFFFF8L;
																																													if (obj195 != null)
																																													{
																																														object obj196 = obj170 + 88;
																																														obj196 = obj58;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X20_v82-40]");
																																														bool flag49 = (nint)0 < (nint)8;
																																														object obj197 = !flag49;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X20_v82-40]");
																																														object obj198 = -8;
																																														bool flag50 = obj198 == null;
																																														object obj199 = ~obj197;
																																														object obj200 = obj199 | flag50;
																																														if (obj200 == null)
																																														{
																																															object obj201 = obj170 + 96;
																																															obj201 = obj58;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																															object obj202 = obj43;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v94+B8]");
																																															object obj203 = (nint)0 + (nint)32;
																																															obj203 = obj170;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v126+18]");
																																															if ((nint)0 != 0)
																																															{
																																																object obj205 = default(object);
																																																object obj204 = obj205 + 32;
																																																obj204 = obj2;
																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X20_v84-8]");
																																																object obj206 = 0 & 0xFFFFFFFEL;
																																																if (obj206 != null)
																																																{
																																																	object obj207 = obj205 + 40;
																																																	obj207 = obj6;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X20_v86-10]");
																																																	bool flag51 = (nint)0 < (nint)2;
																																																	object obj208 = !flag51;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X20_v86-10]");
																																																	object obj209 = -2;
																																																	bool flag52 = obj209 == null;
																																																	object obj210 = ~obj208;
																																																	object obj211 = obj210 | flag52;
																																																	if (obj211 == null)
																																																	{
																																																		object obj212 = "Picking audio files is not supported on iOS" + 296;
																																																		object obj213 = obj205 + 48;
																																																		obj213 = obj212;
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X20_v88-18]");
																																																		object obj214 = 0 & 0xFFFFFFFCL;
																																																		if (obj214 != null)
																																																		{
																																																			object obj215 = "WhiteSmoke" + 1720;
																																																			object obj216 = obj205 + 56;
																																																			obj216 = obj215;
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X20_v90-20]");
																																																			bool flag53 = (nint)0 < (nint)4;
																																																			object obj217 = !flag53;
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X20_v90-20]");
																																																			object obj218 = -4;
																																																			bool flag54 = obj218 == null;
																																																			object obj219 = ~obj217;
																																																			object obj220 = obj219 | flag54;
																																																			if (obj220 == null)
																																																			{
																																																				object obj221 = "Complete" + 1176;
																																																				object obj222 = obj205 + 64;
																																																				obj222 = obj221;
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X20_v92-28]");
																																																				bool flag55 = (nint)0 < (nint)5;
																																																				object obj223 = !flag55;
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X20_v92-28]");
																																																				object obj224 = -5;
																																																				bool flag56 = obj224 == null;
																																																				object obj225 = ~obj223;
																																																				object obj226 = obj225 | flag56;
																																																				if (obj226 == null)
																																																				{
																																																					object obj227 = "Complete" + 1168;
																																																					object obj228 = obj205 + 72;
																																																					obj228 = obj227;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X20_v94-30]");
																																																					bool flag57 = (nint)0 < (nint)6;
																																																					object obj229 = !flag57;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X20_v94-30]");
																																																					object obj230 = -6;
																																																					bool flag58 = obj230 == null;
																																																					object obj231 = ~obj229;
																																																					object obj232 = obj231 | flag58;
																																																					if (obj232 == null)
																																																					{
																																																						object obj233 = "Picking audio files is not supported on iOS" + 200;
																																																						object obj234 = obj205 + 80;
																																																						obj234 = obj233;
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X20_v96-38]");
																																																						object obj235 = 0 & 0xFFFFFFF8L;
																																																						if (obj235 != null)
																																																						{
																																																							object obj236 = "Picking audio files is not supported on iOS" + 160;
																																																							object obj237 = obj205 + 88;
																																																							obj237 = obj236;
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X20_v98-40]");
																																																							bool flag59 = (nint)0 < (nint)8;
																																																							object obj238 = !flag59;
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X20_v98-40]");
																																																							object obj239 = -8;
																																																							bool flag60 = obj239 == null;
																																																							object obj240 = ~obj238;
																																																							object obj241 = obj240 | flag60;
																																																							if (obj241 == null)
																																																							{
																																																								object obj242 = "Picking audio files is not supported on iOS" + 336;
																																																								object obj243 = obj205 + 96;
																																																								obj243 = obj242;
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																								object obj244 = obj43;
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v118+B8]");
																																																								object obj245 = (nint)0 + (nint)40;
																																																								obj245 = obj205;
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v150+18]");
																																																								if ((nint)0 != 0)
																																																								{
																																																									object obj247 = default(object);
																																																									object obj246 = obj247 + 32;
																																																									obj246 = obj47;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X20_v100-8]");
																																																									object obj248 = 0 & 0xFFFFFFFEL;
																																																									if (obj248 != null)
																																																									{
																																																										object obj249 = obj247 + 40;
																																																										obj249 = obj47;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X20_v102-10]");
																																																										bool flag61 = (nint)0 < (nint)2;
																																																										object obj250 = !flag61;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X20_v102-10]");
																																																										object obj251 = -2;
																																																										bool flag62 = obj251 == null;
																																																										object obj252 = ~obj250;
																																																										object obj253 = obj252 | flag62;
																																																										if (obj253 == null)
																																																										{
																																																											object obj254 = "WhiteSmoke" + 1816;
																																																											object obj255 = obj247 + 48;
																																																											obj255 = obj254;
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X20_v104-18]");
																																																											object obj256 = 0 & 0xFFFFFFFCL;
																																																											if (obj256 != null)
																																																											{
																																																												object obj257 = obj247 + 56;
																																																												obj257 = obj58;
																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X20_v106-20]");
																																																												bool flag63 = (nint)0 < (nint)4;
																																																												object obj258 = !flag63;
																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X20_v106-20]");
																																																												object obj259 = -4;
																																																												bool flag64 = obj259 == null;
																																																												object obj260 = ~obj258;
																																																												object obj261 = obj260 | flag64;
																																																												if (obj261 == null)
																																																												{
																																																													object obj262 = obj247 + 64;
																																																													obj262 = obj58;
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X20_v108-28]");
																																																													bool flag65 = (nint)0 < (nint)5;
																																																													object obj263 = !flag65;
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X20_v108-28]");
																																																													object obj264 = -5;
																																																													bool flag66 = obj264 == null;
																																																													object obj265 = ~obj263;
																																																													object obj266 = obj265 | flag66;
																																																													if (obj266 == null)
																																																													{
																																																														object obj267 = obj247 + 72;
																																																														obj267 = obj58;
																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X20_v110-30]");
																																																														bool flag67 = (nint)0 < (nint)6;
																																																														object obj268 = !flag67;
																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X20_v110-30]");
																																																														object obj269 = -6;
																																																														bool flag68 = obj269 == null;
																																																														object obj270 = ~obj268;
																																																														object obj271 = obj270 | flag68;
																																																														if (obj271 == null)
																																																														{
																																																															object obj272 = obj247 + 80;
																																																															obj272 = obj58;
																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X20_v112-38]");
																																																															object obj273 = 0 & 0xFFFFFFF8L;
																																																															if (obj273 != null)
																																																															{
																																																																object obj274 = obj247 + 88;
																																																																obj274 = obj58;
																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X20_v114-40]");
																																																																bool flag69 = (nint)0 < (nint)8;
																																																																object obj275 = !flag69;
																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X20_v114-40]");
																																																																object obj276 = -8;
																																																																bool flag70 = obj276 == null;
																																																																object obj277 = ~obj275;
																																																																object obj278 = obj277 | flag70;
																																																																if (obj278 == null)
																																																																{
																																																																	object obj279 = obj247 + 96;
																																																																	obj279 = obj58;
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																																	object obj280 = obj43;
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v861 @ X8_v130+B8]");
																																																																	object obj281 = (nint)0 + (nint)48;
																																																																	obj281 = obj247;
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																																																	return;
																																																																}
																																																															}
																																																														}
																																																													}
																																																												}
																																																											}
																																																										}
																																																									}
																																																								}
																																																							}
																																																						}
																																																					}
																																																				}
																																																			}
																																																		}
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
