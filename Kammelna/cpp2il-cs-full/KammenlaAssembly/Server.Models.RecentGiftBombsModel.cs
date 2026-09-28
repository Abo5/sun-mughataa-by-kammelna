using System;
using System.Buffers.Text;
using System.Collections.Generic;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Sfs2X.Entities.Data;
using UnityEngine;

namespace Server.Models;

public class RecentGiftBombsModel
{
	private long <ETag>k__BackingField;

	private List<GiftBombData> <GiftBombs>k__BackingField;

	public long ETag
	{
		get
		{
			return <ETag>k__BackingField;
		}
		set
		{
			<ETag>k__BackingField = value;
		}
	}

	public List<GiftBombData> GiftBombs
	{
		get
		{
			return <GiftBombs>k__BackingField;
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

	public static RecentGiftBombsModel FromSfsObject(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_01df: Expected I8, but got I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00aa: Expected O, but got I
		//IL_00b6: Expected O, but got I
		//IL_00be: Expected I, but got O
		//IL_00ce: Expected O, but got I
		//IL_022e: Expected I, but got O
		//IL_0109: Expected O, but got I
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3472;
		object varName = "destinationTimeZone" + 1040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		long num = SFSExtensions.Get(data, (string)varName, 0L);
		object obj6;
		if (obj2 != null && data != null)
		{
			object obj3 = typeof(System.IOAsyncCallback) + 976;
			object obj4 = "com.unity.services.authentication.profile" + 2776;
			object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1624;
			obj6 = (nint)0 + (nint)3144;
			object obj7 = (nint)0 + (nint)456;
			nint num2 = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_014a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj9 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X10_v5-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj9 += 16;
				obj8--;
				if ((nint)obj8 != 1)
				{
					continue;
				}
				goto IL_014a;
			}
			object obj10 = obj9 + 28;
			object obj11 = num2 + obj10;
			object obj12 = obj11 + 312;
			goto IL_020c;
		}
		return (RecentGiftBombsModel)(object)new NullReferenceException();
		IL_014a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_020c;
		IL_020c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v215 @ X0_v7] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)null, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3020370");
		object obj13 = obj2 + 24;
		object obj14 = default(object);
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (RecentGiftBombsModel)obj2;
	}
}
