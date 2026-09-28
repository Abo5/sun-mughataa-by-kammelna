using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using AppleAuth;
using AppleAuth.Enums;
using AppleAuth.Interfaces;
using AppleAuth.Native;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Unity.Services.Authentication.Shared;
using UnityEngine.TextCore;

namespace Social;

public class AppleSigninHandler : Singleton<AppleSigninHandler>
{
	public delegate void SigninCallback(IAppleIDCredential credential, string rawNonce);

	public delegate void SigninError(IAppleError error);

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<IAppleError> <>9__5_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Login>b__5_1(IAppleError error)
		{
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public SigninCallback signinCallback;

		public string rawNonce;

		internal void <Login>b__0(ICredential credential)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 896;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			object obj2 = default(object);
			if (obj2 != null)
			{
				SigninCallback signinCallback = this.signinCallback;
				if (this.signinCallback != null)
				{
					string text = rawNonce;
					IntPtr invoke_impl = ((Delegate)signinCallback).invoke_impl;
					IntPtr method_code = ((Delegate)signinCallback).method_code;
					IntPtr method = ((Delegate)signinCallback).method;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v61 @ X4_v1 (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
	}

	private IAppleAuthManager appleAuthManager;

	protected override void OnAwake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0135: Expected O, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_0171: Expected O, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E7E]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isCurrentPlatformSupported = AppleAuthManager.IsCurrentPlatformSupported;
		bool flag2 = !isCurrentPlatformSupported;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			return;
		}
		goto IL_009f;
		IL_009f:
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PayloadDeserializer payloadDeserializer = default(PayloadDeserializer);
		payloadDeserializer..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AppleAuthManager appleAuthManager = default(AppleAuthManager);
		appleAuthManager..ctor(payloadDeserializer);
		object obj8 = this + 32;
		obj8 = appleAuthManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_007d:
		if (AppleAuthManager.IsCurrentPlatformSupported)
		{
			goto IL_009f;
		}
	}

	private void FixedUpdate()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		while (true)
		{
			IAppleAuthManager appleAuthManager = this.appleAuthManager;
			if (this.appleAuthManager == null)
			{
				break;
			}
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 872;
			nint num = (nint)appleAuthManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<AppleAuth.IAppleAuthManager>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<AppleAuth.IAppleAuthManager>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<AppleAuth.IAppleAuthManager>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X10_v4-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj3 += 16;
					obj2--;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00ad;
				}
				object obj4 = obj3 + 6;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v151 @ X0_v5] (should have been resolved before IL gen)");
				continue;
			}
			goto IL_00ad;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v89 @ X0_v3] (should have been resolved before IL gen)");
			break;
		}
	}

	public void Login(SigninCallback signinCallback)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0528: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0087: Expected O, but got I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0158: Expected O, but got I4
		//IL_0211: Expected I, but got O
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_03c7: Expected O, but got I
		//IL_03d7: Expected O, but got I
		//IL_03f9: Expected O, but got I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_02ab: Expected O, but got I4
		//IL_02c0: Expected I, but got O
		//IL_024e: Expected O, but got I
		//IL_025e: Expected O, but got I
		//IL_0429: Expected O, but got I4
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02f2: Expected I, but got O
		//IL_0302: Expected O, but got I
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected O, but got Unknown
		//IL_05bc: Expected O, but got I
		//IL_05cd: Expected I, but got O
		//IL_05eb: Expected O, but got I
		//IL_0478: Expected O, but got I4
		//IL_0491: Expected O, but got I4
		//IL_04ae: Expected I, but got O
		//IL_0459: Expected O, but got I
		//IL_033d: Expected O, but got I
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected O, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected O, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E80]");
		nint num = 0;
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		AppleAuthLoginArgs appleAuthLoginArgs = (AppleAuthLoginArgs)0;
		object obj3 = obj2;
		AppleSigninHandler appleSigninHandler = this;
		SigninCallback signinCallback2 = signinCallback;
		AppleAuthLoginArgs appleAuthLoginArgs2;
		Action<object> action = default(Action<object>);
		object obj18;
		AppleAuthLoginArgs appleAuthLoginArgs3;
		AppleAuthLoginArgs appleAuthLoginArgs4;
		object obj27;
		if (!flag)
		{
			object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
			object obj5 = obj2 + 16;
			obj5 = signinCallback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2264;
			object obj9 = (nint)0 + (nint)104;
			object obj10 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1760;
			string text = StringUtil.GenerateNonce();
			object obj11 = obj2 + 24;
			obj11 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string text2 = StringUtil.GenerateSHA256((string)obj11);
			appleAuthLoginArgs2 = new AppleAuthLoginArgs((LoginOptions)3, text2);
			object obj12 = this + 32;
			AppleAuthManager appleAuthManager = (AppleAuthManager)obj12;
			bool flag3 = obj12 == null;
			object obj13 = !flag3;
			string text3 = text2;
			if (obj13 == null)
			{
				object obj14 = typeof(System.Buffers.Text.ParserHelpers) + 184;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				PayloadDeserializer payloadDeserializer = default(PayloadDeserializer);
				payloadDeserializer..ctor();
				object obj15 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 280;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				AppleAuthManager appleAuthManager2 = default(AppleAuthManager);
				appleAuthManager2..ctor(payloadDeserializer);
				text3 = null;
				appleAuthManager = appleAuthManager2;
			}
			obj12 = appleAuthManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			appleSigninHandler = (AppleSigninHandler)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor(obj2, (IntPtr)obj9);
			object obj16 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v29+E4]");
			object obj17;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v29+B8]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v13+8]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v13+8]");
				if ((nint)0 != 0)
				{
					goto IL_0283;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v29+B8]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v13+8]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v13+8]");
				bool flag4 = (nint)0 == 0;
				object obj19 = !flag4;
				if (obj19 != null)
				{
					goto IL_0283;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v29+E4]");
			bool flag5 = (nint)0 == 0;
			object obj20 = !flag5;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj21 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v20+B8]");
				obj17 = 0;
			}
			object obj22 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj23 = (nint)0 + (nint)96;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj17, (IntPtr)obj23);
			object obj24 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v18+B8]");
			object obj25 = (nint)0 + (nint)8;
			obj25 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag6 = (object)appleSigninHandler == null;
			object obj26 = !flag6;
			appleAuthLoginArgs3 = appleAuthLoginArgs2;
			appleAuthLoginArgs4 = appleAuthLoginArgs2;
			obj27 = 0;
			obj18 = action2;
			appleAuthLoginArgs = appleAuthLoginArgs2;
			obj3 = action2;
			num = unchecked((nint)null);
			signinCallback2 = (SigninCallback)(object)action;
			if (obj26 != null)
			{
				goto IL_02d6;
			}
		}
		goto IL_04c4;
		IL_02d6:
		object obj28 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 872;
		num = (nint)appleSigninHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v5 (Il2CppClass<Social.AppleSigninHandler>)+12E]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v5 (Il2CppClass<Social.AppleSigninHandler>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_037e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v5 (Il2CppClass<Social.AppleSigninHandler>)+B0]");
		object obj30 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X10_v2-8]");
			bool flag7 = 0 == (nint)obj28;
			appleAuthLoginArgs = appleAuthLoginArgs3;
			obj3 = obj18;
			signinCallback2 = (SigninCallback)(object)action;
			if (flag7)
			{
				break;
			}
			obj30 += 16;
			obj29--;
			if ((nint)obj29 != 1)
			{
				continue;
			}
			goto IL_037e;
		}
		object obj31 = obj30 + 3;
		object obj32 = num + obj31;
		object obj33 = obj32 + 312;
		goto IL_0587;
		IL_0283:
		bool flag8 = (object)appleSigninHandler == null;
		appleAuthLoginArgs3 = appleAuthLoginArgs2;
		appleAuthLoginArgs4 = appleAuthLoginArgs2;
		obj27 = 0;
		appleAuthLoginArgs = appleAuthLoginArgs2;
		obj3 = obj18;
		num = unchecked((nint)null);
		signinCallback2 = (SigninCallback)(object)action;
		if (!flag8)
		{
			goto IL_02d6;
		}
		goto IL_04c4;
		IL_04c4:
		throw new NullReferenceException();
		IL_037e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		appleAuthLoginArgs = appleAuthLoginArgs3;
		obj3 = obj18;
		signinCallback2 = (SigninCallback)(object)action;
		goto IL_0587;
		IL_0587:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v275 @ X0_v4] (should have been resolved before IL gen)");
	}

	public AppleSigninHandler()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E81]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)1896;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)1896;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}
}
