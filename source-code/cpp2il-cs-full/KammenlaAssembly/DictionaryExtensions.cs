using System;
using System.Collections.Generic;
using Cpp2ILInjected;

public static class DictionaryExtensions
{
	public static TResult Get<TKey, TResult>(IDictionary<TKey, TResult> dict, TKey key, TResult defaultValue = default(TResult))
	{
		//IL_003d: Expected O, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0065: Expected O, but got I4
		//IL_0154: Expected I, but got O
		//IL_0164: Expected O, but got I
		//IL_01d1: Expected O, but got I4
		//IL_00a6: Expected O, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		if (dict != null)
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr = default(IntPtr);
				num = intPtr;
			}
			nint num2 = (nint)dict;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<TKey, TResult>>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<TKey, TResult>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00e7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<TKey, TResult>>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X10_v5-8]");
				if (0 == num)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00e7;
			}
			object obj6 = obj5 + 7;
			object obj7 = num2 + obj6;
			object obj8 = obj7 + 312;
			goto IL_01ad;
		}
		return (TResult)new NullReferenceException();
		IL_00e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_01ad;
		IL_01ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ X0_v4] (should have been resolved before IL gen)");
		object obj9 = default(object);
		bool flag2 = obj9 == null;
		object obj10 = !flag2;
		object obj11 = ~obj10;
		TResult result = default(TResult);
		if (obj11 == null)
		{
			return result;
		}
		return defaultValue;
	}

	public unsafe static TValue GetOrPut<TKey, TValue>(IDictionary<TKey, TValue> dict, TKey key, Func<TKey, TValue> valueFactory)
	{
		//IL_003d: Expected O, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0065: Expected O, but got I4
		//IL_0415: Expected I, but got O
		//IL_0425: Expected O, but got I
		//IL_0101: Expected O, but got I
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_00a6: Expected O, but got I
		//IL_0142: Expected O, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_016a: Expected O, but got I4
		//IL_02d5: Expected O, but got I
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02fd: Expected O, but got I4
		//IL_0476: Expected I, but got O
		//IL_0486: Expected O, but got I
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0262: Expected O, but got I
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0294: Expected O, but got I4
		//IL_04e6: Expected I, but got O
		//IL_04f6: Expected O, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_01d9: Expected O, but got I
		//IL_0555: Expected O, but got I
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected O, but got Unknown
		//IL_057a: Expected O, but got Ref
		//IL_033e: Expected O, but got I
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		object obj9;
		if (dict != null)
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr = default(IntPtr);
				num = intPtr;
			}
			nint num2 = (nint)dict;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<TKey, TValue>>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<TKey, TValue>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00e7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<TKey, TValue>>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X10_v21-8]");
				if (0 == num)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00e7;
			}
			object obj6 = obj5 + 4;
			object obj7 = num2 + obj6;
			object obj8 = obj7 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v32+8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v233 @ X0_v32] (should have been resolved before IL gen)");
			object obj11 = default(object);
			object obj10 = obj11 & 1;
			bool flag2 = obj10 == null;
			object obj12 = !flag2;
			if (obj12 != null)
			{
				goto IL_0136;
			}
			goto IL_02a2;
		}
		goto IL_03ff;
		IL_021a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_04cf;
		IL_037f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_053f;
		IL_053f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v470 @ X0_v16] (should have been resolved before IL gen)");
		object obj13 = (nint)0 + (nint)309;
		object obj14 = obj13 & 1;
		bool flag3 = obj14 == null;
		object obj15 = default(object);
		obj9 = (object)(&obj15);
		nint num3 = 0;
		if (flag3)
		{
			goto IL_0194;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v16+8]");
		nint num4 = 0;
		object obj17 = default(object);
		object obj16 = obj17;
		nint num5 = 0;
		goto IL_046e;
		IL_046e:
		nint num6 = (nint)dict;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v8 (Il2CppClass<System.Collections.Generic.IDictionary`2<TKey, TValue>>)+12E]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v8 (Il2CppClass<System.Collections.Generic.IDictionary`2<TKey, TValue>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_021a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v8 (Il2CppClass<System.Collections.Generic.IDictionary`2<TKey, TValue>>)+B0]");
		object obj19 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X10_v7-8]");
			if (0 == num5)
			{
				break;
			}
			obj19 += 16;
			obj18--;
			if ((nint)obj18 != 1)
			{
				continue;
			}
			goto IL_021a;
		}
		object obj20 = num6 + obj19;
		object obj21 = obj20 + 312;
		goto IL_04cf;
		IL_0136:
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		bool flag4 = obj23 == null;
		object obj24 = !flag4;
		num3 = 0;
		IntPtr intPtr2 = default(IntPtr);
		num4 = intPtr2;
		object obj25 = default(object);
		obj16 = obj25;
		num5 = 0;
		if (obj24 == null)
		{
			goto IL_0194;
		}
		goto IL_046e;
		IL_0194:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v16+8]");
		num4 = 0;
		obj16 = obj17;
		IntPtr intPtr3 = default(IntPtr);
		num5 = intPtr3;
		goto IL_046e;
		IL_04cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v439 @ X0_v6] (should have been resolved before IL gen)");
		TValue result = default(TValue);
		return result;
		IL_00e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v29+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v137 @ X0_v29] (should have been resolved before IL gen)");
		object obj27 = default(object);
		object obj26 = obj27 & 1;
		if (obj26 != null)
		{
			goto IL_0136;
		}
		goto IL_02a2;
		IL_02a2:
		if (valueFactory == null)
		{
			goto IL_03ff;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [valueFactory @ X2 (System.Func`2<TKey, TValue>)+18] (should have been resolved before IL gen)");
		object obj28 = (nint)0 + (nint)309;
		object obj29 = obj28 & 1;
		bool flag5 = obj29 == null;
		object obj30 = !flag5;
		nint num7 = 0;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			IntPtr intPtr4 = default(IntPtr);
			num7 = intPtr4;
		}
		nint num8 = (nint)dict;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v17 (Il2CppClass<System.Collections.Generic.IDictionary`2<TKey, TValue>>)+12E]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v17 (Il2CppClass<System.Collections.Generic.IDictionary`2<TKey, TValue>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_037f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v17 (Il2CppClass<System.Collections.Generic.IDictionary`2<TKey, TValue>>)+B0]");
		object obj32 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X10_v14-8]");
			if (0 == num7)
			{
				break;
			}
			obj32 += 16;
			obj31--;
			if ((nint)obj31 != 1)
			{
				continue;
			}
			goto IL_037f;
		}
		object obj33 = obj32 + 1;
		object obj34 = num8 + obj33;
		object obj35 = obj34 + 312;
		goto IL_053f;
		IL_03ff:
		return (TValue)new NullReferenceException();
	}
}
