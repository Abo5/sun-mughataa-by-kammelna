using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Mono.Btls;
using Server.Models;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class OfficialTournamentsUi : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<TournamentModel, DateTime> <>9__13_0;

		public static Func<TournamentModel, bool> <>9__13_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal DateTime <get_StickyTournament>b__13_0(TournamentModel model)
		{
			if (model != null)
			{
				TournamentData <Info>k__BackingField = model.<Info>k__BackingField;
				if (model.<Info>k__BackingField != null)
				{
					return <Info>k__BackingField.<StartingTime>k__BackingField;
				}
			}
			return (DateTime)new NullReferenceException();
		}

		internal bool <get_StickyTournament>b__13_1(TournamentModel model)
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

	private TournamentsEventsChannel eventsChannel;

	private TournamentStrip stickyStrip;

	private GameObject officialStoppingContainer;

	private DateTimeText dateUntilOfficialStops;

	private GameObject monthlyStartingContainer;

	private DateTimeText dateUntilMonthlyStart;

	private DateTime? OfficialTournamentEndTime
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D16]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v6+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_011d;
			}
			goto IL_0164;
			IL_0164:
			return (DateTime?)new NullReferenceException();
			IL_011d:
			TournamentsSection <Tournaments>k__BackingField = current.<Tournaments>k__BackingField;
			if (current.<Tournaments>k__BackingField != null)
			{
				return <Tournaments>k__BackingField.<OfficialEndTime>k__BackingField;
			}
			goto IL_0164;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag2 = current == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_011d;
			}
			goto IL_0164;
		}
	}

	private IEnumerable<TournamentModel> normalTournaments
	{
		get
		{
			if ((object)eventsChannel != null)
			{
				return eventsChannel.GetTournaments(TournamentType.Official);
			}
			return (IEnumerable<TournamentModel>)new NullReferenceException();
		}
	}

	private IEnumerable<TournamentModel> monthlyTournaments
	{
		get
		{
			if ((object)eventsChannel != null)
			{
				return eventsChannel.GetTournaments(TournamentType.OfficialMonthly);
			}
			return (IEnumerable<TournamentModel>)new NullReferenceException();
		}
	}

	private TournamentModel StickyTournament
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00e1: Expected O, but got I
			//IL_00f1: Expected O, but got I
			//IL_0101: Expected O, but got I
			//IL_0123: Expected O, but got I4
			//IL_0066: Expected O, but got I
			//IL_0076: Expected O, but got I
			//IL_0086: Expected O, but got I
			//IL_00a8: Expected O, but got I4
			//IL_0255: Expected O, but got I
			//IL_0265: Expected O, but got I
			//IL_0275: Expected O, but got I
			//IL_0297: Expected O, but got I4
			//IL_015b: Expected O, but got I4
			//IL_01da: Expected O, but got I
			//IL_01ea: Expected O, but got I
			//IL_01fa: Expected O, but got I
			//IL_021c: Expected O, but got I4
			//IL_0356: Unknown result type (might be due to invalid IL or missing references)
			//IL_035b: Expected O, but got Unknown
			//IL_0371: Expected O, but got I
			//IL_0382: Expected I, but got O
			//IL_03a0: Expected O, but got I
			//IL_02cf: Expected O, but got I4
			//IL_018b: Expected O, but got I
			//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03db: Expected O, but got Unknown
			//IL_03f1: Expected O, but got I
			//IL_0402: Expected I, but got O
			//IL_0420: Expected O, but got I
			//IL_02ff: Expected O, but got I
			object obj;
			IEnumerable<TournamentModel> tournaments;
			object obj4;
			Func<object, DateTime> keySelector;
			object obj6;
			object obj3;
			if ((object)eventsChannel != null)
			{
				obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1480;
				tournaments = eventsChannel.GetTournaments(TournamentType.OfficialMonthly);
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v23+E4]");
				if ((nint)0 != 0)
				{
					obj3 = (nint)0 + (nint)2280;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v23+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v19+8]");
					keySelector = (Func<object, DateTime>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v19+8]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						obj6 = obj3;
						goto IL_0139;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					obj6 = (nint)0 + (nint)2280;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v23+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v19+8]");
					keySelector = (Func<object, DateTime>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v19+8]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					obj3 = obj6;
					if (obj7 == null)
					{
						goto IL_0139;
					}
				}
				goto IL_0190;
			}
			return (TournamentModel)(object)new NullReferenceException();
			IL_0139:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v23+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v25+B8]");
				obj4 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3928;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)3912;
			Func<object, DateTime> func = default(Func<object, DateTime>);
			func..ctor(obj4, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v24+B8]");
			object obj13 = (nint)0 + (nint)8;
			obj13 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj3 = obj6;
			keySelector = func;
			goto IL_0190;
			IL_0190:
			IOrderedEnumerable<object> source = Enumerable.OrderBy(tournaments, keySelector);
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v13+E4]");
			object obj16;
			Func<object, bool> predicate;
			object obj18;
			object obj15;
			if ((nint)0 != 0)
			{
				obj15 = (nint)0 + (nint)1336;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v13+B8]");
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v8+10]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v8+10]");
				bool flag4 = (nint)0 == 0;
				object obj17 = !flag4;
				if (obj17 == null)
				{
					obj18 = obj15;
					goto IL_02ad;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj;
				obj18 = (nint)0 + (nint)1336;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v13+B8]");
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v8+10]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v8+10]");
				bool flag5 = (nint)0 == 0;
				object obj19 = !flag5;
				obj15 = obj18;
				if (obj19 == null)
				{
					goto IL_02ad;
				}
			}
			goto IL_0304;
			IL_02ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj21 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v14+B8]");
				obj16 = 0;
			}
			object obj22 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3920;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj23 = (nint)0 + (nint)3920;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj16, (IntPtr)obj23);
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v13+B8]");
			object obj25 = (nint)0 + (nint)16;
			obj25 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj15 = obj18;
			predicate = func2;
			goto IL_0304;
			IL_0304:
			return (TournamentModel)Enumerable.FirstOrDefault(source, predicate);
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0058: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		eventsChannel.OnTournamentsChanged += action;
		RefreshList();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		eventsChannel.OnTournamentsChanged -= action;
	}

	private void RefreshList()
	{
		IEnumerable<TournamentModel> tournaments = eventsChannel.GetTournaments(TournamentType.OfficialMonthly);
		if (Enumerable.Any((IEnumerable<object>)tournaments))
		{
			IEnumerable<TournamentModel> tournaments2 = eventsChannel.GetTournaments(TournamentType.Official);
			if (Enumerable.Any((IEnumerable<object>)tournaments2))
			{
				SetDateUntilStop();
				return;
			}
			TournamentModel stickyTournament = StickyTournament;
			ShowStickyStrip(stickyTournament);
		}
		else
		{
			SetDateUntilChampionshipStart();
		}
	}

	private void ShowStickyStrip(TournamentModel stickyTournament)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00ca: Expected I4, but got I8
		//IL_00d7: Expected I, but got O
		//IL_00e7: Expected O, but got I
		//IL_00f7: Expected O, but got I
		GameObject gameObject = stickyStrip.gameObject;
		bool flag = stickyTournament == null;
		bool active = !flag;
		gameObject.SetActive(active);
		if (stickyTournament != null)
		{
			monthlyStartingContainer.SetActive(value: false);
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1512;
			officialStoppingContainer.SetActive(value: false);
			TournamentStrip tournamentStrip = stickyStrip;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TournamentDataHolder tournamentDataHolder = default(TournamentDataHolder);
			tournamentDataHolder..ctor(stickyTournament.<Room>k__BackingField, -1);
			nint num = (nint)tournamentStrip;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v3 (Il2CppClass<TournamentStrip>)+308]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v3 (Il2CppClass<TournamentStrip>)+310]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X4_v1 (should have been resolved before IL gen)");
		}
	}

	private void SetDateUntilChampionshipStart()
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		DateTime? officialTournamentEndTime = OfficialTournamentEndTime;
		object obj = (??)officialTournamentEndTime & 1;
		if (obj != null)
		{
			GameObject gameObject = stickyStrip.gameObject;
			gameObject.SetActive(value: false);
			officialStoppingContainer.SetActive(value: false);
			object obj2 = typeof(DataRelation) + 712;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			DateTime? officialTournamentEndTime2 = ((OfficialTournamentsUi)now).OfficialTournamentEndTime;
			DateTime? dateTime = default(DateTime?);
			DateTime value = dateTime.Value;
			bool active = now < value;
			monthlyStartingContainer.SetActive(active);
			DateTime? officialTournamentEndTime3 = ((OfficialTournamentsUi)(object)monthlyStartingContainer).OfficialTournamentEndTime;
			DateTime value2 = dateTime.Value;
			dateUntilMonthlyStart.SetDate(value2);
		}
	}

	private void SetDateUntilStop()
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		DateTime? officialTournamentEndTime = OfficialTournamentEndTime;
		object obj = (??)officialTournamentEndTime & 1;
		if (obj != null)
		{
			GameObject gameObject = stickyStrip.gameObject;
			gameObject.SetActive(value: false);
			monthlyStartingContainer.SetActive(value: false);
			object obj2 = typeof(DataRelation) + 712;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			DateTime? officialTournamentEndTime2 = ((OfficialTournamentsUi)now).OfficialTournamentEndTime;
			DateTime? dateTime = default(DateTime?);
			DateTime value = dateTime.Value;
			bool active = now < value;
			officialStoppingContainer.SetActive(active);
			DateTime? officialTournamentEndTime3 = ((OfficialTournamentsUi)(object)officialStoppingContainer).OfficialTournamentEndTime;
			DateTime value2 = dateTime.Value;
			dateUntilOfficialStops.SetDate(value2);
		}
	}
}
