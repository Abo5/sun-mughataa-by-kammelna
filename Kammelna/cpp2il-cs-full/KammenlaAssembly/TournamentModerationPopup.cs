using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util;

public class TournamentModerationPopup : MonoBehaviour, IInitializable
{
	private const string Command = "mmt";

	private const string NewName = "nn";

	private const string NewStartTime = "nst";

	private const string DeleteCmd = "cncl";

	private const string RefundFees = "rf";

	private DatePickerManager pickerManager;

	private PopupUI popup;

	private InputFieldTMProUGUI nameInput;

	private InputFieldTMProUGUI dateInput;

	private Toggle refundFeesToggle;

	private TextMeshProUGUI tournamentIdText;

	private TextMeshProUGUI roomIdText;

	private TournamentViewConnector Connector
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			return (TournamentViewConnector)0;
		}
	}

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		InputFieldTMProUGUI inputFieldTMProUGUI = dateInput;
		object obj = typeof(TypeConverter<ushort, char>) + 400;
		object obj2 = (nint)0 + (nint)1104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction = default(UnityAction<object>);
		unityAction..ctor((object)this, (IntPtr)obj2);
		((UnityEvent<object>)(object)inputFieldTMProUGUI.onSelect).AddListener(unityAction);
	}

	public void Initialize()
	{
		Show();
	}

	public void Show()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_02d3: Expected O, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_00a2: Expected O, but got I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0170: Expected O, but got I
		//IL_019b: Expected O, but got I4
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01fa: Expected O, but got I4
		//IL_0257: Expected O, but got I
		//IL_0271: Expected O, but got I4
		popup.PopFromCenter();
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v6+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v180 @ X8_v8+188] (should have been resolved before IL gen)");
		object obj6 = default(object);
		if (obj6 != null)
		{
			object obj7 = typeof(Queue<string>) + 848;
			object obj8 = (nint)0 + (nint)2200;
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			Room currentRoom = sessionModel.CurrentRoom;
			if (SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom) != TournamentStatus.Scheduled)
			{
				GameObject gameObject = dateInput.gameObject;
				gameObject.SetActive(value: false);
			}
			object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
			object obj12 = typeof(DataRelation) + 712;
			InputFieldTMProUGUI inputFieldTMProUGUI = nameInput;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v7+48]");
			inputFieldTMProUGUI.Text = (string)0;
			object obj13 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj14 = !flag2;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj15 = "utf-32" + 2808;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			object obj16 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v21+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime = default(DateTime);
			string text = dateTime.ToString((string)obj15, invariantCulture);
			dateInput.Text = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v7+10]");
			object obj18 = (nint)0 & (nint)1;
			bool flag4 = obj18 == null;
			object obj19 = !flag4;
			if (obj19 == null)
			{
			}
			int? num = default(int?);
			string text2 = num.ToString();
			tournamentIdText.text = text2;
			int num2 = default(int);
			string text3 = num2.ToString();
			roomIdText.text = text3;
		}
	}

	private void ShowDatePicker(InputField _)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0084: Expected O, but got I
		//IL_006a: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ X8_v6+188] (should have been resolved before IL gen)");
		object obj6 = default(object);
		if (obj6 != null)
		{
			DatePickerManager datePickerManager = pickerManager;
			InputFieldTMProUGUI inputField = dateInput;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5+A8]");
			datePickerManager.PickDateTime(inputField, (DateTime)0, IPicker.PickerMode.FutureOnly);
		}
	}

	public unsafe void Save()
	{
		//IL_0016: Expected O, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0111: Expected O, but got I
		//IL_012b: Expected O, but got I4
		//IL_0134: Expected O, but got I4
		//IL_0145: Expected O, but got I4
		//IL_00ac: Expected O, but got I
		//IL_00ce: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0075: Expected O, but got I4
		//IL_0086: Expected O, but got I4
		//IL_0171: Expected O, but got I
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_0427: Expected O, but got I4
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01fd: Expected O, but got I
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_04a0: Expected O, but got I4
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_033d: Expected O, but got I4
		//IL_035c: Expected O, but got Ref
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_0518: Expected O, but got I4
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_03a4: Expected O, but got I4
		//IL_03ad: Expected O, but got I4
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected O, but got Unknown
		//IL_056c: Expected O, but got I4
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected O, but got Unknown
		//IL_05ee: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E85]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		DateTime result;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B9]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			result = (DateTime)0;
			obj4 = obj2;
			result = (DateTime)0;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B9]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			result = (DateTime)0;
			obj4 = obj2;
			result = (DateTime)0;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v32+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		goto IL_017e;
		IL_02fb:
		string text;
		CultureInfo provider;
		bool flag3 = DateTime.TryParse(text, provider, DateTimeStyles.None, out result);
		bool flag4 = !flag3;
		object obj11 = default(object);
		object obj10 = obj11 + 168;
		object obj12 = !flag4;
		object obj13 = ~obj12;
		object obj14 = ((obj13 != null) ? obj10 : ((object)(&result)));
		object obj16;
		object obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v27+E4]");
		object obj17;
		object command;
		if ((nint)0 != 0)
		{
			obj17 = "m_StencilDeferredPS" + 2160;
			bool flag5 = (DateTime)obj14 != (DateTime)obj10;
			bool flag6 = !flag5;
			object obj18 = !flag6;
			object obj19 = 0;
			command = obj17;
			if (obj18 == null)
			{
				goto IL_03c3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = "m_StencilDeferredPS" + 2160;
			bool flag7 = (DateTime)obj14 != (DateTime)obj10;
			bool flag8 = !flag7;
			object obj19 = 0;
			command = obj17;
			if (flag8)
			{
				goto IL_03c3;
			}
		}
		object obj20 = typeof(DataRelation) + 824;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v29+E4]");
		bool flag9 = (nint)0 == 0;
		object obj22 = !flag9;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long val = DateTimeUtil.ToEpochMilli((DateTime)obj14);
		object key = "not" + 288;
		SFSObject sFSObject = default(SFSObject);
		SFSExtensions.Put(sFSObject, (string)key, val);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
		PopupUI popupUI = popup;
		bool flag10 = (object)popup == null;
		object obj23 = !flag10;
		if (obj23 != null)
		{
			goto IL_03df;
		}
		goto IL_05fc;
		IL_03df:
		popupUI.ShrinkToParent();
		return;
		IL_05fc:
		throw new NullReferenceException();
		IL_0094:
		object obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v37+B8]");
		object obj25 = 0;
		obj9 = obj25;
		bool flag11 = obj25 == null;
		object obj26 = !flag11;
		if (obj26 != null)
		{
			goto IL_017e;
		}
		goto IL_05fc;
		IL_017e:
		object obj27 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ X8_v4+188] (should have been resolved before IL gen)");
		if (obj11 != null)
		{
			object obj28 = typeof(RegisteredWaitHandle) + 2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			sFSObject..ctor();
			string text2 = nameInput.Text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v4+48]");
			bool flag12 = text2 != (string)0;
			bool flag13 = !flag12;
			string text3 = null;
			if (!flag13)
			{
				object key2 = "m_StencilDeferredPS" + 3728;
				SFSExtensions.Put(sFSObject, (string)key2, text2);
				text3 = text2;
			}
			object obj29 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
			obj16 = typeof(DataRelation) + 712;
			text = dateInput.Text;
			object obj30 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v17+E4]");
			CultureInfo cultureInfo;
			if ((nint)0 != 0)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				object obj31 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v18+E4]");
				bool flag14 = (nint)0 == 0;
				provider = invariantCulture;
				cultureInfo = invariantCulture;
				if (!flag14)
				{
					goto IL_02fb;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
				object obj31 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v18+E4]");
				bool flag15 = (nint)0 == 0;
				object obj32 = !flag15;
				provider = invariantCulture2;
				cultureInfo = invariantCulture2;
				if (obj32 != null)
				{
					goto IL_02fb;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			provider = cultureInfo;
			goto IL_02fb;
		}
		object obj33 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v5+E4]");
		bool flag16 = (nint)0 == 0;
		object obj35 = !flag16;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "Index = {0} position = {1}" + 1736;
		PopupWindow.ShowError((string)message);
		return;
		IL_03c3:
		SFS.SendRoomExtensionRequest((string)obj17, sFSObject);
		popupUI = popup;
		goto IL_03df;
	}

	public void Delete()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_00a0: Expected I, but got O
		//IL_00ca: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1096;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "Complete" + 256;
		object msgBody = "Added Tournament Prizes And Features" + 2208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action);
		popup.ShrinkToParent();
	}

	private void Hide()
	{
		popup.ShrinkToParent();
	}

	private void <Delete>b__19_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, val: true);
		Toggle toggle = refundFeesToggle;
		object command = "m_StencilDeferredPS" + 2160;
		if (toggle.m_IsOn)
		{
			object key2 = "placementId" + 3928;
			SFSExtensions.Put(sFSObject, (string)key2, val: true);
		}
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}
}
