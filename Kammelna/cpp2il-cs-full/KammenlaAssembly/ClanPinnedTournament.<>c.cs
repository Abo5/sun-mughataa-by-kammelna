using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Features.Clans;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ClanPinnedTournament : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Room, bool> <>9__15_0;

		public static Func<Room, int> <>9__15_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 1256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <FindClanTournament>b__15_0(Room room)
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v5-8]");
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
				object obj4 = obj3 + 3;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				goto IL_0139;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0139:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ X0_v3] (should have been resolved before IL gen)");
			string clanTag = ClanTag;
			string text = default(string);
			return text == clanTag;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0139;
		}

		internal int <FindClanTournament>b__15_1(Room room)
		{
			//IL_0124: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_010c: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			nint num;
			object obj3 = default(object);
			if (room != null)
			{
				object obj = typeof(RegisteredWaitHandle) + 1376;
				num = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4-8]");
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
				goto IL_00d9;
			}
			goto IL_0116;
			IL_0116:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj5 = default(object);
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_00d9:
			object obj7 = num + obj3;
			object obj8 = obj7 + 312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v6+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0116;
		}
	}

	private GameObject banner;

	private TextMeshProUGUI tournamentName;

	private TournamentCardRoomThemeSetter cardRoomThemeSetter;

	private Button pinButton;

	private ChatMessagesListView chatList;

	private Room pinnedRoom;

	private static bool HasClan
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_017c: Expected I4, but got O
			//IL_01b4: Expected O, but got I4
			//IL_025a: Expected I4, but got O
			//IL_0225: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87E7]");
			object obj3 = (nint)0 & (nint)1;
			object obj6;
			object obj4;
			if (obj3 != null)
			{
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
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
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			obj4 = obj6;
			if (!flag3)
			{
				goto IL_0158;
			}
			goto IL_024c;
			IL_024c:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0158:
			User localUser = sessionModel.LocalUser;
			bool flag4 = localUser == null;
			bool result = (byte)(int)localUser != 0;
			if (!flag4)
			{
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				if ((object)sessionModel2 == null)
				{
					goto IL_024c;
				}
				User localUser2 = sessionModel2.LocalUser;
				int clanId = SFSKammelnaUserExtensions.GetClanId(localUser2);
				object obj10 = clanId + 1;
				bool flag6 = obj10 == null;
				bool flag7 = !flag6;
				result = flag7;
			}
			return result;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag8 = (object)sessionModel == null;
			object obj11 = !flag8;
			if (obj11 != null)
			{
				goto IL_0158;
			}
			goto IL_024c;
		}
	}

	private static string ClanTag
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00fb: Expected O, but got I
			//IL_0125: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_016e: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87E8]");
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
			goto IL_017c;
			IL_00b8:
			User localUser = sessionModel.LocalUser;
			int clanId = SFSKammelnaUserExtensions.GetClanId(localUser);
			return ClanUtils.GetClanChatTag(clanId);
			IL_017c:
			return (string)(object)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_017c;
		}
	}

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button button = pinButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
	}

	private void OnEnable()
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00af: Expected O, but got I4
		//IL_00d4: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_0049: Expected I, but got O
		//IL_0074: Expected I, but got O
		if (HasClan)
		{
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
			object obj2 = (nint)0 + (nint)1472;
			object obj3 = (nint)0 + (nint)1480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj2);
			SFS.OnRoomCreated += action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action2 = default(Action<object>);
			action2..ctor((object)this, (IntPtr)obj3);
			SFS.OnRoomRemoved += action2;
			Room room = FindClanTournament();
			Show(room);
		}
		else
		{
			object obj4 = this + 72;
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X19_v2-28]");
			((GameObject)0).SetActive(value: false);
		}
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0070: Expected I, but got O
		//IL_0049: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)1472;
		object obj3 = (nint)0 + (nint)1480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnRoomCreated -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj3);
		SFS.OnRoomRemoved -= action2;
	}

	private void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button button = pinButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.RemoveListener(unityAction);
	}

	public void OnPinClicked()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0118: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		Room room = pinnedRoom;
		if (pinnedRoom == null)
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X10_v6-8]");
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
		object obj4 = num + obj3;
		object obj5 = obj4 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v180 @ X0_v10] (should have been resolved before IL gen)");
		bool flag = (object)chatList == null;
		object obj6 = !flag;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00c6;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ X0_v7] (should have been resolved before IL gen)");
		goto IL_00c6;
		IL_00c6:
		int roomId = default(int);
		chatList.ScrollToTournamentCard(roomId);
	}

	private static Room FindClanTournament()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0148: Expected O, but got I4
		//IL_00aa: Expected O, but got I
		//IL_00ba: Expected O, but got I
		//IL_00ca: Expected O, but got I
		//IL_00ec: Expected O, but got I4
		//IL_027e: Expected O, but got I4
		//IL_018c: Expected O, but got I
		//IL_019c: Expected O, but got I
		//IL_01ac: Expected O, but got I
		//IL_01ce: Expected O, but got I4
		//IL_03bc: Expected O, but got I
		//IL_03cc: Expected O, but got I
		//IL_03ee: Expected O, but got I4
		//IL_020e: Expected O, but got I4
		//IL_02c5: Expected O, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_034c: Expected O, but got I
		//IL_035d: Expected I, but got O
		//IL_037b: Expected O, but got I
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0426: Expected O, but got I
		//IL_0437: Expected I, but got O
		//IL_0455: Expected O, but got I
		//IL_023e: Expected O, but got I
		//IL_02f5: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(CardUtils.<>c) + 1256;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87EE]");
		object obj3 = (nint)0 & (nint)1;
		IEnumerable<Room> enumerable;
		IEnumerable<Room> enumerable2;
		object obj4;
		if (obj3 != null)
		{
			IEnumerable<Room> tournamentRooms = SFS.TournamentRooms;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			enumerable = tournamentRooms;
			object obj5 = obj4;
			enumerable2 = tournamentRooms;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			IEnumerable<Room> tournamentRooms2 = SFS.TournamentRooms;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			enumerable = tournamentRooms2;
			object obj5 = obj4;
			enumerable2 = tournamentRooms2;
			if (obj6 != null)
			{
				goto IL_009e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)3736;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v19+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v15+8]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v15+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		enumerable = enumerable2;
		if (obj9 == null)
		{
			goto IL_01ec;
		}
		goto IL_0243;
		IL_01ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v21+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)472;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v20+B8]");
		object obj16 = (nint)0 + (nint)8;
		obj16 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate = func;
		obj10 = obj7;
		enumerable = enumerable2;
		goto IL_0243;
		IL_0243:
		IEnumerable<object> source = Enumerable.Where(enumerable, predicate);
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v5+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v6+10]");
		Func<object, int> keySelector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v6+10]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v5+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj22 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v12+B8]");
				obj19 = 0;
			}
			object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj24 = (nint)0 + (nint)480;
			Func<object, int> func2 = default(Func<object, int>);
			func2..ctor(obj19, (IntPtr)obj24);
			object obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v11+B8]");
			object obj26 = (nint)0 + (nint)16;
			obj26 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			keySelector = func2;
		}
		IOrderedEnumerable<object> source2 = Enumerable.OrderByDescending(source, keySelector);
		return (Room)Enumerable.FirstOrDefault(source2);
		IL_009e:
		obj10 = (nint)0 + (nint)3736;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v19+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v15+8]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v15+8]");
		bool flag8 = (nint)0 == 0;
		object obj27 = !flag8;
		if (obj27 == null)
		{
			obj7 = obj10;
			enumerable2 = enumerable;
			goto IL_01ec;
		}
		goto IL_0243;
	}

	private void OnClanTournamentCreated(Room room)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003a: Expected I, but got O
		//IL_004a: Expected O, but got I
		//IL_01cb: Expected O, but got I4
		//IL_0085: Expected O, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		bool hasClan = HasClan;
		if (room == null || !hasClan)
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
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
			goto IL_00c6;
		}
		object obj4 = obj3 + 3;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_018d;
		IL_00c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_018d;
		IL_018d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v196 @ X0_v4] (should have been resolved before IL gen)");
		string clanTag = ClanTag;
		string text = default(string);
		bool flag = text != clanTag;
		bool flag2 = !flag;
		object obj7 = !flag2;
		if (obj7 == null && SFSKammelnaRoomExtensions.IsTournamentHub(room))
		{
			Room room2 = FindClanTournament();
			Show(room2);
		}
	}

	private void OnClanTournamentRemoved(Room room)
	{
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
		if (room == null)
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X10_v6-8]");
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
		object obj4 = obj3 + 3;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_0145;
		IL_0145:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v191 @ X0_v3] (should have been resolved before IL gen)");
		string clanTag = ClanTag;
		string text = default(string);
		if (!(text != clanTag))
		{
			Room room2 = FindClanTournament();
			Show(room2);
		}
		return;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0145;
	}

	private void Show(Room room)
	{
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0095: Expected O, but got I4
		//IL_00d3: Expected O, but got I4
		object obj = this + 72;
		obj = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TournamentData tournamentInfo;
		GameObject gameObject;
		if (room != null)
		{
			tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(room);
			if (tournamentInfo != null)
			{
				object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v12+E4]");
				if ((nint)0 != 0)
				{
					bool flag = tournamentName;
					bool flag2 = !flag;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						goto IL_00a3;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					if (!tournamentName)
					{
						goto IL_00a3;
					}
				}
				TextMeshProExtensions.FixArabic(tournamentName, tournamentInfo.<Name>k__BackingField);
				ApplyRoomTheme(tournamentInfo);
				gameObject = banner;
				goto IL_0176;
			}
		}
		pinnedRoom = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		banner.SetActive(value: false);
		return;
		IL_0176:
		gameObject.SetActive(value: true);
		return;
		IL_00a3:
		ApplyRoomTheme(tournamentInfo);
		gameObject = banner;
		bool flag3 = (object)banner == null;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0176;
	}

	private void ApplyRoomTheme(TournamentData info)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87F2]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = cardRoomThemeSetter;
			obj6 = cardRoomThemeSetter;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = cardRoomThemeSetter;
			obj6 = cardRoomThemeSetter;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj6)
		{
			goto IL_014e;
		}
		return;
		IL_014e:
		cardRoomThemeSetter.resetUI();
		RoomThemeTournamentAddon tournamentAddonsRoomTheme = info.TournamentAddonsRoomTheme;
		if (tournamentAddonsRoomTheme != null)
		{
			RoomThemeTournamentAddon tournamentAddonsRoomTheme2 = info.TournamentAddonsRoomTheme;
			cardRoomThemeSetter.Initialize(tournamentAddonsRoomTheme2.<RoomThemeId>k__BackingField);
		}
		return;
		IL_0091:
		bool flag3 = obj5;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_014e;
	}

	private void Hide()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0039: Expected O, but got I
		object obj = this + 72;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X19_v2-28]");
		((GameObject)0).SetActive(value: false);
	}
}
