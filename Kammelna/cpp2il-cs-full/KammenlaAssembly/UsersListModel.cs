using System;
using System.Collections.Generic;
using System.Data;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.TextCore;
using Util;

public class UsersListModel
{
	private DateTime <LastUpdate>k__BackingField;

	private int <UsersCount>k__BackingField;

	private int <PlayersCount>k__BackingField;

	private IEnumerable<PlayerInfo> <UsersList>k__BackingField;

	public DateTime LastUpdate
	{
		get
		{
			return <LastUpdate>k__BackingField;
		}
		set
		{
			<LastUpdate>k__BackingField = value;
		}
	}

	public int UsersCount
	{
		get
		{
			return <UsersCount>k__BackingField;
		}
		set
		{
			<UsersCount>k__BackingField = value;
		}
	}

	public int PlayersCount
	{
		get
		{
			return <PlayersCount>k__BackingField;
		}
		set
		{
			<PlayersCount>k__BackingField = value;
		}
	}

	public int WatchersCount
	{
		get
		{
			//IL_0011: Expected O, but got I4
			//IL_0027: Expected I4, but got O
			object obj = <UsersCount>k__BackingField - <PlayersCount>k__BackingField;
			object obj2 = ~obj;
			return obj & obj2;
		}
	}

	public IEnumerable<PlayerInfo> UsersList
	{
		get
		{
			return <UsersList>k__BackingField;
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

	public static UsersListModel FromSfsObject(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0506: Expected I8, but got I4
		//IL_0066: Expected O, but got I4
		//IL_0548: Expected O, but got I4
		//IL_0551: Expected I8, but got I4
		//IL_055e: Expected I, but got I8
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I4
		//IL_00a9: Expected I8, but got I4
		//IL_00b6: Expected I, but got I8
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0107: Expected O, but got I
		//IL_0113: Expected O, but got I
		//IL_011b: Expected I, but got O
		//IL_012b: Expected O, but got I
		//IL_05b2: Expected I, but got O
		//IL_0166: Expected O, but got I
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_021c: Expected I, but got O
		//IL_022c: Expected O, but got I
		//IL_02c2: Expected I, but got O
		//IL_02d2: Expected I8, but got I
		//IL_02f4: Expected O, but got I4
		//IL_0304: Expected I8, but got I
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_0267: Expected O, but got I
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_0354: Expected I, but got O
		//IL_0364: Expected O, but got I
		//IL_03f3: Expected O, but got I4
		//IL_03fc: Expected I8, but got I4
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_043a: Expected I, but got O
		//IL_044a: Expected I8, but got I
		//IL_046e: Expected O, but got I4
		//IL_047f: Expected O, but got I4
		//IL_048f: Expected I8, but got I
		//IL_039f: Expected O, but got I
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_0604: Expected O, but got I4
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 168;
		Func<object, object> varName = (Func<object, object>)(object)("java.io.FileOutputStream" + 3592);
		object obj2 = typeof(DataRelation) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		long num = SFSExtensions.Get(data, (string)(object)varName, 0L);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double unixTimeStamp = (double)num / 4.652007308841189E+18;
		DateTime dateTime = DateTimeUtil.FromTimeStamp(unixTimeStamp);
		bool flag2 = obj3 == null;
		object obj6 = 0;
		long num2 = 0L;
		nint num3 = unchecked((nint)4652007308841189376L);
		object obj9;
		object obj13 = default(object);
		if (!flag2)
		{
			bool flag3 = data == null;
			obj6 = 0;
			num2 = 0L;
			num3 = unchecked((nint)4652007308841189376L);
			if (!flag3)
			{
				obj = typeof(System.IOAsyncCallback) + 976;
				object obj7 = "com.unity.services.authentication.profile" + 2776;
				object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1664;
				obj9 = (nint)0 + (nint)560;
				object obj10 = (nint)0 + (nint)496;
				nint num4 = (nint)data;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01af;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj12 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X10_v19-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj13 = obj12 + 16;
					obj11--;
					bool flag4 = (nint)obj11 != 1;
					obj12 = obj13;
					if (flag4)
					{
						continue;
					}
					goto IL_01af;
				}
				object obj14 = obj12 + 28;
				object obj15 = num4 + obj14;
				object obj16 = obj15 + 312;
				obj13 = obj12;
				goto IL_0590;
			}
		}
		goto IL_04a5;
		IL_0590:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v370 @ X0_v19] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)null, (IntPtr)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3020370");
		object obj17 = obj3 + 32;
		object obj18 = default(object);
		obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num5 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02b0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X10_v14-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj13 = obj20 + 16;
			obj19--;
			bool flag5 = (nint)obj19 != 1;
			obj20 = obj13;
			if (flag5)
			{
				continue;
			}
			goto IL_02b0;
		}
		object obj21 = obj20 + 28;
		object obj22 = num5 + obj21;
		object obj23 = obj22 + 312;
		num3 = (nint)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v36+8]");
		long num6 = 0L;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v436 @ X0_v36] (should have been resolved before IL gen)");
		NullReferenceException ex = default(NullReferenceException);
		bool flag6 = ex == null;
		object obj24 = !flag6;
		obj13 = obj20;
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v36+8]");
		num2 = 0L;
		varName = func;
		if (obj24 != null)
		{
			goto IL_031a;
		}
		goto IL_04a5;
		IL_01af:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0590;
		IL_04a5:
		ex = new NullReferenceException();
		goto IL_04b3;
		IL_031a:
		object obj25 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1616;
		obj = "com.unity.services.authentication.profile" + 3296;
		varName = (Func<object, object>)(object)("destinationTimeZone" + 832);
		num3 = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v7 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v7 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03e0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v7 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v11-8]");
			bool flag7 = 0 == (nint)obj25;
			obj6 = 0;
			num2 = num6;
			if (flag7)
			{
				break;
			}
			obj13 += 16;
			obj26--;
			if ((nint)obj26 != 1)
			{
				continue;
			}
			goto IL_03e0;
		}
		goto IL_04b3;
		IL_04b3:
		object obj27 = obj13 + 1;
		object obj28 = num3 + obj27;
		object obj29 = obj28 + 312;
		goto IL_061a;
		IL_03e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj6 = 0;
		num2 = 1L;
		object obj30 = default(object);
		obj29 = obj30;
		goto IL_061a;
		IL_02b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj31 = default(object);
		num3 = (nint)obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v33+8]");
		num6 = 0L;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v420 @ X0_v33] (should have been resolved before IL gen)");
		bool flag8 = ex == null;
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v33+8]");
		num2 = 0L;
		varName = func;
		if (!flag8)
		{
			goto IL_031a;
		}
		goto IL_04a5;
		IL_061a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v311 @ X8_v6] (should have been resolved before IL gen)");
		int defaultValue = default(int);
		int num7 = SFSExtensions.Get(data, (string)obj, defaultValue);
		int num8 = SFSExtensions.Get(data, (string)(object)varName, 0);
		return (UsersListModel)obj3;
	}
}
