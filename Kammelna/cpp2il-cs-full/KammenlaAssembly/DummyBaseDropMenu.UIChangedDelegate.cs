using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

public class DummyBaseDropMenu : MonoBehaviour
{
	public delegate void UIChangedDelegate(bool isToggledOpened);

	private UIChangedDelegate m_OnUIUpdated;

	public UnityEvent<int> OnValueChanged;

	private bool <IsToggled>k__BackingField;

	private int <SelectedIndex>k__BackingField;

	private object <selectedItem>k__BackingField;

	public bool IsToggled
	{
		get
		{
			return <IsToggled>k__BackingField;
		}
		set
		{
			<IsToggled>k__BackingField = value;
		}
	}

	public int SelectedIndex
	{
		get
		{
			return <SelectedIndex>k__BackingField;
		}
		set
		{
			<SelectedIndex>k__BackingField = value;
		}
	}

	public virtual object selectedItem
	{
		get
		{
			return <selectedItem>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public event UIChangedDelegate OnUIUpdated
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 1136;
			object obj2 = this + 32;
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
			object obj = typeof(DebugUI.BitField) + 1136;
			object obj2 = this + 32;
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

	public void InvokeOnOpen()
	{
		<IsToggled>k__BackingField = true;
		UIChangedDelegate onUIUpdated = this.OnUIUpdated;
		if (this.OnUIUpdated != null)
		{
			IntPtr invoke_impl = ((Delegate)onUIUpdated).invoke_impl;
			IntPtr method_code = ((Delegate)onUIUpdated).method_code;
			IntPtr method = ((Delegate)onUIUpdated).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X3_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void InvokeOnClose()
	{
		<IsToggled>k__BackingField = false;
		UIChangedDelegate onUIUpdated = this.OnUIUpdated;
		if (this.OnUIUpdated != null)
		{
			IntPtr invoke_impl = ((Delegate)onUIUpdated).invoke_impl;
			IntPtr method_code = ((Delegate)onUIUpdated).method_code;
			IntPtr method = ((Delegate)onUIUpdated).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void InvokeOnValueChanged(int value)
	{
		if (OnValueChanged != null)
		{
			int arg = default(int);
			OnValueChanged.Invoke(arg);
		}
	}
}
