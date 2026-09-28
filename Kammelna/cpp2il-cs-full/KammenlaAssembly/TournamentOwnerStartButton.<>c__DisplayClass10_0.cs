using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using Spine;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentOwnerStartButton : MonoBehaviour
{
	private sealed class <>c__DisplayClass10_0
	{
		public QueuePlayer player;

		internal bool <ForceStart>b__2(User p)
		{
			//IL_0099: Expected I4, but got O
			//IL_0077: Expected O, but got I4
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(p);
			QueuePlayer queuePlayer = player;
			if (player != null)
			{
				PlayerInfo <info>k__BackingField = queuePlayer.<info>k__BackingField;
				if (queuePlayer.<info>k__BackingField != null)
				{
					object obj = intDbId - <info>k__BackingField.<DBID>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private Button button;

	private GameObject buttonContainer;

	private TournamentData _data;

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

	private Room TournamentRoom
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ECD]");
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

	private void Start()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0044: Expected O, but got I
		//IL_005c: Expected I, but got O
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00f7: Expected O, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I
		//IL_00c4: Expected I, but got O
		//IL_00de: Expected O, but got I
		buttonContainer.SetActive(value: false);
		Button button = this.button;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v7+B8]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)1152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v9+20]");
		((OneShotEvent)0).CallWhenReady(action);
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
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_014d: Expected O, but got I
		//IL_01b9: Expected O, but got I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01e3: Expected O, but got I
		//IL_02d7: Expected O, but got I
		//IL_0301: Expected O, but got I4
		//IL_020c: Expected O, but got I
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0270: Expected O, but got I
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_02a9: Expected I, but got O
		//IL_034a: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ECE]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45BA]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45BA]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v15+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		goto IL_015a;
		IL_0250:
		object obj10 = typeof(SqlSingle[]) + 2376;
		object obj11 = (nint)0 + (nint)1160;
		object varName = "startPosition" + 104;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj11);
		GameObject go;
		VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
		return;
		IL_0358:
		throw new NullReferenceException();
		IL_0241:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0250;
		IL_0082:
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v20+B8]");
		object obj13 = 0;
		obj9 = obj13;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		if (obj14 != null)
		{
			goto IL_015a;
		}
		goto IL_0358;
		IL_015a:
		object obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ X8_v4+188] (should have been resolved before IL gen)");
		object obj16 = this + 48;
		object obj17 = default(object);
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj16 == null)
		{
			return;
		}
		go = base.gameObject;
		object obj18 = 152985600;
		object obj19 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ECD]");
		object obj20 = (nint)0 & (nint)1;
		if (obj20 != null)
		{
			object obj21 = (nint)0 + (nint)2200;
			object obj22 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj23 = obj21;
			if (!flag4)
			{
				goto IL_0241;
			}
		}
		else
		{
			_ = 1;
			object obj21 = (nint)0 + (nint)2200;
			object obj22 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj24 = !flag5;
			object obj23 = obj21;
			if (obj24 != null)
			{
				goto IL_0241;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag6 = (object)sessionModel == null;
		object obj25 = !flag6;
		if (obj25 != null)
		{
			goto IL_0250;
		}
		goto IL_0358;
	}

	private void OnStatusChanged()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_02d1: Expected O, but got I
		//IL_02fb: Expected O, but got I4
		//IL_0304: Expected O, but got I4
		//IL_0054: Expected O, but got I
		//IL_0087: Expected O, but got I
		//IL_00b1: Expected O, but got I4
		//IL_0323: Expected O, but got I4
		//IL_0364: Expected O, but got I
		//IL_0253: Expected O, but got I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0210: Expected O, but got I4
		TournamentData data = _data;
		object obj = typeof(Queue<string>) + 848;
		PlayerInfo <Creator>k__BackingField = data.<Creator>k__BackingField;
		object obj3;
		object obj4;
		int? num2;
		int? num3;
		object obj7;
		object obj8 = default(object);
		if (data.<Creator>k__BackingField != null)
		{
			object obj2 = (nint)0 + (nint)3136;
			int <DBID>k__BackingField = <Creator>k__BackingField.<DBID>k__BackingField;
			obj3 = obj2;
			int? num = <Creator>k__BackingField.<DBID>k__BackingField;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v29+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			num2 = num;
			obj7 = obj4;
			num3 = num;
			obj8 = obj2;
			if (obj6 == null)
			{
				goto IL_00df;
			}
		}
		else
		{
			obj7 = (nint)0 + (nint)2200;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v29+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			num3 = (int?)(object)0;
			if (obj9 == null)
			{
				obj4 = obj7;
				num2 = (int?)(object)0;
				obj3 = obj8;
				IntPtr intPtr = default(IntPtr);
				int <DBID>k__BackingField = (int)(nint)intPtr;
				goto IL_00df;
			}
		}
		goto IL_0106;
		IL_027a:
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom);
		bool flag3 = tournamentStatus == TournamentStatus.Scheduled;
		bool flag4;
		bool active = flag3 && flag4;
		buttonContainer.SetActive(active);
		return;
		IL_01ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_027a;
		IL_0106:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj11 = (object?)num3 >> 32;
		SessionModel sessionModel2 = default(SessionModel);
		User localUser = sessionModel2.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		bool flag6 = intDbId != (nint)obj11;
		flag4 = false;
		if (!flag6)
		{
			object obj12 = (??)num3 & 1;
			bool flag7 = obj12 == null;
			flag4 = false;
			if (!flag7)
			{
				TournamentData data2 = _data;
				flag4 = data2.<IsInstant>k__BackingField;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ECD]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				goto IL_01ec;
			}
		}
		else
		{
			_ = 1;
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v14+E4]");
			bool flag8 = (nint)0 == 0;
			object obj15 = !flag8;
			if (obj15 != null)
			{
				goto IL_01ec;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_027a;
		IL_00df:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj7 = obj4;
		num3 = num2;
		obj8 = obj3;
		goto IL_0106;
	}

	private void ForceStart()
	{
		//IL_0033: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0104: Expected O, but got I
		//IL_012e: Expected O, but got I4
		//IL_00df: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_01a6: Expected O, but got I
		//IL_01b4: Expected I, but got O
		//IL_01c5: Expected O, but got I
		//IL_01f1: Expected O, but got I
		//IL_01ff: Expected I, but got O
		//IL_0221: Expected O, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_027f: Expected O, but got I
		//IL_028d: Expected I, but got O
		TournamentData data = _data;
		if (data.<Type>k__BackingField == TournamentType.Private)
		{
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ECD]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v21+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				if (!flag)
				{
					goto IL_00bb;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v21+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_00bb;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			goto IL_015d;
		}
		goto IL_02a0;
		IL_00bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_015d;
		IL_02a0:
		ForceStartHelper();
		return;
		IL_015d:
		Room currentRoom = sessionModel.CurrentRoom;
		List<QueuePlayer> tournamentQueue = SFSKammelnaRoomExtensions.GetTournamentQueue(currentRoom);
		object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)1112;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)this, (IntPtr)obj10);
		object obj11 = (nint)0 + (nint)3704;
		IEnumerable<object> source = Enumerable.Where(tournamentQueue, func);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)1120;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor((object)this, (IntPtr)obj12);
		IEnumerable<object> source2 = Enumerable.Where(source, func2);
		object obj13 = (nint)0 + (nint)2576;
		List<object> list = Enumerable.ToList(source2);
		if (list._size >= 1)
		{
			object obj14 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)1144;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj15);
			TournamentPopupUtil.ShowForceStartWarning((List<QueuePlayer>)(object)list, action);
			return;
		}
		goto IL_02a0;
	}

	private void ForceStartHelper()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0098: Expected O, but got I
		//IL_00b8: Expected I, but got O
		//IL_0066: Expected O, but got I
		//IL_0076: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)1128;
		button.interactable = false;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		Action<bool> action = default(Action<bool>);
		while (true)
		{
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v6+B8]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor((object)this, (IntPtr)obj2);
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v8+1E8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v8+1F0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v96 @ X3_v3 (should have been resolved before IL gen)");
		}
	}

	private bool <ForceStart>b__10_0(QueuePlayer p)
	{
		//IL_00a4: Expected I4, but got O
		if (p != null)
		{
			TournamentData data = _data;
			if (_data != null)
			{
				if (p.<order>k__BackingField < data.<MaxAllowedSize>k__BackingField)
				{
					return true;
				}
				int num = ~p.<team>k__BackingField;
				return (byte)(num >> 31) != 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool <ForceStart>b__10_1(QueuePlayer player)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02e2: Expected I4, but got O
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Expected O, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_0113: Expected O, but got I
		//IL_013d: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01e7: Expected O, but got I
		//IL_01f0: Expected I, but got O
		//IL_0200: Expected O, but got I
		//IL_035b: Expected I, but got O
		//IL_023b: Expected O, but got I
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		SessionModel sessionModel = default(SessionModel);
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = player;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = 152985600;
			object obj5 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ECD]");
			object obj6 = (nint)0 & (nint)1;
			if (obj6 != null)
			{
				object obj7 = (nint)0 + (nint)2200;
				object obj8 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v20+E4]");
				bool flag = (nint)0 == 0;
				object obj9 = obj7;
				if (!flag)
				{
					goto IL_00ca;
				}
			}
			else
			{
				_ = 1;
				object obj7 = (nint)0 + (nint)2200;
				object obj8 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v20+E4]");
				bool flag2 = (nint)0 == 0;
				object obj10 = !flag2;
				object obj9 = obj7;
				if (obj10 != null)
				{
					goto IL_00ca;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_0189;
			}
		}
		goto IL_02d4;
		IL_0189:
		Room currentRoom = sessionModel.CurrentRoom;
		if (currentRoom == null)
		{
			goto IL_02d4;
		}
		object obj11 = typeof(RegisteredWaitHandle) + 1376;
		object obj12 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 56;
		object obj13 = (nint)0 + (nint)136;
		nint num = (nint)currentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_027c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X10_v5-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj15 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_027c;
		}
		object obj16 = obj15 + 28;
		object obj17 = num + obj16;
		object obj18 = obj17 + 312;
		goto IL_0336;
		IL_027c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj19 = default(object);
		obj18 = obj19;
		goto IL_0336;
		IL_02d4:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0336:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ X8_v9] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj13);
		IEnumerable<object> source = default(IEnumerable<object>);
		bool flag3 = Enumerable.Any(source, func);
		return (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
		IL_00ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj20 = !flag4;
		if (obj20 != null)
		{
			goto IL_0189;
		}
		goto IL_02d4;
	}

	private void <ForceStartHelper>b__11_0(bool success)
	{
		//IL_0037: Expected O, but got I4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_01ab: Expected O, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0148: Expected O, but got I4
		bool interactable = (byte)((success ? 1u : 0u) ^ 1u) != 0;
		button.interactable = interactable;
		bool flag = !success;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		TournamentData data = _data;
		object obj4;
		object obj6;
		if (data.<Type>k__BackingField != TournamentType.Public)
		{
			if (data.<Type>k__BackingField != TournamentType.Private)
			{
				return;
			}
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj3 = obj2;
			obj4 = "startPosition" + 4080;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			obj6 = obj4;
			if (obj5 == null)
			{
				goto IL_00b4;
			}
		}
		else
		{
			object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj3 = obj7;
			obj6 = "startPosition" + 4072;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				obj4 = obj6;
				goto IL_00b4;
			}
		}
		goto IL_00cb;
		IL_00cb:
		object title = "Unsupported map type" + 3592;
		object buttonText = "Network Authentication Required" + 3128;
		PopupWindow.ShowError((string)title, (string)obj6, (string)buttonText);
		return;
		IL_00b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj4;
		goto IL_00cb;
	}
}
