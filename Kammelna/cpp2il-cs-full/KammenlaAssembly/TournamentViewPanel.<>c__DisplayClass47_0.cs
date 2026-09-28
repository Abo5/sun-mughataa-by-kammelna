using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using Spine;
using UI.UI_Themeing;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentViewPanel : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<MatchData, bool> <>9__33_0;

		public static Func<MatchData, bool> <>9__45_0;

		public static Func<MatchData, bool> <>9__45_1;

		public static Func<MatchData, bool> <>9__46_0;

		public static Func<MatchData, bool> <>9__46_1;

		public static Func<MatchData, bool> <>9__47_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3952;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <Init>b__33_0(MatchData m)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01b0: Expected I4, but got O
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EFA]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
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
			if ((object)sessionModel != null)
			{
				goto IL_0150;
			}
			goto IL_01a2;
			IL_01a2:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0150:
			User localUser = sessionModel.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			if (m != null)
			{
				return m.HasPlayer(intDbId);
			}
			goto IL_01a2;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_0150;
			}
			goto IL_01a2;
		}

		internal bool <UpdateLeaveWarning>b__45_0(MatchData data)
		{
			//IL_0044: Expected I4, but got O
			if (data != null)
			{
				return data.<State>k__BackingField == MatchData.Status.Waiting;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <UpdateLeaveWarning>b__45_1(MatchData data)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01b0: Expected I4, but got O
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EFB]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
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
			if ((object)sessionModel != null)
			{
				goto IL_0150;
			}
			goto IL_01a2;
			IL_01a2:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0150:
			User localUser = sessionModel.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			if (data != null)
			{
				return data.HasPlayer(intDbId);
			}
			goto IL_01a2;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_0150;
			}
			goto IL_01a2;
		}

		internal bool <ShowRoundMessage>b__46_0(MatchData data)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01b0: Expected I4, but got O
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EFC]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
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
			if ((object)sessionModel != null)
			{
				goto IL_0150;
			}
			goto IL_01a2;
			IL_01a2:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0150:
			User localUser = sessionModel.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			if (data != null)
			{
				return data.HasPlayer(intDbId);
			}
			goto IL_01a2;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_0150;
			}
			goto IL_01a2;
		}

		internal bool <ShowRoundMessage>b__46_1(MatchData data)
		{
			//IL_0044: Expected I4, but got O
			if (data != null)
			{
				return data.<State>k__BackingField == MatchData.Status.Waiting;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ShowRoundPromotionMessage>b__47_1(MatchData data)
		{
			//IL_0044: Expected I4, but got O
			if (data != null)
			{
				return data.<State>k__BackingField == MatchData.Status.Waiting;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass47_0
	{
		public int myDbId;

		internal bool <ShowRoundPromotionMessage>b__0(MatchData data)
		{
			//IL_0043: Expected I4, but got O
			if (data != null)
			{
				return data.HasPlayer(myDbId);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private TournamentsEventsChannel eventsChannel;

	private ThemeProvider[] themeProviders;

	private TournamentName topbarTitle;

	private Toggle treeTab;

	private Toggle teamsTab;

	private Toggle sunTournamentsTab;

	private TournamentSprites tournamentSprites;

	private RectTransform stripParent;

	private TournamentStrip publicStripPrefab;

	private TournamentStrip privateStripPrefab;

	private TournamentStrip officialStripPrefab;

	private TournamentStrip championshipStripPrefab;

	private TournamentStrip publicClusterStripPrefab;

	private TournamentStrip officialClusterStripPrefab;

	private TournamentStrip championshipAddonStripPrefab;

	private TournamentStrip SportTeamAddonStripPrefab;

	private TournamentStrip championshipClusterAddonStripPrefab;

	private TournamentStrip massStripPrefab;

	private TournamentStrip massFinaleStripPrefab;

	private TournamentStrip massClusterStripPrefab;

	private Button helpBtn;

	private TournamentViewBackground background;

	private LeaveTournamentRoomWarning leaveTournamentRoomWarning;

	private UiToggler backButtonToggler;

	private TournamentData _data;

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
			object obj = 152989696;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
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

	private bool IsStarted
	{
		get
		{
			//IL_0016: Expected O, but got I
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected O, but got Unknown
			//IL_014c: Expected O, but got I
			//IL_0166: Expected O, but got I4
			//IL_016f: Expected O, but got I4
			//IL_0180: Expected O, but got I4
			//IL_00a0: Expected O, but got I
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_005d: Expected O, but got I
			//IL_0075: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			//IL_01a0: Expected O, but got I
			//IL_01ca: Expected O, but got I4
			//IL_0109: Expected O, but got I4
			//IL_0601: Expected I4, but got O
			//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ca: Expected O, but got Unknown
			//IL_03f6: Expected O, but got I4
			//IL_048e: Expected O, but got I
			//IL_04a8: Expected O, but got I4
			//IL_033b: Expected O, but got I
			//IL_04f6: Expected O, but got I4
			//IL_03c1: Expected O, but got I4
			//IL_0572: Unknown result type (might be due to invalid IL or missing references)
			//IL_0577: Expected O, but got Unknown
			//IL_05be: Expected O, but got I4
			//IL_05c7: Expected O, but got I4
			//IL_05e8: Expected O, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701D]");
			object obj = (nint)0 & (nint)1;
			object obj2;
			object obj5;
			object obj6;
			object obj4;
			if (obj != null)
			{
				obj2 = typeof(Queue<string>) + 848;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
				object obj3 = (nint)0 & (nint)1;
				bool flag = obj3 == null;
				obj4 = 152989696;
				obj5 = obj2;
				obj6 = 152989696;
				if (!flag)
				{
					goto IL_0094;
				}
			}
			else
			{
				_ = 1;
				obj2 = typeof(Queue<string>) + 848;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
				object obj7 = (nint)0 & (nint)1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				obj4 = 152989696;
				obj5 = obj2;
				obj6 = 152989696;
				if (obj8 != null)
				{
					goto IL_0094;
				}
			}
			_ = 1;
			object obj9 = (nint)0 + (nint)2200;
			object obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v45+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			obj2 = obj5;
			obj4 = obj6;
			object obj12 = obj9;
			if (obj11 != null)
			{
				goto IL_00e5;
			}
			goto IL_01f0;
			IL_054a:
			SessionModel sessionModel = default(SessionModel);
			Room currentRoom = sessionModel.CurrentRoom;
			DateTime? tournamentRoundTimer = SFSKammelnaRoomExtensions.GetTournamentRoundTimer(currentRoom);
			object obj13 = (??)tournamentRoundTimer & 1;
			object obj15;
			DateTime dateTime2;
			if (obj13 != null)
			{
				object obj14 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v17+E4]");
				bool flag4 = (nint)0 == 0;
				object obj16 = !flag4;
				DateTime dateTime = (DateTime)0;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					dateTime = (DateTime)0;
				}
				return dateTime2 >= dateTime;
			}
			return false;
			IL_05f3:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0368:
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v22+E4]");
			bool flag5 = (nint)0 == 0;
			DateTime dateTime3 = dateTime2;
			if (!flag5)
			{
				goto IL_039d;
			}
			goto IL_050c;
			IL_0094:
			obj9 = (nint)0 + (nint)2200;
			obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v45+E4]");
			bool flag6 = (nint)0 == 0;
			obj12 = obj9;
			obj5 = obj2;
			obj6 = obj4;
			if (!flag6)
			{
				goto IL_00e5;
			}
			goto IL_01f0;
			IL_01f0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			bool flag7 = (object)sessionModel2 == null;
			obj9 = obj12;
			obj2 = obj5;
			obj4 = obj6;
			if (!flag7)
			{
				goto IL_023e;
			}
			goto IL_05f3;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag8 = (object)sessionModel2 == null;
			object obj18 = !flag8;
			if (obj18 != null)
			{
				goto IL_023e;
			}
			goto IL_05f3;
			IL_023e:
			Room currentRoom2 = sessionModel2.CurrentRoom;
			TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom2);
			if (TournamentStatusExtensions.IsStarted(tournamentStatus))
			{
				return true;
			}
			TournamentData data = _data;
			if (_data != null)
			{
				obj15 = typeof(DataRelation) + 712;
				object obj19 = obj15;
				if (data.<IsCluster>k__BackingField)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v7+E4]");
					if ((nint)0 != 0)
					{
						DateTime now = DateTime.Now;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X20_v3+1C]");
						object obj20 = (nint)0 & (nint)1;
						bool flag9 = obj20 == null;
						dateTime2 = now;
						dateTime3 = now;
						if (!flag9)
						{
							goto IL_0368;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						DateTime now2 = DateTime.Now;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X20_v3+1C]");
						object obj21 = (nint)0 & (nint)1;
						bool flag10 = obj21 == null;
						object obj22 = !flag10;
						dateTime2 = now2;
						dateTime3 = now2;
						if (obj22 != null)
						{
							goto IL_0368;
						}
					}
					_ = 1;
					obj17 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v22+E4]");
					bool flag11 = (nint)0 == 0;
					object obj23 = !flag11;
					dateTime2 = dateTime3;
					if (obj23 != null)
					{
						goto IL_039d;
					}
					goto IL_050c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v7+E4]");
				bool flag12 = (nint)0 == 0;
				object obj24 = !flag12;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now3 = DateTime.Now;
				TournamentData data2 = _data;
				if (_data != null)
				{
					return now3 >= data2.<StartingTime>k__BackingField;
				}
			}
			goto IL_05f3;
			IL_050c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag13 = (object)sessionModel == null;
			dateTime2 = dateTime3;
			if (!flag13)
			{
				goto IL_054a;
			}
			goto IL_05f3;
			IL_039d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag14 = (object)sessionModel == null;
			object obj25 = !flag14;
			if (obj25 != null)
			{
				goto IL_054a;
			}
			goto IL_05f3;
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
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0218: Expected O, but got I
		//IL_0247: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EF5]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45BE]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45BE]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v7+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		goto IL_015a;
		IL_015a:
		object obj10 = typeof(SqlSingle[]) + 2376;
		object obj11 = (nint)0 + (nint)1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v3+20]");
		((OneShotEvent)0).CallWhenReady(action);
		Button button = helpBtn;
		object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj13 = (nint)0 + (nint)1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj13);
		object obj14 = typeof(SkeletonBinary.SkeletonInput) + 4032;
		object obj15 = (nint)0 + (nint)1640;
		button.m_OnClick.AddListener(unityAction);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentsEventsChannel.TournamentSeatChanged tournamentSeatChanged = default(TournamentsEventsChannel.TournamentSeatChanged);
		tournamentSeatChanged..ctor(this, (IntPtr)obj15);
		eventsChannel.OnTournamentSeatChanged += tournamentSeatChanged;
		return;
		IL_0082:
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v13+B8]");
		object obj17 = 0;
		obj9 = obj17;
		bool flag3 = obj17 == null;
		object obj18 = !flag3;
		if (obj18 == null)
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
		//IL_004d: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 4032;
		object obj2 = (nint)0 + (nint)1640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentsEventsChannel.TournamentSeatChanged tournamentSeatChanged = default(TournamentsEventsChannel.TournamentSeatChanged);
		tournamentSeatChanged..ctor(this, (IntPtr)obj2);
		eventsChannel.OnTournamentSeatChanged -= tournamentSeatChanged;
	}

	private void Init()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_0100: Expected O, but got I4
		//IL_00b1: Expected O, but got I4
		//IL_0058: Expected O, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_015c: Expected O, but got I
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0195: Expected I, but got O
		//IL_01cf: Expected O, but got I
		//IL_0280: Expected O, but got I4
		//IL_023d: Expected O, but got I4
		//IL_02b3: Expected O, but got I
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02ec: Expected I, but got O
		//IL_0326: Expected O, but got I
		//IL_03d7: Expected O, but got I4
		//IL_0394: Expected O, but got I4
		//IL_040a: Expected O, but got I
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_0443: Expected I, but got O
		//IL_047d: Expected O, but got I
		//IL_052e: Expected O, but got I4
		//IL_04eb: Expected O, but got I4
		//IL_0561: Expected O, but got I
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_059a: Expected I, but got O
		//IL_05f8: Expected O, but got I
		//IL_06a9: Expected O, but got I4
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Expected O, but got Unknown
		//IL_0abd: Expected O, but got I4
		//IL_0666: Expected O, but got I4
		//IL_0ad7: Expected O, but got I
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Expected O, but got Unknown
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Expected O, but got Unknown
		//IL_07af: Expected O, but got I
		//IL_07bf: Expected O, but got I
		//IL_07e1: Expected O, but got I4
		//IL_085a: Expected O, but got I
		//IL_0885: Expected O, but got I4
		//IL_0740: Expected O, but got I
		//IL_0750: Expected O, but got I
		//IL_0772: Expected O, but got I4
		//IL_0819: Expected O, but got I4
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected O, but got Unknown
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4b: Expected O, but got Unknown
		//IL_0b61: Expected O, but got I
		//IL_0b72: Expected I, but got O
		//IL_0b90: Expected O, but got I
		//IL_0996: Expected O, but got I
		//IL_09b0: Expected O, but got I4
		//IL_0849: Expected O, but got I
		//IL_08ea: Expected O, but got I
		//IL_0a26: Expected O, but got I
		//IL_09ee: Expected O, but got I4
		//IL_094c: Expected O, but got I
		UpdateInfo();
		InitializeTournamentPanel();
		GameObject go = base.gameObject;
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v136+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008d;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v136+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_008d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj3 = obj5;
		goto IL_013c;
		IL_0907:
		object obj8;
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X0_v63+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = obj7;
		if (!flag3)
		{
			goto IL_093c;
		}
		goto IL_0a04;
		IL_0555:
		object obj10 = (nint)0 + (nint)1672;
		object varName = "rightCtrl" + 640;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj10);
		GameObject go2;
		VariableBinderExtensions.Bind(go2, currentRoom, (string)varName, action);
		SetupUi();
		if (IsStarted)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
			object obj11 = (nint)0 & (nint)1;
			if (obj11 != null)
			{
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v76+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0642;
				}
			}
			else
			{
				_ = 1;
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v76+E4]");
				bool flag4 = (nint)0 == 0;
				object obj13 = !flag4;
				if (obj13 != null)
				{
					goto IL_0642;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			goto IL_06d0;
		}
		goto IL_0a63;
		IL_04c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj14 = !flag5;
		if (obj14 != null)
		{
			goto IL_0555;
		}
		goto IL_0b15;
		IL_008d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		bool flag6 = (object)sessionModel2 == null;
		object obj15 = !flag6;
		if (obj15 != null)
		{
			goto IL_013c;
		}
		goto IL_0b15;
		IL_013c:
		object obj16 = typeof(SqlSingle[]) + 2376;
		object obj17 = (nint)0 + (nint)1656;
		object varName2 = "https://www.kammelna.com/Home/Terms" + 136;
		Room currentRoom2 = sessionModel2.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj17);
		VariableBinderExtensions.Bind(go, currentRoom2, (string)varName2, action2);
		GameObject go3 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
		object obj18 = (nint)0 & (nint)1;
		if (obj18 != null)
		{
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v121+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0219;
			}
		}
		else
		{
			_ = 1;
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v121+E4]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			if (obj20 != null)
			{
				goto IL_0219;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_02a7;
		IL_084e:
		object obj21 = (nint)0 + (nint)2680;
		List<MatchData> tournamentMatches;
		Func<object, bool> predicate;
		bool flag8 = Enumerable.Any(tournamentMatches, predicate);
		bool flag9 = !flag8;
		object obj22 = !flag9;
		if (obj22 == null)
		{
			obj8 = typeof(RegisteredWaitHandle) + 3136;
			object obj23 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X0_v53+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45BF]");
				object obj24 = (nint)0 & (nint)1;
				if (obj24 != null)
				{
					goto IL_0907;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45BF]");
				object obj25 = (nint)0 & (nint)1;
				bool flag10 = obj25 == null;
				object obj26 = !flag10;
				if (obj26 != null)
				{
					goto IL_0907;
				}
			}
			_ = 1;
			obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X0_v63+E4]");
			bool flag11 = (nint)0 == 0;
			object obj27 = !flag11;
			obj9 = obj7;
			if (obj27 != null)
			{
				goto IL_093c;
			}
			goto IL_0a04;
		}
		goto IL_0a4e;
		IL_093c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X0_v63+B8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v33+14]");
		if ((nint)0 == 4)
		{
			goto IL_0a4e;
		}
		goto IL_0a63;
		IL_0b15:
		throw new NullReferenceException();
		IL_0219:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		bool flag12 = (object)sessionModel3 == null;
		object obj29 = !flag12;
		if (obj29 != null)
		{
			goto IL_02a7;
		}
		goto IL_0b15;
		IL_02a7:
		object obj30 = (nint)0 + (nint)1664;
		object varName3 = "java.io.FileOutputStream" + 3672;
		Room currentRoom3 = sessionModel3.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj30);
		VariableBinderExtensions.Bind(go3, currentRoom3, (string)varName3, action3);
		GameObject go4 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
		object obj31 = (nint)0 & (nint)1;
		if (obj31 != null)
		{
			object obj32 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v106+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0370;
			}
		}
		else
		{
			_ = 1;
			object obj32 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v106+E4]");
			bool flag13 = (nint)0 == 0;
			object obj33 = !flag13;
			if (obj33 != null)
			{
				goto IL_0370;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_03fe;
		IL_0a4e:
		treeTab.isOn = true;
		goto IL_0a63;
		IL_06d0:
		SessionModel sessionModel4 = default(SessionModel);
		Room currentRoom4 = sessionModel4.CurrentRoom;
		tournamentMatches = SFSKammelnaRoomExtensions.GetTournamentMatches(currentRoom4);
		object obj34 = typeof(SkeletonBinary.SkeletonInput) + 3952;
		object obj35 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X0_v66+E4]");
		object obj36;
		Action action4;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X0_v66+B8]");
			obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v39+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v39+8]");
			bool flag14 = (nint)0 == 0;
			object obj37 = !flag14;
			action4 = action;
			if (obj37 == null)
			{
				goto IL_07f7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X0_v66+B8]");
			obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v39+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v39+8]");
			bool flag15 = (nint)0 == 0;
			object obj38 = !flag15;
			action4 = action;
			if (obj38 == null)
			{
				goto IL_07f7;
			}
		}
		goto IL_084e;
		IL_0642:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag16 = (object)sessionModel4 == null;
		object obj39 = !flag16;
		if (obj39 != null)
		{
			goto IL_06d0;
		}
		goto IL_0b15;
		IL_0370:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel5 = default(SessionModel);
		bool flag17 = (object)sessionModel5 == null;
		object obj40 = !flag17;
		if (obj40 != null)
		{
			goto IL_03fe;
		}
		goto IL_0b15;
		IL_03fe:
		object obj41 = (nint)0 + (nint)1648;
		object varName4 = "startPosition" + 104;
		Room currentRoom5 = sessionModel5.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj41);
		VariableBinderExtensions.Bind(go4, currentRoom5, (string)varName4, action5);
		go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
		object obj42 = (nint)0 & (nint)1;
		if (obj42 != null)
		{
			object obj43 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v91+E4]");
			if ((nint)0 != 0)
			{
				goto IL_04c7;
			}
		}
		else
		{
			_ = 1;
			object obj43 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v91+E4]");
			bool flag18 = (nint)0 == 0;
			object obj44 = !flag18;
			if (obj44 != null)
			{
				goto IL_04c7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0555;
		IL_0a04:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj45 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v56+B8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X8_v26+14]");
		if ((nint)0 == 4)
		{
			goto IL_0a4e;
		}
		goto IL_0a63;
		IL_07f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X0_v66+E4]");
		bool flag19 = (nint)0 == 0;
		object obj47 = !flag19;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj48 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v45+B8]");
			obj36 = 0;
		}
		object obj49 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj50 = (nint)0 + (nint)440;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj36, (IntPtr)obj50);
		object obj51 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v44+B8]");
		object obj52 = (nint)0 + (nint)8;
		obj52 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action4 = null;
		predicate = func;
		goto IL_084e;
		IL_0a63:
		IThemeColorProfile theme = tournamentSprites.GetTheme(_data);
		ThemeProvider[] array = themeProviders;
		if (array.Length >= 1)
		{
			object obj53 = array + 32;
			object obj54 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X23_v6+v224 @ X22_v10*8]");
				((ThemeProvider)0).UpdateTheme(theme);
				obj54++;
			}
			while ((nint)obj54 < array.Length);
		}
		background.SetupBackground(_data);
	}

	private void SetupTheme()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		IThemeColorProfile theme = tournamentSprites.GetTheme(_data);
		ThemeProvider[] array = themeProviders;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X22_v4+v24 @ X21_v5*8]");
				((ThemeProvider)0).UpdateTheme(theme);
			}
			while ((nint)obj2 < array.Length);
		}
	}

	private void InitializeTournamentPanel()
	{
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected O, but got Unknown
		//IL_054d: Expected O, but got I
		//IL_0036: Expected I, but got O
		//IL_003f: Expected O, but got I4
		//IL_04e5: Expected O, but got I4
		//IL_04ee: Expected O, but got I4
		//IL_036f: Expected I, but got O
		//IL_061a: Expected O, but got I4
		//IL_046d: Expected O, but got I4
		//IL_0476: Expected O, but got I4
		//IL_049a: Expected O, but got I4
		//IL_0073: Expected I, but got O
		//IL_0637: Expected I, but got O
		//IL_0382: Expected I, but got O
		//IL_038b: Expected O, but got I4
		//IL_04c8: Expected O, but got I4
		//IL_03c1: Expected I, but got O
		//IL_03ca: Expected O, but got I4
		//IL_03ee: Expected O, but got I4
		//IL_062d: Expected I, but got O
		//IL_04ba: Expected O, but got I4
		//IL_041c: Expected O, but got I4
		//IL_0310: Expected I, but got O
		//IL_00a7: Expected I, but got O
		//IL_060a: Expected I, but got O
		//IL_040e: Expected O, but got I4
		//IL_0323: Expected I, but got O
		//IL_032c: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I
		//IL_00ec: Expected I, but got O
		//IL_0116: Expected O, but got I4
		//IL_059f: Expected O, but got I4
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected O, but got Unknown
		//IL_05c9: Expected O, but got I
		//IL_01c6: Expected O, but got I
		//IL_01f0: Expected O, but got I4
		//IL_0198: Expected O, but got I4
		//IL_013f: Expected O, but got I
		//IL_026a: Expected O, but got I4
		//IL_026f: Expected I, but got O
		//IL_01af: Expected O, but got I4
		//IL_0237: Expected O, but got I4
		TournamentData data = _data;
		SessionModel sessionModel = default(SessionModel);
		object obj19;
		nint num;
		if (_data != null)
		{
			SportTeamsCelebrationTournamentAddon tournamentAddonsSportTeamsCelebration = _data.TournamentAddonsSportTeamsCelebration;
			if (tournamentAddonsSportTeamsCelebration != null)
			{
				num = unchecked((nint)null);
				object obj = 152;
			}
			else if (data.<Type>k__BackingField > TournamentType.Private)
			{
				if (data.<Type>k__BackingField != TournamentType.Mass)
				{
					if (data.<Type>k__BackingField != TournamentType.Official)
					{
						bool flag = data.<Type>k__BackingField != TournamentType.OfficialMonthly;
						num = unchecked((nint)null);
						if (flag)
						{
							goto IL_050b;
						}
						num = unchecked((nint)null);
						object obj = 120;
					}
					else
					{
						bool flag2 = !data.<IsCluster>k__BackingField;
						object obj2 = !flag2;
						object obj3 = ~obj2;
						if (obj3 == null)
						{
							object obj = 136;
						}
						else
						{
							object obj = 112;
						}
						num = unchecked((nint)null);
					}
				}
				else if (_data.IsMassFinal)
				{
					num = unchecked((nint)null);
					object obj = 176;
				}
				else
				{
					bool flag3 = !data.<IsCluster>k__BackingField;
					object obj4 = !flag3;
					object obj5 = ~obj4;
					if (obj5 == null)
					{
						object obj = 184;
					}
					else
					{
						object obj = 168;
					}
					num = unchecked((nint)null);
				}
			}
			else if (data.<Type>k__BackingField != TournamentType.Public)
			{
				bool flag4 = data.<Type>k__BackingField != TournamentType.Private;
				num = unchecked((nint)null);
				if (flag4)
				{
					goto IL_050b;
				}
				num = unchecked((nint)null);
				object obj = 104;
			}
			else
			{
				ChampionshipTournamentAddon tournamentAddonsChampionship = _data.TournamentAddonsChampionship;
				bool flag5;
				object obj6;
				if (data.<IsCluster>k__BackingField)
				{
					flag5 = tournamentAddonsChampionship == null;
					obj6 = 128;
					object obj = 160;
				}
				else
				{
					flag5 = tournamentAddonsChampionship == null;
					obj6 = 96;
					object obj = 144;
				}
				object obj7 = !flag5;
				if (obj7 == null)
				{
					object obj = obj6;
				}
				num = unchecked((nint)null);
			}
			if ((object)helpBtn != null)
			{
				GameObject gameObject = helpBtn.gameObject;
				TournamentData data2 = _data;
				bool flag6 = _data == null;
				num = unchecked((nint)null);
				if (!flag6)
				{
					bool active = TournamentTypeExtensions.IsOfficialMonthly(data2.<Type>k__BackingField);
					bool flag7 = (object)gameObject == null;
					num = unchecked((nint)null);
					if (!flag7)
					{
						object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
						object obj9 = (nint)0 + (nint)1072;
						gameObject.SetActive(active);
						num = (nint)stripParent;
						object obj10 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v22+E4]");
						bool flag8 = (nint)0 == 0;
						object obj11 = !flag8;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
						object obj12 = 152989696;
						object obj13 = typeof(Queue<string>) + 848;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
						object obj14 = (nint)0 & (nint)1;
						if (obj14 != null)
						{
							object obj15 = (nint)0 + (nint)2200;
							object obj16 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v29+E4]");
							bool flag9 = (nint)0 == 0;
							object obj17 = obj15;
							if (!flag9)
							{
								goto IL_0174;
							}
						}
						else
						{
							_ = 1;
							object obj15 = (nint)0 + (nint)2200;
							object obj16 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v29+E4]");
							bool flag10 = (nint)0 == 0;
							object obj18 = !flag10;
							object obj17 = obj15;
							if (obj18 != null)
							{
								goto IL_0174;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
						bool flag11 = (object)sessionModel == null;
						obj19 = 0;
						if (!flag11)
						{
							goto IL_0245;
						}
					}
				}
			}
			goto IL_0500;
		}
		goto IL_050b;
		IL_0174:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag12 = (object)sessionModel == null;
		object obj20 = !flag12;
		if (obj20 != null)
		{
			goto IL_0245;
		}
		obj19 = 0;
		goto IL_0500;
		IL_0500:
		throw new NullReferenceException();
		IL_0245:
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentStrip tournamentStrip = default(TournamentStrip);
		bool flag13 = (object)tournamentStrip == null;
		obj19 = 0;
		num = unchecked((nint)null);
		if (!flag13)
		{
			tournamentStrip.Initialize(currentRoom);
			return;
		}
		goto IL_0500;
		IL_050b:
		object obj21 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		ex..ctor();
		object obj22 = (nint)0 + (nint)1632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	private void UpdateTeamsTab()
	{
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_029b: Expected O, but got I4
		//IL_02a4: Expected O, but got I4
		//IL_0134: Expected O, but got I
		//IL_008b: Expected O, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I4
		//IL_02cc: Expected O, but got I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		TournamentData data = _data;
		object obj2;
		int? num2;
		int? num3;
		object obj6 = default(object);
		if (TournamentTypeExtensions.IsPrivate(data.<Type>k__BackingField))
		{
			TournamentData data2 = _data;
			PlayerInfo <Creator>k__BackingField = data2.<Creator>k__BackingField;
			if (data2.<Creator>k__BackingField != null)
			{
				int <DBID>k__BackingField = <Creator>k__BackingField.<DBID>k__BackingField;
				object obj = (nint)0 + (nint)3136;
				obj2 = obj;
				int? num = <Creator>k__BackingField.<DBID>k__BackingField;
				object obj3 = typeof(Queue<string>) + 848;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v26+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				num2 = num;
				obj6 = obj;
				num3 = num;
				if (obj5 == null)
				{
					goto IL_0109;
				}
			}
			else
			{
				object obj7 = typeof(Queue<string>) + 848;
				object obj4 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v26+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				num3 = (int?)(object)0;
				if (obj8 == null)
				{
					obj2 = obj6;
					int <DBID>k__BackingField = 0;
					num2 = (int?)(object)0;
					goto IL_0109;
				}
			}
			goto IL_0128;
		}
		SetTabVisibility(isVisible: false, teamsTab, treeTab);
		return;
		IL_0109:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj2;
		num3 = num2;
		goto IL_0128;
		IL_0128:
		object obj9 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj10 = (object?)num3 >> 32;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		object obj11 = intDbId - obj10;
		bool flag3 = obj11 == null;
		TournamentData data3 = _data;
		object obj12 = flag3 & (??)num3;
		object obj13 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v16+E4]");
		if ((nint)0 != 0)
		{
			bool flag4 = SfsTournamentConnector.IsParticipating(data3.<RoomId>k__BackingField);
			object obj15 = obj12 | flag4;
			if ((nint)obj15 == 1)
			{
				goto IL_0229;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = SfsTournamentConnector.IsParticipating(data3.<RoomId>k__BackingField);
			object obj16 = obj12 | flag5;
			if ((nint)obj16 == 1)
			{
				goto IL_0229;
			}
		}
		bool isVisible = false;
		goto IL_033a;
		IL_033a:
		SetTabVisibility(isVisible, teamsTab, treeTab);
		return;
		IL_0229:
		bool isStarted = IsStarted;
		isVisible = (byte)((isStarted ? 1u : 0u) ^ 1u) != 0;
		goto IL_033a;
	}

	private void UpdateSubTournamentsTab()
	{
		//IL_0046: Expected O, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
		TournamentData data = _data;
		SetTabVisibility(data.<IsCluster>k__BackingField, sunTournamentsTab, treeTab);
		TournamentData data2 = _data;
		object obj = ~(data2.<IsCluster>k__BackingField ? 1 : 0);
		bool isVisible = (byte)(1 & obj) != 0;
		SetTabVisibility(isVisible, treeTab, sunTournamentsTab);
	}

	private void SetupUi()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01c0: Expected O, but got I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected I4, but got Unknown
		//IL_01f9: Expected O, but got I
		//IL_02ce: Expected O, but got I4
		//IL_030f: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v32+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v32+E4]");
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
		IL_0243:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0252;
		IL_0252:
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom);
		if (TournamentStatusExtensions.IsFinished(tournamentStatus))
		{
			CancelInvoke();
		}
		return;
		IL_031d:
		throw new NullReferenceException();
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		bool flag3 = (object)sessionModel2 == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_0140;
		}
		goto IL_031d;
		IL_0140:
		Room currentRoom2 = sessionModel2.CurrentRoom;
		List<MatchData> tournamentMatches = SFSKammelnaRoomExtensions.GetTournamentMatches(currentRoom2);
		UpdateLeaveWarning(tournamentMatches);
		UpdateBackButton();
		UpdateTeamsTab();
		TournamentData data = _data;
		SetTabVisibility(data.<IsCluster>k__BackingField, sunTournamentsTab, treeTab);
		TournamentData data2 = _data;
		object obj9 = ~(data2.<IsCluster>k__BackingField ? 1 : 0);
		bool isVisible = (byte)(1 & obj9) != 0;
		SetTabVisibility(isVisible, treeTab, sunTournamentsTab);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
		object obj10 = (nint)0 & (nint)1;
		if (obj10 != null)
		{
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0243;
			}
		}
		else
		{
			_ = 1;
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 != null)
			{
				goto IL_0243;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj13 = !flag5;
		if (obj13 != null)
		{
			goto IL_0252;
		}
		goto IL_031d;
	}

	private void UpdateBackButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I
		//IL_014c: Expected O, but got I
		//IL_0176: Expected O, but got I4
		//IL_0127: Expected O, but got I4
		//IL_00ce: Expected O, but got I
		//IL_01f5: Expected O, but got I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected I4, but got Unknown
		//IL_0244: Expected O, but got I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		TournamentData data = _data;
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = SfsTournamentConnector.IsParticipating(data.<RoomId>k__BackingField);
		object obj4 = 152989696;
		object obj5 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
		object obj6 = (nint)0 & (nint)1;
		if (obj6 != null)
		{
			object obj7 = (nint)0 + (nint)2200;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = obj7;
			if (!flag3)
			{
				goto IL_0103;
			}
		}
		else
		{
			_ = 1;
			object obj7 = (nint)0 + (nint)2200;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v19+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			object obj9 = obj7;
			if (obj10 != null)
			{
				goto IL_0103;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_01a5;
		IL_0103:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag5 = (object)sessionModel == null;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01a5;
		IL_01a5:
		Room currentRoom = sessionModel.CurrentRoom;
		bool flag6 = SFSKammelnaRoomExtensions.IsFinalCountdown(currentRoom);
		bool isStarted = IsStarted;
		GameObject gameObject = backButtonToggler.gameObject;
		object obj12 = (isStarted ? 1 : 0) ^ 1;
		object obj13 = flag2 & obj12;
		object obj14 = obj13 & flag6;
		bool flag7 = (byte)(obj14 ^ 1) != 0;
		gameObject.SetActive(flag7);
		bool flag8 = !flag7;
		object obj15 = !flag8;
		if (obj15 == null)
		{
			object obj16 = typeof(RegisteredWaitHandle) + 3136;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				ScreenManager.PreventLoadingPreviousScene();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ScreenManager.PreventLoadingPreviousScene();
		}
	}

	private void UpdateRoundTimer()
	{
		//IL_000e: Expected O, but got I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0038: Expected O, but got I
		//IL_00df: Expected O, but got I
		//IL_0109: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_0061: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_0325: Expected O, but got I4
		//IL_03a9: Expected O, but got I4
		//IL_022c: Expected I, but got O
		//IL_0587: Expected O, but got I
		//IL_05b9: Expected O, but got I4
		//IL_05d1: Expected O, but got I
		//IL_0366: Expected O, but got I4
		//IL_036b: Expected I, but got O
		//IL_03e8: Expected O, but got I
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0297: Expected I, but got O
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_0472: Expected O, but got I4
		//IL_02c7: Expected O, but got I4
		//IL_02d8: Expected O, but got I4
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_04ec: Expected O, but got I4
		//IL_02eb: Expected I, but got O
		//IL_02f0: Expected I, but got O
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected O, but got Unknown
		if (!IsStarted)
		{
			return;
		}
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v57+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0096;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v57+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0096;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj4 = obj6;
		if (!flag3)
		{
			goto IL_015d;
		}
		goto IL_0379;
		IL_0379:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0387;
		IL_03ed:
		DateTime now = DateTime.Now;
		DateTime dateTime;
		object obj9;
		if (dateTime > now)
		{
			object methodName = "SetRoomVariables request error" + 600;
			Invoke((string)methodName, 3f);
			object obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now2 = DateTime.Now;
			TimeSpan timeSpan = dateTime - now2;
			object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v19+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan2 = default(TimeSpan);
			double totalSeconds = timeSpan2.TotalSeconds;
			object methodName2 = "SetRoomVariables request error" + 608;
			float time = (float)totalSeconds + 3f;
			Invoke((string)methodName2, time);
			return;
		}
		goto IL_054d;
		IL_023a:
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom = sessionModel2.CurrentRoom;
		DateTime? tournamentRoundTimer = SFSKammelnaRoomExtensions.GetTournamentRoundTimer(currentRoom);
		obj2 = typeof(DataRelation) + 712;
		ex = (NullReferenceException)obj2;
		object obj14 = (??)tournamentRoundTimer & 1;
		bool flag6 = obj14 == null;
		nint num = unchecked((nint)null);
		if (flag6)
		{
			goto IL_0387;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v25 (System.NullReferenceException)+E4]");
		bool flag7 = (nint)0 == 0;
		object obj15 = !flag7;
		obj9 = obj2;
		dateTime = (DateTime)0;
		nint num2;
		if (obj15 == null)
		{
			num = unchecked((nint)null);
			num2 = unchecked((nint)null);
			goto IL_03ce;
		}
		goto IL_03ed;
		IL_020e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag8 = (object)sessionModel2 == null;
		num = unchecked((nint)null);
		if (!flag8)
		{
			goto IL_023a;
		}
		goto IL_0379;
		IL_0096:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag9 = (object)sessionModel == null;
		object obj16 = !flag9;
		if (obj16 != null)
		{
			goto IL_015d;
		}
		goto IL_0379;
		IL_015d:
		Room currentRoom2 = sessionModel.CurrentRoom;
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom2);
		if (TournamentStatusExtensions.IsFinished(tournamentStatus))
		{
			CancelInvoke();
			goto IL_054d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
		object obj17 = (nint)0 & (nint)1;
		if (obj17 != null)
		{
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v37+E4]");
			if ((nint)0 != 0)
			{
				goto IL_020e;
			}
		}
		else
		{
			_ = 1;
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v37+E4]");
			bool flag10 = (nint)0 == 0;
			object obj19 = !flag10;
			if (obj19 != null)
			{
				goto IL_020e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag11 = (object)sessionModel2 == null;
		object obj20 = !flag11;
		num = unchecked((nint)null);
		if (obj20 != null)
		{
			goto IL_023a;
		}
		goto IL_0379;
		IL_03ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj9 = obj2;
		dateTime = (DateTime)num2;
		goto IL_03ed;
		IL_054d:
		SetupUi();
		return;
		IL_0387:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v25 (System.NullReferenceException)+E4]");
		bool flag12 = (nint)0 == 0;
		object obj21 = !flag12;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ex = (NullReferenceException)obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v25 (System.NullReferenceException)+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v18+10]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v25 (System.NullReferenceException)+E4]");
		bool flag13 = (nint)0 == 0;
		object obj23 = !flag13;
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v18+10]");
		dateTime = (DateTime)0;
		if (obj23 == null)
		{
			goto IL_03ce;
		}
		goto IL_03ed;
	}

	private void UpdateInfo()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_0177: Expected O, but got I
		//IL_0228: Expected O, but got I4
		//IL_01e5: Expected O, but got I4
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_030a: Expected O, but got I
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02e9: Expected O, but got I
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v33+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v33+E4]");
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
		IL_024f:
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		if (SFSKammelnaRoomExtensions.IsTournamentHub(currentRoom))
		{
			object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v9+B8]");
			object obj9 = 0;
			object obj10 = obj9;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ X8_v11+188] (should have been resolved before IL gen)");
			object obj12 = this + 224;
			object obj13 = default(object);
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X19_v4-B0]");
			((TournamentName)0).Initialize((TournamentData)obj12);
		}
		return;
		IL_02eb:
		throw new NullReferenceException();
		IL_01c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj14 = !flag3;
		if (obj14 != null)
		{
			goto IL_024f;
		}
		goto IL_02eb;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		bool flag4 = (object)sessionModel2 == null;
		object obj15 = !flag4;
		if (obj15 != null)
		{
			goto IL_0137;
		}
		goto IL_02eb;
		IL_0137:
		Room currentRoom2 = sessionModel2.CurrentRoom;
		if (currentRoom2 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
		object obj16 = (nint)0 & (nint)1;
		if (obj16 != null)
		{
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v18+E4]");
			if ((nint)0 != 0)
			{
				goto IL_01c1;
			}
		}
		else
		{
			_ = 1;
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj18 = !flag5;
			if (obj18 != null)
			{
				goto IL_01c1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_024f;
	}

	private void OnSeatChanged(int roomId, int seat)
	{
		TournamentData data = _data;
		if (_data != null && data.<RoomId>k__BackingField == roomId && !IsStarted)
		{
			SetupUi();
		}
	}

	private void OnStatusChanged()
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
		//IL_00f0: Expected O, but got I4
		//IL_01ff: Expected O, but got I8
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02d0: Expected O, but got I4
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7022]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
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
			obj3 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
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
		object obj8 = (nint)0 + (nint)2200;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj11 = obj8;
		if (obj10 != null)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_01ce:
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom);
		object obj12 = (long)tournamentStatus & 0xFFFFFFFEL;
		if ((nint)obj12 == 2)
		{
			leaveTournamentRoomWarning.CancelLeaveWarning();
			TournamentPopupUtil.ShowTournamentCancelled();
		}
		else if (tournamentStatus == TournamentStatus.Finished)
		{
			TournamentData data = _data;
			if (data.<Type>k__BackingField == TournamentType.OfficialMonthly)
			{
				object obj13 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v6+E4]");
				bool flag4 = (nint)0 == 0;
				object obj15 = !flag4;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerProfilesHandler.ResetModels();
				SetupUi();
				return;
			}
		}
		SetupUi();
		return;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01ce;
		IL_01b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_01ce;
		IL_008b:
		obj8 = (nint)0 + (nint)2200;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v15+E4]");
		bool flag6 = (nint)0 == 0;
		obj11 = obj8;
		if (!flag6)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
	}

	private void UpdateMatches()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00dc: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_014f: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
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
		Room currentRoom = sessionModel.CurrentRoom;
		List<MatchData> tournamentMatches = SFSKammelnaRoomExtensions.GetTournamentMatches(currentRoom);
		UpdateLeaveWarning(tournamentMatches);
	}

	private void UpdateLeaveWarning(List<MatchData> matches)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I
		//IL_00e8: Expected O, but got I
		//IL_00f8: Expected O, but got I
		//IL_011a: Expected O, but got I4
		//IL_005d: Expected O, but got I
		//IL_006d: Expected O, but got I
		//IL_007d: Expected O, but got I
		//IL_009f: Expected O, but got I4
		//IL_027f: Expected O, but got I
		//IL_028f: Expected O, but got I
		//IL_029f: Expected O, but got I
		//IL_02c1: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_01d1: Expected O, but got I
		//IL_01e1: Expected O, but got I
		//IL_01f1: Expected O, but got I
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected O, but got Unknown
		//IL_065b: Expected O, but got I
		//IL_066c: Expected I, but got O
		//IL_068a: Expected O, but got I
		//IL_06a5: Expected O, but got I4
		//IL_02f9: Expected O, but got I4
		//IL_0182: Expected O, but got I
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected O, but got Unknown
		//IL_06e4: Expected O, but got I
		//IL_06f5: Expected I, but got O
		//IL_0713: Expected O, but got I
		//IL_0361: Expected O, but got I4
		//IL_036a: Expected O, but got I4
		//IL_0329: Expected O, but got I
		//IL_03bd: Expected O, but got I4
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_03e7: Expected O, but got I
		//IL_048e: Expected O, but got I
		//IL_04b8: Expected O, but got I4
		//IL_0469: Expected O, but got I4
		//IL_0410: Expected O, but got I
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_060b: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3952;
		leaveTournamentRoomWarning.CancelLeaveWarning();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v56+E4]");
		object obj4;
		Func<object, bool> predicate;
		object obj6;
		object obj3;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)3592;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v56+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v36+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v36+10]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				obj6 = obj3;
				goto IL_0130;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj6 = (nint)0 + (nint)3592;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v56+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v36+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v36+10]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj3 = obj6;
			if (obj7 == null)
			{
				goto IL_0130;
			}
		}
		goto IL_0187;
		IL_0380:
		TournamentData data = _data;
		if (data.<IsInstant>k__BackingField)
		{
			object obj8 = 152989696;
			object obj9 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
			object obj10 = (nint)0 & (nint)1;
			if (obj10 != null)
			{
				object obj11 = (nint)0 + (nint)2200;
				object obj12 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v26+E4]");
				bool flag3 = (nint)0 == 0;
				object obj13 = obj11;
				if (!flag3)
				{
					goto IL_0445;
				}
			}
			else
			{
				_ = 1;
				object obj11 = (nint)0 + (nint)2200;
				object obj12 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v26+E4]");
				bool flag4 = (nint)0 == 0;
				object obj14 = !flag4;
				object obj13 = obj11;
				if (obj14 != null)
				{
					goto IL_0445;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			goto IL_04e7;
		}
		goto IL_0619;
		IL_0445:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag5 = (object)sessionModel == null;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_04e7;
		IL_04e7:
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom);
		if (TournamentStatusExtensions.IsScheduled(tournamentStatus))
		{
			TournamentData data2 = _data;
			object obj16 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v17+E4]");
			if ((nint)0 != 0)
			{
				if (SfsTournamentConnector.IsParticipating(data2.<RoomId>k__BackingField))
				{
					goto IL_05a7;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = SfsTournamentConnector.IsParticipating(data2.<RoomId>k__BackingField);
				bool flag7 = !flag6;
				object obj18 = !flag7;
				if (obj18 != null)
				{
					goto IL_05a7;
				}
			}
		}
		goto IL_0619;
		IL_0130:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v56+E4]");
		bool flag8 = (nint)0 == 0;
		object obj19 = !flag8;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v42+B8]");
			obj4 = 0;
		}
		object obj21 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)472;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj4, (IntPtr)obj22);
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v41+B8]");
		object obj24 = (nint)0 + (nint)16;
		obj24 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj25 = 0;
		obj3 = obj6;
		predicate = func;
		goto IL_0187;
		IL_021e:
		object obj27;
		object obj26 = obj27;
		IEnumerable<object> source;
		Func<object, bool> func2;
		bool flag9 = Enumerable.Any(source, func2);
		bool flag10 = !flag9;
		Func<object, bool> func3 = func2;
		if (flag10)
		{
			goto IL_0380;
		}
		goto IL_05a7;
		IL_0619:
		backButtonToggler.ToggleManual(isON: false);
		return;
		IL_0187:
		source = Enumerable.Where(matches, predicate);
		object obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v41+E4]");
		object obj29;
		object obj30;
		if ((nint)0 != 0)
		{
			obj27 = (nint)0 + (nint)2680;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v41+B8]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v24+18]");
			func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v24+18]");
			bool flag11 = (nint)0 == 0;
			obj30 = obj27;
			if (!flag11)
			{
				goto IL_021e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = obj;
			obj27 = (nint)0 + (nint)2680;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v41+B8]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v24+18]");
			func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v24+18]");
			bool flag12 = (nint)0 == 0;
			object obj31 = !flag12;
			obj30 = obj27;
			if (obj31 != null)
			{
				goto IL_021e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v41+E4]");
		bool flag13 = (nint)0 == 0;
		object obj32 = !flag13;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj33 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v30+B8]");
			obj29 = 0;
		}
		object obj34 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj35 = (nint)0 + (nint)480;
		Func<object, bool> func4 = default(Func<object, bool>);
		func4..ctor(obj29, (IntPtr)obj35);
		object obj36 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v29+B8]");
		object obj37 = (nint)0 + (nint)24;
		obj37 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj26 = obj30;
		bool flag14 = Enumerable.Any(source, func4);
		bool flag15 = !flag14;
		object obj38 = !flag15;
		obj25 = 0;
		func3 = func4;
		if (obj38 == null)
		{
			goto IL_0380;
		}
		goto IL_05a7;
		IL_05a7:
		leaveTournamentRoomWarning.Init(_data, eventsChannel);
		backButtonToggler.ToggleManual(isON: true);
	}

	private void ShowRoundMessage()
	{
		//IL_0016: Expected O, but got I
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_014c: Expected O, but got I
		//IL_0166: Expected O, but got I4
		//IL_016f: Expected O, but got I4
		//IL_0180: Expected O, but got I4
		//IL_00a0: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0075: Expected O, but got I4
		//IL_0086: Expected O, but got I4
		//IL_01a0: Expected O, but got I
		//IL_01ca: Expected O, but got I4
		//IL_0109: Expected O, but got I4
		//IL_0266: Expected O, but got I
		//IL_0317: Expected O, but got I4
		//IL_02d4: Expected O, but got I4
		//IL_0396: Expected O, but got I
		//IL_0447: Expected O, but got I4
		//IL_0404: Expected O, but got I4
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_0555: Expected O, but got I
		//IL_0565: Expected O, but got I
		//IL_0587: Expected O, but got I4
		//IL_0597: Expected O, but got I
		//IL_04de: Expected O, but got I
		//IL_04ee: Expected O, but got I
		//IL_0510: Expected O, but got I4
		//IL_0620: Expected O, but got I4
		//IL_062e: Expected I4, but got O
		//IL_063a: Expected O, but got I
		//IL_05c7: Expected O, but got I4
		//IL_070f: Expected O, but got I
		//IL_071f: Expected O, but got I
		//IL_0741: Expected O, but got I4
		//IL_0761: Expected O, but got I
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected O, but got Unknown
		//IL_08ba: Expected O, but got I
		//IL_08cb: Expected I, but got O
		//IL_08e9: Expected O, but got I
		//IL_052e: Expected O, but got I
		//IL_090c: Expected O, but got I
		//IL_0688: Expected O, but got I
		//IL_0698: Expected O, but got I
		//IL_06ba: Expected O, but got I4
		//IL_05f7: Expected O, but got I
		//IL_07e9: Expected O, but got I4
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Expected O, but got Unknown
		//IL_0827: Expected O, but got I4
		//IL_0791: Expected O, but got I4
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected O, but got Unknown
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cc: Expected O, but got Unknown
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d9: Expected O, but got Unknown
		//IL_09f3: Expected O, but got I4
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected O, but got Unknown
		//IL_0956: Expected O, but got I
		//IL_0967: Expected I, but got O
		//IL_0985: Expected O, but got I
		//IL_06e8: Expected O, but got I
		//IL_07c1: Expected O, but got I
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Expected O, but got Unknown
		//IL_0a33: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7024]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj5;
		object obj6;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = 152989696;
			obj5 = obj2;
			obj6 = 152989696;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			obj4 = 152989696;
			obj5 = obj2;
			obj6 = 152989696;
			if (obj8 != null)
			{
				goto IL_0094;
			}
		}
		_ = 1;
		object obj9 = (nint)0 + (nint)2200;
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v79+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		obj2 = obj5;
		obj4 = obj6;
		object obj12 = obj9;
		if (obj11 != null)
		{
			goto IL_00e5;
		}
		goto IL_01f0;
		IL_05a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v39+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		object obj15;
		object obj16;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v53+B8]");
			obj16 = 0;
		}
		object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)448;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj16, (IntPtr)obj18);
		object obj19 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v52+B8]");
		object obj20 = (nint)0 + (nint)32;
		obj20 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Func<object, bool> predicate = func;
		goto IL_086f;
		IL_0900:
		object obj21 = (nint)0 + (nint)1920;
		IEnumerable<object> source;
		Func<object, bool> predicate2;
		bool flag5 = Enumerable.All(source, predicate2);
		TournamentData data = _data;
		bool flag6;
		object obj22 = (flag6 ? 1 : 0) ^ 1;
		object obj23 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v26+E4]");
		bool flag7 = (nint)0 == 0;
		object obj25 = !flag7;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = SfsTournamentConnector.IsParticipating(data.<RoomId>k__BackingField);
		object message = "ThisIsFakeReceiptData" + 1472;
		object obj26 = "ThisIsFakeReceiptData" + 1288;
		object obj27 = flag8 & obj22;
		bool flag9 = obj27 == null;
		object obj28 = !flag9;
		object obj29 = ~obj28;
		if (obj29 != null)
		{
			message = obj26;
		}
		object obj30 = "ThisIsFakeReceiptData" + 1328;
		bool flag10 = !flag5;
		object obj31 = !flag10;
		object obj32 = ~obj31;
		if (obj32 != null)
		{
			message = obj30;
		}
		TournamentPopupUtil.ShowMessage(_data, (string)message);
		return;
		IL_076f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v29+E4]");
		bool flag11 = (nint)0 == 0;
		object obj33 = !flag11;
		object obj35;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj34 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v42+B8]");
			obj35 = 0;
		}
		object obj36 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj37 = (nint)0 + (nint)456;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj35, (IntPtr)obj37);
		object obj38 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v41+B8]");
		object obj39 = (nint)0 + (nint)40;
		obj39 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IEnumerable<object> enumerable;
		source = enumerable;
		predicate2 = func2;
		goto IL_0900;
		IL_0094:
		obj9 = (nint)0 + (nint)2200;
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v79+E4]");
		bool flag12 = (nint)0 == 0;
		obj12 = obj9;
		obj5 = obj2;
		obj6 = obj4;
		if (!flag12)
		{
			goto IL_00e5;
		}
		goto IL_01f0;
		IL_01f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj9 = obj12;
		obj2 = obj5;
		obj4 = obj6;
		goto IL_0226;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag13 = (object)sessionModel == null;
		object obj40 = !flag13;
		if (obj40 != null)
		{
			goto IL_0226;
		}
		goto IL_0868;
		IL_0226:
		Room currentRoom = sessionModel.CurrentRoom;
		if (currentRoom == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
		object obj41 = (nint)0 & (nint)1;
		if (obj41 != null)
		{
			object obj42 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v64+E4]");
			if ((nint)0 != 0)
			{
				goto IL_02b0;
			}
		}
		else
		{
			_ = 1;
			object obj42 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v64+E4]");
			bool flag14 = (nint)0 == 0;
			object obj43 = !flag14;
			if (obj43 != null)
			{
				goto IL_02b0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_033e;
		IL_0868:
		throw new NullReferenceException();
		IL_086f:
		List<MatchData> tournamentMatches;
		flag6 = Enumerable.Any(tournamentMatches, predicate);
		TournamentData data2 = _data;
		object obj44 = data2.<Size>k__BackingField + data2.<Size>k__BackingField;
		int count = obj44 >> 1;
		object obj45 = (nint)0 + (nint)632;
		IEnumerable<object> enumerable2 = Enumerable.Skip((IEnumerable<object>)tournamentMatches, count);
		object obj46 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v29+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v29+B8]");
			obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v36+28]");
			predicate2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v36+28]");
			bool flag15 = (nint)0 == 0;
			object obj47 = !flag15;
			source = enumerable2;
			if (obj47 == null)
			{
				enumerable = enumerable2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v36+28]");
				Func<object, bool> func3 = (Func<object, bool>)0;
				goto IL_076f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj46 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v29+B8]");
			obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v36+28]");
			Func<object, bool> func3 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v36+28]");
			bool flag16 = (nint)0 == 0;
			object obj48 = !flag16;
			enumerable = enumerable2;
			source = enumerable2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v36+28]");
			predicate2 = (Func<object, bool>)0;
			if (obj48 == null)
			{
				goto IL_076f;
			}
		}
		goto IL_0900;
		IL_046e:
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom2 = sessionModel2.CurrentRoom;
		tournamentMatches = SFSKammelnaRoomExtensions.GetTournamentMatches(currentRoom2);
		obj15 = typeof(SkeletonBinary.SkeletonInput) + 3952;
		object obj49 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v39+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v39+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v47+20]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v47+20]");
			bool flag17 = (nint)0 == 0;
			object obj50 = !flag17;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v47+20]");
				Func<object, bool> func4 = (Func<object, bool>)0;
				goto IL_05a5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj49 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v39+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v47+20]");
			Func<object, bool> func4 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v47+20]");
			bool flag18 = (nint)0 == 0;
			object obj51 = !flag18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v47+20]");
			predicate = (Func<object, bool>)0;
			if (obj51 == null)
			{
				goto IL_05a5;
			}
		}
		goto IL_086f;
		IL_03e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag19 = (object)sessionModel2 == null;
		object obj52 = !flag19;
		if (obj52 != null)
		{
			goto IL_046e;
		}
		goto IL_0868;
		IL_02b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		bool flag20 = (object)sessionModel3 == null;
		object obj53 = !flag20;
		if (obj53 != null)
		{
			goto IL_033e;
		}
		goto IL_0868;
		IL_033e:
		Room currentRoom3 = sessionModel3.CurrentRoom;
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom3);
		if (tournamentInfo.<IsCluster>k__BackingField)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X20_v3+1C]");
		object obj54 = (nint)0 & (nint)1;
		if (obj54 != null)
		{
			object obj55 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v49+E4]");
			if ((nint)0 != 0)
			{
				goto IL_03e0;
			}
		}
		else
		{
			_ = 1;
			object obj55 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v49+E4]");
			bool flag21 = (nint)0 == 0;
			object obj56 = !flag21;
			if (obj56 != null)
			{
				goto IL_03e0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_046e;
	}

	private void ShowRoundPromotionMessage()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected O, but got Unknown
		//IL_0904: Expected O, but got I
		//IL_00a3: Expected O, but got I
		//IL_00cd: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		//IL_0025: Expected O, but got I
		//IL_0149: Expected O, but got I
		//IL_01fa: Expected O, but got I4
		//IL_01b7: Expected O, but got I4
		//IL_026a: Expected O, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02d5: Expected O, but got I
		//IL_02e1: Expected O, but got I
		//IL_0301: Expected I, but got O
		//IL_043d: Expected O, but got I
		//IL_0457: Expected O, but got I4
		//IL_0460: Expected O, but got I4
		//IL_0471: Expected O, but got I4
		//IL_03ae: Expected O, but got I
		//IL_03c6: Expected O, but got I4
		//IL_04db: Expected O, but got I4
		//IL_03e5: Expected O, but got I4
		//IL_05e3: Expected O, but got I4
		//IL_05ec: Expected O, but got I4
		//IL_062e: Expected O, but got I4
		//IL_063c: Expected I4, but got O
		//IL_0648: Expected O, but got I
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected O, but got Unknown
		//IL_07ba: Expected O, but got I
		//IL_07ca: Expected O, but got I
		//IL_07ec: Expected O, but got I4
		//IL_0804: Expected O, but got I
		//IL_0612: Expected O, but got I4
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected O, but got Unknown
		//IL_06aa: Expected O, but got I
		//IL_06ba: Expected O, but got I
		//IL_06e9: Expected O, but got I
		//IL_0584: Expected O, but got I4
		//IL_05aa: Expected O, but got I4
		//IL_0834: Expected O, but got I4
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Expected O, but got Unknown
		//IL_0981: Expected O, but got I
		//IL_0992: Expected I, but got O
		//IL_09b0: Expected O, but got I
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected O, but got Unknown
		//IL_08a3: Expected O, but got I4
		//IL_0864: Expected O, but got I
		//IL_0773: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3960;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
		object obj4 = (nint)0 & (nint)1;
		object obj7;
		object obj5;
		if (obj4 != null)
		{
			obj5 = (nint)0 + (nint)2200;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v85+E4]");
			bool flag = (nint)0 == 0;
			obj7 = obj5;
			if (!flag)
			{
				goto IL_005a;
			}
		}
		else
		{
			_ = 1;
			obj5 = (nint)0 + (nint)2200;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v85+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj7 = obj5;
			if (obj8 != null)
			{
				goto IL_005a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj5 = obj7;
		goto IL_0109;
		IL_094e:
		object message = "ThisIsFakeReceiptData" + 1464;
		TournamentData data;
		TournamentPopupUtil.ShowMessage(data, (string)message);
		return;
		IL_0921:
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v24+E4]");
		SessionModel sessionModel = default(SessionModel);
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag3 = (object)sessionModel == null;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				goto IL_08c0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		}
		Room currentRoom = sessionModel.CurrentRoom;
		int matchId;
		MatchData tournamentMatch = SFSKammelnaRoomExtensions.GetTournamentMatch(currentRoom, matchId);
		MatchData matchData = default(MatchData);
		object obj11;
		TournamentData data2;
		if (matchData.<State>k__BackingField != MatchData.Status.Waiting)
		{
			if (tournamentMatch != null)
			{
				bool flag4 = tournamentMatch.HasEmptyTeam();
				obj11 = (flag4 ? 1 : 0) ^ 1;
				data2 = _data;
				bool flag5 = _data == null;
				object obj12 = !flag5;
				if (obj12 == null)
				{
					goto IL_08c0;
				}
			}
			else
			{
				data2 = _data;
				obj11 = 1;
			}
		}
		else
		{
			data2 = _data;
			bool flag6 = _data == null;
			object obj13 = !flag6;
			obj11 = 0;
			if (obj13 == null)
			{
				goto IL_08c0;
			}
		}
		object obj14 = data2.<Size>k__BackingField + data2.<Size>k__BackingField;
		int count = obj14 >> 1;
		object obj15 = (nint)0 + (nint)632;
		List<MatchData> tournamentMatches;
		IEnumerable<object> enumerable = Enumerable.Skip((IEnumerable<object>)tournamentMatches, count);
		object obj16 = typeof(SkeletonBinary.SkeletonInput) + 3952;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v24+E4]");
		object obj18;
		Func<object, bool> predicate;
		IEnumerable<object> source;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v24+B8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X9_v7+30]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X9_v7+30]");
			bool flag7 = (nint)0 == 0;
			source = enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X9_v7+30]");
			Func<object, bool> func = (Func<object, bool>)0;
			if (!flag7)
			{
				goto IL_06f7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v24+B8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X9_v7+30]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X9_v7+30]");
			bool flag8 = (nint)0 == 0;
			object obj19 = !flag8;
			source = enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X9_v7+30]");
			Func<object, bool> func = (Func<object, bool>)0;
			if (obj19 != null)
			{
				goto IL_06f7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v24+E4]");
		bool flag9 = (nint)0 == 0;
		object obj20 = !flag9;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj21 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v31+B8]");
			obj18 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)464;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj18, (IntPtr)obj22);
		object obj23 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v28+B8]");
		object obj24 = (nint)0 + (nint)48;
		obj24 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag10 = Enumerable.All(enumerable, func2);
		object obj25 = obj11 & 1;
		bool flag11 = obj25 == null;
		object obj26 = !flag11;
		if (obj26 != null)
		{
			goto IL_0734;
		}
		goto IL_08b1;
		IL_0734:
		if (flag10)
		{
			data = _data;
			object obj27 = data.<Size>k__BackingField + data.<Size>k__BackingField;
			if (matchData.<ID>k__BackingField < (nint)obj27)
			{
				return;
			}
			goto IL_094e;
		}
		return;
		IL_005a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		bool flag12 = (object)sessionModel2 == null;
		object obj28 = !flag12;
		if (obj28 != null)
		{
			goto IL_0109;
		}
		goto IL_08c0;
		IL_0109:
		Room currentRoom2 = sessionModel2.CurrentRoom;
		if (currentRoom2 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
		object obj29 = (nint)0 & (nint)1;
		if (obj29 != null)
		{
			object obj30 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v70+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0193;
			}
		}
		else
		{
			_ = 1;
			object obj30 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v70+E4]");
			bool flag13 = (nint)0 == 0;
			object obj31 = !flag13;
			if (obj31 != null)
			{
				goto IL_0193;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0221;
		IL_06f7:
		flag10 = Enumerable.All(source, predicate);
		object obj32 = obj11 & 1;
		if (obj32 != null)
		{
			goto IL_0734;
		}
		goto IL_08b1;
		IL_08b1:
		data = _data;
		goto IL_094e;
		IL_0494:
		_ = 1;
		object obj34;
		object obj33 = obj34;
		int <Size>k__BackingField;
		int num = <Size>k__BackingField;
		int num2;
		matchId = num2;
		goto IL_0921;
		IL_08c0:
		throw new NullReferenceException();
		IL_0193:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		bool flag14 = (object)sessionModel3 == null;
		object obj35 = !flag14;
		if (obj35 != null)
		{
			goto IL_0221;
		}
		goto IL_08c0;
		IL_0221:
		Room currentRoom3 = sessionModel3.CurrentRoom;
		tournamentMatches = SFSKammelnaRoomExtensions.GetTournamentMatches(currentRoom3);
		object obj36 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v12+E4]");
		bool flag15 = (nint)0 == 0;
		object obj37 = !flag15;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel4 = default(SessionModel);
		User localUser = sessionModel4.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		object obj38 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
		object obj39 = (nint)0 + (nint)488;
		object obj40 = (nint)0 + (nint)1816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj3, (IntPtr)obj39);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC96CC");
		if (matchData == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Object)+10]");
		int teamId = matchData.GetTeamId(0);
		TournamentData data3 = _data;
		if (teamId == 1)
		{
			<Size>k__BackingField = data3.<Size>k__BackingField;
			int firstParentId = TournamentMath.GetFirstParentId(matchData.<ID>k__BackingField, data3.<Size>k__BackingField);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
			object obj41 = (nint)0 & (nint)1;
			bool flag16 = obj41 == null;
			obj34 = 0;
			num2 = firstParentId;
			if (flag16)
			{
				goto IL_0494;
			}
			obj33 = 0;
			num = data3.<Size>k__BackingField;
			matchId = firstParentId;
		}
		else
		{
			<Size>k__BackingField = data3.<Size>k__BackingField;
			int secondParentId = TournamentMath.GetSecondParentId(matchData.<ID>k__BackingField, data3.<Size>k__BackingField);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E701C]");
			object obj42 = (nint)0 & (nint)1;
			bool flag17 = obj42 == null;
			object obj43 = !flag17;
			obj34 = 0;
			num2 = secondParentId;
			obj33 = 0;
			num = data3.<Size>k__BackingField;
			matchId = secondParentId;
			if (obj43 == null)
			{
				goto IL_0494;
			}
		}
		goto IL_0921;
	}

	private void SetTeamsTabVisibility(bool isVisible)
	{
		SetTabVisibility(isVisible, teamsTab, treeTab);
	}

	private static void SetTabVisibility(bool isVisible, Toggle tab, Toggle altTab)
	{
		//IL_0037: Expected O, but got I4
		if (isVisible)
		{
			bool flag = (object)tab == null;
			object obj = !flag;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		else if (tab.m_IsOn)
		{
			tab.isOn = false;
			altTab.isOn = true;
		}
		GameObject gameObject = tab.gameObject;
		gameObject.SetActive(isVisible);
	}

	private void <Start>b__31_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cc: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1560;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EF8]");
		object obj2 = (nint)0 & (nint)1;
		TournamentData data;
		TournamentData data2;
		if (obj2 != null)
		{
			data = _data;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			data2 = _data;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			data = _data;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			data2 = _data;
			if (obj4 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		TournamentHubHelpSectionPopup.Show(data2);
		return;
		IL_0088:
		TournamentHubHelpSectionPopup.Show(data);
	}
}
