using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentEligibilityIndicator : MonoBehaviour
{
	private const string Eligible = "Eligible";

	private const string EligibleToReserve = "Eligible To Reserve";

	private const string OverQualified = "Eligible to higher championship";

	private const string NotEligible = "Not Eligible";

	private const string Participant = "Participant";

	private const string NotParticipant = "Not Participant";

	private static readonly Color EligibleSolidColor;

	private static readonly Color EligibleGradiantColor;

	private static readonly Color EligibleToReserveSolidColor;

	private static readonly Color EligibleToReserveGradiantColor;

	private TextMeshProUGUI text;

	private GameObject eligibilityIndicator;

	private Image solidIcon;

	private Image gradiantIcon;

	private bool hasDeep;

	private GameObject regularDeep;

	private GameObject eligibleDeep;

	private GameObject waitingDeep;

	public void Initialize(MassTournamentPlayerState player)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		TextMeshProExtensions.Localize(text, friendlyName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum indicator = default(Enum);
		SetIndicator(indicator);
	}

	public void Initialize(TournamentData tournament)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_052a: Expected O, but got I
		//IL_0554: Expected O, but got I4
		//IL_007b: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_0183: Expected O, but got I4
		//IL_019d: Expected O, but got I4
		//IL_01b3: Expected O, but got I4
		//IL_012c: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_00ce: Expected O, but got I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00fc: Expected O, but got I4
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_01d5: Expected O, but got I
		//IL_058c: Expected O, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_03fc: Expected O, but got I4
		//IL_02b6: Expected O, but got I
		//IL_02cc: Expected I4, but got O
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_02fa: Expected O, but got I4
		//IL_0316: Expected O, but got I4
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0358: Expected O, but got I4
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_0498: Expected O, but got I4
		//IL_05a8: Expected O, but got I4
		//IL_04c3: Expected O, but got I4
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		//IL_0602: Expected O, but got I4
		//IL_0633: Expected O, but got I4
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected O, but got Unknown
		//IL_0689: Expected O, but got I4
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected O, but got Unknown
		object obj = "Drop Menu Toggle" + 2200;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		MonthlyTournamentEligibilityType monthlyTournamentEligibility = SFSKammelnaUserExtensions.GetMonthlyTournamentEligibility(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DD9]");
		object obj6 = (nint)0 & (nint)1;
		System.Int32Enum? int32Enum2;
		System.Int32Enum int32Enum3;
		System.Int32Enum int32Enum;
		if (obj6 != null)
		{
			int32Enum = (System.Int32Enum)(monthlyTournamentEligibility - 1);
			bool flag2 = int32Enum < (System.Int32Enum)3;
			object obj7 = !flag2;
			object obj8 = int32Enum - 3;
			bool flag3 = obj8 == null;
			object obj9 = ~obj7;
			object obj10 = obj9 | flag3;
			int32Enum2 = (System.Int32Enum?)(object)0;
			int32Enum3 = int32Enum;
			if (obj10 == null)
			{
				goto IL_0112;
			}
		}
		else
		{
			_ = 1;
			int32Enum = (System.Int32Enum)(monthlyTournamentEligibility - 1);
			bool flag4 = int32Enum < (System.Int32Enum)3;
			object obj11 = !flag4;
			object obj12 = int32Enum - 3;
			bool flag5 = obj12 == null;
			object obj13 = !flag5;
			object obj14 = obj11 & obj13;
			int32Enum2 = (System.Int32Enum?)(object)0;
			int32Enum3 = int32Enum;
			if (obj14 != null)
			{
				goto IL_0112;
			}
		}
		object obj15 = (nint)0 + (nint)488;
		System.Int32Enum? int32Enum4 = int32Enum3;
		System.Int32Enum? int32Enum5 = int32Enum4;
		int32Enum = int32Enum3;
		int32Enum2 = int32Enum4;
		goto IL_01ff;
		IL_0112:
		bool flag6 = tournament == null;
		object obj16 = !flag6;
		int32Enum5 = int32Enum2;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01ff;
		IL_01ff:
		object obj17 = "Drop Menu Toggle" + 2208;
		object obj18 = (??)tournament.<SubType>k__BackingField & 1;
		bool flag7 = obj18 == null;
		bool flag8 = false;
		if (!flag7)
		{
			object obj19 = (??)int32Enum2 & 1;
			bool flag9 = obj19 == null;
			flag8 = false;
			if (!flag9)
			{
				object obj20 = (object?)int32Enum2 ^ (object?)tournament.<SubType>k__BackingField;
				object obj21 = obj20 >> 32;
				bool flag10 = obj21 == null;
				object obj22 = (nint)0 + (nint)520;
				System.Int32Enum value = int32Enum5.Value;
				int32Enum = (System.Int32Enum)obj22;
				System.Int32Enum? int32Enum6 = default(System.Int32Enum?);
				System.Int32Enum value2 = int32Enum6.Value;
				object obj23 = "Drop Menu Toggle" + 2216;
				object obj24 = value - value2;
				bool flag11 = (nint)obj24 < 0;
				object obj25 = value ^ value2;
				object obj26 = value ^ obj24;
				object obj27 = obj25 & obj26;
				bool flag12 = (nint)obj27 < 0;
				bool flag13 = flag11 == flag12;
				object obj28 = !flag13;
				object obj29 = ~obj28;
				if (obj29 == null)
				{
					obj17 = obj23;
					flag8 = flag10;
				}
				else
				{
					flag8 = flag10;
				}
			}
		}
		object obj30 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v12+E4]");
		bool flag14 = (nint)0 == 0;
		object obj31 = !flag14;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		bool flag15 = tournament.CanParticipate(localUser2);
		object obj32 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v19+E4]");
		bool flag16 = (nint)0 == 0;
		object obj33 = !flag16;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj34 = "Network Authentication Required" + 1760;
		object obj35 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		SessionModel sessionModel3 = default(SessionModel);
		User localUser3 = sessionModel3.LocalUser;
		bool flag17 = tournament.CanParticipate(localUser3);
		object obj36 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X9_v3+E4]");
		bool flag18 = (nint)0 == 0;
		object obj37 = !flag18;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj38 = (flag15 ? 1 : 0) ^ 1;
		if (tournament.<Type>k__BackingField != TournamentType.OfficialMonthly)
		{
			obj38 = 1;
		}
		object obj39 = obj38 | flag8;
		object obj40 = obj39 & 1;
		bool flag19 = obj40 == null;
		object obj41 = !flag19;
		object obj42 = ~obj41;
		string text = (string)((obj42 != null) ? obj17 : obj);
		bool flag20 = !flag17;
		object obj43 = !flag20;
		object obj44 = ~obj43;
		string text2 = (string)((obj44 != null) ? obj34 : text);
		bool flag21 = SfsTournamentConnector.IsParticipating(tournament.<RoomId>k__BackingField);
		object obj45 = "October" + 3248;
		bool flag22 = !flag21;
		object obj46 = !flag22;
		object obj47 = ~obj46;
		string text3 = (string)((obj47 != null) ? text2 : obj45);
		TextMeshProExtensions.Localize(this.text, text3);
		object obj48 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum indicator = default(Enum);
		SetIndicator(indicator);
	}

	public void InitializeAsRegistered()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		object obj = "October" + 3248;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1528;
		TextMeshProExtensions.Localize(text, (string)obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum indicator = default(Enum);
		SetIndicator(indicator);
	}

	private void SetText(string status)
	{
		TextMeshProExtensions.Localize(text, status);
	}

	private void SetIndicator(Enum status)
	{
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected O, but got Unknown
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_088c: Expected O, but got I
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0465: Expected I4, but got O
		//IL_055c: Expected O, but got I4
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_05cb: Expected O, but got I4
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_0218: Expected O, but got I4
		//IL_04c0: Expected I, but got O
		//IL_04c9: Expected O, but got I4
		//IL_061d: Expected O, but got I
		//IL_062d: Expected O, but got I
		//IL_063d: Expected O, but got I
		//IL_0655: Expected O, but got I
		//IL_065d: Expected I, but got O
		//IL_066d: Expected O, but got I
		//IL_0505: Expected I, but got O
		//IL_0272: Expected O, but got I
		//IL_0282: Expected O, but got I
		//IL_0292: Expected O, but got I
		//IL_02a2: Expected O, but got I
		//IL_02b2: Expected O, but got I
		//IL_02ba: Expected I, but got O
		//IL_02ca: Expected O, but got I
		//IL_06b8: Expected O, but got I
		//IL_06c8: Expected O, but got I
		//IL_06d8: Expected O, but got I
		//IL_06e8: Expected O, but got I
		//IL_06f8: Expected O, but got I
		//IL_0700: Expected I, but got O
		//IL_0710: Expected O, but got I
		//IL_071d: Expected O, but got I
		//IL_0535: Expected I, but got O
		//IL_0315: Expected O, but got I
		//IL_0325: Expected O, but got I
		//IL_0335: Expected O, but got I
		//IL_0345: Expected O, but got I
		//IL_0355: Expected O, but got I
		//IL_035d: Expected I, but got O
		//IL_036d: Expected O, but got I
		//IL_037a: Expected O, but got I
		//IL_0784: Expected I, but got O
		//IL_03e1: Expected I, but got O
		//IL_07c7: Expected I, but got O
		//IL_0424: Expected I, but got O
		//IL_042d: Expected O, but got I4
		//IL_08e7: Expected I, but got O
		//IL_08ef: Expected O, but got I4
		bool flag = status == null;
		Enum obj = status;
		Enum actualValue = status;
		Enum obj5;
		if (!flag)
		{
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3744;
			obj = (Enum)obj2;
			nint num = (nint)status;
			if (status != obj2)
			{
				object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1528;
				obj = (Enum)obj3;
				bool flag2 = status != obj3;
				actualValue = status;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v7 (Il2CppClass<System.Enum>)+40]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X1_v7 (System.Enum)+40]");
					if (num2 != 0)
					{
						goto IL_08a1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
					object obj4 = default(object);
					bool flag3 = (nint)obj4 == 2;
					obj5 = (Enum)obj3;
					if (flag3)
					{
						goto IL_01d0;
					}
					if ((nint)obj4 == 1)
					{
						goto IL_0449;
					}
					if (obj4 == null)
					{
						goto IL_0583;
					}
					actualValue = status;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v7 (Il2CppClass<System.Enum>)+40]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X1_v7 (System.Enum)+40]");
				if (num3 != 0)
				{
					goto IL_08a1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
				object obj6 = default(object);
				if (obj6 == null)
				{
					goto IL_0449;
				}
				if ((nint)obj6 == 1)
				{
					goto IL_0583;
				}
				bool flag4 = (nint)obj6 != 2;
				obj5 = (Enum)obj2;
				actualValue = status;
				if (!flag4)
				{
					goto IL_01d0;
				}
			}
		}
		object obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = "startPosition" + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		ex..ctor(paramName, actualValue, null);
		object obj9 = (nint)0 + (nint)808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
		IL_01d0:
		actualValue = (Enum)(object)solidIcon;
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1520;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v42+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = actualValue == null;
		obj = obj5;
		GameObject gameObject;
		bool flag9;
		nint num6;
		if (!flag6)
		{
			object obj13 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v24+B8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v25+28]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v25+2C]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v25+20]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v25+24]");
			object obj18 = 0;
			nint num4 = (nint)actualValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v26 (Il2CppClass<System.Enum>)+2B0]");
			obj = (Enum)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v462 @ X8_v26 (Il2CppClass<System.Enum>)+2A8] (should have been resolved before IL gen)");
			Image image = gradiantIcon;
			if ((object)gradiantIcon != null)
			{
				object obj19 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v27+B8]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v28+38]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v28+3C]");
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v28+30]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v28+34]");
				obj18 = 0;
				nint num5 = (nint)image;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v29 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
				obj = (Enum)0;
				gradiantIcon.color = (Color)0;
				if (!hasDeep)
				{
					goto IL_07e8;
				}
				if ((object)regularDeep != null)
				{
					regularDeep.SetActive(value: false);
					bool flag7 = (object)waitingDeep == null;
					num6 = unchecked((nint)null);
					obj = null;
					if (!flag7)
					{
						waitingDeep.SetActive(value: true);
						gameObject = eligibleDeep;
						bool flag8 = (object)eligibleDeep == null;
						num6 = unchecked((nint)null);
						obj = (Enum)1;
						if (!flag8)
						{
							flag9 = false;
							goto IL_08d5;
						}
					}
				}
			}
		}
		goto IL_0818;
		IL_07e8:
		if ((object)eligibilityIndicator != null)
		{
			eligibilityIndicator.SetActive(value: true);
			return;
		}
		goto IL_0818;
		IL_0583:
		actualValue = (Enum)(object)solidIcon;
		object obj21 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1520;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v25+E4]");
		bool flag10 = (nint)0 == 0;
		object obj23 = !flag10;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (actualValue != null)
		{
			object obj24 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v13+B8]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v14+8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v14+C]");
			object obj16 = 0;
			object obj17 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v14+4]");
			object obj18 = 0;
			nint num7 = (nint)actualValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v15 (Il2CppClass<System.Enum>)+2B0]");
			obj = (Enum)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v464 @ X8_v15 (Il2CppClass<System.Enum>)+2A8] (should have been resolved before IL gen)");
			Image image2 = gradiantIcon;
			if ((object)gradiantIcon != null)
			{
				object obj26 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v16+B8]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v17+18]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v17+1C]");
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v17+10]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v17+14]");
				obj18 = 0;
				nint num8 = (nint)image2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v18 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
				obj = (Enum)0;
				gradiantIcon.color = (Color)0;
				if (!hasDeep)
				{
					goto IL_07e8;
				}
				if ((object)regularDeep != null)
				{
					regularDeep.SetActive(value: false);
					bool flag11 = (object)waitingDeep == null;
					num6 = unchecked((nint)null);
					obj = null;
					if (!flag11)
					{
						waitingDeep.SetActive(value: false);
						gameObject = eligibleDeep;
						bool flag12 = (object)eligibleDeep == null;
						num6 = unchecked((nint)null);
						obj = null;
						if (!flag12)
						{
							flag9 = true;
							goto IL_08d5;
						}
					}
				}
			}
		}
		goto IL_0818;
		IL_0543:
		bool flag13 = (object)eligibilityIndicator == null;
		bool flag14;
		obj = (Enum)flag14;
		actualValue = status;
		if (!flag13)
		{
			eligibilityIndicator.SetActive(value: false);
			return;
		}
		goto IL_0818;
		IL_0449:
		bool flag15 = !hasDeep;
		flag14 = (byte)(int)obj != 0;
		if (flag15)
		{
			goto IL_0543;
		}
		bool flag16 = (object)regularDeep == null;
		actualValue = status;
		if (!flag16)
		{
			regularDeep.SetActive(value: true);
			bool flag17 = (object)waitingDeep == null;
			num6 = unchecked((nint)null);
			obj = (Enum)1;
			actualValue = status;
			if (!flag17)
			{
				waitingDeep.SetActive(value: false);
				bool flag18 = (object)eligibleDeep == null;
				num6 = unchecked((nint)null);
				obj = null;
				actualValue = status;
				if (!flag18)
				{
					eligibleDeep.SetActive(value: false);
					num6 = unchecked((nint)null);
					flag14 = false;
					goto IL_0543;
				}
			}
		}
		goto IL_0818;
		IL_0818:
		throw new NullReferenceException();
		IL_08d5:
		gameObject.SetActive(flag9);
		num6 = unchecked((nint)null);
		obj = (Enum)flag9;
		goto IL_07e8;
		IL_08a1:
		throw new InvalidCastException();
	}

	static TournamentEligibilityIndicator()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1520;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252E10]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252E20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252E30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252E40]");
		_ = 0;
	}
}
