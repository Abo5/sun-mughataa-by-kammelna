using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class MassActiveTournamentsWidget : MassWidget
{
	private TournamentsEventsChannel tournamentsEventsChannel;

	private TournamentStrip[] tournamentStrips;

	private TournamentStrip finalStrip;

	private Button viewMoreButton;

	private ComponentReference<MassActiveTournamentsPopup> activeTournamentsPopup;

	private int populatedCount;

	protected override void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_018f: Expected O, but got I
		//IL_01c9: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0090: Expected I, but got O
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00fc: Expected I, but got O
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0168: Expected I, but got O
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		RegisterEvents();
		GameObject go = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)3040;
		object varName = "___# Content push apply failed [{0}]: {1}" + 3960;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName2 = "alignContent" + 2640;
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom2 = sessionModel2.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go2, currentRoom2, (string)varName2, action2);
		GameObject go3 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName3 = "alignContent" + 2504;
		SessionModel sessionModel3 = default(SessionModel);
		Room currentRoom3 = sessionModel3.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go3, currentRoom3, (string)varName3, action3);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoom -= action;
	}

	private void RefreshTournaments(string _)
	{
		RefreshTournaments();
	}

	private void RefreshTournaments(Room _)
	{
		RefreshTournaments();
	}

	private void RefreshTournaments()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I4
		//IL_00dd: Expected O, but got I4
		//IL_005d: Expected O, but got I4
		//IL_017a: Expected O, but got I4
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected I4, but got Unknown
		//IL_0271: Expected O, but got I4
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected I4, but got Unknown
		//IL_02e0: Expected O, but got I4
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected I4, but got Unknown
		//IL_0209: Expected O, but got I
		object obj = typeof(List<AdaptivePerformanceScaler>) + 4016;
		object obj2 = (nint)0 + (nint)1472;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		MassTournamentServerConnector massTournamentServerConnector;
		if ((nint)0 != 0)
		{
			bool flag = _connector != null;
			bool flag2 = !flag;
			massTournamentServerConnector = (MassTournamentServerConnector)flag;
			if (!flag2)
			{
				goto IL_006b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = _connector != null;
			bool flag4 = !flag3;
			object obj5 = !flag4;
			massTournamentServerConnector = (MassTournamentServerConnector)flag3;
			if (obj5 != null)
			{
				goto IL_006b;
			}
		}
		int num = 0;
		List<object> list2 = list;
		goto IL_0384;
		IL_0244:
		GameObject gameObject = viewMoreButton.gameObject;
		TournamentStrip[] array = tournamentStrips;
		object obj6 = num - array.Length;
		bool flag5 = (nint)obj6 < 0;
		bool flag6 = obj6 == null;
		int num2 = num ^ array.Length;
		int num3 = num ^ obj6;
		int num4 = num2 & num3;
		bool flag7 = num4 < 0;
		bool flag8 = flag5 == flag7;
		object obj7 = !flag6;
		bool active = (byte)((flag8 & obj7) ? 1 : 0) != 0;
		gameObject.SetActive(active);
		tournamentsEventsChannel.TriggerTournamentsChanged();
		if (populatedCount < list2._size)
		{
			populatedCount = list2._size;
		}
		return;
		IL_0384:
		GameObject gameObject2 = base.gameObject;
		bool flag9 = list2._size < 0;
		bool flag10 = list2._size == 0;
		int num5 = list2._size ^ list2._size;
		int num6 = list2._size & num5;
		bool flag11 = num6 < 0;
		bool flag12 = flag9 == flag11;
		object obj8 = !flag10;
		bool active2 = (byte)((flag12 & obj8) ? 1 : 0) != 0;
		gameObject2.SetActive(active2);
		if (list2._size == 1)
		{
			object obj9 = list2.get_Item(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v15 (System.Object)+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v15 (System.Object)+18]");
				if (((TournamentData)0).IsMassFinal)
				{
					PopulateFinal((List<TournamentRoomModel>)(object)list2);
					goto IL_0244;
				}
			}
		}
		PopulateTournaments((List<TournamentRoomModel>)(object)list2);
		goto IL_0244;
		IL_006b:
		List<TournamentRoomModel> activeTournaments = massTournamentServerConnector.GetActiveTournaments();
		int activeRoomsCount = ((MassTournamentServerConnector)(object)activeTournaments).GetActiveRoomsCount();
		num = activeRoomsCount;
		list2 = (List<object>)(object)activeTournaments;
		goto IL_0384;
	}

	private unsafe void PopulateTournaments(List<TournamentRoomModel> activeTournaments)
	{
		//IL_0010: Expected O, but got I
		//IL_03ea: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_0252: Expected O, but got I4
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected I4, but got Unknown
		//IL_0336: Expected O, but got I4
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_0365: Expected I4, but got O
		//IL_03c3: Expected O, but got I4
		//IL_00f6: Expected O, but got I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected I4, but got Unknown
		//IL_0167: Expected O, but got I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected I4, but got Unknown
		//IL_0191: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60B7]");
		TournamentStrip[] array = (TournamentStrip[])0;
		if ((object)finalStrip != null)
		{
			GameObject gameObject = finalStrip.gameObject;
			if ((object)gameObject != null)
			{
				gameObject.SetActive(value: false);
				array = tournamentStrips;
				if (tournamentStrips != null)
				{
					if (activeTournaments == null)
					{
						goto IL_03e0;
					}
					object obj = (nint)0 + (nint)1488;
					object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1512;
					int num2 = default(int);
					int num = num2;
					object obj4 = default(object);
					object obj3 = obj4;
					TournamentStrip[] array2 = tournamentStrips;
					int num3 = 0;
					TournamentDataHolder tournamentDataHolder = default(TournamentDataHolder);
					bool flag;
					do
					{
						if (num3 >= array2.Length)
						{
							return;
						}
						array = (TournamentStrip[])(array2 + num3);
						flag = (object)array[0] == null;
						num2 = num;
						if (flag)
						{
							break;
						}
						num2 = activeTournaments._size;
						GameObject gameObject2 = array[0].gameObject;
						if ((object)gameObject2 == null)
						{
							break;
						}
						object obj5 = num3 - activeTournaments._size;
						bool flag2 = (nint)obj5 < 0;
						int num4 = num3 ^ activeTournaments._size;
						int num5 = num3 ^ obj5;
						int num6 = num4 & num5;
						bool flag3 = num6 < 0;
						bool flag4 = flag2 == flag3;
						bool active = !flag4;
						gameObject2.SetActive(active);
						if (num3 < activeTournaments._size)
						{
							TournamentStrip[] array3 = tournamentStrips;
							flag = tournamentStrips == null;
							array = tournamentStrips;
							if (flag)
							{
								break;
							}
							bool flag5 = num3 < array3.Length;
							object obj6 = !flag5;
							if (obj6 != null)
							{
								throw new IndexOutOfRangeException();
							}
							array = (TournamentStrip[])(tournamentStrips + num3);
							num2 = (int)array[0];
							object model = ((List<object>)(object)activeTournaments).get_Item(num3);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							tournamentDataHolder..ctor((TournamentRoomModel)model, num3);
							bool flag6 = (object)array[0] == null;
							flag = !flag6;
							obj4 = 0;
							if (!flag)
							{
								break;
							}
							object obj7 = populatedCount - num3;
							bool flag7 = (nint)obj7 < 0;
							bool flag8 = obj7 == null;
							int num7 = populatedCount ^ num3;
							int num8 = populatedCount ^ obj7;
							int num9 = num7 & num8;
							bool flag9 = num9 < 0;
							bool flag10 = flag7 == flag9;
							object obj8 = !flag10;
							int num10 = ((obj8 | flag8) ? 1 : 0);
							int value = ((int*)num2)->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v15 (System.Int32)+310]");
							obj3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v322 @ X8_v15 (System.Int32)+308] (should have been resolved before IL gen)");
						}
						num3++;
						array2 = tournamentStrips;
						flag = tournamentStrips == null;
						num = num2;
						array = tournamentStrips;
					}
					while (!flag);
				}
			}
		}
		goto IL_03d2;
		IL_03d2:
		NullReferenceException ex = new NullReferenceException();
		goto IL_03e0;
		IL_03e0:
		array = (TournamentStrip[])array.Length;
		if (array.Length <= 0)
		{
			return;
		}
		goto IL_03d2;
	}

	private void PopulateFinal(List<TournamentRoomModel> activeTournaments)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0362: Expected I, but got O
		//IL_0032: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I4
		//IL_010b: Expected O, but got I
		//IL_013e: Expected O, but got I4
		//IL_0386: Expected O, but got I
		//IL_019b: Expected O, but got I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_01f4: Expected O, but got I
		//IL_0202: Expected I, but got O
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0240: Expected O, but got I4
		//IL_0320: Expected I, but got O
		//IL_0330: Expected O, but got I
		//IL_0340: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3824;
		object obj2 = (nint)0 + (nint)1952;
		Action<object> action = default(Action<object>);
		TimeSpan timeSpan2 = default(TimeSpan);
		Action action2 = default(Action);
		TournamentDataHolder tournamentDataHolder = default(TournamentDataHolder);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor((object)null, (IntPtr)obj2);
			ArraysExtensions.ForEach(tournamentStrips, action);
			object obj3 = (nint)0 + (nint)1488;
			object model = ((List<object>)(object)activeTournaments).get_Item(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v8 (System.Object)+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v8 (System.Object)+18]");
			if ((nint)0 == 0)
			{
				break;
			}
			object obj5 = typeof(DataRelation) + 712;
			object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v6+A8]");
			TimeSpan timeSpan = (DateTime)0 - now;
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v9+B8]");
			object obj11 = 0;
			bool flag3 = timeSpan > (TimeSpan)obj11;
			GameObject gameObject = base.gameObject;
			if (flag3)
			{
				gameObject.SetActive(value: false);
				object obj12 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v27+E4]");
				bool flag4 = (nint)0 == 0;
				object obj13 = !flag4;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double totalSeconds = timeSpan2.TotalSeconds;
				object obj14 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj15 = (nint)0 + (nint)3040;
				action2..ctor(this, (IntPtr)obj15);
				object obj16 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v32+E4]");
				bool flag5 = (nint)0 == 0;
				object obj18 = !flag5;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Coroutine coroutine = CoroutineDummy.WaitForSeconds((float)totalSeconds, action2);
				return;
			}
			Transform transform = gameObject.transform;
			transform.SetSiblingIndex(1);
			GameObject gameObject2 = finalStrip.gameObject;
			gameObject2.SetActive(value: true);
			TournamentStrip tournamentStrip = finalStrip;
			object obj19 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1512;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			tournamentDataHolder..ctor((TournamentRoomModel)model, 1);
			nint num = (nint)tournamentStrip;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v13 (Il2CppClass<TournamentStrip>)+308]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v13 (Il2CppClass<TournamentStrip>)+310]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v144 @ X4_v1 (should have been resolved before IL gen)");
		}
		GameObject gameObject3 = base.gameObject;
		gameObject3.SetActive(value: false);
	}

	private void RegisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_009c: Expected I, but got O
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0054: Expected O, but got I
		//IL_006c: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoom += action;
		Button button = viewMoreButton;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj4 = (nint)0 + (nint)3056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj4);
		button.m_OnClick.AddListener(unityAction);
	}

	private void UnregisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoom -= action;
	}

	private void ShowFullList()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2608;
		object obj2 = (nint)0 + (nint)3032;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)2104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private void <ShowFullList>b__15_0(MassActiveTournamentsPopup popup)
	{
		popup.Show(_connector);
	}
}
