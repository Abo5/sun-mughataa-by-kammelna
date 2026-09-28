using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using Cpp2ILInjected;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;

public class GeneralTournamentFilter : BaseTournamentFilter
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<TournamentModel, int> <>9__3_0;

		public static Func<TournamentModel, DateTime> <>9__3_1;

		public static Func<TournamentModel, int> <>9__3_2;

		public static Func<TournamentModel, int> <>9__3_3;

		public static Func<TournamentModel, DateTime> <>9__3_4;

		public static Func<TournamentModel, int> <>9__3_5;

		public static Func<TournamentModel, bool> <>9__4_3;

		public static Func<TournamentModel, bool> <>9__4_2;

		public static Func<TournamentModel, string> <>9__5_0;

		public static Func<IGrouping<string, TournamentModel>, TournamentListGroup> <>9__5_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <ApplyFilter>b__3_0(TournamentModel tournament)
		{
			//IL_0294: Expected I4, but got O
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_0064: Expected I, but got O
			//IL_0074: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_00af: Expected O, but got I
			//IL_0224: Expected O, but got I4
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Expected O, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected O, but got Unknown
			//IL_01a4: Expected O, but got I
			//IL_01d8: Expected O, but got I4
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected O, but got Unknown
			object obj2;
			int roomId;
			int num2 = default(int);
			object obj7;
			object obj8;
			if (tournament != null)
			{
				Room <Room>k__BackingField = tournament.<Room>k__BackingField;
				if (tournament.<Room>k__BackingField != null)
				{
					object obj = typeof(RegisteredWaitHandle) + 1376;
					obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
					nint num = (nint)<Room>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00f0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj4 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v8-8]");
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
						goto IL_00f0;
					}
					object obj5 = num + obj4;
					object obj6 = obj5 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v23+8]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v203 @ X0_v23] (should have been resolved before IL gen)");
					obj8 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v8+E4]");
					bool flag = (nint)0 == 0;
					object obj9 = !flag;
					roomId = num2;
					if (obj9 != null)
					{
						goto IL_0149;
					}
					goto IL_01ee;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_0173:
			return 0;
			IL_0232:
			TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(tournament.<Room>k__BackingField);
			if (!TournamentStatusExtensions.IsScheduled(tournamentStatus))
			{
				return 1 + 1;
			}
			return 1;
			IL_00f0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v20+8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ X0_v20] (should have been resolved before IL gen)");
			obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v8+E4]");
			bool flag2 = (nint)0 == 0;
			roomId = num2;
			if (!flag2)
			{
				goto IL_0149;
			}
			goto IL_01ee;
			IL_01ee:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = SfsTournamentConnector.IsParticipating(roomId);
			bool flag4 = !flag3;
			object obj10 = !flag4;
			if (obj10 != null)
			{
				goto IL_0173;
			}
			goto IL_0232;
			IL_0149:
			if (SfsTournamentConnector.IsParticipating(num2))
			{
				goto IL_0173;
			}
			goto IL_0232;
		}

		internal DateTime <ApplyFilter>b__3_1(TournamentModel tournament)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0112: Expected O, but got I4
			//IL_011b: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_0174: Expected O, but got I4
			//IL_01da: Expected O, but got I
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected O, but got Unknown
			if (tournament != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v4+E4]");
				if ((nint)0 != 0)
				{
					bool flag = SfsTournamentConnector.CanJoin(tournament.<Room>k__BackingField, tournament.<Info>k__BackingField);
					bool flag2 = !flag;
					object obj3 = 0;
					TournamentData <Info>k__BackingField = tournament.<Info>k__BackingField;
					if (!flag2)
					{
						goto IL_0094;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag3 = SfsTournamentConnector.CanJoin(tournament.<Room>k__BackingField, tournament.<Info>k__BackingField);
					bool flag4 = !flag3;
					object obj4 = !flag4;
					object obj3 = 0;
					TournamentData <Info>k__BackingField = tournament.<Info>k__BackingField;
					if (obj4 != null)
					{
						goto IL_0094;
					}
				}
				object obj5 = typeof(DataRelation) + 712;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v7+E4]");
				bool flag5 = (nint)0 == 0;
				object obj7 = !flag5;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v7+B8]");
				return (DateTime)((nint)0 + (nint)24);
			}
			goto IL_0199;
			IL_0199:
			return (DateTime)new NullReferenceException();
			IL_0094:
			if (tournament.<Info>k__BackingField != null)
			{
				return (DateTime)(tournament.<Info>k__BackingField + 168);
			}
			goto IL_0199;
		}

		internal int <ApplyFilter>b__3_2(TournamentModel tournament)
		{
			//IL_0064: Expected I4, but got O
			if (tournament != null && tournament.<Info>k__BackingField != null)
			{
				return tournament.<Info>k__BackingField.TotalPrize;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal int <ApplyFilter>b__3_3(TournamentModel tournament)
		{
			//IL_0064: Expected I4, but got O
			if (tournament != null)
			{
				TournamentData <Info>k__BackingField = tournament.<Info>k__BackingField;
				if (tournament.<Info>k__BackingField != null)
				{
					return <Info>k__BackingField.<Size>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal DateTime <ApplyFilter>b__3_4(TournamentModel tournament)
		{
			if (tournament != null)
			{
				TournamentData <Info>k__BackingField = tournament.<Info>k__BackingField;
				if (tournament.<Info>k__BackingField != null)
				{
					return <Info>k__BackingField.<StartingTime>k__BackingField;
				}
			}
			return (DateTime)new NullReferenceException();
		}

		internal int <ApplyFilter>b__3_5(TournamentModel tournament)
		{
			//IL_0064: Expected I4, but got O
			if (tournament != null)
			{
				TournamentData <Info>k__BackingField = tournament.<Info>k__BackingField;
				if (tournament.<Info>k__BackingField != null)
				{
					return <Info>k__BackingField.<RoomId>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal bool <GetExtraFilter>b__4_3(TournamentModel _)
		{
			return false;
		}

		internal bool <GetExtraFilter>b__4_2(TournamentModel _)
		{
			return true;
		}

		internal string <CreateGrouping>b__5_0(TournamentModel model)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_0064: Expected I, but got O
			//IL_0074: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_00af: Expected O, but got I
			//IL_0232: Expected O, but got I4
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected O, but got Unknown
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Expected O, but got Unknown
			//IL_01b2: Expected O, but got I
			//IL_01e6: Expected O, but got I4
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Expected O, but got Unknown
			//IL_029c: Expected O, but got I4
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected O, but got Unknown
			object obj2;
			int roomId;
			int num2 = default(int);
			object obj7;
			object obj8;
			if (model != null)
			{
				Room <Room>k__BackingField = model.<Room>k__BackingField;
				if (model.<Room>k__BackingField != null)
				{
					object obj = typeof(RegisteredWaitHandle) + 1376;
					obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
					nint num = (nint)<Room>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00f0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj4 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X10_v8-8]");
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
						goto IL_00f0;
					}
					object obj5 = num + obj4;
					object obj6 = obj5 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v21+8]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v212 @ X0_v21] (should have been resolved before IL gen)");
					obj8 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v12+E4]");
					bool flag = (nint)0 == 0;
					object obj9 = !flag;
					roomId = num2;
					if (obj9 != null)
					{
						goto IL_0149;
					}
					goto IL_01fc;
				}
			}
			return (string)(object)new NullReferenceException();
			IL_0173:
			return "Material with texture name \"" + 3192;
			IL_0240:
			TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(model.<Room>k__BackingField);
			bool flag2 = TournamentStatusExtensions.IsStarted(tournamentStatus);
			object result = "Added Tournament Prizes And Features" + 4064;
			object obj10 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3592;
			bool flag3 = !flag2;
			object obj11 = !flag3;
			object obj12 = ~obj11;
			if (obj12 == null)
			{
				result = obj10;
			}
			return (string)result;
			IL_00f0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v18+8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v105 @ X0_v18] (should have been resolved before IL gen)");
			obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v12+E4]");
			bool flag4 = (nint)0 == 0;
			roomId = num2;
			if (!flag4)
			{
				goto IL_0149;
			}
			goto IL_01fc;
			IL_01fc:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = SfsTournamentConnector.IsParticipating(roomId);
			bool flag6 = !flag5;
			object obj13 = !flag6;
			if (obj13 != null)
			{
				goto IL_0173;
			}
			goto IL_0240;
			IL_0149:
			if (SfsTournamentConnector.IsParticipating(num2))
			{
				goto IL_0173;
			}
			goto IL_0240;
		}

		internal TournamentListGroup <CreateGrouping>b__5_1(IGrouping<string, TournamentModel> models)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0035: Expected I, but got O
			//IL_0045: Expected O, but got I
			//IL_0080: Expected O, but got I
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			if (models != null)
			{
				object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1552;
				object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1568;
				nint num = (nint)models;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<System.Linq.IGrouping`2<System.String, TournamentModel>>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<System.Linq.IGrouping`2<System.String, TournamentModel>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00c1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<System.Linq.IGrouping`2<System.String, TournamentModel>>)+B0]");
				object obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X10_v5-8]");
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
				goto IL_013f;
			}
			return (TournamentListGroup)(object)new NullReferenceException();
			IL_013f:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v169 @ X0_v3] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TournamentListGroup tournamentListGroup = default(TournamentListGroup);
			string title = default(string);
			tournamentListGroup..ctor(title, models);
			return tournamentListGroup;
			IL_00c1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_013f;
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public string defaultRoomGroup;

		internal bool <GetExtraFilter>b__0(TournamentModel model)
		{
			//IL_0127: Expected I4, but got O
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0050: Expected I, but got O
			//IL_0060: Expected O, but got I
			//IL_009b: Expected O, but got I
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected O, but got Unknown
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
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
						goto IL_00dc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v5-8]");
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
					object obj4 = obj3 + 3;
					object obj5 = num + obj4;
					object obj6 = obj5 + 312;
					goto IL_0168;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00dc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0168;
			IL_0168:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v168 @ X0_v3] (should have been resolved before IL gen)");
			string text = default(string);
			return text == defaultRoomGroup;
		}
	}

	private sealed class <>c__DisplayClass4_1
	{
		public string targetRoomGroup;

		internal bool <GetExtraFilter>b__1(TournamentModel model)
		{
			//IL_0127: Expected I4, but got O
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0050: Expected I, but got O
			//IL_0060: Expected O, but got I
			//IL_009b: Expected O, but got I
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected O, but got Unknown
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
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
						goto IL_00dc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v5-8]");
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
					object obj4 = obj3 + 3;
					object obj5 = num + obj4;
					object obj6 = obj5 + 312;
					goto IL_0168;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00dc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0168;
			IL_0168:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v168 @ X0_v3] (should have been resolved before IL gen)");
			string text = default(string);
			return text == targetRoomGroup;
		}
	}

	private bool IsRoomFilter
	{
		get
		{
			//IL_01c9: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0028: Expected O, but got I4
			//IL_0038: Expected O, but got I
			//IL_0136: Expected O, but got I
			//IL_0158: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_007a: Expected O, but got I
			//IL_009a: Expected O, but got I4
			//IL_01ad: Expected O, but got I4
			//IL_00f6: Expected O, but got I4
			TournamentType[] array = base.<Types>k__BackingField;
			Type typeFromHandle;
			Array values;
			if (base.<Types>k__BackingField != null)
			{
				object handle = typeof(SqlDouble) + 680;
				object obj = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v3+E0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
				Type enumType;
				if ((nint)0 != 0)
				{
					typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v3+98]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v7+E4]");
					bool flag = (nint)0 == 0;
					object obj4 = 0;
					enumType = typeFromHandle;
					if (!flag)
					{
						goto IL_00b0;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v3+98]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v7+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					object obj4 = 0;
					enumType = typeFromHandle;
					if (obj5 != null)
					{
						goto IL_00b0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				values = Enum.GetValues(enumType);
				bool flag3 = values == null;
				object obj6 = !flag3;
				if (obj6 != null)
				{
					goto IL_00da;
				}
			}
			goto IL_01bb;
			IL_00b0:
			values = Enum.GetValues(typeFromHandle);
			if (values != null)
			{
				goto IL_00da;
			}
			goto IL_01bb;
			IL_00da:
			int length = values.Length;
			object obj7 = length - array.Length;
			return obj7 == null;
			IL_01bb:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public GeneralTournamentFilter(TournamentType[] types)
		: base(types)
	{
	}

	public override IEnumerable<TournamentModel> ApplyFilter(IEnumerable<TournamentModel> tournaments)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_00d9: Expected O, but got I
		//IL_00e9: Expected O, but got I
		//IL_00f9: Expected O, but got I
		//IL_011b: Expected O, but got I4
		//IL_005e: Expected O, but got I
		//IL_006e: Expected O, but got I
		//IL_007e: Expected O, but got I
		//IL_00a0: Expected O, but got I4
		//IL_024d: Expected O, but got I
		//IL_025d: Expected O, but got I
		//IL_026d: Expected O, but got I
		//IL_028f: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_01d2: Expected O, but got I
		//IL_01e2: Expected O, but got I
		//IL_01f2: Expected O, but got I
		//IL_0214: Expected O, but got I4
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Expected O, but got Unknown
		//IL_0912: Expected O, but got I
		//IL_0923: Expected I, but got O
		//IL_0941: Expected O, but got I
		//IL_095c: Expected O, but got I4
		//IL_03c1: Expected O, but got I
		//IL_03d1: Expected O, but got I
		//IL_03e1: Expected O, but got I
		//IL_0403: Expected O, but got I4
		//IL_02c7: Expected O, but got I4
		//IL_0183: Expected O, but got I
		//IL_0346: Expected O, but got I
		//IL_0356: Expected O, but got I
		//IL_0366: Expected O, but got I
		//IL_0388: Expected O, but got I4
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected O, but got Unknown
		//IL_099b: Expected O, but got I
		//IL_09ac: Expected I, but got O
		//IL_09ca: Expected O, but got I
		//IL_09e5: Expected O, but got I4
		//IL_0525: Expected O, but got I
		//IL_0535: Expected O, but got I
		//IL_0557: Expected O, but got I4
		//IL_043b: Expected O, but got I4
		//IL_02f7: Expected O, but got I
		//IL_04be: Expected O, but got I
		//IL_04ce: Expected O, but got I
		//IL_04f0: Expected O, but got I4
		//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Expected O, but got Unknown
		//IL_0a24: Expected O, but got I
		//IL_0a35: Expected I, but got O
		//IL_0a53: Expected O, but got I
		//IL_0a6e: Expected O, but got I4
		//IL_0681: Expected O, but got I
		//IL_0691: Expected O, but got I
		//IL_06a1: Expected O, but got I
		//IL_06c3: Expected O, but got I4
		//IL_0587: Expected O, but got I4
		//IL_046b: Expected O, but got I
		//IL_0606: Expected O, but got I
		//IL_0616: Expected O, but got I
		//IL_0626: Expected O, but got I
		//IL_0648: Expected O, but got I4
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Expected O, but got Unknown
		//IL_0aad: Expected O, but got I
		//IL_0abe: Expected I, but got O
		//IL_0adc: Expected O, but got I
		//IL_0af7: Expected O, but got I4
		//IL_07f5: Expected O, but got I
		//IL_0805: Expected O, but got I
		//IL_0815: Expected O, but got I
		//IL_0837: Expected O, but got I4
		//IL_06fb: Expected O, but got I4
		//IL_05b7: Expected O, but got I
		//IL_077a: Expected O, but got I
		//IL_078a: Expected O, but got I
		//IL_079a: Expected O, but got I
		//IL_07bc: Expected O, but got I4
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected O, but got Unknown
		//IL_0b2e: Expected O, but got I
		//IL_0b3f: Expected I, but got O
		//IL_0b5d: Expected O, but got I
		//IL_0b78: Expected O, but got I4
		//IL_086f: Expected O, but got I4
		//IL_072b: Expected O, but got I
		//IL_0b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba1: Expected O, but got Unknown
		//IL_0bb7: Expected O, but got I
		//IL_0bc8: Expected I, but got O
		//IL_0be6: Expected O, but got I
		//IL_089f: Expected O, but got I
		object obj = (nint)0 + (nint)3808;
		object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 160;
		Func<TournamentModel, bool> extraFilter = GetExtraFilter();
		IEnumerable<TournamentModel> source = base.ApplyFilter(tournaments);
		IEnumerable<object> source2 = Enumerable.Where(source, (Func<object, bool>)extraFilter);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v81+E4]");
		object obj5;
		Func<object, int> keySelector;
		object obj7;
		object obj4;
		if ((nint)0 != 0)
		{
			obj4 = (nint)0 + (nint)2288;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v81+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v71+8]");
			keySelector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v71+8]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				obj7 = obj4;
				goto IL_0131;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			obj7 = (nint)0 + (nint)2288;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v81+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v71+8]");
			keySelector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v71+8]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj4 = obj7;
			if (obj8 == null)
			{
				goto IL_0131;
			}
		}
		goto IL_0188;
		IL_02fc:
		IOrderedEnumerable<object> source4;
		Func<object, DateTime> keySelector2;
		IOrderedEnumerable<object> source3 = Enumerable.ThenBy(source4, keySelector2);
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v61+E4]");
		object obj11;
		Func<object, int> keySelector3;
		object obj13;
		object obj10;
		if ((nint)0 != 0)
		{
			obj10 = (nint)0 + (nint)1072;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v61+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v49+18]");
			keySelector3 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v49+18]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				obj13 = obj10;
				goto IL_0419;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj2;
			obj13 = (nint)0 + (nint)1072;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v61+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v49+18]");
			keySelector3 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v49+18]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			obj10 = obj13;
			if (obj14 == null)
			{
				goto IL_0419;
			}
		}
		goto IL_0470;
		IL_0470:
		IOrderedEnumerable<object> source5 = Enumerable.ThenByDescending(source3, keySelector3);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v51+E4]");
		object obj16;
		Func<object, int> keySelector4;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v51+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v38+20]");
			keySelector4 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v38+20]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			if (obj17 == null)
			{
				goto IL_0565;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v51+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v38+20]");
			keySelector4 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v38+20]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				goto IL_0565;
			}
		}
		goto IL_05bc;
		IL_0565:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v51+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj20 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v44+B8]");
			obj16 = 0;
		}
		object obj21 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)1992;
		Func<object, int> func = default(Func<object, int>);
		func..ctor(obj16, (IntPtr)obj22);
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v43+B8]");
		object obj24 = (nint)0 + (nint)32;
		obj24 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj25 = 0;
		keySelector4 = func;
		goto IL_05bc;
		IL_0131:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v81+E4]");
		bool flag8 = (nint)0 == 0;
		object obj26 = !flag8;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj27 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v77+B8]");
			obj5 = 0;
		}
		object obj28 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = (nint)0 + (nint)1968;
		Func<object, int> func2 = default(Func<object, int>);
		func2..ctor(obj5, (IntPtr)obj29);
		object obj30 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v76+B8]");
		object obj31 = (nint)0 + (nint)8;
		obj31 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj25 = 0;
		obj4 = obj7;
		keySelector = func2;
		goto IL_0188;
		IL_06d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v41+E4]");
		bool flag9 = (nint)0 == 0;
		object obj32 = !flag9;
		object obj34;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj33 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v33+B8]");
			obj34 = 0;
		}
		object obj35 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj36 = (nint)0 + (nint)2000;
		Func<object, DateTime> func3 = default(Func<object, DateTime>);
		func3..ctor(obj34, (IntPtr)obj36);
		object obj37 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v32+B8]");
		object obj38 = (nint)0 + (nint)40;
		obj38 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj25 = 0;
		object obj40;
		object obj39 = obj40;
		Func<object, DateTime> keySelector5 = func3;
		goto IL_0730;
		IL_084d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v31+E4]");
		bool flag10 = (nint)0 == 0;
		object obj41 = !flag10;
		object obj43;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj42 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v22+B8]");
			obj43 = 0;
		}
		object obj44 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj45 = (nint)0 + (nint)2008;
		Func<object, int> func4 = default(Func<object, int>);
		func4..ctor(obj43, (IntPtr)obj45);
		object obj46 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v21+B8]");
		object obj47 = (nint)0 + (nint)48;
		obj47 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj49;
		object obj48 = obj49;
		Func<object, int> keySelector6 = func4;
		goto IL_08a4;
		IL_0188:
		source4 = Enumerable.OrderBy(source2, keySelector);
		object obj50 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v71+E4]");
		object obj52;
		object obj54;
		object obj51;
		if ((nint)0 != 0)
		{
			obj51 = (nint)0 + (nint)1016;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v71+B8]");
			obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v60+10]");
			keySelector2 = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v60+10]");
			bool flag11 = (nint)0 == 0;
			object obj53 = !flag11;
			if (obj53 == null)
			{
				obj54 = obj51;
				goto IL_02a5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj50 = obj2;
			obj54 = (nint)0 + (nint)1016;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v71+B8]");
			obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v60+10]");
			keySelector2 = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v60+10]");
			bool flag12 = (nint)0 == 0;
			object obj55 = !flag12;
			obj51 = obj54;
			if (obj55 == null)
			{
				goto IL_02a5;
			}
		}
		goto IL_02fc;
		IL_05bc:
		IOrderedEnumerable<object> source6 = Enumerable.ThenByDescending(source5, keySelector4);
		object obj56 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v41+E4]");
		if ((nint)0 != 0)
		{
			obj39 = (nint)0 + (nint)1064;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v41+B8]");
			obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v27+28]");
			keySelector5 = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v27+28]");
			bool flag13 = (nint)0 == 0;
			object obj57 = !flag13;
			if (obj57 == null)
			{
				obj40 = obj39;
				goto IL_06d9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj56 = obj2;
			obj40 = (nint)0 + (nint)1064;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v41+B8]");
			obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v27+28]");
			keySelector5 = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v27+28]");
			bool flag14 = (nint)0 == 0;
			object obj58 = !flag14;
			obj39 = obj40;
			if (obj58 == null)
			{
				goto IL_06d9;
			}
		}
		goto IL_0730;
		IL_0419:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v61+E4]");
		bool flag15 = (nint)0 == 0;
		object obj59 = !flag15;
		if (obj59 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj60 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v55+B8]");
			obj11 = 0;
		}
		object obj61 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj62 = (nint)0 + (nint)1984;
		Func<object, int> func5 = default(Func<object, int>);
		func5..ctor(obj11, (IntPtr)obj62);
		object obj63 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v54+B8]");
		object obj64 = (nint)0 + (nint)24;
		obj64 = func5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj25 = 0;
		obj10 = obj13;
		keySelector3 = func5;
		goto IL_0470;
		IL_0730:
		IOrderedEnumerable<object> source7 = Enumerable.ThenByDescending(source6, keySelector5);
		object obj65 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v31+E4]");
		if ((nint)0 != 0)
		{
			obj48 = (nint)0 + (nint)1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v31+B8]");
			obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v16+30]");
			keySelector6 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v16+30]");
			bool flag16 = (nint)0 == 0;
			object obj66 = !flag16;
			if (obj66 == null)
			{
				obj49 = obj48;
				goto IL_084d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj65 = obj2;
			obj49 = (nint)0 + (nint)1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v31+B8]");
			obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v16+30]");
			keySelector6 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v16+30]");
			bool flag17 = (nint)0 == 0;
			object obj67 = !flag17;
			obj48 = obj49;
			if (obj67 == null)
			{
				goto IL_084d;
			}
		}
		goto IL_08a4;
		IL_02a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v71+E4]");
		bool flag18 = (nint)0 == 0;
		object obj68 = !flag18;
		if (obj68 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj69 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v66+B8]");
			obj52 = 0;
		}
		object obj70 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj71 = (nint)0 + (nint)1976;
		Func<object, DateTime> func6 = default(Func<object, DateTime>);
		func6..ctor(obj52, (IntPtr)obj71);
		object obj72 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v65+B8]");
		object obj73 = (nint)0 + (nint)16;
		obj73 = func6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj25 = 0;
		obj51 = obj54;
		keySelector2 = func6;
		goto IL_02fc;
		IL_08a4:
		return (IEnumerable<TournamentModel>)Enumerable.ThenBy(source7, keySelector6);
	}

	private Func<TournamentModel, bool> GetExtraFilter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_0319: Expected O, but got I
		//IL_0321: Expected I, but got O
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0092: Expected O, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00da: Expected O, but got I4
		//IL_0103: Expected O, but got I
		//IL_0358: Expected O, but got I4
		//IL_018c: Expected O, but got I4
		//IL_03cf: Expected O, but got I4
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected O, but got Unknown
		//IL_0407: Expected O, but got I4
		//IL_04c4: Expected O, but got I4
		//IL_06a0: Expected O, but got I4
		//IL_06a9: Expected O, but got I4
		//IL_06b2: Expected O, but got I4
		//IL_05bd: Expected O, but got I4
		//IL_05c6: Expected O, but got I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0253: Expected O, but got I4
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Expected O, but got Unknown
		//IL_06ea: Expected O, but got I
		//IL_06f2: Expected I, but got O
		//IL_0857: Expected O, but got I
		//IL_0867: Expected O, but got I
		//IL_0729: Expected O, but got I
		//IL_0739: Expected O, but got I
		//IL_075b: Expected O, but got I4
		//IL_07e2: Expected O, but got I4
		//IL_0625: Expected O, but got I
		//IL_0635: Expected O, but got I
		//IL_0657: Expected O, but got I4
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected O, but got Unknown
		//IL_0979: Expected O, but got I
		//IL_0981: Expected I, but got O
		//IL_0992: Expected I, but got O
		//IL_09b0: Expected O, but got I
		//IL_09c1: Expected O, but got I4
		//IL_078b: Expected O, but got I4
		//IL_0812: Expected O, but got I
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Expected O, but got Unknown
		//IL_08eb: Expected O, but got I
		//IL_08f3: Expected I, but got O
		//IL_0904: Expected I, but got O
		//IL_0922: Expected O, but got I
		//IL_0933: Expected O, but got I4
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected O, but got Unknown
		//IL_07bb: Expected O, but got I
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj4 = default(object);
		object obj5;
		Func<TournamentModel, bool> result;
		Func<object, bool> result2;
		object obj25;
		nint method;
		object obj34;
		Func<TournamentModel, bool> result3;
		Func<object, bool> func2 = default(Func<object, bool>);
		object obj27;
		nint num;
		object obj21;
		object obj22;
		if (IsRoomFilter)
		{
			object obj3 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj4..ctor();
			if (obj4 != null)
			{
				obj5 = obj4 + 16;
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj6 = typeof(Queue<string>) + 848;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v22+E4]");
				bool flag = (nint)0 == 0;
				object obj8 = !flag;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj9 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				if ((object)sessionModel != null)
				{
					Room currentRoom = sessionModel.CurrentRoom;
					bool flag2 = SFSKammelnaRoomExtensions.IsTournamentHub(currentRoom);
					object obj10 = obj6;
					if (flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v28+E4]");
						bool flag3 = (nint)0 == 0;
						object obj11 = !flag3;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
						SessionModel sessionModel2 = default(SessionModel);
						if ((object)sessionModel2 != null)
						{
							Room currentRoom2 = sessionModel2.CurrentRoom;
							TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom2);
							if (TournamentStatusExtensions.IsScheduled(tournamentStatus))
							{
								object obj12 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 160;
								object obj13 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v85+E4]");
								bool flag4 = (nint)0 == 0;
								object obj14 = !flag4;
								if (obj14 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj13 = obj12;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v85+B8]");
								object obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v44+38]");
								result = (Func<TournamentModel, bool>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v44+38]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v85+E4]");
									bool flag5 = (nint)0 == 0;
									object obj16 = !flag5;
									if (obj16 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										object obj17 = obj12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v50+B8]");
										obj15 = 0;
									}
									object obj18 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3920;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj19 = (nint)0 + (nint)2040;
									num = (nint)obj19;
									Func<object, bool> func = default(Func<object, bool>);
									func..ctor(obj15, (IntPtr)obj19);
									object obj20 = obj12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v49+B8]");
									obj21 = (nint)0 + (nint)56;
									obj21 = func;
									obj22 = 0;
									result2 = func;
									goto IL_0940;
								}
								goto IL_0278;
							}
							object obj23 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v77+E4]");
							bool flag6 = (nint)0 == 0;
							object obj24 = !flag6;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
							SessionModel sessionModel3 = default(SessionModel);
							if ((object)sessionModel3 != null)
							{
								Room currentRoom3 = sessionModel3.CurrentRoom;
								TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom3);
								if (tournamentInfo != null)
								{
									obj25 = tournamentInfo + 56;
									goto IL_08a2;
								}
							}
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v28+E4]");
						bool flag7 = (nint)0 == 0;
						object obj26 = !flag7;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
						SessionModel sessionModel4 = default(SessionModel);
						if ((object)sessionModel4 != null)
						{
							Room currentRoom4 = sessionModel4.CurrentRoom;
							bool flag8 = SFSKammelnaRoomExtensions.IsMassTournament(currentRoom4);
							bool flag9 = !flag8;
							obj27 = 0;
							if (flag9)
							{
								goto IL_0557;
							}
							object obj28 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v61+E4]");
							bool flag10 = (nint)0 == 0;
							object obj29 = !flag10;
							if (obj29 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
							SessionModel sessionModel5 = default(SessionModel);
							if ((object)sessionModel5 != null)
							{
								Room currentRoom5 = sessionModel5.CurrentRoom;
								MassTournamentInfo massTournamentInfo = SFSKammelnaRoomExtensions.GetMassTournamentInfo(currentRoom5);
								if (massTournamentInfo != null)
								{
									obj25 = massTournamentInfo + 32;
									goto IL_08a2;
								}
							}
						}
					}
				}
			}
		}
		else
		{
			object obj30 = typeof(RegisteredWaitHandle) + 1392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			if (obj2 != null)
			{
				object obj31 = obj2 + 16;
				obj31 = friendlyName;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj32 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj33 = (nint)0 + (nint)2048;
				method = (nint)obj33;
				obj34 = obj2;
				result3 = func2;
				goto IL_088c;
			}
		}
		return (Func<TournamentModel, bool>)(object)new NullReferenceException();
		IL_0557:
		object obj35 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj36 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v20+E4]");
		if ((nint)0 != 0)
		{
			bool flag11 = StringsExtensions.IsNullOrEmpty((string)obj5);
			bool flag12 = !flag11;
			object obj37 = 0;
			object obj38 = 0;
			if (!flag12)
			{
				goto IL_05d4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag13 = StringsExtensions.IsNullOrEmpty((string)obj5);
			bool flag14 = !flag13;
			object obj39 = !flag14;
			object obj37 = 0;
			object obj38 = 0;
			if (obj39 != null)
			{
				goto IL_05d4;
			}
		}
		object obj40 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj41 = (nint)0 + (nint)2056;
		method = (nint)obj41;
		obj34 = obj4;
		result3 = func2;
		goto IL_088c;
		IL_0278:
		return result;
		IL_08a2:
		obj27 = obj25;
		obj5 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_0557;
		IL_0940:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return result2;
		IL_05d4:
		object obj42 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 160;
		object obj43 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v46+E4]");
		object obj44;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v46+B8]");
			obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v27+40]");
			result = (Func<TournamentModel, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v27+40]");
			bool flag15 = (nint)0 == 0;
			object obj45 = !flag15;
			if (obj45 != null)
			{
				goto IL_0278;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v46+B8]");
			obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v27+40]");
			result = (Func<TournamentModel, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v27+40]");
			bool flag16 = (nint)0 == 0;
			object obj46 = !flag16;
			if (obj46 != null)
			{
				goto IL_0278;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v46+E4]");
		bool flag17 = (nint)0 == 0;
		object obj47 = !flag17;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj48 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v33+B8]");
			obj44 = 0;
		}
		object obj49 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj50 = (nint)0 + (nint)2032;
		num = (nint)obj50;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj44, (IntPtr)obj50);
		object obj51 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v32+B8]");
		obj21 = (nint)0 + (nint)64;
		obj21 = func3;
		obj22 = 0;
		result2 = func3;
		goto IL_0940;
		IL_088c:
		func2..ctor(obj34, (IntPtr)method);
		return result3;
	}

	public override List<TournamentListGroup> CreateGrouping(List<TournamentModel> tournaments)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_00b1: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_023c: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_0162: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_0372: Expected O, but got I
		//IL_0382: Expected O, but got I
		//IL_03a4: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_0283: Expected O, but got I4
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_030a: Expected O, but got I
		//IL_031b: Expected I, but got O
		//IL_0339: Expected O, but got I
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_03dc: Expected O, but got I
		//IL_03ed: Expected I, but got O
		//IL_040b: Expected O, but got I
		//IL_01fc: Expected O, but got I
		//IL_02b3: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CB7]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v19+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v19+E4]");
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
		object obj7 = (nint)0 + (nint)2968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v19+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v15+48]");
		Func<object, object> keySelector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v15+48]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 == null)
		{
			goto IL_01aa;
		}
		goto IL_0201;
		IL_01aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v21+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)2016;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v20+B8]");
		object obj16 = (nint)0 + (nint)72;
		obj16 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		keySelector = func;
		goto IL_0201;
		IL_0201:
		ILookup<object, object> source = Enumerable.ToLookup(tournaments, keySelector);
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v5+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v6+50]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v6+50]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v5+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj22 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v12+B8]");
				obj19 = 0;
			}
			object obj23 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj24 = (nint)0 + (nint)2024;
			Func<object, object> func2 = default(Func<object, object>);
			func2..ctor(obj19, (IntPtr)obj24);
			object obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+B8]");
			object obj26 = (nint)0 + (nint)80;
			obj26 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func2;
		}
		IEnumerable<object> source2 = Enumerable.Select(source, selector);
		return (List<TournamentListGroup>)(object)Enumerable.ToList(source2);
		IL_0085:
		obj10 = (nint)0 + (nint)2968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v19+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v15+48]");
		keySelector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v15+48]");
		bool flag8 = (nint)0 == 0;
		object obj27 = !flag8;
		if (obj27 == null)
		{
			obj7 = obj10;
			goto IL_01aa;
		}
		goto IL_0201;
	}
}
