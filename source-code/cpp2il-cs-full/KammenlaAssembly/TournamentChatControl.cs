using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentChatControl : MonoBehaviour
{
	private GameObject panel;

	private Toggle enableChatToggle;

	private InputFieldTMProUGUI inputField;

	private TextMeshProUGUI text;

	private GameObject pinMessage;

	private TextMeshProUGUI showFullMessage;

	private SlideAnimationHelper pinMessagePanel;

	private Button readMore;

	private GameObject blocker;

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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EA4]");
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
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_0333: Expected O, but got I
		//IL_035d: Expected O, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_004a: Expected O, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e5: Expected O, but got I
		//IL_00fd: Expected I, but got O
		//IL_010e: Expected O, but got I
		//IL_030e: Expected O, but got I
		//IL_0138: Expected O, but got I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0162: Expected O, but got I
		//IL_0078: Expected O, but got I
		//IL_0086: Expected I, but got O
		//IL_0241: Expected O, but got I
		//IL_026b: Expected O, but got I4
		//IL_00a0: Expected O, but got I
		//IL_00a9: Expected O, but got I4
		//IL_018b: Expected O, but got I
		//IL_01db: Expected O, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_0214: Expected I, but got O
		//IL_02b4: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5+B8]");
		object obj4 = 0;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = typeof(SqlSingle[]) + 2376;
		bool flag2 = (UnityEngine.Object)obj4 != null;
		bool flag3 = !flag2;
		object obj8 = 0;
		Action action = null;
		if (!flag3)
		{
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v22+B8]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)624;
			Action action2 = default(Action);
			action2..ctor(this, (IntPtr)obj12);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v24+20]");
			((OneShotEvent)0).CallWhenReady(action2);
			obj8 = 0;
			action = action2;
		}
		Toggle toggle = enableChatToggle;
		object obj13 = typeof(TypeConverter<ushort, char>) + 360;
		object obj14 = (nint)0 + (nint)616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor((object)this, (IntPtr)obj14);
		object obj15 = (nint)0 + (nint)832;
		toggle.onValueChanged.AddListener(unityAction);
		GameObject go = base.gameObject;
		object obj16 = 152985600;
		object obj17 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EA4]");
		object obj18 = (nint)0 & (nint)1;
		if (obj18 != null)
		{
			object obj19 = (nint)0 + (nint)2200;
			object obj20 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj21 = obj19;
			if (!flag4)
			{
				goto IL_01c0;
			}
		}
		else
		{
			_ = 1;
			object obj19 = (nint)0 + (nint)2200;
			object obj20 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj22 = !flag5;
			object obj21 = obj19;
			if (obj22 != null)
			{
				goto IL_01c0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag6 = (object)sessionModel == null;
		object obj23 = !flag6;
		if (obj23 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01cf;
		IL_01c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_01cf;
		IL_01cf:
		object obj24 = (nint)0 + (nint)632;
		object varName = "placementId" + 288;
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj24);
		VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action3);
	}

	private void OnEnable()
	{
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01e3: Expected O, but got I
		//IL_00b2: Expected O, but got I
		//IL_00e4: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_001d: Expected O, but got I
		//IL_0218: Expected O, but got I
		//IL_0131: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_017c: Expected O, but got I
		//IL_018a: Expected I, but got O
		//IL_01a4: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B4]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj6;
		UnityEngine.Object obj8;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v23+B8]");
			object obj5 = 0;
			obj6 = (UnityEngine.Object)obj5;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			obj8 = (UnityEngine.Object)obj5;
			if (!flag)
			{
				goto IL_005a;
			}
		}
		else
		{
			_ = 1;
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v18+B8]");
			object obj10 = 0;
			obj6 = (UnityEngine.Object)obj10;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			obj8 = (UnityEngine.Object)obj10;
			if (obj11 != null)
			{
				goto IL_005a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj8 == null;
		bool flag4 = !flag3;
		object obj12 = !flag4;
		object obj13 = 0;
		UnityEngine.Object obj14 = null;
		if (obj12 != null)
		{
			return;
		}
		goto IL_0200;
		IL_0200:
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v7+B8]");
		object obj16 = 0;
		object obj17 = obj16;
		object obj18 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)600;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj19);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v9+20]");
		((OneShotEvent)0).CallWhenReady(action);
		return;
		IL_005a:
		bool flag5 = obj6 == null;
		bool flag6 = !flag5;
		obj13 = 0;
		obj14 = null;
		if (!flag6)
		{
			return;
		}
		goto IL_0200;
	}

	private void Init()
	{
		//IL_0016: Expected O, but got I
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0121: Expected O, but got I
		//IL_013b: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		//IL_0155: Expected O, but got I4
		//IL_009c: Expected I, but got O
		//IL_00b4: Expected O, but got I
		//IL_00ce: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0075: Expected O, but got I4
		//IL_0086: Expected O, but got I4
		//IL_01be: Expected O, but got I
		//IL_0171: Expected I, but got O
		//IL_0189: Expected O, but got I
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_0223: Expected O, but got I
		//IL_09f3: Expected O, but got I
		//IL_0a1d: Expected O, but got I4
		//IL_0a26: Expected O, but got I4
		//IL_025c: Expected O, but got I
		//IL_0285: Expected O, but got I
		//IL_02af: Expected O, but got I4
		//IL_0357: Expected O, but got I
		//IL_0abd: Expected O, but got I4
		//IL_04db: Expected O, but got I4
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected I4, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected I4, but got Unknown
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_0674: Expected O, but got I
		//IL_05ba: Expected O, but got I4
		//IL_05d0: Expected O, but got I
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected I4, but got Unknown
		//IL_0740: Expected O, but got I4
		//IL_06e2: Expected O, but got I4
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected O, but got Unknown
		//IL_07bf: Expected O, but got I
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected O, but got Unknown
		//IL_07f8: Expected I, but got O
		//IL_06f9: Expected O, but got I4
		//IL_0703: Expected I, but got O
		//IL_077f: Expected O, but got I4
		//IL_0789: Expected I, but got O
		//IL_083a: Expected O, but got I
		//IL_095e: Expected O, but got I4
		//IL_08a6: Expected O, but got I4
		//IL_08b7: Expected O, but got I4
		//IL_08bc: Expected I, but got O
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected O, but got Unknown
		//IL_099f: Expected O, but got I4
		//IL_09a8: Expected O, but got I4
		//IL_09b9: Expected O, but got I4
		//IL_09be: Expected I, but got O
		//IL_0913: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EA6]");
		object obj = (nint)0 & (nint)1;
		Room room;
		GameObject gameObject;
		Room room2;
		GameObject gameObject2;
		if (obj != null)
		{
			room = (Room)(typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B4]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			gameObject = (GameObject)146685952;
			room2 = room;
			gameObject2 = (GameObject)146685952;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			room = (Room)(typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B4]");
			object obj3 = (nint)0 & (nint)1;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			gameObject = (GameObject)146685952;
			room2 = room;
			gameObject2 = (GameObject)146685952;
			if (obj4 != null)
			{
				goto IL_0094;
			}
		}
		_ = 1;
		nint num = (nint)room2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v32 (Il2CppClass<Sfs2X.Entities.Room>)+B8]");
		nint num2 = 0;
		object obj5 = num2;
		if (num2 != 0)
		{
			goto IL_01a6;
		}
		goto IL_09dc;
		IL_08da:
		object varName = "startPosition" + 104;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		object obj6 = default(object);
		action..ctor(this, (IntPtr)obj6);
		GameObject gameObject3;
		VariableBinderExtensions.Bind(gameObject3, currentRoom, (string)varName, action);
		return;
		IL_046e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		int? num3;
		GameObject gameObject4;
		object obj13;
		SessionModel sessionModel3 = default(SessionModel);
		bool flag7 = default(bool);
		bool flag6 = default(bool);
		int num6 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		bool flag5 = default(bool);
		bool flag4 = default(bool);
		object obj9 = default(object);
		object obj8 = default(object);
		object obj7 = default(object);
		string text = default(string);
		nint num7;
		if ((object)sessionModel2 != null)
		{
			obj7 = (object?)num3 >> 32;
			User localUser = sessionModel2.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			bool flag3 = intDbId < (nint)obj7;
			obj8 = !flag3;
			obj9 = intDbId - obj7;
			flag4 = (nint)obj9 < 0;
			flag5 = obj9 == null;
			num4 = intDbId ^ obj7;
			num5 = intDbId ^ obj9;
			num6 = num4 & num5;
			flag6 = num6 < 0;
			flag7 = intDbId != (nint)obj7;
			bool flag8 = false;
			if (!flag7)
			{
				object obj10 = (??)num3 & 1;
				bool flag9 = obj10 == null;
				flag8 = false;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X21_v5 (Sfs2X.Entities.Room)+60]");
					bool flag10 = (nint)0 < (nint)1;
					obj8 = !flag10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X21_v5 (Sfs2X.Entities.Room)+60]");
					obj9 = -1;
					flag4 = (nint)obj9 < 0;
					flag5 = obj9 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X21_v5 (Sfs2X.Entities.Room)+60]");
					num4 = (int)((nint)0 ^ (nint)1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X21_v5 (Sfs2X.Entities.Room)+60]");
					num5 = 0 ^ obj9;
					num6 = num4 & num5;
					flag6 = num6 < 0;
					flag8 = flag5;
				}
			}
			bool flag11 = (object)gameObject2 == null;
			num7 = (flag8 ? 1 : 0);
			if (!flag11)
			{
				gameObject2.SetActive(flag8);
				gameObject4 = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EA4]");
				object obj11 = (nint)0 & (nint)1;
				if (obj11 != null)
				{
					object obj12 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v41+E4]");
					if ((nint)0 != 0)
					{
						goto IL_06be;
					}
				}
				else
				{
					_ = 1;
					object obj12 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v41+E4]");
					bool flag12 = (nint)0 == 0;
					object obj14 = !flag12;
					if (obj14 != null)
					{
						goto IL_06be;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				bool flag13 = (object)sessionModel3 == null;
				obj7 = 152985600;
				text = null;
				num7 = unchecked((nint)null);
				gameObject2 = gameObject4;
				if (!flag13)
				{
					goto IL_079f;
				}
			}
		}
		goto IL_09dc;
		IL_03a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj16;
		object obj15 = obj16;
		Action action3;
		Action action2 = action3;
		object obj18;
		object obj17 = obj18;
		object obj19;
		obj6 = obj19;
		object obj21;
		object obj20 = obj21;
		bool flag14;
		flag7 = flag14;
		bool flag15;
		flag6 = flag15;
		int num8;
		num6 = num8;
		int num9;
		num5 = num9;
		int num10;
		num4 = num10;
		bool flag16;
		flag5 = flag16;
		bool flag17;
		flag4 = flag17;
		object obj22;
		obj9 = obj22;
		object obj23;
		obj8 = obj23;
		object obj24;
		obj7 = obj24;
		object obj26;
		object obj25 = obj26;
		int? num11;
		num3 = num11;
		string text2;
		text = text2;
		object obj27;
		obj13 = obj27;
		nint num12;
		num7 = num12;
		object obj29;
		object obj28 = obj29;
		Room room3;
		room2 = room3;
		GameObject gameObject5;
		gameObject2 = gameObject5;
		goto IL_046e;
		IL_0094:
		nint num13 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v37 (Il2CppClass<Sfs2X.Entities.Room>)+B8]");
		nint num14 = 0;
		obj5 = num14;
		bool flag18 = num14 == 0;
		object obj30 = !flag18;
		if (obj30 != null)
		{
			goto IL_01a6;
		}
		room2 = room;
		gameObject2 = gameObject;
		goto IL_09dc;
		IL_01a6:
		object obj31 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v25+188]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v25+190]");
		num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ X8_v25+188] (should have been resolved before IL gen)");
		Room room4 = default(Room);
		if (room4 == null)
		{
			return;
		}
		obj13 = typeof(Queue<string>) + 848;
		gameObject2 = panel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v59 (Sfs2X.Entities.Room)+50]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v59 (Sfs2X.Entities.Room)+50]");
		bool flag19 = (nint)0 == 0;
		room2 = room4;
		if (!flag19)
		{
			object obj33 = (nint)0 + (nint)3136;
			text2 = (string)obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v26+10]");
			int? num15 = 0;
			obj26 = (nint)0 + (nint)2200;
			object obj34 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v56+E4]");
			bool flag20 = (nint)0 == 0;
			object obj35 = !flag20;
			obj16 = obj15;
			action3 = action2;
			obj18 = obj17;
			obj19 = obj6;
			obj21 = obj20;
			flag14 = flag7;
			flag15 = flag6;
			num8 = num6;
			num9 = num5;
			num10 = num4;
			flag16 = flag5;
			flag17 = flag4;
			obj22 = obj9;
			obj23 = obj8;
			obj24 = obj7;
			num11 = num15;
			obj27 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v26+10]");
			num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v25+188]");
			obj29 = 0;
			room3 = room4;
			gameObject5 = panel;
			obj25 = obj26;
			num3 = num15;
			text = (string)obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v26+10]");
			num7 = 0;
			room2 = room4;
			if (obj35 == null)
			{
				goto IL_03a7;
			}
		}
		else
		{
			obj25 = (nint)0 + (nint)2200;
			object obj34 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v56+E4]");
			bool flag21 = (nint)0 == 0;
			object obj36 = !flag21;
			num3 = (int?)(object)0;
			if (obj36 == null)
			{
				obj16 = obj15;
				action3 = action2;
				obj18 = obj17;
				obj19 = obj6;
				obj21 = obj20;
				flag14 = flag7;
				flag15 = flag6;
				num8 = num6;
				num9 = num5;
				num10 = num4;
				flag16 = flag5;
				flag17 = flag4;
				obj22 = obj9;
				obj23 = obj8;
				obj24 = obj7;
				obj26 = obj25;
				num11 = (int?)(object)0;
				text2 = text;
				obj27 = obj13;
				num12 = num7;
				obj29 = obj28;
				room3 = room2;
				gameObject5 = gameObject2;
				goto IL_03a7;
			}
		}
		goto IL_046e;
		IL_079f:
		obj20 = typeof(SqlSingle[]) + 2376;
		obj6 = (nint)0 + (nint)648;
		obj17 = "utf-32" + 1728;
		Room currentRoom2 = sessionModel3.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj6);
		text = (string)obj17;
		VariableBinderExtensions.Bind(gameObject4, currentRoom2, (string)obj17, action4);
		gameObject3 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EA4]");
		object obj37 = (nint)0 & (nint)1;
		if (obj37 != null)
		{
			object obj38 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v21+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0884;
			}
		}
		else
		{
			_ = 1;
			object obj38 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v21+E4]");
			bool flag22 = (nint)0 == 0;
			object obj39 = !flag22;
			if (obj39 != null)
			{
				goto IL_0884;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag23 = (object)sessionModel == null;
		object obj40 = !flag23;
		obj15 = 0;
		action2 = action4;
		obj7 = 152985600;
		num7 = unchecked((nint)null);
		room2 = currentRoom2;
		gameObject2 = gameObject3;
		if (obj40 != null)
		{
			goto IL_08da;
		}
		goto IL_09dc;
		IL_09dc:
		throw new NullReferenceException();
		IL_0884:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag24 = (object)sessionModel == null;
		obj15 = 0;
		action2 = action4;
		obj7 = 152985600;
		num7 = unchecked((nint)null);
		room2 = currentRoom2;
		gameObject2 = gameObject3;
		if (!flag24)
		{
			goto IL_08da;
		}
		goto IL_09dc;
		IL_06be:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag25 = (object)sessionModel3 == null;
		object obj41 = !flag25;
		if (obj41 != null)
		{
			goto IL_079f;
		}
		obj7 = 152985600;
		text = null;
		num7 = unchecked((nint)null);
		gameObject2 = gameObject4;
		goto IL_09dc;
	}

	private void UpdateChat()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0130: Expected O, but got I
		//IL_014a: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_005b: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_019c: Expected O, but got I4
		//IL_00ed: Expected O, but got I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0d92: Expected O, but got I
		//IL_027e: Expected O, but got I
		//IL_032f: Expected O, but got I4
		//IL_02ec: Expected O, but got I4
		//IL_0394: Expected O, but got I
		//IL_05f0: Expected O, but got I4
		//IL_05f9: Expected O, but got I4
		//IL_0602: Expected O, but got I4
		//IL_03d5: Expected O, but got I
		//IL_041c: Expected O, but got I4
		//IL_0619: Expected O, but got I4
		//IL_0622: Expected O, but got I4
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_067b: Expected O, but got I4
		//IL_068c: Expected O, but got I4
		//IL_0510: Expected O, but got I4
		//IL_0521: Expected O, but got I4
		//IL_0545: Expected O, but got I
		//IL_06c4: Expected O, but got I4
		//IL_0763: Expected O, but got I4
		//IL_05b3: Expected O, but got I4
		//IL_071d: Expected O, but got I4
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Expected O, but got Unknown
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected O, but got Unknown
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected O, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected O, but got Unknown
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected O, but got Unknown
		//IL_082b: Expected O, but got I4
		//IL_08fb: Expected O, but got I4
		//IL_093d: Expected O, but got I4
		//IL_094d: Expected O, but got I
		//IL_095d: Expected O, but got I
		//IL_0994: Expected O, but got I4
		//IL_0863: Expected O, but got I4
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Expected O, but got Unknown
		//IL_0a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a07: Expected O, but got Unknown
		//IL_0a3c: Expected O, but got I4
		//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b11: Expected O, but got Unknown
		//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8f: Expected O, but got Unknown
		//IL_0aa9: Expected O, but got I4
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected O, but got Unknown
		//IL_0b71: Expected O, but got I4
		//IL_0dd4: Expected O, but got I4
		//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Expected O, but got Unknown
		//IL_0bd5: Expected O, but got I4
		//IL_0cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccc: Expected O, but got Unknown
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c01: Expected O, but got Unknown
		//IL_0d41: Expected O, but got I4
		//IL_0d4a: Expected O, but got I4
		//IL_0c40: Expected I, but got O
		//IL_0c64: Expected O, but got I4
		//IL_0c6d: Expected O, but got I4
		//IL_0ca7: Expected O, but got I4
		object obj = typeof(UnityEngine.IPlayerEditorConnectionNative) & 1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EA4]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0080;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EA4]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0080;
			}
		}
		_ = 1;
		object obj7 = (nint)0 + (nint)2200;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v132+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj2 = obj4;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00c9;
		}
		goto IL_01ba;
		IL_07b2:
		int? num;
		object obj11 = (object?)num >> 32;
		int intDbId;
		object obj12 = intDbId - obj11;
		bool flag4 = obj12 == null;
		object obj13 = flag4 & (??)num;
		bool flag5;
		object obj14 = obj13 | flag5;
		bool flag6;
		object obj15 = flag6 | obj14;
		object obj16 = obj15 & 1;
		bool flag7 = obj16 == null;
		object obj17 = !flag7;
		InputFieldTMProUGUI inputFieldTMProUGUI;
		bool flag9;
		if (obj17 == null)
		{
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X0_v70+E4]");
			bool flag8 = (nint)0 == 0;
			object obj19 = !flag8;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			if (!SFSKammelnaUserExtensions.Can(localUser, UserPermission.AccessHiddenTournaments))
			{
				inputFieldTMProUGUI = inputField;
				flag9 = false;
				goto IL_092e;
			}
		}
		bool canSend = ChatHandler.CanSend;
		inputFieldTMProUGUI = inputField;
		bool flag10 = (object)inputField == null;
		object obj20 = !flag10;
		flag9 = canSend;
		if (obj20 != null)
		{
			goto IL_092e;
		}
		goto IL_0d73;
		IL_0d12:
		InputFieldTMProUGUI inputFieldTMProUGUI2;
		inputFieldTMProUGUI2.Interactable = flag9;
		return;
		IL_0461:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser2);
		object obj21 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v17+E4]");
		bool flag13;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v9+30]");
			bool flag11 = SfsTournamentConnector.IsParticipating(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v9+60]");
			bool flag12 = (nint)0 != 1;
			flag6 = flag11;
			object obj23 = 0;
			flag13 = flag11;
			object obj24 = 0;
			if (!flag12)
			{
				goto IL_052f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v9+30]");
			bool flag14 = SfsTournamentConnector.IsParticipating(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v9+60]");
			bool flag15 = (nint)0 == 1;
			flag6 = flag14;
			object obj23 = 0;
			flag13 = flag14;
			object obj24 = 0;
			if (flag15)
			{
				goto IL_052f;
			}
		}
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X0_v79+E4]");
		bool flag16 = (nint)0 == 0;
		object obj26 = !flag16;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		User localUser3 = sessionModel3.LocalUser;
		flag5 = SFSKammelnaUserExtensions.IsSubscribed(localUser3);
		object obj27 = 0;
		flag6 = flag13;
		bool flag17 = true;
		goto IL_07b2;
		IL_0080:
		obj7 = (nint)0 + (nint)2200;
		obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v132+E4]");
		bool flag18 = (nint)0 == 0;
		obj10 = obj7;
		obj4 = obj2;
		if (!flag18)
		{
			goto IL_00c9;
		}
		goto IL_01ba;
		IL_01ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj7 = obj10;
		obj2 = obj4;
		goto IL_01e8;
		IL_00c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel4 = default(SessionModel);
		bool flag19 = (object)sessionModel4 == null;
		object obj28 = !flag19;
		if (obj28 != null)
		{
			goto IL_01e8;
		}
		goto IL_0d73;
		IL_01e8:
		Room currentRoom = sessionModel4.CurrentRoom;
		if (!SFSKammelnaRoomExtensions.IsTournamentHub(currentRoom))
		{
			return;
		}
		object obj29 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj30 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v7+B8]");
		object obj31 = 0;
		object obj32 = obj31;
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v446 @ X8_v9+188] (should have been resolved before IL gen)");
		object obj34 = default(object);
		if (obj34 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EA4]");
		object obj35 = (nint)0 & (nint)1;
		if (obj35 != null)
		{
			object obj36 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v114+E4]");
			if ((nint)0 != 0)
			{
				goto IL_02c8;
			}
		}
		else
		{
			_ = 1;
			object obj36 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v114+E4]");
			bool flag20 = (nint)0 == 0;
			object obj37 = !flag20;
			if (obj37 != null)
			{
				goto IL_02c8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0356;
		IL_078a:
		SessionModel sessionModel5 = default(SessionModel);
		Room currentRoom2 = sessionModel5.CurrentRoom;
		flag5 = SFSKammelnaRoomExtensions.IsTournamentWatchersChatEnabled(currentRoom2);
		flag17 = false;
		goto IL_07b2;
		IL_0de2:
		object[] array = default(object[]);
		if (array.Length != 0)
		{
			goto IL_0cbe;
		}
		goto IL_0d65;
		IL_092e:
		object obj38 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v26+90]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v27+B8]");
		object obj40 = 0;
		inputFieldTMProUGUI.Text = (string)obj40;
		object obj41 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X0_v23+E4]");
		bool flag21 = (nint)0 == 0;
		object obj42 = !flag21;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel6 = default(SessionModel);
		User localUser4 = sessionModel6.LocalUser;
		DateTime? mutedUntil = SFSKammelnaUserExtensions.GetMutedUntil(localUser4);
		string muteReason;
		string text2;
		if (flag9)
		{
			object placeholder = "WhiteSmoke" + 2184;
			inputField.SetPlaceholder((string)placeholder);
			inputFieldTMProUGUI2 = inputField;
			bool flag22 = (object)inputField == null;
			object obj43 = !flag22;
			if (obj43 != null)
			{
				goto IL_0d12;
			}
		}
		else
		{
			if (!ChatHandler.CanSend)
			{
				muteReason = ChatHandler.MuteReason;
				object obj44 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj45 = (??)mutedUntil & 1;
				bool flag23 = obj45 == null;
				IFormatProvider formatProvider = null;
				if (!flag23)
				{
					object obj46 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
					object obj47 = obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v48+E4]");
					bool flag24 = (nint)0 == 0;
					object obj48 = !flag24;
					if (obj48 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					object obj49 = typeof(DataRelation) + 712;
					object obj50 = obj49;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X0_v52+E4]");
					bool flag25 = (nint)0 == 0;
					object obj51 = !flag25;
					if (obj51 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj52 = "utf-32" + 3032;
					DateTime dateTime = default(DateTime);
					string text = dateTime.ToString((string)obj52, invariantCulture);
					object obj54;
					if (text == null)
					{
						bool flag26 = array.Length == 0;
						object obj53 = !flag26;
						obj54 = 0;
						formatProvider = invariantCulture;
						text2 = null;
						if (obj53 != null)
						{
							goto IL_0cbe;
						}
						goto IL_0d65;
					}
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					object obj55 = default(object);
					bool flag27 = obj55 == null;
					object obj56 = !flag27;
					obj54 = 0;
					formatProvider = invariantCulture;
					text2 = text;
					if (obj56 != null)
					{
						goto IL_0de2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
					OutOfMemoryException ex = new OutOfMemoryException();
					obj54 = 0;
					formatProvider = invariantCulture;
				}
				text2 = null;
				goto IL_0de2;
			}
			object placeholder2 = "SubscribeGroup request Error" + 24;
			object obj57 = "Cannot populate JSON object onto type '{0}'." + 2328;
			bool flag28 = !flag6;
			object obj58 = !flag28;
			object obj59 = ~obj58;
			if (obj59 != null)
			{
				placeholder2 = obj57;
			}
			inputField.SetPlaceholder((string)placeholder2);
			inputFieldTMProUGUI2 = inputField;
			bool flag29 = (object)inputField == null;
			object obj60 = !flag29;
			if (obj60 != null)
			{
				goto IL_0d12;
			}
		}
		goto IL_0d73;
		IL_052f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EA4]");
		object obj61 = (nint)0 & (nint)1;
		if (obj61 != null)
		{
			object obj62 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v94+E4]");
			if ((nint)0 != 0)
			{
				goto IL_058f;
			}
		}
		else
		{
			_ = 1;
			object obj62 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v94+E4]");
			bool flag30 = (nint)0 == 0;
			object obj63 = !flag30;
			if (obj63 != null)
			{
				goto IL_058f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_078a;
		IL_0d73:
		throw new NullReferenceException();
		IL_02c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel7 = default(SessionModel);
		bool flag31 = (object)sessionModel7 == null;
		object obj64 = !flag31;
		if (obj64 != null)
		{
			goto IL_0356;
		}
		goto IL_0d73;
		IL_0356:
		Room currentRoom3 = sessionModel7.CurrentRoom;
		bool flag32 = SFSKammelnaRoomExtensions.IsTournamentWatchersChatEnabled(currentRoom3);
		enableChatToggle.SetIsOnWithoutNotify(flag32);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v9+50]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v9+50]");
		object obj67;
		int? num5;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v12+10]");
			int num3 = 0;
			object obj66 = (nint)0 + (nint)3136;
			obj67 = obj66;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v12+10]");
			int? num4 = 0;
			object obj68 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X0_v110+E4]");
			bool flag33 = (nint)0 == 0;
			object obj69 = !flag33;
			num5 = num4;
			num = num4;
			obj27 = obj66;
			if (obj69 == null)
			{
				goto IL_0442;
			}
		}
		else
		{
			object obj68 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X0_v110+E4]");
			bool flag34 = (nint)0 == 0;
			object obj70 = !flag34;
			num = (int?)(object)0;
			obj27 = 0;
			if (obj70 == null)
			{
				num5 = (int?)(object)0;
				obj67 = 0;
				int num3 = (flag32 ? 1 : 0);
				goto IL_0442;
			}
		}
		goto IL_0461;
		IL_0d65:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0d73;
		IL_058f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag35 = (object)sessionModel5 == null;
		object obj71 = !flag35;
		if (obj71 != null)
		{
			goto IL_078a;
		}
		goto IL_0d73;
		IL_0cbe:
		object obj72 = array + 32;
		obj72 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		LocalizableText placeholder3 = TextMeshProExtensions.LocalizeWith(muteReason, array);
		inputField.SetPlaceholder(placeholder3);
		inputFieldTMProUGUI2 = inputField;
		goto IL_0d12;
		IL_0442:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num = num5;
		obj27 = obj67;
		goto IL_0461;
	}

	private void EnableChatChanged(bool enable)
	{
		SFS.SendEnableTournamentWatchersChat(enable);
	}

	private void OnPinMessageUpdated()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_01cb: Expected O, but got I4
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_0291: Expected O, but got I
		//IL_029f: Expected I, but got O
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E0B]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj3 = obj5;
		goto IL_0137;
		IL_0137:
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		string value = SFSKammelnaRoomExtensions.GetPinMessage(currentRoom);
		if (string.IsNullOrEmpty(value))
		{
			pinMessage.SetActive(value: false);
			return;
		}
		pinMessage.SetActive(value: true);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom2 = sessionModel2.CurrentRoom;
		string text = SFSKammelnaRoomExtensions.GetPinMessage(currentRoom2);
		TextMeshProExtensions.FixArabic(this.text, text);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		Room currentRoom3 = sessionModel3.CurrentRoom;
		string text2 = SFSKammelnaRoomExtensions.GetPinMessage(currentRoom3);
		TextMeshProExtensions.FixArabic(showFullMessage, text2);
		object obj9 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)608;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj10);
		object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v22+E4]");
		if ((nint)0 != 0)
		{
			CoroutineDummy.WaitForEndOfFrame(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CoroutineDummy.WaitForEndOfFrame(action);
		return;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0137;
	}

	public void ShowPinMessagePopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b1: Expected O, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00d8: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)640;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "Picking audio files is not supported on iOS" + 16;
		object msgBody = (nint)0 + (nint)2000;
		object primaryText = "SERVICE_DISABLED" + 2720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		IPopupWindowBuilderInput inputData = PopupInput.From(InputField.ContentType.Standard, action);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowPrompt((string)msgTitle, (string)msgBody, inputData, (string)primaryText);
	}

	private void PinMessage(string message)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ca: Expected O, but got I4
		//IL_00d3: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E0D]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			SFS.SendPinMessage(message);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = 0;
			if (!flag)
			{
				goto IL_0086;
			}
		}
		else
		{
			_ = 1;
			SFS.SendPinMessage(message);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = 0;
			if (obj5 != null)
			{
				goto IL_0086;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.DismissMessage();
		return;
		IL_0086:
		PopupWindow.DismissMessage();
	}

	public void HideFullMessage()
	{
		pinMessagePanel.SlideOut();
		blocker.SetActive(value: false);
	}

	public void ShowFullMessage()
	{
		pinMessagePanel.SlideIn();
		blocker.SetActive(value: true);
	}

	private void <OnEnable>b__14_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Coroutine coroutine = UIExtensions.WaitForSeconds(this, 0.1f, action);
	}

	private void <OnPinMessageUpdated>b__18_0()
	{
		GameObject gameObject = readMore.gameObject;
		TextMeshProUGUI textMeshProUGUI = text;
		gameObject.SetActive(((TMP_Text)textMeshProUGUI).m_isTextTruncated);
	}
}
