using System;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

namespace UI.Popups.Chat;

public class SubBombNotifyClientPopupPreview : MonoBehaviour
{
	private SubBombNotifyClientPopup subBombNotifyClientPopup;

	private Button confirmButton;

	private Button backButton;

	private PopupUI popupUI;

	public void Init(UnityAction confirmAction)
	{
		AssignButtons(confirmAction);
	}

	public void Setup(int subDays, string bombMessage, string userId)
	{
		subBombNotifyClientPopup.Populate(subDays, bombMessage, userId);
		Show();
	}

	private void Populate(int subDays, string bombMessage, string userId)
	{
		subBombNotifyClientPopup.Populate(subDays, bombMessage, userId);
	}

	private void AssignButtons(UnityAction confirmAction)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_0098: Expected I, but got O
		Button button = confirmButton;
		button.m_OnClick.RemoveAllListeners();
		Button button2 = backButton;
		button2.m_OnClick.RemoveAllListeners();
		Button button3 = confirmButton;
		button3.m_OnClick.AddListener(confirmAction);
		Button button4 = backButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button4.m_OnClick.AddListener(unityAction);
	}

	private void Show()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0068: Expected I, but got O
		//IL_0092: Expected O, but got I4
		PopupUI popupUI = this.popupUI;
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2832;
		object obj3 = typeof(RegisteredWaitHandle) + 3136;
		GameObject popup = popupUI.content.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(popup, action);
		this.popupUI.PopFromCenter();
	}

	public void Hide()
	{
		popupUI.ShrinkToParent();
	}
}
