using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Core;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class PersonalizedStatsManager : MonoBehaviour
{
	private sealed class <>c__DisplayClass16_0
	{
		public PersonalizedStatsManager <>4__this;

		public PersonalizedStatReport report;

		internal void <FetchConfigsThenShowReport>b__0(KammelnaResponseModel<List<PersonalReportTypeConfig>> configsResponse)
		{
			Dictionary<PerformanceReportType, PersonalReportTypeConfig> configs = BuildConfigsDictionary(configsResponse);
			<>4__this.ShowReport(report, configs);
		}
	}

	private sealed class <>c__DisplayClass18_0
	{
		public PersonalizedStatReport report;

		public Dictionary<PerformanceReportType, PersonalReportTypeConfig> configs;

		internal void <ShowReport>b__0(PersonalizedStatsPanel statsPanel)
		{
			statsPanel.OnStatReportReceived(report, configs);
		}
	}

	private int _currentUserId;

	private ComponentReference<PersonalizedStatsPanel> panelRef;

	private unsafe DateTime LastWeeklyReportDate
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected I4, but got Unknown
			//IL_0092: Expected O, but got I4
			//IL_00b0: Expected O, but got I
			//IL_00c5: Expected O, but got I
			object obj = "LAK" + 560;
			object obj2 = typeof(DataRelation) + 712;
			int num = this + 32;
			string text = ((int*)num)->ToString();
			string key = (string)obj + text;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v5+10]");
			return PlayerPrefsGame.GetDate(key, (DateTime)0);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected I4, but got Unknown
			object obj = "LAK" + 560;
			int num = this + 32;
			string text = ((int*)num)->ToString();
			string key = (string)obj + text;
			PlayerPrefsGame.SetDate(key, value);
		}
	}

	private unsafe DateTime LastMonthlyReportDate
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected I4, but got Unknown
			//IL_0092: Expected O, but got I4
			//IL_00b0: Expected O, but got I
			//IL_00c5: Expected O, but got I
			object obj = "LAK" + 520;
			object obj2 = typeof(DataRelation) + 712;
			int num = this + 32;
			string text = ((int*)num)->ToString();
			string key = (string)obj + text;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v5+10]");
			return PlayerPrefsGame.GetDate(key, (DateTime)0);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected I4, but got Unknown
			object obj = "LAK" + 520;
			int num = this + 32;
			string text = ((int*)num)->ToString();
			string key = (string)obj + text;
			PlayerPrefsGame.SetDate(key, value);
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_005a: Expected O, but got I
		//IL_008e: Expected O, but got I4
		//IL_00c5: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
		object obj3 = (nint)0 + (nint)3144;
		GameObject gameObject = base.gameObject;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		UnityEngine.Object target = gameObject;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		UnityEngine.Object.DontDestroyOnLoad(target);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		SFS.OnLogin += action;
	}

	private void OnLogin(BaseEvent evt)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0182: Expected O, but got I
		//IL_01ac: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_0115: Expected I, but got O
		//IL_01f5: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6435]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)3168;
		object obj11 = typeof(RegisteredWaitHandle) + 3136;
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		_currentUserId = intDbId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj10);
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v28+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.WaitForScene(Scenes.Menu, action);
	}

	private void TryLoadReports()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3136;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2704;
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
		NotificationsManager.CallWhenLoaded(action);
	}

	private void TryShowMonthlyReport()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0148: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01ce: Expected O, but got I4
		//IL_0176: Expected O, but got I
		//IL_0190: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_027a: Expected O, but got I4
		//IL_0206: Expected O, but got I
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_022e: Expected O, but got I4
		//IL_0314: Expected O, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0360: Expected O, but got I4
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_03b5: Expected O, but got I
		//IL_03c3: Expected I, but got O
		object obj = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6437]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v31+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v31+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459A]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_019e;
		IL_023c:
		object obj7 = typeof(DataRelation) + 712;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		DateTime dateTime = default(DateTime);
		int year = dateTime.Year;
		int month = dateTime.Month;
		DateTime dateTime2 = new DateTime(year, month, 1);
		DateTime lastMonthlyReportDate = LastMonthlyReportDate;
		bool flag4 = lastMonthlyReportDate >= dateTime2;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v14+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)3152;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj15);
			KammelnaRequests.GetMonthlyPersonalizedStats(currentGame, action);
		}
		return;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v50+B8]");
		object obj16 = 0;
		object obj17 = obj16 & 1;
		if (obj17 != null)
		{
			return;
		}
		goto IL_023c;
		IL_01e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v25+B8]");
		object obj19 = 0;
		object obj20 = obj19 & 1;
		bool flag7 = obj20 == null;
		object obj21 = !flag7;
		if (obj21 != null)
		{
			return;
		}
		goto IL_023c;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459A]");
		object obj22 = (nint)0 & (nint)1;
		if (obj22 != null)
		{
			goto IL_00a7;
		}
		goto IL_019e;
		IL_019e:
		_ = 1;
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v50+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		object obj25 = obj23;
		if (obj24 != null)
		{
			goto IL_00dc;
		}
		goto IL_01e4;
		IL_00a7:
		obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v50+E4]");
		bool flag9 = (nint)0 == 0;
		obj25 = obj23;
		if (!flag9)
		{
			goto IL_00dc;
		}
		goto IL_01e4;
	}

	private void TryShowWeeklyReport()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0198: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I
		//IL_0118: Expected O, but got I4
		//IL_015b: Expected I, but got O
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		DateTime today = DateTime.Today;
		DateTime dateTime = default(DateTime);
		DayOfWeek dayOfWeek = dateTime.DayOfWeek;
		double value = 0.0 - (double)dayOfWeek;
		DateTime dateTime3 = default(DateTime);
		DateTime dateTime2 = dateTime3.AddDays(value);
		DateTime lastWeeklyReportDate = LastWeeklyReportDate;
		bool flag2 = lastWeeklyReportDate >= dateTime2;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 568;
			object obj7 = (nint)0 + (nint)3160;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v16+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj7);
			KammelnaRequests.GetWeeklyPersonalizedStats(currentGame, action);
		}
	}

	private unsafe void OnMonthlyStatsReportReceived(KammelnaResponseModel<PersonalizedStatReport> response)
	{
		//IL_0011: Expected O, but got I
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_02b3: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_016c: Expected O, but got I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_030e: Expected O, but got I
		//IL_0097: Expected O, but got I
		//IL_00b1: Expected O, but got I4
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected I4, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected I4, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0228: Expected O, but got I4
		object obj = (nint)0 + (nint)1296;
		DateTime dateTime;
		DateTime value;
		if (((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			object obj2 = typeof(DataRelation) + 712;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v32+E4]");
			if ((nint)0 != 0)
			{
				DateTime now = DateTime.Now;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64CD]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				dateTime = now;
				value = now;
				if (obj5 == null)
				{
					goto IL_00cf;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				DateTime now2 = DateTime.Now;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64CD]");
				object obj6 = (nint)0 & (nint)1;
				bool flag2 = obj6 == null;
				dateTime = now2;
				if (flag2)
				{
					goto IL_00cf;
				}
				value = now2;
			}
			goto IL_0340;
		}
		if (KammelnaError.InvalidCode == response.<Error>k__BackingField)
		{
			object obj7 = typeof(DataRelation) + 712;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now3 = DateTime.Now;
			object obj10 = "LAK" + 520;
			int num = this + 32;
			string text = ((int*)num)->ToString();
			string key = (string)obj10 + text;
			PlayerPrefsGame.SetDate(key, now3);
			object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "___# Content push apply failed [{0}]: {1}" + 512;
			object arg = default(object);
			string text2 = string.Format((string)format, arg);
			object obj12 = typeof(DataRelation) + 856;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v23+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			object message = text2;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text2;
			}
			Debug.Log(message);
		}
		else
		{
			object format2 = "Error reading data from socket: " + 3456;
			string text3 = string.Format((string)format2, response);
			object obj15 = typeof(DataRelation) + 856;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v10+E4]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			object message2 = text3;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message2 = text3;
			}
			Debug.LogError(message2);
		}
		return;
		IL_00cf:
		_ = 1;
		value = dateTime;
		goto IL_0340;
		IL_0340:
		int num2 = this + 32;
		string text4 = ((int*)num2)->ToString();
		object obj18 = "LAK" + 520;
		string text5 = (string)obj18 + text4;
		PlayerPrefsGame.SetDate(text5, value);
		((PersonalizedStatsManager)(object)text5).CreateMonthlyReportFeed(response.<Model>k__BackingField);
		FetchConfigsThenShowReport(response.<Model>k__BackingField);
	}

	private void CreateMonthlyReportFeed(PersonalizedStatReport report)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I4
		//IL_00dc: Expected O, but got I
		//IL_014d: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 1488;
		object obj2 = typeof(UsageHint) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MonthlyStatsReportFeedData monthlyStatsReportFeedData = default(MonthlyStatsReportFeedData);
		monthlyStatsReportFeedData..ctor(report);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UserFeedItem userFeedItem = default(UserFeedItem);
		userFeedItem..ctor();
		object obj3 = typeof(DataRelation) + 712;
		object obj4 = typeof(Queue<string>) + 888;
		object obj5 = userFeedItem + 48;
		obj5 = monthlyStatsReportFeedData;
		_ = 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = (nint)0 + (nint)2272;
		DateTime now = DateTime.Now;
		userFeedItem.<DateCreated>k__BackingField = now;
		DateTime now2 = DateTime.Now;
		DateTime dateTime = default(DateTime);
		DateTime <DateExpires>k__BackingField = dateTime.AddDays(16.00000000325963);
		userFeedItem.<DateExpires>k__BackingField = <DateExpires>k__BackingField;
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v19+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		UserFeedManager userFeedManager = default(UserFeedManager);
		userFeedManager.CreateLocalFeed(userFeedItem);
	}

	private unsafe void OnWeeklyStatsReportReceived(KammelnaResponseModel<PersonalizedStatReport> response)
	{
		//IL_0011: Expected O, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01f0: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0075: Expected O, but got I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0165: Expected O, but got I4
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected I4, but got Unknown
		object obj = (nint)0 + (nint)1296;
		if (((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			object obj2 = typeof(DataRelation) + 712;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			object obj5 = "LAK" + 560;
			int num = this + 32;
			string text = ((int*)num)->ToString();
			string key = (string)obj5 + text;
			PlayerPrefsGame.SetDate(key, now);
			FetchConfigsThenShowReport(response.<Model>k__BackingField);
		}
		else if (KammelnaError.InvalidCode == response.<Error>k__BackingField)
		{
			object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "___# Content push apply failed [{0}]: {1}" + 528;
			object arg = default(object);
			string text2 = string.Format((string)format, arg);
			object obj7 = typeof(DataRelation) + 856;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			object message = text2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text2;
			}
			Debug.Log(message);
		}
		else
		{
			object format2 = "Error reading data from socket: " + 3464;
			string text3 = string.Format((string)format2, response);
			object obj10 = typeof(DataRelation) + 856;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			object message2 = text3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message2 = text3;
			}
			Debug.LogError(message2);
		}
	}

	public void FetchConfigsThenShowReport(PersonalizedStatReport report)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I4
		//IL_00ff: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 392;
		object obj5 = (nint)0 + (nint)408;
		object obj6 = obj2 + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = report;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		KammelnaRequests.GetPersonalStatsConfigs(currentGame, action);
	}

	private static Dictionary<PerformanceReportType, PersonalReportTypeConfig> BuildConfigsDictionary(KammelnaResponseModel<List<PersonalReportTypeConfig>> response)
	{
		//IL_0345: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_01c8: Expected O, but got I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0083: Expected O, but got I
		//IL_008b: Expected I, but got O
		//IL_02dc: Expected O, but got I
		//IL_02e4: Expected I, but got O
		//IL_031b: Expected I4, but got O
		//IL_0201: Expected O, but got I
		//IL_0209: Expected I, but got O
		//IL_022c: Expected O, but got I4
		//IL_00ff: Expected O, but got I
		//IL_010b: Expected O, but got I
		//IL_035b: Expected I, but got O
		bool flag = response == null;
		Dictionary<System.Int32Enum, object> result = (Dictionary<System.Int32Enum, object>)152985600;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		NullReferenceException ex;
		nint num = default(nint);
		if (!flag)
		{
			object obj = (nint)0 + (nint)784;
			if (!((KammelnaResponseModel<object>)(object)response).Succeeded || response.<Model>k__BackingField == null)
			{
				object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
				object format = "Error reading data from socket: " + 3248;
				object obj3 = typeof(DataRelation) + 856;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object arg = default(object);
				string text = string.Format((string)format, arg);
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v17+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object message = text;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					message = text;
				}
				Debug.LogWarning(message);
				result = null;
				goto IL_03bb;
			}
			object obj6 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1848;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = (nint)0 + (nint)352;
			num = (nint)obj7;
			Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
			dictionary..ctor();
			bool flag3 = response.<Model>k__BackingField == null;
			result = dictionary;
			if (!flag3)
			{
				List<object>.Enumerator enumerator = ((List<object>)(object)response.<Model>k__BackingField).GetEnumerator();
				if (dictionary != null)
				{
					object obj8 = (nint)0 + (nint)4024;
					object obj9 = (nint)0 + (nint)368;
					num = (nint)obj8;
					if (enumerator2.MoveNext())
					{
						object obj10 = null;
						KammelnaError kammelnaError = (KammelnaError)0;
						result = dictionary;
						ex = new NullReferenceException();
						goto IL_028f;
					}
				}
				else
				{
					object obj11 = (nint)0 + (nint)4024;
					num = (nint)obj11;
					bool flag4 = enumerator2.MoveNext();
					bool flag5 = !flag4;
					object obj12 = !flag5;
					KammelnaError kammelnaError = (KammelnaError)0;
					result = dictionary;
					if (obj12 != null)
					{
						goto IL_027b;
					}
				}
				enumerator2.Dispose();
				return (Dictionary<PerformanceReportType, PersonalReportTypeConfig>)(object)dictionary;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_027b;
		IL_028f:
		bool flag6 = num != 1;
		NullReferenceException ex3 = ex;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj13 = (nint)0 + (nint)4016;
			num = (nint)obj13;
			enumerator2.Dispose();
			object obj14 = default(object);
			if (obj14 == null)
			{
				goto IL_03bb;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			KammelnaError kammelnaError = (KammelnaError)obj14;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237F2C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		Dictionary<PerformanceReportType, PersonalReportTypeConfig> result2 = default(Dictionary<PerformanceReportType, PersonalReportTypeConfig>);
		return result2;
		IL_03bb:
		return (Dictionary<PerformanceReportType, PersonalReportTypeConfig>)(object)result;
		IL_027b:
		ex = new NullReferenceException();
		goto IL_028f;
	}

	private void ShowReport(PersonalizedStatReport report, Dictionary<PerformanceReportType, PersonalReportTypeConfig> configs)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00b9: Expected I, but got O
		//IL_00e8: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2960;
		object obj4 = (nint)0 + (nint)416;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)2216;
		object obj7 = obj2 + 16;
		obj7 = report;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = configs;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private void <TryLoadReports>b__10_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f0: Expected O, but got I
		//IL_011a: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0163: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E643D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2104;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
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
			object obj4 = (nint)0 + (nint)2104;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
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
		NotificationsManager notificationsManager = default(NotificationsManager);
		bool flag3 = (object)notificationsManager == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		List<Notification> activeForcedNotifications = notificationsManager.ActiveForcedNotifications;
		if (!Enumerable.Any((IEnumerable<object>)activeForcedNotifications))
		{
			TryShowMonthlyReport();
		}
	}
}
