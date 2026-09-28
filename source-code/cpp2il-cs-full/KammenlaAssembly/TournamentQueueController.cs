using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Spine;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.UI;
using Util;

public class TournamentQueueController : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<QueuePlayer, bool> <>9__34_1;

		public static Func<QueuePlayer, int> <>9__48_0;

		public static Action<GameObject[]> <>9__59_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <UpdateTournamentQueue>b__34_1(QueuePlayer player)
		{
			//IL_00c8: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_00a8: Expected O, but got I4
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected I4, but got Unknown
			if (player != null)
			{
				object obj = player.<status>k__BackingField - 1;
				bool flag = (nint)obj < 0;
				bool flag2 = obj == null;
				object obj2 = player.<status>k__BackingField ^ QueuePlayer.Status.Highlight;
				object obj3 = player.<status>k__BackingField ^ obj;
				object obj4 = obj2 & obj3;
				bool flag3 = (nint)obj4 < 0;
				bool flag4 = flag == flag3;
				object obj5 = !flag2;
				return (byte)((flag4 & obj5) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <Teamup>b__48_0(QueuePlayer player)
		{
			//IL_0064: Expected I4, but got O
			if (player != null)
			{
				PlayerInfo <info>k__BackingField = player.<info>k__BackingField;
				if (player.<info>k__BackingField != null)
				{
					return <info>k__BackingField.<DBID>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void <SetView>b__59_0(GameObject[] objs)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_003f: Expected I, but got O
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
			object obj2 = (nint)0 + (nint)1960;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)null, (IntPtr)obj2);
			ArraysExtensions.ForEach(objs, action);
		}
	}

	private sealed class <>c__DisplayClass34_0
	{
		public TournamentData data;

		internal bool <UpdateTournamentQueue>b__0(QueuePlayer player)
		{
			//IL_00d2: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected I4, but got Unknown
			if (player != null)
			{
				TournamentData tournamentData = data;
				if (data != null)
				{
					object obj = player.<order>k__BackingField - tournamentData.<MaxAllowedSize>k__BackingField;
					bool flag = (nint)obj < 0;
					int num = player.<order>k__BackingField ^ tournamentData.<MaxAllowedSize>k__BackingField;
					int num2 = player.<order>k__BackingField ^ obj;
					int num3 = num & num2;
					bool flag2 = num3 < 0;
					return flag == flag2;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <UpdateTournamentQueue>b__2(QueuePlayer player)
		{
			//IL_00dd: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected I4, but got Unknown
			if (player != null)
			{
				TournamentData tournamentData = data;
				if (data != null)
				{
					object obj = player.<order>k__BackingField - tournamentData.<MaxAllowedSize>k__BackingField;
					bool flag = (nint)obj < 0;
					int num = player.<order>k__BackingField ^ tournamentData.<MaxAllowedSize>k__BackingField;
					int num2 = player.<order>k__BackingField ^ obj;
					int num3 = num & num2;
					bool flag2 = num3 < 0;
					bool flag3 = flag == flag2;
					return !flag3;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass37_0
	{
		public QueuePlayer player;

		public TournamentData data;

		internal bool <SelectPlayer>b__0(QueuePlayer queuePlayer)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (queuePlayer != null)
			{
				PlayerInfo <info>k__BackingField = queuePlayer.<info>k__BackingField;
				if (queuePlayer.<info>k__BackingField != null)
				{
					QueuePlayer queuePlayer2 = player;
					if (player != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer2.<info>k__BackingField;
						if (queuePlayer2.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <SelectPlayer>b__1(QueuePlayer selectedPlayer)
		{
			//IL_00dd: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected I4, but got Unknown
			if (selectedPlayer != null)
			{
				TournamentData tournamentData = data;
				if (data != null)
				{
					object obj = selectedPlayer.<order>k__BackingField - tournamentData.<MaxAllowedSize>k__BackingField;
					bool flag = (nint)obj < 0;
					int num = selectedPlayer.<order>k__BackingField ^ tournamentData.<MaxAllowedSize>k__BackingField;
					int num2 = selectedPlayer.<order>k__BackingField ^ obj;
					int num3 = num & num2;
					bool flag2 = num3 < 0;
					bool flag3 = flag == flag2;
					return !flag3;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass38_0
	{
		public TournamentData data;

		internal bool <OnSelectingTeam>b__0(QueuePlayer selectedPlayer)
		{
			//IL_00dd: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected I4, but got Unknown
			if (selectedPlayer != null)
			{
				TournamentData tournamentData = data;
				if (data != null)
				{
					object obj = selectedPlayer.<order>k__BackingField - tournamentData.<MaxAllowedSize>k__BackingField;
					bool flag = (nint)obj < 0;
					int num = selectedPlayer.<order>k__BackingField ^ tournamentData.<MaxAllowedSize>k__BackingField;
					int num2 = selectedPlayer.<order>k__BackingField ^ obj;
					int num3 = num & num2;
					bool flag2 = num3 < 0;
					bool flag3 = flag == flag2;
					return !flag3;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass41_0
	{
		public TournamentQueueController <>4__this;

		public int playerDbId;

		internal void <OnKickPlayer>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0054: Expected O, but got I
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ X8_v7+1F8] (should have been resolved before IL gen)");
			<>4__this.ClearPlayersSelection();
		}
	}

	private sealed class <>c__DisplayClass42_0
	{
		public TournamentQueueController <>4__this;

		public int teamIndex;

		internal void <OnBreakTeam>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00c6: Expected O, but got I
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v5+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v96 @ X8_v7+188] (should have been resolved before IL gen)");
			object obj6 = default(object);
			if (obj6 != null)
			{
				int num = teamIndex;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v5+6C]");
				if ((nint)num < (nint)0)
				{
					<>4__this.UnsetTeam();
					return;
				}
				int seat = teamIndex << 1;
				<>4__this.SendSeatPlayerRequest(seat);
				<>4__this.ClearPlayersSelection();
			}
		}
	}

	private sealed class <>c__DisplayClass55_0
	{
		public int myId;

		internal bool <SetView>b__0(QueuePlayer player)
		{
			//IL_0082: Expected I4, but got O
			//IL_0060: Expected O, but got I4
			if (player != null)
			{
				PlayerInfo <info>k__BackingField = player.<info>k__BackingField;
				if (player.<info>k__BackingField != null)
				{
					object obj = <info>k__BackingField.<DBID>k__BackingField - myId;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass56_0
	{
		public QueuePlayer player;

		internal bool <IsSelected>b__0(QueuePlayer p)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					QueuePlayer queuePlayer = player;
					if (player != null)
					{
						PlayerInfo <info>k__BackingField2 = queuePlayer.<info>k__BackingField;
						if (queuePlayer.<info>k__BackingField != null)
						{
							object obj = <info>k__BackingField.<DBID>k__BackingField - <info>k__BackingField2.<DBID>k__BackingField;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass57_0
	{
		public int playerId;

		public QueuePlayer player;

		internal bool <IsTeamed>b__0(QueuePlayer p)
		{
			//IL_0082: Expected I4, but got O
			//IL_0060: Expected O, but got I4
			if (p != null)
			{
				PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
				if (p.<info>k__BackingField != null)
				{
					object obj = <info>k__BackingField.<DBID>k__BackingField - playerId;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <IsTeamed>b__1(QueuePlayer p)
		{
			//IL_00e5: Expected I4, but got O
			//IL_00b8: Expected O, but got I4
			if (p != null)
			{
				QueuePlayer queuePlayer = player;
				if (player != null)
				{
					if (p.<team>k__BackingField == queuePlayer.<team>k__BackingField)
					{
						return false;
					}
					PlayerInfo <info>k__BackingField = p.<info>k__BackingField;
					if (p.<info>k__BackingField != null)
					{
						object obj = <info>k__BackingField.<DBID>k__BackingField - playerId;
						bool flag = obj == null;
						return !flag;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const string Request = "tu";

	private const string Command = "cmd";

	private const string CommandReset = "reset";

	private const string CommandFill = "fill";

	private const string CommandUpdate = "update";

	private const string CommandUnseat = "unseat";

	private const string CommandConfig = "config";

	private const string CommandTeamUp = "team";

	private const string PlayerTeams = "tms";

	private const string AllowParticipants = "ap";

	private const string ShuffleTeams = "sfl";

	private const string Player = "plyr";

	private const string Team = "team";

	private const string Unauthorized = "unauthorized";

	private const string NoSeats = "no_seats";

	private Toggle allowParticipantsToggle;

	private Toggle shuffleTeamsToggle;

	private Button unsetTeamButton;

	private WaitingListView waitingList;

	private MatchupsListView matchupsList;

	private GameObject[] ownerObjects;

	private GameObject[] playerObjects;

	private GameObject[] spectatorObjects;

	private TournamentInviteManager inviteManager;

	private TournamentSceneEventsChannel tournamentEventsChannel;

	private readonly List<QueuePlayer> selectedPlayers;

	private List<QueuePlayer> _fullQueue;

	private TournamentViewConnector Connector
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			return (TournamentViewConnector)0;
		}
	}

	private Room TournamentRoom
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00dc: Expected O, but got I
			//IL_0106: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_014f: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DFE]");
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
			goto IL_015d;
			IL_00b8:
			return sessionModel.CurrentRoom;
			IL_015d:
			return (Room)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_015d;
		}
	}

	private void Start()
	{
		//IL_0016: Expected O, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_017a: Expected O, but got I
		//IL_0192: Expected I, but got O
		//IL_014d: Expected O, but got I
		//IL_01ac: Expected O, but got I
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01db: Expected O, but got I
		//IL_01f3: Expected I, but got O
		//IL_0204: Expected O, but got I
		//IL_0231: Expected O, but got I
		//IL_0249: Expected I, but got O
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_028f: Expected O, but got I
		//IL_02a7: Expected I, but got O
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02cc: Expected O, but got I
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02fb: Expected O, but got I
		//IL_0334: Expected I, but got O
		//IL_0363: Expected O, but got I4
		//IL_03b3: Expected I, but got O
		//IL_03c4: Expected O, but got I
		//IL_03f0: Expected I, but got O
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_0415: Expected O, but got I
		//IL_0441: Expected I, but got O
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_0466: Expected O, but got I
		//IL_0492: Expected I, but got O
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04b7: Expected O, but got I
		//IL_04e3: Expected I, but got O
		//IL_04f4: Expected O, but got I
		//IL_0520: Expected I, but got O
		//IL_0531: Expected O, but got I
		//IL_055d: Expected I, but got O
		//IL_056e: Expected O, but got I
		//IL_059a: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DB8]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B3]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B3]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v10+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		goto IL_015a;
		IL_015a:
		object obj10 = typeof(SqlSingle[]) + 2376;
		object obj11 = (nint)0 + (nint)1280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v3+20]");
		((OneShotEvent)0).CallWhenReady(action);
		Toggle toggle = allowParticipantsToggle;
		object obj12 = typeof(TypeConverter<ushort, char>) + 360;
		object obj13 = (nint)0 + (nint)1264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor((object)this, (IntPtr)obj13);
		object obj14 = (nint)0 + (nint)832;
		toggle.onValueChanged.AddListener(unityAction);
		Toggle toggle2 = shuffleTeamsToggle;
		object obj15 = (nint)0 + (nint)1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction2 = default(UnityAction<bool>);
		unityAction2..ctor((object)this, (IntPtr)obj15);
		toggle2.onValueChanged.AddListener(unityAction2);
		Button button = unsetTeamButton;
		object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj17 = (nint)0 + (nint)1360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj17);
		object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj19 = (nint)0 + (nint)1304;
		object obj20 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 832;
		object obj21 = (nint)0 + (nint)1384;
		button.m_OnClick.AddListener(unityAction3);
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj19);
		object obj22 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj23 = !flag3;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.AddListener(go, (string)command, onlyOnce: false, action2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj21);
		object obj24 = (nint)0 + (nint)1272;
		tournamentEventsChannel.OnUpdateQueue += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj24);
		object obj25 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3216;
		object obj26 = (nint)0 + (nint)1328;
		tournamentEventsChannel.OnClearSelection += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj26);
		object obj27 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 624;
		object obj28 = (nint)0 + (nint)1336;
		tournamentEventsChannel.OnSelectingPlayer += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action6 = default(Action<object, object>);
		action6..ctor((object)this, (IntPtr)obj28);
		object obj29 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj30 = (nint)0 + (nint)1320;
		tournamentEventsChannel.OnSelectingTeam += action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action7 = default(Action<int>);
		action7..ctor((object)this, (IntPtr)obj30);
		object obj31 = (nint)0 + (nint)1344;
		tournamentEventsChannel.OnSeatSelected += action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action8 = default(Action<int>);
		action8..ctor((object)this, (IntPtr)obj31);
		object obj32 = (nint)0 + (nint)1312;
		tournamentEventsChannel.OnTeamSelected += action8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action9 = default(Action<int>);
		action9..ctor((object)this, (IntPtr)obj32);
		object obj33 = (nint)0 + (nint)1296;
		tournamentEventsChannel.OnKickPlayer += action9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action10 = default(Action<int>);
		action10..ctor((object)this, (IntPtr)obj33);
		tournamentEventsChannel.OnBreakTeam += action10;
		return;
		IL_0082:
		object obj34 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v16+B8]");
		object obj35 = 0;
		obj9 = obj35;
		bool flag4 = obj35 == null;
		object obj36 = !flag4;
		if (obj36 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_015a;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0234: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_005d: Expected I, but got O
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_00ae: Expected I, but got O
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_00ff: Expected I, but got O
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0124: Expected O, but got I
		//IL_0150: Expected I, but got O
		//IL_0161: Expected O, but got I
		//IL_018d: Expected I, but got O
		//IL_019e: Expected O, but got I
		//IL_01ca: Expected I, but got O
		//IL_01db: Expected O, but got I
		//IL_0207: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)1272;
		tournamentEventsChannel.OnUpdateQueue -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3216;
		object obj5 = (nint)0 + (nint)1328;
		tournamentEventsChannel.OnClearSelection -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj5);
		object obj6 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 624;
		object obj7 = (nint)0 + (nint)1336;
		tournamentEventsChannel.OnSelectingPlayer -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action4 = default(Action<object, object>);
		action4..ctor((object)this, (IntPtr)obj7);
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj9 = (nint)0 + (nint)1320;
		tournamentEventsChannel.OnSelectingTeam -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action5 = default(Action<int>);
		action5..ctor((object)this, (IntPtr)obj9);
		object obj10 = (nint)0 + (nint)1344;
		tournamentEventsChannel.OnSeatSelected -= action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action6 = default(Action<int>);
		action6..ctor((object)this, (IntPtr)obj10);
		object obj11 = (nint)0 + (nint)1312;
		tournamentEventsChannel.OnTeamSelected -= action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action7 = default(Action<int>);
		action7..ctor((object)this, (IntPtr)obj11);
		object obj12 = (nint)0 + (nint)1296;
		tournamentEventsChannel.OnKickPlayer -= action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action8 = default(Action<int>);
		action8..ctor((object)this, (IntPtr)obj12);
		tournamentEventsChannel.OnBreakTeam += action8;
	}

	private void Init()
	{
		//IL_0016: Expected O, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_01b5: Expected O, but got I
		//IL_01c3: Expected I4, but got O
		//IL_01e3: Expected O, but got I4
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_020d: Expected O, but got I
		//IL_02b5: Expected O, but got I
		//IL_02df: Expected O, but got I4
		//IL_028f: Expected O, but got I4
		//IL_0236: Expected O, but got I
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_033b: Expected O, but got I
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_0374: Expected I, but got O
		//IL_03ae: Expected O, but got I
		//IL_045f: Expected O, but got I4
		//IL_041c: Expected O, but got I4
		//IL_0492: Expected O, but got I
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_04cb: Expected I, but got O
		//IL_0505: Expected O, but got I
		//IL_05ee: Expected O, but got I4
		//IL_056a: Expected O, but got I
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected O, but got Unknown
		//IL_05a3: Expected I, but got O
		//IL_062f: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DFF]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B3]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B3]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v29+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		goto IL_015a;
		IL_054f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_055e;
		IL_031b:
		object obj10 = typeof(SqlSingle[]) + 2376;
		object obj11 = (nint)0 + (nint)1384;
		object varName = "placementId" + 1856;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj11);
		GameObject go;
		VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DFE]");
		object obj12 = (nint)0 & (nint)1;
		object obj14;
		if (obj12 != null)
		{
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v41+E4]");
			if ((nint)0 != 0)
			{
				goto IL_03f8;
			}
		}
		else
		{
			_ = 1;
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v41+E4]");
			bool flag3 = (nint)0 == 0;
			object obj15 = !flag3;
			if (obj15 != null)
			{
				goto IL_03f8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0486;
		IL_026b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj16 = !flag4;
		if (obj16 != null)
		{
			goto IL_031b;
		}
		goto IL_063d;
		IL_0082:
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v34+B8]");
		object obj18 = 0;
		obj9 = obj18;
		bool flag5 = obj18 == null;
		object obj19 = !flag5;
		if (obj19 != null)
		{
			goto IL_015a;
		}
		goto IL_063d;
		IL_015a:
		object obj20 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ X8_v4+188] (should have been resolved before IL gen)");
		object obj21 = default(object);
		if (obj21 == null)
		{
			return;
		}
		MatchupsListView matchupsListView = matchupsList;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v4+6C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v4+6C]");
		object obj22 = num + 0;
		int <MatchCount>k__BackingField = obj22 >> 1;
		matchupsListView.<MatchCount>k__BackingField = <MatchCount>k__BackingField;
		go = base.gameObject;
		object obj23 = 152985600;
		obj14 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DFE]");
		object obj24 = (nint)0 & (nint)1;
		object obj27;
		object obj25;
		if (obj24 != null)
		{
			obj25 = (nint)0 + (nint)2200;
			object obj26 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v56+E4]");
			bool flag6 = (nint)0 == 0;
			obj27 = obj25;
			if (!flag6)
			{
				goto IL_026b;
			}
		}
		else
		{
			_ = 1;
			obj25 = (nint)0 + (nint)2200;
			object obj26 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v56+E4]");
			bool flag7 = (nint)0 == 0;
			object obj28 = !flag7;
			obj27 = obj25;
			if (obj28 != null)
			{
				goto IL_026b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj25 = obj27;
		goto IL_031b;
		IL_055e:
		object obj29 = (nint)0 + (nint)1376;
		object varName2 = "setMimeType" + 1768;
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom2 = sessionModel2.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj29);
		GameObject go3;
		VariableBinderExtensions.Bind(go3, currentRoom2, (string)varName2, action2);
		return;
		IL_0486:
		object obj30 = (nint)0 + (nint)1368;
		object varName3 = "alignContent" + 704;
		SessionModel sessionModel3 = default(SessionModel);
		Room currentRoom3 = sessionModel3.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj30);
		VariableBinderExtensions.Bind(go2, currentRoom3, (string)varName3, action3);
		go3 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DFE]");
		object obj31 = (nint)0 & (nint)1;
		if (obj31 != null)
		{
			object obj32 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v21+E4]");
			if ((nint)0 != 0)
			{
				goto IL_054f;
			}
		}
		else
		{
			_ = 1;
			object obj32 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v21+E4]");
			bool flag8 = (nint)0 == 0;
			object obj33 = !flag8;
			if (obj33 != null)
			{
				goto IL_054f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag9 = (object)sessionModel2 == null;
		object obj34 = !flag9;
		if (obj34 != null)
		{
			goto IL_055e;
		}
		goto IL_063d;
		IL_03f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag10 = (object)sessionModel3 == null;
		object obj35 = !flag10;
		if (obj35 != null)
		{
			goto IL_0486;
		}
		goto IL_063d;
		IL_063d:
		throw new NullReferenceException();
	}

	public unsafe void UpdateTournamentQueue()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_12bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c2: Expected O, but got Unknown
		//IL_12df: Expected O, but got I
		//IL_12ff: Expected O, but got I4
		//IL_1308: Expected O, but got I4
		//IL_1311: Expected O, but got I4
		//IL_131f: Expected O, but got I4
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		//IL_0063: Expected O, but got I4
		//IL_006c: Expected O, but got I4
		//IL_0075: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00da: Expected O, but got I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_0104: Expected O, but got I
		//IL_01f6: Expected O, but got I
		//IL_01fe: Expected I, but got O
		//IL_020e: Expected O, but got I
		//IL_0230: Expected O, but got I4
		//IL_0248: Expected O, but got I
		//IL_01a6: Expected O, but got I4
		//IL_012d: Expected O, but got I
		//IL_0135: Expected I, but got O
		//IL_0145: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_0313: Expected O, but got I4
		//IL_031c: Expected O, but got I4
		//IL_0325: Expected O, but got I4
		//IL_01bd: Expected O, but got I4
		//IL_01c6: Expected O, but got I4
		//IL_01cf: Expected O, but got I4
		//IL_028f: Expected O, but got I4
		//IL_0298: Expected O, but got I4
		//IL_02a1: Expected O, but got I4
		//IL_0358: Expected O, but got I
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_0378: Expected O, but got I
		//IL_0384: Expected O, but got I
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_03a4: Expected O, but got I
		//IL_03b9: Expected O, but got Ref
		//IL_0485: Expected I, but got O
		//IL_10a8: Expected O, but got I4
		//IL_10b8: Expected O, but got Ref
		//IL_10c1: Expected O, but got I4
		//IL_0548: Expected O, but got I
		//IL_0558: Expected O, but got I
		//IL_057a: Expected O, but got I4
		//IL_0583: Expected O, but got I4
		//IL_03eb: Expected O, but got I
		//IL_0604: Expected O, but got I
		//IL_0621: Expected O, but got I
		//IL_04d8: Expected O, but got I
		//IL_04e8: Expected O, but got I
		//IL_050a: Expected O, but got I4
		//IL_0513: Expected O, but got I4
		//IL_10e0: Expected O, but got I4
		//IL_10f0: Expected O, but got Ref
		//IL_10f9: Expected O, but got I4
		//IL_0649: Expected O, but got I
		//IL_065a: Expected I, but got O
		//IL_05a1: Expected O, but got I
		//IL_05c3: Expected O, but got I4
		//IL_1388: Expected O, but got I
		//IL_1399: Expected I, but got O
		//IL_13b7: Expected O, but got I
		//IL_13d2: Expected O, but got I4
		//IL_1070: Expected O, but got I4
		//IL_1080: Expected O, but got Ref
		//IL_1089: Expected O, but got I4
		//IL_069a: Expected O, but got I
		//IL_06a8: Expected I, but got O
		//IL_05f3: Expected O, but got I
		//IL_06e0: Expected O, but got I4
		//IL_06e9: Expected O, but got I4
		//IL_06f1: Expected O, but got Ref
		//IL_070a: Expected O, but got I4
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected O, but got Unknown
		//IL_074c: Expected I, but got O
		//IL_075c: Expected O, but got I
		//IL_0836: Expected O, but got I
		//IL_085a: Expected O, but got I4
		//IL_0863: Expected O, but got I4
		//IL_086b: Expected O, but got Ref
		//IL_0874: Expected O, but got I4
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected O, but got Unknown
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_098d: Expected O, but got Unknown
		//IL_0797: Expected O, but got I
		//IL_156b: Expected O, but got I
		//IL_089b: Expected O, but got I4
		//IL_08a3: Expected O, but got Ref
		//IL_08ac: Expected O, but got I4
		//IL_08b4: Expected O, but got Ref
		//IL_13ef: Expected O, but got I
		//IL_1401: Unknown result type (might be due to invalid IL or missing references)
		//IL_1406: Expected O, but got Unknown
		//IL_0a48: Expected O, but got I4
		//IL_0c4b: Expected O, but got I4
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected O, but got Unknown
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Expected O, but got Unknown
		//IL_08ec: Expected O, but got I
		//IL_091d: Expected O, but got Ref
		//IL_0926: Expected O, but got I4
		//IL_0936: Expected O, but got I
		//IL_0946: Expected O, but got Ref
		//IL_094f: Expected O, but got I4
		//IL_0957: Expected O, but got Ref
		//IL_1497: Expected O, but got I
		//IL_14aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_14af: Expected O, but got Unknown
		//IL_09b0: Expected O, but got I
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Expected O, but got Unknown
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected O, but got Unknown
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected O, but got Unknown
		//IL_0c80: Expected O, but got I4
		//IL_0ca1: Expected O, but got I4
		//IL_0caa: Expected O, but got I4
		//IL_0cbb: Expected O, but got I4
		//IL_0ce4: Expected O, but got I4
		//IL_0d0d: Expected O, but got I4
		//IL_0d16: Expected O, but got I4
		//IL_0d27: Expected O, but got I4
		//IL_143f: Expected O, but got I
		//IL_1451: Unknown result type (might be due to invalid IL or missing references)
		//IL_1456: Expected O, but got Unknown
		//IL_15aa: Expected O, but got I4
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a70: Expected O, but got Unknown
		//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d59: Expected O, but got Unknown
		//IL_0d71: Expected O, but got I
		//IL_1150: Expected O, but got I4
		//IL_1161: Expected O, but got I4
		//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Expected O, but got Unknown
		//IL_09e1: Expected O, but got I
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Expected O, but got Unknown
		//IL_0e10: Expected O, but got I4
		//IL_0aba: Expected O, but got I
		//IL_165c: Expected O, but got I
		//IL_0dac: Expected O, but got I
		//IL_0b8d: Expected O, but got I4
		//IL_0e84: Expected O, but got I4
		//IL_1628: Expected O, but got I
		//IL_152c: Expected O, but got I
		//IL_0af5: Expected O, but got I
		//IL_11f5: Expected O, but got I4
		//IL_1206: Expected O, but got I4
		//IL_0f52: Expected O, but got I4
		//IL_0e33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e38: Expected O, but got Unknown
		//IL_1118: Expected O, but got I4
		//IL_1129: Expected O, but got I4
		//IL_14dc: Expected O, but got I
		//IL_14ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f3: Expected O, but got Unknown
		//IL_0dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbf: Expected O, but got Unknown
		//IL_0dd5: Expected O, but got I
		//IL_0bea: Expected O, but got I4
		//IL_0c13: Expected O, but got I4
		//IL_0bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb5: Expected O, but got Unknown
		//IL_126d: Expected O, but got I4
		//IL_0fe9: Expected O, but got I4
		//IL_0b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b10: Expected O, but got Unknown
		//IL_0b26: Expected O, but got I
		//IL_0b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v5+B8]");
		object obj5 = 0;
		object obj6 = obj5;
		bool flag = obj5 == null;
		object obj7 = 0;
		object obj8 = 0;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		Func<object, bool> func = null;
		List<object> list = (List<object>)146685952;
		object obj9 = obj2;
		Func<object, bool> func2 = default(Func<object, bool>);
		object obj15;
		SessionModel sessionModel = default(SessionModel);
		if (!flag)
		{
			obj5 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v7+188]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v7+190]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v246 @ X8_v7+188] (should have been resolved before IL gen)");
			bool flag2 = obj2 == null;
			obj7 = 0;
			obj8 = 0;
			enumerator = (List<object>.Enumerator)0;
			list = (List<object>)146685952;
			obj9 = obj2;
			if (!flag2)
			{
				object obj11 = obj2 + 16;
				obj11 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (obj11 == null)
				{
					return;
				}
				object obj12 = 152985600;
				list = (List<object>)(typeof(Queue<string>) + 848);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DFE]");
				object obj13 = (nint)0 & (nint)1;
				if (obj13 != null)
				{
					object obj14 = (nint)0 + (nint)2200;
					nint num = (nint)list;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v102 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+E4]");
					obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v102 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+E4]");
					bool flag3 = (nint)0 == 0;
					object obj16 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v102 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+E4]");
					obj5 = 0;
					if (!flag3)
					{
						goto IL_0182;
					}
				}
				else
				{
					_ = 1;
					object obj14 = (nint)0 + (nint)2200;
					nint num = (nint)list;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v102 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+E4]");
					obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v102 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+E4]");
					bool flag4 = (nint)0 == 0;
					object obj17 = !flag4;
					object obj16 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v102 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+E4]");
					obj5 = 0;
					if (obj17 != null)
					{
						goto IL_0182;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				bool flag5 = (object)sessionModel == null;
				obj15 = obj5;
				obj7 = 0;
				obj8 = 0;
				enumerator = (List<object>.Enumerator)0;
				func = func2;
				obj9 = obj2;
				if (!flag5)
				{
					goto IL_02bf;
				}
			}
		}
		goto IL_1335;
		IL_1335:
		throw new NullReferenceException();
		IL_02bf:
		Room currentRoom = sessionModel.CurrentRoom;
		List<QueuePlayer> tournamentQueue = SFSKammelnaRoomExtensions.GetTournamentQueue(currentRoom);
		list = (List<object>)(this + 120);
		list = (List<object>)(object)tournamentQueue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag6 = list == null;
		obj7 = 0;
		obj8 = 0;
		enumerator = (List<object>.Enumerator)0;
		func = (Func<object, bool>)(object)tournamentQueue;
		obj5 = obj15;
		obj9 = obj2;
		if (!flag6)
		{
			object obj18 = (nint)0 + (nint)336;
			object obj19 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2992;
			object obj20 = (nint)0 + (nint)264;
			object obj21 = (nint)0 + (nint)3704;
			object obj22 = typeof(SkeletonBinary.SkeletonInput) + 3824;
			object obj23 = (nint)0 + (nint)328;
			List<object>.Enumerator enumerator2 = list.GetEnumerator();
			obj5 = (object)(&enumerator);
			object obj24 = default(object);
			Func<object, bool> func3 = default(Func<object, bool>);
			object obj52 = default(object);
			object obj53 = default(object);
			object obj63 = default(object);
			object obj32 = default(object);
			object obj34 = default(object);
			object obj25 = default(object);
			Func<object, bool> func4 = default(Func<object, bool>);
			Func<object, bool> func5 = default(Func<object, bool>);
			bool flag19 = default(bool);
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			object obj80 = default(object);
			object obj82 = default(object);
			object obj87 = default(object);
			Func<object, bool> func6 = default(Func<object, bool>);
			while (true)
			{
				func = (Func<object, bool>)obj18;
				object obj26;
				if (enumerator.MoveNext())
				{
					if (obj24 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ stack_-90+10]");
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ stack_-90+10]");
						if ((nint)0 != 0)
						{
							if ((object)inviteManager != null)
							{
								TournamentInviteManager tournamentInviteManager = inviteManager;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v7+10]");
								QueuePlayer.Status status = tournamentInviteManager.GetStatus(0);
								obj25 = obj24;
								continue;
							}
							NullReferenceException ex = new NullReferenceException();
							obj7 = 0;
							obj25 = obj24;
							obj26 = (object)(&enumerator);
							enumerator3 = (List<object>.Enumerator)0;
							obj9 = obj2;
						}
						else
						{
							NullReferenceException ex2 = new NullReferenceException();
							obj7 = 0;
							obj25 = obj24;
							obj26 = (object)(&enumerator);
							enumerator3 = (List<object>.Enumerator)0;
							obj9 = obj2;
						}
					}
					else
					{
						NullReferenceException ex3 = new NullReferenceException();
						obj7 = 0;
						obj25 = obj24;
						obj26 = (object)(&enumerator);
						enumerator3 = (List<object>.Enumerator)0;
						obj9 = obj2;
					}
					goto IL_1176;
				}
				enumerator.Dispose();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				func3..ctor(obj2, (IntPtr)obj20);
				IEnumerable<object> source = Enumerable.Where(list, func3);
				object obj27 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X0_v87+E4]");
				object obj28;
				Func<object, bool> keySelector;
				object obj30;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X0_v87+B8]");
					obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v57+8]");
					keySelector = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v57+8]");
					bool flag7 = (nint)0 == 0;
					object obj29 = !flag7;
					obj30 = 0;
					if (obj29 == null)
					{
						goto IL_0591;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj27 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X0_v87+B8]");
					obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v57+8]");
					keySelector = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v57+8]");
					bool flag8 = (nint)0 == 0;
					object obj31 = !flag8;
					obj30 = 0;
					if (obj31 == null)
					{
						goto IL_0591;
					}
				}
				goto IL_05f8;
				IL_0c29:
				NullReferenceException ex4 = new NullReferenceException();
				object obj33;
				obj32 = obj33;
				object obj35;
				obj34 = obj35;
				object obj36 = 0;
				object obj38;
				object obj37 = obj38;
				List<object> list2;
				list = list2;
				List<object> list3;
				obj9 = list3;
				goto IL_1176;
				IL_113e:
				NullReferenceException ex5 = new NullReferenceException();
				obj36 = 0;
				object obj39;
				obj26 = obj39;
				obj21 = 1;
				list = list2;
				obj9 = list3;
				goto IL_1176;
				IL_164c:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X0_v26+8]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v621 @ X0_v26] (should have been resolved before IL gen)");
				object obj40 = obj32;
				object obj41 = obj34;
				object obj42 = obj36;
				object obj43 = obj25;
				obj39 = obj26;
				object obj44 = obj8;
				List<object>.Enumerator enumerator5;
				List<object>.Enumerator enumerator4 = enumerator5;
				object obj46;
				object obj45 = obj46;
				object obj47 = obj21;
				object obj48 = obj19;
				object obj50;
				object obj49 = obj50;
				List<QueuePlayer> list4 = (List<QueuePlayer>)(object)list;
				object obj51 = obj9;
				goto IL_1590;
				IL_0814:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				object obj10 = obj52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X0_v83+8]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v841 @ X0_v83] (should have been resolved before IL gen)");
				bool flag9 = obj53 == null;
				object obj54 = !flag9;
				obj37 = 0;
				obj39 = (object)(&obj7);
				enumerator3 = (List<object>.Enumerator)0;
				if (obj54 != null)
				{
					goto IL_0965;
				}
				obj33 = obj32;
				obj35 = obj34;
				obj38 = 0;
				obj26 = (object)(&obj7);
				enumerator3 = (List<object>.Enumerator)0;
				obj5 = (object)(&obj7);
				goto IL_0c29;
				IL_0d45:
				object obj55 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj57;
				object obj56 = obj57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v14+12E]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v14+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0dfd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v14+B0]");
				object obj58 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X10_v10-8]");
					obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X10_v10-8]");
					if (0 == (nint)obj55)
					{
						break;
					}
					obj34 = obj58 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v14+12E]");
					obj10 = -1;
					bool flag10 = (nint)obj10 != 1;
					obj58 = obj34;
					if (flag10)
					{
						continue;
					}
					goto IL_0dfd;
				}
				obj10 = obj58;
				object obj59 = obj56 + obj58;
				object obj60 = obj59 + 312;
				obj34 = obj58;
				object obj61 = obj37;
				goto IL_164c;
				IL_1590:
				while (true)
				{
					bool flag11 = obj49 == null;
					object obj62 = !flag11;
					obj32 = obj40;
					obj34 = obj41;
					obj36 = obj42;
					obj37 = obj61;
					obj25 = obj43;
					obj26 = obj39;
					obj8 = obj44;
					enumerator5 = enumerator4;
					obj21 = obj47;
					obj19 = obj48;
					list = (List<object>)(object)list4;
					obj9 = obj51;
					if (obj62 != null)
					{
						OutOfMemoryException ex6 = new OutOfMemoryException();
						if ((nint)func == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
							obj50 = obj63;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
							bool flag12 = obj7 == null;
							object obj64 = !flag12;
							enumerator3 = (List<object>.Enumerator)obj63;
							obj46 = 0;
							obj57 = obj7;
							if (obj64 == null)
							{
								obj40 = obj32;
								obj41 = obj34;
								obj42 = obj36;
								obj61 = obj37;
								obj43 = obj25;
								obj39 = obj26;
								obj44 = obj8;
								enumerator4 = enumerator5;
								enumerator3 = (List<object>.Enumerator)obj63;
								obj45 = 0;
								obj47 = obj21;
								obj48 = obj19;
								obj49 = obj63;
								list4 = (List<QueuePlayer>)(object)list;
								obj51 = obj9;
								continue;
							}
							goto IL_0d45;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
						return;
					}
					break;
				}
				if ((nint)obj45 != 9)
				{
					bool flag13 = obj45 == null;
					object obj65 = !flag13;
					if (obj65 != null)
					{
						return;
					}
				}
				bool flag14 = (object)waitingList == null;
				obj32 = obj40;
				obj34 = obj41;
				obj36 = obj42;
				obj37 = obj61;
				obj25 = obj43;
				obj26 = obj39;
				obj8 = obj44;
				enumerator5 = enumerator4;
				obj21 = obj47;
				obj19 = obj48;
				list = (List<object>)(object)list4;
				obj9 = obj51;
				if (flag14)
				{
					break;
				}
				waitingList.SetData(list4);
				bool flag15 = (object)matchupsList == null;
				obj32 = obj40;
				obj34 = obj41;
				obj36 = obj42;
				obj37 = 0;
				obj25 = obj43;
				obj26 = obj39;
				obj8 = obj44;
				enumerator5 = enumerator4;
				obj21 = obj47;
				obj19 = obj48;
				func = (Func<object, bool>)(object)list4;
				list = (List<object>)(object)list4;
				obj9 = obj51;
				if (flag15)
				{
					break;
				}
				matchupsList.SetData((List<QueuePlayer>)obj51);
				bool flag16 = (object)inviteManager == null;
				obj32 = obj40;
				obj34 = obj41;
				obj36 = obj42;
				obj37 = 0;
				obj25 = obj43;
				obj26 = obj39;
				obj8 = obj44;
				enumerator5 = enumerator4;
				obj21 = obj47;
				obj19 = obj48;
				func = (Func<object, bool>)obj51;
				list = (List<object>)(object)list4;
				obj9 = obj51;
				if (flag16)
				{
					break;
				}
				inviteManager.QueueUpdated(list4, (List<QueuePlayer>)obj51);
				SetView();
				return;
				IL_1176:
				obj8 = obj24;
				enumerator5 = enumerator3;
				break;
				IL_05f8:
				object obj66 = (nint)0 + (nint)2488;
				IOrderedEnumerable<object> source2 = Enumerable.OrderByDescending(source, keySelector);
				object obj67 = (nint)0 + (nint)2576;
				list2 = Enumerable.ToList(source2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj68 = (nint)0 + (nint)272;
				func4..ctor(obj2, (IntPtr)obj68);
				IEnumerable<object> source3 = Enumerable.Where(_fullQueue, func4);
				list3 = Enumerable.ToList(source3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj5 = (nint)0 + (nint)1288;
				func5..ctor((object)this, (IntPtr)obj5);
				obj37 = obj21;
				IEnumerable<object> enumerable = Enumerable.Where(_fullQueue, func5);
				bool flag17 = enumerable == null;
				obj7 = 0;
				obj36 = 0;
				obj26 = (object)(&enumerator);
				obj8 = obj24;
				enumerator5 = enumerator3;
				enumerator3 = (List<object>.Enumerator)0;
				func = func5;
				list = list2;
				obj9 = list3;
				if (flag17)
				{
					break;
				}
				object obj69 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3672;
				nint num2 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ X8_v39 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
				object obj70 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ X8_v39 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0814;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ X8_v39 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
				obj35 = (nint)0 + (nint)8;
				bool flag18 = flag19;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X10_v13-8]");
					obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X10_v13-8]");
					object obj71 = 0 - obj69;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X10_v13-8]");
					if (0 == (nint)obj69)
					{
						break;
					}
					obj34 = obj35 + 16;
					obj70--;
					obj71 = obj70 - 1;
					bool flag20 = obj71 == null;
					flag19 = (nint)obj70 != 1;
					flag18 = flag19;
					obj35 = obj34;
					if (flag19)
					{
						continue;
					}
					goto IL_0814;
				}
				object obj72 = num2 + obj35;
				object obj73 = obj72 + 312;
				obj10 = obj73;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X8_v54+8]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v878 @ X8_v54] (should have been resolved before IL gen)");
				bool flag21 = obj53 == null;
				flag19 = flag18;
				obj34 = obj35;
				obj39 = (object)(&obj7);
				enumerator3 = (List<object>.Enumerator)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X10_v13-8]");
				obj33 = 0;
				obj38 = obj37;
				obj26 = (object)(&obj7);
				enumerator3 = (List<object>.Enumerator)0;
				obj5 = (object)(&obj7);
				if (!flag21)
				{
					goto IL_0965;
				}
				goto IL_0c29;
				IL_0965:
				object obj74 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				object obj75 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1104;
				object obj76 = obj53;
				while (true)
				{
					object obj77 = obj76;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v43+12E]");
					obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v43+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0a35;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v43+B0]");
					object obj78 = (nint)0 + (nint)8;
					bool flag22 = flag19;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X10_v26-8]");
						obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X10_v26-8]");
						object obj71 = 0 - obj74;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X10_v26-8]");
						if (0 == (nint)obj74)
						{
							break;
						}
						obj34 = obj78 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v43+12E]");
						obj10 = -1;
						obj71 = obj10 - 1;
						bool flag20 = obj71 == null;
						flag19 = (nint)obj10 != 1;
						flag22 = flag19;
						obj78 = obj34;
						if (flag19)
						{
							continue;
						}
						goto IL_0a35;
					}
					obj10 = obj78;
					object obj79 = obj77 + obj78;
					obj80 = obj79 + 312;
					flag19 = flag22;
					obj34 = obj78;
					goto IL_147f;
					IL_147f:
					obj5 = obj80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X0_v69+8]");
					func = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v989 @ X0_v69] (should have been resolved before IL gen)");
					object obj81 = obj82 & 1;
					if (obj81 == null)
					{
						break;
					}
					if (obj7 == null)
					{
						goto IL_113e;
					}
					object obj83 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X8_v46+12E]");
					obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X8_v46+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0b7a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X8_v46+B0]");
					object obj84 = (nint)0 + (nint)8;
					bool flag23 = flag19;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ X10_v21-8]");
						obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ X10_v21-8]");
						object obj71 = 0 - obj75;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ X10_v21-8]");
						if (0 == (nint)obj75)
						{
							break;
						}
						obj34 = obj84 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X8_v46+12E]");
						obj10 = -1;
						obj71 = obj10 - 1;
						bool flag20 = obj71 == null;
						flag19 = (nint)obj10 != 1;
						flag23 = flag19;
						obj84 = obj34;
						if (flag19)
						{
							continue;
						}
						goto IL_0b7a;
					}
					obj10 = obj84;
					object obj85 = obj83 + obj84;
					object obj86 = obj85 + 312;
					flag19 = flag23;
					obj34 = obj84;
					goto IL_151c;
					IL_151c:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X0_v73+8]");
					func = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1052 @ X0_v73] (should have been resolved before IL gen)");
					if (obj87 != null)
					{
						_ = 1;
						bool flag24 = obj7 == null;
						object obj88 = !flag24;
						obj33 = obj32;
						obj35 = obj34;
						obj38 = obj37;
						obj26 = obj39;
						obj21 = 1;
						obj76 = obj7;
						if (obj88 != null)
						{
							continue;
						}
						goto IL_0c29;
					}
					goto IL_1106;
					IL_0b7a:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj37 = 0;
					goto IL_151c;
					IL_0a35:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj37 = 0;
					goto IL_147f;
				}
				bool flag25 = obj7 == null;
				obj36 = 0;
				obj26 = obj39;
				obj8 = obj24;
				enumerator5 = enumerator3;
				obj46 = 9;
				obj21 = 1;
				obj57 = obj7;
				obj50 = 0;
				list = list2;
				obj9 = list3;
				obj40 = obj32;
				obj41 = obj34;
				obj42 = 0;
				obj61 = obj37;
				obj43 = obj25;
				obj44 = obj24;
				enumerator4 = enumerator3;
				obj45 = 9;
				obj47 = 1;
				obj48 = obj19;
				obj49 = 0;
				list4 = (List<QueuePlayer>)(object)list2;
				obj51 = list3;
				if (!flag25)
				{
					goto IL_0d45;
				}
				goto IL_1590;
				IL_0dfd:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj61 = 0;
				goto IL_164c;
				IL_0591:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X0_v87+E4]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X0_v87+E4]");
				bool flag26 = (nint)0 == 0;
				object obj89 = !flag26;
				if (obj89 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj90 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v61+B8]");
					obj28 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj91 = (nint)0 + (nint)256;
				func6..ctor(obj28, (IntPtr)obj91);
				object obj92 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v60+B8]");
				object obj93 = (nint)0 + (nint)8;
				obj93 = func6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj30 = 0;
				keySelector = func6;
				goto IL_05f8;
				IL_1106:
				NullReferenceException ex7 = new NullReferenceException();
				obj36 = 0;
				obj26 = obj39;
				obj21 = 1;
				list = list2;
				obj9 = list3;
				goto IL_1176;
			}
		}
		goto IL_1335;
		IL_0182:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag27 = (object)sessionModel == null;
		object obj94 = !flag27;
		if (obj94 != null)
		{
			goto IL_02bf;
		}
		obj7 = 0;
		obj8 = 0;
		enumerator = (List<object>.Enumerator)0;
		func = func2;
		obj9 = obj2;
		goto IL_1335;
	}

	private void OnExtensionResponse(ISFSObject param)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0068: Expected O, but got I4
		//IL_0071: Expected O, but got I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_014d: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_0164: Expected O, but got I4
		object varName = "destinationTimeZone" + 2696;
		object defaultValue = (nint)0 + (nint)2000;
		object obj = "tournament_participate_warning_body_with_tickets_warning_daily" + 1504;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		string text = SFSExtensions.Get(param, (string)varName, (string)defaultValue);
		string text2 = (string)obj;
		object obj4;
		object obj7;
		if (text == (string)obj)
		{
			object obj3 = obj2;
			obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			object obj6 = 0;
			obj7 = obj4;
			if (obj5 == null)
			{
				goto IL_0087;
			}
		}
		else
		{
			object obj8 = "m_StencilDeferredPS" + 3848;
			text2 = (string)obj8;
			if (!(text == (string)obj8))
			{
				return;
			}
			object obj3 = obj2;
			obj7 = "tournament_participate_warning_body_with_tickets_warning_daily" + 64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				object obj6 = 0;
				obj4 = obj7;
				goto IL_0087;
			}
		}
		goto IL_009e;
		IL_009e:
		object title = "tournament_participate_warning_body_with_tickets_warning_daily" + 56;
		object buttonText = "Network Authentication Required" + 3128;
		PopupWindow.ShowError((string)title, (string)obj7, (string)buttonText);
		return;
		IL_0087:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj7 = obj4;
		goto IL_009e;
	}

	private void OnSelectingPlayer(QueuePlayer player)
	{
		//IL_0016: Expected O, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01a9: Expected O, but got I
		//IL_01d3: Expected O, but got I4
		//IL_022e: Expected O, but got I
		//IL_031d: Expected O, but got I
		//IL_03ce: Expected O, but got I4
		//IL_038b: Expected O, but got I4
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected O, but got Unknown
		//IL_052e: Expected O, but got I4
		//IL_0455: Expected O, but got I4
		//IL_04a2: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E01]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B3]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B3]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v31+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		goto IL_015a;
		IL_0367:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_03f5;
		}
		goto IL_0577;
		IL_054b:
		ClearPlayersSelection();
		return;
		IL_0577:
		throw new NullReferenceException();
		IL_0082:
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v36+B8]");
		object obj12 = 0;
		obj9 = obj12;
		bool flag4 = obj12 == null;
		object obj13 = !flag4;
		if (obj13 != null)
		{
			goto IL_015a;
		}
		goto IL_0577;
		IL_015a:
		object obj14 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v92 @ X8_v4+188] (should have been resolved before IL gen)");
		object obj15 = default(object);
		if (obj15 == null)
		{
			return;
		}
		object obj16 = typeof(Queue<string>) + 848;
		object obj17 = (nint)0 + (nint)2200;
		object obj18 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj19 = !flag5;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser = sessionModel2.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v4+50]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v4+50]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v7+10]");
			if ((nint)0 == intDbId)
			{
				PlayerInfo <info>k__BackingField = player.<info>k__BackingField;
				QueuePlayer.Status status = inviteManager.GetStatus(<info>k__BackingField.<DBID>k__BackingField);
				if (status == QueuePlayer.Status.PendingResponse)
				{
					inviteManager.PlayerSelected(player);
				}
				else
				{
					SelectPlayer(player);
				}
				return;
			}
		}
		PlayerInfo <info>k__BackingField2 = player.<info>k__BackingField;
		if (<info>k__BackingField2.<DBID>k__BackingField == intDbId)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DFE]");
		object obj21 = (nint)0 & (nint)1;
		if (obj21 != null)
		{
			object obj22 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v29+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0367;
			}
		}
		else
		{
			_ = 1;
			object obj22 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v29+E4]");
			bool flag6 = (nint)0 == 0;
			object obj23 = !flag6;
			if (obj23 != null)
			{
				goto IL_0367;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_03f5;
		IL_03f5:
		Room currentRoom = sessionModel.CurrentRoom;
		if (SFSKammelnaRoomExtensions.CanTournamentParticipantsChooseTeam(currentRoom))
		{
			bool flag7 = IsTeamed(intDbId);
			bool flag8 = !flag7;
			object obj24 = !flag8;
			if (obj24 == null)
			{
				PlayerInfo <info>k__BackingField3 = player.<info>k__BackingField;
				bool flag9 = IsTeamed(<info>k__BackingField3.<DBID>k__BackingField);
				bool flag10 = !flag9;
				object obj25 = !flag10;
				if (obj25 == null)
				{
					int <order>k__BackingField = player.<order>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v4+70]");
					if ((nint)<order>k__BackingField >= (nint)0)
					{
						inviteManager.PlayerSelected(player);
						goto IL_054b;
					}
				}
			}
		}
		int num = default(int);
		string dbId = num.ToString();
		object obj26 = typeof(MemberAchievementClanFeedData) + 840;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v19+E4]");
		bool flag11 = (nint)0 == 0;
		object obj28 = !flag11;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		MiniProfilePopup.Show(dbId, TrackingPlacement.TournamentTeams);
		goto IL_054b;
	}

	private void SelectPlayer(QueuePlayer player)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0a03: Expected O, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_010a: Expected O, but got I
		//IL_011b: Expected I, but got O
		//IL_012c: Expected O, but got I
		//IL_0134: Expected I4, but got O
		//IL_04e3: Expected O, but got I
		//IL_0176: Expected O, but got I4
		//IL_053d: Expected O, but got I4
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Expected O, but got Unknown
		//IL_08f6: Expected O, but got I
		//IL_07c9: Expected O, but got I
		//IL_0781: Expected O, but got I
		//IL_0791: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_0924: Expected I, but got O
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected O, but got Unknown
		//IL_0842: Expected O, but got I4
		//IL_0983: Expected O, but got I
		//IL_046f: Expected O, but got I
		//IL_0a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Expected O, but got Unknown
		//IL_0a5c: Expected O, but got I4
		//IL_089c: Expected O, but got I
		//IL_08ac: Expected O, but got I
		//IL_09be: Expected O, but got I4
		//IL_0484: Expected O, but got I
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected O, but got Unknown
		//IL_07e2: Expected O, but got I
		//IL_07ea: Expected I4, but got O
		//IL_0815: Expected O, but got I
		//IL_05fc: Expected O, but got I
		//IL_062a: Expected O, but got I
		//IL_033f: Expected O, but got I
		//IL_0359: Expected O, but got I4
		//IL_0659: Expected O, but got I
		//IL_0667: Expected I4, but got O
		//IL_06fa: Expected O, but got I
		//IL_0373: Expected O, but got I
		//IL_037b: Expected I4, but got O
		//IL_03b6: Expected O, but got I4
		//IL_0755: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v6+B8]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v506 @ X8_v8+188] (should have been resolved before IL gen)");
		object obj9 = obj2 + 24;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj9 == null)
		{
			return;
		}
		object obj11 = obj3;
		List<object> list = (List<object>)(object)selectedPlayers;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X1_v16 (System.Object)+20]");
		Component component;
		int num;
		if ((nint)0 == 1)
		{
			object obj12 = typeof(List<Tween>) + 3408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)280;
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor(obj2, (IntPtr)obj13);
			object obj14 = (nint)0 + (nint)2960;
			num = (int)obj14;
			int num2 = list.RemoveAll(predicate);
			UpdateTournamentQueue();
			component = unsetTeamButton;
			bool flag = (object)unsetTeamButton == null;
			object obj15 = !flag;
			int num3 = 0;
			if (obj15 != null)
			{
				goto IL_08d6;
			}
			goto IL_09cc;
		}
		object obj19;
		IntPtr intPtr = default(IntPtr);
		List<object> list2;
		object obj40;
		if (list._size != 1)
		{
			if (list._size != 2)
			{
				object obj16 = (nint)0 + (nint)2928;
				object obj17 = obj16;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				bool flag2 = list._size < items.Length;
				object obj18 = !flag2;
				if (obj18 == null)
				{
					int size = list._size + 1;
					list._size = size;
					obj19 = items + list._size;
					num = (int)(nint)intPtr;
					goto IL_0a10;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X9_v15+20]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v32+C0]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v33+70]");
				num = 0;
				list2 = list;
				goto IL_0a6a;
			}
			object obj22 = list.get_Item(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v44 (System.Object)+1C]");
			object obj23 = (nint)0 + (nint)1;
			if (obj23 != null)
			{
				object obj24 = ((List<object>)(object)selectedPlayers).get_Item(0);
				object obj25 = ((List<object>)(object)selectedPlayers).get_Item(1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v55 (System.Object)+1C]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v57 (System.Object)+1C]");
				if (num4 == 0)
				{
					List<QueuePlayer> list3 = selectedPlayers;
					num = list3._size;
					int version2 = list3._version + 1;
					list3._size = 0;
					list3._version = version2;
					if (list3._size >= 1)
					{
						Array.Clear(list3._items, 0, list3._size);
						int num3 = 0;
					}
					obj11 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X1_v16 (System.Object)+1C]");
					object obj26 = (nint)0 + (nint)1;
					bool flag3 = obj26 == null;
					object obj27 = !flag3;
					if (obj27 != null)
					{
						goto IL_08c1;
					}
					object obj28 = (nint)0 + (nint)2928;
					num = (int)obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9C1C4");
					UpdateTournamentQueue();
					component = unsetTeamButton;
					bool flag4 = (object)unsetTeamButton == null;
					object obj29 = !flag4;
					if (obj29 != null)
					{
						goto IL_08d6;
					}
					goto IL_09cc;
				}
			}
			object obj30 = obj3;
			object obj31 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v36+18]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X9_v17+70]");
			if (num5 < 0)
			{
				object obj32 = ((List<object>)(object)selectedPlayers).get_Item(0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v48 (System.Object)+10]");
				object obj33 = 0;
				object obj34 = ((List<object>)(object)selectedPlayers).get_Item(1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v50 (System.Object)+10]");
				object obj35 = 0;
				object obj36 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X9_v19+18]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X9_v19+18]");
				object obj37 = num6 + 0;
				int num3 = obj37 >> 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v42+10]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v43+10]");
				((TournamentQueueController)obj34).SendSeatTeamRequest((int)num7, 0, num3);
				List<QueuePlayer> list4 = selectedPlayers;
				num = list4._size;
				int version3 = list4._version + 1;
				list4._size = 0;
				list4._version = version3;
				bool flag5 = list4._size < 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v42+10]");
				obj11 = 0;
				if (flag5)
				{
					goto IL_08c1;
				}
				Array.Clear(list4._items, 0, list4._size);
				UpdateTournamentQueue();
				component = unsetTeamButton;
				bool flag6 = (object)unsetTeamButton == null;
				object obj38 = !flag6;
				num3 = 0;
				if (obj38 != null)
				{
					goto IL_08d6;
				}
				goto IL_09cc;
			}
			object obj39 = (nint)0 + (nint)2968;
			num = (int)obj39;
			((List<object>)(object)selectedPlayers).RemoveAt(1);
			list2 = (List<object>)(object)selectedPlayers;
			obj40 = (nint)0 + (nint)2928;
			obj11 = obj3;
		}
		else
		{
			object obj41 = Enumerable.First(list);
			obj11 = obj3;
			object obj42 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X1_v16 (System.Object)+18]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v23+70]");
			if (num8 < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v33 (System.Object)+18]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v33 (System.Object)+18]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v23+70]");
				if (num9 < 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v33 (System.Object)+10]");
					object obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X1_v16 (System.Object)+10]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X9_v12+10]");
					int num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v30+10]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v33 (System.Object)+18]");
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X9_v12+10]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X1_v16 (System.Object)+18]");
					((TournamentQueueController)obj41).SendSwapRequest((int)num10, (int)num11, (int)num12, 0);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X1_v16 (System.Object)+18]");
					SendSeatPlayerRequest(0);
				}
				object obj45 = (nint)0 + (nint)2936;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223933C");
				UpdateTournamentQueue();
				component = unsetTeamButton;
				bool flag7 = (object)unsetTeamButton == null;
				object obj46 = !flag7;
				if (obj46 != null)
				{
					goto IL_08d6;
				}
				goto IL_09cc;
			}
			list2 = (List<object>)(object)selectedPlayers;
			obj40 = (nint)0 + (nint)2928;
			num = (int)(nint)intPtr;
		}
		object obj47 = obj40;
		int version4 = list2._version + 1;
		list2._version = version4;
		object[] items2 = list2._items;
		bool flag8 = list2._size < items2.Length;
		object obj48 = !flag8;
		if (obj48 == null)
		{
			int size2 = list2._size + 1;
			list2._size = size2;
			obj19 = items2 + list2._size;
			goto IL_0a10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v14+20]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v15+C0]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v16+70]");
		num = 0;
		goto IL_0a6a;
		IL_0a6a:
		list2.AddWithResize(obj11);
		goto IL_08c1;
		IL_08c1:
		UpdateTournamentQueue();
		component = unsetTeamButton;
		goto IL_08d6;
		IL_0a10:
		object obj51 = obj19 + 32;
		obj51 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateTournamentQueue();
		component = unsetTeamButton;
		bool flag9 = (object)unsetTeamButton == null;
		object obj52 = !flag9;
		if (obj52 != null)
		{
			goto IL_08d6;
		}
		goto IL_09cc;
		IL_08d6:
		object obj53 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2992;
		object obj54 = (nint)0 + (nint)288;
		GameObject gameObject = component.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj54);
		bool active = Enumerable.Any(selectedPlayers, func);
		gameObject.SetActive(active);
		tournamentEventsChannel.TriggerPlayersSelected(selectedPlayers);
		return;
		IL_09cc:
		throw new NullReferenceException();
	}

	private void OnSelectingTeam(QueuePlayer player1, QueuePlayer player2)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Expected O, but got Unknown
		//IL_07a3: Expected O, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0099: Expected O, but got I
		//IL_03a8: Expected O, but got I
		//IL_03d2: Expected O, but got I4
		//IL_03db: Expected O, but got I4
		//IL_00da: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_012d: Expected O, but got I4
		//IL_040a: Expected O, but got I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_04b0: Expected O, but got I
		//IL_050a: Expected O, but got I4
		//IL_049f: Expected I, but got O
		//IL_0254: Expected O, but got I
		//IL_057f: Expected O, but got I
		//IL_058f: Expected O, but got I
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		//IL_061a: Expected O, but got I4
		//IL_0690: Expected O, but got I
		//IL_06a0: Expected O, but got I
		//IL_02ca: Expected O, but got I
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected O, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected O, but got Unknown
		//IL_070c: Expected O, but got I
		//IL_071d: Expected I, but got O
		//IL_0396: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v5+B8]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ X8_v8+188] (should have been resolved before IL gen)");
		object obj8 = obj2 + 16;
		int num = default(int);
		obj8 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj8;
		if (obj8 == null)
		{
			return;
		}
		object obj10 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v9+50]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v9+50]");
		object obj13;
		int? num4;
		int? num5;
		object obj16;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v11+10]");
			int num2 = 0;
			object obj12 = (nint)0 + (nint)3136;
			QueuePlayer queuePlayer = (QueuePlayer)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v11+10]");
			int? num3 = 0;
			obj13 = (nint)0 + (nint)2200;
			object obj14 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v47+E4]");
			bool flag = (nint)0 == 0;
			object obj15 = !flag;
			num4 = num3;
			obj16 = obj13;
			num5 = num3;
			if (obj15 == null)
			{
				goto IL_0153;
			}
		}
		else
		{
			obj16 = (nint)0 + (nint)2200;
			object obj14 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v47+E4]");
			bool flag2 = (nint)0 == 0;
			object obj17 = !flag2;
			num5 = (int?)(object)0;
			if (obj17 == null)
			{
				obj13 = obj16;
				QueuePlayer queuePlayer = player2;
				int num2 = num;
				num4 = (int?)(object)0;
				goto IL_0153;
			}
		}
		goto IL_0172;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj16 = obj13;
		num5 = num4;
		goto IL_0172;
		IL_0172:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj18 = (object?)num5 >> 32;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		if (intDbId != (nint)obj18)
		{
			return;
		}
		object obj19 = (??)num5 & 1;
		if (obj19 == null)
		{
			return;
		}
		List<object> list = (List<object>)(object)selectedPlayers;
		int size;
		if (list._size == 2)
		{
			object obj20 = list.get_Item(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v41 (System.Object)+10]");
			object obj21 = 0;
			PlayerInfo <info>k__BackingField = player1.<info>k__BackingField;
			list = (List<object>)(object)selectedPlayers;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v34+10]");
			if ((nint)0 == <info>k__BackingField.<DBID>k__BackingField)
			{
				object obj22 = ((List<object>)(object)selectedPlayers).get_Item(1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v44 (System.Object)+10]");
				object obj23 = 0;
				PlayerInfo <info>k__BackingField2 = player2.<info>k__BackingField;
				list = (List<object>)(object)selectedPlayers;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v37+10]");
				if ((nint)0 == <info>k__BackingField2.<DBID>k__BackingField)
				{
					size = list._size;
					int version = list._version + 1;
					list._size = 0;
					list._version = version;
					if (list._size >= 1)
					{
						Array.Clear(list._items, 0, list._size);
						nint num6 = unchecked((nint)null);
					}
					goto IL_06c3;
				}
			}
		}
		size = list._size;
		int version2 = list._version + 1;
		list._size = 0;
		list._version = version2;
		bool flag3 = list._size < 1;
		List<object> list2 = list;
		if (!flag3)
		{
			Array.Clear(list._items, 0, list._size);
			list2 = (List<object>)(object)selectedPlayers;
			nint num6 = unchecked((nint)null);
		}
		object obj24 = (nint)0 + (nint)2928;
		object obj25 = obj24;
		int version3 = list2._version + 1;
		list2._version = version3;
		object[] items = list2._items;
		bool flag4 = list2._size < items.Length;
		object obj26 = !flag4;
		if (obj26 == null)
		{
			int size2 = list2._size + 1;
			list2._size = size2;
			object obj27 = items + list2._size;
			object obj28 = obj27 + 32;
			obj28 = player1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v25+20]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v31+C0]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v32+70]");
			size = 0;
			list2.AddWithResize((object)player1);
		}
		List<object> list3 = (List<object>)(object)selectedPlayers;
		object obj31 = obj24;
		int version4 = list3._version + 1;
		list3._version = version4;
		object[] items2 = list3._items;
		bool flag5 = list3._size < items2.Length;
		object obj32 = !flag5;
		if (obj32 == null)
		{
			int size3 = list3._size + 1;
			list3._size = size3;
			object obj33 = items2 + list3._size;
			object obj34 = obj33 + 32;
			obj34 = player2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v27+20]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v28+C0]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v29+70]");
			size = 0;
			list3.AddWithResize((object)player2);
		}
		goto IL_06c3;
		IL_06c3:
		UpdateTournamentQueue();
		GameObject gameObject = unsetTeamButton.gameObject;
		object obj37 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj38 = (nint)0 + (nint)296;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj38);
		bool active = Enumerable.Any(selectedPlayers, func);
		gameObject.SetActive(active);
		tournamentEventsChannel.TriggerPlayersSelected(selectedPlayers);
	}

	private void OnSeatSelected(int seat)
	{
		GameObject gameObject = unsetTeamButton.gameObject;
		gameObject.SetActive(value: false);
		if (Enumerable.Any((IEnumerable<object>)selectedPlayers))
		{
			SendSeatPlayerRequest(seat);
			ClearPlayersSelection();
		}
	}

	private void OnTeamSelected(int teamIndex)
	{
		//IL_0083: Expected O, but got I
		//IL_00b1: Expected O, but got I
		GameObject gameObject = unsetTeamButton.gameObject;
		gameObject.SetActive(value: false);
		List<object> list = (List<object>)(object)selectedPlayers;
		if (list._size == 2)
		{
			object obj = list.get_Item(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v7 (System.Object)+10]");
			object obj2 = 0;
			object obj3 = ((List<object>)(object)selectedPlayers).get_Item(1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v9 (System.Object)+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v5+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v6+10]");
			((TournamentQueueController)obj3).SendSeatTeamRequest((int)num, 0, teamIndex);
			ClearPlayersSelection();
		}
	}

	private void OnKickPlayer(int playerDbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_00d7: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)304;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3968;
		object msgBody = "Added Tournament Prizes And Features" + 2184;
		object obj6 = obj2 + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action);
	}

	private void OnBreakTeam(int teamIndex)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_00d7: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)312;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "AvailableVoices" + 2680;
		object msgBody = "Added Tournament Prizes And Features" + 2168;
		object obj6 = obj2 + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action);
	}

	private void UnsetTeam()
	{
		//IL_006d: Expected O, but got I
		//IL_00ca: Expected O, but got I4
		GameObject gameObject = unsetTeamButton.gameObject;
		gameObject.SetActive(value: false);
		if (Enumerable.Any((IEnumerable<object>)selectedPlayers))
		{
			object obj2;
			do
			{
				object item = Enumerable.First((IEnumerable<object>)selectedPlayers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v12 (System.Object)+10]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v6+10]");
				SendUnseat(0);
				bool flag = ((List<object>)(object)selectedPlayers).Remove(item);
				bool flag2 = Enumerable.Any((IEnumerable<object>)selectedPlayers);
				bool flag3 = !flag2;
				obj2 = !flag3;
			}
			while (obj2 != null);
		}
		ClearPlayersSelection();
	}

	private void AllowParticipantsChanged(bool isOn)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "com.unity.services.authentication.profile" + 392;
		object key2 = "alignContent" + 680;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFSExtensions.Put(sFSObject, (string)key2, isOn);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	private void ShuffleTeamsChanged(bool isOn)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "com.unity.services.authentication.profile" + 392;
		object key2 = "setMimeType" + 1768;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFSExtensions.Put(sFSObject, (string)key2, isOn);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	public void FillTeams()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		object key = "clear_mass_tournaments" + 264;
		object value = "fetch_products" + 208;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 832;
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, (string)value);
		SFS.SendRoomExtensionRequest((string)command, param);
		ClearPlayersSelection();
	}

	public void ResetTeams()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		object key = "clear_mass_tournaments" + 264;
		object value = "placementId" + 3520;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 832;
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, (string)value);
		SFS.SendRoomExtensionRequest((string)command, param);
		ClearPlayersSelection();
	}

	public void Teamup()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_014e: Expected O, but got I
		//IL_015e: Expected O, but got I
		//IL_0188: Expected O, but got I4
		//IL_00d7: Expected O, but got I
		//IL_00e7: Expected O, but got I
		//IL_0111: Expected O, but got I4
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_01c0: Expected O, but got I4
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_028f: Expected O, but got I
		//IL_02a0: Expected I, but got O
		//IL_02be: Expected O, but got I
		//IL_01f0: Expected O, but got I
		List<QueuePlayer> list = selectedPlayers;
		SFSObject sFSObject = default(SFSObject);
		object obj3;
		object obj5;
		Func<object, int> selector;
		string key2;
		string text;
		if (list._size == 2)
		{
			object obj = typeof(RegisteredWaitHandle) + 2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			sFSObject..ctor();
			object key = "clear_mass_tournaments" + 264;
			object obj2 = "startPosition" + 2440;
			SFSExtensions.Put(sFSObject, (string)key, (string)obj2);
			obj3 = typeof(SkeletonBinary.SkeletonInput) + 3824;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v15+B8]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v19+10]");
				selector = (Func<object, int>)0;
				key2 = (string)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v19+10]");
				bool flag = (nint)0 == 0;
				object obj6 = !flag;
				if (obj6 == null)
				{
					text = (string)obj2;
					goto IL_019e;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v15+B8]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v19+10]");
				selector = (Func<object, int>)0;
				text = (string)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v19+10]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				key2 = (string)obj2;
				if (obj7 == null)
				{
					goto IL_019e;
				}
			}
			goto IL_01f5;
		}
		goto IL_024f;
		IL_01f5:
		IEnumerable<int> source = Enumerable.Select(selectedPlayers, selector);
		List<int> val = Enumerable.ToList(source);
		SFSExtensions.Put(sFSObject, key2, val);
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 832;
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
		goto IL_024f;
		IL_024f:
		ClearPlayersSelection();
		return;
		IL_019e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v25+B8]");
			obj5 = 0;
		}
		object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)248;
		Func<object, int> func = default(Func<object, int>);
		func..ctor(obj5, (IntPtr)obj11);
		object obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v24+B8]");
		object obj13 = (nint)0 + (nint)16;
		obj13 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector = func;
		key2 = text;
		goto IL_01f5;
	}

	private void UpdateParticipantsToggle()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DFE]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
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
		goto IL_0133;
		IL_0133:
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		bool isOnWithoutNotify = SFSKammelnaRoomExtensions.CanTournamentParticipantsChooseTeam(currentRoom);
		allowParticipantsToggle.SetIsOnWithoutNotify(isOnWithoutNotify);
		SetView();
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	private void UpdateShuffleTeamsToggle()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DFE]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
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
		goto IL_0133;
		IL_0133:
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		bool isOnWithoutNotify = SFSKammelnaRoomExtensions.IsTournamentTeamsShuffled(currentRoom);
		shuffleTeamsToggle.SetIsOnWithoutNotify(isOnWithoutNotify);
		UpdateTournamentQueue();
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	private void SendSeatPlayerRequest(int seat)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "tournament_participate_warning_body_with_tickets_warning_daily" + 3360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		object obj2 = Enumerable.First((IEnumerable<object>)selectedPlayers);
		int num = default(int);
		string key2 = num.ToString();
		ISFSObject val2 = SfsObjectUtil.FromOneValue(key2, seat);
		object key3 = "startPosition" + 3440;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 832;
		sFSObject.PutSFSObject((string)key3, val2);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	private static void SendUnseat(int playerId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "tournament_participate_warning_body_with_tickets_warning_daily" + 3216;
		object key2 = "placementId" + 264;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFSExtensions.Put(sFSObject, (string)key2, playerId);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	private void SendSwapRequest(int id1, int seat1, int id2, int seat2)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "tournament_participate_warning_body_with_tickets_warning_daily" + 3360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject2 = default(SFSObject);
		sFSObject2..ctor();
		int num = default(int);
		string key2 = num.ToString();
		SFSExtensions.Put(sFSObject2, key2, seat2);
		int num2 = default(int);
		string key3 = num2.ToString();
		SFSExtensions.Put(sFSObject2, key3, seat1);
		object key4 = "startPosition" + 3440;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 832;
		sFSObject.PutSFSObject((string)key4, sFSObject2);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	private void SendSeatTeamRequest(int id1, int id2, int teamIndex)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "tournament_participate_warning_body_with_tickets_warning_daily" + 3360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		int val2 = teamIndex << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject2 = default(SFSObject);
		sFSObject2..ctor();
		int num = default(int);
		string key2 = num.ToString();
		SFSExtensions.Put(sFSObject2, key2, val2);
		int num2 = default(int);
		string key3 = num2.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
		SFSExtensions.Put(sFSObject2, key3, 1);
		object key4 = "startPosition" + 3440;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 832;
		sFSObject.PutSFSObject((string)key4, sFSObject2);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	private void SetView()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_04ec: Expected O, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0068: Expected O, but got I
		//IL_0092: Expected O, but got I4
		//IL_0127: Expected O, but got I
		//IL_01fd: Expected O, but got I
		//IL_02ae: Expected O, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_026b: Expected O, but got I4
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected O, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0354: Expected O, but got I
		//IL_0365: Expected I, but got O
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected O, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_0376: Expected O, but got I
		//IL_039d: Expected O, but got I4
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_0403: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5+B8]");
		object obj5 = 0;
		object obj6 = obj5;
		GameObject[] array;
		GameObject[] array3;
		GameObject[][] array4;
		SessionModel sessionModel2 = default(SessionModel);
		if (obj5 != null)
		{
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ X8_v9+188] (should have been resolved before IL gen)");
			object obj8 = default(object);
			if (obj8 == null)
			{
				return;
			}
			object obj9 = typeof(Queue<string>) + 848;
			object obj10 = (nint)0 + (nint)2200;
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj12 = !flag;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
				if (obj2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v10+50]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v10+50]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v11+10]");
						if ((nint)0 == intDbId)
						{
							array = ownerObjects;
							object obj14 = typeof(TypeConverter<ushort, char>) + 1480;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
							GameObject[][] array2 = default(GameObject[][]);
							if (array2 != null)
							{
								array3 = playerObjects;
								array4 = array2;
								goto IL_053f;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DFE]");
							object obj15 = (nint)0 & (nint)1;
							if (obj15 != null)
							{
								object obj16 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v39+E4]");
								if ((nint)0 != 0)
								{
									goto IL_0247;
								}
							}
							else
							{
								_ = 1;
								object obj16 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v39+E4]");
								bool flag2 = (nint)0 == 0;
								object obj17 = !flag2;
								if (obj17 != null)
								{
									goto IL_0247;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
							if ((object)sessionModel2 != null)
							{
								goto IL_02f2;
							}
						}
					}
				}
			}
		}
		goto IL_0493;
		IL_0511:
		object obj18 = array4 + 40;
		GameObject[] array5;
		obj18 = array5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject[] objectToEnable;
		SetView(objectToEnable, array4);
		return;
		IL_0247:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel2 == null;
		object obj19 = !flag3;
		if (obj19 != null)
		{
			goto IL_02f2;
		}
		goto IL_0493;
		IL_053f:
		object obj20 = array4 + 32;
		obj20 = array3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		array5 = spectatorObjects;
		objectToEnable = array;
		goto IL_0511;
		IL_0493:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_02f2:
		Room currentRoom = sessionModel2.CurrentRoom;
		if (SFSKammelnaRoomExtensions.CanTournamentParticipantsChooseTeam(currentRoom))
		{
			object obj21 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj22 = (nint)0 + (nint)320;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj22);
			object obj23 = (nint)0 + (nint)2760;
			bool flag4 = Enumerable.Any(_fullQueue, func);
			bool flag5 = !flag4;
			object obj24 = 0;
			if (!flag5)
			{
				array = playerObjects;
				object obj25 = typeof(TypeConverter<ushort, char>) + 1480;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				GameObject[][] array6 = default(GameObject[][]);
				if (array6 == null)
				{
					goto IL_0493;
				}
				array3 = ownerObjects;
				obj24 = 0;
				array4 = array6;
				goto IL_053f;
			}
		}
		objectToEnable = spectatorObjects;
		object obj26 = typeof(TypeConverter<ushort, char>) + 1480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		GameObject[][] array7 = default(GameObject[][]);
		if (array7 == null)
		{
			goto IL_0493;
		}
		object obj27 = array7 + 32;
		obj27 = ownerObjects;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		array5 = playerObjects;
		array4 = array7;
		goto IL_0511;
	}

	private bool IsSelected(QueuePlayer player)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00f0: Expected I4, but got O
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I
		//IL_00bf: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = player;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj3;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+10]");
				if ((nint)0 != 0)
				{
					object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2992;
					object obj6 = (nint)0 + (nint)328;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor(obj2, (IntPtr)obj6);
					return Enumerable.Any(selectedPlayers, func);
				}
				return false;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool IsTeamed(int playerId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0153: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0065: Expected I, but got O
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I
		//IL_0110: Expected O, but got I
		//IL_0121: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2992;
			object obj4 = (nint)0 + (nint)336;
			object obj5 = (nint)0 + (nint)1120;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			object obj6 = Enumerable.FirstOrDefault(_fullQueue, func);
			object obj7 = obj2 + 24;
			obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = obj7;
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v3+1C]");
				object obj9 = (nint)0 + (nint)1;
				if (obj9 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj10 = (nint)0 + (nint)344;
					Func<object, bool> func2 = default(Func<object, bool>);
					func2..ctor(obj2, (IntPtr)obj10);
					return Enumerable.Any(_fullQueue, func2);
				}
			}
			return false;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void ClearPlayersSelection()
	{
		List<QueuePlayer> list = selectedPlayers;
		int version = list._version + 1;
		list._size = 0;
		list._version = version;
		if (list._size >= 1)
		{
			Array.Clear(list._items, 0, list._size);
		}
		tournamentEventsChannel.TriggerPlayersSelected(selectedPlayers);
		UpdateTournamentQueue();
	}

	private static void SetView(GameObject[] objectToEnable, GameObject[][] objectToDisable)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I4
		//IL_0180: Expected O, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01a0: Expected O, but got I
		//IL_01b1: Expected O, but got I
		//IL_01c1: Expected O, but got I
		//IL_01e3: Expected O, but got I4
		//IL_00b1: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0126: Expected O, but got I
		//IL_0137: Expected I, but got O
		//IL_0155: Expected O, but got I
		//IL_0082: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3824;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj4 = (nint)0 + (nint)2016;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj6 = (nint)0 + (nint)1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6+18]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6+18]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v12+B8]");
				obj7 = 0;
			}
			object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 968;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)240;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj7, (IntPtr)obj12);
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v11+B8]");
			object obj14 = (nint)0 + (nint)24;
			obj14 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			action = action2;
		}
		ArraysExtensions.ForEach(objectToDisable, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)null, (IntPtr)obj6);
		ArraysExtensions.ForEach(objectToEnable, action3);
	}

	public TournamentQueueController()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 112;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
