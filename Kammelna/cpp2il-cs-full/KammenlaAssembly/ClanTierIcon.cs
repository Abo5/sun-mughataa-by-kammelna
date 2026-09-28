using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class ClanTierIcon : MonoBehaviour
{
	private sealed class <>c__DisplayClass4_0
	{
		public int tier;

		internal void <SetTier>b__0(ClanTierIcon c)
		{
			c.SetTierSelfOnly(tier);
		}
	}

	private bool childrenOnly;

	private ClanTierSprites tierSprites;

	private Image target;

	private ClanTierIcon[] childIcons;

	public void SetTier(int tier)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0069: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1600;
		object obj4 = (nint)0 + (nint)816;
		SetTierSelfOnly(tier);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		ArraysExtensions.ForEach(childIcons, action);
	}

	public void SetTierSelfOnly(int tier)
	{
		//IL_0029: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0053: Expected O, but got I
		//IL_011d: Expected O, but got I4
		//IL_00d5: Expected O, but got I4
		if (childrenOnly)
		{
			return;
		}
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E880D]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			obj5 = tierSprites;
			obj6 = tierSprites;
			if (!flag)
			{
				goto IL_00b1;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = tierSprites;
			obj6 = tierSprites;
			if (obj7 != null)
			{
				goto IL_00b1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		Sprite sprite = null;
		if (!flag4)
		{
			goto IL_017a;
		}
		goto IL_019a;
		IL_00b1:
		bool flag5 = obj5 != null;
		bool flag6 = !flag5;
		object obj8 = !flag6;
		if (obj8 != null)
		{
			goto IL_017a;
		}
		sprite = null;
		goto IL_019a;
		IL_019a:
		target.sprite = sprite;
		return;
		IL_017a:
		Sprite sprite2 = tierSprites.GetSprite(tier);
		sprite = sprite2;
		goto IL_019a;
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
		object obj = (nint)0 + (nint)776;
		object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 744;
		object obj3 = (nint)0 + (nint)1656;
		object obj4 = (nint)0 + (nint)3352;
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

	public Sprite GetSprite(int tier)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011f: Expected O, but got I4
		//IL_0174: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E880D]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			obj5 = tierSprites;
			obj6 = tierSprites;
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
			obj5 = tierSprites;
			obj6 = tierSprites;
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
		if ((object)tierSprites != null)
		{
			return tierSprites.GetSprite(tier);
		}
		return (Sprite)(object)new NullReferenceException();
		IL_0182:
		return null;
		IL_0091:
		if (obj5 != null)
		{
			goto IL_00b8;
		}
		goto IL_0182;
	}

	private bool <AutoAssignChildren>b__6_0(ClanTierIcon c)
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
