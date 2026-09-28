using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Spine;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class SwipeWheelChoice : MonoBehaviour
{
	private sealed class <>c__DisplayClass7_0
	{
		public SwipeWheel parent;

		public SwipeWheelChoice <>4__this;

		internal void <Init>b__0()
		{
			parent.ActivateChoiceAndClose(<>4__this);
		}
	}

	private Button butt;

	public UnityEvent onDrop;

	private SwipeWheel wheel;

	private Graphic graphic;

	private Transform selectionAnchor;

	public Transform SelectionAnchor => selectionAnchor;

	public void Init(SwipeWheel parent)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0174: Expected O, but got I
		//IL_0193: Expected O, but got I4
		//IL_019c: Expected O, but got I4
		//IL_00cb: Expected O, but got I
		//IL_00e3: Expected O, but got I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_0140: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 2024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = parent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = this + 48;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X21_v4-10]");
			bool flag = (UnityEngine.Object)0 != null;
			bool flag2 = !flag;
			object obj8 = 0;
			UnityEngine.Object obj9 = null;
			if (flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X21_v4-10]");
			bool flag3 = (UnityEngine.Object)0 != null;
			bool flag4 = !flag3;
			object obj10 = !flag4;
			object obj8 = 0;
			UnityEngine.Object obj9 = null;
			if (obj10 == null)
			{
				return;
			}
		}
		Button button = butt;
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)2336;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(obj2, (IntPtr)obj12);
		button.m_OnClick.AddListener(unityAction);
	}

	public void OnDrop()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f9: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_015f: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B76]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			obj5 = graphic;
			obj6 = graphic;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = graphic;
			obj6 = graphic;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (obj6 != null)
		{
			goto IL_0152;
		}
		goto IL_0164;
		IL_0164:
		onDrop.Invoke();
		return;
		IL_0152:
		graphic.color = (Color)0;
		goto IL_0164;
		IL_0091:
		bool flag3 = obj5 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_0152;
		}
		goto IL_0164;
	}

	public void HighLight()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0129: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		//IL_00cf: Expected I, but got O
		//IL_00df: Expected O, but got I
		//IL_00ef: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B75]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00f9;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		UnityEngine.Object obj5 = this.graphic;
		UnityEngine.Object obj6 = this.graphic;
		if (!flag)
		{
			goto IL_0091;
		}
		goto IL_014b;
		IL_014b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = obj6 != null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_0091:
		if (obj5 != null)
		{
			goto IL_00b8;
		}
		return;
		IL_00b8:
		Graphic graphic = this.graphic;
		nint num = (nint)graphic;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7 (Il2CppClass<UnityEngine.UI.Graphic>)+2A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7 (Il2CppClass<UnityEngine.UI.Graphic>)+2B0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v91 @ X2_v4 (should have been resolved before IL gen)");
		goto IL_00f9;
		IL_00f9:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		obj5 = this.graphic;
		obj6 = this.graphic;
		if (obj10 != null)
		{
			goto IL_0091;
		}
		goto IL_014b;
	}

	public void DeHighlight()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0129: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		//IL_00cf: Expected I, but got O
		//IL_00df: Expected O, but got I
		//IL_00ef: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B76]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00f9;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		UnityEngine.Object obj5 = this.graphic;
		UnityEngine.Object obj6 = this.graphic;
		if (!flag)
		{
			goto IL_0091;
		}
		goto IL_014b;
		IL_014b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = obj6 != null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_0091:
		if (obj5 != null)
		{
			goto IL_00b8;
		}
		return;
		IL_00b8:
		Graphic graphic = this.graphic;
		nint num = (nint)graphic;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7 (Il2CppClass<UnityEngine.UI.Graphic>)+2A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7 (Il2CppClass<UnityEngine.UI.Graphic>)+2B0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v91 @ X2_v4 (should have been resolved before IL gen)");
		goto IL_00f9;
		IL_00f9:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		obj5 = this.graphic;
		obj6 = this.graphic;
		if (obj10 != null)
		{
			goto IL_0091;
		}
		goto IL_014b;
	}
}
