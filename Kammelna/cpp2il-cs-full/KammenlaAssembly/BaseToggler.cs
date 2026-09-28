using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using GoogleMobileAds.Api.AdManager;
using Newtonsoft.Json.Linq.JsonPath;
using UI.Conditions;
using UnityEngine;

public abstract class BaseToggler : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Predicate<ICondition> <>9__2_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2848;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <Start>b__2_0(ICondition c)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0083: Expected O, but got I
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			if (c != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3616;
				object obj2 = obj;
				nint num = (nint)c;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v2 (Il2CppClass<UI.Conditions.ICondition>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v2 (Il2CppClass<UI.Conditions.ICondition>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
					object obj4 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X9_v4-8]");
					object obj5 = 0 - obj2;
					return obj5 == null;
				}
			}
			return false;
		}
	}

	private bool toggleTheInverse;

	private ConditionsList conditionsList;

	public void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0051: Expected I, but got O
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0157: Expected O, but got I
		//IL_0167: Expected O, but got I
		//IL_0189: Expected O, but got I4
		//IL_0119: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_00c5: Expected O, but got I
		//IL_00d5: Expected O, but got I
		//IL_0210: Expected O, but got I
		//IL_0240: Expected O, but got I4
		//IL_01b9: Expected O, but got I4
		//IL_0355: Expected I, but got O
		//IL_0365: Expected O, but got I
		//IL_0375: Expected O, but got I
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_030a: Expected O, but got I
		//IL_031b: Expected I, but got O
		//IL_0339: Expected O, but got I
		//IL_0384: Expected I, but got O
		//IL_01f7: Expected O, but got I4
		//IL_01e9: Expected O, but got I
		//IL_0283: Expected O, but got I4
		//IL_028c: Expected O, but got I4
		//IL_02bc: Expected O, but got I4
		//IL_02c5: Expected O, but got I4
		GameObject gm = base.gameObject;
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2920;
		this.conditionsList.Setup(gm);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		this.conditionsList.OnConditionChanged += action;
		ConditionsList conditionsList = this.conditionsList;
		object obj3 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2848;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v20+E4]");
		object obj5;
		Predicate<object> match;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v20+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v16+8]");
			match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v16+8]");
			if ((nint)0 != 0)
			{
				goto IL_00fa;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v20+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v16+8]");
			match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v16+8]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 != null)
			{
				goto IL_00fa;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v20+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v22+B8]");
			obj5 = 0;
		}
		object obj9 = typeof(List<Tween>) + 3248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)1080;
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj5, (IntPtr)obj10);
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v21+B8]");
		object obj12 = (nint)0 + (nint)8;
		obj12 = predicate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj13 = 0;
		match = predicate;
		goto IL_0204;
		IL_0204:
		object obj14 = (nint)0 + (nint)3728;
		bool flag3 = ((List<object>)(object)conditionsList.conditions).Exists(match);
		bool flag4 = !flag3;
		object obj15 = !flag4;
		if (obj15 != null)
		{
			goto IL_0350;
		}
		if (this.conditionsList.Satisfied)
		{
			object obj16 = 408;
			object obj17 = 416;
		}
		else
		{
			if (!toggleTheInverse)
			{
				goto IL_0350;
			}
			object obj16 = 424;
			object obj17 = 432;
		}
		goto IL_037f;
		IL_00fa:
		bool flag5 = conditionsList.conditions == null;
		object obj18 = !flag5;
		obj13 = 0;
		if (obj18 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0204;
		IL_037f:
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v226 @ X10_v2 (Il2CppClass<BaseToggler>)+v262 @ X9_v4] (should have been resolved before IL gen)");
		goto IL_0350;
		IL_0350:
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v10 (Il2CppClass<BaseToggler>)+178]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v10 (Il2CppClass<BaseToggler>)+180]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v161 @ X2_v7 (should have been resolved before IL gen)");
		goto IL_037f;
	}

	public void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_008b: Expected I, but got O
		//IL_0049: Expected I, but got O
		//IL_0059: Expected O, but got I
		//IL_0069: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2920;
		Action action = default(Action);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor(this, (IntPtr)obj2);
			conditionsList.OnConditionChanged -= action;
			conditionsList.Teardown();
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v3 (Il2CppClass<BaseToggler>)+188]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v3 (Il2CppClass<BaseToggler>)+190]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v73 @ X2_v4 (should have been resolved before IL gen)");
		}
	}

	protected virtual void Setup()
	{
	}

	protected virtual void Teardown()
	{
	}

	private void ToggleUI()
	{
		//IL_0035: Expected O, but got I4
		//IL_003e: Expected O, but got I4
		//IL_006e: Expected O, but got I4
		//IL_0077: Expected O, but got I4
		//IL_0082: Expected I, but got O
		//IL_0092: Expected O, but got I
		//IL_00a2: Expected O, but got I
		if (conditionsList.Satisfied)
		{
			object obj = 408;
			object obj2 = 416;
		}
		else
		{
			if (!toggleTheInverse)
			{
				return;
			}
			object obj = 424;
			object obj2 = 432;
		}
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X10_v1 (Il2CppClass<BaseToggler>)+v86 @ X9_v1]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X10_v1 (Il2CppClass<BaseToggler>)+v89 @ X8_v1]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v48 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected abstract void ToggleOn();

	protected abstract void ToggleOff();

	public void ToggleManual(bool isON)
	{
		//IL_0005: Expected I, but got O
		//IL_001f: Expected O, but got I4
		//IL_004d: Expected O, but got I4
		//IL_0079: Expected O, but got I4
		//IL_003f: Expected O, but got I4
		//IL_0069: Expected O, but got I4
		//IL_00a0: Expected O, but got I
		//IL_00b0: Expected O, but got I
		//IL_005b: Expected O, but got I4
		nint num = (nint)this;
		bool flag = !isON;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			object obj3 = 408;
		}
		else
		{
			object obj3 = 424;
		}
		object obj4 = !flag;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			object obj6 = 416;
		}
		else
		{
			object obj6 = 432;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<BaseToggler>)+v18 @ X9_v2]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<BaseToggler>)+v25 @ X10_v3]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v26 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public bool ValidateConditions()
	{
		//IL_0039: Expected I4, but got O
		ConditionsList conditionsList = this.conditionsList;
		if (this.conditionsList != null)
		{
			bool flag = Enumerable.Any((IEnumerable<object>)conditionsList.conditions);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
