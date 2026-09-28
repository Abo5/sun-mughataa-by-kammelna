using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class ClanInterClanLeaderboardUI : MonoBehaviour, IInitializable
{
	private sealed class <>c__DisplayClass19_0
	{
		public ClanInterClanLeaderboardUI <>4__this;

		public Games game;

		public DateTime month;

		internal void <Reload>b__0(List<InterClanLeaderboardEntryModel> entries)
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_01b0: Expected O, but got I4
			//IL_01b9: Expected O, but got I4
			//IL_0153: Expected O, but got I4
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Expected O, but got Unknown
			//IL_024c: Expected O, but got I4
			//IL_02c4: Expected O, but got I4
			if (!<>4__this.isActiveAndEnabled)
			{
				return;
			}
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v7+E4]");
			if ((nint)0 != 0)
			{
				Games currentGame = Preferences.CurrentGame;
				if (game != currentGame)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Games currentGame2 = Preferences.CurrentGame;
				if (game != currentGame2)
				{
					return;
				}
			}
			ClanInterClanLeaderboardUI clanInterClanLeaderboardUI = <>4__this;
			object obj3 = typeof(DataRelation) + 712;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v9+E4]");
			object obj5;
			if ((nint)0 != 0)
			{
				bool flag = month != clanInterClanLeaderboardUI._selectedMonth;
				bool flag2 = !flag;
				obj5 = 0;
				DateTime selectedMonth = clanInterClanLeaderboardUI._selectedMonth;
				if (!flag2)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = month != clanInterClanLeaderboardUI._selectedMonth;
				bool flag4 = !flag3;
				object obj6 = !flag4;
				obj5 = 0;
				DateTime selectedMonth = clanInterClanLeaderboardUI._selectedMonth;
				if (obj6 != null)
				{
					return;
				}
			}
			ClanInterClanLeaderboardUI clanInterClanLeaderboardUI2 = <>4__this;
			object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v15+E4]");
			if ((nint)0 != 0)
			{
				bool flag5 = clanInterClanLeaderboardUI2.loader;
				bool flag6 = !flag5;
				object obj9 = !flag6;
				if (obj9 != null)
				{
					goto IL_0299;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if ((bool)clanInterClanLeaderboardUI2.loader)
				{
					goto IL_0299;
				}
			}
			goto IL_02c9;
			IL_0299:
			ClanInterClanLeaderboardUI clanInterClanLeaderboardUI3 = <>4__this;
			clanInterClanLeaderboardUI3.loader.SetActive(value: false);
			obj5 = 0;
			goto IL_02c9;
			IL_02c9:
			<>4__this.Render(entries);
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public int myClanId;

		internal bool <Render>b__0(InterClanLeaderboardEntryModel entry)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (entry != null)
			{
				object obj = entry.ClanId - myClanId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const string CURRENT_MONTH_KEY = "ClanLeaderboardCurrentMonth";

	private const string LAST_MONTH_KEY = "ClanLeaderboardLastMonth";

	private ClanLeaderboardWidget top3Widget;

	private InterClanLeaderboardListView listView;

	private GameObject loader;

	private GameObject emptyState;

	private TextMeshProUGUI monthLabel;

	private GameObject myClanSection;

	private InterClanLeaderboardRow myClanRow;

	private bool startOnCurrentMonth = true;

	private DateTime _selectedMonth;

	private bool _initialized;

	private void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0051: Expected I, but got O
		if (_initialized)
		{
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)1120;
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				Preferences.OnGameChanged -= action;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Preferences.OnGameChanged -= action;
		}
	}

	public void Initialize()
	{
		Show();
	}

	public void Show()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0084: Expected O, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_0170: Expected O, but got I4
		//IL_0123: Expected O, but got I4
		//IL_01bd: Expected I, but got O
		//IL_01ec: Expected O, but got I4
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8687]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			if (_initialized)
			{
				goto IL_005b;
			}
		}
		else
		{
			_ = 1;
			bool flag = !_initialized;
			object obj3 = !flag;
			if (obj3 != null)
			{
				goto IL_005b;
			}
		}
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1208;
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)1120;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj8 = obj4;
		DateTime selectedMonth;
		if (startOnCurrentMonth)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			selectedMonth = ClanInterClanLeaderboardManager.CurrentMonth;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			selectedMonth = ClanInterClanLeaderboardManager.LastMonth;
		}
		_selectedMonth = selectedMonth;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Preferences.OnGameChanged += action;
		_initialized = true;
		Reload();
		return;
		IL_005b:
		Reload();
	}

	public void SelectCurrentMonth()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0071: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1208;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime currentMonth = ClanInterClanLeaderboardManager.CurrentMonth;
		_selectedMonth = currentMonth;
		Reload();
	}

	public void SelectLastMonth()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0071: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1208;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime lastMonth = ClanInterClanLeaderboardManager.LastMonth;
		_selectedMonth = lastMonth;
		Reload();
	}

	public void Refresh()
	{
		Reload();
	}

	private void SelectMonth(DateTime month)
	{
		_selectedMonth = month;
		Reload();
	}

	private void Reload()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I4
		//IL_01e8: Expected O, but got I4
		//IL_01f1: Expected O, but got I4
		//IL_01fa: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_027a: Expected O, but got I4
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_02cc: Expected O, but got I4
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_032d: Expected O, but got I
		//IL_033e: Expected I, but got O
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_037c: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v11+E4]");
		bool flag3;
		if ((nint)0 != 0)
		{
			bool flag = loader;
			bool flag2 = !flag;
			object obj6 = !flag2;
			flag3 = false;
			if (obj6 == null)
			{
				goto IL_00db;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = loader;
			bool flag5 = !flag4;
			flag3 = false;
			if (flag5)
			{
				goto IL_00db;
			}
		}
		loader.SetActive(value: true);
		UnityEngine.Object obj7 = emptyState;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v27+E4]");
		bool flag6 = (nint)0 == 0;
		object obj9 = !flag6;
		object obj10 = 0;
		object obj11 = 0;
		flag3 = true;
		UnityEngine.Object obj12 = emptyState;
		if (obj9 != null)
		{
			goto IL_0124;
		}
		goto IL_021b;
		IL_021b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag7 = obj12;
		bool flag8 = !flag7;
		obj10 = obj11;
		bool flag9 = false;
		if (!flag8)
		{
			goto IL_0261;
		}
		goto IL_0288;
		IL_0288:
		UpdateMonthLabel();
		object obj13 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v14+E4]");
		bool flag10 = (nint)0 == 0;
		object obj15 = !flag10;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		_ = _selectedMonth;
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)3760;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj17);
		object obj18 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1208;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v20+E4]");
		bool flag11 = (nint)0 == 0;
		object obj20 = !flag11;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ClanInterClanLeaderboardManager.Get(currentGame, _selectedMonth, action);
		return;
		IL_0261:
		emptyState.SetActive(value: false);
		obj10 = 0;
		flag9 = false;
		goto IL_0288;
		IL_0124:
		bool flag12 = obj7;
		bool flag13 = !flag12;
		object obj21 = !flag13;
		if (obj21 != null)
		{
			goto IL_0261;
		}
		flag9 = false;
		goto IL_0288;
		IL_00db:
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v27+E4]");
		bool flag14 = (nint)0 == 0;
		obj7 = emptyState;
		obj11 = obj10;
		obj12 = emptyState;
		if (!flag14)
		{
			goto IL_0124;
		}
		goto IL_021b;
	}

	private void Render(List<InterClanLeaderboardEntryModel> entries)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_03d6: Expected O, but got I
		//IL_0413: Expected O, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_01ac: Expected O, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I
		//IL_0282: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0333: Expected O, but got I
		//IL_034f: Expected I, but got O
		//IL_0306: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 768;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int clanId = SFSKammelnaUserExtensions.GetClanId(localUser);
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj9;
		bool flag4;
		if (entries != null)
		{
			object obj8 = (nint)0 + (nint)832;
			listView.SetData(entries, clanId);
			obj9 = obj8;
			IEnumerable<object> source = Enumerable.Take((IEnumerable<object>)entries, 3);
			List<object> top = Enumerable.ToList(source);
			top3Widget.Populate((List<InterClanLeaderboardEntryModel>)(object)top);
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v16+E4]");
			if ((nint)0 != 0)
			{
				bool flag2 = emptyState;
				bool flag3 = !flag2;
				object obj11 = !flag3;
				if (obj11 != null)
				{
					goto IL_02da;
				}
				flag4 = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag5 = emptyState;
				bool flag6 = !flag5;
				flag4 = false;
				if (!flag6)
				{
					goto IL_02da;
				}
			}
			goto IL_0313;
		}
		object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v14+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "Index = {0} position = {1}" + 1736;
		PopupWindow.ShowError((string)message);
		object obj15 = typeof(List<AdaptivePerformanceScaler>) + 1840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		InterClanLeaderboardListView interClanLeaderboardListView = listView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Object)+10]");
		interClanLeaderboardListView.SetData((List<InterClanLeaderboardEntryModel>)(object)list, 0);
		object obj16 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v15+E4]");
		InterClanLeaderboardEntryModel myEntry;
		if ((nint)0 != 0)
		{
			bool flag8 = emptyState;
			bool flag9 = !flag8;
			object obj17 = !flag9;
			if (obj17 != null)
			{
				goto IL_03af;
			}
			myEntry = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag10 = emptyState;
			bool flag11 = !flag10;
			myEntry = null;
			if (!flag11)
			{
				goto IL_03af;
			}
		}
		goto IL_0421;
		IL_0313:
		object obj18 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1968;
		object obj19 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj4, (IntPtr)obj19);
		object obj20 = Enumerable.FirstOrDefault(entries, func);
		myEntry = (InterClanLeaderboardEntryModel)obj20;
		goto IL_0421;
		IL_0421:
		UpdateMyClan(myEntry);
		return;
		IL_03af:
		emptyState.SetActive(value: true);
		myEntry = null;
		goto IL_0421;
		IL_02da:
		bool flag12 = entries._size == 0;
		emptyState.SetActive(flag12);
		obj9 = 0;
		flag4 = flag12;
		goto IL_0313;
	}

	private void UpdateMyClan(InterClanLeaderboardEntryModel myEntry)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_00b6: Expected O, but got I4
		//IL_00cd: Expected O, but got I4
		//IL_015a: Expected O, but got I4
		//IL_0163: Expected O, but got I4
		//IL_016c: Expected O, but got I4
		//IL_021a: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_01d5: Expected O, but got I4
		//IL_027a: Expected O, but got I4
		//IL_02ab: Expected O, but got I4
		//IL_03ea: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E868C]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v30+E4]");
			bool flag = (nint)0 == 0;
			obj5 = myClanSection;
			obj6 = myClanSection;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v30+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = myClanSection;
			obj6 = myClanSection;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		object obj10 = 0;
		if (obj8 == null)
		{
			goto IL_017a;
		}
		goto IL_0228;
		IL_0228:
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v3+E4]");
		bool flag7;
		if ((nint)0 != 0)
		{
			bool flag5 = myClanSection;
			bool flag6 = !flag5;
			object obj12 = !flag6;
			flag7 = false;
			if (obj12 == null)
			{
				goto IL_0291;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag8 = myClanSection;
			bool flag9 = !flag8;
			flag7 = false;
			if (flag9)
			{
				goto IL_0291;
			}
		}
		bool flag10 = myEntry == null;
		bool flag11 = !flag10;
		myClanSection.SetActive(flag11);
		bool flag12 = myEntry == null;
		flag7 = flag11;
		if (!flag12)
		{
			goto IL_034c;
		}
		return;
		IL_034c:
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			if (!myClanRow)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag13 = myClanRow;
			bool flag14 = !flag13;
			object obj14 = !flag14;
			if (obj14 == null)
			{
				return;
			}
		}
		myClanRow.Populate(myEntry, isMyClan: true);
		return;
		IL_0291:
		bool flag15 = myEntry == null;
		object obj15 = !flag15;
		if (obj15 == null)
		{
			return;
		}
		goto IL_034c;
		IL_0091:
		bool flag16 = obj5;
		bool flag17 = !flag16;
		obj9 = 0;
		if (flag17)
		{
			goto IL_017a;
		}
		obj10 = 0;
		goto IL_0228;
		IL_017a:
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v24+E4]");
		if ((nint)0 != 0)
		{
			bool flag18 = myClanRow;
			bool flag19 = !flag18;
			object obj17 = !flag19;
			obj10 = 0;
			if (obj17 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag20 = myClanRow;
			bool flag21 = !flag20;
			obj10 = 0;
			if (flag21)
			{
				return;
			}
		}
		goto IL_0228;
	}

	private void UpdateMonthLabel()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01cd: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_011c: Expected O, but got I4
		//IL_0217: Expected O, but got I4
		//IL_0220: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E868D]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = monthLabel;
			obj6 = monthLabel;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = monthLabel;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = monthLabel;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c0;
		IL_00c0:
		object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1208;
		object obj11 = "Cannot populate JSON object onto type '{0}'." + 2976;
		object obj12 = "Cannot populate JSON object onto type '{0}'." + 2984;
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = ClanInterClanLeaderboardManager.IsCurrentMonth(_selectedMonth);
		bool flag7 = !flag6;
		object obj15 = !flag7;
		object obj16 = ~obj15;
		object text = ((obj16 != null) ? obj12 : obj11);
		TextMeshProExtensions.Localize(monthLabel, (string)text);
		return;
		IL_0091:
		bool flag8 = obj5;
		bool flag9 = !flag8;
		obj9 = 0;
		if (!flag9)
		{
			goto IL_00c0;
		}
	}
}
