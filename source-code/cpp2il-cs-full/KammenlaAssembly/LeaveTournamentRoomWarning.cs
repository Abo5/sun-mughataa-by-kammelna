using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class LeaveTournamentRoomWarning : MonoBehaviour
{
	private static readonly TimeSpan Threshold;

	private TournamentData _tournamentData;

	private TournamentsEventsChannel _eventsChannel;

	private static bool WarningIgnored
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "ThisIsFakeReceiptData" + 1504;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "ThisIsFakeReceiptData" + 1504;
			Prefs.SetBool((string)key, value);
		}
	}

	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC0]");
		object obj3 = (nint)0 & (nint)1;
		GameObject gameObject;
		GameObject go;
		if (obj3 != null)
		{
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			go = gameObject;
			object obj5 = 0;
			if (!flag)
			{
				goto IL_0098;
			}
		}
		else
		{
			_ = 1;
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			go = gameObject;
			object obj5 = 0;
			if (obj6 != null)
			{
				goto IL_0098;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ScreenManager.RemovePopup(go);
		return;
		IL_0098:
		ScreenManager.RemovePopup(gameObject);
	}

	public void Init(TournamentData data, TournamentsEventsChannel eventsChannel)
	{
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0135: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_00ea: Expected O, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_009b: Expected O, but got I
		//IL_01f3: Expected O, but got I4
		//IL_019c: Expected O, but got I4
		//IL_01a5: Expected O, but got I4
		//IL_0458: Expected O, but got I
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_0496: Expected O, but got I4
		//IL_023c: Expected O, but got I
		//IL_0275: Expected O, but got I4
		//IL_02ae: Expected O, but got I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_0328: Expected O, but got I4
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_0381: Expected O, but got I
		//IL_038f: Expected I, but got O
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_03cd: Expected O, but got I4
		object obj = this + 32;
		TournamentData tournamentData = default(TournamentData);
		obj = tournamentData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 40;
		obj2 = eventsChannel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v3+98]");
		if ((nint)0 == 1)
		{
			goto IL_002e;
		}
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1848;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v9+E4]");
		object obj6;
		object key;
		if ((nint)0 != 0)
		{
			obj6 = "ThisIsFakeReceiptData" + 1504;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EBD]");
			object obj7 = (nint)0 & (nint)1;
			bool flag = obj7 == null;
			key = obj6;
			if (!flag)
			{
				goto IL_00c0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = "ThisIsFakeReceiptData" + 1504;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EBD]");
			object obj8 = (nint)0 & (nint)1;
			bool flag2 = obj8 == null;
			object obj9 = !flag2;
			key = obj6;
			if (obj9 != null)
			{
				goto IL_00c0;
			}
		}
		_ = 1;
		bool flag3 = Prefs.GetBool((string)key);
		bool flag4 = !flag3;
		object obj10 = !flag4;
		object obj11 = 0;
		bool flag5 = false;
		if (obj10 == null)
		{
			goto IL_01bc;
		}
		return;
		IL_00c0:
		bool flag6 = Prefs.GetBool((string)obj6);
		bool flag7 = !flag6;
		obj11 = 0;
		flag5 = false;
		if (!flag7)
		{
			return;
		}
		goto IL_01bc;
		IL_002e:
		ActivateLeaveWarning();
		return;
		IL_01bc:
		object obj12 = obj;
		object obj13 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v13+E4]");
		bool flag8 = (nint)0 == 0;
		object obj14 = !flag8;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v13+B8]");
		object obj15 = 0;
		object obj16 = typeof(DataRelation) + 712;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v14+E4]");
		bool flag9 = (nint)0 == 0;
		object obj18 = !flag9;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v9+A8]");
		DateTime dateTime = (DateTime)0 - (TimeSpan)obj15;
		DateTime now = DateTime.Now;
		bool flag10 = now > dateTime;
		bool flag11 = !flag10;
		object obj19 = !flag11;
		if (obj19 == null)
		{
			object obj20 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v21+E4]");
			bool flag12 = (nint)0 == 0;
			object obj21 = !flag12;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now2 = DateTime.Now;
			TimeSpan timeSpan = dateTime - now2;
			object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v27+E4]");
			bool flag13 = (nint)0 == 0;
			object obj24 = !flag13;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan2 = default(TimeSpan);
			double totalSeconds = timeSpan2.TotalSeconds;
			object obj25 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj26 = (nint)0 + (nint)672;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj26);
			object obj27 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v32+E4]");
			bool flag14 = (nint)0 == 0;
			object obj29 = !flag14;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds((float)totalSeconds, action);
			return;
		}
		goto IL_002e;
	}

	public void CancelLeaveWarning()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC0]");
		object obj3 = (nint)0 & (nint)1;
		GameObject gameObject;
		GameObject go;
		if (obj3 != null)
		{
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			go = gameObject;
			object obj5 = 0;
			if (!flag)
			{
				goto IL_0098;
			}
		}
		else
		{
			_ = 1;
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			go = gameObject;
			object obj5 = 0;
			if (obj6 != null)
			{
				goto IL_0098;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ScreenManager.RemovePopup(go);
		return;
		IL_0098:
		ScreenManager.RemovePopup(gameObject);
	}

	private void ActivateLeaveWarning()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00b5: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)712;
		object obj3 = typeof(RegisteredWaitHandle) + 3136;
		GameObject popup = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(popup, action, persistent: true);
	}

	private void ShowLeaveWarning()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0070: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0298: Expected I, but got O
		//IL_02a8: Expected O, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I4
		//IL_0352: Expected O, but got I4
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_03b6: Expected O, but got I
		//IL_02e3: Expected O, but got I
		//IL_044c: Expected O, but got I
		//IL_0470: Expected O, but got I4
		//IL_04c9: Expected O, but got I
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_04f0: Expected O, but got I
		//IL_03f1: Expected O, but got I
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_057f: Expected O, but got I4
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_0cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce1: Expected O, but got Unknown
		//IL_0dd7: Expected I, but got O
		//IL_052b: Expected O, but got I
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected O, but got Unknown
		//IL_04ae: Expected O, but got I
		//IL_05c6: Expected O, but got I
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected O, but got Unknown
		//IL_05ed: Expected O, but got I
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_01b0: Expected I, but got O
		//IL_01c0: Expected O, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected O, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected O, but got Unknown
		//IL_026a: Expected O, but got I4
		//IL_0e38: Expected I, but got O
		//IL_0628: Expected O, but got I
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_094f: Expected O, but got I
		//IL_01fb: Expected O, but got I
		//IL_06b0: Expected O, but got I
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_0f49: Expected O, but got I
		//IL_0f57: Expected I, but got O
		//IL_0f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Expected O, but got Unknown
		//IL_098a: Expected O, but got I
		//IL_0915: Unknown result type (might be due to invalid IL or missing references)
		//IL_091a: Expected O, but got Unknown
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Expected O, but got Unknown
		//IL_0e99: Expected I, but got O
		//IL_06eb: Expected O, but got I
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected O, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_0a1a: Expected O, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0773: Expected O, but got I
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fd: Expected O, but got Unknown
		//IL_081d: Expected O, but got I4
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected O, but got Unknown
		//IL_0fc7: Expected I, but got O
		//IL_0a55: Expected O, but got I
		//IL_0998: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Expected O, but got Unknown
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected O, but got Unknown
		//IL_087a: Expected O, but got I
		//IL_089a: Expected O, but got I4
		//IL_07ae: Expected O, but got I
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Expected O, but got Unknown
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected O, but got Unknown
		//IL_0add: Expected O, but got I
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Expected O, but got Unknown
		//IL_104b: Expected O, but got I
		//IL_08be: Expected O, but got I
		//IL_0846: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected O, but got Unknown
		//IL_0b92: Expected O, but got I
		//IL_0bb2: Expected O, but got I4
		//IL_0b18: Expected O, but got I
		//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a68: Expected O, but got Unknown
		//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a76: Expected O, but got Unknown
		//IL_0ef7: Expected O, but got I4
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected O, but got Unknown
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected O, but got Unknown
		//IL_0c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c45: Expected O, but got Unknown
		//IL_0c5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c60: Expected O, but got Unknown
		//IL_0bd6: Expected O, but got I
		//IL_0c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c80: Expected O, but got Unknown
		//IL_0ca4: Expected O, but got I4
		//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d1: Expected O, but got Unknown
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Expected O, but got Unknown
		//IL_1025: Expected O, but got I4
		//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2b: Expected O, but got Unknown
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Expected O, but got Unknown
		//IL_0908: Expected O, but got I4
		//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be9: Expected O, but got Unknown
		//IL_0bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf7: Expected O, but got Unknown
		//IL_0c12: Expected O, but got I4
		TournamentData tournamentData = _tournamentData;
		object obj = typeof(System.IOAsyncCallback) + 392;
		object obj2 = "Unsupported map type" + 3592;
		object obj3 = typeof(System.IOAsyncCallback) + 384;
		object obj4 = typeof(System.IOAsyncCallback) + 368;
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)680;
		object label = "COORDINATE_TYPE_GCJ_02" + 1864;
		if (tournamentData.<IsInstant>k__BackingField)
		{
			object obj7 = typeof(DataRelation) + 712;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v58+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			TournamentData tournamentData2 = _tournamentData;
			if (now <= tournamentData2.<StartingTime>k__BackingField)
			{
				TournamentData tournamentData3 = _tournamentData;
				object obj10 = "https://www.kammelna.com/Home/Terms" + 1584;
				if (_tournamentData != null)
				{
					object obj11 = "not" + 1024;
					object obj12 = "m_StencilDeferredPS" + 592;
					if (tournamentData3.<Type>k__BackingField == TournamentType.Official)
					{
						obj10 = obj11;
					}
					if (tournamentData3.<Type>k__BackingField == TournamentType.Mass)
					{
						obj10 = obj12;
					}
				}
				goto IL_1055;
			}
		}
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Error);
		nint num = (nint)popupWindowBuilderNeedsTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v13 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v13 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0324;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v13 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X10_v43-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj14 += 16;
			obj13--;
			if ((nint)obj13 != 1)
			{
				continue;
			}
			goto IL_0324;
		}
		object obj15 = num + obj14;
		object obj16 = obj15 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v412 @ X8_v43] (should have been resolved before IL gen)");
		goto IL_038f;
		IL_0e16:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v981 @ X0_v20] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		object obj17;
		action..ctor(this, (IntPtr)obj17);
		object label2;
		PopupButton popupButton = PopupButton.Neutral((string)label2, action);
		object obj19 = default(object);
		object obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ X8_v24+12E]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ X8_v24+12E]");
		if ((nint)0 == 0)
		{
			goto IL_072c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ X8_v24+B0]");
		object obj21 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1101 @ X10_v23-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj21 += 16;
			obj20--;
			if ((nint)obj20 != 1)
			{
				continue;
			}
			goto IL_072c;
		}
		object obj22 = obj18 + obj21;
		object obj23 = obj22 + 312;
		goto IL_0e77;
		IL_0937:
		object obj25 = default(object);
		object obj24 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v55+12E]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v55+12E]");
		if ((nint)0 == 0)
		{
			goto IL_09cb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v55+B0]");
		object obj27 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X10_v67-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj27 += 16;
			obj26--;
			if ((nint)obj26 != 1)
			{
				continue;
			}
			goto IL_09cb;
		}
		object obj28 = obj24 + obj27;
		object obj29 = obj28 + 312;
		goto IL_0f29;
		IL_072c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0e77;
		IL_0669:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0e16;
		IL_09cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj30 = default(object);
		obj29 = obj30;
		goto IL_0f29;
		IL_0cb2:
		throw new NullReferenceException();
		IL_0fa5:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1053 @ X0_v73] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj6);
		PopupButton popupButton2 = PopupButton.Neutral((string)label, action2);
		object obj32 = default(object);
		object obj31 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1134 @ X8_v64+12E]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1134 @ X8_v64+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0b59;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1134 @ X8_v64+B0]");
		object obj34 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X10_v57-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj34 += 16;
			obj33--;
			if ((nint)obj33 != 1)
			{
				continue;
			}
			goto IL_0b59;
		}
		object obj35 = obj31 + obj34;
		object obj36 = obj35 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1171 @ X0_v85] (should have been resolved before IL gen)");
		object obj37 = default(object);
		bool flag2 = obj37 == null;
		object obj38 = !flag2;
		if (obj38 != null)
		{
			goto IL_0b72;
		}
		goto IL_0cb2;
		IL_0c20:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj40 = default(object);
		object obj39 = obj40;
		goto IL_1033;
		IL_0324:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v546 @ X0_v54] (should have been resolved before IL gen)");
		object obj41 = default(object);
		bool flag3 = obj41 == null;
		object obj42 = !flag3;
		if (obj42 != null)
		{
			goto IL_038f;
		}
		goto IL_0cb2;
		IL_038f:
		object obj43 = "startPosition" + 4048;
		object obj44 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v17+12E]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v17+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0432;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v17+B0]");
		object obj46 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X10_v38-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj46 += 16;
			obj45--;
			if ((nint)obj45 != 1)
			{
				continue;
			}
			goto IL_0432;
		}
		object obj47 = obj44 + obj46;
		object obj48 = obj47 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v40+8]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v414 @ X8_v40] (should have been resolved before IL gen)");
		goto IL_04bd;
		IL_07ef:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1284 @ X0_v36] (should have been resolved before IL gen)");
		bool flag4 = obj37 == null;
		object obj50 = !flag4;
		if (obj50 != null)
		{
			goto IL_085a;
		}
		goto IL_0cb2;
		IL_085a:
		object obj51 = obj4;
		object obj52 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1354 @ X8_v7+12E]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1354 @ X8_v7+12E]");
		bool flag5 = (nint)0 == 0;
		object obj54 = 0;
		if (flag5)
		{
			goto IL_0c20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1354 @ X8_v7+B0]");
		object obj55 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1327 @ X10_v3-8]");
			bool flag6 = 0 == (nint)obj51;
			obj54 = 0;
			if (flag6)
			{
				break;
			}
			obj55 += 16;
			obj53--;
			if ((nint)obj53 != 1)
			{
				continue;
			}
			goto IL_08ff;
		}
		goto IL_0c37;
		IL_0c37:
		object obj56 = obj55 + 9;
		object obj57 = obj52 + obj56;
		obj39 = obj57 + 312;
		goto IL_1033;
		IL_0a96:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0fa5;
		IL_0432:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X0_v50+8]");
		obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v626 @ X0_v50] (should have been resolved before IL gen)");
		object obj58 = default(object);
		bool flag7 = obj58 == null;
		object obj59 = !flag7;
		if (obj59 != null)
		{
			goto IL_04bd;
		}
		goto IL_0cb2;
		IL_04bd:
		object obj60 = (nint)0 + (nint)704;
		object label3 = "LAK" + 880;
		object obj61 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v19+12E]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v19+12E]");
		if ((nint)0 == 0)
		{
			goto IL_056c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v19+B0]");
		object obj63 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X10_v33-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj63 += 16;
			obj62--;
			if ((nint)obj62 != 1)
			{
				continue;
			}
			goto IL_056c;
		}
		object obj64 = obj63 + 4;
		object obj65 = obj61 + obj64;
		object obj66 = obj65 + 312;
		goto IL_0db5;
		IL_023c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v763 @ X0_v93] (should have been resolved before IL gen)");
		bool flag8 = obj25 == null;
		object obj67 = !flag8;
		if (obj67 != null)
		{
			goto IL_0937;
		}
		goto IL_0cb2;
		IL_0f29:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v906 @ X8_v56] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj68 = (nint)0 + (nint)688;
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj68);
		object label4 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 840;
		PopupButton popupButton3 = PopupButton.Negative((string)label4, action3);
		object obj70 = default(object);
		object obj69 = obj70;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v61+12E]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v61+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0a96;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v61+B0]");
		object obj72 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X10_v62-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj72 += 16;
			obj71--;
			if ((nint)obj71 != 1)
			{
				continue;
			}
			goto IL_0a96;
		}
		object obj73 = obj69 + obj72;
		object obj74 = obj73 + 312;
		goto IL_0fa5;
		IL_08ff:
		obj54 = 0;
		goto IL_0c20;
		IL_1033:
		object obj75 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v6+8]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v474 @ X2_v3 (should have been resolved before IL gen)");
		goto IL_1055;
		IL_056c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj49 = 4;
		object obj77 = default(object);
		obj66 = obj77;
		goto IL_0db5;
		IL_0db5:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v415 @ X8_v20] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj60);
		PopupButton popupButton4 = PopupButton.Negative((string)label3, action4);
		obj17 = (nint)0 + (nint)696;
		label2 = "LAK" + 864;
		object obj79 = default(object);
		object obj78 = obj79;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v21+12E]");
		object obj80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v21+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0669;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v21+B0]");
		object obj81 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X10_v28-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj81 += 16;
			obj80--;
			if ((nint)obj80 != 1)
			{
				continue;
			}
			goto IL_0669;
		}
		object obj82 = obj78 + obj81;
		object obj83 = obj82 + 312;
		goto IL_0e16;
		IL_1055:
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle2 = PopupWindowBuilder.Create(PopupWindow.MessageType.Error);
		nint num2 = (nint)popupWindowBuilderNeedsTitle2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v53 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v53 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_023c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v53 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj85 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X10_v72-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj85 += 16;
			obj84--;
			if ((nint)obj84 != 1)
			{
				continue;
			}
			goto IL_023c;
		}
		object obj86 = num2 + obj85;
		object obj87 = obj86 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v420 @ X8_v76] (should have been resolved before IL gen)");
		goto IL_0937;
		IL_0b72:
		obj51 = obj4;
		obj52 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1354 @ X8_v7+12E]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1354 @ X8_v7+12E]");
		bool flag9 = (nint)0 == 0;
		obj54 = 0;
		if (flag9)
		{
			goto IL_0c20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1354 @ X8_v7+B0]");
		obj55 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1327 @ X10_v3-8]");
			bool flag10 = 0 == (nint)obj51;
			obj54 = 0;
			if (flag10)
			{
				break;
			}
			obj55 += 16;
			obj88--;
			bool flag11 = (nint)obj88 != 1;
			obj54 = 0;
			if (flag11)
			{
				continue;
			}
			goto IL_0c20;
		}
		goto IL_0c37;
		IL_0e77:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1125 @ X0_v27] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj6);
		PopupButton popupButton5 = PopupButton.Neutral((string)label, action5);
		object obj90 = default(object);
		object obj89 = obj90;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1196 @ X8_v27+12E]");
		object obj91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1196 @ X8_v27+12E]");
		if ((nint)0 == 0)
		{
			goto IL_07ef;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1196 @ X8_v27+B0]");
		object obj92 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X10_v18-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj92 += 16;
			obj91--;
			if ((nint)obj91 != 1)
			{
				continue;
			}
			goto IL_07ef;
		}
		object obj93 = obj89 + obj92;
		object obj94 = obj93 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1370 @ X0_v39] (should have been resolved before IL gen)");
		goto IL_085a;
		IL_0b59:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1155 @ X0_v82] (should have been resolved before IL gen)");
		goto IL_0b72;
	}

	private string GetLeaveWarningMessage()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		TournamentData tournamentData = _tournamentData;
		object result = "https://www.kammelna.com/Home/Terms" + 1584;
		if (_tournamentData != null)
		{
			object obj = "not" + 1024;
			object obj2 = "m_StencilDeferredPS" + 592;
			if (tournamentData.<Type>k__BackingField == TournamentType.Official)
			{
				result = obj;
			}
			if (tournamentData.<Type>k__BackingField == TournamentType.Mass)
			{
				result = obj2;
			}
		}
		return (string)result;
	}

	private void LeaveAndIgnore()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0115: Expected O, but got I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0152: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC3]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = "ThisIsFakeReceiptData" + 1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EBE]");
		object obj7 = (nint)0 & (nint)1;
		if (obj7 == null)
		{
			goto IL_00d2;
		}
		object key = obj6;
		goto IL_017c;
		IL_00d2:
		_ = 1;
		key = obj6;
		goto IL_017c;
		IL_007d:
		obj6 = "ThisIsFakeReceiptData" + 1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EBE]");
		object obj8 = (nint)0 & (nint)1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		key = obj6;
		if (obj9 == null)
		{
			goto IL_00d2;
		}
		goto IL_017c;
		IL_017c:
		Prefs.SetBool((string)key, value: true);
		Leave();
	}

	private void ForfeitAndLeave()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0104: Expected O, but got I
		//IL_013e: Expected O, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00bc: Expected O, but got I4
		//IL_00f6: Expected I4, but got I8
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		SFS.SendLockedRoomRequest(LockedRoomRequestSubCommand.Forfeit);
		Leave();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		if (SFSKammelnaRoomExtensions.IsTournamentHub(currentRoom))
		{
			TournamentData tournamentData = _tournamentData;
			object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SfsTournamentConnector.SetSeat(tournamentData.<RoomId>k__BackingField, -1, _eventsChannel);
		}
	}

	private void Leave()
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_014a: Expected O, but got I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I4
		//IL_002f: Expected O, but got I
		//IL_005e: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 3136;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		GameObject go = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(Queue<string>) + 840;
		ScreenManager.RemovePopup(go);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = (nint)0 + (nint)2184;
		PopupWindow.DismissMessage();
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		ScreenManager screenManager = default(ScreenManager);
		screenManager.Back();
	}

	private void Cancel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00aa: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E6F]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.DismissMessage();
		return;
		IL_0074:
		PopupWindow.DismissMessage();
	}

	static LeaveTournamentRoomWarning()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		//IL_0052: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1848;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan = TimeSpan.FromMinutes(8.000000001629815);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+B8]");
		object obj6 = 0;
		obj6 = timeSpan;
	}
}
