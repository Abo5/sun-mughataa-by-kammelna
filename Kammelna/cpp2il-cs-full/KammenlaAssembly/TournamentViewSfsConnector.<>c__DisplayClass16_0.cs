using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Spine;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using Util;

public class TournamentViewSfsConnector : TournamentViewConnector
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<bool> <>9__13_0;

		public static Func<bool> <>9__14_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3968;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <JoinTournamentRoom>b__13_0()
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
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F0D]");
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

		internal bool <JoinSpawnerTournament>b__14_0()
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
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F0E]");
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
	}

	private sealed class <>c__DisplayClass15_0
	{
		public TournamentViewSfsConnector <>4__this;

		public Action<int> callback;

		internal void <CheckParticipationStatus>b__0(ISFSObject response)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_003f: Expected I, but got O
			//IL_004f: Expected O, but got I
			//IL_01d3: Expected I4, but got I8
			//IL_008a: Expected O, but got I
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Expected O, but got Unknown
			//IL_0147: Expected O, but got I4
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object obj2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 568;
			object varName = "setMimeType" + 3176;
			nint num = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00cb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X10_v6-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00cb;
			}
			object obj5 = obj4 + 14;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_01b3;
			IL_00cb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_01b3;
			IL_01b3:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v220 @ X0_v4] (should have been resolved before IL gen)");
			int num2 = SFSExtensions.Get(response, (string)varName, -1);
			TournamentViewSfsConnector tournamentViewSfsConnector = <>4__this;
			object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int roomId = default(int);
			SfsTournamentConnector.SetSeat(roomId, num2, tournamentViewSfsConnector.eventsChannel);
			Actions.SafeInvoke(callback, num2);
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public Action<bool> callback;

		internal void <ForceStart>b__0(ISFSObject param)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0031: Expected I, but got O
			//IL_0041: Expected O, but got I
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected I4, but got Unknown
			//IL_007c: Expected O, but got I
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object obj2 = "destinationTimeZone" + 2696;
			nint num = (nint)param;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00bd;
			}
			object obj5 = obj4 + 1;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_011e;
			IL_00bd:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_011e;
			IL_011e:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ X0_v3] (should have been resolved before IL gen)");
			object obj8 = default(object);
			bool arg = (byte)(obj8 ^ 1) != 0;
			Actions.SafeInvoke(callback, arg);
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public TournamentData data;

		public TournamentViewSfsConnector <>4__this;

		internal void <SetReady>b__0()
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0095: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			TournamentData tournamentData = data;
			long? num = default(long?);
			long value = num.Value;
			object obj = typeof(RegisteredWaitHandle) + 1552;
			long num2 = default(long);
			string payload = num2.ToString();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RoutingManager.Route(RoutingCommand.MassTournament, payload, (Games?)(object)0);
		}

		internal void <SetReady>b__1(MassEventModel model)
		{
			<>4__this.SetReadyHelper(data);
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public TournamentData data;

		internal bool <SetReadyHelper>b__0(Tournament tournament)
		{
			//IL_00bb: Expected I4, but got O
			//IL_00e1: Expected O, but got I4
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected O, but got Unknown
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected I4, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_00a8: Expected O, but got I4
			//IL_007b: Expected I8, but got O
			//IL_0092: Expected O, but got I4
			long? num;
			object obj2;
			if (tournament != null)
			{
				TournamentData tournamentData = data;
				bool flag = data == null;
				num = (long?)data;
				if (!flag)
				{
					object obj = (??)tournamentData.<TournamentId>k__BackingField & 1;
					if (obj != null)
					{
						long value = (object?)tournamentData.<TournamentId>k__BackingField >> 32;
						long? num2 = value;
						obj2 = 0;
						num = num2;
						goto IL_00e6;
					}
					num = (long?)(object)0;
				}
				obj2 = 0;
				goto IL_00e6;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00e6:
			object obj3 = tournament.id - obj2;
			bool flag2 = obj3 == null;
			return (byte)(((??)num & flag2) ? 1 : 0) != 0;
		}
	}

	private TournamentsEventsChannel eventsChannel;

	private bool recoveringConnection;

	public override void Init()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_015a: Expected O, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0129: Expected O, but got I
		//IL_04f4: Expected O, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01f4: Expected O, but got I4
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected O, but got Unknown
		//IL_077e: Expected O, but got I4
		//IL_049d: Expected O, but got I
		//IL_04bf: Expected O, but got I4
		//IL_07a7: Expected O, but got I
		//IL_0234: Expected O, but got I4
		//IL_092d: Expected O, but got I
		//IL_0563: Expected O, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0297: Expected O, but got I4
		//IL_0803: Expected O, but got I4
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_05de: Expected O, but got I4
		//IL_02c5: Expected O, but got I
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_0307: Expected O, but got I4
		//IL_096f: Expected O, but got I
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Expected O, but got Unknown
		//IL_09b1: Expected O, but got I4
		//IL_0593: Expected O, but got I
		//IL_0330: Expected O, but got I
		//IL_0616: Expected O, but got I
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_0385: Expected I, but got O
		//IL_0395: Expected O, but got I
		//IL_042b: Expected O, but got I
		//IL_044c: Expected O, but got I4
		//IL_0687: Expected O, but got I4
		//IL_089e: Expected O, but got I4
		//IL_03d0: Expected O, but got I
		//IL_0463: Expected O, but got I4
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Expected O, but got Unknown
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Expected O, but got Unknown
		//IL_0843: Expected O, but got I
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected O, but got Unknown
		//IL_0726: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EFD]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v46+E4]");
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
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v46+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v46+B8]");
		object obj6 = 0;
		object obj7 = obj6;
		if (obj6 != null)
		{
			goto IL_014e;
		}
		goto IL_0468;
		IL_0874:
		object obj9;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v59+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		bool flag4 = SFSKammelnaRoomExtensions.IsTournamentHub(currentRoom);
		bool flag5 = !flag4;
		object obj12;
		object obj11 = obj12;
		if (!flag5)
		{
			goto IL_090b;
		}
		goto IL_0912;
		IL_0912:
		int num;
		JoinTournamentRoom(num);
		return;
		IL_090b:
		SetReady();
		return;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v46+B8]");
		object obj13 = 0;
		obj7 = obj13;
		bool flag6 = obj13 == null;
		object obj14 = !flag6;
		if (obj14 != null)
		{
			goto IL_014e;
		}
		goto IL_0468;
		IL_014e:
		object obj15 = (nint)0 + (nint)4056;
		obj11 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v29+10]");
		System.Int32Enum? int32Enum = (System.Int32Enum)0;
		obj3 = obj;
		object obj16 = (??)int32Enum & 1;
		bool flag7 = obj16 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v29+10]");
		nint num2 = 0;
		object obj34;
		if (!flag7)
		{
			object obj17 = (object?)int32Enum >> 32;
			object obj18 = obj17 + 4294955296L;
			bool flag8 = (nint)obj18 < 6;
			object obj19 = !flag8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v29+10]");
			num2 = 0;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v46+E4]");
				bool flag9 = (nint)0 == 0;
				object obj20 = !flag9;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v46+B8]");
				object obj21 = 0;
				object obj22 = obj21;
				object obj23 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
				object obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v47+E4]");
				bool flag10 = (nint)0 == 0;
				object obj25 = !flag10;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v35+18]");
				num = Convert.ToInt32((string)0);
				obj9 = typeof(Queue<string>) + 848;
				object obj26 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v51+E4]");
				bool flag11 = (nint)0 == 0;
				object obj27 = !flag11;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj28 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				Room currentRoom2 = sessionModel2.CurrentRoom;
				if (currentRoom2 != null)
				{
					object obj29 = typeof(RegisteredWaitHandle) + 1376;
					nint num3 = (nint)currentRoom2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v43 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v43 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0411;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v43 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj31 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X10_v10-8]");
						if (0 == (nint)obj29)
						{
							break;
						}
						obj31 += 16;
						obj30--;
						if ((nint)obj30 != 1)
						{
							continue;
						}
						goto IL_0411;
					}
					object obj32 = num3 + obj31;
					object obj33 = obj32 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v48+8]");
					obj34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v505 @ X8_v48] (should have been resolved before IL gen)");
					object obj35 = default(object);
					bool flag12 = (nint)obj35 != num;
					obj12 = obj11;
					if (!flag12)
					{
						goto IL_0874;
					}
				}
				goto IL_0912;
			}
		}
		goto IL_0468;
		IL_0411:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v66+8]");
		obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v536 @ X0_v66] (should have been resolved before IL gen)");
		object obj36 = default(object);
		bool flag13 = (nint)obj36 == num;
		obj12 = 0;
		if (flag13)
		{
			goto IL_0874;
		}
		obj11 = 0;
		goto IL_0912;
		IL_0519:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v13+10]");
		if ((nint)0 == 12100)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v46+E4]");
			bool flag14 = (nint)0 == 0;
			object obj37 = !flag14;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj38 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v22+B8]");
				object obj39 = 0;
				object obj40 = obj39;
			}
			object obj41 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			object obj42 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v16+E4]");
			bool flag15 = (nint)0 == 0;
			object obj43 = !flag15;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v13+18]");
			int num4 = Convert.ToInt32((string)0);
			object obj44 = typeof(Queue<string>) + 848;
			object obj45 = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v21+E4]");
			bool flag16 = (nint)0 == 0;
			object obj46 = !flag16;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj47 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel3 = default(SessionModel);
			Room currentRoom3 = sessionModel3.CurrentRoom;
			if (SFSKammelnaRoomExtensions.IsTournamentHub(currentRoom3))
			{
				object obj48 = obj44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v29+E4]");
				bool flag17 = (nint)0 == 0;
				object obj49 = !flag17;
				if (obj49 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel4 = default(SessionModel);
				Room currentRoom4 = sessionModel4.CurrentRoom;
				TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v34 (TournamentData)+D8]");
				if ((nint)num4 == 0)
				{
					object obj50 = (??)tournamentInfo.<SpawnerId>k__BackingField & 1;
					bool flag18 = obj50 == null;
					object obj51 = !flag18;
					if (obj51 != null)
					{
						goto IL_090b;
					}
				}
			}
			JoinSpawnerTournament(num4);
			return;
		}
		goto IL_0740;
		IL_0468:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v46+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v46+B8]");
			object obj52 = 0;
			object obj40 = obj52;
			bool flag19 = obj52 == null;
			object obj53 = !flag19;
			if (obj53 != null)
			{
				goto IL_0519;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v46+B8]");
			object obj54 = 0;
			object obj40 = obj54;
			if (obj54 != null)
			{
				goto IL_0519;
			}
		}
		goto IL_0740;
		IL_0740:
		object obj55 = typeof(Queue<string>) + 848;
		object obj56 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v7+E4]");
		bool flag20 = (nint)0 == 0;
		object obj57 = !flag20;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj58 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel5 = default(SessionModel);
		Room currentRoom5 = sessionModel5.CurrentRoom;
		if (currentRoom5 != null)
		{
			bool flag21 = SFSKammelnaRoomExtensions.IsTournamentHub(currentRoom5);
			bool flag22 = !flag21;
			object obj59 = !flag22;
			if (obj59 != null)
			{
				goto IL_090b;
			}
		}
		TournamentPopupUtil.ShowTournamentHubError();
	}

	private void SetReady()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00db: Expected O, but got I
		//IL_00ec: Expected I, but got O
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_012a: Expected O, but got I4
		//IL_0172: Expected O, but got I
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_01ae: Expected O, but got I
		//IL_01bf: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TournamentData tournamentData = GetTournamentData();
		object obj4 = obj2 + 16;
		obj4 = tournamentData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TournamentData tournamentData2 = (TournamentData)obj4;
		object obj5 = (??)tournamentData2.<ParentMassEventId>k__BackingField & 1;
		if (obj5 != null)
		{
			GameObject popup = base.gameObject;
			object obj6 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = (nint)0 + (nint)528;
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj7);
			object obj8 = typeof(RegisteredWaitHandle) + 3136;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ScreenManager.PushPopup(popup, action);
			object obj11 = obj4;
			object obj12 = (nint)0 + (nint)3232;
			long? num = default(long?);
			long value = num.Value;
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2616;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)536;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj2, (IntPtr)obj14);
			MassTournamentManager.GetMassEvent(value, action2);
		}
		else
		{
			SetReadyHelper(tournamentData2);
		}
	}

	private void SetReadyHelper(TournamentData data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0072: Expected O, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00cf: Expected O, but got I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_010c: Expected O, but got I
		//IL_0133: Expected I, but got O
		//IL_0138: Expected I, but got O
		//IL_016c: Expected O, but got I4
		//IL_01b2: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 4000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = typeof(RegisteredWaitHandle) + 3136;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj6 = (nint)0 + (nint)1896;
		object obj7 = typeof(UsageHint) + 72;
		ReadyState.IsReady = true;
		SFS.SendTournamentRoomLoaded();
		SplashAnimation.EndAnimation();
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = typeof(List<Tween>) + 3560;
		object obj11 = (nint)0 + (nint)544;
		ScreenManager.AnimateTransitionIn();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action = default(Action<int>);
		action..ctor((object)null, (IntPtr)obj6);
		nint num = (nint)this;
		CheckParticipationStatus(action);
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v19+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<Tournament> createdTournaments = UserInfo.CreatedTournaments;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj2, (IntPtr)obj11);
		int num2 = ((List<object>)(object)createdTournaments).RemoveAll(predicate);
		UserInfo.CreatedTournaments = createdTournaments;
	}

	private static void LoadParentMass(long parentMassEventId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0073: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 1552;
		long num = default(long);
		string payload = num.ToString();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoutingManager.Route(RoutingCommand.MassTournament, payload, (Games?)(object)0);
	}

	protected override void RegisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004c: Expected O, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0125: Expected I, but got O
		//IL_008b: Expected I, but got O
		//IL_00b1: Expected I, but got O
		//IL_00e0: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)1688;
		object obj3 = (nint)0 + (nint)1696;
		object obj4 = typeof(List<Tween>) + 3424;
		object obj5 = (nint)0 + (nint)1680;
		object obj6 = typeof(RegisteredWaitHandle) + 1552;
		base.RegisterEvents();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoom += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj3);
		SFS.OnRoomRemoved += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor((object)this, (IntPtr)obj5);
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoutingManager.OnValidateRouting += predicate;
	}

	protected override void UnregisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004c: Expected O, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0111: Expected I, but got O
		//IL_007d: Expected I, but got O
		//IL_00a8: Expected I, but got O
		//IL_00d2: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)1688;
		object obj3 = (nint)0 + (nint)1696;
		object obj4 = typeof(List<Tween>) + 3424;
		object obj5 = (nint)0 + (nint)1680;
		object obj6 = typeof(RegisteredWaitHandle) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoom -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj3);
		SFS.OnRoomRemoved -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor((object)this, (IntPtr)obj5);
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoutingManager.OnValidateRouting -= predicate;
	}

	public override TournamentData GetTournamentData()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0118: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0161: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F02]");
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
		goto IL_016f;
		IL_00b8:
		Room currentRoom = sessionModel.CurrentRoom;
		return SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom);
		IL_016f:
		return (TournamentData)(object)new NullReferenceException();
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_016f;
	}

	public override List<MatchData> GetMatches()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0118: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0161: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F03]");
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
		goto IL_016f;
		IL_00b8:
		Room currentRoom = sessionModel.CurrentRoom;
		return SFSKammelnaRoomExtensions.GetTournamentMatches(currentRoom);
		IL_016f:
		return (List<MatchData>)(object)new NullReferenceException();
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_016f;
	}

	public override void OnJoinRoom(TournamentData data)
	{
	}

	private void OnRoomChanged(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_014c: Expected O, but got I4
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_0285: Expected O, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X10_v7-8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v255 @ X0_v28] (should have been resolved before IL gen)");
		object obj8 = default(object);
		object obj7 = obj8 & 1;
		bool flag = obj7 == null;
		object obj9 = !flag;
		if (obj9 == null)
		{
			goto IL_015a;
		}
		goto IL_0180;
		IL_0180:
		ReadyState.IsReady = false;
		return;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v148 @ X0_v25] (should have been resolved before IL gen)");
		object obj11 = default(object);
		object obj10 = obj11 & 1;
		if (obj10 == null)
		{
			goto IL_015a;
		}
		goto IL_0180;
		IL_015a:
		if (SFSKammelnaRoomExtensions.IsMassTournament(room))
		{
			goto IL_0180;
		}
		if (SFSKammelnaRoomExtensions.IsTournamentHub(room))
		{
			recoveringConnection = false;
			SetReady();
			object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				PopupWindow.DismissMessage();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.DismissMessage();
			return;
		}
		if (recoveringConnection)
		{
			TournamentPopupUtil.ShowTournamentHubError();
			return;
		}
		ReadyState.IsReady = false;
		object obj14 = typeof(UsageHint) + 72;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int lastJoinedTournamentRoomId = UserInfo.LastJoinedTournamentRoomId;
		JoinTournamentRoom(lastJoinedTournamentRoomId);
	}

	private void OnRoomRemoved(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_0107: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I4
		//IL_0150: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F05]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
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
		if (currentRoom == null)
		{
			object obj9 = typeof(UsageHint) + 72;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v2+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int lastJoinedTournamentRoomId = UserInfo.LastJoinedTournamentRoomId;
			JoinTournamentRoom(lastJoinedTournamentRoomId);
		}
	}

	private void JoinTournamentRoom(int roomId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01d4: Expected O, but got I
		//IL_01e4: Expected O, but got I
		//IL_01f4: Expected O, but got I
		//IL_0216: Expected O, but got I4
		//IL_0140: Expected I, but got O
		//IL_00f3: Expected O, but got I4
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0260: Expected O, but got I
		//IL_0268: Expected I, but got O
		//IL_0279: Expected I, but got O
		//IL_0297: Expected O, but got I
		//IL_02b1: Expected I4, but got O
		//IL_0123: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1504;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgBody = "LAK" + 2136;
		object obj3 = typeof(SkeletonBinary.SkeletonInput) + 3968;
		recoveringConnection = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentData tournamentData = default(TournamentData);
		tournamentData..ctor(roomId);
		SFS.JoinTournamentRoom(tournamentData);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowLoading((string)msgBody, dismissible: false);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj3;
		}
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v9+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v8+8]");
		Func<bool> cancelCondition = (Func<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v8+8]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		nint num = 0;
		bool flag4 = false;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v14+B8]");
				obj10 = 0;
			}
			object obj14 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)504;
			num = (nint)obj15;
			Func<bool> func = default(Func<bool>);
			func..ctor(obj10, (IntPtr)obj15);
			object obj16 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v13+B8]");
			object obj17 = (nint)0 + (nint)8;
			obj17 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			flag4 = (byte)(int)func != 0;
			cancelCondition = func;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj9);
		Coroutine coroutine = UIExtensions.SetTimeout(this, 5f, cancelCondition, action);
	}

	private void JoinSpawnerTournament(int spawnerId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0176: Expected O, but got I4
		//IL_0060: Expected O, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a4: Expected O, but got I
		//IL_01b4: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_01e6: Expected O, but got I4
		//IL_00f4: Expected I, but got O
		//IL_00a7: Expected O, but got I4
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0230: Expected O, but got I
		//IL_0238: Expected I, but got O
		//IL_0249: Expected I, but got O
		//IL_0267: Expected O, but got I
		//IL_0281: Expected I4, but got O
		//IL_00d7: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgBody = "LAK" + 2136;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 3968;
		recoveringConnection = true;
		SFS.JoinSpawnerTournament(spawnerId);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowLoading((string)msgBody, dismissible: false);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
		}
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v8+10]");
		Func<bool> cancelCondition = (Func<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v8+10]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		nint num = 0;
		bool flag4 = false;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v14+B8]");
				obj9 = 0;
			}
			object obj13 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)496;
			num = (nint)obj14;
			Func<bool> func = default(Func<bool>);
			func..ctor(obj9, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v13+B8]");
			object obj16 = (nint)0 + (nint)16;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			flag4 = (byte)(int)func != 0;
			cancelCondition = func;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj8);
		Coroutine coroutine = UIExtensions.SetTimeout(this, 5f, cancelCondition, action);
	}

	public override void CheckParticipationStatus(Action<int> callback)
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
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00c8: Expected I, but got O
		//IL_00f2: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj4 = (nint)0 + (nint)512;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "com.unity.services.authentication.profile" + 2512;
		object obj6 = obj2 + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v15+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendRoomRequest(go, (string)command, null, keepListening: true, action);
	}

	public override void ForceStart(Action<bool> callback)
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
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_00a6: Expected I, but got O
		//IL_00d5: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj4 = (nint)0 + (nint)520;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "startPosition" + 984;
		object obj6 = obj2 + 16;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendRoomRequest(go, (string)command, null, keepListening: false, action);
	}

	public override void BanPlayer(int dbId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object key = "placementId" + 192;
		object command = "alignContent" + 3816;
		int value = default(int);
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, value);
		SFS.SendRoomExtensionRequest((string)command, param);
	}

	private bool IsRoutingNeeded(RoutingParams routingParams)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_015a: Expected O, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_0129: Expected O, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_027a: Expected O, but got I4
		//IL_02a3: Expected O, but got I
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01f9: Expected O, but got I4
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0221: Expected O, but got I4
		//IL_065d: Expected I4, but got O
		//IL_031e: Expected O, but got I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_04d8: Expected O, but got I4
		//IL_04e9: Expected O, but got I4
		//IL_043a: Expected O, but got I4
		//IL_0474: Expected O, but got I4
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected O, but got Unknown
		//IL_0583: Expected I, but got O
		//IL_0593: Expected O, but got I
		//IL_0622: Expected O, but got I4
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected O, but got Unknown
		//IL_05ce: Expected O, but got I
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected O, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected O, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F0B]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v70+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v70+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v44+B8]");
		object obj7 = 0;
		object obj8 = obj7;
		if (obj7 != null)
		{
			goto IL_014e;
		}
		goto IL_0487;
		IL_0487:
		return true;
		IL_0450:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_053d;
		}
		goto IL_064f;
		IL_053d:
		Room currentRoom = sessionModel.CurrentRoom;
		if (currentRoom == null)
		{
			goto IL_064f;
		}
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)currentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_060f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X10_v5-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_060f;
		}
		object obj13 = num + obj12;
		object obj14 = obj13 + 312;
		goto IL_0681;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v70+B8]");
		object obj15 = 0;
		obj8 = obj15;
		bool flag4 = obj15 == null;
		object obj16 = !flag4;
		if (obj16 != null)
		{
			goto IL_014e;
		}
		goto IL_0487;
		IL_014e:
		object obj17 = (nint)0 + (nint)4056;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+10]");
		System.Int32Enum? int32Enum = (System.Int32Enum)0;
		object obj19 = (??)int32Enum & 1;
		if (obj19 == null)
		{
			goto IL_0487;
		}
		object obj20 = (object?)int32Enum >> 32;
		if ((nint)obj20 != 12100)
		{
			object obj21 = obj20 + 4294955296L;
			bool flag5 = (nint)obj21 < 5;
			object obj22 = !flag5;
			object obj23 = obj21 - 5;
			bool flag6 = obj23 == null;
			object obj24 = !flag6;
			object obj25 = obj22 & obj24;
			if (obj25 != null)
			{
				goto IL_0487;
			}
		}
		object obj26 = typeof(Queue<string>) + 848;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v5+E4]");
		bool flag7 = (nint)0 == 0;
		object obj28 = !flag7;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj29 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		int num3;
		if ((object)sessionModel2 != null)
		{
			Room currentRoom2 = sessionModel2.CurrentRoom;
			if (currentRoom2 == null)
			{
				goto IL_0487;
			}
			object obj30 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v12+E4]");
			bool flag8 = (nint)0 == 0;
			object obj31 = !flag8;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel3 = default(SessionModel);
			if ((object)sessionModel3 != null)
			{
				Room currentRoom3 = sessionModel3.CurrentRoom;
				if (!SFSKammelnaRoomExtensions.IsTournamentHub(currentRoom3))
				{
					goto IL_0487;
				}
				if (routingParams != null)
				{
					object obj32 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
					object obj33 = obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v12+E4]");
					int num4;
					if ((nint)0 != 0)
					{
						int num2 = Convert.ToInt32(routingParams.Payload);
						object obj34 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v26+E4]");
						bool flag9 = (nint)0 == 0;
						num3 = num2;
						object obj35 = 0;
						num4 = num2;
						if (!flag9)
						{
							goto IL_0450;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						int num5 = Convert.ToInt32(routingParams.Payload);
						object obj34 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v26+E4]");
						bool flag10 = (nint)0 == 0;
						object obj36 = !flag10;
						num3 = num5;
						object obj35 = 0;
						num4 = num5;
						if (obj36 != null)
						{
							goto IL_0450;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					bool flag11 = (object)sessionModel == null;
					num3 = num4;
					if (!flag11)
					{
						goto IL_053d;
					}
				}
			}
		}
		goto IL_064f;
		IL_064f:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0681:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v195 @ X8_v17] (should have been resolved before IL gen)");
		object obj38 = default(object);
		object obj37 = num3 - obj38;
		bool flag12 = obj37 == null;
		return !flag12;
		IL_060f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj18 = 0;
		object obj39 = default(object);
		obj14 = obj39;
		goto IL_0681;
	}

	public TournamentViewSfsConnector()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OneShotEvent oneShotEvent = default(OneShotEvent);
		oneShotEvent..ctor();
		object obj2 = this + 32;
		obj2 = oneShotEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((MonoBehaviour)this)..ctor();
	}
}
