using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Firebase.Analytics;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;

namespace DataTracking;

public static class FirebaseTrack
{
	private static string ParameterValue
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7C10]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+360]");
			return (string)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+360]");
			return (string)0;
		}
	}

	private static string ParameterItemName
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7C11]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+238]");
			return (string)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+238]");
			return (string)0;
		}
	}

	private static string ParameterCurrency
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7C12]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+1A8]");
			return (string)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+1A8]");
			return (string)0;
		}
	}

	private static string EventEcommercePurchase
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7C13]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+88]");
			return (string)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+88]");
			return (string)0;
		}
	}

	public static void Purchase(string name, string type, string currencyCode, double revenue = 0.0)
	{
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_026d: Expected O, but got I
		//IL_0297: Expected O, but got I4
		//IL_018e: Expected O, but got I
		//IL_01aa: Expected O, but got I4
		//IL_01c0: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_005d: Expected O, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007c: Expected O, but got I
		//IL_0095: Expected O, but got I
		//IL_0150: Expected O, but got I4
		//IL_0207: Expected O, but got I4
		//IL_02b5: Expected O, but got I
		//IL_02c4: Expected O, but got I4
		//IL_02e7: Expected O, but got I
		//IL_023f: Expected O, but got I4
		//IL_02fc: Expected O, but got I
		//IL_0315: Expected O, but got I
		//IL_032a: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj2 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		object obj3 = (nint)0 + (nint)4072;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v4+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj7 = 146685952;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E1]");
		object obj8 = (nint)0 & (nint)1;
		object obj9;
		if (obj8 != null)
		{
			obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = obj9;
			if (!flag2)
			{
				goto IL_0051;
			}
		}
		else
		{
			_ = 1;
			obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			object obj10 = obj9;
			if (obj11 != null)
			{
				goto IL_0051;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj9 = obj;
		bool flag4 = dictionary == null;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0051;
		IL_0051:
		object obj13 = (nint)0 + (nint)4088;
		object key = "tournament_participate_warning_body_with_tickets_warning_daily" + 968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v16+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v13+238]");
		dictionary.Add(0, name);
		dictionary.Add(key, type);
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v21+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v21+B8]");
		object obj17 = 0;
		object obj18 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17+360]");
		object value = default(object);
		dictionary.Add(0, value);
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v27+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v27+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v23+1A8]");
		dictionary.Add(0, currencyCode);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v6+88]");
		Event((string)0, (Dictionary<string, object>)(object)dictionary);
	}

	internal static void BuyCard(StoreItem bItem)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I4
		object obj = "AvailableVoices" + 3152;
		object obj2 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		int num = default(int);
		string text = num.ToString();
		string name = (string)obj + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object key = "m_StencilDeferredPS" + 2872;
		object obj3 = (nint)0 + (nint)4088;
		object key2 = "utf-32" + 888;
		dictionary.Add(key, bItem.<name>k__BackingField);
		int num2 = StorePricing.EffectivePrice(bItem);
		object obj4 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value = default(object);
		dictionary.Add(key2, value);
		Event(name, (Dictionary<string, object>)(object)dictionary);
	}

	public static void Event(string action, string type = "")
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object key = "tournament_participate_warning_body_with_tickets_warning_daily" + 968;
		dictionary.Add(key, type);
		Event(action, (Dictionary<string, object>)(object)dictionary);
	}

	public static void FinishGame(int pointsDifference, string rating, bool balancedGame, string cheatingType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object key = "Picking audio files is not supported on iOS" + 792;
		object obj3 = (nint)0 + (nint)4088;
		object key2 = "Picking audio files is not supported on iOS" + 3976;
		object key3 = "AvailableVoices" + 1032;
		object key4 = "Cannot populate JSON object onto type '{0}'." + 2400;
		object name = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 104;
		object value = default(object);
		dictionary.Add(key, value);
		dictionary.Add(key2, rating);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value2 = default(object);
		dictionary.Add(key3, value2);
		dictionary.Add(key4, cheatingType);
		Event((string)name, (Dictionary<string, object>)(object)dictionary);
	}

	public static void CurrencyEvent(string action, string itemName, long value)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0183: Expected O, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01ad: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_0066: Expected O, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0085: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_00ad: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		object obj2 = (nint)0 + (nint)4072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj3 = 146685952;
		object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E1]");
		object obj5 = (nint)0 & (nint)1;
		object obj6;
		if (obj5 != null)
		{
			obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = obj6;
			if (!flag)
			{
				goto IL_005a;
			}
		}
		else
		{
			_ = 1;
			obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj7 = obj6;
			if (obj8 != null)
			{
				goto IL_005a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj4;
		bool flag3 = dictionary == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_005a;
		IL_005a:
		object obj10 = (nint)0 + (nint)4088;
		object key = "utf-32" + 888;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v13+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v9+238]");
		dictionary.Add(0, itemName);
		object obj12 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value2 = default(object);
		dictionary.Add(key, value2);
		Event(action, (Dictionary<string, object>)(object)dictionary);
	}

	public static void AbandonGame(int pointsDifference, bool balancedGame, int lostPoints)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object key = "Picking audio files is not supported on iOS" + 792;
		object obj3 = (nint)0 + (nint)4088;
		object key2 = "AvailableVoices" + 1032;
		object key3 = "Picking audio files is not supported on iOS" + 800;
		object name = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2984;
		object value = default(object);
		dictionary.Add(key, value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value2 = default(object);
		dictionary.Add(key2, value2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value3 = default(object);
		dictionary.Add(key3, value3);
		Event((string)name, (Dictionary<string, object>)(object)dictionary);
	}

	public static void UserProperty(string propertyName, string propertyText)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0157: Expected O, but got I4
		//IL_010b: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D72]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		bool flag2 = !noPlayServices;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			return;
		}
		goto IL_0119;
		IL_0119:
		object obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FirebaseAnalytics.SetUserProperty(propertyName, propertyText);
		return;
		IL_0074:
		if (KUtil.NoPlayServices)
		{
			return;
		}
		goto IL_0119;
	}

	public static void Screen(string sceneName)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0175: Expected O, but got I4
		//IL_027d: Expected O, but got I
		//IL_0114: Expected O, but got I4
		//IL_01b2: Expected O, but got I
		//IL_01cc: Expected O, but got I
		//IL_01e0: Expected O, but got I4
		//IL_01f0: Expected O, but got I
		//IL_0200: Expected O, but got I
		//IL_0218: Expected O, but got I
		//IL_0224: Expected O, but got I
		//IL_0252: Expected O, but got I
		//IL_026c: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7C14]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		bool flag2 = !noPlayServices;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0122;
		IL_0122:
		object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj8 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v3+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v6+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v7+2F8]");
		dictionary.Add(0, sceneName);
		object obj14 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+90]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v10+B8]");
		object newValue = 0;
		object obj16 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v12+B8]");
		object obj17 = 0;
		object oldValue = (nint)0 + (nint)3072;
		string value = sceneName.Replace((string)oldValue, (string)newValue);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v13+2F0]");
		dictionary.Add(0, value);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v4+A0]");
		Event((string)0, (Dictionary<string, object>)(object)dictionary);
		return;
		IL_007d:
		if (KUtil.NoPlayServices)
		{
			return;
		}
		goto IL_0122;
	}

	private static void Event(string name, Dictionary<string, object> parameters)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0139: Expected O, but got I
		//IL_0145: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_017d: Expected I, but got O
		//IL_010b: Expected O, but got I4
		//IL_01cf: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7C15]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		bool flag2 = !noPlayServices;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			return;
		}
		goto IL_0119;
		IL_0119:
		object obj6 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3664;
		object obj7 = (nint)0 + (nint)640;
		object obj8 = (nint)0 + (nint)2800;
		object obj9 = (nint)0 + (nint)1416;
		object obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<KeyValuePair<object, object>, object> func = default(Func<KeyValuePair<object, object>, object>);
		func..ctor((object)null, (IntPtr)obj7);
		IEnumerable<object> source = Enumerable.Select((IEnumerable<KeyValuePair<object, object>>)parameters, func);
		object[] parameters2 = Enumerable.ToArray(source);
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FirebaseAnalytics.LogEvent(name, (Parameter[])parameters2);
		return;
		IL_0074:
		if (KUtil.NoPlayServices)
		{
			return;
		}
		goto IL_0119;
	}

	private static Parameter PairToParameter(KeyValuePair<string, object> pair)
	{
		//IL_0014: Expected O, but got I4
		//IL_001c: Expected O, but got I
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_02ab: Expected O, but got I
		//IL_0058: Expected O, but got I
		//IL_008c: Expected O, but got I
		//IL_0160: Expected I8, but got O
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_01a6: Expected I8, but got O
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_020f: Expected F8, but got O
		//IL_0259: Expected F8, but got O
		object obj = 153100288 + 1024;
		IntPtr intPtr = default(IntPtr);
		object obj2 = (nint)intPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X9_v3+90]");
		bool flag = intPtr == (IntPtr)0;
		IntPtr intPtr2 = intPtr;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X9_v3+48]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X9_v3+48]");
			long parameterValue2;
			if (intPtr != (IntPtr)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X9_v3+68]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X9_v3+68]");
				if (intPtr != (IntPtr)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X9_v3+78]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X9_v3+78]");
					double parameterValue;
					string parameterName;
					Parameter result;
					Parameter parameter = default(Parameter);
					if (intPtr != (IntPtr)0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X9_v3+80]");
						if (intPtr != (IntPtr)0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ X8_v4+168] (should have been resolved before IL gen)");
							IntPtr intPtr3 = default(IntPtr);
							intPtr2 = intPtr3;
							goto IL_027c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CA1380");
						object obj5 = typeof(MemberAchievementClanFeedData) + 3976;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj6 = default(object);
						parameterValue = (double)obj6;
						parameterName = (string)pair;
						result = parameter;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4+40]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X1_v8+40]");
						if (num != 0)
						{
							goto IL_026e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
						object obj7 = typeof(MemberAchievementClanFeedData) + 3976;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj8 = default(object);
						parameterValue = (double)obj8;
						parameterName = (string)pair;
						result = parameter;
					}
					parameter..ctor(parameterName, parameterValue);
					return result;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4+40]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X1_v5+40]");
				if (num2 != 0)
				{
					goto IL_026e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
				object obj9 = default(object);
				parameterValue2 = (long)obj9;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4+40]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X1_v5+40]");
				if (num3 != 0)
				{
					goto IL_026e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
				object obj10 = default(object);
				parameterValue2 = (long)obj10;
			}
			object obj11 = typeof(MemberAchievementClanFeedData) + 3976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Parameter parameter2 = default(Parameter);
			parameter2..ctor((string)pair, parameterValue2);
			return parameter2;
		}
		goto IL_027c;
		IL_027c:
		object obj12 = typeof(MemberAchievementClanFeedData) + 3976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Parameter parameter3 = default(Parameter);
		parameter3..ctor((string)pair, (string)(nint)intPtr2);
		return parameter3;
		IL_026e:
		return (Parameter)(object)new InvalidCastException();
	}

	public static void SetAnalyticsConsent()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, System.Int32Enum> dictionary = default(Dictionary<System.Int32Enum, System.Int32Enum>);
		dictionary..ctor();
		object obj2 = (nint)0 + (nint)2280;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		dictionary.Add((System.Int32Enum)1, (System.Int32Enum)0);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			FirebaseAnalytics.SetConsent((IDictionary<ConsentType, ConsentStatus>)dictionary);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FirebaseAnalytics.SetConsent((IDictionary<ConsentType, ConsentStatus>)dictionary);
	}
}
