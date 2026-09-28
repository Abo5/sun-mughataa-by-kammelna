using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanChatMuteModel
{
	public int ClanId;

	public string Reason;

	public long MutedByUserId;

	public long? UserId;

	public DateTime MutedUntil;

	public DateTime CreatedAt;

	public static ClanChatMuteModel Parse(ISFSObject data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0053: Expected I, but got O
		//IL_0063: Expected O, but got I
		//IL_0519: Expected I, but got O
		//IL_0529: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_018d: Expected O, but got I
		//IL_01b1: Expected O, but got I4
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0286: Expected O, but got I4
		//IL_0132: Expected O, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_02cf: Expected I, but got O
		//IL_02df: Expected O, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_0205: Expected O, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_05a6: Expected O, but got I
		//IL_05ca: Expected O, but got I4
		//IL_031a: Expected O, but got I
		//IL_05f9: Expected O, but got I4
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_03b7: Expected I, but got O
		//IL_03c7: Expected O, but got I
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_0643: Expected O, but got I
		//IL_0402: Expected O, but got I
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		if (data == null)
		{
			goto IL_04a5;
		}
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "m_StencilDeferredPS" + 2704;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1144;
		object obj4 = "clear_mass_tournaments" + 64;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00df;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X10_v25-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj6 += 16;
			obj5--;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_00df;
		}
		object obj7 = obj6 + 15;
		object obj8 = num + obj7;
		object obj9 = obj8 + 312;
		goto IL_04f4;
		IL_0662:
		object obj10;
		object obj12;
		if (obj10 != null)
		{
			object obj11 = obj10 + 24;
			obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (ClanChatMuteModel)obj10;
		}
		goto IL_04a5;
		IL_0173:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v35+8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v310 @ X0_v35] (should have been resolved before IL gen)");
		object obj14 = default(object);
		bool flag = obj14 == null;
		object obj15 = !flag;
		object obj16 = obj4;
		if (obj15 != null)
		{
			goto IL_0234;
		}
		goto IL_04a5;
		IL_0234:
		object obj17 = typeof(DataRelation) + 768;
		object obj18 = "placementId" + 2064;
		object obj19 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj20 = !flag2;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long milliseconds = default(long);
		DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(milliseconds);
		DateTimeOffset dateTimeOffset2 = default(DateTimeOffset);
		DateTime utcDateTime = dateTimeOffset2.UtcDateTime;
		nint num2 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_035b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj22 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X10_v15-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj22 += 16;
			obj21--;
			if ((nint)obj21 != 1)
			{
				continue;
			}
			goto IL_035b;
		}
		object obj23 = obj22 + 1;
		object obj24 = num2 + obj23;
		object obj25 = obj24 + 312;
		goto IL_0596;
		IL_0443:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0633;
		IL_0633:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v24+8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v537 @ X0_v24] (should have been resolved before IL gen)");
		object obj27 = default(object);
		obj12 = obj27;
		object obj28;
		obj10 = obj28;
		goto IL_0662;
		IL_00df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_04f4;
		IL_04f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X0_v4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj14..ctor();
		nint num3 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0173;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj30 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X10_v20-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj30 += 16;
			obj29--;
			if ((nint)obj29 != 1)
			{
				continue;
			}
			goto IL_0173;
		}
		object obj31 = obj30 + 14;
		object obj32 = num3 + obj31;
		object obj33 = obj32 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v38+8]");
		obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v327 @ X0_v38] (should have been resolved before IL gen)");
		bool flag3 = obj14 == null;
		obj16 = obj4;
		if (!flag3)
		{
			goto IL_0234;
		}
		goto IL_04a5;
		IL_04a5:
		return (ClanChatMuteModel)(object)new NullReferenceException();
		IL_035b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0596;
		IL_0596:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v16+8]");
		obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v434 @ X0_v16] (should have been resolved before IL gen)");
		object obj34 = default(object);
		bool flag4 = obj34 == null;
		object obj35 = !flag4;
		object obj36 = ~obj35;
		obj28 = ((obj36 != null) ? null : obj14);
		bool flag5 = obj34 == null;
		obj12 = 0;
		obj10 = obj14;
		if (!flag5)
		{
			nint num4 = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v18 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v18 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0443;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v18 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj38 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X10_v10-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj38 += 16;
				obj37--;
				if ((nint)obj37 != 1)
				{
					continue;
				}
				goto IL_0443;
			}
			object obj39 = obj38 + 18;
			object obj40 = num4 + obj39;
			object obj41 = obj40 + 312;
			goto IL_0633;
		}
		goto IL_0662;
	}
}
