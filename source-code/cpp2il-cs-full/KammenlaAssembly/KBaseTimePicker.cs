using System;
using System.Data;
using Cpp2ILInjected;
using Features.GameReplay;
using UnityEngine;
using UnityEngine.EventSystems;

public class KBaseTimePicker : DummyBaseDropMenu, IPicker
{
	private IPicker.TimeDel m_OnPickEnded;

	protected IPicker.PickerMode Mode;

	protected DateTime DateTime;

	protected PopupUI Popup;

	protected bool skipPickerRebuild;

	public event IPicker.TimeDel OnPickEnded
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1952;
			object obj2 = this + 64;
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
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1952;
			object obj2 = this + 64;
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

	private void Awake()
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<KBaseTimePicker>)+1D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<KBaseTimePicker>)+1E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void OpenPicker(DateTime defaultTime, IPicker.PickerMode md = IPicker.PickerMode.Normal)
	{
		//IL_0036: Expected O, but got I4
		GameObject gameObject = base.gameObject;
		bool activeInHierarchy = gameObject.activeInHierarchy;
		bool flag = !activeInHierarchy;
		object obj = !flag;
		if (obj == null)
		{
			GameObject gameObject2 = base.gameObject;
			gameObject2.SetActive(value: true);
			Mode = md;
			SetUiTo(defaultTime);
			Popup.PopFromCenter();
			base.<IsToggled>k__BackingField = true;
			UIChangedDelegate onUIUpdated = base.OnUIUpdated;
			if (base.OnUIUpdated != null)
			{
				IntPtr invoke_impl = ((Delegate)onUIUpdated).invoke_impl;
				IntPtr method_code = ((Delegate)onUIUpdated).method_code;
				IntPtr method = ((Delegate)onUIUpdated).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v81 @ X3_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public unsafe void ClosePicker()
	{
		//IL_0016: Expected O, but got I
		//IL_00b8: Expected O, but got I4
		//IL_0083: Expected O, but got I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_02ad: Expected O, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_01e1: Expected O, but got I4
		//IL_0193: Expected O, but got I
		//IL_019b: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7629]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			if (skipPickerRebuild)
			{
				goto IL_0052;
			}
		}
		else
		{
			_ = 1;
			bool flag = !skipPickerRebuild;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_0052;
			}
		}
		SetPickedDateTime();
		skipPickerRebuild = false;
		PopupUI popup = Popup;
		goto IL_00e6;
		IL_00e6:
		object obj3 = typeof(DataRelation) + 712;
		popup.ShrinkToParent();
		IPicker.TimeDel onPickEnded = this.OnPickEnded;
		bool flag2 = this.OnPickEnded == null;
		DateTime dateTime = (DateTime)0;
		if (!flag2)
		{
			dateTime = DateTime;
			nint method = ((Delegate)onPickEnded).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v91.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime2 = (DateTime)(this + 80);
		int hashCode = ((DateTime*)dateTime2)->GetHashCode();
		object obj6 = typeof(DataRelation) + 3776;
		bool flag4 = OnValueChanged == null;
		int num = 0;
		if (!flag4)
		{
			object obj7 = (nint)0 + (nint)976;
			nint method = (nint)obj7;
			OnValueChanged.Invoke(hashCode);
			num = hashCode;
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		EventSystem current = EventSystem.current;
		current.SetSelectedGameObject(null);
		base.<IsToggled>k__BackingField = false;
		UIChangedDelegate onUIUpdated = base.OnUIUpdated;
		if (base.OnUIUpdated != null)
		{
			IntPtr invoke_impl = ((Delegate)onUIUpdated).invoke_impl;
			IntPtr method_code = ((Delegate)onUIUpdated).method_code;
			IntPtr method2 = ((Delegate)onUIUpdated).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v112 @ X3_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
		return;
		IL_0052:
		skipPickerRebuild = false;
		popup = Popup;
		bool flag6 = (object)Popup == null;
		object obj10 = !flag6;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00e6;
	}

	protected virtual void Initialize()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_003d: Expected I, but got O
		//IL_004d: Expected O, but got I
		//IL_005d: Expected O, but got I
		object obj = (nint)0 + (nint)4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 88;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3 (Il2CppClass<KBaseTimePicker>)+1E8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3 (Il2CppClass<KBaseTimePicker>)+1F0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v52 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void SetPickedDateTime()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0094: Expected O, but got I4
		//IL_0040: Expected I, but got O
		//IL_0050: Expected O, but got I
		//IL_0060: Expected O, but got I
		object obj = typeof(DataRelation) + 712;
		while (true)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			DateTime = now;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4 (Il2CppClass<KBaseTimePicker>)+208]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4 (Il2CppClass<KBaseTimePicker>)+210]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v53 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	protected virtual void SetUiTo(DateTime time)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object message = default(object);
		MonoBehaviour.print(message);
	}

	protected unsafe virtual void AdjustDateTime()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0247: Expected O, but got I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0122: Expected O, but got I4
		//IL_027f: Expected O, but got I8
		//IL_015a: Expected O, but got I8
		//IL_0177: Expected O, but got I4
		//IL_017f: Expected I, but got O
		//IL_02cb: Expected O, but got I4
		//IL_01b7: Expected O, but got I4
		//IL_0307: Expected I8, but got O
		//IL_0302: Expected native int or pointer, but got O
		//IL_01e6: Expected I4, but got I8
		//IL_01f7: Expected I8, but got O
		//IL_01f2: Expected native int or pointer, but got O
		//IL_0200: Expected O, but got I4
		//IL_020d: Expected I, but got I8
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E758F]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		IPicker.PickerMode mode;
		object obj4;
		if (obj2 != null)
		{
			obj3 = typeof(DataRelation) + 712;
			mode = Mode;
			bool flag = Mode == IPicker.PickerMode.PastOnly;
			obj4 = obj3;
			if (!flag)
			{
				goto IL_0081;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(DataRelation) + 712;
			mode = Mode;
			bool flag2 = Mode != IPicker.PickerMode.PastOnly;
			obj4 = obj3;
			if (flag2)
			{
				goto IL_0081;
			}
		}
		DateTime dateTime = (DateTime)(this + 80);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		bool flag4 = (DateTime)dateTime._dateData > now;
		bool flag5 = !flag4;
		object obj7 = 0;
		nint num = (nint)now;
		if (!flag5)
		{
			object obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v22+E4]");
			bool flag6 = (nint)0 == 0;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime2 = ((DateTime*)dateTime)->AddYears(-1);
			((DateTime*)(nint)dateTime)->_dateData = (ulong)(long)dateTime2;
			obj7 = 0;
			num = unchecked((nint)4294967295L);
		}
		bool flag7 = Mode != IPicker.PickerMode.FutureOnly;
		obj3 = obj4;
		if (flag7)
		{
			return;
		}
		goto IL_0212;
		IL_0081:
		if (mode != IPicker.PickerMode.FutureOnly)
		{
			return;
		}
		goto IL_0212;
		IL_0212:
		DateTime dateTime3 = (DateTime)(this + 80);
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v2+E4]");
		bool flag8 = (nint)0 == 0;
		object obj11 = !flag8;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now2 = DateTime.Now;
		if ((DateTime)dateTime3._dateData < now2)
		{
			object obj12 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v8+E4]");
			bool flag9 = (nint)0 == 0;
			object obj13 = !flag9;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime4 = ((DateTime*)dateTime3)->AddYears(1);
			((DateTime*)(nint)dateTime3)->_dateData = (ulong)(long)dateTime4;
		}
	}
}
