using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.WebRequests;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util;

public class ModeratorControl : MonoBehaviour
{
	private enum ModeratorAction
	{
		Kick,
		Mute,
		Unmute
	}

	private PopupUI popup;

	private ToggleGroup toggles;

	private InputFieldTMProUGUI durationText;

	private InputFieldTMProUGUI reasonText;

	private InputFieldTMProUGUI descriptionText;

	private TextMeshProUGUI title;

	private Button send;

	private Button cancelBan;

	private TextMeshProUGUI cancelBanText;

	private ChatMessageData _messageData;

	private ModeratorAction _type;

	private int _userId;

	private int _duration;

	private string _reason;

	private string _comment;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_007b: Expected I, but got O
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I
		//IL_00cf: Expected I, but got O
		Button button = send;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = cancelBan;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)3264;
		button2.m_OnClick.AddListener(unityAction2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		durationText.OnValueChanged += action;
	}

	public void SetType()
	{
		ModeratorAction type;
		if (ToggleGroupExtensions.GetSelectedIndex(toggles) != 0)
		{
			int selectedIndex = ToggleGroupExtensions.GetSelectedIndex(toggles);
			if (selectedIndex == 1)
			{
				type = ModeratorAction.Mute;
			}
			else
			{
				int selectedIndex2 = ToggleGroupExtensions.GetSelectedIndex(toggles);
				if (selectedIndex2 != 2)
				{
					goto IL_00c7;
				}
				type = ModeratorAction.Unmute;
			}
		}
		else
		{
			type = ModeratorAction.Kick;
		}
		_type = type;
		goto IL_00c7;
		IL_00c7:
		UpdateUi();
	}

	private void ClearData()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		object obj = this + 104;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069538]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnValueChanged(string _)
	{
		if (durationText.Interactable)
		{
			UIExtensions.EnsureNumeric(durationText, 360.0);
		}
	}

	public void ShowForUser(int userId)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0026: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069538]");
		_type = ModeratorAction.Kick;
		object obj = this + 104;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_userId = userId;
		ShowPopup();
	}

	public void ShowMessageForUser(ChatMessageData msg)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009c: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		object obj = this + 104;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069538]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj = msg;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int userId = Convert.ToInt32(msg.<UserId>k__BackingField);
		_userId = userId;
		ShowPopup();
	}

	public void ShowKickForUser(int userId)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0026: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069538]");
		_type = ModeratorAction.Kick;
		object obj = this + 104;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_userId = userId;
		ToggleGroupExtensions.SetSelectedIndex(toggles, 0);
		ShowPopup();
	}

	public void ShowMuteForUser(int userId)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0026: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069538]");
		_type = ModeratorAction.Kick;
		object obj = this + 104;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_userId = userId;
		ToggleGroupExtensions.SetSelectedIndex(toggles, 1);
		ShowPopup();
	}

	public void ShowUnmuteForUser(int userId)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0026: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069538]");
		_type = ModeratorAction.Kick;
		object obj = this + 104;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_userId = userId;
		ToggleGroupExtensions.SetSelectedIndex(toggles, 2);
		ShowPopup();
	}

	private void ShowPopup()
	{
		ModeratorAction type;
		if (ToggleGroupExtensions.GetSelectedIndex(toggles) != 0)
		{
			int selectedIndex = ToggleGroupExtensions.GetSelectedIndex(toggles);
			if (selectedIndex == 1)
			{
				type = ModeratorAction.Mute;
			}
			else
			{
				int selectedIndex2 = ToggleGroupExtensions.GetSelectedIndex(toggles);
				if (selectedIndex2 != 2)
				{
					goto IL_00d3;
				}
				type = ModeratorAction.Unmute;
			}
		}
		else
		{
			type = ModeratorAction.Kick;
		}
		_type = type;
		goto IL_00d3;
		IL_00d3:
		UpdateUi();
		popup.SlideFromTop();
	}

	private void UpdateUi()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_0156: Expected O, but got I4
		//IL_01a6: Expected O, but got I4
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0262: Expected O, but got I
		//IL_0270: Expected I, but got O
		//IL_027f: Expected I8, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		TextMeshProExtensions.Localize(title, friendlyName);
		object obj2 = (nint)0 + (nint)288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration2 = default(Enum);
		string friendlyName2 = EnumExtensions.GetFriendlyName(enumeration2);
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, friendlyName2);
		durationText.Interactable = true;
		reasonText.Interactable = true;
		descriptionText.Interactable = true;
		send.interactable = true;
		durationText.ClearInput();
		reasonText.ClearInput();
		descriptionText.ClearInput();
		GameObject gameObject = descriptionText.gameObject;
		object obj3 = _type - 2;
		bool flag = obj3 == null;
		bool active = !flag;
		gameObject.SetActive(active);
		GameObject gameObject2 = send.gameObject;
		object obj4 = _type - 2;
		bool flag2 = obj4 == null;
		bool active2 = !flag2;
		gameObject2.SetActive(active2);
		GameObject gameObject3 = cancelBan.gameObject;
		object obj5 = _type - 2;
		bool active3 = obj5 == null;
		gameObject3.SetActive(active3);
		if (_type == ModeratorAction.Unmute)
		{
			durationText.Interactable = false;
			reasonText.Interactable = false;
			descriptionText.Interactable = false;
			cancelBan.interactable = false;
			object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = (nint)0 + (nint)3240;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj7);
			KammelnaRequests.GetBanInfo(_userId, action);
		}
	}

	private void FormatDuration(DateTime dateTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I4
		//IL_0071: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = typeof(DataRelation) + 824;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = dateTime - now;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = DateTimeUtil.GetDurationText(timeSpan, 2, DateTimeUnit.Hours);
		durationText.Text = text;
	}

	private bool ValidateInput()
	{
		//IL_02b9: Expected I4, but got O
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		if (_type == ModeratorAction.Unmute)
		{
			return true;
		}
		if ((object)durationText == null)
		{
			goto IL_02ab;
		}
		string text = durationText.Text;
		object msg;
		if (int.TryParse(text, out var result))
		{
			object obj = result - 1;
			bool flag = (nint)obj < 358;
			object obj2 = !flag;
			object obj3 = obj - 358;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			if (obj5 == null)
			{
				_duration = result;
				if ((object)reasonText != null)
				{
					string text2 = reasonText.Text;
					if (text2 != null)
					{
						if (text2._stringLength < 3)
						{
							msg = "Drop Menu Toggle" + 3168;
							goto IL_02db;
						}
						if ((object)reasonText != null)
						{
							string text3 = reasonText.Text;
							object obj6 = this + 128;
							obj6 = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X20_v6-40]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X20_v6-40]");
								string text4 = ((InputFieldTMProUGUI)0).Text;
								if (text4 != null)
								{
									if (text4._stringLength < 3)
									{
										msg = "Drop Menu Toggle" + 3144;
										goto IL_02db;
									}
									if ((object)descriptionText != null)
									{
										string text5 = descriptionText.Text;
										object obj7 = this + 136;
										obj7 = text5;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										return true;
									}
								}
							}
						}
					}
				}
				goto IL_02ab;
			}
		}
		msg = "Drop Menu Toggle" + 3152;
		goto IL_02db;
		IL_02ab:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_02db:
		ShowError((string)msg);
		return false;
	}

	private void ShowError(string msg)
	{
		//IL_0026: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0046: Expected O, but got I
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_008e: Expected I, but got O
		//IL_00bd: Expected O, but got I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_013d: Expected O, but got I4
		send.interactable = false;
		object obj = (nint)0 + (nint)288;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)3256;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, msg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(3f, action);
		PopupUI popupUI = popup;
		object obj7 = typeof(SqlSingle[]) + 3912;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AnimationExtensions.ErrorFeedback(popupUI.content, 10f, 1f);
	}

	private void EnableSend()
	{
		//IL_0026: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		send.interactable = true;
		object obj = (nint)0 + (nint)288;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, friendlyName);
	}

	private void Send()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0040: Expected I8, but got I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0164: Expected O, but got I4
		//IL_018d: Expected O, but got I
		//IL_04d3: Expected O, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01e2: Expected I, but got O
		//IL_01f2: Expected O, but got I
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_0281: Expected O, but got I4
		//IL_022d: Expected O, but got I
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_02f1: Expected O, but got I
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_0481: Expected O, but got I
		//IL_048f: Expected I, but got O
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_04a3: Expected I8, but got I4
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0436: Expected O, but got I
		//IL_0444: Expected I, but got O
		//IL_03b2: Expected O, but got I4
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03ea: Expected O, but got I
		//IL_03f8: Expected I, but got O
		if (!ValidateInput())
		{
			return;
		}
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		BanRequestModel banRequestModel = default(BanRequestModel);
		banRequestModel..ctor();
		banRequestModel.<UserID>k__BackingField = _userId;
		banRequestModel.<Duration>k__BackingField = _duration;
		object obj2 = banRequestModel + 32;
		obj2 = _reason;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = banRequestModel + 40;
		obj3 = _comment;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v15+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SFSConfig currentSFS = Config.CurrentSFS;
		object obj7 = banRequestModel + 48;
		obj7 = currentSFS.<ID>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = typeof(Queue<string>) + 848;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v22+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		if (currentRoom == null)
		{
			goto IL_04c7;
		}
		object obj12 = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)currentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v40 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v40 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_026e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v40 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X10_v7-8]");
			if (0 == (nint)obj12)
			{
				break;
			}
			obj14 += 16;
			obj13--;
			if ((nint)obj13 != 1)
			{
				continue;
			}
			goto IL_026e;
		}
		object obj15 = obj14 + 1;
		object obj16 = num + obj15;
		object obj17 = obj16 + 312;
		goto IL_0517;
		IL_026e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		string text = (string)1;
		object obj18 = default(object);
		obj17 = obj18;
		goto IL_0517;
		IL_0517:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v305 @ X8_v41] (should have been resolved before IL gen)");
		goto IL_04c7;
		IL_04c7:
		object obj19 = (nint)0 + (nint)2000;
		Room room = (Room)((currentRoom != null) ? currentRoom : obj19);
		object obj20 = banRequestModel + 56;
		obj20 = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ChatMessageData messageData = _messageData;
		string text2;
		if (_messageData != null)
		{
			object obj21 = "The '{0}' attribute is not declared." + 4064;
			object obj22 = (nint)0 + (nint)2408;
			string reportText = ChatHandler.GetReportText();
			text = (string)obj22;
			text2 = (string)obj21 + messageData.<Message>k__BackingField + (string)obj22 + reportText;
		}
		else
		{
			text2 = ChatHandler.GetReportText();
		}
		object obj23 = banRequestModel + 64;
		obj23 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (_type != ModeratorAction.Unmute)
		{
			if (_type != ModeratorAction.Mute)
			{
				bool flag3 = _type == ModeratorAction.Kick;
				object obj24 = !flag3;
				if (obj24 == null)
				{
					object obj25 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj26 = (nint)0 + (nint)3248;
					Action<object> action = default(Action<object>);
					action..ctor((object)this, (IntPtr)obj26);
					KammelnaRequests.BanUser(banRequestModel, action);
				}
			}
			else
			{
				object obj27 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj28 = (nint)0 + (nint)3248;
				Action<object> action2 = default(Action<object>);
				action2..ctor((object)this, (IntPtr)obj28);
				KammelnaRequests.MuteUser(banRequestModel, action2);
			}
		}
		else
		{
			object obj29 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj30 = (nint)0 + (nint)3248;
			Action<object> action3 = default(Action<object>);
			action3..ctor((object)this, (IntPtr)obj30);
			KammelnaRequests.UnbanUser(_userId, action3);
		}
	}

	private string GetData()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		ChatMessageData messageData = _messageData;
		if (_messageData != null)
		{
			object obj = "The '{0}' attribute is not declared." + 4064;
			object obj2 = (nint)0 + (nint)2408;
			string reportText = ChatHandler.GetReportText();
			return (string)obj + messageData.<Message>k__BackingField + (string)obj2 + reportText;
		}
		return ChatHandler.GetReportText();
	}

	private void Callback(KammelnaResponseModel<bool> response)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		if (response.Succeeded)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069538]");
			_type = ModeratorAction.Kick;
			object obj = this + 104;
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_userId = _userId;
			ShowPopup();
		}
	}

	private void <UpdateUi>b__26_0(KammelnaResponseModel<BanInfoModel> response)
	{
		//IL_0011: Expected O, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_013c: Expected O, but got I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_00aa: Expected O, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_01c7: Expected O, but got I
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1008;
		if (!((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			return;
		}
		BanInfoModel <Model>k__BackingField = response.<Model>k__BackingField;
		if (response.<Model>k__BackingField != null)
		{
			reasonText.Text = <Model>k__BackingField.<banReason>k__BackingField;
			object text = "Material with texture name \"" + 2264;
			TextMeshProExtensions.Localize(cancelBanText, (string)text);
			cancelBanText.color = (Color)0;
			BanInfoModel <Model>k__BackingField2 = response.<Model>k__BackingField;
			object obj2 = (??)<Model>k__BackingField2.<bannedUntil>k__BackingField & 1;
			DateTime? dateTime;
			if (obj2 != null)
			{
				dateTime = <Model>k__BackingField2.<bannedUntil>k__BackingField;
			}
			else
			{
				object obj3 = (??)<Model>k__BackingField2.<mutedUntil>k__BackingField & 1;
				bool flag = obj3 == null;
				dateTime = <Model>k__BackingField2.<mutedUntil>k__BackingField;
				if (flag)
				{
					goto IL_0237;
				}
			}
			DateTime value = dateTime.Value;
			FormatDuration(value);
			goto IL_0237;
		}
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object input = "Unsupported map type" + 672;
		string text2 = LocalizationUtil.Localize((string)input);
		reasonText.Text = text2;
		object text3 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 1048;
		TextMeshProExtensions.Localize(cancelBanText, (string)text3);
		Color gray = Color.gray;
		cancelBanText.color = (Color)0;
		cancelBan.interactable = false;
		return;
		IL_0237:
		cancelBan.interactable = true;
	}
}
