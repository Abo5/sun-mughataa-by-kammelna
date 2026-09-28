using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Rendering;

namespace UI.Conditions;

[Serializable]
public class UiDropMenuCondition : ICondition
{
	private Action m_OnConditionChanged;

	public DummyBaseDropMenu dropmenuToggle;

	public string Name => "Drop Menu Toggle";

	public bool Satisfied
	{
		get
		{
			//IL_0041: Expected I4, but got O
			DummyBaseDropMenu dummyBaseDropMenu = dropmenuToggle;
			if ((object)dropmenuToggle != null)
			{
				return dummyBaseDropMenu.<IsToggled>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public event Action OnConditionChanged
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 16;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 16;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public void Setup(GameObject gm)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 1136;
		object obj2 = (nint)0 + (nint)1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DummyBaseDropMenu.UIChangedDelegate uIChangedDelegate = default(DummyBaseDropMenu.UIChangedDelegate);
		uIChangedDelegate..ctor(this, (IntPtr)obj2);
		dropmenuToggle.OnUIUpdated += uIChangedDelegate;
	}

	public void Teardown()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0147: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I
		//IL_00f8: Expected I, but got O
		//IL_0191: Expected O, but got I4
		//IL_019a: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E2B]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = dropmenuToggle;
			obj6 = dropmenuToggle;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = dropmenuToggle;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = dropmenuToggle;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c0;
		IL_00c0:
		object obj10 = typeof(DebugUI.BitField) + 1136;
		object obj11 = (nint)0 + (nint)1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DummyBaseDropMenu.UIChangedDelegate uIChangedDelegate = default(DummyBaseDropMenu.UIChangedDelegate);
		uIChangedDelegate..ctor(this, (IntPtr)obj11);
		dropmenuToggle.OnUIUpdated -= uIChangedDelegate;
		return;
		IL_0091:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		obj9 = 0;
		if (!flag6)
		{
			goto IL_00c0;
		}
	}

	private void ToggleChanged(bool _)
	{
		Actions.SafeInvoke(this.OnConditionChanged);
	}
}
