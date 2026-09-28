using System;
using System.ComponentModel;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class GyroscopeReader : MonoBehaviour
{
	public UnityEvent<Vector3> OnGyroUpdate;

	private Quaternion _lastRotation;

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		//IL_015d: Expected O, but got I4
		//IL_00a3: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0191: Expected O, but got I
		//IL_01b3: Expected O, but got I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		object obj = 152981504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F12]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3488;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458F]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3488;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458F]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v5+B8]");
		object obj9 = 0;
		InputDevice device = (InputDevice)obj9;
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			return;
		}
		goto IL_00c8;
		IL_00c8:
		object obj11 = typeof(System.IOAsyncCallback) + 3120;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			InputSystem.EnableDevice(device);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		InputSystem.EnableDevice(device);
		return;
		IL_008b:
		object obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v14+B8]");
		object obj14 = 0;
		device = (InputDevice)obj14;
		if (obj14 != null)
		{
			goto IL_00c8;
		}
	}

	private Quaternion GyroToUnity(Quaternion gyroQ)
	{
		return (Quaternion)this;
	}

	private void Update()
	{
		//IL_0011: Expected O, but got I
		if (InputUtil.TryReadGyroAngularVelocity(out var _))
		{
			object arg = (nint)0 + (nint)1288;
			OnGyroUpdate.Invoke((Vector3)arg);
		}
	}
}
