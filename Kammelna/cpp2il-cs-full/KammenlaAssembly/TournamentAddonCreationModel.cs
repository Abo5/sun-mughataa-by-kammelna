using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities.Data;
using UnityEngine.Purchasing.Telemetry;

[Serializable]
public class TournamentAddonCreationModel
{
	private const string addonType = "aot";

	private const string addonData = "aod";

	private const string levelIdKey = "lid";

	private TournamentAddonType <AddonType>k__BackingField;

	private string <SerializedData>k__BackingField;

	private int <LevelId>k__BackingField;

	private string <RequiredLevelsJson>k__BackingField;

	public TournamentAddonType AddonType
	{
		get
		{
			return <AddonType>k__BackingField;
		}
		set
		{
			<AddonType>k__BackingField = value;
		}
	}

	public string SerializedData
	{
		get
		{
			return <SerializedData>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int LevelId
	{
		get
		{
			return <LevelId>k__BackingField;
		}
		set
		{
			<LevelId>k__BackingField = value;
		}
	}

	public string RequiredLevelsJson
	{
		get
		{
			return <RequiredLevelsJson>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public TournamentAddonCreationModel(ISFSObject addon)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0036: Expected O, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		object obj = "alignContent" + 672;
		object obj2 = (nint)0 + (nint)192;
		object varName = "alignContent" + 664;
		object defaultValue = (nint)0 + (nint)2000;
		object varName2 = "java.io.FileOutputStream" + 2528;
		<LevelId>k__BackingField = 1;
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		TournamentAddonType tournamentAddonType = default(TournamentAddonType);
		<AddonType>k__BackingField = tournamentAddonType;
		string text = SFSExtensions.Get(addon, (string)varName, (string)defaultValue);
		object obj3 = this + 24;
		obj3 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<LevelId>k__BackingField = SFSExtensions.Get(addon, (string)varName2, 1);
		string text2 = SFSExtensions.Get(addon, (string)varName2, (string)defaultValue);
		object obj4 = this + 40;
		obj4 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public TournamentAddonCreationModel(TournamentAddonType modelFeatureAddonType, string featureDataSerializedData)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		<LevelId>k__BackingField = 1;
		base..ctor();
		object obj = this + 24;
		obj = featureDataSerializedData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public TournamentAddonCreationModel(TournamentAddonModel addonModel)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		<LevelId>k__BackingField = 1;
		base..ctor();
		TournamentAddonType type = addonModel.Type;
		<AddonType>k__BackingField = type;
		string serializedData = addonModel.SerializedData;
		object obj = this + 24;
		obj = serializedData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public TournamentAddonModel GetAddonModel()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003d: Expected I, but got O
		//IL_0066: Expected O, but got I4
		//IL_0209: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_013c: Expected O, but got I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_022c: Expected O, but got I
		//IL_0256: Expected O, but got I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		TournamentAddonModel modelByType = TournamentAddonTypeExtensions.GetModelByType(<AddonType>k__BackingField, <SerializedData>k__BackingField);
		if (modelByType != null)
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 584;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1200;
			object obj3 = obj;
			nint num = (nint)modelByType;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6 (Il2CppClass<TournamentAddonModel>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X11_v2+130]");
			bool flag = num2 < 0;
			object obj4 = !flag;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6 (Il2CppClass<TournamentAddonModel>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X11_v2+130]");
				object obj6 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X12_v4-8]");
				if (0 == (nint)obj3)
				{
					_ = <LevelId>k__BackingField;
				}
			}
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6 (Il2CppClass<TournamentAddonModel>)+130]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v4+130]");
			bool flag2 = num4 < 0;
			object obj8 = !flag2;
			object obj9 = ~obj8;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6 (Il2CppClass<TournamentAddonModel>)+C8]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v4+130]");
				object obj10 = num5 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v8-8]");
				if (0 == (nint)obj7)
				{
					bool flag3 = string.IsNullOrEmpty(<RequiredLevelsJson>k__BackingField);
					bool flag4 = !flag3;
					object obj11 = !flag4;
					if (obj11 == null)
					{
						object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
						object obj13 = (nint)0 + (nint)1064;
						object obj14 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v9+E4]");
						bool flag5 = (nint)0 == 0;
						object obj15 = !flag5;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E949E4");
						object obj16 = modelByType + 24;
						object obj17 = default(object);
						obj16 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					return modelByType;
				}
			}
		}
		return modelByType;
	}
}
