using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentSharingArea : MonoBehaviour
{
	private TournamentsEventsChannel eventsChannel;

	private GameObject container;

	private GameObject passwordContainer;

	private TextMeshProUGUI password;

	private Button copyPassword;

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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ED6]");
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
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0148: Expected O, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Expected O, but got I
		//IL_0066: Expected I, but got O
		//IL_0080: Expected O, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00af: Expected O, but got I
		//IL_00c7: Expected I, but got O
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I
		//IL_011b: Expected I, but got O
		container.SetActive(value: false);
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v6+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)1400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v8+20]");
		((OneShotEvent)0).CallWhenReady(action);
		Button button = copyPassword;
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj8 = (nint)0 + (nint)1392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj8);
		object obj9 = typeof(SkeletonBinary.SkeletonInput) + 4032;
		object obj10 = (nint)0 + (nint)1408;
		button.m_OnClick.AddListener(unityAction);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentsEventsChannel.TournamentSeatChanged tournamentSeatChanged = default(TournamentsEventsChannel.TournamentSeatChanged);
		tournamentSeatChanged..ctor(this, (IntPtr)obj10);
		eventsChannel.OnTournamentSeatChanged += tournamentSeatChanged;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 4032;
		object obj2 = (nint)0 + (nint)1408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentsEventsChannel.TournamentSeatChanged tournamentSeatChanged = default(TournamentsEventsChannel.TournamentSeatChanged);
		tournamentSeatChanged..ctor(this, (IntPtr)obj2);
		eventsChannel.OnTournamentSeatChanged -= tournamentSeatChanged;
	}

	private void OnSeatChanged(int roomId, int seat)
	{
		UpdateInfo();
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ED7]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45BB]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45BB]");
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
		object obj11 = (nint)0 + (nint)1416;
		object varName = "https://www.kammelna.com/Home/Terms" + 136;
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
		object obj16 = this + 72;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ED6]");
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

	private void UpdateInfo()
	{
		//IL_0031: Expected O, but got I4
		//IL_0044: Expected O, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected I4, but got Unknown
		//IL_0915: Unknown result type (might be due to invalid IL or missing references)
		//IL_091a: Expected O, but got Unknown
		//IL_0944: Expected O, but got I4
		//IL_094d: Expected O, but got I4
		//IL_02c2: Expected O, but got I
		//IL_0110: Expected O, but got I
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0168: Expected O, but got I4
		//IL_0974: Expected O, but got I4
		//IL_032f: Expected O, but got I4
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected I4, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected I4, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_0426: Expected O, but got I4
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected I4, but got Unknown
		//IL_04ae: Expected O, but got I4
		//IL_04e9: Expected O, but got I4
		//IL_0548: Expected O, but got I4
		//IL_05a2: Expected O, but got I4
		//IL_05e0: Expected O, but got I4
		//IL_05f3: Expected O, but got I4
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected I4, but got Unknown
		//IL_0a8c: Expected O, but got I4
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected O, but got Unknown
		//IL_06b5: Expected O, but got I4
		//IL_06f5: Expected O, but got I4
		//IL_0703: Expected O, but got I4
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Expected I4, but got Unknown
		//IL_07a1: Expected O, but got I4
		//IL_07b7: Expected O, but got I
		//IL_089b: Expected O, but got I4
		//IL_082b: Expected O, but got I4
		//IL_08dc: Expected O, but got I4
		//IL_08ed: Expected O, but got I4
		TournamentData data = _data;
		bool flag = _data == null;
		IntPtr intPtr = default(IntPtr);
		bool flag2 = (byte)(nint)intPtr != 0;
		TournamentSharingArea tournamentSharingArea = this;
		object obj4;
		object obj5;
		int num5;
		bool flag10;
		int? num7;
		bool flag12;
		bool flag13;
		bool flag14;
		int num8;
		int num9;
		int num10;
		bool flag15;
		bool flag16;
		object obj8;
		object obj9;
		TournamentType tournamentType;
		TournamentSharingArea tournamentSharingArea2;
		int? num11;
		object obj11;
		int num6 = default(int);
		TournamentType <Type>k__BackingField;
		object obj;
		object obj2;
		bool flag4;
		bool flag5;
		int num;
		int num2;
		int num3;
		bool flag6;
		bool flag7;
		bool flag11 = default(bool);
		object obj10 = default(object);
		if (!flag)
		{
			<Type>k__BackingField = data.<Type>k__BackingField;
			bool flag3 = data.<Type>k__BackingField < TournamentType.Private;
			obj = !flag3;
			obj2 = data.<Type>k__BackingField - 1;
			flag4 = (nint)obj2 < 0;
			flag5 = obj2 == null;
			num = (int)(data.<Type>k__BackingField ^ TournamentType.Private);
			num2 = data.<Type>k__BackingField ^ obj2;
			num3 = num & num2;
			flag6 = num3 < 0;
			flag7 = data.<Type>k__BackingField != TournamentType.Private;
			if (flag7)
			{
				return;
			}
			PlayerInfo <Creator>k__BackingField = data.<Creator>k__BackingField;
			bool flag8 = data.<Creator>k__BackingField == null;
			flag2 = (byte)(nint)intPtr != 0;
			tournamentSharingArea = this;
			if (!flag8)
			{
				object obj3 = (nint)0 + (nint)3136;
				obj4 = obj3;
				int? num4 = <Creator>k__BackingField.<DBID>k__BackingField;
				obj5 = typeof(Queue<string>) + 848;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v48+E4]");
				bool flag9 = (nint)0 == 0;
				object obj7 = !flag9;
				num5 = num6;
				flag10 = flag11;
				num7 = num4;
				flag12 = (byte)<Creator>k__BackingField.<DBID>k__BackingField != 0;
				flag13 = flag7;
				flag14 = flag6;
				num8 = num3;
				num9 = num2;
				num10 = num;
				flag15 = flag5;
				flag16 = flag4;
				obj8 = obj2;
				obj9 = obj;
				tournamentType = data.<Type>k__BackingField;
				tournamentSharingArea2 = this;
				num11 = num4;
				obj10 = obj3;
				flag2 = (byte)<Creator>k__BackingField.<DBID>k__BackingField != 0;
				obj11 = obj5;
				tournamentSharingArea = this;
				if (obj7 == null)
				{
					goto IL_021f;
				}
			}
			else
			{
				obj11 = typeof(Queue<string>) + 848;
				object obj6 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v48+E4]");
				bool flag17 = (nint)0 == 0;
				object obj12 = !flag17;
				num11 = (int?)(object)0;
				if (obj12 == null)
				{
					num5 = num6;
					flag10 = flag11;
					num7 = (int?)(object)0;
					obj4 = obj10;
					flag12 = flag2;
					flag13 = flag7;
					flag14 = flag6;
					num8 = num3;
					num9 = num2;
					num10 = num;
					flag15 = flag5;
					flag16 = flag4;
					obj8 = obj2;
					obj9 = obj;
					tournamentType = <Type>k__BackingField;
					obj5 = obj11;
					tournamentSharingArea2 = tournamentSharingArea;
					goto IL_021f;
				}
			}
			goto IL_02b6;
		}
		goto IL_08fb;
		IL_021f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num6 = num5;
		flag11 = flag10;
		num11 = num7;
		obj10 = obj4;
		flag2 = flag12;
		flag7 = flag13;
		flag6 = flag14;
		num3 = num8;
		num2 = num9;
		num = num10;
		flag5 = flag15;
		flag4 = flag16;
		obj2 = obj8;
		obj = obj9;
		<Type>k__BackingField = tournamentType;
		obj11 = obj5;
		tournamentSharingArea = tournamentSharingArea2;
		goto IL_02b6;
		IL_02b6:
		object obj13 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag19;
		SessionModel sessionModel2 = default(SessionModel);
		if ((object)sessionModel != null)
		{
			object obj14 = (object?)num11 >> 32;
			User localUser = sessionModel.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			bool flag18 = intDbId < (nint)obj14;
			obj = !flag18;
			obj2 = intDbId - obj14;
			flag4 = (nint)obj2 < 0;
			flag19 = obj2 == null;
			num = intDbId ^ obj14;
			num2 = intDbId ^ obj2;
			num3 = num & num2;
			flag6 = num3 < 0;
			TournamentData data2 = tournamentSharingArea._data;
			bool flag20 = tournamentSharingArea._data == null;
			flag11 = flag19;
			flag2 = false;
			flag5 = flag19;
			if (!flag20)
			{
				object obj15 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v12+E4]");
				<Type>k__BackingField = TournamentType.Public;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v12+E4]");
				bool flag21 = (nint)0 == 0;
				object obj17 = !flag21;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num6 = data2.<RoomId>k__BackingField;
				}
				bool flag22 = SfsTournamentConnector.IsParticipating(data2.<RoomId>k__BackingField);
				bool flag23 = (object)tournamentSharingArea.container == null;
				flag11 = flag19;
				flag2 = false;
				flag5 = flag19;
				if (!flag23)
				{
					<Type>k__BackingField = ((flag19 & (??)num11) ? TournamentType.Private : TournamentType.Public);
					flag2 = (byte)((uint)<Type>k__BackingField | (flag22 ? 1u : 0u)) != 0;
					tournamentSharingArea.container.SetActive(flag2);
					TournamentData data3 = tournamentSharingArea._data;
					bool flag24 = tournamentSharingArea._data == null;
					flag11 = flag19;
					obj10 = 0;
					flag5 = flag19;
					if (!flag24)
					{
						bool flag25 = (object)tournamentSharingArea.passwordContainer == null;
						flag11 = flag19;
						obj10 = 0;
						flag5 = flag19;
						if (!flag25)
						{
							flag2 = data3.<IsProtected>k__BackingField;
							tournamentSharingArea.passwordContainer.SetActive(data3.<IsProtected>k__BackingField);
							bool flag26 = (object)tournamentSharingArea.copyPassword == null;
							flag11 = flag19;
							obj10 = 0;
							flag5 = flag19;
							if (!flag26)
							{
								GameObject gameObject = tournamentSharingArea.copyPassword.gameObject;
								TournamentData data4 = tournamentSharingArea._data;
								bool flag27 = tournamentSharingArea._data == null;
								flag11 = flag19;
								obj10 = 0;
								flag2 = false;
								flag5 = flag19;
								if (!flag27)
								{
									bool flag28 = (data4.<IsProtected>k__BackingField ? 1 : 0) < (true ? 1 : 0);
									obj = !flag28;
									obj2 = (data4.<IsProtected>k__BackingField ? 1 : 0) - 1;
									flag4 = (nint)obj2 < 0;
									flag5 = obj2 == null;
									num = (data4.<IsProtected>k__BackingField ? 1 : 0) ^ 1;
									num2 = ((data4.<IsProtected>k__BackingField ^ obj2) ? 1 : 0);
									num3 = num & num2;
									flag6 = num3 < 0;
									if (data4.<IsProtected>k__BackingField)
									{
										object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
										object obj19 = obj18;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v39+E4]");
										bool flag29 = (nint)0 == 0;
										object obj20 = !flag29;
										if (obj20 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Platform platform = KUtil.GetPlatform();
										bool flag30 = platform < Platform.Web;
										obj = !flag30;
										obj2 = platform - 3;
										flag4 = (nint)obj2 < 0;
										flag5 = obj2 == null;
										num = (int)(platform ^ Platform.Web);
										num2 = platform ^ obj2;
										num3 = num & num2;
										flag6 = num3 < 0;
										flag7 = !flag5;
										flag2 = flag7;
									}
									else
									{
										flag2 = false;
									}
									bool flag31 = (object)gameObject == null;
									flag11 = flag19;
									obj10 = 0;
									if (!flag31)
									{
										gameObject.SetActive(flag2);
										tournamentSharingArea = (TournamentSharingArea)(object)tournamentSharingArea.password;
										object obj21 = 152985600;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ED6]");
										object obj22 = (nint)0 & (nint)1;
										if (obj22 != null)
										{
											object obj23 = obj11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v20+E4]");
											if ((nint)0 != 0)
											{
												goto IL_0801;
											}
										}
										else
										{
											_ = 1;
											object obj23 = obj11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v20+E4]");
											bool flag32 = (nint)0 == 0;
											object obj24 = !flag32;
											if (obj24 != null)
											{
												goto IL_0801;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
										bool flag33 = (object)sessionModel2 == null;
										object obj25 = !flag33;
										flag11 = flag19;
										obj10 = 0;
										if (obj25 != null)
										{
											goto IL_0839;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_08fb;
		IL_0839:
		Room currentRoom = sessionModel2.CurrentRoom;
		string tournamentPassword = SFSKammelnaRoomExtensions.GetTournamentPassword(currentRoom);
		TextMeshProExtensions.FixArabic((TextMeshProUGUI)(object)tournamentSharingArea, tournamentPassword);
		return;
		IL_0801:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag34 = (object)sessionModel2 == null;
		flag11 = flag19;
		obj10 = 0;
		if (!flag34)
		{
			goto IL_0839;
		}
		goto IL_08fb;
		IL_08fb:
		throw new NullReferenceException();
	}

	private void CopyToClipboard()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01b5: Expected O, but got I
		//IL_01cf: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_00af: Expected O, but got I
		//IL_00de: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_01f7: Expected O, but got I
		//IL_020f: Expected O, but got I
		//IL_0231: Expected O, but got I4
		//IL_0249: Expected O, but got I
		//IL_028a: Expected O, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ED9]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ED6]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ED6]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+E4]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		object obj12 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+E4]");
		object obj13 = 0;
		if (obj11 != null)
		{
			goto IL_00ec;
		}
		goto IL_0257;
		IL_02ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		NullReferenceException systemCopyBuffer;
		GUIUtility.systemCopyBuffer = (string)(object)systemCopyBuffer;
		return;
		IL_0113:
		object obj14 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1976;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		string tournamentPassword = SFSKammelnaRoomExtensions.GetTournamentPassword(currentRoom);
		obj10 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v2+E4]");
		bool flag4 = (nint)0 == 0;
		systemCopyBuffer = (NullReferenceException)(object)tournamentPassword;
		if (!flag4)
		{
			GUIUtility.systemCopyBuffer = tournamentPassword;
			return;
		}
		goto IL_02ae;
		IL_02a0:
		systemCopyBuffer = new NullReferenceException();
		goto IL_02ae;
		IL_008b:
		obj8 = (nint)0 + (nint)2200;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+E4]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		obj12 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+E4]");
		obj13 = 0;
		if (!flag5)
		{
			goto IL_00ec;
		}
		goto IL_0257;
		IL_0257:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag6 = (object)sessionModel == null;
		object obj15 = !flag6;
		obj10 = obj13;
		if (obj15 != null)
		{
			goto IL_0113;
		}
		goto IL_02a0;
		IL_00ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_0113;
		}
		goto IL_02a0;
	}
}
