using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Kammelna.Server.WebRequests;
using Kammelna.Server.WebRequests.Servers;
using Libraries.AppCheck;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Server.Models.StcPay;
using Server.Models.Store;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;

public static class KammelnaRequests
{
	private sealed class <>c__DisplayClass1_0
	{
		public UserCredentials credentials;

		public Action<KammelnaResponseModel<AuthModel>> callback;

		internal void <GetAuthTokens>b__0(AppIntegrityRequestModel tokenModel)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2472;
			object obj2 = credentials + 48;
			AppIntegrityRequestModel appIntegrityRequestModel = default(AppIntegrityRequestModel);
			obj2 = appIntegrityRequestModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GetAuthTokenRequest getAuthTokenRequest = default(GetAuthTokenRequest);
			getAuthTokenRequest..ctor(credentials);
			SendRequest((IWebRequest<object>)getAuthTokenRequest, (Action<KammelnaResponseModel<object>>)callback);
		}
	}

	private sealed class <>c__DisplayClass2_0
	{
		public Action<KammelnaResponseModel<AuthModel>> callback;

		internal void <RefreshAuthTokens>b__0(AppIntegrityRequestModel tokenModel)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			TokenModel refreshToken = Authentication.RefreshToken;
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3856;
			string deviceId = UserDeviceIDRecorder.DeviceId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			RefreshAuthTokenRequest refreshAuthTokenRequest = default(RefreshAuthTokenRequest);
			refreshAuthTokenRequest..ctor(refreshToken.<Token>k__BackingField, deviceId, tokenModel);
			SendRequest((IWebRequest<object>)refreshAuthTokenRequest, (Action<KammelnaResponseModel<object>>)callback);
		}
	}

	private sealed class <>c__DisplayClass39_0
	{
		public Action<long> successCallback;

		public Action<KammelnaError> errorCallback;

		internal void <BuyConsumable>b__0(KammelnaResponseModel<long> response)
		{
			//IL_00a4: Expected O, but got I
			//IL_00b4: Expected O, but got I
			//IL_00c4: Expected O, but got I
			//IL_00d4: Expected O, but got I
			//IL_004b: Expected O, but got I
			//IL_005b: Expected O, but got I
			//IL_006b: Expected O, but got I
			//IL_007b: Expected O, but got I
			if (response.Succeeded)
			{
				Action<long> action = successCallback;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Int64>)+30]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v7 (System.Action`1<System.Int64>)+18]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v7 (System.Action`1<System.Int64>)+40]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v7 (System.Action`1<System.Int64>)+28]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v75 @ X3_v2 (should have been resolved before IL gen)");
			}
			Action<KammelnaError> action2 = errorCallback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Int64>)+14]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v6 (System.Action`1<KammelnaError>)+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v6 (System.Action`1<KammelnaError>)+40]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v6 (System.Action`1<KammelnaError>)+28]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v76 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public Action<KammelnaResponseModel<AuthModel>> requestCallback;

		public AppCheckResult callback;

		internal void <PerformIntegrityCheck>b__0(KammelnaResponseModel<ServerChallengeResult> response)
		{
			//IL_0011: Expected O, but got I
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected O, but got Unknown
			//IL_00fb: Expected O, but got I
			//IL_010b: Expected O, but got I
			//IL_011b: Expected O, but got I
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Expected O, but got Unknown
			//IL_0154: Expected O, but got I
			//IL_01b2: Expected I, but got O
			object obj = (nint)0 + (nint)1464;
			string userKey = default(string);
			string requestHash = default(string);
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				ServerChallengeResult <Model>k__BackingField = response.<Model>k__BackingField;
				if ((object)response.<Model>k__BackingField != null)
				{
					if (<Model>k__BackingField.<AttestationRequested>k__BackingField)
					{
						userKey = <Model>k__BackingField.<UserKey>k__BackingField;
						requestHash = <Model>k__BackingField.<ServerChallenge>k__BackingField;
						goto IL_0134;
					}
					AppCheckResult appCheckResult = callback;
					IntPtr invoke_impl = ((Delegate)appCheckResult).invoke_impl;
					IntPtr method_code = ((Delegate)appCheckResult).method_code;
					IntPtr method = ((Delegate)appCheckResult).method;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v115 @ X3_v4 (System.IntPtr) (should have been resolved before IL gen)");
					goto IL_019a;
				}
			}
			else
			{
				Action<KammelnaResponseModel<AuthModel>> action = requestCallback;
				object obj2 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2936;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				KammelnaResponseModel<object> kammelnaResponseModel = default(KammelnaResponseModel<object>);
				kammelnaResponseModel..ctor(response.<Error>k__BackingField);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X21_v3 (System.Action`1<KammelnaResponseModel`1<AuthModel>>)+18]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X21_v3 (System.Action`1<KammelnaResponseModel`1<AuthModel>>)+40]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X21_v3 (System.Action`1<KammelnaResponseModel`1<AuthModel>>)+28]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v113 @ X3_v1 (should have been resolved before IL gen)");
			}
			requestHash = null;
			userKey = null;
			goto IL_0134;
			IL_019a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			AppCheckResult appCheckResult2 = default(AppCheckResult);
			object obj6 = default(object);
			appCheckResult2..ctor(this, (IntPtr)obj6);
			AppCheckManager.GetToken(userKey, requestHash, appCheckResult2);
			return;
			IL_0134:
			object obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 72;
			obj6 = (nint)0 + (nint)3312;
			goto IL_019a;
		}

		internal void <PerformIntegrityCheck>g__GetIntegrityModel|1(string userKey, string serverChallenge)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_003e: Expected I, but got O
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 72;
			object obj2 = (nint)0 + (nint)3312;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			AppCheckResult appCheckResult = default(AppCheckResult);
			appCheckResult..ctor(this, (IntPtr)obj2);
			AppCheckManager.GetToken(userKey, serverChallenge, appCheckResult);
		}

		internal void <PerformIntegrityCheck>b__2(AppIntegrityRequestModel model)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0063: Expected O, but got I4
			while (true)
			{
				string deviceId = UserDeviceIDRecorder.DeviceId;
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
				object obj2 = model + 48;
				obj2 = deviceId;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Platform platform = KUtil.GetPlatform();
				model.<Platform>k__BackingField = (int)platform;
				AppCheckResult appCheckResult = callback;
				IntPtr invoke_impl = ((Delegate)appCheckResult).invoke_impl;
				IntPtr method_code = ((Delegate)appCheckResult).method_code;
				IntPtr method = ((Delegate)appCheckResult).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v75 @ X3_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass40_0
	{
		public Action<bool> successCallback;

		public Action<KammelnaError> errorCallback;

		internal void <BuySubscription>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_006a: Expected O, but got I
			//IL_003c: Expected O, but got I
			//IL_007f: Expected O, but got I
			//IL_008f: Expected O, but got I
			//IL_009f: Expected O, but got I
			if (response.Succeeded)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Boolean>)+30]");
				object obj = 0;
				Action<KammelnaError> action = (Action<KammelnaError>)(object)successCallback;
			}
			else
			{
				Action<KammelnaError> action = errorCallback;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Boolean>)+14]");
				object obj = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6 (System.Action`1<KammelnaError>)+18]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6 (System.Action`1<KammelnaError>)+40]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6 (System.Action`1<KammelnaError>)+28]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v72 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <WaitForRequest>d__131<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public IWebRequest<T> request;

		public Action<KammelnaResponseModel<T>> callback;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <WaitForRequest>d__131(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_01a4: Expected I4, but got I8
			//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Expected O, but got Unknown
			//IL_0050: Expected I4, but got I8
			//IL_0262: Expected I4, but got O
			//IL_0099: Expected O, but got I
			//IL_00af: Expected O, but got I
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected O, but got Unknown
			//IL_00d7: Expected O, but got I4
			//IL_0280: Expected I, but got O
			//IL_0290: Expected O, but got I
			//IL_0112: Expected O, but got I
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_0205: Expected O, but got Unknown
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Expected O, but got Unknown
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Expected O, but got Unknown
			//IL_0246: Expected O, but got I4
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected O, but got Unknown
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected O, but got Unknown
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					IWebRequest<T> webRequest = request;
					if (request != null)
					{
						Action<KammelnaResponseModel<T>> action = callback;
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v8 (Il2CppRgctx<KammelnaRequests+<WaitForRequest>d__131`1>)+8]");
						object obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v8 (Il2CppRgctx<KammelnaRequests+<WaitForRequest>d__131`1>)+8]");
						object obj2 = (nint)0 + (nint)309;
						object obj3 = obj2 & 1;
						bool flag = obj3 == null;
						object obj4 = !flag;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							object obj5 = default(object);
							obj = obj5;
						}
						nint num2 = (nint)webRequest;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v11 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+12E]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v11 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0153;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v11 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+B0]");
						object obj7 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X10_v7-8]");
							if (0 == (nint)obj)
							{
								break;
							}
							obj7 += 16;
							obj6--;
							if ((nint)obj6 != 1)
							{
								continue;
							}
							goto IL_0153;
						}
						object obj8 = obj7 + 3;
						object obj9 = num2 + obj8;
						object obj10 = obj9 + 312;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v253 @ X0_v19] (should have been resolved before IL gen)");
						bool flag2 = callback == null;
						object obj11 = !flag2;
						if (obj11 != null)
						{
							goto IL_0186;
						}
					}
					goto IL_0254;
				}
				goto IL_0262;
			}
			<>1__state = -1;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3107D84");
			object obj12 = this + 24;
			object obj13 = default(object);
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<>1__state = 1;
			return <>1__state == 0;
			IL_0186:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ X21_v5 (System.Action`1<KammelnaResponseModel`1<T>>)+18] (should have been resolved before IL gen)");
			goto IL_0262;
			IL_0262:
			return <>1__state == 0;
			IL_0153:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v237 @ X0_v16] (should have been resolved before IL gen)");
			if (callback != null)
			{
				goto IL_0186;
			}
			goto IL_0254;
			IL_0254:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}
	}

	public static void GetServers(Action<KammelnaResponseModel<ConfigsModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_009f: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2456;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string backendURL = Config.BackendURL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LoadServersRequest loadServersRequest = default(LoadServersRequest);
		loadServersRequest..ctor(backendURL);
		SendRequest((IWebRequest<object>)loadServersRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetAuthTokens(UserCredentials credentials, Action<KammelnaResponseModel<AuthModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_025f: Expected O, but got I
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_028e: Expected O, but got I
		//IL_029f: Expected I, but got O
		//IL_02bd: Expected O, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I
		//IL_01b7: Expected O, but got I
		//IL_01c7: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = credentials;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TokenModel accessToken = Authentication.AccessToken;
		if (accessToken != null && accessToken.IsValid)
		{
			object obj5 = obj4;
			object obj6 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = (nint)0 + (nint)952;
			KammelnaResponseModel<object> kammelnaResponseModel = default(KammelnaResponseModel<object>);
			kammelnaResponseModel..ctor();
			TokenModel accessToken2 = Authentication.AccessToken;
			TokenModel refreshToken = Authentication.RefreshToken;
			object obj8 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = default(object);
			obj9..ctor();
			object obj10 = obj9 + 16;
			obj10 = accessToken2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj11 = obj9 + 24;
			obj11 = refreshToken;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj12 = kammelnaResponseModel + 48;
			obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X23_v4+18]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X23_v4+40]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X23_v4+28]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v115 @ X3_v2 (should have been resolved before IL gen)");
		}
		TokenModel refreshToken2 = Authentication.RefreshToken;
		if (refreshToken2 != null && refreshToken2.IsValid)
		{
			RefreshAuthTokens((Action<KammelnaResponseModel<AuthModel>>)obj4);
			return;
		}
		object obj16 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
		GetLoginChallengeRequest getLoginChallengeRequest = default(GetLoginChallengeRequest);
		getLoginChallengeRequest..ctor((UserCredentials)0);
		object obj17 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)3280;
		AppCheckResult appCheckResult = default(AppCheckResult);
		appCheckResult..ctor(obj2, (IntPtr)obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
		PerformIntegrityCheck(getLoginChallengeRequest, (Action<KammelnaResponseModel<AuthModel>>)0, appCheckResult);
	}

	public static void RefreshAuthTokens(Action<KammelnaResponseModel<AuthModel>> callback, bool forceRefresh = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_008b: Expected O, but got I4
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00e4: Expected O, but got I
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_0292: Expected O, but got I
		//IL_02a3: Expected I, but got O
		//IL_02c1: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01af: Expected O, but got I
		//IL_01bf: Expected O, but got I
		//IL_01cf: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TokenModel accessToken = Authentication.AccessToken;
		if (accessToken != null)
		{
			bool isValid = accessToken.IsValid;
			bool flag = !forceRefresh;
			object obj4 = !flag;
			if (obj4 == null && isValid)
			{
				object obj5 = obj3;
				object obj6 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2936;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj7 = (nint)0 + (nint)952;
				KammelnaResponseModel<object> kammelnaResponseModel = default(KammelnaResponseModel<object>);
				kammelnaResponseModel..ctor();
				TokenModel accessToken2 = Authentication.AccessToken;
				TokenModel refreshToken = Authentication.RefreshToken;
				object obj8 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1480;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = default(object);
				obj9..ctor();
				object obj10 = obj9 + 16;
				obj10 = accessToken2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj11 = obj9 + 24;
				obj11 = refreshToken;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj12 = kammelnaResponseModel + 48;
				obj12 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X23_v4+18]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X23_v4+40]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X23_v4+28]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v114 @ X3_v2 (should have been resolved before IL gen)");
			}
		}
		TokenModel refreshToken2 = Authentication.RefreshToken;
		if (refreshToken2 != null && refreshToken2.IsValid)
		{
			TokenModel refreshToken3 = Authentication.RefreshToken;
			object obj16 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2728;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GetRefreshChallengeRequest getRefreshChallengeRequest = default(GetRefreshChallengeRequest);
			getRefreshChallengeRequest..ctor(refreshToken3.<Token>k__BackingField);
			object obj17 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)3288;
			AppCheckResult appCheckResult = default(AppCheckResult);
			appCheckResult..ctor(obj2, (IntPtr)obj18);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
			PerformIntegrityCheck(getRefreshChallengeRequest, (Action<KammelnaResponseModel<AuthModel>>)0, appCheckResult);
		}
	}

	public static void PerformIntegrityCheck(BaseWebRequest<ServerChallengeResult> request, Action<KammelnaResponseModel<AuthModel>> requestCallback, AppCheckResult callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0111: Expected O, but got I
		//IL_014a: Expected I, but got O
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00cc: Expected O, but got I
		//IL_00dd: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = requestCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (AppCheckManager.IsSupported && AppCheckManager.RequireSignature)
		{
			object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 624;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)3304;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj6);
			SendRequest((IWebRequest<object>)request, action);
		}
		else
		{
			object obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 72;
			object obj8 = (nint)0 + (nint)3312;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			AppCheckResult appCheckResult = default(AppCheckResult);
			appCheckResult..ctor(obj2, (IntPtr)obj8);
			AppCheckManager.GetToken(null, null, appCheckResult);
		}
	}

	public static void Register(string email, string password, string nickname, string phone, string deviceId, Action<KammelnaResponseModel<RegisteredUserModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 4088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RegisterUserRequest registerUserRequest = default(RegisterUserRequest);
		registerUserRequest..ctor(email, nickname, password, phone, deviceId);
		SendRequest((IWebRequest<object>)registerUserRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void RegisterSocial(string email, string nickname, string phone, string firebaseID, SocialPlatform firebasePlatform, string twitterID, string deviceId, Action<KammelnaResponseModel<RegisteredUserModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 4072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RegisterSocialUserRequest registerSocialUserRequest = default(RegisterSocialUserRequest);
		registerSocialUserRequest..ctor(email, nickname, firebaseID, twitterID, firebasePlatform, phone, deviceId);
		SendRequest((IWebRequest<object>)registerSocialUserRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void DeleteAccount(Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(DataRelation) + 1904;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DeleteUserAccountRequest deleteUserAccountRequest = default(DeleteUserAccountRequest);
		deleteUserAccountRequest..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void RegisterInGame(Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_007d: Expected O, but got I
		//IL_00a7: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 4080;
		object obj3 = (nint)0 + (nint)3768;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RegisterUserInGameRequest registerUserInGameRequest = default(RegisterUserInGameRequest);
		registerUserInGameRequest..ctor(currentGame);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void LinkSocialPlatform(SocialPlatform socialPlatform, string firebaseToken, string twitterID, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2152;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LinkSocialPlatformRequest linkSocialPlatformRequest = default(LinkSocialPlatformRequest);
		linkSocialPlatformRequest..ctor(socialPlatform, firebaseToken, twitterID);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void UnlinkSocialPlatform(SocialPlatform socialPlatform, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3840;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnlinkSocialPlatformRequest unlinkSocialPlatformRequest = default(UnlinkSocialPlatformRequest);
		unlinkSocialPlatformRequest..ctor(socialPlatform);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void ForgotPassword(string email, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1208;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ForgetPasswordRequest forgetPasswordRequest = default(ForgetPasswordRequest);
		forgetPasswordRequest..ctor(email);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void ResetPassword(string email, string newPassword, string newPasswordConfirmation, string confirmationCode, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ResetPasswordModel resetPasswordModel = default(ResetPasswordModel);
		resetPasswordModel..ctor();
		object obj2 = typeof(RegisteredWaitHandle) + 848;
		object obj3 = (nint)0 + (nint)3768;
		object obj4 = resetPasswordModel + 16;
		obj4 = email;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = resetPasswordModel + 24;
		obj5 = newPassword;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = resetPasswordModel + 32;
		obj6 = newPasswordConfirmation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = resetPasswordModel + 40;
		obj7 = confirmationCode;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ResetPasswordRequest resetPasswordRequest = default(ResetPasswordRequest);
		resetPasswordRequest..ctor(resetPasswordModel);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void ChangePassword(string newPassword, string oldPassword, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 640;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ChangePasswordRequest changePasswordRequest = default(ChangePasswordRequest);
		changePasswordRequest..ctor(oldPassword, newPassword);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void ForcePasswordChange(ForcePasswordChangeRequestModel model, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1160;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ForcePasswordChangeRequest forcePasswordChangeRequest = default(ForcePasswordChangeRequest);
		forcePasswordChangeRequest..ctor(model);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void ChangeNickName(string newName, Action<KammelnaResponseModel<string>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ChangeNickNameRequest changeNickNameRequest = default(ChangeNickNameRequest);
		changeNickNameRequest..ctor(newName);
		SendRequest((IWebRequest<object>)changeNickNameRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void ChangeEmail(string newEmail, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 608;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ChangeEmailRequest changeEmailRequest = default(ChangeEmailRequest);
		changeEmailRequest..ctor(newEmail);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void UpdateAvatar(byte[] avatarData, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4008;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UploadPersonalAvatarRequest uploadPersonalAvatarRequest = default(UploadPersonalAvatarRequest);
		uploadPersonalAvatarRequest..ctor(avatarData);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void RemoveAvatar(Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 176;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RemovePersonalAvatarRequest removePersonalAvatarRequest = default(RemovePersonalAvatarRequest);
		removePersonalAvatarRequest..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void ActivateTitle(string titleId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2432;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ActivateTitleRequest activateTitleRequest = default(ActivateTitleRequest);
		activateTitleRequest..ctor(titleId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void ChangeBio(string bio, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 592;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ChangeBioRequest changeBioRequest = default(ChangeBioRequest);
		changeBioRequest..ctor(bio);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void LikeUser(long likedUserId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2096;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LikeUserRequest likeUserRequest = default(LikeUserRequest);
		likeUserRequest..ctor(likedUserId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void RegisterFirebaseNotifications(string token, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 4056;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RegisterNotificationTokenRequest registerNotificationTokenRequest = default(RegisterNotificationTokenRequest);
		registerNotificationTokenRequest..ctor(token);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void GetUserFriendlyChallenges(long userId, Action<KammelnaResponseModel<FriendlyChallengeEntryModel[]>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2792;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetUserFriendlyChallenges getUserFriendlyChallenges = default(GetUserFriendlyChallenges);
		getUserFriendlyChallenges..ctor(userId, currentGame);
		SendRequest((IWebRequest<object>)getUserFriendlyChallenges, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetUserProfileGiftsSenders(long userId, Action<KammelnaResponseModel<ProfileGiftsSenderModel[]>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetProfileGiftsSendersListRequest getProfileGiftsSendersListRequest = default(GetProfileGiftsSendersListRequest);
		getProfileGiftsSendersListRequest..ctor(userId);
		SendRequest((IWebRequest<object>)getProfileGiftsSendersListRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetIsPlayerLiked(string userId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2600;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetIsPlayerLikedRequest getIsPlayerLikedRequest = default(GetIsPlayerLikedRequest);
		getIsPlayerLikedRequest..ctor(userId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void GetPersonalStatsConfigs(Games game, Action<KammelnaResponseModel<List<PersonalReportTypeConfig>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetPersonalStatsConfigs getPersonalStatsConfigs = default(GetPersonalStatsConfigs);
		getPersonalStatsConfigs..ctor(game);
		SendRequest((IWebRequest<object>)getPersonalStatsConfigs, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetWeeklyPersonalizedStats(Games game, Action<KammelnaResponseModel<PersonalizedStatReport>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetWeeklyPersonalizedStatsList getWeeklyPersonalizedStatsList = default(GetWeeklyPersonalizedStatsList);
		getWeeklyPersonalizedStatsList..ctor(game);
		SendRequest((IWebRequest<object>)getWeeklyPersonalizedStatsList, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetMonthlyPersonalizedStats(Games game, Action<KammelnaResponseModel<PersonalizedStatReport>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetMonthlyPersonalizedStatsList getMonthlyPersonalizedStatsList = default(GetMonthlyPersonalizedStatsList);
		getMonthlyPersonalizedStatsList..ctor(game);
		SendRequest((IWebRequest<object>)getMonthlyPersonalizedStatsList, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetStoreHomePage(Action<KammelnaResponseModel<StoreHomePageViewModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetStoreHomePageRequest getStoreHomePageRequest = default(GetStoreHomePageRequest);
		getStoreHomePageRequest..ctor();
		SendRequest((IWebRequest<object>)getStoreHomePageRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void BuyItem(int itemId, Action<KammelnaResponseModel<BuyItemResponseModel>> callback, IClientContext clientContext, int? templateId, long[] recipients)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BuyItemRequest buyItemRequest = default(BuyItemRequest);
		buyItemRequest..ctor(itemId, templateId, recipients, clientContext);
		SendRequest((IWebRequest<object>)buyItemRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void ResetDefaultItem(ItemCategory category, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 816;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ResetDefaultItemRequest resetDefaultItemRequest = default(ResetDefaultItemRequest);
		resetDefaultItemRequest..ctor(category);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void SetItemAsDefault(int userItemId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 4064;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SetDefaultItemRequest setDefaultItemRequest = default(SetDefaultItemRequest);
		setDefaultItemRequest..ctor(userItemId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void SetFeaturedSlotRequest(string slotId, int levelId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 4072;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SetFeaturedSlotRequest setFeaturedSlotRequest = default(SetFeaturedSlotRequest);
		setFeaturedSlotRequest..ctor(slotId, levelId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void SetFeaturedSlotRequest(UserAchievementModel trophy, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 4072;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SetFeaturedSlotRequest setFeaturedSlotRequest = default(SetFeaturedSlotRequest);
		setFeaturedSlotRequest..ctor(trophy.<gameAchievementId>k__BackingField, trophy.<levelId>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void ResetFeaturedSlot(Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 824;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ResetFeaturedSlotRequest resetFeaturedSlotRequest = default(ResetFeaturedSlotRequest);
		resetFeaturedSlotRequest..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void BuyBomb(GiftBombType giftBombType, int currencyPerPlayer, int playersCount, string message, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3768;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BuyGiftBombRequest buyGiftBombRequest = default(BuyGiftBombRequest);
		buyGiftBombRequest..ctor(giftBombType, currencyPerPlayer, playersCount, message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void GetAppStoreDiscount(int productListingId, Action<KammelnaResponseModel<AppStorePromotionalOffer>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetAppStoreDiscountRequest getAppStoreDiscountRequest = default(GetAppStoreDiscountRequest);
		getAppStoreDiscountRequest..ctor(productListingId);
		SendRequest((IWebRequest<object>)getAppStoreDiscountRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void BuyProfileGift(long giftId, string recipientId, string message, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3800;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BuyProfileGiftRequest buyProfileGiftRequest = default(BuyProfileGiftRequest);
		buyProfileGiftRequest..ctor(giftId, recipientId, message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void CheckAppStoreIntroductoryOfferEligibility(string receipt, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 944;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CheckAppStoreIntroductoryOfferEligibilityRequest checkAppStoreIntroductoryOfferEligibilityRequest = default(CheckAppStoreIntroductoryOfferEligibilityRequest);
		checkAppStoreIntroductoryOfferEligibilityRequest..ctor(receipt);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void BuyConsumable(SalesChannel channel, string receipt, string transactionId, GiftInfo giftInfo, Action<long> successCallback, Action<KammelnaError> errorCallback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00be: Expected O, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_01d2: Expected O, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_013a: Expected O, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_017a: Expected O, but got I4
		//IL_01fd: Expected I, but got O
		//IL_0196: Expected I8, but got O
		//IL_01a2: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.IOAsyncCallback) + 2328;
		object obj4 = obj2 + 16;
		obj4 = successCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = errorCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IapReceiptModel iapReceiptModel = default(IapReceiptModel);
		iapReceiptModel..ctor();
		object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3744;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 560;
		object obj8 = (nint)0 + (nint)3296;
		iapReceiptModel.<Channel>k__BackingField = channel;
		object obj9 = iapReceiptModel + 24;
		obj9 = receipt;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = iapReceiptModel + 32;
		string text = default(string);
		obj10 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text2;
		if (giftInfo != null)
		{
			object obj11 = (nint)0 + (nint)3136;
			text = (string)obj11;
			int? num = giftInfo.<RecipientId>k__BackingField;
			object obj12 = (??)num & 1;
			bool flag = obj12 == null;
			long? <RecipientID>k__BackingField = (long?)(object)0;
			if (!flag)
			{
				long value = (object?)num >> 32;
				object obj13 = (nint)0 + (nint)3184;
				text = (string)obj13;
				long? num2 = value;
				<RecipientID>k__BackingField = num2;
			}
			iapReceiptModel.<RecipientID>k__BackingField = <RecipientID>k__BackingField;
			text2 = giftInfo.<Message>k__BackingField;
		}
		else
		{
			iapReceiptModel.<RecipientID>k__BackingField = (long?)(object)0;
			_ = 0;
			text2 = null;
		}
		object obj14 = iapReceiptModel + 56;
		obj14 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BuyConsumableProductRequest buyConsumableProductRequest = default(BuyConsumableProductRequest);
		buyConsumableProductRequest..ctor(iapReceiptModel);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj8);
		SendRequest(buyConsumableProductRequest, action);
	}

	public static void BuySubscription(SalesChannel channel, string receipt, string transactionId, Action<bool> successCallback, Action<KammelnaError> errorCallback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00be: Expected O, but got I
		//IL_00ca: Expected O, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0153: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.IOAsyncCallback) + 2328;
		object obj4 = obj2 + 16;
		obj4 = successCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = errorCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IapReceiptModel iapReceiptModel = default(IapReceiptModel);
		iapReceiptModel..ctor();
		object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3808;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj8 = (nint)0 + (nint)3320;
		object obj9 = (nint)0 + (nint)3768;
		iapReceiptModel.<Channel>k__BackingField = channel;
		object obj10 = iapReceiptModel + 24;
		obj10 = receipt;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj11 = iapReceiptModel + 32;
		obj11 = transactionId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BuySubscriptionRequest buySubscriptionRequest = default(BuySubscriptionRequest);
		buySubscriptionRequest..ctor(iapReceiptModel);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void ActivateCode(string code, Action<KammelnaResponseModel<CodeActivationViewModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 2400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ActivateCodeRequest activateCodeRequest = default(ActivateCodeRequest);
		activateCodeRequest..ctor(code);
		SendRequest((IWebRequest<object>)activateCodeRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void TransferCurrency(GiftInfo giftInfo, int amount, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1896;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TransferCurrencyRequest transferCurrencyRequest = default(TransferCurrencyRequest);
		transferCurrencyRequest..ctor(giftInfo, amount);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void GetTransferFee(Action<KammelnaResponseModel<TransferFeesModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetTransferFeeRequest getTransferFeeRequest = default(GetTransferFeeRequest);
		getTransferFeeRequest..ctor();
		SendRequest((IWebRequest<object>)getTransferFeeRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void ConvertCoinsToSubscription(int currency, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3024;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ConvertCurrencyToSubscriptionRequest convertCurrencyToSubscriptionRequest = default(ConvertCurrencyToSubscriptionRequest);
		convertCurrencyToSubscriptionRequest..ctor(currency);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void BuyStcItem(string mobileNumber, long productListingId, int? recipientId, Action<KammelnaResponseModel<StcPaymentAuthorizeResponse>> callback)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_004b: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_001f: Expected I8, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3408;
		int? num = default(int?);
		object obj2 = (??)num & 1;
		long? recipientId2;
		if (obj2 != null)
		{
			object obj3 = (nint)0 + (nint)3184;
			long value = (object?)num >> 32;
			long? num2 = value;
			recipientId2 = num2;
		}
		else
		{
			long value = productListingId;
			recipientId2 = (long?)(object)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CreateStcPayPaymentRequest createStcPayPaymentRequest = default(CreateStcPayPaymentRequest);
		createStcPayPaymentRequest..ctor(mobileNumber, productListingId, recipientId2);
		SendRequest((IWebRequest<object>)createStcPayPaymentRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetReferralsId(Action<KammelnaResponseModel<string>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetReferralCodeRequest getReferralCodeRequest = default(GetReferralCodeRequest);
		getReferralCodeRequest..ctor();
		SendRequest((IWebRequest<object>)getReferralCodeRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetReferralsHistory(Action<KammelnaResponseModel<List<UserReferralModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetReferralHistoryRequest getReferralHistoryRequest = default(GetReferralHistoryRequest);
		getReferralHistoryRequest..ctor();
		SendRequest((IWebRequest<object>)getReferralHistoryRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void SendReferralReport(string referralCode, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 648;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ReportReferralRequest reportReferralRequest = default(ReportReferralRequest);
		reportReferralRequest..ctor(referralCode);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void SendClaimReward(int rewardId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1072;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ClaimReferralRewardRequest claimReferralRewardRequest = default(ClaimReferralRewardRequest);
		claimReferralRewardRequest..ctor(rewardId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void GetReferralRewards(Action<KammelnaResponseModel<List<UserReferralRewardModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetReferralRewardRequest getReferralRewardRequest = default(GetReferralRewardRequest);
		getReferralRewardRequest..ctor();
		SendRequest((IWebRequest<object>)getReferralRewardRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void SendClaimAchievement(UserAchievementModel ua, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1064;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ClaimAchievementRequest claimAchievementRequest = default(ClaimAchievementRequest);
		claimAchievementRequest..ctor(ua.<gameAchievementId>k__BackingField, ua.<levelId>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void GetHints(Action<KammelnaResponseModel<List<InGameHintModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetHintsRequest getHintsRequest = default(GetHintsRequest);
		getHintsRequest..ctor();
		SendRequest((IWebRequest<object>)getHintsRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetUserFeedItems(Action<KammelnaResponseModel<List<UserFeedItem>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetUserFeedItems getUserFeedItems = default(GetUserFeedItems);
		getUserFeedItems..ctor();
		SendRequest((IWebRequest<object>)getUserFeedItems, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void DeleteReadFeedItems(long lastReadFeedId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(DataRelation) + 1896;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DeleteReadUserFeedItems deleteReadUserFeedItems = default(DeleteReadUserFeedItems);
		deleteReadUserFeedItems..ctor(lastReadFeedId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void SendReport(SupportTicketRequestModel model, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 3472;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SendSupportTicketRequest sendSupportTicketRequest = default(SendSupportTicketRequest);
		sendSupportTicketRequest..ctor(model);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void SendTrollingReport(TrollingReportModel model, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 3480;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SendTrollingRequest sendTrollingRequest = default(SendTrollingRequest);
		sendTrollingRequest..ctor(model);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void SendPlayerReport(PlayerReportRequestModel model, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 3464;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SendPlayerReportRequest sendPlayerReportRequest = default(SendPlayerReportRequest);
		sendPlayerReportRequest..ctor(model);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void PredictMatch(int matchId, int homeTeamScore, int awayTeamScore, Action<KammelnaResponseModel<UserMatchPredictionModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PredictMatchResultRequest predictMatchResultRequest = default(PredictMatchResultRequest);
		predictMatchResultRequest..ctor(matchId, homeTeamScore, awayTeamScore);
		SendRequest((IWebRequest<object>)predictMatchResultRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetMatchesHistory(int page, Action<KammelnaResponseModel<List<UserMatchPredictionModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetPredictionHistoryRequest getPredictionHistoryRequest = default(GetPredictionHistoryRequest);
		getPredictionHistoryRequest..ctor(page);
		SendRequest((IWebRequest<object>)getPredictionHistoryRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetMyPredictionRanking(Action<KammelnaResponseModel<SeasonalPredictionRanking>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetPredictionRankingRequest getPredictionRankingRequest = default(GetPredictionRankingRequest);
		getPredictionRankingRequest..ctor();
		SendRequest((IWebRequest<object>)getPredictionRankingRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetPredictionSeason(Action<KammelnaResponseModel<PredictionSeasonModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetPredictionSeasonRequest getPredictionSeasonRequest = default(GetPredictionSeasonRequest);
		getPredictionSeasonRequest..ctor();
		SendRequest((IWebRequest<object>)getPredictionSeasonRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void FindFriend(string codeOrEmail, Action<KammelnaResponseModel<PlayerProfileModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FindFriendRequest findFriendRequest = default(FindFriendRequest);
		findFriendRequest..ctor(codeOrEmail);
		SendRequest((IWebRequest<object>)findFriendRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetFriendInviteToken(Action<KammelnaResponseModel<string>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetFriendInviteTokenRequest getFriendInviteTokenRequest = default(GetFriendInviteTokenRequest);
		getFriendInviteTokenRequest..ctor();
		SendRequest((IWebRequest<object>)getFriendInviteTokenRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void AddFriendVerified(string friendCode, string token, Action<KammelnaResponseModel<PlayerProfileModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = typeof(UsageHint) + 968;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		VerifiedAddFriendRequest verifiedAddFriendRequest = default(VerifiedAddFriendRequest);
		verifiedAddFriendRequest..ctor(friendCode, token, currentGame);
		SendRequest((IWebRequest<object>)verifiedAddFriendRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetFriendsList(Action<KammelnaResponseModel<List<Friend>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetFriendsListRequest getFriendsListRequest = default(GetFriendsListRequest);
		getFriendsListRequest..ctor();
		SendRequest((IWebRequest<object>)getFriendsListRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetFriendsLeaderboardList(Action<KammelnaResponseModel<List<FriendLeaderboardModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetFriendsLeaderRequest getFriendsLeaderRequest = default(GetFriendsLeaderRequest);
		getFriendsLeaderRequest..ctor();
		SendRequest((IWebRequest<object>)getFriendsLeaderRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void SendFriendRequest(long friendID, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2976;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AddFriendRequest addFriendRequest = default(AddFriendRequest);
		addFriendRequest..ctor(friendID);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void ForceFriendRequest(long friendID, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1152;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ForceAddFriendRequest forceAddFriendRequest = default(ForceAddFriendRequest);
		forceAddFriendRequest..ctor(friendID);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void AcceptFriendRequest(long friendID, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2168;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AcceptFriendRequest acceptFriendRequest = default(AcceptFriendRequest);
		acceptFriendRequest..ctor(friendID);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void RemoveFriend(long friendID, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 168;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RemoveFriendRequest removeFriendRequest = default(RemoveFriendRequest);
		removeFriendRequest..ctor(friendID);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void BlockUser(long friendID, Action<KammelnaResponseModel<bool>> callback, bool block = true)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3072;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BlockFriendRequest blockFriendRequest = default(BlockFriendRequest);
		blockFriendRequest..ctor(friendID);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void UnblockUser(long friendID, Action<KammelnaResponseModel<bool>> callback, bool block = true)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3280;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnblockFriendRequest unblockFriendRequest = default(UnblockFriendRequest);
		unblockFriendRequest..ctor(friendID);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void MuteUser(BanRequestModel requestModel, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 1864;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MutePlayerRequest mutePlayerRequest = default(MutePlayerRequest);
		mutePlayerRequest..ctor(requestModel);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void BanUser(BanRequestModel requestModel, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2096;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BanPlayerRequest banPlayerRequest = default(BanPlayerRequest);
		banPlayerRequest..ctor(requestModel);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void GetBanInfo(long userId, Action<KammelnaResponseModel<BanInfoModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetBanStatusRequest getBanStatusRequest = default(GetBanStatusRequest);
		getBanStatusRequest..ctor(userId);
		SendRequest((IWebRequest<object>)getBanStatusRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void UnbanUser(long userId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3272;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnbanPlayerRequest unbanPlayerRequest = default(UnbanPlayerRequest);
		unbanPlayerRequest..ctor(userId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void RemoveBio(int userId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003d: Expected I8, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 1096;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ModeratorRemovePlayerBioRequest moderatorRemovePlayerBioRequest = default(ModeratorRemovePlayerBioRequest);
		moderatorRemovePlayerBioRequest..ctor(userId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void RemoveAvatar(int userId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003d: Expected I8, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 1088;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ModeratorRemovePlayerAvatarRequest moderatorRemovePlayerAvatarRequest = default(ModeratorRemovePlayerAvatarRequest);
		moderatorRemovePlayerAvatarRequest..ctor(userId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void PunishBeggar(BanRequestModel requestModel, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 2504;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PunishCurrencyBeggarRequest punishCurrencyBeggarRequest = default(PunishCurrencyBeggarRequest);
		punishCurrencyBeggarRequest..ctor(requestModel);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void SyncMessages(long lastUpdatedAt, Action<KammelnaResponseModel<List<PrivateMessageModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SyncMessagesRequest syncMessagesRequest = default(SyncMessagesRequest);
		syncMessagesRequest..ctor(lastUpdatedAt);
		SendRequest((IWebRequest<object>)syncMessagesRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void CreateTournament(TournamentCreationModel tournament, Action<KammelnaResponseModel<Tournament>> callback)
	{
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_015e: Expected O, but got I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_009a: Expected O, but got I4
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0103: Expected O, but got I4
		Action<KammelnaResponseModel<Tournament>> action2;
		Action<KammelnaResponseModel<Tournament>> action3;
		if (tournament.type != TournamentType.Public)
		{
			bool flag = tournament.type != TournamentType.Private;
			Action<KammelnaResponseModel<Tournament>> action = callback;
			action2 = callback;
			if (!flag)
			{
				goto IL_005c;
			}
		}
		else
		{
			object obj = typeof(RegisteredWaitHandle) + 56;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RemoteConfigModel current = RemoteConfig.Current;
			TournamentsSection <Tournaments>k__BackingField = current.<Tournaments>k__BackingField;
			bool canCreateTournament = <Tournaments>k__BackingField.<Public>k__BackingField.CanCreateTournament;
			bool flag3 = !canCreateTournament;
			action3 = null;
			if (flag3)
			{
				goto IL_0236;
			}
			bool flag4 = tournament.type == TournamentType.Private;
			Action<KammelnaResponseModel<Tournament>> action = null;
			action2 = null;
			if (flag4)
			{
				goto IL_005c;
			}
		}
		goto IL_01f7;
		IL_01f7:
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CreateTournamentRequest createTournamentRequest = default(CreateTournamentRequest);
		createTournamentRequest..ctor(tournament);
		SendRequest((IWebRequest<object>)createTournamentRequest, (Action<KammelnaResponseModel<object>>)callback);
		return;
		IL_0236:
		object obj5 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KammelnaResponseModel<object> kammelnaResponseModel = default(KammelnaResponseModel<object>);
		kammelnaResponseModel..ctor();
		kammelnaResponseModel.<Error>k__BackingField = KammelnaError.CreationLocked;
		Actions.SafeInvoke((Action<object>)callback, kammelnaResponseModel);
		return;
		IL_005c:
		object obj6 = typeof(RegisteredWaitHandle) + 56;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current2 = RemoteConfig.Current;
		TournamentsSection <Tournaments>k__BackingField2 = current2.<Tournaments>k__BackingField;
		bool canCreateTournament2 = <Tournaments>k__BackingField2.<Private>k__BackingField.CanCreateTournament;
		bool flag6 = !canCreateTournament2;
		object obj9 = !flag6;
		action2 = null;
		if (obj9 != null)
		{
			goto IL_01f7;
		}
		action3 = null;
		goto IL_0236;
	}

	public static void RedeemMarketingGrant(string token, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3648;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RedeemMarketingGrantRequest redeemMarketingGrantRequest = default(RedeemMarketingGrantRequest);
		redeemMarketingGrantRequest..ctor(token);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void GetSportTeams(Action<KammelnaResponseModel<List<SportTeam>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetSportTeamsRequest getSportTeamsRequest = default(GetSportTeamsRequest);
		getSportTeamsRequest..ctor();
		SendRequest((IWebRequest<object>)getSportTeamsRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void CreateClan(ClanCreationModel model, Action<KammelnaResponseModel<int>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CreateClanRequest createClanRequest = default(CreateClanRequest);
		createClanRequest..ctor(model);
		SendRequest(createClanRequest, callback);
	}

	public static void EditClan(EditClanModel model, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(DataRelation) + 2936;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EditClanRequest editClanRequest = default(EditClanRequest);
		editClanRequest..ctor(model);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void GetClans(string query, Action<KammelnaResponseModel<List<ClanCardModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ClanListRequest clanListRequest = default(ClanListRequest);
		clanListRequest..ctor(query);
		SendRequest((IWebRequest<object>)clanListRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetClan(int clanId, Action<KammelnaResponseModel<ClanViewModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ClanInfoRequest clanInfoRequest = default(ClanInfoRequest);
		clanInfoRequest..ctor(clanId);
		SendRequest((IWebRequest<object>)clanInfoRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetMyPendingMemberships(Action<KammelnaResponseModel<List<UserPendingMembershipModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetMyPendingMembershipsRequest getMyPendingMembershipsRequest = default(GetMyPendingMembershipsRequest);
		getMyPendingMembershipsRequest..ctor();
		SendRequest((IWebRequest<object>)getMyPendingMembershipsRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetClanJoinRequests(Action<KammelnaResponseModel<List<ClanPendingMembershipViewModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetClanJoinRequestsRequest getClanJoinRequestsRequest = default(GetClanJoinRequestsRequest);
		getClanJoinRequestsRequest..ctor();
		SendRequest((IWebRequest<object>)getClanJoinRequestsRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void RequestJoinClan(int clanId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 744;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RequestJoinClanRequest requestJoinClanRequest = default(RequestJoinClanRequest);
		requestJoinClanRequest..ctor(clanId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void AcceptClanRequest(long userId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2160;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AcceptClanRequestRequest acceptClanRequestRequest = default(AcceptClanRequestRequest);
		acceptClanRequestRequest..ctor(userId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void RefuseClanRequest(long userId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3912;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RefuseClanRequestRequest refuseClanRequestRequest = default(RefuseClanRequestRequest);
		refuseClanRequestRequest..ctor(userId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void InviteUserToClan(long userId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		object obj = typeof(System.IOAsyncCallback) + 3888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InviteUserModel inviteUserModel = default(InviteUserModel);
		inviteUserModel..ctor();
		object obj2 = typeof(System.IOAsyncCallback) + 3896;
		object obj3 = (nint)0 + (nint)3768;
		inviteUserModel.TargetUserId = userId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InviteUserRequest inviteUserRequest = default(InviteUserRequest);
		inviteUserRequest..ctor(inviteUserModel);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void AcceptClanInvite(int clanId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2176;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AcceptInviteRequest acceptInviteRequest = default(AcceptInviteRequest);
		acceptInviteRequest..ctor(clanId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void IgnoreClanInvite(int clanId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.IOAsyncCallback) + 2408;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IgnoreInviteRequest ignoreInviteRequest = default(IgnoreInviteRequest);
		ignoreInviteRequest..ctor(clanId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void CancelJoinRequest(int clanId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 176;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CancelJoinRequestRequest cancelJoinRequestRequest = default(CancelJoinRequestRequest);
		cancelJoinRequestRequest..ctor(clanId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void LeaveClanRequest(Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1784;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LeaveClanRequest leaveClanRequest = default(LeaveClanRequest);
		leaveClanRequest..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void KickClanMember(long userId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KickMemberModel kickMemberModel = default(KickMemberModel);
		kickMemberModel..ctor();
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1360;
		object obj3 = (nint)0 + (nint)3768;
		kickMemberModel.TargetUserId = userId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KickClanMemberRequest kickClanMemberRequest = default(KickClanMemberRequest);
		kickClanMemberRequest..ctor(kickMemberModel);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void TransferClanOwnership(long newOwnerId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TransferOwnershipModel transferOwnershipModel = default(TransferOwnershipModel);
		transferOwnershipModel..ctor();
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1944;
		object obj3 = (nint)0 + (nint)3768;
		transferOwnershipModel.NewOwnerId = newOwnerId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TransferOwnershipRequest transferOwnershipRequest = default(TransferOwnershipRequest);
		transferOwnershipRequest..ctor(transferOwnershipModel);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void EditMembershipRequest(EditClanMembershipModel model, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(DataRelation) + 2920;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EditClanMembershipRequest editClanMembershipRequest = default(EditClanMembershipRequest);
		editClanMembershipRequest..ctor(model);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void GetClanLogoElements(Action<KammelnaResponseModel<List<ClanLogoElementViewModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetLogoElementsRequest getLogoElementsRequest = default(GetLogoElementsRequest);
		getLogoElementsRequest..ctor();
		SendRequest((IWebRequest<object>)getLogoElementsRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetClanEmblemTiers(Action<KammelnaResponseModel<List<ClanEmblemTierModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetEmblemTiersRequest getEmblemTiersRequest = default(GetEmblemTiersRequest);
		getEmblemTiersRequest..ctor();
		SendRequest((IWebRequest<object>)getEmblemTiersRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void BuyEmblemTier(Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3752;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BuyEmblemTierRequest buyEmblemTierRequest = default(BuyEmblemTierRequest);
		buyEmblemTierRequest..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void ActivateEmblemTier(int tier, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2416;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ActivateEmblemTierRequest activateEmblemTierRequest = default(ActivateEmblemTierRequest);
		activateEmblemTierRequest..ctor(tier);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void DepositToClanVault(int amount, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(DataRelation) + 2016;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DepositToVaultRequest depositToVaultRequest = default(DepositToVaultRequest);
		depositToVaultRequest..ctor(amount);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void GetClanVaultTransactions(int limit, Action<KammelnaResponseModel<List<ClanVaultTransactionModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetVaultTransactionsRequest getVaultTransactionsRequest = default(GetVaultTransactionsRequest);
		getVaultTransactionsRequest..ctor(limit);
		SendRequest((IWebRequest<object>)getVaultTransactionsRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetClanVaultSupportRequestSupporters(long feedId, Action<KammelnaResponseModel<List<ClanVaultSupporterModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetVaultSupportRequestSupportersRequest getVaultSupportRequestSupportersRequest = default(GetVaultSupportRequestSupportersRequest);
		getVaultSupportRequestSupportersRequest..ctor(feedId);
		SendRequest((IWebRequest<object>)getVaultSupportRequestSupportersRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void SetClanAutoRenewal(bool enabled, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 4048;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SetAutoRenewalRequest setAutoRenewalRequest = default(SetAutoRenewalRequest);
		setAutoRenewalRequest..ctor(enabled);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void ManualRenewClanSubscription(Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3584;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ManualRenewRequest manualRenewRequest = default(ManualRenewRequest);
		manualRenewRequest..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void CreateClanSupportRequest(Action<KammelnaResponseModel<int>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CreateSupportRequestRequest createSupportRequestRequest = default(CreateSupportRequestRequest);
		createSupportRequestRequest..ctor();
		SendRequest(createSupportRequestRequest, callback);
	}

	public static void CreateClanVaultSupportRequest(int targetAmount, int durationDays, Action<KammelnaResponseModel<long>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CreateVaultSupportRequestRequest createVaultSupportRequestRequest = default(CreateVaultSupportRequestRequest);
		createVaultSupportRequestRequest..ctor(targetAmount, durationDays);
		SendRequest(createVaultSupportRequestRequest, callback);
	}

	public static void CreateClanAnnouncement(string title, string message, bool pinOnCreate, Action<KammelnaResponseModel<long>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CreateAnnouncementRequest createAnnouncementRequest = default(CreateAnnouncementRequest);
		createAnnouncementRequest..ctor(title, message, pinOnCreate);
		SendRequest(createAnnouncementRequest, callback);
	}

	public static void GetClanFeed(int limit, long? beforeId, Action<KammelnaResponseModel<List<ClanFeedModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetClanFeedRequest getClanFeedRequest = default(GetClanFeedRequest);
		getClanFeedRequest..ctor(limit, beforeId);
		IntPtr intPtr = default(IntPtr);
		SendRequest((IWebRequest<object>)getClanFeedRequest, (Action<KammelnaResponseModel<object>>)(nint)intPtr);
	}

	public static void PinClanFeed(long feedId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 600;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PinClanFeedRequest pinClanFeedRequest = default(PinClanFeedRequest);
		pinClanFeedRequest..ctor(feedId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void UnpinClanFeed(long feedId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3888;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnpinClanFeedRequest unpinClanFeedRequest = default(UnpinClanFeedRequest);
		unpinClanFeedRequest..ctor(feedId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void DeleteClanAnnouncement(long feedId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(DataRelation) + 1888;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DeleteAnnouncementRequest deleteAnnouncementRequest = default(DeleteAnnouncementRequest);
		deleteAnnouncementRequest..ctor(feedId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void LikeClanFeed(long feedId, Action<KammelnaResponseModel<ClanFeedLikeChangeModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LikeClanFeedRequest likeClanFeedRequest = default(LikeClanFeedRequest);
		likeClanFeedRequest..ctor(feedId);
		SendRequest((IWebRequest<object>)likeClanFeedRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void UnlikeClanFeed(long feedId, Action<KammelnaResponseModel<ClanFeedLikeChangeModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnlikeClanFeedRequest unlikeClanFeedRequest = default(UnlikeClanFeedRequest);
		unlikeClanFeedRequest..ctor(feedId);
		SendRequest((IWebRequest<object>)unlikeClanFeedRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void MuteClanMember(long userId, int durationSeconds, string reason, Action<KammelnaResponseModel<ClanChatMuteModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 1856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MuteClanMemberRequest muteClanMemberRequest = default(MuteClanMemberRequest);
		muteClanMemberRequest..ctor(userId, durationSeconds, reason);
		SendRequest((IWebRequest<object>)muteClanMemberRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void UnmuteClanMember(long userId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3872;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnmuteClanMemberRequest unmuteClanMemberRequest = default(UnmuteClanMemberRequest);
		unmuteClanMemberRequest..ctor(userId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void GetClanMutes(Action<KammelnaResponseModel<List<ClanChatMuteModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetClanMutesRequest getClanMutesRequest = default(GetClanMutesRequest);
		getClanMutesRequest..ctor();
		SendRequest((IWebRequest<object>)getClanMutesRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetClanInternalLeaderboard(InternalLeaderboardKind kind, Games game, int clanId, Action<KammelnaResponseModel<List<InternalLeaderboardEntryModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetInternalLeaderboardRequest getInternalLeaderboardRequest = default(GetInternalLeaderboardRequest);
		getInternalLeaderboardRequest..ctor(kind, game, clanId);
		SendRequest((IWebRequest<object>)getInternalLeaderboardRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetClanInterClanLeaderboard(DateTime firstDayOfTheMonth, Games game, Action<KammelnaResponseModel<List<InterClanLeaderboardEntryModel>>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetInterClanLeaderboardRequest getInterClanLeaderboardRequest = default(GetInterClanLeaderboardRequest);
		getInterClanLeaderboardRequest..ctor(firstDayOfTheMonth, game);
		SendRequest((IWebRequest<object>)getInterClanLeaderboardRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetClanLanding(Games game, Action<KammelnaResponseModel<ClanLandingResponseModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetClanLandingRequest getClanLandingRequest = default(GetClanLandingRequest);
		getClanLandingRequest..ctor(game);
		SendRequest((IWebRequest<object>)getClanLandingRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void SearchClans(ClanSearchRequestModel model, Action<KammelnaResponseModel<ClanSearchResponse>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SearchClansRequest searchClansRequest = default(SearchClansRequest);
		searchClansRequest..ctor(model);
		SendRequest((IWebRequest<object>)searchClansRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void RollbackClan(int clanId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 1368;
		object obj2 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RollbackClanRequest rollbackClanRequest = default(RollbackClanRequest);
		rollbackClanRequest..ctor(clanId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FF24");
	}

	public static void GetRollbackPrompt(Action<KammelnaResponseModel<RollbackInfoModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GetRollbackPromptRequest getRollbackPromptRequest = default(GetRollbackPromptRequest);
		getRollbackPromptRequest..ctor();
		SendRequest((IWebRequest<object>)getRollbackPromptRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	public static void GetSuggestedOwner(Action<KammelnaResponseModel<ClanMemberViewModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SuggestedOwnerRequest suggestedOwnerRequest = default(SuggestedOwnerRequest);
		suggestedOwnerRequest..ctor();
		SendRequest((IWebRequest<object>)suggestedOwnerRequest, (Action<KammelnaResponseModel<object>>)callback);
	}

	private static void SendRequest<T>(IWebRequest<T> request, Action<KammelnaResponseModel<T>> callback)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy permanentInstance = CoroutineDummy.PermanentInstance;
		IEnumerator routine = WaitForRequest(request, callback);
		Coroutine coroutine = permanentInstance.StartCoroutine(routine);
	}

	public static void Send<T>(IWebRequest<T> request, Action<KammelnaResponseModel<T>> callback)
	{
		SendRequest(request, callback);
	}

	private static IEnumerator WaitForRequest<T>(IWebRequest<T> request, Action<KammelnaResponseModel<T>> callback)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00bf: Expected I4, but got O
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00e2: Expected I4, but got O
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IEnumerator enumerator = default(IEnumerator);
		((<WaitForRequest>d__131<T>)enumerator)..ctor(0);
		if (enumerator != null)
		{
			<WaitForRequest>d__131<T> <WaitForRequest>d__ = (<WaitForRequest>d__131<T>)(enumerator + 32);
			<WaitForRequest>d__ = (<WaitForRequest>d__131<T>)(object)request;
			<WaitForRequest>d__..ctor((int)request);
			<WaitForRequest>d__131<T> <WaitForRequest>d__2 = (<WaitForRequest>d__131<T>)(enumerator + 40);
			<WaitForRequest>d__2 = (<WaitForRequest>d__131<T>)(object)callback;
			<WaitForRequest>d__2..ctor((int)callback);
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}
}
