using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class DelayedActionTimer
{
	private readonly TimeSpan <Delay>k__BackingField;

	private DateTime _initialTime;

	private Coroutine _waitForSeconds;

	public TimeSpan Delay => <Delay>k__BackingField;

	public DelayedActionTimer(TimeSpan delay)
	{
		<Delay>k__BackingField = delay;
	}

	public void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0158: Expected O, but got I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00ed: Expected O, but got I4
		//IL_01a4: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D76]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime now = DateTime.Now;
		_initialTime = now;
		bool flag2 = _waitForSeconds == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00af;
		IL_00af:
		object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy instance = CoroutineDummy.Instance;
		instance.StopCoroutine(_waitForSeconds);
		return;
		IL_007d:
		DateTime now2 = DateTime.Now;
		_initialTime = now2;
		if (_waitForSeconds != null)
		{
			goto IL_00af;
		}
	}

	public void End(Action endAction)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0296: Expected O, but got I4
		//IL_01ea: Expected O, but got I4
		//IL_01f3: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00f1: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = now - _initialTime;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = <Delay>k__BackingField >= timeSpan;
			bool flag3 = !flag2;
			object obj6 = 0;
			TimeSpan timeSpan2 = timeSpan;
			if (!flag3)
			{
				goto IL_00b3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = <Delay>k__BackingField >= timeSpan;
			bool flag5 = !flag4;
			object obj7 = !flag5;
			object obj6 = 0;
			TimeSpan timeSpan2 = timeSpan;
			if (obj7 != null)
			{
				goto IL_00b3;
			}
		}
		if (endAction != null)
		{
			IntPtr invoke_impl = ((Delegate)endAction).invoke_impl;
			IntPtr method_code = ((Delegate)endAction).method_code;
			IntPtr method = ((Delegate)endAction).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v111 @ X2_v4 (System.IntPtr) (should have been resolved before IL gen)");
		}
		return;
		IL_00b3:
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v15+E4]");
		bool flag6 = (nint)0 == 0;
		object obj10 = !flag6;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan3 = <Delay>k__BackingField - timeSpan;
		TimeSpan timeSpan4 = default(TimeSpan);
		double totalSeconds = timeSpan4.TotalSeconds;
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v20+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds((float)totalSeconds, endAction);
		object obj13 = this + 32;
		obj13 = coroutine;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
