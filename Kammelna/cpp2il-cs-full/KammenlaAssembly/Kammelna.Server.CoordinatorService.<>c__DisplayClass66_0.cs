using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Kammelna.Server.Models.Presence;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Coordinator.Models;
using Sfs2X;
using Sfs2X.Core;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.InputSystem.XR;

namespace Kammelna.Server;

public class CoordinatorService : Singleton<CoordinatorService>
{
	private class VariableUpdatePayload
	{
		private string <scope>k__BackingField;

		private string <key>k__BackingField;

		private object <value>k__BackingField;

		public string scope
		{
			get
			{
				return <scope>k__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 16;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}

		public string key
		{
			get
			{
				return <key>k__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 24;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}

		public object value
		{
			get
			{
				return <value>k__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 32;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action <>9__53_0;

		public static Action <>9__54_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 2496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <OnSignalRConnected>b__53_0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_006c: Expected O, but got I
			//IL_007c: Expected O, but got I
			//IL_0029: Expected O, but got I
			//IL_0039: Expected O, but got I
			//IL_0049: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+78]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+78]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+18]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+28]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v43 @ X2_v1 (should have been resolved before IL gen)");
			}
		}

		internal void <OnSignalRClosed>b__54_0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0208: Expected O, but got I4
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_0191: Expected O, but got I4
			//IL_00db: Expected O, but got I4
			//IL_01da: Expected O, but got I4
			//IL_01e3: Expected O, but got I4
			//IL_0118: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = obj;
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (!Authentication.CanLogin())
			{
				return;
			}
			object obj4 = typeof(Queue<string>) + 736;
			object obj5 = (nint)0 + (nint)1992;
			object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v7+E4]");
			UnityEngine.Object obj9;
			UnityEngine.Object obj10 = default(UnityEngine.Object);
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v6+E4]");
				bool flag = (nint)0 == 0;
				obj9 = obj10;
				if (!flag)
				{
					goto IL_00b9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj11 = !flag2;
				obj9 = obj10;
				if (obj11 != null)
				{
					goto IL_00b9;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj9 != null;
			bool flag4 = !flag3;
			object obj12 = !flag4;
			object obj13 = 0;
			UnityEngine.Object obj14 = null;
			if (obj12 == null)
			{
				return;
			}
			goto IL_00ee;
			IL_00b9:
			bool flag5 = obj10 != null;
			bool flag6 = !flag5;
			obj13 = 0;
			obj14 = null;
			if (!flag6)
			{
				goto IL_00ee;
			}
			return;
			IL_00ee:
			object obj15 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v17+E4]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			CoordinatorService coordinatorService = default(CoordinatorService);
			coordinatorService.Initialize();
		}
	}

	private sealed class <>c__DisplayClass50_0
	{
		public Action callback;

		internal void <Disconnect>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = obj;
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Actions.SafeInvoke(callback);
		}
	}

	private sealed class <>c__DisplayClass55_0
	{
		public PrivateMessageModel message;

		internal void <OnMessageReceived>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0076: Expected O, but got I
			//IL_0086: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_0043: Expected O, but got I
			//IL_0053: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
			if ((nint)0 != 0)
			{
				PrivateMessageModel privateMessageModel = message;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+28]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass56_0
	{
		public ConnectionStatusUpdate status;

		internal void <OnConnectionStatusUpdated>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0076: Expected O, but got I
			//IL_0086: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_0043: Expected O, but got I
			//IL_0053: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+10]");
			if ((nint)0 != 0)
			{
				ConnectionStatusUpdate connectionStatusUpdate = status;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+28]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass57_0
	{
		public List<int> friendsIds;

		internal void <OnOnlineFriendsUpdated>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0076: Expected O, but got I
			//IL_0086: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_0043: Expected O, but got I
			//IL_0053: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+18]");
			if ((nint)0 != 0)
			{
				List<int> list = friendsIds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+28]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass58_0
	{
		public GameInvitationModel invitation;

		internal void <OnGameInvitationReceived>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0076: Expected O, but got I
			//IL_0086: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_0043: Expected O, but got I
			//IL_0053: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+20]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				GameInvitationModel gameInvitationModel = invitation;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+28]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass61_0
	{
		public int id;

		internal void <OnRemoveFriendReceived>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0076: Expected O, but got I
			//IL_0086: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_0043: Expected O, but got I
			//IL_0053: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+28]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+28]");
			if ((nint)0 != 0)
			{
				int num = id;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+28]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass62_0
	{
		public Friend friend;

		internal void <OnFriendStatusUpdateReceived>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0076: Expected O, but got I
			//IL_0086: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_0043: Expected O, but got I
			//IL_0053: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+30]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+30]");
			if ((nint)0 != 0)
			{
				Friend friend = this.friend;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+28]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass63_0
	{
		public VariableUpdatePayload payload;

		public string valueJson;

		internal void <OnVariableUpdateReceived>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_009f: Expected O, but got I
			//IL_00af: Expected O, but got I
			//IL_005c: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_007c: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+38]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+38]");
			if ((nint)0 != 0)
			{
				VariableUpdatePayload variableUpdatePayload = payload;
				string text = valueJson;
				string <scope>k__BackingField = variableUpdatePayload.<scope>k__BackingField;
				string <key>k__BackingField = variableUpdatePayload.<key>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+28]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v59 @ X5_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass64_0
	{
		public ClanFeedModel feed;

		internal void <OnClanFeedAddedReceived>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0076: Expected O, but got I
			//IL_0086: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_0043: Expected O, but got I
			//IL_0053: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+40]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+40]");
			if ((nint)0 != 0)
			{
				ClanFeedModel clanFeedModel = feed;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+28]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass65_0
	{
		public ClanFeedRemovedModel payload;

		internal void <OnClanFeedRemovedReceived>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0076: Expected O, but got I
			//IL_0086: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_0043: Expected O, but got I
			//IL_0053: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+48]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+48]");
			if ((nint)0 != 0)
			{
				ClanFeedRemovedModel clanFeedRemovedModel = payload;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+28]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass66_0
	{
		public ClanFeedPinChangeModel payload;

		internal void <OnClanFeedPinChangedReceived>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0076: Expected O, but got I
			//IL_0086: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_0043: Expected O, but got I
			//IL_0053: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+50]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+50]");
			if ((nint)0 != 0)
			{
				ClanFeedPinChangeModel clanFeedPinChangeModel = payload;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+28]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass67_0
	{
		public ClanFeedLikeChangeModel payload;

		internal void <OnClanFeedLikeChangedReceived>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0076: Expected O, but got I
			//IL_0086: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_0043: Expected O, but got I
			//IL_0053: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+58]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+58]");
			if ((nint)0 != 0)
			{
				ClanFeedLikeChangeModel clanFeedLikeChangeModel = payload;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+28]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass68_0
	{
		public ClanMembershipChanged payload;

		internal void <OnClanMembershipChangedReceived>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00a3: Expected O, but got I
			//IL_00b3: Expected O, but got I
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0065: Expected O, but got I
			//IL_0073: Expected I, but got O
			//IL_00f2: Expected O, but got I
			//IL_0102: Expected O, but got I
			//IL_0112: Expected O, but got I
			ClanMembershipChanged clanMembershipChanged = payload;
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			if (clanMembershipChanged.ChangeType != ClanMembershipChangeType.RoleChanged)
			{
				object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 480;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj3 = (nint)0 + (nint)1856;
				Action<object> action = default(Action<object>);
				action..ctor((object)null, (IntPtr)obj3);
				KammelnaRequests.RefreshAuthTokens(action, forceRefresh: true);
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+68]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+68]");
			if ((nint)0 != 0)
			{
				ClanMembershipChanged clanMembershipChanged2 = payload;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v8+18]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v8+40]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v8+28]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v87 @ X3_v2 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass69_0
	{
		public ClanRosterChanged payload;

		internal void <OnClanRosterChangedReceived>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0076: Expected O, but got I
			//IL_0086: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_0043: Expected O, but got I
			//IL_0053: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+70]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+70]");
			if ((nint)0 != 0)
			{
				ClanRosterChanged clanRosterChanged = payload;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+28]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass70_0
	{
		public List<PresenceEntry> entries;

		internal void <OnPresenceUpdateReceived>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			//IL_0042: Expected O, but got I4
			object obj = 152993792;
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			if (entries != null)
			{
				object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
				List<object>.Enumerator enumerator = ((List<object>)(object)entries).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj3 = 0;
				}
				enumerator2.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			IntPtr intPtr = default(IntPtr);
			bool flag = intPtr != (IntPtr)1;
			NullReferenceException ex2 = ex;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				enumerator2.Dispose();
				object obj4 = default(object);
				if (obj4 == null)
				{
					return;
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				object obj5 = obj4;
				ex2 = (NullReferenceException)(object)ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223C744");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		}
	}

	public static ISignalRConnector Connector;

	public static event Action<PrivateMessageModel> OnPrivateMessage
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3104;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3104;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<ConnectionStatusUpdate> OnConnectionStatusUpdate
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1704;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1704;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<List<int>> OnOnlineFriendsUpdate
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 800;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+18]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 800;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+18]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<GameInvitationModel> OnGameInvitation
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2080;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+20]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2080;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+20]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<int> OnRemoveFriend
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+28]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+28]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<Friend> OnFriendStatusUpdate
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2008;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+30]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2008;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+30]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<string, string, string> OnVariableUpdate
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 976;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+38]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 976;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+38]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<ClanFeedModel> OnClanFeedAdded
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1472;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+40]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1472;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+40]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<ClanFeedRemovedModel> OnClanFeedRemoved
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1488;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+48]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1488;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+48]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<ClanFeedPinChangeModel> OnClanFeedPinChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1480;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+50]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)80;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1480;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+50]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)80;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<ClanFeedLikeChangeModel> OnClanFeedLikeChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1464;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+58]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)88;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1464;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+58]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)88;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<long, PresenceState> OnPresenceUpdated
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 528;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+60]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 528;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+60]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<ClanMembershipChanged> OnClanMembershipChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1544;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+68]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)104;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1544;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+68]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)104;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<ClanRosterChanged> OnClanRosterChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1584;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+70]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)112;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1584;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+70]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)112;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action OnConnected
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+78]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)120;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+78]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)120;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_019b: Expected I, but got O
		//IL_005d: Expected I, but got O
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01d5: Expected O, but got I
		//IL_01e5: Expected O, but got I
		//IL_0099: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
		object obj2 = (nint)0 + (nint)3832;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnLogin += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj5 = typeof(RegisteredWaitHandle) + 1880;
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v5+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v6+20]");
		Delegate obj9 = (Delegate)0;
		bool flag;
		Delegate obj13 = default(Delegate);
		do
		{
			Delegate obj10 = Delegate.Combine(obj9, action2);
			Delegate obj14;
			if ((object)obj10 == null || obj10 == obj3)
			{
				object obj11 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X9_v6+B8]");
				object obj12 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag = (object)obj13 == obj9;
				obj9 = obj13;
				obj14 = obj13;
				continue;
			}
			obj14 = null;
			throw new InvalidCastException();
		}
		while (!flag);
		GameObject target = base.gameObject;
		object obj15 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v9+E4]");
		if ((nint)0 != 0)
		{
			UnityEngine.Object.DontDestroyOnLoad(target);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.DontDestroyOnLoad(target);
	}

	private void OnDestroy()
	{
		Disconnect();
	}

	private void OnLogin(BaseEvent _)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3736;
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
		FriendsManager.CallWhenLoaded(action);
	}

	private void OnLogout()
	{
		Disconnect();
	}

	private void Disconnect(Action callback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0065: Expected O, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0111: Expected O, but got I
		//IL_0156: Expected O, but got I4
		//IL_029c: Expected O, but got I
		//IL_02bf: Expected I, but got O
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_019f: Expected O, but got I
		//IL_01da: Expected O, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
		object obj4 = obj2 + 16;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v4+B8]");
		object obj6 = 0;
		if (obj6 != null)
		{
			object obj7 = typeof(DataRelation) + 712;
			object obj8 = typeof(UsageHint) + 72;
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = typeof(SqlSingle[]) + 2376;
			object obj12 = (nint)0 + (nint)3504;
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = default(DateTime);
			long ticks = dateTime.Ticks;
			object obj13 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj14 = !flag2;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UserInfo.ChatLastUpdatedAt = ticks;
			object obj15 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v10+B8]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj12);
			object obj18 = typeof(System.IOAsyncCallback) + 1216;
			object obj19 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v14+12E]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v14+12E]");
			if ((nint)0 == 0)
			{
				goto IL_021b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v14+B0]");
			object obj21 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v5-8]");
				if (0 == (nint)obj18)
				{
					break;
				}
				obj21 += 16;
				obj20--;
				if ((nint)obj20 != 1)
				{
					continue;
				}
				goto IL_021b;
			}
			object obj22 = obj21 + 7;
			object obj23 = obj19 + obj22;
			object obj24 = obj23 + 312;
			goto IL_02e8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_02e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v271 @ X0_v20] (should have been resolved before IL gen)");
		return;
		IL_021b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_02e8;
	}

	private void Reconnect()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		((CoordinatorService)(object)action).Disconnect(action);
	}

	public void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_0640: Expected O, but got I
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0291: Expected O, but got I
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0461: Expected O, but got I
		//IL_047b: Expected O, but got I4
		//IL_00c7: Expected O, but got I
		//IL_00e9: Expected O, but got I4
		//IL_00f9: Expected O, but got I
		//IL_02f0: Expected O, but got I
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_043b: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_04f1: Expected O, but got I
		//IL_0501: Expected O, but got I
		//IL_04b9: Expected O, but got I4
		//IL_06e7: Expected I, but got O
		//IL_011f: Expected O, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0165: Expected O, but got I4
		//IL_0534: Expected O, but got I
		//IL_0352: Expected O, but got I
		//IL_0362: Expected O, but got I
		//IL_0385: Expected O, but got I4
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected O, but got Unknown
		//IL_03d1: Expected O, but got I
		//IL_03f5: Expected O, but got I4
		//IL_040d: Expected O, but got I
		//IL_01a8: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0735: Expected O, but got I
		//IL_056f: Expected O, but got I
		//IL_06c5: Expected O, but got I
		//IL_01e3: Expected O, but got I
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected O, but got Unknown
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
		object obj2 = typeof(System.IOAsyncCallback) + 1216;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj12;
		object obj15;
		object obj17;
		if (obj4 != null)
		{
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v27+12E]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v27+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v27+B0]");
			object obj8 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X10_v19-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj8 += 16;
				obj7--;
				if ((nint)obj7 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj9 = obj8 + 8;
			object obj10 = obj6 + obj9;
			object obj11 = obj10 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v56+8]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v143 @ X0_v56] (should have been resolved before IL gen)");
			object obj13 = default(object);
			bool flag = obj13 == null;
			object obj14 = !flag;
			object obj16 = default(object);
			obj15 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v56+8]");
			obj17 = 0;
			if (obj14 != null)
			{
				goto IL_0107;
			}
			goto IL_041b;
		}
		object obj18 = typeof(System.Formats.Asn1.SetOfValueComparer) + 384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = default(object);
		obj19..ctor();
		object obj20 = obj;
		object obj21 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v9+B8]");
		object obj23 = 0;
		object obj24 = obj23;
		object obj25 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45F2]");
			object obj27 = (nint)0 & (nint)1;
			if (obj27 != null)
			{
				goto IL_030d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45F2]");
			object obj28 = (nint)0 & (nint)1;
			bool flag2 = obj28 == null;
			object obj29 = !flag2;
			if (obj29 != null)
			{
				goto IL_030d;
			}
		}
		_ = 1;
		object obj30 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v26+E4]");
		bool flag3 = (nint)0 == 0;
		object obj31 = !flag3;
		object obj32 = obj30;
		if (obj31 != null)
		{
			goto IL_0342;
		}
		goto IL_04cf;
		IL_071d:
		object obj34 = default(object);
		object obj33 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v10+8]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v370 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_05b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_071d;
		IL_0224:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_06ad;
		IL_0107:
		object obj36 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v33+B8]");
		object obj37 = 0;
		object obj38 = obj37;
		object obj39 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj40 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v42+E4]");
		bool flag4 = (nint)0 == 0;
		object obj41 = !flag4;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string serverID = Config.ServerID;
		object obj42 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v38+12E]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v38+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0224;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v38+B0]");
		object obj44 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X10_v14-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj44 += 16;
			obj43--;
			if ((nint)obj43 != 1)
			{
				continue;
			}
			goto IL_0224;
		}
		object obj45 = obj44 + 3;
		object obj46 = obj42 + obj45;
		object obj47 = obj46 + 312;
		goto IL_06ad;
		IL_030d:
		obj30 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v26+E4]");
		bool flag5 = (nint)0 == 0;
		obj32 = obj30;
		if (!flag5)
		{
			goto IL_0342;
		}
		goto IL_04cf;
		IL_04cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj48 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v17+B8]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v17+30]");
		object obj50 = 0;
		TokenModel accessToken = Authentication.AccessToken;
		goto IL_050f;
		IL_0342:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v26+B8]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v23+30]");
		obj50 = 0;
		accessToken = Authentication.AccessToken;
		bool flag6 = accessToken == null;
		object obj52 = !flag6;
		if (obj52 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_050f;
		IL_050f:
		string <Token>k__BackingField = accessToken.<Token>k__BackingField;
		object obj53 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v13+12E]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v13+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05b0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v13+B0]");
		object obj55 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X10_v6-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj55 += 16;
			obj54--;
			if ((nint)obj54 != 1)
			{
				continue;
			}
			goto IL_05b0;
		}
		object obj56 = obj53 + obj55;
		obj34 = obj56 + 312;
		goto IL_071d;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v53+8]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ X0_v53] (should have been resolved before IL gen)");
		object obj57 = default(object);
		bool flag7 = obj57 == null;
		obj15 = 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v53+8]");
		obj17 = 0;
		if (!flag7)
		{
			goto IL_0107;
		}
		goto IL_041b;
		IL_041b:
		object obj58 = typeof(SqlSingle[]) + 2376;
		object obj59 = (nint)0 + (nint)3744;
		goto IL_06cf;
		IL_06ad:
		object obj60 = obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X0_v46+8]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v379 @ X3_v3 (should have been resolved before IL gen)");
		goto IL_06cf;
		IL_06cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj59);
		((CoordinatorService)(object)action).Disconnect(action);
	}

	public static void OnSignalRConnected()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_020b: Expected O, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01a1: Expected O, but got I
		//IL_01b1: Expected O, but got I
		//IL_01d3: Expected O, but got I4
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02cb: Expected O, but got I
		//IL_02dc: Expected I, but got O
		//IL_02fa: Expected O, but got I
		//IL_026a: Expected O, but got I4
		//IL_023b: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(CardUtils.<>c) + 2496;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E828D]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
		Action action = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00e6;
		}
		goto IL_01e9;
		IL_00e6:
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		Action callback = action;
		if (!flag4)
		{
			goto IL_011b;
		}
		goto IL_0288;
		IL_0288:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.CallInMainThread(callback);
		return;
		IL_011b:
		KUtil.CallInMainThread(action);
		return;
		IL_0085:
		obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
		action = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		if (!flag5)
		{
			goto IL_00e6;
		}
		goto IL_01e9;
		IL_01e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj14 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)3496;
		Action action2 = default(Action);
		action2..ctor(obj8, (IntPtr)obj15);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v9+B8]");
		object obj17 = (nint)0 + (nint)8;
		obj17 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		action = action2;
		callback = action2;
		if (obj18 != null)
		{
			goto IL_011b;
		}
		goto IL_0288;
	}

	public static void OnSignalRClosed()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_020b: Expected O, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01a1: Expected O, but got I
		//IL_01b1: Expected O, but got I
		//IL_01d3: Expected O, but got I4
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02cb: Expected O, but got I
		//IL_02dc: Expected I, but got O
		//IL_02fa: Expected O, but got I
		//IL_026a: Expected O, but got I4
		//IL_023b: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(CardUtils.<>c) + 2496;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E828E]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+10]");
		Action action = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+10]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00e6;
		}
		goto IL_01e9;
		IL_00e6:
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		Action callback = action;
		if (!flag4)
		{
			goto IL_011b;
		}
		goto IL_0288;
		IL_0288:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.CallInMainThread(callback);
		return;
		IL_011b:
		KUtil.CallInMainThread(action);
		return;
		IL_0085:
		obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+10]");
		action = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+10]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		if (!flag5)
		{
			goto IL_00e6;
		}
		goto IL_01e9;
		IL_01e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj14 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)3488;
		Action action2 = default(Action);
		action2..ctor(obj8, (IntPtr)obj15);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v9+B8]");
		object obj17 = (nint)0 + (nint)16;
		obj17 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		action = action2;
		callback = action2;
		if (obj18 != null)
		{
			goto IL_011b;
		}
		goto IL_0288;
	}

	public static void OnMessageReceived(string jsonBody)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_011b: Expected O, but got I
		//IL_0158: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_006b: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00bf: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2512;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj3 = (nint)0 + (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)3512;
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj10 = obj4 + 16;
		object obj11 = default(object);
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj4, (IntPtr)obj8);
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			KUtil.CallInMainThread(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.CallInMainThread(action);
	}

	public static void OnConnectionStatusUpdated(string jsonBody)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_011b: Expected O, but got I
		//IL_0158: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_006b: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00bf: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2520;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj3 = (nint)0 + (nint)4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)3520;
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj10 = obj4 + 16;
		object obj11 = default(object);
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj4, (IntPtr)obj8);
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			KUtil.CallInMainThread(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.CallInMainThread(action);
	}

	public static void OnOnlineFriendsUpdated(string jsonBody)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_011b: Expected O, but got I
		//IL_0158: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_006b: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00bf: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2528;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj3 = (nint)0 + (nint)3888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)3528;
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj10 = obj4 + 16;
		object obj11 = default(object);
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj4, (IntPtr)obj8);
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			KUtil.CallInMainThread(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.CallInMainThread(action);
	}

	public static void OnGameInvitationReceived(string jsonBody)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_011b: Expected O, but got I
		//IL_0158: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_006b: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00bf: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2536;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj3 = (nint)0 + (nint)4056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)3536;
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj10 = obj4 + 16;
		object obj11 = default(object);
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj4, (IntPtr)obj8);
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			KUtil.CallInMainThread(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.CallInMainThread(action);
	}

	public static void OnDisconnectReceived(string jsonBody)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0133: Expected O, but got I
		//IL_014d: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0175: Expected O, but got I
		//IL_019f: Expected O, but got I4
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_00f0: Expected O, but got I4
		//IL_0235: Expected O, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_026e: Expected O, but got I
		//IL_0218: Expected O, but got I
		//IL_030c: Expected O, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0357: Expected O, but got I
		//IL_02a9: Expected O, but got I
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E838E]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = (nint)0 + (nint)2152;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj11 = obj8;
		if (obj10 != null)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_02ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj13 = default(object);
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v6+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v132 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_0316;
		IL_0316:
		object obj16 = default(object);
		object obj15 = obj16 + 7;
		object obj18;
		object obj17 = obj18 + obj15;
		object obj19 = obj17 + 312;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v8+8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v133 @ X3_v2 (should have been resolved before IL gen)");
		goto IL_0361;
		IL_0361:
		throw new NullReferenceException();
		IL_008b:
		obj8 = (nint)0 + (nint)2152;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		obj11 = obj8;
		if (!flag4)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_01b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_01ce;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj22 = default(object);
		bool flag5 = obj22 == null;
		object obj23 = !flag5;
		if (obj23 != null)
		{
			goto IL_01ce;
		}
		goto IL_0361;
		IL_01ce:
		object obj24 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v3+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v3+20]");
			((SmartFox)0).Disconnect();
		}
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v4+B8]");
		object obj26 = 0;
		object obj27 = obj26;
		object obj28 = typeof(System.IOAsyncCallback) + 1216;
		obj18 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v8+12E]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v8+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02ea;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v8+B0]");
		obj16 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X10_v4-8]");
			if (0 == (nint)obj28)
			{
				break;
			}
			obj16 += 16;
			obj29--;
			if ((nint)obj29 != 1)
			{
				continue;
			}
			goto IL_02ea;
		}
		goto IL_0316;
	}

	public static void OnReconnected()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2544;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			KUtil.CallInMainThread(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.CallInMainThread(action);
	}

	public static void OnRemoveFriendReceived(string friendId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_006d: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		int num = int.Parse(friendId);
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3544;
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			KUtil.CallInMainThread(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.CallInMainThread(action);
	}

	public static void OnFriendStatusUpdateReceived(string jsonBody)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_011b: Expected O, but got I
		//IL_0158: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_006b: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00bf: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2552;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj3 = (nint)0 + (nint)4048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)3552;
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj10 = obj4 + 16;
		object obj11 = default(object);
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj4, (IntPtr)obj8);
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			KUtil.CallInMainThread(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.CallInMainThread(action);
	}

	public static void OnVariableUpdateReceived(string jsonBody)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0200: Expected O, but got I
		//IL_023d: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00a1: Expected O, but got I
		//IL_00bf: Expected O, but got I4
		//IL_00eb: Expected O, but got I
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02b7: Expected O, but got I
		//IL_02c8: Expected I, but got O
		//IL_0169: Expected O, but got I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_025c: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 2560;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj3 = (nint)0 + (nint)40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj7 = obj4 + 16;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj7;
		if (obj7 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v5+10]");
		bool flag2 = string.IsNullOrEmpty((string)0);
		bool flag3 = !flag2;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			return;
		}
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v7+18]");
		if (string.IsNullOrEmpty((string)0))
		{
			return;
		}
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v8+20]");
		string text2;
		if ((nint)0 != 0)
		{
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v17+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v8+20]");
			string text = JsonConvert.SerializeObject(0);
			text2 = text;
		}
		else
		{
			text2 = null;
		}
		object obj15 = obj4 + 24;
		obj15 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj16 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)3560;
		Action action = default(Action);
		action..ctor(obj4, (IntPtr)obj17);
		object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v24+E4]");
		if ((nint)0 != 0)
		{
			KUtil.CallInMainThread(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.CallInMainThread(action);
	}

	public static void OnClanFeedAddedReceived(string jsonBody)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I4
		//IL_0048: Expected O, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00cc: Expected O, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00fb: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2568;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = (nint)0 + (nint)3960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		if (obj3 != null)
		{
			object obj7 = obj3 + 16;
			object obj8 = default(object);
			obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj7 != null)
			{
				object obj9 = typeof(SqlSingle[]) + 2376;
				object obj10 = (nint)0 + (nint)3568;
				object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Action action = default(Action);
				action..ctor(obj3, (IntPtr)obj10);
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v17+E4]");
				if ((nint)0 != 0)
				{
					KUtil.CallInMainThread(action);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				KUtil.CallInMainThread(action);
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		}
	}

	public static void OnClanFeedRemovedReceived(string jsonBody)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0139: Expected O, but got I
		//IL_0176: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00d7: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2576;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj3 = (nint)0 + (nint)3976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj7 = obj4 + 16;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj7 != null)
		{
			object obj9 = typeof(SqlSingle[]) + 2376;
			object obj10 = (nint)0 + (nint)3576;
			object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj4, (IntPtr)obj10);
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				KUtil.CallInMainThread(action);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			KUtil.CallInMainThread(action);
		}
	}

	public static void OnClanFeedPinChangedReceived(string jsonBody)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0139: Expected O, but got I
		//IL_0176: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00d7: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2584;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj3 = (nint)0 + (nint)3968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj7 = obj4 + 16;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj7 != null)
		{
			object obj9 = typeof(SqlSingle[]) + 2376;
			object obj10 = (nint)0 + (nint)3584;
			object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj4, (IntPtr)obj10);
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				KUtil.CallInMainThread(action);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			KUtil.CallInMainThread(action);
		}
	}

	public static void OnClanFeedLikeChangedReceived(string jsonBody)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0139: Expected O, but got I
		//IL_0176: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00d7: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2592;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj3 = (nint)0 + (nint)3952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj7 = obj4 + 16;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj7 != null)
		{
			object obj9 = typeof(SqlSingle[]) + 2376;
			object obj10 = (nint)0 + (nint)3592;
			object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj4, (IntPtr)obj10);
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				KUtil.CallInMainThread(action);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			KUtil.CallInMainThread(action);
		}
	}

	public static void OnClanMembershipChangedReceived(string jsonBody)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0139: Expected O, but got I
		//IL_0176: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00d7: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2600;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj3 = (nint)0 + (nint)3984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj7 = obj4 + 16;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj7 != null)
		{
			object obj9 = typeof(SqlSingle[]) + 2376;
			object obj10 = (nint)0 + (nint)3600;
			object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj4, (IntPtr)obj10);
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				KUtil.CallInMainThread(action);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			KUtil.CallInMainThread(action);
		}
	}

	public static void OnClanRosterChangedReceived(string jsonBody)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0139: Expected O, but got I
		//IL_0176: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00d7: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2608;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj3 = (nint)0 + (nint)3992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj7 = obj4 + 16;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj7 != null)
		{
			object obj9 = typeof(SqlSingle[]) + 2376;
			object obj10 = (nint)0 + (nint)3608;
			object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj4, (IntPtr)obj10);
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				KUtil.CallInMainThread(action);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			KUtil.CallInMainThread(action);
		}
	}

	public static void OnPresenceUpdateReceived(string jsonBody)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0166: Expected O, but got I
		//IL_01a3: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_00f0: Expected I, but got O
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 2616;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj3 = (nint)0 + (nint)3904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj7 = obj4 + 16;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj7;
		if (obj7 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v4+18]");
		if ((nint)0 != 0)
		{
			object obj10 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)3616;
			Action action = default(Action);
			action..ctor(obj4, (IntPtr)obj11);
			object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				KUtil.CallInMainThread(action);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			KUtil.CallInMainThread(action);
		}
	}

	public void SendGameInvitations(int[] userIds)
	{
		//IL_000c: Expected O, but got I
		//IL_04be: Expected O, but got I4
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_0462: Expected O, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004a: Expected I, but got O
		//IL_005a: Expected O, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_01c2: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_01d8: Expected I, but got O
		//IL_01e8: Expected O, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_017e: Expected O, but got I4
		//IL_0273: Expected I, but got O
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_0223: Expected O, but got I
		//IL_0313: Expected O, but got I4
		//IL_058f: Expected O, but got I
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0367: Expected O, but got I
		//IL_0321: Expected O, but got I4
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_05d8: Expected O, but got I
		//IL_03a2: Expected O, but got I
		//IL_0336: Expected O, but got I
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2632;
		Room lastJoinedRoom = SFS.LastJoinedRoom;
		object obj2 = obj;
		bool flag = ArraysExtensions.IsNullOrEmpty(userIds);
		bool flag2 = !flag;
		object obj3 = !flag2;
		object obj4;
		nint num2;
		if (obj3 == null && lastJoinedRoom != null)
		{
			obj4 = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)lastJoinedRoom;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj6 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X10_v20-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				obj6 += 16;
				obj5--;
				if ((nint)obj5 != 1)
				{
					continue;
				}
				goto IL_00d6;
			}
			object obj7 = obj6 + 6;
			object obj8 = num + obj7;
			object obj9 = obj8 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v194 @ X0_v45] (should have been resolved before IL gen)");
			object obj11 = default(object);
			object obj10 = obj11 & 1;
			bool flag3 = obj10 == null;
			object obj12 = !flag3;
			IntPtr intPtr = default(IntPtr);
			num2 = intPtr;
			if (obj12 == null)
			{
				goto IL_0194;
			}
			goto IL_01d0;
		}
		goto IL_0420;
		IL_0420:
		object obj13 = typeof(MemberAchievementClanFeedData) + 2824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NullReferenceException ex = default(NullReferenceException);
		ex..ctor();
		object obj14 = (nint)0 + (nint)3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		throw new NullReferenceException();
		IL_0514:
		object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v389 @ X0_v18] (should have been resolved before IL gen)");
		string password = SFSKammelnaRoomExtensions.GetPassword(lastJoinedRoom);
		if (SFSKammelnaRoomExtensions.IsTournamentHub(lastJoinedRoom))
		{
			TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(lastJoinedRoom);
			if (tournamentInfo != null)
			{
				object obj16 = (??)tournamentInfo.<TournamentId>k__BackingField & 1;
				if (obj16 != null)
				{
					object obj17 = (object?)tournamentInfo.<TournamentId>k__BackingField >> 32;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v32 (TournamentData)+1C]");
					object obj17 = 0;
				}
			}
			else
			{
				object obj17 = 0;
			}
			string tournamentPassword = SFSKammelnaRoomExtensions.GetTournamentPassword(lastJoinedRoom);
		}
		else
		{
			object obj17 = 0;
		}
		object obj18 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v11+B8]");
		object obj19 = 0;
		object obj20 = obj19;
		object obj21 = typeof(System.IOAsyncCallback) + 1216;
		object obj22 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v15+12E]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v15+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03e3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v15+B0]");
		object obj24 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X10_v9-8]");
			if (0 == (nint)obj21)
			{
				break;
			}
			obj24 += 16;
			obj23--;
			if ((nint)obj23 != 1)
			{
				continue;
			}
			goto IL_03e3;
		}
		object obj25 = obj24 + 4;
		object obj26 = obj22 + obj25;
		object obj27 = obj26 + 312;
		goto IL_05c0;
		IL_01d0:
		nint num3 = (nint)lastJoinedRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0264;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj29 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X10_v14-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj29 += 16;
			obj28--;
			if ((nint)obj28 != 1)
			{
				continue;
			}
			goto IL_0264;
		}
		object obj30 = num3 + obj29;
		object obj31 = obj30 + 312;
		goto IL_0514;
		IL_03e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_05c0;
		IL_0264:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = unchecked((nint)null);
		goto IL_0514;
		IL_05c0:
		object obj32 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v26+8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v336 @ X6_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_00d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ X0_v42] (should have been resolved before IL gen)");
		object obj35 = default(object);
		object obj34 = obj35 & 1;
		if (obj34 == null)
		{
			goto IL_0194;
		}
		num2 = 6;
		goto IL_01d0;
		IL_0194:
		bool flag4 = SFSKammelnaRoomExtensions.IsTournamentHub(lastJoinedRoom);
		bool flag5 = !flag4;
		num2 = 6;
		obj2 = 0;
		if (!flag5)
		{
			goto IL_01d0;
		}
		goto IL_0420;
	}

	public void SetPresence(PresenceState state)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0117: Expected O, but got I
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0080: Expected O, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		if (obj3 == null)
		{
			return;
		}
		object obj5 = typeof(System.IOAsyncCallback) + 1216;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v7+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v7+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v7+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X10_v5-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj8 += 16;
			obj7--;
			if ((nint)obj7 != 1)
			{
				continue;
			}
			goto IL_00c1;
		}
		object obj9 = obj8 + 6;
		object obj10 = obj6 + obj9;
		object obj11 = obj10 + 312;
		goto IL_0160;
		IL_0160:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v178 @ X0_v2] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_00c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0160;
	}

	public CoordinatorService()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 736;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E82A0]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)1984;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
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
			object obj4 = (nint)0 + (nint)1984;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}

	private void <OnLogin>b__48_0()
	{
		Initialize();
	}
}
