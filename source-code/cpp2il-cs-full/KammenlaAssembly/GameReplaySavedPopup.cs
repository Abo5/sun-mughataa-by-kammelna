using System;
using System.ComponentModel;
using Cpp2ILInjected;
using DataTracking;
using Features.GameReplay;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class GameReplaySavedPopup : MonoBehaviour, IInitializable
{
	private PopupUI _popupUI;

	private Button _cancelButton;

	private Button _goToReplayButton;

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		Button cancelButton = _cancelButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		cancelButton.m_OnClick.AddListener(unityAction);
		Button goToReplayButton = _goToReplayButton;
		object obj3 = (nint)0 + (nint)2312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(null, (IntPtr)obj3);
		goToReplayButton.m_OnClick.AddListener(unityAction2);
	}

	private void OnCancelClicked()
	{
		_popupUI.ShrinkToParent();
	}

	private static void OnGoToReplayClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00af: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7714]");
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
		GameReplayManager.GoToReplay(TrackingPlacement.EndGamePopup);
		return;
		IL_0074:
		GameReplayManager.GoToReplay(TrackingPlacement.EndGamePopup);
	}

	public void Initialize()
	{
		_popupUI.PopFromParent();
	}
}
