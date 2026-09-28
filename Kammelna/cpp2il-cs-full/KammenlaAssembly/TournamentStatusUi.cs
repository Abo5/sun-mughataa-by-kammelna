using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Sfs2X.Entities;
using Spine;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentStatusUi : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<GameObject, bool> <>9__29_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <SetupUi>b__29_0(GameObject go)
		{
			//IL_003d: Expected I4, but got O
			if ((object)go != null)
			{
				return go.activeSelf;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private TournamentsEventsChannel eventsChannel;

	private TextMeshProUGUI seatText;

	private Button participateBtn;

	private GameObject participateBtnContainer;

	private Button leaveBtn;

	private GameObject leaveBtnContainer;

	private GameObject textView;

	private TextMeshProUGUI statusText;

	private GameObject rankLimitView;

	private RankUI rankLimitRank;

	private GameObject titleLimitView;

	private TitleSetter titleLimitTitle;

	private GameObject roundTimerView;

	private DateTimeText roundTimerText;

	private GameObject[] allContainers;

	private TournamentData _data;

	private bool checkedParticipation;

	private DateTime RoundTimer
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected O, but got Unknown
			//IL_015b: Expected O, but got I
			//IL_0175: Expected O, but got I4
			//IL_0097: Expected O, but got I
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0066: Expected O, but got I
			//IL_019d: Expected O, but got I
			//IL_01c7: Expected O, but got I4
			//IL_0210: Expected O, but got I4
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected O, but got Unknown
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_023d: Expected O, but got Unknown
			//IL_02a9: Expected O, but got I
			//IL_02b6: Expected O, but got I
			//IL_012b: Expected O, but got I4
			//IL_027a: Expected O, but got I
			//IL_0287: Expected O, but got I
			object obj = 152985600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EDA]");
			object obj2 = (nint)0 & (nint)1;
			object obj3;
			object obj5;
			if (obj2 != null)
			{
				obj3 = typeof(Queue<string>) + 848;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EDB]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EDB]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			object obj11 = obj8;
			if (obj10 != null)
			{
				goto IL_00cc;
			}
			goto IL_01dd;
			IL_00cc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			goto IL_00db;
			IL_00db:
			SessionModel sessionModel = default(SessionModel);
			Room currentRoom = sessionModel.CurrentRoom;
			DateTime? tournamentRoundTimer = SFSKammelnaRoomExtensions.GetTournamentRoundTimer(currentRoom);
			object obj12 = (??)tournamentRoundTimer & 1;
			if (obj12 == null)
			{
				object obj13 = typeof(DataRelation) + 712;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v2+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v2+B8]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v5+10]");
					return (DateTime)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj16 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v4+B8]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v4+10]");
				return (DateTime)0;
			}
			return (DateTime)0;
			IL_01dd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag4 = (object)sessionModel == null;
			object obj18 = !flag4;
			if (obj18 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00db;
			IL_008b:
			obj8 = (nint)0 + (nint)2200;
			obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			obj11 = obj8;
			if (!flag5)
			{
				goto IL_00cc;
			}
			goto IL_01dd;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EDB]");
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

	private bool available
	{
		get
		{
			//IL_0097: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			TournamentData data = _data;
			if (_data != null)
			{
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				return data.<AvailabilityTime>k__BackingField <= now;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_008c: Expected O, but got I8
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00ed: Expected O, but got I4
		//IL_0103: Expected O, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0172: Expected O, but got I8
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01d3: Expected O, but got I4
		//IL_01e9: Expected O, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0260: Expected O, but got I4
		//IL_0276: Expected O, but got I
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 2568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		GameObject gameObject = participateBtn.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			object obj3 = default(object);
			object obj2 = obj3 + 32;
			obj2 = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X21_v6-8]");
			object obj4 = 0 & 0xFFFFFFFEL;
			if (obj4 != null)
			{
				object obj5 = obj3 + 40;
				obj5 = leaveBtnContainer;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X21_v8-10]");
				bool flag = (nint)0 < (nint)2;
				object obj6 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X21_v8-10]");
				object obj7 = -2;
				bool flag2 = obj7 == null;
				object obj8 = ~obj6;
				object obj9 = obj8 | flag2;
				if (obj9 == null)
				{
					object obj10 = obj3 + 48;
					obj10 = textView;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X21_v10-18]");
					object obj11 = 0 & 0xFFFFFFFCL;
					if (obj11 != null)
					{
						object obj12 = obj3 + 56;
						obj12 = rankLimitView;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X21_v12-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj13 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X21_v12-20]");
						object obj14 = -4;
						bool flag4 = obj14 == null;
						object obj15 = ~obj13;
						object obj16 = obj15 | flag4;
						if (obj16 == null)
						{
							object obj17 = obj3 + 64;
							obj17 = roundTimerView;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X21_v14-28]");
							bool flag5 = (nint)0 < (nint)5;
							object obj18 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X21_v14-28]");
							object obj19 = -5;
							bool flag6 = obj19 == null;
							object obj20 = ~obj18;
							object obj21 = obj20 | flag6;
							if (obj21 == null)
							{
								object obj22 = obj3 + 72;
								obj22 = titleLimitView;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj23 = this + 144;
								obj23 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								return;
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
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
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01db: Expected O, but got I
		//IL_01f3: Expected I, but got O
		//IL_0225: Expected O, but got I
		//IL_023d: Expected I, but got O
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0262: Expected O, but got I
		//IL_0291: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E9A]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45BC]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45BC]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v8+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		goto IL_015a;
		IL_015a:
		object obj10 = typeof(SqlSingle[]) + 2376;
		object obj11 = (nint)0 + (nint)1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v3+20]");
		((OneShotEvent)0).CallWhenReady(action);
		Button button = participateBtn;
		object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj13 = (nint)0 + (nint)1456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj13);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = leaveBtn;
		object obj14 = (nint)0 + (nint)1424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj14);
		object obj15 = typeof(SkeletonBinary.SkeletonInput) + 4032;
		object obj16 = (nint)0 + (nint)1440;
		button2.m_OnClick.AddListener(unityAction2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentsEventsChannel.TournamentSeatChanged tournamentSeatChanged = default(TournamentsEventsChannel.TournamentSeatChanged);
		tournamentSeatChanged..ctor(this, (IntPtr)obj16);
		eventsChannel.OnTournamentSeatChanged += tournamentSeatChanged;
		return;
		IL_0082:
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v14+B8]");
		object obj18 = 0;
		obj9 = obj18;
		bool flag3 = obj18 == null;
		object obj19 = !flag3;
		if (obj19 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_015a;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 4032;
		object obj2 = (nint)0 + (nint)1440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentsEventsChannel.TournamentSeatChanged tournamentSeatChanged = default(TournamentsEventsChannel.TournamentSeatChanged);
		tournamentSeatChanged..ctor(this, (IntPtr)obj2);
		eventsChannel.OnTournamentSeatChanged -= tournamentSeatChanged;
	}

	private void Init()
	{
		//IL_0437: Expected O, but got I4
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_0461: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_00b9: Expected O, but got I4
		//IL_006a: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_014e: Expected I, but got O
		//IL_0188: Expected O, but got I
		//IL_0239: Expected O, but got I4
		//IL_01f6: Expected O, but got I4
		//IL_026c: Expected O, but got I
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_02a5: Expected I, but got O
		//IL_02df: Expected O, but got I
		//IL_03ce: Expected O, but got I4
		//IL_0344: Expected O, but got I
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_037d: Expected I, but got O
		//IL_040f: Expected O, but got I4
		GameObject go = base.gameObject;
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EDB]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v56+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0046;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v56+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0046;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_00f5;
		IL_0260:
		object obj8 = (nint)0 + (nint)1448;
		object varName = "startPosition" + 104;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj8);
		GameObject go2;
		VariableBinderExtensions.Bind(go2, currentRoom, (string)varName, action);
		GameObject go3 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EDB]");
		object obj9 = (nint)0 & (nint)1;
		if (obj9 != null)
		{
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0329;
			}
		}
		else
		{
			_ = 1;
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v20+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 != null)
			{
				goto IL_0329;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		bool flag4 = (object)sessionModel2 == null;
		object obj12 = !flag4;
		if (obj12 != null)
		{
			goto IL_0338;
		}
		goto IL_041d;
		IL_01d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj13 = !flag5;
		if (obj13 != null)
		{
			goto IL_0260;
		}
		goto IL_041d;
		IL_041d:
		throw new NullReferenceException();
		IL_0046:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		bool flag6 = (object)sessionModel3 == null;
		object obj14 = !flag6;
		if (obj14 != null)
		{
			goto IL_00f5;
		}
		goto IL_041d;
		IL_00f5:
		object obj15 = typeof(SqlSingle[]) + 2376;
		object obj16 = (nint)0 + (nint)1464;
		object varName2 = "https://www.kammelna.com/Home/Terms" + 136;
		Room currentRoom2 = sessionModel3.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj16);
		VariableBinderExtensions.Bind(go, currentRoom2, (string)varName2, action2);
		go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EDB]");
		object obj17 = (nint)0 & (nint)1;
		if (obj17 != null)
		{
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v41+E4]");
			if ((nint)0 != 0)
			{
				goto IL_01d2;
			}
		}
		else
		{
			_ = 1;
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v41+E4]");
			bool flag7 = (nint)0 == 0;
			object obj19 = !flag7;
			if (obj19 != null)
			{
				goto IL_01d2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0260;
		IL_0329:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0338;
		IL_0338:
		object obj20 = (nint)0 + (nint)1472;
		object varName3 = "rightCtrl" + 640;
		Room currentRoom3 = sessionModel2.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj20);
		VariableBinderExtensions.Bind(go3, currentRoom3, (string)varName3, action3);
		SetupUi();
	}

	private void SetupUi()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_063f: Expected I, but got O
		//IL_003f: Expected O, but got I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0069: Expected O, but got I
		//IL_0111: Expected O, but got I
		//IL_013b: Expected O, but got I4
		//IL_00eb: Expected O, but got I4
		//IL_0092: Expected O, but got I
		//IL_01b7: Expected O, but got I4
		//IL_01d1: Expected O, but got I4
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_0336: Expected O, but got I4
		//IL_038c: Expected O, but got I4
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_03a9: Expected O, but got I4
		//IL_051e: Expected O, but got I
		//IL_052e: Expected O, but got I
		//IL_0550: Expected O, but got I4
		//IL_0561: Expected O, but got I
		//IL_048f: Expected O, but got I
		//IL_049f: Expected O, but got I
		//IL_04c7: Expected O, but got I
		//IL_02d5: Expected O, but got I4
		//IL_0591: Expected O, but got I4
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected O, but got Unknown
		//IL_0685: Expected O, but got I
		//IL_0696: Expected I, but got O
		//IL_06b4: Expected O, but got I
		//IL_05f3: Expected O, but got I4
		//IL_05c1: Expected O, but got I
		if (_data == null)
		{
			return;
		}
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)1960;
		object obj3 = (nint)0 + (nint)2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		object obj4 = obj3;
		ArraysExtensions.ForEach(allContainers, action);
		object obj5 = 152985600;
		object obj6 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EDB]");
		object obj7 = (nint)0 & (nint)1;
		if (obj7 != null)
		{
			object obj8 = (nint)0 + (nint)2200;
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v56+E4]");
			bool flag = (nint)0 == 0;
			object obj10 = obj8;
			if (!flag)
			{
				goto IL_00c7;
			}
		}
		else
		{
			_ = 1;
			object obj8 = (nint)0 + (nint)2200;
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v56+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			object obj10 = obj8;
			if (obj11 != null)
			{
				goto IL_00c7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_016a;
		IL_04ed:
		GameObject gameObject;
		bool active;
		gameObject.SetActive(active);
		return;
		IL_03ff:
		SetScheduledView();
		goto IL_040a;
		IL_0601:
		throw new NullReferenceException();
		IL_04d5:
		Func<object, bool> predicate;
		active = Enumerable.Any(allContainers, predicate);
		goto IL_04ed;
		IL_00c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj12 = !flag3;
		if (obj12 != null)
		{
			goto IL_016a;
		}
		goto IL_0601;
		IL_016a:
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom);
		if (tournamentStatus > TournamentStatus.Running)
		{
			object obj13 = tournamentStatus - 2;
			bool flag4 = (nint)obj13 < 3;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				CancelInvoke();
				SetFinishedView();
			}
			else if (tournamentStatus == TournamentStatus.FinalCountdown)
			{
				TournamentData data = _data;
				object obj15 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v33+E4]");
				if ((nint)0 != 0)
				{
					bool flag5 = SfsTournamentConnector.IsParticipating(data.<RoomId>k__BackingField);
					bool flag6 = !flag5;
					object obj17 = !flag6;
					if (obj17 != null)
					{
						goto IL_03e9;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					if (SfsTournamentConnector.IsParticipating(data.<RoomId>k__BackingField))
					{
						goto IL_03e9;
					}
				}
				goto IL_03ff;
			}
		}
		else if (tournamentStatus != TournamentStatus.Scheduled)
		{
			if (tournamentStatus == TournamentStatus.Running)
			{
				SetStartedView();
			}
		}
		else
		{
			TournamentData data2 = _data;
			object obj18 = typeof(DataRelation) + 712;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v36+E4]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			bool flag8 = data2.<AvailabilityTime>k__BackingField > now;
			bool flag9 = !flag8;
			obj4 = 0;
			if (flag9)
			{
				goto IL_03ff;
			}
			SetNotAvailableView();
			obj4 = 0;
		}
		goto IL_040a;
		IL_040a:
		Transform transform = textView.transform;
		Transform parent = transform.parent;
		object obj21 = typeof(SkeletonBinary.SkeletonInput) + 3912;
		gameObject = parent.gameObject;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v17+E4]");
		object obj23;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v17+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v12+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v12+8]");
			bool flag10 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v12+8]");
			Func<object, bool> func = (Func<object, bool>)0;
			if (!flag10)
			{
				goto IL_04d5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v17+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v12+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v12+8]");
			bool flag11 = (nint)0 == 0;
			object obj24 = !flag11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v12+8]");
			Func<object, bool> func = (Func<object, bool>)0;
			if (obj24 != null)
			{
				goto IL_04d5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v17+E4]");
		bool flag12 = (nint)0 == 0;
		object obj25 = !flag12;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj26 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v18+B8]");
			obj23 = 0;
		}
		object obj27 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj28 = (nint)0 + (nint)368;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj23, (IntPtr)obj28);
		object obj29 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v17+B8]");
		object obj30 = (nint)0 + (nint)8;
		obj30 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		active = Enumerable.Any(allContainers, func2);
		bool flag13 = (object)gameObject == null;
		object obj31 = !flag13;
		if (obj31 != null)
		{
			goto IL_04ed;
		}
		goto IL_0601;
		IL_03e9:
		CancelInvoke();
		SetStartingSoonView();
		goto IL_040a;
	}

	private void SetScheduledView()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_0080: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_0257: Expected O, but got I4
		//IL_0172: Expected O, but got I4
		//IL_01aa: Expected O, but got I4
		//IL_0562: Expected O, but got I4
		//IL_056b: Expected O, but got I4
		//IL_0574: Expected O, but got I4
		//IL_01c4: Expected O, but got I
		//IL_01cc: Expected I4, but got O
		//IL_0297: Expected O, but got I
		//IL_02e8: Expected O, but got I4
		//IL_058b: Expected O, but got I4
		//IL_0594: Expected O, but got I4
		//IL_0203: Expected O, but got I
		//IL_020b: Expected I4, but got O
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_03a0: Expected O, but got I
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_05bb: Expected O, but got I4
		//IL_05c4: Expected O, but got I4
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_0493: Expected O, but got I4
		//IL_0715: Expected O, but got I4
		//IL_04f5: Expected O, but got I4
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected O, but got Unknown
		//IL_061b: Expected O, but got I4
		//IL_03d4: Expected O, but got I4
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected O, but got Unknown
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected O, but got Unknown
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected O, but got Unknown
		//IL_0ce2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce7: Expected O, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Expected O, but got Unknown
		//IL_06d8: Expected O, but got I4
		//IL_0803: Expected O, but got I4
		//IL_0a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3b: Expected O, but got Unknown
		//IL_0a65: Expected O, but got I4
		//IL_0d66: Expected I4, but got O
		//IL_0d10: Expected I4, but got I8
		//IL_0d2a: Expected O, but got I4
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Expected O, but got Unknown
		//IL_0c16: Expected O, but got I4
		//IL_0ac3: Expected O, but got I4
		//IL_0af1: Expected O, but got I4
		//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Expected O, but got Unknown
		//IL_0b83: Expected O, but got I4
		//IL_0992: Expected I4, but got O
		//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbc: Expected O, but got Unknown
		TournamentData data = _data;
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2200;
		bool flag2 = SfsTournamentConnector.IsParticipating(data.<RoomId>k__BackingField);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		TournamentData data2 = _data;
		TournamentType tournamentType = data2.<Type>k__BackingField;
		TicketRecord tournamentTickets = SFSKammelnaUserExtensions.GetTournamentTickets(localUser, data2.<Type>k__BackingField);
		object obj8;
		if (tournamentTickets != null && tournamentTickets.<RemainingCount>k__BackingField > 0)
		{
			obj8 = 1;
		}
		else
		{
			TournamentData data3 = _data;
			if (data3.<IsCluster>k__BackingField)
			{
				bool flag4 = data3.<Type>k__BackingField == TournamentType.Public;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					object obj10 = (nint)0 + (nint)504;
					tournamentType = (TournamentType)obj10;
					if (TournamentAddonListExtensions.HasAddonOfType<T>(data3.Addons))
					{
						object obj11 = (nint)0 + (nint)496;
						tournamentType = (TournamentType)obj11;
						if (TournamentAddonListExtensions.HasAddonOfType<T>(data3.Addons))
						{
							obj8 = (??)data3.<SpawnerId>k__BackingField ^ 1;
							goto IL_0c4c;
						}
					}
				}
			}
			obj8 = 0;
		}
		goto IL_0c4c;
		IL_0a1a:
		TournamentStatusUi tournamentStatusUi;
		DateTime roundTimer = tournamentStatusUi.RoundTimer;
		object obj12 = typeof(DataRelation) + 712;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X0_v57+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		bool flag6 = roundTimer > now;
		DateTime dateTime;
		DateTime dateTime2;
		if (flag6)
		{
			DateTime roundTimer2 = ((TournamentStatusUi)flag6).RoundTimer;
			object obj15 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v74+E4]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			dateTime = roundTimer2;
			dateTime2 = roundTimer2;
			if (obj16 == null)
			{
				goto IL_0b0f;
			}
		}
		else
		{
			TournamentData data4 = _data;
			dateTime2 = data4.<StartingTime>k__BackingField;
			object obj15 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v74+E4]");
			bool flag8 = (nint)0 == 0;
			object obj17 = !flag8;
			if (obj17 == null)
			{
				dateTime = data4.<StartingTime>k__BackingField;
				goto IL_0b0f;
			}
		}
		goto IL_0b26;
		IL_03f6:
		TournamentData data5 = _data;
		object obj18 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		if (data5.<Type>k__BackingField == TournamentType.Official)
		{
			object text = "WhiteSmoke" + 1968;
			textView.SetActive(value: true);
			TextMeshProExtensions.Localize(statusText, (string)text);
			data5 = _data;
		}
		object obj19 = data5.<Type>k__BackingField - 3;
		bool flag9 = obj19 == null;
		bool active = !flag9;
		leaveBtnContainer.SetActive(active);
		TournamentData data6 = _data;
		object obj20 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X0_v104+E4]");
		bool flag10 = (nint)0 == 0;
		object obj21 = !flag10;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int seat = SfsTournamentConnector.GetSeat(data6.<RoomId>k__BackingField);
		UpdateSeatText(seat);
		return;
		IL_0b26:
		DateTime now2 = DateTime.Now;
		TimeSpan timeSpan = dateTime2 - now2;
		object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X0_v69+E4]");
		bool flag11 = (nint)0 == 0;
		object obj24 = !flag11;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan2 = default(TimeSpan);
		double totalSeconds = timeSpan2.TotalSeconds;
		object methodName = "SetRoomVariables request error" + 24;
		Invoke((string)methodName, (float)totalSeconds);
		return;
		IL_0b0f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		dateTime2 = dateTime;
		goto IL_0b26;
		IL_0d38:
		GameObject gameObject;
		gameObject.SetActive(value: true);
		object obj25;
		TextMeshProExtensions.Localize(statusText, (string)obj25);
		bool flag12 = false;
		PlayerRank.Ranks ranks = (PlayerRank.Ranks)obj25;
		tournamentStatusUi = (TournamentStatusUi)(object)statusText;
		goto IL_0a1a;
		IL_0c4c:
		TournamentData data7 = _data;
		PlayerInfo <Creator>k__BackingField = data7.<Creator>k__BackingField;
		object obj27;
		int? num2;
		int? num3;
		object obj30;
		if (data7.<Creator>k__BackingField != null)
		{
			object obj26 = (nint)0 + (nint)3136;
			int <DBID>k__BackingField = <Creator>k__BackingField.<DBID>k__BackingField;
			obj27 = obj26;
			int? num = <Creator>k__BackingField.<DBID>k__BackingField;
			object obj28 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v122+E4]");
			bool flag13 = (nint)0 == 0;
			object obj29 = !flag13;
			num2 = num;
			num3 = num;
			obj30 = obj26;
			if (obj29 == null)
			{
				goto IL_030e;
			}
		}
		else
		{
			object obj28 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v122+E4]");
			bool flag14 = (nint)0 == 0;
			object obj31 = !flag14;
			num3 = (int?)(object)0;
			obj30 = 0;
			if (obj31 == null)
			{
				num2 = (int?)(object)0;
				obj27 = 0;
				int <DBID>k__BackingField = (int)tournamentType;
				goto IL_030e;
			}
		}
		goto IL_032d;
		IL_030e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num3 = num2;
		obj30 = obj27;
		goto IL_032d;
		IL_032d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj32 = (object?)num3 >> 32;
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser2);
		object obj33 = intDbId - obj32;
		bool flag15 = obj33 == null;
		TournamentData data8 = _data;
		object obj34 = (nint)0 + (nint)464;
		User user = (User)obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
		object obj35 = default(object);
		object obj36;
		if (obj35 != null)
		{
			TournamentData data9 = _data;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
			TitleRestrictionTournamentAddon titleRestrictionTournamentAddon = default(TitleRestrictionTournamentAddon);
			bool flag16 = titleRestrictionTournamentAddon.IsEligible();
			obj36 = (flag16 ? 1 : 0) ^ 1;
			bool flag17 = !flag2;
			user = null;
			if (!flag17)
			{
				goto IL_03f6;
			}
		}
		else
		{
			bool flag18 = !flag2;
			object obj37 = !flag18;
			obj36 = 0;
			if (obj37 != null)
			{
				goto IL_03f6;
			}
		}
		if (!checkedParticipation)
		{
			object obj38 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X0_v26+E4]");
			bool flag19 = (nint)0 == 0;
			object obj39 = !flag19;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel3 = default(SessionModel);
			User localUser3 = sessionModel3.LocalUser;
			bool flag20 = _data.CanParticipate(localUser3);
			bool flag21 = !flag20;
			user = localUser3;
			if (!flag21)
			{
				object obj40 = flag15 & (??)num3;
				object obj41 = obj8 | obj40;
				object obj42 = obj41 & 1;
				bool flag22 = obj42 == null;
				user = localUser3;
				if (!flag22)
				{
					checkedParticipation = true;
					TournamentData data10 = _data;
					object obj43 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
					object obj44 = obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v25+E4]");
					bool flag23 = (nint)0 == 0;
					object obj45 = !flag23;
					if (obj45 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int seat2 = SfsTournamentConnector.GetSeat(data10.<RoomId>k__BackingField);
					int num4 = (int)(seat2 & 0x80000000L);
					bool flag24 = num4 == 0;
					object obj46 = !flag24;
					if (obj46 == null)
					{
						OnSeatChanged(seat2);
					}
					return;
				}
			}
		}
		object obj47 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X0_v46+E4]");
		bool flag25 = (nint)0 == 0;
		object obj48 = !flag25;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel4 = default(SessionModel);
		User localUser4 = sessionModel4.LocalUser;
		bool flag26 = _data.CanParticipate(localUser4);
		TournamentData data11 = _data;
		if (flag26)
		{
			object obj49 = obj8 & 1;
			if (obj49 != null)
			{
				bool flag27 = data11 == null;
				object obj50 = !flag27;
				if (obj50 == null)
				{
					throw new NullReferenceException();
				}
			}
			else if (data11.<Type>k__BackingField == TournamentType.Official)
			{
				gameObject = textView;
				obj25 = "Network Authentication Required" + 2200;
				goto IL_0d38;
			}
			bool flag28 = data11.<Type>k__BackingField != TournamentType.Mass;
			participateBtnContainer.SetActive(flag28);
			flag12 = false;
			ranks = (flag28 ? PlayerRank.Ranks.Beginner : PlayerRank.Ranks.AI);
			tournamentStatusUi = (TournamentStatusUi)(object)participateBtnContainer;
		}
		else
		{
			if (data11.<Type>k__BackingField == TournamentType.OfficialMonthly)
			{
				gameObject = textView;
				obj25 = "WhiteSmoke" + 1960;
				goto IL_0d38;
			}
			if (obj36 != null)
			{
				titleLimitView.SetActive(value: true);
				TournamentData data12 = _data;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
				TitleRestrictionTournamentAddon titleRestrictionTournamentAddon2 = default(TitleRestrictionTournamentAddon);
				string text2 = titleRestrictionTournamentAddon2.RestrictionTitleId();
				TournamentData data13 = _data;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
				TitleRestrictionTournamentAddon titleRestrictionTournamentAddon3 = default(TitleRestrictionTournamentAddon);
				int num5 = titleRestrictionTournamentAddon3.RestrictionTitleLevel();
				titleLimitTitle.AssignTitle(text2, num5);
				bool flag29 = false;
				flag12 = (byte)num5 != 0;
				ranks = (PlayerRank.Ranks)text2;
				tournamentStatusUi = (TournamentStatusUi)(object)titleLimitTitle;
			}
			else
			{
				rankLimitView.SetActive(value: true);
				TournamentData data14 = _data;
				ranks = data14.<RankLimit>k__BackingField;
				rankLimitRank.SetRank(data14.<RankLimit>k__BackingField);
				bool flag29 = false;
				flag12 = false;
				tournamentStatusUi = (TournamentStatusUi)(object)rankLimitRank;
			}
		}
		goto IL_0a1a;
	}

	private void UpdateInfo()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ X8_v5+188] (should have been resolved before IL gen)");
		object obj6 = this + 152;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetupUi();
	}

	private void OnStatusChanged()
	{
		SetupUi();
	}

	private void UpdateRoundTimer()
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
		//IL_022e: Expected O, but got I4
		//IL_0248: Expected O, but got I4
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0270: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_02b3: Expected O, but got I4
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02fd: Expected O, but got I4
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_033f: Expected O, but got I4
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03b5: Expected O, but got I
		//IL_0526: Expected I, but got O
		//IL_042c: Expected O, but got I4
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_04a6: Expected O, but got I4
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected O, but got Unknown
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EE0]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EDB]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EDB]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v47+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj11 = obj8;
		if (obj10 != null)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_0219:
		SetupUi();
		return;
		IL_01ce:
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom);
		if (tournamentStatus != TournamentStatus.FinalCountdown)
		{
			object obj12 = tournamentStatus - 1;
			bool flag4 = (nint)obj12 < 3;
			object obj13 = !flag4;
			object obj14 = obj12 - 3;
			bool flag5 = obj14 == null;
			object obj15 = !flag5;
			object obj16 = obj13 & obj15;
			if (obj16 != null)
			{
				return;
			}
			object obj17 = tournamentStatus - 2;
			bool flag6 = (nint)obj17 < 2;
			object obj18 = !flag6;
			object obj19 = obj17 - 2;
			bool flag7 = obj19 == null;
			object obj20 = ~obj18;
			object obj21 = obj20 | flag7;
			if (obj21 == null)
			{
				DateTime roundTimer = ((TournamentStatusUi)tournamentStatus).RoundTimer;
				object obj22 = typeof(DataRelation) + 712;
				object obj23 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v8+E4]");
				bool flag8 = (nint)0 == 0;
				object obj24 = !flag8;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				if (roundTimer > now)
				{
					object obj25 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
					object obj26 = (nint)0 + (nint)1960;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Action<object> action = default(Action<object>);
					action..ctor((object)null, (IntPtr)obj26);
					ArraysExtensions.ForEach(allContainers, action);
					roundTimerView.SetActive(value: true);
					DateTime roundTimer2 = ((TournamentStatusUi)(object)roundTimerView).RoundTimer;
					roundTimerText.SetDate(roundTimer2);
					DateTime roundTimer3 = ((TournamentStatusUi)(object)roundTimerText).RoundTimer;
					object obj27 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v22+E4]");
					bool flag9 = (nint)0 == 0;
					object obj28 = !flag9;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					DateTime now2 = DateTime.Now;
					TimeSpan timeSpan = roundTimer3 - now2;
					object obj29 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
					object obj30 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v28+E4]");
					bool flag10 = (nint)0 == 0;
					object obj31 = !flag10;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					TimeSpan timeSpan2 = default(TimeSpan);
					double totalSeconds = timeSpan2.TotalSeconds;
					object methodName = "SetRoomVariables request error" + 24;
					float time = (float)totalSeconds + 3f;
					Invoke((string)methodName, time);
					return;
				}
				goto IL_0219;
			}
		}
		CancelInvoke();
		goto IL_0219;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag11 = (object)sessionModel == null;
		object obj32 = !flag11;
		if (obj32 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01ce;
		IL_008b:
		obj8 = (nint)0 + (nint)2200;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v47+E4]");
		bool flag12 = (nint)0 == 0;
		obj11 = obj8;
		if (!flag12)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_01b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_01ce;
	}

	private void Participate()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003a: Expected O, but got I
		//IL_0074: Expected O, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00cc: Expected O, but got I
		//IL_016a: Expected O, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01b5: Expected O, but got I
		//IL_0107: Expected O, but got I
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		participateBtn.interactable = true;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)240;
		leaveBtn.interactable = true;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = typeof(System.IOAsyncCallback) + 1792;
		object obj7 = default(object);
		object obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7+12E]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0148;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7+B0]");
		object obj9 = (nint)0 + (nint)8;
		goto IL_01bf;
		IL_0174:
		object obj10 = obj9 + 1;
		object obj11 = obj6 + obj10;
		object obj12 = obj11 + 312;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v10+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v120 @ X2_v6 (should have been resolved before IL gen)");
		goto IL_01bf;
		IL_01bf:
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X10_v4-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 += 16;
			obj8--;
			if ((nint)obj8 != 1)
			{
				continue;
			}
			goto IL_0148;
		}
		goto IL_0174;
		IL_0148:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj16 = default(object);
		object obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v10+8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v119 @ X2_v5 (should have been resolved before IL gen)");
		goto IL_0174;
	}

	private void Forfeit()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003a: Expected O, but got I
		//IL_0074: Expected O, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00cc: Expected O, but got I
		//IL_016a: Expected O, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01b5: Expected O, but got I
		//IL_0107: Expected O, but got I
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		participateBtn.interactable = true;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)240;
		leaveBtn.interactable = true;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = typeof(System.IOAsyncCallback) + 1792;
		object obj7 = default(object);
		object obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7+12E]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0148;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7+B0]");
		object obj9 = (nint)0 + (nint)8;
		goto IL_01bf;
		IL_0174:
		object obj10 = obj9 + 2;
		object obj11 = obj6 + obj10;
		object obj12 = obj11 + 312;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v10+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v120 @ X2_v6 (should have been resolved before IL gen)");
		goto IL_01bf;
		IL_01bf:
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X10_v4-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj9 += 16;
			obj8--;
			if ((nint)obj8 != 1)
			{
				continue;
			}
			goto IL_0148;
		}
		goto IL_0174;
		IL_0148:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj16 = default(object);
		object obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v10+8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v119 @ X2_v5 (should have been resolved before IL gen)");
		goto IL_0174;
	}

	private void CheckParticipation()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00d0: Expected I4, but got I8
		//IL_006a: Expected I4, but got I8
		//IL_0084: Expected O, but got I4
		checkedParticipation = true;
		TournamentData data = _data;
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		int seat;
		if ((nint)0 != 0)
		{
			seat = SfsTournamentConnector.GetSeat(data.<RoomId>k__BackingField);
			int num = (int)(seat & 0x80000000L);
			bool flag = num == 0;
			object obj3 = !flag;
			if (obj3 != null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			seat = SfsTournamentConnector.GetSeat(data.<RoomId>k__BackingField);
			if ((int)(seat & 0x80000000L) != 0)
			{
				return;
			}
		}
		OnSeatChanged(seat);
	}

	private void OnSeatChanged(int roomId, int seat)
	{
		TournamentData data = _data;
		if (_data != null && data.<RoomId>k__BackingField == roomId)
		{
			OnSeatChanged(seat);
		}
	}

	private void OnSeatChanged(int seat)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_00dc: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_005e: Expected O, but got I
		//IL_0162: Expected O, but got I4
		//IL_017c: Expected O, but got I4
		checkedParticipation = true;
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EDB]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj3;
			if (!flag)
			{
				goto IL_0093;
			}
		}
		else
		{
			_ = 1;
			object obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0093;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0135;
		IL_0135:
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom);
		object obj7 = tournamentStatus - 1;
		bool flag3 = (nint)obj7 < 4;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			int seat2 = seat + 1;
			UpdateSeatText(seat2);
			participateBtn.interactable = true;
			leaveBtn.interactable = true;
			SetupUi();
		}
		return;
		IL_0093:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0135;
	}

	private void SetStartedView()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)1960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		ArraysExtensions.ForEach(allContainers, action);
		object text = "ThisIsFakeReceiptData" + 1288;
		textView.SetActive(value: true);
		TextMeshProExtensions.Localize(statusText, (string)text);
	}

	private void SetStartingSoonView()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)1960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		ArraysExtensions.ForEach(allContainers, action);
		object text = "ThisIsFakeReceiptData" + 1296;
		textView.SetActive(value: true);
		TextMeshProExtensions.Localize(statusText, (string)text);
	}

	private void SetFinishedView()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)1960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		ArraysExtensions.ForEach(allContainers, action);
		object text = "ThisIsFakeReceiptData" + 1272;
		textView.SetActive(value: true);
		TextMeshProExtensions.Localize(statusText, (string)text);
	}

	private void SetNotAvailableView()
	{
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_0550: Expected O, but got I
		//IL_055c: Expected O, but got I
		//IL_064b: Expected I, but got O
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0086: Expected O, but got I
		//IL_00a0: Expected O, but got I4
		//IL_00ed: Expected O, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected O, but got Unknown
		//IL_05a8: Expected O, but got I
		//IL_05c2: Expected O, but got I4
		//IL_05d3: Expected O, but got I4
		//IL_05ec: Expected O, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_0606: Expected O, but got I
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_018f: Expected O, but got I
		//IL_01ac: Expected O, but got I4
		//IL_0230: Expected O, but got I4
		//IL_01d0: Expected O, but got I4
		//IL_02ae: Expected O, but got I
		//IL_035f: Expected O, but got I4
		//IL_031c: Expected O, but got I4
		//IL_03cf: Expected O, but got I4
		//IL_0453: Expected O, but got I4
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected O, but got Unknown
		//IL_04d2: Expected O, but got I4
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected O, but got Unknown
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)1960;
		object obj3 = (nint)0 + (nint)2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		ArraysExtensions.ForEach(allContainers, action);
		TournamentData data = _data;
		object obj4 = typeof(DataRelation) + 712;
		GameObject gameObject;
		object obj5;
		object obj10;
		string text;
		object obj12;
		object obj13;
		string text2;
		object obj14;
		if (data.<Type>k__BackingField == TournamentType.OfficialMonthly)
		{
			gameObject = textView;
			obj5 = "October" + 48;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EDC]");
			object obj6 = (nint)0 & (nint)1;
			bool flag = obj6 == null;
			object obj7 = !flag;
			if (obj7 == null)
			{
				_ = 1;
				data = _data;
			}
			object obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v66+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			bool flag3 = data.<AvailabilityTime>k__BackingField <= now;
			gameObject = textView;
			if (flag3)
			{
				textView.SetActive(value: false);
				obj10 = typeof(Queue<string>) + 848;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EDB]");
				object obj11 = (nint)0 & (nint)1;
				bool flag4 = obj11 == null;
				text = null;
				obj12 = 0;
				if (flag4)
				{
					goto IL_01e9;
				}
				obj13 = obj10;
				text2 = null;
				obj14 = 0;
				goto IL_05fa;
			}
			obj5 = "ThisIsFakeReceiptData" + 1440;
		}
		gameObject.SetActive(value: true);
		TextMeshProExtensions.Localize(statusText, (string)obj5);
		obj10 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EDB]");
		object obj15 = (nint)0 & (nint)1;
		bool flag5 = obj15 == null;
		object obj16 = !flag5;
		text = (string)obj5;
		obj12 = 0;
		obj13 = obj10;
		text2 = (string)obj5;
		obj14 = 0;
		if (obj16 == null)
		{
			goto IL_01e9;
		}
		goto IL_05fa;
		IL_02f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag6 = (object)sessionModel == null;
		object obj17 = !flag6;
		if (obj17 != null)
		{
			goto IL_0386;
		}
		goto IL_0529;
		IL_0529:
		throw new NullReferenceException();
		IL_0386:
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom);
		object obj18 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v17+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now2 = DateTime.Now;
		if (tournamentInfo.<AvailabilityTime>k__BackingField > now2)
		{
			object obj20 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v23+E4]");
			bool flag8 = (nint)0 == 0;
			object obj21 = !flag8;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now3 = DateTime.Now;
			TimeSpan timeSpan = tournamentInfo.<AvailabilityTime>k__BackingField - now3;
			object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v29+E4]");
			bool flag9 = (nint)0 == 0;
			object obj24 = !flag9;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan2 = default(TimeSpan);
			double totalSeconds = timeSpan2.TotalSeconds;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			object methodName = "October" + 648;
			Invoke((string)methodName, (float)totalSeconds);
		}
		return;
		IL_05fa:
		object obj25 = (nint)0 + (nint)2200;
		object obj26 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v9+E4]");
		SessionModel sessionModel2 = default(SessionModel);
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag10 = (object)sessionModel2 == null;
			object obj27 = !flag10;
			if (obj27 == null)
			{
				goto IL_0529;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		}
		Room currentRoom2 = sessionModel2.CurrentRoom;
		TournamentData tournamentInfo2 = SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom2);
		if (tournamentInfo2 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EDB]");
		object obj28 = (nint)0 & (nint)1;
		if (obj28 != null)
		{
			object obj29 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v36+E4]");
			if ((nint)0 != 0)
			{
				goto IL_02f8;
			}
		}
		else
		{
			_ = 1;
			object obj29 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v36+E4]");
			bool flag11 = (nint)0 == 0;
			object obj30 = !flag11;
			if (obj30 != null)
			{
				goto IL_02f8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0386;
		IL_01e9:
		_ = 1;
		obj13 = obj10;
		text2 = text;
		obj14 = obj12;
		goto IL_05fa;
	}

	private unsafe void UpdateSeatText(int seat)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e2: Expected O, but got I
		//IL_010c: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_01ff: Expected O, but got I4
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_0288: Expected O, but got I4
		//IL_02e4: Expected I, but got O
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E9E]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v26+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v26+E4]");
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
		int num = seat;
		if (!flag3)
		{
			goto IL_0160;
		}
		goto IL_0417;
		IL_0417:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0425;
		IL_0433:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0425:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0433;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_0160;
		}
		num = seat;
		goto IL_0417;
		IL_0160:
		User localUser = sessionModel.LocalUser;
		MonthlyTournamentEligibilityType monthlyTournamentEligibility = SFSKammelnaUserExtensions.GetMonthlyTournamentEligibility(localUser);
		TournamentSubType? tournamentSubType = MonthlyTournamentEligibilityExtensions.ToTournamentSubType(monthlyTournamentEligibility);
		TournamentData data = _data;
		bool flag5 = _data == null;
		num = 0;
		if (flag5)
		{
			goto IL_0417;
		}
		TextMeshProUGUI textMesh;
		object text2;
		if (data.<Type>k__BackingField != TournamentType.OfficialMonthly)
		{
			bool flag6 = data.<Type>k__BackingField == TournamentType.Public;
			object obj9 = !flag6;
			if (obj9 == null && seat > data.<MaxAllowedSize>k__BackingField)
			{
				object obj10 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				bool flag7 = _data == null;
				num = 1;
				if (!flag7)
				{
					object obj11 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object[] array = default(object[]);
					bool flag8 = array == null;
					object obj12 = default(object);
					num = (int)(&obj12);
					if (!flag8)
					{
						object obj13 = default(object);
						bool flag9 = obj13 == null;
						int num2 = (int)(&obj12);
						if (!flag9)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
							num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag10 = ex2 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
							num = 0;
							if (flag10)
							{
								goto IL_0433;
							}
						}
						bool flag11 = array.Length == 0;
						num = num2;
						if (!flag11)
						{
							object obj14 = array + 32;
							obj14 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object text = "WhiteSmoke" + 2272;
							TextMeshProExtensions.Localize(seatText, (string)text, array);
							return;
						}
						goto IL_0425;
					}
				}
				goto IL_0417;
			}
		}
		else
		{
			object obj15 = (object?)data.<SubType>k__BackingField ^ (object?)tournamentSubType;
			object obj16 = obj15 & -4294967295L;
			if (obj16 != null)
			{
				textMesh = seatText;
				text2 = "WhiteSmoke" + 1544;
				goto IL_0449;
			}
		}
		text2 = "WhiteSmoke" + 1536;
		textMesh = seatText;
		goto IL_0449;
		IL_0449:
		TextMeshProExtensions.Localize(textMesh, (string)text2);
	}

	private void SetStatus(string text)
	{
		textView.SetActive(value: true);
		TextMeshProExtensions.Localize(statusText, text);
	}

	private void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003f: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)1960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		ArraysExtensions.ForEach(allContainers, action);
	}
}
