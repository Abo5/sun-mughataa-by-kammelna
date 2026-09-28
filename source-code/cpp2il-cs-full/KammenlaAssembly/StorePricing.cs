using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine;

public static class StorePricing
{
	public static event Action OnPricingChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2144;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			bool flag;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj8 == obj5;
					obj5 = obj8;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2144;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			bool flag;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj8 == obj5;
					obj5 = obj8;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static int EffectivePrice(StoreItem item)
	{
		//IL_004f: Expected I4, but got O
		if (item != null)
		{
			int num = DiscountAmount(item);
			return item.<virtualPrice>k__BackingField - num;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static int TotalPrice(StoreItem item, int recipients)
	{
		//IL_005c: Expected I4, but got O
		//IL_003c: Expected O, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected I4, but got Unknown
		if (item != null)
		{
			int num = DiscountAmount(item);
			object obj = item.<virtualPrice>k__BackingField - num;
			return obj * recipients;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static int DiscountAmount(StoreItem item)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0161: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01e7: Expected O, but got I4
		//IL_018f: Expected O, but got I
		//IL_01a9: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_021f: Expected O, but got I
		//IL_022f: Expected O, but got I
		//IL_04f4: Expected I4, but got O
		//IL_029c: Expected I4, but got O
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0329: Expected O, but got I4
		//IL_03b7: Expected O, but got I
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_0452: Expected O, but got I4
		//IL_0481: Expected O, but got I4
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected I4, but got Unknown
		//IL_04ce: Expected I4, but got I8
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AAC]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v32+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v32+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A86]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_04e0:
		return 0;
		IL_04e6:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0254:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v3+18]");
		if ((nint)0 == 1)
		{
			User mySelf = SFS.MySelf;
			bool flag3 = mySelf == null;
			int result = (int)mySelf;
			if (!flag3)
			{
				User mySelf2 = SFS.MySelf;
				bool flag4 = SFSKammelnaUserExtensions.IsSubscribed(mySelf2);
				bool flag5 = !flag4;
				result = (flag4 ? 1 : 0);
				if (!flag5)
				{
					object obj7 = typeof(RegisteredWaitHandle) + 56;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v12+E4]");
					bool flag6 = (nint)0 == 0;
					object obj9 = !flag6;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					RemoteConfigModel current = RemoteConfig.Current;
					if (current == null || item == null || current.<SubscriberCategoryDiscounts>k__BackingField == null)
					{
						goto IL_04e6;
					}
					object obj10 = (nint)0 + (nint)3864;
					int value;
					bool flag7 = ((Dictionary<System.Int32Enum, int>)(object)current.<SubscriberCategoryDiscounts>k__BackingField).TryGetValue((System.Int32Enum)item.<category>k__BackingField, out value);
					bool flag8 = !flag7;
					result = (flag7 ? 1 : 0);
					if (!flag8)
					{
						if (value < 1)
						{
							goto IL_04e0;
						}
						object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
						object obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v18+E4]");
						bool flag9 = (nint)0 == 0;
						object obj13 = !flag9;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj14 = item.<virtualPrice>k__BackingField * value;
						int num = (int)(obj14 / 4636737291354636288L);
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
						result = (int)((num != 9218868437227405312L) ? num : 2147483648L);
					}
				}
			}
			return result;
		}
		goto IL_04e0;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A86]");
		object obj15 = (nint)0 & (nint)1;
		if (obj15 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_01b7:
		_ = 1;
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v47+E4]");
		bool flag10 = (nint)0 == 0;
		object obj17 = !flag10;
		object obj18 = obj16;
		if (obj17 != null)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
		IL_00a7:
		obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v47+E4]");
		bool flag11 = (nint)0 == 0;
		obj18 = obj16;
		if (!flag11)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
		IL_01fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v26+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v19+18]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v19+18]");
		if ((nint)0 != 0)
		{
			goto IL_0254;
		}
		goto IL_04e6;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v47+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v29+18]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v29+18]");
		bool flag12 = (nint)0 == 0;
		object obj23 = !flag12;
		if (obj23 != null)
		{
			goto IL_0254;
		}
		goto IL_04e6;
	}

	public static void BindPricingSources(GameObject host)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0118: Expected I, but got O
		//IL_007b: Expected I, but got O
		//IL_00a5: Expected O, but got I4
		//IL_00e8: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)120;
		object varName = "setMimeType" + 3808;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		User mySelf = SFS.MySelf;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		VariableBinderExtensions.Bind(host, mySelf, (string)varName, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(null, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(null, (IntPtr)obj2);
		RemoteConfig.OnChanged += action3;
	}

	private static void NotifyPricingChanged()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_0029: Expected O, but got I
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2144;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v43 @ X2_v1 (should have been resolved before IL gen)");
		}
	}
}
