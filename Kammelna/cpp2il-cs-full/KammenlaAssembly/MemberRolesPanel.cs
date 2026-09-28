using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Features.Clans;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class MemberRolesPanel : MonoBehaviour, IInitializable
{
	private ClanMembersListView membersList;

	private InputFieldTMProUGUI searchInput;

	private ClanModel _clan;

	private string _query;

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0113: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00bf: Expected O, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0190: Expected O, but got I
		//IL_01a8: Expected I, but got O
		//IL_015d: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85FC]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			obj5 = searchInput;
			obj6 = searchInput;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = searchInput;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = searchInput;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (flag4)
		{
			goto IL_00d2;
		}
		goto IL_0170;
		IL_00d2:
		LoadMembers();
		return;
		IL_0170:
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj11 = (nint)0 + (nint)208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj11);
		searchInput.OnValueChanged += action;
		LoadMembers();
		return;
		IL_0091:
		bool flag5 = obj5 != null;
		bool flag6 = !flag5;
		object obj12 = !flag6;
		obj8 = 0;
		obj9 = null;
		if (obj12 == null)
		{
			goto IL_00d2;
		}
		goto IL_0170;
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00ec: Expected I, but got O
		//IL_0071: Expected I, but got O
		//IL_00b7: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj2 = (nint)0 + (nint)192;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj4 = (nint)0 + (nint)200;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ClanServerConnector.OnClanRosterChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action2 = default(Action<int>);
		action2..ctor((object)this, (IntPtr)obj4);
		ClanServerConnector.OnMemberPermissionsUpdated += action2;
		ITrackEvent trackEvent = TrackerLibrary.ClanRolesViewed();
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	public void Initialize()
	{
		ClearSearch();
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_0084: Expected I, but got O
		//IL_005d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj2 = (nint)0 + (nint)192;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj4 = (nint)0 + (nint)200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ClanServerConnector.OnClanRosterChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action2 = default(Action<int>);
		action2..ctor((object)this, (IntPtr)obj4);
		ClanServerConnector.OnMemberPermissionsUpdated -= action2;
	}

	public void LoadMembers()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_008e: Expected O, but got I
		//IL_00b8: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(Queue<string>) + 728;
		object obj2 = (nint)0 + (nint)1976;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj4 = (nint)0 + (nint)184;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.GetMyClan(action);
	}

	private void OnClanRosterChanged(ClanModel clan)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		if (clan != null)
		{
			object obj = this + 48;
			obj = clan;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			RefreshList();
		}
	}

	private void OnMemberPermissionsUpdated(int memberId)
	{
		LoadMembers();
	}

	private void OnClanLoaded(ClanModel clan)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		if (clan != null)
		{
			object obj = this + 48;
			obj = clan;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			RefreshList();
		}
	}

	private void ClearSearch()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_0070: Expected O, but got I
		//IL_008f: Expected O, but got I4
		//IL_002b: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+90]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+B8]");
		object obj4 = 0;
		object obj5 = this + 56;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X20_v3-10]");
			if (!((UnityEngine.Object)0 != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X20_v3-10]");
			bool flag = (UnityEngine.Object)0 != null;
			bool flag2 = !flag;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				return;
			}
		}
		searchInput.ClearInput();
	}

	private void OnSearchChanged(string query)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 56;
		obj = query;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		RefreshList();
	}

	private void RefreshList()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0052: Expected I, but got O
		if (_clan != null)
		{
			object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 760;
			object obj2 = (nint)0 + (nint)176;
			IEnumerable<ClanUserModel> getMembers = _clan.GetMembers;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)this, (IntPtr)obj2);
			IEnumerable<object> users = Enumerable.Where(getMembers, func);
			membersList.Initialize((IEnumerable<ClanUserModel>)users);
		}
	}

	public MemberRolesPanel()
	{
		//IL_000f: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_002f: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v2+90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = this + 56;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private bool <RefreshList>b__14_0(ClanUserModel user)
	{
		if (ClanUtils.IsMe(user))
		{
			return true;
		}
		return ClanUtils.MatchesSearch(user, _query);
	}
}
