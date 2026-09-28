using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Sfs2X.Entities.Data;
using Unity.Properties;
using UnityEngine;

public class GiftNotification
{
	private const string C_ItemId = "item_id";

	private const string C_Sender = "sender";

	private const string C_Recipients = "recipients";

	private int <ItemId>k__BackingField;

	private long <SenderId>k__BackingField;

	private long[] <Recipients>k__BackingField;

	public int ItemId
	{
		get
		{
			return <ItemId>k__BackingField;
		}
		set
		{
			<ItemId>k__BackingField = value;
		}
	}

	public long SenderId
	{
		get
		{
			return <SenderId>k__BackingField;
		}
		set
		{
			<SenderId>k__BackingField = value;
		}
	}

	public bool AdCampaign
	{
		get
		{
			//IL_0010: Expected O, but got I8
			object obj = <SenderId>k__BackingField + 1;
			return obj == null;
		}
	}

	public long[] Recipients
	{
		get
		{
			return <Recipients>k__BackingField;
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

	public GiftNotification()
	{
	}

	public GiftNotification(ISFSObject param)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Expected I8, but got I4
		//IL_003b: Expected O, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_009b: Expected O, but got I
		//IL_00a7: Expected O, but got I
		//IL_00e4: Expected I, but got O
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		object varName = "https://www.kammelna.com/Home/Terms" + 3848;
		object varName2 = "rightCtrl" + 1936;
		base..ctor();
		int num = SFSExtensions.Get(param, (string)varName, 0);
		<ItemId>k__BackingField = num;
		int num2 = SFSExtensions.Get(param, (string)varName2, 0);
		<SenderId>k__BackingField = num2;
		if ((object)(num2 + 1) != null)
		{
			object obj = typeof(TypeConverter<ushort, char>) + 3048;
			object varName3 = "placementId" + 2608;
			object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1880;
			object obj3 = (nint)0 + (nint)3080;
			object obj4 = (nint)0 + (nint)3480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			int[] defaultValue = default(int[]);
			int[] source = SFSExtensions.Get(param, (string)varName3, defaultValue);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<int, long> func = default(Func<int, long>);
			func..ctor((object)null, (IntPtr)obj3);
			long[] array = Enumerable.ToArray(Enumerable.Select(source, func));
			object obj5 = this + 32;
			obj5 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public ISFSObject ToSfsObject()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_0062: Expected I, but got O
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d4: Expected I, but got O
		//IL_00e4: Expected O, but got I
		//IL_011f: Expected O, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "https://www.kammelna.com/Home/Terms" + 3848;
		object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1960;
		object obj3 = (nint)0 + (nint)3040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, <ItemId>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<long, int> func = default(Func<long, int>);
		func..ctor((object)null, (IntPtr)obj3);
		IEnumerable<int> source = Enumerable.Select(<Recipients>k__BackingField, func);
		int[] array = Enumerable.ToArray(source);
		if (sFSObject != null)
		{
			object obj4 = typeof(System.IOAsyncCallback) + 976;
			object obj5 = "placementId" + 2608;
			nint num = (nint)sFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0160;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
			object obj7 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X10_v5-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				obj7 += 16;
				obj6--;
				if ((nint)obj6 != 1)
				{
					continue;
				}
				goto IL_0160;
			}
			object obj8 = obj7 + 44;
			object obj9 = num + obj8;
			object obj10 = obj9 + 312;
			goto IL_0226;
		}
		return (ISFSObject)new NullReferenceException();
		IL_0226:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v243 @ X0_v11] (should have been resolved before IL gen)");
		if (<SenderId>k__BackingField != 0)
		{
			object key2 = "rightCtrl" + 1936;
			SFSExtensions.Put(sFSObject, (string)key2, <SenderId>k__BackingField);
		}
		return sFSObject;
		IL_0160:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0226;
	}
}
