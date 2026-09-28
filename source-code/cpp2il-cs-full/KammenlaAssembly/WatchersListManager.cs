using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WatchersListManager : MonoBehaviour
{
	private WatchersListView WatchersList;

	private TextMeshProUGUI WatchersCount;

	private Image WatchersIcon;

	private GameEventsChannel gameEventsChannel;

	private SlideAnimationHelper WatchersSlider;

	private GameObject blocker;

	private KGame game;

	protected void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_019c: Expected O, but got I
		//IL_01c6: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0074: Expected O, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0094: Expected O, but got I
		//IL_00ac: Expected O, but got I
		//IL_00d9: Expected I, but got O
		//IL_0104: Expected I, but got O
		//IL_012a: Expected I, but got O
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_014f: Expected O, but got I
		//IL_017b: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 80;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
		object obj8 = (nint)0 + (nint)3840;
		object obj9 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj10 = (nint)0 + (nint)3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X20_v4-30]");
		object obj11 = (nint)0 + (nint)360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateWatchers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj8);
		SFS.OnUserJoinRoom += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj8);
		SFS.OnUserLeaveRoom += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)obj10);
		object obj12 = typeof(SqlSingle[]) + 2376;
		object obj13 = (nint)0 + (nint)3832;
		game.OnPlayerSwitchSeat += playerSwitchSeatDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj13);
		gameEventsChannel.OnPanelShow += action3;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_00b5: Expected I, but got O
		//IL_005d: Expected I, but got O
		//IL_0088: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
		object obj2 = (nint)0 + (nint)3840;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnUserJoinRoom -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj2);
		SFS.OnUserLeaveRoom -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj4);
		gameEventsChannel.OnPanelShow -= action3;
	}

	private void OnRoomUsersUpdated(int i, string s)
	{
		UpdateWatchers();
	}

	private void OnRoomUsersUpdated(User _)
	{
		UpdateWatchers();
	}

	private void UpdateWatchers()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_0045: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_0080: Expected O, but got I
		//IL_016c: Expected I, but got O
		//IL_017c: Expected O, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0232: Expected O, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_01b7: Expected O, but got I
		//IL_0319: Expected O, but got I4
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected I4, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_03ac: Expected O, but got I4
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected I4, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_0405: Expected O, but got I4
		//IL_0457: Expected O, but got I4
		Room room = game.Room;
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X10_v12-8]");
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
			goto IL_00c1;
		}
		object obj4 = obj3 + 30;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v236 @ X8_v30] (should have been resolved before IL gen)");
		goto IL_013c;
		IL_013c:
		List<User> data = default(List<User>);
		WatchersList.SetData(data);
		Room room2 = game.Room;
		nint num2 = (nint)room2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01f8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X10_v7-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj8 += 16;
			obj7--;
			if ((nint)obj7 != 1)
			{
				continue;
			}
			goto IL_01f8;
		}
		object obj9 = obj8 + 18;
		object obj10 = num2 + obj9;
		object obj11 = obj10 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v239 @ X8_v27] (should have been resolved before IL gen)");
		Component watchersCount = WatchersCount;
		int num4 = default(int);
		int num3 = num4;
		int num5 = num4;
		goto IL_02a7;
		IL_01f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v358 @ X0_v28] (should have been resolved before IL gen)");
		watchersCount = WatchersCount;
		bool flag = (object)WatchersCount == null;
		object obj12 = !flag;
		int num6 = default(int);
		num3 = num6;
		num5 = num6;
		if (obj12 != null)
		{
			goto IL_02a7;
		}
		goto IL_0461;
		IL_0461:
		throw new NullReferenceException();
		IL_02a7:
		GameObject gameObject = watchersCount.gameObject;
		bool flag2 = num5 < 0;
		bool flag3 = num5 == 0;
		int num7 = num5 ^ num5;
		int num8 = num5 & num7;
		bool flag4 = num8 < 0;
		bool flag5 = flag2 == flag4;
		object obj13 = !flag3;
		bool active = (byte)((flag5 & obj13) ? 1 : 0) != 0;
		gameObject.SetActive(active);
		GameObject gameObject2 = WatchersIcon.gameObject;
		bool flag6 = num5 < 0;
		bool flag7 = num5 == 0;
		int num9 = num5 ^ num5;
		int num10 = num5 & num9;
		bool flag8 = num10 < 0;
		bool flag9 = flag6 == flag8;
		object obj14 = !flag7;
		bool active2 = (byte)((flag9 & obj14) ? 1 : 0) != 0;
		gameObject2.SetActive(active2);
		if (num5 >= 1)
		{
			Transform transform = WatchersCount.transform;
			transform.localScale = (Vector3)0;
			string text = num3.ToString();
			WatchersCount.text = text;
			Transform target = WatchersCount.transform;
			Tweener tweener = ShortcutExtensions.DOPunchScale(target, (Vector3)10, 0.15f, 0, 0.15f);
		}
		return;
		IL_00c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v317 @ X0_v34] (should have been resolved before IL gen)");
		bool flag10 = (object)WatchersList == null;
		object obj15 = !flag10;
		if (obj15 != null)
		{
			goto IL_013c;
		}
		goto IL_0461;
	}

	public void OnWatcherUIClicked(string userDbId)
	{
		gameEventsChannel.TriggerWatcherClicked(userDbId);
	}

	public void OnShowListViewClicked()
	{
		Open();
	}

	public void Toggle()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f9: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6836]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object watchersSlider;
		UnityEngine.Object watchersSlider2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			watchersSlider = WatchersSlider;
			watchersSlider2 = WatchersSlider;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			watchersSlider = WatchersSlider;
			watchersSlider2 = WatchersSlider;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)watchersSlider2)
		{
			goto IL_0152;
		}
		goto IL_0187;
		IL_0187:
		Close();
		return;
		IL_0152:
		SlideAnimationHelper watchersSlider3 = WatchersSlider;
		if (watchersSlider3.<IsShown>k__BackingField)
		{
			goto IL_0187;
		}
		Open();
		return;
		IL_0091:
		bool flag3 = watchersSlider;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 != null)
		{
			goto IL_0152;
		}
		goto IL_0187;
	}

	public void Open()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		//IL_0184: Expected O, but got I4
		//IL_01d7: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		gameEventsChannel.TriggerPanelShow();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v5+E4]");
		bool flag3;
		if ((nint)0 != 0)
		{
			bool flag = blocker;
			bool flag2 = !flag;
			object obj3 = !flag2;
			flag3 = false;
			if (obj3 == null)
			{
				goto IL_008d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = blocker;
			bool flag5 = !flag4;
			flag3 = false;
			if (flag5)
			{
				goto IL_008d;
			}
		}
		blocker.SetActive(value: true);
		UnityEngine.Object watchersSlider = WatchersSlider;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+E4]");
		bool flag6 = (nint)0 == 0;
		object obj5 = !flag6;
		flag3 = true;
		UnityEngine.Object watchersSlider2 = WatchersSlider;
		if (obj5 != null)
		{
			goto IL_00ce;
		}
		goto IL_01a5;
		IL_00f4:
		WatchersSlider.SlideIn();
		return;
		IL_00ce:
		if ((bool)watchersSlider)
		{
			goto IL_00f4;
		}
		return;
		IL_01a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag7 = watchersSlider2;
		bool flag8 = !flag7;
		object obj6 = !flag8;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00f4;
		IL_008d:
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+E4]");
		bool flag9 = (nint)0 == 0;
		watchersSlider = WatchersSlider;
		watchersSlider2 = WatchersSlider;
		if (!flag9)
		{
			goto IL_00ce;
		}
		goto IL_01a5;
	}

	public void Close()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_016e: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0212: Expected O, but got I4
		//IL_0265: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6838]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = blocker;
			obj6 = blocker;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = blocker;
			obj6 = blocker;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		bool flag5 = false;
		if (flag4)
		{
			goto IL_00cb;
		}
		goto IL_01ce;
		IL_0132:
		WatchersSlider.SlideOut();
		return;
		IL_010c:
		UnityEngine.Object watchersSlider;
		if ((bool)watchersSlider)
		{
			goto IL_0132;
		}
		return;
		IL_0233:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object watchersSlider2;
		bool flag6 = watchersSlider2;
		bool flag7 = !flag6;
		object obj8 = !flag7;
		if (obj8 == null)
		{
			return;
		}
		goto IL_0132;
		IL_0091:
		bool flag8 = obj5;
		bool flag9 = !flag8;
		object obj9 = !flag9;
		flag5 = false;
		if (obj9 == null)
		{
			goto IL_00cb;
		}
		goto IL_01ce;
		IL_01ce:
		blocker.SetActive(value: false);
		watchersSlider = WatchersSlider;
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v4+E4]");
		bool flag10 = (nint)0 == 0;
		object obj11 = !flag10;
		flag5 = false;
		watchersSlider2 = WatchersSlider;
		if (obj11 != null)
		{
			goto IL_010c;
		}
		goto IL_0233;
		IL_00cb:
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v4+E4]");
		bool flag11 = (nint)0 == 0;
		watchersSlider = WatchersSlider;
		watchersSlider2 = WatchersSlider;
		if (!flag11)
		{
			goto IL_010c;
		}
		goto IL_0233;
	}
}
