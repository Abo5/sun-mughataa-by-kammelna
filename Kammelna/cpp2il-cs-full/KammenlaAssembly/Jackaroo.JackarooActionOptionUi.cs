using System;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

namespace Jackaroo;

public class JackarooActionOptionUi : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private sealed class <>c__DisplayClass4_0
	{
		public Action<JackarooActions> onSelectedAction;

		public JackarooActions jackarooAction;

		public JackarooActionOptionUi <>4__this;

		internal void <Setup>b__0()
		{
			Action<JackarooActions> action = onSelectedAction;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ X8_v1 (System.Action`1<Jackaroo.JackarooActions>)+18] (should have been resolved before IL gen)");
			JackarooActionOptionUi jackarooActionOptionUi = <>4__this;
			Button jackarooButton = jackarooActionOptionUi._jackarooButton;
			jackarooButton.m_OnClick.RemoveAllListeners();
		}
	}

	private TextMeshProUGUI _jackarooOptionText;

	private Button _jackarooButton;

	private JackarooActions _action;

	public void Reset()
	{
		Button jackarooButton = _jackarooButton;
		jackarooButton.m_OnClick.RemoveAllListeners();
	}

	public unsafe void Setup(JackarooActions jackarooAction, Action<JackarooActions> onSelectedAction)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007d: Expected O, but got Ref
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I
		//IL_00ef: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = onSelectedAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X22_v4-8]");
		_action = JackarooActions.NONE;
		object obj5 = default(object);
		string text = ((Enum)(&obj5)).ToString();
		TextMeshProExtensions.Localize(_jackarooOptionText, text);
		_jackarooButton.interactable = true;
		Button jackarooButton = _jackarooButton;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj7 = (nint)0 + (nint)1416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(obj2, (IntPtr)obj7);
		jackarooButton.m_OnClick.AddListener(unityAction);
	}

	public unsafe void SetupDisabled(JackarooActions jackarooAction)
	{
		//IL_002b: Expected O, but got Ref
		_action = jackarooAction;
		object obj = default(object);
		string text = ((Enum)(&obj)).ToString();
		TextMeshProExtensions.Localize(_jackarooOptionText, text);
		_jackarooButton.interactable = false;
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
