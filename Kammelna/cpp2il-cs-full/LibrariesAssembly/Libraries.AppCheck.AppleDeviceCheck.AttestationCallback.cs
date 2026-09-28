using System;
using System.Buffers.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.iOS;

namespace Libraries.AppCheck;

public class AppleDeviceCheck : IAppChecker
{
	private enum KeyIdPhase
	{
		Lookup,
		Generate
	}

	public delegate void KeyIdCallback(IntPtr keyIdPtr);

	public delegate void AttestationCallback(IntPtr attestationStringPtr);

	public delegate void AssertionCallback(IntPtr assertionStringPtr);

	public delegate void ErrorCallback(IntPtr errorPtr);

	private static AppleDeviceCheck _instance;

	private AppCheckResult _appCheckCallback;

	private string _latestUserKey;

	private string _latestRequestHash;

	private KeyIdPhase _keyIdPhase;

	private string _currentKeyId;

	private bool _attesting;

	private static string LegacyKeysPath
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			//IL_00e6: Expected O, but got I4
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 72;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object path = "Added Tournament Prizes And Features" + 1944;
			string persistentDataPath = Application.persistentDataPath;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+E4]");
			if ((nint)0 != 0)
			{
				return Path.Combine(persistentDataPath, (string)path);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return Path.Combine(persistentDataPath, (string)path);
		}
	}

	public AppCheckerStrategy AppChecker => AppCheckerStrategy.AppleDeviceCheck;

	private static string SystemVersion
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0043: Expected O, but got I
			//IL_0076: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3920;
			object pattern = "WhiteSmoke" + 3912;
			object replacement = (nint)0 + (nint)2000;
			string systemVersion = Device.systemVersion;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Regex.Replace(systemVersion, (string)pattern, (string)replacement);
		}
	}

	public bool IsSupported
	{
		get
		{
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00ca: Expected O, but got I
			//IL_00fd: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3920;
			object obj2 = typeof(UsageHint) + 992;
			object pattern = "WhiteSmoke" + 3912;
			object replacement = (nint)0 + (nint)2000;
			string systemVersion = Device.systemVersion;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string version = Regex.Replace(systemVersion, (string)pattern, (string)replacement);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Version version2 = default(Version);
			version2..ctor(version);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Version version3 = default(Version);
			version3..ctor(14, 0, 0);
			return version2 >= version3;
		}
	}

	public bool RequireSignature => true;

	[PreserveSig]
	private static extern void DeviceCheckPlugin_SetKeyIdCallback(KeyIdCallback callback);

	[PreserveSig]
	private static extern void DeviceCheckPlugin_SetAttestationCallback(AttestationCallback callback);

	[PreserveSig]
	private static extern void DeviceCheckPlugin_SetAssertionCallback(AssertionCallback callback);

	[PreserveSig]
	private static extern void DeviceCheckPlugin_SetErrorCallback(ErrorCallback callback);

	[PreserveSig]
	private static extern void DeviceCheckPlugin_GenerateKey(string userKey);

	[PreserveSig]
	private static extern void DeviceCheckPlugin_AttestKey(string keyId, string signature);

	[PreserveSig]
	private static extern void DeviceCheckPlugin_GenerateAssertion(string keyId, string signature);

	[PreserveSig]
	private static extern void DeviceCheckPlugin_GetStoredKeyId(string userKey);

	[PreserveSig]
	private static extern int DeviceCheckPlugin_StoreKeyId(string userKey, string keyId);

	[PreserveSig]
	private static extern int DeviceCheckPlugin_DeleteStoredKeyId(string userKey);

	public void Initialize()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0090: Expected O, but got I4
		//IL_03bb: Expected O, but got I4
		//IL_0118: Expected O, but got I
		//IL_0408: Expected O, but got I4
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_0102: Expected O, but got I4
		//IL_0136: Expected O, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0167: Expected O, but got I4
		//IL_01ee: Expected O, but got I
		//IL_0458: Expected O, but got I4
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected O, but got Unknown
		//IL_01d9: Expected O, but got I4
		//IL_020c: Expected O, but got I
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_023d: Expected O, but got I4
		//IL_02c4: Expected O, but got I
		//IL_04a8: Expected O, but got I4
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_02af: Expected O, but got I4
		//IL_02e2: Expected O, but got I
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_0313: Expected O, but got I4
		//IL_039a: Expected O, but got I
		//IL_04f8: Expected O, but got I4
		//IL_0385: Expected O, but got I4
		if (!IsSupported)
		{
			return;
		}
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 304;
		object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1688;
		object obj3 = (nint)0 + (nint)2760;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X20_v5+8]");
		_ = 0;
		object obj7 = default(object);
		object obj6 = obj7 + 32;
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj8 = default(object);
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X20_v5+52]");
			if ((nint)0 == 1)
			{
				object obj9 = 35909632 + 2328;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+20]");
				_ = 0;
			}
			object obj10 = 35909632 + 2244;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CAFF20");
			object obj11 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)2744;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X20_v7+8]");
			_ = 0;
			object obj15 = default(object);
			object obj14 = obj15 + 32;
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
			object obj16 = default(object);
			if (obj16 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X20_v7+52]");
				if ((nint)0 == 1)
				{
					object obj17 = 35909632 + 2440;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v19+10]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v19+20]");
					_ = 0;
				}
				object obj18 = 35909632 + 2356;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CAFF08");
				object obj19 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1664;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj20 = (nint)0 + (nint)2736;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X20_v8+8]");
				_ = 0;
				object obj23 = default(object);
				object obj22 = obj23 + 32;
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
				object obj24 = default(object);
				if (obj24 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X20_v8+52]");
					if ((nint)0 == 1)
					{
						object obj25 = 35909632 + 2552;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v28+10]");
						object obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v28+20]");
						_ = 0;
					}
					object obj26 = 35909632 + 2468;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB4");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CAFEFC");
					object obj27 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1680;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj28 = (nint)0 + (nint)2752;
					object obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X20_v9+8]");
					_ = 0;
					object obj31 = default(object);
					object obj30 = obj31 + 32;
					obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
					object obj32 = default(object);
					if (obj32 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X20_v9+52]");
						if ((nint)0 == 1)
						{
							object obj33 = 35909632 + 2664;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v37+10]");
							object obj33 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v37+20]");
							_ = 0;
						}
						object obj34 = 35909632 + 2580;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB4");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CAFF14");
						return;
					}
				}
			}
		}
		object obj35 = 134782976 + 1449;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1AB4");
		throw new OutOfMemoryException();
	}

	public void GetToken(string userKey, string requestHash, AppCheckResult callback)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0082: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		while (!IsSupported)
		{
			object error = "Network Authentication Required" + 2264;
			AppIntegrityRequestModel errorModel = GetErrorModel((string)error);
			IntPtr invoke_impl = ((Delegate)callback).invoke_impl;
			IntPtr method_code = ((Delegate)callback).method_code;
			IntPtr method = ((Delegate)callback).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v75 @ X3_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj2 = this + 16;
		obj2 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 24;
		obj3 = userKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string version = Application.version;
		string text = requestHash + version;
		object obj6 = this + 32;
		obj6 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CAFEF0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
	}

	public void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0088: Expected O, but got I
		//IL_002a: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 304;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+18]");
		if (!string.IsNullOrEmpty((string)0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CAFECC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		}
	}

	public static void MigrateStoredKeyIds()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00c7: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_0081: Expected O, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_012f: Expected O, but got I4
		//IL_015d: Expected O, but got I
		string legacyKeysPath = LegacyKeysPath;
		if (!Directory.Exists(legacyKeysPath))
		{
			return;
		}
		string legacyKeysPath2 = LegacyKeysPath;
		string[] files = Directory.GetFiles(legacyKeysPath2);
		if (files.Length >= 1)
		{
			object obj = files + 32;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 72;
			object obj3 = 0;
			object obj7 = default(object);
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X25_v6+v219 @ X24_v7*8]");
				string value = File.ReadAllText((string)0);
				bool flag = string.IsNullOrEmpty(value);
				bool flag2 = !flag;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					object obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v17+E4]");
					bool flag3 = (nint)0 == 0;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X25_v6+v219 @ X24_v7*8]");
					string fileName = Path.GetFileName((string)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CAFF2C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
					if ((nint)obj7 != 1)
					{
						goto IL_0087;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X25_v6+v219 @ X24_v7*8]");
				File.Delete((string)0);
				goto IL_0087;
				IL_0087:
				obj3++;
			}
			while ((nint)obj3 < files.Length);
		}
		string legacyKeysPath3 = LegacyKeysPath;
		string[] fileSystemEntries = Directory.GetFileSystemEntries(legacyKeysPath3);
		if (fileSystemEntries.Length == 0)
		{
			string legacyKeysPath4 = LegacyKeysPath;
			Directory.Delete(legacyKeysPath4);
		}
	}

	private static void OnKeyIdCallback(IntPtr keyIdPtr)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_024c: Expected O, but got I4
		//IL_004d: Expected O, but got I
		//IL_007c: Expected O, but got I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0132: Expected O, but got I
		//IL_00af: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3680;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 304;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = Marshal.PtrToStringAnsi(keyIdPtr);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4+B8]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v9+28]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			bool flag3 = string.IsNullOrEmpty(text);
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4+B8]");
			object obj10 = 0;
			obj7 = obj10;
			if (flag3)
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CAFEE4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
				return;
			}
		}
		object obj11 = obj7 + 48;
		obj11 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v9+B8]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v11+28]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v11+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CAFEC0");
			object obj16 = default(object);
			object obj15 = obj16;
			object obj18 = default(object);
			object obj17 = obj18;
			object obj19 = obj16;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CAFED8");
			object obj20 = default(object);
			object obj15 = obj20;
			object obj21 = default(object);
			object obj17 = obj21;
			object obj19 = obj20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
	}

	private static void OnAttestationCallback(IntPtr attestationStringPtr)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_00f7: Expected O, but got I
		//IL_0129: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_0175: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 304;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3680;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D3F]");
		object obj4 = (nint)0 & (nint)1;
		AppleDeviceCheck appleDeviceCheck;
		AppleDeviceCheck appleDeviceCheck2;
		if (obj4 != null)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v10+B8]");
			object obj6 = 0;
			appleDeviceCheck = (AppleDeviceCheck)obj6;
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			appleDeviceCheck2 = (AppleDeviceCheck)obj6;
			if (!flag)
			{
				goto IL_00b9;
			}
		}
		else
		{
			_ = 1;
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5+B8]");
			object obj9 = 0;
			appleDeviceCheck = (AppleDeviceCheck)obj9;
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			appleDeviceCheck2 = (AppleDeviceCheck)obj9;
			if (obj10 != null)
			{
				goto IL_00b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string token = Marshal.PtrToStringAnsi(attestationStringPtr);
		bool flag3 = appleDeviceCheck2 == null;
		object obj11 = !flag3;
		appleDeviceCheck = appleDeviceCheck2;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00cb;
		IL_00b9:
		token = Marshal.PtrToStringAnsi(attestationStringPtr);
		goto IL_00cb;
		IL_00cb:
		appleDeviceCheck.DeliverToken(token);
	}

	private static void OnAssertionCallback(IntPtr assertionStringPtr)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_00f7: Expected O, but got I
		//IL_0129: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_0175: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 304;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3680;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D40]");
		object obj4 = (nint)0 & (nint)1;
		AppleDeviceCheck appleDeviceCheck;
		AppleDeviceCheck appleDeviceCheck2;
		if (obj4 != null)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v10+B8]");
			object obj6 = 0;
			appleDeviceCheck = (AppleDeviceCheck)obj6;
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			appleDeviceCheck2 = (AppleDeviceCheck)obj6;
			if (!flag)
			{
				goto IL_00b9;
			}
		}
		else
		{
			_ = 1;
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5+B8]");
			object obj9 = 0;
			appleDeviceCheck = (AppleDeviceCheck)obj9;
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			appleDeviceCheck2 = (AppleDeviceCheck)obj9;
			if (obj10 != null)
			{
				goto IL_00b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string token = Marshal.PtrToStringAnsi(assertionStringPtr);
		bool flag3 = appleDeviceCheck2 == null;
		object obj11 = !flag3;
		appleDeviceCheck = appleDeviceCheck2;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00cb;
		IL_00b9:
		token = Marshal.PtrToStringAnsi(assertionStringPtr);
		goto IL_00cb;
		IL_00cb:
		appleDeviceCheck.DeliverToken(token);
	}

	private static void OnErrorCallback(IntPtr errorPtr)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0392: Expected O, but got I4
		//IL_004d: Expected O, but got I
		//IL_02f0: Expected O, but got I
		//IL_0313: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0131: Expected O, but got I4
		//IL_022f: Expected O, but got I
		//IL_024d: Expected O, but got I
		//IL_026b: Expected O, but got I4
		//IL_017d: Expected O, but got I4
		//IL_029a: Expected O, but got I
		//IL_01c7: Expected O, but got I4
		//IL_01f6: Expected O, but got I4
		//IL_0208: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3680;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 304;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = Marshal.PtrToStringAnsi(errorPtr);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+B8]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v6+38]");
		object obj10;
		object obj11 = default(object);
		if ((nint)0 == 1)
		{
			object obj8 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 56;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				if (!string.IsNullOrEmpty(text))
				{
					goto IL_0147;
				}
				obj10 = obj11;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag2 = string.IsNullOrEmpty(text);
				bool flag3 = !flag2;
				object obj12 = !flag3;
				obj10 = obj11;
				if (obj12 == null)
				{
					goto IL_0147;
				}
			}
			goto IL_0217;
		}
		goto IL_02d8;
		IL_0217:
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v19+B8]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v21+18]");
		bool flag4 = string.IsNullOrEmpty((string)0);
		bool flag5 = !flag4;
		object obj16 = !flag5;
		obj11 = obj10;
		if (obj16 == null)
		{
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v22+B8]");
			object obj18 = 0;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CAFECC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
			obj11 = obj10;
		}
		goto IL_02d8;
		IL_02d8:
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v10+B8]");
		object obj21 = 0;
		object obj22 = obj21;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v12+10]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v12+10]");
		if ((nint)0 != 0)
		{
			AppIntegrityRequestModel errorModel = GetErrorModel(text);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v184 @ X20_v5+18] (should have been resolved before IL gen)");
		}
		return;
		IL_0147:
		string[] array = text.Split('|');
		bool flag6 = array.Length < 3;
		obj10 = 0;
		StringSplitOptions stringSplitOptions = StringSplitOptions.None;
		if (!flag6)
		{
			int result;
			bool flag7 = int.TryParse(array[2], out result);
			bool flag8 = !flag7;
			obj10 = 0;
			stringSplitOptions = StringSplitOptions.None;
			if (!flag8)
			{
				bool flag9 = result == 4;
				obj10 = 0;
				stringSplitOptions = StringSplitOptions.None;
				obj11 = 0;
				if (flag9)
				{
					goto IL_02d8;
				}
			}
		}
		goto IL_0217;
	}

	private void DeliverToken(string token)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0172: Expected O, but got I
		//IL_01a5: Expected O, but got I4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_0212: Expected O, but got I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		_attesting = false;
		AppCheckResult appCheckCallback = _appCheckCallback;
		if (_appCheckCallback != null)
		{
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 16;
			obj3 = token;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = _currentKeyId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 3920;
			object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
			object pattern = "WhiteSmoke" + 3912;
			object replacement = (nint)0 + (nint)2000;
			string systemVersion = Device.systemVersion;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = Regex.Replace(systemVersion, (string)pattern, (string)replacement);
			object obj9 = obj2 + 40;
			obj9 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj10 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string version = Application.version;
			object obj12 = obj2 + 64;
			obj12 = version;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			IntPtr invoke_impl = ((Delegate)appCheckCallback).invoke_impl;
			IntPtr method_code = ((Delegate)appCheckCallback).method_code;
			IntPtr method = ((Delegate)appCheckCallback).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v77 @ X3_v2 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static AppIntegrityRequestModel GetErrorModel(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I
		//IL_00fa: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3920;
		object pattern = "WhiteSmoke" + 3912;
		object replacement = (nint)0 + (nint)2000;
		string systemVersion = Device.systemVersion;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = Regex.Replace(systemVersion, (string)pattern, (string)replacement);
		if (obj2 != null)
		{
			object obj6 = obj2 + 40;
			obj6 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj2 + 56;
			obj7 = error;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (AppIntegrityRequestModel)obj2;
		}
		return (AppIntegrityRequestModel)(object)new NullReferenceException();
	}
}
