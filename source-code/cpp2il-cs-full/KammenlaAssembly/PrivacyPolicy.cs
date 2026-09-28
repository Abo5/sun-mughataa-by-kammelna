using System;
using Cpp2ILInjected;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class PrivacyPolicy : MonoBehaviour, IInitializable
{
	private PopupUI popup;

	private Toggle acceptToggle;

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_017a: Expected O, but got I
		//IL_0192: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6892]");
		object obj3 = (nint)0 & (nint)1;
		Toggle toggle;
		Toggle toggle2;
		if (obj3 != null)
		{
			toggle = acceptToggle;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			toggle2 = acceptToggle;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			toggle = acceptToggle;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			toggle2 = acceptToggle;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool allowIdAnalytics = UserInfo.AllowIdAnalytics;
		toggle = toggle2;
		goto IL_013e;
		IL_013e:
		toggle.isOn = allowIdAnalytics;
		Toggle toggle3 = acceptToggle;
		object obj6 = typeof(TypeConverter<ushort, char>) + 360;
		object obj7 = (nint)0 + (nint)2680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor((object)this, (IntPtr)obj7);
		toggle3.onValueChanged.AddListener(unityAction);
		return;
		IL_0091:
		allowIdAnalytics = UserInfo.AllowIdAnalytics;
		bool flag3 = (object)toggle == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_013e;
	}

	private void ToggleAnalyticsAgreement(bool isEnabled)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		object obj = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6893]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UserInfo.AllowIdAnalytics = isEnabled;
		return;
		IL_0074:
		UserInfo.AllowIdAnalytics = isEnabled;
	}

	public void Initialize()
	{
		popup.SlideFromBottom();
	}
}
