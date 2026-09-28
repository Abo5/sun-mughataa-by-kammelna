using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using UnityEngine;

public class TournamentSprites : ScriptableObject
{
	private Sprite instant;

	private Sprite scheduled;

	private Sprite publicType;

	private Sprite privateType;

	private Sprite officialType;

	private Sprite platHalfCup;

	private Sprite goldHalfCup;

	private Sprite silverHalfCup;

	private Sprite bronzeHalfCup;

	private Sprite platFirstCup;

	private Sprite goldFirstCup;

	private Sprite silverFirstCup;

	private Sprite bronzeFirstCup;

	private Sprite platSecondCup;

	private Sprite goldSecondCup;

	private Sprite silverSecondCup;

	private Sprite bronzeSecondCup;

	private Sprite platTitle;

	private Sprite goldTitle;

	private Sprite silverTitle;

	private Sprite bronzeTitle;

	private Sprite platCertificate;

	private Sprite goldCertificate;

	private Sprite silverCertificate;

	private Sprite bronzeCertificate;

	private Sprite platChampion;

	private Sprite goldChampion;

	private Sprite silverChampion;

	private Sprite bronzeChampion;

	private Sprite chatEnabled;

	private Sprite chatDisabled;

	private Sprite chooseTeammateEnabled;

	private Sprite chooseTeammateDisabled;

	private ThemeColorProfile kammelnaColors;

	private ThemeColorProfile officialMonthlyColors;

	private ThemeColorProfile officialChampionsColors;

	private const string PlatDescription = "PLAT_DESCRIPTION";

	private const string GoldDescription = "GOLD_DESCRIPTION";

	private const string SilverDescription = "SILVER_DESCRIPTION";

	private const string BronzeDescription = "BRONZE_DESCRIPTION";

	public Sprite GetSchedulingIcon(bool isInstant)
	{
		//IL_001a: Expected O, but got I4
		//IL_0048: Expected O, but got I4
		//IL_005a: Expected O, but got I
		//IL_003a: Expected O, but got I4
		bool flag = !isInstant;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			object obj3 = 24;
		}
		else
		{
			object obj3 = 32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentSprites)+v16 @ X8_v2]");
		return (Sprite)0;
	}

	public Sprite GetChatIcon(bool isEnabled)
	{
		//IL_001a: Expected O, but got I4
		//IL_0048: Expected O, but got I4
		//IL_005a: Expected O, but got I
		//IL_003a: Expected O, but got I4
		bool flag = !isEnabled;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			object obj3 = 256;
		}
		else
		{
			object obj3 = 264;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentSprites)+v16 @ X8_v2]");
		return (Sprite)0;
	}

	public Sprite GetChooseTeammateIcon(bool isEnabled)
	{
		//IL_001a: Expected O, but got I4
		//IL_0048: Expected O, but got I4
		//IL_005a: Expected O, but got I
		//IL_003a: Expected O, but got I4
		bool flag = !isEnabled;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			object obj3 = 272;
		}
		else
		{
			object obj3 = 280;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentSprites)+v16 @ X8_v2]");
		return (Sprite)0;
	}

	public unsafe Sprite GetTournamentTypeIcon(TournamentType type)
	{
		//IL_00b5: Expected O, but got Ref
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_011c: Expected O, but got I4
		switch (type)
		{
		case TournamentType.Official:
		case TournamentType.OfficialMonthly:
			return officialType;
		case TournamentType.Private:
			return privateType;
		default:
		{
			object obj = default(object);
			string text = ((Enum)(&obj)).ToString();
			object obj2 = "UInt16" + 2576;
			string text2 = (string)obj2 + text;
			object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			object obj6 = text2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = text2;
			}
			KLogger.LogError(obj6);
			break;
		}
		case TournamentType.Public:
		case TournamentType.Mass:
			break;
		}
		return publicType;
	}

	public Sprite GetMonthlyTournamentHalfCup(TournamentSubType? subType)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003c: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_012b: Expected O, but got I
		object obj = (??)subType & -17179869183L;
		if ((nint)obj == 1)
		{
			object obj2 = (object?)subType >> 29;
			object obj3 = obj2 & 0x18;
			object obj4 = obj3 | 0x40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentSprites)+v60 @ X8_v10]");
			return (Sprite)0;
		}
		object obj5 = "UInt16" + 2560;
		object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		System.Int32Enum? int32Enum = default(System.Int32Enum?);
		string text = int32Enum.ToString();
		string text2 = (string)obj5 + text;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		object obj9 = text2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = text2;
		}
		KLogger.LogError(obj9);
		object obj10 = 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentSprites)+v99 @ X8_v7]");
		return (Sprite)0;
	}

	public Sprite GetMonthlyTournamentSecondCup(TournamentSubType? subType)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003c: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_012b: Expected O, but got I
		object obj = (??)subType & -17179869183L;
		if ((nint)obj == 1)
		{
			object obj2 = (object?)subType >> 29;
			object obj3 = obj2 & 0x18;
			object obj4 = obj3 | 0x80;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentSprites)+v60 @ X8_v10]");
			return (Sprite)0;
		}
		object obj5 = "UInt16" + 2560;
		object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		System.Int32Enum? int32Enum = default(System.Int32Enum?);
		string text = int32Enum.ToString();
		string text2 = (string)obj5 + text;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		object obj9 = text2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = text2;
		}
		KLogger.LogError(obj9);
		object obj10 = 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentSprites)+v99 @ X8_v7]");
		return (Sprite)0;
	}

	public Sprite GetMonthlyTournamentFirstCup(TournamentSubType? subType)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003c: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_012b: Expected O, but got I
		object obj = (??)subType & -17179869183L;
		if ((nint)obj == 1)
		{
			object obj2 = (object?)subType >> 29;
			object obj3 = obj2 & 0x18;
			object obj4 = obj3 | 0x60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentSprites)+v60 @ X8_v10]");
			return (Sprite)0;
		}
		object obj5 = "UInt16" + 2560;
		object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		System.Int32Enum? int32Enum = default(System.Int32Enum?);
		string text = int32Enum.ToString();
		string text2 = (string)obj5 + text;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		object obj9 = text2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = text2;
		}
		KLogger.LogError(obj9);
		object obj10 = 120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentSprites)+v99 @ X8_v7]");
		return (Sprite)0;
	}

	public Sprite GetMonthlyTournamentTypeTitle(TournamentSubType? subType)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003c: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_012b: Expected O, but got I
		object obj = (??)subType & -17179869183L;
		if ((nint)obj == 1)
		{
			object obj2 = (object?)subType >> 29;
			object obj3 = obj2 & 0x18;
			object obj4 = obj3 | 0xA0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentSprites)+v61 @ X8_v10]");
			return (Sprite)0;
		}
		object obj5 = "UInt16" + 2560;
		object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		System.Int32Enum? int32Enum = default(System.Int32Enum?);
		string text = int32Enum.ToString();
		string text2 = (string)obj5 + text;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		object obj9 = text2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = text2;
		}
		KLogger.LogError(obj9);
		object obj10 = 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentSprites)+v99 @ X8_v7]");
		return (Sprite)0;
	}

	public Sprite GetMonthlyTournamentCertificate(TournamentSubType? subType)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003c: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_012b: Expected O, but got I
		object obj = (??)subType & -17179869183L;
		if ((nint)obj == 1)
		{
			object obj2 = (object?)subType >> 29;
			object obj3 = obj2 & 0x18;
			object obj4 = obj3 | 0xC0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentSprites)+v60 @ X8_v10]");
			return (Sprite)0;
		}
		object obj5 = "UInt16" + 2560;
		object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		System.Int32Enum? int32Enum = default(System.Int32Enum?);
		string text = int32Enum.ToString();
		string text2 = (string)obj5 + text;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		object obj9 = text2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = text2;
		}
		KLogger.LogError(obj9);
		object obj10 = 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentSprites)+v99 @ X8_v7]");
		return (Sprite)0;
	}

	public string GetMonthlyTournamentDescription(TournamentSubType? subType)
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		//IL_0022: Expected O, but got I4
		//IL_0032: Expected O, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		object obj = (??)subType & -17179869183L;
		if ((nint)obj == 1)
		{
			object obj2 = (object?)subType >> 32;
			object obj3 = 139821056 + 2896;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X9_v3+v57 @ X8_v9*8]");
			return (string)0;
		}
		object obj4 = "UInt16" + 2560;
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		System.Int32Enum? int32Enum = default(System.Int32Enum?);
		string text = int32Enum.ToString();
		string text2 = (string)obj4 + text;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		object obj8 = text2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = text2;
		}
		KLogger.LogError(obj8);
		return "AvailableVoices" + 672;
	}

	public Sprite GetMonthlyTournamentChampionTitle(TournamentSubType? subType)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003c: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_012b: Expected O, but got I
		object obj = (??)subType & -17179869183L;
		if ((nint)obj == 1)
		{
			object obj2 = (object?)subType >> 29;
			object obj3 = obj2 & 0x18;
			object obj4 = obj3 | 0xE0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentSprites)+v60 @ X8_v10]");
			return (Sprite)0;
		}
		object obj5 = "UInt16" + 2560;
		object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		System.Int32Enum? int32Enum = default(System.Int32Enum?);
		string text = int32Enum.ToString();
		string text2 = (string)obj5 + text;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		object obj9 = text2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = text2;
		}
		KLogger.LogError(obj9);
		object obj10 = 248;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentSprites)+v99 @ X8_v7]");
		return (Sprite)0;
	}

	public ThemeColorProfile GetDefaultTheme()
	{
		return kammelnaColors;
	}

	public IThemeColorProfile GetTheme(TournamentData tournament)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		if (tournament != null)
		{
			if (tournament.<IsChampions>k__BackingField)
			{
				return officialChampionsColors;
			}
			if (tournament.<Type>k__BackingField != TournamentType.Mass)
			{
				if (tournament.<Type>k__BackingField == TournamentType.OfficialMonthly)
				{
					return officialMonthlyColors;
				}
			}
			else
			{
				object obj = (??)tournament.<ParentMassEventId>k__BackingField & 1;
				if (obj != null)
				{
					long? num = default(long?);
					long value = num.Value;
					MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(value);
					if (cachedMassEvent != null)
					{
						return cachedMassEvent.GenerateTheme();
					}
					goto IL_0105;
				}
			}
			return kammelnaColors;
		}
		goto IL_0105;
		IL_0105:
		return (IThemeColorProfile)new NullReferenceException();
	}
}
