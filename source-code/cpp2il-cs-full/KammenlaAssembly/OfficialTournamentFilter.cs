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
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Mono.Btls;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;

public class OfficialTournamentFilter : BaseTournamentFilter
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<TournamentModel, DateTime> <>9__1_0;

		public static Func<TournamentModel, bool> <>9__2_0;

		public static Func<TournamentModel, bool> <>9__2_1;

		public static Predicate<TournamentModel> <>9__2_2;

		public static Func<TournamentModel, bool> <>9__2_5;

		public static Func<TournamentModel, IComparable> <>9__2_6;

		public static Func<TournamentModel, string> <>9__2_3;

		public static Func<IGrouping<string, TournamentModel>, TournamentListGroup> <>9__2_4;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal DateTime <ApplyFilter>b__1_0(TournamentModel tournament)
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

		internal bool <CreateGrouping>b__2_0(TournamentModel model)
		{
			//IL_00bc: Expected I4, but got O
			if (model != null)
			{
				TournamentData <Info>k__BackingField = model.<Info>k__BackingField;
				if (model.<Info>k__BackingField != null)
				{
					if (<Info>k__BackingField.<Type>k__BackingField == TournamentType.OfficialMonthly)
					{
						TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(model.<Room>k__BackingField);
						bool flag = TournamentStatusExtensions.IsFinished(tournamentStatus);
						return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
					}
					return false;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <CreateGrouping>b__2_1(TournamentModel model)
		{
			//IL_0081: Expected I4, but got O
			//IL_005f: Expected O, but got I4
			if (model != null)
			{
				TournamentData <Info>k__BackingField = model.<Info>k__BackingField;
				if (model.<Info>k__BackingField != null)
				{
					object obj = <Info>k__BackingField.<Type>k__BackingField - 3;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <CreateGrouping>b__2_2(TournamentModel model)
		{
			//IL_0081: Expected I4, but got O
			//IL_005f: Expected O, but got I4
			if (model != null)
			{
				TournamentData <Info>k__BackingField = model.<Info>k__BackingField;
				if (model.<Info>k__BackingField != null)
				{
					object obj = <Info>k__BackingField.<Type>k__BackingField - 4;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <CreateGrouping>b__2_5(TournamentModel model)
		{
			//IL_0062: Expected I4, but got O
			if (model != null)
			{
				TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(model.<Room>k__BackingField);
				bool flag = TournamentStatusExtensions.IsFinished(tournamentStatus);
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal IComparable <CreateGrouping>b__2_6(TournamentModel model)
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			if (model != null && model.<Info>k__BackingField != null)
			{
				object obj = typeof(DataRelation) + 712;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				IComparable result = default(IComparable);
				return result;
			}
			return (IComparable)new NullReferenceException();
		}

		internal string <CreateGrouping>b__2_3(TournamentModel model)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_0064: Expected I, but got O
			//IL_0074: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0138: Expected I, but got O
			//IL_013d: Expected I, but got O
			//IL_014d: Expected O, but got I
			//IL_00af: Expected O, but got I
			//IL_0264: Expected O, but got I4
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected O, but got Unknown
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Expected O, but got Unknown
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Expected O, but got Unknown
			//IL_01cc: Expected O, but got I
			//IL_0200: Expected O, but got I4
			//IL_0218: Expected O, but got I
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected O, but got Unknown
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c5: Expected O, but got Unknown
			//IL_02ef: Expected O, but got I4
			//IL_0410: Unknown result type (might be due to invalid IL or missing references)
			//IL_0415: Expected O, but got Unknown
			//IL_0424: Unknown result type (might be due to invalid IL or missing references)
			//IL_0429: Expected O, but got Unknown
			//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b9: Expected O, but got Unknown
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c8: Expected O, but got Unknown
			//IL_03e2: Expected O, but got I4
			object obj2;
			nint num2;
			object obj10;
			int roomId;
			int num4 = default(int);
			object obj8;
			nint num3 = default(nint);
			object obj7;
			if (model != null)
			{
				Room <Room>k__BackingField = model.<Room>k__BackingField;
				if (model.<Room>k__BackingField != null)
				{
					object obj = typeof(RegisteredWaitHandle) + 1376;
					obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
					nint num = (nint)<Room>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00f0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj4 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X10_v9-8]");
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v34+8]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v268 @ X0_v34] (should have been resolved before IL gen)");
					obj8 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v21+E4]");
					bool flag = (nint)0 == 0;
					object obj9 = !flag;
					num2 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v34+8]");
					obj10 = 0;
					roomId = num4;
					if (obj9 != null)
					{
						goto IL_0163;
					}
					goto IL_022e;
				}
			}
			goto IL_042e;
			IL_00f0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v31+8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v141 @ X0_v31] (should have been resolved before IL gen)");
			obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v21+E4]");
			bool flag2 = (nint)0 == 0;
			num3 = unchecked((nint)null);
			num2 = unchecked((nint)null);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v31+8]");
			obj10 = 0;
			roomId = num4;
			if (!flag2)
			{
				goto IL_0163;
			}
			goto IL_022e;
			IL_022e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = SfsTournamentConnector.IsParticipating(roomId);
			bool flag4 = !flag3;
			object obj11 = !flag4;
			num3 = num2;
			obj7 = obj10;
			if (obj11 != null)
			{
				goto IL_018d;
			}
			goto IL_0282;
			IL_0163:
			if (SfsTournamentConnector.IsParticipating(num4))
			{
				goto IL_018d;
			}
			goto IL_0282;
			IL_0282:
			TournamentData <Info>k__BackingField = model.<Info>k__BackingField;
			if (model.<Info>k__BackingField != null)
			{
				object obj12 = typeof(DataRelation) + 712;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v5+E4]");
				bool flag5 = (nint)0 == 0;
				object obj14 = !flag5;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				if (<Info>k__BackingField.<AvailabilityTime>k__BackingField <= now)
				{
					TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(model.<Room>k__BackingField);
					if (TournamentStatusExtensions.IsStarted(tournamentStatus))
					{
						TournamentStatus tournamentStatus2 = SFSKammelnaRoomExtensions.GetTournamentStatus(model.<Room>k__BackingField);
						bool flag6 = TournamentStatusExtensions.IsFinished(tournamentStatus2);
						object result = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3592;
						object obj15 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 112;
						bool flag7 = !flag6;
						object obj16 = !flag7;
						object obj17 = ~obj16;
						if (obj17 == null)
						{
							result = obj15;
						}
						return (string)result;
					}
					return "Added Tournament Prizes And Features" + 4064;
				}
				return "SERVICE_DISABLED" + 1896;
			}
			goto IL_042e;
			IL_042e:
			return (string)(object)new NullReferenceException();
			IL_018d:
			return "Material with texture name \"" + 3192;
		}

		internal TournamentListGroup <CreateGrouping>b__2_4(IGrouping<string, TournamentModel> models)
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

	public OfficialTournamentFilter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		TournamentType[] array = default(TournamentType[]);
		if (array.Length != 0)
		{
			_ = 3;
			if (array.Length != 1)
			{
				_ = 4;
				base..ctor(array);
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public override IEnumerable<TournamentModel> ApplyFilter(IEnumerable<TournamentModel> tournaments)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0038: Expected O, but got I
		//IL_0044: Expected O, but got I
		//IL_0050: Expected O, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_027a: Expected I, but got O
		//IL_0097: Expected I, but got O
		//IL_00c5: Expected I, but got O
		//IL_018f: Expected O, but got I
		//IL_019f: Expected O, but got I
		//IL_01af: Expected O, but got I
		//IL_01d1: Expected O, but got I4
		//IL_0114: Expected O, but got I
		//IL_0124: Expected O, but got I
		//IL_0134: Expected O, but got I
		//IL_0156: Expected O, but got I4
		//IL_0209: Expected O, but got I4
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_02a9: Expected O, but got I
		//IL_02ba: Expected I, but got O
		//IL_02d8: Expected O, but got I
		//IL_0239: Expected O, but got I
		object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3944;
		object obj2 = (nint)0 + (nint)1704;
		object obj3 = (nint)0 + (nint)2288;
		object obj4 = (nint)0 + (nint)1696;
		object obj5 = (nint)0 + (nint)1024;
		object obj6 = (nint)0 + (nint)1712;
		object obj7 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1464;
		IEnumerable<TournamentModel> tournaments2 = default(IEnumerable<TournamentModel>);
		IEnumerable<TournamentModel> source = base.ApplyFilter(tournaments2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, int> func = default(Func<object, int>);
		func..ctor((object)null, (IntPtr)obj2);
		IOrderedEnumerable<object> source2 = Enumerable.OrderBy(source, func);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, int> func2 = default(Func<object, int>);
		func2..ctor((object)null, (IntPtr)obj4);
		IOrderedEnumerable<object> source3 = Enumerable.ThenBy(source2, func2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, int> func3 = default(Func<object, int>);
		func3..ctor((object)null, (IntPtr)obj6);
		IOrderedEnumerable<object> source4 = Enumerable.ThenBy(source3, func3);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v19+E4]");
		object obj10;
		Func<object, DateTime> keySelector;
		object obj12;
		object obj9;
		if ((nint)0 != 0)
		{
			obj9 = (nint)0 + (nint)1016;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v19+B8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v6+8]");
			keySelector = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v6+8]");
			bool flag = (nint)0 == 0;
			object obj11 = !flag;
			if (obj11 == null)
			{
				obj12 = obj9;
				goto IL_01e7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj7;
			obj12 = (nint)0 + (nint)1016;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v19+B8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v6+8]");
			keySelector = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			obj9 = obj12;
			if (obj13 == null)
			{
				goto IL_01e7;
			}
		}
		goto IL_023e;
		IL_01e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v19+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v12+B8]");
			obj10 = 0;
		}
		object obj16 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)3832;
		Func<object, DateTime> func4 = default(Func<object, DateTime>);
		func4..ctor(obj10, (IntPtr)obj17);
		object obj18 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v11+B8]");
		object obj19 = (nint)0 + (nint)8;
		obj19 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		keySelector = func4;
		obj9 = obj12;
		goto IL_023e;
		IL_023e:
		return (IEnumerable<TournamentModel>)Enumerable.ThenBy(source4, keySelector);
	}

	public override List<TournamentListGroup> CreateGrouping(List<TournamentModel> tournaments)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00d0: Expected O, but got I
		//IL_00e0: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_0045: Expected O, but got I
		//IL_0055: Expected O, but got I
		//IL_0065: Expected O, but got I
		//IL_0087: Expected O, but got I4
		//IL_027e: Expected O, but got I
		//IL_028e: Expected O, but got I
		//IL_02b0: Expected O, but got I4
		//IL_02c0: Expected O, but got I
		//IL_013a: Expected O, but got I4
		//IL_0231: Expected O, but got I4
		//IL_01bd: Expected O, but got I
		//IL_01cd: Expected O, but got I
		//IL_01f4: Expected O, but got I
		//IL_0e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e30: Expected O, but got Unknown
		//IL_0e46: Expected O, but got I
		//IL_0e57: Expected I, but got O
		//IL_0e75: Expected O, but got I
		//IL_0e90: Expected O, but got I4
		//IL_02f0: Expected O, but got I4
		//IL_016a: Expected O, but got I
		//IL_0eb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb9: Expected O, but got Unknown
		//IL_0ecf: Expected O, but got I
		//IL_0ee0: Expected I, but got O
		//IL_0efe: Expected O, but got I
		//IL_06ec: Expected O, but got I
		//IL_06fc: Expected O, but got I
		//IL_071e: Expected O, but got I4
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_0356: Expected O, but got I4
		//IL_0367: Expected O, but got I4
		//IL_0320: Expected O, but got I
		//IL_078f: Expected O, but got I
		//IL_0594: Expected O, but got I
		//IL_05a4: Expected O, but got I
		//IL_05c6: Expected O, but got I4
		//IL_0b3e: Expected O, but got I
		//IL_0b4e: Expected O, but got I
		//IL_0b5e: Expected O, but got I
		//IL_0b80: Expected O, but got I4
		//IL_0b98: Expected O, but got I
		//IL_0844: Expected O, but got I
		//IL_0854: Expected O, but got I
		//IL_0876: Expected O, but got I4
		//IL_074e: Expected O, but got I4
		//IL_09a1: Expected O, but got I
		//IL_09b1: Expected O, but got I
		//IL_09c1: Expected O, but got I
		//IL_09e3: Expected O, but got I4
		//IL_08e7: Expected O, but got I
		//IL_07dd: Expected O, but got I
		//IL_07ed: Expected O, but got I
		//IL_080f: Expected O, but got I4
		//IL_0f69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6e: Expected O, but got Unknown
		//IL_0f84: Expected O, but got I
		//IL_0f95: Expected I, but got O
		//IL_0fb3: Expected O, but got I
		//IL_0fce: Expected O, but got I4
		//IL_0cdd: Expected O, but got I
		//IL_0ced: Expected O, but got I
		//IL_0d0f: Expected O, but got I4
		//IL_0d2f: Expected O, but got I
		//IL_0bc8: Expected O, but got I4
		//IL_08a6: Expected O, but got I4
		//IL_077e: Expected O, but got I
		//IL_0c23: Expected O, but got I
		//IL_0c33: Expected O, but got I
		//IL_0c6a: Expected O, but got I
		//IL_1119: Unknown result type (might be due to invalid IL or missing references)
		//IL_111e: Expected O, but got Unknown
		//IL_1134: Expected O, but got I
		//IL_1145: Expected I, but got O
		//IL_1163: Expected O, but got I
		//IL_0a19: Expected O, but got I
		//IL_091a: Expected O, but got I
		//IL_0fea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fef: Expected O, but got Unknown
		//IL_1005: Expected O, but got I
		//IL_1016: Expected I, but got O
		//IL_1034: Expected O, but got I
		//IL_104f: Expected O, but got I4
		//IL_041e: Expected O, but got I
		//IL_0d60: Expected O, but got I4
		//IL_0bf8: Expected O, but got I
		//IL_08d6: Expected O, but got I
		//IL_1189: Unknown result type (might be due to invalid IL or missing references)
		//IL_118e: Expected O, but got Unknown
		//IL_11a4: Expected O, but got I
		//IL_11b5: Expected I, but got O
		//IL_11d3: Expected O, but got I
		//IL_0495: Expected O, but got I4
		//IL_0dc0: Expected O, but got I4
		//IL_0d90: Expected O, but got I
		//IL_05e9: Expected O, but got I
		//IL_05f9: Expected O, but got I
		//IL_0609: Expected O, but got I
		//IL_0640: Expected O, but got I4
		//IL_0658: Expected O, but got I
		//IL_0f25: Expected O, but got I
		//IL_0f35: Expected O, but got I
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_0524: Expected O, but got I4
		//IL_0a40: Expected O, but got I4
		//IL_10a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ae: Expected O, but got Unknown
		//IL_10c4: Expected O, but got I
		//IL_10d5: Expected I, but got O
		//IL_10f3: Expected O, but got I
		//IL_06b7: Expected O, but got I4
		//IL_0a8d: Expected O, but got I4
		//IL_0a70: Expected O, but got I
		//IL_0aaf: Expected O, but got I
		//IL_0af2: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 4008;
		object obj2 = (nint)0 + (nint)1416;
		object obj3 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v117+E4]");
		object obj5;
		object obj6;
		Func<object, bool> predicate;
		object obj8;
		if ((nint)0 != 0)
		{
			obj5 = (nint)0 + (nint)2848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v117+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v112+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v112+10]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				obj8 = obj5;
				goto IL_0118;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
			obj8 = (nint)0 + (nint)2848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v117+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v112+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v112+10]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj5 = obj8;
			if (obj9 == null)
			{
				goto IL_0118;
			}
		}
		goto IL_016f;
		IL_0783:
		object obj10 = (nint)0 + (nint)3808;
		Func<object, bool> predicate2;
		IEnumerable<object> enumerable = Enumerable.Where(tournaments, predicate2);
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X0_v58+E4]");
		object obj12;
		Func<object, object> func;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X0_v58+B8]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v51+30]");
			func = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v51+30]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				goto IL_0884;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X0_v58+B8]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v51+30]");
			func = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v51+30]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				goto IL_0884;
			}
		}
		goto IL_08db;
		IL_0b20:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj15 = obj3;
		object obj16 = (nint)0 + (nint)2968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v33+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v25+38]");
		Func<object, object> func2 = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v25+38]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		object obj19 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v25+38]");
		Func<object, object> keySelector = (Func<object, object>)0;
		if (obj18 == null)
		{
			goto IL_0ba6;
		}
		goto IL_105c;
		IL_0ba6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v33+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj21 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v31+B8]");
			obj17 = 0;
		}
		object obj22 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)3864;
		Func<object, object> func3 = default(Func<object, object>);
		func3..ctor(obj17, (IntPtr)obj23);
		object obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v30+B8]");
		object obj25 = (nint)0 + (nint)56;
		obj25 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj19 = obj16;
		keySelector = func3;
		goto IL_105c;
		IL_0118:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v117+E4]");
		bool flag7 = (nint)0 == 0;
		object obj26 = !flag7;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj27 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v118+B8]");
			obj6 = 0;
		}
		object obj28 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = (nint)0 + (nint)3840;
		Func<object, bool> func4 = default(Func<object, bool>);
		func4..ctor(obj6, (IntPtr)obj29);
		object obj30 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v117+B8]");
		object obj31 = (nint)0 + (nint)16;
		obj31 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj32 = 0;
		obj5 = obj8;
		predicate = func4;
		goto IL_016f;
		IL_0884:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X0_v58+E4]");
		bool flag8 = (nint)0 == 0;
		object obj33 = !flag8;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj34 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v57+B8]");
			obj12 = 0;
		}
		object obj35 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj36 = (nint)0 + (nint)3888;
		Func<object, object> func5 = default(Func<object, object>);
		func5..ctor(obj12, (IntPtr)obj36);
		object obj37 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v56+B8]");
		object obj38 = (nint)0 + (nint)48;
		obj38 = func5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj32 = 0;
		func = func5;
		goto IL_08db;
		IL_0c79:
		ILookup<object, object> source;
		Func<object, object> selector;
		IEnumerable<object> collection = Enumerable.Select(source, selector);
		if (list != null)
		{
			goto IL_0ca7;
		}
		goto IL_0dce;
		IL_016f:
		bool flag9 = Enumerable.Any(tournaments, predicate);
		object obj39 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v101+E4]");
		object obj40;
		Func<object, bool> func6;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v101+B8]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v99+18]");
			func6 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v99+18]");
			bool flag10 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v99+18]");
			Func<object, bool> func7 = (Func<object, bool>)0;
			if (!flag10)
			{
				goto IL_0202;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj39 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v101+B8]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v99+18]");
			func6 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v99+18]");
			bool flag11 = (nint)0 == 0;
			object obj41 = !flag11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v99+18]");
			Func<object, bool> func7 = (Func<object, bool>)0;
			if (obj41 != null)
			{
				goto IL_0202;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v101+E4]");
		bool flag12 = (nint)0 == 0;
		object obj42 = !flag12;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj43 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v105+B8]");
			obj40 = 0;
		}
		object obj44 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj45 = (nint)0 + (nint)3848;
		Func<object, bool> func8 = default(Func<object, bool>);
		func8..ctor(obj40, (IntPtr)obj45);
		object obj46 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v104+B8]");
		object obj47 = (nint)0 + (nint)24;
		obj47 = func8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj48 = obj5;
		bool flag13 = Enumerable.Any(tournaments, func8);
		bool flag14 = !flag9;
		obj32 = 0;
		func6 = func8;
		object obj49 = 0;
		object obj50 = obj5;
		object obj51 = func8;
		if (!flag14)
		{
			goto IL_0385;
		}
		goto IL_0948;
		IL_08db:
		object obj52 = (nint)0 + (nint)2880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C98D24");
		if (tournaments != null)
		{
			object obj53 = (nint)0 + (nint)1448;
			obj50 = obj53;
			object obj54 = default(object);
			bool flag15 = ((List<object>)(object)tournaments).Remove(obj54);
			obj49 = obj32;
			obj51 = obj54;
			goto IL_0948;
		}
		goto IL_0dce;
		IL_0ca7:
		list.AddRange(collection);
		return (List<TournamentListGroup>)(object)list;
		IL_0dce:
		return (List<TournamentListGroup>)(object)new NullReferenceException();
		IL_0676:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj55 = obj3;
		object obj56;
		obj48 = obj56;
		TournamentListGroup tournamentListGroup2;
		TournamentListGroup tournamentListGroup = tournamentListGroup2;
		goto IL_0f15;
		IL_105c:
		ILookup<object, object> lookup = Enumerable.ToLookup(tournaments, keySelector);
		object obj57 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v13+E4]");
		object obj58;
		ILookup<object, object> source2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v13+B8]");
			obj58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v9+40]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v9+40]");
			bool flag16 = (nint)0 == 0;
			source = lookup;
			source2 = lookup;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v9+40]");
			Func<object, object> func9 = (Func<object, object>)0;
			if (!flag16)
			{
				goto IL_0c79;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj57 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v13+B8]");
			obj58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v9+40]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v9+40]");
			bool flag17 = (nint)0 == 0;
			object obj59 = !flag17;
			source = lookup;
			source2 = lookup;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v9+40]");
			Func<object, object> func9 = (Func<object, object>)0;
			if (obj59 != null)
			{
				goto IL_0c79;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v13+E4]");
		bool flag18 = (nint)0 == 0;
		object obj60 = !flag18;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj61 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v15+B8]");
			obj58 = 0;
		}
		object obj62 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj63 = (nint)0 + (nint)3872;
		Func<object, object> func10 = default(Func<object, object>);
		func10..ctor(obj58, (IntPtr)obj63);
		object obj64 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v14+B8]");
		object obj65 = (nint)0 + (nint)64;
		obj65 = func10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		collection = Enumerable.Select(source2, func10);
		bool flag19 = list == null;
		object obj66 = !flag19;
		if (obj66 != null)
		{
			goto IL_0ca7;
		}
		goto IL_0dce;
		IL_0202:
		obj48 = obj5;
		flag13 = Enumerable.Any(tournaments, func6);
		bool flag20 = !flag9;
		object obj67 = !flag20;
		if (obj67 != null)
		{
			goto IL_0385;
		}
		obj49 = obj32;
		obj50 = obj5;
		obj51 = func6;
		goto IL_0948;
		IL_0385:
		if (flag13)
		{
			object obj68 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TournamentListGroup tournamentListGroup3 = default(TournamentListGroup);
			tournamentListGroup3..ctor();
			if (tournamentListGroup3 != null)
			{
				tournamentListGroup3.<IsMonthlyAnnouncementGroup>k__BackingField = true;
				if (list != null)
				{
					object obj69 = (nint)0 + (nint)1424;
					object obj70 = obj69;
					int version = list._version + 1;
					list._version = version;
					object[] items = list._items;
					if (list._items != null)
					{
						bool flag21 = list._size < items.Length;
						object obj71 = !flag21;
						if (obj71 == null)
						{
							int size = list._size + 1;
							list._size = size;
							object obj72 = list._items + list._size;
							object obj73 = obj72 + 32;
							obj73 = tournamentListGroup3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj55 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v80+E4]");
							bool flag22 = (nint)0 == 0;
							object obj74 = !flag22;
							tournamentListGroup = tournamentListGroup3;
							if (obj74 == null)
							{
								obj56 = obj48;
								tournamentListGroup2 = tournamentListGroup3;
								object obj75 = obj55;
								goto IL_0676;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v77+20]");
							object obj76 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v93+C0]");
							object obj77 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v94+70]");
							obj56 = 0;
							list.AddWithResize((object)tournamentListGroup3);
							object obj75 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v92+E4]");
							bool flag23 = (nint)0 == 0;
							object obj78 = !flag23;
							tournamentListGroup2 = tournamentListGroup3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v94+70]");
							obj48 = 0;
							tournamentListGroup = tournamentListGroup3;
							obj55 = obj75;
							if (obj78 == null)
							{
								goto IL_0676;
							}
						}
						goto IL_0f15;
					}
				}
			}
			goto IL_0dce;
		}
		object obj79 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v68+E4]");
		object obj80;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v68+B8]");
			obj80 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v62+28]");
			predicate2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v62+28]");
			bool flag24 = (nint)0 == 0;
			object obj81 = !flag24;
			if (obj81 == null)
			{
				goto IL_072c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj79 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v68+B8]");
			obj80 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v62+28]");
			predicate2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v62+28]");
			bool flag25 = (nint)0 == 0;
			object obj82 = !flag25;
			if (obj82 == null)
			{
				goto IL_072c;
			}
		}
		goto IL_0783;
		IL_0aa3:
		object obj83 = (nint)0 + (nint)1456;
		obj50 = obj83;
		Predicate<object> predicate3;
		int num = ((List<object>)(object)tournaments).RemoveAll(predicate3);
		obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v33+E4]");
		bool flag26 = (nint)0 == 0;
		object obj84 = !flag26;
		obj49 = obj32;
		object obj85 = obj83;
		Predicate<object> predicate4 = predicate3;
		object obj86 = obj15;
		if (obj84 != null)
		{
			goto IL_0995;
		}
		goto IL_0b20;
		IL_0948:
		obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v33+E4]");
		bool flag27 = (nint)0 == 0;
		obj32 = obj49;
		obj85 = obj50;
		predicate4 = (Predicate<object>)obj51;
		obj86 = obj15;
		if (!flag27)
		{
			goto IL_0995;
		}
		goto IL_0b20;
		IL_0f15:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v80+B8]");
		object obj87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v84+20]");
		predicate3 = (Predicate<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v84+20]");
		if ((nint)0 != 0)
		{
			bool flag28 = tournaments == null;
			object obj88 = !flag28;
			if (obj88 != null)
			{
				goto IL_0aa3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v80+E4]");
			bool flag29 = (nint)0 == 0;
			object obj89 = !flag29;
			if (obj89 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj90 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v90+B8]");
				obj87 = 0;
			}
			object obj91 = typeof(List<Tween>) + 3568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj92 = (nint)0 + (nint)3856;
			Predicate<object> predicate5 = default(Predicate<object>);
			predicate5..ctor(obj87, (IntPtr)obj92);
			object obj93 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v89+B8]");
			object obj94 = (nint)0 + (nint)32;
			obj94 = predicate5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag30 = tournaments == null;
			obj32 = 0;
			predicate3 = predicate5;
			if (!flag30)
			{
				goto IL_0aa3;
			}
		}
		goto IL_0dce;
		IL_072c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v68+E4]");
		bool flag31 = (nint)0 == 0;
		object obj95 = !flag31;
		if (obj95 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj96 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v68+B8]");
			obj80 = 0;
		}
		object obj97 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj98 = (nint)0 + (nint)3880;
		Func<object, bool> func11 = default(Func<object, bool>);
		func11..ctor(obj80, (IntPtr)obj98);
		object obj99 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v67+B8]");
		object obj100 = (nint)0 + (nint)40;
		obj100 = func11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj32 = 0;
		predicate2 = func11;
		goto IL_0783;
		IL_0995:
		obj19 = (nint)0 + (nint)2968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v33+B8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v25+38]");
		keySelector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v25+38]");
		bool flag32 = (nint)0 == 0;
		object obj101 = !flag32;
		if (obj101 == null)
		{
			obj16 = obj19;
			obj32 = obj49;
			obj85 = obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v25+38]");
			func2 = (Func<object, object>)0;
			goto IL_0ba6;
		}
		goto IL_105c;
	}

	internal static int <ApplyFilter>g__IsParticipating|1_1(TournamentModel t)
	{
		//IL_021d: Expected I4, but got O
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0064: Expected I, but got O
		//IL_0074: Expected O, but got I
		//IL_0134: Expected O, but got I
		//IL_00af: Expected O, but got I
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_01ba: Expected O, but got I4
		//IL_01ca: Expected O, but got I
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		object obj2;
		int roomId;
		int num2 = default(int);
		object obj7;
		object obj9;
		if (t != null)
		{
			Room <Room>k__BackingField = t.<Room>k__BackingField;
			if (t.<Room>k__BackingField != null)
			{
				object obj = typeof(RegisteredWaitHandle) + 1376;
				obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
				nint num = (nint)<Room>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00f0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X10_v6-8]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v190 @ X0_v16] (should have been resolved before IL gen)");
				obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj8 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v16+8]");
				obj9 = 0;
				roomId = num2;
				if (obj8 != null)
				{
					goto IL_014a;
				}
				goto IL_01e0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_00f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ X0_v13] (should have been resolved before IL gen)");
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v6+E4]");
		bool flag2 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v13+8]");
		obj9 = 0;
		roomId = num2;
		if (!flag2)
		{
			goto IL_014a;
		}
		goto IL_01e0;
		IL_014a:
		bool flag3 = SfsTournamentConnector.IsParticipating(num2);
		return (flag3 ? 1 : 0) ^ 1;
		IL_01e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag4 = SfsTournamentConnector.IsParticipating(roomId);
		return (flag4 ? 1 : 0) ^ 1;
	}

	internal static int <ApplyFilter>g__IsAvailableForRegistration|1_2(TournamentModel t)
	{
		//IL_0109: Expected I4, but got O
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		if (t != null)
		{
			TournamentData <Info>k__BackingField = t.<Info>k__BackingField;
			if (t.<Info>k__BackingField != null)
			{
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				if (<Info>k__BackingField.<AvailabilityTime>k__BackingField <= now)
				{
					TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(t.<Room>k__BackingField);
					return TournamentStatusExtensions.IsStarted(tournamentStatus) ? 1 : 0;
				}
				return 1;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	internal static int <ApplyFilter>g__IsUpcoming|1_3(TournamentModel t)
	{
		//IL_00d4: Expected I4, but got O
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		if (t != null)
		{
			TournamentData <Info>k__BackingField = t.<Info>k__BackingField;
			if (t.<Info>k__BackingField != null)
			{
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				bool flag2 = <Info>k__BackingField.<AvailabilityTime>k__BackingField > now;
				return (flag2 ? 1 : 0) ^ 1;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}
}
