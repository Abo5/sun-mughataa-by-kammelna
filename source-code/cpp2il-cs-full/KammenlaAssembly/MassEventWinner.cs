using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities.Data;
using UnityEngine;

[Serializable]
public class MassEventWinner
{
	private DateTime <Date>k__BackingField;

	private int <Place>k__BackingField;

	private List<LeaderBoardPlayer> <Players>k__BackingField;

	public DateTime Date
	{
		get
		{
			return <Date>k__BackingField;
		}
		set
		{
			<Date>k__BackingField = value;
		}
	}

	public int Place
	{
		get
		{
			return <Place>k__BackingField;
		}
		set
		{
			<Place>k__BackingField = value;
		}
	}

	public List<LeaderBoardPlayer> Players
	{
		get
		{
			return <Players>k__BackingField;
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

	public static MassEventWinner FromSfsObject(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_022e: Expected O, but got I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_00fd: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_0111: Expected I, but got O
		//IL_0121: Expected O, but got I
		//IL_0279: Expected I, but got O
		//IL_015c: Expected O, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3768;
		object varName = "not" + 3736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		DateTime? defaultValue = (DateTime)0;
		DateTime? dateTime = SFSExtensions.Get(data, (string)varName, defaultValue);
		DateTime? dateTime2 = default(DateTime?);
		DateTime value = dateTime2.Value;
		object obj6;
		if (obj2 != null)
		{
			object varName2 = "placementId" + 224;
			int num = SFSExtensions.Get(data, (string)varName2, 0);
			if (data != null)
			{
				object obj3 = typeof(System.IOAsyncCallback) + 976;
				object obj4 = "utf-32" + 1368;
				object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1632;
				obj6 = (nint)0 + (nint)536;
				object obj7 = (nint)0 + (nint)464;
				nint num2 = (nint)data;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_019d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj9 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X10_v5-8]");
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
					goto IL_019d;
				}
				object obj10 = obj9 + 28;
				object obj11 = num2 + obj10;
				object obj12 = obj11 + 312;
				goto IL_0257;
			}
		}
		return (MassEventWinner)(object)new NullReferenceException();
		IL_019d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0257;
		IL_0257:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v252 @ X0_v13] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)null, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3020370");
		object obj13 = obj2 + 32;
		object obj14 = default(object);
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (MassEventWinner)obj2;
	}
}
