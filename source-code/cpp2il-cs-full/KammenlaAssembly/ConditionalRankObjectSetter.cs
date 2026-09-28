using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public class ConditionalRankObjectSetter : IRankSubSetter
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<GameObject> <>9__4_0;

		public static Action<GameObject> <>9__4_1;

		public static Action<GameObject> <>9__4_2;

		public static Action<GameObject> <>9__4_3;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 2144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Set>b__4_0(GameObject o)
		{
			GameObject gameObject = o.gameObject;
			gameObject.SetActive(value: true);
		}

		internal void <Set>b__4_1(GameObject o)
		{
			GameObject gameObject = o.gameObject;
			gameObject.SetActive(value: false);
		}

		internal void <Set>b__4_2(GameObject o)
		{
			GameObject gameObject = o.gameObject;
			gameObject.SetActive(value: false);
		}

		internal void <Set>b__4_3(GameObject o)
		{
			GameObject gameObject = o.gameObject;
			gameObject.SetActive(value: true);
		}
	}

	private PlayerRank.Ranks targetRank;

	private GameObject[] objectsToEnable;

	private GameObject[] objectsToDisable;

	private bool doTheInverse;

	public string Label => "Complete" + 216;

	public void Set(PlayerRank playerRank)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_019c: Expected O, but got I
		//IL_01ac: Expected O, but got I
		//IL_01ce: Expected O, but got I4
		//IL_03bf: Expected O, but got I
		//IL_03cf: Expected O, but got I
		//IL_03f1: Expected O, but got I4
		//IL_023f: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_0462: Expected O, but got I
		//IL_0134: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_0166: Expected O, but got I4
		//IL_02fc: Expected O, but got I
		//IL_030c: Expected O, but got I
		//IL_032e: Expected O, but got I4
		//IL_01fe: Expected O, but got I4
		//IL_051f: Expected O, but got I
		//IL_052f: Expected O, but got I
		//IL_0551: Expected O, but got I4
		//IL_0421: Expected O, but got I4
		//IL_028b: Expected O, but got I
		//IL_029b: Expected O, but got I
		//IL_02bd: Expected O, but got I4
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected O, but got Unknown
		//IL_05f8: Expected O, but got I
		//IL_0609: Expected I, but got O
		//IL_0627: Expected O, but got I
		//IL_0642: Expected O, but got I4
		//IL_04ae: Expected O, but got I
		//IL_04be: Expected O, but got I
		//IL_04e0: Expected O, but got I4
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Expected O, but got Unknown
		//IL_0719: Expected O, but got I
		//IL_072a: Expected I, but got O
		//IL_0748: Expected O, but got I
		//IL_0763: Expected O, but got I4
		//IL_0368: Expected O, but got I4
		//IL_022e: Expected O, but got I
		//IL_058b: Expected O, but got I4
		//IL_0451: Expected O, but got I
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0679: Expected O, but got I
		//IL_0681: Expected I, but got O
		//IL_0692: Expected I, but got O
		//IL_06b0: Expected O, but got I
		//IL_06c1: Expected O, but got I4
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Expected O, but got Unknown
		//IL_079a: Expected O, but got I
		//IL_07a2: Expected I, but got O
		//IL_07b3: Expected I, but got O
		//IL_07d1: Expected O, but got I
		//IL_07e2: Expected O, but got I4
		//IL_0398: Expected O, but got I
		//IL_05bb: Expected O, but got I
		object obj;
		object obj3;
		Action<object> action;
		if (playerRank.<Rank>k__BackingField == targetRank)
		{
			obj = typeof(CardUtils.<>c) + 2144;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v43+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v43+B8]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v47+8]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v47+8]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					goto IL_01dc;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v43+B8]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v47+8]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v47+8]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					goto IL_01dc;
				}
			}
			goto IL_0233;
		}
		if (!doTheInverse)
		{
			return;
		}
		object obj6 = typeof(CardUtils.<>c) + 2144;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v20+E4]");
		object obj8;
		Action<object> action2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v20+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v22+18]");
			action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v22+18]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				goto IL_03ff;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v20+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v22+18]");
			action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v22+18]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				goto IL_03ff;
			}
		}
		goto IL_0456;
		IL_01dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v43+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v53+B8]");
			obj3 = 0;
		}
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1536;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj3, (IntPtr)obj14);
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v52+B8]");
		object obj16 = (nint)0 + (nint)8;
		obj16 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj17 = 0;
		action = action3;
		goto IL_0233;
		IL_06d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Action<object> action5;
		Action<object> action4 = action5;
		goto IL_05c0;
		IL_0569:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		object obj20;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj19 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v17+B8]");
			obj20 = 0;
		}
		object obj21 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)1560;
		nint num = (nint)obj22;
		Action<object> action6 = default(Action<object>);
		action6..ctor(obj20, (IntPtr)obj22);
		object obj23 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v16+B8]");
		object obj24 = (nint)0 + (nint)32;
		obj24 = action6;
		object obj25 = 0;
		IEnumerable<object> enumeration = objectsToDisable;
		action5 = action6;
		goto IL_06d8;
		IL_0233:
		object obj26 = (nint)0 + (nint)2160;
		ArraysExtensions.ForEach(objectsToEnable, action);
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v34+E4]");
		object obj28;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v34+B8]");
			obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v36+10]");
			action4 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v36+10]");
			bool flag7 = (nint)0 == 0;
			object obj29 = !flag7;
			enumeration = objectsToDisable;
			if (obj29 == null)
			{
				goto IL_0346;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v34+B8]");
			obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v36+10]");
			action4 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v36+10]");
			bool flag8 = (nint)0 == 0;
			object obj30 = !flag8;
			enumeration = objectsToDisable;
			if (obj30 == null)
			{
				goto IL_0346;
			}
		}
		goto IL_05c0;
		IL_03ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v20+E4]");
		bool flag9 = (nint)0 == 0;
		object obj31 = !flag9;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj32 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v28+B8]");
			obj8 = 0;
		}
		object obj33 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj34 = (nint)0 + (nint)1552;
		Action<object> action7 = default(Action<object>);
		action7..ctor(obj8, (IntPtr)obj34);
		object obj35 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+B8]");
		object obj36 = (nint)0 + (nint)24;
		obj36 = action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj17 = 0;
		action2 = action7;
		goto IL_0456;
		IL_0346:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v34+E4]");
		bool flag10 = (nint)0 == 0;
		object obj37 = !flag10;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj38 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v42+B8]");
			obj28 = 0;
		}
		object obj39 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj40 = (nint)0 + (nint)1544;
		num = (nint)obj40;
		Action<object> action8 = default(Action<object>);
		action8..ctor(obj28, (IntPtr)obj40);
		object obj41 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v41+B8]");
		obj24 = (nint)0 + (nint)16;
		obj24 = action8;
		obj25 = 0;
		enumeration = objectsToDisable;
		action5 = action8;
		goto IL_06d8;
		IL_05c0:
		ArraysExtensions.ForEach(enumeration, action4);
		return;
		IL_0456:
		obj26 = (nint)0 + (nint)2160;
		ArraysExtensions.ForEach(objectsToEnable, action2);
		object obj42 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v11+B8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v11+20]");
			action4 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v11+20]");
			bool flag11 = (nint)0 == 0;
			object obj43 = !flag11;
			enumeration = objectsToDisable;
			if (obj43 == null)
			{
				goto IL_0569;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj42 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v11+B8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v11+20]");
			action4 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v11+20]");
			bool flag12 = (nint)0 == 0;
			object obj44 = !flag12;
			enumeration = objectsToDisable;
			if (obj44 == null)
			{
				goto IL_0569;
			}
		}
		goto IL_05c0;
	}
}
