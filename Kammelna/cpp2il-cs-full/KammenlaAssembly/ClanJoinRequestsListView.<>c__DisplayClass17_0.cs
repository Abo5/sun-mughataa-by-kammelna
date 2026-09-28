using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Features.Clans;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class ClanJoinRequestsListView : UiListView<ClanJoinRequestDataHolder, ClanJoinRequestStrip>
{
	private sealed class <>c__DisplayClass12_0
	{
		public ClanJoinRequestsListView <>4__this;

		public int userId;

		public ClanJoinRequestStrip strip;

		internal void <Accept>b__0(bool succeeded, KammelnaError error)
		{
			bool accepted = default(bool);
			<>4__this.Resolve(userId, strip, succeeded, error, accepted);
		}
	}

	private sealed class <>c__DisplayClass13_0
	{
		public ClanJoinRequestsListView <>4__this;

		public int userId;

		public ClanJoinRequestStrip strip;

		internal void <Reject>b__0(bool succeeded, KammelnaError error)
		{
			bool accepted = default(bool);
			<>4__this.Resolve(userId, strip, succeeded, error, accepted);
		}
	}

	private sealed class <>c__DisplayClass15_0
	{
		public ClanJoinRequestsListView <>4__this;

		public string template;

		internal bool <RebuildData>b__0(ClanUserModel user)
		{
			//IL_0052: Expected I4, but got O
			ClanJoinRequestsListView clanJoinRequestsListView = <>4__this;
			if ((object)<>4__this != null)
			{
				return ClanUtils.MatchesSearch(user, clanJoinRequestsListView._query);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal unsafe ClanJoinRequestDataHolder <RebuildData>b__1(ClanUserModel user)
		{
			//IL_0005: Expected native int or pointer, but got O
			//IL_000f: Expected native int or pointer, but got O
			//IL_001d: Expected native int or pointer, but got O
			//IL_004c: Expected native int or pointer, but got O
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected O, but got Unknown
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			ClanJoinRequestDataHolder clanJoinRequestDataHolder = default(ClanJoinRequestDataHolder);
			System.Runtime.CompilerServices.Unsafe.Write(&((ClanJoinRequestDataHolder*)(nint)clanJoinRequestDataHolder)-><template>k__BackingField, null);
			System.Runtime.CompilerServices.Unsafe.Write(&((ClanJoinRequestDataHolder*)(nint)clanJoinRequestDataHolder)-><User>k__BackingField, null);
			((ClanJoinRequestDataHolder*)(nint)clanJoinRequestDataHolder)-><index>k__BackingField = 0;
			if (user != null)
			{
				((ClanJoinRequestDataHolder*)(nint)clanJoinRequestDataHolder)-><index>k__BackingField = user.UserId;
				object obj = clanJoinRequestDataHolder + 8;
				obj = template;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj2 = clanJoinRequestDataHolder + 16;
				obj2 = user;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				ClanJoinRequestDataHolder result = default(ClanJoinRequestDataHolder);
				return result;
			}
			return (ClanJoinRequestDataHolder)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public ClanJoinRequestsListView <>4__this;

		public int userId;

		internal void <Resolve>b__0()
		{
			<>4__this.RemoveData(userId);
		}
	}

	private sealed class <>c__DisplayClass17_0
	{
		public int userId;

		internal bool <RemoveData>b__0(ClanUserModel u)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (u != null)
			{
				object obj = u.UserId - userId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const string RequestActionErrorTitleKey = "Join request";

	private GameObject NoRequests;

	private TextMeshProUGUI RequestCounter;

	private InputFieldTMProUGUI SearchInput;

	private readonly List<ClanUserModel> _requesters;

	private string _query;

	private bool _started;

	protected override void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		//IL_004b: Expected O, but got I4
		//IL_0055: Expected O, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I
		//IL_00ee: Expected I, but got O
		object obj = (nint)0 + (nint)584;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Start();
		_started = true;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag = SearchInput != null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (obj4 == null)
			{
				goto IL_0068;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = SearchInput != null;
			bool flag4 = !flag3;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (flag4)
			{
				goto IL_0068;
			}
		}
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj8 = (nint)0 + (nint)1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj8);
		SearchInput.OnValueChanged += action;
		Reload();
		return;
		IL_0068:
		Reload();
	}

	private void OnEnable()
	{
		if (_started)
		{
			ClearSearch();
			Reload();
		}
	}

	private void ClearSearch()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a1: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+90]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+B8]");
		object query = 0;
		_query = (string)query;
		object obj4 = this + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			if (!(SearchInput != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = SearchInput != null;
			bool flag2 = !flag;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				return;
			}
		}
		SearchInput.ClearInput();
	}

	private void OnSearchChanged(string query)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		_query = query;
		object obj = this + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		RebuildData();
	}

	public void Reload()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0181: Expected O, but got I
		//IL_0270: Expected O, but got I4
		//IL_0219: Expected O, but got I4
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02d4: Expected O, but got I
		//IL_030b: Expected I, but got O
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87AB]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v26+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v26+E4]");
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
		IL_02b4:
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 256;
		object obj8 = (nint)0 + (nint)1168;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int clanId = SFSKammelnaUserExtensions.GetClanId(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj8);
		ClanServerConnector clanServerConnector;
		clanServerConnector.GetJoinRequests(clanId, action);
		return;
		IL_0322:
		throw new NullReferenceException();
		IL_01f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_02b4;
		}
		goto IL_0322;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		bool flag4 = (object)sessionModel2 == null;
		object obj10 = !flag4;
		if (obj10 != null)
		{
			goto IL_0137;
		}
		goto IL_0322;
		IL_0137:
		User localUser2 = sessionModel2.LocalUser;
		if (localUser2 == null)
		{
			return;
		}
		object obj11 = typeof(Queue<string>) + 728;
		object obj12 = (nint)0 + (nint)1976;
		object obj13 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v5+E4]");
		ClanServerConnector clanServerConnector3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v12+E4]");
			bool flag5 = (nint)0 == 0;
			ClanServerConnector clanServerConnector2 = default(ClanServerConnector);
			clanServerConnector = clanServerConnector2;
			clanServerConnector3 = clanServerConnector2;
			if (!flag5)
			{
				goto IL_01f5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v12+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			ClanServerConnector clanServerConnector4 = default(ClanServerConnector);
			clanServerConnector = clanServerConnector4;
			clanServerConnector3 = clanServerConnector4;
			if (obj15 != null)
			{
				goto IL_01f5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		clanServerConnector = clanServerConnector3;
		goto IL_02b4;
	}

	public void Accept(int userId, ClanJoinRequestStrip strip)
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
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I4
		//IL_0111: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 728;
		object obj4 = (nint)0 + (nint)1976;
		object obj5 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 256;
		object obj6 = (nint)0 + (nint)3840;
		object obj7 = obj2 + 16;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 32;
		obj8 = strip;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool, System.Int32Enum> action = default(Action<bool, System.Int32Enum>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+18]");
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.AcceptJoinRequest(0, (Action<bool, KammelnaError>)(object)action);
	}

	public void Reject(int userId, ClanJoinRequestStrip strip)
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
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I4
		//IL_0111: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 728;
		object obj4 = (nint)0 + (nint)1976;
		object obj5 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 256;
		object obj6 = (nint)0 + (nint)3848;
		object obj7 = obj2 + 16;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 32;
		obj8 = strip;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool, System.Int32Enum> action = default(Action<bool, System.Int32Enum>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+18]");
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.RejectJoinRequest(0, (Action<bool, KammelnaError>)(object)action);
	}

	private void Populate(IEnumerable<ClanUserModel> requesters)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00ca: Expected O, but got I4
		//IL_0084: Expected O, but got I4
		//IL_00e5: Expected O, but got I
		//IL_00fd: Expected O, but got I
		//IL_031f: Expected O, but got I
		//IL_032f: Expected O, but got I
		//IL_0345: Expected O, but got I
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_036d: Expected O, but got I4
		//IL_037d: Expected O, but got I
		//IL_0132: Expected O, but got I
		//IL_0148: Expected O, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0175: Expected O, but got I
		//IL_03df: Expected O, but got I
		//IL_03ef: Expected O, but got I
		//IL_0405: Expected O, but got I
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_03b7: Expected O, but got I4
		//IL_01b8: Expected O, but got I
		//IL_01c8: Expected O, but got I
		//IL_01de: Expected O, but got I
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_0206: Expected O, but got I4
		//IL_0216: Expected O, but got I
		//IL_0243: Expected O, but got I
		//IL_0440: Expected O, but got I
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87AE]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			if (requesters != null)
			{
				goto IL_005b;
			}
		}
		else
		{
			_ = 1;
			bool flag = requesters == null;
			object obj3 = !flag;
			if (obj3 != null)
			{
				goto IL_005b;
			}
		}
		object obj4 = (nint)0 + (nint)3800;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X20_v5+38]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X20_v5+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v11+10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v11+10]");
			object obj8 = (nint)0 + (nint)309;
			object obj9 = obj8 & 1;
			bool flag2 = obj9 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v11+10]");
			object obj10 = 0;
			if (!flag2)
			{
				goto IL_0183;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X20_v5+38]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v18+10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v18+10]");
			object obj12 = (nint)0 + (nint)309;
			object obj13 = obj12 & 1;
			bool flag3 = obj13 == null;
			object obj14 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v18+10]");
			object obj10 = 0;
			if (obj14 != null)
			{
				goto IL_0183;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 != null)
		{
			goto IL_01a8;
		}
		goto IL_03c5;
		IL_01a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X20_v5+38]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v25+10]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v25+10]");
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag5 = obj19 == null;
		object obj20 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v25+10]");
		object obj21 = 0;
		if (obj20 == null)
		{
			goto IL_0224;
		}
		goto IL_0233;
		IL_0267:
		List<object> requesters2;
		int version = requesters2._version + 1;
		requesters2._size = 0;
		requesters2._version = version;
		if (requesters2._size >= 1)
		{
			Array.Clear(requesters2._items, 0, requesters2._size);
			requesters2 = (List<object>)(object)_requesters;
		}
		List<object> list;
		requesters2.AddRange(list);
		RebuildData();
		ClanRequestsBadge.MarkSeen((IEnumerable<ClanUserModel>)list);
		return;
		IL_03c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X20_v5+38]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v13+10]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v13+10]");
		object obj23 = (nint)0 + (nint)309;
		object obj24 = obj23 & 1;
		if (obj24 == null)
		{
			goto IL_0224;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v13+10]");
		obj21 = 0;
		goto IL_0233;
		IL_005b:
		List<object> list2 = Enumerable.ToList((IEnumerable<object>)requesters);
		bool flag6 = _requesters == null;
		object obj25 = !flag6;
		requesters2 = (List<object>)(object)_requesters;
		list = list2;
		if (obj25 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0267;
		IL_0233:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v18+B8]");
		object source = 0;
		List<object> list3 = Enumerable.ToList((IEnumerable<object>)source);
		requesters2 = (List<object>)(object)_requesters;
		list = list3;
		goto IL_0267;
		IL_0224:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0233;
		IL_0183:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			goto IL_01a8;
		}
		goto IL_03c5;
	}

	private void RebuildData()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		//IL_009a: Expected O, but got I4
		//IL_0104: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01b2: Expected O, but got I
		//IL_01c3: Expected I, but got O
		//IL_01d4: Expected O, but got I
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0216: Expected O, but got I
		//IL_0227: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = obj2 + 16;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				bool flag = this == null;
				bool flag2 = !flag;
				object obj6 = 0;
				if (!flag2)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = this == null;
				bool flag4 = !flag3;
				object obj7 = !flag4;
				object obj6 = 0;
				if (obj7 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanJoinRequestsListView)+38]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanJoinRequestsListView)+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6+20]");
					string text = ((UnityEngine.Object)0).name;
					object obj9 = obj2 + 24;
					obj9 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 760;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj11 = (nint)0 + (nint)3856;
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor(obj2, (IntPtr)obj11);
					object obj12 = (nint)0 + (nint)3368;
					IEnumerable<object> source = Enumerable.Where(_requesters, func);
					object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 768;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj14 = (nint)0 + (nint)3864;
					Func<object, ClanJoinRequestDataHolder> func2 = default(Func<object, ClanJoinRequestDataHolder>);
					func2..ctor(obj2, (IntPtr)obj14);
					IEnumerable<ClanJoinRequestDataHolder> source2 = Enumerable.Select(source, func2);
					List<ClanJoinRequestDataHolder> list = Enumerable.ToList(source2);
					base.data = list;
					if (((UiListView<ClanJoinRequestDataHolder, object>)(object)this).TemplatesReady)
					{
						base.UpdateView();
					}
					UpdateState();
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void Resolve(int userId, ClanJoinRequestStrip strip, bool succeeded, KammelnaError error, bool accepted)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I4
		//IL_00f4: Expected O, but got I4
		//IL_009f: Expected O, but got I4
		//IL_0292: Expected O, but got I4
		//IL_029b: Expected O, but got I4
		//IL_02a4: Expected O, but got I4
		//IL_0156: Expected O, but got I4
		//IL_015f: Expected O, but got I4
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I
		//IL_020c: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			bool flag = this == null;
			bool flag2 = !flag;
			object obj6 = 0;
			UnityEngine.Object obj7 = null;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = this == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj6 = 0;
			UnityEngine.Object obj7 = null;
			if (obj8 != null)
			{
				return;
			}
		}
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v11+E4]");
		if ((nint)0 == 0)
		{
			goto IL_025f;
		}
		bool flag5 = strip != null;
		bool flag6 = !flag5;
		object obj10 = 0;
		object obj11 = 0;
		if (!flag6)
		{
			goto IL_016d;
		}
		goto IL_02b2;
		IL_025f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag7 = strip != null;
		bool flag8 = !flag7;
		object obj12 = !flag8;
		obj10 = 0;
		obj11 = 0;
		if (obj12 != null)
		{
			goto IL_016d;
		}
		goto IL_02b2;
		IL_039c:
		int userId2;
		RemoveData(userId2);
		return;
		IL_02b2:
		if (!succeeded)
		{
			goto IL_0332;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+18]");
		userId2 = 0;
		goto IL_039c;
		IL_0332:
		object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object title = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3104;
		PopupWindowBuilder.ShowError((string)title, friendlyName);
		return;
		IL_016d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+18]");
		userId2 = 0;
		if (succeeded)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [strip @ X2 (ClanJoinRequestStrip)+40]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+18]");
			bool flag9 = num != 0;
			obj11 = obj10;
			if (!flag9)
			{
				object obj14 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj15 = (nint)0 + (nint)3872;
				Action action = default(Action);
				action..ctor(obj2, (IntPtr)obj15);
				if (action != null)
				{
					IntPtr invoke_impl = ((Delegate)action).invoke_impl;
					IntPtr method_code = ((Delegate)action).method_code;
					IntPtr method = ((Delegate)action).method;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v161 @ X2_v11 (System.IntPtr) (should have been resolved before IL gen)");
					goto IL_025f;
				}
				return;
			}
			goto IL_039c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [strip @ X2 (ClanJoinRequestStrip)+40]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+18]");
		bool flag10 = num2 != 0;
		obj11 = obj10;
		if (!flag10)
		{
			strip.SetInteractable(interactable: true);
			obj11 = obj10;
		}
		goto IL_0332;
	}

	private void RemoveData(int userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I4
		//IL_00d3: Expected O, but got I4
		//IL_0082: Expected O, but got I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0110: Expected O, but got I
		//IL_0121: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag = this == null;
			bool flag2 = !flag;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = this == null;
			bool flag4 = !flag3;
			object obj7 = !flag4;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (obj7 != null)
			{
				return;
			}
		}
		object obj8 = typeof(List<Tween>) + 3168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)3880;
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj2, (IntPtr)obj9);
		int num = ((List<object>)(object)_requesters).RemoveAll(predicate);
		RebuildData();
	}

	private void UpdateState()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_01d2: Expected O, but got I4
		//IL_006c: Expected O, but got I4
		//IL_0075: Expected O, but got I4
		//IL_0209: Expected I, but got O
		//IL_0219: Expected O, but got I
		//IL_025a: Expected O, but got I4
		//IL_02ab: Expected O, but got I4
		//IL_0107: Expected O, but got I4
		//IL_0110: Expected O, but got I4
		//IL_0154: Expected I4, but got O
		//IL_0310: Expected O, but got I4
		//IL_0319: Expected O, but got I4
		//IL_0190: Expected O, but got I4
		//IL_03e3: Expected O, but got I4
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected I4, but got Unknown
		List<ClanUserModel> requesters = _requesters;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
		object obj4;
		UnityEngine.Object obj5;
		if ((nint)0 != 0)
		{
			bool flag = RequestCounter != null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			obj4 = 0;
			obj5 = null;
			if (obj3 == null)
			{
				goto IL_0088;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = RequestCounter != null;
			bool flag4 = !flag3;
			obj4 = 0;
			obj5 = null;
			if (flag4)
			{
				goto IL_0088;
			}
		}
		TextMeshProUGUI requestCounter = RequestCounter;
		int num = default(int);
		string text = num.ToString();
		nint num2 = (nint)requestCounter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v14 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		obj4 = 0;
		requestCounter.text = text;
		UnityEngine.Object noRequests = NoRequests;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v16+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		obj5 = (UnityEngine.Object)(object)text;
		UnityEngine.Object noRequests2 = NoRequests;
		if (obj7 != null)
		{
			goto IL_00e3;
		}
		goto IL_027a;
		IL_036f:
		GameObject gameObject = SearchInput.gameObject;
		bool flag6 = num < 0;
		bool flag7 = num == 0;
		int num3 = num ^ num;
		int num4 = num & num3;
		bool flag8 = num4 < 0;
		bool flag9 = flag6 == flag8;
		object obj8 = !flag7;
		bool active = (byte)((flag9 & obj8) ? 1 : 0) != 0;
		gameObject.SetActive(active);
		return;
		IL_016c:
		UnityEngine.Object searchInput;
		bool flag10 = searchInput != null;
		bool flag11 = !flag10;
		object obj9 = !flag11;
		if (obj9 == null)
		{
			return;
		}
		goto IL_036f;
		IL_0339:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object searchInput2;
		if (!(searchInput2 != null))
		{
			return;
		}
		goto IL_036f;
		IL_0088:
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v16+E4]");
		bool flag12 = (nint)0 == 0;
		num = requesters._size;
		noRequests = NoRequests;
		num = requesters._size;
		noRequests2 = NoRequests;
		if (!flag12)
		{
			goto IL_00e3;
		}
		goto IL_027a;
		IL_027a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag13 = noRequests2 != null;
		bool flag14 = !flag13;
		object obj10 = 0;
		UnityEngine.Object obj11 = null;
		if (flag14)
		{
			goto IL_0123;
		}
		goto IL_02be;
		IL_00e3:
		bool flag15 = noRequests != null;
		bool flag16 = !flag15;
		object obj12 = !flag16;
		obj10 = 0;
		obj11 = null;
		if (obj12 == null)
		{
			goto IL_0123;
		}
		goto IL_02be;
		IL_02be:
		bool flag17 = num == 0;
		NoRequests.SetActive(flag17);
		searchInput = SearchInput;
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v9+E4]");
		bool flag18 = (nint)0 == 0;
		object obj14 = !flag18;
		obj10 = 0;
		bool flag19 = flag17;
		searchInput2 = SearchInput;
		if (obj14 != null)
		{
			goto IL_016c;
		}
		goto IL_0339;
		IL_0123:
		searchInput = SearchInput;
		obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v9+E4]");
		bool flag20 = (nint)0 == 0;
		flag19 = (byte)(int)obj11 != 0;
		searchInput2 = SearchInput;
		if (!flag20)
		{
			goto IL_016c;
		}
		goto IL_0339;
	}

	protected unsafe override bool GetNewItem(ClanJoinRequestDataHolder datum, out ClanJoinRequestStrip item)
	{
		//IL_000c: Expected O, but got I
		//IL_0050: Expected O, but got Ref
		//IL_0042: Expected I4, but got O
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1432;
		int num = default(int);
		bool newItem = ((ListViewController<ClanJoinRequestDataHolder, object, int>)(object)this).GetNewItem((ClanJoinRequestDataHolder)(&num), out System.Runtime.CompilerServices.Unsafe.As<ClanJoinRequestStrip, object>(ref item));
		if ((object)item != null)
		{
			object obj2 = item + 168;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return newItem;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public ClanJoinRequestsListView()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_002a: Expected O, but got I4
		//IL_003a: Expected O, but got I
		//IL_004a: Expected O, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		_requesters = (List<ClanUserModel>)(object)list;
		object obj2 = this + 384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+90]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v5+B8]");
		_query = (string)0;
		object obj5 = this + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((UiListView<ClanJoinRequestDataHolder, object>)(object)this)..ctor();
	}

	private void <Reload>b__11_0(IEnumerable<ClanUserModel> requesters)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0112: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87B5]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this != null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			return;
		}
		goto IL_0099;
		IL_0099:
		Populate(requesters);
		return;
		IL_0074:
		if (this != null)
		{
			goto IL_0099;
		}
	}
}
