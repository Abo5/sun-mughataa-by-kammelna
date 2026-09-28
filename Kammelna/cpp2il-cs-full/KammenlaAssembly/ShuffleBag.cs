using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

public class ShuffleBag<T>
{
	private readonly List<T> _items;

	private int _currentIndex;

	private readonly Random _random;

	public ShuffleBag(List<T> items)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_0102: Expected O, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_012a: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00a4: Expected I4, but got I8
		//IL_00ba: Expected O, but got I
		object obj7 = default(object);
		Random random = default(Random);
		while (true)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3072;
			base..ctor();
			nint num = 0;
			IntPtr intPtr = num;
			object obj2 = num + 309;
			object obj3 = obj2 & 1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v8 (Il2CppRgctx<ShuffleBag`1>)+8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ X2_v1] (should have been resolved before IL gen)");
			object obj6 = this + 16;
			obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			random..ctor();
			object obj8 = this + 32;
			obj8 = random;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_currentIndex = -1;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v12 (Il2CppRgctx<ShuffleBag`1>)+20]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v86 @ X2_v2 (should have been resolved before IL gen)");
		}
	}

	public unsafe void Add(T item, int count = 1)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_0038: Expected O, but got I
		//IL_004e: Expected O, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006d: Expected O, but got Ref
		//IL_0277: Expected O, but got I
		//IL_0291: Expected O, but got I
		//IL_009e: Expected O, but got Ref
		//IL_0119: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_018a: Expected O, but got I4
		//IL_01d1: Expected O, but got I
		//IL_01eb: Expected O, but got I8
		//IL_0205: Expected O, but got I4
		//IL_00bb: Expected O, but got I
		//IL_0232: Expected I4, but got O
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v5 (Il2CppRgctx<ShuffleBag`1>)+28]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X9_v1+FC]");
		object obj5 = (nint)0 + (nint)15;
		object obj6 = obj5 & 0x1FFFFFFF0L;
		object obj8 = default(object);
		object obj7 = (ref *(?*)(&obj8)) - (ref *(?*)obj6);
		int num2 = default(int);
		bool flag = num2 < 1;
		nint num3 = 0;
		T val2;
		if (!flag)
		{
			T val = (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 104));
			int num4 = num2;
			while (true)
			{
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v11 (Il2CppRgctx<ShuffleBag`1>)+28]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v12+28]");
				bool flag2 = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v12+28]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v12+28]");
				object obj10 = num6 ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v12+28]");
				object obj11 = 0 & obj10;
				bool flag3 = (nint)obj11 < 0;
				bool flag4 = flag2 == flag3;
				object obj12 = !flag4;
				object obj13 = ~obj12;
				if (obj13 == null)
				{
					val2 = item;
				}
				else
				{
					val2 = val;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				if (_items == null)
				{
					break;
				}
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v14 (Il2CppRgctx<ShuffleBag`1>)+28]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X9_v9+28]");
				object obj15 = 0 & 0x80000000L;
				bool flag5 = obj15 == null;
				object obj16 = !flag5;
				object obj17 = obj7;
				if (obj16 == null)
				{
					obj17 = obj7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v14 (Il2CppRgctx<ShuffleBag`1>)+30]");
				object obj18 = 0;
				nint num8 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ X1_v6+10] (should have been resolved before IL gen)");
				num4--;
				if (num4 != 1)
				{
					continue;
				}
				goto IL_0228;
			}
			NullReferenceException ex = new NullReferenceException();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X9_v1+FC]");
			num2 = 0;
			goto IL_025c;
		}
		goto IL_0267;
		IL_025c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		return;
		IL_0228:
		num2 = (int)_items;
		num3 = 0;
		goto IL_0267;
		IL_0267:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v6 (Il2CppRgctx<ShuffleBag`1>)+20]");
		val2 = (T)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v194 @ X1_v3 (T)] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
		if (obj19 == null)
		{
			return;
		}
		goto IL_025c;
	}

	private unsafe void Shuffle()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_0033: Expected O, but got I
		//IL_0049: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0068: Expected O, but got Ref
		//IL_007a: Expected O, but got Ref
		//IL_008c: Expected O, but got Ref
		//IL_0099: Expected O, but got Ref
		//IL_00a6: Expected O, but got Ref
		//IL_00b8: Expected O, but got Ref
		//IL_0104: Expected O, but got I
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected I4, but got Unknown
		//IL_0494: Expected O, but got I
		//IL_0235: Expected I, but got O
		//IL_0245: Expected O, but got I
		//IL_02ab: Expected O, but got I
		//IL_02be: Expected O, but got Ref
		//IL_02de: Expected O, but got Ref
		//IL_0365: Expected O, but got I
		//IL_038a: Expected O, but got Ref
		//IL_03c3: Expected O, but got I
		//IL_03dd: Expected O, but got I8
		//IL_03f7: Expected O, but got I4
		//IL_04e5: Expected O, but got I
		//IL_04f8: Expected O, but got Ref
		//IL_0510: Expected O, but got Ref
		//IL_055a: Expected O, but got I
		//IL_0574: Expected O, but got I8
		//IL_058e: Expected O, but got I4
		//IL_0182: Expected O, but got Ref
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v5 (Il2CppRgctx<ShuffleBag`1>)+28]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X9_v1+FC]");
		object obj5 = (nint)0 + (nint)15;
		object obj6 = obj5 & 0x1FFFFFFF0L;
		object obj8 = default(object);
		object obj7 = (ref *(?*)(&obj8)) - (ref *(?*)obj6);
		object obj9 = (ref *(?*)(&obj8)) - (ref *(?*)obj6);
		object obj10 = (ref *(?*)(&obj8)) - (ref *(?*)obj6);
		object obj11 = (ref *(?*)(&obj8)) - (ref *(?*)obj6);
		object obj12 = (ref *(?*)(&obj8)) - (ref *(?*)obj6);
		object obj13 = (ref *(?*)(&obj8)) - (ref *(?*)obj6);
		ShuffleBag<T> shuffleBag;
		nint num2;
		if (_items != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v5 (Il2CppRgctx<ShuffleBag`1>)+38]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v249 @ X1_v1 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
			nint num3 = default(nint);
			object obj14 = num3 - 1;
			bool flag = (nint)obj14 < 1;
			shuffleBag = this;
			if (flag)
			{
				goto IL_0427;
			}
			nint num5 = default(nint);
			nint num4 = num5;
			List<T> list2 = default(List<T>);
			List<T> list = list2;
			object obj16 = default(object);
			object obj15 = obj16;
			nint num6 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v5 (Il2CppRgctx<ShuffleBag`1>)+38]");
			nint num7 = 0;
			shuffleBag = this;
			while (true)
			{
				Random random = shuffleBag._random;
				bool flag2 = shuffleBag._random == null;
				num5 = num4;
				list2 = list;
				obj16 = obj15;
				num2 = num7;
				if (flag2)
				{
					break;
				}
				nint num8 = (nint)random;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v17 (Il2CppClass<System.Random>)+1B0]");
				list2 = (List<T>)0;
				int num9 = shuffleBag._random.Next((int)num6);
				bool flag3 = shuffleBag._items == null;
				num5 = num4;
				obj16 = obj15;
				num2 = num6;
				if (flag3)
				{
					break;
				}
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v19 (Il2CppRgctx<ShuffleBag`1>)+40]");
				object obj17 = 0;
				object obj18 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 108));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
				_ = 0;
				obj16 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 104));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v325 @ X1_v8+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				list2 = shuffleBag._items;
				bool flag4 = shuffleBag._items == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
				num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
				num2 = 0;
				if (flag4)
				{
					break;
				}
				num6--;
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v22 (Il2CppRgctx<ShuffleBag`1>)+40]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
				_ = 0;
				object obj20 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 104));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v333 @ X1_v10+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v25 (Il2CppRgctx<ShuffleBag`1>)+28]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X9_v20+28]");
				object obj22 = 0 & 0x80000000L;
				bool flag5 = obj22 == null;
				object obj23 = !flag5;
				object obj24 = obj10;
				if (obj23 == null)
				{
					obj24 = obj10;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v25 (Il2CppRgctx<ShuffleBag`1>)+48]");
				object obj25 = 0;
				object obj26 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 108));
				object obj27 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 104));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v357 @ X1_v13+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-98]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v28 (Il2CppRgctx<ShuffleBag`1>)+48]");
				num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v28 (Il2CppRgctx<ShuffleBag`1>)+28]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v29+28]");
				object obj29 = 0 & 0x80000000L;
				bool flag6 = obj29 == null;
				object obj30 = !flag6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-98]");
				num4 = 0;
				if (obj30 == null)
				{
					num4 = num13;
				}
				obj15 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 104));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ X1_v6 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
				bool flag7 = num6 <= 1;
				list = shuffleBag._items;
				num5 = num4;
				list2 = shuffleBag._items;
				obj16 = obj15;
				num2 = num7;
				if (!flag7)
				{
					continue;
				}
				goto IL_0427;
			}
		}
		goto IL_04bc;
		IL_04ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		return;
		IL_0427:
		if (shuffleBag._items == null)
		{
			goto IL_04bc;
		}
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v12 (Il2CppRgctx<ShuffleBag`1>)+38]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v249 @ X1_v1 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		NullReferenceException ex = default(NullReferenceException);
		int currentIndex = ex - 1;
		shuffleBag._currentIndex = currentIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
		if (obj31 == null)
		{
			return;
		}
		goto IL_04ca;
		IL_04bc:
		ex = new NullReferenceException();
		goto IL_04ca;
	}

	public unsafe T GetItem()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_003a: Expected O, but got I
		//IL_004a: Expected O, but got I
		//IL_0060: Expected O, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_007f: Expected O, but got Ref
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_010b: Expected I4, but got I8
		//IL_02ab: Expected O, but got I4
		//IL_0145: Expected O, but got I
		//IL_018b: Expected O, but got I
		//IL_019b: Expected O, but got I
		//IL_01ae: Expected O, but got Ref
		//IL_01c6: Expected O, but got Ref
		//IL_01ea: Expected O, but got I
		//IL_0213: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		List<T> list = default(List<T>);
		object syncRoot = list._syncRoot;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v4 (System.Object)+C0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v5+28]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X9_v1+FC]");
		object obj6 = (nint)0 + (nint)15;
		object obj7 = obj6 & 0x1FFFFFFF0L;
		object obj8 = default(object);
		List<T> list2 = (List<T>)((ref *(?*)(&obj8)) - (ref *(?*)obj7));
		bool flag = _items == null;
		List<T> list3 = list;
		IntPtr intPtr = default(IntPtr);
		nint num = intPtr;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v5+38]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ X1_v7 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
			object obj9 = default(object);
			bool flag2 = obj9 == null;
			List<T> list4 = list;
			if (!flag2)
			{
				int currentIndex = _currentIndex;
				if ((int)(_currentIndex & 0x80000000L) != 0)
				{
					object syncRoot2 = list._syncRoot;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v15 (System.Object)+C0]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v16+20]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ X1_v7 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
					currentIndex = _currentIndex;
				}
				list3 = _items;
				int currentIndex2 = currentIndex - 1;
				_currentIndex = currentIndex2;
				bool flag3 = _items == null;
				list4 = list;
				if (flag3)
				{
					goto IL_0236;
				}
				object syncRoot3 = list._syncRoot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v7 (System.Object)+C0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X9_v8+40]");
				object obj12 = 0;
				object obj13 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 76));
				object obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 72));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ X1_v8+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
				bool flag4 = obj15 != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X9_v1+FC]");
				object obj16 = 0;
				List<T> list5 = list2;
				T val = default(T);
				OutOfMemoryException ex = (OutOfMemoryException)val;
				if (!flag4)
				{
					return val;
				}
			}
			else
			{
				object obj17 = typeof(System.IOAsyncCallback) + 3768;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj18 = "SetRoomVariables request error" + 656;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				InvalidOperationException ex2 = default(InvalidOperationException);
				string message = default(string);
				ex2..ctor(message);
				OutOfMemoryException ex = new OutOfMemoryException();
				object obj16 = 0;
				List<T> list5 = list4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
			T result = default(T);
			return result;
		}
		goto IL_0236;
		IL_0236:
		throw new NullReferenceException();
	}

	public bool IsEmpty()
	{
		return (byte)(_currentIndex >> 31) != 0;
	}
}
