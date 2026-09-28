using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Features.Clans;
using Kammelna.Server;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Server.Models;
using Sfs2X.Entities;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class SfsTournamentConnector : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Predicate<Tournament> <>9__5_0;

		public static Func<TournamentModel, bool> <>9__12_0;

		public static Func<TournamentModel, int?> <>9__12_1;

		public static Func<Room, bool> <>9__16_0;

		public static Func<Room, int> <>9__16_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <LoadUserTournaments>b__5_0(Tournament tournament)
		{
			//IL_0097: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			if (tournament != null)
			{
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				return tournament.startingTime < now;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <UpdateLastSeen>b__12_0(TournamentModel model)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0072: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = IsMyClanTournament(model);
			return (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
		}

		internal int? <UpdateLastSeen>b__12_1(TournamentModel model)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0051: Expected I, but got O
			//IL_0061: Expected O, but got I
			//IL_009c: Expected O, but got I
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected O, but got Unknown
			if (model != null)
			{
				Room <Room>k__BackingField = model.<Room>k__BackingField;
				if (model.<Room>k__BackingField != null)
				{
					object obj = typeof(RegisteredWaitHandle) + 1376;
					nint num = (nint)<Room>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00dd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X10_v5-8]");
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
						goto IL_00dd;
					}
					object obj4 = num + obj3;
					object obj5 = obj4 + 312;
					goto IL_015b;
				}
			}
			return (int?)new NullReferenceException();
			IL_00dd:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_015b;
			IL_015b:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v166 @ X0_v3] (should have been resolved before IL gen)");
			int value = default(int);
			return value;
		}

		internal bool <CheckUserTournaments>b__16_0(Room room)
		{
			return SFSKammelnaRoomExtensions.IsTournamentHub(room);
		}

		internal int <CheckUserTournaments>b__16_1(Room room)
		{
			//IL_0124: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_010c: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			nint num;
			object obj3 = default(object);
			if (room != null)
			{
				object obj = typeof(RegisteredWaitHandle) + 1376;
				num = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4-8]");
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
			goto IL_0116;
			IL_0116:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj5 = default(object);
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_00d9:
			object obj7 = num + obj3;
			object obj8 = obj7 + 312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v6+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0116;
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public SfsTournamentConnector <>4__this;

		public List<int> roomIds;

		internal void <CheckUserTournaments>b__2(Dictionary<int, int> tournamentSeats)
		{
			//IL_0524: Expected O, but got I4
			//IL_052e: Expected O, but got I4
			//IL_0537: Expected O, but got I4
			//IL_0012: Expected O, but got I
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_003f: Expected O, but got I
			//IL_004b: Expected O, but got I
			//IL_0154: Expected O, but got I4
			//IL_016e: Expected O, but got I4
			//IL_0491: Expected O, but got I
			//IL_03cf: Expected O, but got I4
			//IL_03e1: Expected O, but got I4
			//IL_010b: Expected O, but got I4
			//IL_02fb: Expected O, but got I
			//IL_032e: Expected O, but got I4
			//IL_0074: Expected I4, but got O
			//IL_0081: Expected I, but got O
			//IL_0219: Expected O, but got I4
			//IL_0564: Expected O, but got I
			//IL_0409: Expected O, but got I4
			//IL_0246: Expected I, but got O
			//IL_0253: Expected I4, but got O
			//IL_0271: Expected O, but got I4
			//IL_0431: Expected O, but got I4
			//IL_02d2: Expected O, but got I4
			//IL_01ab: Expected I4, but got I8
			//IL_01ab: Expected I4, but got O
			//IL_01b8: Expected I, but got O
			Dictionary<int, int> dictionary = default(Dictionary<int, int>);
			bool flag = dictionary == null;
			List<int>.Enumerator enumerator = (List<int>.Enumerator)0;
			Dictionary<int, int>.Enumerator enumerator2 = (Dictionary<int, int>.Enumerator)0;
			Dictionary<int, int>.Enumerator enumerator3 = (Dictionary<int, int>.Enumerator)0;
			Dictionary<int, int>.Enumerator enumerator5 = default(Dictionary<int, int>.Enumerator);
			List<int>.Enumerator enumerator10 = default(List<int>.Enumerator);
			Dictionary<int, int>.Enumerator enumerator6;
			Dictionary<int, int>.Enumerator enumerator7 = default(Dictionary<int, int>.Enumerator);
			if (!flag)
			{
				object obj = (nint)0 + (nint)1472;
				object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
				object obj3 = (nint)0 + (nint)2392;
				object obj4 = (nint)0 + (nint)896;
				object obj5 = (nint)0 + (nint)1464;
				Dictionary<int, int>.Enumerator enumerator4 = dictionary.GetEnumerator();
				int seat = default(int);
				while (true)
				{
					dictionary = (Dictionary<int, int>)obj;
					if (!enumerator2.MoveNext())
					{
						break;
					}
					SfsTournamentConnector sfsTournamentConnector = <>4__this;
					if ((object)<>4__this != null)
					{
						object obj6 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v46+E4]");
						bool flag2 = (nint)0 == 0;
						object obj7 = !flag2;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						SetSeat((int)enumerator5, seat, sfsTournamentConnector.eventsChannel);
						nint num = (nint)sfsTournamentConnector.eventsChannel;
						continue;
					}
					goto IL_03bc;
				}
				dictionary = (Dictionary<int, int>)obj5;
				enumerator2.Dispose();
				bool flag3 = roomIds == null;
				enumerator = (List<int>.Enumerator)0;
				enumerator6 = enumerator5;
				enumerator3 = enumerator7;
				enumerator7 = (Dictionary<int, int>.Enumerator)0;
				if (!flag3)
				{
					List<int>.Enumerator enumerator8 = roomIds.GetEnumerator();
					List<int>.Enumerator enumerator9 = default(List<int>.Enumerator);
					while (true)
					{
						dictionary = (Dictionary<int, int>)obj3;
						if (!enumerator9.MoveNext())
						{
							break;
						}
						object obj8 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v34+E4]");
						bool flag4 = (nint)0 == 0;
						object obj9 = !flag4;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj8 = obj2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v34+B8]");
						object obj10 = 0;
						if (obj10 == null)
						{
							goto IL_03e6;
						}
						nint num = (nint)obj4;
						bool flag5 = ((Dictionary<int, int>)obj10).ContainsKey((int)enumerator5);
						bool flag6 = !flag5;
						object obj11 = !flag6;
						if (obj11 != null)
						{
							continue;
						}
						SfsTournamentConnector sfsTournamentConnector2 = <>4__this;
						if ((object)<>4__this != null)
						{
							object obj12 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v39+E4]");
							bool flag7 = (nint)0 == 0;
							object obj13 = !flag7;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							SetSeat((int)enumerator5, -1, sfsTournamentConnector2.eventsChannel);
							num = (nint)sfsTournamentConnector2.eventsChannel;
							continue;
						}
						goto IL_040e;
					}
					object obj14 = (nint)0 + (nint)2384;
					dictionary = (Dictionary<int, int>)obj14;
					enumerator9.Dispose();
					enumerator = enumerator10;
					enumerator6 = enumerator5;
					enumerator3 = (Dictionary<int, int>.Enumerator)enumerator10;
					enumerator7 = (Dictionary<int, int>.Enumerator)0;
					goto IL_0333;
				}
			}
			goto IL_0546;
			IL_0546:
			NullReferenceException ex = new NullReferenceException();
			if ((nint)dictionary == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj15 = (nint)0 + (nint)2384;
				dictionary = (Dictionary<int, int>)obj15;
				enumerator.Dispose();
				object obj16 = default(object);
				bool flag8 = obj16 == null;
				enumerator7 = (Dictionary<int, int>.Enumerator)obj16;
				if (flag8)
				{
					goto IL_0333;
				}
				OutOfMemoryException ex2 = new OutOfMemoryException();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22392FC");
				NullReferenceException ex3 = (NullReferenceException)(object)ex2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CBC9E0");
				NullReferenceException ex3 = ex;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_03bc:
			NullReferenceException ex4 = new NullReferenceException();
			enumerator = (List<int>.Enumerator)0;
			enumerator3 = enumerator7;
			enumerator7 = (Dictionary<int, int>.Enumerator)0;
			goto IL_043e;
			IL_043e:
			enumerator6 = enumerator5;
			goto IL_0546;
			IL_03e6:
			NullReferenceException ex5 = new NullReferenceException();
			enumerator = enumerator10;
			enumerator3 = (Dictionary<int, int>.Enumerator)enumerator10;
			enumerator7 = (Dictionary<int, int>.Enumerator)0;
			goto IL_043e;
			IL_040e:
			NullReferenceException ex6 = new NullReferenceException();
			enumerator = enumerator10;
			enumerator3 = (Dictionary<int, int>.Enumerator)enumerator10;
			enumerator7 = (Dictionary<int, int>.Enumerator)0;
			dictionary = (Dictionary<int, int>)enumerator5;
			goto IL_043e;
			IL_0333:
			SfsTournamentConnector sfsTournamentConnector3 = <>4__this;
			if ((object)<>4__this != null && (object)sfsTournamentConnector3.eventsChannel != null)
			{
				sfsTournamentConnector3.eventsChannel.TriggerTournamentsChanged();
				bool flag9 = (object)<>4__this == null;
				dictionary = null;
				if (!flag9)
				{
					<>4__this.UpdateTournamentsCounter();
					return;
				}
			}
			goto IL_0546;
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public TournamentType type;

		public int lastSeenId;

		internal bool <NewTournamentsCount>b__0(TournamentModel model)
		{
			//IL_04e5: Expected I4, but got O
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_00d6: Expected O, but got I4
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected O, but got Unknown
			//IL_0151: Expected O, but got I4
			//IL_01ac: Expected O, but got I4
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Expected O, but got Unknown
			//IL_01f8: Expected O, but got I4
			//IL_0221: Expected O, but got I
			//IL_031d: Expected O, but got I4
			//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0402: Expected O, but got Unknown
			//IL_040a: Expected I, but got O
			//IL_041a: Expected O, but got I
			//IL_04a9: Expected O, but got I4
			//IL_053f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0544: Expected O, but got Unknown
			//IL_056c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0571: Expected I4, but got Unknown
			//IL_0586: Unknown result type (might be due to invalid IL or missing references)
			//IL_058b: Expected I4, but got Unknown
			//IL_05b3: Expected O, but got I4
			//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c0: Expected I4, but got Unknown
			//IL_0455: Expected O, but got I
			//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bb: Expected O, but got Unknown
			//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c9: Expected O, but got Unknown
			//IL_04d2: Expected O, but got I4
			//IL_0463: Unknown result type (might be due to invalid IL or missing references)
			//IL_0468: Expected O, but got Unknown
			//IL_0471: Unknown result type (might be due to invalid IL or missing references)
			//IL_0476: Expected O, but got Unknown
			bool flag8;
			object obj19;
			if (model != null)
			{
				if (model.<Info>k__BackingField != null)
				{
					object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v6+E4]");
					if ((nint)0 != 0)
					{
						if (IsMyClanTournament(model))
						{
							goto IL_0092;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool flag = IsMyClanTournament(model);
						bool flag2 = !flag;
						object obj3 = !flag2;
						if (obj3 != null)
						{
							goto IL_0092;
						}
					}
					TournamentData <Info>k__BackingField = model.<Info>k__BackingField;
					if (model.<Info>k__BackingField == null)
					{
						goto IL_04d7;
					}
					object obj4 = typeof(DataRelation) + 712;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v9+E4]");
					bool flag3 = (nint)0 == 0;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					DateTime now = DateTime.Now;
					bool flag4 = <Info>k__BackingField.<AvailabilityTime>k__BackingField > now;
					bool flag5 = !flag4;
					object obj7 = !flag5;
					if (obj7 == null)
					{
						object obj8 = typeof(Queue<string>) + 848;
						object obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v15+E4]");
						bool flag6 = (nint)0 == 0;
						object obj10 = !flag6;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj11 = (nint)0 + (nint)2200;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
						SessionModel sessionModel = default(SessionModel);
						if ((object)sessionModel == null)
						{
							goto IL_04d7;
						}
						User localUser = sessionModel.LocalUser;
						TicketRecord tournamentTickets = SFSKammelnaUserExtensions.GetTournamentTickets(localUser, type);
						if (tournamentTickets == null || tournamentTickets.<RemainingCount>k__BackingField != 0)
						{
							TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(model.<Room>k__BackingField);
							if (!TournamentStatusExtensions.IsStarted(tournamentStatus))
							{
								object obj12 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v24+E4]");
								bool flag7 = (nint)0 == 0;
								object obj13 = !flag7;
								if (obj13 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
								SessionModel sessionModel2 = default(SessionModel);
								if ((object)sessionModel2 != null)
								{
									User localUser2 = sessionModel2.LocalUser;
									if (model.<Info>k__BackingField != null)
									{
										flag8 = model.<Info>k__BackingField.CanParticipate(localUser2);
										if (!flag8)
										{
											goto IL_0502;
										}
										Room <Room>k__BackingField = model.<Room>k__BackingField;
										if (model.<Room>k__BackingField != null)
										{
											object obj14 = typeof(RegisteredWaitHandle) + 1376;
											nint num = (nint)<Room>k__BackingField;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
											object obj15 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
											if ((nint)0 == 0)
											{
												goto IL_0496;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
											object obj16 = (nint)0 + (nint)8;
											while (true)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X10_v5-8]");
												if (0 == (nint)obj14)
												{
													break;
												}
												obj16 += 16;
												obj15--;
												if ((nint)obj15 != 1)
												{
													continue;
												}
												goto IL_0496;
											}
											object obj17 = num + obj16;
											object obj18 = obj17 + 312;
											obj19 = 0;
											goto IL_052b;
										}
									}
								}
								goto IL_04d7;
							}
						}
					}
				}
				return false;
			}
			goto IL_04d7;
			IL_0092:
			flag8 = false;
			goto IL_0502;
			IL_0502:
			return flag8;
			IL_052b:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v328 @ X0_v31] (should have been resolved before IL gen)");
			object obj21 = default(object);
			object obj20 = obj21 - lastSeenId;
			bool flag9 = (nint)obj20 < 0;
			bool flag10 = obj20 == null;
			int num2 = obj21 ^ lastSeenId;
			object obj22 = obj21 ^ obj20;
			int num3 = num2 & obj22;
			bool flag11 = num3 < 0;
			bool flag12 = flag9 == flag11;
			object obj23 = !flag10;
			return (byte)((flag12 & obj23) ? 1 : 0) != 0;
			IL_0496:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj19 = 0;
			goto IL_052b;
			IL_04d7:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public List<Room> tournamentRooms;

		internal bool <LoadUserTournaments>b__1(Tournament tournament)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00a5: Expected I4, but got O
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_007a: Expected I, but got O
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3232;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (obj2 != null)
			{
				object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3160;
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2 + 16;
				obj5 = tournament;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj4);
				return Enumerable.Any(tournamentRooms, func);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass5_1
	{
		public Tournament tournament;

		internal bool <LoadUserTournaments>b__2(Room room)
		{
			//IL_0075: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			//IL_00c4: Expected I4, but got O
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected O, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected I4, but got Unknown
			//IL_0048: Expected I8, but got O
			//IL_005f: Expected O, but got I4
			TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(room);
			object obj2;
			long? num2;
			if (tournamentInfo != null)
			{
				object obj = (??)tournamentInfo.<TournamentId>k__BackingField & 1;
				if (obj != null)
				{
					long value = (object?)tournamentInfo.<TournamentId>k__BackingField >> 32;
					long? num = value;
					obj2 = 0;
					num2 = num;
					goto IL_00ee;
				}
			}
			obj2 = 0;
			num2 = (long?)(object)0;
			goto IL_00ee;
			IL_00ee:
			Tournament tournament = this.tournament;
			if (this.tournament != null)
			{
				object obj3 = obj2 - tournament.id;
				bool flag = obj3 == null;
				return (byte)(((??)num2 & flag) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass5_2
	{
		public Tournament tournament;

		internal void <LoadUserTournaments>b__3()
		{
			Tournament tournament = this.tournament;
			SFS.SendLoadTournamentRequest(tournament.id);
		}
	}

	private static readonly Dictionary<int, int> seatsCache;

	private TournamentsEventsChannel eventsChannel;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004c: Expected O, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_0163: Expected I, but got O
		//IL_0089: Expected I, but got O
		//IL_00b4: Expected I, but got O
		//IL_00da: Expected I, but got O
		//IL_0105: Expected I, but got O
		//IL_012b: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)3544;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)3552;
		object obj5 = (nint)0 + (nint)3536;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3840;
		object obj7 = (nint)0 + (nint)3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoom += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		SFS.OnRoomGroupSubscribe += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj4);
		SFS.OnRoomGroupUnsubscribe += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj5);
		SFS.OnRoomCreated += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj5);
		SFS.OnRoomRemoved += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action6 = default(Action<System.Int32Enum>);
		action6..ctor((object)this, (IntPtr)obj7);
		eventsChannel.OnLastSeenUpdated += (Action<TournamentType>)(object)action6;
		TryInitializeTournaments();
	}

	private void TryInitializeTournaments()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0075: Expected I, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (SFS.IsSubscribedToGroup(RoomGroup.Tournaments))
		{
			object obj = typeof(RegisteredWaitHandle) + 1392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			InitializeTournaments(null);
		}
		else
		{
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj3 = (nint)0 + (nint)3528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj3);
			SFS.OnRoomGroupSubscribe += action;
		}
	}

	private void InitializeTournaments(string groupName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e6: Expected O, but got I4
		//IL_013c: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D21]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			CheckUserTournaments();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			CheckUserTournaments();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_0082;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		LoadUserTournaments();
		CheckTournamentAvailability();
		TournamentsEventsChannel tournamentsEventsChannel = eventsChannel;
		bool flag3 = (object)eventsChannel == null;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a1;
		IL_0082:
		LoadUserTournaments();
		CheckTournamentAvailability();
		tournamentsEventsChannel = eventsChannel;
		goto IL_00a1;
		IL_00a1:
		tournamentsEventsChannel.TriggerTournamentsChanged();
	}

	private static void LoadUserTournaments()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_051c: Expected O, but got I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_018a: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_01bc: Expected O, but got I4
		//IL_0141: Expected O, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00ea: Expected O, but got I
		//IL_00fa: Expected O, but got I
		//IL_024a: Expected O, but got I
		//IL_0256: Expected O, but got I
		//IL_01f4: Expected O, but got I4
		//IL_0287: Expected I, but got O
		//IL_028f: Expected I, but got O
		//IL_0540: Expected O, but got I
		//IL_0551: Expected I, but got O
		//IL_056f: Expected O, but got I
		//IL_0224: Expected O, but got I
		//IL_0343: Expected O, but got I4
		//IL_02fb: Expected O, but got I4
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0371: Expected O, but got I
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_0391: Expected O, but got I
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_03ae: Expected O, but got I4
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_047e: Expected I, but got O
		//IL_048f: Expected I, but got O
		//IL_04b9: Expected O, but got I4
		//IL_03c9: Expected F4, but got I4
		//IL_03fa: Expected O, but got I4
		//IL_0403: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3224;
		object obj2 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<Tournament> createdTournaments = UserInfo.CreatedTournaments;
		IEnumerable<Room> tournamentRooms = SFS.TournamentRooms;
		List<object> list = Enumerable.ToList((IEnumerable<object>)tournamentRooms);
		object obj6 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3200;
		object obj7 = obj3 + 16;
		obj7 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v45+E4]");
		object obj10;
		Predicate<object> match;
		object obj11;
		object obj9;
		if ((nint)0 != 0)
		{
			obj9 = typeof(List<Tween>) + 3560;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v45+B8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v16+8]");
			match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v16+8]");
			bool flag2 = (nint)0 == 0;
			obj11 = obj9;
			if (!flag2)
			{
				goto IL_0127;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj6;
			obj9 = typeof(List<Tween>) + 3560;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v45+B8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v16+8]");
			match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v16+8]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			obj11 = obj9;
			if (obj12 != null)
			{
				goto IL_0127;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v45+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v20+B8]");
			obj10 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)2104;
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj10, (IntPtr)obj15);
		object obj16 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v19+B8]");
		object obj17 = (nint)0 + (nint)8;
		obj17 = predicate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		match = predicate;
		obj9 = obj11;
		goto IL_023e;
		IL_023e:
		object obj18 = (nint)0 + (nint)1256;
		object obj19 = (nint)0 + (nint)2144;
		int num = ((List<object>)(object)createdTournaments).RemoveAll(match);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Predicate<object> predicate2 = default(Predicate<object>);
		predicate2..ctor(obj3, (IntPtr)obj19);
		nint num2 = (nint)obj18;
		int num3 = ((List<object>)(object)createdTournaments).RemoveAll(predicate2);
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v24+E4]");
		if ((nint)0 != 0)
		{
			UserInfo.CreatedTournaments = createdTournaments;
			bool flag5 = createdTournaments._size >= 1;
			object obj21 = 0;
			if (!flag5)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UserInfo.CreatedTournaments = createdTournaments;
			bool flag6 = createdTournaments._size < 1;
			object obj21 = 0;
			if (flag6)
			{
				return;
			}
		}
		object obj22 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3240;
		object obj23 = (nint)0 + (nint)1272;
		object obj24 = typeof(SqlSingle[]) + 2376;
		object obj25 = (nint)0 + (nint)2160;
		object obj26 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj27 = 0;
		int num4 = 0;
		object obj28 = default(object);
		Action action = default(Action);
		bool flag8;
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj28..ctor();
			object obj29 = ((List<object>)(object)createdTournaments).get_Item(num4);
			object obj30 = obj28 + 16;
			obj30 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			num2 = (nint)obj25;
			action..ctor(obj28, (IntPtr)obj25);
			object obj31 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v37+E4]");
			bool flag7 = (nint)0 == 0;
			object obj32 = !flag7;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSecondsPermanently(num4, action);
			int num5 = num4 + 1;
			flag8 = num5 >= createdTournaments._size;
			obj27 = 0;
			object obj21 = 0;
			num4 = num5;
		}
		while (!flag8);
		return;
		IL_0127:
		bool flag9 = createdTournaments == null;
		object obj33 = !flag9;
		if (obj33 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_023e;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004c: Expected O, but got I
		//IL_0058: Expected O, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_018f: Expected I, but got O
		//IL_0095: Expected I, but got O
		//IL_00c0: Expected I, but got O
		//IL_00e6: Expected I, but got O
		//IL_0111: Expected I, but got O
		//IL_0137: Expected I, but got O
		//IL_0162: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)3528;
		object obj3 = (nint)0 + (nint)3552;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj5 = (nint)0 + (nint)3544;
		object obj6 = (nint)0 + (nint)3536;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3840;
		object obj8 = (nint)0 + (nint)3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnRoomGroupSubscribe -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj3);
		SFS.OnRoomGroupSubscribe -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj3);
		SFS.OnRoomGroupUnsubscribe -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj5);
		SFS.OnJoinRoom -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj6);
		SFS.OnRoomCreated -= action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj6);
		SFS.OnRoomRemoved -= action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action7 = default(Action<System.Int32Enum>);
		action7..ctor((object)this, (IntPtr)obj8);
		eventsChannel.OnLastSeenUpdated -= (Action<TournamentType>)(object)action7;
	}

	private void TriggerTournamentsChanged(string _)
	{
		eventsChannel.TriggerTournamentsChanged();
	}

	private void TriggerTournamentsChanged(Room _)
	{
		eventsChannel.TriggerTournamentsChanged();
	}

	private void TriggerTournamentsChanged()
	{
		eventsChannel.TriggerTournamentsChanged();
	}

	private void RefreshTournaments(Room r)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0055: Expected O, but got I4
		//IL_008f: Expected I4, but got I8
		if (SFSKammelnaRoomExtensions.IsTournamentHub(r))
		{
			TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(r);
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SetSeat(tournamentInfo.<RoomId>k__BackingField, -1, eventsChannel);
			eventsChannel.TriggerTournamentsChanged();
			UpdateTournamentsCounter();
			CheckAvailability(tournamentInfo);
		}
	}

	public static bool CanJoin(Room room, TournamentData info)
	{
		//IL_0430: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_0045: Expected O, but got I
		//IL_00fa: Expected I, but got O
		//IL_00ff: Expected I, but got O
		//IL_010f: Expected O, but got I
		//IL_0080: Expected O, but got I
		//IL_0211: Expected O, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_01ad: Expected O, but got I4
		//IL_01c5: Expected O, but got I
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02eb: Expected O, but got I4
		//IL_0314: Expected O, but got I
		//IL_038e: Expected O, but got I4
		//IL_03c3: Expected O, but got I4
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_040a: Expected O, but got I4
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected I4, but got Unknown
		object obj2;
		nint num2;
		int roomId;
		int num4 = default(int);
		object obj7;
		object obj9;
		nint num3 = default(nint);
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00c1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v10-8]");
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
				goto IL_00c1;
			}
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ X0_v33] (should have been resolved before IL gen)");
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			num2 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v33+8]");
			obj9 = 0;
			roomId = num4;
			if (obj8 != null)
			{
				goto IL_0125;
			}
			goto IL_01db;
		}
		goto IL_0422;
		IL_0125:
		if (IsParticipating(num4))
		{
			goto IL_014f;
		}
		goto IL_0227;
		IL_0227:
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(room);
		bool flag2 = TournamentStatusExtensions.IsScheduled(tournamentStatus);
		if (flag2)
		{
			int tournamentParticipantsCount = SFSKammelnaRoomExtensions.GetTournamentParticipantsCount(room);
			if (info != null)
			{
				if (tournamentParticipantsCount >= info.<MaxAllowedSize>k__BackingField)
				{
					return false;
				}
				object obj10 = typeof(Queue<string>) + 848;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v12+E4]");
				bool flag3 = (nint)0 == 0;
				object obj12 = !flag3;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj13 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				if ((object)sessionModel != null)
				{
					User localUser = sessionModel.LocalUser;
					PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser);
					if (rank != null)
					{
						object obj14 = info.<RankLimit>k__BackingField - rank.<Rank>k__BackingField;
						bool flag4 = (nint)obj14 < 0;
						bool flag5 = obj14 == null;
						object obj15 = info.<RankLimit>k__BackingField ^ rank.<Rank>k__BackingField;
						object obj16 = info.<RankLimit>k__BackingField ^ obj14;
						object obj17 = obj15 & obj16;
						bool flag6 = (nint)obj17 < 0;
						bool flag7 = flag4 == flag6;
						object obj18 = !flag7;
						return (byte)((obj18 | flag5) ? 1 : 0) != 0;
					}
				}
			}
			goto IL_0422;
		}
		goto IL_0471;
		IL_014f:
		flag2 = true;
		goto IL_0471;
		IL_0422:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0471:
		return flag2;
		IL_00c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ X0_v30] (should have been resolved before IL gen)");
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v16+E4]");
		bool flag8 = (nint)0 == 0;
		num3 = unchecked((nint)null);
		num2 = unchecked((nint)null);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v30+8]");
		obj9 = 0;
		roomId = num4;
		if (!flag8)
		{
			goto IL_0125;
		}
		goto IL_01db;
		IL_01db:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag9 = IsParticipating(roomId);
		bool flag10 = !flag9;
		object obj19 = !flag10;
		num3 = num2;
		if (obj19 != null)
		{
			goto IL_014f;
		}
		goto IL_0227;
	}

	private unsafe void UpdateLastSeen(TournamentType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b5: Expected I, but got O
		//IL_019a: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01ba: Expected O, but got I
		//IL_01dc: Expected O, but got I4
		//IL_0204: Expected O, but got I
		//IL_0896: Expected O, but got I4
		//IL_00ff: Expected O, but got I
		//IL_010f: Expected O, but got I
		//IL_011f: Expected O, but got I
		//IL_0141: Expected O, but got I4
		//IL_0928: Expected O, but got I
		//IL_0937: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Expected O, but got Unknown
		//IL_094c: Expected O, but got I
		//IL_095c: Expected O, but got I
		//IL_097e: Expected O, but got I4
		//IL_0234: Expected O, but got I4
		//IL_0a41: Expected I4, but got O
		//IL_0a6b: Expected O, but got I4
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected O, but got Unknown
		//IL_08d6: Expected O, but got I
		//IL_08e7: Expected I, but got O
		//IL_0905: Expected O, but got I
		//IL_0177: Expected O, but got I
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_02c7: Expected O, but got I4
		//IL_0264: Expected O, but got I
		//IL_099b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected O, but got Unknown
		//IL_09b6: Expected O, but got I
		//IL_09c7: Expected I, but got O
		//IL_09e5: Expected O, but got I
		//IL_035e: Expected O, but got Ref
		//IL_02f7: Expected O, but got I
		//IL_041b: Expected O, but got I4
		//IL_03bb: Expected O, but got I4
		//IL_0679: Expected O, but got Ref
		//IL_06a7: Expected O, but got I4
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected O, but got Unknown
		//IL_0763: Expected O, but got I4
		//IL_0641: Expected I4, but got I8
		//IL_0488: Expected I4, but got I8
		//IL_04a2: Expected O, but got I4
		//IL_07d9: Expected O, but got I4
		//IL_07f2: Expected O, but got I4
		//IL_0585: Expected O, but got I4
		//IL_05fb: Expected O, but got I4
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected I4, but got Unknown
		object obj = typeof(SqlSingle[]) + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		TournamentType[] array = default(TournamentType[]);
		object obj3;
		object obj6;
		Func<object, bool> predicate;
		IEnumerable<object> source;
		object obj8;
		IEnumerable<TournamentModel> enumerable2;
		object obj5;
		if (array != null)
		{
			object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			BaseTournamentFilter baseTournamentFilter = default(BaseTournamentFilter);
			baseTournamentFilter..ctor(array);
			if ((object)eventsChannel != null)
			{
				IEnumerable<TournamentModel> tournaments = eventsChannel.GetTournaments();
				if (baseTournamentFilter != null)
				{
					obj3 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3200;
					nint num = (nint)baseTournamentFilter;
					IEnumerable<TournamentModel> enumerable = baseTournamentFilter.ApplyFilter(tournaments);
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v87+E4]");
					if ((nint)0 != 0)
					{
						obj5 = (nint)0 + (nint)3808;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v87+B8]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v43+10]");
						predicate = (Func<object, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v43+10]");
						bool flag = (nint)0 == 0;
						object obj7 = !flag;
						source = enumerable;
						if (obj7 == null)
						{
							obj8 = obj5;
							enumerable2 = enumerable;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v43+10]");
							Func<object, bool> func = (Func<object, bool>)0;
							goto IL_0212;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj4 = obj3;
						obj8 = (nint)0 + (nint)3808;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v87+B8]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v43+10]");
						Func<object, bool> func = (Func<object, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v43+10]");
						bool flag2 = (nint)0 == 0;
						object obj9 = !flag2;
						enumerable2 = enumerable;
						obj5 = obj8;
						source = enumerable;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v43+10]");
						predicate = (Func<object, bool>)0;
						if (obj9 == null)
						{
							goto IL_0212;
						}
					}
					goto IL_085b;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_04c1:
		bool flag3 = type == TournamentType.Official;
		IEnumerable<object> enumerable4;
		IEnumerable<object> enumerable3 = enumerable4;
		string text2;
		string text = text2;
		if (!flag3)
		{
			goto IL_04ee;
		}
		goto IL_071a;
		IL_054f:
		int num2 = CounterBubbleManager.GetCount(CounterBubbleType.Tournaments);
		object obj11;
		object obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = 0;
		int num3 = num2;
		if (!flag4)
		{
			goto IL_059b;
		}
		goto IL_0808;
		IL_04ee:
		obj11 = typeof(UsageHint) + 72;
		object obj14;
		object obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X0_v37+E4]");
		bool flag5 = (nint)0 == 0;
		enumerable3 = enumerable4;
		text = text2;
		int num4;
		TournamentType tournamentType = (TournamentType)num4;
		object obj15 = obj11;
		if (!flag5)
		{
			goto IL_054f;
		}
		goto IL_0792;
		IL_066f:
		TournamentType tournamentType2 = default(TournamentType);
		string text3 = ((Enum)(&tournamentType2)).ToString();
		object obj16 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v47+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.Tournaments, 0, text3);
		bool flag7 = type != TournamentType.Official;
		enumerable4 = null;
		text2 = text3;
		num4 = 0;
		enumerable3 = null;
		text = text3;
		if (flag7)
		{
			goto IL_04ee;
		}
		goto IL_071a;
		IL_043b:
		object obj18 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v59+E4]");
		if ((nint)0 != 0)
		{
			int count = CounterBubbleManager.GetCount(CounterBubbleType.Tournaments);
			int num5 = (int)(count & 0x80000000L);
			bool flag8 = num5 == 0;
			object obj19 = !flag8;
			num4 = 0;
			string text4 = text2;
			if (obj19 == null)
			{
				goto IL_04c1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int count2 = CounterBubbleManager.GetCount(CounterBubbleType.Tournaments);
			int num6 = (int)(count2 & 0x80000000L);
			bool flag9 = num6 == 0;
			num4 = 0;
			string text4 = text2;
			if (flag9)
			{
				goto IL_04c1;
			}
		}
		goto IL_066f;
		IL_0792:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num2 = CounterBubbleManager.GetCount(CounterBubbleType.Tournaments);
		obj10 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v19+E4]");
		bool flag10 = (nint)0 == 0;
		object obj20 = !flag10;
		enumerable3 = enumerable4;
		text = text2;
		obj12 = 0;
		num3 = num2;
		if (obj20 != null)
		{
			goto IL_059b;
		}
		goto IL_0808;
		IL_0808:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num2 = num3;
		goto IL_059b;
		IL_0212:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v87+E4]");
		bool flag11 = (nint)0 == 0;
		object obj21 = !flag11;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj22 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v49+B8]");
			obj6 = 0;
		}
		object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)2112;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj6, (IntPtr)obj24);
		object obj25 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v48+B8]");
		object obj26 = (nint)0 + (nint)16;
		obj26 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj5 = obj8;
		source = enumerable2;
		predicate = func2;
		goto IL_085b;
		IL_071a:
		UpdateLastSeen(TournamentType.OfficialMonthly);
		obj11 = typeof(UsageHint) + 72;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X0_v37+E4]");
		bool flag12 = (nint)0 == 0;
		object obj27 = !flag12;
		enumerable4 = enumerable3;
		text2 = text;
		tournamentType = TournamentType.OfficialMonthly;
		obj15 = obj11;
		if (obj27 != null)
		{
			goto IL_054f;
		}
		goto IL_0792;
		IL_059b:
		bool flag13 = num2 < 0;
		bool flag14 = num2 == 0;
		int num7 = num2 ^ num2;
		int num8 = num2 & num7;
		bool flag15 = num8 < 0;
		bool flag16 = flag13 == flag15;
		object obj28 = !flag14;
		bool hasUnseenTournaments = (byte)((flag16 & obj28) ? 1 : 0) != 0;
		UserInfo.HasUnseenTournaments = hasUnseenTournaments;
		return;
		IL_085b:
		IEnumerable<object> enumerable5 = Enumerable.Where(source, predicate);
		object obj29 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v19+E4]");
		bool flag17 = (nint)0 == 0;
		object obj30 = !flag17;
		enumerable4 = enumerable5;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj29 = obj3;
			enumerable4 = enumerable5;
		}
		object obj31 = (nint)0 + (nint)1896;
		object obj32 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v19+B8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v34+18]");
		Func<object, int?> func3 = (Func<object, int?>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v34+18]");
		bool flag18 = (nint)0 == 0;
		object obj34 = !flag18;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v19+E4]");
			bool flag19 = (nint)0 == 0;
			object obj35 = !flag19;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj36 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v40+B8]");
				obj33 = 0;
			}
			object obj37 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj38 = (nint)0 + (nint)2120;
			Func<object, int?> func4 = default(Func<object, int?>);
			func4..ctor(obj33, (IntPtr)obj38);
			object obj39 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v39+B8]");
			object obj40 = (nint)0 + (nint)24;
			obj40 = func4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func3 = func4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCAA14");
		object obj41 = default(object);
		int value = obj41 >> 32;
		object obj42 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v23+E4]");
		bool flag20 = (nint)0 == 0;
		object obj43 = !flag20;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj44 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
		obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object format = "LAK" + 536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string key = string.Format((string)format, arg);
		Prefs.SetInt(key, value);
		string text5 = ((Enum)(&tournamentType2)).ToString();
		object obj45 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v32+E4]");
		if ((nint)0 != 0)
		{
			int count3 = CounterBubbleManager.GetCount(CounterBubbleType.Tournaments, text5);
			bool flag21 = count3 == 0;
			object obj46 = !flag21;
			string text4 = null;
			if (obj46 == null)
			{
				text2 = null;
				string text6 = text5;
				goto IL_043b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int count4 = CounterBubbleManager.GetCount(CounterBubbleType.Tournaments, text5);
			bool flag22 = count4 == 0;
			object obj47 = !flag22;
			text2 = null;
			string text6 = text5;
			string text4 = null;
			if (obj47 == null)
			{
				goto IL_043b;
			}
		}
		goto IL_066f;
	}

	public static bool IsParticipating(int roomId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_015f: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_01c7: Expected O, but got I
		//IL_01f1: Expected O, but got I4
		//IL_018d: Expected O, but got I
		//IL_01a7: Expected O, but got I4
		//IL_0109: Expected O, but got I
		//IL_012a: Expected I4, but got O
		//IL_00bc: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DDB]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DDC]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_01b5;
		IL_00f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v18+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D6B19C");
		object obj10 = default(object);
		object obj9 = ~obj10;
		return (byte)(obj9 >> 31) != 0;
		IL_020f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj11 = obj2;
		object obj13;
		object obj12 = obj13;
		goto IL_00f9;
		IL_00b0:
		obj12 = (nint)0 + (nint)3256;
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v18+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = obj11;
		obj13 = obj12;
		if (!flag3)
		{
			goto IL_00f9;
		}
		goto IL_020f;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DDC]");
		object obj15 = (nint)0 & (nint)1;
		if (obj15 != null)
		{
			goto IL_00b0;
		}
		goto IL_01b5;
		IL_01b5:
		_ = 1;
		obj12 = (nint)0 + (nint)3256;
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		obj14 = obj11;
		obj13 = obj12;
		if (obj16 != null)
		{
			goto IL_00f9;
		}
		goto IL_020f;
	}

	public static int GetSeat(int roomId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003c: Expected O, but got I
		//IL_0066: Expected O, but got I4
		//IL_0084: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		object obj2 = (nint)0 + (nint)3256;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D6B19C");
		int result = default(int);
		return result;
	}

	public static void SetSeat(int roomId, int seat, TournamentsEventsChannel channel)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_0129: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D26]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v16+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v16+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v7+B8]");
		object obj7 = 0;
		Dictionary<int, int> dictionary = (Dictionary<int, int>)obj7;
		goto IL_0136;
		IL_0136:
		dictionary.set_Item(roomId, seat);
		channel.TriggerTournamentSeatChanged(roomId, seat);
		return;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v16+B8]");
		object obj8 = 0;
		dictionary = (Dictionary<int, int>)obj8;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0136;
	}

	private void CheckUserTournaments()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_010c: Expected O, but got I
		//IL_011c: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_014e: Expected O, but got I4
		//IL_01f6: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_00b1: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_04a9: Expected O, but got I
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected O, but got Unknown
		//IL_04ce: Expected O, but got I
		//IL_04de: Expected O, but got I
		//IL_0500: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_043e: Expected O, but got I
		//IL_044f: Expected I, but got O
		//IL_046d: Expected O, but got I
		//IL_0488: Expected O, but got I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02df: Expected O, but got I4
		//IL_023d: Expected O, but got I4
		//IL_01b6: Expected O, but got I
		//IL_059f: Expected O, but got I
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected O, but got Unknown
		//IL_0538: Expected O, but got I
		//IL_0549: Expected I, but got O
		//IL_0567: Expected O, but got I
		//IL_0582: Expected O, but got I4
		//IL_0310: Expected O, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_0330: Expected O, but got I
		//IL_033c: Expected O, but got I
		//IL_026d: Expected O, but got I
		//IL_0369: Expected I, but got O
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03d8: Expected O, but got I
		//IL_03e9: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3200;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IEnumerable<Room> tournamentRooms = SFS.TournamentRooms;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v48+E4]");
		object obj7;
		Func<object, bool> predicate;
		object obj9;
		object obj6;
		if ((nint)0 != 0)
		{
			obj6 = (nint)0 + (nint)3736;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v48+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v26+20]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v26+20]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				obj9 = obj6;
				goto IL_0164;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj3;
			obj9 = (nint)0 + (nint)3736;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v48+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v26+20]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v26+20]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			obj6 = obj9;
			if (obj10 == null)
			{
				goto IL_0164;
			}
		}
		goto IL_01bb;
		IL_0164:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v48+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v32+B8]");
			obj7 = 0;
		}
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)2088;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj7, (IntPtr)obj14);
		object obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v31+B8]");
		object obj16 = (nint)0 + (nint)32;
		obj16 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj17 = 0;
		predicate = func;
		obj6 = obj9;
		goto IL_01bb;
		IL_01bb:
		IEnumerable<object> source = Enumerable.Where(tournamentRooms, predicate);
		object obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v16+E4]");
		bool flag4 = (nint)0 == 0;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj3;
		}
		object obj20 = (nint)0 + (nint)3960;
		object obj21 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v16+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v17+28]");
		Func<object, int> selector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v17+28]");
		bool flag5 = (nint)0 == 0;
		object obj23 = !flag5;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v16+E4]");
			bool flag6 = (nint)0 == 0;
			object obj24 = !flag6;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj25 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v23+B8]");
				obj22 = 0;
			}
			object obj26 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj27 = (nint)0 + (nint)2096;
			Func<object, int> func2 = default(Func<object, int>);
			func2..ctor(obj22, (IntPtr)obj27);
			object obj28 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v22+B8]");
			object obj29 = (nint)0 + (nint)40;
			obj29 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj17 = 0;
			selector = func2;
		}
		IEnumerable<int> source2 = Enumerable.Select(source, selector);
		List<int> list = Enumerable.ToList(source2);
		object obj30 = obj2 + 24;
		obj30 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj31 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v24+E4]");
		bool flag7 = (nint)0 == 0;
		object obj32 = !flag7;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj21;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v24+B8]");
		object obj33 = 0;
		object obj34 = (nint)0 + (nint)944;
		object obj35 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
		object obj36 = (nint)0 + (nint)3232;
		object obj37 = (nint)0 + (nint)1888;
		Dictionary<int, int>.KeyCollection keys = ((Dictionary<int, int>)obj33).Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<int, bool> func3 = default(Func<int, bool>);
		func3..ctor((object)keys, (IntPtr)obj36);
		if (Enumerable.All((IEnumerable<int>)obj30, func3))
		{
			UpdateTournamentsCounter();
			return;
		}
		GameObject lifecycle = base.gameObject;
		object obj38 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj39 = (nint)0 + (nint)2128;
		SFS.TournamentSeatsSuccess tournamentSeatsSuccess = default(SFS.TournamentSeatsSuccess);
		tournamentSeatsSuccess..ctor(obj2, (IntPtr)obj39);
		SFS.GetMyTournaments(lifecycle, tournamentSeatsSuccess);
	}

	public void CheckTournamentAvailability()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0022: Expected I, but got O
		//IL_0032: Expected O, but got I
		//IL_010c: Expected O, but got I
		//IL_0130: Expected O, but got I4
		//IL_0142: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_006d: Expected O, but got I
		//IL_02a5: Expected O, but got I
		//IL_016c: Expected O, but got I4
		//IL_0175: Expected O, but got I4
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Expected O, but got Unknown
		//IL_0378: Expected O, but got I4
		//IL_0629: Expected I, but got O
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01b6: Expected O, but got I
		//IL_01e1: Expected O, but got I4
		//IL_0204: Expected O, but got I4
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected O, but got Unknown
		//IL_02e0: Expected O, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_0512: Expected O, but got I4
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Expected O, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_086a: Expected O, but got I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_0311: Expected O, but got I
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_0543: Expected O, but got I
		//IL_03ea: Expected O, but got I
		//IL_05e2: Expected O, but got I4
		//IL_04bd: Expected O, but got I4
		//IL_057e: Expected O, but got I
		//IL_0425: Expected O, but got I
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected O, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected O, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected O, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected O, but got Unknown
		//IL_05a7: Expected O, but got I
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_0456: Expected O, but got I
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		IEnumerable<Room> tournamentRooms = SFS.TournamentRooms;
		object obj3;
		bool flag2 = default(bool);
		TournamentData tournamentData;
		object obj9 = default(object);
		object obj12;
		object obj10;
		object obj8;
		object obj11;
		object obj13 = default(object);
		object obj5 = default(object);
		if (tournamentRooms != null)
		{
			object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3696;
			nint num = (nint)tournamentRooms;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Sfs2X.Entities.Room>>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Sfs2X.Entities.Room>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ea;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Sfs2X.Entities.Room>>)+B0]");
			obj3 = (nint)0 + (nint)8;
			bool flag = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X10_v11-8]");
				object obj4 = 0 - obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X10_v11-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj5 = obj3 + 16;
				obj2--;
				obj4 = obj2 - 1;
				bool flag3 = obj4 == null;
				flag2 = (nint)obj2 != 1;
				flag = flag2;
				obj3 = obj5;
				if (flag2)
				{
					continue;
				}
				goto IL_00ea;
			}
			object obj6 = num + obj3;
			object obj7 = obj6 + 312;
			obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v31+8]");
			tournamentData = (TournamentData)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v236 @ X8_v31] (should have been resolved before IL gen)");
			bool flag4 = obj9 == null;
			obj10 = obj9;
			obj11 = 0;
			flag2 = flag;
			obj5 = obj3;
			obj10 = obj9;
			obj11 = 0;
			obj12 = obj13;
			if (!flag4)
			{
				goto IL_021b;
			}
			goto IL_0618;
		}
		goto IL_0708;
		IL_00ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj14 = default(object);
		obj8 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v45+8]");
		tournamentData = (TournamentData)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v150 @ X0_v45] (should have been resolved before IL gen)");
		bool flag5 = obj9 == null;
		object obj15 = !flag5;
		obj10 = obj9;
		obj11 = 0;
		obj13 = 0;
		if (obj15 != null)
		{
			goto IL_021b;
		}
		obj10 = obj9;
		obj11 = 0;
		obj12 = 0;
		obj3 = obj5;
		goto IL_0618;
		IL_021b:
		object obj16 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj17 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1128;
		object obj18 = obj9;
		object obj24 = default(object);
		object obj36 = default(object);
		Room room = default(Room);
		nint num2;
		while (true)
		{
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v20+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v20+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0365;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v20+B0]");
			object obj20 = (nint)0 + (nint)8;
			bool flag6 = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X10_v25-8]");
				object obj4 = 0 - obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X10_v25-8]");
				if (0 == (nint)obj16)
				{
					break;
				}
				obj5 = obj20 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v20+12E]");
				obj8 = -1;
				obj4 = obj8 - 1;
				bool flag3 = obj4 == null;
				flag2 = (nint)obj8 != 1;
				flag6 = flag2;
				obj20 = obj5;
				if (flag2)
				{
					continue;
				}
				goto IL_0365;
			}
			obj8 = obj20;
			object obj21 = obj19 + obj20;
			object obj22 = obj21 + 312;
			flag2 = flag6;
			obj5 = obj20;
			goto IL_0795;
			IL_0795:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v29+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v427 @ X0_v29] (should have been resolved before IL gen)");
			object obj23 = obj24 & 1;
			if (obj23 != null)
			{
				if (obj10 == null)
				{
					break;
				}
				object obj25 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v23+12E]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v23+12E]");
				if ((nint)0 == 0)
				{
					goto IL_04aa;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v23+B0]");
				object obj26 = (nint)0 + (nint)8;
				bool flag7 = flag2;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X10_v20-8]");
					object obj4 = 0 - obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X10_v20-8]");
					if (0 == (nint)obj17)
					{
						break;
					}
					obj5 = obj26 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v23+12E]");
					obj8 = -1;
					obj4 = obj8 - 1;
					bool flag3 = obj4 == null;
					flag2 = (nint)obj8 != 1;
					flag7 = flag2;
					obj26 = obj5;
					if (flag2)
					{
						continue;
					}
					goto IL_04aa;
				}
				obj8 = obj26;
				object obj27 = obj25 + obj26;
				object obj28 = obj27 + 312;
				flag2 = flag7;
				obj5 = obj26;
				goto IL_081c;
			}
			object obj29 = 0;
			while (true)
			{
				if (obj10 == null)
				{
					goto IL_0850;
				}
				object obj30 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj31 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v7+12E]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v7+12E]");
				if ((nint)0 == 0)
				{
					goto IL_05cf;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v7+B0]");
				object obj32 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X10_v7-8]");
					if (0 == (nint)obj30)
					{
						break;
					}
					obj5 = obj32 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v7+12E]");
					obj8 = -1;
					bool flag8 = (nint)obj8 != 1;
					obj32 = obj5;
					if (flag8)
					{
						continue;
					}
					goto IL_05cf;
				}
				obj8 = obj32;
				object obj33 = obj31 + obj32;
				object obj34 = obj33 + 312;
				obj5 = obj32;
				goto IL_089c;
				IL_0850:
				bool flag9 = obj29 == null;
				object obj35 = !flag9;
				if (obj35 == null)
				{
					return;
				}
				OutOfMemoryException ex = new OutOfMemoryException();
				if (num2 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj29 = obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj11 = obj36;
				continue;
				IL_05cf:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj13 = 0;
				goto IL_089c;
				IL_089c:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X0_v6+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v617 @ X0_v6] (should have been resolved before IL gen)");
				goto IL_0850;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_04aa:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj13 = 0;
			goto IL_081c;
			IL_081c:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v624 @ X0_v33] (should have been resolved before IL gen)");
			TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(room);
			if (tournamentInfo != null)
			{
				CheckAvailability(tournamentInfo);
			}
			bool flag10 = obj10 == null;
			obj18 = obj10;
			obj12 = obj13;
			obj3 = obj5;
			tournamentData = tournamentInfo;
			if (!flag10)
			{
				continue;
			}
			goto IL_0618;
			IL_0365:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj13 = 0;
			goto IL_0795;
		}
		NullReferenceException ex2 = new NullReferenceException();
		obj12 = obj13;
		obj3 = obj5;
		goto IL_064c;
		IL_0618:
		NullReferenceException ex3 = new NullReferenceException();
		num2 = (nint)tournamentData;
		goto IL_064c;
		IL_064c:
		obj13 = obj12;
		obj5 = obj3;
		goto IL_0708;
		IL_0708:
		throw new NullReferenceException();
	}

	private void CheckAvailability(TournamentData tournamentInfo)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0146: Expected O, but got I4
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01a9: Expected O, but got I
		//IL_01b7: Expected I, but got O
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01f5: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		if (tournamentInfo.<AvailabilityTime>k__BackingField > now)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now2 = DateTime.Now;
			TimeSpan timeSpan = tournamentInfo.<AvailabilityTime>k__BackingField - now2;
			object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan2 = default(TimeSpan);
			double totalSeconds = timeSpan2.TotalSeconds;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			object obj9 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)3520;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj10);
			object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v21+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float seconds = default(float);
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(seconds, action);
		}
	}

	private void UpdateTournamentsCounter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00fd: Expected O, but got I4
		//IL_0106: Expected O, but got I4
		//IL_006c: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		<UpdateTournamentsCounter>g__UpdateCounter|19_0(TournamentType.Public);
		<UpdateTournamentsCounter>g__UpdateCounter|19_0(TournamentType.Private);
		<UpdateTournamentsCounter>g__UpdateCounter|19_0(TournamentType.Official);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			int count = CounterBubbleManager.GetCount(CounterBubbleType.Tournaments);
			bool flag = count == 0;
			object obj3 = 0;
			if (flag)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int count2 = CounterBubbleManager.GetCount(CounterBubbleType.Tournaments);
			bool flag2 = count2 == 0;
			object obj4 = !flag2;
			object obj3 = 0;
			if (obj4 == null)
			{
				return;
			}
		}
		object obj5 = typeof(UsageHint) + 72;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			UserInfo.HasUnseenTournaments = true;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UserInfo.HasUnseenTournaments = true;
	}

	private int NewTournamentsCount(TournamentType type, int lastSeenId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0191: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0125: Expected O, but got I
		//IL_012e: Expected I, but got O
		//IL_015a: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(SqlSingle[]) + 320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			TournamentType[] array = default(TournamentType[]);
			if (array != null)
			{
				if (array.Length == 0)
				{
					goto IL_0183;
				}
				object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2264;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				BaseTournamentFilter baseTournamentFilter = default(BaseTournamentFilter);
				baseTournamentFilter..ctor(array);
				if ((object)eventsChannel != null)
				{
					IEnumerable<TournamentModel> tournaments = eventsChannel.GetTournaments();
					if (baseTournamentFilter != null)
					{
						object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3920;
						object obj6 = (nint)0 + (nint)2136;
						nint num = (nint)baseTournamentFilter;
						IEnumerable<TournamentModel> source = baseTournamentFilter.ApplyFilter(tournaments);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Func<object, bool> func = default(Func<object, bool>);
						func..ctor(obj2, (IntPtr)obj6);
						return Enumerable.Count(source, func);
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0183;
		IL_0183:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (int)ex2;
	}

	private static bool IsMyClanTournament(TournamentModel model)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_02f7: Expected I4, but got O
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_021a: Expected I, but got O
		//IL_022a: Expected O, but got I
		//IL_0265: Expected O, but got I
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D2C]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v18+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v18+E4]");
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
		goto IL_02e9;
		IL_02e9:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_02a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_031b;
		IL_031b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v236 @ X0_v8] (should have been resolved before IL gen)");
		int clanId;
		string clanChatTag = ClanUtils.GetClanChatTag(clanId);
		string text = default(string);
		return text == clanChatTag;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_0150;
		}
		goto IL_02e9;
		IL_0150:
		User localUser = sessionModel.LocalUser;
		if (localUser != null)
		{
			clanId = SFSKammelnaUserExtensions.GetClanId(localUser);
			object obj9 = clanId + 1;
			if (obj9 != null)
			{
				if (model != null)
				{
					Room <Room>k__BackingField = model.<Room>k__BackingField;
					if (model.<Room>k__BackingField != null)
					{
						object obj10 = typeof(RegisteredWaitHandle) + 1376;
						nint num = (nint)<Room>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02a6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
						object obj12 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v5-8]");
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
							goto IL_02a6;
						}
						object obj13 = obj12 + 3;
						object obj14 = num + obj13;
						object obj15 = obj14 + 312;
						goto IL_031b;
					}
				}
				goto IL_02e9;
			}
		}
		return false;
	}

	public static void OnLogout()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0147: Expected O, but got I
		//IL_0169: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DDD]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v48+E4]");
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
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v48+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5+B8]");
		object obj8 = 0;
		Dictionary<int, int> dictionary = (Dictionary<int, int>)obj8;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a2;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v48+B8]");
		object obj10 = 0;
		dictionary = (Dictionary<int, int>)obj10;
		goto IL_00a2;
		IL_00a2:
		dictionary.Clear();
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
		object format = "LAK" + 536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string key = string.Format((string)format, arg);
		Prefs.SetInt(key, 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg2 = default(object);
		string key2 = string.Format((string)format, arg2);
		Prefs.SetInt(key2, 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg3 = default(object);
		string key3 = string.Format((string)format, arg3);
		Prefs.SetInt(key3, 0);
	}

	private static int GetLastSeenId(TournamentType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
		object format = "LAK" + 536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string key = string.Format((string)format, arg);
		return Prefs.GetInt(key);
	}

	private static void SetLastSeenId(TournamentType type, int value)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
		object format = "LAK" + 536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string key = string.Format((string)format, arg);
		Prefs.SetInt(key, value);
	}

	static SfsTournamentConnector()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1112;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<int, int> dictionary = default(Dictionary<int, int>);
		dictionary..ctor();
		object obj3 = obj2;
		object obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <CheckAvailability>b__18_0()
	{
		eventsChannel.TriggerTournamentsChanged();
	}

	private unsafe void <UpdateTournamentsCounter>g__UpdateCounter|19_0(TournamentType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02a7: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_0305: Expected O, but got Ref
		//IL_01c0: Expected O, but got I4
		//IL_0175: Expected O, but got I4
		//IL_025b: Expected O, but got I
		//IL_01d8: Expected O, but got Ref
		//IL_0206: Expected O, but got I4
		//IL_00e9: Expected O, but got I
		//IL_0103: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
		object obj5 = 152985600;
		object format = "LAK" + 536;
		object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string key = string.Format((string)format, arg);
		int num = Prefs.GetInt(key);
		int num2 = NewTournamentsCount(type, num);
		bool flag2 = TournamentTypeExtensions.IsOfficial(type);
		bool flag3 = !flag2;
		int num3 = num;
		int num4 = num2;
		if (flag3)
		{
			goto IL_02fb;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v31+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DDE]");
			object obj8 = (nint)0 & (nint)1;
			bool flag4 = obj8 == null;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				goto IL_0111;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X26_v1+DDE]");
			object obj10 = (nint)0 & (nint)1;
			if (obj10 == null)
			{
				goto IL_0111;
			}
		}
		goto IL_0336;
		IL_0336:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg2 = default(object);
		string key2 = string.Format((string)format, arg2);
		int num5 = Prefs.GetInt(key2);
		int num6 = NewTournamentsCount(TournamentType.OfficialMonthly, num5);
		num4 = num6 + num2;
		num3 = num5;
		goto IL_02fb;
		IL_02fb:
		TournamentType tournamentType = default(TournamentType);
		string extra = ((Enum)(&tournamentType)).ToString();
		object obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v17+E4]");
		if ((nint)0 != 0)
		{
			int count = CounterBubbleManager.GetCount(CounterBubbleType.Tournaments, extra);
			bool flag5 = count != num4;
			object obj12 = 0;
			if (!flag5)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int count2 = CounterBubbleManager.GetCount(CounterBubbleType.Tournaments, extra);
			bool flag6 = count2 == num4;
			object obj12 = 0;
			if (flag6)
			{
				return;
			}
		}
		string extra2 = ((Enum)(&tournamentType)).ToString();
		object obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v22+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.Tournaments, num4, extra2);
		return;
		IL_0111:
		_ = 1;
		goto IL_0336;
	}
}
