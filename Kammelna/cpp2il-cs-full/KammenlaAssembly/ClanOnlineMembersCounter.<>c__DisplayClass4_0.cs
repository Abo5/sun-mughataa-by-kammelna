using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public static class ClanOnlineMembersCounter
{
	private sealed class <>c__DisplayClass4_0
	{
		public int requestedClanId;

		internal void <RefreshRoster>b__0(ClanModel clan)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0194: Expected O, but got I4
			//IL_020f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0214: Expected O, but got Unknown
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87E5]");
			object obj3 = (nint)0 & (nint)1;
			object obj6;
			object obj4;
			if (obj3 != null)
			{
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v17+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v17+E4]");
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
			obj4 = obj6;
			goto IL_0140;
			IL_0140:
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			if (localUser == null)
			{
				return;
			}
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			int clanId = SFSKammelnaUserExtensions.GetClanId(localUser2);
			if (clanId == requestedClanId)
			{
				object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1328;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v12+E4]");
				if ((nint)0 != 0)
				{
					ApplyRoster(clan);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				ApplyRoster(clan);
			}
			return;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag4 = (object)sessionModel == null;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0140;
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public int myId;

		internal bool <Recount>b__0(int id)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_0071: Expected I8, but got I4
			//IL_0055: Expected I8, but got I4
			if (id == myId)
			{
				return false;
			}
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1680;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return PresenceManager.IsOnline(id);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return PresenceManager.IsOnline(id);
		}
	}

	private static readonly HashSet<int> MemberIds;

	private static void Bootstrap()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01e1: Expected O, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_0201: Expected O, but got I
		//IL_020d: Expected O, but got I
		//IL_0219: Expected O, but got I
		//IL_0231: Expected I, but got O
		//IL_025b: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0094: Expected I, but got O
		//IL_00bf: Expected I, but got O
		//IL_00e5: Expected I, but got O
		//IL_0110: Expected I, but got O
		//IL_0136: Expected I, but got O
		//IL_0161: Expected I, but got O
		//IL_0187: Expected I, but got O
		//IL_01b2: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1456;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1680;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj5 = (nint)0 + (nint)1432;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1624;
		object obj7 = (nint)0 + (nint)1448;
		object obj8 = (nint)0 + (nint)1464;
		object obj9 = (nint)0 + (nint)1440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PresenceManager.OnPresenceChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(null, (IntPtr)obj2);
		PresenceManager.OnPresenceChanged += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)null, (IntPtr)obj5);
		ClanServerConnector.OnClanRosterChanged -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)null, (IntPtr)obj5);
		ClanServerConnector.OnClanRosterChanged += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)null, (IntPtr)obj7);
		ClanServerConnector.OnMyMembershipChanged -= action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)null, (IntPtr)obj7);
		ClanServerConnector.OnMyMembershipChanged += action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action7 = default(Action);
		action7..ctor(null, (IntPtr)obj8);
		CoordinatorService.OnConnected -= action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action8 = default(Action);
		action8..ctor(null, (IntPtr)obj8);
		CoordinatorService.OnConnected += action8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action9 = default(Action);
		action9..ctor(null, (IntPtr)obj9);
		SFS.OnLogout -= action9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action10 = default(Action);
		action10..ctor(null, (IntPtr)obj9);
		SFS.OnLogout += action10;
	}

	private static void OnMyMembershipChanged(ClanUserModel membership)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87DF]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RefreshRoster();
		return;
		IL_007c:
		RefreshRoster();
	}

	private static void OnLogout()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ab: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87E0]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ApplyRoster(null);
		return;
		IL_0074:
		ApplyRoster(null);
	}

	private static void RefreshRoster()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_02c4: Expected O, but got I
		//IL_0301: Expected O, but got I4
		//IL_0070: Expected O, but got I4
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		//IL_010e: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01d4: Expected O, but got I4
		//IL_01fd: Expected O, but got I
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_0236: Expected O, but got I
		//IL_0247: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1240;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		bool flag2 = localUser == null;
		object obj7 = 0;
		if (!flag2)
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			int clanId = SFSKammelnaUserExtensions.GetClanId(localUser2);
			bool flag4 = clanId <= 0;
			obj7 = 0;
			if (!flag4)
			{
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v22+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel3 = default(SessionModel);
				User localUser3 = sessionModel3.LocalUser;
				int clanId2 = SFSKammelnaUserExtensions.GetClanId(localUser3);
				object obj12 = typeof(Queue<string>) + 728;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v28+E4]");
				bool flag6 = (nint)0 == 0;
				object obj14 = !flag6;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj15 = (nint)0 + (nint)1976;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj17 = (nint)0 + (nint)456;
				Action<object> action = default(Action<object>);
				action..ctor(obj4, (IntPtr)obj17);
				ClanServerConnector clanServerConnector = default(ClanServerConnector);
				clanServerConnector.GetMyClan(action);
				return;
			}
		}
		object obj18 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1328;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			ApplyRoster(null);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ApplyRoster(null);
	}

	private unsafe static void ApplyRoster(ClanModel clan)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0103: Expected O, but got I4
		//IL_010c: Expected O, but got I4
		//IL_011d: Expected O, but got I4
		//IL_009e: Expected O, but got I
		//IL_00c0: Expected O, but got I4
		//IL_006f: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_017e: Expected O, but got I
		//IL_0186: Expected I, but got O
		//IL_014d: Expected O, but got I
		//IL_0748: Expected O, but got I4
		//IL_01cd: Expected I, but got O
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f7: Expected I, but got O
		//IL_0207: Expected O, but got I
		//IL_02d2: Expected O, but got I4
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected O, but got Unknown
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected O, but got Unknown
		//IL_08cb: Expected O, but got I
		//IL_08f5: Expected O, but got Ref
		//IL_0242: Expected O, but got I
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_07b6: Expected O, but got I4
		//IL_0327: Expected O, but got I
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_03fa: Expected O, but got I4
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Expected O, but got Unknown
		//IL_0362: Expected O, but got I
		//IL_0600: Expected O, but got I4
		//IL_0619: Expected O, but got I4
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected O, but got Unknown
		//IL_0a61: Expected O, but got I4
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_0393: Expected O, but got I
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected O, but got Unknown
		//IL_064a: Expected O, but got I
		//IL_046c: Expected O, but got I
		//IL_06e9: Expected O, but got I4
		//IL_053f: Expected O, but got I4
		//IL_0685: Expected O, but got I
		//IL_09fa: Expected O, but got I
		//IL_0a1c: Expected O, but got I4
		//IL_04a7: Expected O, but got I
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected O, but got Unknown
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Expected O, but got Unknown
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected O, but got Unknown
		//IL_06ae: Expected O, but got I
		//IL_05a3: Expected O, but got I
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_04d8: Expected O, but got I
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87E2]");
		object obj2 = (nint)0 & (nint)1;
		object obj4;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v82+E4]");
			bool flag = (nint)0 == 0;
			obj4 = 0;
			object obj5 = obj3;
			obj4 = 0;
			if (!flag)
			{
				goto IL_008e;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v82+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj4 = 0;
			object obj5 = obj3;
			obj4 = 0;
			if (obj6 != null)
			{
				goto IL_008e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v58+B8]");
		object obj8 = 0;
		HashSet<int> hashSet = (HashSet<int>)obj8;
		if (obj8 != null)
		{
			goto IL_0172;
		}
		goto IL_0843;
		IL_0897:
		object obj9 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj10 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 440;
		object obj11 = (nint)0 + (nint)424;
		object obj13;
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v20+8]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v376 @ X8_v20] (should have been resolved before IL gen)");
		obj8 = (object)(&obj4);
		object obj14 = default(object);
		bool flag4 = default(bool);
		object obj20 = default(object);
		object obj22 = default(object);
		object obj31 = default(object);
		object obj27 = default(object);
		object obj28;
		nint num2;
		object obj18;
		while (true)
		{
			if (obj14 != null)
			{
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v24+12E]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v24+12E]");
				if ((nint)0 == 0)
				{
					goto IL_03e7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v24+B0]");
				object obj16 = (nint)0 + (nint)8;
				bool flag3 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X10_v25-8]");
					object obj17 = 0 - obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X10_v25-8]");
					if (0 == (nint)obj9)
					{
						break;
					}
					obj18 = obj16 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v24+12E]");
					obj12 = -1;
					obj17 = obj12 - 1;
					bool flag5 = obj17 == null;
					flag4 = (nint)obj12 != 1;
					flag3 = flag4;
					obj16 = obj18;
					if (flag4)
					{
						continue;
					}
					goto IL_03e7;
				}
				obj12 = obj16;
				object obj19 = obj15 + obj16;
				obj20 = obj19 + 312;
				flag4 = flag3;
				obj18 = obj16;
				goto IL_093b;
			}
			NullReferenceException ex = new NullReferenceException();
			num2 = num;
			goto IL_07ab;
			IL_093b:
			obj8 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v33+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v609 @ X0_v33] (should have been resolved before IL gen)");
			object obj21 = obj22 & 1;
			if (obj21 == null)
			{
				break;
			}
			if (obj14 != null)
			{
				object obj23 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v27+12E]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v27+12E]");
				if ((nint)0 == 0)
				{
					goto IL_052c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v27+B0]");
				object obj24 = (nint)0 + (nint)8;
				bool flag6 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X10_v20-8]");
					object obj17 = 0 - obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X10_v20-8]");
					if (0 == (nint)obj10)
					{
						break;
					}
					obj18 = obj24 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v27+12E]");
					obj12 = -1;
					obj17 = obj12 - 1;
					bool flag5 = obj17 == null;
					flag4 = (nint)obj12 != 1;
					flag6 = flag4;
					obj24 = obj18;
					if (flag4)
					{
						continue;
					}
					goto IL_052c;
				}
				obj12 = obj24;
				object obj25 = obj23 + obj24;
				object obj26 = obj25 + 312;
				flag4 = flag6;
				obj18 = obj24;
				goto IL_09c8;
			}
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_07ab;
			IL_052c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj27 = 0;
			goto IL_09c8;
			IL_07ab:
			obj28 = 0;
			obj4 = obj14;
			goto IL_0843;
			IL_09c8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X0_v37+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v671 @ X0_v37] (should have been resolved before IL gen)");
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X0_v41+E4]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X0_v41+E4]");
			bool flag7 = (nint)0 == 0;
			object obj30 = !flag7;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj29 = obj;
			}
			if (obj31 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X0_v41+B8]");
				obj8 = 0;
				if (obj8 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X0_v39+14]");
					num = 0;
					obj27 = obj11;
					object obj32 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X0_v39+14]");
					bool flag8 = ((HashSet<int>)obj32).Add(0);
					continue;
				}
				NullReferenceException ex3 = new NullReferenceException();
			}
			else
			{
				NullReferenceException ex4 = new NullReferenceException();
			}
			goto IL_07ab;
			IL_03e7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj27 = 0;
			goto IL_093b;
		}
		obj28 = 0;
		object obj33 = obj27;
		obj4 = obj14;
		object obj34 = 0;
		object obj41 = default(object);
		nint num3;
		while (true)
		{
			if (obj4 == null)
			{
				goto IL_0a47;
			}
			object obj35 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj36 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v6+12E]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v6+12E]");
			if ((nint)0 == 0)
			{
				goto IL_06d6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v6+B0]");
			object obj37 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X10_v7-8]");
				if (0 == (nint)obj35)
				{
					break;
				}
				obj18 = obj37 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v6+12E]");
				obj12 = -1;
				bool flag9 = (nint)obj12 != 1;
				obj37 = obj18;
				if (flag9)
				{
					continue;
				}
				goto IL_06d6;
			}
			obj12 = obj37;
			object obj38 = obj36 + obj37;
			object obj39 = obj38 + 312;
			obj18 = obj37;
			goto IL_0aa3;
			IL_0a47:
			bool flag10 = obj34 == null;
			object obj40 = !flag10;
			obj27 = obj33;
			num3 = num2;
			if (obj40 != null)
			{
				OutOfMemoryException ex5 = new OutOfMemoryException();
				if (num2 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj34 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					obj28 = obj41;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
			}
			break;
			IL_06d6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj33 = 0;
			goto IL_0aa3;
			IL_0aa3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v3+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v602 @ X0_v3] (should have been resolved before IL gen)");
			goto IL_0a47;
		}
		goto IL_071e;
		IL_02bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj27 = 0;
		object obj42 = default(object);
		obj13 = obj42;
		goto IL_0897;
		IL_0843:
		obj33 = obj27;
		throw new NullReferenceException();
		IL_008e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v82+B8]");
		obj8 = 0;
		hashSet = (HashSet<int>)obj8;
		bool flag11 = obj8 == null;
		object obj43 = !flag11;
		if (obj43 != null)
		{
			goto IL_0172;
		}
		goto IL_0843;
		IL_0172:
		obj8 = (nint)0 + (nint)432;
		num3 = (nint)obj8;
		hashSet.Clear();
		if (clan == null)
		{
			goto IL_071e;
		}
		IEnumerable<ClanUserModel> getMembers = clan.GetMembers;
		bool flag12 = getMembers == null;
		num2 = unchecked((nint)null);
		if (flag12)
		{
			goto IL_0843;
		}
		object obj44 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3064;
		nint num4 = (nint)getMembers;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v19 (Il2CppClass<System.Collections.Generic.IEnumerable`1<ClanUserModel>>)+12E]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v19 (Il2CppClass<System.Collections.Generic.IEnumerable`1<ClanUserModel>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02bf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v19 (Il2CppClass<System.Collections.Generic.IEnumerable`1<ClanUserModel>>)+B0]");
		object obj46 = (nint)0 + (nint)8;
		bool flag13 = flag4;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X10_v30-8]");
			object obj17 = 0 - obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X10_v30-8]");
			if (0 == (nint)obj44)
			{
				break;
			}
			obj18 = obj46 + 16;
			obj45--;
			obj17 = obj45 - 1;
			bool flag5 = obj17 == null;
			flag4 = (nint)obj45 != 1;
			flag13 = flag4;
			obj46 = obj18;
			if (flag4)
			{
				continue;
			}
			goto IL_02bf;
		}
		object obj47 = num4 + obj46;
		obj13 = obj47 + 312;
		flag4 = flag13;
		obj18 = obj46;
		goto IL_0897;
		IL_071e:
		object obj48 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v23+E4]");
		bool flag14 = (nint)0 == 0;
		object obj49 = !flag14;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Recount();
	}

	private static void Recount()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0252: Expected O, but got I
		//IL_028f: Expected O, but got I4
		//IL_0070: Expected O, but got I4
		//IL_0078: Expected I4, but got O
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I
		//IL_00e1: Expected O, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0124: Expected O, but got I4
		//IL_02ad: Expected O, but got I
		//IL_02c8: Expected I, but got O
		//IL_009c: Expected O, but got I4
		//IL_01e1: Expected O, but got I4
		//IL_019e: Expected O, but got I4
		//IL_0219: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 1248;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		bool flag2 = localUser == null;
		object obj7 = 0;
		int num = (int)localUser;
		if (!flag2)
		{
			num = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			obj7 = 0;
		}
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1328;
		object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
		object obj10 = (nint)0 + (nint)464;
		object obj11 = (nint)0 + (nint)3560;
		object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object obj13 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v13+B8]");
		object source = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<int, bool> func = default(Func<int, bool>);
		func..ctor(obj4, (IntPtr)obj10);
		int num2 = Enumerable.Count((IEnumerable<int>)source, func);
		object obj15 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v18+E4]");
		if ((nint)0 != 0)
		{
			int count = CounterBubbleManager.GetCount(CounterBubbleType.OnlineClanMembers);
			bool flag4 = num2 != count;
			object obj16 = 0;
			if (!flag4)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int count2 = CounterBubbleManager.GetCount(CounterBubbleType.OnlineClanMembers);
			bool flag5 = num2 == count2;
			object obj16 = 0;
			if (flag5)
			{
				return;
			}
		}
		object obj17 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v20+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.OnlineClanMembers, num2);
	}

	static ClanOnlineMembersCounter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 1528;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		HashSet<int> hashSet = default(HashSet<int>);
		hashSet..ctor();
		object obj3 = obj2;
		object obj4 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
