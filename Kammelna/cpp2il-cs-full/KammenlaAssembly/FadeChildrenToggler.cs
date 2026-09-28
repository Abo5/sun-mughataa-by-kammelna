using System.Data.SqlTypes;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class FadeChildrenToggler : BaseToggler
{
	private Transform customParent;

	private float targetFade;

	private float duration;

	private bool keepMeEnabled;

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0137: Expected O, but got I4
		//IL_00c2: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0188: Expected O, but got I4
		//IL_0191: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73CE]");
		object obj3 = (nint)0 & (nint)1;
		Object obj5;
		Object obj7;
		object obj8;
		object obj4;
		if (obj3 != null)
		{
			obj4 = this + 48;
			obj5 = (Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj7 = (Object)obj4;
			obj8 = obj4;
			if (!flag)
			{
				goto IL_00a0;
			}
		}
		else
		{
			_ = 1;
			obj4 = this + 48;
			obj5 = (Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = (Object)obj4;
			obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj7 == null;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		object obj11 = 0;
		obj4 = obj8;
		if (obj10 == null)
		{
			return;
		}
		goto IL_00d0;
		IL_00d0:
		Transform transform = base.transform;
		customParent = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_00a0:
		bool flag5 = obj5 == null;
		bool flag6 = !flag5;
		obj11 = 0;
		if (!flag6)
		{
			goto IL_00d0;
		}
	}

	protected override void ToggleOn()
	{
		//IL_0011: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0078: Expected O, but got I4
		//IL_015c: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_011b: Expected O, but got I4
		//IL_01bf: Expected I4, but got O
		object obj = (nint)0 + (nint)688;
		Transform transform = (Transform)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		object obj2 = typeof(SqlSingle[]) + 3912;
		object obj4 = default(object);
		object obj3 = obj4 + 32;
		object obj5 = 0;
		bool flag5;
		do
		{
			bool flag4;
			bool flag3;
			if (keepMeEnabled)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X25_v4+v85 @ X23_v5*8]");
				Transform transform2 = ((Component)0).transform;
				Transform transform3 = base.transform;
				bool flag = transform2.IsChildOf(transform3);
				bool flag2 = !flag;
				flag3 = false;
				transform = transform3;
				if (!flag2)
				{
					flag3 = false;
					flag4 = (byte)(int)transform3 != 0;
					goto IL_00ec;
				}
			}
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v16+E4]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X25_v4+v85 @ X23_v5*8]");
			Tween tween = AnimationExtensions.DOFadeChildren((Graphic)0, targetFade, duration);
			flag3 = false;
			flag4 = true;
			goto IL_00ec;
			IL_00ec:
			obj5++;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5+18]");
			flag5 = (nint)obj7 >= 0;
			transform = (Transform)flag4;
		}
		while (!flag5);
	}

	protected override void ToggleOff()
	{
		//IL_0011: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0078: Expected O, but got I4
		//IL_015f: Expected O, but got I
		//IL_00d4: Expected O, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_011e: Expected O, but got I4
		//IL_01c2: Expected I4, but got O
		object obj = (nint)0 + (nint)688;
		Transform transform = (Transform)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		object obj2 = typeof(SqlSingle[]) + 3912;
		object obj4 = default(object);
		object obj3 = obj4 + 32;
		object obj5 = 0;
		bool flag5;
		do
		{
			bool flag4;
			bool flag3;
			if (keepMeEnabled)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X25_v4+v83 @ X23_v5*8]");
				Transform transform2 = ((Component)0).transform;
				Transform transform3 = base.transform;
				bool flag = transform2.IsChildOf(transform3);
				bool flag2 = !flag;
				flag3 = false;
				transform = transform3;
				if (!flag2)
				{
					flag3 = false;
					flag4 = (byte)(int)transform3 != 0;
					goto IL_00ef;
				}
			}
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v16+E4]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X25_v4+v83 @ X23_v5*8]");
			Tween tween = AnimationExtensions.DOFadeChildren((Graphic)0, 1f, duration);
			flag3 = false;
			flag4 = true;
			goto IL_00ef;
			IL_00ef:
			obj5++;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5+18]");
			flag5 = (nint)obj7 >= 0;
			transform = (Transform)flag4;
		}
		while (!flag5);
	}

	private void Reset()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0137: Expected O, but got I4
		//IL_00c2: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0188: Expected O, but got I4
		//IL_0191: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73D1]");
		object obj3 = (nint)0 & (nint)1;
		Object obj5;
		Object obj7;
		object obj8;
		object obj4;
		if (obj3 != null)
		{
			obj4 = this + 48;
			obj5 = (Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj7 = (Object)obj4;
			obj8 = obj4;
			if (!flag)
			{
				goto IL_00a0;
			}
		}
		else
		{
			_ = 1;
			obj4 = this + 48;
			obj5 = (Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = (Object)obj4;
			obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj7 == null;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		object obj11 = 0;
		obj4 = obj8;
		if (obj10 == null)
		{
			return;
		}
		goto IL_00d0;
		IL_00d0:
		Transform transform = base.transform;
		customParent = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_00a0:
		bool flag5 = obj5 == null;
		bool flag6 = !flag5;
		obj11 = 0;
		if (!flag6)
		{
			goto IL_00d0;
		}
	}

	public FadeChildrenToggler()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num = default(float);
		targetFade = num;
		base..ctor();
	}
}
