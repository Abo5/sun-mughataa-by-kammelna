using System;
using System.Data;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class TournamentTime : MonoBehaviour
{
	private DateTimeText dateTimeText;

	private bool ignoreAvailability;

	private Room _tournamentRoom;

	private TournamentData _tournamentData;

	public void Initialize(TournamentData tournament, Room tournamentRoom)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_005b: Expected I, but got O
		//IL_009c: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1536;
		object varName = "https://www.kammelna.com/Home/Terms" + 136;
		object varName2 = "startPosition" + 104;
		object obj3 = this + 48;
		obj3 = tournamentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 56;
		obj4 = tournament;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		VariableBinderExtensions.Bind(go, (Room)obj3, (string)varName, action);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj2);
		VariableBinderExtensions.Bind(go2, (Room)obj3, (string)varName2, action2);
		SetupUi();
	}

	private void SetupUi()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_010c: Expected O, but got I4
		//IL_01cf: Expected O, but got I4
		//IL_03ba: Expected O, but got I4
		//IL_029e: Expected O, but got I4
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_031d: Expected O, but got I4
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		CancelInvoke();
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(_tournamentRoom);
		TournamentData tournamentData = _tournamentData;
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		if (!(tournamentData.<AvailabilityTime>k__BackingField > now) || ignoreAvailability)
		{
			DateTime dateTime = default(DateTime);
			DateTimeText dateTimeText;
			object fallbackText;
			if (TournamentStatusExtensions.IsFinished(tournamentStatus))
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v39+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now2 = DateTime.Now;
				DateTime date = dateTime.AddDays(-1.0);
				this.dateTimeText.SetDate(date);
				dateTimeText = this.dateTimeText;
				fallbackText = "ThisIsFakeReceiptData" + 1272;
			}
			else if (TournamentStatusExtensions.IsFinalCountdown(tournamentStatus))
			{
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v30+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now3 = DateTime.Now;
				DateTime date2 = dateTime.AddDays(-1.0);
				this.dateTimeText.SetDate(date2);
				dateTimeText = this.dateTimeText;
				fallbackText = "SetRoomVariables request error" + 2856;
			}
			else
			{
				if (!TournamentStatusExtensions.IsStarted(tournamentStatus))
				{
					TournamentData tournamentData2 = _tournamentData;
					this.dateTimeText.SetDate(tournamentData2.<StartingTime>k__BackingField);
					return;
				}
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v21+E4]");
				bool flag4 = (nint)0 == 0;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now4 = DateTime.Now;
				DateTime date3 = dateTime.AddDays(-1.0);
				this.dateTimeText.SetDate(date3);
				dateTimeText = this.dateTimeText;
				fallbackText = "Added Tournament Prizes And Features" + 552;
			}
			dateTimeText.SetFallbackText((string)fallbackText);
		}
		else
		{
			TournamentData tournamentData3 = _tournamentData;
			this.dateTimeText.SetDate(tournamentData3.<AvailabilityTime>k__BackingField);
			TournamentData tournamentData4 = _tournamentData;
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v49+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now5 = DateTime.Now;
			TimeSpan timeSpan = tournamentData4.<AvailabilityTime>k__BackingField - now5;
			object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v55+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan2 = default(TimeSpan);
			double totalSeconds = timeSpan2.TotalSeconds;
			object methodName = "SetRoomVariables request error" + 280;
			Invoke((string)methodName, (float)totalSeconds);
		}
	}

	private void OnStatusChanged()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(_tournamentRoom);
		object obj = this + 56;
		obj = tournamentInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetupUi();
	}
}
