using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class HintsPopup : MonoBehaviour
{
	private const string WaitingForAdMessage = "Waiting for Ad to load";

	private const string LookingForSessionMessage = "Looking for a session";

	private PopupUI popup;

	private Button CancelMatching;

	private TextMeshProUGUI WaitingText;

	private ElegantLoadingIndicator sceneLoadingIndicator;

	private Action m_OnMatchMakingCancel;

	public event Action OnMatchMakingCancel
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
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
			object obj = typeof(SqlSingle[]) + 2376;
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
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button cancelMatching = CancelMatching;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		cancelMatching.m_OnClick.AddListener(unityAction);
	}

	public void Open(bool isWaitingForAd = false, bool isDisableCancelButton = false)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0071: Expected O, but got I4
		bool isWaitingForAd2 = default(bool);
		bool isDisableCancelButton2 = default(bool);
		UpdateState(isWaitingForAd2, isDisableCancelButton2);
		PopupUI popupUI = popup;
		if (!popupUI.<IsCurrentlyShown>k__BackingField)
		{
			sceneLoadingIndicator.StartLoading();
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ScreenManager.PreventBackAction();
			popup.PopFromCenter();
		}
	}

	private void UpdateState(bool isWaitingForAd, bool isDisableCancelButton)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0087: Expected O, but got I4
		object obj = "Unsupported map type" + 3544;
		object obj2 = "LAK" + 2464;
		bool flag = !isWaitingForAd;
		object obj3 = !flag;
		object obj4 = ~obj3;
		object text = ((obj4 != null) ? obj2 : obj);
		TextMeshProExtensions.Localize(WaitingText, (string)text);
		GameObject gameObject = CancelMatching.gameObject;
		bool active = (byte)((isDisableCancelButton ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active);
	}

	public void Close()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0073: Expected O, but got I4
		PopupUI popupUI = popup;
		if (popupUI.<IsCurrentlyShown>k__BackingField)
		{
			sceneLoadingIndicator.Freeze();
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ScreenManager.AllowBackAction();
			popup.ShrinkToParent();
		}
	}

	private void MatchMakingCancel()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_007c: Expected I, but got O
		//IL_0099: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1496;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)1504;
		CancelMatching.interactable = false;
		GameObject lifecycle = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		SFS.SendStopFindMatch(lifecycle, action, action2);
	}

	private void <MatchMakingCancel>b__13_0()
	{
		Actions.SafeInvoke(this.OnMatchMakingCancel);
		Close();
		CancelMatching.interactable = true;
	}

	private void <MatchMakingCancel>b__13_1(string onError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_0099: Expected O, but got I4
		//IL_00da: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 3912;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)1512;
		RectTransform rect = UIExtensions.rectTransform(CancelMatching);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AnimationExtensions.ErrorFeedback(rect);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		Coroutine coroutine = UIExtensions.WaitForSeconds(this, 10f, action);
	}

	private void <MatchMakingCancel>b__13_2()
	{
		CancelMatching.interactable = true;
	}
}
