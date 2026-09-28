using System;
using System.Data;
using Cpp2ILInjected;
using DataTracking;
using Unity.Services.Authentication.Shared;
using UnityEngine.Purchasing.Telemetry;

namespace Kammelna.Server;

public static class Authentication
{
	private const string ExpiresKeySuffix = "Expires";

	private static string _accessTokenCache;

	public static string CurrentAccessTokenString
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1504;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object result = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1868");
			return (string)result;
		}
	}

	public static TokenModel AccessToken
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3176;
			return GetToken((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3176;
			TokenModel value2 = default(TokenModel);
			SetToken(value2, (string)key);
		}
	}

	public static TokenModel RefreshToken
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Read object reference Id '{0}' for {1}." + 1120;
			return GetToken((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Read object reference Id '{0}' for {1}." + 1120;
			TokenModel value2 = default(TokenModel);
			SetToken(value2, (string)key);
		}
	}

	public static void SyncAccessTokenCache()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0111: Expected O, but got I
		//IL_012b: Expected O, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0187: Expected O, but got I4
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8584]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object key;
		if (obj2 != null)
		{
			obj3 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8585]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			key = obj3;
			if (!flag)
			{
				goto IL_0086;
			}
		}
		else
		{
			_ = 1;
			obj3 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8585]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			key = obj3;
			if (obj6 != null)
			{
				goto IL_0086;
			}
		}
		_ = 1;
		object obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1504;
		TokenModel token = GetToken((string)key);
		bool flag3 = token == null;
		object obj8 = !flag3;
		TokenModel tokenModel = token;
		object obj9 = obj7;
		if (obj8 != null)
		{
			goto IL_00d4;
		}
		goto IL_01a5;
		IL_01bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1868");
		object obj10 = obj7;
		string text;
		object obj11 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_00d4:
		text = token.<Token>k__BackingField;
		goto IL_01bf;
		IL_01a5:
		token = tokenModel;
		obj7 = obj9;
		text = null;
		goto IL_01bf;
		IL_0086:
		obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1504;
		token = GetToken((string)obj3);
		bool flag4 = token == null;
		tokenModel = token;
		obj9 = obj7;
		if (!flag4)
		{
			goto IL_00d4;
		}
		goto IL_01a5;
	}

	public static bool CanLogin()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0038: Expected I4, but got O
		//IL_001d: Expected O, but got I4
		object key = "Read object reference Id '{0}' for {1}." + 1120;
		bool flag = (byte)(int)GetToken((string)key) != 0;
		if (flag)
		{
			return ((TokenModel)flag).IsValid;
		}
		return flag;
	}

	public static void Clear(string reason)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		object key = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3176;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		SetToken(null, (string)key);
		object key2 = "Read object reference Id '{0}' for {1}." + 1120;
		SetToken(null, (string)key2);
		ITrackEvent trackEvent = TrackerLibrary.DevAuthenticationCleared(reason);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private static TokenModel GetToken(string key = "")
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_005f: Expected O, but got I4
		//IL_00b4: Expected O, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_013c: Expected O, but got I4
		//IL_0176: Expected O, but got I
		//IL_018b: Expected O, but got I
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E83BA]");
		object obj2 = (nint)0 & (nint)1;
		TokenModel result;
		if (obj2 != null)
		{
			bool flag = Prefs.HasKey(key);
			bool flag2 = !flag;
			object obj3 = !flag2;
			result = null;
			if (obj3 == null)
			{
				goto IL_0072;
			}
		}
		else
		{
			_ = 1;
			bool flag3 = Prefs.HasKey(key);
			bool flag4 = !flag3;
			result = null;
			if (flag4)
			{
				goto IL_0072;
			}
		}
		object defaultValue = (nint)0 + (nint)2000;
		object obj4 = "Error reading data from socket: " + 1840;
		object obj5 = typeof(DataRelation) + 712;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1280;
		string token = Prefs.GetString(key, (string)defaultValue);
		string key2 = key + (string)obj4;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v6+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v7+10]");
		DateTime date = Prefs.GetDate(key2, (DateTime)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TokenModel tokenModel = default(TokenModel);
		tokenModel..ctor(token, date);
		return tokenModel;
		IL_0072:
		return result;
	}

	private static void SetToken(TokenModel value, string key = "")
	{
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_008c: Expected O, but got I4
		object obj = "Error reading data from socket: " + 1840;
		object obj2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3176;
		string text2;
		if (value != null)
		{
			Prefs.SetString(key, value.<Token>k__BackingField);
			string key2 = key + (string)obj;
			Prefs.SetDate(key2, value.<ExpiresAt>k__BackingField);
			string text = (string)obj2;
			if (!(key == (string)obj2))
			{
				return;
			}
			text2 = value.<Token>k__BackingField;
			object obj3 = 0;
		}
		else
		{
			Prefs.DeleteKey(key);
			string key3 = key + (string)obj;
			Prefs.DeleteKey(key3);
			string text = (string)obj2;
			bool flag = key == (string)obj2;
			bool flag2 = !flag;
			object obj3 = 0;
			text2 = null;
			if (flag2)
			{
				return;
			}
		}
		object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1868");
		object obj5 = obj4;
		object obj6 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
