using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class GameReplayWarningPopup : MonoBehaviour, IInitializable
{
	private PopupUI _popupUI;

	private Button _gotItButton;

	private Toggle _doNotShowAgainToggle;

	private Button _blockerButton;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_0084: Expected I, but got O
		Button gotItButton = _gotItButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		gotItButton.m_OnClick.AddListener(unityAction);
		Button blockerButton = _blockerButton;
		object popupUI = _popupUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)popupUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6 (Il2CppClass<System.Object>)+1A0]");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(popupUI, (IntPtr)0);
		blockerButton.m_OnClick.AddListener(unityAction2);
	}

	private void ConfirmWarning()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		Toggle doNotShowAgainToggle = _doNotShowAgainToggle;
		object obj = typeof(UsageHint) + 72;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UserInfo.DoNotShowGameReplaysWarning = doNotShowAgainToggle.m_IsOn;
		_popupUI.ShrinkToParent();
	}

	public void Initialize()
	{
		_popupUI.PopFromCenter();
		_doNotShowAgainToggle.isOn = true;
	}
}
