using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Text;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using SFSLitJson;
using Server.Models;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.UI;
using UnityEngine.Networking;
using UnityEngine.Purchasing.Telemetry;

public static class WebRequest
{
	private sealed class <>c__DisplayClass13_0<T>
	{
		public ApiResponseModel<T> response;

		public Action<ApiResponseModel<T>> callback;

		internal void <WaitForRequest>b__0()
		{
			//IL_0017: Expected I, but got O
			//IL_0027: Expected O, but got I
			//IL_0037: Expected O, but got I
			ApiResponseModel<T> apiResponseModel = response;
			nint num = (nint)apiResponseModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<ApiResponseModel`1<T>>)+178]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<ApiResponseModel`1<T>>)+180]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void <WaitForRequest>b__1()
		{
			//IL_0029: Expected O, but got I
			//IL_0039: Expected O, but got I
			//IL_0049: Expected O, but got I
			Action<ApiResponseModel<T>> action = callback;
			ApiResponseModel<T> apiResponseModel = response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<ApiResponseModel`1<T>>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<ApiResponseModel`1<T>>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<ApiResponseModel`1<T>>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public UnityWebRequest request;

		internal void <SetRequestHeaders>b__0(KeyValuePair<string, string> pair)
		{
			//IL_0018: Expected O, but got I
			IntPtr intPtr = default(IntPtr);
			request.SetRequestHeader((string)pair, (string)(nint)intPtr);
		}
	}

	private sealed class <WaitForRequest>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public UnityWebRequest request;

		public Action<ApiResponseModel> callback;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <WaitForRequest>d__12(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00ff: Expected I4, but got I8
			//IL_0179: Expected I4, but got O
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected O, but got Unknown
			//IL_0036: Expected I4, but got I8
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			if (<>1__state != 0)
			{
				if (<>1__state != 1)
				{
					goto IL_0198;
				}
				<>1__state = -1;
				object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				ApiResponseModel apiResponseModel = default(ApiResponseModel);
				apiResponseModel..ctor(request);
				if (request != null)
				{
					request.Dispose();
					if (apiResponseModel != null)
					{
						apiResponseModel.ParseResponse();
						Action<ApiResponseModel> action = callback;
						if (callback != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ X8_v11 (System.Action`1<ApiResponseModel>)+18] (should have been resolved before IL gen)");
							goto IL_0198;
						}
					}
				}
			}
			else
			{
				<>1__state = -1;
				if (request != null)
				{
					UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = request.SendWebRequest();
					object obj2 = this + 24;
					obj2 = unityWebRequestAsyncOperation;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					return <>1__state == 0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0198:
			return <>1__state == 0;
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
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)3592;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private sealed class <WaitForRequest>d__13<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public Action<ApiResponseModel<T>> callback;

		public UnityWebRequest request;

		private <>c__DisplayClass13_0<T> <>8__1;

		public CachedModel<T> cachedModel;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <WaitForRequest>d__13(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0221: Expected I4, but got I8
			//IL_0237: Expected O, but got I
			//IL_024d: Expected O, but got I
			//IL_0256: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Expected O, but got Unknown
			//IL_0275: Expected O, but got I4
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bc: Expected O, but got Unknown
			//IL_0376: Expected I4, but got O
			//IL_0036: Expected I4, but got I8
			//IL_004c: Expected O, but got I
			//IL_0062: Expected O, but got I
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			//IL_008a: Expected O, but got I4
			//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f9: Expected O, but got Unknown
			//IL_0341: Unknown result type (might be due to invalid IL or missing references)
			//IL_0346: Expected O, but got Unknown
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected O, but got Unknown
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Expected O, but got Unknown
			//IL_01e3: Expected O, but got I4
			if (<>1__state != 0)
			{
				if (<>1__state != 1)
				{
					goto IL_0395;
				}
				<>1__state = -1;
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v15 (Il2CppRgctx<WebRequest+<WaitForRequest>d__13`1>)+28]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v15 (Il2CppRgctx<WebRequest+<WaitForRequest>d__13`1>)+28]");
				object obj2 = (nint)0 + (nint)309;
				object obj3 = obj2 & 1;
				bool flag = obj3 == null;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4AF3C4C");
				if (<>8__1 != null)
				{
					object obj5 = <>8__1 + 16;
					object obj6 = default(object);
					obj5 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if (request != null)
					{
						request.Dispose();
						object obj7 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						nint num3 = 0;
						<>c__DisplayClass13_0<T> <>c__DisplayClass13_ = <>8__1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v21 (Il2CppRgctx<WebRequest+<WaitForRequest>d__13`1>)+38]");
						Action action = default(Action);
						action..ctor(<>c__DisplayClass13_, (IntPtr)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						nint num4 = 0;
						<>c__DisplayClass13_0<T> <>c__DisplayClass13_2 = <>8__1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v23 (Il2CppRgctx<WebRequest+<WaitForRequest>d__13`1>)+40]");
						Action action2 = default(Action);
						action2..ctor(<>c__DisplayClass13_2, (IntPtr)0);
						object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
						object obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v29+E4]");
						bool flag2 = (nint)0 == 0;
						object obj10 = !flag2;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						KUtil.SwitchToBackground(action, action2);
						goto IL_0395;
					}
				}
			}
			else
			{
				<>1__state = -1;
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7 (Il2CppRgctx<WebRequest+<WaitForRequest>d__13`1>)+8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7 (Il2CppRgctx<WebRequest+<WaitForRequest>d__13`1>)+8]");
				object obj12 = (nint)0 + (nint)309;
				object obj13 = obj12 & 1;
				bool flag3 = obj13 == null;
				object obj14 = !flag3;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31D6B5C");
				object obj15 = this + 48;
				object obj16 = default(object);
				obj15 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (obj15 != null)
				{
					object obj17 = obj15 + 24;
					obj17 = callback;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if (request != null)
					{
						UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = request.SendWebRequest();
						object obj18 = this + 24;
						obj18 = unityWebRequestAsyncOperation;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_ = 1;
						goto IL_0395;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0395:
			return <>1__state == 0;
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

	public const string ETag = "KTag";

	public const string StandardETag = "ETag";

	public const string ETagCheckHeader = "If-None-Match";

	public static void SendPostHttpRequest(string url, object postData, Action<ApiResponseModel> callback, Dictionary<string, string> headers = null)
	{
		UnityWebRequest request = CreateJsonPostRequest(url, postData);
		SetRequestHeaders(request, headers);
		SendUnityWebRequest(request, callback);
	}

	public static void SendPostHttpRequest<T>(string url, object postData, Action<ApiResponseModel<T>> callback, Dictionary<string, string> headers = null, CachedModel<T> cachedModel = null)
	{
		//IL_0037: Expected O, but got I
		string url2 = default(string);
		object postData2 = default(object);
		UnityWebRequest unityWebRequest = CreateJsonPostRequest(url2, postData2, headers);
		nint num = 0;
		object obj = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v56 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public static void SendGetHttpRequest(string url, Action<ApiResponseModel> callback, Dictionary<string, string> headers = null)
	{
		UnityWebRequest request = UnityWebRequest.Get(url);
		SetRequestHeaders(request, headers);
		SendUnityWebRequest(request, callback);
	}

	public static void SendGetHttpRequest<T>(string url, Action<ApiResponseModel<T>> callback, Dictionary<string, string> headers = null, CachedModel<T> cachedModel = null)
	{
		string uri = default(string);
		UnityWebRequest request = UnityWebRequest.Get(uri);
		SetRequestHeaders(request, headers);
		SendUnityWebRequest(request, callback, cachedModel);
	}

	private static UnityWebRequest CreateJsonPostRequest(string url, object postData, Dictionary<string, string> headers)
	{
		UnityWebRequest unityWebRequest = CreateJsonPostRequest(url, postData);
		SetRequestHeaders(unityWebRequest, headers);
		return unityWebRequest;
	}

	public static UnityWebRequest CreateJsonPostRequest(string url, object postData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_010b: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004c: Expected I, but got O
		//IL_0075: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_017c: Expected I, but got O
		//IL_0291: Expected O, but got I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_021b: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3664;
		object obj2 = "October" + 2264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		string text = (string)obj2;
		UnityWebRequest unityWebRequest = default(UnityWebRequest);
		unityWebRequest..ctor(url, (string)obj2);
		if (postData != null)
		{
			object obj3 = typeof(List<AdaptivePerformanceScaler>) + 1528;
			object obj4 = obj3;
			nint num = (nint)postData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X9_v5 (Il2CppClass<System.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v14+130]");
			bool flag = num2 < 0;
			object obj5 = !flag;
			object obj6 = ~obj5;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X9_v5 (Il2CppClass<System.Object>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v14+130]");
				object obj7 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X9_v7-8]");
				if (0 == (nint)obj4)
				{
					SetupMultipartRequest((List<IMultipartFormSection>)postData, unityWebRequest);
					object obj8 = 0;
					string text2 = (string)(object)unityWebRequest;
					goto IL_0220;
				}
			}
		}
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string s = JsonMapper.ToJson(postData);
		Encoding uTF = Encoding.UTF8;
		if (uTF != null)
		{
			object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4000;
			nint num4 = (nint)uTF;
			byte[] bytes = uTF.GetBytes(s);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UploadHandlerRaw uploadHandlerRaw = default(UploadHandlerRaw);
			uploadHandlerRaw..ctor(bytes);
			if (unityWebRequest != null)
			{
				object obj13 = "Complete" + 904;
				object obj14 = "alignContent" + 2104;
				unityWebRequest.uploadHandler = uploadHandlerRaw;
				string text2 = (string)obj13;
				text = (string)obj14;
				unityWebRequest.SetRequestHeader((string)obj13, (string)obj14);
				object obj8 = 0;
				goto IL_0220;
			}
		}
		goto IL_029e;
		IL_0220:
		object obj15 = typeof(DataRelation) + 2520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DownloadHandlerBuffer downloadHandlerBuffer = default(DownloadHandlerBuffer);
		downloadHandlerBuffer..ctor();
		if (unityWebRequest != null)
		{
			unityWebRequest.downloadHandler = downloadHandlerBuffer;
			return unityWebRequest;
		}
		goto IL_029e;
		IL_029e:
		return (UnityWebRequest)(object)new NullReferenceException();
	}

	private static void SetRequestHeaders(UnityWebRequest request, Dictionary<string, string> headers)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_0100: Expected O, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_014c: Expected O, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01ae: Expected O, but got I
		//IL_01ba: Expected O, but got I
		//IL_01d5: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj4 = obj2 + 16;
		obj4 = request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string version = Application.version;
		object name = "utf-32" + 456;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		((UnityWebRequest)obj4).SetRequestHeader((string)name, version);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		object obj11 = "Complete" + 3480;
		object obj12 = (nint)0 + (nint)2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F812BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object name2 = "fetch_products" + 2352;
		((UnityWebRequest)obj4).SetRequestHeader((string)name2, friendlyName);
		if (headers != null)
		{
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 688;
			object obj14 = (nint)0 + (nint)3584;
			object obj15 = (nint)0 + (nint)2008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<KeyValuePair<object, object>> action = default(Action<KeyValuePair<object, object>>);
			action..ctor(obj2, (IntPtr)obj14);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C95C80");
		}
	}

	public static void SendUnityWebRequest(UnityWebRequest request, Action<ApiResponseModel> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy permanentInstance = CoroutineDummy.PermanentInstance;
		object obj4 = typeof(TrackedDeviceRaycaster.<>c) + 2544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		_ = 0;
		object obj6 = obj5 + 32;
		obj6 = request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj5 + 40;
		obj7 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = permanentInstance.StartCoroutine((IEnumerator)obj5);
	}

	private static void SendUnityWebRequest<T>(UnityWebRequest request, Action<ApiResponseModel<T>> callback, CachedModel<T> cachedModel)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy permanentInstance = CoroutineDummy.PermanentInstance;
		IEnumerator routine = WaitForRequest(request, callback, cachedModel);
		Coroutine coroutine = permanentInstance.StartCoroutine(routine);
	}

	private static IEnumerator WaitForRequest(UnityWebRequest request, Action<ApiResponseModel> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 2544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 40;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private static IEnumerator WaitForRequest<T>(UnityWebRequest request, Action<ApiResponseModel<T>> callback, CachedModel<T> cachedModel)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
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
		((<WaitForRequest>d__13<T>)enumerator)..ctor(0);
		if (enumerator != null)
		{
			object obj4 = enumerator + 40;
			obj4 = request;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = enumerator + 32;
			obj5 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = enumerator + 56;
			obj6 = cachedModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private static void SetupMultipartRequest(List<IMultipartFormSection> multipartFormData, UnityWebRequest request)
	{
		//IL_0011: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		byte[] array = UnityWebRequest.GenerateBoundary();
		Encoding uTF = Encoding.UTF8;
		object obj = (nint)0 + (nint)2864;
		object obj2 = ", stale={0}" + 240;
		string text = uTF.GetString(array);
		Encoding uTF2 = Encoding.UTF8;
		string s = (string)obj + text + (string)obj2;
		byte[] bytes = uTF2.GetBytes(s);
		byte[] array2 = UnityWebRequest.SerializeFormSections(multipartFormData, array);
		object obj3 = typeof(TypeConverter<ushort, char>) + 1880;
		object obj4 = "m_StencilDeferredPS" + 2760;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4000;
		object obj6 = bytes.Length + array2.Length;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Array array3 = default(Array);
		Buffer.BlockCopy(array2, 0, array3, 0, array2.Length);
		Buffer.BlockCopy(bytes, 0, array3, array2.Length, bytes.Length);
		string value = (string)obj4 + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UploadHandlerRaw uploadHandlerRaw = default(UploadHandlerRaw);
		uploadHandlerRaw..ctor((byte[])array3);
		object name = "Complete" + 904;
		request.uploadHandler = uploadHandlerRaw;
		request.SetRequestHeader((string)name, value);
	}
}
