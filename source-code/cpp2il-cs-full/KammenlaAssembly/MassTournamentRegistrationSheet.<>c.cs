using System;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using Features.GameReplay;
using Kammelna.Server.Models.Clans;
using Server.Models;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class MassTournamentRegistrationSheet : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static InputField.OnValidateInput <>9__10_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal char <Start>b__10_0(string _, int _, char addedChar)
		{
			//IL_000f: Expected O, but got I4
			//IL_001f: Expected O, but got I
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v2+88]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				return char.ToUpper(addedChar);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return char.ToUpper(addedChar);
		}
	}

	private Toggle termsToggle;

	private MassTournamentEventChannel eventChannel;

	private GameObject registrationCodeInputContainer;

	private InputFieldTMProUGUI registrationCodeInput;

	private GameObject registrationCodeWarning;

	private Button submitButton;

	private ElegantLoadingIndicator loader;

	private Sprite massTournamentIcon;

	private PopupUI popup;

	private MassTournamentServerConnector _connector;

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014d: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_01f9: Expected O, but got I4
		//IL_018f: Expected O, but got I
		//IL_019f: Expected O, but got I
		//IL_01c1: Expected O, but got I4
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_02e4: Expected O, but got I
		//IL_02f5: Expected I, but got O
		//IL_0313: Expected O, but got I
		//IL_0100: Expected O, but got I4
		//IL_0229: Expected O, but got I
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_027f: Expected O, but got I
		//IL_0297: Expected I, but got O
		//IL_02a8: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3112;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6087]");
		object obj3 = (nint)0 & (nint)1;
		InputFieldTMProUGUI inputFieldTMProUGUI;
		InputFieldTMProUGUI inputFieldTMProUGUI2;
		object obj4;
		if (obj3 != null)
		{
			inputFieldTMProUGUI = registrationCodeInput;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			inputFieldTMProUGUI2 = registrationCodeInput;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			inputFieldTMProUGUI = registrationCodeInput;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			inputFieldTMProUGUI2 = registrationCodeInput;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v8+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v8+8]");
		InputField.OnValidateInput value = (InputField.OnValidateInput)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v8+8]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		inputFieldTMProUGUI = inputFieldTMProUGUI2;
		if (obj8 != null)
		{
			goto IL_00e6;
		}
		goto IL_01d7;
		IL_0243:
		inputFieldTMProUGUI.OnValidateInput += value;
		MassTournamentEventChannel massTournamentEventChannel = eventChannel;
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2664;
		object obj10 = (nint)0 + (nint)3448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj10);
		object obj11 = (nint)0 + (nint)2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
		return;
		IL_00e6:
		bool flag4 = (object)inputFieldTMProUGUI == null;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0243;
		IL_01d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v14+B8]");
			obj7 = 0;
		}
		object obj15 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)960;
		InputField.OnValidateInput onValidateInput = default(InputField.OnValidateInput);
		onValidateInput..ctor(obj7, (IntPtr)obj16);
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v13+B8]");
		object obj18 = (nint)0 + (nint)8;
		obj18 = onValidateInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		value = onValidateInput;
		inputFieldTMProUGUI = inputFieldTMProUGUI2;
		goto IL_0243;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v8+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v8+8]");
		value = (InputField.OnValidateInput)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v8+8]");
		bool flag6 = (nint)0 == 0;
		inputFieldTMProUGUI2 = inputFieldTMProUGUI;
		if (!flag6)
		{
			goto IL_00e6;
		}
		goto IL_01d7;
	}

	private void Initialize(MassTournamentServerConnector connector)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 104;
		obj = connector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Populate();
	}

	private void Populate()
	{
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)this).GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		registrationCodeInputContainer.SetActive(cachedMassEvent.<IsRegisterByCode>k__BackingField);
	}

	public void SubmitForm()
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0107: Expected O, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0146: Expected O, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_01a8: Expected O, but got I
		//IL_01b6: Expected I, but got O
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I4
		//IL_01e5: Expected O, but got I
		//IL_01f3: Expected I, but got O
		Toggle toggle = termsToggle;
		Selectable selectable;
		string code;
		if (toggle.m_IsOn)
		{
			if (registrationCodeInputContainer.activeSelf)
			{
				string text = registrationCodeInput.Text;
				if (text != null)
				{
					string text2 = text.Trim();
					selectable = submitButton;
					bool flag = (object)submitButton == null;
					object obj = !flag;
					code = text2;
					if (obj == null)
					{
						throw new NullReferenceException();
					}
					goto IL_015b;
				}
			}
			selectable = submitButton;
			code = null;
			goto IL_015b;
		}
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "Material with texture name \"" + 2952;
		Toast.Show((string)message, (Vector2)0, 0f);
		return;
		IL_015b:
		selectable.interactable = false;
		loader.StartLoading();
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = (nint)0 + (nint)3464;
		Action<int> action = default(Action<int>);
		action..ctor((object)this, (IntPtr)obj6);
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)3456;
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj8);
		_connector.RegisterInTournament(code, action, action2);
	}

	public void Show()
	{
		popup.SlideFromBottom();
		ResetForm();
	}

	public void Hide()
	{
		popup.SlideToBottom();
	}

	private void OnSuccess(int _)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0092: Expected O, but got I4
		//IL_00c2: Expected O, but got I4
		submitButton.interactable = true;
		loader.Freeze();
		loader.FinishLoading();
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = "SubscribeGroup request Error" + 176;
		popup.SlideToBottom();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show((string)message, (Vector2)0, 0f);
	}

	private void OnError(string error)
	{
		//IL_0089: Expected O, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0164: Expected O, but got I4
		//IL_0194: Expected O, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_0109: Expected O, but got I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		submitButton.interactable = true;
		loader.Freeze();
		loader.FinishLoading();
		registrationCodeWarning.SetActive(value: true);
		Transform target = registrationCodeInput.transform;
		Tweener tweener = ShortcutExtensions.DOShakePosition(target, 0.3f, (Vector3)20, 0, 10f, snapping: true, fadeOut: false);
		object value = "startPosition" + 1152;
		if (error.Equals((string)value))
		{
			object obj = typeof(MemberAchievementClanFeedData) + 3448;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object text = "The operation is not allowed on non-connected sockets." + 3696;
			OnlyForSubscribersPopup.Show(TrackingFeature.MassEvents, massTournamentIcon, (string)text);
		}
		else
		{
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Show(error, (Vector2)0, 0f);
		}
	}

	private void SetLoading(bool isLoading)
	{
		//IL_0037: Expected O, but got I4
		bool flag = (byte)((isLoading ? 1u : 0u) ^ 1u) != 0;
		submitButton.interactable = flag;
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			loader.StartLoading();
			return;
		}
		loader.Freeze();
		loader.FinishLoading();
	}

	private void StartLoading()
	{
		loader.StartLoading();
	}

	private void StopLoading()
	{
		loader.Freeze();
		loader.FinishLoading();
	}

	public void FillRegistrationCode(string code)
	{
		if (!string.IsNullOrWhiteSpace(code))
		{
			string text = code.Trim();
			string text2 = text.ToUpperInvariant();
			registrationCodeInput.Text = text2;
			registrationCodeWarning.SetActive(value: false);
		}
	}

	private void ResetForm()
	{
		//IL_0026: Expected O, but got I
		termsToggle.isOn = false;
		object text = (nint)0 + (nint)2000;
		registrationCodeInput.Text = (string)text;
		registrationCodeWarning.SetActive(value: false);
		submitButton.interactable = true;
		loader.Freeze();
		loader.FinishLoading();
	}
}
