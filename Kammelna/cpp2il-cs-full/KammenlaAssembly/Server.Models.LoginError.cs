using System;
using System.Collections.Generic;
using System.Data;
using Cpp2ILInjected;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Core;
using Sfs2X.Entities.Data;
using Util;

namespace Server.Models;

public class LoginError
{
	private const string C_ErrorMessage = "errorMessage";

	private const string C_ErrorCode = "err";

	private const string C_LastServerId = "lsi";

	private const string C_KickedUntil = "ku";

	private const string C_KickReason = "kr";

	private LoginErrorCode <Error>k__BackingField;

	private string <KickErrorMessage>k__BackingField;

	private DateTime <KickErrorDuration>k__BackingField;

	private string <LastServerId>k__BackingField;

	public LoginErrorCode Error
	{
		get
		{
			return <Error>k__BackingField;
		}
		set
		{
			<Error>k__BackingField = value;
		}
	}

	public string KickErrorMessage
	{
		get
		{
			return <KickErrorMessage>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public DateTime KickErrorDuration
	{
		get
		{
			return <KickErrorDuration>k__BackingField;
		}
		set
		{
			<KickErrorDuration>k__BackingField = value;
		}
	}

	public string LastServerId
	{
		get
		{
			return <LastServerId>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public LoginError(LoginErrorCode error)
	{
		<Error>k__BackingField = error;
	}

	public LoginError(BaseEvent evt)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005a: Expected I, but got O
		//IL_006a: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0157: Expected O, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01f3: Expected I8, but got I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0235: Expected O, but got I4
		//IL_05d7: Expected I, but got O
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02c5: Expected I, but got O
		//IL_02d5: Expected O, but got I
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected O, but got Unknown
		//IL_06d3: Expected O, but got I4
		//IL_0310: Expected O, but got I
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		//IL_04a4: Expected O, but got I4
		//IL_04ad: Expected O, but got I4
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_0547: Expected O, but got I4
		//IL_03f7: Expected O, but got I4
		//IL_0407: Expected O, but got I
		//IL_0417: Expected O, but got I
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_0452: Expected O, but got I4
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected O, but got Unknown
		//IL_04fb: Expected O, but got I4
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		object obj2;
		object obj5;
		if (evt != null)
		{
			IDictionary<string, object> dictionary = evt.Params;
			if (dictionary != null)
			{
				object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
				obj2 = "destinationTimeZone" + 2712;
				nint num = (nint)dictionary;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00e6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
				object obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X10_v13-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj4 += 16;
					obj3--;
					if ((nint)obj3 != 1)
					{
						continue;
					}
					goto IL_00e6;
				}
				obj5 = (object)(num + obj4) + 312;
				goto IL_0648;
			}
			NullReferenceException ex = new NullReferenceException();
			string text = null;
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
			string text = null;
		}
		goto IL_05dc;
		IL_0351:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_06a3;
		IL_05dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj6 = default(object);
		obj5 = obj6;
		goto IL_0648;
		IL_06a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v451 @ X0_v26] (should have been resolved before IL gen)");
		object obj8 = default(object);
		object obj7 = obj8 & 1;
		bool flag = obj7 == null;
		object obj9 = 0;
		ISFSObject iSFSObject;
		object varName;
		if (!flag)
		{
			object obj10 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v34+90]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v35+B8]");
			string text2 = SFSExtensions.Get(iSFSObject, (string)varName, (string)0);
			object obj12 = this + 24;
			obj12 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj9 = 0;
		}
		object obj13 = this + 24;
		object obj14 = "fetch_products" + 816;
		string text3 = (string)obj14;
		object obj15 = (string)obj13 == (string)obj14;
		object obj16 = 0;
		if (obj15 == null)
		{
			object obj17 = "SubscribeGroup request Error" + 296;
			text3 = (string)obj17;
			bool flag2 = !((string)obj13 == (string)obj17);
			obj16 = 0;
			if (flag2)
			{
				return;
			}
		}
		object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v33+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		obj13 = LocalizationUtil.Localize((string)obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0648:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v7+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v140 @ X8_v7] (should have been resolved before IL gen)");
		object obj19 = default(object);
		if (obj19 != null)
		{
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v224 @ X8_v8+168] (should have been resolved before IL gen)");
			string js = default(string);
			iSFSObject = SFSObject.NewFromJsonData(js);
			object obj21 = "destinationTimeZone" + 2680;
			object obj22 = (nint)0 + (nint)128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
			LoginErrorCode loginErrorCode = default(LoginErrorCode);
			<Error>k__BackingField = loginErrorCode;
			switch (loginErrorCode)
			{
			case LoginErrorCode.Kicked:
			case LoginErrorCode.Banned:
				break;
			case LoginErrorCode.LoggedToDifferentServer:
			{
				int num3 = SFSExtensions.Get(iSFSObject, "java.io.FileOutputStream" + 3496, 0);
				int num4 = default(int);
				string text4 = num4.ToString();
				object obj23 = this + 40;
				obj23 = text4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return;
			}
			default:
				return;
			}
			object obj24 = "java.io.FileOutputStream" + 984;
			string text = (string)obj24;
			long num5 = SFSExtensions.Get(iSFSObject, (string)obj24, 0L);
			object obj25 = typeof(DataRelation) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v21+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			<KickErrorDuration>k__BackingField = DateTimeUtil.FromTimeStamp((double)num5 / 4.652007308841189E+18);
			if (iSFSObject != null)
			{
				object obj26 = typeof(System.IOAsyncCallback) + 976;
				varName = "java.io.FileOutputStream" + 928;
				nint num6 = (nint)iSFSObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0351;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj28 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X10_v8-8]");
					if (0 == (nint)obj26)
					{
						break;
					}
					obj28 += 16;
					obj27--;
					if ((nint)obj27 != 1)
					{
						continue;
					}
					goto IL_0351;
				}
				object obj29 = (object)(num6 + (object)(obj28 + 1)) + 312;
				goto IL_06a3;
			}
			NullReferenceException ex = new NullReferenceException();
			num2 = unchecked((nint)null);
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
			string text = (string)obj2;
		}
		goto IL_05dc;
	}
}
