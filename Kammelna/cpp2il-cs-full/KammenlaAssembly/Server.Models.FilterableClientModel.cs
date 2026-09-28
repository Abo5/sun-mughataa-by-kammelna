using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;

namespace Server.Models;

public class FilterableClientModel
{
	private readonly Games <Game>k__BackingField;

	private readonly Platform <Platform>k__BackingField;

	private readonly Version <AppVersion>k__BackingField;

	private readonly bool <IsEligibleForAppStoreIntroOffer>k__BackingField;

	public Games Game => <Game>k__BackingField;

	public Platform Platform => <Platform>k__BackingField;

	public Version AppVersion => <AppVersion>k__BackingField;

	public bool IsEligibleForAppStoreIntroOffer => <IsEligibleForAppStoreIntroOffer>k__BackingField;

	public FilterableClientModel(Games game, Platform platform, Version appVersion, bool isEligibleForAppStoreIntroOffer)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = appVersion;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public static FilterableClientModel Current()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_0202: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0085: Expected O, but got I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_014d: Expected O, but got I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		string version = Application.version;
		Version result;
		bool flag2 = Version.TryParse(version, out result);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = typeof(UsageHint) + 72;
		Games currentGame = Preferences.CurrentGame;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 600;
		Platform platform = KUtil.GetPlatform();
		object obj12 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v15+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isEligibleForAppStoreIntroOffer = UserInfo.IsEligibleForAppStoreIntroOffer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = default(object);
		obj14..ctor();
		object obj15 = obj14 + 24;
		obj15 = result;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (FilterableClientModel)obj14;
	}

	public Dictionary<string, object> ToQueryParams()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I4
		//IL_003c: Expected I, but got O
		//IL_004c: Expected O, but got I
		//IL_0075: Expected O, but got I4
		//IL_0108: Expected O, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_01c0: Expected O, but got I4
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		object obj2 = (nint)0 + (nint)4072;
		object key = "Added Tournament Prizes And Features" + 1872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = obj2;
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		Version version = <AppVersion>k__BackingField;
		object value;
		if ((object)<AppVersion>k__BackingField != null)
		{
			nint num = (nint)version;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v14 (Il2CppClass<System.Version>)+170]");
			obj3 = 0;
			object obj4 = <AppVersion>k__BackingField.ToString();
			bool flag = obj4 == null;
			object obj5 = !flag;
			value = obj4;
			if (obj5 != null)
			{
				goto IL_0237;
			}
		}
		object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v20+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string version2 = Application.version;
		value = version2;
		goto IL_0237;
		IL_0237:
		if (dictionary != null)
		{
			object obj9 = (nint)0 + (nint)56;
			object obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
			object key2 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2232;
			object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 728;
			object key3 = "Picking audio files is not supported on iOS" + 120;
			object key4 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 1352;
			dictionary.set_Item(key, value);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object value2 = default(object);
			dictionary.set_Item(key2, value2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object value3 = default(object);
			dictionary.set_Item(key3, value3);
			object obj12 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object value4 = default(object);
			dictionary.set_Item(key4, value4);
			return (Dictionary<string, object>)(object)dictionary;
		}
		return (Dictionary<string, object>)(object)new NullReferenceException();
	}

	public override bool Equals(object obj)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_008b: Expected O, but got I
		//IL_011b: Expected O, but got I
		//IL_014f: Expected O, but got I
		bool flag2;
		if (obj != null)
		{
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 600;
			object obj3 = obj2;
			nint num = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X9_v2 (Il2CppClass<System.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v6+130]");
			bool flag = num2 < 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				flag2 = false;
				goto IL_0186;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X9_v2 (Il2CppClass<System.Object>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v6+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X9_v5-8]");
			if (0 == (nint)obj3)
			{
				Games num4 = <Game>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				if ((nint)num4 == (nint)0)
				{
					Platform num5 = <Platform>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+14]");
					if ((nint)num5 == (nint)0)
					{
						Version objA = <AppVersion>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+18]");
						flag2 = object.Equals(objA, 0);
						if (flag2)
						{
							bool num6 = <IsEligibleForAppStoreIntroOffer>k__BackingField;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+20]");
							object obj6 = (nint)(num6 ? 1 : 0) - (nint)0;
							return obj6 == null;
						}
						goto IL_0186;
					}
				}
			}
		}
		return false;
		IL_0186:
		return flag2;
	}

	public override int GetHashCode()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_006d: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3752;
		object obj2 = (nint)0 + (nint)824;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3914C");
		int result = default(int);
		return result;
	}
}
