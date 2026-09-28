using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class FeaturesBottomSheet : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<TournamentAddonSelector> <>9__54_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 2312;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <ClearSelectors>b__54_0(TournamentAddonSelector s)
		{
			//IL_0008: Expected I, but got O
			//IL_0018: Expected O, but got I
			//IL_0028: Expected O, but got I
			nint num = (nint)s;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<TournamentAddonSelector>)+208]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<TournamentAddonSelector>)+210]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass40_0
	{
		public TournamentFeature feature;

		internal bool <PopulateAvailableAddons>b__0(TournamentFeatureAvailableItem f)
		{
			//IL_00b9: Expected I4, but got O
			//IL_008c: Expected O, but got I4
			if ((object)f != null)
			{
				TournamentFeature <Feature>k__BackingField = f.<Feature>k__BackingField;
				if ((object)f.<Feature>k__BackingField != null)
				{
					TournamentFeature tournamentFeature = feature;
					if ((object)feature != null)
					{
						object obj = <Feature>k__BackingField.FeatureType - tournamentFeature.FeatureType;
						bool flag = obj == null;
						return !flag;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass45_0
	{
		public TournamentAddonSelector selector;

		internal bool <ActivateSelector>b__0(KeyValuePair<TournamentAddonType, TournamentAddonModel> s)
		{
			//IL_0043: Expected I4, but got O
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			if ((object)selector != null)
			{
				TournamentAddonType addonType = selector.addonType;
				object obj = addonType - s;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private GameObject availableFeaturesSelectors;

	private TitleAddonSelector titleSelector;

	private CardbackAddonSelector cardbackSelector;

	private ChampionshipAddonSelector championshipSelector;

	private RoomthemeAddonSelector roomThemeSelector;

	private MessageAddonSelector messageSelector;

	private SportTeamAddonSelector sportTeamSelector;

	private Dictionary<TournamentAddonType, TournamentAddonSelector> AllSelectors;

	private TournamentFeatureAvailableItem availableFeaturesPrefab;

	private TournamentFeatureSelectedItem selectedFeaturesPrefab;

	private List<TournamentFeatureAvailableItem> availableFeatureItems;

	private List<TournamentFeatureSelectedItem> selectedFeatureItems;

	private Transform availableFeaturesParent;

	private Transform selectedFeaturesParent;

	private GameObject addFeaturesText;

	private PopupUI popup;

	private TextMeshProUGUI title;

	private TextMeshProUGUI subTitle;

	private Button confirmButton;

	private TournamentFeatureEditView featureEditPopupPrefab;

	public TournamentFeaturesList features;

	private TournamentsCreationPopupEventsChannel eventsChannel;

	private TournamentAddonSelector ActiveSelector;

	private TournamentFeatureEditView featureEditPopupInstance;

	public Dictionary<TournamentAddonType, TournamentAddonModel> SelectedAddons;

	private Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig> AddonConfig
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CE8]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v6+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_011d;
			}
			goto IL_0156;
			IL_0156:
			return (Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig>)(object)new NullReferenceException();
			IL_011d:
			if (current.<Tournaments>k__BackingField != null)
			{
				return current.<Tournaments>k__BackingField.Addons;
			}
			goto IL_0156;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag2 = current == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_011d;
			}
			goto IL_0156;
		}
	}

	private TournamentAddonConfig.TitleRestrictionConfig TitleConfig
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected O, but got Unknown
			//IL_01b3: Expected I, but got O
			//IL_01dc: Expected O, but got I4
			//IL_0211: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C30]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v12+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_011d;
			}
			goto IL_024f;
			IL_024f:
			return (TournamentAddonConfig.TitleRestrictionConfig)(object)new NullReferenceException();
			IL_011d:
			if (current.<Tournaments>k__BackingField != null)
			{
				Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig> addons = current.<Tournaments>k__BackingField.Addons;
				object obj5 = DictionaryExtensions.Get((IDictionary<System.Int32Enum, object>)addons, (System.Int32Enum)4);
				bool flag2 = obj5 == null;
				TournamentAddonConfig.TitleRestrictionConfig result = (TournamentAddonConfig.TitleRestrictionConfig)obj5;
				if (!flag2)
				{
					object obj6 = typeof(SkeletonBinary.SkeletonInput) + 3424;
					object obj7 = obj6;
					nint num = (nint)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X9_v2 (Il2CppClass<System.Object>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+130]");
					bool flag3 = num2 < 0;
					object obj8 = !flag3;
					if (obj8 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X9_v2 (Il2CppClass<System.Object>)+C8]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+130]");
						object obj9 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X9_v4-8]");
						if (0 == (nint)obj7)
						{
							return (TournamentAddonConfig.TitleRestrictionConfig)obj5;
						}
						return null;
					}
					result = null;
				}
				return result;
			}
			goto IL_024f;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag4 = current == null;
			object obj10 = !flag4;
			if (obj10 != null)
			{
				goto IL_011d;
			}
			goto IL_024f;
		}
	}

	public long GetSelectedAddonsPrice
	{
		get
		{
			//IL_008b: Expected I8, but got O
			//IL_0011: Expected O, but got I
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			//IL_003d: Expected O, but got I
			//IL_0069: Expected I, but got O
			if (SelectedAddons != null)
			{
				object obj = (nint)0 + (nint)2312;
				object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3848;
				object obj3 = (nint)0 + (nint)2624;
				object obj4 = (nint)0 + (nint)752;
				Dictionary<System.Int32Enum, object>.ValueCollection values = ((Dictionary<System.Int32Enum, object>)(object)SelectedAddons).Values;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, long> func = default(Func<object, long>);
				func..ctor((object)this, (IntPtr)obj3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DE3A00");
				long result = default(long);
				return result;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}
	}

	public int? CardBackId
	{
		get
		{
			//IL_00f2: Expected O, but got I
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0022: Expected I, but got O
			//IL_0032: Expected O, but got I
			//IL_006d: Expected O, but got I
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected O, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected O, but got Unknown
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected O, but got Unknown
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			object obj = (nint)0 + (nint)480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304E320");
			IEnumerable<object> source = default(IEnumerable<object>);
			object obj2 = Enumerable.FirstOrDefault(source);
			bool flag = obj2 == null;
			int? result = (int?)obj2;
			if (flag)
			{
				goto IL_00f7;
			}
			object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1400;
			nint num = (nint)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v8 (Il2CppClass<System.Object>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v8 (Il2CppClass<System.Object>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ae;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v8 (Il2CppClass<System.Object>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X10_v6-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00ae;
			}
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_0120;
			IL_0120:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v125 @ X8_v9] (should have been resolved before IL gen)");
			int value = default(int);
			int? num2 = value;
			result = num2;
			goto IL_00f7;
			IL_00f7:
			return result;
			IL_00ae:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj8 = default(object);
			obj7 = obj8;
			goto IL_0120;
		}
	}

	public IRoomThemeAddon RoomThemeAddon
	{
		get
		{
			//IL_0012: Expected O, but got I
			object obj = (nint)0 + (nint)488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304E320");
			IEnumerable<object> source = default(IEnumerable<object>);
			return (IRoomThemeAddon)Enumerable.FirstOrDefault(source);
		}
	}

	private bool IsAvailableFeature(TournamentFeature feature)
	{
		//IL_0077: Expected I4, but got O
		TournamentsCreationPopupEventsChannel tournamentsCreationPopupEventsChannel = eventsChannel;
		if ((object)eventsChannel != null && (object)features != null)
		{
			return features.IsFeatureAvailable(feature, tournamentsCreationPopupEventsChannel.<TournamentType>k__BackingField);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private long GetAddonPrice(TournamentAddonModel addon)
	{
		//IL_0016: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_012f: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_0294: Expected I8, but got O
		//IL_0277: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CE9]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CE8]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CE8]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_0286:
		NullReferenceException ex = new NullReferenceException();
		return (long)ex;
		IL_01b8:
		RemoteConfigModel current;
		if (current.<Tournaments>k__BackingField != null)
		{
			Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig> addons = current.<Tournaments>k__BackingField.Addons;
			if (addon != null)
			{
				System.Int32Enum type = (System.Int32Enum)addon.Type;
				if (addons != null)
				{
					object obj9 = ((Dictionary<System.Int32Enum, object>)(object)addons).get_Item(type);
					string serializedData = addon.SerializedData;
					if (obj9 != null)
					{
						nint num = (nint)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v140 @ X8_v8 (Il2CppClass<System.Object>)+178] (should have been resolved before IL gen)");
						long result = default(long);
						return result;
					}
				}
			}
		}
		goto IL_0286;
		IL_00af:
		current = RemoteConfig.Current;
		bool flag4 = current == null;
		object obj10 = !flag4;
		if (obj10 != null)
		{
			goto IL_01b8;
		}
		goto IL_0286;
		IL_0082:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_0183:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current = RemoteConfig.Current;
		if (current != null)
		{
			goto IL_01b8;
		}
		goto IL_0286;
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0c72: Expected O, but got I4
		//IL_0033: Expected O, but got I4
		//IL_0059: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0169: Expected O, but got I8
		//IL_0118: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0242: Expected O, but got I4
		//IL_0258: Expected O, but got I
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_01e9: Expected O, but got I
		//IL_0212: Expected O, but got I
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_033f: Expected O, but got I8
		//IL_02ee: Expected O, but got I
		//IL_0317: Expected O, but got I
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_0418: Expected O, but got I4
		//IL_042e: Expected O, but got I
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_03bf: Expected O, but got I
		//IL_03e8: Expected O, but got I
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected O, but got Unknown
		//IL_051d: Expected O, but got I4
		//IL_0533: Expected O, but got I
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		//IL_04c4: Expected O, but got I
		//IL_04ed: Expected O, but got I
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected O, but got Unknown
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		//IL_05bd: Expected I4, but got O
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected O, but got Unknown
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected O, but got Unknown
		//IL_0751: Expected O, but got I4
		//IL_05d7: Expected O, but got I
		//IL_05e3: Expected O, but got I
		//IL_05fc: Expected O, but got I4
		//IL_0606: Expected I4, but got O
		//IL_0c90: Expected O, but got I
		//IL_0ca2: Expected I, but got O
		//IL_0cb0: Expected I, but got O
		//IL_0cd0: Expected O, but got I4
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected O, but got Unknown
		//IL_07bd: Expected O, but got I
		//IL_07f4: Expected O, but got I4
		//IL_0819: Expected I, but got O
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected O, but got Unknown
		//IL_0613: Expected I, but got O
		//IL_0635: Expected I, but got O
		//IL_0645: Expected O, but got I
		//IL_0669: Expected O, but got I4
		//IL_0855: Expected O, but got I
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		//IL_06a8: Expected O, but got I
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Expected O, but got Unknown
		//IL_08a2: Expected O, but got I
		//IL_08b4: Expected I, but got O
		//IL_08c2: Expected I, but got O
		//IL_08e7: Expected O, but got I4
		//IL_0906: Expected O, but got I
		//IL_0915: Unknown result type (might be due to invalid IL or missing references)
		//IL_091a: Expected O, but got Unknown
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Expected O, but got Unknown
		//IL_093a: Expected O, but got I
		//IL_094f: Expected O, but got I
		//IL_0983: Expected I, but got O
		//IL_09b2: Expected O, but got I4
		//IL_09ef: Expected I, but got O
		//IL_09fd: Expected I, but got O
		//IL_0a17: Expected O, but got I4
		//IL_0a36: Expected O, but got I
		//IL_0a5c: Expected I, but got O
		//IL_0a6a: Expected I, but got O
		//IL_0a84: Expected O, but got I4
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aab: Expected O, but got Unknown
		//IL_0ab7: Expected O, but got I
		//IL_0add: Expected I, but got O
		//IL_0aeb: Expected I, but got O
		//IL_0b05: Expected O, but got I4
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected O, but got Unknown
		//IL_0b38: Expected O, but got I
		//IL_0b5e: Expected I, but got O
		//IL_0b6c: Expected I, but got O
		//IL_0b86: Expected O, but got I4
		//IL_0ba5: Expected O, but got I
		//IL_0bcb: Expected I, but got O
		//IL_0bd9: Expected I, but got O
		//IL_0bf3: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = default(object);
		bool flag = obj2 == null;
		object obj3 = 6;
		if (flag)
		{
			goto IL_0c16;
		}
		bool flag2 = (object)titleSelector == null;
		obj3 = 6;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj5;
		if (!flag2)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v35+40]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag3 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v35+40]");
			obj5 = 0;
			if (flag3)
			{
				goto IL_0c3a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			object obj6 = obj2 + 32;
			obj6 = titleSelector;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag4 = (object)cardbackSelector == null;
			obj3 = titleSelector;
			if (!flag4)
			{
				object obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v34+40]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag5 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v34+40]");
				obj5 = 0;
				if (flag5)
				{
					goto IL_0c3a;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+18]");
			object obj8 = 0 & 0xFFFFFFFEL;
			if (obj8 != null)
			{
				object obj9 = obj2 + 40;
				obj9 = cardbackSelector;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag6 = (object)championshipSelector == null;
				obj3 = cardbackSelector;
				if (!flag6)
				{
					object obj10 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v33+40]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag7 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v33+40]");
					obj5 = 0;
					if (flag7)
					{
						goto IL_0c3a;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+18]");
				bool flag8 = (nint)0 < (nint)2;
				object obj11 = !flag8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+18]");
				object obj12 = -2;
				bool flag9 = obj12 == null;
				object obj13 = ~obj11;
				object obj14 = obj13 | flag9;
				if (obj14 == null)
				{
					object obj15 = obj2 + 48;
					obj15 = championshipSelector;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag10 = (object)roomThemeSelector == null;
					obj3 = championshipSelector;
					if (!flag10)
					{
						object obj16 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v32+40]");
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag11 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v32+40]");
						obj5 = 0;
						if (flag11)
						{
							goto IL_0c3a;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+18]");
					object obj17 = 0 & 0xFFFFFFFCL;
					if (obj17 != null)
					{
						object obj18 = obj2 + 56;
						obj18 = roomThemeSelector;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						bool flag12 = (object)sportTeamSelector == null;
						obj3 = roomThemeSelector;
						if (!flag12)
						{
							object obj19 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v31+40]");
							obj3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag13 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v31+40]");
							obj5 = 0;
							if (flag13)
							{
								goto IL_0c3a;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+18]");
						bool flag14 = (nint)0 < (nint)4;
						object obj20 = !flag14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+18]");
						object obj21 = -4;
						bool flag15 = obj21 == null;
						object obj22 = ~obj20;
						object obj23 = obj22 | flag15;
						if (obj23 == null)
						{
							object obj24 = obj2 + 64;
							obj24 = sportTeamSelector;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							bool flag16 = (object)messageSelector == null;
							obj3 = sportTeamSelector;
							if (!flag16)
							{
								object obj25 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v30+40]");
								obj3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag17 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v30+40]");
								obj5 = 0;
								if (flag17)
								{
									goto IL_0c3a;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+18]");
							bool flag18 = (nint)0 < (nint)5;
							object obj26 = !flag18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+18]");
							object obj27 = -5;
							bool flag19 = obj27 == null;
							object obj28 = ~obj26;
							object obj29 = obj28 | flag19;
							if (obj29 == null)
							{
								object obj30 = typeof(SqlSingle[]) + 2376;
								object obj31 = obj2 + 72;
								obj31 = messageSelector;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X23_v5-30]");
								bool flag20 = (nint)0 < (nint)1;
								System.Int32Enum int32Enum = (System.Int32Enum)messageSelector;
								if (flag20)
								{
									goto IL_0704;
								}
								object obj32 = (nint)0 + (nint)2672;
								object obj33 = (nint)0 + (nint)2336;
								object obj35 = default(object);
								object obj34 = obj35;
								nint num2 = default(nint);
								nint num = num2;
								object obj36 = 0;
								System.Int32Enum int32Enum2 = (System.Int32Enum)messageSelector;
								Action action = default(Action);
								System.Int32Enum int32Enum3 = default(System.Int32Enum);
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X21_v7+v104 @ X25_v9*8]");
									object obj37 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									num2 = (nint)obj32;
									action..ctor(this, (IntPtr)obj32);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X21_v7+v104 @ X25_v9*8]");
									bool flag21 = (nint)0 == 0;
									obj35 = 0;
									obj3 = this;
									if (flag21)
									{
										break;
									}
									nint num3 = (nint)obj37;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v27 (Il2CppClass<System.Object>)+1B0]");
									num2 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v562 @ X8_v27 (Il2CppClass<System.Object>)+1A8] (should have been resolved before IL gen)");
									nint num4 = (nint)obj37;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v28 (Il2CppClass<System.Object>)+1A0]");
									obj3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v208 @ X8_v28 (Il2CppClass<System.Object>)+198] (should have been resolved before IL gen)");
									bool flag22 = AllSelectors == null;
									obj35 = 0;
									if (flag22)
									{
										break;
									}
									obj36++;
									obj35 = obj33;
									Dictionary<TournamentAddonType, TournamentAddonSelector> allSelectors = AllSelectors;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X21_v7+v104 @ X25_v9*8]");
									((Dictionary<System.Int32Enum, object>)(object)allSelectors).Add(int32Enum3, (object)0);
									object obj38 = obj36;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+18]");
									bool flag23 = (nint)obj38 < 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X21_v7+v104 @ X25_v9*8]");
									num2 = 0;
									int32Enum = int32Enum3;
									obj34 = obj33;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X21_v7+v104 @ X25_v9*8]");
									num = 0;
									int32Enum2 = int32Enum3;
									if (flag23)
									{
										continue;
									}
									goto IL_0704;
								}
								goto IL_0c16;
							}
						}
					}
				}
			}
		}
		goto IL_0c24;
		IL_0c3a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0704:
		object obj39 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object caller = "AvailableVoices" + 136;
		object obj40 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v34+E4]");
		bool flag24 = (nint)0 == 0;
		object obj41 = !flag24;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GameObject secondaryCanvas = KUtil.GetSecondaryCanvas((string)caller);
		bool flag25 = (object)secondaryCanvas == null;
		obj3 = null;
		if (!flag25)
		{
			object obj42 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj43 = (nint)0 + (nint)816;
			Transform transform = secondaryCanvas.transform;
			object obj44 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v39+E4]");
			bool flag26 = (nint)0 == 0;
			object obj45 = !flag26;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			nint num2 = (nint)obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			object obj46 = this + 216;
			object obj47 = default(object);
			obj46 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X20_v8-28]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X20_v8-28]");
			bool flag27 = (nint)0 == 0;
			obj3 = obj47;
			if (!flag27)
			{
				object obj49 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
				object obj50 = (nint)0 + (nint)2640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				num2 = (nint)obj50;
				UnityAction unityAction = default(UnityAction);
				unityAction..ctor(this, (IntPtr)obj50);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v24+100]");
				bool flag28 = (nint)0 == 0;
				object obj35 = 0;
				obj3 = this;
				if (!flag28)
				{
					object obj51 = (nint)0 + (nint)2632;
					object obj52 = typeof(RegisteredWaitHandle) + 56;
					object obj53 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3776;
					object obj54 = (nint)0 + (nint)2648;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v24+100]");
					((UnityEvent)0).AddListener(unityAction);
					PopulateAvailableAddons();
					PopulateSelectedAddons();
					PopulateSelectors();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Action action2 = default(Action);
					action2..ctor(this, (IntPtr)obj51);
					object obj55 = obj52;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X0_v53+E4]");
					bool flag29 = (nint)0 == 0;
					object obj56 = !flag29;
					if (obj56 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					RemoteConfig.OnChanged += action2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					num2 = (nint)obj54;
					Action<object> action3 = default(Action<object>);
					action3..ctor((object)this, (IntPtr)obj54);
					bool flag30 = (object)eventsChannel == null;
					obj35 = 0;
					obj3 = this;
					if (!flag30)
					{
						object obj57 = (nint)0 + (nint)2656;
						eventsChannel.OnOpenAddFeature += action3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						num2 = (nint)obj57;
						Action<object> action4 = default(Action<object>);
						action4..ctor((object)this, (IntPtr)obj57);
						bool flag31 = (object)eventsChannel == null;
						obj35 = 0;
						obj3 = this;
						if (!flag31)
						{
							object obj58 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3728;
							object obj59 = (nint)0 + (nint)2608;
							eventsChannel.OnOpenEditFeature += action4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							num2 = (nint)obj59;
							Action<object> action5 = default(Action<object>);
							action5..ctor((object)this, (IntPtr)obj59);
							bool flag32 = (object)eventsChannel == null;
							obj35 = 0;
							obj3 = this;
							if (!flag32)
							{
								object obj60 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3744;
								object obj61 = (nint)0 + (nint)2664;
								eventsChannel.OnAddAddon += action5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								num2 = (nint)obj61;
								Action<System.Int32Enum> action6 = default(Action<System.Int32Enum>);
								action6..ctor((object)this, (IntPtr)obj61);
								bool flag33 = (object)eventsChannel == null;
								obj35 = 0;
								obj3 = this;
								if (!flag33)
								{
									object obj62 = (nint)0 + (nint)2616;
									eventsChannel.OnRemoveAddon += (Action<TournamentAddonType>)(object)action6;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									num2 = (nint)obj62;
									Action<System.Int32Enum> action7 = default(Action<System.Int32Enum>);
									action7..ctor((object)this, (IntPtr)obj62);
									bool flag34 = (object)eventsChannel == null;
									obj35 = 0;
									obj3 = this;
									if (!flag34)
									{
										eventsChannel.OnEditAddon += (Action<TournamentAddonType>)(object)action7;
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0c16;
		IL_0c16:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0c24;
		IL_0c24:
		ex = new IndexOutOfRangeException();
		obj5 = obj3;
		goto IL_0c3a;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01bf: Expected O, but got I
		//IL_01d7: Expected I, but got O
		//IL_0201: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_007f: Expected O, but got I
		//IL_00ab: Expected I, but got O
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I
		//IL_00fc: Expected I, but got O
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0121: Expected O, but got I
		//IL_014d: Expected I, but got O
		//IL_015e: Expected O, but got I
		//IL_018a: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2632;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3776;
		object obj5 = (nint)0 + (nint)2648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		object obj8 = (nint)0 + (nint)2656;
		eventsChannel.OnOpenAddFeature -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj8);
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3728;
		object obj10 = (nint)0 + (nint)2608;
		eventsChannel.OnOpenEditFeature -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj10);
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3744;
		object obj12 = (nint)0 + (nint)2664;
		eventsChannel.OnAddAddon -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action5 = default(Action<System.Int32Enum>);
		action5..ctor((object)this, (IntPtr)obj12);
		object obj13 = (nint)0 + (nint)2616;
		eventsChannel.OnRemoveAddon -= (Action<TournamentAddonType>)(object)action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action6 = default(Action<System.Int32Enum>);
		action6..ctor((object)this, (IntPtr)obj13);
		eventsChannel.OnEditAddon -= (Action<TournamentAddonType>)(object)action6;
	}

	private void PopulateSelectors()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0037: Expected O, but got I
		//IL_0070: Expected O, but got I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_010d: Expected O, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_014d: Expected I, but got O
		//IL_0177: Expected O, but got I4
		TournamentAddonConfig.TitleRestrictionConfig titleConfig = TitleConfig;
		List<GameAchievementViewModel> allowedTitles = titleConfig.GetAllowedTitles();
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		titleSelector.Populate(allowedTitles);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		List<StoreOwnedItem> ownedCards = SFSKammelnaUserExtensions.GetOwnedCards(localUser);
		cardbackSelector.Populate(ownedCards);
		championshipSelector.Populate();
		IEnumerable<StoreItem> availableItems = StoreUtil.GetAvailableItems(ItemCategory.Rooms);
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 872;
		object obj6 = (nint)0 + (nint)2592;
		object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1176;
		roomThemeSelector.Populate(availableItems);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj6);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v20+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SportTeamsUtil.GetSportTeams(action);
	}

	private unsafe void PopulateAvailableAddons()
	{
		//IL_0b18: Expected O, but got I4
		//IL_002f: Expected O, but got I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0059: Expected I, but got O
		//IL_0069: Expected O, but got I
		//IL_0150: Expected I, but got O
		//IL_0bc2: Expected O, but got Ref
		//IL_0b53: Expected O, but got I4
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Expected O, but got Unknown
		//IL_0a6f: Expected O, but got I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01df: Expected O, but got I
		//IL_01eb: Expected O, but got I
		//IL_0162: Expected O, but got I4
		//IL_0174: Expected O, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_02dc: Expected O, but got I
		//IL_00d5: Expected O, but got I
		//IL_00ef: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_03c3: Expected I, but got O
		//IL_0c5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c60: Expected O, but got Unknown
		//IL_087c: Expected O, but got I4
		//IL_089d: Expected O, but got I4
		//IL_0bf2: Expected O, but got I4
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Expected O, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		//IL_03d5: Expected O, but got I4
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_0d26: Expected O, but got I4
		//IL_0348: Expected O, but got I
		//IL_0362: Expected O, but got I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected O, but got Unknown
		//IL_08ce: Expected O, but got I
		//IL_0a11: Expected I, but got O
		//IL_0969: Expected I, but got O
		//IL_046b: Expected O, but got I
		//IL_0552: Expected I, but got O
		//IL_097b: Expected O, but got I4
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_098d: Expected O, but got Unknown
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_099b: Expected O, but got Unknown
		//IL_0c9f: Expected O, but got I4
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Expected O, but got Unknown
		//IL_0932: Expected O, but got I
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected O, but got Unknown
		//IL_05af: Expected O, but got I
		//IL_0564: Expected O, but got I4
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected O, but got Unknown
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected O, but got Unknown
		//IL_05e3: Expected I, but got O
		//IL_05eb: Expected I, but got O
		//IL_04d7: Expected O, but got I
		//IL_04f1: Expected O, but got I4
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected O, but got Unknown
		//IL_0285: Expected O, but got I4
		//IL_0296: Expected O, but got I4
		//IL_02b6: Expected I, but got O
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected O, but got Unknown
		//IL_0670: Expected O, but got I4
		//IL_0699: Expected O, but got I
		//IL_06a1: Expected I, but got O
		//IL_0a47: Expected O, but got I4
		//IL_0a57: Expected I, but got O
		//IL_06d0: Expected I, but got O
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected O, but got Unknown
		//IL_0a28: Expected O, but got I4
		//IL_0733: Expected O, but got I
		//IL_07b8: Expected O, but got I4
		//IL_07cc: Expected O, but got I4
		//IL_0229: Expected O, but got I
		//IL_0239: Expected O, but got I
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Expected O, but got Unknown
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Expected O, but got Unknown
		//IL_0855: Expected I, but got O
		//IL_0865: Expected O, but got I4
		TournamentFeaturesList tournamentFeaturesList = features;
		bool flag = (object)features == null;
		object obj = 0;
		bool flag4 = default(bool);
		int num3 = default(int);
		if (!flag)
		{
			List<TournamentFeature> allTournamentFeatures = tournamentFeaturesList.allTournamentFeatures;
			bool flag2 = tournamentFeaturesList.allTournamentFeatures == null;
			obj = 0;
			if (!flag2)
			{
				object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3792;
				nint num = (nint)allTournamentFeatures;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v16 (Il2CppClass<System.Collections.Generic.List`1<TournamentFeature>>)+12E]");
				object[] array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v16 (Il2CppClass<System.Collections.Generic.List`1<TournamentFeature>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0141;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v16 (Il2CppClass<System.Collections.Generic.List`1<TournamentFeature>>)+B0]");
				int num2 = (int)((nint)0 + (nint)8);
				bool flag3 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v32 (System.Int32)-8]");
					bool flag5 = 0 < (nint)obj2;
					object obj3 = !flag5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v32 (System.Int32)-8]");
					object obj4 = 0 - obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v32 (System.Int32)-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					num3 = num2 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v16 (Il2CppClass<System.Collections.Generic.List`1<TournamentFeature>>)+12E]");
					array = (object[])(-1);
					bool flag6 = (nint)array < 1;
					obj3 = !flag6;
					obj4 = array - 1;
					bool flag7 = obj4 == null;
					flag4 = (nint)array != 1;
					flag3 = flag4;
					num2 = num3;
					if (flag4)
					{
						continue;
					}
					goto IL_0141;
				}
				array = (object[])((int*)num2)->m_value;
				object obj5 = num + ((int*)num2)->m_value;
				object obj6 = obj5 + 312;
				flag4 = flag3;
				num3 = num2;
				goto IL_0b91;
			}
		}
		goto IL_0b26;
		IL_09eb:
		NullReferenceException ex = new NullReferenceException();
		object obj8;
		object obj7 = obj8;
		nint num5;
		nint num4 = num5;
		int num6;
		num3 = num6;
		nint num7 = unchecked((nint)null);
		goto IL_0a5c;
		IL_0a35:
		NullReferenceException ex2 = new NullReferenceException();
		obj7 = 0;
		num3 = num6;
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		num7 = (nint)enumerable;
		goto IL_0a5c;
		IL_0b26:
		throw new NullReferenceException();
		IL_09bd:
		NullReferenceException ex3 = new NullReferenceException();
		obj7 = obj8;
		num4 = num5;
		num3 = num6;
		IntPtr intPtr = default(IntPtr);
		num7 = intPtr;
		goto IL_0a5c;
		IL_0a5c:
		object obj9 = default(object);
		obj = obj9;
		object obj10 = 0;
		goto IL_0b26;
		IL_09af:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0a5c;
		IL_0141:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = unchecked((nint)null);
		goto IL_0b91;
		IL_0b91:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v23+8]");
		num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v295 @ X0_v23] (should have been resolved before IL gen)");
		bool flag8 = obj9 == null;
		tournamentFeaturesList = (TournamentFeaturesList)(&obj);
		if (!flag8)
		{
			object obj11 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			object obj12 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1248;
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3904;
			object obj14 = (nint)0 + (nint)3792;
			object obj15 = (nint)0 + (nint)1984;
			obj8 = obj7;
			IEnumerable<object> enumerable2 = enumerable;
			num5 = num4;
			num6 = num3;
			object obj16 = obj9;
			object obj19 = default(object);
			object obj20 = default(object);
			object obj21 = default(object);
			Func<object, bool> func = default(Func<object, bool>);
			TournamentFeatureAvailableItem tournamentFeatureAvailableItem = default(TournamentFeatureAvailableItem);
			object obj33 = default(object);
			while (true)
			{
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v23+12E]");
				object[] array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v23+12E]");
				if ((nint)0 == 0)
				{
					goto IL_03b4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v23+B0]");
				int num8 = (int)((nint)0 + (nint)8);
				bool flag9 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X10_v27 (System.Int32)-8]");
					bool flag10 = 0 < (nint)obj11;
					object obj3 = !flag10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X10_v27 (System.Int32)-8]");
					object obj4 = 0 - obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X10_v27 (System.Int32)-8]");
					if (0 == (nint)obj11)
					{
						break;
					}
					num6 = num8 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v23+12E]");
					array = (object[])(-1);
					bool flag11 = (nint)array < 1;
					obj3 = !flag11;
					obj4 = array - 1;
					bool flag7 = obj4 == null;
					flag4 = (nint)array != 1;
					flag9 = flag4;
					num8 = num6;
					if (flag4)
					{
						continue;
					}
					goto IL_03b4;
				}
				array = (object[])((int*)num8)->m_value;
				object obj18 = obj17 + ((int*)num8)->m_value;
				obj19 = obj18 + 312;
				flag4 = flag9;
				num6 = num8;
				goto IL_0c30;
				IL_0cdd:
				tournamentFeaturesList = (TournamentFeaturesList)obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v731 @ X0_v36] (should have been resolved before IL gen)");
				if (obj21 == null)
				{
					goto IL_09bd;
				}
				object obj22 = obj21 + 16;
				obj22 = (nint)intPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				enumerable2 = availableFeatureItems;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				func..ctor(obj21, (IntPtr)obj14);
				num5 = (nint)obj15;
				bool flag12 = Enumerable.All(availableFeatureItems, func);
				bool flag13 = !flag12;
				object obj23 = func;
				if (flag13)
				{
					goto IL_026d;
				}
				enumerable = (IEnumerable<object>)availableFeaturesParent;
				object obj24 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X0_v46+E4]");
				bool flag14 = (nint)0 == 0;
				object obj26 = !flag14;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				tournamentFeaturesList = (TournamentFeaturesList)((nint)0 + (nint)808);
				num4 = (nint)tournamentFeaturesList;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
				if ((object)tournamentFeatureAvailableItem != null)
				{
					num7 = (nint)obj22;
					object obj27 = tournamentFeatureAvailableItem + 32;
					obj27 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					tournamentFeatureAvailableItem.Refresh();
					List<object> list = (List<object>)(object)availableFeatureItems;
					if (availableFeatureItems != null)
					{
						object obj28 = (nint)0 + (nint)1376;
						tournamentFeaturesList = (TournamentFeaturesList)obj28;
						int version = list._version + 1;
						list._version = version;
						array = list._items;
						if (list._items != null)
						{
							num6 = list._size;
							bool flag15 = list._size < array.Length;
							object obj3 = !flag15;
							object obj4 = list._size - array.Length;
							bool flag7 = obj4 == null;
							if (obj3 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v36 (TournamentFeaturesList)+20]");
								object obj29 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v41+C0]");
								tournamentFeaturesList = (TournamentFeaturesList)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v36 (TournamentFeaturesList)+70]");
								num5 = 0;
								((List<object>)(object)availableFeatureItems).AddWithResize((object)tournamentFeatureAvailableItem);
								enumerable2 = enumerable;
								obj23 = tournamentFeatureAvailableItem;
							}
							else
							{
								int num9 = ++list._size;
								object obj30 = list._items + list._size;
								object obj31 = obj30 + 32;
								obj31 = tournamentFeatureAvailableItem;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								enumerable2 = enumerable;
								num5 = (nint)tournamentFeaturesList;
								obj23 = tournamentFeatureAvailableItem;
								tournamentFeaturesList = (TournamentFeaturesList)num9;
							}
							goto IL_026d;
						}
					}
					goto IL_0a16;
				}
				goto IL_0a35;
				IL_026d:
				bool flag16 = obj9 == null;
				obj8 = 0;
				obj16 = obj9;
				obj7 = 0;
				enumerable = enumerable2;
				num4 = num5;
				num3 = num6;
				num7 = (nint)obj23;
				if (!flag16)
				{
					continue;
				}
				goto IL_09af;
				IL_0543:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num5 = unchecked((nint)null);
				goto IL_0cdd;
				IL_03b4:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num5 = unchecked((nint)null);
				goto IL_0c30;
				IL_0c30:
				tournamentFeaturesList = (TournamentFeaturesList)obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v30+8]");
				num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v609 @ X0_v30] (should have been resolved before IL gen)");
				object obj32 = obj33 & 1;
				if (obj32 == null)
				{
					break;
				}
				tournamentFeaturesList = (TournamentFeaturesList)(typeof(DebugUI.BitField) + 2320);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj21..ctor();
				if (obj9 == null)
				{
					goto IL_09eb;
				}
				object obj34 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v28+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v28+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0543;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v28+B0]");
				int num10 = (int)((nint)0 + (nint)8);
				bool flag17 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X10_v22 (System.Int32)-8]");
					bool flag18 = 0 < (nint)obj12;
					object obj3 = !flag18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X10_v22 (System.Int32)-8]");
					object obj4 = 0 - obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X10_v22 (System.Int32)-8]");
					if (0 == (nint)obj12)
					{
						break;
					}
					num6 = num10 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v28+12E]");
					array = (object[])(-1);
					bool flag19 = (nint)array < 1;
					obj3 = !flag19;
					obj4 = array - 1;
					bool flag7 = obj4 == null;
					flag4 = (nint)array != 1;
					flag17 = flag4;
					num10 = num6;
					if (flag4)
					{
						continue;
					}
					goto IL_0543;
				}
				array = (object[])((int*)num10)->m_value;
				object obj35 = obj34 + ((int*)num10)->m_value;
				obj20 = obj35 + 312;
				flag4 = flag17;
				num6 = num10;
				goto IL_0cdd;
			}
			obj = obj9;
			obj10 = 0;
			obj7 = obj8;
			num4 = num5;
			num3 = num6;
			object obj36 = 0;
			object obj42 = default(object);
			while (true)
			{
				if (obj == null)
				{
					goto IL_0d0c;
				}
				object obj37 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj38 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v8+12E]");
				object[] array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v8+12E]");
				if ((nint)0 == 0)
				{
					goto IL_095a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v8+B0]");
				int num11 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X10_v7 (System.Int32)-8]");
					if (0 == (nint)obj37)
					{
						break;
					}
					num3 = num11 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v8+12E]");
					array = (object[])(-1);
					bool flag20 = (nint)array != 1;
					num11 = num3;
					if (flag20)
					{
						continue;
					}
					goto IL_095a;
				}
				array = (object[])((int*)num11)->m_value;
				object obj39 = obj38 + ((int*)num11)->m_value;
				object obj40 = obj39 + 312;
				num3 = num11;
				goto IL_0d58;
				IL_0d0c:
				bool flag21 = obj36 == null;
				object obj41 = !flag21;
				if (obj41 == null)
				{
					RefreshAvailableAddons();
					return;
				}
				OutOfMemoryException ex5 = new OutOfMemoryException();
				if (num7 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj36 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj10 = obj42;
				continue;
				IL_095a:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num4 = unchecked((nint)null);
				goto IL_0d58;
				IL_0d58:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v5+8]");
				num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v670 @ X0_v5] (should have been resolved before IL gen)");
				goto IL_0d0c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		goto IL_09af;
		IL_0a16:
		NullReferenceException ex6 = new NullReferenceException();
		obj7 = 0;
		num3 = num6;
		goto IL_0a5c;
	}

	private void RefreshAvailableAddons()
	{
		//IL_0360: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_002a: Expected O, but got I
		//IL_0054: Expected I, but got O
		//IL_02e6: Expected I, but got O
		//IL_0298: Expected O, but got I4
		//IL_012f: Expected O, but got I
		//IL_0183: Expected O, but got I
		//IL_01cf: Expected I4, but got O
		bool flag = availableFeatureItems == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		object obj3 = default(object);
		nint num = default(nint);
		if (!flag)
		{
			object obj = (nint)0 + (nint)2544;
			object obj2 = (nint)0 + (nint)2296;
			obj3 = (nint)0 + (nint)2536;
			List<object>.Enumerator enumerator2 = ((List<object>)(object)availableFeatureItems).GetEnumerator();
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			Component component = default(Component);
			while (true)
			{
				num = (nint)obj;
				if (enumerator3.MoveNext())
				{
					if ((object)component != null)
					{
						GameObject gameObject = component.gameObject;
						TournamentsCreationPopupEventsChannel tournamentsCreationPopupEventsChannel = eventsChannel;
						bool flag2 = (object)eventsChannel == null;
						bool flag3 = false;
						if (!flag2)
						{
							bool flag4 = (object)features == null;
							flag3 = false;
							if (!flag4)
							{
								TournamentType <TournamentType>k__BackingField = tournamentsCreationPopupEventsChannel.<TournamentType>k__BackingField;
								TournamentFeaturesList tournamentFeaturesList = features;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ stack_-68 (UnityEngine.Component)+20]");
								bool flag5 = tournamentFeaturesList.IsFeatureAvailable((TournamentFeature)0, tournamentsCreationPopupEventsChannel.<TournamentType>k__BackingField);
								bool flag6 = (object)gameObject == null;
								flag3 = flag5;
								if (!flag6)
								{
									gameObject.SetActive(flag5);
									((TournamentFeatureAvailableItem)component).Refresh();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ stack_-68 (UnityEngine.Component)+20]");
									object obj4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ stack_-68 (UnityEngine.Component)+20]");
									if ((nint)0 != 0)
									{
										if (SelectedAddons != null)
										{
											<TournamentType>k__BackingField = (TournamentType)obj2;
											Dictionary<TournamentAddonType, TournamentAddonModel> selectedAddons = SelectedAddons;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v13+18]");
											if (!((Dictionary<System.Int32Enum, object>)(object)selectedAddons).ContainsKey((System.Int32Enum)0))
											{
												((TournamentFeatureAvailableItem)component).UnDim();
											}
											else
											{
												((TournamentFeatureAvailableItem)component).Dim();
											}
											continue;
										}
										NullReferenceException ex = new NullReferenceException();
										<TournamentType>k__BackingField = TournamentType.Public;
										num = (flag5 ? 1 : 0);
										break;
									}
									NullReferenceException ex2 = new NullReferenceException();
									<TournamentType>k__BackingField = TournamentType.Public;
									num = (flag5 ? 1 : 0);
									break;
								}
							}
						}
						NullReferenceException ex3 = new NullReferenceException();
						num = (flag3 ? 1 : 0);
					}
					else
					{
						NullReferenceException ex4 = new NullReferenceException();
					}
					break;
				}
				enumerator3.Dispose();
				return;
			}
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			enumerator = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
		}
		NullReferenceException ex5 = new NullReferenceException();
		bool flag7 = num != 1;
		OutOfMemoryException ex6 = (OutOfMemoryException)(object)ex5;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj3;
			enumerator.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				return;
			}
			ex6 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223913C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private unsafe void PopulateSelectedAddons()
	{
		//IL_092a: Expected O, but got I4
		//IL_002f: Expected O, but got I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0059: Expected I, but got O
		//IL_0069: Expected O, but got I
		//IL_0108: Expected O, but got I4
		//IL_0881: Expected O, but got I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_018f: Expected O, but got I
		//IL_019b: Expected O, but got I
		//IL_011a: Expected O, but got I4
		//IL_012c: Expected O, but got I
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0262: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_0301: Expected O, but got I4
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fc: Expected O, but got Unknown
		//IL_06ce: Expected O, but got I4
		//IL_06e7: Expected O, but got I4
		//IL_0313: Expected O, but got I4
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0adb: Expected O, but got I4
		//IL_02c6: Expected O, but got I
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected O, but got Unknown
		//IL_0718: Expected O, but got I
		//IL_0375: Expected O, but got I
		//IL_07b7: Expected O, but got I4
		//IL_0414: Expected O, but got I4
		//IL_0a6a: Expected O, but got I
		//IL_0a8c: Expected O, but got I4
		//IL_048b: Expected I, but got O
		//IL_07c9: Expected O, but got I4
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected O, but got Unknown
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected O, but got Unknown
		//IL_0426: Expected O, but got I4
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_077c: Expected O, but got I
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected O, but got Unknown
		//IL_04af: Expected O, but got I
		//IL_03d9: Expected O, but got I
		//IL_0503: Expected O, but got I
		//IL_0503: Expected O, but got I
		//IL_0513: Expected O, but got I
		//IL_0535: Expected O, but got I4
		//IL_0aa3: Expected O, but got I4
		//IL_0593: Expected O, but got I
		//IL_0593: Expected O, but got I
		//IL_0825: Expected O, but got I4
		//IL_0641: Expected O, but got I4
		//IL_01d1: Expected O, but got I
		//IL_01f1: Expected O, but got I
		//IL_023c: Expected I, but got O
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_06af: Expected O, but got I4
		TournamentFeaturesList tournamentFeaturesList = features;
		bool flag = (object)features == null;
		object obj = 0;
		int num3 = default(int);
		if (!flag)
		{
			List<TournamentFeature> allTournamentFeatures = tournamentFeaturesList.allTournamentFeatures;
			bool flag2 = tournamentFeaturesList.allTournamentFeatures == null;
			obj = 0;
			if (!flag2)
			{
				object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3792;
				nint num = (nint)allTournamentFeatures;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v16 (Il2CppClass<System.Collections.Generic.List`1<TournamentFeature>>)+12E]");
				object[] array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v16 (Il2CppClass<System.Collections.Generic.List`1<TournamentFeature>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00f5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v16 (Il2CppClass<System.Collections.Generic.List`1<TournamentFeature>>)+B0]");
				int num2 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X10_v31 (System.Int32)-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					num3 = num2 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v16 (Il2CppClass<System.Collections.Generic.List`1<TournamentFeature>>)+12E]");
					array = (object[])(-1);
					bool flag3 = (nint)array != 1;
					num2 = num3;
					if (flag3)
					{
						continue;
					}
					goto IL_00f5;
				}
				array = (object[])((int*)num2)->m_value;
				object obj3 = num + ((int*)num2)->m_value;
				object obj4 = obj3 + 312;
				num3 = num2;
				goto IL_0968;
			}
		}
		goto IL_0938;
		IL_0850:
		NullReferenceException ex = new NullReferenceException();
		object obj6;
		object obj5 = obj6;
		int num4;
		num3 = num4;
		goto IL_086e;
		IL_0813:
		NullReferenceException ex2 = new NullReferenceException();
		obj5 = 0;
		num3 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v33 (TournamentFeaturesList)+40]");
		nint num5 = 0;
		goto IL_086e;
		IL_0938:
		throw new NullReferenceException();
		IL_07fd:
		NullReferenceException ex3 = new NullReferenceException();
		num3 = num4;
		goto IL_086e;
		IL_0842:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_086e;
		IL_086e:
		object obj7 = default(object);
		obj = obj7;
		object obj8 = 0;
		goto IL_0938;
		IL_00f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj5 = 0;
		goto IL_0968;
		IL_0968:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v23+8]");
		num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v292 @ X0_v23] (should have been resolved before IL gen)");
		bool flag4 = obj7 == null;
		int num6 = (int)(&obj);
		if (!flag4)
		{
			object obj9 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			object obj10 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1248;
			object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj12 = (nint)0 + (nint)824;
			object obj13 = (nint)0 + (nint)1400;
			object obj15 = default(object);
			object obj14 = obj15;
			obj6 = obj5;
			num4 = num3;
			object obj16 = obj7;
			object obj19 = default(object);
			object obj21 = default(object);
			object obj27 = default(object);
			IntPtr intPtr = default(IntPtr);
			while (true)
			{
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v23+12E]");
				object[] array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v23+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02ee;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v23+B0]");
				int num7 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X10_v26 (System.Int32)-8]");
					if (0 == (nint)obj9)
					{
						break;
					}
					num4 = num7 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v23+12E]");
					array = (object[])(-1);
					bool flag5 = (nint)array != 1;
					num7 = num4;
					if (flag5)
					{
						continue;
					}
					goto IL_02ee;
				}
				array = (object[])((int*)num7)->m_value;
				object obj18 = obj17 + ((int*)num7)->m_value;
				obj19 = obj18 + 312;
				num4 = num7;
				goto IL_09cc;
				IL_09cc:
				tournamentFeaturesList = (TournamentFeaturesList)obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X0_v30+8]");
				num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v594 @ X0_v30] (should have been resolved before IL gen)");
				object obj20 = obj21 & 1;
				if (obj20 == null)
				{
					break;
				}
				if (obj7 == null)
				{
					goto IL_0850;
				}
				object obj22 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v26+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v26+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0401;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v26+B0]");
				int num8 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X10_v21 (System.Int32)-8]");
					if (0 == (nint)obj10)
					{
						break;
					}
					num4 = num8 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v26+12E]");
					array = (object[])(-1);
					bool flag6 = (nint)array != 1;
					num8 = num4;
					if (flag6)
					{
						continue;
					}
					goto IL_0401;
				}
				array = (object[])((int*)num8)->m_value;
				object obj23 = obj22 + ((int*)num8)->m_value;
				object obj24 = obj23 + 312;
				num4 = num8;
				goto IL_0a3e;
				IL_0a3e:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v723 @ X0_v34] (should have been resolved before IL gen)");
				Transform transform = selectedFeaturesParent;
				object obj25 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X0_v37+E4]");
				tournamentFeaturesList = (TournamentFeaturesList)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X0_v37+E4]");
				bool flag7 = (nint)0 == 0;
				object obj26 = !flag7;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				obj5 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
				bool flag8 = obj27 == null;
				num5 = (nint)transform;
				if (!flag8)
				{
					transform = (Transform)(obj27 + 72);
					transform = (Transform)(nint)intPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					tournamentFeaturesList = (TournamentFeaturesList)(object)transform;
					bool flag9 = (object)transform == null;
					num5 = intPtr;
					if (!flag9)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X0_v40 (System.Object)+20]");
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v33 (TournamentFeaturesList)+28]");
						TextMeshProExtensions.Localize((TextMeshProUGUI)num9, (string)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X0_v40 (System.Object)+48]");
						tournamentFeaturesList = (TournamentFeaturesList)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X0_v40 (System.Object)+48]");
						bool flag10 = (nint)0 == 0;
						object obj28 = !flag10;
						obj14 = ~obj28;
						bool flag11;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X0_v40 (System.Object)+28]");
							flag11 = (nint)0 == 0;
						}
						else
						{
							flag11 = true;
						}
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v33 (TournamentFeaturesList)+28]");
						num5 = 0;
						if (!flag11)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X0_v40 (System.Object)+28]");
							nint num10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v33 (TournamentFeaturesList)+40]");
							((Image)num10).sprite = (Sprite)0;
							List<object> list = (List<object>)(object)selectedFeatureItems;
							if (selectedFeatureItems != null)
							{
								tournamentFeaturesList = (TournamentFeaturesList)obj13;
								int version = list._version + 1;
								list._version = version;
								array = list._items;
								if (list._items != null)
								{
									num4 = list._size;
									bool flag12 = list._size < array.Length;
									object obj29 = !flag12;
									object obj31;
									if (obj29 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v33 (TournamentFeaturesList)+20]");
										object obj30 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v37+C0]");
										num6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v21 (System.Int32)+70]");
										obj6 = 0;
										((List<object>)(object)selectedFeatureItems).AddWithResize(obj27);
										obj31 = obj27;
									}
									else
									{
										num6 = list._size + 1;
										list._size = num6;
										object obj32 = list._items + list._size;
										object obj33 = obj32 + 32;
										obj33 = obj27;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										obj6 = 0;
										obj31 = obj27;
									}
									bool flag13 = obj7 == null;
									obj16 = obj7;
									obj5 = obj6;
									num3 = num4;
									num5 = (nint)obj31;
									if (!flag13)
									{
										continue;
									}
									goto IL_0842;
								}
							}
							goto IL_0813;
						}
					}
				}
				goto IL_07fd;
				IL_0401:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj6 = 0;
				goto IL_0a3e;
				IL_02ee:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj6 = 0;
				goto IL_09cc;
			}
			obj = obj7;
			obj8 = 0;
			obj5 = obj6;
			num3 = num4;
			object obj34 = 0;
			object obj40 = default(object);
			while (true)
			{
				if (obj == null)
				{
					goto IL_0ac1;
				}
				object obj35 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj36 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v8+12E]");
				object[] array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v8+12E]");
				if ((nint)0 == 0)
				{
					goto IL_07a4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v8+B0]");
				int num11 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X10_v7 (System.Int32)-8]");
					if (0 == (nint)obj35)
					{
						break;
					}
					num3 = num11 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v8+12E]");
					array = (object[])(-1);
					bool flag14 = (nint)array != 1;
					num11 = num3;
					if (flag14)
					{
						continue;
					}
					goto IL_07a4;
				}
				array = (object[])((int*)num11)->m_value;
				object obj37 = obj36 + ((int*)num11)->m_value;
				object obj38 = obj37 + 312;
				num3 = num11;
				goto IL_0b0d;
				IL_0ac1:
				bool flag15 = obj34 == null;
				object obj39 = !flag15;
				if (obj39 == null)
				{
					RefreshSelectedAddons();
					return;
				}
				OutOfMemoryException ex5 = new OutOfMemoryException();
				if (num5 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj34 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj8 = obj40;
				continue;
				IL_07a4:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj5 = 0;
				goto IL_0b0d;
				IL_0b0d:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v5+8]");
				num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v656 @ X0_v5] (should have been resolved before IL gen)");
				goto IL_0ac1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		goto IL_0842;
	}

	private void RefreshSelectedAddons()
	{
		//IL_000c: Expected O, but got I
		//IL_0294: Expected I4, but got O
		//IL_003a: Expected O, but got I4
		//IL_005d: Expected O, but got I
		//IL_0069: Expected O, but got I
		//IL_0075: Expected O, but got I
		//IL_008d: Expected O, but got I4
		//IL_022c: Expected I4, but got O
		//IL_02d3: Expected I4, but got O
		//IL_01de: Expected O, but got I4
		//IL_00cc: Expected O, but got I
		//IL_0166: Expected O, but got I4
		object obj = (nint)0 + (nint)2504;
		bool flag = (byte)(int)obj != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C977F0");
		object obj5 = default(object);
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		if ((object)addFeaturesText != null)
		{
			bool flag2 = default(bool);
			addFeaturesText.SetActive(flag2);
			bool flag3 = selectedFeatureItems == null;
			object obj2 = 0;
			flag = flag2;
			if (!flag3)
			{
				object obj3 = (nint)0 + (nint)2568;
				object obj4 = (nint)0 + (nint)2296;
				obj5 = (nint)0 + (nint)2560;
				List<object>.Enumerator enumerator = ((List<object>)(object)selectedFeatureItems).GetEnumerator();
				obj2 = 0;
				List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
				Component component = default(Component);
				while (true)
				{
					flag = (byte)(int)obj3 != 0;
					if (enumerator2.MoveNext())
					{
						if ((object)component != null)
						{
							GameObject gameObject = component.gameObject;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ stack_-68 (UnityEngine.Component)+48]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ stack_-68 (UnityEngine.Component)+48]");
							if ((nint)0 != 0)
							{
								if (SelectedAddons != null)
								{
									obj2 = obj4;
									Dictionary<TournamentAddonType, TournamentAddonModel> selectedAddons = SelectedAddons;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v12+18]");
									bool flag4 = ((Dictionary<System.Int32Enum, object>)(object)selectedAddons).ContainsKey((System.Int32Enum)0);
									if ((object)gameObject != null)
									{
										gameObject.SetActive(flag4);
										obj2 = 0;
										continue;
									}
									NullReferenceException ex = new NullReferenceException();
									flag = flag4;
									break;
								}
								NullReferenceException ex2 = new NullReferenceException();
								flag = false;
								break;
							}
							NullReferenceException ex3 = new NullReferenceException();
							flag = false;
							break;
						}
						NullReferenceException ex4 = new NullReferenceException();
						break;
					}
					enumerator2.Dispose();
					return;
				}
				List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
				enumerator3 = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
			}
		}
		NullReferenceException ex5 = new NullReferenceException();
		bool flag5 = !flag;
		OutOfMemoryException ex6 = (OutOfMemoryException)(object)ex5;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			flag = (byte)(int)obj5 != 0;
			enumerator3.Dispose();
			object obj7 = default(object);
			if (obj7 == null)
			{
				return;
			}
			ex6 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223917C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public void ActivateAvailableFeaturesSelectors()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object text = "Added Tournament Prizes And Features" + 8;
		DisableActiveSelectors();
		TextMeshProExtensions.Localize(title, (string)text);
		object text2 = (nint)0 + (nint)2000;
		subTitle.text = (string)text2;
		availableFeaturesSelectors.SetActive(value: true);
	}

	private void ActivateSelector(TournamentAddonType addonType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0105: Expected O, but got I
		//IL_0111: Expected O, but got I
		//IL_0152: Expected I, but got O
		//IL_0171: Expected O, but got I
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01d4: Expected O, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_0212: Expected I, but got O
		//IL_023c: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 2328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = (nint)0 + (nint)2344;
		object obj4 = ((Dictionary<System.Int32Enum, object>)(object)AllSelectors).get_Item((System.Int32Enum)addonType);
		object obj5 = obj2 + 16;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		DisableActiveSelectors();
		GameObject gameObject = ((Component)obj5).gameObject;
		gameObject.SetActive(value: true);
		object obj6 = this + 208;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj5;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v125 @ X8_v6+178] (should have been resolved before IL gen)");
		string text = default(string);
		TextMeshProExtensions.Localize(title, text);
		object obj9 = obj5;
		object obj10 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3720;
		object obj11 = (nint)0 + (nint)3800;
		object obj12 = (nint)0 + (nint)576;
		object obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ X8_v7+188] (should have been resolved before IL gen)");
		string text2 = default(string);
		TextMeshProExtensions.Localize(subTitle, text2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<KeyValuePair<System.Int32Enum, object>, bool> func = default(Func<KeyValuePair<System.Int32Enum, object>, bool>);
		func..ctor(obj2, (IntPtr)obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC4A3C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+10]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v127 @ X8_v8+1F8] (should have been resolved before IL gen)");
		GameObject gameObject2 = confirmButton.gameObject;
		gameObject2.SetActive(value: true);
		object obj16 = typeof(SqlSingle[]) + 2376;
		object obj17 = (nint)0 + (nint)2600;
		object obj18 = typeof(RegisteredWaitHandle) + 3136;
		GameObject gameObject3 = ((Component)obj6).gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj17);
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v33+E4]");
		bool flag = (nint)0 == 0;
		object obj20 = !flag;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(gameObject3, action);
		SelectorOnValidStateChange();
	}

	private void OpenAddFeature(TournamentFeature feature)
	{
		if (feature.Configurable)
		{
			ActivateSelector(feature.FeatureType);
		}
		else
		{
			featureEditPopupInstance.OpenAddMode(feature);
		}
	}

	private void OpenEditFeature(TournamentFeature feature)
	{
		featureEditPopupInstance.OpenEditMode(feature);
	}

	private void OnConfirm()
	{
		TournamentAddonSelector activeSelector = ActiveSelector;
		activeSelector.OnConfirm();
		ActivateAvailableFeaturesSelectors();
	}

	private void AddAddon(TournamentAddonModel addon)
	{
		TournamentAddonType type = addon.Type;
		RemoveAddon(type);
		System.Int32Enum type2 = (System.Int32Enum)addon.Type;
		((Dictionary<System.Int32Enum, object>)(object)SelectedAddons).set_Item(type2, (object)addon);
		RefreshAvailableAddons();
		RefreshSelectedAddons();
		eventsChannel.TriggerRefreshView();
	}

	private void RemoveAddon(TournamentAddonType addonType)
	{
		bool flag = ((Dictionary<System.Int32Enum, object>)(object)SelectedAddons).Remove((System.Int32Enum)addonType);
		RefreshAvailableAddons();
		RefreshSelectedAddons();
		eventsChannel.TriggerRefreshView();
	}

	private void EditAddon(TournamentAddonType addonType)
	{
		ActivateSelector(addonType);
		popup.SlideFromBottom();
	}

	private void RemoveAllAddons()
	{
		((Dictionary<System.Int32Enum, object>)(object)SelectedAddons).Clear();
		RefreshSelectedAddons();
	}

	private void DisableActiveSelectors()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0121: Expected O, but got I4
		//IL_00c3: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_01e9: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C3E]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		UnityEngine.Object obj5;
		UnityEngine.Object obj7;
		object obj8;
		if (obj3 != null)
		{
			obj4 = this + 208;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (!flag)
			{
				goto IL_00a0;
			}
		}
		else
		{
			_ = 1;
			obj4 = this + 208;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj7;
		bool flag4 = !flag3;
		obj4 = obj8;
		if (!flag4)
		{
			goto IL_017c;
		}
		goto IL_01a9;
		IL_01a9:
		GameObject gameObject = confirmButton.gameObject;
		gameObject.SetActive(value: false);
		availableFeaturesSelectors.SetActive(value: false);
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_017c:
		GameObject gameObject2 = ((Component)obj4).gameObject;
		gameObject2.SetActive(value: false);
		obj8 = obj4;
		goto IL_01a9;
		IL_00a0:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		object obj10 = !flag6;
		if (obj10 != null)
		{
			goto IL_017c;
		}
		obj8 = obj4;
		goto IL_01a9;
	}

	private void ClearSelectors()
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I
		//IL_00f8: Expected O, but got I
		//IL_0108: Expected O, but got I
		//IL_012a: Expected O, but got I4
		//IL_006d: Expected O, but got I
		//IL_007d: Expected O, but got I
		//IL_008d: Expected O, but got I
		//IL_00af: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01cf: Expected O, but got I
		//IL_01e0: Expected I, but got O
		//IL_01fe: Expected O, but got I
		//IL_0192: Expected O, but got I
		object obj = (nint)0 + (nint)2352;
		object obj2 = typeof(DebugUI.BitField) + 2312;
		Dictionary<System.Int32Enum, object>.ValueCollection values = ((Dictionary<System.Int32Enum, object>)(object)AllSelectors).Values;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v8+E4]");
		object obj5;
		Action<object> action;
		object obj7;
		object obj4;
		if ((nint)0 != 0)
		{
			obj4 = (nint)0 + (nint)2384;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v8+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v8+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v8+8]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				obj7 = obj4;
				goto IL_0140;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			obj7 = (nint)0 + (nint)2384;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v8+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v8+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v8+8]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj4 = obj7;
			if (obj8 == null)
			{
				goto IL_0140;
			}
		}
		goto IL_0197;
		IL_0140:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v14+B8]");
			obj5 = 0;
		}
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)3784;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj5, (IntPtr)obj12);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v13+B8]");
		object obj14 = (nint)0 + (nint)8;
		obj14 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4 = obj7;
		action = action2;
		goto IL_0197;
		IL_0197:
		ArraysExtensions.ForEach(values, action);
	}

	private void SelectorOnValidStateChange()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0131: Expected O, but got I4
		//IL_018f: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C40]");
		object obj3 = (nint)0 & (nint)1;
		Button button;
		UnityEngine.Object activeSelector;
		UnityEngine.Object activeSelector2;
		Button button2;
		if (obj3 != null)
		{
			button = confirmButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			activeSelector = ActiveSelector;
			activeSelector2 = ActiveSelector;
			button2 = confirmButton;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			button = confirmButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			activeSelector = ActiveSelector;
			activeSelector2 = ActiveSelector;
			button2 = confirmButton;
			if (obj5 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = activeSelector2;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		button = button2;
		if (obj6 != null)
		{
			goto IL_00d3;
		}
		goto IL_01a5;
		IL_01bb:
		Selectable selectable;
		bool interactable;
		selectable.interactable = interactable;
		return;
		IL_00d3:
		bool isValid = ActiveSelector.IsValid;
		interactable = isValid;
		selectable = button;
		goto IL_01bb;
		IL_01a5:
		interactable = false;
		selectable = button2;
		goto IL_01bb;
		IL_00a5:
		bool flag5 = activeSelector;
		bool flag6 = !flag5;
		button2 = button;
		if (!flag6)
		{
			goto IL_00d3;
		}
		goto IL_01a5;
	}

	public void OnConfigChanged()
	{
		((Dictionary<System.Int32Enum, object>)(object)SelectedAddons).Clear();
		RefreshSelectedAddons();
		RefreshAvailableAddons();
		ClearSelectors();
		eventsChannel.TriggerRefreshView();
	}

	private void Show()
	{
		popup.SlideFromBottom();
	}

	public FeaturesBottomSheet()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 3112;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 3992;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 4000;
		object obj4 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 3104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
		dictionary..ctor();
		object obj5 = this + 88;
		obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj6 = this + 112;
		obj6 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj7 = this + 120;
		obj7 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary2 = default(Dictionary<System.Int32Enum, object>);
		dictionary2..ctor();
		object obj8 = this + 224;
		obj8 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <PopulateSelectors>b__39_0(List<SportTeam> sportTeams)
	{
		if (!ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)sportTeams))
		{
			sportTeamSelector.Populate(sportTeams);
		}
	}
}
