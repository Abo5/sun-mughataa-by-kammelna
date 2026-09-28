using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class LastPlayedWithUI : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<PlayerInfo, bool> <>9__8_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1584;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <PopulatePlayers>b__8_0(PlayerInfo player)
		{
			//IL_0091: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0075: Expected I8, but got I4
			//IL_0054: Expected I8, but got I4
			if (player != null)
			{
				object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					return FriendsManager.IsCompleteStranger(player.<DBID>k__BackingField);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return FriendsManager.IsCompleteStranger(player.<DBID>k__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private LastPlayedWithListView list;

	private TextMeshProUGUI countText;

	private GameObject emptyState;

	private static string LastMatchPlayers
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0085: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = "java.io.FileOutputStream" + 1160;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string cachePath = Config.CachePath;
			return cachePath + (string)obj2;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0075: Expected I, but got O
		//IL_009f: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)152;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.OnFriendListUpdated += action;
		OnFriendListUpdated();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)152;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			FriendsManager.OnFriendListUpdated -= action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FriendsManager.OnFriendListUpdated -= action;
	}

	private void OnFriendListUpdated()
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_014b: Expected O, but got I4
		//IL_00cf: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		object obj3 = "java.io.FileOutputStream" + 1160;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string cachePath = Config.CachePath;
		string path = cachePath + (string)obj3;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6+E4]");
		object obj7;
		if ((nint)0 != 0)
		{
			if (FileUtils.TryLoadObject<object>(path, out obj7))
			{
				goto IL_008d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = FileUtils.TryLoadObject<object>(path, out obj7);
			bool flag3 = !flag2;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_008d;
			}
		}
		PopulateEmptyState();
		return;
		IL_008d:
		PopulatePlayers((List<PlayerInfo>)obj7);
	}

	private void PopulatePlayers(List<PlayerInfo> players)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_041c: Expected O, but got I4
		//IL_04ae: Expected O, but got I
		//IL_04bf: Expected O, but got I
		//IL_04cf: Expected O, but got I
		//IL_04f1: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected O, but got Unknown
		//IL_0454: Expected O, but got I
		//IL_0465: Expected I, but got O
		//IL_0483: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_015b: Expected O, but got I4
		//IL_018e: Expected O, but got I
		//IL_0373: Expected O, but got I4
		//IL_0225: Expected O, but got I4
		//IL_02b4: Expected I, but got O
		//IL_02c4: Expected O, but got I
		//IL_02f1: Expected O, but got I
		//IL_030b: Expected O, but got I4
		//IL_032b: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1584;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj4 = (nint)0 + (nint)3656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v26+8]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v26+8]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v32+B8]");
				obj5 = 0;
			}
			object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)3512;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj5, (IntPtr)obj10);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v31+B8]");
			object obj12 = (nint)0 + (nint)8;
			obj12 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func;
		}
		object obj13 = obj4;
		IEnumerable<object> source = Enumerable.Where(players, predicate);
		List<object> list = Enumerable.ToList(source);
		object obj14;
		GameObject gameObject;
		string text3;
		object obj19;
		GameObject gameObject2;
		string text;
		if (list._size > 0)
		{
			list.Reverse();
			obj14 = typeof(MemberAchievementClanFeedData) + 2976;
			this.list.SetPlayers((IEnumerable<PlayerInfo>)list);
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				bool flag4 = countText;
				bool flag5 = !flag4;
				object obj16 = !flag5;
				text = null;
				if (obj16 == null)
				{
					goto IL_016e;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = countText;
				bool flag7 = !flag6;
				text = null;
				if (flag7)
				{
					goto IL_016e;
				}
			}
			TextMeshProUGUI textMeshProUGUI = countText;
			List<PlayerInfoWrapper> data = this.list.data;
			int num = default(int);
			string text2 = num.ToString();
			nint num2 = (nint)textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v19 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
			obj13 = 0;
			textMeshProUGUI.text = text2;
			gameObject = emptyState;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6291]");
			object obj17 = (nint)0 & (nint)1;
			bool flag8 = obj17 == null;
			object obj18 = !flag8;
			text = text2;
			text3 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v19 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
			obj19 = 0;
			gameObject2 = emptyState;
			if (obj18 != null)
			{
				goto IL_01c5;
			}
			goto IL_0343;
		}
		PopulateEmptyState();
		return;
		IL_0343:
		_ = 1;
		object obj20 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v17+E4]");
		bool flag9 = (nint)0 == 0;
		object obj21 = !flag9;
		UnityEngine.Object obj22 = gameObject2;
		text = text3;
		obj13 = obj19;
		UnityEngine.Object obj23 = gameObject2;
		if (obj21 != null)
		{
			goto IL_0202;
		}
		goto IL_03a1;
		IL_01c5:
		obj20 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v17+E4]");
		bool flag10 = (nint)0 == 0;
		obj22 = gameObject;
		obj23 = gameObject;
		if (!flag10)
		{
			goto IL_0202;
		}
		goto IL_03a1;
		IL_0202:
		bool flag11 = obj22;
		bool flag12 = !flag11;
		object obj24 = !flag12;
		if (obj24 == null)
		{
			return;
		}
		goto IL_03de;
		IL_016e:
		gameObject = emptyState;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6291]");
		object obj25 = (nint)0 & (nint)1;
		bool flag13 = obj25 == null;
		text3 = text;
		obj19 = obj13;
		gameObject2 = emptyState;
		if (!flag13)
		{
			goto IL_01c5;
		}
		goto IL_0343;
		IL_03a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag14 = obj23;
		bool flag15 = !flag14;
		obj22 = obj23;
		if (!flag15)
		{
			goto IL_03de;
		}
		return;
		IL_03de:
		((GameObject)obj22).SetActive(value: false);
	}

	private void PopulateEmptyState()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		//IL_00c2: Expected O, but got I
		//IL_028c: Expected O, but got I4
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01d5: Expected I, but got O
		//IL_01e5: Expected O, but got I
		//IL_0212: Expected O, but got I
		//IL_022c: Expected O, but got I4
		//IL_023c: Expected O, but got I
		//IL_02ec: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		this.list.SetPlayers((IEnumerable<PlayerInfo>)list);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v7+E4]");
		string text;
		if ((nint)0 != 0)
		{
			bool flag = countText;
			bool flag2 = !flag;
			object obj4 = !flag2;
			text = null;
			if (obj4 == null)
			{
				goto IL_00a2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = countText;
			bool flag4 = !flag3;
			text = null;
			if (flag4)
			{
				goto IL_00a2;
			}
		}
		TextMeshProUGUI textMeshProUGUI = countText;
		object obj5 = ", stale={0}" + 3424;
		text = (string)obj5;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v12 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj6 = 0;
		textMeshProUGUI.text = (string)obj5;
		GameObject gameObject = emptyState;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6291]");
		object obj7 = (nint)0 & (nint)1;
		bool flag5 = obj7 == null;
		object obj8 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v12 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj9 = 0;
		string text2 = (string)obj5;
		GameObject gameObject2 = emptyState;
		if (obj8 != null)
		{
			goto IL_00f9;
		}
		goto IL_025c;
		IL_015c:
		UnityEngine.Object obj10;
		((GameObject)obj10).SetActive(value: true);
		return;
		IL_0136:
		if ((bool)obj10)
		{
			goto IL_015c;
		}
		return;
		IL_02ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj11;
		bool flag6 = obj11;
		bool flag7 = !flag6;
		object obj12 = !flag7;
		obj10 = obj11;
		if (obj12 == null)
		{
			return;
		}
		goto IL_015c;
		IL_00a2:
		gameObject = emptyState;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6291]");
		object obj13 = (nint)0 & (nint)1;
		bool flag8 = obj13 == null;
		obj9 = obj6;
		text2 = text;
		gameObject2 = emptyState;
		if (!flag8)
		{
			goto IL_00f9;
		}
		goto IL_025c;
		IL_025c:
		_ = 1;
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v9+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		obj10 = gameObject2;
		obj6 = obj9;
		text = text2;
		obj11 = gameObject2;
		if (obj15 != null)
		{
			goto IL_0136;
		}
		goto IL_02ba;
		IL_00f9:
		obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v9+E4]");
		bool flag10 = (nint)0 == 0;
		obj10 = gameObject;
		obj11 = gameObject;
		if (!flag10)
		{
			goto IL_0136;
		}
		goto IL_02ba;
	}

	private void TrySetActive(GameObject go, bool active)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_0118: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6291]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = go;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			return;
		}
		goto IL_009a;
		IL_009a:
		go.SetActive(active);
		return;
		IL_0074:
		if ((bool)go)
		{
			goto IL_009a;
		}
	}
}
