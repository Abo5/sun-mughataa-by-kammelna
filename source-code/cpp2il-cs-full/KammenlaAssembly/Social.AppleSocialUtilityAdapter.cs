using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using AppleAuth.Interfaces;
using Cpp2ILInjected;
using Firebase.Auth;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using UnityEngine.TextCore;

namespace Social;

public class AppleSocialUtilityAdapter : SocialUtilityAdapterBase
{
	[PreserveSig]
	private static extern void facebookLogin();

	[PreserveSig]
	private static extern void googleLogin();

	[PreserveSig]
	private static extern void logoutAll();

	[PreserveSig]
	private static extern void twitterTextSharingMethod(string text);

	[PreserveSig]
	private static extern void twitterImageSharing(string path, string text);

	public override void FacebookLogin()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14F6C");
	}

	public override void GoogleLogin()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14FB8");
	}

	public override void TwitterPostText(string text)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @15050");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
	}

	public override void TwitterPostImage(string path, string text)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @150A4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
	}

	public override void AppleLogin()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_008e: Expected O, but got I
		//IL_00b8: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(Queue<string>) + 696;
		object obj2 = (nint)0 + (nint)1904;
		object obj3 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1776;
		object obj4 = (nint)0 + (nint)2792;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AppleSigninHandler.SigninCallback signinCallback = default(AppleSigninHandler.SigninCallback);
		signinCallback..ctor(this, (IntPtr)obj4);
		AppleSigninHandler appleSigninHandler = default(AppleSigninHandler);
		appleSigninHandler.Login(signinCallback);
	}

	public override void LogoutAll()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @15004");
	}

	private void <AppleLogin>b__9_0(IAppleIDCredential credential, string nonce)
	{
		//IL_163a: Expected O, but got I4
		//IL_146c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1471: Expected O, but got Unknown
		//IL_1479: Unknown result type (might be due to invalid IL or missing references)
		//IL_147e: Expected O, but got Unknown
		//IL_1487: Unknown result type (might be due to invalid IL or missing references)
		//IL_148c: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_196c: Expected O, but got I
		//IL_1990: Unknown result type (might be due to invalid IL or missing references)
		//IL_1995: Expected O, but got Unknown
		//IL_19a5: Expected I, but got O
		//IL_19b5: Expected O, but got I
		//IL_00d7: Expected I, but got O
		//IL_00fb: Expected O, but got I4
		//IL_152b: Expected O, but got I4
		//IL_019d: Expected I, but got O
		//IL_01ad: Expected O, but got I
		//IL_01cf: Expected I, but got O
		//IL_01df: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_1a52: Expected I, but got O
		//IL_1a62: Expected O, but got I
		//IL_14a7: Expected O, but got I
		//IL_0275: Expected I, but got O
		//IL_0299: Expected O, but got I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0368: Expected I, but got O
		//IL_03a3: Expected O, but got I4
		//IL_021a: Expected O, but got I
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_014e: Expected I, but got O
		//IL_159c: Expected O, but got I
		//IL_1539: Unknown result type (might be due to invalid IL or missing references)
		//IL_153e: Expected O, but got Unknown
		//IL_1546: Unknown result type (might be due to invalid IL or missing references)
		//IL_154b: Expected O, but got Unknown
		//IL_1554: Unknown result type (might be due to invalid IL or missing references)
		//IL_1559: Expected O, but got Unknown
		//IL_03e1: Expected I, but got O
		//IL_03f1: Expected O, but got I
		//IL_02b0: Expected O, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_14b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ba: Expected O, but got Unknown
		//IL_14c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c8: Expected O, but got Unknown
		//IL_04a1: Expected O, but got I4
		//IL_04aa: Expected O, but got I4
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_02fe: Expected I, but got O
		//IL_15f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fe: Expected O, but got Unknown
		//IL_1607: Unknown result type (might be due to invalid IL or missing references)
		//IL_160c: Expected O, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_0667: Expected I, but got O
		//IL_0677: Expected O, but got I
		//IL_0699: Expected O, but got I4
		//IL_06a2: Expected O, but got I4
		//IL_042c: Expected O, but got I
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_15aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_15af: Expected O, but got Unknown
		//IL_15b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bd: Expected O, but got Unknown
		//IL_04c0: Expected I, but got O
		//IL_04d0: Expected O, but got I
		//IL_06ce: Expected O, but got I4
		//IL_0566: Expected I, but got O
		//IL_058a: Expected O, but got I4
		//IL_0593: Expected O, but got I4
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected O, but got Unknown
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected O, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got Unknown
		//IL_0625: Expected O, but got I4
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected O, but got Unknown
		//IL_07a1: Expected O, but got I
		//IL_07b9: Expected O, but got I
		//IL_050b: Expected O, but got I
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected O, but got Unknown
		//IL_0850: Expected O, but got I4
		//IL_05aa: Expected O, but got I4
		//IL_05b2: Expected I, but got O
		//IL_05bb: Expected O, but got I4
		//IL_07f4: Expected O, but got I
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected O, but got Unknown
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected O, but got Unknown
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Expected O, but got Unknown
		//IL_0729: Expected I, but got O
		//IL_0753: Expected O, but got I4
		//IL_075b: Expected I, but got O
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected O, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected O, but got Unknown
		//IL_1736: Expected I, but got O
		//IL_1746: Expected O, but got I
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Expected O, but got Unknown
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Expected O, but got Unknown
		//IL_091e: Expected I, but got O
		//IL_0942: Expected O, but got I4
		//IL_094b: Expected O, but got I4
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Expected O, but got Unknown
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected O, but got Unknown
		//IL_0a21: Expected O, but got I
		//IL_08c3: Expected O, but got I
		//IL_0ad3: Expected O, but got I4
		//IL_0adc: Expected O, but got I4
		//IL_0ae5: Expected O, but got I4
		//IL_0962: Expected O, but got I4
		//IL_096a: Expected I, but got O
		//IL_0973: Expected O, but got I4
		//IL_0bd8: Expected I, but got O
		//IL_0be8: Expected O, but got I
		//IL_0a5c: Expected O, but got I
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected O, but got Unknown
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Expected O, but got Unknown
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Expected O, but got Unknown
		//IL_09b9: Expected I, but got O
		//IL_09e3: Expected O, but got I4
		//IL_09eb: Expected I, but got O
		//IL_0c7e: Expected I, but got O
		//IL_0ca2: Expected O, but got I4
		//IL_0cab: Expected O, but got I4
		//IL_0b0b: Expected I, but got O
		//IL_0b1b: Expected O, but got I
		//IL_0b3d: Expected O, but got I4
		//IL_0b45: Expected I, but got O
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Expected O, but got Unknown
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Expected O, but got Unknown
		//IL_0d81: Expected O, but got I
		//IL_0c23: Expected O, but got I
		//IL_0e71: Expected O, but got I
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Expected O, but got Unknown
		//IL_0b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b99: Expected O, but got Unknown
		//IL_0e18: Expected O, but got I4
		//IL_0cc2: Expected O, but got I4
		//IL_0cca: Expected I, but got O
		//IL_0cd3: Expected O, but got I4
		//IL_0b5b: Expected I, but got O
		//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected O, but got Unknown
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Expected O, but got Unknown
		//IL_1811: Expected O, but got I
		//IL_1836: Expected I, but got O
		//IL_1846: Expected O, but got I
		//IL_1862: Expected I, but got O
		//IL_1877: Expected I, but got O
		//IL_0dbc: Expected O, but got I
		//IL_0cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf6: Expected O, but got Unknown
		//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d03: Expected O, but got Unknown
		//IL_0d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d11: Expected O, but got Unknown
		//IL_0d19: Expected I, but got O
		//IL_0d43: Expected O, but got I4
		//IL_0d4b: Expected I, but got O
		//IL_0f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f64: Expected O, but got Unknown
		//IL_0f6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f71: Expected O, but got Unknown
		//IL_0f7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7f: Expected O, but got Unknown
		//IL_0f87: Expected I, but got O
		//IL_0fc1: Expected O, but got I4
		//IL_0ee4: Expected I, but got O
		//IL_0f08: Expected O, but got I4
		//IL_0f11: Expected O, but got I4
		//IL_0c31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c36: Expected O, but got Unknown
		//IL_0c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Expected O, but got Unknown
		//IL_0e7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e84: Expected O, but got Unknown
		//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e92: Expected O, but got Unknown
		//IL_0ff7: Expected O, but got I
		//IL_0e2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e33: Expected O, but got Unknown
		//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4e: Expected O, but got Unknown
		//IL_10a9: Expected O, but got I4
		//IL_10b2: Expected O, but got I4
		//IL_10bb: Expected O, but got I4
		//IL_0f28: Expected O, but got I4
		//IL_0f39: Expected O, but got I4
		//IL_0dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcf: Expected O, but got Unknown
		//IL_0dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddd: Expected O, but got Unknown
		//IL_11ec: Expected I, but got O
		//IL_11fc: Expected O, but got I
		//IL_1032: Expected O, but got I
		//IL_1292: Expected I, but got O
		//IL_12b4: Expected O, but got I4
		//IL_12bd: Expected O, but got I4
		//IL_12ce: Expected O, but got I4
		//IL_10d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dd: Expected O, but got Unknown
		//IL_10ed: Expected I, but got O
		//IL_10fd: Expected O, but got I
		//IL_111f: Expected O, but got I4
		//IL_1128: Expected O, but got I4
		//IL_1130: Expected O, but got I
		//IL_1237: Expected O, but got I
		//IL_118d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1192: Expected O, but got Unknown
		//IL_11a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Expected O, but got Unknown
		//IL_12fc: Expected I, but got O
		//IL_130c: Expected O, but got I
		//IL_1157: Expected O, but got I4
		//IL_115f: Expected O, but got I
		//IL_1040: Unknown result type (might be due to invalid IL or missing references)
		//IL_1045: Expected O, but got Unknown
		//IL_104e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1053: Expected O, but got Unknown
		//IL_139b: Expected O, but got I4
		//IL_13ac: Expected O, but got I4
		//IL_13d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d7: Expected O, but got Unknown
		//IL_13df: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e4: Expected O, but got Unknown
		//IL_13ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f2: Expected O, but got Unknown
		//IL_13fa: Expected I, but got O
		//IL_141e: Expected O, but got I4
		//IL_1427: Expected O, but got I4
		//IL_1347: Expected O, but got I
		//IL_1245: Unknown result type (might be due to invalid IL or missing references)
		//IL_124a: Expected O, but got Unknown
		//IL_1253: Unknown result type (might be due to invalid IL or missing references)
		//IL_1258: Expected O, but got Unknown
		//IL_1928: Expected O, but got I4
		//IL_1355: Unknown result type (might be due to invalid IL or missing references)
		//IL_135a: Expected O, but got Unknown
		//IL_1363: Unknown result type (might be due to invalid IL or missing references)
		//IL_1368: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E85]");
		nint num = 0;
		Encoding uTF = Encoding.UTF8;
		bool flag = credential == null;
		string text2 = default(string);
		string text = text2;
		Encoding encoding = (Encoding)152989696;
		string text3 = text2;
		object obj = default(object);
		object obj3;
		object obj4 = default(object);
		if (!flag)
		{
			obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 896;
			nint num2 = (nint)credential;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v20 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v20 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00c5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v20 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+B0]");
			obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X10_v32-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 = obj3 + 16;
				obj2--;
				bool flag2 = (nint)obj2 != 1;
				obj3 = obj4;
				if (flag2)
				{
					continue;
				}
				goto IL_00c5;
			}
			object obj5 = num2 + obj3;
			object obj6 = obj5 + 312;
			num = (nint)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v506 @ X0_v125] (should have been resolved before IL gen)");
			bool flag3 = uTF == null;
			text = text2;
			obj4 = obj3;
			encoding = uTF;
			text3 = text2;
			if (!flag3)
			{
				goto IL_0195;
			}
		}
		goto IL_1455;
		IL_107b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1483 @ X0_v57] (should have been resolved before IL gen)");
		object obj7 = default(object);
		bool flag4 = obj7 == null;
		object obj8 = !flag4;
		string text4 = (string)3;
		text2 = (string)3;
		if (obj8 == null)
		{
			goto IL_10c9;
		}
		goto IL_11e4;
		IL_17fb:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1543 @ X8_v63] (should have been resolved before IL gen)");
		object obj9 = (nint)0 + (nint)3072;
		string text6 = default(string);
		string text5 = (string)(object)encoding + (string)obj9 + text6;
		object obj10 = obj;
		nint num3 = (nint)credential;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1309 @ X8_v56 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1309 @ X8_v56 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		bool flag5 = (nint)0 == 0;
		nint num4 = unchecked((nint)null);
		text2 = text6;
		encoding = (Encoding)(object)text5;
		nint num5 = unchecked((nint)null);
		object obj12;
		obj3 = obj12;
		object obj13 = obj;
		Encoding encoding2 = (Encoding)(object)text5;
		if (!flag5)
		{
			goto IL_0e5b;
		}
		goto IL_0ed2;
		IL_0e5b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1309 @ X8_v56 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+B0]");
		obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X10_v15-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj3 = obj4 + 16;
			obj11--;
			bool flag6 = (nint)obj11 != 1;
			num5 = num4;
			obj13 = obj10;
			encoding2 = encoding;
			obj4 = obj3;
			if (flag6)
			{
				continue;
			}
			goto IL_0ed2;
		}
		object obj14 = obj4 + 4;
		object obj15 = num3 + obj14;
		object obj16 = obj15 + 312;
		num = (nint)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1376 @ X0_v67] (should have been resolved before IL gen)");
		object obj17 = default(object);
		bool flag7 = obj17 == null;
		num5 = num4;
		obj3 = obj4;
		encoding2 = encoding;
		object obj18 = 0;
		text = text2;
		Credential credential2;
		text3 = (string)(object)credential2;
		if (!flag7)
		{
			goto IL_0fdf;
		}
		goto IL_1455;
		IL_0afb:
		obj10 = obj;
		num3 = (nint)credential;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1309 @ X8_v56 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1309 @ X8_v56 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		bool flag8 = (nint)0 == 0;
		object obj19 = !flag8;
		string text7;
		num4 = (nint)text7;
		if (obj19 != null)
		{
			goto IL_0e5b;
		}
		num5 = (nint)text7;
		obj13 = obj;
		encoding2 = encoding;
		goto IL_0ed2;
		IL_1455:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1463;
		IL_00c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj20 = default(object);
		num = (nint)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v385 @ X0_v122] (should have been resolved before IL gen)");
		bool flag9 = uTF == null;
		object obj21 = !flag9;
		obj3 = obj4;
		if (obj21 != null)
		{
			goto IL_0195;
		}
		text = null;
		encoding = uTF;
		text3 = text2;
		goto IL_1455;
		IL_0195:
		nint num6 = (nint)uTF;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v22 (Il2CppClass<System.Text.Encoding>)+380]");
		text = (string)0;
		byte[] bytes = default(byte[]);
		Encoding encoding3 = (Encoding)(object)uTF.GetString(bytes);
		Encoding uTF2 = Encoding.UTF8;
		nint num7 = (nint)credential;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v23 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v23 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0263;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v23 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+B0]");
		obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X10_v15-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 = obj4 + 16;
			obj22--;
			bool flag10 = (nint)obj22 != 1;
			obj4 = obj3;
			if (flag10)
			{
				continue;
			}
			goto IL_0263;
		}
		object obj23 = obj4 + 1;
		object obj24 = num7 + obj23;
		object obj25 = obj24 + 312;
		num = (nint)obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v744 @ X0_v118] (should have been resolved before IL gen)");
		bool flag11 = uTF2 == null;
		obj3 = obj4;
		encoding = encoding3;
		text3 = text2;
		if (!flag11)
		{
			goto IL_033d;
		}
		goto IL_1455;
		IL_090c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj26 = default(object);
		num = (nint)obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1127 @ X0_v91] (should have been resolved before IL gen)");
		object obj27 = default(object);
		bool flag12 = obj27 == null;
		object obj28 = !flag12;
		text2 = (string)4;
		if (obj28 != null)
		{
			goto IL_0a09;
		}
		obj18 = 0;
		num4 = (nint)text7;
		text = (string)4;
		obj4 = obj3;
		text3 = (string)(object)credential2;
		goto IL_1455;
		IL_0a09:
		object obj29 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X8_v38+12E]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X8_v38+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0aa5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X8_v38+B0]");
		obj12 = (nint)0 + (nint)8;
		object obj31;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1300 @ X10_v51-8]");
			if (0 == (nint)obj31)
			{
				break;
			}
			obj3 = obj12 + 16;
			obj30--;
			bool flag13 = (nint)obj30 != 1;
			obj12 = obj3;
			if (flag13)
			{
				continue;
			}
			goto IL_0aa5;
		}
		object obj32 = obj12 + 2;
		object obj33 = obj29 + obj32;
		object obj34 = obj33 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1228 @ X8_v77] (should have been resolved before IL gen)");
		object obj35 = default(object);
		bool flag14 = obj35 == null;
		obj3 = obj12;
		string text8 = text2;
		if (flag14)
		{
			goto IL_0afb;
		}
		goto IL_0bd0;
		IL_11e4:
		nint num8 = (nint)credential;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1583 @ X8_v42 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1583 @ X8_v42 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_1280;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1583 @ X8_v42 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+B0]");
		obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X10_v15-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 = obj4 + 16;
			obj36--;
			bool flag15 = (nint)obj36 != 1;
			obj4 = obj3;
			if (flag15)
			{
				continue;
			}
			goto IL_1280;
		}
		object obj37 = obj4 + 4;
		object obj38 = num8 + obj37;
		object obj39 = obj38 + 312;
		num = (nint)obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1616 @ X0_v53] (should have been resolved before IL gen)");
		bool flag16 = ex == null;
		object obj40 = !flag16;
		obj18 = 0;
		num4 = num5;
		text = text2;
		encoding = encoding2;
		text3 = (string)(object)credential2;
		if (obj40 != null)
		{
			goto IL_12f4;
		}
		goto IL_1455;
		IL_1463:
		object obj41 = obj4 + 3;
		object obj42 = num + obj41;
		object obj43 = obj42 + 312;
		goto IL_1956;
		IL_0263:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj44 = default(object);
		num = (nint)obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v666 @ X0_v115] (should have been resolved before IL gen)");
		bool flag17 = uTF2 == null;
		object obj45 = !flag17;
		if (obj45 != null)
		{
			goto IL_033d;
		}
		text = (string)1;
		obj4 = obj3;
		encoding = encoding3;
		text3 = text2;
		goto IL_1455;
		IL_033d:
		object obj46 = typeof(MemberAchievementClanFeedData) + 2920;
		object providerId = "alignContent" + 2056;
		nint num9 = (nint)uTF2;
		byte[] bytes2 = default(byte[]);
		text7 = uTF2.GetString(bytes2);
		object obj47 = obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X0_v34+E4]");
		bool flag18 = (nint)0 == 0;
		object obj48 = !flag18;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		credential2 = OAuthProvider.GetCredential((string)providerId, (string)(object)encoding3, text2, text7);
		nint num10 = (nint)credential;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v27 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v27 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0475;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v27 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+B0]");
		object obj50 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X10_v86-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 = obj50 + 16;
			obj49--;
			bool flag19 = (nint)obj49 != 1;
			obj50 = obj3;
			if (flag19)
			{
				continue;
			}
			goto IL_0475;
		}
		object obj51 = obj50 + 4;
		object obj52 = num10 + obj51;
		object obj53 = obj52 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v933 @ X0_v110] (should have been resolved before IL gen)");
		object obj54 = default(object);
		bool flag20 = obj54 == null;
		object obj55 = !flag20;
		obj3 = obj50;
		text4 = text2;
		if (obj55 != null)
		{
			goto IL_04b8;
		}
		goto IL_0643;
		IL_15dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text4 = null;
		goto IL_1aab;
		IL_0c6c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj56 = default(object);
		num = (nint)obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1328 @ X0_v79] (should have been resolved before IL gen)");
		object obj57 = default(object);
		bool flag21 = obj57 == null;
		object obj58 = !flag21;
		text8 = (string)4;
		if (obj58 != null)
		{
			goto IL_0d69;
		}
		obj18 = 0;
		num4 = (nint)text7;
		text = (string)4;
		obj4 = obj12;
		text3 = (string)(object)credential2;
		goto IL_1455;
		IL_0aa5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1195 @ X0_v86] (should have been resolved before IL gen)");
		object obj59 = default(object);
		bool flag22 = obj59 == null;
		object obj60 = !flag22;
		text2 = (string)2;
		text8 = (string)2;
		obj12 = obj3;
		if (obj60 == null)
		{
			goto IL_0afb;
		}
		goto IL_0bd0;
		IL_0bd0:
		nint num11 = (nint)credential;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v60 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v60 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0c6c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v60 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+B0]");
		obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X10_v15-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj12 = obj4 + 16;
			obj61--;
			bool flag23 = (nint)obj61 != 1;
			obj4 = obj12;
			if (flag23)
			{
				continue;
			}
			goto IL_0c6c;
		}
		object obj62 = obj4 + 4;
		object obj63 = num11 + obj62;
		object obj64 = obj63 + 312;
		num = (nint)obj64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1381 @ X0_v82] (should have been resolved before IL gen)");
		bool flag24 = obj57 == null;
		obj12 = obj4;
		obj18 = 0;
		num4 = (nint)text7;
		text = text8;
		text3 = (string)(object)credential2;
		if (!flag24)
		{
			goto IL_0d69;
		}
		goto IL_1455;
		IL_0ed2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj65 = default(object);
		num = (nint)obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1346 @ X0_v63] (should have been resolved before IL gen)");
		bool flag25 = obj17 == null;
		object obj66 = !flag25;
		text2 = (string)4;
		if (obj66 != null)
		{
			goto IL_0fdf;
		}
		obj18 = 0;
		num4 = num5;
		text = (string)4;
		obj4 = obj3;
		encoding = encoding2;
		text3 = (string)(object)credential2;
		goto IL_1455;
		IL_1956:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v487 @ X8_v9] (should have been resolved before IL gen)");
		object obj67 = (nint)0 + (nint)3072;
		string text10 = default(string);
		string text9 = (string)(object)encoding + (string)obj67 + text10;
		object obj68 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1928;
		object obj69 = obj;
		nint num12 = (nint)credential;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v14 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		object obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v14 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		bool flag26 = (nint)0 == 0;
		string text11 = null;
		text4 = text10;
		string text12 = text9;
		object obj71 = obj18;
		string text13 = null;
		object obj72 = obj68;
		object obj73 = obj;
		string displayName = text9;
		string credential3 = text3;
		if (!flag26)
		{
			goto IL_1491;
		}
		goto IL_1518;
		IL_0475:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v902 @ X0_v107] (should have been resolved before IL gen)");
		object obj74 = default(object);
		bool flag27 = obj74 == null;
		text2 = (string)4;
		text4 = (string)4;
		if (!flag27)
		{
			goto IL_04b8;
		}
		goto IL_0643;
		IL_0643:
		obj68 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1928;
		obj69 = obj;
		num12 = (nint)credential;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v14 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v14 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		bool flag28 = (nint)0 == 0;
		object obj75 = !flag28;
		obj18 = 0;
		text11 = text7;
		text12 = null;
		text3 = (string)(object)credential2;
		if (obj75 != null)
		{
			goto IL_1491;
		}
		obj71 = 0;
		text13 = text7;
		obj72 = obj68;
		obj73 = obj;
		displayName = null;
		credential3 = (string)(object)credential2;
		goto IL_1518;
		IL_12f4:
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v16 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v16 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_1388;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v16 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X10_v15-8]");
			bool flag29 = 0 == (nint)obj31;
			obj18 = 0;
			num4 = num5;
			text = text2;
			encoding = encoding2;
			text3 = (string)(object)credential2;
			if (flag29)
			{
				break;
			}
			obj4 += 16;
			obj76--;
			if ((nint)obj76 != 1)
			{
				continue;
			}
			goto IL_1388;
		}
		goto IL_1463;
		IL_04b8:
		nint num13 = (nint)credential;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X8_v31 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X8_v31 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0554;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X8_v31 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+B0]");
		obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X10_v15-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 = obj4 + 16;
			obj77--;
			bool flag30 = (nint)obj77 != 1;
			obj4 = obj3;
			if (flag30)
			{
				continue;
			}
			goto IL_0554;
		}
		object obj78 = obj4 + 4;
		object obj79 = num13 + obj78;
		object obj80 = obj79 + 312;
		num = (nint)obj80;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v997 @ X0_v103] (should have been resolved before IL gen)");
		object obj81 = default(object);
		bool flag31 = obj81 == null;
		obj3 = obj4;
		obj18 = 0;
		num4 = (nint)text7;
		text = text2;
		encoding = encoding3;
		text3 = (string)(object)credential2;
		if (!flag31)
		{
			goto IL_0781;
		}
		goto IL_1455;
		IL_0fdf:
		object obj82 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1423 @ X8_v40+12E]");
		object obj83 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1423 @ X8_v40+12E]");
		if ((nint)0 == 0)
		{
			goto IL_107b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1423 @ X8_v40+B0]");
		object obj84 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1517 @ X10_v41-8]");
			if (0 == (nint)obj31)
			{
				break;
			}
			obj3 = obj84 + 16;
			obj83--;
			bool flag32 = (nint)obj83 != 1;
			obj84 = obj3;
			if (flag32)
			{
				continue;
			}
			goto IL_107b;
		}
		object obj85 = obj84 + 3;
		object obj86 = obj82 + obj85;
		object obj87 = obj86 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1555 @ X8_v53] (should have been resolved before IL gen)");
		object obj88 = default(object);
		bool flag33 = obj88 == null;
		text4 = text2;
		obj3 = obj84;
		if (flag33)
		{
			goto IL_10c9;
		}
		goto IL_11e4;
		IL_1aab:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v852 @ X0_v7] (should have been resolved before IL gen)");
		string email = default(string);
		string userId = default(string);
		SigninCallbackHelper((Credential)(object)credential3, email, userId, SocialPlatform.Apple, displayName);
		return;
		IL_1518:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text4 = (string)5;
		goto IL_1a40;
		IL_1491:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v14 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+B0]");
		object obj89 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X10_v13-8]");
			if (0 == (nint)obj69)
			{
				break;
			}
			obj89 += 16;
			obj70--;
			bool flag34 = (nint)obj70 != 1;
			obj71 = obj18;
			text13 = text11;
			obj72 = obj68;
			obj73 = obj69;
			displayName = text12;
			credential3 = text3;
			if (flag34)
			{
				continue;
			}
			goto IL_1518;
		}
		object obj90 = obj89 + 5;
		object obj91 = num12 + obj90;
		object obj92 = obj91 + 312;
		obj71 = obj18;
		text13 = text11;
		obj72 = obj68;
		displayName = text12;
		credential3 = text3;
		goto IL_1a40;
		IL_0554:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj93 = default(object);
		num = (nint)obj93;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v980 @ X0_v100] (should have been resolved before IL gen)");
		bool flag35 = obj81 == null;
		object obj94 = !flag35;
		text2 = (string)4;
		if (obj94 != null)
		{
			goto IL_0781;
		}
		obj18 = 0;
		num4 = (nint)text7;
		text = (string)4;
		obj4 = obj3;
		encoding = encoding3;
		text3 = (string)(object)credential2;
		goto IL_1455;
		IL_0781:
		obj31 = typeof(System.IOAsyncCallback) + 240;
		object obj95 = (nint)0 + (nint)2000;
		object obj96 = obj81;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ X8_v33+12E]");
		object obj97 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ X8_v33+12E]");
		if ((nint)0 == 0)
		{
			goto IL_083d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ X8_v33+B0]");
		object obj98 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ X10_v76-8]");
			if (0 == (nint)obj31)
			{
				break;
			}
			obj3 = obj98 + 16;
			obj97--;
			bool flag36 = (nint)obj97 != 1;
			obj98 = obj3;
			if (flag36)
			{
				continue;
			}
			goto IL_083d;
		}
		object obj99 = obj98 + 1;
		object obj100 = obj96 + obj99;
		object obj101 = obj100 + 312;
		obj3 = obj98;
		goto IL_1704;
		IL_0d69:
		object obj102 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1401 @ X8_v62+12E]");
		object obj103 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1401 @ X8_v62+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0e05;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1401 @ X8_v62+B0]");
		object obj104 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ X10_v55-8]");
			if (0 == (nint)obj31)
			{
				break;
			}
			obj12 = obj104 + 16;
			obj103--;
			bool flag37 = (nint)obj103 != 1;
			obj104 = obj12;
			if (flag37)
			{
				continue;
			}
			goto IL_0e05;
		}
		object obj105 = obj104 + 2;
		object obj106 = obj102 + obj105;
		object obj107 = obj106 + 312;
		obj12 = obj104;
		goto IL_17fb;
		IL_1280:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj108 = default(object);
		num = (nint)obj108;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1600 @ X0_v50] (should have been resolved before IL gen)");
		bool flag38 = ex == null;
		text2 = (string)4;
		obj18 = 0;
		num4 = num5;
		text = (string)4;
		obj4 = obj3;
		encoding = encoding2;
		text3 = (string)(object)credential2;
		if (!flag38)
		{
			goto IL_12f4;
		}
		goto IL_1455;
		IL_1388:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj18 = 0;
		num4 = num5;
		text = (string)3;
		object obj109 = default(object);
		obj43 = obj109;
		encoding = encoding2;
		text3 = (string)(object)credential2;
		goto IL_1956;
		IL_10c9:
		obj68 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1928;
		obj69 = obj;
		num12 = (nint)credential;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v14 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v14 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		bool flag39 = (nint)0 == 0;
		object obj110 = !flag39;
		obj18 = 0;
		text11 = (string)num5;
		text12 = (string)(object)encoding2;
		text3 = (string)(object)credential2;
		if (obj110 != null)
		{
			goto IL_1491;
		}
		obj71 = 0;
		text13 = (string)num5;
		obj72 = obj68;
		obj73 = obj;
		displayName = (string)(object)encoding2;
		credential3 = (string)(object)credential2;
		goto IL_1518;
		IL_083d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text2 = (string)1;
		object obj111 = default(object);
		obj101 = obj111;
		goto IL_1704;
		IL_1704:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1092 @ X8_v34] (should have been resolved before IL gen)");
		Encoding encoding4 = default(Encoding);
		encoding = (Encoding)((encoding4 != null) ? encoding4 : obj95);
		nint num14 = (nint)credential;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1110 @ X8_v36 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		object obj112 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1110 @ X8_v36 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_090c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1110 @ X8_v36 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+B0]");
		obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X10_v15-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 = obj4 + 16;
			obj112--;
			bool flag40 = (nint)obj112 != 1;
			obj4 = obj3;
			if (flag40)
			{
				continue;
			}
			goto IL_090c;
		}
		object obj113 = obj4 + 4;
		object obj114 = num14 + obj113;
		object obj115 = obj114 + 312;
		num = (nint)obj115;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1144 @ X0_v94] (should have been resolved before IL gen)");
		bool flag41 = obj27 == null;
		obj3 = obj4;
		obj18 = 0;
		num4 = (nint)text7;
		text = text2;
		text3 = (string)(object)credential2;
		if (!flag41)
		{
			goto IL_0a09;
		}
		goto IL_1455;
		IL_0e05:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text8 = (string)2;
		object obj116 = default(object);
		obj107 = obj116;
		goto IL_17fb;
		IL_1a40:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v727 @ X0_v4] (should have been resolved before IL gen)");
		nint num15 = (nint)credential;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X8_v5 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		object obj117 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X8_v5 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_15dd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X8_v5 (Il2CppClass<AppleAuth.Interfaces.IAppleIDCredential>)+B0]");
		object obj118 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X10_v6-8]");
			if (0 == (nint)obj72)
			{
				break;
			}
			obj118 += 16;
			obj117--;
			if ((nint)obj117 != 1)
			{
				continue;
			}
			goto IL_15dd;
		}
		object obj119 = num15 + obj118;
		object obj120 = obj119 + 312;
		goto IL_1aab;
	}
}
