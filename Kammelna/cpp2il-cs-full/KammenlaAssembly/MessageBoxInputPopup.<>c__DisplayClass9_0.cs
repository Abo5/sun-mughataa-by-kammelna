using System;
using System.Buffers.Text;
using System.Diagnostics;
using Cpp2ILInjected;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class MessageBoxInputPopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass9_0
	{
		public string title;

		public string description;

		public Action<string> onSave;

		public string placeholder;

		public bool emptyTextAllowed;

		internal void <Show>b__0(MessageBoxInputPopup instance)
		{
			instance.ShowPopup(title, description, onSave, placeholder, emptyTextAllowed);
		}
	}

	private static readonly AddressReference<MessageBoxInputPopup> Address;

	private PopupUI popup;

	private TextMeshProUGUI titleText;

	private InputFieldTMProUGUI descriptionInput;

	private Button saveButton;

	private Button cancelButton;

	private const string EMPTY_VALUE_KEY = "Value cannot be empty";

	private Action<string> _onSave;

	private bool _emptyTextAllowed;

	public static void Show(string title, string description, Action<string> onSave, string placeholder = null, bool emptyTextAllowed = true)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_011a: Expected O, but got I4
		//IL_017d: Expected O, but got I
		//IL_018d: Expected O, but got I
		//IL_01a8: Expected I, but got O
		//IL_01d2: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 456;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2728;
		object obj5 = (nint)0 + (nint)1592;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = description;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj2 + 32;
		obj9 = onSave;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = obj2 + 40;
		obj10 = placeholder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v17+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj3;
		}
		object obj13 = (nint)0 + (nint)2144;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v17+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj15 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v20+E4]");
		bool flag2 = (nint)0 == 0;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		Button button = saveButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = cancelButton;
		object obj3 = (nint)0 + (nint)2016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
	}

	private void ShowPopup(string title, string description, Action<string> onSave, string placeholder, bool emptyTextAllowed)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0037: Expected O, but got I
		//IL_0056: Expected O, but got I4
		//IL_00bd: Expected O, but got I
		//IL_00e9: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		//IL_008b: Expected O, but got I
		//IL_009b: Expected O, but got I
		object obj = this + 72;
		obj = onSave;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X24_v2-20]");
		TextMeshProExtensions.Localize((TextMeshProUGUI)0, title);
		bool flag = description == null;
		object obj2 = !flag;
		string text = description;
		if (obj2 == null)
		{
			object obj3 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+90]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+B8]");
			object obj5 = 0;
			text = (string)obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X24_v2-18]");
		((InputFieldTMProUGUI)0).Text = text;
		bool flag2 = string.IsNullOrEmpty(placeholder);
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			descriptionInput.SetPlaceholder(placeholder);
		}
		popup.PopFromCenter(1f);
		descriptionInput.ShowKeyboard();
	}

	private void OnSave()
	{
		//IL_0030: Expected O, but got I4
		//IL_00e7: Expected O, but got I
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0108: Expected O, but got I4
		//IL_0129: Expected O, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00be: Expected O, but got I4
		//IL_013d: Expected O, but got I4
		string text = descriptionInput.Text;
		bool flag = !_emptyTextAllowed;
		object obj = !flag;
		if (obj == null && string.IsNullOrWhiteSpace(text))
		{
			object text2 = "Unsupported map type" + 1840;
			LocalizableText text3 = TextMeshProExtensions.Localize((string)text2);
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Show(text3, (Vector2)0, 0f);
		}
		else
		{
			object obj5 = (nint)0 + (nint)2336;
			object action = this + 72;
			Actions.SafeInvoke((Action<object>)action, text);
			action = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X19_v3-28]");
			((PopupUI)0).ShrinkToParent(null);
		}
	}

	private void OnCancel()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0035: Expected O, but got I
		object obj = this + 72;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X19_v2-28]");
		((PopupUI)0).ShrinkToParent(null);
	}

	private void Close()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0035: Expected O, but got I
		object obj = this + 72;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X19_v2-28]");
		((PopupUI)0).ShrinkToParent(null);
	}

	static MessageBoxInputPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "Material with texture name \"" + 976;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3064;
		object obj3 = typeof(MemberAchievementClanFeedData) + 456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
