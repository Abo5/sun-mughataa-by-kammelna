using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Mono.Btls;
using UnityEngine;

public static class ProfileGiftQuantityPairExtension
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ProfileGiftQuantityPair, int> <>9__2_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <GetTotalValue>b__2_0(ProfileGiftQuantityPair x)
		{
			//IL_00c1: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_0089: Expected I4, but got O
			if (x != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				ProfileGiftModel profileGift = Store.GetProfileGift(x.<GiftId>k__BackingField);
				bool flag2 = profileGift == null;
				int result = (int)profileGift;
				if (!flag2)
				{
					result = profileGift.Price * x.<Quantity>k__BackingField;
				}
				return result;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass0_0
	{
		public long giftId;

		internal bool <AddCount>b__0(ProfileGiftQuantityPair x)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I8
			if (x != null)
			{
				object obj = x.<GiftId>k__BackingField - giftId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public static void AddCount(List<ProfileGiftQuantityPair> pairs, long giftId, int quantity)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0065: Expected I, but got O
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I
		//IL_014a: Expected O, but got I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2944;
		object obj4 = (nint)0 + (nint)2480;
		object obj5 = (nint)0 + (nint)1112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj4);
		object obj6 = Enumerable.FirstOrDefault(pairs, func);
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v9 (System.Object)+18]");
			object obj7 = (nint)0 + (nint)quantity;
			return;
		}
		object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 2208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = default(object);
		obj9..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
		_ = 0;
		int version = pairs._version + 1;
		pairs._version = version;
		ProfileGiftQuantityPair[] items = pairs._items;
		bool flag = pairs._size < items.Length;
		object obj10 = !flag;
		if (obj10 == null)
		{
			int size = pairs._size + 1;
			pairs._size = size;
			object obj11 = items + pairs._size;
			object obj12 = obj11 + 32;
			obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			((List<object>)(object)pairs).AddWithResize(obj9);
		}
	}

	public static int GetTotalValue(ProfileGiftQuantityPair pair)
	{
		//IL_00c1: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_0089: Expected I4, but got O
		if (pair != null)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ProfileGiftModel profileGift = Store.GetProfileGift(pair.<GiftId>k__BackingField);
			bool flag2 = profileGift == null;
			int result = (int)profileGift;
			if (!flag2)
			{
				result = profileGift.Price * pair.<Quantity>k__BackingField;
			}
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static int GetTotalValue(IEnumerable<ProfileGiftQuantityPair> pairs)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_00b1: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_0162: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0253: Expected O, but got I
		//IL_0264: Expected I, but got O
		//IL_0282: Expected O, but got I
		//IL_01fc: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3472;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E72B9]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)3880;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v5+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v4+8]");
		Func<object, int> selector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 == null)
		{
			goto IL_01aa;
		}
		goto IL_0201;
		IL_01aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v10+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)2472;
		Func<object, int> func = default(Func<object, int>);
		func..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v9+B8]");
		object obj16 = (nint)0 + (nint)8;
		obj16 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		selector = func;
		goto IL_0201;
		IL_0201:
		IEnumerable<int> source = Enumerable.Select(pairs, selector);
		return Enumerable.Sum(source);
		IL_0085:
		obj10 = (nint)0 + (nint)3880;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v5+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v4+8]");
		selector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			obj7 = obj10;
			goto IL_01aa;
		}
		goto IL_0201;
	}
}
