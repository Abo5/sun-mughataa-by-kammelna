using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine.Networking;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace Kammelna.Server.WebRequests;

public abstract class BaseWebRequest<TResponse> : IWebRequest<TResponse>, IDisposable
{
	protected enum HttpMethod
	{
		GET,
		POST,
		PUT,
		DELETE
	}

	private sealed class <Execute>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public BaseWebRequest<TResponse> <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <Execute>d__22(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_006c: Expected I4, but got I8
			//IL_00fd: Expected I4, but got O
			//IL_004e: Expected I4, but got I8
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected O, but got Unknown
			int num;
			if (<>1__state != 0)
			{
				if (<>1__state != 1)
				{
					goto IL_00fd;
				}
				num = -1;
			}
			else
			{
				BaseWebRequest<TResponse> baseWebRequest = <>4__this;
				<>1__state = -1;
				if (<>4__this == null || baseWebRequest.<UnityRequest>k__BackingField == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = baseWebRequest.<UnityRequest>k__BackingField.SendWebRequest();
				object obj = this + 24;
				obj = unityWebRequestAsyncOperation;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				num = 1;
			}
			<>1__state = num;
			goto IL_00fd;
			IL_00fd:
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

	private sealed class <Materialize>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public BaseWebRequest<TResponse> <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <Materialize>d__23(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0104: Expected I4, but got I8
			//IL_0299: Expected I4, but got O
			//IL_0139: Expected O, but got I
			//IL_014f: Expected O, but got I
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_0177: Expected O, but got I4
			//IL_005a: Expected I4, but got I8
			//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e8: Expected O, but got Unknown
			//IL_01c1: Expected O, but got I
			//IL_01d7: Expected O, but got I
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected O, but got Unknown
			//IL_01ff: Expected O, but got I4
			//IL_0244: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Expected O, but got Unknown
			//IL_00b3: Expected I, but got O
			//IL_0276: Expected O, but got I
			//IL_0286: Expected O, but got I
			//IL_00e0: Expected O, but got I
			//IL_00f0: Expected O, but got I
			BaseWebRequest<TResponse> baseWebRequest = <>4__this;
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					if (<>4__this == null || baseWebRequest.<Response>k__BackingField == null)
					{
						goto IL_028b;
					}
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D1374C");
					nint num2 = (nint)baseWebRequest;
					object obj = default(object);
					if (obj != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v21 (Il2CppClass<Kammelna.Server.WebRequests.BaseWebRequest`1<TResponse>>)+268]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v21 (Il2CppClass<Kammelna.Server.WebRequests.BaseWebRequest`1<TResponse>>)+270]");
						object obj3 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v21 (Il2CppClass<Kammelna.Server.WebRequests.BaseWebRequest`1<TResponse>>)+278]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v21 (Il2CppClass<Kammelna.Server.WebRequests.BaseWebRequest`1<TResponse>>)+280]");
						object obj3 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48 @ X9_v4 (should have been resolved before IL gen)");
				}
			}
			else
			{
				<>1__state = -1;
				if (<>4__this == null)
				{
					goto IL_028b;
				}
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v5 (Il2CppRgctx<Kammelna.Server.WebRequests.BaseWebRequest`1+<Materialize>d__23>)+18]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v5 (Il2CppRgctx<Kammelna.Server.WebRequests.BaseWebRequest`1+<Materialize>d__23>)+18]");
				object obj5 = (nint)0 + (nint)309;
				object obj6 = obj5 & 1;
				bool flag = obj6 == null;
				object obj7 = !flag;
				<Materialize>d__23 <Materialize>d__;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					<Materialize>d__ = this;
					object obj8 = default(object);
					obj4 = obj8;
				}
				else
				{
					<Materialize>d__ = this;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D13804");
				object obj9 = <>4__this + 32;
				object obj10 = default(object);
				obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v11 (Il2CppRgctx<Kammelna.Server.WebRequests.BaseWebRequest`1+<Materialize>d__23>)+38]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v11 (Il2CppRgctx<Kammelna.Server.WebRequests.BaseWebRequest`1+<Materialize>d__23>)+38]");
				object obj12 = (nint)0 + (nint)309;
				object obj13 = obj12 & 1;
				bool flag2 = obj13 == null;
				object obj14 = !flag2;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D13140");
				object obj15 = <Materialize>d__ + 24;
				object obj16 = default(object);
				obj15 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
			}
			return <>1__state == 0;
			IL_028b:
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

	private IClientContext <ClientContext>k__BackingField;

	private UnityWebRequest <UnityRequest>k__BackingField;

	private KammelnaResponseModel<TResponse> <Response>k__BackingField;

	private readonly Dictionary<string, object> <QueryParams>k__BackingField;

	protected abstract HttpMethod Method { get; }

	public abstract string EndPoint { get; }

	public string RequestUrl
	{
		get
		{
			//IL_0005: Expected I, but got O
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ X8_v1 (Il2CppClass<Kammelna.Server.WebRequests.BaseWebRequest`1<TResponse>>)+218] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4290BBC");
			string text = default(string);
			string text2 = default(string);
			return text + text2;
		}
	}

	public IClientContext ClientContext
	{
		get
		{
			return <ClientContext>k__BackingField;
		}
		protected set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public UnityWebRequest UnityRequest
	{
		get
		{
			return <UnityRequest>k__BackingField;
		}
		protected set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public KammelnaResponseModel<TResponse> Response
	{
		get
		{
			return <Response>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	protected virtual Dictionary<string, object> QueryParams => <QueryParams>k__BackingField;

	public unsafe virtual void Setup()
	{
		//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected O, but got Unknown
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4b: Expected O, but got Unknown
		//IL_0a50: Expected I, but got O
		//IL_0a7a: Expected I, but got O
		//IL_0aa1: Expected O, but got I
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Expected O, but got Unknown
		//IL_0ac9: Expected O, but got I4
		//IL_001d: Expected O, but got Ref
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I4
		//IL_0bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Expected O, but got Unknown
		//IL_0c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0f: Expected O, but got Unknown
		//IL_0c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c23: Expected O, but got Unknown
		//IL_0c3b: Expected O, but got I
		//IL_0c4e: Expected O, but got I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0185: Expected O, but got I
		//IL_0274: Expected I, but got O
		//IL_02d6: Expected O, but got I4
		//IL_02df: Expected O, but got I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected I, but got Unknown
		//IL_01c0: Expected O, but got I
		//IL_055d: Expected O, but got I
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_0309: Expected I, but got O
		//IL_0319: Expected O, but got I
		//IL_0ae7: Expected O, but got I
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Expected O, but got Unknown
		//IL_0b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Expected O, but got Unknown
		//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Expected O, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected O, but got Unknown
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_0493: Expected I, but got O
		//IL_04b7: Expected O, but got I4
		//IL_04c7: Expected O, but got I
		//IL_0ce9: Expected O, but got I
		//IL_0cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d01: Expected O, but got Unknown
		//IL_05a8: Expected O, but got I
		//IL_0354: Expected O, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_086d: Expected O, but got I4
		//IL_0876: Expected O, but got I4
		//IL_0c64: Expected O, but got I
		//IL_0c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7b: Expected O, but got Unknown
		//IL_0ca2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca7: Expected O, but got Unknown
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Expected O, but got Unknown
		//IL_0b6b: Expected O, but got I
		//IL_0b7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b82: Expected O, but got Unknown
		//IL_0ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bae: Expected O, but got Unknown
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Expected O, but got Unknown
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected O, but got Unknown
		//IL_0df9: Expected O, but got I4
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_05d9: Expected O, but got I
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03e8: Expected O, but got I
		//IL_0893: Expected O, but got I
		//IL_06db: Expected O, but got I
		//IL_0e43: Expected O, but got I
		//IL_08ce: Expected O, but got I
		//IL_0db3: Expected O, but got I
		//IL_0716: Expected O, but got I
		//IL_0825: Expected O, but got I
		//IL_083e: Expected O, but got I4
		//IL_0856: Expected O, but got I
		//IL_0d2e: Expected O, but got I
		//IL_0d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Expected O, but got Unknown
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Expected O, but got Unknown
		//IL_0d81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Expected O, but got Unknown
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected O, but got Unknown
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected O, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Expected O, but got Unknown
		//IL_08f7: Expected O, but got I
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected O, but got Unknown
		//IL_0747: Expected O, but got I
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected O, but got Unknown
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3664;
		object obj2 = typeof(DataRelation) + 2520;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ X8_v3 (Il2CppClass<Kammelna.Server.WebRequests.BaseWebRequest`1<TResponse>>)+218] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4290BBC");
		string text = default(string);
		string text2 = default(string);
		string url = text + text2;
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v72 @ X8_v4 (Il2CppClass<Kammelna.Server.WebRequests.BaseWebRequest`1<TResponse>>)+208] (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6 (Il2CppRgctx<Kammelna.Server.WebRequests.BaseWebRequest`1>)+30]");
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3 & 1;
		bool flag = obj4 == null;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		object obj6 = default(object);
		string text3 = ((Enum)(&obj6)).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityWebRequest unityWebRequest = default(UnityWebRequest);
		unityWebRequest..ctor(url, text3);
		object obj7 = this + 24;
		obj7 = unityWebRequest;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DownloadHandlerBuffer downloadHandlerBuffer = default(DownloadHandlerBuffer);
		downloadHandlerBuffer..ctor();
		bool flag2 = obj7 == null;
		string text4 = text3;
		nint num4 = -1;
		object obj14;
		bool flag5;
		bool flag6 = default(bool);
		object obj15 = default(object);
		object obj16;
		bool flag7;
		object obj17;
		object obj18;
		object obj19;
		object obj20 = default(object);
		object obj29;
		string text5;
		NullReferenceException ex = default(NullReferenceException);
		object obj21 = default(object);
		bool flag8 = default(bool);
		object obj22 = default(object);
		object obj23 = default(object);
		object obj24 = default(object);
		if (!flag2)
		{
			((UnityWebRequest)obj7).downloadHandler = downloadHandlerBuffer;
			object obj8 = this + 16;
			object obj9 = obj8;
			bool flag3 = obj8 == null;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				num4 = (nint)(typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1496);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				ClientContext clientContext = default(ClientContext);
				clientContext..ctor();
				obj8 = clientContext;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj9 = obj8;
				bool flag4 = obj8 == null;
				text4 = null;
				if (flag4)
				{
					goto IL_0517;
				}
			}
			object obj11 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1552;
			object obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v37+12E]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v37+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0262;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v37+B0]");
			obj14 = (nint)0 + (nint)8;
			flag5 = flag6;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X10_v29-8]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X10_v29-8]");
				obj16 = 0 - obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X10_v29-8]");
				flag7 = 0 == (nint)obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X10_v29-8]");
				obj17 = 0 ^ obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X10_v29-8]");
				obj18 = 0 ^ obj16;
				obj19 = obj17 & obj18;
				if (flag7)
				{
					break;
				}
				obj20 = obj14 + 16;
				obj13--;
				obj21 = obj13 - 1;
				flag8 = obj21 == null;
				obj22 = obj13 ^ 1;
				obj23 = obj13 ^ obj21;
				obj24 = obj22 & obj23;
				flag6 = (nint)obj13 != 1;
				flag5 = flag6;
				obj14 = obj20;
				if (flag6)
				{
					continue;
				}
				goto IL_0262;
			}
			object obj25 = obj14 + 8;
			object obj26 = obj12 + obj25;
			object obj27 = obj26 + 312;
			num4 = (nint)obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v383 @ X0_v71] (should have been resolved before IL gen)");
			bool flag9 = ex == null;
			object obj28 = !flag9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X10_v29-8]");
			obj29 = 0;
			text5 = null;
			flag6 = flag5;
			obj24 = obj19;
			obj23 = obj18;
			obj22 = obj17;
			flag8 = flag7;
			obj21 = obj16;
			obj20 = obj14;
			text4 = null;
			if (obj28 != null)
			{
				goto IL_02ed;
			}
		}
		goto IL_0517;
		IL_0406:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj15 = obj29;
		flag6 = flag5;
		obj24 = obj19;
		obj23 = obj18;
		obj22 = obj17;
		flag8 = flag7;
		obj21 = obj16;
		obj20 = obj14;
		text4 = null;
		object obj31 = default(object);
		object obj30 = obj31;
		goto IL_0be7;
		IL_0525:
		object obj32 = num4 + obj20;
		obj30 = obj32 + 312;
		goto IL_0be7;
		IL_0be7:
		object obj33 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj34 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 192;
		object obj35 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj36 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v10+8]");
		string text6 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v286 @ X8_v10] (should have been resolved before IL gen)");
		object obj37 = 0;
		object obj38 = default(object);
		object obj47 = default(object);
		object obj52;
		string text7;
		string text8;
		string text9 = default(string);
		while (true)
		{
			object obj41;
			object obj42;
			object obj40;
			if (obj38 != null)
			{
				object obj39 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v21+12E]");
				obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v21+12E]");
				bool flag10 = (nint)0 == 0;
				obj41 = obj15;
				obj42 = obj20;
				if (flag10)
				{
					goto IL_0652;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v21+B0]");
				object obj43 = (nint)0 + (nint)8;
				bool flag11 = flag6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X10_v23-8]");
					obj41 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X10_v23-8]");
					obj21 = 0 - obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X10_v23-8]");
					flag8 = 0 == (nint)obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X10_v23-8]");
					obj22 = 0 ^ obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X10_v23-8]");
					obj23 = 0 ^ obj21;
					obj24 = obj22 & obj23;
					if (flag8)
					{
						break;
					}
					obj42 = obj43 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v21+12E]");
					obj40 = -1;
					obj21 = obj40 - 1;
					flag8 = obj21 == null;
					obj22 = obj40 ^ 1;
					obj23 = obj40 ^ obj21;
					obj24 = obj22 & obj23;
					flag6 = (nint)obj40 != 1;
					flag11 = flag6;
					obj43 = obj42;
					if (flag6)
					{
						continue;
					}
					goto IL_0652;
				}
				obj40 = obj43;
				object obj44 = obj39 + obj43;
				object obj45 = obj44 + 312;
				flag6 = flag11;
				obj42 = obj43;
				text7 = text4;
				goto IL_0cd8;
			}
			throw new NullReferenceException();
			IL_0652:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			text7 = null;
			goto IL_0cd8;
			IL_0cd8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X0_v43+8]");
			text8 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v520 @ X0_v43] (should have been resolved before IL gen)");
			object obj46 = obj47 & 1;
			if (obj46 != null)
			{
				if (obj38 != null)
				{
					object obj48 = obj38;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v24+12E]");
					obj40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v24+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v24+B0]");
						object obj49 = (nint)0 + (nint)8;
						bool flag12 = flag6;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X10_v18-8]");
							obj41 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X10_v18-8]");
							obj21 = 0 - obj34;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X10_v18-8]");
							flag8 = 0 == (nint)obj34;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X10_v18-8]");
							obj22 = 0 ^ obj34;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X10_v18-8]");
							obj23 = 0 ^ obj21;
							obj24 = obj22 & obj23;
							if (flag8)
							{
								break;
							}
							obj42 = obj49 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v24+12E]");
							obj40 = -1;
							obj21 = obj40 - 1;
							flag8 = obj21 == null;
							obj22 = obj40 ^ 1;
							obj23 = obj40 ^ obj21;
							obj24 = obj22 & obj23;
							flag6 = (nint)obj40 != 1;
							flag12 = flag6;
							obj49 = obj42;
							if (flag6)
							{
								continue;
							}
							goto IL_07c0;
						}
						obj40 = obj49;
						object obj50 = obj48 + obj49;
						object obj51 = obj50 + 312;
						flag6 = flag12;
						obj42 = obj49;
						goto IL_0da2;
					}
					goto IL_07c0;
				}
				throw new NullReferenceException();
			}
			obj6 = 0;
			obj52 = 0;
			break;
			IL_07c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			text7 = null;
			goto IL_0da2;
			IL_0da2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v47+8]");
			text8 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v726 @ X0_v47] (should have been resolved before IL gen)");
			object obj53 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v47+8]");
			((UnityWebRequest)obj53).SetRequestHeader(text9, (string)0);
			obj15 = obj41;
			obj20 = obj42;
			obj37 = 0;
			obj36 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v47+8]");
			text4 = (string)0;
			text6 = text9;
		}
		object obj59 = default(object);
		while (true)
		{
			if (obj38 == null)
			{
				goto IL_0ddf;
			}
			object obj54 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v16+12E]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v16+12E]");
			if ((nint)0 == 0)
			{
				goto IL_091f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v16+B0]");
			object obj55 = (nint)0 + (nint)8;
			object obj42;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X10_v10-8]");
				if (0 == (nint)obj35)
				{
					break;
				}
				obj42 = obj55 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v16+12E]");
				obj40 = -1;
				bool flag13 = (nint)obj40 != 1;
				obj55 = obj42;
				if (flag13)
				{
					continue;
				}
				goto IL_091f;
			}
			obj40 = obj55;
			object obj56 = obj54 + obj55;
			object obj57 = obj56 + 312;
			obj42 = obj55;
			goto IL_0e33;
			IL_0ddf:
			bool flag14 = obj52 == null;
			object obj58 = !flag14;
			text4 = text7;
			if (obj58 == null)
			{
				return;
			}
			OutOfMemoryException ex2 = new OutOfMemoryException();
			if ((nint)text8 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			obj52 = obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj6 = obj59;
			text7 = text4;
			continue;
			IL_091f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			text7 = null;
			goto IL_0e33;
			IL_0e33:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v35+8]");
			text8 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v783 @ X0_v35] (should have been resolved before IL gen)");
			goto IL_0ddf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0517:
		ex = new NullReferenceException();
		goto IL_0525;
		IL_0262:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj60 = default(object);
		num4 = (nint)obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v321 @ X0_v68] (should have been resolved before IL gen)");
		bool flag15 = ex == null;
		obj29 = obj15;
		flag5 = flag6;
		obj19 = obj24;
		obj18 = obj23;
		obj17 = obj22;
		flag7 = flag8;
		obj16 = obj21;
		obj14 = obj20;
		text5 = (string)8;
		text4 = (string)8;
		if (!flag15)
		{
			goto IL_02ed;
		}
		goto IL_0517;
		IL_02ed:
		object obj61 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2848;
		num4 = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v30 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v30 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0406;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v30 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj20 = (nint)0 + (nint)8;
		flag6 = flag5;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X10_v2-8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X10_v2-8]");
			obj21 = 0 - obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X10_v2-8]");
			flag8 = 0 == (nint)obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X10_v2-8]");
			obj22 = 0 ^ obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X10_v2-8]");
			obj23 = 0 ^ obj21;
			obj24 = obj22 & obj23;
			text4 = text5;
			if (flag8)
			{
				break;
			}
			obj14 = obj20 + 16;
			obj62--;
			obj16 = obj62 - 1;
			flag7 = obj16 == null;
			obj17 = obj62 ^ 1;
			obj18 = obj62 ^ obj16;
			obj19 = obj17 & obj18;
			flag5 = (nint)obj62 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X10_v2-8]");
			obj29 = 0;
			flag6 = flag5;
			obj20 = obj14;
			if (flag5)
			{
				continue;
			}
			goto IL_0406;
		}
		goto IL_0525;
	}

	public virtual IEnumerator Execute()
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.BaseWebRequest`1>)+60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.BaseWebRequest`1>)+60]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @449A5E4");
		IEnumerator enumerator = default(IEnumerator);
		if (enumerator != null)
		{
			object obj5 = enumerator + 32;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	public virtual IEnumerator Materialize()
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.BaseWebRequest`1>)+70]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.BaseWebRequest`1>)+70]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @45A7568");
		IEnumerator enumerator = default(IEnumerator);
		if (enumerator != null)
		{
			object obj5 = enumerator + 32;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	public void Dispose()
	{
		if (<UnityRequest>k__BackingField != null)
		{
			<UnityRequest>k__BackingField.Dispose();
		}
	}

	protected virtual void OnSuccess()
	{
	}

	protected virtual void OnError()
	{
	}

	private string GenerateQueryString()
	{
		//IL_0314: Expected I, but got O
		//IL_0346: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_0223: Expected O, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_02ab: Expected I4, but got O
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00ba: Expected I, but got O
		//IL_00ec: Expected O, but got I4
		//IL_0110: Expected O, but got I
		//IL_0243: Expected O, but got I4
		//IL_024c: Expected O, but got I4
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3 (Il2CppClass<Kammelna.Server.WebRequests.BaseWebRequest`1<TResponse>>)+230]");
		char c = '\0';
		Dictionary<object, object> queryParams = (Dictionary<object, object>)(object)((BaseWebRequest<>)(object)this).QueryParams;
		bool flag = queryParams == null;
		StringBuilder stringBuilder = (StringBuilder)152973312;
		StringBuilder stringBuilder2 = default(StringBuilder);
		object obj4 = default(object);
		object obj3;
		if (!flag)
		{
			object obj = (nint)0 + (nint)40;
			if (queryParams.Count == 0)
			{
				return (string)((nint)0 + (nint)2000);
			}
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			stringBuilder2..ctor();
			bool flag2 = stringBuilder2 == null;
			c = '\0';
			stringBuilder = stringBuilder2;
			if (!flag2)
			{
				object value = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1120;
				StringBuilder stringBuilder3 = stringBuilder2.Append((string)value);
				nint num2 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v15 (Il2CppClass<Kammelna.Server.WebRequests.BaseWebRequest`1<TResponse>>)+230]");
				c = '\0';
				Dictionary<object, object> queryParams2 = (Dictionary<object, object>)(object)((BaseWebRequest<>)(object)this).QueryParams;
				bool flag3 = queryParams2 == null;
				obj3 = 0;
				stringBuilder = stringBuilder2;
				if (!flag3)
				{
					obj4 = (nint)0 + (nint)3112;
					Dictionary<object, object>.Enumerator enumerator = queryParams2.GetEnumerator();
					Dictionary<object, object>.Enumerator enumerator2 = default(Dictionary<object, object>.Enumerator);
					string s = default(string);
					object obj5 = default(object);
					string s2 = default(string);
					while (enumerator2.MoveNext())
					{
						int length = stringBuilder2.Length;
						if (length >= 2)
						{
							StringBuilder stringBuilder4 = stringBuilder2.Append('&');
						}
						string value2 = UnityWebRequest.EscapeURL(s);
						StringBuilder stringBuilder5 = stringBuilder2.Append(value2);
						StringBuilder stringBuilder6 = stringBuilder2.Append('=');
						if (obj5 != null)
						{
							object obj6 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v316 @ X8_v22+168] (should have been resolved before IL gen)");
							string value3 = UnityWebRequest.EscapeURL(s2);
							StringBuilder stringBuilder7 = stringBuilder2.Append(value3);
							continue;
						}
						goto IL_0228;
					}
					enumerator2.Dispose();
					stringBuilder = stringBuilder2;
					goto IL_0205;
				}
			}
		}
		goto IL_0354;
		IL_0354:
		NullReferenceException ex = new NullReferenceException();
		bool flag4 = c != '\u0001';
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		Dictionary<object, object>.Enumerator enumerator3 = default(Dictionary<object, object>.Enumerator);
		Dictionary<object, object>.Enumerator enumerator4 = default(Dictionary<object, object>.Enumerator);
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			c = (char)(int)obj4;
			enumerator3.Dispose();
			object obj7 = default(object);
			if (obj7 == null)
			{
				goto IL_0205;
			}
			ex2 = new OutOfMemoryException();
			enumerator4 = (Dictionary<object, object>.Enumerator)obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		string result = default(string);
		return result;
		IL_0228:
		NullReferenceException ex3 = new NullReferenceException();
		enumerator3 = enumerator4;
		enumerator4 = (Dictionary<object, object>.Enumerator)0;
		obj3 = 0;
		c = '=';
		stringBuilder = stringBuilder2;
		goto IL_0354;
		IL_0205:
		return stringBuilder.ToString();
	}

	protected BaseWebRequest()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj2 = this + 40;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
