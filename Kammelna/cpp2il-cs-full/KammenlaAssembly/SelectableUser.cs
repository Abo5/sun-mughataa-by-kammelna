using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SelectableUser : MonoBehaviour
{
	private Action<SelectableUser> m_Selected;

	private Toggle toggle;

	private AvatarInitializer avatar;

	private ClanUserModel <User>k__BackingField;

	private bool <IsSelectable>k__BackingField;

	public ClanUserModel User
	{
		get
		{
			return <User>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool IsSelectable
	{
		get
		{
			return <IsSelectable>k__BackingField;
		}
		private set
		{
			<IsSelectable>k__BackingField = value;
		}
	}

	public event Action<SelectableUser> Selected
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3384;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3384;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0160: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_01ab: Expected O, but got I4
		//IL_01b4: Expected O, but got I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_010d: Expected I, but got O
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8609]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = this.toggle;
			obj6 = this.toggle;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = this.toggle;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = this.toggle;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c6;
		IL_00c6:
		Toggle toggle = this.toggle;
		object obj11 = typeof(TypeConverter<ushort, char>) + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)1744;
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor((object)this, (IntPtr)obj12);
		toggle.onValueChanged.RemoveListener(unityAction);
		return;
		IL_0091:
		bool flag5 = obj5 != null;
		bool flag6 = !flag5;
		obj9 = 0;
		obj10 = null;
		if (!flag6)
		{
			goto IL_00c6;
		}
	}

	public void Initialize(ClanUserModel user, ToggleGroup group, bool selectable)
	{
		<IsSelectable>k__BackingField = selectable;
		BindModel(user, group);
		SubscribeToggle();
		GameObject gameObject = toggle.gameObject;
		gameObject.SetActive(selectable);
	}

	public void Select()
	{
		toggle.isOn = true;
	}

	private void BindModel(ClanUserModel user, ToggleGroup group)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0037: Expected O, but got I
		object obj = this + 56;
		obj = user;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X22_v2-10]");
		((Toggle)0).group = group;
		toggle.SetIsOnWithoutNotify(value: false);
		AvatarData data = user;
		avatar.Initialize(data);
	}

	private void SubscribeToggle()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_004e: Expected O, but got I
		//IL_0087: Expected I, but got O
		Toggle toggle = this.toggle;
		object obj = typeof(TypeConverter<ushort, char>) + 360;
		object obj2 = (nint)0 + (nint)1744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)848;
		toggle.onValueChanged.RemoveListener(unityAction);
		Toggle toggle2 = this.toggle;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction2 = default(UnityAction<bool>);
		unityAction2..ctor((object)this, (IntPtr)obj2);
		toggle2.onValueChanged.AddListener(unityAction2);
	}

	private void OnToggleChanged(bool isOn)
	{
		if (isOn)
		{
			Actions.SafeInvoke((Action<object>)this.Selected, this);
		}
	}
}
