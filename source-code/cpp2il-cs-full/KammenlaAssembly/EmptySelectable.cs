using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class EmptySelectable : MonoBehaviour, ISelectable
{
	private Button button;

	private ObjectToggler selectionMarker;

	public UnityEvent Callback;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button button = this.button;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
	}

	public void Select()
	{
		selectionMarker.ToggleManual(isON: true);
	}

	public void Deselect()
	{
		selectionMarker.ToggleManual(isON: false);
	}

	private void <Awake>b__3_0()
	{
		Callback.Invoke();
	}
}
