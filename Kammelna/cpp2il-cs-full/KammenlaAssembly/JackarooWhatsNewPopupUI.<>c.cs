using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class JackarooWhatsNewPopupUI : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static UnityAction <>9__3_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Start>b__3_0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00af: Expected O, but got I4
			object obj = typeof(UsageHint) + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6212]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UserInfo.SawWhatsNewForJackaroo = true;
			return;
			IL_0074:
			UserInfo.SawWhatsNewForJackaroo = true;
		}
	}

	private Button _dismissButton;

	public Button DismissButton => _dismissButton;

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00d0: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_0056: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01cc: Expected O, but got I
		//IL_01dd: Expected I, but got O
		//IL_01fb: Expected O, but got I
		//IL_0176: Expected O, but got I4
		//IL_0152: Expected O, but got I
		Button dismissButton = _dismissButton;
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 904;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v5+E4]");
		object obj3;
		UnityAction call;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v5+B8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v7+8]");
			call = (UnityAction)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v7+8]");
			if ((nint)0 != 0)
			{
				goto IL_008b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v5+B8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v7+8]");
			call = (UnityAction)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v7+8]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_008b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v13+B8]");
			obj3 = 0;
		}
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)2400;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(obj3, (IntPtr)obj8);
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v12+B8]");
		object obj10 = (nint)0 + (nint)8;
		obj10 = unityAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag3 = dismissButton.m_OnClick == null;
		object obj11 = !flag3;
		call = unityAction;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_008b;
		IL_008b:
		dismissButton.m_OnClick.AddListener(call);
	}
}
