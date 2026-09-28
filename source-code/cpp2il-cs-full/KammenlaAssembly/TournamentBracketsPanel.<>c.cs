using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Sfs2X.Entities;
using Spine;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class TournamentBracketsPanel : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<PlayerInfo, bool> <>9__16_0;

		public static Func<MatchData, bool> <>9__17_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <SetMyLightPath>b__16_0(PlayerInfo p)
		{
			//IL_003d: Expected I4, but got O
			if (p != null)
			{
				return p.IsMe;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <SetWinnerLightPath>b__17_0(MatchData m)
		{
			//IL_003d: Expected I4, but got O
			if (m != null)
			{
				return m.HasPlayers();
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private GameObject emptyState;

	private GameObject shuffleWarning;

	private BracketGenerator generator;

	private BracketNavigation navigation;

	private bool _bracketsDoneDrawing;

	private static TournamentViewConnector Connector
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C06]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B2]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B2]");
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
		object obj11 = (nint)0 + (nint)512;
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

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0076: Expected O, but got I
		//IL_0029: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+20]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v7+18]");
		if ((nint)0 == 1)
		{
			UpdateTree();
		}
	}

	private void Init()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02b0: Expected O, but got I
		//IL_02e4: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0090: Expected I, but got O
		//IL_00cf: Expected O, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_0108: Expected I, but got O
		//IL_0147: Expected O, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0180: Expected I, but got O
		//IL_01bf: Expected O, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01df: Expected O, but got I
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_01ff: Expected O, but got I
		//IL_0229: Expected I, but got O
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_026a: Expected I, but got O
		//IL_0295: Expected I, but got O
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		GameObject go = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)544;
		object varName = "java.io.FileOutputStream" + 3672;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj7 = (nint)0 + (nint)528;
		object varName2 = "setMimeType" + 1768;
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom2 = sessionModel2.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj7);
		VariableBinderExtensions.Bind(go2, currentRoom2, (string)varName2, action2);
		GameObject go3 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = (nint)0 + (nint)536;
		object varName3 = "startPosition" + 104;
		SessionModel sessionModel3 = default(SessionModel);
		Room currentRoom3 = sessionModel3.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj8);
		VariableBinderExtensions.Bind(go3, currentRoom3, (string)varName3, action3);
		GameObject go4 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj9 = (nint)0 + (nint)520;
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj11 = (nint)0 + (nint)552;
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj13 = (nint)0 + (nint)560;
		SessionModel sessionModel4 = default(SessionModel);
		Room currentRoom4 = sessionModel4.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj9);
		object varName4 = "java.io.FileOutputStream" + 3672;
		VariableBinderExtensions.Bind(go4, currentRoom4, (string)varName4, action4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj11);
		SFS.OnRoomCreated += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj13);
		SFS.OnRoomGroupSubscribe += action6;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_0084: Expected I, but got O
		//IL_005d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)552;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnRoomCreated -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		SFS.OnRoomGroupSubscribe -= action2;
	}

	private void UpdateTree(Room _)
	{
		UpdateTree();
	}

	private void UpdateTree(string _)
	{
		UpdateTree();
	}

	private void UpdateTree()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_008e: Expected O, but got I
		emptyState.SetActive(value: false);
		if (!_bracketsDoneDrawing)
		{
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v5+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ X8_v7+198] (should have been resolved before IL gen)");
			List<MatchData> matches = default(List<MatchData>);
			AddBrackets(matches);
			navigation.InitNavigation();
		}
	}

	private void AddBrackets(List<MatchData> matches)
	{
		if (matches._size != 0)
		{
			BracketGenerator bracketGenerator = generator;
			int tournamentSize = matches._size + 1;
			bracketGenerator.tournamentSize = tournamentSize;
			bracketGenerator.Clear();
			bracketGenerator.PrepareForFlattening();
			bracketGenerator.CreateBracketsTree();
			bracketGenerator.FlattenUnits();
			_bracketsDoneDrawing = true;
			List<BracketUnit> bracketUnits = generator.GetBracketUnits();
			if (matches._size >= 1)
			{
				int num = 0;
				do
				{
					object obj = ((List<object>)(object)bracketUnits).get_Item(num);
					object match = ((List<object>)(object)matches).get_Item(num);
					((BracketUnit)obj).Initialize((MatchData)match);
					num++;
				}
				while (num < matches._size);
			}
		}
		else
		{
			emptyState.SetActive(value: true);
		}
	}

	private void SetShuffleWarning()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01af: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C0A]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_0140;
		IL_0140:
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom);
		if (TournamentStatusExtensions.IsScheduled(tournamentStatus))
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			Room currentRoom2 = sessionModel2.CurrentRoom;
			bool active = SFSKammelnaRoomExtensions.IsTournamentTeamsShuffled(currentRoom2);
			shuffleWarning.SetActive(active);
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
	}

	private void SetMyLightPath()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_019b: Expected O, but got I4
		//IL_01d3: Expected O, but got I4
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_07cb: Expected O, but got I
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02c2: Expected O, but got I4
		//IL_0300: Expected O, but got I4
		//IL_0329: Expected O, but got I
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_082c: Expected O, but got I4
		//IL_04d8: Expected O, but got I
		//IL_0513: Expected O, but got I
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_055d: Expected O, but got I4
		//IL_0864: Expected O, but got I4
		//IL_086c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Expected O, but got Unknown
		//IL_0658: Expected O, but got I
		//IL_0668: Expected O, but got I
		//IL_068a: Expected O, but got I4
		//IL_069a: Expected O, but got I
		//IL_05ba: Expected O, but got I
		//IL_05ca: Expected O, but got I
		//IL_05f1: Expected O, but got I
		//IL_06ca: Expected O, but got I4
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected O, but got Unknown
		//IL_08f1: Expected O, but got I
		//IL_0902: Expected I, but got O
		//IL_0920: Expected O, but got I
		//IL_074d: Expected O, but got I4
		//IL_075b: Expected I4, but got O
		//IL_06fa: Expected O, but got I
		//IL_0799: Expected O, but got I4
		//IL_039b: Expected O, but got I4
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_0430: Expected O, but got I4
		//IL_07ee: Expected I4, but got O
		//IL_044b: Unsupported input type for neg.
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C0B]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v63+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v63+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_0140;
		IL_07a7:
		throw new NullReferenceException();
		IL_0140:
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom);
		if (tournamentInfo == null)
		{
			return;
		}
		bool flag3 = !tournamentInfo.<IsCluster>k__BackingField;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom2 = sessionModel2.CurrentRoom;
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom2);
		if (!TournamentStatusExtensions.IsRunning(tournamentStatus))
		{
			return;
		}
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v9+B8]");
		object obj13 = 0;
		object obj14 = obj13;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v208 @ X8_v11+198] (should have been resolved before IL gen)");
		List<BracketLines> bracketLines = generator.GetBracketLines();
		object obj16 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v19+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence sequence = DOTween.Sequence();
		List<object> list = default(List<object>);
		object obj19 = list._size - 1;
		if ((nint)obj19 < 1)
		{
			return;
		}
		object obj20 = (nint)0 + (nint)3944;
		object obj21 = typeof(SkeletonBinary.SkeletonInput) + 3432;
		int num = 2;
		int num2 = 0;
		DG.Tweening.Sequence sequence2 = sequence;
		Func<object, bool> func2 = default(Func<object, bool>);
		while (true)
		{
			object obj22 = list.get_Item(num2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v25 (System.Object)+40]");
			PlayerInfo[] teamPlayers;
			Func<object, bool> predicate;
			int num6;
			if ((nint)0 == 2)
			{
				object obj23 = list.get_Item(num2);
				object obj24 = list.get_Item(num2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v30 (System.Object)+20]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v30 (System.Object)+24]");
				object obj25 = num3 - 0;
				bool flag6 = (nint)obj25 < 0;
				bool flag7 = obj25 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v30 (System.Object)+20]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v30 (System.Object)+24]");
				object obj26 = num4 ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v30 (System.Object)+20]");
				object obj27 = 0 ^ obj25;
				object obj28 = obj26 & obj27;
				bool flag8 = (nint)obj28 < 0;
				bool flag9 = flag6 == flag8;
				object obj29 = !flag9;
				object obj30 = ~obj29;
				int num5 = ((obj30 == null) ? num : 0);
				bool flag10 = flag6 == flag8;
				object obj31 = !flag10;
				object obj32 = obj31 | flag7;
				object obj33 = ~obj32;
				int team = ((obj33 != null) ? 1 : num5);
				teamPlayers = ((MatchData)obj23).GetTeamPlayers(team);
				object obj34 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v43+E4]");
				object obj35;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v43+B8]");
					obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v35+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v35+8]");
					bool flag11 = (nint)0 == 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v35+8]");
					Func<object, bool> func = (Func<object, bool>)0;
					if (!flag11)
					{
						goto IL_05ff;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj34 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v43+B8]");
					obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v35+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v35+8]");
					bool flag12 = (nint)0 == 0;
					object obj36 = !flag12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v35+8]");
					Func<object, bool> func = (Func<object, bool>)0;
					if (obj36 != null)
					{
						goto IL_05ff;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v43+E4]");
				bool flag13 = (nint)0 == 0;
				object obj37 = !flag13;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj38 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v41+B8]");
					obj35 = 0;
				}
				object obj39 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj40 = (nint)0 + (nint)3640;
				func2..ctor(obj35, (IntPtr)obj40);
				object obj41 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v40+B8]");
				object obj42 = (nint)0 + (nint)8;
				obj42 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag14 = Enumerable.Any(teamPlayers, func2);
				bool flag15 = !flag14;
				num6 = 2;
				DG.Tweening.Sequence sequence3 = null;
				num = 2;
				if (!flag15)
				{
					goto IL_0740;
				}
			}
			goto IL_080b;
			IL_05ff:
			if (Enumerable.Any(teamPlayers, predicate))
			{
				num6 = num;
				goto IL_0740;
			}
			goto IL_080b;
			IL_0740:
			object obj43 = num2 + num2;
			int index = obj43 >> 1;
			object obj44 = ((List<object>)(object)bracketLines).get_Item(index);
			bool topLine = IntegerExtensions.IsEven(num2);
			bool flag16 = obj44 == null;
			object obj45 = !flag16;
			if (obj45 != null)
			{
				DG.Tweening.Sequence sequence4 = ((BracketLines)obj44).AnimateSlider(isMe: true, topLine, sequence2);
				bool flag17 = IntegerExtensions.IsOdd(num2);
				object obj46 = num2 + list._size;
				object obj47 = obj46 - flag17;
				object obj48 = obj47 + 1;
				object obj49 = obj48 + obj48;
				object obj50 = obj49 >> 1;
				object obj51 = obj50 & 1;
				bool flag18 = (nint)obj50 < 0;
				object obj52 = obj50 ^ obj50;
				object obj53 = obj50 & obj52;
				bool flag19 = (nint)obj53 < 0;
				bool flag20 = flag18 == flag19;
				object obj54 = !flag20;
				object obj33 = ~obj54;
				if (obj33 == null)
				{
					obj51 = 0 - obj51;
				}
				object obj55 = ~obj51;
				num2 = (int)(obj50 + obj55);
				DG.Tweening.Sequence sequence3 = sequence2;
				num = num6;
				sequence2 = sequence4;
				goto IL_080b;
			}
			break;
			IL_080b:
			num2++;
			object obj56 = list._size - 1;
			if (num2 >= (nint)obj56)
			{
				return;
			}
		}
		goto IL_07a7;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag21 = (object)sessionModel == null;
		object obj57 = !flag21;
		if (obj57 != null)
		{
			goto IL_0140;
		}
		goto IL_07a7;
	}

	private void SetWinnerLightPath()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_019b: Expected O, but got I4
		//IL_01d3: Expected O, but got I4
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0765: Expected O, but got I
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_02bb: Expected O, but got I4
		//IL_0782: Expected O, but got I
		//IL_0792: Expected O, but got I
		//IL_07b4: Expected O, but got I4
		//IL_0343: Expected O, but got I
		//IL_0369: Expected O, but got I4
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected I4, but got Unknown
		//IL_03e5: Expected O, but got I4
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_0302: Expected O, but got I4
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected O, but got Unknown
		//IL_07ec: Expected O, but got I
		//IL_07fd: Expected I, but got O
		//IL_081b: Expected O, but got I
		//IL_0857: Expected O, but got I
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected O, but got Unknown
		//IL_08a2: Expected O, but got I4
		//IL_0332: Expected O, but got I
		//IL_045b: Expected O, but got I4
		//IL_06b5: Expected O, but got I
		//IL_04a2: Expected O, but got I
		//IL_06fa: Expected O, but got I4
		//IL_0729: Expected O, but got I4
		//IL_04db: Expected O, but got I4
		//IL_0562: Expected O, but got I4
		//IL_0570: Expected I4, but got O
		//IL_05d1: Expected O, but got I4
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got Unknown
		//IL_0666: Expected O, but got I4
		//IL_08c6: Expected I4, but got O
		//IL_08cf: Expected O, but got I4
		//IL_0681: Unsupported input type for neg.
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C0C]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v64+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v64+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_0140;
		IL_0746:
		throw new NullReferenceException();
		IL_0140:
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom);
		if (tournamentInfo == null)
		{
			return;
		}
		bool flag3 = !tournamentInfo.<IsCluster>k__BackingField;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom2 = sessionModel2.CurrentRoom;
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom2);
		if (tournamentStatus != TournamentStatus.Finished)
		{
			return;
		}
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v9+B8]");
		object obj13 = 0;
		object obj14 = obj13;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v222 @ X8_v11+198] (should have been resolved before IL gen)");
		List<BracketLines> bracketLines = generator.GetBracketLines();
		object obj16 = typeof(SkeletonBinary.SkeletonInput) + 3432;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v19+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj16;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v19+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v39+10]");
		Func<object, bool> func = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v39+10]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v19+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj22 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v45+B8]");
				obj19 = 0;
			}
			object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj24 = (nint)0 + (nint)3648;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj19, (IntPtr)obj24);
			object obj25 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v44+B8]");
			object obj26 = (nint)0 + (nint)16;
			obj26 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func = func2;
		}
		object obj27 = (nint)0 + (nint)1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC848C");
		MatchData matchData = default(MatchData);
		object obj28 = matchData.<team1Score>k__BackingField - matchData.<team2Score>k__BackingField;
		bool flag8 = (nint)obj28 < 0;
		bool flag9 = obj28 == null;
		int num = matchData.<team1Score>k__BackingField ^ matchData.<team2Score>k__BackingField;
		int num2 = matchData.<team1Score>k__BackingField ^ obj28;
		int num3 = num & num2;
		bool flag10 = num3 < 0;
		bool flag11 = flag8 == flag10;
		object obj29 = !flag11;
		object obj30 = obj29 | flag9;
		object obj31 = ~obj30;
		int team = ((obj31 != null) ? 1 : (1 + 1));
		PlayerInfo[] teamPlayers = matchData.GetTeamPlayers(team);
		object obj32 = (nint)0 + (nint)2496;
		List<object> list = Enumerable.ToList((IEnumerable<object>)teamPlayers);
		object obj33 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v25+E4]");
		bool flag12 = (nint)0 == 0;
		object obj35 = !flag12;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence sequence = DOTween.Sequence();
		List<object> list2 = default(List<object>);
		object obj36 = list2._size - 1;
		if (bracketLines != null)
		{
			if ((nint)obj36 < 1)
			{
				return;
			}
			object obj37 = (nint)0 + (nint)1600;
			DG.Tweening.Sequence sequence2 = sequence;
			int num4 = 0;
			IEnumerable<object> source = default(IEnumerable<object>);
			bool flag19;
			do
			{
				object obj38 = list2.get_Item(num4);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC67D0");
				bool flag13 = Enumerable.Any(source);
				bool flag14 = !flag13;
				DG.Tweening.Sequence sequence3 = sequence2;
				if (!flag14)
				{
					object obj39 = num4 + num4;
					int index = obj39 >> 1;
					object obj40 = ((List<object>)(object)bracketLines).get_Item(index);
					bool topLine = IntegerExtensions.IsEven(num4);
					DG.Tweening.Sequence sequence4 = ((BracketLines)obj40).AnimateSlider(isMe: false, topLine, sequence2);
					bool flag15 = IntegerExtensions.IsOdd(num4);
					object obj41 = num4 + list2._size;
					object obj42 = obj41 - flag15;
					object obj43 = obj42 + 1;
					object obj44 = obj43 + obj43;
					object obj45 = obj44 >> 1;
					object obj46 = obj45 & 1;
					bool flag16 = (nint)obj45 < 0;
					object obj47 = obj45 ^ obj45;
					object obj48 = obj45 & obj47;
					bool flag17 = (nint)obj48 < 0;
					bool flag18 = flag16 == flag17;
					object obj49 = !flag18;
					obj31 = ~obj49;
					if (obj31 == null)
					{
						obj46 = 0 - obj46;
					}
					object obj50 = ~obj46;
					num4 = (int)(obj45 + obj50);
					object obj51 = 0;
					sequence3 = sequence4;
				}
				num4++;
				object obj52 = list2._size - 1;
				flag19 = num4 >= (nint)obj52;
				sequence2 = sequence3;
			}
			while (!flag19);
			return;
		}
		if ((nint)obj36 < 1)
		{
			return;
		}
		object obj53 = (nint)0 + (nint)1600;
		int num5 = 0;
		IEnumerable<object> source2 = default(IEnumerable<object>);
		while (true)
		{
			object obj54 = list2.get_Item(num5);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC67D0");
			bool flag20 = Enumerable.Any(source2);
			bool flag21 = !flag20;
			object obj55 = !flag21;
			if (obj55 != null)
			{
				break;
			}
			num5++;
			object obj56 = list2._size - 1;
			if (num5 >= (nint)obj56)
			{
				return;
			}
		}
		goto IL_0746;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag22 = (object)sessionModel == null;
		object obj57 = !flag22;
		if (obj57 != null)
		{
			goto IL_0140;
		}
		goto IL_0746;
	}

	private DG.Tweening.Sequence AnimateBracketLine(BracketLines bracketLines, bool isMe, bool topLine, DG.Tweening.Sequence sequence)
	{
		if ((object)bracketLines != null)
		{
			return bracketLines.AnimateSlider(isMe, topLine, sequence);
		}
		return (DG.Tweening.Sequence)(object)new NullReferenceException();
	}

	private int GetBracketLineOfNextStage(int matchesCount, int index)
	{
		//IL_001a: Expected O, but got I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_00af: Expected O, but got I4
		//IL_00ea: Expected I4, but got O
		//IL_00ca: Unsupported input type for neg.
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		bool flag = IntegerExtensions.IsOdd(index);
		object obj = matchesCount + index;
		object obj2 = obj - flag;
		object obj3 = obj2 + 1;
		object obj4 = obj3 + obj3;
		object obj5 = obj4 >> 1;
		object obj6 = obj5 & 1;
		bool flag2 = (nint)obj5 < 0;
		object obj7 = obj5 ^ obj5;
		object obj8 = obj5 & obj7;
		bool flag3 = (nint)obj8 < 0;
		bool flag4 = flag2 == flag3;
		object obj9 = !flag4;
		object obj10 = ~obj9;
		if (obj10 == null)
		{
			obj6 = 0 - obj6;
		}
		object obj11 = ~obj6;
		return (int)(obj5 + obj11);
	}

	private List<MatchData> GetTournamentGames()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0051: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		if (obj3 != null)
		{
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v43 @ X8_v5+198] (should have been resolved before IL gen)");
		}
		return (List<MatchData>)(object)new NullReferenceException();
	}

	private void MarkBracketsAsDone()
	{
		_bracketsDoneDrawing = true;
	}
}
