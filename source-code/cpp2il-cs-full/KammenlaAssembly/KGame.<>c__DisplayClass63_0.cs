using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.Baloot.Tutorial;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Core;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.TextCore;

public abstract class KGame : MonoBehaviour
{
	public delegate void PlayerSwitchSeatDelegate(int userID, string error);

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<KPlayer, bool> <>9__43_0;

		public static Action <>9__178_0;

		public static Func<bool> <>9__215_1;

		public static Action <>9__215_2;

		public static Func<KPlayer, int> <>9__226_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_HumansCount>b__43_0(KPlayer p)
		{
			//IL_004f: Expected I4, but got O
			if (p != null)
			{
				bool flag = p.<User>k__BackingField == null;
				return !flag;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <OnLogin>b__178_0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0165: Expected O, but got I4
			//IL_035b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0360: Expected O, but got Unknown
			//IL_038a: Expected O, but got I4
			//IL_019d: Expected O, but got I4
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Expected O, but got Unknown
			//IL_01f7: Expected I, but got O
			//IL_0207: Expected O, but got I
			//IL_029d: Expected O, but got I
			//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b5: Expected O, but got Unknown
			//IL_0242: Expected O, but got I
			//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e1: Expected O, but got Unknown
			//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Expected O, but got Unknown
			//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Expected O, but got Unknown
			//IL_030c: Expected O, but got I
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0324: Expected O, but got Unknown
			//IL_033e: Expected O, but got I4
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Expected O, but got Unknown
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Expected O, but got Unknown
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8B79]");
			object obj3 = (nint)0 & (nint)1;
			object obj6;
			object obj4;
			if (obj3 != null)
			{
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v22+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v22+E4]");
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
			IL_034c:
			object obj8 = typeof(RegisteredWaitHandle) + 3136;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
			return;
			IL_0283:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v17+8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v238 @ X0_v17] (should have been resolved before IL gen)");
			object obj13 = default(object);
			object obj12 = obj13 & 1;
			if (obj12 != null)
			{
				return;
			}
			goto IL_034c;
			IL_0140:
			SessionModel sessionModel = default(SessionModel);
			Room currentRoom = sessionModel.CurrentRoom;
			bool flag4 = currentRoom == null;
			obj11 = 0;
			if (!flag4)
			{
				object obj14 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v11+E4]");
				bool flag5 = (nint)0 == 0;
				object obj15 = !flag5;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				Room currentRoom2 = sessionModel2.CurrentRoom;
				object obj16 = typeof(RegisteredWaitHandle) + 1376;
				nint num = (nint)currentRoom2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0283;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj18 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X10_v6-8]");
					if (0 == (nint)obj16)
					{
						break;
					}
					obj18 += 16;
					obj17--;
					if ((nint)obj17 != 1)
					{
						continue;
					}
					goto IL_0283;
				}
				object obj19 = obj18 + 6;
				object obj20 = num + obj19;
				object obj21 = obj20 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v16+8]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ X8_v16] (should have been resolved before IL gen)");
				object obj23 = default(object);
				object obj22 = obj23 & 1;
				bool flag6 = obj22 == null;
				object obj24 = !flag6;
				if (obj24 != null)
				{
					return;
				}
			}
			goto IL_034c;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag7 = (object)sessionModel == null;
			object obj25 = !flag7;
			if (obj25 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0140;
		}

		internal bool <ExitGame>b__215_1()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_010e: Expected O, but got I
			//IL_0138: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01a0: Expected I4, but got O
			//IL_00dc: Expected I4, but got O
			//IL_0181: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8B7A]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
			goto IL_018f;
			IL_01a5:
			bool result;
			return result;
			IL_00b8:
			Room currentRoom = sessionModel.CurrentRoom;
			bool flag4 = currentRoom == null;
			result = (byte)(int)currentRoom != 0;
			if (!flag4)
			{
				return SFSKammelnaRoomExtensions.IsTournamentHub(currentRoom);
			}
			goto IL_01a5;
			IL_018f:
			NullReferenceException ex = new NullReferenceException();
			result = (byte)(int)ex != 0;
			goto IL_01a5;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_018f;
		}

		internal void <ExitGame>b__215_2()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0061: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.Menu);
		}

		internal int <IsGameBalanced>b__226_0(KPlayer player)
		{
			//IL_008c: Expected I4, but got O
			if (player != null)
			{
				if (player.<User>k__BackingField == null)
				{
					return 1000;
				}
				PlayerRank rank = SFSKammelnaUserExtensions.GetRank(player.<User>k__BackingField);
				if (rank != null)
				{
					return rank.<Points>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass221_0
	{
		public int index;

		internal bool <GetPlayerByIndex>b__0(KPlayer p)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (p != null)
			{
				object obj = p.<Index>k__BackingField - index;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass222_0
	{
		public int sfsId;

		internal bool <GetPlayerBySFSId>b__0(KPlayer p)
		{
			//IL_011f: Expected I4, but got O
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0050: Expected I, but got O
			//IL_0060: Expected O, but got I
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			//IL_009b: Expected O, but got I
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected O, but got Unknown
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			if (p != null)
			{
				User <User>k__BackingField = p.<User>k__BackingField;
				if (p.<User>k__BackingField != null)
				{
					object obj = typeof(UsageHint) + 8;
					nint num = (nint)<User>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00dc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X10_v5-8]");
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
						goto IL_00dc;
					}
					object obj4 = num + obj3;
					object obj5 = obj4 + 312;
					goto IL_0160;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00dc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0160;
			IL_0160:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v179 @ X0_v4] (should have been resolved before IL gen)");
			object obj7 = default(object);
			object obj6 = obj7 - sfsId;
			return obj6 == null;
		}
	}

	private sealed class <>c__DisplayClass63_0
	{
		public int myUserDbId;

		internal bool <get_IsSpectator>b__0(User user)
		{
			//IL_0039: Expected O, but got I4
			if (user != null)
			{
				int intDbId = SFSKammelnaUserExtensions.GetIntDbId(user);
				object obj = intDbId - myUserDbId;
				bool flag = obj == null;
				return !flag;
			}
			return true;
		}
	}

	public const string UPDATE_GAME_STATE = "game_state";

	public const string CHEATING_UPDATE = "chup";

	public const string SAWA = "sawa";

	public const string KASHO = "kasho";

	public const string START_ROUND = "sr";

	public const string END_ROUND = "er";

	public const string END_GAME = "eg";

	public const string APPROVE_TEAMMATE = "approve";

	public const string SWITCH_SEAT = "switch_seat";

	public const string NOTIFY_GIFT = "notify_gift";

	public const string ANIM_GIFT = "ne";

	public const string EMOTE = "emt";

	public const string Restart = "restart";

	public const string GAME_LOADED = "game_loaded";

	public const string RESUME_GAME = "resume_game";

	public const string KICKED = "kicked";

	public const string GAME_CANCELLED = "gc";

	public const string LIVE_CATCH = "live_catch";

	public const string STATISTICS = "gst";

	public const string HIGHLIGHTS = "ghl";

	private const string APPROVE = "approve";

	private const string TEAMMATE_ID = "teammateId";

	public const string SEAT = "seat";

	protected const string ERROR = "error";

	public const string PLAYER_VOICE = "pv";

	public const string GAME_ACTION_PARAM = "gact";

	public const string SEATS_STATUSES = "ss";

	public const string MOVER = "mover";

	public const string WATCH_DOG_TIMER = "wdt";

	public const string LAST_ACTION_INFO = "last_action";

	public const string POSSIBLE_FORFEITERS = "fps";

	public const string Player = "player";

	public const string GAME_PHASE = "gp";

	public const string ALLOWED_IDLE_TIME = "ait";

	public const string UserId = "dbId";

	private Room _room;

	private bool <IsInitialized>k__BackingField;

	private int <MySeatIndex>k__BackingField;

	private int <Mover>k__BackingField;

	private float <WatchDogTimer>k__BackingField;

	private int <AllowedIdleTime>k__BackingField;

	private GamePhase <GamePhase>k__BackingField;

	private List<int> <ForfeitingPenalties>k__BackingField;

	private List<SeatStatus> <SeatStatuses>k__BackingField;

	private LastActionInfo <LastAction>k__BackingField;

	private readonly GameLobbyState <GameLobbyState>k__BackingField;

	private Action m__OnGameInitialized;

	private Action m__OnGameStateUpdated;

	private PlayerSwitchSeatDelegate m_OnPlayerSwitchSeat;

	private Action m_OnRoundStart;

	private Action m_OnRoundEnd;

	private Action<SawaInfo> m_OnSawa;

	private Action<KashoInfo> m_OnKasho;

	private Action<CheatingInfo> m_OnCheating;

	private Action<LiveCatchingInfo> m_OnLiveCatching;

	private Action<ISFSObject> m_OnGameEnd;

	private Action<VotingGameLobby> m_OnVotingGameLobbyUpdated;

	private Action<GiftNotification> m_OnGiftSent;

	private Action<AnimatedGiftNotification> m_OnAnimatedGiftSent;

	private Action<EmoteNotification> m_OnEmoteSent;

	private Action<ISFSObject> m_OnMatchMakerEvent;

	private Action<GameLobbyState> m_OnGameLobbyUpdate;

	private Action m_OnGameExiting;

	private Action m_OnBecomingWatcher;

	private Action m_OnBecomingPlayer;

	protected KPlayer[] players;

	private GameEventsChannel gameEventsChannel;

	private LeaveReason _kickReason;

	public bool IsInitialized
	{
		get
		{
			return <IsInitialized>k__BackingField;
		}
		set
		{
			<IsInitialized>k__BackingField = value;
		}
	}

	public Room Room
	{
		get
		{
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_0048: Expected O, but got I4
			//IL_0071: Expected O, but got I
			object obj = this + 32;
			if (obj != null)
			{
				return (Room)obj;
			}
			object obj2 = typeof(Queue<string>) + 848;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				Room currentRoom = sessionModel.CurrentRoom;
				obj = currentRoom;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return currentRoom;
			}
			return (Room)new NullReferenceException();
		}
	}

	public int HumansCount
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_00a5: Expected O, but got I
			//IL_00b5: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_00e7: Expected O, but got I4
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01aa: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_0289: Expected O, but got I
			//IL_029a: Expected I, but got O
			//IL_02b8: Expected O, but got I
			//IL_0244: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8B26]");
			object obj3 = (nint)0 & (nint)1;
			KPlayer[] array;
			KPlayer[] array2;
			object obj4;
			if (obj3 != null)
			{
				array = players;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				array2 = players;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				array = players;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				array2 = players;
				if (obj6 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj7 = (nint)0 + (nint)3568;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			IEnumerable<object> enumerable = array2;
			object obj10 = obj7;
			IEnumerable<object> source = array2;
			if (obj9 == null)
			{
				goto IL_01f2;
			}
			goto IL_0249;
			IL_01f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)3080;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj7;
			predicate = func;
			source = enumerable;
			goto IL_0249;
			IL_0249:
			return Enumerable.Count(source, predicate);
			IL_0099:
			obj10 = (nint)0 + (nint)3568;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			source = array;
			if (obj17 == null)
			{
				obj7 = obj10;
				enumerable = array;
				goto IL_01f2;
			}
			goto IL_0249;
		}
	}

	public List<KPlayer> Players => (List<KPlayer>)(object)Enumerable.ToList((IEnumerable<object>)players);

	public bool IsFastTrackGame
	{
		get
		{
			Room room = Room;
			GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
			return GameTypeExtensions.IsFastTrack(gameType);
		}
	}

	public bool IsTutorial
	{
		get
		{
			Room room = Room;
			TutorialType tutorialType = SFSKammelnaRoomExtensions.GetTutorialType(room);
			bool flag = tutorialType == TutorialType.None;
			return !flag;
		}
	}

	public bool IsReplay
	{
		get
		{
			Room room = Room;
			return SFSKammelnaRoomExtensions.GetIsReplay(room);
		}
	}

	public bool IsChallenge
	{
		get
		{
			//IL_002a: Expected O, but got I4
			Room room = Room;
			GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
			object obj = gameType - 4;
			return obj == null;
		}
	}

	public bool IsVoiceChatEnabled
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9460470");
			bool result = default(bool);
			return result;
		}
	}

	public bool IsVoiceChatEnabledForSpectators
	{
		get
		{
			Room room = Room;
			return SFSKammelnaRoomExtensions.IsVoiceChatEnabledForSpectators(room);
		}
	}

	public int MySeatIndex
	{
		get
		{
			return <MySeatIndex>k__BackingField;
		}
		protected set
		{
			<MySeatIndex>k__BackingField = value;
		}
	}

	public bool IsSpectator
	{
		get
		{
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Expected O, but got Unknown
			//IL_01e7: Expected O, but got I4
			//IL_0210: Expected O, but got I
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_040a: Expected I4, but got O
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_006f: Expected O, but got I4
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_0336: Expected O, but got Unknown
			//IL_0360: Expected O, but got I4
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_038c: Expected O, but got Unknown
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Expected O, but got Unknown
			//IL_0287: Expected I, but got O
			//IL_0297: Expected O, but got I
			//IL_04f6: Expected I4, but got O
			//IL_02d2: Expected O, but got I
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected O, but got Unknown
			//IL_010e: Expected I, but got O
			//IL_011e: Expected O, but got I
			//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dc: Expected O, but got Unknown
			//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e9: Expected O, but got Unknown
			//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f7: Expected O, but got Unknown
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Expected O, but got Unknown
			//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f3: Expected O, but got Unknown
			//IL_0477: Unknown result type (might be due to invalid IL or missing references)
			//IL_047c: Expected O, but got Unknown
			//IL_0492: Expected O, but got I
			//IL_04a3: Expected I, but got O
			//IL_0159: Expected O, but got I
			//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Expected O, but got Unknown
			//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b6: Expected O, but got Unknown
			//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c4: Expected O, but got Unknown
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected O, but got Unknown
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Expected O, but got Unknown
			Room room = Room;
			object obj2 = default(object);
			if (SFSKammelnaRoomExtensions.GetIsReplay(room))
			{
				object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1192;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj2..ctor();
				object obj3 = typeof(UsageHint) + 72;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v29+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string userDbId = UserInfo.UserDbId;
				int num = int.Parse(userDbId);
				if (obj2 != null)
				{
					Room room2 = _room;
					if (_room != null)
					{
						object obj6 = typeof(RegisteredWaitHandle) + 1376;
						nint num2 = (nint)room2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_019a;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
						object obj8 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X10_v11-8]");
							if (0 == (nint)obj6)
							{
								break;
							}
							obj8 += 16;
							obj7--;
							if ((nint)obj7 != 1)
							{
								continue;
							}
							goto IL_019a;
						}
						object obj9 = obj8 + 29;
						object obj10 = num2 + obj9;
						object obj11 = obj10 + 312;
						goto IL_045e;
					}
				}
			}
			else
			{
				object obj12 = typeof(Queue<string>) + 848;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj14 = !flag2;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj15 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				if ((object)sessionModel != null)
				{
					User localUser = sessionModel.LocalUser;
					if (localUser != null)
					{
						Room room3 = Room;
						object obj16 = typeof(UsageHint) + 8;
						nint num3 = (nint)localUser;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v16 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v16 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0313;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v16 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
						object obj18 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X10_v5-8]");
							if (0 == (nint)obj16)
							{
								break;
							}
							obj18 += 16;
							obj17--;
							if ((nint)obj17 != 1)
							{
								continue;
							}
							goto IL_0313;
						}
						object obj19 = obj18 + 5;
						object obj20 = num3 + obj19;
						object obj21 = obj20 + 312;
						goto IL_04de;
					}
					object obj22 = typeof(DataRelation) + 856;
					object obj23 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v12+E4]");
					bool flag3 = (nint)0 == 0;
					object obj24 = !flag3;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object message = "___# Content push apply failed [{0}]: {1}" + 448;
					Debug.LogWarning(message);
					return true;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_04de:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v343 @ X0_v19] (should have been resolved before IL gen)");
			object obj25 = default(object);
			return (byte)(obj25 >> 31) != 0;
			IL_0313:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_04de;
			IL_019a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_045e;
			IL_045e:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v353 @ X0_v34] (should have been resolved before IL gen)");
			object obj26 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj27 = (nint)0 + (nint)3104;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj27);
			IEnumerable<object> source = default(IEnumerable<object>);
			return Enumerable.All(source, func);
		}
	}

	public bool HasActivePlayers
	{
		get
		{
			//IL_0126: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0042: Expected I, but got O
			//IL_0052: Expected O, but got I
			//IL_0193: Expected I, but got O
			//IL_008d: Expected O, but got I
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected O, but got Unknown
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected O, but got Unknown
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected O, but got Unknown
			Room room = Room;
			object obj3;
			object obj8;
			if (room != null)
			{
				object obj = typeof(RegisteredWaitHandle) + 1376;
				object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 56;
				obj3 = (nint)0 + (nint)3256;
				nint num = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ce;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X10_v5-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj5 += 16;
					obj4--;
					if ((nint)obj4 != 1)
					{
						continue;
					}
					goto IL_00ce;
				}
				object obj6 = obj5 + 29;
				object obj7 = num + obj6;
				obj8 = obj7 + 312;
				goto IL_0171;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0171:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v179 @ X8_v6] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)this, (IntPtr)obj3);
			IEnumerable<object> source = default(IEnumerable<object>);
			return Enumerable.Any(source, func);
			IL_00ce:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj9 = default(object);
			obj8 = obj9;
			goto IL_0171;
		}
	}

	public bool IsRoomOwner
	{
		get
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_0048: Expected O, but got I
			//IL_009b: Expected O, but got I4
			//IL_0122: Expected I4, but got O
			Room room = Room;
			GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
			if (GameTypeExtensions.IsFastTrack(gameType))
			{
				return false;
			}
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			Room room2 = Room;
			int originalOwnerId = SFSKammelnaRoomExtensions.GetOriginalOwnerId(room2);
			int num = default(int);
			string text = num.ToString();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
				return text == dbId;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public KPlayer MyPlayer => GetPlayerByIndex(<MySeatIndex>k__BackingField);

	public int Mover
	{
		get
		{
			return <Mover>k__BackingField;
		}
		protected set
		{
			<Mover>k__BackingField = value;
		}
	}

	public float WatchDogTimer
	{
		get
		{
			return <WatchDogTimer>k__BackingField;
		}
		protected set
		{
			<WatchDogTimer>k__BackingField = value;
		}
	}

	public int AllowedIdleTime
	{
		get
		{
			return <AllowedIdleTime>k__BackingField;
		}
		set
		{
			<AllowedIdleTime>k__BackingField = value;
		}
	}

	public GamePhase GamePhase
	{
		get
		{
			return <GamePhase>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<int> ForfeitingPenalties
	{
		get
		{
			return <ForfeitingPenalties>k__BackingField;
		}
		protected set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<SeatStatus> SeatStatuses
	{
		get
		{
			return <SeatStatuses>k__BackingField;
		}
		protected set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public LastActionInfo LastAction
	{
		get
		{
			return <LastAction>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 88;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public GameLobbyState GameLobbyState => <GameLobbyState>k__BackingField;

	public abstract IGameScores GameScores { get; }

	private event Action _OnGameInitialized
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 104;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 104;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action OnGameInitialized
	{
		add
		{
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			if (<IsInitialized>k__BackingField)
			{
				Actions.SafeInvoke(value);
			}
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 104;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 104;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	private event Action _OnGameStateUpdated
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 112;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 112;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action OnGameStateUpdated
	{
		add
		{
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			if (<IsInitialized>k__BackingField)
			{
				Actions.SafeInvoke(value);
			}
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 112;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 112;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event PlayerSwitchSeatDelegate OnPlayerSwitchSeat
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
			object obj2 = this + 120;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
			object obj2 = this + 120;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action OnRoundStart
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 128;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 128;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action OnRoundEnd
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 136;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 136;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action<SawaInfo> OnSawa
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3368;
			object obj2 = this + 144;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3368;
			object obj2 = this + 144;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<KashoInfo> OnKasho
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2512;
			object obj2 = this + 152;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2512;
			object obj2 = this + 152;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<CheatingInfo> OnCheating
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1408;
			object obj2 = this + 160;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1408;
			object obj2 = this + 160;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<LiveCatchingInfo> OnLiveCatching
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2560;
			object obj2 = this + 168;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2560;
			object obj2 = this + 168;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<ISFSObject> OnGameEnd
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
			object obj2 = this + 176;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
			object obj2 = this + 176;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<VotingGameLobby> OnVotingGameLobbyUpdated
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 4024;
			object obj2 = this + 184;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 4024;
			object obj2 = this + 184;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<GiftNotification> OnGiftSent
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2136;
			object obj2 = this + 192;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2136;
			object obj2 = this + 192;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<AnimatedGiftNotification> OnAnimatedGiftSent
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1104;
			object obj2 = this + 200;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1104;
			object obj2 = this + 200;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<EmoteNotification> OnEmoteSent
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1896;
			object obj2 = this + 208;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1896;
			object obj2 = this + 208;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<ISFSObject> OnMatchMakerEvent
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
			object obj2 = this + 216;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
			object obj2 = this + 216;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<GameLobbyState> OnGameLobbyUpdate
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2088;
			object obj2 = this + 224;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2088;
			object obj2 = this + 224;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action OnGameExiting
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 232;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 232;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action OnBecomingWatcher
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 240;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 240;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action OnBecomingPlayer
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 248;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 248;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public abstract int[] GetScores();

	protected virtual void OnDestroy()
	{
		UnRegisterEvents();
		gameEventsChannel.ClearState();
	}

	private void RegisterEvents()
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_0115: Expected I, but got O
		//IL_009d: Expected I, but got O
		//IL_00c8: Expected I, but got O
		//IL_00ee: Expected I, but got O
		object obj = typeof(DataRelation) + 3728;
		object obj2 = (nint)0 + (nint)3272;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj4 = (nint)0 + (nint)3288;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
		object obj6 = (nint)0 + (nint)3280;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
		object obj8 = (nint)0 + (nint)3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj2);
		SFS.OnExtensionResponse += eventListenerDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		SFS.OnJoinRoom += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj6);
		SFS.OnLogin += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj8);
		SFS.OnUserLeaveRoom += action3;
	}

	private void UnRegisterEvents()
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_0115: Expected I, but got O
		//IL_009d: Expected I, but got O
		//IL_00c8: Expected I, but got O
		//IL_00ee: Expected I, but got O
		object obj = typeof(DataRelation) + 3728;
		object obj2 = (nint)0 + (nint)3272;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj4 = (nint)0 + (nint)3288;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
		object obj6 = (nint)0 + (nint)3280;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
		object obj8 = (nint)0 + (nint)3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj2);
		SFS.OnExtensionResponse -= eventListenerDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		SFS.OnJoinRoom -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj6);
		SFS.OnLogin -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj8);
		SFS.OnUserLeaveRoom -= action3;
	}

	private void OnExtensionResponse(BaseEvent evt)
	{
		//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4b: Expected O, but got Unknown
		//IL_0f81: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_0114: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_013c: Expected O, but got I4
		//IL_0307: Expected O, but got I4
		//IL_0319: Expected O, but got I8
		//IL_0333: Expected O, but got I4
		//IL_0559: Expected O, but got I4
		//IL_056b: Expected O, but got I8
		//IL_0585: Expected O, but got I4
		//IL_0171: Expected O, but got I4
		//IL_017f: Expected O, but got I4
		//IL_0199: Expected O, but got I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_036c: Expected O, but got I4
		//IL_038a: Expected O, but got I4
		//IL_0454: Expected O, but got I4
		//IL_0462: Expected O, but got I4
		//IL_047c: Expected O, but got I4
		//IL_0e3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e40: Expected O, but got Unknown
		//IL_01ce: Expected O, but got I4
		//IL_01dc: Expected O, but got I4
		//IL_01f6: Expected O, but got I4
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Expected O, but got Unknown
		//IL_0dd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd9: Expected O, but got Unknown
		//IL_0e73: Expected I, but got O
		//IL_0e83: Expected O, but got I
		//IL_0e93: Expected O, but got I
		//IL_0d6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d72: Expected O, but got Unknown
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Expected O, but got Unknown
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Expected O, but got Unknown
		//IL_0b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b44: Expected O, but got Unknown
		//IL_0b10: Expected I, but got O
		//IL_0b20: Expected O, but got I
		//IL_0b30: Expected O, but got I
		//IL_0bcf: Expected I, but got O
		//IL_0bdf: Expected O, but got I
		//IL_0e0c: Expected I, but got O
		//IL_0e1c: Expected O, but got I
		//IL_0e2c: Expected O, but got I
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0b: Expected O, but got Unknown
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected O, but got Unknown
		//IL_0da5: Expected I, but got O
		//IL_0db5: Expected O, but got I
		//IL_0dc5: Expected O, but got I
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected O, but got Unknown
		//IL_0a38: Expected I, but got O
		//IL_0a48: Expected O, but got I
		//IL_0a58: Expected O, but got I
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa9: Expected O, but got Unknown
		//IL_0ab5: Expected O, but got I
		//IL_0b77: Expected I, but got O
		//IL_0b87: Expected O, but got I
		//IL_0b97: Expected O, but got I
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected O, but got Unknown
		//IL_0eb4: Expected O, but got I4
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_0d3e: Expected I, but got O
		//IL_0d4e: Expected O, but got I
		//IL_0d5e: Expected O, but got I
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected O, but got Unknown
		//IL_0627: Expected I, but got O
		//IL_0637: Expected O, but got I
		//IL_0647: Expected O, but got I
		//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c25: Expected O, but got Unknown
		//IL_0c2e: Expected O, but got I4
		//IL_0777: Expected I, but got O
		//IL_0787: Expected O, but got I
		//IL_0797: Expected O, but got I
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0918: Expected I, but got O
		//IL_0928: Expected O, but got I
		//IL_0938: Expected O, but got I
		//IL_0c86: Expected O, but got I
		//IL_0415: Expected I, but got O
		//IL_0425: Expected O, but got I
		//IL_0435: Expected O, but got I
		//IL_0516: Expected I, but got O
		//IL_0526: Expected O, but got I
		//IL_0536: Expected O, but got I
		//IL_06cb: Expected I, but got O
		//IL_06db: Expected O, but got I
		//IL_06eb: Expected O, but got I
		//IL_09cc: Expected O, but got I
		//IL_09dc: Expected O, but got I
		//IL_09ec: Expected O, but got I
		//IL_0c9c: Expected O, but got I
		//IL_0ca8: Expected I, but got O
		//IL_0cb8: Expected O, but got I
		//IL_0ccd: Expected O, but got I
		//IL_0838: Expected I, but got O
		//IL_0848: Expected O, but got I
		//IL_0858: Expected O, but got I
		//IL_0c3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c42: Expected O, but got Unknown
		//IL_0c55: Expected O, but got I
		//IL_0cf7: Expected O, but got I
		//IL_02c4: Expected O, but got I
		//IL_02d4: Expected O, but got I
		//IL_02e4: Expected O, but got I
		object obj = "fetch_products" + 2456;
		ISFSObject responseParams = SFSExtensions.GetResponseParams(evt);
		string command = SFSExtensions.GetCommand(evt);
		bool flag = !<IsInitialized>k__BackingField;
		object obj2 = !flag;
		if (obj2 == null && command != (string)obj)
		{
			object obj3 = "setMimeType" + 3704;
			bool flag2 = command != (string)obj3;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 != null)
			{
				return;
			}
		}
		bool isSpectator = IsSpectator;
		bool flag4 = !isSpectator;
		object obj5 = !flag4;
		if (obj5 == null && <MySeatIndex>k__BackingField <= 0 && !TrySeatPlayer())
		{
			return;
		}
		uint num = global::<PrivateImplementationDetails>.ComputeStringHash(command);
		bool flag5 = (int)num < 1479958588;
		object obj6 = !flag5;
		object obj7 = num - 1479958588;
		bool flag6 = obj7 == null;
		object obj8 = !flag6;
		object obj9 = obj6 & obj8;
		if (obj9 == null)
		{
			bool flag7 = (int)num < 1042313471;
			object obj10 = !flag7;
			object obj11 = num - 1042313471;
			bool flag8 = obj11 == null;
			object obj12 = !flag8;
			object obj13 = obj10 & obj12;
			if (obj13 == null)
			{
				bool flag9 = (int)num < 875406394;
				object obj14 = !flag9;
				object obj15 = num - 875406394;
				bool flag10 = obj15 == null;
				object obj16 = !flag10;
				object obj17 = obj14 & obj16;
				if (obj17 == null)
				{
					if (num == 475664083)
					{
						object obj18 = "java.io.FileOutputStream" + 2960;
						if (command == (string)obj18)
						{
							<GameLobbyState>k__BackingField.Update(responseParams);
							Action<GameLobbyState> onGameLobbyUpdate = this.OnGameLobbyUpdate;
							if (this.OnGameLobbyUpdate != null)
							{
								GameLobbyState gameLobbyState = <GameLobbyState>k__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v120 (System.Action`1<GameLobbyState>)+18]");
								object obj19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v120 (System.Action`1<GameLobbyState>)+40]");
								object obj20 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v120 (System.Action`1<GameLobbyState>)+28]");
								object obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v545 @ X3_v19 (should have been resolved before IL gen)");
								goto IL_09f6;
							}
							return;
						}
						return;
					}
					if (num != 875406394)
					{
						return;
					}
					object obj22 = "m_StencilDeferredPS" + 2136;
					if (!(command == (string)obj22))
					{
						return;
					}
					Action<ISFSObject> onMatchMakerEvent = this.OnMatchMakerEvent;
					if (this.OnMatchMakerEvent == null)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v125 (System.Action`1<Sfs2X.Entities.Data.ISFSObject>)+18]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v125 (System.Action`1<Sfs2X.Entities.Data.ISFSObject>)+40]");
					KGame kGame = (KGame)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v125 (System.Action`1<Sfs2X.Entities.Data.ISFSObject>)+28]");
					object obj24 = 0;
				}
				else
				{
					switch (num)
					{
					case 1042313471u:
					{
						object obj26 = "fetch_products" + 2488;
						if (command == (string)obj26)
						{
							nint num3 = (nint)this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v115 (Il2CppClass<KGame>)+298]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v115 (Il2CppClass<KGame>)+2A0]");
							object obj24 = 0;
							break;
						}
						return;
					}
					case 974805637u:
					{
						object obj25 = "destinationTimeZone" + 1656;
						if (command == (string)obj25)
						{
							nint num2 = (nint)this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v110 (Il2CppClass<KGame>)+208]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v110 (Il2CppClass<KGame>)+210]");
							object obj24 = 0;
							break;
						}
						return;
					}
					default:
						return;
					}
				}
			}
			else
			{
				bool flag11 = (int)num < 1159359446;
				object obj27 = !flag11;
				object obj28 = num - 1159359446;
				bool flag12 = obj28 == null;
				object obj29 = !flag12;
				object obj30 = obj27 & obj29;
				if (obj30 == null)
				{
					switch (num)
					{
					case 1159359446u:
						break;
					case 1103147486u:
					{
						object obj31 = "java.io.FileOutputStream" + 744;
						if (command == (string)obj31)
						{
							object obj32 = "placementId" + 2520;
							object obj33 = (nint)0 + (nint)120;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
							LeaveReason kickReason = default(LeaveReason);
							_kickReason = kickReason;
						}
						return;
					}
					default:
						return;
					}
					object obj34 = "destinationTimeZone" + 2656;
					if (!(command == (string)obj34))
					{
						return;
					}
					nint num4 = (nint)this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ X8_v103 (Il2CppClass<KGame>)+1F8]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ X8_v103 (Il2CppClass<KGame>)+200]");
					object obj24 = 0;
				}
				else
				{
					switch (num)
					{
					case 1479958588u:
					{
						object obj36 = "m_StencilDeferredPS" + 3152;
						if (command == (string)obj36)
						{
							nint num6 = (nint)this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v90 (Il2CppClass<KGame>)+268]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v90 (Il2CppClass<KGame>)+270]");
							object obj24 = 0;
							break;
						}
						return;
					}
					case 1265573399u:
					{
						object obj37 = "java.io.FileOutputStream" + 2856;
						if (command == (string)obj37)
						{
							nint num7 = (nint)this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X8_v85 (Il2CppClass<KGame>)+228]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X8_v85 (Il2CppClass<KGame>)+230]");
							object obj24 = 0;
							break;
						}
						return;
					}
					case 1163008208u:
					{
						object obj35 = "setMimeType" + 3704;
						if (command == (string)obj35)
						{
							nint num5 = (nint)this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v80 (Il2CppClass<KGame>)+1E8]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v80 (Il2CppClass<KGame>)+1F0]");
							object obj24 = 0;
							break;
						}
						return;
					}
					default:
						return;
					}
				}
			}
		}
		else
		{
			bool flag13 = (int)num < 2787029455L;
			object obj38 = !flag13;
			object obj39 = (int)num - 2787029455L;
			bool flag14 = obj39 == null;
			object obj40 = !flag14;
			object obj41 = obj38 & obj40;
			if (obj41 == null)
			{
				bool flag15 = (int)num < 2389307203L;
				object obj42 = !flag15;
				bool flag16 = (int)num == 2389307203L;
				object obj43 = !flag16;
				object obj44 = obj42 & obj43;
				if (obj44 == null)
				{
					if (flag16)
					{
						goto IL_09f6;
					}
					if (num != 1821026105)
					{
						return;
					}
					object obj45 = "destinationTimeZone" + 1976;
					if (!(command == (string)obj45))
					{
						return;
					}
					nint num8 = (nint)this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X8_v71 (Il2CppClass<KGame>)+278]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X8_v71 (Il2CppClass<KGame>)+280]");
					object obj24 = 0;
				}
				else
				{
					if ((int)num == 2675519245L)
					{
						if (!(command == (string)obj))
						{
							return;
						}
						nint num9 = (nint)this;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v45 (Il2CppClass<KGame>)+1D0]");
						object obj46 = 0;
						UpdateGameState(responseParams);
						KPlayer[] array = players;
						if (array.Length >= 1)
						{
							object obj47 = array + 32;
							object obj48 = 0;
							do
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X25_v7+v790 @ X24_v8*8]");
								KPlayer kPlayer = (KPlayer)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X25_v7+v790 @ X24_v8*8]");
								bool flag17 = ((KPlayer)0).UpdateUser();
								nint num10 = (nint)kPlayer;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X8_v54 (Il2CppClass<KPlayer>)+190]");
								obj46 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X25_v7+v790 @ X24_v8*8]");
								((KPlayer)0).UpdatePlayerState(responseParams);
								if (flag17)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X25_v7+v790 @ X24_v8*8]");
									((KPlayer)0).UserChanged();
								}
								obj48++;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X25_v7+v790 @ X24_v8*8]");
								((KPlayer)0).FireEvents();
							}
							while ((nint)obj48 < array.Length);
						}
						bool flag18 = !<IsInitialized>k__BackingField;
						object obj49 = !flag18;
						if (obj49 == null)
						{
							<IsInitialized>k__BackingField = true;
							SplashAnimation.StopLoading();
							Action onGameInitialized = this._OnGameInitialized;
							if (this._OnGameInitialized != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v912.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
							}
						}
						goto IL_0f9a;
					}
					if ((int)num != 2787029455L)
					{
						return;
					}
					object obj50 = "startPosition" + 1552;
					if (!(command == (string)obj50))
					{
						return;
					}
					nint num11 = (nint)this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v63 (Il2CppClass<KGame>)+1B8]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v63 (Il2CppClass<KGame>)+1C0]");
					object obj24 = 0;
				}
			}
			else
			{
				bool flag19 = (int)num < 2962243947L;
				object obj51 = !flag19;
				object obj52 = (int)num - 2962243947L;
				bool flag20 = obj52 == null;
				object obj53 = !flag20;
				object obj54 = obj51 & obj53;
				if (obj54 == null)
				{
					if ((int)num != 2902265169L)
					{
						if ((int)num != 2962243947L)
						{
							return;
						}
						object obj55 = "not" + 208;
						if (!(command == (string)obj55))
						{
							return;
						}
						nint num12 = (nint)this;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v40 (Il2CppClass<KGame>)+258]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v40 (Il2CppClass<KGame>)+260]");
						object obj24 = 0;
					}
					else
					{
						object obj56 = "rightCtrl" + 1032;
						if (!(command == (string)obj56))
						{
							return;
						}
						nint num13 = (nint)this;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v35 (Il2CppClass<KGame>)+238]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v35 (Il2CppClass<KGame>)+240]");
						object obj24 = 0;
					}
				}
				else
				{
					object obj57 = typeof(DigitalContDownFormat) | 0xBC180000L;
					if ((int)num != (nint)obj57)
					{
						if ((int)num != 4165267615L)
						{
							if ((int)num != 4271641068L)
							{
								return;
							}
							object obj58 = "placementId" + 3704;
							if (!(command == (string)obj58))
							{
								return;
							}
							nint num14 = (nint)this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v30 (Il2CppClass<KGame>)+288]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v30 (Il2CppClass<KGame>)+290]");
							object obj24 = 0;
						}
						else
						{
							object obj59 = "java.io.FileOutputStream" + 552;
							if (!(command == (string)obj59))
							{
								return;
							}
							nint num15 = (nint)this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v25 (Il2CppClass<KGame>)+248]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v25 (Il2CppClass<KGame>)+250]");
							object obj24 = 0;
						}
					}
					else
					{
						object obj60 = "___# Content push apply failed [{0}]: {1}" + 2664;
						if (!(command == (string)obj60))
						{
							return;
						}
						nint num16 = (nint)this;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v20 (Il2CppClass<KGame>)+1A8]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v20 (Il2CppClass<KGame>)+1B0]");
						object obj24 = 0;
					}
				}
			}
		}
		goto IL_0f90;
		IL_0f90:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v546 @ X3_v3 (should have been resolved before IL gen)");
		goto IL_0f9a;
		IL_09f6:
		object obj61 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3280;
		if (command == (string)obj61)
		{
			nint num17 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v66 (Il2CppClass<KGame>)+218]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v66 (Il2CppClass<KGame>)+220]");
			object obj24 = 0;
			goto IL_0f90;
		}
		return;
		IL_0f9a:
		Action onGameStateUpdated = this._OnGameStateUpdated;
		if (this._OnGameStateUpdated != null)
		{
			IntPtr invoke_impl = ((Delegate)onGameStateUpdated).invoke_impl;
			IntPtr method_code = ((Delegate)onGameStateUpdated).method_code;
			IntPtr method = ((Delegate)onGameStateUpdated).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v578 @ X2_v19 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	protected virtual void OnPlayCard(ISFSObject response)
	{
	}

	private void OnUserLeaveRoom(User user)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_013d: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 8;
		nint num = (nint)user;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X10_v7-8]");
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
		object obj4 = obj3 + 19;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v210 @ X0_v11] (should have been resolved before IL gen)");
		object obj7 = default(object);
		bool flag = obj7 == null;
		object obj8 = !flag;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00de;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v125 @ X0_v8] (should have been resolved before IL gen)");
		object obj9 = default(object);
		if (obj9 != null)
		{
			goto IL_00de;
		}
		return;
		IL_00de:
		gameEventsChannel.TriggerLeaveRoom(_kickReason);
	}

	public void OnRoomJoined(Room joinedRoom)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00eb: Expected O, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0198: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0133: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if (joinedRoom == null)
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)joinedRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X10_v6-8]");
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
		object obj4 = obj3 + 6;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v13+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ X0_v13] (should have been resolved before IL gen)");
		object obj8 = default(object);
		if (obj8 == null)
		{
			return;
		}
		goto IL_015a;
		IL_015a:
		object obj9 = typeof(RegisteredWaitHandle) + 3136;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
		return;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v10+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ X0_v10] (should have been resolved before IL gen)");
		object obj12 = default(object);
		bool flag2 = obj12 == null;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			return;
		}
		goto IL_015a;
	}

	private void OnLogin(BaseEvent _)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_016a: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01b6: Expected O, but got I
		//IL_01c6: Expected O, but got I
		//IL_01e8: Expected O, but got I4
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02de: Expected O, but got I
		//IL_02e6: Expected I, but got O
		//IL_02f7: Expected I, but got O
		//IL_0315: Expected O, but got I
		//IL_027f: Expected O, but got I4
		//IL_0250: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8B53]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			int num2 = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
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
		object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+10]");
		Action action = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+10]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00e6;
		}
		goto IL_01fe;
		IL_00e6:
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		IntPtr intPtr = default(IntPtr);
		nint num = intPtr;
		Action action2 = action;
		if (!flag4)
		{
			goto IL_0123;
		}
		goto IL_029d;
		IL_029d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action = action2;
		goto IL_0123;
		IL_0123:
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
		return;
		IL_0085:
		obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+10]");
		action = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+10]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		if (!flag5)
		{
			goto IL_00e6;
		}
		goto IL_01fe;
		IL_01fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj14 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)3072;
		num = (nint)obj15;
		Action action3 = default(Action);
		action3..ctor(obj8, (IntPtr)obj15);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v9+B8]");
		object obj17 = (nint)0 + (nint)16;
		obj17 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		action = action3;
		action2 = action3;
		if (obj18 != null)
		{
			goto IL_0123;
		}
		goto IL_029d;
	}

	protected virtual void OnSeatSwitched(ISFSObject response)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0210: Expected O, but got I
		//IL_0250: Expected O, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00fc: Expected O, but got I4
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_0147: Expected O, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0178: Expected O, but got I
		object varName = "com.unity.services.authentication.profile" + 3280;
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		int num = SFSExtensions.Get(response, (string)varName, 0);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		if (num == intDbId)
		{
			object varName2 = "rightCtrl" + 1552;
			SeatPlayer(<MySeatIndex>k__BackingField = SFSExtensions.Get(response, (string)varName2, 0));
		}
		KPlayer[] array = players;
		if (array.Length >= 1)
		{
			object obj5 = array + 32;
			object obj6 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X25_v5+v90 @ X24_v6*8]");
				if (((KPlayer)0).UpdateUser())
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X25_v5+v90 @ X24_v6*8]");
					((KPlayer)0).UserChanged();
				}
				obj6++;
			}
			while ((nint)obj6 < array.Length);
		}
		gameEventsChannel.TriggerOnSeatSwitch();
		PlayerSwitchSeatDelegate onPlayerSwitchSeat = this.OnPlayerSwitchSeat;
		if (this.OnPlayerSwitchSeat != null)
		{
			object varName3 = "destinationTimeZone" + 2696;
			string text = SFSExtensions.Get(response, (string)varName3, (string)null);
			IntPtr invoke_impl = ((Delegate)onPlayerSwitchSeat).invoke_impl;
			IntPtr method_code = ((Delegate)onPlayerSwitchSeat).method_code;
			IntPtr method = ((Delegate)onPlayerSwitchSeat).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v178 @ X4_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	protected virtual void UpdateGameState(ISFSObject gameState)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_03a3: Expected I4, but got I8
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00bd: Expected I, but got O
		//IL_00cd: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_018d: Expected O, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01ec: Expected O, but got I
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_0211: Expected I, but got O
		//IL_0221: Expected O, but got I
		//IL_0108: Expected O, but got I
		//IL_0403: Expected I, but got O
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_043e: Expected O, but got I
		//IL_025c: Expected O, but got I
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_02e5: Expected O, but got I
		//IL_0309: Expected O, but got I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_0328: Expected O, but got I
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		object obj = "setMimeType" + 3784;
		object obj2 = (nint)0 + (nint)280;
		object varName = "m_StencilDeferredPS" + 2456;
		object varName2 = "utf-32" + 1200;
		object varName3 = "___# Content push apply failed [{0}]: {1}" + 3992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301EE38");
		object obj3 = this + 80;
		object obj4 = default(object);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = SFSExtensions.Get(gameState, (string)varName, -1);
		float num2 = SFSExtensions.Get(gameState, (string)varName2, 0f);
		int num3 = SFSExtensions.Get(gameState, (string)varName3, 0);
		object obj5 = typeof(System.IOAsyncCallback) + 976;
		object obj6 = "fetch_products" + 1168;
		nint num4 = (nint)gameState;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0149;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X10_v13-8]");
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
			goto IL_0149;
		}
		object obj9 = obj8 + 28;
		object obj10 = num4 + obj9;
		object obj11 = obj10 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v35+8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v297 @ X0_v35] (should have been resolved before IL gen)");
		ISFSArray iSFSArray = default(ISFSArray);
		bool flag = iSFSArray == null;
		object obj13 = !flag;
		if (obj13 != null)
		{
			goto IL_01a0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v35+8]");
		object obj14 = 0;
		List<int> list = null;
		goto IL_01c2;
		IL_0149:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v32+8]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ X0_v32] (should have been resolved before IL gen)");
		bool flag2 = iSFSArray == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v32+8]");
		obj14 = 0;
		list = null;
		if (!flag2)
		{
			goto IL_01a0;
		}
		goto IL_01c2;
		IL_01a0:
		List<int> list2 = SFSExtensions.ToIntList(iSFSArray);
		obj14 = obj12;
		list = list2;
		goto IL_01c2;
		IL_01c2:
		object obj15 = "java.io.FileOutputStream" + 1184;
		object obj16 = "getSecondRescanTask" + 1808;
		object obj17 = (nint)0 + (nint)248;
		object obj18 = this + 72;
		obj18 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num5 = (nint)gameState;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_029d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X10_v7-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj20 += 16;
			obj19--;
			if ((nint)obj19 != 1)
			{
				continue;
			}
			goto IL_029d;
		}
		object obj21 = obj20 + 29;
		object obj22 = num5 + obj21;
		object obj23 = obj22 + 312;
		goto IL_03f4;
		IL_03f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v394 @ X0_v17] (should have been resolved before IL gen)");
		nint num6 = (nint)this;
		ISFSObject lastActionParams = default(ISFSObject);
		LastActionInfo lastActionInfo = ParseLastActionInfo(lastActionParams);
		object obj24 = this + 88;
		obj24 = lastActionInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X20_v3-18]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		return;
		IL_029d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_03f4;
	}

	protected virtual LastActionInfo ParseLastActionInfo(ISFSObject lastActionParams)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CardGameLastActionInfo cardGameLastActionInfo = default(CardGameLastActionInfo);
		cardGameLastActionInfo..ctor(lastActionParams);
		return cardGameLastActionInfo;
	}

	protected virtual void StartRound(ISFSObject data)
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0065: Expected O, but got I4
		//IL_00bc: Expected O, but got I
		//IL_00d2: Expected O, but got I
		//IL_00de: Expected I, but got O
		//IL_00ee: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_008b: Expected O, but got I
		//IL_012d: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X8_v1 (Il2CppClass<KGame>)+1D0]");
		object obj = 0;
		UpdateGameState(data);
		KPlayer[] array = players;
		if (array.Length >= 1)
		{
			object obj2 = array + 32;
			object obj3 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X25_v5+v66 @ X24_v6*8]");
				KPlayer kPlayer = (KPlayer)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X25_v5+v66 @ X24_v6*8]");
				bool flag = ((KPlayer)0).UpdateUser();
				nint num2 = (nint)kPlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v8 (Il2CppClass<KPlayer>)+190]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X25_v5+v66 @ X24_v6*8]");
				((KPlayer)0).UpdatePlayerState(data);
				if (flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X25_v5+v66 @ X24_v6*8]");
					((KPlayer)0).UserChanged();
				}
				obj3++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X25_v5+v66 @ X24_v6*8]");
				((KPlayer)0).FireEvents();
			}
			while ((nint)obj3 < array.Length);
		}
		Action onRoundStart = this.OnRoundStart;
		if (this.OnRoundStart != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v142.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		Action onGameStateUpdated = this._OnGameStateUpdated;
		if (this._OnGameStateUpdated != null)
		{
			IntPtr invoke_impl = ((Delegate)onGameStateUpdated).invoke_impl;
			IntPtr method_code = ((Delegate)onGameStateUpdated).method_code;
			IntPtr method = ((Delegate)onGameStateUpdated).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v191 @ X2_v4 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	protected virtual void EndRound(ISFSObject data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0166: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		IGameScores gameScores = GameScores;
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2792;
		nint num = (nint)gameScores;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Il2CppClass<IGameScores>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Il2CppClass<IGameScores>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Il2CppClass<IGameScores>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X10_v6-8]");
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
		goto IL_011b;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ X0_v8] (should have been resolved before IL gen)");
		Action onRoundEnd = this.OnRoundEnd;
		if (this.OnRoundEnd != null)
		{
			goto IL_00ea;
		}
		return;
		IL_00ea:
		IntPtr invoke_impl = ((Delegate)onRoundEnd).invoke_impl;
		IntPtr method_code = ((Delegate)onRoundEnd).method_code;
		IntPtr method = ((Delegate)onRoundEnd).method;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v135 @ X2_v3 (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_011b;
		IL_011b:
		object obj4 = num + obj3;
		object obj5 = obj4 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v197 @ X8_v12] (should have been resolved before IL gen)");
		onRoundEnd = this.OnRoundEnd;
		bool flag = this.OnRoundEnd == null;
		object obj6 = !flag;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00ea;
	}

	protected virtual void EndGame(ISFSObject data)
	{
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		//IL_0059: Expected O, but got I
		Action<ISFSObject> onGameEnd = this.OnGameEnd;
		if (this.OnGameEnd != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<Sfs2X.Entities.Data.ISFSObject>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<Sfs2X.Entities.Data.ISFSObject>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<Sfs2X.Entities.Data.ISFSObject>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	protected virtual void OnCheatingCommand(ISFSObject data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0046: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_0066: Expected O, but got I
		Action<CheatingInfo> onCheating = this.OnCheating;
		if (this.OnCheating != null)
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 920;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			CheatingInfo cheatingInfo = default(CheatingInfo);
			cheatingInfo..ctor(data, this);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X22_v1 (System.Action`1<CheatingInfo>)+18]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X22_v1 (System.Action`1<CheatingInfo>)+40]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X22_v1 (System.Action`1<CheatingInfo>)+28]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v63 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	protected virtual void OnLiveCatchingCommand(ISFSObject data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0046: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_0066: Expected O, but got I
		Action<LiveCatchingInfo> onLiveCatching = this.OnLiveCatching;
		if (this.OnLiveCatching != null)
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			LiveCatchingInfo liveCatchingInfo = default(LiveCatchingInfo);
			liveCatchingInfo..ctor(data, this);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X22_v1 (System.Action`1<LiveCatchingInfo>)+18]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X22_v1 (System.Action`1<LiveCatchingInfo>)+40]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X22_v1 (System.Action`1<LiveCatchingInfo>)+28]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v64 @ X3_v2 (should have been resolved before IL gen)");
		}
	}

	protected virtual void OnSawaCommand(ISFSObject data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_0071: Expected O, but got I
		//IL_0081: Expected O, but got I
		Action<SawaInfo> onSawa = this.OnSawa;
		if (this.OnSawa != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 2808;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 16;
			obj3 = data;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X21_v2 (System.Action`1<SawaInfo>)+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X21_v2 (System.Action`1<SawaInfo>)+40]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X21_v2 (System.Action`1<SawaInfo>)+28]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v64 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	protected virtual void OnKashoCommand(ISFSObject data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_0071: Expected O, but got I
		//IL_0081: Expected O, but got I
		Action<KashoInfo> onKasho = this.OnKasho;
		if (this.OnKasho != null)
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 16;
			obj3 = data;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X21_v2 (System.Action`1<KashoInfo>)+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X21_v2 (System.Action`1<KashoInfo>)+40]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X21_v2 (System.Action`1<KashoInfo>)+28]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v64 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	protected virtual void NotifyGift(ISFSObject response)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0063: Expected O, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00bd: Expected I, but got O
		//IL_00cd: Expected O, but got I
		//IL_0108: Expected O, but got I
		//IL_0205: Expected O, but got I
		//IL_0215: Expected O, but got I
		//IL_0225: Expected O, but got I
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftNotification giftNotification = default(GiftNotification);
		giftNotification..ctor(response);
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		object obj6 = typeof(UsageHint) + 8;
		nint num = (nint)localUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v9 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v9 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0149;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v9 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X10_v6-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj8 += 16;
			obj7--;
			if ((nint)obj7 != 1)
			{
				continue;
			}
			goto IL_0149;
		}
		object obj9 = num + obj8;
		object obj10 = obj9 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v241 @ X8_v15] (should have been resolved before IL gen)");
		object obj11 = default(object);
		if (giftNotification.<SenderId>k__BackingField != (long)obj11)
		{
			goto IL_01cc;
		}
		return;
		IL_01cc:
		Action<GiftNotification> onGiftSent = this.OnGiftSent;
		if (this.OnGiftSent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v12 (System.Action`1<GiftNotification>)+18]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v12 (System.Action`1<GiftNotification>)+40]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v12 (System.Action`1<GiftNotification>)+28]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v92 @ X3_v1 (should have been resolved before IL gen)");
		}
		return;
		IL_0149:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v201 @ X0_v14] (should have been resolved before IL gen)");
		object obj15 = default(object);
		if (giftNotification.<SenderId>k__BackingField == (long)obj15)
		{
			return;
		}
		goto IL_01cc;
	}

	protected virtual void NotifyAnimatedGift(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0063: Expected O, but got I4
		//IL_0108: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_0128: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 3816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AnimatedGiftNotification animatedGiftNotification = default(AnimatedGiftNotification);
		animatedGiftNotification..ctor(data);
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		if (animatedGiftNotification.<SenderId>k__BackingField != intDbId)
		{
			Action<AnimatedGiftNotification> onAnimatedGiftSent = this.OnAnimatedGiftSent;
			if (this.OnAnimatedGiftSent != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v8 (System.Action`1<AnimatedGiftNotification>)+18]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v8 (System.Action`1<AnimatedGiftNotification>)+40]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v8 (System.Action`1<AnimatedGiftNotification>)+28]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v81 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	protected virtual void NotifyEmote(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0038: Expected O, but got I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0084: Expected O, but got I4
		//IL_0135: Expected O, but got I
		//IL_0145: Expected O, but got I
		//IL_0155: Expected O, but got I
		//IL_00ad: Expected O, but got I
		object obj = typeof(DataRelation) + 3016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EmoteNotification emoteNotification = default(EmoteNotification);
		emoteNotification..ctor(data);
		bool flag = !emoteNotification.<IsFromServer>k__BackingField;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = typeof(Queue<string>) + 848;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			if (emoteNotification.<SenderId>k__BackingField == intDbId)
			{
				return;
			}
		}
		Action<EmoteNotification> onEmoteSent = this.OnEmoteSent;
		if (this.OnEmoteSent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v7 (System.Action`1<EmoteNotification>)+18]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v7 (System.Action`1<EmoteNotification>)+40]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v7 (System.Action`1<EmoteNotification>)+28]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v113 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	protected virtual void OnNextMatchLobbyUpdated(ISFSObject data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0055: Expected O, but got I
		//IL_0065: Expected O, but got I
		Action<VotingGameLobby> onVotingGameLobbyUpdated = this.OnVotingGameLobbyUpdated;
		if (this.OnVotingGameLobbyUpdated != null)
		{
			object obj = typeof(UsageHint) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			VotingGameLobby votingGameLobby = default(VotingGameLobby);
			votingGameLobby..ctor(data);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X21_v2 (System.Action`1<VotingGameLobby>)+18]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X21_v2 (System.Action`1<VotingGameLobby>)+40]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X21_v2 (System.Action`1<VotingGameLobby>)+28]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v64 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	protected virtual void OnGameCancelled(ISFSObject data)
	{
	}

	private void OnMatchMakerEventReceived(ISFSObject data)
	{
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		//IL_0059: Expected O, but got I
		Action<ISFSObject> onMatchMakerEvent = this.OnMatchMakerEvent;
		if (this.OnMatchMakerEvent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<Sfs2X.Entities.Data.ISFSObject>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<Sfs2X.Entities.Data.ISFSObject>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<Sfs2X.Entities.Data.ISFSObject>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	public static void SendApproveTeammate(bool approve, int teammateSFSId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object obj2 = "alignContent" + 2328;
		object key = "startPosition" + 2464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)obj2, approve);
		SFSExtensions.Put(sFSObject, (string)key, teammateSFSId);
		SFS.SendRoomExtensionRequest((string)obj2, sFSObject);
	}

	public void SendSwitchRequest(int seatIndex)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "rightCtrl" + 1552;
		object command = "startPosition" + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, seatIndex);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	public void SendGameLoaded()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		GameSoundManager instance = GameSoundManager.Instance;
		object key = "placementId" + 1792;
		object command = "fetch_products" + 2432;
		int myVoiceId = instance.GetMyVoiceId();
		SFSExtensions.Put(sFSObject, (string)key, myVoiceId);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	public void SendResumeLastGame()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "placementId" + 3792;
		SFS.SendRoomExtensionRequest((string)command);
	}

	public static void RestartGame()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "placementId" + 3704;
		SFS.SendRoomExtensionRequest((string)command);
	}

	public void CancelMatchMaking()
	{
		ExitGame();
	}

	public void NotifyGiftSent(int giftId, long[] recipientsDbIds)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftNotification giftNotification = default(GiftNotification);
		giftNotification..ctor();
		object command = "not" + 208;
		giftNotification.<ItemId>k__BackingField = giftId;
		object obj2 = giftNotification + 32;
		obj2 = recipientsDbIds;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ISFSObject param = giftNotification.ToSfsObject();
		SFS.SendRoomExtensionRequest((string)command, param);
	}

	public void NotifyAnimatedGiftSent(int giftId, long[] targetIds)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0082: Expected O, but got I4
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0294: Expected O, but got I4
		//IL_00a2: Expected O, but got I
		//IL_00cb: Expected I, but got O
		//IL_00db: Expected O, but got I
		//IL_0116: Expected O, but got I
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01ed: Expected I4, but got O
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		if (targetIds.Length < 1)
		{
			return;
		}
		object obj = typeof(UsageHint) + 8;
		object obj2 = typeof(SqlSingle[]) + 3816;
		object obj3 = targetIds + 32;
		object command = "m_StencilDeferredPS" + 3152;
		long[] array = targetIds;
		int num = giftId;
		object obj4 = 0;
		SessionModel sessionModel = default(SessionModel);
		object obj14 = default(object);
		AnimatedGiftNotification animatedGiftNotification = default(AnimatedGiftNotification);
		int senderId = default(int);
		bool flag3;
		do
		{
			object obj5 = typeof(Queue<string>) + 848;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			User localUser = sessionModel.LocalUser;
			nint num2 = (nint)localUser;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v12 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v12 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_015f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v12 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj10 = (nint)0 + (nint)8;
			object obj11;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X10_v8-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj11 = obj10 + 16;
				obj9--;
				bool flag2 = (nint)obj9 != 1;
				obj10 = obj11;
				if (flag2)
				{
					continue;
				}
				goto IL_015f;
			}
			object obj12 = num2 + obj10;
			object obj13 = obj12 + 312;
			obj11 = obj10;
			goto IL_0220;
			IL_015f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			array = null;
			obj13 = obj14;
			goto IL_0220;
			IL_0220:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v159 @ X8_v13] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X25_v4+v112 @ X24_v5*8]");
			animatedGiftNotification..ctor(giftId, senderId, 0);
			ISFSObject iSFSObject = animatedGiftNotification.ToSfsObject();
			SFS.SendRoomExtensionRequest((string)command, iSFSObject);
			obj4++;
			flag3 = (nint)obj4 < targetIds.Length;
			array = null;
			num = (int)iSFSObject;
		}
		while (flag3);
	}

	public void NotifyEmoteSent(int emoteId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0175: Expected I, but got O
		//IL_0185: Expected O, but got I
		//IL_01c0: Expected O, but got I
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8B67]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v14+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v14+E4]");
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
		IL_0201:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj9 = default(object);
		object obj8 = obj9;
		goto IL_0292;
		IL_0292:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ X8_v7] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EmoteNotification emoteNotification = default(EmoteNotification);
		int senderId = default(int);
		emoteNotification..ctor(emoteId, senderId);
		object command = "destinationTimeZone" + 1976;
		ISFSObject param = emoteNotification.ToSfsObject();
		SFS.SendRoomExtensionRequest((string)command, param);
		return;
		IL_0133:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		object obj10 = typeof(UsageHint) + 8;
		object obj11 = typeof(DataRelation) + 3016;
		nint num = (nint)localUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0201;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X10_v6-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj13 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_0201;
		}
		object obj14 = num + obj13;
		obj8 = obj14 + 312;
		goto IL_0292;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	public void FakeGiftSent(int giftId, int[] recipientsSfsIds)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0070: Expected O, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_00f7: Expected I, but got O
		//IL_0107: Expected O, but got I
		//IL_02c8: Expected I, but got O
		//IL_0142: Expected O, but got I
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0232: Expected O, but got I
		//IL_0242: Expected O, but got I
		//IL_0252: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftNotification giftNotification = default(GiftNotification);
		giftNotification..ctor();
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		giftNotification.<ItemId>k__BackingField = giftId;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		object obj6 = typeof(UsageHint) + 8;
		object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1880;
		object obj8 = (nint)0 + (nint)3080;
		object obj9 = (nint)0 + (nint)3480;
		nint num = (nint)localUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v9 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v9 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0183;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v9 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X10_v5-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0183;
		}
		object obj12 = num + obj11;
		object obj13 = obj12 + 312;
		int[] array = recipientsSfsIds;
		goto IL_0299;
		IL_0299:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v257 @ X8_v10] (should have been resolved before IL gen)");
		long <SenderId>k__BackingField = default(long);
		giftNotification.<SenderId>k__BackingField = <SenderId>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<int, long> func = default(Func<int, long>);
		func..ctor((object)null, (IntPtr)obj8);
		IEnumerable<long> source = Enumerable.Select(recipientsSfsIds, func);
		long[] array2 = Enumerable.ToArray(source);
		object obj14 = giftNotification + 32;
		obj14 = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Action<GiftNotification> onGiftSent = this.OnGiftSent;
		if (this.OnGiftSent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v12 (System.Action`1<GiftNotification>)+18]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v12 (System.Action`1<GiftNotification>)+40]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v12 (System.Action`1<GiftNotification>)+28]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v104 @ X3_v2 (should have been resolved before IL gen)");
		}
		return;
		IL_0183:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		array = null;
		object obj18 = default(object);
		obj13 = obj18;
		goto IL_0299;
	}

	public void FakeAnimatedGiftSent(int giftId, long[] recipientsSfsIds)
	{
		//IL_0030: Expected O, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0073: Expected O, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_018f: Expected O, but got I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_01b5: Expected O, but got I
		//IL_01c7: Expected I4, but got O
		if (recipientsSfsIds.Length < 1)
		{
			return;
		}
		object obj = (nint)0 + (nint)2200;
		object obj2 = recipientsSfsIds + 32;
		object obj3 = typeof(SqlSingle[]) + 3816;
		IntPtr intPtr = default(IntPtr);
		int num = (int)(nint)intPtr;
		long[] array = recipientsSfsIds;
		int num2 = giftId;
		object obj4 = 0;
		SessionModel sessionModel = default(SessionModel);
		AnimatedGiftNotification animatedGiftNotification = default(AnimatedGiftNotification);
		bool flag3;
		do
		{
			object obj5 = typeof(Queue<string>) + 848;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			User localUser = sessionModel.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X28_v4+v95 @ X25_v5*8]");
			animatedGiftNotification..ctor(giftId, intDbId, 0);
			Action<AnimatedGiftNotification> onAnimatedGiftSent = this.OnAnimatedGiftSent;
			bool flag2 = this.OnAnimatedGiftSent == null;
			array = (long[])intDbId;
			num2 = giftId;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v10 (System.Action`1<AnimatedGiftNotification>)+28]");
				array = (long[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v242 @ X8_v10 (System.Action`1<AnimatedGiftNotification>)+18] (should have been resolved before IL gen)");
				num2 = (int)animatedGiftNotification;
			}
			obj4++;
			flag3 = (nint)obj4 >= recipientsSfsIds.Length;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X28_v4+v95 @ X25_v5*8]");
			num = 0;
		}
		while (!flag3);
	}

	public void FakeEmoteSent(int emoteId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0168: Expected O, but got I
		//IL_0192: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_01db: Expected O, but got I4
		//IL_012c: Expected O, but got I
		//IL_013c: Expected O, but got I
		//IL_014c: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8B6A]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0156;
		}
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = obj4;
		if (!flag)
		{
			goto IL_0091;
		}
		goto IL_01a8;
		IL_0156:
		_ = 1;
		obj4 = (nint)0 + (nint)2200;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		obj6 = obj4;
		if (obj7 != null)
		{
			goto IL_0091;
		}
		goto IL_01a8;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		object obj8 = typeof(DataRelation) + 3016;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EmoteNotification emoteNotification = default(EmoteNotification);
		emoteNotification..ctor(emoteId, intDbId);
		Action<EmoteNotification> onEmoteSent = this.OnEmoteSent;
		if (this.OnEmoteSent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v8 (System.Action`1<EmoteNotification>)+18]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v8 (System.Action`1<EmoteNotification>)+40]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v8 (System.Action`1<EmoteNotification>)+28]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v116 @ X3_v3 (should have been resolved before IL gen)");
			goto IL_0156;
		}
		return;
		IL_01a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
	}

	public void MutePlayerInGame(string mutePlayerDbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "m_StencilDeferredPS" + 2792;
		object command = "m_StencilDeferredPS" + 2800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, mutePlayerDbId);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	public void BanPlayerFromGame(string bannedPlayerDbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "alignContent" + 3832;
		object command = "alignContent" + 3824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, bannedPlayerDbId);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	public static void SendForfeitGame()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "fetch_products" + 1048;
		SFS.SendRoomExtensionRequest((string)command);
	}

	protected virtual void Init()
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I4
		//IL_0020: Expected O, but got I
		RegisterEvents();
		object obj = typeof(Queue<string>) + 848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if ((object)sessionModel != null)
		{
			User localUser = sessionModel.LocalUser;
			Room room = Room;
			int playerIndexByUser = SFSKammelnaRoomExtensions.GetPlayerIndexByUser(room, localUser);
			SeatPlayer(playerIndexByUser);
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
			NullReferenceException ex2 = new NullReferenceException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		}
	}

	public virtual void GameComponentsLoaded()
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<KGame>)+2A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<KGame>)+2B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private bool TrySeatPlayer()
	{
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_034c: Expected O, but got I4
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_03a7: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_0bb5: Expected I4, but got O
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00e8: Expected I, but got O
		//IL_00f8: Expected O, but got I
		//IL_018e: Expected O, but got I
		//IL_01bf: Expected O, but got I
		//IL_0133: Expected O, but got I
		//IL_01f8: Expected O, but got I4
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		//IL_0479: Expected I, but got O
		//IL_0489: Expected O, but got I
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03f3: Expected O, but got I
		//IL_0427: Expected O, but got I
		//IL_051f: Expected O, but got I
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected O, but got Unknown
		//IL_054f: Expected O, but got I4
		//IL_0558: Expected O, but got I4
		//IL_0568: Expected O, but got I
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_09d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dc: Expected O, but got Unknown
		//IL_0a06: Expected O, but got I4
		//IL_04c4: Expected O, but got I
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Expected O, but got Unknown
		//IL_05aa: Expected O, but got I4
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected O, but got Unknown
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected O, but got Unknown
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected O, but got Unknown
		//IL_0970: Expected O, but got I
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected O, but got Unknown
		//IL_09a2: Expected O, but got I4
		//IL_09ba: Expected O, but got I
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Expected O, but got Unknown
		//IL_08c9: Expected O, but got I4
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected O, but got Unknown
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Expected O, but got Unknown
		//IL_0924: Expected O, but got I4
		//IL_028b: Expected I, but got O
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02d3: Expected O, but got I4
		//IL_0612: Expected O, but got I4
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Expected O, but got Unknown
		//IL_0b3e: Expected O, but got I4
		//IL_0b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6a: Expected O, but got Unknown
		//IL_0b99: Expected O, but got I4
		//IL_064a: Expected O, but got I4
		//IL_06c0: Expected I, but got O
		//IL_06d0: Expected O, but got I
		//IL_0766: Expected O, but got I
		//IL_0788: Expected O, but got I4
		//IL_0791: Expected O, but got I4
		//IL_07a1: Expected O, but got I
		//IL_070b: Expected O, but got I
		//IL_07be: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected O, but got Unknown
		//IL_07ed: Expected O, but got I4
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Expected O, but got Unknown
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0836: Expected O, but got Unknown
		//IL_0860: Expected O, but got I4
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Expected O, but got Unknown
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a98: Expected O, but got Unknown
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Expected O, but got Unknown
		//IL_0ab6: Expected O, but got I
		//IL_0ada: Expected O, but got I4
		//IL_0af2: Expected O, but got I
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected O, but got Unknown
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Expected O, but got Unknown
		Room room = Room;
		object obj;
		Room room2;
		GameEventsChannel gameEventsChannel;
		object obj11;
		Room room3;
		object obj13;
		if (room != null)
		{
			obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				room2 = Room;
				if (localUser != null)
				{
					object obj5 = typeof(UsageHint) + 8;
					nint num = (nint)localUser;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v14 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v14 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0174;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v14 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
					object obj7 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X10_v23-8]");
						if (0 == (nint)obj5)
						{
							break;
						}
						obj7 += 16;
						obj6--;
						if ((nint)obj6 != 1)
						{
							continue;
						}
						goto IL_0174;
					}
					object obj8 = obj7 + 5;
					object obj9 = num + obj8;
					object obj10 = obj9 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v95+8]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v456 @ X0_v95] (should have been resolved before IL gen)");
					object obj12 = default(object);
					bool flag2 = (nint)obj12 >= 1;
					room3 = room2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v95+8]");
					obj13 = 0;
					if (flag2)
					{
						goto IL_01ce;
					}
					goto IL_0436;
				}
			}
		}
		else
		{
			object obj14 = typeof(DataRelation) + 856;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj16 = !flag3;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "ThisIsFakeReceiptData" + 2120;
			Debug.LogWarning(message);
			gameEventsChannel = this.gameEventsChannel;
			bool flag4 = (object)this.gameEventsChannel == null;
			object obj17 = !flag4;
			if (obj17 != null)
			{
				goto IL_0a64;
			}
		}
		goto IL_0ba7;
		IL_0436:
		Room room4 = Room;
		object obj18;
		object obj24;
		object obj28;
		object obj29;
		if (room4 != null)
		{
			obj18 = typeof(RegisteredWaitHandle) + 1376;
			nint num2 = (nint)room4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0505;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj20 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X10_v17-8]");
				if (0 == (nint)obj18)
				{
					break;
				}
				obj20 += 16;
				obj19--;
				if ((nint)obj19 != 1)
				{
					continue;
				}
				goto IL_0505;
			}
			object obj21 = obj20 + 6;
			object obj22 = num2 + obj21;
			object obj23 = obj22 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v48+8]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v554 @ X8_v48] (should have been resolved before IL gen)");
			object obj26 = default(object);
			object obj25 = obj26 & 1;
			bool flag5 = obj25 == null;
			object obj27 = !flag5;
			obj28 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v48+8]");
			obj29 = 0;
			if (obj27 != null)
			{
				goto IL_0576;
			}
			goto IL_09c8;
		}
		goto IL_0ba7;
		IL_0ba7:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0a77:
		return false;
		IL_0174:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v92+8]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v409 @ X0_v92] (should have been resolved before IL gen)");
		object obj30 = default(object);
		bool flag6 = (nint)obj30 < 1;
		room3 = room2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v92+8]");
		obj13 = 0;
		if (!flag6)
		{
			goto IL_01ce;
		}
		goto IL_0436;
		IL_0a64:
		gameEventsChannel.TriggerLeaveRoom(LeaveReason.RoomClosed);
		goto IL_0a77;
		IL_07af:
		object obj31 = typeof(DataRelation) + 856;
		object obj32 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v50+E4]");
		bool flag7 = (nint)0 == 0;
		object obj33 = !flag7;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message2 = "ThisIsFakeReceiptData" + 2080;
		Debug.LogWarning(message2);
		object obj34 = typeof(RegisteredWaitHandle) + 3136;
		object obj35 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X0_v53+E4]");
		bool flag8 = (nint)0 == 0;
		object obj36 = !flag8;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
		goto IL_0a77;
		IL_01ce:
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X0_v70+E4]");
		bool flag9 = (nint)0 == 0;
		object obj38 = !flag9;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		if ((object)sessionModel2 != null)
		{
			User localUser2 = sessionModel2.LocalUser;
			Room room5 = Room;
			int playerIndexByUser = SFSKammelnaRoomExtensions.GetPlayerIndexByUser(room5, localUser2);
			if (playerIndexByUser >= 1)
			{
				nint num3 = (nint)this;
				SeatPlayer(playerIndexByUser);
				object obj39 = typeof(DataRelation) + 856;
				object obj40 = obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v85+E4]");
				bool flag10 = (nint)0 == 0;
				object obj41 = !flag10;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object message3 = "ThisIsFakeReceiptData" + 2104;
				Debug.LogWarning(message3);
				return true;
			}
			object obj42 = typeof(DataRelation) + 856;
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v78+E4]");
			bool flag11 = (nint)0 == 0;
			object obj44 = !flag11;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message4 = "ThisIsFakeReceiptData" + 2112;
			Debug.LogWarning(message4);
			gameEventsChannel = this.gameEventsChannel;
			bool flag12 = (object)this.gameEventsChannel == null;
			object obj45 = !flag12;
			if (obj45 != null)
			{
				goto IL_0a64;
			}
		}
		goto IL_0ba7;
		IL_0576:
		Room room6 = Room;
		object obj46 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v33+E4]");
		bool flag13 = (nint)0 == 0;
		object obj47 = !flag13;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		object obj56;
		object obj59;
		object obj48;
		if ((object)sessionModel3 != null)
		{
			Room currentRoom = sessionModel3.CurrentRoom;
			bool flag14 = room6 == currentRoom;
			obj48 = 0;
			if (flag14)
			{
				goto IL_0b00;
			}
			object obj49 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v44+E4]");
			bool flag15 = (nint)0 == 0;
			object obj50 = !flag15;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel4 = default(SessionModel);
			if ((object)sessionModel4 != null)
			{
				Room currentRoom2 = sessionModel4.CurrentRoom;
				if (currentRoom2 != null)
				{
					nint num4 = (nint)currentRoom2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v32 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					object obj51 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v32 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_074c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v32 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj52 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X10_v12-8]");
						if (0 == (nint)obj18)
						{
							break;
						}
						obj52 += 16;
						obj51--;
						if ((nint)obj51 != 1)
						{
							continue;
						}
						goto IL_074c;
					}
					object obj53 = obj52 + 6;
					object obj54 = num4 + obj53;
					object obj55 = obj54 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v45+8]");
					obj56 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v653 @ X8_v45] (should have been resolved before IL gen)");
					object obj57 = default(object);
					bool flag16 = obj57 == null;
					object obj58 = !flag16;
					obj59 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v45+8]");
					obj48 = 0;
					if (obj58 != null)
					{
						goto IL_07af;
					}
					goto IL_0b00;
				}
			}
		}
		goto IL_0ba7;
		IL_0b00:
		object obj60 = typeof(DataRelation) + 856;
		object obj61 = obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X0_v39+E4]");
		bool flag17 = (nint)0 == 0;
		object obj62 = !flag17;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message5 = "ThisIsFakeReceiptData" + 2088;
		Debug.LogWarning(message5);
		gameEventsChannel = this.gameEventsChannel;
		bool flag18 = (object)this.gameEventsChannel == null;
		object obj63 = !flag18;
		if (obj63 != null)
		{
			goto IL_0a64;
		}
		goto IL_0ba7;
		IL_0505:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X0_v65+8]");
		obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v517 @ X0_v65] (should have been resolved before IL gen)");
		object obj65 = default(object);
		object obj64 = obj65 & 1;
		bool flag19 = obj64 == null;
		obj13 = 6;
		obj28 = 6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X0_v65+8]");
		obj29 = 0;
		if (!flag19)
		{
			goto IL_0576;
		}
		goto IL_09c8;
		IL_09c8:
		object obj66 = typeof(DataRelation) + 856;
		object obj67 = obj66;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v25+E4]");
		bool flag20 = (nint)0 == 0;
		object obj68 = !flag20;
		if (obj68 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message6 = "ThisIsFakeReceiptData" + 2096;
		Debug.LogWarning(message6);
		gameEventsChannel = this.gameEventsChannel;
		if ((object)this.gameEventsChannel != null)
		{
			goto IL_0a64;
		}
		goto IL_0ba7;
		IL_074c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X0_v59+8]");
		obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v688 @ X0_v59] (should have been resolved before IL gen)");
		object obj69 = default(object);
		bool flag21 = obj69 == null;
		obj59 = 6;
		obj13 = 6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X0_v59+8]");
		obj48 = 0;
		if (!flag21)
		{
			goto IL_07af;
		}
		goto IL_0b00;
	}

	private bool IsInvalidSeatingState()
	{
		//IL_003d: Expected O, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected I4, but got Unknown
		if (IsSpectator)
		{
			return false;
		}
		object obj = <MySeatIndex>k__BackingField - 1;
		bool flag = (nint)obj < 0;
		int num = <MySeatIndex>k__BackingField ^ 1;
		int num2 = <MySeatIndex>k__BackingField ^ obj;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		return !flag3;
	}

	public virtual void ResetGame()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00cf: Expected O, but got I
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_011a: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj3 = default(object);
		object obj5 = default(object);
		while (true)
		{
			IGameScores gameScores = GameScores;
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2792;
			nint num = (nint)gameScores;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v6 (Il2CppClass<IGameScores>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v6 (Il2CppClass<IGameScores>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v6 (Il2CppClass<IGameScores>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v4-8]");
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
				goto IL_00d9;
			}
			goto IL_00ad;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v116 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_00d9:
			object obj7 = obj3 + 1;
			object obj8 = num + obj7;
			object obj9 = obj8 + 312;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v9+8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v126 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	public void ExitGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_010b: Expected O, but got I
		//IL_013b: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_009c: Expected O, but got I4
		//IL_00a5: Expected F4, but got I4
		//IL_00ae: Expected O, but got I4
		//IL_0161: Expected I, but got O
		//IL_018b: Expected O, but got I4
		//IL_00d0: Expected F4, but got I4
		//IL_00d9: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)248;
		UnRegisterEvents();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)3248;
		object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		VivoxManager vivoxManager = default(VivoxManager);
		vivoxManager.DestroySelf();
		bool isTablet = ScreenUtility.IsTablet;
		bool flag2 = !isTablet;
		object obj8 = !flag2;
		float seconds = 0f;
		object obj9 = 0;
		if (obj8 == null)
		{
			Actions.SafeInvoke(this.OnGameExiting);
			seconds = 1.05360915E+09f;
			obj9 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(seconds, action);
	}

	public void SendBackToGame()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "___# Content push apply failed [{0}]: {1}" + 2648;
		SFS.SendRoomExtensionRequest((string)command);
	}

	protected virtual void SeatPlayer(int seatIndex)
	{
		//IL_006b: Expected O, but got I4
		//IL_0030: Expected O, but got I4
		//IL_0099: Expected O, but got I4
		//IL_017a: Expected O, but got I
		//IL_008b: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
		//IL_0105: Expected O, but got I4
		//IL_010e: Expected O, but got I4
		//IL_0150: Expected O, but got I4
		if (IsSpectator)
		{
			object obj = 240;
		}
		else
		{
			Room room = Room;
			bool isReplay = SFSKammelnaRoomExtensions.GetIsReplay(room);
			bool flag = !isReplay;
			object obj2 = !flag;
			object obj3 = ~obj2;
			if (obj3 == null)
			{
				object obj = 240;
			}
			else
			{
				object obj = 248;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KGame)+v54 @ X8_v1]");
		Actions.SafeInvoke((Action)0);
		Room room2 = Room;
		TutorialType tutorialType = SFSKammelnaRoomExtensions.GetTutorialType(room2);
		bool flag2 = tutorialType == TutorialType.None;
		object obj4 = !flag2;
		KGame kGame = (KGame)tutorialType;
		if (obj4 == null)
		{
			Room room3 = Room;
			bool isReplay2 = SFSKammelnaRoomExtensions.GetIsReplay(room3);
			bool flag3 = !isReplay2;
			object obj5 = !flag3;
			kGame = (KGame)isReplay2;
			if (obj5 == null)
			{
				Room room4 = Room;
				bool flag4 = SFSKammelnaRoomExtensions.IsOffline(room4);
				bool flag5 = !flag4;
				kGame = (KGame)flag4;
				if (!flag5)
				{
					return;
				}
			}
		}
		kGame.SendGameLoaded();
	}

	private void SwitchToSpectatorMode()
	{
		Actions.SafeInvoke(this.OnBecomingWatcher);
	}

	private void SwitchToPlayerMode()
	{
		Actions.SafeInvoke(this.OnBecomingPlayer);
	}

	public KPlayer GetPlayer(Userbox userbox)
	{
		//IL_0066: Expected O, but got I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0095: Expected O, but got I
		if ((object)userbox != null)
		{
			KPlayer[] array = players;
			if (players != null)
			{
				bool flag = (int)userbox.direction < array.Length;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = players + userbox.direction;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+20]");
					return (KPlayer)0;
				}
				goto IL_00a3;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00a3;
		IL_00a3:
		return (KPlayer)(object)new IndexOutOfRangeException();
	}

	public KPlayer GetPlayerByIndex(int index)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_004b: Expected O, but got I
		//IL_00ce: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2208;
			object obj4 = (nint)0 + (nint)3088;
			object obj5 = (nint)0 + (nint)2312;
			List<object> source = Enumerable.ToList((IEnumerable<object>)players);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return (KPlayer)Enumerable.FirstOrDefault(source, func);
		}
		return (KPlayer)(object)new NullReferenceException();
	}

	public KPlayer GetPlayerBySFSId(int sfsId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_004b: Expected O, but got I
		//IL_00ce: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2208;
			object obj4 = (nint)0 + (nint)3096;
			object obj5 = (nint)0 + (nint)2312;
			List<object> source = Enumerable.ToList((IEnumerable<object>)players);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return (KPlayer)Enumerable.FirstOrDefault(source, func);
		}
		return (KPlayer)(object)new NullReferenceException();
	}

	public int GetPlayerIndexByUser(User user)
	{
		Room room = Room;
		return SFSKammelnaRoomExtensions.GetPlayerIndexByUser(room, user);
	}

	public int GetPlayerIndexByUserDbId(string userDbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_02bf: Expected I4, but got O
		//IL_0118: Expected O, but got I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_016a: Expected I, but got O
		//IL_017a: Expected O, but got I
		//IL_02b1: Expected I4, but got I8
		//IL_01b5: Expected O, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0299: Expected O, but got I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8B73]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string value = default(string);
		bool flag2 = StringsExtensions.IsNullOrEmpty(value);
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			goto IL_0127;
		}
		goto IL_02a7;
		IL_02a7:
		return -1;
		IL_01f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v217 @ X0_v11] (should have been resolved before IL gen)");
		User user = default(User);
		if (user != null)
		{
			goto IL_0227;
		}
		goto IL_02a7;
		IL_0227:
		Room room = Room;
		return SFSKammelnaRoomExtensions.GetPlayerIndexByUser(room, user);
		IL_0074:
		if (!StringsExtensions.IsNullOrEmpty(value))
		{
			goto IL_0127;
		}
		goto IL_02a7;
		IL_0127:
		Room room2 = Room;
		if (room2 != null)
		{
			object obj6 = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01f6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj8 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X10_v6-8]");
				if (0 == (nint)obj6)
				{
					break;
				}
				obj8 += 16;
				obj7--;
				if ((nint)obj7 != 1)
				{
					continue;
				}
				goto IL_01f6;
			}
			object obj9 = obj8 + 26;
			object obj10 = num + obj9;
			object obj11 = obj10 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v137 @ X8_v10] (should have been resolved before IL gen)");
			bool flag4 = user == null;
			object obj12 = !flag4;
			if (obj12 != null)
			{
				goto IL_0227;
			}
			goto IL_02a7;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public bool IsInGameRoom(string userDbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_024a: Expected I4, but got O
		//IL_0119: Expected O, but got I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_016b: Expected I, but got O
		//IL_017b: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8B74]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = StringsExtensions.IsNullOrEmpty(userDbId);
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			goto IL_009f;
		}
		goto IL_0128;
		IL_009f:
		return false;
		IL_01f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj7 = default(object);
		object obj6 = obj7;
		goto IL_026e;
		IL_026e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v138 @ X8_v6] (should have been resolved before IL gen)");
		object obj8 = default(object);
		bool flag4 = obj8 == null;
		return !flag4;
		IL_0074:
		if (StringsExtensions.IsNullOrEmpty(userDbId))
		{
			goto IL_009f;
		}
		goto IL_0128;
		IL_0128:
		Room room = Room;
		if (room != null)
		{
			object obj9 = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01f7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X10_v5-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				obj11 += 16;
				obj10--;
				if ((nint)obj10 != 1)
				{
					continue;
				}
				goto IL_01f7;
			}
			object obj12 = obj11 + 26;
			object obj13 = num + obj12;
			obj6 = obj13 + 312;
			goto IL_026e;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public bool IsGameBalanced()
	{
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_0380: Expected O, but got I
		//IL_053c: Expected O, but got I4
		//IL_0391: Expected O, but got I
		//IL_039d: Expected O, but got I
		//IL_03ad: Expected O, but got I
		//IL_03bd: Expected O, but got I
		//IL_03df: Expected O, but got I4
		//IL_003e: Expected O, but got I4
		//IL_0360: Expected I4, but got O
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected O, but got Unknown
		//IL_0417: Expected O, but got I
		//IL_0428: Expected I, but got O
		//IL_0446: Expected O, but got I
		//IL_006e: Expected O, but got I
		//IL_00ee: Expected O, but got I4
		//IL_00fe: Expected O, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_01a3: Expected O, but got I4
		//IL_01b3: Expected O, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_0202: Expected O, but got I4
		//IL_0212: Expected O, but got I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_0319: Expected O, but got I4
		//IL_0472: Expected O, but got I4
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		//IL_033a: Unsupported input type for neg.
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1168;
		object obj2 = (nint)0 + (nint)2312;
		List<object> source = Enumerable.ToList((IEnumerable<object>)players);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		object obj5 = (nint)0 + (nint)3656;
		object obj6 = (nint)0 + (nint)1320;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v6+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v18+28]");
		Func<object, int> selector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v18+28]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v24+B8]");
				obj7 = 0;
			}
			object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)3064;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj7, (IntPtr)obj12);
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v23+B8]");
			object obj14 = (nint)0 + (nint)40;
			obj14 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<int> source2 = Enumerable.Select(source, selector);
		int[] array = Enumerable.ToArray(source2);
		if (array != null)
		{
			if (array.Length != 0)
			{
				bool flag4 = array.Length < 2;
				object obj15 = !flag4;
				object obj16 = array.Length - 2;
				bool flag5 = obj16 == null;
				object obj17 = ~obj15;
				object obj18 = obj17 | flag5;
				if (obj18 == null)
				{
					object obj19 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					int points = array[2] + array[0];
					PlayerRank playerRank = default(PlayerRank);
					playerRank..ctor(points);
					bool flag6 = array.Length < 1;
					object obj20 = !flag6;
					object obj21 = array.Length - 1;
					bool flag7 = obj21 == null;
					object obj22 = ~obj20;
					object obj23 = obj22 | flag7;
					if (obj23 == null)
					{
						bool flag8 = array.Length < 3;
						object obj24 = !flag8;
						object obj25 = array.Length - 3;
						bool flag9 = obj25 == null;
						object obj26 = ~obj24;
						object obj27 = obj26 | flag9;
						if (obj27 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							int points2 = array[3] + array[1];
							PlayerRank playerRank2 = default(PlayerRank);
							playerRank2..ctor(points2);
							if (playerRank != null)
							{
								int totalSubRank = playerRank.GetTotalSubRank();
								if (playerRank2 != null)
								{
									object obj28 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
									int totalSubRank2 = playerRank2.GetTotalSubRank();
									object obj29 = obj28;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v12+E4]");
									bool flag10 = (nint)0 == 0;
									object obj30 = !flag10;
									if (obj30 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									object obj31 = totalSubRank - totalSubRank2;
									if (totalSubRank < totalSubRank2)
									{
										obj31 = 0 - obj31;
									}
									object obj32 = obj31 - 4;
									bool flag11 = (nint)obj32 < 0;
									object obj33 = obj31 ^ 4;
									object obj34 = obj31 ^ obj32;
									object obj35 = obj33 & obj34;
									bool flag12 = (nint)obj35 < 0;
									bool flag13 = flag11 == flag12;
									return !flag13;
								}
							}
							goto IL_0352;
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		goto IL_0352;
		IL_0352:
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	protected KGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0086: Expected O, but got I
		//IL_0211: Expected O, but got I
		//IL_0221: Expected O, but got I
		//IL_0237: Expected O, but got I
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_025f: Expected O, but got I4
		//IL_026f: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I
		//IL_02d1: Expected O, but got I
		//IL_02e1: Expected O, but got I
		//IL_02f7: Expected O, but got I
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_02a9: Expected O, but got I4
		//IL_0141: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0167: Expected O, but got I
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_018f: Expected O, but got I4
		//IL_019f: Expected O, but got I
		//IL_01cc: Expected O, but got I
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_0332: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2104;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2088;
		object obj3 = (nint)0 + (nint)3200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = this + 64;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GameLobbyState gameLobbyState = default(GameLobbyState);
		gameLobbyState..ctor();
		object obj6 = this + 96;
		obj6 = gameLobbyState;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X20_v4+38]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X20_v4+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v3+10]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v3+10]");
			bool flag = (object)((object)((nint)0 + (nint)309) & 1) == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v3+10]");
			object obj10 = 0;
			if (!flag)
			{
				goto IL_010c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X20_v4+38]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v10+10]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v10+10]");
			object obj12 = (object)((object)((nint)0 + (nint)309) & 1) != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v10+10]");
			object obj10 = 0;
			if (obj12 != null)
			{
				goto IL_010c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v12+E4]");
		if ((object)((nint)0 != 0) != null)
		{
			goto IL_0131;
		}
		goto IL_02b7;
		IL_01ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_01bc;
		IL_0131:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X20_v4+38]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v17+10]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v17+10]");
		object obj15 = (object)((object)((nint)0 + (nint)309) & 1) != null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v17+10]");
		object obj16 = 0;
		if (obj15 == null)
		{
			goto IL_01ad;
		}
		goto IL_01bc;
		IL_01bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v20+B8]");
		players = (KPlayer[])0;
		object obj17 = this + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		return;
		IL_010c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0131;
		}
		goto IL_02b7;
		IL_02b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X20_v4+38]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v5+10]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v5+10]");
		if ((object)((object)((nint)0 + (nint)309) & 1) == null)
		{
			goto IL_01ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v5+10]");
		obj16 = 0;
		goto IL_01bc;
	}

	private bool <get_HasActivePlayers>b__65_0(User user)
	{
		//IL_00f8: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0164: Expected I4, but got O
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		Room room = Room;
		if (user != null)
		{
			object obj = typeof(UsageHint) + 8;
			nint num = (nint)user;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X10_v5-8]");
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
			object obj4 = obj3 + 5;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0143;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0143:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ X0_v4] (should have been resolved before IL gen)");
		object obj8 = default(object);
		object obj7 = ~obj8;
		return (byte)(obj7 >> 31) != 0;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0143;
	}

	private void <ExitGame>b__215_0()
	{
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01e0: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_022e: Expected O, but got I
		//IL_023e: Expected O, but got I
		//IL_0260: Expected O, but got I4
		//IL_0098: Expected O, but got I
		//IL_00a8: Expected O, but got I
		//IL_0360: Expected O, but got I
		//IL_0370: Expected O, but got I
		//IL_0392: Expected O, but got I4
		//IL_0298: Expected O, but got I4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0460: Expected O, but got I4
		//IL_0134: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_0166: Expected O, but got I4
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected O, but got Unknown
		//IL_050e: Expected O, but got I
		//IL_051f: Expected I, but got O
		//IL_053d: Expected O, but got I
		//IL_0489: Expected O, but got I
		//IL_03d2: Expected O, but got I4
		//IL_02f7: Expected O, but got I4
		//IL_0310: Expected O, but got I4
		//IL_0318: Expected I, but got O
		//IL_02c8: Expected O, but got I
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected O, but got Unknown
		//IL_057e: Expected O, but got I
		//IL_058f: Expected I, but got O
		//IL_05ad: Expected O, but got I
		//IL_0185: Expected O, but got I4
		//IL_018d: Expected I, but got O
		//IL_0402: Expected O, but got I
		Room room = Room;
		if (SFSKammelnaRoomExtensions.IsOffline(room))
		{
			SFS.BackFromOffline();
			return;
		}
		Room room2 = Room;
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room2);
		object obj;
		Func<bool> func;
		object obj9 = default(object);
		Func<bool> func3;
		Func<bool> func5;
		object obj14;
		object obj2;
		object obj13;
		nint num;
		Func<bool> func4;
		if (gameType == GameType.Tournament)
		{
			obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1168;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v24+E4]");
			object obj3;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v24+B8]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v26+18]");
				func = (Func<bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v26+18]");
				bool flag = (nint)0 == 0;
				object obj4 = obj2;
				if (!flag)
				{
					goto IL_00d5;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v24+B8]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v26+18]");
				func = (Func<bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v26+18]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj2;
				if (obj5 != null)
				{
					goto IL_00d5;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v35+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v33+B8]");
				obj3 = 0;
			}
			object obj8 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj9 = (nint)0 + (nint)3048;
			Func<bool> func2 = default(Func<bool>);
			func2..ctor(obj3, (IntPtr)obj9);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v31+B8]");
			object obj11 = (nint)0 + (nint)24;
			obj11 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v24+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			func3 = func2;
			func = func2;
			obj13 = 0;
			num = (nint)obj9;
			func4 = func2;
			obj14 = obj2;
			func5 = func2;
			if (obj12 != null)
			{
				goto IL_0124;
			}
			goto IL_033e;
		}
		object obj15 = typeof(RegisteredWaitHandle) + 3136;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.Menu);
		return;
		IL_00d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v24+E4]");
		bool flag6 = (nint)0 == 0;
		func3 = null;
		object obj18 = default(object);
		obj13 = obj18;
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		func4 = null;
		obj14 = obj2;
		func5 = func;
		if (!flag6)
		{
			goto IL_0124;
		}
		goto IL_033e;
		IL_03b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v24+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		object obj21;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v21+B8]");
			obj21 = 0;
		}
		object obj22 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)3056;
		Action action = default(Action);
		action..ctor(obj21, (IntPtr)obj23);
		object obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v20+B8]");
		object obj25 = (nint)0 + (nint)32;
		obj25 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Action fallback = action;
		Func<bool> func6;
		Func<bool> cancelCondition = func6;
		goto IL_0407;
		IL_033e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v24+B8]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v15+20]");
		fallback = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v15+20]");
		bool flag8 = (nint)0 == 0;
		object obj26 = !flag8;
		func6 = func5;
		cancelCondition = func5;
		if (obj26 == null)
		{
			goto IL_03b0;
		}
		goto IL_0407;
		IL_0407:
		Coroutine coroutine = UIExtensions.SetTimeout(this, 5f, cancelCondition, fallback);
		object obj27 = typeof(Queue<string>) + 872;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v17+E4]");
		bool flag9 = (nint)0 == 0;
		object obj29 = !flag9;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj30 = (nint)0 + (nint)2248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
		TournamentData tournament = tournamentMatchInfo.Tournament;
		SFS.JoinTournamentRoom(tournament);
		return;
		IL_0124:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v24+B8]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v15+20]");
		fallback = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v15+20]");
		bool flag10 = (nint)0 == 0;
		object obj31 = !flag10;
		cancelCondition = func;
		if (obj31 == null)
		{
			obj13 = 0;
			num = (nint)obj9;
			func4 = func3;
			func6 = func;
			goto IL_03b0;
		}
		goto IL_0407;
	}
}
