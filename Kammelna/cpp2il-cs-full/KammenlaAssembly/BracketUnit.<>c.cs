using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class BracketUnit : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<PlayerInfo, bool> <>9__53_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <ShowGameState>b__53_0(PlayerInfo info)
		{
			//IL_003d: Expected I4, but got O
			if (info != null)
			{
				return info.IsHuman;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private List<AvatarInitializer> slots;

	private DiscreteProgressIndicator team1Score;

	private DiscreteProgressIndicator team2Score;

	private TextMeshProUGUI team1Points;

	private TextMeshProUGUI team2Points;

	private DiscreteProgressIndicator team1P1Score;

	private DiscreteProgressIndicator team1P2Score;

	private DiscreteProgressIndicator team2P1Score;

	private DiscreteProgressIndicator team2P2Score;

	private TextMeshProUGUI watchersCount;

	private TextMeshProUGUI roomName;

	private ObjectToggler team1PointsBackground;

	private ObjectToggler team2PointsBackground;

	private Button watchButton;

	private Button joinButton;

	private GameObject[] watchersObjects;

	private GameObject[] waitingObjects;

	private GameObject[] finishedObjects;

	private GameObject[] startingSoonObjects;

	private GameObject[] cancelledObjects;

	private GameObject[] watchButtonObjects;

	private GameObject[] joinButtonObjects;

	private Graphic[] teamGroupGraphics1;

	private Graphic[] teamGroupGraphics2;

	private GameObject Team1Area;

	private GameObject Team2Area;

	private Room _room;

	private MatchData _match;

	private TournamentData _tournament;

	private GameObject[] clearObjects;

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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CDD]");
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

	private string RoomName
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_0063: Expected O, but got I4
			if (_tournament != null)
			{
				object obj = typeof(List<Tween>) + 2432;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				if (_match != null)
				{
					object format = "SubscribeGroup request Error" + 1800;
					object obj2 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object arg = default(object);
					object arg2 = default(object);
					return string.Format((string)format, arg, arg2);
				}
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private void assignTeamObjects()
	{
		//IL_0011: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E33B8C");
		object obj2 = this + 208;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E33B8C");
		object obj4 = this + 216;
		object obj5 = default(object);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Awake()
	{
		//IL_037c: Expected O, but got I
		//IL_0385: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0044: Expected I, but got O
		//IL_0052: Expected I, but got O
		//IL_0074: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_00fb: Expected I, but got O
		//IL_0109: Expected I, but got O
		//IL_012b: Expected O, but got I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_015e: Expected O, but got I
		//IL_016a: Expected O, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_018a: Expected O, but got I
		//IL_01b9: Expected I, but got O
		//IL_01df: Expected I, but got O
		//IL_0204: Expected I, but got O
		//IL_0212: Expected I, but got O
		//IL_023a: Expected O, but got I4
		//IL_0262: Expected O, but got I
		//IL_026e: Expected O, but got I
		//IL_028b: Expected O, but got I4
		//IL_02bd: Expected O, but got I4
		//IL_02c6: Expected O, but got I4
		Button button = watchButton;
		bool flag = (object)watchButton == null;
		IntPtr intPtr = default(IntPtr);
		object obj = (nint)intPtr;
		UnityEvent unityEvent = (UnityEvent)152985600;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag)
		{
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
			object obj3 = (nint)0 + (nint)840;
			unityEvent = button.m_OnClick;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num = (nint)obj3;
			UnityAction unityAction = default(UnityAction);
			unityAction..ctor(this, (IntPtr)obj3);
			bool flag2 = button.m_OnClick == null;
			object obj4 = 0;
			obj = this;
			if (!flag2)
			{
				button.m_OnClick.AddListener(unityAction);
				Button button2 = joinButton;
				bool flag3 = (object)joinButton == null;
				obj4 = 0;
				obj = unityAction;
				num = 0;
				if (!flag3)
				{
					unityEvent = button2.m_OnClick;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					num = (nint)obj3;
					UnityAction unityAction2 = default(UnityAction);
					unityAction2..ctor(this, (IntPtr)obj3);
					bool flag4 = button2.m_OnClick == null;
					obj4 = 0;
					obj = this;
					if (!flag4)
					{
						object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
						object obj6 = (nint)0 + (nint)824;
						object obj7 = (nint)0 + (nint)832;
						object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
						object obj9 = (nint)0 + (nint)800;
						button2.m_OnClick.AddListener(unityAction2);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Action<object> action = default(Action<object>);
						action..ctor((object)this, (IntPtr)obj6);
						SFS.OnRoomCreated += action;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Action<object> action2 = default(Action<object>);
						action2..ctor((object)this, (IntPtr)obj7);
						SFS.OnRoomRemoved += action2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						num = (nint)obj9;
						Action<object> action3 = default(Action<object>);
						action3..ctor((object)this, (IntPtr)obj9);
						SFS.OnRoomGroupSubscribe += action3;
						bool flag5 = slots == null;
						obj4 = 0;
						obj = null;
						unityEvent = (UnityEvent)(object)action3;
						if (!flag5)
						{
							object obj10 = (nint)0 + (nint)3376;
							unityEvent = (UnityEvent)((nint)0 + (nint)3368);
							List<object>.Enumerator enumerator = ((List<object>)(object)slots).GetEnumerator();
							obj = obj10;
							if (!enumerator2.MoveNext())
							{
								enumerator2.Dispose();
								return;
							}
							object obj11 = 0;
							NullReferenceException ex = new NullReferenceException();
							object obj12 = 0;
							obj4 = 0;
						}
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag6 = (nint)obj != 1;
		NullReferenceException ex3 = ex2;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj = unityEvent;
			enumerator2.Dispose();
			object obj13 = default(object);
			if (obj13 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj12 = obj13;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22390FC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004c: Expected O, but got I
		//IL_00bb: Expected I, but got O
		//IL_0069: Expected I, but got O
		//IL_0094: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)824;
		object obj3 = (nint)0 + (nint)832;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj5 = (nint)0 + (nint)800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnRoomCreated -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj3);
		SFS.OnRoomRemoved -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj5);
		SFS.OnRoomGroupSubscribe -= action3;
	}

	private void RoomAdded(Room room)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0040: Expected I, but got O
		//IL_0050: Expected O, but got I
		//IL_008b: Expected O, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		if (_tournament == null || _match == null)
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00cc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X10_v6-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00cc;
		}
		object obj4 = obj3 + 1;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_0158;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0158;
		IL_0158:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v196 @ X0_v4] (should have been resolved before IL gen)");
		string text = RoomName;
		string text2 = default(string);
		if (text2 == text)
		{
			BindRoom(room);
		}
	}

	private void BindRoom(Room room)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003b: Expected O, but got I
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_0076: Expected I, but got O
		//IL_00b7: Expected I, but got O
		//IL_00f6: Expected O, but got I
		//IL_0104: Expected I, but got O
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0152: Expected O, but got I
		//IL_0160: Expected I, but got O
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_01ae: Expected O, but got I
		//IL_01bc: Expected I, but got O
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_020a: Expected O, but got I
		//IL_0218: Expected I, but got O
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0254: Expected O, but got I4
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_027e: Expected O, but got I
		//IL_041f: Expected O, but got I
		//IL_0449: Expected O, but got I4
		//IL_02a7: Expected O, but got I
		//IL_02f7: Expected O, but got I
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_0312: Expected O, but got I
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_035a: Expected I, but got O
		//IL_0492: Expected O, but got I4
		//IL_039b: Expected I, but got O
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)744;
		object varName = "utf-32" + 1104;
		object obj3 = (nint)0 + (nint)752;
		object varName2 = "utf-32" + 1112;
		object obj4 = this + 240;
		Room room2 = default(Room);
		obj4 = room2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		VariableBinderExtensions.Bind(go2, (Room)obj4, (string)varName, action);
		GameObject go3 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		VariableBinderExtensions.Bind(go3, (Room)obj4, (string)varName2, action2);
		GameObject go4 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = (nint)0 + (nint)760;
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj5);
		object varName3 = "tournament_participate_warning_body_with_tickets_warning_daily" + 744;
		VariableBinderExtensions.Bind(go4, (Room)obj4, (string)varName3, action3);
		GameObject go5 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = (nint)0 + (nint)768;
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj6);
		object varName4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 752;
		VariableBinderExtensions.Bind(go5, (Room)obj4, (string)varName4, action4);
		GameObject go6 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = (nint)0 + (nint)776;
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj7);
		object varName5 = "tournament_participate_warning_body_with_tickets_warning_daily" + 768;
		VariableBinderExtensions.Bind(go6, (Room)obj4, (string)varName5, action5);
		GameObject go7 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)784;
		Action action6 = default(Action);
		action6..ctor(this, (IntPtr)obj8);
		object varName6 = "tournament_participate_warning_body_with_tickets_warning_daily" + 776;
		VariableBinderExtensions.Bind(go7, (Room)obj4, (string)varName6, action6);
		GameObject go8 = base.gameObject;
		object obj9 = 152985600;
		object obj10 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CDD]");
		object obj11 = (nint)0 & (nint)1;
		if (obj11 != null)
		{
			object obj12 = (nint)0 + (nint)2200;
			object obj13 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v40+E4]");
			bool flag = (nint)0 == 0;
			object obj14 = obj12;
			if (!flag)
			{
				goto IL_02dc;
			}
		}
		else
		{
			_ = 1;
			object obj12 = (nint)0 + (nint)2200;
			object obj13 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v40+E4]");
			bool flag2 = (nint)0 == 0;
			object obj15 = !flag2;
			object obj14 = obj12;
			if (obj15 != null)
			{
				goto IL_02dc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_02eb;
		IL_02dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_02eb;
		IL_02eb:
		object obj17 = (nint)0 + (nint)816;
		object varName7 = "java.io.FileOutputStream" + 3672;
		object obj18 = (nint)0 + (nint)808;
		object varName8 = "utf-32" + 1720;
		object defaultValue = ", stale={0}" + 120;
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action7 = default(Action);
		action7..ctor(this, (IntPtr)obj17);
		VariableBinderExtensions.Bind(go8, currentRoom, (string)varName7, action7);
		GameObject go9 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action8 = default(Action);
		action8..ctor(this, (IntPtr)obj18);
		VariableBinderExtensions.Bind(go9, _room, (string)varName8, action8);
		object varName9 = "startPosition" + 2144;
		VariableBinderExtensions.Bind(team1Points, _room, (string)varName9, (string)defaultValue);
		object varName10 = "startPosition" + 2160;
		VariableBinderExtensions.Bind(team2Points, _room, (string)varName10, (string)defaultValue);
	}

	private void RoomRemoved(Room room)
	{
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0186: Expected O, but got I
		//IL_022e: Expected O, but got I
		//IL_0258: Expected O, but got I4
		//IL_0208: Expected O, but got I4
		//IL_01af: Expected O, but got I
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02d0: Expected O, but got I
		//IL_02de: Expected I, but got O
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_0327: Expected O, but got I
		//IL_0404: Expected O, but got I4
		//IL_03aa: Expected I, but got O
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_0445: Expected O, but got I4
		object obj = this + 240;
		if (obj == null)
		{
			return;
		}
		object obj2 = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X10_v7-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj5 = obj4 + 1;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_04a6;
		IL_01e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag = (object)sessionModel == null;
		object obj8 = !flag;
		if (obj8 != null)
		{
			goto IL_0294;
		}
		goto IL_0453;
		IL_0371:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0380;
		IL_0380:
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom = sessionModel2.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		object obj9;
		action..ctor(this, (IntPtr)obj9);
		object varName = "startPosition" + 104;
		GameObject go;
		VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
		return;
		IL_0294:
		Room currentRoom2 = sessionModel.CurrentRoom;
		object obj10 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj9 = (nint)0 + (nint)816;
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj9);
		object varName2 = "java.io.FileOutputStream" + 3672;
		GameObject go2;
		VariableBinderExtensions.Bind(go2, currentRoom2, (string)varName2, action2);
		go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CDD]");
		object obj11 = (nint)0 & (nint)1;
		object obj13;
		if (obj11 != null)
		{
			object obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v29+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0371;
			}
		}
		else
		{
			_ = 1;
			object obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v29+E4]");
			bool flag2 = (nint)0 == 0;
			object obj14 = !flag2;
			if (obj14 != null)
			{
				goto IL_0371;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel2 == null;
		object obj15 = !flag3;
		if (obj15 != null)
		{
			goto IL_0380;
		}
		goto IL_0453;
		IL_0453:
		throw new NullReferenceException();
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_04a6;
		IL_04a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v306 @ X0_v5] (should have been resolved before IL gen)");
		string text = RoomName;
		string text2 = default(string);
		if (!(text2 == text))
		{
			return;
		}
		_room = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go3 = base.gameObject;
		VariableBinderExtensions.Unbind(go3);
		GameObject go4 = team1Points.gameObject;
		VariableBinderExtensions.Unbind(go4);
		GameObject go5 = team2Points.gameObject;
		VariableBinderExtensions.Unbind(go5);
		go2 = base.gameObject;
		obj13 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CDD]");
		object obj16 = (nint)0 & (nint)1;
		object obj19;
		object obj17;
		if (obj16 != null)
		{
			obj17 = (nint)0 + (nint)2200;
			object obj18 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v49+E4]");
			bool flag4 = (nint)0 == 0;
			obj19 = obj17;
			if (!flag4)
			{
				goto IL_01e4;
			}
		}
		else
		{
			_ = 1;
			obj17 = (nint)0 + (nint)2200;
			object obj18 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v49+E4]");
			bool flag5 = (nint)0 == 0;
			object obj20 = !flag5;
			obj19 = obj17;
			if (obj20 != null)
			{
				goto IL_01e4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj17 = obj19;
		goto IL_0294;
	}

	public void Initialize(MatchData match)
	{
		//IL_08ee: Expected O, but got I4
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_0914: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_00c1: Expected O, but got I
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_015f: Expected O, but got I4
		//IL_0175: Expected O, but got I
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01ec: Expected O, but got I4
		//IL_0202: Expected O, but got I
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0279: Expected O, but got I4
		//IL_028f: Expected O, but got I
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_0313: Expected O, but got I
		//IL_0321: Expected I, but got O
		//IL_032d: Expected O, but got I
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_058c: Expected O, but got I4
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected O, but got Unknown
		//IL_05b6: Expected O, but got I
		//IL_065e: Expected O, but got I
		//IL_0688: Expected O, but got I4
		//IL_0638: Expected O, but got I4
		//IL_05df: Expected O, but got I
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected O, but got Unknown
		//IL_06fc: Expected O, but got I
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected O, but got Unknown
		//IL_0735: Expected I, but got O
		//IL_076f: Expected O, but got I
		//IL_086e: Expected O, but got I4
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Expected O, but got Unknown
		//IL_08af: Expected O, but got I4
		//IL_0819: Expected I, but got O
		bool flag = clearObjects == null;
		object obj = !flag;
		if (obj != null)
		{
			goto IL_0375;
		}
		object obj2 = typeof(TypeConverter<ushort, char>) + 1480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		if (enumerable == null)
		{
			goto IL_08bd;
		}
		object obj3 = enumerable + 32;
		obj3 = watchersObjects;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = enumerable + 40;
		obj4 = waitingObjects;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X22_v11-10]");
		bool flag2 = (nint)0 < (nint)2;
		object obj5 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X22_v11-10]");
		object obj6 = -2;
		bool flag3 = obj6 == null;
		object obj7 = ~obj5;
		object obj8 = obj7 | flag3;
		if (obj8 == null)
		{
			object obj9 = enumerable + 48;
			obj9 = finishedObjects;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj10 = enumerable + 56;
			obj10 = startingSoonObjects;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X22_v15-20]");
			bool flag4 = (nint)0 < (nint)4;
			object obj11 = !flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X22_v15-20]");
			object obj12 = -4;
			bool flag5 = obj12 == null;
			object obj13 = ~obj11;
			object obj14 = obj13 | flag5;
			if (obj14 == null)
			{
				object obj15 = enumerable + 64;
				obj15 = cancelledObjects;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X22_v17-28]");
				bool flag6 = (nint)0 < (nint)5;
				object obj16 = !flag6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X22_v17-28]");
				object obj17 = -5;
				bool flag7 = obj17 == null;
				object obj18 = ~obj16;
				object obj19 = obj18 | flag7;
				if (obj19 == null)
				{
					object obj20 = enumerable + 72;
					obj20 = watchButtonObjects;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X22_v19-30]");
					bool flag8 = (nint)0 < (nint)6;
					object obj21 = !flag8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X22_v19-30]");
					object obj22 = -6;
					bool flag9 = obj22 == null;
					object obj23 = ~obj21;
					object obj24 = obj23 | flag9;
					if (obj24 == null)
					{
						object obj25 = enumerable + 80;
						obj25 = joinButtonObjects;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj26 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3976;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj27 = (nint)0 + (nint)3240;
						Func<object, object> func = default(Func<object, object>);
						func..ctor((object)null, (IntPtr)obj27);
						object obj28 = (nint)0 + (nint)296;
						IEnumerable<object> source = Enumerable.SelectMany(enumerable, (Func<object, IEnumerable<object>>)func);
						object[] array = Enumerable.ToArray(source);
						clearObjects = (GameObject[])array;
						object obj29 = this + 264;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						goto IL_0375;
					}
				}
			}
		}
		goto IL_08cb;
		IL_06dc:
		object obj30 = typeof(SqlSingle[]) + 2376;
		object obj31 = (nint)0 + (nint)816;
		object varName = "java.io.FileOutputStream" + 3672;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj31);
		GameObject go;
		VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CDD]");
		object obj32 = (nint)0 & (nint)1;
		object obj34;
		if (obj32 != null)
		{
			object obj33 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v38+E4]");
			if ((nint)0 != 0)
			{
				goto IL_07b9;
			}
		}
		else
		{
			_ = 1;
			object obj33 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v38+E4]");
			bool flag10 = (nint)0 == 0;
			object obj35 = !flag10;
			if (obj35 != null)
			{
				goto IL_07b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		bool flag11 = (object)sessionModel2 == null;
		object obj36 = !flag11;
		if (obj36 != null)
		{
			goto IL_07e0;
		}
		goto IL_08bd;
		IL_08cb:
		throw new IndexOutOfRangeException();
		IL_07b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel2 != null)
		{
			goto IL_07e0;
		}
		goto IL_08bd;
		IL_07e0:
		object varName2 = "startPosition" + 104;
		Room currentRoom2 = sessionModel2.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj31);
		VariableBinderExtensions.Bind(go2, currentRoom2, (string)varName2, action2);
		FindRoom((string)(object)currentRoom2);
		return;
		IL_08bd:
		NullReferenceException ex = new NullReferenceException();
		goto IL_08cb;
		IL_0614:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag12 = (object)sessionModel == null;
		object obj37 = !flag12;
		if (obj37 != null)
		{
			goto IL_06dc;
		}
		goto IL_08bd;
		IL_0375:
		object obj38 = this + 248;
		obj38 = match;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj39 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj40 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v9+B8]");
		object obj41 = 0;
		object obj42 = obj41;
		if (obj41 != null)
		{
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v199 @ X8_v11+188] (should have been resolved before IL gen)");
			TournamentData tournamentData = default(TournamentData);
			if (tournamentData == null)
			{
				return;
			}
			_tournament = tournamentData;
			object obj44 = this + 256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			GameObject go3 = base.gameObject;
			VariableBinderExtensions.Unbind(go3);
			if ((object)team1Points != null)
			{
				GameObject go4 = team1Points.gameObject;
				VariableBinderExtensions.Unbind(go4);
				if ((object)team2Points != null)
				{
					GameObject go5 = team2Points.gameObject;
					VariableBinderExtensions.Unbind(go5);
					if ((object)team1P1Score != null)
					{
						GameObject go6 = team1P1Score.gameObject;
						VariableBinderExtensions.Unbind(go6);
						if ((object)team1P2Score != null)
						{
							GameObject go7 = team1P2Score.gameObject;
							VariableBinderExtensions.Unbind(go7);
							if ((object)team2P1Score != null)
							{
								GameObject go8 = team2P1Score.gameObject;
								VariableBinderExtensions.Unbind(go8);
								if ((object)team2P2Score != null)
								{
									GameObject go9 = team2P2Score.gameObject;
									VariableBinderExtensions.Unbind(go9);
									go = base.gameObject;
									object obj45 = 152985600;
									obj34 = typeof(Queue<string>) + 848;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CDD]");
									object obj46 = (nint)0 & (nint)1;
									object obj49;
									object obj47;
									if (obj46 != null)
									{
										obj47 = (nint)0 + (nint)2200;
										object obj48 = obj34;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v59+E4]");
										bool flag13 = (nint)0 == 0;
										obj49 = obj47;
										if (!flag13)
										{
											goto IL_0614;
										}
									}
									else
									{
										_ = 1;
										obj47 = (nint)0 + (nint)2200;
										object obj48 = obj34;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v59+E4]");
										bool flag14 = (nint)0 == 0;
										object obj50 = !flag14;
										obj49 = obj47;
										if (obj50 != null)
										{
											goto IL_0614;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
									bool flag15 = (object)sessionModel == null;
									obj47 = obj49;
									if (!flag15)
									{
										goto IL_06dc;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_08bd;
	}

	private void FindRoom(string _ = null)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_005c: Expected O, but got I
		//IL_006a: Expected I, but got O
		if (_tournament != null && _match != null)
		{
			IEnumerable<Room> tournamentMatchesRoomsList = SFS.TournamentMatchesRoomsList;
			object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = (nint)0 + (nint)792;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)this, (IntPtr)obj2);
			object obj3 = Enumerable.FirstOrDefault(tournamentMatchesRoomsList, func);
			if (obj3 != null)
			{
				BindRoom((Room)obj3);
			}
		}
	}

	private void Populate()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CDD]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
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
		goto IL_0133;
		IL_0133:
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		MatchData match = _match;
		MatchData tournamentMatch = SFSKammelnaRoomExtensions.GetTournamentMatch(currentRoom, match.<ID>k__BackingField);
		MatchData match2 = _match;
		if (tournamentMatch != null && tournamentMatch.<ID>k__BackingField == match2.<ID>k__BackingField)
		{
			object obj8 = match2 + 24;
			obj8 = tournamentMatch.<Players>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = tournamentMatch.<team1Score>k__BackingField;
			_ = tournamentMatch.<team1Player1Points>k__BackingField;
			_ = tournamentMatch.<State>k__BackingField;
		}
		ShowInfo();
		ShowGameState();
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	private void WatchClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0041: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
		object obj3 = 0;
		((TournamentViewConnector)obj3).ClickMatch(_match);
	}

	private unsafe void ShowInfo()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected I4, but got Unknown
		//IL_017a: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected I4, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_01ce: Expected O, but got I
		//IL_020d: Expected O, but got I4
		//IL_0273: Expected O, but got I
		//IL_012f: Expected O, but got I4
		//IL_0145: Expected O, but got I
		//IL_06a4: Expected I4, but got O
		//IL_06cb: Expected O, but got I4
		//IL_02cb: Expected I4, but got O
		//IL_0303: Expected O, but got I
		//IL_030f: Expected O, but got I
		//IL_036e: Expected I4, but got O
		//IL_071d: Expected I4, but got O
		//IL_1823: Expected O, but got I
		//IL_039d: Expected O, but got I4
		//IL_03b2: Expected O, but got I
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected I4, but got Unknown
		//IL_07aa: Expected O, but got I4
		//IL_07cb: Expected O, but got I4
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected O, but got Unknown
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected I4, but got Unknown
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected I4, but got Unknown
		//IL_049c: Expected I4, but got O
		//IL_04b9: Expected I4, but got O
		//IL_04d2: Expected O, but got I4
		//IL_08f6: Expected O, but got I4
		//IL_0507: Expected O, but got I4
		//IL_0525: Expected I4, but got O
		//IL_053a: Expected O, but got I
		//IL_09c2: Expected I4, but got O
		//IL_09e4: Expected O, but got I4
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0941: Expected I4, but got Unknown
		//IL_095a: Expected O, but got I4
		//IL_097a: Expected O, but got I4
		//IL_0983: Expected O, but got I4
		//IL_0a02: Expected O, but got I
		//IL_059f: Expected I4, but got O
		//IL_05bb: Expected O, but got I4
		//IL_062f: Expected I4, but got O
		//IL_0b00: Expected I4, but got O
		//IL_0b2a: Expected O, but got I4
		//IL_09a2: Expected O, but got I4
		//IL_09b3: Expected O, but got I4
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7f: Expected I4, but got Unknown
		//IL_0a98: Expected O, but got I4
		//IL_0ab8: Expected O, but got I4
		//IL_0ac1: Expected O, but got I4
		//IL_0b48: Expected O, but got I
		//IL_0c46: Expected I4, but got O
		//IL_0c70: Expected O, but got I4
		//IL_0ae0: Expected O, but got I4
		//IL_0af1: Expected O, but got I4
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc5: Expected I4, but got Unknown
		//IL_0bde: Expected O, but got I4
		//IL_0bfe: Expected O, but got I4
		//IL_0c07: Expected O, but got I4
		//IL_0c8e: Expected O, but got I
		//IL_0d8c: Expected I4, but got O
		//IL_0db6: Expected O, but got I4
		//IL_0c26: Expected O, but got I4
		//IL_0c37: Expected O, but got I4
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0b: Expected I4, but got Unknown
		//IL_0d24: Expected O, but got I4
		//IL_0d44: Expected O, but got I4
		//IL_0d4d: Expected O, but got I4
		//IL_0dd4: Expected O, but got I
		//IL_0ed2: Expected I4, but got O
		//IL_0efc: Expected O, but got I4
		//IL_0d6c: Expected O, but got I4
		//IL_0d7d: Expected O, but got I4
		//IL_0e4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e51: Expected I4, but got Unknown
		//IL_0e6a: Expected O, but got I4
		//IL_0e8a: Expected O, but got I4
		//IL_0e93: Expected O, but got I4
		//IL_0f1a: Expected O, but got I
		//IL_1020: Expected I4, but got O
		//IL_104a: Expected O, but got I4
		//IL_0eb2: Expected O, but got I4
		//IL_0ec3: Expected O, but got I4
		//IL_0f92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f97: Expected I4, but got Unknown
		//IL_0fb0: Expected O, but got I4
		//IL_0fd0: Expected O, but got I4
		//IL_0fd9: Expected O, but got I4
		//IL_1068: Expected O, but got I
		//IL_10a4: Expected I4, but got O
		//IL_1392: Expected O, but got I4
		//IL_0ff8: Expected O, but got I4
		//IL_1009: Expected O, but got I4
		//IL_111e: Expected O, but got I4
		//IL_1422: Expected O, but got I4
		//IL_1490: Expected O, but got I4
		//IL_12f5: Expected O, but got I4
		//IL_1153: Expected O, but got I4
		//IL_1166: Expected O, but got I4
		//IL_11a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ae: Expected I4, but got Unknown
		//IL_167d: Expected O, but got I4
		//IL_1690: Expected O, but got I4
		//IL_16ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d3: Expected I4, but got Unknown
		//IL_11e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e7: Expected O, but got Unknown
		//IL_122f: Expected O, but got I4
		//IL_1240: Expected O, but got I4
		//IL_126a: Expected O, but got I4
		//IL_17c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c8: Expected O, but got Unknown
		//IL_14e7: Expected O, but got I4
		//IL_14fa: Expected O, but got I4
		//IL_1538: Unknown result type (might be due to invalid IL or missing references)
		//IL_153d: Expected I4, but got Unknown
		//IL_15ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bf: Expected I4, but got Unknown
		//IL_15d6: Expected O, but got I4
		//IL_15fe: Expected O, but got I4
		//IL_1614: Expected O, but got I4
		//IL_1625: Expected O, but got I4
		//IL_163b: Expected O, but got I4
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CE1]");
		object obj2 = (nint)0 & (nint)1;
		int num;
		int num3;
		int num2;
		if (obj2 != null)
		{
			num = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CDD]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			num2 = 0;
			num2 = 0;
			num3 = num;
			if (!flag)
			{
				goto IL_009d;
			}
		}
		else
		{
			_ = 1;
			num = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CDD]");
			object obj4 = (nint)0 & (nint)1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			num2 = 0;
			num2 = 0;
			num3 = num;
			if (obj5 != null)
			{
				goto IL_009d;
			}
		}
		_ = 1;
		object obj6 = (nint)0 + (nint)2200;
		int value = ((int*)num3)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v71 (System.Int32)+E4]");
		int num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v71 (System.Int32)+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		num = num3;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v71 (System.Int32)+E4]");
		int num5 = 0;
		if (obj7 != null)
		{
			goto IL_010b;
		}
		goto IL_023b;
		IL_17b9:
		object obj9 = "Material with texture name \"" + 3224;
		int num6;
		string text = num6.ToString((string)obj9);
		TextMeshProExtensions.FixArabic(team1Points, text);
		string text2 = num2.ToString((string)obj9);
		TextMeshProExtensions.FixArabic(team2Points, text2);
		return;
		IL_0653:
		TournamentData tournament = _tournament;
		object obj14;
		int num12;
		object obj15 = default(object);
		object obj11 = default(object);
		object obj12 = default(object);
		bool flag8 = default(bool);
		bool flag9 = default(bool);
		int num8 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		bool flag10 = default(bool);
		int num7 = default(int);
		AvatarData avatarData;
		if (_tournament != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+10]");
			int matchRound = TournamentMath.GetMatchRound(0, tournament.<Size>k__BackingField);
			num4 = (int)_tournament;
			bool flag4 = _tournament == null;
			num7 = 0;
			avatarData = (AvatarData)tournament.<Size>k__BackingField;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+6C]");
				int numberOfRounds = TournamentMath.GetNumberOfRounds(0);
				LocalizableText tournamentRoundName = TournamentUtil.GetTournamentRoundName(matchRound, numberOfRounds);
				TextMeshProExtensions.Localize(roomName, tournamentRoundName);
				num4 = (int)_match;
				bool flag5 = _match == null;
				num7 = 0;
				avatarData = (AvatarData)(object)tournamentRoundName;
				if (!flag5)
				{
					TournamentData tournament2 = _tournament;
					bool flag6 = _tournament == null;
					num7 = 0;
					avatarData = (AvatarData)(object)tournamentRoundName;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+10]");
						num4 = 0;
						object obj10 = tournament2.<Size>k__BackingField - 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+10]");
						bool flag7 = 0 < (nint)obj10;
						obj11 = !flag7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+10]");
						obj12 = 0 - obj10;
						flag8 = (nint)obj12 < 0;
						flag9 = obj12 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+10]");
						num8 = 0 ^ obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+10]");
						num9 = 0 ^ obj12;
						num10 = num8 & num9;
						flag10 = num10 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+10]");
						int num11;
						if (0 == (nint)obj10)
						{
							num11 = _tournament.FinalWiningValue;
							avatarData = null;
						}
						else
						{
							num11 = _tournament.WiningValue;
							avatarData = null;
						}
						bool flag11 = (object)team1Score == null;
						num7 = 0;
						if (!flag11)
						{
							team1Score.MaxProgress = num11;
							bool flag12 = (object)team2Score == null;
							num7 = 0;
							avatarData = (AvatarData)num11;
							if (!flag12)
							{
								team2Score.MaxProgress = num11;
								if (_room != null)
								{
									num4 = (int)("utf-32" + 1104);
									int variable = SFSExtensions.GetVariable(_room, (string)((int*)num4)->m_value, 0);
									bool flag13 = (object)team1Score == null;
									object obj13 = !flag13;
									obj14 = 0;
									num12 = variable;
									if (obj13 != null)
									{
										goto IL_0a42;
									}
									obj15 = 0;
									num7 = 0;
									avatarData = (AvatarData)variable;
								}
								else
								{
									num4 = (int)_match;
									bool flag14 = _match == null;
									num7 = 0;
									avatarData = (AvatarData)num11;
									if (!flag14)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+20]");
										avatarData = (AvatarData)0;
										bool flag15 = (object)team1Score == null;
										num7 = 0;
										obj14 = obj15;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+20]");
										num12 = 0;
										if (!flag15)
										{
											goto IL_0a42;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0645;
		IL_0645:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0653;
		IL_009d:
		obj6 = (nint)0 + (nint)2200;
		value = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v71 (System.Int32)+E4]");
		num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v71 (System.Int32)+E4]");
		bool flag16 = (nint)0 == 0;
		obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v71 (System.Int32)+E4]");
		num5 = 0;
		num3 = num;
		if (!flag16)
		{
			goto IL_010b;
		}
		goto IL_023b;
		IL_023b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag17 = (object)sessionModel == null;
		num = num3;
		IntPtr intPtr = default(IntPtr);
		avatarData = (AvatarData)(nint)intPtr;
		num4 = num5;
		if (!flag17)
		{
			goto IL_0289;
		}
		goto IL_0645;
		IL_010b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag18 = (object)sessionModel == null;
		object obj16 = !flag18;
		if (obj16 != null)
		{
			goto IL_0289;
		}
		avatarData = (AvatarData)(nint)intPtr;
		goto IL_0645;
		IL_0289:
		Room currentRoom = sessionModel.CurrentRoom;
		if (!SFSKammelnaRoomExtensions.IsTournamentHub(currentRoom))
		{
			return;
		}
		num4 = (int)_match;
		bool flag19 = _match == null;
		avatarData = null;
		num3 = num;
		if (!flag19)
		{
			object obj17 = (nint)0 + (nint)1472;
			object obj18 = (nint)0 + (nint)1968;
			int num13 = num7;
			bool flag21 = default(bool);
			bool flag20 = flag21;
			bool flag22 = flag10;
			int num14 = num10;
			int num15 = num9;
			int num16 = num8;
			bool flag23 = flag9;
			bool flag24 = flag8;
			object obj19 = obj12;
			object obj20 = obj11;
			AvatarData avatarData2 = null;
			int num17 = (int)_match;
			int num18 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v49 (System.Int32)+18]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v49 (System.Int32)+18]");
				bool flag25 = (nint)0 == 0;
				num7 = num13;
				flag21 = flag20;
				flag10 = flag22;
				num10 = num14;
				num9 = num15;
				num8 = num16;
				flag9 = flag23;
				flag8 = flag24;
				obj12 = obj19;
				obj11 = obj20;
				avatarData = avatarData2;
				num4 = num17;
				num3 = num18;
				if (flag25)
				{
					break;
				}
				int num19 = num18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v15+18]");
				bool flag26 = (nint)num19 < (nint)0;
				obj11 = !flag26;
				int num20 = num18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v15+18]");
				obj12 = (nint)num20 - (nint)0;
				flag8 = (nint)obj12 < 0;
				flag9 = obj12 == null;
				int num21 = num18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v15+18]");
				num8 = (int)((nint)num21 ^ (nint)0);
				num9 = num18 ^ obj12;
				num10 = num8 & num9;
				flag10 = num10 < 0;
				int num22 = num18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v15+18]");
				flag21 = (nint)num22 >= (nint)0;
				num7 = num13;
				avatarData = avatarData2;
				num4 = num17;
				num3 = num18;
				if (!flag21)
				{
					bool flag27 = slots == null;
					num7 = num13;
					avatarData = avatarData2;
					num4 = num17;
					num3 = num18;
					if (flag27)
					{
						break;
					}
					num7 = (int)obj17;
					object obj22 = ((List<object>)(object)slots).get_Item(num18);
					num4 = (int)_match;
					bool flag28 = _match == null;
					avatarData = (AvatarData)num18;
					num3 = num18;
					if (flag28)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+18]");
					bool flag29 = (nint)0 == 0;
					avatarData = (AvatarData)num18;
					num3 = num18;
					if (flag29)
					{
						break;
					}
					num7 = (int)obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+18]");
					object obj23 = ((List<object>)0).get_Item(num18);
					AvatarData avatarData3 = (PlayerInfo)obj23;
					bool flag30 = obj22 == null;
					avatarData = null;
					num3 = num18;
					if (flag30)
					{
						break;
					}
					((AvatarInitializer)obj22).Initialize(avatarData3);
					num3 = num18 + 1;
					num4 = (int)_match;
					bool flag31 = _match == null;
					object obj24 = !flag31;
					num7 = 0;
					avatarData = avatarData3;
					num13 = 0;
					flag20 = flag21;
					flag22 = flag10;
					num14 = num10;
					num15 = num9;
					num16 = num8;
					flag23 = flag9;
					flag24 = flag8;
					obj19 = obj12;
					obj20 = obj11;
					avatarData2 = avatarData3;
					num17 = (int)_match;
					num18 = num3;
					if (obj24 == null)
					{
						break;
					}
					continue;
				}
				goto IL_0653;
			}
		}
		goto IL_0645;
		IL_0a42:
		team1Score.CurrentProgress = num12;
		int num23;
		if (_room != null)
		{
			num4 = (int)("utf-32" + 1112);
			int variable2 = SFSExtensions.GetVariable(_room, (string)((int*)num4)->m_value, 0);
			bool flag32 = (object)team2Score == null;
			object obj25 = !flag32;
			obj14 = 0;
			num23 = variable2;
			if (obj25 != null)
			{
				goto IL_0b88;
			}
			obj15 = 0;
			num7 = 0;
			avatarData = (AvatarData)variable2;
		}
		else
		{
			num4 = (int)_match;
			bool flag33 = _match == null;
			obj15 = obj14;
			num7 = 0;
			avatarData = (AvatarData)num12;
			if (!flag33)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+24]");
				avatarData = (AvatarData)0;
				bool flag34 = (object)team2Score == null;
				obj15 = obj14;
				num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+24]");
				num23 = 0;
				if (!flag34)
				{
					goto IL_0b88;
				}
			}
		}
		goto IL_0645;
		IL_12db:
		MatchData matchData;
		bool flag35 = matchData == null;
		object obj26 = !flag35;
		int num24;
		bool flag36;
		int num25;
		int num26;
		int num27;
		bool flag37;
		bool flag38;
		object obj27;
		object obj28;
		AvatarData avatarData4;
		int num28;
		if (obj26 == null)
		{
			obj15 = obj14;
			num7 = num24;
			flag10 = flag36;
			num10 = num25;
			num9 = num26;
			num8 = num27;
			flag9 = flag37;
			flag8 = flag38;
			obj12 = obj27;
			obj11 = obj28;
			avatarData = avatarData4;
			num4 = num28;
			goto IL_0645;
		}
		goto IL_159e;
		IL_159e:
		num2 = matchData.<team2Points>k__BackingField;
		goto IL_1651;
		IL_0b88:
		team2Score.CurrentProgress = num23;
		int num29;
		if (_room != null)
		{
			num4 = (int)("tournament_participate_warning_body_with_tickets_warning_daily" + 744);
			int variable3 = SFSExtensions.GetVariable(_room, (string)((int*)num4)->m_value, 0);
			bool flag39 = (object)team1P1Score == null;
			object obj29 = !flag39;
			obj14 = 0;
			num29 = variable3;
			if (obj29 != null)
			{
				goto IL_0cce;
			}
			obj15 = 0;
			num7 = 0;
			avatarData = (AvatarData)variable3;
		}
		else
		{
			num4 = (int)_match;
			bool flag40 = _match == null;
			obj15 = obj14;
			num7 = 0;
			avatarData = (AvatarData)num23;
			if (!flag40)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+30]");
				avatarData = (AvatarData)0;
				bool flag41 = (object)team1P1Score == null;
				obj15 = obj14;
				num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+30]");
				num29 = 0;
				if (!flag41)
				{
					goto IL_0cce;
				}
			}
		}
		goto IL_0645;
		IL_0cce:
		team1P1Score.CurrentProgress = num29;
		int num30;
		if (_room != null)
		{
			num4 = (int)("tournament_participate_warning_body_with_tickets_warning_daily" + 752);
			int variable4 = SFSExtensions.GetVariable(_room, (string)((int*)num4)->m_value, 0);
			bool flag42 = (object)team1P2Score == null;
			object obj30 = !flag42;
			obj14 = 0;
			num30 = variable4;
			if (obj30 != null)
			{
				goto IL_0e14;
			}
			obj15 = 0;
			num7 = 0;
			avatarData = (AvatarData)variable4;
		}
		else
		{
			num4 = (int)_match;
			bool flag43 = _match == null;
			obj15 = obj14;
			num7 = 0;
			avatarData = (AvatarData)num29;
			if (!flag43)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+34]");
				avatarData = (AvatarData)0;
				bool flag44 = (object)team1P2Score == null;
				obj15 = obj14;
				num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+34]");
				num30 = 0;
				if (!flag44)
				{
					goto IL_0e14;
				}
			}
		}
		goto IL_0645;
		IL_0e14:
		team1P2Score.CurrentProgress = num30;
		int num31;
		if (_room != null)
		{
			num4 = (int)("tournament_participate_warning_body_with_tickets_warning_daily" + 768);
			int variable5 = SFSExtensions.GetVariable(_room, (string)((int*)num4)->m_value, 0);
			bool flag45 = (object)team2P1Score == null;
			object obj31 = !flag45;
			obj14 = 0;
			num31 = variable5;
			if (obj31 != null)
			{
				goto IL_0f5a;
			}
			obj15 = 0;
			num7 = 0;
			avatarData = (AvatarData)variable5;
		}
		else
		{
			num4 = (int)_match;
			bool flag46 = _match == null;
			obj15 = obj14;
			num7 = 0;
			avatarData = (AvatarData)num30;
			if (!flag46)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+38]");
				avatarData = (AvatarData)0;
				bool flag47 = (object)team2P1Score == null;
				obj15 = obj14;
				num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+38]");
				num31 = 0;
				if (!flag47)
				{
					goto IL_0f5a;
				}
			}
		}
		goto IL_0645;
		IL_0f5a:
		team2P1Score.CurrentProgress = num31;
		int num32;
		int num33;
		if (_room != null)
		{
			num32 = (int)("tournament_participate_warning_body_with_tickets_warning_daily" + 776);
			int variable6 = SFSExtensions.GetVariable(_room, (string)((int*)num32)->m_value, 0);
			bool flag48 = (object)team2P2Score == null;
			object obj32 = !flag48;
			obj14 = 0;
			num33 = variable6;
			if (obj32 != null)
			{
				goto IL_10b2;
			}
			obj15 = 0;
			num7 = 0;
			avatarData = (AvatarData)variable6;
			num4 = num32;
		}
		else
		{
			num4 = (int)_match;
			bool flag49 = _match == null;
			obj15 = obj14;
			num7 = 0;
			avatarData = (AvatarData)num31;
			if (!flag49)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+3C]");
				avatarData = (AvatarData)0;
				bool flag50 = (object)team2P2Score == null;
				obj15 = obj14;
				num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v3 (System.Int32)+3C]");
				num33 = 0;
				num32 = (int)_match;
				if (!flag50)
				{
					goto IL_10b2;
				}
			}
		}
		goto IL_0645;
		IL_10b2:
		team2P2Score.CurrentProgress = num33;
		Room room = _room;
		matchData = _match;
		MatchData matchData2;
		if (_room != null)
		{
			bool flag51 = _match == null;
			obj15 = obj14;
			num7 = 0;
			avatarData = (AvatarData)num33;
			num4 = num32;
			if (flag51)
			{
				goto IL_0645;
			}
			bool flag52 = matchData.<State>k__BackingField < MatchData.Status.Finished;
			obj28 = !flag52;
			obj27 = matchData.<State>k__BackingField - 2;
			flag38 = (nint)obj27 < 0;
			flag37 = matchData.<State>k__BackingField == MatchData.Status.Finished;
			num27 = (int)(matchData.<State>k__BackingField ^ MatchData.Status.Finished);
			num26 = matchData.<State>k__BackingField ^ obj27;
			num25 = num27 & num26;
			flag36 = num25 < 0;
			if (!flag37)
			{
				object obj33 = "startPosition" + 2144;
				int variable7 = SFSExtensions.GetVariable(_room, (string)obj33, 0);
				room = _room;
				matchData = _match;
				bool flag53 = _room == null;
				object obj34 = !flag53;
				num6 = variable7;
				obj14 = 0;
				num24 = 0;
				avatarData4 = (AvatarData)obj33;
				num28 = variable7;
				num6 = variable7;
				obj15 = 0;
				num7 = 0;
				flag10 = flag36;
				num10 = num25;
				num9 = num26;
				num8 = num27;
				flag9 = flag37;
				flag8 = flag38;
				obj12 = obj27;
				obj11 = obj28;
				matchData2 = _match;
				avatarData = (AvatarData)obj33;
				num4 = variable7;
				if (obj34 == null)
				{
					goto IL_12db;
				}
				goto IL_14ab;
			}
		}
		else
		{
			bool flag54 = _match == null;
			obj15 = obj14;
			num7 = 0;
			avatarData = (AvatarData)num33;
			num4 = num32;
			flag36 = flag10;
			num25 = num10;
			num26 = num9;
			num27 = num8;
			flag37 = flag9;
			flag38 = flag8;
			obj27 = obj12;
			obj28 = obj11;
			if (flag54)
			{
				goto IL_0645;
			}
		}
		num28 = matchData.<team1Points>k__BackingField;
		bool flag55 = room == null;
		num6 = matchData.<team1Points>k__BackingField;
		num24 = 0;
		avatarData4 = (AvatarData)num33;
		num6 = matchData.<team1Points>k__BackingField;
		obj15 = obj14;
		num7 = 0;
		flag10 = flag36;
		num10 = num25;
		num9 = num26;
		num8 = num27;
		flag9 = flag37;
		flag8 = flag38;
		obj12 = obj27;
		obj11 = obj28;
		matchData2 = matchData;
		avatarData = (AvatarData)num33;
		num4 = matchData.<team1Points>k__BackingField;
		if (flag55)
		{
			goto IL_12db;
		}
		goto IL_14ab;
		IL_14ab:
		if (matchData2 != null)
		{
			bool flag56 = matchData2.<State>k__BackingField < MatchData.Status.Finished;
			obj11 = !flag56;
			obj12 = matchData2.<State>k__BackingField - 2;
			flag8 = (nint)obj12 < 0;
			flag9 = obj12 == null;
			num8 = (int)(matchData2.<State>k__BackingField ^ MatchData.Status.Finished);
			num9 = matchData2.<State>k__BackingField ^ obj12;
			num10 = num8 & num9;
			flag10 = num10 < 0;
			bool flag21 = matchData2.<State>k__BackingField != MatchData.Status.Finished;
			obj14 = obj15;
			num24 = num7;
			matchData = matchData2;
			avatarData4 = avatarData;
			if (!flag21)
			{
				goto IL_159e;
			}
			num4 = (int)("startPosition" + 2160);
			int variable8 = SFSExtensions.GetVariable(room, (string)((int*)num4)->m_value, 0);
			matchData = _match;
			bool flag57 = _match == null;
			obj15 = 0;
			num7 = 0;
			avatarData = (AvatarData)((int*)num4)->m_value;
			num2 = variable8;
			obj14 = 0;
			num24 = 0;
			avatarData4 = (AvatarData)((int*)num4)->m_value;
			num2 = variable8;
			if (!flag57)
			{
				goto IL_1651;
			}
		}
		goto IL_0645;
		IL_1651:
		num4 = (int)matchData.<State>k__BackingField;
		bool flag58 = matchData.<State>k__BackingField < MatchData.Status.Finished;
		obj11 = !flag58;
		obj12 = matchData.<State>k__BackingField - 2;
		flag8 = (nint)obj12 < 0;
		flag9 = obj12 == null;
		num8 = (int)(matchData.<State>k__BackingField ^ MatchData.Status.Finished);
		num9 = matchData.<State>k__BackingField ^ obj12;
		num10 = num8 & num9;
		flag10 = num10 < 0;
		if (matchData.<State>k__BackingField == MatchData.Status.Finished)
		{
			bool flag59 = (object)team1Points == null;
			obj15 = obj14;
			num7 = num24;
			avatarData = avatarData4;
			if (!flag59)
			{
				GameObject go = team1Points.gameObject;
				VariableBinderExtensions.Unbind(go);
				bool flag60 = (object)team2Points == null;
				obj15 = obj14;
				num7 = num24;
				avatarData = null;
				if (!flag60)
				{
					GameObject go2 = team2Points.gameObject;
					VariableBinderExtensions.Unbind(go2);
					goto IL_17b9;
				}
			}
			goto IL_0645;
		}
		goto IL_17b9;
	}

	private int GetWiningValue()
	{
		//IL_00bf: Expected I4, but got O
		//IL_0065: Expected O, but got I4
		MatchData match = _match;
		if (_match != null)
		{
			TournamentData tournament = _tournament;
			if (_tournament != null)
			{
				object obj = tournament.<Size>k__BackingField - 1;
				if (match.<ID>k__BackingField == (nint)obj)
				{
					return _tournament.FinalWiningValue;
				}
				return _tournament.WiningValue;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private void SetWinner()
	{
		//IL_0036: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_0134: Expected O, but got I4
		//IL_01a2: Expected O, but got I4
		//IL_020b: Expected O, but got I4
		MatchData match = _match;
		int num = match.<team1Score>k__BackingField | match.<team2Score>k__BackingField;
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			MatchData nextMatch = GetNextMatch();
			if (nextMatch == null)
			{
				goto IL_021a;
			}
			MatchData match2 = _match;
			object obj2 = ((List<object>)(object)match2.<Players>k__BackingField).get_Item(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v13 (System.Object)+10]");
			bool flag2 = nextMatch.HasPlayer(0);
			bool flag3 = !flag2;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				MatchData match3 = _match;
				object obj4 = ((List<object>)(object)match3.<Players>k__BackingField).get_Item(2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v17 (System.Object)+10]");
				bool flag4 = nextMatch.HasPlayer(0);
				bool flag5 = !flag4;
				object obj5 = !flag5;
				if (obj5 == null)
				{
					MatchData match4 = _match;
					object obj6 = ((List<object>)(object)match4.<Players>k__BackingField).get_Item(1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v21 (System.Object)+10]");
					bool flag6 = nextMatch.HasPlayer(0);
					bool flag7 = !flag6;
					object obj7 = !flag7;
					if (obj7 == null)
					{
						MatchData match5 = _match;
						object obj8 = ((List<object>)(object)match5.<Players>k__BackingField).get_Item(3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v25 (System.Object)+10]");
						bool flag8 = nextMatch.HasPlayer(0);
						bool flag9 = !flag8;
						object obj9 = !flag9;
						if (obj9 == null)
						{
							goto IL_021a;
						}
					}
					goto IL_0252;
				}
			}
		}
		else if (match.<team1Score>k__BackingField <= match.<team2Score>k__BackingField)
		{
			goto IL_0252;
		}
		HighlightTeam1();
		return;
		IL_0252:
		HighlightTeam2();
		return;
		IL_021a:
		DimTeams();
	}

	private MatchData GetNextMatch()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Expected O, but got I
		//IL_0093: Expected O, but got I4
		MatchData match = _match;
		if (_match != null)
		{
			TournamentData tournament = _tournament;
			if (_tournament != null)
			{
				object obj = typeof(Queue<string>) + 848;
				object obj2 = (nint)0 + (nint)2200;
				int nextMatchId = TournamentMath.GetNextMatchId(match.<ID>k__BackingField, tournament.<Size>k__BackingField);
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				if ((object)sessionModel != null)
				{
					Room currentRoom = sessionModel.CurrentRoom;
					return SFSKammelnaRoomExtensions.GetTournamentMatch(currentRoom, nextMatchId);
				}
			}
		}
		return (MatchData)(object)new NullReferenceException();
	}

	private void HighlightTeam1()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_00bf: Expected O, but got I
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		//IL_010a: Expected O, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		Graphic[] array = teamGroupGraphics1;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X22_v6+v134 @ X21_v9*8]");
				UIExtensions.SetAlpha((Graphic)0, 1f);
				obj2++;
			}
			while ((nint)obj2 < array.Length);
		}
		Graphic[] array2 = teamGroupGraphics2;
		if (array2.Length >= 1)
		{
			object obj3 = array2 + 32;
			object obj4 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X22_v5+v218 @ X21_v6*8]");
				TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade((Graphic)0, 0.5f, 0.3f);
				obj4++;
			}
			while ((nint)obj4 < array2.Length);
		}
		team1PointsBackground.ToggleManual(isON: true);
	}

	private void HighlightTeam2()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_00c4: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		//IL_010e: Expected O, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		Graphic[] array = teamGroupGraphics1;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X22_v6+v139 @ X21_v9*8]");
				TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade((Graphic)0, 0.5f, 0.3f);
				obj2++;
			}
			while ((nint)obj2 < array.Length);
		}
		Graphic[] array2 = teamGroupGraphics2;
		if (array2.Length >= 1)
		{
			object obj3 = array2 + 32;
			object obj4 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X22_v5+v219 @ X21_v6*8]");
				UIExtensions.SetAlpha((Graphic)0, 1f);
				obj4++;
			}
			while ((nint)obj4 < array2.Length);
		}
		team2PointsBackground.ToggleManual(isON: true);
	}

	private void DimTeams()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_0060: Expected O, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I
		GameObject[] array = clearObjects;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X22_v4+v48 @ X21_v7*8]");
				((GameObject)0).SetActive(value: false);
				obj2++;
			}
			while ((nint)obj2 < array.Length);
		}
		GameObject[] array2 = cancelledObjects;
		if (array2.Length >= 1)
		{
			object obj3 = array2 + 32;
			object obj4 = 0;
			do
			{
				obj4++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v5+v108 @ X20_v6*8]");
				((GameObject)0).SetActive(value: true);
			}
			while ((nint)obj4 < array2.Length);
		}
	}

	private void ShowGameState()
	{
		//IL_0108: Expected O, but got I4
		//IL_0110: Expected O, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_0361: Expected I4, but got O
		//IL_005e: Expected O, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_038e: Expected O, but got I4
		//IL_01d6: Expected O, but got I
		//IL_01e6: Expected O, but got I
		//IL_0208: Expected O, but got I4
		//IL_016f: Expected O, but got I
		//IL_017f: Expected O, but got I
		//IL_01a1: Expected O, but got I4
		//IL_0238: Expected O, but got I4
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_04fe: Expected O, but got I
		//IL_050f: Expected I, but got O
		//IL_052d: Expected O, but got I
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_0476: Expected O, but got I4
		//IL_0268: Expected O, but got I
		//IL_0491: Expected O, but got I
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03e1: Expected O, but got I4
		//IL_03fc: Expected O, but got I
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_02e2: Expected O, but got I4
		//IL_02fd: Expected O, but got I
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		GameObject[] array = clearObjects;
		bool flag = array.Length < 1;
		IntPtr intPtr = default(IntPtr);
		bool flag2 = (byte)(nint)intPtr != 0;
		if (!flag)
		{
			object obj = array + 32;
			object obj2 = 0;
			bool flag3;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X22_v13+v98 @ X21_v21*8]");
				((GameObject)0).SetActive(value: false);
				obj2++;
				flag3 = (nint)obj2 < array.Length;
				flag2 = false;
			}
			while (flag3);
		}
		OnWatchersUpdated();
		MatchData match = _match;
		if (_room != null && match.<State>k__BackingField != MatchData.Status.Finished)
		{
			goto IL_0429;
		}
		bool flag4 = match.<State>k__BackingField == MatchData.Status.Waiting;
		object obj3 = !flag4;
		Func<object, bool> func = (Func<object, bool>)flag2;
		object obj4;
		object obj6;
		Func<object, bool> func2;
		if (obj3 == null)
		{
			obj4 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3392;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v22+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v22+B8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v27+8]");
				func2 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v27+8]");
				bool flag5 = (nint)0 == 0;
				object obj7 = !flag5;
				if (obj7 == null)
				{
					goto IL_0216;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v22+B8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v27+8]");
				func2 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v27+8]");
				bool flag6 = (nint)0 == 0;
				object obj8 = !flag6;
				if (obj8 == null)
				{
					goto IL_0216;
				}
			}
			goto IL_026d;
		}
		goto IL_0345;
		IL_0345:
		bool flag7 = match.<State>k__BackingField == MatchData.Status.Started;
		flag2 = (byte)(int)func != 0;
		if (!flag7)
		{
			bool flag8 = match.<State>k__BackingField == MatchData.Status.Waiting;
			object obj9 = !flag8;
			if (obj9 == null)
			{
				GameObject[] array2 = waitingObjects;
				if (array2.Length >= 1)
				{
					object obj10 = array2 + 32;
					object obj11 = 0;
					do
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X21_v13+v216 @ X20_v12*8]");
						((GameObject)0).SetActive(value: true);
						obj11++;
					}
					while ((nint)obj11 < array2.Length);
				}
				return;
			}
			GameObject[] array3 = finishedObjects;
			if (array3.Length >= 1)
			{
				object obj12 = array3 + 32;
				object obj13 = 0;
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X22_v10+v104 @ X21_v11*8]");
					((GameObject)0).SetActive(value: true);
					obj13++;
				}
				while ((nint)obj13 < array3.Length);
			}
			SetWinner();
			return;
		}
		goto IL_0429;
		IL_026d:
		if (Enumerable.Any(match.<Players>k__BackingField, func2))
		{
			GameObject[] array4 = startingSoonObjects;
			if (array4.Length >= 1)
			{
				object obj14 = array4 + 32;
				object obj15 = 0;
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X21_v15+v214 @ X20_v16*8]");
					((GameObject)0).SetActive(value: true);
					obj15++;
				}
				while ((nint)obj15 < array4.Length);
			}
			return;
		}
		match = _match;
		func = func2;
		goto IL_0345;
		IL_0429:
		ShowStartedGameInfo();
		return;
		IL_0216:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v22+E4]");
		bool flag9 = (nint)0 == 0;
		object obj16 = !flag9;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj17 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v33+B8]");
			obj6 = 0;
		}
		object obj18 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)1912;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj6, (IntPtr)obj19);
		object obj20 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v32+B8]");
		object obj21 = (nint)0 + (nint)8;
		obj21 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		func2 = func3;
		goto IL_026d;
	}

	private void ShowWaitingGameInfo()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		GameObject[] array = waitingObjects;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v4+v40 @ X20_v5*8]");
				((GameObject)0).SetActive(value: true);
			}
			while ((nint)obj2 < array.Length);
		}
	}

	private void ShowStartingSoonInfo()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		GameObject[] array = startingSoonObjects;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v4+v40 @ X20_v5*8]");
				((GameObject)0).SetActive(value: true);
			}
			while ((nint)obj2 < array.Length);
		}
	}

	private void ShowStartedGameInfo()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01dd: Expected O, but got I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_0205: Expected O, but got I
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0268: Expected O, but got I4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_029e: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BFB]");
		object obj3 = (nint)0 & (nint)1;
		MatchData matchData;
		MatchData match;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			matchData = _match;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			match = _match;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			matchData = _match;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			match = _match;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		matchData = match;
		goto IL_0168;
		IL_0168:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		bool flag3 = matchData.HasPlayer(intDbId);
		GameObject[] array = joinButtonObjects;
		if (array.Length >= 1)
		{
			object obj8 = array + 32;
			object obj9 = 0;
			do
			{
				obj9++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X23_v4+v151 @ X22_v8*8]");
				((GameObject)0).SetActive(flag3);
			}
			while ((nint)obj9 < array.Length);
		}
		GameObject[] array2 = watchButtonObjects;
		if (array2.Length >= 1)
		{
			object obj10 = array2 + 32;
			object obj11 = 0;
			do
			{
				obj11++;
				bool active = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X22_v6+v162 @ X21_v8*8]");
				((GameObject)0).SetActive(active);
			}
			while ((nint)obj11 < array2.Length);
		}
		return;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0168;
	}

	private void OnWatchersUpdated()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0093: Expected O, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_0106: Expected O, but got I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected I4, but got Unknown
		//IL_0128: Expected O, but got I
		if (_room != null)
		{
			object varName = "utf-32" + 1720;
			int variable = SFSExtensions.GetVariable(_room, (string)varName, 0);
		}
		MatchData match = _match;
		int num = default(int);
		GameObject[] array = default(GameObject[]);
		if (match.<State>k__BackingField == MatchData.Status.Started)
		{
			string text = num.ToString();
			TextMeshProExtensions.FixArabic(watchersCount, text);
			array = watchersObjects;
		}
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				bool flag = num < 0;
				bool flag2 = num == 0;
				int num2 = num ^ num;
				int num3 = num & num2;
				bool flag3 = num3 < 0;
				bool flag4 = flag == flag3;
				object obj3 = !flag2;
				bool active = (byte)((flag4 & obj3) ? 1 : 0) != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X21_v4+v118 @ X20_v7*8]");
				((GameObject)0).SetActive(active);
			}
			while ((nint)obj2 < array.Length);
		}
	}

	private void ShowFinishedGameInfo()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_006f: Expected O, but got I
		GameObject[] array = finishedObjects;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X22_v4+v41 @ X21_v5*8]");
				((GameObject)0).SetActive(value: true);
			}
			while ((nint)obj2 < array.Length);
		}
		SetWinner();
	}

	private void HideAll()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		GameObject[] array = clearObjects;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v4+v40 @ X20_v5*8]");
				((GameObject)0).SetActive(value: false);
			}
			while ((nint)obj2 < array.Length);
		}
	}

	private void <BindRoom>b__40_0()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "utf-32" + 1104;
		int variable = SFSExtensions.GetVariable(_room, (string)varName, 0);
		team1Score.CurrentProgress = variable;
	}

	private void <BindRoom>b__40_1()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "utf-32" + 1112;
		int variable = SFSExtensions.GetVariable(_room, (string)varName, 0);
		team2Score.CurrentProgress = variable;
	}

	private void <BindRoom>b__40_2()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "tournament_participate_warning_body_with_tickets_warning_daily" + 744;
		int variable = SFSExtensions.GetVariable(_room, (string)varName, 0);
		team1P1Score.CurrentProgress = variable;
	}

	private void <BindRoom>b__40_3()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "tournament_participate_warning_body_with_tickets_warning_daily" + 752;
		int variable = SFSExtensions.GetVariable(_room, (string)varName, 0);
		team1P2Score.CurrentProgress = variable;
	}

	private void <BindRoom>b__40_4()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "tournament_participate_warning_body_with_tickets_warning_daily" + 768;
		int variable = SFSExtensions.GetVariable(_room, (string)varName, 0);
		team2P1Score.CurrentProgress = variable;
	}

	private void <BindRoom>b__40_5()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "tournament_participate_warning_body_with_tickets_warning_daily" + 776;
		int variable = SFSExtensions.GetVariable(_room, (string)varName, 0);
		team2P2Score.CurrentProgress = variable;
	}

	private bool <FindRoom>b__43_0(Room room)
	{
		//IL_00f8: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj4 = obj3 + 1;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0139;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0139:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ X0_v3] (should have been resolved before IL gen)");
		string text = RoomName;
		string text2 = default(string);
		return text2 == text;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0139;
	}
}
