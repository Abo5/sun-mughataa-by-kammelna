using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;

public class ClanTierText : MonoBehaviour
{
	private sealed class <>c__DisplayClass4_0
	{
		public int tier;

		internal void <SetTier>b__0(ClanTierText c)
		{
			c.SetTierSelfOnly(tier);
		}
	}

	private bool childrenOnly;

	private ClanTierTextMaterials tierMaterials;

	private TextMeshProUGUI target;

	private ClanTierText[] childTexts;

	public void SetTier(int tier)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0069: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1608;
		object obj4 = (nint)0 + (nint)824;
		SetTierSelfOnly(tier);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		ArraysExtensions.ForEach(childTexts, action);
	}

	public void SetTierSelfOnly(int tier)
	{
		//IL_02d5: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0022: Expected O, but got I4
		//IL_0038: Expected O, but got I
		//IL_01a8: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_00c3: Expected O, but got I4
		//IL_0250: Expected O, but got I4
		//IL_0261: Expected O, but got I4
		//IL_01fb: Expected O, but got I4
		//IL_02aa: Expected O, but got I4
		//IL_014e: Expected I, but got O
		//IL_015e: Expected O, but got I
		//IL_016e: Expected O, but got I
		bool flag = !childrenOnly;
		object obj = !flag;
		object obj2;
		UnityEngine.Object obj6;
		UnityEngine.Object obj7;
		object obj5;
		if (obj == null)
		{
			obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = 152993792;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88D1]");
			object obj4 = (nint)0 & (nint)1;
			if (obj4 == null)
			{
				goto IL_0178;
			}
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			obj6 = tierMaterials;
			obj7 = tierMaterials;
			if (!flag2)
			{
				goto IL_0096;
			}
			goto IL_01ca;
		}
		return;
		IL_0213:
		int tier2 = default(int);
		Material material = tierMaterials.GetMaterial(tier2);
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		UnityEngine.Object obj10 = material;
		object obj11 = 0;
		UnityEngine.Object obj12 = material;
		if (obj9 != null)
		{
			goto IL_0110;
		}
		goto IL_0277;
		IL_0277:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag4 = obj12 != null;
		bool flag5 = !flag4;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			return;
		}
		goto IL_0137;
		IL_0096:
		bool flag6 = obj6 != null;
		bool flag7 = !flag6;
		object obj14 = !flag7;
		obj11 = 0;
		UnityEngine.Object obj15 = null;
		obj10 = null;
		if (obj14 == null)
		{
			goto IL_00db;
		}
		goto IL_0213;
		IL_00db:
		obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v5+E4]");
		bool flag8 = (nint)0 == 0;
		obj12 = obj10;
		if (!flag8)
		{
			goto IL_0110;
		}
		goto IL_0277;
		IL_0110:
		if (obj10 != null)
		{
			goto IL_0137;
		}
		return;
		IL_0137:
		TextMeshProUGUI textMeshProUGUI = target;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v14 (Il2CppClass<TMPro.TextMeshProUGUI>)+578]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v14 (Il2CppClass<TMPro.TextMeshProUGUI>)+580]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v88 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_0178;
		IL_0178:
		_ = 1;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v13+E4]");
		bool flag9 = (nint)0 == 0;
		object obj18 = !flag9;
		obj6 = tierMaterials;
		obj7 = tierMaterials;
		if (obj18 != null)
		{
			goto IL_0096;
		}
		goto IL_01ca;
		IL_01ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag10 = obj7 != null;
		bool flag11 = !flag10;
		obj11 = 0;
		obj15 = null;
		obj10 = null;
		if (flag11)
		{
			goto IL_00db;
		}
		goto IL_0213;
	}

	private void AutoAssignChildren()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002c: Expected O, but got I
		//IL_0038: Expected O, but got I
		//IL_00a1: Expected I, but got O
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		object obj = (nint)0 + (nint)784;
		object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 752;
		object obj3 = (nint)0 + (nint)1664;
		object obj4 = (nint)0 + (nint)3360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31D00");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)this, (IntPtr)obj3);
		IEnumerable<object> source2 = default(IEnumerable<object>);
		IEnumerable<object> source = Enumerable.Where(source2, func);
		object[] array = Enumerable.ToArray(source);
		object obj5 = this + 56;
		obj5 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public Material GetMaterial(int tier)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011f: Expected O, but got I4
		//IL_0174: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88D1]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			obj5 = tierMaterials;
			obj6 = tierMaterials;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = tierMaterials;
			obj6 = tierMaterials;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_0182;
		IL_00b8:
		if ((object)tierMaterials != null)
		{
			return tierMaterials.GetMaterial(tier);
		}
		return (Material)(object)new NullReferenceException();
		IL_0182:
		return null;
		IL_0091:
		if (obj5 != null)
		{
			goto IL_00b8;
		}
		goto IL_0182;
	}

	private bool <AutoAssignChildren>b__6_0(ClanTierText c)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0065: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return c != this;
	}
}
