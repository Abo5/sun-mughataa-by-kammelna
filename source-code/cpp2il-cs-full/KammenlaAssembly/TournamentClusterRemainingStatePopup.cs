using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server;
using Sfs2X.Entities;
using Spine;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentClusterRemainingStatePopup : MonoBehaviour
{
	private TournamentsEventsChannel eventsChannel;

	private PopupUI popup;

	private DateTimeText[] timers;

	private ProgressBar progressBar;

	private CircularProgress progressCircle;

	private RectTransform scaleBody;

	private CanvasGroup mainGroup;

	private CanvasGroup smallGroup;

	private Room TournamentClusterRoom
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00dc: Expected O, but got I
			//IL_0106: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_014f: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC5]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_015d;
			IL_00b8:
			return sessionModel.CurrentRoom;
			IL_015d:
			return (Room)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_015d;
		}
	}

	private int TournamentSize
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0120: Expected O, but got I
			//IL_014a: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01af: Expected I4, but got O
			//IL_0193: Expected O, but got I4
			//IL_00ee: Expected I4, but got O
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC5]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_01a1;
			IL_00b8:
			Room currentRoom = sessionModel.CurrentRoom;
			TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom);
			bool flag4 = tournamentInfo == null;
			int result = (int)tournamentInfo;
			if (!flag4)
			{
				result = tournamentInfo.<MaxAllowedSize>k__BackingField;
			}
			return result;
			IL_01a1:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_01a1;
		}
	}

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

	private bool IsParticipating
	{
		get
		{
			//IL_0016: Expected O, but got I
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected O, but got Unknown
			//IL_00ff: Expected O, but got I
			//IL_0119: Expected O, but got I4
			//IL_009a: Expected O, but got I
			//IL_00bc: Expected O, but got I4
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_005d: Expected O, but got I
			//IL_014d: Expected O, but got I
			//IL_0233: Expected I4, but got O
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Expected O, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E72]");
			object obj = (nint)0 & (nint)1;
			object obj2;
			object obj4;
			if (obj != null)
			{
				obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B7]");
				object obj3 = (nint)0 & (nint)1;
				bool flag = obj3 == null;
				obj4 = obj2;
				if (!flag)
				{
					goto IL_0082;
				}
			}
			else
			{
				_ = 1;
				obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B7]");
				object obj5 = (nint)0 & (nint)1;
				bool flag2 = obj5 == null;
				object obj6 = !flag2;
				obj4 = obj2;
				if (obj6 != null)
				{
					goto IL_0082;
				}
			}
			_ = 1;
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v10+B8]");
			object obj8 = 0;
			object obj9 = obj8;
			if (obj8 != null)
			{
				goto IL_0172;
			}
			goto IL_0225;
			IL_0225:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0172:
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ X8_v4+188] (should have been resolved before IL gen)");
			object obj11 = default(object);
			if (obj11 != null)
			{
				object obj12 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v5+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v4+30]");
					return SfsTournamentConnector.IsParticipating(0);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v4+30]");
				return SfsTournamentConnector.IsParticipating(0);
			}
			goto IL_0225;
			IL_0082:
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v15+B8]");
			object obj15 = 0;
			obj9 = obj15;
			bool flag3 = obj15 == null;
			object obj16 = !flag3;
			if (obj16 != null)
			{
				goto IL_0172;
			}
			goto IL_0225;
		}
	}

	private void Start()
	{
		//IL_0016: Expected O, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_017a: Expected O, but got I
		//IL_0192: Expected I, but got O
		//IL_014d: Expected O, but got I
		//IL_01ac: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E73]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B7]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B7]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		goto IL_015a;
		IL_015a:
		object obj10 = typeof(SqlSingle[]) + 2376;
		object obj11 = (nint)0 + (nint)664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3+20]");
		((OneShotEvent)0).CallWhenReady(action);
		return;
		IL_0082:
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v12+B8]");
		object obj13 = 0;
		obj9 = obj13;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_015a;
	}

	private void Init()
	{
		//IL_0016: Expected O, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01e5: Expected O, but got I
		//IL_028c: Expected O, but got I
		//IL_02b6: Expected O, but got I4
		//IL_0267: Expected O, but got I4
		//IL_020e: Expected O, but got I
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_0312: Expected O, but got I
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_034b: Expected I, but got O
		//IL_0385: Expected O, but got I
		//IL_0436: Expected O, but got I4
		//IL_03f3: Expected O, but got I4
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_0496: Expected I, but got O
		//IL_04d0: Expected O, but got I
		//IL_0589: Expected O, but got I4
		//IL_053e: Expected O, but got I4
		//IL_05c9: Expected O, but got I
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		//IL_05f8: Expected O, but got I
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected O, but got Unknown
		//IL_0618: Expected O, but got I
		//IL_0642: Expected I, but got O
		//IL_067f: Expected I, but got O
		//IL_06a5: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC6]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B7]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B7]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v30+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		goto IL_015a;
		IL_02f2:
		object obj10 = typeof(SqlSingle[]) + 2376;
		object obj11 = (nint)0 + (nint)688;
		object varName = "rightCtrl" + 640;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj11);
		GameObject go;
		VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC5]");
		object obj12 = (nint)0 & (nint)1;
		object obj14;
		if (obj12 != null)
		{
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v48+E4]");
			if ((nint)0 != 0)
			{
				goto IL_03cf;
			}
		}
		else
		{
			_ = 1;
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v48+E4]");
			bool flag3 = (nint)0 == 0;
			object obj15 = !flag3;
			if (obj15 != null)
			{
				goto IL_03cf;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_045d;
		IL_0243:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj16 = !flag4;
		if (obj16 != null)
		{
			goto IL_02f2;
		}
		goto IL_06bb;
		IL_06bb:
		throw new NullReferenceException();
		IL_0082:
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v35+B8]");
		object obj18 = 0;
		obj9 = obj18;
		bool flag5 = obj18 == null;
		object obj19 = !flag5;
		if (obj19 != null)
		{
			goto IL_015a;
		}
		goto IL_06bb;
		IL_015a:
		object obj20 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ X8_v4+188] (should have been resolved before IL gen)");
		object obj21 = default(object);
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v4+C8]");
			if ((nint)0 != 1)
			{
				return;
			}
		}
		go = base.gameObject;
		obj14 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC5]");
		object obj22 = (nint)0 & (nint)1;
		object obj25;
		object obj23;
		if (obj22 != null)
		{
			obj23 = (nint)0 + (nint)2200;
			object obj24 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v63+E4]");
			bool flag6 = (nint)0 == 0;
			obj25 = obj23;
			if (!flag6)
			{
				goto IL_0243;
			}
		}
		else
		{
			_ = 1;
			obj23 = (nint)0 + (nint)2200;
			object obj24 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v63+E4]");
			bool flag7 = (nint)0 == 0;
			object obj26 = !flag7;
			obj25 = obj23;
			if (obj26 != null)
			{
				goto IL_0243;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj23 = obj25;
		goto IL_02f2;
		IL_05bd:
		object obj27 = (nint)0 + (nint)696;
		object varName2 = "placementId" + 296;
		object obj28 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj29 = (nint)0 + (nint)672;
		object obj30 = typeof(SkeletonBinary.SkeletonInput) + 4032;
		object obj31 = (nint)0 + (nint)680;
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom2 = sessionModel2.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj27);
		GameObject go3;
		VariableBinderExtensions.Bind(go3, currentRoom2, (string)varName2, action2);
		ShowStatus();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj29);
		SFS.OnJoinGameRoom += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentsEventsChannel.TournamentSeatChanged tournamentSeatChanged = default(TournamentsEventsChannel.TournamentSeatChanged);
		tournamentSeatChanged..ctor(this, (IntPtr)obj31);
		eventsChannel.OnTournamentSeatChanged += tournamentSeatChanged;
		return;
		IL_051a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag8 = (object)sessionModel2 == null;
		object obj32 = !flag8;
		object obj33 = obj10;
		if (obj32 != null)
		{
			goto IL_05bd;
		}
		goto IL_06bb;
		IL_045d:
		object varName3 = "startPosition" + 104;
		SessionModel sessionModel3 = default(SessionModel);
		Room currentRoom3 = sessionModel3.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj11);
		VariableBinderExtensions.Bind(go2, currentRoom3, (string)varName3, action4);
		go3 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC5]");
		object obj34 = (nint)0 & (nint)1;
		if (obj34 != null)
		{
			object obj35 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v33+E4]");
			if ((nint)0 != 0)
			{
				goto IL_051a;
			}
		}
		else
		{
			_ = 1;
			object obj35 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v33+E4]");
			bool flag9 = (nint)0 == 0;
			object obj36 = !flag9;
			if (obj36 != null)
			{
				goto IL_051a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj33 = obj10;
		goto IL_05bd;
		IL_03cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag10 = (object)sessionModel3 == null;
		object obj37 = !flag10;
		if (obj37 != null)
		{
			goto IL_045d;
		}
		goto IL_06bb;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_008a: Expected I, but got O
		//IL_005d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)672;
		object obj3 = typeof(SkeletonBinary.SkeletonInput) + 4032;
		object obj4 = (nint)0 + (nint)680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinGameRoom -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentsEventsChannel.TournamentSeatChanged tournamentSeatChanged = default(TournamentsEventsChannel.TournamentSeatChanged);
		tournamentSeatChanged..ctor(this, (IntPtr)obj4);
		eventsChannel.OnTournamentSeatChanged -= tournamentSeatChanged;
	}

	private void OnSeatChanged(int roomId, int seat)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0133: Expected O, but got I
		//IL_014d: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0175: Expected O, but got I
		//IL_019f: Expected O, but got I4
		//IL_00f0: Expected O, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01fc: Expected I, but got O
		//IL_020c: Expected O, but got I
		//IL_0247: Expected O, but got I
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC7]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC5]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC5]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = (nint)0 + (nint)2200;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj11 = obj8;
		if (obj10 != null)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_0288:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v238 @ X0_v8] (should have been resolved before IL gen)");
		if (seat < 1)
		{
			return;
		}
		goto IL_0305;
		IL_0305:
		object obj12 = default(object);
		if (roomId == (nint)obj12)
		{
			ShowStatus();
		}
		return;
		IL_01ce:
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		object obj13 = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)currentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0288;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X10_v6-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			obj15 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_0288;
		}
		object obj16 = num + obj15;
		object obj17 = obj16 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v278 @ X8_v11] (should have been resolved before IL gen)");
		if (seat >= 1)
		{
			goto IL_0305;
		}
		return;
		IL_008b:
		obj8 = (nint)0 + (nint)2200;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		obj11 = obj8;
		if (!flag4)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_01b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_01ce;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01ce;
	}

	public void Minimize()
	{
		int num = ShortcutExtensions.DOKill(scaleBody, complete: true);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(scaleBody, 0.5f, 0.3f);
		HideBlocker();
		int num2 = ShortcutExtensions.DOKill(mainGroup, complete: true);
		TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTweenModuleUI.DOFade(mainGroup, 0f, 0.3f);
		mainGroup.blocksRaycasts = false;
		int num3 = ShortcutExtensions.DOKill(smallGroup, complete: true);
		TweenerCore<float, float, FloatOptions> tweenerCore3 = DOTweenModuleUI.DOFade(smallGroup, 1f, 0.3f);
		smallGroup.blocksRaycasts = true;
	}

	public void Restore()
	{
		int num = ShortcutExtensions.DOKill(scaleBody, complete: true);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(scaleBody, 1f, 0.3f);
		ShowBlocker();
		int num2 = ShortcutExtensions.DOKill(smallGroup, complete: true);
		TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTweenModuleUI.DOFade(smallGroup, 0f, 0.3f);
		smallGroup.blocksRaycasts = false;
		int num3 = ShortcutExtensions.DOKill(mainGroup, complete: true);
		TweenerCore<float, float, FloatOptions> tweenerCore3 = DOTweenModuleUI.DOFade(mainGroup, 1f, 0.3f);
		mainGroup.blocksRaycasts = true;
	}

	private void OnJoinGameRoom(Room obj)
	{
		HideBlocker();
		popup.ShrinkToParent();
	}

	private void ShowStatus()
	{
		//IL_0016: Expected O, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I
		//IL_025a: Expected O, but got I
		//IL_0284: Expected O, but got I4
		//IL_0235: Expected O, but got I4
		//IL_01dc: Expected O, but got I
		//IL_0301: Expected O, but got I4
		//IL_0334: Expected O, but got I
		//IL_03e5: Expected O, but got I4
		//IL_03a2: Expected O, but got I4
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected O, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_04db: Expected O, but got I4
		//IL_0894: Expected O, but got I
		//IL_08a4: Expected O, but got I
		//IL_08c6: Expected O, but got I4
		//IL_08d6: Expected O, but got I
		//IL_0494: Expected O, but got I4
		//IL_049d: Expected O, but got I4
		//IL_0550: Expected O, but got I4
		//IL_04b4: Expected O, but got I4
		//IL_0588: Expected O, but got I4
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_0602: Expected O, but got I4
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected O, but got Unknown
		//IL_067c: Expected O, but got I4
		//IL_06c7: Expected O, but got I4
		//IL_06d0: Expected O, but got I4
		//IL_077a: Expected O, but got I4
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected O, but got Unknown
		//IL_06f5: Expected O, but got I4
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected O, but got Unknown
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected O, but got Unknown
		//IL_071d: Expected O, but got I
		//IL_0736: Expected O, but got I4
		//IL_07d4: Expected O, but got I
		//IL_07e2: Expected I, but got O
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected O, but got Unknown
		//IL_0820: Expected O, but got I4
		//IL_079a: Expected O, but got I4
		//IL_084a: Invalid comparison between F8 and I8
		//IL_086a: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC8]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B7]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B7]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v49+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		goto IL_015a;
		IL_037e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_040c;
		}
		goto IL_087d;
		IL_02c0:
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom = sessionModel2.CurrentRoom;
		bool flag4 = SFSKammelnaRoomExtensions.IsFinalCountdown(currentRoom);
		if (!flag4 || !((TournamentClusterRemainingStatePopup)flag4).IsParticipating)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC5]");
		object obj11 = (nint)0 & (nint)1;
		object obj13;
		if (obj11 != null)
		{
			object obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v53+E4]");
			if ((nint)0 != 0)
			{
				goto IL_037e;
			}
		}
		else
		{
			_ = 1;
			object obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v53+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 != null)
			{
				goto IL_037e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_040c;
		IL_0211:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag6 = (object)sessionModel2 == null;
		object obj15 = !flag6;
		if (obj15 != null)
		{
			goto IL_02c0;
		}
		goto IL_087d;
		IL_0082:
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v54+B8]");
		object obj17 = 0;
		obj9 = obj17;
		bool flag7 = obj17 == null;
		object obj18 = !flag7;
		if (obj18 != null)
		{
			goto IL_015a;
		}
		goto IL_087d;
		IL_015a:
		object obj19 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ X8_v4+188] (should have been resolved before IL gen)");
		object obj20 = default(object);
		if (obj20 == null)
		{
			return;
		}
		obj13 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC5]");
		object obj21 = (nint)0 & (nint)1;
		object obj24;
		object obj22;
		if (obj21 != null)
		{
			obj22 = (nint)0 + (nint)2200;
			object obj23 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v68+E4]");
			bool flag8 = (nint)0 == 0;
			obj24 = obj22;
			if (!flag8)
			{
				goto IL_0211;
			}
		}
		else
		{
			_ = 1;
			obj22 = (nint)0 + (nint)2200;
			object obj23 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v68+E4]");
			bool flag9 = (nint)0 == 0;
			object obj25 = !flag9;
			obj24 = obj22;
			if (obj25 != null)
			{
				goto IL_0211;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj22 = obj24;
		goto IL_02c0;
		IL_040c:
		Room currentRoom2 = sessionModel.CurrentRoom;
		DateTime? tournamentRoundTimer = SFSKammelnaRoomExtensions.GetTournamentRoundTimer(currentRoom2);
		object obj26 = typeof(DataRelation) + 712;
		object obj27 = obj26;
		object obj28 = (??)tournamentRoundTimer & 1;
		DateTime dateTime;
		DateTime dateTime2;
		if (obj28 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v48+E4]");
			bool flag10 = (nint)0 == 0;
			object obj29 = !flag10;
			dateTime = (DateTime)0;
			if (obj29 == null)
			{
				dateTime2 = (DateTime)0;
				goto IL_0500;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v48+E4]");
			bool flag11 = (nint)0 == 0;
			object obj30 = !flag11;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj27 = obj26;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v48+B8]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v34+10]");
			dateTime2 = (DateTime)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v48+E4]");
			bool flag12 = (nint)0 == 0;
			object obj32 = !flag12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v34+10]");
			dateTime = (DateTime)0;
			if (obj32 == null)
			{
				goto IL_0500;
			}
		}
		goto IL_0517;
		IL_0500:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		dateTime = dateTime2;
		goto IL_0517;
		IL_087d:
		throw new NullReferenceException();
		IL_0517:
		DateTime now = DateTime.Now;
		bool flag13 = dateTime < now;
		bool flag14 = !flag13;
		object obj33 = !flag14;
		if (obj33 != null)
		{
			return;
		}
		object obj34 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v19+E4]");
		bool flag15 = (nint)0 == 0;
		object obj35 = !flag15;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now2 = DateTime.Now;
		TimeSpan timeSpan = dateTime - now2;
		object obj36 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj37 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v25+E4]");
		bool flag16 = (nint)0 == 0;
		object obj38 = !flag16;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan3 = default(TimeSpan);
		TimeSpan timeSpan2 = timeSpan3.Duration();
		double totalSeconds = timeSpan3.TotalSeconds;
		object obj39 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj40 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v30+E4]");
		bool flag17 = (nint)0 == 0;
		object obj41 = !flag17;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.DismissMessage();
		DateTimeText[] array = timers;
		bool flag18 = array.Length < 1;
		object obj42 = 0;
		DateTime dateTime3 = (DateTime)0;
		if (!flag18)
		{
			object obj43 = array + 32;
			object obj44 = 0;
			bool flag19;
			do
			{
				obj44++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X23_v5+v152 @ X22_v7*8]");
				((DateTimeText)0).SetDate(dateTime);
				flag19 = (nint)obj44 < array.Length;
				obj42 = 0;
				dateTime3 = dateTime;
			}
			while (flag19);
		}
		PopupUI popupUI = popup;
		bool flag20 = !popupUI.<IsCurrentlyShown>k__BackingField;
		object obj45 = !flag20;
		if (obj45 == null)
		{
			popupUI.PopFromCenter();
			dateTime3 = (DateTime)0;
		}
		UpdateParticipantsNumber();
		object obj46 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj47 = (nint)0 + (nint)656;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj47);
		object obj48 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj49 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v38+E4]");
		bool flag21 = (nint)0 == 0;
		object obj50 = !flag21;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float seconds = ((totalSeconds != 9.218868437227405E+18) ? ((float)totalSeconds) : 207f);
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(seconds, action);
	}

	private void UpdateParticipantsNumber()
	{
		//IL_0030: Expected O, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_005a: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_012c: Expected O, but got I4
		//IL_00dc: Expected O, but got I4
		//IL_0083: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected I4, but got Unknown
		//IL_0206: Expected F4, but got I4
		//IL_0206: Expected F4, but got I4
		int tournamentSize = TournamentSize;
		if (tournamentSize == 0)
		{
			return;
		}
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC5]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_00b8;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_00b8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_015b;
		IL_00b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_015b;
		IL_015b:
		Room currentRoom = sessionModel.CurrentRoom;
		int tournamentParticipantsCount = SFSKammelnaRoomExtensions.GetTournamentParticipantsCount(currentRoom);
		int num = tournamentParticipantsCount / tournamentSize;
		object obj9 = num * tournamentSize;
		int num2 = tournamentParticipantsCount - obj9;
		int num3 = ((num2 != 0) ? num2 : tournamentSize);
		progressBar.Initialize(tournamentSize, num3);
		progressCircle.Initialize(tournamentSize, num3);
	}

	private void HidePopup()
	{
		HideBlocker();
		popup.ShrinkToParent();
	}

	private static void ShowGroup(CanvasGroup canvasGroup)
	{
		int num = ShortcutExtensions.DOKill(canvasGroup, complete: true);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(canvasGroup, 1f, 0.3f);
		canvasGroup.blocksRaycasts = true;
	}

	private static void HideGroup(CanvasGroup canvasGroup)
	{
		int num = ShortcutExtensions.DOKill(canvasGroup, complete: true);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(canvasGroup, 0f, 0.3f);
		canvasGroup.blocksRaycasts = false;
	}

	private void ShowBlocker()
	{
		//IL_002b: Expected O, but got I
		popup.ShowBlurOnly();
		PopupUI popupUI = popup;
		object obj = (nint)0 + (nint)3816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Component component = default(Component);
		int num = ShortcutExtensions.DOKill(component, complete: true);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade((Graphic)component, 0.3f, 0.3f);
		GameObject gameObject = component.gameObject;
		gameObject.SetActive(value: true);
	}

	private void HideBlocker()
	{
		//IL_002b: Expected O, but got I
		//IL_0037: Expected O, but got I
		popup.HideBlurOnly();
		PopupUI popupUI = popup;
		object obj = (nint)0 + (nint)3816;
		object obj2 = (nint)0 + (nint)2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Component component = default(Component);
		int num = ShortcutExtensions.DOKill(component, complete: true);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade((Graphic)component, 0f, 0.3f);
		TweenCallback tweenCallback = TweenHelpers.Disable(component);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}
}
