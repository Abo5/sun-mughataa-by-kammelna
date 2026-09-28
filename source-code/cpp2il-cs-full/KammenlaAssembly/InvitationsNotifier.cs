using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class InvitationsNotifier : MonoBehaviour
{
	private class InvitationData
	{
		private readonly FriendProfile <UserData>k__BackingField;

		private readonly int <RoomId>k__BackingField;

		private readonly string <Password>k__BackingField;

		private readonly long <TournamentId>k__BackingField;

		private readonly string <ServerId>k__BackingField;

		private readonly Games <Game>k__BackingField;

		private readonly GameType <GameType>k__BackingField;

		private readonly FriendlyChallengeInviteModel <ChallengeInvite>k__BackingField;

		public FriendProfile UserData => <UserData>k__BackingField;

		public int RoomId => <RoomId>k__BackingField;

		public string Password => <Password>k__BackingField;

		public long TournamentId => <TournamentId>k__BackingField;

		public string ServerId => <ServerId>k__BackingField;

		public Games Game => <Game>k__BackingField;

		public GameType GameType => <GameType>k__BackingField;

		public FriendlyChallengeInviteModel ChallengeInvite => <ChallengeInvite>k__BackingField;

		public InvitationData(FriendlyChallengeInviteModel challenge)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected O, but got Unknown
			//IL_00a7: Expected O, but got I4
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			base..ctor();
			object obj2 = this + 64;
			obj2 = challenge;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 4;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string serverID = Config.ServerID;
			object obj5 = this + 48;
			obj5 = serverID;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		public InvitationData(FriendProfile fp, int roomId, string pass, long tournamentId, string serverId, Games game)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			object obj = this + 16;
			obj = fp;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<RoomId>k__BackingField = roomId;
			object obj2 = this + 32;
			obj2 = pass;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj3 = this + 48;
			obj3 = serverId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public GameInvitationModel model;

		internal bool <ReceivedInvitation>b__0(FriendProfile f)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (f != null)
			{
				GameInvitationModel gameInvitationModel = model;
				if (model != null)
				{
					object obj = f.UserID - gameInvitationModel.userId;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public InvitationsNotifier <>4__this;

		public InvitationData invitation;

		internal void <ShowInvite>b__0(RecieveInvitePopup popup)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			object obj = popup + 56;
			obj = <>4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			InvitationData invitationData = invitation;
			popup.OpenChallengeInvite(invitationData.<ChallengeInvite>k__BackingField);
		}

		internal void <ShowInvite>b__1(RecieveInvitePopup popup)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			//IL_012e: Expected O, but got I
			//IL_0148: Expected O, but got I4
			//IL_008d: Expected O, but got I
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			//IL_0182: Expected O, but got I4
			object obj = popup + 56;
			obj = <>4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			InvitationData invitationData = invitation;
			object obj2 = typeof(System.IOAsyncCallback) + 3880;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v7+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CD9]");
				object obj4 = (nint)0 & (nint)1;
				if (obj4 != null)
				{
					goto IL_00aa;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CD9]");
				object obj5 = (nint)0 & (nint)1;
				bool flag = obj5 == null;
				object obj6 = !flag;
				if (obj6 != null)
				{
					goto IL_00aa;
				}
			}
			_ = 1;
			InvitationData invitationData2 = invitation;
			bool flag2 = invitation == null;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00b9;
			IL_00aa:
			invitationData2 = invitation;
			goto IL_00b9;
			IL_00b9:
			object message = "The operation is not allowed on non-connected sockets." + 3936;
			object obj8 = "The operation is not allowed on non-connected sockets." + 3928;
			if (invitationData.<TournamentId>k__BackingField != 0)
			{
				message = obj8;
			}
			popup.Open(invitationData.<UserData>k__BackingField, (string)message, invitationData2.<GameType>k__BackingField);
		}
	}

	private TournamentsEventsChannel eventsChannel;

	private ComponentReference<RecieveInvitePopup> invitePopupPrefab;

	private ChallengeEventsChannel challengeEventsChannel;

	private ChallengeConnector _challengeConnector;

	private static readonly Dictionary<int, DateTime> ignoreUserDictionary;

	private static readonly TimeSpan ignorePeriod;

	private readonly List<InvitationData> pendingInvitations;

	private ChallengeConnector ChallengeConnector
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected O, but got Unknown
			//IL_0130: Expected O, but got I4
			//IL_00c4: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_01a6: Expected O, but got I
			//IL_01d0: Expected O, but got I4
			//IL_0187: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C2A]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			UnityEngine.Object obj5;
			UnityEngine.Object obj7;
			object obj8;
			if (obj3 != null)
			{
				obj4 = this + 56;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (!flag)
				{
					goto IL_00a0;
				}
			}
			else
			{
				_ = 1;
				obj4 = this + 56;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (obj9 != null)
				{
					goto IL_00a0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj7 == null;
			bool flag4 = !flag3;
			obj4 = obj8;
			object obj10 = 0;
			UnityEngine.Object obj11 = null;
			if (flag4)
			{
				goto IL_00e8;
			}
			goto IL_019a;
			IL_00e8:
			return (ChallengeConnector)obj4;
			IL_019a:
			object obj12 = (nint)0 + (nint)40;
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v2+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			object obj15 = default(object);
			obj8 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (ChallengeConnector)obj8;
			IL_00a0:
			bool flag6 = obj5 == null;
			bool flag7 = !flag6;
			object obj16 = !flag7;
			obj10 = 0;
			obj11 = null;
			obj8 = obj4;
			if (obj16 == null)
			{
				goto IL_00e8;
			}
			goto IL_019a;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_014e: Expected I, but got O
		//IL_007d: Expected I, but got O
		//IL_00a8: Expected I, but got O
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_0109: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2080;
		object obj2 = (nint)0 + (nint)3168;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj4 = (nint)0 + (nint)3176;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2048;
		object obj6 = (nint)0 + (nint)3160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		CoordinatorService.OnGameInvitation += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		SFS.OnRoomRemoved += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj6);
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		challengeEventsChannel.OnChallengeInviteReceived += action3;
		GameObject gameObject = base.gameObject;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		UnityEngine.Object target = gameObject;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		UnityEngine.Object.DontDestroyOnLoad(target);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_00d5: Expected I, but got O
		//IL_007d: Expected I, but got O
		//IL_00a8: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2080;
		object obj2 = (nint)0 + (nint)3168;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj4 = (nint)0 + (nint)3176;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2048;
		object obj6 = (nint)0 + (nint)3160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		CoordinatorService.OnGameInvitation -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		SFS.OnRoomRemoved -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj6);
		challengeEventsChannel.OnChallengeInviteReceived -= action3;
	}

	public void AcceptNotifier()
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_004f: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I
		//IL_00e4: Expected I, but got O
		//IL_0218: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_010a: Expected O, but got I
		//IL_01c0: Expected O, but got I
		//IL_01d5: Expected O, but got I
		object obj = (nint)0 + (nint)72;
		object obj2 = Enumerable.First((IEnumerable<object>)pendingInvitations);
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string serverID = Config.ServerID;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+30]");
		if ((string)0 != serverID)
		{
			object obj6 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = (nint)0 + (nint)3152;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj7);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+30]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+38]");
			SfsConnectionManager.SwitchGame((string)num, Games.Baloot, action);
			return;
		}
		((List<object>)(object)pendingInvitations).RemoveAt(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+28]");
		if ((nint)0 != 0)
		{
			GameObject gameObject = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+18]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+20]");
			AcceptTournamentInvite.Accept((int)num2, (string)0, gameObject, eventsChannel);
			ReadNextInvite();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+3C]");
		if ((nint)0 == 4)
		{
			ChallengeConnector challengeConnector = ChallengeConnector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+40]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v11+10]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v12+10]");
			challengeConnector.SendChallengeAccept(0);
			ReadNextInvite();
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+18]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+20]");
			SFS.JoinGameRoom((int)num3, 0, (string)0);
			ReadNextInvite();
		}
	}

	public void RejectNotifier()
	{
		//IL_0052: Expected O, but got I
		//IL_0067: Expected O, but got I
		object obj = Enumerable.First((IEnumerable<object>)pendingInvitations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+3C]");
		if ((nint)0 == 4)
		{
			object obj2 = Enumerable.First((IEnumerable<object>)pendingInvitations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v10 (System.Object)+40]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v8+10]");
			object obj4 = 0;
			ChallengeConnector challengeConnector = ChallengeConnector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v9+10]");
			challengeConnector.SendChallengeDecline(0);
		}
		((List<object>)(object)pendingInvitations).RemoveAt(0);
		ReadNextInvite();
	}

	public void ExpiredNotifier()
	{
		((List<object>)(object)pendingInvitations).RemoveAt(0);
		ReadNextInvite();
	}

	public void IgnoreNotifier(int userId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0157: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0197: Expected O, but got I
		//IL_01c9: Expected O, but got I4
		//IL_0211: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.IOAsyncCallback) + 3880;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C30]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = typeof(DataRelation) + 712;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			obj7 = obj4;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(DataRelation) + 712;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v9+B8]");
		object obj10 = 0;
		Dictionary<int, DateTime> dictionary = (Dictionary<int, DateTime>)obj10;
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		Dictionary<int, DateTime> dictionary2 = (Dictionary<int, DateTime>)obj10;
		if (obj12 != null)
		{
			goto IL_00ee;
		}
		goto IL_01df;
		IL_00ee:
		DateTime now = DateTime.Now;
		goto IL_00fc;
		IL_00fc:
		bool flag4 = dictionary.TryAdd(userId, now);
		return;
		IL_01df:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		now = DateTime.Now;
		bool flag5 = dictionary2 == null;
		object obj13 = !flag5;
		dictionary = dictionary2;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00fc;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v27+B8]");
		object obj14 = 0;
		dictionary = (Dictionary<int, DateTime>)obj14;
		obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		dictionary2 = (Dictionary<int, DateTime>)obj14;
		if (!flag6)
		{
			goto IL_00ee;
		}
		goto IL_01df;
	}

	private void ReceivedInvitation(GameInvitationModel model)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_003c: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0181: Expected O, but got I4
		//IL_00c6: Expected O, but got I
		//IL_0207: Expected O, but got I4
		//IL_01af: Expected O, but got I
		//IL_01c9: Expected O, but got I4
		//IL_0128: Expected O, but got I
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_02a2: Expected O, but got I4
		//IL_023f: Expected O, but got I
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02f7: Expected O, but got I
		//IL_0308: Expected I, but got O
		//IL_0314: Expected O, but got I
		//IL_033a: Expected O, but got I
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected O, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_03b6: Expected O, but got I
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_03f0: Expected O, but got I
		object typeFromHandle = typeof(<>c__DisplayClass16_0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj = default(object);
		obj..ctor();
		object obj2 = obj + 16;
		obj2 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = 152993792;
		object obj4 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CD8]");
		object obj5 = (nint)0 & (nint)1;
		if (obj5 != null)
		{
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v39+E4]");
			if ((nint)0 != 0)
			{
				goto IL_00b0;
			}
		}
		else
		{
			_ = 1;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v39+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj8 = (nint)0 & (nint)1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 != null)
		{
			goto IL_00e3;
		}
		goto IL_01d7;
		IL_0264:
		object obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<FriendProfile> friendsList = FriendsManager.FriendsList;
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1120;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj, (IntPtr)obj14);
		object obj15 = (nint)0 + (nint)800;
		object obj16 = Enumerable.FirstOrDefault(friendsList, func);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+10]");
		object obj17 = 0;
		object obj18 = typeof(<>c__DisplayClass16_0) + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = default(object);
		obj19..ctor();
		object obj20 = obj19 + 16;
		obj20 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v15+1C]");
		_ = 0;
		object obj21 = obj19 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v15+28]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v15+20]");
		_ = 0;
		object obj22 = obj19 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v15+10]");
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v15+30]");
		_ = 0;
		AddNewInvitation((InvitationData)obj19);
		return;
		IL_0118:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v46+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v30+18]");
		if ((nint)0 == 4)
		{
			return;
		}
		goto IL_0264;
		IL_021d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj24 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v33+B8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v19+18]");
		if ((nint)0 == 4)
		{
			return;
		}
		goto IL_0264;
		IL_00b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj26 = (nint)0 & (nint)1;
		if (obj26 != null)
		{
			goto IL_00e3;
		}
		goto IL_01d7;
		IL_01d7:
		_ = 1;
		object obj27 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v46+E4]");
		bool flag4 = (nint)0 == 0;
		object obj28 = !flag4;
		object obj29 = obj27;
		if (obj28 != null)
		{
			goto IL_0118;
		}
		goto IL_021d;
		IL_00e3:
		obj27 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v46+E4]");
		bool flag5 = (nint)0 == 0;
		obj29 = obj27;
		if (!flag5)
		{
			goto IL_0118;
		}
		goto IL_021d;
	}

	private void ChallengeReceived(FriendlyChallengeInviteModel invite)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0199: Expected O, but got I
		//IL_01b3: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_022f: Expected O, but got I
		//IL_0249: Expected O, but got I4
		//IL_01f9: Expected O, but got I4
		//IL_00d6: Expected O, but got I
		//IL_02cf: Expected O, but got I
		//IL_028f: Expected O, but got I4
		//IL_0140: Expected O, but got I
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_03cc: Expected O, but got I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CD7]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(RegisteredWaitHandle) + 3136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CD8]");
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
			obj3 = typeof(RegisteredWaitHandle) + 3136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CD8]");
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
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v28+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj3 = obj5;
		if (obj9 != null)
		{
			goto IL_00c0;
		}
		goto IL_020f;
		IL_02f4:
		object obj10 = typeof(<>c__DisplayClass16_0) + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj12 = default(object);
		obj12..ctor();
		object obj13 = obj12 + 64;
		obj13 = invite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 4;
		object obj14 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string serverID = Config.ServerID;
		object obj16 = obj12 + 48;
		obj16 = serverID;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AddNewInvitation((InvitationData)obj12);
		return;
		IL_0130:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v39+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v25+18]");
		if ((nint)0 == 4)
		{
			return;
		}
		goto IL_02f4;
		IL_02ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v22+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v11+18]");
		if ((nint)0 == 4)
		{
			return;
		}
		goto IL_02f4;
		IL_008b:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v28+E4]");
		bool flag5 = (nint)0 == 0;
		obj5 = obj3;
		if (!flag5)
		{
			goto IL_00c0;
		}
		goto IL_020f;
		IL_020f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj20 = (nint)0 & (nint)1;
		bool flag6 = obj20 == null;
		object obj21 = !flag6;
		obj3 = obj5;
		if (obj21 != null)
		{
			goto IL_00fb;
		}
		goto IL_025f;
		IL_00c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj22 = (nint)0 & (nint)1;
		bool flag7 = obj22 == null;
		obj5 = obj3;
		if (!flag7)
		{
			goto IL_00fb;
		}
		goto IL_025f;
		IL_025f:
		_ = 1;
		object obj23 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v39+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		object obj25 = obj23;
		obj3 = obj5;
		if (obj24 != null)
		{
			goto IL_0130;
		}
		goto IL_02ad;
		IL_00fb:
		obj23 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v39+E4]");
		bool flag9 = (nint)0 == 0;
		obj25 = obj23;
		if (!flag9)
		{
			goto IL_0130;
		}
		goto IL_02ad;
	}

	private bool PlayerIsPlaying()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_01d5: Expected O, but got I4
		//IL_017d: Expected O, but got I
		//IL_0197: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_010b: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CD8]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_01a5;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11+18]");
		object obj9 = -4;
		return obj9 == null;
		IL_01eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj10 = obj2;
		goto IL_00e5;
		IL_00b0:
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = obj10;
		if (!flag3)
		{
			goto IL_00e5;
		}
		goto IL_01eb;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj12 = (nint)0 & (nint)1;
		if (obj12 != null)
		{
			goto IL_00b0;
		}
		goto IL_01a5;
		IL_01a5:
		_ = 1;
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		obj11 = obj10;
		if (obj13 != null)
		{
			goto IL_00e5;
		}
		goto IL_01eb;
	}

	private void AddNewInvitation(InvitationData invitation)
	{
		//IL_0059: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		List<object> list = (List<object>)(object)pendingInvitations;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj = !flag;
		if (obj == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj2 = items + list._size;
			object obj3 = obj2 + 32;
			obj3 = invitation;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)invitation);
		}
		List<InvitationData> list2 = pendingInvitations;
		if (list2._size <= 1)
		{
			ShowInvite(invitation);
		}
	}

	private void ShowInvite(InvitationData invitation)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_009c: Expected O, but got I
		//IL_019c: Expected O, but got I
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_00e9: Expected I, but got O
		//IL_00fa: Expected I, but got O
		//IL_0129: Expected O, but got I4
		//IL_0132: Expected O, but got I4
		//IL_025f: Expected O, but got I4
		//IL_028d: Expected O, but got I
		//IL_0295: Expected I, but got O
		//IL_02a6: Expected I, but got O
		//IL_02d5: Expected O, but got I4
		//IL_02f4: Expected O, but got I4
		object obj = typeof(<>c__DisplayClass16_0) + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = invitation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj4;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3248;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj8 = (nint)0 + (nint)2296;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v4+40]");
		ComponentReference<RecieveInvitePopup> componentReference;
		Action<object> action2;
		ComponentReference<RecieveInvitePopup> componentReference2;
		Action<object> action3;
		if ((nint)0 != 0)
		{
			object obj9 = (nint)0 + (nint)1128;
			componentReference = invitePopupPrefab;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num = (nint)obj9;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj9);
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			object obj11 = !flag;
			object obj12 = 0;
			object obj13 = obj2;
			action2 = action;
			componentReference2 = invitePopupPrefab;
			action3 = action;
			if (obj11 == null)
			{
				goto IL_0162;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v4+10]");
			object obj14 = 0;
			object obj15 = typeof(System.IOAsyncCallback) + 3880;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v8+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v5+10]");
				if (IsIgnored(0))
				{
					goto IL_0210;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v5+10]");
				bool flag2 = IsIgnored(0);
				bool flag3 = !flag2;
				object obj17 = !flag3;
				if (obj17 != null)
				{
					goto IL_0210;
				}
			}
			componentReference2 = invitePopupPrefab;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)1136;
			nint num = (nint)obj18;
			Action<object> action4 = default(Action<object>);
			action4..ctor(obj2, (IntPtr)obj18);
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v26+E4]");
			bool flag4 = (nint)0 == 0;
			object obj19 = !flag4;
			action3 = action4;
			if (obj19 == null)
			{
				object obj12 = 0;
				object obj13 = obj2;
				componentReference = invitePopupPrefab;
				action2 = action4;
				goto IL_0162;
			}
		}
		goto IL_0181;
		IL_0181:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0162:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		componentReference2 = componentReference;
		action3 = action2;
		goto IL_0181;
		IL_0210:
		bool flag5 = ((List<object>)(object)pendingInvitations).Remove(obj4);
	}

	private static bool IsIgnored(int userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0216: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_028c: Expected I4, but got O
		//IL_024e: Expected O, but got I
		//IL_0270: Expected O, but got I4
		//IL_00bd: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0129: Expected O, but got I4
		//IL_018f: Expected O, but got I4
		//IL_029c: Expected O, but got I
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02da: Expected O, but got I4
		//IL_01d8: Expected O, but got I
		object obj = typeof(System.IOAsyncCallback) + 3880;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C33]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v38+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v38+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v5+B8]");
		object obj7 = 0;
		Dictionary<int, DateTime> dictionary = (Dictionary<int, DateTime>)obj7;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00b1;
		}
		goto IL_027e;
		IL_00b1:
		object obj9 = (nint)0 + (nint)288;
		DateTime value;
		bool flag4 = dictionary.TryGetValue(userId, out value);
		if (flag4)
		{
			object obj10 = typeof(DataRelation) + 712;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v23+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			TimeSpan timeSpan = now - value;
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v29+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v29+B8]");
			object obj15 = 0;
			object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v30+E4]");
			bool flag7 = (nint)0 == 0;
			object obj18 = !flag7;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v15+8]");
			flag4 = timeSpan <= (TimeSpan)0;
		}
		return flag4;
		IL_027e:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v38+B8]");
		object obj19 = 0;
		dictionary = (Dictionary<int, DateTime>)obj19;
		if (obj19 != null)
		{
			goto IL_00b1;
		}
		goto IL_027e;
	}

	private static string CreateInviteMessage(InvitationData invitation)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		if (invitation != null)
		{
			object result = "The operation is not allowed on non-connected sockets." + 3936;
			object obj = "The operation is not allowed on non-connected sockets." + 3928;
			if (invitation.<TournamentId>k__BackingField != 0)
			{
				result = obj;
			}
			return (string)result;
		}
		return (string)(object)new NullReferenceException();
	}

	private void RoomRemoved(Room room)
	{
		List<InvitationData> list = pendingInvitations;
		if (list._size != 0)
		{
			Room room2 = default(Room);
			RemoveUnneededInvitation(room2);
		}
	}

	private void RemoveUnneededInvitation(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00e8: Expected O, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_013f: Expected I, but got O
		//IL_014f: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_01de: Expected O, but got I4
		//IL_018a: Expected O, but got I
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X10_v12-8]");
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
		goto IL_0227;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0227;
		IL_0227:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v234 @ X0_v4] (should have been resolved before IL gen)");
		object obj6 = (nint)0 + (nint)2928;
		object obj7 = obj6;
		object obj8 = ((List<object>)(object)pendingInvitations).get_Item(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v9 (System.Object)+18]");
		object obj9 = default(object);
		if (obj9 == null)
		{
			RejectNotifier();
			return;
		}
		nint num2 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01cb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X10_v7-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_01cb;
		}
		object obj12 = num2 + obj11;
		object obj13 = obj12 + 312;
		goto IL_025a;
		IL_01cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj7 = 0;
		goto IL_025a;
		IL_025a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v307 @ X0_v10] (should have been resolved before IL gen)");
		int roomId = default(int);
		RemoveInvitationIfExists(roomId);
	}

	private bool InvitePopupCurrentlyShowing(int roomId)
	{
		//IL_006e: Expected I4, but got O
		//IL_004c: Expected O, but got I
		if (pendingInvitations != null)
		{
			object obj = ((List<object>)(object)pendingInvitations).get_Item(0);
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5 (System.Object)+18]");
				object obj2 = (nint)roomId - (nint)0;
				return obj2 == null;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void RemoveInvitationIfExists(int roomId)
	{
		//IL_00e0: Expected O, but got I4
		//IL_0013: Expected O, but got I
		//IL_00c0: Expected O, but got I4
		//IL_0142: Expected I4, but got O
		object obj;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		NullReferenceException ex;
		int num = default(int);
		if (pendingInvitations != null)
		{
			obj = (nint)0 + (nint)4048;
			List<object>.Enumerator enumerator = ((List<object>)(object)pendingInvitations).GetEnumerator();
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			object obj2 = null;
			ex = new NullReferenceException();
			object obj3 = 0;
			num = 0;
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj = 152993792;
			ex = new NullReferenceException();
		}
		bool flag = num != 1;
		NullReferenceException ex3 = ex;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (int)obj;
			enumerator2.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj3 = obj4;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223ED38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void ReadNextInvite()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0073: Expected I, but got O
		//IL_00a2: Expected O, but got I4
		List<InvitationData> list = pendingInvitations;
		if (list._size >= 1)
		{
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)3144;
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
		}
	}

	public InvitationsNotifier()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<Tween>) + 960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 64;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	static InvitationsNotifier()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected O, but got I4
		//IL_00b3: Expected O, but got I
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 992;
		object obj2 = typeof(System.IOAsyncCallback) + 3880;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<int, DateTime> dictionary = default(Dictionary<int, DateTime>);
		dictionary..ctor();
		object obj4 = obj2;
		object obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan = TimeSpan.FromMinutes(8.000000000465661);
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5+B8]");
		object obj9 = 0;
	}

	private void <ReadNextInvite>b__27_0()
	{
		object invitation = Enumerable.First((IEnumerable<object>)pendingInvitations);
		ShowInvite((InvitationData)invitation);
	}
}
