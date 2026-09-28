using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Sfs2X.Entities;
using Spine;
using UnityEngine;

public static class StoreUtil
{
	private sealed class <>c__DisplayClass0_0
	{
		public List<StoreOwnedItem> ownedRoomThemes;

		internal bool <GetAvailableItems>b__0(StoreItem item)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0141: Expected I4, but got O
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_007a: Expected I, but got O
			//IL_00b8: Expected O, but got I4
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Expected I4, but got Unknown
			//IL_012e: Expected O, but got I4
			//IL_0120: Expected O, but got I
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1608;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (obj2 != null)
			{
				object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3480;
				object obj4 = (nint)0 + (nint)1768;
				object obj5 = obj2 + 16;
				obj5 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj4);
				object obj6;
				if (Enumerable.Any(ownedRoomThemes, func))
				{
					obj6 = 1;
				}
				else
				{
					object obj7 = obj5;
					if (obj5 == null)
					{
						goto IL_0133;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v5+88]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v5+58]");
						obj6 = (nint)0 ^ (nint)1;
					}
					else
					{
						obj6 = 0;
					}
				}
				return (byte)(obj6 & 1) != 0;
			}
			goto IL_0133;
			IL_0133:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass0_1
	{
		public StoreItem item;

		internal bool <GetAvailableItems>b__1(StoreOwnedItem ownedItem)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (ownedItem != null)
			{
				StoreItem storeItem = item;
				if (item != null)
				{
					object obj = ownedItem.<itemId>k__BackingField - storeItem.<id>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public static IEnumerable<StoreItem> GetAvailableItems(ItemCategory category)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_019d: Expected O, but got I
		//IL_01da: Expected O, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_011e: Expected O, but got I4
		//IL_0168: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1600;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if ((object)sessionModel != null)
		{
			User localUser = sessionModel.LocalUser;
			List<StoreOwnedItem> ownedRoomThemes = SFSKammelnaUserExtensions.GetOwnedRoomThemes(localUser);
			if (obj4 != null)
			{
				object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
				object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
				object obj9 = (nint)0 + (nint)1760;
				object obj10 = obj4 + 16;
				obj10 = ownedRoomThemes;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj11 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v15+E4]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				IEnumerable<StoreItem> categoryItems = Store.GetCategoryItems(category);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj4, (IntPtr)obj9);
				return (IEnumerable<StoreItem>)Enumerable.Where(categoryItems, func);
			}
		}
		return (IEnumerable<StoreItem>)new NullReferenceException();
	}
}
