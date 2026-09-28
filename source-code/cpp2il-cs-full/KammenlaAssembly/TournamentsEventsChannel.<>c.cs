using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Sfs2X.Entities;
using Spine;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class TournamentsEventsChannel : ScriptableObject
{
	public delegate void TournamentSeatChanged(int roomId, int seat);

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Room, TournamentModel> <>9__0_0;

		public static Func<TournamentModel, bool> <>9__2_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 4016;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal TournamentModel <GetTournaments>b__0_0(Room room)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1576;
			TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(room);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TournamentModel tournamentModel = default(TournamentModel);
			tournamentModel..ctor(room, tournamentInfo);
			return tournamentModel;
		}

		internal bool <GetTournamentsCount>b__2_0(TournamentModel model)
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
	}

	private sealed class <>c__DisplayClass1_0
	{
		public TournamentType type;

		internal bool <GetTournaments>b__0(TournamentModel model)
		{
			//IL_0082: Expected I4, but got O
			//IL_0060: Expected O, but got I4
			if (model != null)
			{
				TournamentData <Info>k__BackingField = model.<Info>k__BackingField;
				if (model.<Info>k__BackingField != null)
				{
					object obj = <Info>k__BackingField.<Type>k__BackingField - type;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private TournamentSeatChanged m_OnTournamentSeatChanged;

	private Action m_OnTournamentsChanged;

	private Action<TournamentType> m_OnLastSeenUpdated;

	public event TournamentSeatChanged OnTournamentSeatChanged
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 4032;
			object obj2 = this + 24;
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
			object obj = typeof(SkeletonBinary.SkeletonInput) + 4032;
			object obj2 = this + 24;
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

	public event Action OnTournamentsChanged
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 32;
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
			object obj2 = this + 32;
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

	public event Action<TournamentType> OnLastSeenUpdated
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3840;
			object obj2 = this + 40;
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
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3840;
			object obj2 = this + 40;
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

	public IEnumerable<TournamentModel> GetTournaments()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0148: Expected O, but got I4
		//IL_00aa: Expected O, but got I
		//IL_00ba: Expected O, but got I
		//IL_00ca: Expected O, but got I
		//IL_00ec: Expected O, but got I4
		//IL_018c: Expected O, but got I
		//IL_019c: Expected O, but got I
		//IL_01ac: Expected O, but got I
		//IL_01ce: Expected O, but got I4
		//IL_020e: Expected O, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0283: Expected O, but got I
		//IL_0294: Expected I, but got O
		//IL_02b2: Expected O, but got I
		//IL_023e: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 4016;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74B0]");
		object obj3 = (nint)0 & (nint)1;
		IEnumerable<Room> enumerable;
		IEnumerable<Room> enumerable2;
		object obj4;
		if (obj3 != null)
		{
			IEnumerable<Room> tournamentRooms = SFS.TournamentRooms;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			enumerable = tournamentRooms;
			object obj5 = obj4;
			enumerable2 = tournamentRooms;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			IEnumerable<Room> tournamentRooms2 = SFS.TournamentRooms;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			enumerable = tournamentRooms2;
			object obj5 = obj4;
			enumerable2 = tournamentRooms2;
			if (obj6 != null)
			{
				goto IL_009e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)3992;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v4+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v4+8]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		enumerable = enumerable2;
		if (obj9 == null)
		{
			goto IL_01ec;
		}
		goto IL_0243;
		IL_01ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v10+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)568;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v9+B8]");
		object obj16 = (nint)0 + (nint)8;
		obj16 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector = func;
		obj10 = obj7;
		enumerable = enumerable2;
		goto IL_0243;
		IL_0243:
		return (IEnumerable<TournamentModel>)Enumerable.Select(enumerable, selector);
		IL_009e:
		obj10 = (nint)0 + (nint)3992;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v4+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v4+8]");
		selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			obj7 = obj10;
			enumerable2 = enumerable;
			goto IL_01ec;
		}
		goto IL_0243;
	}

	public IEnumerable<TournamentModel> GetTournaments(TournamentType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_006c: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3920;
			object obj4 = (nint)0 + (nint)584;
			IEnumerable<TournamentModel> tournaments = ((TournamentsEventsChannel)obj2).GetTournaments();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return (IEnumerable<TournamentModel>)Enumerable.Where(tournaments, func);
		}
		return (IEnumerable<TournamentModel>)new NullReferenceException();
	}

	public int GetTournamentsCount(TournamentType type)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_017e: Expected O, but got I4
		//IL_00b7: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00d7: Expected O, but got I
		//IL_00f9: Expected O, but got I4
		//IL_01ca: Expected O, but got I
		//IL_01da: Expected O, but got I
		//IL_01ea: Expected O, but got I
		//IL_020c: Expected O, but got I4
		//IL_024c: Expected O, but got I4
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_02c1: Expected O, but got I
		//IL_02d2: Expected I, but got O
		//IL_02f0: Expected O, but got I
		//IL_027c: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 4016;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74B2]");
		object obj3 = (nint)0 & (nint)1;
		TournamentType tournamentType = default(TournamentType);
		IEnumerable<TournamentModel> enumerable;
		IEnumerable<TournamentModel> enumerable2;
		object obj4;
		if (obj3 != null)
		{
			IEnumerable<TournamentModel> tournaments = GetTournaments(tournamentType);
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			enumerable = tournaments;
			TournamentType tournamentType2 = tournamentType;
			object obj5 = obj4;
			enumerable2 = tournaments;
			if (!flag)
			{
				goto IL_00ab;
			}
		}
		else
		{
			object obj6 = typeof(SkeletonBinary.SkeletonInput) + 4016;
			_ = 1;
			IEnumerable<TournamentModel> tournaments2 = ((TournamentsEventsChannel)obj6).GetTournaments(tournamentType);
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			enumerable = tournaments2;
			TournamentType tournamentType2 = tournamentType;
			object obj5 = obj4;
			enumerable2 = tournaments2;
			if (obj7 != null)
			{
				goto IL_00ab;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj8 = (nint)0 + (nint)3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v4+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+10]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+10]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj11 = obj8;
		enumerable = enumerable2;
		if (obj10 == null)
		{
			goto IL_022a;
		}
		goto IL_0281;
		IL_022a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v10+B8]");
			obj9 = 0;
		}
		object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)576;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj9, (IntPtr)obj15);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v9+B8]");
		object obj17 = (nint)0 + (nint)16;
		obj17 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate = func;
		obj11 = obj8;
		enumerable = enumerable2;
		goto IL_0281;
		IL_0281:
		return Enumerable.Count(enumerable, predicate);
		IL_00ab:
		obj11 = (nint)0 + (nint)3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v4+B8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+10]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+10]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			TournamentType tournamentType2 = tournamentType;
			obj8 = obj11;
			enumerable2 = enumerable;
			goto IL_022a;
		}
		goto IL_0281;
	}

	public void TriggerTournamentSeatChanged(int roomId, int seat)
	{
		TournamentSeatChanged onTournamentSeatChanged = this.OnTournamentSeatChanged;
		if (this.OnTournamentSeatChanged != null)
		{
			IntPtr invoke_impl = ((Delegate)onTournamentSeatChanged).invoke_impl;
			IntPtr method_code = ((Delegate)onTournamentSeatChanged).method_code;
			IntPtr method = ((Delegate)onTournamentSeatChanged).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X4_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void TriggerTournamentsChanged()
	{
		Actions.SafeInvoke(this.OnTournamentsChanged);
	}

	public void TriggerLastSeanUpdated(TournamentType type)
	{
		Actions.SafeInvoke((Action<System.Int32Enum>)(object)this.OnLastSeenUpdated, (System.Int32Enum)type);
	}
}
