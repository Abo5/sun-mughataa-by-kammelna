using System;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

public class LiveCatchingInfo
{
	private readonly string <CatchCheatMode>k__BackingField;

	private readonly Card <WrongCard>k__BackingField;

	private readonly Card <AllowedCard>k__BackingField;

	public string CatchCheatMode => <CatchCheatMode>k__BackingField;

	public Card WrongCard => <WrongCard>k__BackingField;

	public Card AllowedCard => <AllowedCard>k__BackingField;

	public LiveCatchingInfo(ISFSObject response, KGame game)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0108: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_0269: Expected O, but got I4
		//IL_02ab: Expected O, but got I4
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2536;
		object varName2 = "utf-32" + 1192;
		object varName3 = "___# Content push apply failed [{0}]: {1}" + 2808;
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		base..ctor();
		string text = SFSExtensions.Get(response, (string)varName, (string)null);
		object obj2 = this + 16;
		obj2 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text2 = SFSExtensions.Get(response, (string)varName2, (string)null);
		string text3 = SFSExtensions.Get(response, (string)varName3, (string)null);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v12+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		if (StringsExtensions.IsNullOrEmpty(text2))
		{
			object obj5 = this + 24;
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			Card card = null;
			if (!flag)
			{
				goto IL_0144;
			}
		}
		else
		{
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v29+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Card card2 = CardUtils.FromString(text2);
			object obj8 = this + 24;
			obj8 = card2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v25+E4]");
			object obj9 = (nint)0 != 0;
			Card card = card2;
			if (obj9 != null)
			{
				goto IL_0144;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj10 = StringsExtensions.IsNullOrEmpty(text3);
		Card card3 = null;
		Card card4 = null;
		if (obj10 == null)
		{
			goto IL_0281;
		}
		goto IL_031c;
		IL_0281:
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v20+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		card4 = CardUtils.FromString(text3);
		goto IL_031c;
		IL_031c:
		object obj12 = this + 32;
		obj12 = card4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0144:
		bool flag2 = !StringsExtensions.IsNullOrEmpty(text3);
		card3 = null;
		if (flag2)
		{
			goto IL_0281;
		}
		card4 = null;
		goto IL_031c;
	}

	public static ISFSObject SendCheatingData(Card wrongCard, Card allowedCard, string mode)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005a: Expected I, but got O
		//IL_006a: Expected O, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0164: Expected I, but got O
		//IL_0174: Expected O, but got I
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0261: Expected I, but got O
		//IL_0271: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_01af: Expected O, but got I
		//IL_02ac: Expected O, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		if (wrongCard == null)
		{
			goto IL_037c;
		}
		string text = wrongCard.ToString();
		if (sFSObject == null)
		{
			goto IL_032a;
		}
		object obj3 = "utf-32" + 1192;
		nint num = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X10_v21-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj5 += 16;
			obj4--;
			if ((nint)obj4 != 1)
			{
				continue;
			}
			goto IL_00e6;
		}
		object obj6 = obj5 + 39;
		object obj7 = num + obj6;
		object obj8 = obj7 + 312;
		goto IL_03bd;
		IL_0400:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v16+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v430 @ X0_v16] (should have been resolved before IL gen)");
		goto IL_0452;
		IL_0452:
		if (mode != null)
		{
			if (sFSObject == null)
			{
				goto IL_032a;
			}
			object obj9 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2536;
			nint num3 = (nint)sFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02ed;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X10_v8-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj11 += 16;
				obj10--;
				if ((nint)obj10 != 1)
				{
					continue;
				}
				goto IL_02ed;
			}
			object obj12 = obj11 + 39;
			object obj13 = num3 + obj12;
			object obj14 = obj13 + 312;
			goto IL_0443;
		}
		goto IL_046f;
		IL_046f:
		return sFSObject;
		IL_032a:
		return (ISFSObject)new NullReferenceException();
		IL_0443:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v460 @ X0_v8] (should have been resolved before IL gen)");
		goto IL_046f;
		IL_02ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0443;
		IL_00e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_03bd;
		IL_03bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v26+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v371 @ X0_v26] (should have been resolved before IL gen)");
		goto IL_037c;
		IL_037c:
		if (allowedCard != null)
		{
			string text2 = allowedCard.ToString();
			if (sFSObject == null)
			{
				goto IL_032a;
			}
			object obj15 = "___# Content push apply failed [{0}]: {1}" + 2808;
			nint num4 = (nint)sFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01f0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
			object obj17 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X10_v14-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj17 += 16;
				obj16--;
				if ((nint)obj16 != 1)
				{
					continue;
				}
				goto IL_01f0;
			}
			object obj18 = obj17 + 39;
			object obj19 = num4 + obj18;
			object obj20 = obj19 + 312;
			goto IL_0400;
		}
		goto IL_0452;
		IL_01f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0400;
	}
}
